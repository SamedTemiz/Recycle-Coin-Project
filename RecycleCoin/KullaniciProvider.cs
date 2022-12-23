using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RecycleCoin
{
    public class KullaniciProvider : Kullanicilar
    {
        //Kullanici işlemleri
        public List<Kullanicilar> KullaniciListele()
        {
            List<Kullanicilar> kullanici = new List<Kullanicilar>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanicilar", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Kullanicilar kul = new Kullanicilar();

                kul.ID = dr[0].ToString();
                kul.ad = dr[1].ToString();
                kul.soyad = dr[2].ToString();
                kul.yas = int.Parse(dr[3].ToString());
                kul.KullaniciAd = dr[4].ToString();
                kul.sifre = dr[5].ToString();
                kul.mail = dr[6].ToString();
                kul.telefonNo = dr[7].ToString();
                kul.KullaniciTip = dr[8].ToString();
                kullanici.Add(kul);
            }
            dr.Close();
            conn.Close();
            return kullanici;
        }
        
        public int GirisKontrol(string kulad, string sifre)
        {
            cmd = new SqlCommand("SELECT KullaniciAd, Sifre, KullaniciTip FROM Kullanicilar WHERE KullaniciAd='" + kulad + "' AND Sifre= '" + sifre + "' ", conn);
            conn.Open();
            SqlDataReader oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                return (int)oku[2];
            }
            conn.Close();
            return 0;
        }
        public bool KullaniciEkle(Kullanicilar kul)
        {
            bool result = false;
            if (!kontrolKullanici(kul.KullaniciAd))
            {
                conn.Open();
                cmd = new SqlCommand("INSERT INTO Kullanicilar(KullaniciID, Ad, Soyad, Yas, KullaniciAd, Sifre, Mail, TelefonNumarasi) VALUES ('" + kul.ID + "','" + kul.ad + "', '" + kul.soyad + "', '" + kul.yas + "', '" + kul.KullaniciAd + "', '" + kul.sifre + "', '" + kul.mail + "', '" + kul.telefonNo + "')", conn);

                if (cmd.ExecuteNonQuery() != -1)
                {
                    if (CuzdanOlustur(kul.ID))
                    {
                        return true;
                    }
                }
            }
            conn.Close();
            return result;
        } 
        
        public bool SifreGuncelleme(Kullanicilar kul)
        {
            int durum = 1;
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Kullanicilar SET Sifre='" + kul.sifre + "' where KullaniciAd='" + kul.KullaniciAd + "'", conn);
            durum = cmd.ExecuteNonQuery();
            conn.Close();
            if (durum == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool KullaniciYetkiGuncelleme(string kulad, int tip)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Kullanicilar SET KullaniciTip='"+tip+"' WHERE KullaniciAd='"+kulad+"'", conn);
            if(cmd.ExecuteNonQuery() > -1)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }
        public bool KullaniciBilgiGuncelle(Kullanicilar kul, string kulid)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Kullanicilar SET Ad='"+kul.ad+"', Soyad='"+kul.soyad+"', Yas='"+kul.yas+"', KullaniciAd='"+kul.KullaniciAd+"', Mail='"+kul.mail+"', TelefonNumarasi='"+kul.telefonNo+"' WHERE KullaniciID='"+kulid  +"'", conn);
            if (cmd.ExecuteNonQuery() > -1)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }
        public bool KullaniciSil(string kulad)
        {
            bool result = false;
            conn.Open();
            cmd = new SqlCommand("DELETE FROM Kullanicilar WHERE KullaniciAd='" + kulad + "'", conn);

            if (cmd.ExecuteNonQuery() != -1)
            {
                result = true;
            }
            conn.Close();
            return result;
        }
        public bool kontrolKullanici(string kulad)
        {
            conn.Open();
            bool result = false;
            cmd = new SqlCommand("SELECT * FROM Kullanicilar WHERE KullaniciAd = '" + kulad + "'", conn);
            var oku = cmd.ExecuteReader();

            if (oku.Read())
            {
                result = true;
            }
            else
            {
                result = false;
            }
            conn.Close();
            return result;
        }
        public bool kontrolMail(string mail)
        {
            conn.Open();
            bool durum = false;
            cmd = new SqlCommand("SELECT * FROM Kullanicilar WHERE Mail='" +mail+ "'", conn);
            
            if (cmd.ExecuteNonQuery() > -1)
            {
                durum = true; 
            }
            else
            {
                durum = false;
            }
            conn.Close();
            return durum;

        }

        //Şifreleme
        public string IdOlustur()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[5];//id
            var random = new Random();
            var pin = "";

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
                pin += stringChars[i];
            }
            return pin;
        }
        public string SHA256Hash(string text)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(text);
                byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                return hash.ToLower();
            }
        }

        //Cüzdan Bilgileri
        public List<Cuzdan> cuzdanBilgileri()
        {
            List<Cuzdan> para = new List<Cuzdan>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Cuzdan", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cuzdan cuz = new Cuzdan();
                cuz.cuzdan_ID = int.Parse(dr[0].ToString());
                cuz.kullanici_ID = dr[1].ToString();
                cuz.carbon_Miktari = int.Parse(dr[2].ToString());
                cuz.coin_Miktari = Convert.ToDouble(dr[3].ToString());
                para.Add(cuz);
            }
            conn.Close();
            return para;
        }
        public bool CuzdanOlustur(string id)
        {
            string hash = SHA256Hash(id);
            cmd = new SqlCommand("INSERT INTO Cuzdan(kullanici_ID) VALUES ('" + hash + "')", conn);
            if (cmd.ExecuteNonQuery() != -1)
                return true;
            return false;
        }
        public void Cuzdan(string kimlik, int karbon, double coin)
        {
            string sorgu = "Update Cuzdan Set Carbon-=@carbon, RecycleCoin+=@recycle Where kullanici_ID=@kullaniciID";
            SqlCommand komut = new SqlCommand(sorgu, conn);
            komut.Parameters.AddWithValue("@kullaniciID", kimlik);
            komut.Parameters.AddWithValue("@carbon", karbon);
            komut.Parameters.AddWithValue("@recycle", coin);
            
            
            conn.Open();
            komut.ExecuteNonQuery();
            conn.Close();
        }   
        public bool CuzdanTransfer(string kimlik, double coin)
        {
            conn.Open();
            cmd = new SqlCommand("UPDATE Cuzdan SET RecycleCoin-=@coin WHERE kullanici_ID = '" + kimlik + "'", conn);
            cmd.Parameters.AddWithValue("@coin", coin);
            if (cmd.ExecuteNonQuery() > -1)
            {
                conn.Close();
                return true;
            }  
            return false;
        }
        public bool CuzdanOnay(string kimlik, double coin)
        {
            conn.Open();
            cmd = new SqlCommand("UPDATE Cuzdan SET RecycleCoin+=@coin WHERE kullanici_ID = '" + kimlik + "'", conn);
            cmd.Parameters.AddWithValue("@coin", coin);
            if (cmd.ExecuteNonQuery() > -1)
            {
                conn.Close();
                return true;
            }
            return false;
        }
        public bool KarbonEkle(int karbon, string kulID)
        {
            bool result = false;
            conn.Open();
            cmd = new SqlCommand("Update Cuzdan Set Carbon=('" + karbon + "') where Kullanici_ID='" + kulID + "'", conn);
            if (cmd.ExecuteNonQuery() != -1)
            {
                result = true;
            }
            conn.Close();
            return result;
        }
        public void CuzdanTemizle()
        {
            foreach(var cuz in cuzdanBilgileri())
            {
                if(!KullaniciListele().Exists(x=> (SHA256Hash(x.ID) == cuz.kullanici_ID)))
                {
                    conn.Open();
                    cmd = new SqlCommand("DELETE FROM Cuzdan WHERE kullanici_ID='" + cuz.kullanici_ID + "'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}

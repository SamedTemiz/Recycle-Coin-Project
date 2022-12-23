using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RecycleCoin
{
    public class UrunProvider:Urunler
    {
        public UrunProvider()
        {
            Baglan();
        }
        public bool UrunEkle(Urunler urun)
        {
            int durum = 1;
            conn.Open();
            cmd = new SqlCommand("INSERT INTO Urunler(UrunAd, UrunTur, UrunKod, UrunKarbon, UrunQrUrl)" + "Values('" + urun.UrunAd + "','" + urun.UrunTur + "','" + urun.UrunKod + "','" + urun.UrunKarbon + "','" + urun.QrUrl + "')", conn);
            durum=cmd.ExecuteNonQuery();
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
        public bool urunKontrol(string kod)
        {
            conn.Open();
            int durum = 1;
            cmd = new SqlCommand("SELECT Count(UrunKod) FROM Urunler WHERE UrunKod = '" + kod + "'", conn);
            durum = Convert.ToInt32(cmd.ExecuteScalar());
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
        public List<Urunler> UrunleriListele()
        {
            List<Urunler> urunler = new List<Urunler>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Urunler", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Urunler urun = new Urunler();
                urun.UrunID = int.Parse(dr[0].ToString());
                urun.UrunAd = dr[1].ToString();
                urun.UrunTur = int.Parse(dr[2].ToString());
                urun.UrunKod = dr[3].ToString();
                urun.UrunKarbon = int.Parse(dr[4].ToString());
                urun.QrUrl = dr[5].ToString();
                urun.UrunDurum = Convert.ToBoolean(dr[6]);
                urunler.Add(urun);
            }
            dr.Close();
            conn.Close();
            return urunler;
        }
        public bool UrunleriGuncelle(int id, Urunler urun)
        {
            int durum = 1;
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Urunler set UrunAd='"+urun.UrunAd+"', UrunTur='"+urun.UrunTur+"',Urunkod='"+urun.UrunKod+"',UrunKarbon='"+urun.UrunKarbon+"',UrunQrUrl='"+urun.QrUrl+"' where UrunID='"+id+"'", conn);
            durum= cmd.ExecuteNonQuery();
            conn.Close(); 
            if (durum==1)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }
        public bool UrunSil(string urunkod)
        {
            conn.Open();
            cmd = new SqlCommand("DELETE FROM Urunler WHERE UrunKod='" +urunkod+ "'", conn);
            if (cmd.ExecuteNonQuery() != -1)
            {
                conn.Close();
                return  true;
            }
            else
            {
                conn.Close();
                return false;
            }

        }
        public bool UrunDurumGuncelle(string[] kodlar)
        {
            conn.Open();
            foreach (string kod in kodlar)
            {
                cmd = new SqlCommand("UPDATE Urunler SET UrunDurum=0 WHERE UrunKod = '" + kod + "'", conn);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
            return true;
        }
        public DataTable UrunDoldur(string kod)
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select UrunAd,UrunTur,UrunKod,UrunKarbon from Urunler where UrunKod='" + kod + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;
        }
    }
}

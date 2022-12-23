using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Text;

namespace RecycleCoin
{
    class DonusturmeProvider : Donusturme
    {
        public List<Donusturme> DonusturListele()
        {
            List<Donusturme> donustur = new List<Donusturme>();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM Donustur", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Donusturme tra = new Donusturme();
                tra.DonusturmeID = int.Parse(dr[0].ToString());
                tra.KullaniciKimlik = dr[1].ToString();
                tra.Karbon = int.Parse(dr[2].ToString());
                tra.Coin = Convert.ToDouble(dr[3].ToString());
                tra.istekTarihi = Convert.ToDateTime(dr[4].ToString());
                tra.onayTarihi = Convert.ToDateTime(dr[5].ToString());
                //tra.Onay = Convert.ToBoolean(dr[6].ToString());
                tra.Onay = Convert.ToChar(dr[6].ToString());
                donustur.Add(tra);
            }
            conn.Close();
            return donustur;
        }
        public bool DonusturIstek(string sha, int karbon, double coin)
        {
            bool result = false;
            conn.Open();
            cmd = new SqlCommand("INSERT INTO Donustur(KullaniciKimlik, Karbon, RecycleCoin) VALUES ('" + sha + "','" + karbon + "', @coin)", conn);
            cmd.Parameters.AddWithValue("@coin", coin);

            SqlCommand cuzdanUpd = new SqlCommand("UPDATE Cuzdan SET Carbon -= '" + karbon + "' WHERE kullanici_ID= '" + sha + "'", conn);

            if (cmd.ExecuteNonQuery() != -1)
            {
                cuzdanUpd.ExecuteNonQuery();
                result = true;
            }
            conn.Close();
            return result;
        }
        public bool DonusturOnay(string kimlik, DateTime onayTar)
        {
            conn.Open();
            cmd = new SqlCommand("UPDATE Donustur SET OnayTarihi=('" + onayTar.ToString() + "'), Onay=1 WHERE KullaniciKimlik = '"+kimlik+"'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }
    }
}

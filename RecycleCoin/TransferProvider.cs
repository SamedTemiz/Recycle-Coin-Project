using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Text;

namespace RecycleCoin
{
    class TransferProvider : Transfer
    {
        public List<Transfer> TransferListele()
        {
            List<Transfer> transfer = new List<Transfer>();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM Transfer", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Transfer tra = new Transfer();
                tra.TranferID = int.Parse(dr[0].ToString());
                tra.GondericiAdresi = dr[1].ToString();
                tra.AliciAdresi = dr[2].ToString();
                tra.CoinMiktari = Convert.ToDouble(dr[3].ToString());
                tra.IslemTarihi = Convert.ToDateTime(dr[4].ToString());
                tra.OnayTarihi = Convert.ToDateTime(dr[5].ToString());
                tra.Onay = Convert.ToChar(dr[6].ToString());
                transfer.Add(tra);
            }
            conn.Close();
            return transfer;
        }
        public bool TransferEkle(Transfer tra)
        {
            conn.Open();
            cmd = new SqlCommand("INSERT INTO Transfer(GondericiAdresi, AliciAdresi, CoinMiktari) VALUES ('" + tra.GondericiAdresi + "', '" + tra.AliciAdresi + "', @coin)", conn);
            cmd.Parameters.AddWithValue("@coin", tra.CoinMiktari);
            if (cmd.ExecuteNonQuery() > -1)
            {
                conn.Close();
                return true;
            }
            return false;
        }
        public bool TransferGuncelle(int id, DateTime date)
        {
            conn.Open();
            cmd = new SqlCommand("UPDATE Transfer SET OnayTarihi='"+date.ToString()+"', Onay = 1 WHERE TransferID = '" + id + "'", conn);
            if (cmd.ExecuteNonQuery() > -1)
            {
                conn.Close();
                return true;
            } 
            return false;
        }
        public bool TransferSil(int id)
        {
            conn.Open();
            cmd = new SqlCommand("DELETE FROM Transfer WHERE TransferID = '" + id + "'", conn);
            if (cmd.ExecuteNonQuery() > -1)
            {
                conn.Close();
                return true;
            }    
            return false;
        }

    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Text;
using System.Timers;

namespace RecycleCoin
{
    public class RecycleProvider:Kullanicilar
    {
        public const double carbon_degeri = 0.00001;//carbonumuzun rc karşılığı
        public RecycleProvider()
        {    
            Baglan();
        }
        public bool RecycleGuncelle(double RecycleAdet)
        {
            bool result = false;
            conn.Open();
            cmd = new SqlCommand("Update RecycleCoin Set RecycleAdet=('" +RecycleAdet+"')", conn);

            if (cmd.ExecuteNonQuery() != -1)
            {
                result = true;
            }
            conn.Close();
            return result;
        }
        public DataTable RecycleBilgi()
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM RecycleCoin", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;
        }
        public double RecycleCoinHesapla(int karbon)//gelen karbon kullanıcının elindeki
        {
           double recycle = karbon * carbon_degeri;
           return recycle; //kullanıcının alacağı karbon

        }
        

    }
}

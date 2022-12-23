using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RecycleCoin
{
    public class Kullanicilar:Database
    {
        public string ID { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public int yas { get; set; }
        public string KullaniciAd { get; set; }
        public string sifre { get; set; }
        public string mail { get; set; }
        public string telefonNo { get; set; }
        public string KullaniciTip { get; set; }
        //public string Sha { get; set; }
        public Kullanicilar()
        {
            Baglan();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RecycleCoin
{
    public class Urunler : Database
    {
        public Urunler()
        {
            Baglan();
        }
        
        public int UrunID { get; set; }
        public string UrunAd { get; set; }
        public int UrunTur { get; set; }
        public string UrunKod { get; set; }
        public int UrunKarbon { get; set; }
        public string QrUrl { get; set; }
        public bool UrunDurum { get; set; }
       
    }
}

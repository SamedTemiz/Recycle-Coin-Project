using System;
using System.Collections.Generic;
using System.Text;

namespace RecycleCoin
{
    class Transfer : Database
    {
        public int TranferID { get; set; }
        public string GondericiAdresi { get; set; }
        public string AliciAdresi { get; set; }
        public double CoinMiktari { get; set; }
        public DateTime IslemTarihi { get; set; }
        public DateTime OnayTarihi { get; set; }
        public char Onay { get; set; }

        public Transfer()
        {
            Baglan();
        }
    }
}

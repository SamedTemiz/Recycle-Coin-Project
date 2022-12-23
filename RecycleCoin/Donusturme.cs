using System;
using System.Collections.Generic;
using System.Text;

namespace RecycleCoin
{
    class Donusturme : Database
    {
        public int DonusturmeID { get; set; }
        public string KullaniciKimlik { get; set; }
        public int Karbon { get; set; }
        public double Coin { get; set; }
        public DateTime istekTarihi { get; set; }
        public DateTime onayTarihi { get; set; }
        public char Onay { get; set; }

        public Donusturme()
        {
            Baglan();
        }
    }
}

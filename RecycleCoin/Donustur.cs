using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Windows.Forms;

namespace RecycleCoin
{
    public partial class Donustur : Form
    {
        public Donustur()
        {
            
            InitializeComponent();
            
            Bilgiler();
        }
        RecycleProvider rc = new RecycleProvider();
        KullaniciProvider kullaniciProvider = new KullaniciProvider();

        public void Bilgiler()
        {
            var kullanici = kullaniciProvider.KullaniciListele().Find(x => (x.KullaniciAd == LoginInfo.kulad));
            var bakiye = kullaniciProvider.cuzdanBilgileri().Find(x => (x.kullanici_ID == kullaniciProvider.SHA256Hash(kullanici.ID)));

            lbl_carbonBakiye.Text = string.Format("{0:0,0}", bakiye.carbon_Miktari).Replace(",", ".");
            lbl_coinBakiye.Text = bakiye.coin_Miktari.ToString();

        }

        private void btn_tumBakiye_Click(object sender, EventArgs e)
        {
            decimal carbon = Convert.ToDecimal(lbl_carbonBakiye.Text);
            string yeniHali = String.Format("{0:N}", carbon);
            txt_carbonAdet.Text = yeniHali.Replace(",00", "");
            txt_carbonAdet.Select(txt_carbonAdet.Text.Length, 0);
        }

        int carbon_toCoin;
        
        private void txt_carbonAdet_TextChanged(object sender, EventArgs e)
        {
            decimal lbl = Convert.ToDecimal(lbl_carbonBakiye.Text);
            if (txt_carbonAdet.Text != "")
            {
                decimal carbon = Convert.ToDecimal(txt_carbonAdet.Text);
                if (carbon < lbl)
                {
                    string yeniHali = String.Format("{0:N}", carbon);
                    txt_carbonAdet.Text = yeniHali.Replace(",00", "");
                    txt_carbonAdet.Select(txt_carbonAdet.Text.Length, 0);
                }
                else
                {
                    txt_carbonAdet.Text = lbl_carbonBakiye.Text;
                    txt_carbonAdet.Select(txt_carbonAdet.Text.Length, 0);
                }
                carbon_toCoin = int.Parse(txt_carbonAdet.Text.Replace(".", ""));

                double deneme = rc.RecycleCoinHesapla(carbon_toCoin);

                decimal coin = Convert.ToDecimal(deneme);
                string mana = String.Format("{0:N}", coin);
                txt_coinAdet.Text = mana.Replace(",00", "");
                txt_coinAdet.Select(txt_coinAdet.Text.Length, 0);
            }
        }
        private void btn_Onayla_Click(object sender, EventArgs e)
        {
            DonusturmeProvider traPro = new DonusturmeProvider();
            if (carbon_toCoin >= 100000)
            {
                double coin = Convert.ToDouble(txt_coinAdet.Text);
                var kullanici = kullaniciProvider.KullaniciListele().Find(x => (x.KullaniciAd == LoginInfo.kulad));
                if (traPro.DonusturIstek(kullaniciProvider.SHA256Hash(kullanici.ID), carbon_toCoin, coin))
                {
                    var cuzdan = kullaniciProvider.cuzdanBilgileri().Find(x => x.kullanici_ID == kullaniciProvider.SHA256Hash(kullanici.ID));
                    MessageBox.Show("Transfer isteğiniz alınmıştır, onaylanınca tarafınıza bilgilendirme yapılacaktır.");
                    Bilgiler();
                    txt_carbonAdet.Clear();
                    txt_coinAdet.Clear();
                }
                else
                {
                    MessageBox.Show("İşlem başarısız!");
                }
            }
            else
            {
                MessageBox.Show("Minimum dönüştürme miktarı 100.000C'dur.");
                txt_carbonAdet.Focus();
            }
        }

        private void txt_carbonAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        //public Button TheButton { get { return btn_kapat; } }
        //public event EventHandler TheButton;

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

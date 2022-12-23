using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecycleCoin
{
    public partial class KullaniciBilgiGuncelleme : Form
    {
        KullaniciProvider kullanici = new KullaniciProvider();
        string kulid;
        public KullaniciBilgiGuncelleme()
        {
            InitializeComponent();
        }
        //Formu taşımak için
        Point lastPoint;
        private void KullaniciBilgiGuncelleme_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void KullaniciBilgiGuncelleme_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        //---------------------------------------------------------------------------------
        private void KullaniciBilgiGuncelleme_Load(object sender, EventArgs e)
        {
            Bilgiler();
        }
        public void Bilgiler()
        {
            var kul = kullanici.KullaniciListele().Find(x => x.KullaniciAd == LoginInfo.kulad);
            kulid = kul.ID;

            txt_Ad.Text = kul.ad;
            txt_Soyad.Text = kul.soyad;
            txt_Yas.Text = kul.yas.ToString();
            txt_KulAd.Text = kul.KullaniciAd;
            txt_Mail.Text = kul.mail;
            txt_Telefon.Text = kul.telefonNo;
        }
        public bool FormKontrol()
        {
            var kul = kullanici.KullaniciListele().Find(x => x.KullaniciAd == LoginInfo.kulad);
            if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
            {
                return true;
            }
            else
            {
                if(int.Parse(txt_Yas.Text) < 18)
                {
                    error.SetError(txt_Yas, "Yaşınız 18'den büyük olmalıdır.");
                    return true;
                }
                else
                {
                    if(txt_KulAd.Text != kul.KullaniciAd && kullanici.kontrolKullanici(txt_KulAd.Text))
                    {
                        error.SetError(txt_KulAd, "Kullanıcı adı kullanılıyor!");
                        return true;
                    }
                    else if(txt_Mail.Text != kul.mail && kullanici.kontrolMail(txt_Mail.Text))
                    {
                        error.SetError(txt_Mail, "E-Posta adresi kullanılıyor!");
                        return true;
                    }
                }
            }
            return false;
        }
        private void link_SifreGuncelleme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreGuncelleme sifre = new SifreGuncelleme();
            sifre.Show();
            this.Hide();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            Kullanicilar kul = new Kullanicilar();
            if(!FormKontrol())
            {
                kul.ad = txt_Ad.Text;
                kul.soyad = txt_Soyad.Text;
                kul.yas = int.Parse(txt_Yas.Text);
                kul.KullaniciAd = txt_KulAd.Text;
                kul.mail = txt_Mail.Text;
                kul.telefonNo = txt_Telefon.Text;

                if(kullanici.KullaniciBilgiGuncelle(kul, kulid))
                {
                    DialogResult secenek = MessageBox.Show("Güncelleme işlemi başarılı.", "ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(secenek == DialogResult.OK)
                    {
                        Anasayfa ana = new Anasayfa();
                        ana.Show();
                        this.Close();
                    }
                }
            }
        }

        private void link_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Close();
        }
    }
}

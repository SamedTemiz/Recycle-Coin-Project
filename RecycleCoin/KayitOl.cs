using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecycleCoin
{
    public partial class KayitOl : Form
    {
        Kullanicilar kul = new Kullanicilar();
        KullaniciProvider kullanici = new KullaniciProvider();

        public KayitOl()
        {
            InitializeComponent();
        }
        //Formu taşımak için
        Point lastPoint;
        private void KayitOl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void KayitOl_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        //----------------------------------------------------------------
        private void btn_Kayit_Click(object sender, EventArgs e)
        {
            kul.ID = kullanici.IdOlustur();
            kul.ad = txt_Ad.Text;
            kul.soyad = txt_Soyad.Text;
            kul.mail = txt_Mail.Text;
            kul.sifre = txt_Sifre.Text;
            kul.KullaniciAd = txt_Kulad.Text;
            kul.yas = int.Parse(txt_Yas.Text);
            kul.telefonNo = txt_Telefon.Text;

            if (formKontrol())
            {
                if (kullanici.KullaniciEkle(kul))
                {
                    //cüzdan oluştur
                    Giris grs = new Giris();
                    MessageBox.Show("Kayıt başarılı..");
                    this.Close();
                    grs.Show();
                }
                else
                {
                    MessageBox.Show("HATA");
                    Temizle();
                }
            }
        }
        public bool formKontrol()
        {
            if (txt_Ad.Text == "" || txt_Soyad.Text == "" || txt_Yas.Text == "" || txt_Kulad.Text == "" || txt_Sifre.Text == "" || txt_SifreOnay.Text == "" || txt_Mail.Text == "" || txt_Telefon.Text == "")
            {
                MessageBox.Show("Boşlukları Doldurunuz!");
            }
            else
            {
                if (kul.yas < 18)
                {
                    error.SetError(txt_Yas, "Yaşınız 18'den büyük olmalıdır!");
                    txt_Yas.Text = "";
                }
                else
                {
                    if (txt_Kulad.TextLength >= 6)
                    {

                        if (kullanici.kontrolKullanici(kul.KullaniciAd))
                        {

                            error.Clear();
                            error.SetError(txt_Kulad, "Kullanıcı adı mevcut!");
                            txt_Kulad.Text = "";
                        }
                        else
                        {
                            if (txt_Sifre.TextLength >= 6)
                            {

                                if (txt_Sifre.Text != txt_SifreOnay.Text)
                                {
                                    error.Clear();
                                    error.SetError(txt_SifreOnay, "Şifreler aynı değil!");
                                    txt_Sifre.Text = "";
                                    txt_SifreOnay.Text = "";
                                }
                                else
                                {
                                    string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                                    if (Regex.IsMatch(txt_Mail.Text,pattern))
                                    {
                                        error.Clear();
                                    if (txt_Telefon.TextLength !=10)
                                    {
                                        error.Clear();
                                        error.SetError(txt_Telefon,"Telefon Numarası 10 Karakter Olmalıdır.");
                                    }
                                    else
                                    {
                                        return true;
                                    }
                                    }
                                    else
                                    {
                                        error.SetError(txt_Mail,"Geçerli Bir Mail Adresi Giriniz.");
                                    }
                                }
                            }
                            else
                            {
                                error.Clear();
                                error.SetError(txt_Sifre,"Şifreniz Minimum 6 Karakter Olmalıdır.");
                            }
                        }
                    }
                    else
                    {
                        error.Clear();
                        error.SetError(txt_Kulad, "Kullanıcı Adı Minimum 6 Karakter Olmalıdır.");
                    }
                }
            }
            return false;
        }
        private void Temizle()
        {
            txt_Ad.Text = "";
            txt_Soyad.Text = "";
            txt_Kulad.Text = "";
            txt_Mail.Text = "";
            txt_Sifre.Text = "";
            txt_SifreOnay.Text = "";
            txt_Telefon.Text = "";
            txt_Yas.Text = "";
        }

        private void btn_sifreGizle_Click(object sender, EventArgs e)
        {
            txt_Sifre.PasswordChar = '*';
            txt_SifreOnay.PasswordChar = '*';
            btn_sifreGizle.SendToBack();
            btn_sifreGoster.BringToFront();
        }
        private void btn_sifreGoster_Click(object sender, EventArgs e)
        {
            txt_Sifre.PasswordChar = default;
            txt_SifreOnay.PasswordChar = default;
            btn_sifreGoster.SendToBack();
            btn_sifreGizle.BringToFront();
        }

        private void link_giris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
            this.Close();
        }

        private void txt_Yas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

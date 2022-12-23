using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RecycleCoin
{
    public partial class Giris : Form
    {
        KullaniciProvider kullanici = new KullaniciProvider();
        RecycleProvider rc = new RecycleProvider();

        public Giris()
        {
            //Program açıldığından çalışacak
            string system = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            var userInfo = system.Split("\\");
            LoginInfo.pcName = userInfo[0];
            LoginInfo.userName = userInfo[1];
            LoginInfo.path = @"C:\Users\" + userInfo[1] + @"\Desktop\RecycleCoin\";

            InitializeComponent();
            this.ActiveControl = null;  //this = form
            btn_Giris.Focus();            
        }
        //Formu taşımak için
        Point lastPoint;
        private void Giris_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Giris_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        //--------------------------------------------------------------   

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            if (txt_girisKulad.Text == "" || txt_girisSifre.Text == "")
            {
                MessageBox.Show("Öncellikle Boşlukları Doldurmalısınız.");
            }
            else
            {
                //Giriş bilgileri doğru ise kullanıcı tipi dönüyor; yanlış ise 0 dönüyor
                var kul_tip = kullanici.GirisKontrol(txt_girisKulad.Text, txt_girisSifre.Text);

                if (kul_tip != 0)//Kullanıcı bilgisi yanlış demek
                {
                    LoginInfo.kulad = txt_girisKulad.Text;
                    LoginInfo.oturum = true;
                    switch (kul_tip)
                    {
                        case 1: //Admin sayfası
                            Admin admin = new Admin();
                            admin.Show();
                            this.Hide();
                            break;
                        case 2: //Sorumlu sayfası
                            Urun urun = new Urun();
                            urun.Show();
                            this.Hide();
                            break;
                        case 3: //Kullanıcı sayfası
                            Anasayfa ana = new Anasayfa();
                            ana.Show();
                            this.Hide();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Bilgiler Hatalı");
                    txt_girisSifre.Text = "";
                    txt_girisKulad.Text = "";
                }
            }
        }
        private void link_sifre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum sifre = new SifremiUnuttum();
            sifre.Show();
            this.Hide();
        }
        private void link_kayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOl kayit = new KayitOl();
            kayit.Show();
            this.Hide();
        }
        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Giris_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyChar == Convert.ToInt16(Keys.Enter))
            //{
            //    MessageBox.Show("Testing KeyPress");
            //}
        }

        private void btn_Giris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Giris.PerformClick();
            }
        }

        private void txt_girisSifre_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btn_Giris.PerformClick();
            }
        }

        private void txt_girisKulad_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btn_Giris.PerformClick();
            }
        }
    }
}

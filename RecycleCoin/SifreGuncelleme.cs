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
    public partial class SifreGuncelleme : Form
    {
        public SifreGuncelleme()
        {
            InitializeComponent();
        }
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            KullaniciProvider kul = new KullaniciProvider();
            kul.KullaniciAd = txt_Kulad.Text;
            kul.sifre = txt_YeniSifre.Text;
            DialogResult dialog = new DialogResult();
            if (kul.kontrolKullanici(kul.KullaniciAd) == true)
            {
                if (txt_YeniSifre.Text == txt_YeniSifreOnay.Text)
                {
                    if (kul.SifreGuncelleme(kul) == true)
                    {
                        dialog = MessageBox.Show("Şifreniz Güncellendi ", "Bilgilendirme", MessageBoxButtons.OK);
                        if (dialog == DialogResult.OK)
                        {
                            Giris giris = new Giris();
                            giris.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        dialog = MessageBox.Show("Şifreniz Güncellenemedi, Tekrar Deneyin !", "Bilgilendirme", MessageBoxButtons.OK);
                        if (dialog == DialogResult.OK)
                        {
                            txt_YeniSifreOnay.Text = "";
                            txt_YeniSifre.Text = "";
                        }
                    }
                }
                else
                {
                    dialog = MessageBox.Show("Girmiş Olduğunuz Şifreler Aynı Değil !", "Bilgilendirme", MessageBoxButtons.OK);
                    if (dialog == DialogResult.OK)
                    {
                        txt_YeniSifreOnay.Text = "";
                        txt_YeniSifre.Text = "";
                    }
                }
            }
            else
            {
                dialog = MessageBox.Show("Sistemimizde Bu Kullanıcı Adına Sahip Bir Kullanıcı Bulunamamaktadır. Bilgilerinizi Kontrol Edip Tekrar Deneyin.", "Bilgilendirme", MessageBoxButtons.OK);
                if (dialog == DialogResult.OK)
                {
                    txt_Kulad.Text = "";
                    txt_YeniSifreOnay.Text = "";
                    txt_YeniSifre.Text = "";
                }

            }
        }
        private void btn_ac_Click(object sender, EventArgs e)
        {

            if (txt_YeniSifre.PasswordChar == '*')
            {
                btn_kapat.BringToFront();
                txt_YeniSifre.PasswordChar = '\0';
                txt_YeniSifreOnay.PasswordChar = '\0';
            }
        }
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            if (txt_YeniSifre.PasswordChar == '\0')
            {
                btn_ac.BringToFront();
                txt_YeniSifre.PasswordChar = '*';
                txt_YeniSifreOnay.PasswordChar = '*';
            }
        }
    }
}

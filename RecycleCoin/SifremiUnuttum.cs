using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecycleCoin
{
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }
        private void btn_Gönder_Click(object sender, EventArgs e)
        {
            KullaniciProvider kul = new KullaniciProvider();
            if (kul.kontrolMail(txt_Mail.Text) == false)
            {
                MessageBox.Show("Girmiş Olduğunuz Mail Adresi Sistemimize Kayıtlı Değildir.");
            }
            else
            {
                MailYolla();
            }
        }
        private void btn_Onay_Click(object sender, EventArgs e)
        {
            OnayDogrulama();
        }
        private void link_YenidenKod_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MailYolla();
        }
        string onaykodu;
        public void MailYolla()
        {
            Random rnd = new Random();
            string mail = txt_Mail.Text;
            MailMessage sms = new MailMessage();
            SmtpClient client = new SmtpClient();
            onaykodu = rnd.Next(999, 9999).ToString();
            client.Credentials = new NetworkCredential("recyclecoin@hotmail.com", "mert1254");
            client.Port = 587;
            client.Host = "smtp.office365.com";
            client.EnableSsl = true;
            sms.To.Add(mail);
            sms.From = new MailAddress("recyclecoin@hotmail.com", "RecycleCoin");
            sms.Subject = "Güvenlik Kodu";
            sms.Body = "Onay Kodunuz: " + onaykodu;
            client.Send(sms);
            MessageBox.Show("Güvenlik Kodu Gönderildi.");
        }
        public void OnayDogrulama()
        {
            DialogResult mesaj = new DialogResult();

            if (txt_Kod.Text == onaykodu)
            {
                mesaj = MessageBox.Show("Güvenlik Kodu Doğru", "Mesaj", MessageBoxButtons.OK);
                if (mesaj == DialogResult.OK)
                {
                    SifreGuncelleme guncelleme = new SifreGuncelleme();
                    guncelleme.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Güvenlik Kodu Hatalı");
            }
        }
        private void link_giris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
            this.Close();
        }
    }
}

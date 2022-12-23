using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;


namespace RecycleCoin
{
    public partial class Urun : Form
    {
        string urunQR_path;
        static Random random = new Random();
        UrunProvider urunProvider = new UrunProvider();

        public Urun()
        {
            //urunQR_path = LoginInfo.path + @"UrunQR\";
            urunQR_path = Application.StartupPath + @"UrunQR\";
            Directory.CreateDirectory(urunQR_path);

            InitializeComponent();
        }
        //Formu taşımak için
        Point lastPoint;
        private void Urun_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void Urun_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        //-------------------------------------------------------------

        private void Urun_Load(object sender, EventArgs e)
        {
            UrunListele();
            FotografTemizlik();
        }

        //TAB 1
        private void cmb_UrunTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_UrunTur.SelectedIndex == 0)
            {
                txt_UrunTur.Text = "P";
            }
            else if (cmb_UrunTur.SelectedIndex == 1)
            {
                txt_UrunTur.Text = "A";
            }
            else if (cmb_UrunTur.SelectedIndex == 2)
            {
                txt_UrunTur.Text = "K";
            }
            else if (cmb_UrunTur.SelectedIndex == 3)
            {
                txt_UrunTur.Text = "C";
            }
            else if (cmb_UrunTur.SelectedIndex == 4)
            {
                txt_UrunTur.Text = "D";
            }
        }
        private void btn_QrYazdir_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += myPrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }
        private void myPrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pic_QrYazdir.Width, pic_QrYazdir.Height);
            pic_QrYazdir.DrawToBitmap(bm, new Rectangle(0, 0, pic_QrYazdir.Width, pic_QrYazdir.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();

        }
        public void QrKodOlustur(string metin)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(metin, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(8);

            pic_UrunQr.Image = qrCodeImage;
        }
        private void btn_Qr_Click(object sender, EventArgs e)
        {
            if (txt_Kod.Text == "" || cmb_UrunTur.Text == "--Ürün Türünü Seçiniz--")
            {
                MessageBox.Show("Ürünü Sisteme Kaydetmek İçin Gerekli Boşlukları Doldurmanız Gerekiyor.");
            }
            else
            {
                QrKodOlustur(txt_UrunTur.Text + "-" + txt_Kod.Text);
            }
        }
        public void qrKaydet(string metin)
        {
            FileInfo[] Files;
            DirectoryInfo d = new DirectoryInfo(urunQR_path);
            Files = d.GetFiles("*.jpg");//Files.Name => A-333.jpg
            var list = Files.ToList();
            if (!(list.Exists(x=> x.Name == metin)))
            {
                pic_UrunQr.Image.Save(urunQR_path + metin);
            }
        }
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (cmb_UrunTur.Text == "--Ürün Türünü Seçiniz--" || txt_KarbonMik.Text == "" || txt_UrunTur.Text == "")
            {
                MessageBox.Show("Ürünü Sisteme Kaydetmek İçin Gerekli Boşlukları Doldurmanız Gerekiyor.");
            }
            else
            {
                progBar.Visible = true;
                progBar.Maximum = (int)num_urunAdet.Value;

                for (int i = 0; i < num_urunAdet.Value; i++)
                {
                    Urunler urun = new Urunler();
                    UrunProvider urunProvider = new UrunProvider();
                git:
                    int num = random.Next(100, 1000);
                    if (txt_Kod.Text == "")
                    {
                        txt_Kod.Text = num.ToString();
                    }
                    else
                    {
                        if (urunProvider.urunKontrol(txt_Kod.Text) == true)
                        {
                            goto git;
                        }
                    }
                    urun.UrunTur = cmb_UrunTur.SelectedIndex + 1;
                    urun.UrunAd = txt_urunAd.Text;
                    urun.UrunKod = txt_UrunTur.Text + "-" + string.Format("{0:D3}", int.Parse(txt_Kod.Text));
                    urun.UrunKarbon = int.Parse(txt_KarbonMik.Text);
                    urun.QrUrl = urun.UrunKod + ".jpg";

                    QrKodOlustur(urun.UrunKod);//:*
                    qrKaydet(urun.QrUrl);
                    urunProvider.UrunEkle(urun);
                    progBar.Value += 1;//Process bar ilerlemesi
                    txt_Kod.Text = "";
                }
                MessageBox.Show("Ürün(ler) başarılı bir şekilde eklendi.");
                formTemizle();
                UrunListele();
            }
        }
        public void formTemizle()
        {
            //pic_UrunQr.Image = null;
            txt_UrunTur.Text = "";
            txt_urunAd.Text = "";
            txt_KarbonMik.Text = "";
            txt_Kod.Text = "";
            cmb_UrunTur.Text = "--Ürün Türünü Seçiniz--";
            progBar.Value = 0;
            progBar.Visible = false;
        }
        private void num_urunAdet_ValueChanged(object sender, EventArgs e)
        {
            if (txt_Kod.Text != "")
            {
                error.SetError(txt_Kod, "Ürün kodu sadece 1 adet için geçerlidir!");
            }
        }
        private void btn_txtKodinfo_MouseHover(object sender, EventArgs e)
        {
            lbl_txtKodinfo.Visible = true;
            lbl_txtKodinfo.Text = "Kod rastgele oluşur.";
        }
        private void btn_txtKodinfo_MouseLeave(object sender, EventArgs e)
        {
            lbl_txtKodinfo.Visible = false;
        }
        //----------------------------------------------------------------------------

        //TAB 2
        static int id;
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            //Güncel bilgileri alıyoruz
            int index = data_UrunListele.CurrentRow.Index;
            int id = int.Parse(data_UrunListele.CurrentRow.Cells[0].Value.ToString());
            var urunBilgi = urunProvider.UrunleriListele().Find(x => x.UrunID == id);
            string yeniUrunKod = txt_listUrunTur.Text + "-" + txt_listUrunKod.Text;
            string yeniUrunQr = yeniUrunKod + ".jpg";

            Urunler urun = new Urunler();
            urun.UrunAd = txt_listUrunAd.Text;
            urun.UrunTur = cmb_listUrunTur.SelectedIndex + 1;
            urun.UrunKod = yeniUrunKod;
            urun.UrunKarbon = int.Parse(txt_listUrunKarbon.Text);
            urun.QrUrl = yeniUrunKod + ".jpg";

            if (yeniUrunKod == urunBilgi.UrunKod || (!urunProvider.urunKontrol(yeniUrunKod)))
            {
                if (urunProvider.UrunleriGuncelle(id, urun))
                {
                    QrKodOlustur(yeniUrunKod);
                    qrKaydet(yeniUrunQr);
                    UrunListele();
                    data_UrunListele.Rows[index].Selected = true;
                    MessageBox.Show("Güncelleme Başarılı");
                }
                else
                {
                    MessageBox.Show("Güncelleme başarısız!");
                }
            }
            else
            {
               
                MessageBox.Show("Ürün kodu zaten var!");
            }
            UrunListele();
        }
        public void DataGridDoldurma()
        {
            id = int.Parse(data_UrunListele.CurrentRow.Cells[0].Value.ToString());
            //txt_UurunAd.Text = data_UrunListele.CurrentRow.Cells[1].Value.ToString();
            int UrunTurIndex = int.Parse(data_UrunListele.CurrentRow.Cells[2].Value.ToString());
            if (UrunTurIndex == 1)
            {
                cmb_listUrunTur.SelectedIndex = 0;
            }
            else if (UrunTurIndex == 2)
            {
                cmb_listUrunTur.SelectedIndex = 1;
            }
            else if (UrunTurIndex == 3)
            {
                cmb_listUrunTur.SelectedIndex = 2;
            }
            else if (UrunTurIndex == 4)
            {
                cmb_listUrunTur.SelectedIndex = 3;
            }
            else if (UrunTurIndex == 5)
            {
                cmb_listUrunTur.SelectedIndex = 4;
            }
            else
            {
                cmb_listUrunTur.Text = "--Ürün Türünü Seçiniz--";
            }
            txt_listUrunKod.Text = data_UrunListele.CurrentRow.Cells[3].Value.ToString();
            char[] ayrac = { '-' };
            string[] urunkey = txt_listUrunKod.Text.Split(ayrac, 2);
            txt_listUrunTur.Text = urunkey[0];
            txt_listUrunKod.Text = urunkey[1];
            txt_listUrunKarbon.Text = data_UrunListele.CurrentRow.Cells[4].Value.ToString();
            txt_listUrunQr.Text = data_UrunListele.CurrentRow.Cells[5].Value.ToString();
            pic_QrYazdir.Image = Image.FromFile(@"C:\Users\merts\Masaüstü\RecycleCoin\UrunQR\" + txt_listUrunQr.Text);
        }
        private void cmb_listUrunTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_listUrunTur.SelectedIndex == 0)
            {
                txt_listUrunTur.Text = "P";
            }
            else if (cmb_listUrunTur.SelectedIndex == 1)
            {
                txt_listUrunTur.Text = "A";
            }
            else if (cmb_listUrunTur.SelectedIndex == 2)
            {
                txt_listUrunTur.Text = "K";
            }
            else if (cmb_listUrunTur.SelectedIndex == 3)
            {
                txt_listUrunTur.Text = "C";
            }
            else if (cmb_listUrunTur.SelectedIndex == 4)
            {
                txt_listUrunTur.Text = "D";
            }
            txt_listUrunQr.Text = string.Format("{0}-{1}.jpg", txt_listUrunTur.Text, txt_listUrunKod.Text);
        }
        private void txt_listUrunKod_TextChanged(object sender, EventArgs e)
        {
            txt_listUrunQr.Text = string.Format("{0}-{1}.jpg", txt_listUrunTur.Text, txt_listUrunKod.Text);
        }
        private void btn_Sil_Click(object sender, EventArgs e)
        {
            string kod = data_UrunListele.CurrentRow.Cells[3].Value.ToString();
            DialogResult secenek = MessageBox.Show("Ürün kaydını silmek istediğinizden emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                if (urunProvider.UrunSil(kod))
                {
                    MessageBox.Show("Ürün başarıyla silindi");
                    UrunListele();
                }
                else
                    MessageBox.Show("HATA!");

                if(data_UrunListele.Rows.Count > 0)
                    data_UrunListele.Rows[0].Selected = true;
            }
            UrunListele();
        }
        public void UrunListele()
        {
            UrunProvider urunProvider = new UrunProvider();
            data_UrunListele.DataSource = urunProvider.UrunleriListele();
            DataGridAyar();
        }
        public void DataGridAyar()
        {
            data_UrunListele.Columns[0].Visible = false;
            data_UrunListele.Columns[1].HeaderText = "Ürünün Adı";
            data_UrunListele.Columns[2].HeaderText = "Ürünün Türü";
            data_UrunListele.Columns[3].HeaderText = "Ürünün Kodu";
            data_UrunListele.Columns[4].HeaderText = "Ürünün Karbon Miktarı";
            data_UrunListele.Columns[5].HeaderText = "QR adı";

            //data_UrunListele.Columns[5].HeaderText = "Ürünün Qr Adresi";
            data_UrunListele.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data_UrunListele.Columns[1].Width = 180;
            data_UrunListele.Columns[2].Width = 160;
            data_UrunListele.Columns[3].Width = 180;
            data_UrunListele.Columns[4].Width = 180;
            data_UrunListele.Columns[5].Width = 180;

            data_UrunListele.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            data_UrunListele.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            data_UrunListele.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            data_UrunListele.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            data_UrunListele.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
        }
        private void data_UrunListele_SelectionChanged(object sender, EventArgs e)
        {
            formDoldur();
        }
        private void formDoldur()
        {
            txt_listUrunAd.Text = data_UrunListele.CurrentRow.Cells[1].Value.ToString();
            cmb_listUrunTur.SelectedIndex = (int)data_UrunListele.CurrentRow.Cells[2].Value - 1;
            txt_listUrunTur.Text = cmb_listUrunTur.SelectedItem.ToString().Substring(0, 1);
            txt_listUrunKod.Text = data_UrunListele.CurrentRow.Cells[3].Value.ToString().Split("-")[1];
            txt_listUrunKarbon.Text = data_UrunListele.CurrentRow.Cells[4].Value.ToString();
            txt_listUrunQr.Text = data_UrunListele.CurrentRow.Cells[5].Value.ToString();

            if (File.Exists(urunQR_path + txt_listUrunQr.Text))
                pic_QrYazdir.Image = Image.FromFile(urunQR_path + txt_listUrunQr.Text);
            pic_QrYazdir.Refresh();
        }
        private void txt_urunAd_Leave(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Globalization.TextInfo textInfo = cultureInfo.TextInfo;
            txt_urunAd.Text = textInfo.ToTitleCase(txt_urunAd.Text);
        }
        private void btn_kodAra_Click(object sender, EventArgs e)
        {
            string searchValue = txt_urunkodAra.Text;
            if (searchValue != "")
            {
                try
                {
                    bool valueResult = false;
                    foreach (DataGridViewRow row in data_UrunListele.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
                            {
                                int rowIndex = row.Index;
                                data_UrunListele.ClearSelection();
                                data_UrunListele.Rows[rowIndex].Selected = true;
                                formDoldur();
                                valueResult = true;
                                break;
                            }
                        }

                    }
                    if (!valueResult)
                    {
                        MessageBox.Show(txt_urunkodAra.Text, "Kod bulunamadı");
                        return;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
                error.SetError(txt_urunkodAra, "Boş bırakılamaz!");
        }
        private void txt_KarbonMik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void cmb_Tur_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_urunkodAra.Text = string.Format("{0}-", cmb_Tur.SelectedItem.ToString());

        }
        //----------------------------------------------------------------------------

        //GENEL
        public void FotografTemizlik()
        {
            FileInfo[] Files;
            DirectoryInfo d = new DirectoryInfo(urunQR_path);
            Files = d.GetFiles("*.jpg");//Files.Name => A-333.jpg

            for (int i = 0; i < Files.Length; i++)
            {
                if (!urunProvider.UrunleriListele().Exists(x => (x.QrUrl == Files[i].Name)))
                {
                    File.Delete(Files[i].FullName);
                }
            }
        }
        private void btn_Oturum_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
            this.Close();
        }
        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
    }
}



using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using ZXing;
namespace RecycleCoin
{
    public partial class Anasayfa : Form
    {
        int karbontut = 0;
        double recycleCoin = 0;

        UrunProvider urunProvider = new UrunProvider();
        KullaniciProvider kul = new KullaniciProvider();
        Donustur don = new Donustur();
        KullaniciBilgiGuncelleme kulBilgi = new KullaniciBilgiGuncelleme();
        DonusturmeProvider donustur = new DonusturmeProvider();
        TransferProvider transfer = new TransferProvider();

        public Anasayfa()
        {
            InitializeComponent();

            don.FormClosed += new FormClosedEventHandler(don_FormClosed);
            kulBilgi.FormClosed += new FormClosedEventHandler(kul_FormClosed);
            FotografYakala();
            KullaniciBilgileri();
            setTool();
        }
        //Formu taşımak için
        Point lastPoint;
        private void Anasayfa_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void Anasayfa_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        //--------------------------------------------------------------   

        //TAB 1
        VideoCaptureDevice cam;
        FilterInfoCollection webcam;
        public void FotografYakala()
        {
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            cam = new VideoCaptureDevice(webcam[0].MonikerString);
            cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);
            cam.Start();
            timer1.Start();
        }
        private void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            pic_QrOkutma.Image = bit;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pic_QrOkutma.Image != null)
            {
                BarcodeReader brd = new BarcodeReader();
                Result sonuc = brd.Decode((Bitmap)pic_QrOkutma.Image);
                if (sonuc != null)
                {
                    txt_UrunKodu.Text = sonuc.ToString();
                    timer1.Stop();
                    if (BilgileriGetir(txt_UrunKodu.Text))
                        DataKontrol();
                    if (datagrid_Sepet.Rows.Count > 0)
                    {
                        pic_leftArrow.Visible = false;
                        lbl_Bilgilendirme.Visible = false;

                        lbl_donusturBilgi.Visible = true;
                        pic_Arrow.Visible = true;
                        picButton_Donustur.Visible = true;

                        lbl_toplamKarbon.Text = string.Format("{0}", ToplamKarbon().ToString());
                        pnl_Karbon.Visible = true;

                        DataGridAyar();
                    }
                }
            }
            timer1.Start();
        }
        public bool BilgileriGetir(string kod)
        {
            var veri = urunProvider.UrunleriListele().Find(x => (x.UrunKod == kod) && (x.UrunDurum == true));
            if (veri != null)
            {
                txt_Urunad.Text = veri.UrunAd;
                txt_UrunTur.Text = veri.UrunTur.ToString();
                txt_KarbonMik.Text = veri.UrunKarbon.ToString();
                return true;
            }
            else
            {
                MessageBox.Show("Bu koda ait ürün bulunamamıştır!");
                txt_UrunKodu.Text = "";
                return false;
            }
        }
        public void DataKontrol()
        {
            string[] yeni = { txt_UrunKodu.Text, txt_Urunad.Text, txt_UrunTur.Text, txt_KarbonMik.Text };
            if (datagrid_Sepet.RowCount < 1)
            {
                datagrid_Sepet.Rows.Add(yeni);
                playSimpleSound();
            }
            else
            {
                bool check = false;
                foreach (DataGridViewRow row in datagrid_Sepet.Rows)
                {
                    if (row.Cells[0].Value.ToString() == txt_UrunKodu.Text)
                    {
                        check = true;
                    }

                }
                if (!check)
                {
                    datagrid_Sepet.Rows.Add(yeni);
                    playSimpleSound();
                    check = false;
                }
            }
        }
        public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.barkod);
            simpleSound.Play();
        }
        private void picButton_Donustur_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show(ToplamKarbon().ToString() + " adet Carbon(C) hesabınıza eklenmiştir.", "Bilgilendirme", MessageBoxButtons.OK);

            karbontut += ToplamKarbon();
            kul.KarbonEkle(karbontut, lbl_KullaniciKimlik.Text);
            urunProvider.UrunDurumGuncelle(Kodlar());
            datagrid_Sepet.Rows.Clear();
            tab_Control.SelectedIndex = 1;

            if (dialog == DialogResult.OK)
            {
                pic_leftArrow.Visible = true;
                lbl_Bilgilendirme.Visible = true;

                lbl_donusturBilgi.Visible = false;
                pic_Arrow.Visible = false;
                picButton_Donustur.Visible = false;

                pnl_Karbon.Visible = false;
            }

            lbl_KarbonMikListe.Text = karbontut.ToString();
        }
        public string[] Kodlar()
        {
            string[] kods = new string[datagrid_Sepet.Rows.Count];
            for (int i = 0; i < datagrid_Sepet.Rows.Count; i++)
            {
                kods[i] = datagrid_Sepet.Rows[i].Cells[0].Value.ToString();
            }
            return kods;
        }
        public void DataGridAyar()
        {
            datagrid_Sepet.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_Sepet.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            datagrid_Sepet.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            datagrid_Sepet.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            datagrid_Sepet.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
        }
        //----------------------------------------------------------------------

        //TAB 2
        private void link_KulBilgi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullaniciBilgiGuncelleme kulbilgi = new KullaniciBilgiGuncelleme();
            kulbilgi.Show();
            this.Hide();
        }
        public int ToplamKarbon()
        {
            int toplamKarbon = 0;
            datagrid_Sepet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow row in datagrid_Sepet.Rows)
            {
                int deger = int.Parse(row.Cells[3].Value.ToString());
                toplamKarbon += deger;
            }
            return toplamKarbon;
        }
        private void txt_UrunTur_TextChanged(object sender, EventArgs e)
        {
            if (txt_UrunTur.Text == "1")
            {
                txt_UrunTur.Text = "Plastik";
            }
            else if (txt_UrunTur.Text == "2")
            {
                txt_UrunTur.Text = "Alüminyum";
            }
            else if (txt_UrunTur.Text == "3")
            {
                txt_UrunTur.Text = "Kağıt";
            }
            else if (txt_UrunTur.Text == "4")
            {
                txt_UrunTur.Text = "Cam";
            }
            else if (txt_UrunTur.Text == "5")
            {
                txt_UrunTur.Text = "Demir";
            }
        }
        public void KullaniciBilgileri()
        {
            KullaniciProvider kullaniciProvider = new KullaniciProvider();
            var kullanici = kullaniciProvider.KullaniciListele().Find(x => (x.KullaniciAd == LoginInfo.kulad));
            var bakiye = kullaniciProvider.cuzdanBilgileri().Find(x => (x.kullanici_ID == kullaniciProvider.SHA256Hash(kullanici.ID)));

            //Ana sayfa
            lbl_Miktar.Text = bakiye.coin_Miktari.ToString();
            lbl_KarbonMikListe.Text = bakiye.carbon_Miktari.ToString();

            //Kullanıcı sayfası
            lbl_KullaniciKimlik.Text = bakiye.kullanici_ID;
            txt_KulAd.Text = kullanici.KullaniciAd;
            txt_Mail.Text = kullanici.mail;
            txt_Telefon.Text = kullanici.telefonNo;

            //Transfer sayfası
            txt_GondericiAdresi.Text = bakiye.kullanici_ID;
            lbl_RC.Text = bakiye.coin_Miktari.ToString();

            DonusturmeList();
            TranferList();
        }
        public void DonusturmeList()
        {
            dataGrid_OnayBekleyen.Rows.Clear();
            var kullanici = kul.KullaniciListele().Find(x => (x.KullaniciAd == LoginInfo.kulad));
            var donusturme = donustur.DonusturListele().FindAll(x => (x.KullaniciKimlik == kul.SHA256Hash(kullanici.ID)));

            int sayac = 0;
            foreach (var x in donusturme)
            {
                if (x.Onay.ToString() == "0")
                {
                    string[] row = { x.Karbon.ToString(), x.Coin.ToString(), x.istekTarihi.ToString().Substring(0, 10), "Onay Bekliyor" };
                    dataGrid_OnayBekleyen.Rows.Add(row);
                    sayac++;
                }
                else if (x.Onay.ToString() == "1")
                {
                    string[] row = { x.Karbon.ToString(), x.Coin.ToString(), x.istekTarihi.ToString().Substring(0, 10), "Onaylandı" };
                    dataGrid_OnayBekleyen.Rows.Add(row);
                }
            }
            dataGrid_OnayBekleyen.Columns["onayDurumu"].HeaderText = string.Format("Onay Durumu | {0} bekleyen", sayac);
            this.dataGrid_OnayBekleyen.Sort(this.dataGrid_OnayBekleyen.Columns["onayDurumu"], ListSortDirection.Ascending);

            dataGrid_OnayBekleyen.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_OnayBekleyen.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_OnayBekleyen.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_OnayBekleyen.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGrid_OnayBekleyen.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_OnayBekleyen.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_OnayBekleyen.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_OnayBekleyen.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public void TranferList()
        {
            dataGrid_Transferler.Rows.Clear();
            var kullanici = kul.KullaniciListele().Find(x => (x.KullaniciAd == LoginInfo.kulad));
            var trans = transfer.TransferListele().FindAll(x => (x.GondericiAdresi == kul.SHA256Hash(kullanici.ID)) || (x.AliciAdresi == kul.SHA256Hash(kullanici.ID)));

            int sayac = 0;
            foreach (var x in trans)
            {
                if (x.Onay.ToString() == "0")
                {
                    if (x.GondericiAdresi == txt_GondericiAdresi.Text)
                    {
                        string[] row = { x.GondericiAdresi, x.AliciAdresi, x.CoinMiktari.ToString(), "GİDEN", "Onay Bekliyor", x.IslemTarihi.ToString().Substring(0, 10) };
                        dataGrid_Transferler.Rows.Add(row);
                    }
                    else
                    {
                        string[] row = { x.GondericiAdresi, x.AliciAdresi, x.CoinMiktari.ToString(), "GELEN", "Onay Bekliyor", x.IslemTarihi.ToString().Substring(0, 10) };
                        dataGrid_Transferler.Rows.Add(row);
                    }
                    sayac++;
                }
                else if (x.Onay.ToString() == "1")
                {
                    if (x.GondericiAdresi == txt_GondericiAdresi.Text)
                    {
                        string[] row = { x.GondericiAdresi, x.AliciAdresi, x.CoinMiktari.ToString(), "GİDEN", "Onaylandı", x.IslemTarihi.ToString().Substring(0, 10) };
                        dataGrid_Transferler.Rows.Add(row);
                    }
                    else
                    {
                        string[] row = { x.GondericiAdresi, x.AliciAdresi, x.CoinMiktari.ToString(), "GELEN", "Onaylandı", x.IslemTarihi.ToString().Substring(0, 10) };
                        dataGrid_Transferler.Rows.Add(row);
                    }
                }
                foreach (DataGridViewRow row in dataGrid_Transferler.Rows)
                {
                    if (row.Cells["gelen_giden"].Value.ToString() == "GELEN")
                    {
                        row.Cells["gelen_giden"].Style.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        row.Cells["gelen_giden"].Style.BackColor = Color.LightSalmon;
                    }
                }
            }


            dataGrid_OnayBekleyen.Columns["onayDurumu"].HeaderText = string.Format("Onay Durumu | {0} bekleyen", sayac);
            this.dataGrid_Transferler.Sort(this.dataGrid_Transferler.Columns["transferOnay"], ListSortDirection.Ascending);

            dataGrid_Transferler.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_Transferler.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_Transferler.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_Transferler.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_Transferler.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGrid_Transferler.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_Transferler.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_Transferler.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_Transferler.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid_Transferler.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        void don_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGrid_OnayBekleyen.Rows.Clear();
            dataGrid_OnayBekleyen.Refresh();
            KullaniciBilgileri();
        }
        void kul_FormClosed(object sender, FormClosedEventArgs e)
        {
            KullaniciBilgileri();
            tab_Control.SelectedIndex = 2;
        }
        private void btn_Paste_Click(object sender, EventArgs e)
        {
            txt_AliciAdresi.Text = Clipboard.GetText();
            txt_AliciAdresi.Refresh();
        }
        private void link_Donustur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int carbon = int.Parse(lbl_KarbonMikListe.Text);
            if (carbon > 100000)
            {
                don.ShowDialog();
            }
            else
                MessageBox.Show("Dönüştürmek için yeterli Carbon(C)'a sahip değilsiniz!");
        }
        //----------------------------------------------------------------------

        //TAB 3
        private void btn_25_Click(object sender, EventArgs e)
        {
            txt_TransferRC.Text = (Convert.ToDouble(lbl_RC.Text) / 4).ToString();
        }
        private void btn_50_Click(object sender, EventArgs e)
        {
            txt_TransferRC.Text = (Convert.ToDouble(lbl_RC.Text) / 2).ToString();
        }
        private void btn_100_Click(object sender, EventArgs e)
        {
            txt_TransferRC.Text = lbl_RC.Text;
        }
        private void btn_Gonder_Click(object sender, EventArgs e)
        {
            var kullanici = kul.KullaniciListele().Find(x => (x.KullaniciAd == LoginInfo.kulad));
            var bakiye = kul.cuzdanBilgileri().Find(x => (x.kullanici_ID == kul.SHA256Hash(kullanici.ID)));
            bool check = kul.cuzdanBilgileri().Exists(x => x.kullanici_ID == txt_AliciAdresi.Text.Trim());
            if (txt_AliciAdresi.Text != "" && txt_TransferRC.Text != "")
            {
                if(check)
                {
                    double miktar = Convert.ToDouble(txt_TransferRC.Text);
                    if (miktar < 5)
                    {
                        MessageBox.Show("Minimum transfer tutarı 5 RC'dir.");
                        txt_TransferRC.Clear();
                        txt_TransferRC.Focus();
                    }
                    else
                    {
                        Transfer tra = new Transfer();
                        tra.GondericiAdresi = txt_GondericiAdresi.Text;
                        tra.AliciAdresi = txt_AliciAdresi.Text;
                        tra.CoinMiktari = Convert.ToDouble(txt_TransferRC.Text);

                        if (transfer.TransferEkle(tra))
                        {
                            if (kul.CuzdanTransfer(kul.SHA256Hash(kullanici.ID), miktar))
                                MessageBox.Show("Transfer talebiniz alınmıtır.");
                            else
                                MessageBox.Show("HATA!");
                        }
                        else
                            MessageBox.Show("Bilinmeyen HATA!");
                    }
                }
                else
                {
                    MessageBox.Show("Alıcı bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz!");
            }
            dataGrid_Transferler.Rows.Clear();
            dataGrid_Transferler.Refresh();
            KullaniciBilgileri();
        }
        //----------------------------------------------------------------------

        //TAB 4
        private void btn_Oturum_Click(object sender, EventArgs e)
        {
            LoginInfo.oturum = false;
            Giris grs = new Giris();
            grs.Show();
            this.Close();
        }
        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //----------------------------------------------------------------------

        //GENEL
        private void tab_Control_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_Control.SelectedIndex != 0)
            {
                cam.SignalToStop();
            }
            else
            {
                cam.Start();
            }
        }
        public void setTool()
        {
            tool.SetToolTip(btn_Copy, "KOPYALA");
            tool.SetToolTip(link_Donustur, "Dönüştürmek için minimum 100.000C gereklidir!");
            tool.SetToolTip(pic_rcLogo, "Recycle Coin");
            tool.SetToolTip(pic_cLogo, "Carbon");
        }
    }
}


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecycleCoin
{
    public partial class Admin : Form
    {
        KullaniciProvider kul = new KullaniciProvider();
        RecycleProvider rec = new RecycleProvider();
        TransferProvider transfer = new TransferProvider();
        DonusturmeProvider donusturme = new DonusturmeProvider();

        public Admin()
        {
            InitializeComponent();
        }
        //Formu taşımak için
        Point lastPoint;
        private void Admin_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void Admin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        //--------------------------------------------------------------
        private void Admin_Load(object sender, EventArgs e)
        {
            KullaniciListesi();
            DonusturmeListesi();
            TransferListesi();
            kul.CuzdanTemizle();
        }
        //TAB 1
        public void KullaniciListesi()
        {
            dataGrid_Kullanicilar.Rows.Clear();
            foreach (var kul in kul.KullaniciListele())
            {
                string[] row = { kul.ad, kul.soyad, kul.yas.ToString(), kul.KullaniciAd, kul.mail, kul.telefonNo, kul.KullaniciTip.ToString() };
                dataGrid_Kullanicilar.Rows.Add(row);
            }
            dataGrid_Kullanicilar.ClearSelection();
        }
        private void btn_KulSil_Click(object sender, EventArgs e)
        {
            if (kul.KullaniciSil(txt_Kulad.Text))
            {
                MessageBox.Show("Kullanıcı Başarıyla Silindi.");
                KullaniciListesi();
            }
            else
            {
                MessageBox.Show("HATA!");
            }
        }
        private void dataGrid_Kullanicilar_SelectionChanged(object sender, EventArgs e)
        {
            txt_Ad.Text = dataGrid_Kullanicilar.CurrentRow.Cells[0].Value.ToString();
            txt_Soyad.Text = dataGrid_Kullanicilar.CurrentRow.Cells[1].Value.ToString();
            txt_Yas.Text = dataGrid_Kullanicilar.CurrentRow.Cells[2].Value.ToString();
            txt_Kulad.Text = dataGrid_Kullanicilar.CurrentRow.Cells[3].Value.ToString();
            txt_Mail.Text = dataGrid_Kullanicilar.CurrentRow.Cells[4].Value.ToString();
            txt_Telefon.Text = dataGrid_Kullanicilar.CurrentRow.Cells[5].Value.ToString();
            int tur = int.Parse(dataGrid_Kullanicilar.CurrentRow.Cells[6].Value.ToString());
            cmb_KullaniciTur.SelectedIndex = tur - 1;

            var kullanici = kul.KullaniciListele().Find(x => x.KullaniciAd == txt_Kulad.Text);
            var cuzdan = kul.cuzdanBilgileri().Find(z => z.kullanici_ID == kul.SHA256Hash(kullanici.ID));

            lbl_rcMiktar.Text = cuzdan.coin_Miktari.ToString();
            lbl_cMiktar.Text = cuzdan.carbon_Miktari.ToString();
        }
        public void KullaniciArama()
        {
            if (dataGrid_Kullanicilar.Rows.Count > 0)
            {
                int index = 0;
                foreach (DataGridViewRow row in dataGrid_Kullanicilar.Rows)
                {
                    if (row.Cells[3].Value.ToString() == txt_Arama.Text.Trim())
                    {
                        index = row.Cells[3].RowIndex;
                    }
                }
                dataGrid_Kullanicilar.Rows[index].Selected = true;
            }
        }
        private void txt_Arama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KullaniciArama();
                txt_Arama.Clear();
                txt_Arama.Refresh();
                //ActiveControl = null;
            }
            if (e.KeyCode == Keys.Back)
            {
                dataGrid_Kullanicilar.ClearSelection();
            }
        }
        private void txt_Arama_MouseClick(object sender, MouseEventArgs e)
        {
            dataGrid_Kullanicilar.ClearSelection();
        }
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            int index = cmb_KullaniciTur.SelectedIndex + 1;
            int tip = int.Parse(dataGrid_Kullanicilar.CurrentRow.Cells[6].Value.ToString());
            int rowIndex = dataGrid_Kullanicilar.CurrentRow.Index;
            if (index != tip)
            {
                if (kul.KullaniciYetkiGuncelleme(txt_Kulad.Text, index))
                {
                    MessageBox.Show("Güncelleme işlemi başarılı.");
                    KullaniciListesi();
                    dataGrid_Kullanicilar.Rows[rowIndex].Selected = true;
                }
                else
                    MessageBox.Show("HATA!");
            }
        }
        //TAB 2
        public void DonusturmeListesi()
        {
            datagrid_Donusturme.Rows.Clear();
            int adet = 0, sayac = 0;
            foreach (var don in donusturme.DonusturListele())
            {
                if (don.Onay.ToString() == "0")
                {
                    string[] row = { don.DonusturmeID.ToString(), don.KullaniciKimlik, don.Karbon.ToString(), don.Coin.ToString(), don.istekTarihi.ToString().Substring(0, 10), "Onay Bekliyor" };
                    datagrid_Donusturme.Rows.Add(row);
                    adet++;
                }
                else
                {
                    string[] row = { don.DonusturmeID.ToString(), don.KullaniciKimlik, don.Karbon.ToString(), don.Coin.ToString(), don.istekTarihi.ToString().Substring(0, 10), "Onaylandı" };
                    datagrid_Donusturme.Rows.Add(row);
                }
            }
            int[] onay_bekleyen = new int[adet];
            foreach (DataGridViewRow row in datagrid_Donusturme.Rows)
            {
                if (row.Cells["donusturOnayDurumu"].Value.ToString() == "Onaylandı")
                {
                    row.Cells["donusturOnayDurumu"].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    row.Cells["donusturOnayDurumu"].Style.BackColor = Color.LightSalmon;
                    onay_bekleyen[sayac] = int.Parse(row.Cells[0].Value.ToString());
                    sayac++;
                }
            }
            lbl_onayBekleyen.Text = string.Format("ONAY BEKLEYEN: {0}", adet);
            this.datagrid_Donusturme.Sort(this.datagrid_Donusturme.Columns["donusturOnayDurumu"], ListSortDirection.Ascending);

            datagrid_Donusturme.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_Donusturme.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_Donusturme.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_Donusturme.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_Donusturme.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_Donusturme.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            datagrid_Donusturme.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_Donusturme.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_Donusturme.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_Donusturme.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_Donusturme.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_Donusturme.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            datagrid_Donusturme.ClearSelection();
        }
        private void btn_seciliDonusturme_Click(object sender, EventArgs e)
        {
            int id = int.Parse(datagrid_Donusturme.CurrentRow.Cells[0].Value.ToString());
            var don = donusturme.DonusturListele().Find(a => a.DonusturmeID == id);
            if(donusturme.DonusturListele().Exists(x => (x.DonusturmeID == id) && (x.Onay == '0')))
            {
                if (donusturme.DonusturOnay(don.KullaniciKimlik, DateTime.Now))
                {
                    kul.CuzdanOnay(don.KullaniciKimlik, don.Coin);
                    MessageBox.Show("İşlem başarılı");
                }
            }
            else
            {
                MessageBox.Show("Zaten onaylı!");
            }
            DonusturmeListesi();
        }
        private void btn_donusturOnayla_Click(object sender, EventArgs e)
        {
            if (donusturme.DonusturListele().Count(x => x.Onay == '0') > 0)
            {
                DialogResult secenek = MessageBox.Show("Tüm dönüştürmeleri onaylıyor musunuz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    foreach (var onay in donusturme.DonusturListele().FindAll(x => (x.Onay == '0')))
                    {
                        if (donusturme.DonusturOnay(onay.KullaniciKimlik, DateTime.Now))
                        {
                            kul.CuzdanOnay(onay.KullaniciKimlik, onay.Coin);
                        }
                    }
                    MessageBox.Show("İşlem başarılı");
                }
            }
            else
            {
                MessageBox.Show("Onay bekleyen herhangi bir transfer yok!");
            }
            DonusturmeListesi();
        }
        //TAB 3
        public void TransferListesi()
        {
            datagrid_Transfer.Rows.Clear();
            int adet = 0, sayac = 0;
            foreach (var tra in transfer.TransferListele())
            {
                if (tra.Onay.ToString() == "0")
                {
                    string[] row = { tra.TranferID.ToString(), tra.GondericiAdresi, tra.AliciAdresi, tra.CoinMiktari.ToString(), tra.IslemTarihi.ToString().Substring(0, 10), "Onay Bekliyor" };
                    datagrid_Transfer.Rows.Add(row);
                    adet++;
                }
                else
                {
                    string[] row = { tra.TranferID.ToString(), tra.GondericiAdresi, tra.AliciAdresi, tra.CoinMiktari.ToString(), tra.IslemTarihi.ToString().Substring(0, 10), "Onaylandı" };
                    datagrid_Transfer.Rows.Add(row);
                }
            }
            int[] onay_bekleyen = new int[adet];
            foreach (DataGridViewRow row in datagrid_Transfer.Rows)
            {
                if (row.Cells["onayDurumu"].Value.ToString() == "Onaylandı")
                {
                    row.Cells["onayDurumu"].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    row.Cells["onayDurumu"].Style.BackColor = Color.LightSalmon;
                    onay_bekleyen[sayac] = int.Parse(row.Cells[0].Value.ToString());
                    sayac++;
                }
            }
            lbl_OnayBekleyenSayisi.Text = string.Format("ONAY BEKLEYEN: {0}", adet);
            this.datagrid_Transfer.Sort(this.datagrid_Transfer.Columns["onayDurumu"], ListSortDirection.Ascending);

            datagrid_Transfer.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_Transfer.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_Transfer.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_Transfer.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_Transfer.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_Transfer.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            datagrid_Transfer.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_Transfer.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_Transfer.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_Transfer.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_Transfer.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_Transfer.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            datagrid_Transfer.ClearSelection();
        }
        private void btn_seciliTransfer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(datagrid_Transfer.CurrentRow.Cells[0].Value.ToString());
            var tra = transfer.TransferListele().Find(a => a.TranferID == id);
            if (transfer.TransferListele().Exists(x => (x.TranferID == id) && (x.Onay == '0')))
            {
                if (transfer.TransferGuncelle(tra.TranferID, DateTime.Now))
                {
                    kul.CuzdanOnay(tra.AliciAdresi, tra.CoinMiktari);
                    MessageBox.Show("İşlem başarılı");
                }
            }
            else
            {
                MessageBox.Show("Zaten onaylı!");
            }
            TransferListesi();
        }
        private void btn_transferOnayla_Click(object sender, EventArgs e)
        {
            if (transfer.TransferListele().Count(x => x.Onay == '0') > 0)
            {
                DialogResult secenek = MessageBox.Show("Tüm transferleri onaylıyor musunuz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    foreach (var onay in transfer.TransferListele().FindAll(x => (x.Onay == '0')))
                    {
                        if (transfer.TransferGuncelle(onay.TranferID, DateTime.Now))
                        {
                            kul.CuzdanOnay(onay.AliciAdresi, onay.CoinMiktari);
                        }
                    }
                    MessageBox.Show("İşlem başarılı");
                }
            }
            else
            {
                MessageBox.Show("Onay bekleyen herhangi bir transfer yok!");
            }
            TransferListesi();
        }
        //Genel
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
        private void tab_CoinInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagrid_Transfer.ClearSelection();
            dataGrid_Kullanicilar.ClearSelection();
        }

       
    }
}

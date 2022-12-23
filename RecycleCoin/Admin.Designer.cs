
namespace RecycleCoin
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.tab_CoinInfo = new System.Windows.Forms.TabControl();
            this.tab_List = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbl_cMiktar = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_rcMiktar = new System.Windows.Forms.Label();
            this.pic_cLogo = new System.Windows.Forms.PictureBox();
            this.pic_rcLogo = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_KulSil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.cmb_KullaniciTur = new System.Windows.Forms.ComboBox();
            this.txt_Arama = new System.Windows.Forms.TextBox();
            this.txt_Telefon = new System.Windows.Forms.TextBox();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.txt_Kulad = new System.Windows.Forms.TextBox();
            this.txt_Yas = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.dataGrid_Kullanicilar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onayDonusturme = new System.Windows.Forms.TabPage();
            this.btn_seciliDonusturme = new System.Windows.Forms.Button();
            this.lbl_onayBekleyen = new System.Windows.Forms.Label();
            this.btn_donusturOnayla = new System.Windows.Forms.Button();
            this.datagrid_Donusturme = new System.Windows.Forms.DataGridView();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donusturOnayDurumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Onay = new System.Windows.Forms.TabPage();
            this.btn_seciliTransfer = new System.Windows.Forms.Button();
            this.lbl_OnayBekleyenSayisi = new System.Windows.Forms.Label();
            this.btn_transferOnayla = new System.Windows.Forms.Button();
            this.datagrid_Transfer = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onayDurumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.btn_Oturum = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tab_CoinInfo.SuspendLayout();
            this.tab_List.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rcLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Kullanicilar)).BeginInit();
            this.onayDonusturme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Donusturme)).BeginInit();
            this.tab_Onay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Transfer)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_CoinInfo
            // 
            this.tab_CoinInfo.Controls.Add(this.tab_List);
            this.tab_CoinInfo.Controls.Add(this.onayDonusturme);
            this.tab_CoinInfo.Controls.Add(this.tab_Onay);
            this.tab_CoinInfo.Controls.Add(this.tabPage2);
            this.tab_CoinInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_CoinInfo.Location = new System.Drawing.Point(0, 0);
            this.tab_CoinInfo.Name = "tab_CoinInfo";
            this.tab_CoinInfo.SelectedIndex = 0;
            this.tab_CoinInfo.Size = new System.Drawing.Size(900, 600);
            this.tab_CoinInfo.TabIndex = 0;
            this.tab_CoinInfo.SelectedIndexChanged += new System.EventHandler(this.tab_CoinInfo_SelectedIndexChanged);
            // 
            // tab_List
            // 
            this.tab_List.BackColor = System.Drawing.Color.Transparent;
            this.tab_List.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tab_List.BackgroundImage")));
            this.tab_List.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_List.Controls.Add(this.panel1);
            this.tab_List.Controls.Add(this.label8);
            this.tab_List.Controls.Add(this.label7);
            this.tab_List.Controls.Add(this.label6);
            this.tab_List.Controls.Add(this.label5);
            this.tab_List.Controls.Add(this.label4);
            this.tab_List.Controls.Add(this.label3);
            this.tab_List.Controls.Add(this.label1);
            this.tab_List.Controls.Add(this.pictureBox1);
            this.tab_List.Controls.Add(this.btn_KulSil);
            this.tab_List.Controls.Add(this.btn_Guncelle);
            this.tab_List.Controls.Add(this.cmb_KullaniciTur);
            this.tab_List.Controls.Add(this.txt_Arama);
            this.tab_List.Controls.Add(this.txt_Telefon);
            this.tab_List.Controls.Add(this.txt_Mail);
            this.tab_List.Controls.Add(this.txt_Kulad);
            this.tab_List.Controls.Add(this.txt_Yas);
            this.tab_List.Controls.Add(this.txt_Soyad);
            this.tab_List.Controls.Add(this.txt_Ad);
            this.tab_List.Controls.Add(this.dataGrid_Kullanicilar);
            this.tab_List.Location = new System.Drawing.Point(4, 29);
            this.tab_List.Name = "tab_List";
            this.tab_List.Padding = new System.Windows.Forms.Padding(3);
            this.tab_List.Size = new System.Drawing.Size(892, 567);
            this.tab_List.TabIndex = 0;
            this.tab_List.Text = "Kullanıcı Listesi";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.pic_cLogo);
            this.panel1.Controls.Add(this.pic_rcLogo);
            this.panel1.Location = new System.Drawing.Point(636, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 251);
            this.panel1.TabIndex = 18;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.panel9.Controls.Add(this.lbl_cMiktar);
            this.panel9.Location = new System.Drawing.Point(76, 136);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(144, 50);
            this.panel9.TabIndex = 30;
            // 
            // lbl_cMiktar
            // 
            this.lbl_cMiktar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(181)))), ((int)(((byte)(138)))));
            this.lbl_cMiktar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_cMiktar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cMiktar.ForeColor = System.Drawing.Color.White;
            this.lbl_cMiktar.Location = new System.Drawing.Point(0, 0);
            this.lbl_cMiktar.Name = "lbl_cMiktar";
            this.lbl_cMiktar.Size = new System.Drawing.Size(144, 50);
            this.lbl_cMiktar.TabIndex = 16;
            this.lbl_cMiktar.Text = "0";
            this.lbl_cMiktar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.panel5.Controls.Add(this.lbl_rcMiktar);
            this.panel5.Location = new System.Drawing.Point(76, 68);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(144, 50);
            this.panel5.TabIndex = 29;
            // 
            // lbl_rcMiktar
            // 
            this.lbl_rcMiktar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.lbl_rcMiktar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_rcMiktar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_rcMiktar.ForeColor = System.Drawing.Color.White;
            this.lbl_rcMiktar.Location = new System.Drawing.Point(0, 0);
            this.lbl_rcMiktar.Name = "lbl_rcMiktar";
            this.lbl_rcMiktar.Size = new System.Drawing.Size(144, 50);
            this.lbl_rcMiktar.TabIndex = 17;
            this.lbl_rcMiktar.Text = "0,000";
            this.lbl_rcMiktar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_cLogo
            // 
            this.pic_cLogo.Image = ((System.Drawing.Image)(resources.GetObject("pic_cLogo.Image")));
            this.pic_cLogo.Location = new System.Drawing.Point(25, 136);
            this.pic_cLogo.Name = "pic_cLogo";
            this.pic_cLogo.Size = new System.Drawing.Size(50, 50);
            this.pic_cLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_cLogo.TabIndex = 28;
            this.pic_cLogo.TabStop = false;
            // 
            // pic_rcLogo
            // 
            this.pic_rcLogo.Image = ((System.Drawing.Image)(resources.GetObject("pic_rcLogo.Image")));
            this.pic_rcLogo.Location = new System.Drawing.Point(25, 68);
            this.pic_rcLogo.Name = "pic_rcLogo";
            this.pic_rcLogo.Size = new System.Drawing.Size(50, 50);
            this.pic_rcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_rcLogo.TabIndex = 27;
            this.pic_rcLogo.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "KULLANICI TÜRÜ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "E-POSTA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "KULLANICI ADI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "TELEFON NO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "YAŞ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "SOYAD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "AD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(272, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btn_KulSil
            // 
            this.btn_KulSil.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_KulSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_KulSil.Location = new System.Drawing.Point(484, 222);
            this.btn_KulSil.Name = "btn_KulSil";
            this.btn_KulSil.Size = new System.Drawing.Size(145, 36);
            this.btn_KulSil.TabIndex = 13;
            this.btn_KulSil.Text = "Sil";
            this.btn_KulSil.UseVisualStyleBackColor = false;
            this.btn_KulSil.Click += new System.EventHandler(this.btn_KulSil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Guncelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Guncelle.Location = new System.Drawing.Point(330, 222);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(145, 36);
            this.btn_Guncelle.TabIndex = 12;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // cmb_KullaniciTur
            // 
            this.cmb_KullaniciTur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_KullaniciTur.FormattingEnabled = true;
            this.cmb_KullaniciTur.Items.AddRange(new object[] {
            "Admin",
            "Sorumlu",
            "Kullanıcı"});
            this.cmb_KullaniciTur.Location = new System.Drawing.Point(329, 165);
            this.cmb_KullaniciTur.Name = "cmb_KullaniciTur";
            this.cmb_KullaniciTur.Size = new System.Drawing.Size(300, 36);
            this.cmb_KullaniciTur.TabIndex = 11;
            // 
            // txt_Arama
            // 
            this.txt_Arama.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Arama.Location = new System.Drawing.Point(8, 222);
            this.txt_Arama.Multiline = true;
            this.txt_Arama.Name = "txt_Arama";
            this.txt_Arama.PlaceholderText = "Kullanıcı Adı";
            this.txt_Arama.Size = new System.Drawing.Size(300, 36);
            this.txt_Arama.TabIndex = 9;
            this.txt_Arama.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Arama_MouseClick);
            this.txt_Arama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Arama_KeyDown);
            // 
            // txt_Telefon
            // 
            this.txt_Telefon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Telefon.Location = new System.Drawing.Point(89, 165);
            this.txt_Telefon.Multiline = true;
            this.txt_Telefon.Name = "txt_Telefon";
            this.txt_Telefon.PlaceholderText = "(+90)555 555 55 55";
            this.txt_Telefon.ReadOnly = true;
            this.txt_Telefon.Size = new System.Drawing.Size(219, 36);
            this.txt_Telefon.TabIndex = 6;
            // 
            // txt_Mail
            // 
            this.txt_Mail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Mail.Location = new System.Drawing.Point(329, 97);
            this.txt_Mail.Multiline = true;
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.PlaceholderText = "eposta@eposta.com";
            this.txt_Mail.ReadOnly = true;
            this.txt_Mail.Size = new System.Drawing.Size(300, 36);
            this.txt_Mail.TabIndex = 7;
            // 
            // txt_Kulad
            // 
            this.txt_Kulad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Kulad.Location = new System.Drawing.Point(329, 29);
            this.txt_Kulad.Multiline = true;
            this.txt_Kulad.Name = "txt_Kulad";
            this.txt_Kulad.PlaceholderText = "Kullanıcı adı";
            this.txt_Kulad.ReadOnly = true;
            this.txt_Kulad.Size = new System.Drawing.Size(300, 36);
            this.txt_Kulad.TabIndex = 8;
            // 
            // txt_Yas
            // 
            this.txt_Yas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Yas.Location = new System.Drawing.Point(8, 165);
            this.txt_Yas.Multiline = true;
            this.txt_Yas.Name = "txt_Yas";
            this.txt_Yas.PlaceholderText = "Yaş";
            this.txt_Yas.ReadOnly = true;
            this.txt_Yas.Size = new System.Drawing.Size(75, 36);
            this.txt_Yas.TabIndex = 2;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Soyad.Location = new System.Drawing.Point(8, 97);
            this.txt_Soyad.Multiline = true;
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.PlaceholderText = "Soyad";
            this.txt_Soyad.ReadOnly = true;
            this.txt_Soyad.Size = new System.Drawing.Size(300, 36);
            this.txt_Soyad.TabIndex = 2;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Ad.Location = new System.Drawing.Point(8, 29);
            this.txt_Ad.Multiline = true;
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.PlaceholderText = "Ad";
            this.txt_Ad.ReadOnly = true;
            this.txt_Ad.Size = new System.Drawing.Size(300, 36);
            this.txt_Ad.TabIndex = 2;
            // 
            // dataGrid_Kullanicilar
            // 
            this.dataGrid_Kullanicilar.AllowUserToAddRows = false;
            this.dataGrid_Kullanicilar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.dataGrid_Kullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Kullanicilar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGrid_Kullanicilar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGrid_Kullanicilar.Location = new System.Drawing.Point(3, 264);
            this.dataGrid_Kullanicilar.Name = "dataGrid_Kullanicilar";
            this.dataGrid_Kullanicilar.ReadOnly = true;
            this.dataGrid_Kullanicilar.RowHeadersVisible = false;
            this.dataGrid_Kullanicilar.RowHeadersWidth = 51;
            this.dataGrid_Kullanicilar.RowTemplate.Height = 29;
            this.dataGrid_Kullanicilar.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_Kullanicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Kullanicilar.Size = new System.Drawing.Size(886, 300);
            this.dataGrid_Kullanicilar.TabIndex = 0;
            this.dataGrid_Kullanicilar.SelectionChanged += new System.EventHandler(this.dataGrid_Kullanicilar_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "AD";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "SOYAD";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "YAŞ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "KULLANICI ADI";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "E-POSTA";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 175;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "TELEFON";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "YETKİ";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 75;
            // 
            // onayDonusturme
            // 
            this.onayDonusturme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("onayDonusturme.BackgroundImage")));
            this.onayDonusturme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.onayDonusturme.Controls.Add(this.btn_seciliDonusturme);
            this.onayDonusturme.Controls.Add(this.lbl_onayBekleyen);
            this.onayDonusturme.Controls.Add(this.btn_donusturOnayla);
            this.onayDonusturme.Controls.Add(this.datagrid_Donusturme);
            this.onayDonusturme.Location = new System.Drawing.Point(4, 29);
            this.onayDonusturme.Name = "onayDonusturme";
            this.onayDonusturme.Padding = new System.Windows.Forms.Padding(3);
            this.onayDonusturme.Size = new System.Drawing.Size(892, 567);
            this.onayDonusturme.TabIndex = 4;
            this.onayDonusturme.Text = "Dönüştürmeler";
            this.onayDonusturme.UseVisualStyleBackColor = true;
            // 
            // btn_seciliDonusturme
            // 
            this.btn_seciliDonusturme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(190)))), ((int)(((byte)(120)))));
            this.btn_seciliDonusturme.FlatAppearance.BorderSize = 0;
            this.btn_seciliDonusturme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seciliDonusturme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_seciliDonusturme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.btn_seciliDonusturme.Location = new System.Drawing.Point(330, 6);
            this.btn_seciliDonusturme.Name = "btn_seciliDonusturme";
            this.btn_seciliDonusturme.Size = new System.Drawing.Size(233, 52);
            this.btn_seciliDonusturme.TabIndex = 113;
            this.btn_seciliDonusturme.Text = "SEÇİLİ OLANI ONAYLA";
            this.btn_seciliDonusturme.UseVisualStyleBackColor = false;
            this.btn_seciliDonusturme.Click += new System.EventHandler(this.btn_seciliDonusturme_Click);
            // 
            // lbl_onayBekleyen
            // 
            this.lbl_onayBekleyen.AutoSize = true;
            this.lbl_onayBekleyen.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_onayBekleyen.Location = new System.Drawing.Point(3, 16);
            this.lbl_onayBekleyen.Name = "lbl_onayBekleyen";
            this.lbl_onayBekleyen.Size = new System.Drawing.Size(245, 30);
            this.lbl_onayBekleyen.TabIndex = 112;
            this.lbl_onayBekleyen.Text = "ONAY BEKLEYEN: 12";
            // 
            // btn_donusturOnayla
            // 
            this.btn_donusturOnayla.BackColor = System.Drawing.Color.Salmon;
            this.btn_donusturOnayla.FlatAppearance.BorderSize = 0;
            this.btn_donusturOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_donusturOnayla.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_donusturOnayla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.btn_donusturOnayla.Location = new System.Drawing.Point(569, 6);
            this.btn_donusturOnayla.Name = "btn_donusturOnayla";
            this.btn_donusturOnayla.Size = new System.Drawing.Size(320, 52);
            this.btn_donusturOnayla.TabIndex = 111;
            this.btn_donusturOnayla.Text = "TÜMÜNÜ ONAYLA";
            this.btn_donusturOnayla.UseVisualStyleBackColor = false;
            this.btn_donusturOnayla.Click += new System.EventHandler(this.btn_donusturOnayla_Click);
            // 
            // datagrid_Donusturme
            // 
            this.datagrid_Donusturme.AllowUserToAddRows = false;
            this.datagrid_Donusturme.BackgroundColor = System.Drawing.Color.White;
            this.datagrid_Donusturme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Donusturme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.donusturOnayDurumu});
            this.datagrid_Donusturme.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datagrid_Donusturme.Location = new System.Drawing.Point(3, 64);
            this.datagrid_Donusturme.Name = "datagrid_Donusturme";
            this.datagrid_Donusturme.RowHeadersVisible = false;
            this.datagrid_Donusturme.RowHeadersWidth = 51;
            this.datagrid_Donusturme.RowTemplate.Height = 29;
            this.datagrid_Donusturme.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_Donusturme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_Donusturme.Size = new System.Drawing.Size(886, 500);
            this.datagrid_Donusturme.TabIndex = 110;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "ID";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Width = 50;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Kullanıcı Kimlik";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.Width = 250;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Karbon";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.Width = 125;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Recycle Coin";
            this.Column16.MinimumWidth = 6;
            this.Column16.Name = "Column16";
            this.Column16.Width = 125;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "İstek Tarihi";
            this.Column17.MinimumWidth = 6;
            this.Column17.Name = "Column17";
            this.Column17.Width = 125;
            // 
            // donusturOnayDurumu
            // 
            this.donusturOnayDurumu.HeaderText = "Onay Durumu";
            this.donusturOnayDurumu.MinimumWidth = 6;
            this.donusturOnayDurumu.Name = "donusturOnayDurumu";
            this.donusturOnayDurumu.Width = 200;
            // 
            // tab_Onay
            // 
            this.tab_Onay.BackColor = System.Drawing.Color.Transparent;
            this.tab_Onay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tab_Onay.BackgroundImage")));
            this.tab_Onay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_Onay.Controls.Add(this.btn_seciliTransfer);
            this.tab_Onay.Controls.Add(this.lbl_OnayBekleyenSayisi);
            this.tab_Onay.Controls.Add(this.btn_transferOnayla);
            this.tab_Onay.Controls.Add(this.datagrid_Transfer);
            this.tab_Onay.Location = new System.Drawing.Point(4, 29);
            this.tab_Onay.Name = "tab_Onay";
            this.tab_Onay.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Onay.Size = new System.Drawing.Size(892, 567);
            this.tab_Onay.TabIndex = 1;
            this.tab_Onay.Text = "Transferler";
            // 
            // btn_seciliTransfer
            // 
            this.btn_seciliTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(190)))), ((int)(((byte)(120)))));
            this.btn_seciliTransfer.FlatAppearance.BorderSize = 0;
            this.btn_seciliTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seciliTransfer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_seciliTransfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.btn_seciliTransfer.Location = new System.Drawing.Point(330, 6);
            this.btn_seciliTransfer.Name = "btn_seciliTransfer";
            this.btn_seciliTransfer.Size = new System.Drawing.Size(233, 52);
            this.btn_seciliTransfer.TabIndex = 112;
            this.btn_seciliTransfer.Text = "SEÇİLİ OLANI ONAYLA";
            this.btn_seciliTransfer.UseVisualStyleBackColor = false;
            this.btn_seciliTransfer.Click += new System.EventHandler(this.btn_seciliTransfer_Click);
            // 
            // lbl_OnayBekleyenSayisi
            // 
            this.lbl_OnayBekleyenSayisi.AutoSize = true;
            this.lbl_OnayBekleyenSayisi.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_OnayBekleyenSayisi.Location = new System.Drawing.Point(3, 16);
            this.lbl_OnayBekleyenSayisi.Name = "lbl_OnayBekleyenSayisi";
            this.lbl_OnayBekleyenSayisi.Size = new System.Drawing.Size(245, 30);
            this.lbl_OnayBekleyenSayisi.TabIndex = 109;
            this.lbl_OnayBekleyenSayisi.Text = "ONAY BEKLEYEN: 12";
            // 
            // btn_transferOnayla
            // 
            this.btn_transferOnayla.BackColor = System.Drawing.Color.Salmon;
            this.btn_transferOnayla.FlatAppearance.BorderSize = 0;
            this.btn_transferOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_transferOnayla.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_transferOnayla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.btn_transferOnayla.Location = new System.Drawing.Point(569, 6);
            this.btn_transferOnayla.Name = "btn_transferOnayla";
            this.btn_transferOnayla.Size = new System.Drawing.Size(320, 52);
            this.btn_transferOnayla.TabIndex = 108;
            this.btn_transferOnayla.Text = "TÜMÜNÜ ONAYLA";
            this.btn_transferOnayla.UseVisualStyleBackColor = false;
            this.btn_transferOnayla.Click += new System.EventHandler(this.btn_transferOnayla_Click);
            // 
            // datagrid_Transfer
            // 
            this.datagrid_Transfer.AllowUserToAddRows = false;
            this.datagrid_Transfer.BackgroundColor = System.Drawing.Color.White;
            this.datagrid_Transfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Transfer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.onayDurumu});
            this.datagrid_Transfer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datagrid_Transfer.Location = new System.Drawing.Point(3, 64);
            this.datagrid_Transfer.Name = "datagrid_Transfer";
            this.datagrid_Transfer.RowHeadersVisible = false;
            this.datagrid_Transfer.RowHeadersWidth = 51;
            this.datagrid_Transfer.RowTemplate.Height = 29;
            this.datagrid_Transfer.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_Transfer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_Transfer.Size = new System.Drawing.Size(886, 500);
            this.datagrid_Transfer.TabIndex = 13;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ID";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 50;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Gönderici";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 225;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Alıcı";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 225;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Tutar";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "İşlem Tarihi";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // onayDurumu
            // 
            this.onayDurumu.HeaderText = "Onay Durumu";
            this.onayDurumu.MinimumWidth = 6;
            this.onayDurumu.Name = "onayDurumu";
            this.onayDurumu.Width = 150;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.btn_Cikis);
            this.tabPage2.Controls.Add(this.btn_Oturum);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(892, 567);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "ÇIKIŞ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btn_Cikis.FlatAppearance.BorderSize = 0;
            this.btn_Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cikis.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cikis.ForeColor = System.Drawing.Color.White;
            this.btn_Cikis.Location = new System.Drawing.Point(246, 293);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(400, 80);
            this.btn_Cikis.TabIndex = 7;
            this.btn_Cikis.Text = "ÇIKIŞ";
            this.btn_Cikis.UseVisualStyleBackColor = false;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // btn_Oturum
            // 
            this.btn_Oturum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btn_Oturum.FlatAppearance.BorderSize = 0;
            this.btn_Oturum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Oturum.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Oturum.ForeColor = System.Drawing.Color.White;
            this.btn_Oturum.Location = new System.Drawing.Point(246, 193);
            this.btn_Oturum.Name = "btn_Oturum";
            this.btn_Oturum.Size = new System.Drawing.Size(400, 80);
            this.btn_Oturum.TabIndex = 8;
            this.btn_Oturum.Text = "OTURUMU KAPAT";
            this.btn_Oturum.UseVisualStyleBackColor = false;
            this.btn_Oturum.Click += new System.EventHandler(this.btn_Oturum_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.tab_CoinInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Admin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Admin_MouseMove);
            this.tab_CoinInfo.ResumeLayout(false);
            this.tab_List.ResumeLayout(false);
            this.tab_List.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_cLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rcLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Kullanicilar)).EndInit();
            this.onayDonusturme.ResumeLayout(false);
            this.onayDonusturme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Donusturme)).EndInit();
            this.tab_Onay.ResumeLayout(false);
            this.tab_Onay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Transfer)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_CoinInfo;
        private System.Windows.Forms.TabPage tab_List;
        private System.Windows.Forms.TextBox txt_Yas;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.DataGridView dataGrid_Kullanicilar;
        private System.Windows.Forms.TabPage tab_Onay;
        private System.Windows.Forms.TextBox txt_Arama;
        private System.Windows.Forms.TextBox txt_Telefon;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.TextBox txt_Kulad;
        private System.Windows.Forms.ComboBox cmb_KullaniciTur;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_KulSil;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView datagrid_Transfer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Cikis;
        private System.Windows.Forms.Button btn_Oturum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn onayDurumu;
        private System.Windows.Forms.Button btn_transferOnayla;
        private System.Windows.Forms.Label lbl_OnayBekleyenSayisi;
        private System.Windows.Forms.TabPage onayDonusturme;
        private System.Windows.Forms.Label lbl_onayBekleyen;
        private System.Windows.Forms.Button btn_donusturOnayla;
        private System.Windows.Forms.DataGridView datagrid_Donusturme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn donusturOnayDurumu;
        private System.Windows.Forms.Button btn_seciliTransfer;
        private System.Windows.Forms.Button btn_seciliDonusturme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_rcLogo;
        private System.Windows.Forms.PictureBox pic_cLogo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_rcMiktar;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lbl_cMiktar;
    }
}
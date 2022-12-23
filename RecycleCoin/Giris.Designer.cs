
namespace RecycleCoin
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.link_sifre = new System.Windows.Forms.LinkLabel();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_girisKulad = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_girisSifre = new System.Windows.Forms.TextBox();
            this.link_kayit = new System.Windows.Forms.LinkLabel();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.link_sifre);
            this.panel1.Controls.Add(this.btn_Giris);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(75, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 500);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(107, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 111;
            this.label1.Text = "Şifremi Unuttum?";
            // 
            // link_sifre
            // 
            this.link_sifre.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.link_sifre.AutoSize = true;
            this.link_sifre.BackColor = System.Drawing.Color.Transparent;
            this.link_sifre.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.link_sifre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.link_sifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.link_sifre.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.link_sifre.Location = new System.Drawing.Point(228, 463);
            this.link_sifre.Name = "link_sifre";
            this.link_sifre.Size = new System.Drawing.Size(89, 20);
            this.link_sifre.TabIndex = 108;
            this.link_sifre.TabStop = true;
            this.link_sifre.Text = "Buraya Tıkla";
            this.link_sifre.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.link_sifre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_sifre_LinkClicked);
            // 
            // btn_Giris
            // 
            this.btn_Giris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(19)))));
            this.btn_Giris.FlatAppearance.BorderSize = 0;
            this.btn_Giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Giris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Giris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.btn_Giris.Location = new System.Drawing.Point(65, 398);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(320, 52);
            this.btn_Giris.TabIndex = 107;
            this.btn_Giris.Text = "GİRİŞ";
            this.btn_Giris.UseVisualStyleBackColor = false;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            this.btn_Giris.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Giris_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.txt_girisKulad);
            this.panel2.Location = new System.Drawing.Point(35, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 60);
            this.panel2.TabIndex = 109;
            this.panel2.TabStop = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(60, 60);
            this.panel4.TabIndex = 0;
            this.panel4.TabStop = true;
            // 
            // txt_girisKulad
            // 
            this.txt_girisKulad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.txt_girisKulad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_girisKulad.Font = new System.Drawing.Font("Yu Gothic UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_girisKulad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.txt_girisKulad.Location = new System.Drawing.Point(72, 13);
            this.txt_girisKulad.MaxLength = 20;
            this.txt_girisKulad.Multiline = true;
            this.txt_girisKulad.Name = "txt_girisKulad";
            this.txt_girisKulad.PlaceholderText = "Username";
            this.txt_girisKulad.Size = new System.Drawing.Size(275, 34);
            this.txt_girisKulad.TabIndex = 105;
            this.txt_girisKulad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_girisKulad_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.txt_girisSifre);
            this.panel3.Location = new System.Drawing.Point(35, 311);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 60);
            this.panel3.TabIndex = 110;
            this.panel3.TabStop = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(60, 60);
            this.panel5.TabIndex = 0;
            this.panel5.TabStop = true;
            // 
            // txt_girisSifre
            // 
            this.txt_girisSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.txt_girisSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_girisSifre.Font = new System.Drawing.Font("Yu Gothic UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_girisSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.txt_girisSifre.Location = new System.Drawing.Point(72, 13);
            this.txt_girisSifre.MaxLength = 25;
            this.txt_girisSifre.Multiline = true;
            this.txt_girisSifre.Name = "txt_girisSifre";
            this.txt_girisSifre.PasswordChar = '*';
            this.txt_girisSifre.PlaceholderText = "Password";
            this.txt_girisSifre.Size = new System.Drawing.Size(275, 34);
            this.txt_girisSifre.TabIndex = 106;
            this.txt_girisSifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_girisSifre_KeyDown);
            // 
            // link_kayit
            // 
            this.link_kayit.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.link_kayit.AutoSize = true;
            this.link_kayit.BackColor = System.Drawing.Color.Transparent;
            this.link_kayit.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.link_kayit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.link_kayit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.link_kayit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.link_kayit.Location = new System.Drawing.Point(267, 603);
            this.link_kayit.Name = "link_kayit";
            this.link_kayit.Size = new System.Drawing.Size(66, 23);
            this.link_kayit.TabIndex = 109;
            this.link_kayit.TabStop = true;
            this.link_kayit.Text = "Kayıt ol";
            this.link_kayit.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.link_kayit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_kayit_LinkClicked);
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cikis.BackgroundImage")));
            this.btn_Cikis.FlatAppearance.BorderSize = 0;
            this.btn_Cikis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Cikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cikis.Location = new System.Drawing.Point(548, 12);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(40, 40);
            this.btn_Cikis.TabIndex = 110;
            this.btn_Cikis.UseVisualStyleBackColor = false;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(181)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(600, 700);
            this.Controls.Add(this.btn_Cikis);
            this.Controls.Add(this.link_kayit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Giris_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Giris_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Giris_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_girisKulad;
        private System.Windows.Forms.TextBox txt_girisSifre;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.LinkLabel link_sifre;
        private System.Windows.Forms.LinkLabel link_kayit;
        private System.Windows.Forms.Button btn_Cikis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
    }
}
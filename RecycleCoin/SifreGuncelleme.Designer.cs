
namespace RecycleCoin
{
    partial class SifreGuncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreGuncelleme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_YeniSifreOnay = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_YeniSifre = new System.Windows.Forms.TextBox();
            this.btn_ac = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Kulad = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Guncelle);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ŞİFRE SIFIRLAMA";
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(19)))));
            this.btn_Guncelle.FlatAppearance.BorderSize = 0;
            this.btn_Guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Guncelle.Location = new System.Drawing.Point(134, 220);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(183, 40);
            this.btn_Guncelle.TabIndex = 30;
            this.btn_Guncelle.Text = "SIFIRLA";
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txt_YeniSifreOnay);
            this.panel3.Location = new System.Drawing.Point(74, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 40);
            this.panel3.TabIndex = 29;
            // 
            // txt_YeniSifreOnay
            // 
            this.txt_YeniSifreOnay.BackColor = System.Drawing.Color.White;
            this.txt_YeniSifreOnay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_YeniSifreOnay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_YeniSifreOnay.Location = new System.Drawing.Point(25, 3);
            this.txt_YeniSifreOnay.MaxLength = 50;
            this.txt_YeniSifreOnay.Multiline = true;
            this.txt_YeniSifreOnay.Name = "txt_YeniSifreOnay";
            this.txt_YeniSifreOnay.PlaceholderText = "Yeni Şifre Tekrar";
            this.txt_YeniSifreOnay.Size = new System.Drawing.Size(230, 34);
            this.txt_YeniSifreOnay.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txt_YeniSifre);
            this.panel2.Controls.Add(this.btn_ac);
            this.panel2.Controls.Add(this.btn_kapat);
            this.panel2.Location = new System.Drawing.Point(74, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 40);
            this.panel2.TabIndex = 29;
            // 
            // txt_YeniSifre
            // 
            this.txt_YeniSifre.BackColor = System.Drawing.Color.White;
            this.txt_YeniSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_YeniSifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_YeniSifre.Location = new System.Drawing.Point(25, 3);
            this.txt_YeniSifre.MaxLength = 50;
            this.txt_YeniSifre.Multiline = true;
            this.txt_YeniSifre.Name = "txt_YeniSifre";
            this.txt_YeniSifre.PlaceholderText = "Yeni Şifre";
            this.txt_YeniSifre.Size = new System.Drawing.Size(230, 34);
            this.txt_YeniSifre.TabIndex = 1;
            // 
            // btn_ac
            // 
            this.btn_ac.BackColor = System.Drawing.Color.Transparent;
            this.btn_ac.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ac.BackgroundImage")));
            this.btn_ac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ac.FlatAppearance.BorderSize = 0;
            this.btn_ac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ac.Location = new System.Drawing.Point(263, 3);
            this.btn_ac.Name = "btn_ac";
            this.btn_ac.Size = new System.Drawing.Size(34, 34);
            this.btn_ac.TabIndex = 27;
            this.btn_ac.UseVisualStyleBackColor = false;
            this.btn_ac.Click += new System.EventHandler(this.btn_ac_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Transparent;
            this.btn_kapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kapat.BackgroundImage")));
            this.btn_kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Location = new System.Drawing.Point(263, 3);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(34, 34);
            this.btn_kapat.TabIndex = 28;
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_Kulad);
            this.panel1.Location = new System.Drawing.Point(74, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 40);
            this.panel1.TabIndex = 29;
            // 
            // txt_Kulad
            // 
            this.txt_Kulad.BackColor = System.Drawing.Color.White;
            this.txt_Kulad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Kulad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Kulad.Location = new System.Drawing.Point(25, 3);
            this.txt_Kulad.MaxLength = 50;
            this.txt_Kulad.Multiline = true;
            this.txt_Kulad.Name = "txt_Kulad";
            this.txt_Kulad.PlaceholderText = "Kullanıcı Adı";
            this.txt_Kulad.Size = new System.Drawing.Size(250, 34);
            this.txt_Kulad.TabIndex = 1;
            // 
            // SifreGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SifreGuncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifreGuncelleme";
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ac;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_YeniSifreOnay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_YeniSifre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Kulad;
        private System.Windows.Forms.Button btn_Guncelle;
    }
}
namespace Store_Manager
{
    partial class KayıtOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayıtOl));
            this.panelÜst = new System.Windows.Forms.Panel();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.picBoxAyarlar = new System.Windows.Forms.PictureBox();
            this.lblKayıtOl = new System.Windows.Forms.Label();
            this.picBoxÇıkış = new System.Windows.Forms.PictureBox();
            this.panelAlt = new System.Windows.Forms.Panel();
            this.progressBarYükleme = new System.Windows.Forms.ProgressBar();
            this.txtBoxŞifre = new System.Windows.Forms.TextBox();
            this.txtBoxKulAdı = new System.Windows.Forms.TextBox();
            this.txtBoxŞifreTekrar = new System.Windows.Forms.TextBox();
            this.radBtnYönetici = new System.Windows.Forms.RadioButton();
            this.radBtnÇalışan = new System.Windows.Forms.RadioButton();
            this.btnKayıtOl = new System.Windows.Forms.Button();
            this.txtBoxAd = new System.Windows.Forms.TextBox();
            this.txtBoxSoyad = new System.Windows.Forms.TextBox();
            this.txtBoxTCKimlikNo = new System.Windows.Forms.TextBox();
            this.txtBoxAdres = new System.Windows.Forms.TextBox();
            this.txtBoxTelNo = new System.Windows.Forms.TextBox();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.timerZaman = new System.Windows.Forms.Timer(this.components);
            this.Açıklama = new System.Windows.Forms.ToolTip(this.components);
            this.panelÜst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAyarlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxÇıkış)).BeginInit();
            this.panelAlt.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelÜst
            // 
            this.panelÜst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelÜst.Controls.Add(this.picBoxLogo);
            this.panelÜst.Controls.Add(this.picBoxAyarlar);
            this.panelÜst.Controls.Add(this.lblKayıtOl);
            this.panelÜst.Controls.Add(this.picBoxÇıkış);
            this.panelÜst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelÜst.Location = new System.Drawing.Point(0, 0);
            this.panelÜst.Name = "panelÜst";
            this.panelÜst.Size = new System.Drawing.Size(400, 85);
            this.panelÜst.TabIndex = 1;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(80, 12);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(63, 63);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 4;
            this.picBoxLogo.TabStop = false;
            // 
            // picBoxAyarlar
            // 
            this.picBoxAyarlar.Image = global::Store_Manager.Properties.Resources.Ayarlar;
            this.picBoxAyarlar.Location = new System.Drawing.Point(338, 3);
            this.picBoxAyarlar.Name = "picBoxAyarlar";
            this.picBoxAyarlar.Size = new System.Drawing.Size(29, 32);
            this.picBoxAyarlar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAyarlar.TabIndex = 3;
            this.picBoxAyarlar.TabStop = false;
            this.picBoxAyarlar.Click += new System.EventHandler(this.picBoxAyarlar_Click);
            // 
            // lblKayıtOl
            // 
            this.lblKayıtOl.AutoSize = true;
            this.lblKayıtOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblKayıtOl.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayıtOl.ForeColor = System.Drawing.SystemColors.Window;
            this.lblKayıtOl.Location = new System.Drawing.Point(149, 19);
            this.lblKayıtOl.Name = "lblKayıtOl";
            this.lblKayıtOl.Size = new System.Drawing.Size(144, 46);
            this.lblKayıtOl.TabIndex = 1;
            this.lblKayıtOl.Text = "Kayıt Ol";
            this.lblKayıtOl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBoxÇıkış
            // 
            this.picBoxÇıkış.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.picBoxÇıkış.Image = global::Store_Manager.Properties.Resources.Çıkış;
            this.picBoxÇıkış.Location = new System.Drawing.Point(368, 3);
            this.picBoxÇıkış.Name = "picBoxÇıkış";
            this.picBoxÇıkış.Size = new System.Drawing.Size(32, 32);
            this.picBoxÇıkış.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxÇıkış.TabIndex = 2;
            this.picBoxÇıkış.TabStop = false;
            this.picBoxÇıkış.Click += new System.EventHandler(this.picBoxÇıkış_Click);
            // 
            // panelAlt
            // 
            this.panelAlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelAlt.Controls.Add(this.progressBarYükleme);
            this.panelAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAlt.Location = new System.Drawing.Point(0, 509);
            this.panelAlt.Name = "panelAlt";
            this.panelAlt.Size = new System.Drawing.Size(400, 56);
            this.panelAlt.TabIndex = 2;
            // 
            // progressBarYükleme
            // 
            this.progressBarYükleme.BackColor = System.Drawing.SystemColors.Window;
            this.progressBarYükleme.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBarYükleme.Location = new System.Drawing.Point(12, 19);
            this.progressBarYükleme.Name = "progressBarYükleme";
            this.progressBarYükleme.Size = new System.Drawing.Size(376, 24);
            this.progressBarYükleme.TabIndex = 14;
            this.progressBarYükleme.Visible = false;
            // 
            // txtBoxŞifre
            // 
            this.txtBoxŞifre.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxŞifre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxŞifre.Location = new System.Drawing.Point(53, 133);
            this.txtBoxŞifre.MaxLength = 15;
            this.txtBoxŞifre.Multiline = true;
            this.txtBoxŞifre.Name = "txtBoxŞifre";
            this.txtBoxŞifre.Size = new System.Drawing.Size(303, 27);
            this.txtBoxŞifre.TabIndex = 2;
            this.txtBoxŞifre.Text = "Şifre";
            this.txtBoxŞifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxŞifre.Click += new System.EventHandler(this.txtBoxŞifre_Click);
            // 
            // txtBoxKulAdı
            // 
            this.txtBoxKulAdı.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxKulAdı.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxKulAdı.Location = new System.Drawing.Point(53, 100);
            this.txtBoxKulAdı.MaxLength = 15;
            this.txtBoxKulAdı.Multiline = true;
            this.txtBoxKulAdı.Name = "txtBoxKulAdı";
            this.txtBoxKulAdı.Size = new System.Drawing.Size(303, 27);
            this.txtBoxKulAdı.TabIndex = 1;
            this.txtBoxKulAdı.Text = "Kullanıcı Adı";
            this.txtBoxKulAdı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxKulAdı.Click += new System.EventHandler(this.txtBoxKulAdı_Click);
            this.txtBoxKulAdı.Leave += new System.EventHandler(this.txtBoxKulAdı_Leave);
            // 
            // txtBoxŞifreTekrar
            // 
            this.txtBoxŞifreTekrar.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxŞifreTekrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxŞifreTekrar.Location = new System.Drawing.Point(53, 166);
            this.txtBoxŞifreTekrar.MaxLength = 15;
            this.txtBoxŞifreTekrar.Multiline = true;
            this.txtBoxŞifreTekrar.Name = "txtBoxŞifreTekrar";
            this.txtBoxŞifreTekrar.Size = new System.Drawing.Size(303, 27);
            this.txtBoxŞifreTekrar.TabIndex = 3;
            this.txtBoxŞifreTekrar.Text = "Şifre Tekrar";
            this.txtBoxŞifreTekrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxŞifreTekrar.Click += new System.EventHandler(this.txtBoxŞifreTekrar_Click);
            // 
            // radBtnYönetici
            // 
            this.radBtnYönetici.AutoSize = true;
            this.radBtnYönetici.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radBtnYönetici.ForeColor = System.Drawing.SystemColors.Window;
            this.radBtnYönetici.Location = new System.Drawing.Point(260, 418);
            this.radBtnYönetici.Name = "radBtnYönetici";
            this.radBtnYönetici.Size = new System.Drawing.Size(96, 28);
            this.radBtnYönetici.TabIndex = 12;
            this.radBtnYönetici.TabStop = true;
            this.radBtnYönetici.Text = "Yönetici";
            this.radBtnYönetici.UseVisualStyleBackColor = true;
            this.radBtnYönetici.CheckedChanged += new System.EventHandler(this.radBtnYönetici_CheckedChanged);
            // 
            // radBtnÇalışan
            // 
            this.radBtnÇalışan.AutoSize = true;
            this.radBtnÇalışan.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radBtnÇalışan.ForeColor = System.Drawing.SystemColors.Window;
            this.radBtnÇalışan.Location = new System.Drawing.Point(53, 418);
            this.radBtnÇalışan.Name = "radBtnÇalışan";
            this.radBtnÇalışan.Size = new System.Drawing.Size(85, 28);
            this.radBtnÇalışan.TabIndex = 11;
            this.radBtnÇalışan.TabStop = true;
            this.radBtnÇalışan.Text = "Çalışan";
            this.radBtnÇalışan.UseVisualStyleBackColor = true;
            this.radBtnÇalışan.CheckedChanged += new System.EventHandler(this.radBtnÇalışan_CheckedChanged);
            // 
            // btnKayıtOl
            // 
            this.btnKayıtOl.BackColor = System.Drawing.SystemColors.Window;
            this.btnKayıtOl.FlatAppearance.BorderSize = 0;
            this.btnKayıtOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayıtOl.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayıtOl.ForeColor = System.Drawing.Color.Black;
            this.btnKayıtOl.Location = new System.Drawing.Point(53, 452);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(303, 41);
            this.btnKayıtOl.TabIndex = 13;
            this.btnKayıtOl.Text = "Kayıt Ol";
            this.btnKayıtOl.UseVisualStyleBackColor = false;
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKayıtOl_Click);
            // 
            // txtBoxAd
            // 
            this.txtBoxAd.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxAd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxAd.Location = new System.Drawing.Point(53, 199);
            this.txtBoxAd.MaxLength = 15;
            this.txtBoxAd.Multiline = true;
            this.txtBoxAd.Name = "txtBoxAd";
            this.txtBoxAd.Size = new System.Drawing.Size(303, 27);
            this.txtBoxAd.TabIndex = 4;
            this.txtBoxAd.Text = "Adı";
            this.txtBoxAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxAd.Click += new System.EventHandler(this.txtBoxAd_Click);
            this.txtBoxAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxAd_KeyPress);
            // 
            // txtBoxSoyad
            // 
            this.txtBoxSoyad.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxSoyad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxSoyad.Location = new System.Drawing.Point(53, 232);
            this.txtBoxSoyad.MaxLength = 15;
            this.txtBoxSoyad.Multiline = true;
            this.txtBoxSoyad.Name = "txtBoxSoyad";
            this.txtBoxSoyad.Size = new System.Drawing.Size(303, 27);
            this.txtBoxSoyad.TabIndex = 5;
            this.txtBoxSoyad.Text = "Soyadı";
            this.txtBoxSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxSoyad.Click += new System.EventHandler(this.txtBoxSoyad_Click);
            this.txtBoxSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSoyad_KeyPress);
            // 
            // txtBoxTCKimlikNo
            // 
            this.txtBoxTCKimlikNo.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxTCKimlikNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxTCKimlikNo.Location = new System.Drawing.Point(53, 265);
            this.txtBoxTCKimlikNo.MaxLength = 11;
            this.txtBoxTCKimlikNo.Multiline = true;
            this.txtBoxTCKimlikNo.Name = "txtBoxTCKimlikNo";
            this.txtBoxTCKimlikNo.Size = new System.Drawing.Size(303, 27);
            this.txtBoxTCKimlikNo.TabIndex = 6;
            this.txtBoxTCKimlikNo.Text = "TC Kimlik Numarası";
            this.txtBoxTCKimlikNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxTCKimlikNo.Click += new System.EventHandler(this.txtBoxTCKimlikNo_Click);
            this.txtBoxTCKimlikNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTCKimlikNo_KeyPress);
            // 
            // txtBoxAdres
            // 
            this.txtBoxAdres.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxAdres.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxAdres.Location = new System.Drawing.Point(53, 364);
            this.txtBoxAdres.MaxLength = 15;
            this.txtBoxAdres.Multiline = true;
            this.txtBoxAdres.Name = "txtBoxAdres";
            this.txtBoxAdres.Size = new System.Drawing.Size(303, 52);
            this.txtBoxAdres.TabIndex = 9;
            this.txtBoxAdres.Text = "Adres";
            this.txtBoxAdres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxAdres.Click += new System.EventHandler(this.txtBoxAdres_Click);
            // 
            // txtBoxTelNo
            // 
            this.txtBoxTelNo.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxTelNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxTelNo.Location = new System.Drawing.Point(53, 298);
            this.txtBoxTelNo.MaxLength = 10;
            this.txtBoxTelNo.Multiline = true;
            this.txtBoxTelNo.Name = "txtBoxTelNo";
            this.txtBoxTelNo.Size = new System.Drawing.Size(303, 27);
            this.txtBoxTelNo.TabIndex = 7;
            this.txtBoxTelNo.Text = "Telefon Numarası";
            this.txtBoxTelNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxTelNo.Click += new System.EventHandler(this.txtBoxTelNo_Click);
            this.txtBoxTelNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTelNo_KeyPress);
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxMail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxMail.Location = new System.Drawing.Point(53, 331);
            this.txtBoxMail.MaxLength = 30;
            this.txtBoxMail.Multiline = true;
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(303, 27);
            this.txtBoxMail.TabIndex = 8;
            this.txtBoxMail.Text = "E - Mail";
            this.txtBoxMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxMail.Click += new System.EventHandler(this.txtBoxMail_Click);
            // 
            // timerZaman
            // 
            this.timerZaman.Tick += new System.EventHandler(this.timerZaman_Tick);
            // 
            // KayıtOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(400, 565);
            this.Controls.Add(this.txtBoxMail);
            this.Controls.Add(this.txtBoxTelNo);
            this.Controls.Add(this.txtBoxAdres);
            this.Controls.Add(this.txtBoxTCKimlikNo);
            this.Controls.Add(this.txtBoxSoyad);
            this.Controls.Add(this.txtBoxAd);
            this.Controls.Add(this.radBtnYönetici);
            this.Controls.Add(this.radBtnÇalışan);
            this.Controls.Add(this.btnKayıtOl);
            this.Controls.Add(this.txtBoxŞifreTekrar);
            this.Controls.Add(this.txtBoxŞifre);
            this.Controls.Add(this.panelAlt);
            this.Controls.Add(this.txtBoxKulAdı);
            this.Controls.Add(this.panelÜst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KayıtOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayıtOl";
            this.Activated += new System.EventHandler(this.KayıtOl_Activated);
            this.Load += new System.EventHandler(this.KayıtOl_Load);
            this.panelÜst.ResumeLayout(false);
            this.panelÜst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAyarlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxÇıkış)).EndInit();
            this.panelAlt.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelÜst;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.PictureBox picBoxAyarlar;
        private System.Windows.Forms.Label lblKayıtOl;
        private System.Windows.Forms.PictureBox picBoxÇıkış;
        private System.Windows.Forms.Panel panelAlt;
        private System.Windows.Forms.ProgressBar progressBarYükleme;
        private System.Windows.Forms.TextBox txtBoxŞifre;
        private System.Windows.Forms.TextBox txtBoxKulAdı;
        private System.Windows.Forms.TextBox txtBoxŞifreTekrar;
        private System.Windows.Forms.RadioButton radBtnYönetici;
        private System.Windows.Forms.RadioButton radBtnÇalışan;
        private System.Windows.Forms.Button btnKayıtOl;
        private System.Windows.Forms.TextBox txtBoxAd;
        private System.Windows.Forms.TextBox txtBoxSoyad;
        private System.Windows.Forms.TextBox txtBoxTCKimlikNo;
        private System.Windows.Forms.TextBox txtBoxAdres;
        private System.Windows.Forms.TextBox txtBoxTelNo;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.Timer timerZaman;
        private System.Windows.Forms.ToolTip Açıklama;
    }
}
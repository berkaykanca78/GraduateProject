namespace Store_Manager
{
    partial class OturumAç
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OturumAç));
            this.panelÜst = new System.Windows.Forms.Panel();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.picBoxAyarlar = new System.Windows.Forms.PictureBox();
            this.lblStoreManager = new System.Windows.Forms.Label();
            this.picBoxÇıkış = new System.Windows.Forms.PictureBox();
            this.panelAlt = new System.Windows.Forms.Panel();
            this.progressBarYükleme = new System.Windows.Forms.ProgressBar();
            this.txtBoxKulAdı = new System.Windows.Forms.TextBox();
            this.btnOturumAç = new System.Windows.Forms.Button();
            this.btnKayıtOl = new System.Windows.Forms.Button();
            this.radBtnÇalışan = new System.Windows.Forms.RadioButton();
            this.radBtnYönetici = new System.Windows.Forms.RadioButton();
            this.linkLblŞifreUnuttum = new System.Windows.Forms.LinkLabel();
            this.cBoxOturumAçık = new System.Windows.Forms.CheckBox();
            this.timerZaman = new System.Windows.Forms.Timer(this.components);
            this.txtBoxŞifre = new System.Windows.Forms.TextBox();
            this.picBoxGöster = new System.Windows.Forms.PictureBox();
            this.Açıklama = new System.Windows.Forms.ToolTip(this.components);
            this.panelÜst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAyarlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxÇıkış)).BeginInit();
            this.panelAlt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGöster)).BeginInit();
            this.SuspendLayout();
            // 
            // panelÜst
            // 
            this.panelÜst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelÜst.Controls.Add(this.picBoxLogo);
            this.panelÜst.Controls.Add(this.picBoxAyarlar);
            this.panelÜst.Controls.Add(this.lblStoreManager);
            this.panelÜst.Controls.Add(this.picBoxÇıkış);
            this.panelÜst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelÜst.Location = new System.Drawing.Point(0, 0);
            this.panelÜst.Name = "panelÜst";
            this.panelÜst.Size = new System.Drawing.Size(400, 85);
            this.panelÜst.TabIndex = 0;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(12, 19);
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
            // lblStoreManager
            // 
            this.lblStoreManager.AutoSize = true;
            this.lblStoreManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblStoreManager.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStoreManager.ForeColor = System.Drawing.SystemColors.Window;
            this.lblStoreManager.Location = new System.Drawing.Point(81, 26);
            this.lblStoreManager.Name = "lblStoreManager";
            this.lblStoreManager.Size = new System.Drawing.Size(251, 46);
            this.lblStoreManager.TabIndex = 1;
            this.lblStoreManager.Text = "Store Manager";
            this.lblStoreManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panelAlt.Location = new System.Drawing.Point(0, 399);
            this.panelAlt.Name = "panelAlt";
            this.panelAlt.Size = new System.Drawing.Size(400, 56);
            this.panelAlt.TabIndex = 1;
            // 
            // progressBarYükleme
            // 
            this.progressBarYükleme.BackColor = System.Drawing.SystemColors.Window;
            this.progressBarYükleme.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBarYükleme.Location = new System.Drawing.Point(12, 19);
            this.progressBarYükleme.Name = "progressBarYükleme";
            this.progressBarYükleme.Size = new System.Drawing.Size(376, 24);
            this.progressBarYükleme.TabIndex = 10;
            this.progressBarYükleme.Visible = false;
            // 
            // txtBoxKulAdı
            // 
            this.txtBoxKulAdı.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxKulAdı.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxKulAdı.Location = new System.Drawing.Point(53, 116);
            this.txtBoxKulAdı.MaxLength = 15;
            this.txtBoxKulAdı.Multiline = true;
            this.txtBoxKulAdı.Name = "txtBoxKulAdı";
            this.txtBoxKulAdı.Size = new System.Drawing.Size(303, 44);
            this.txtBoxKulAdı.TabIndex = 1;
            this.txtBoxKulAdı.Text = "Kullanıcı Adı";
            this.txtBoxKulAdı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxKulAdı.Click += new System.EventHandler(this.txtBoxKulAdı_Click);
            this.txtBoxKulAdı.TextChanged += new System.EventHandler(this.txtBoxKulAdı_TextChanged);
            // 
            // btnOturumAç
            // 
            this.btnOturumAç.BackColor = System.Drawing.SystemColors.Window;
            this.btnOturumAç.FlatAppearance.BorderSize = 0;
            this.btnOturumAç.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOturumAç.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOturumAç.ForeColor = System.Drawing.Color.Black;
            this.btnOturumAç.Location = new System.Drawing.Point(53, 255);
            this.btnOturumAç.Name = "btnOturumAç";
            this.btnOturumAç.Size = new System.Drawing.Size(139, 41);
            this.btnOturumAç.TabIndex = 3;
            this.btnOturumAç.Text = "Oturum Aç";
            this.btnOturumAç.UseVisualStyleBackColor = false;
            this.btnOturumAç.Click += new System.EventHandler(this.btnOturumAç_Click);
            // 
            // btnKayıtOl
            // 
            this.btnKayıtOl.BackColor = System.Drawing.SystemColors.Window;
            this.btnKayıtOl.FlatAppearance.BorderSize = 0;
            this.btnKayıtOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayıtOl.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayıtOl.ForeColor = System.Drawing.Color.Black;
            this.btnKayıtOl.Location = new System.Drawing.Point(219, 255);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(137, 41);
            this.btnKayıtOl.TabIndex = 4;
            this.btnKayıtOl.Text = "Kayıt Ol";
            this.btnKayıtOl.UseVisualStyleBackColor = false;
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKayıtOl_Click);
            // 
            // radBtnÇalışan
            // 
            this.radBtnÇalışan.AutoSize = true;
            this.radBtnÇalışan.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radBtnÇalışan.ForeColor = System.Drawing.SystemColors.Window;
            this.radBtnÇalışan.Location = new System.Drawing.Point(53, 311);
            this.radBtnÇalışan.Name = "radBtnÇalışan";
            this.radBtnÇalışan.Size = new System.Drawing.Size(74, 23);
            this.radBtnÇalışan.TabIndex = 5;
            this.radBtnÇalışan.TabStop = true;
            this.radBtnÇalışan.Text = "Çalışan";
            this.radBtnÇalışan.UseVisualStyleBackColor = true;
            this.radBtnÇalışan.CheckedChanged += new System.EventHandler(this.radBtnÇalışan_CheckedChanged);
            // 
            // radBtnYönetici
            // 
            this.radBtnYönetici.AutoSize = true;
            this.radBtnYönetici.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radBtnYönetici.ForeColor = System.Drawing.SystemColors.Window;
            this.radBtnYönetici.Location = new System.Drawing.Point(53, 348);
            this.radBtnYönetici.Name = "radBtnYönetici";
            this.radBtnYönetici.Size = new System.Drawing.Size(83, 23);
            this.radBtnYönetici.TabIndex = 7;
            this.radBtnYönetici.TabStop = true;
            this.radBtnYönetici.Text = "Yönetici";
            this.radBtnYönetici.UseVisualStyleBackColor = true;
            this.radBtnYönetici.CheckedChanged += new System.EventHandler(this.radBtnYönetici_CheckedChanged);
            // 
            // linkLblŞifreUnuttum
            // 
            this.linkLblŞifreUnuttum.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLblŞifreUnuttum.AutoSize = true;
            this.linkLblŞifreUnuttum.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLblŞifreUnuttum.LinkColor = System.Drawing.SystemColors.Window;
            this.linkLblŞifreUnuttum.Location = new System.Drawing.Point(199, 348);
            this.linkLblŞifreUnuttum.Name = "linkLblŞifreUnuttum";
            this.linkLblŞifreUnuttum.Size = new System.Drawing.Size(168, 19);
            this.linkLblŞifreUnuttum.TabIndex = 8;
            this.linkLblŞifreUnuttum.TabStop = true;
            this.linkLblŞifreUnuttum.Text = "Şifrenizi Mi Unuttunuz ?";
            this.linkLblŞifreUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblŞifreUnuttum_LinkClicked);
            // 
            // cBoxOturumAçık
            // 
            this.cBoxOturumAçık.AutoSize = true;
            this.cBoxOturumAçık.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxOturumAçık.ForeColor = System.Drawing.SystemColors.Window;
            this.cBoxOturumAçık.Location = new System.Drawing.Point(203, 312);
            this.cBoxOturumAçık.Name = "cBoxOturumAçık";
            this.cBoxOturumAçık.Size = new System.Drawing.Size(166, 23);
            this.cBoxOturumAçık.TabIndex = 6;
            this.cBoxOturumAçık.Text = "Oturumumu Açık Tut";
            this.cBoxOturumAçık.UseVisualStyleBackColor = true;
            // 
            // timerZaman
            // 
            this.timerZaman.Tick += new System.EventHandler(this.timerZaman_Tick);
            // 
            // txtBoxŞifre
            // 
            this.txtBoxŞifre.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxŞifre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxŞifre.Location = new System.Drawing.Point(53, 186);
            this.txtBoxŞifre.MaxLength = 15;
            this.txtBoxŞifre.Multiline = true;
            this.txtBoxŞifre.Name = "txtBoxŞifre";
            this.txtBoxŞifre.Size = new System.Drawing.Size(303, 44);
            this.txtBoxŞifre.TabIndex = 2;
            this.txtBoxŞifre.Text = "Şifre";
            this.txtBoxŞifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxŞifre.Click += new System.EventHandler(this.txtBoxŞifre_Click);
            this.txtBoxŞifre.TextChanged += new System.EventHandler(this.txtBoxŞifre_TextChanged);
            // 
            // picBoxGöster
            // 
            this.picBoxGöster.BackColor = System.Drawing.Color.White;
            this.picBoxGöster.Image = global::Store_Manager.Properties.Resources.Göz;
            this.picBoxGöster.Location = new System.Drawing.Point(324, 195);
            this.picBoxGöster.Name = "picBoxGöster";
            this.picBoxGöster.Size = new System.Drawing.Size(32, 22);
            this.picBoxGöster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxGöster.TabIndex = 11;
            this.picBoxGöster.TabStop = false;
            this.picBoxGöster.Click += new System.EventHandler(this.picBoxGöster_Click);
            // 
            // OturumAç
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(400, 455);
            this.Controls.Add(this.picBoxGöster);
            this.Controls.Add(this.txtBoxŞifre);
            this.Controls.Add(this.cBoxOturumAçık);
            this.Controls.Add(this.linkLblŞifreUnuttum);
            this.Controls.Add(this.radBtnYönetici);
            this.Controls.Add(this.radBtnÇalışan);
            this.Controls.Add(this.btnKayıtOl);
            this.Controls.Add(this.btnOturumAç);
            this.Controls.Add(this.txtBoxKulAdı);
            this.Controls.Add(this.panelAlt);
            this.Controls.Add(this.panelÜst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OturumAç";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Manager";
            this.Activated += new System.EventHandler(this.OturumAç_Activated);
            this.Load += new System.EventHandler(this.OturumAç_Load);
            this.panelÜst.ResumeLayout(false);
            this.panelÜst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAyarlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxÇıkış)).EndInit();
            this.panelAlt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGöster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelÜst;
        private System.Windows.Forms.Panel panelAlt;
        private System.Windows.Forms.PictureBox picBoxÇıkış;
        private System.Windows.Forms.Label lblStoreManager;
        private System.Windows.Forms.TextBox txtBoxKulAdı;
        private System.Windows.Forms.Button btnOturumAç;
        private System.Windows.Forms.Button btnKayıtOl;
        private System.Windows.Forms.RadioButton radBtnÇalışan;
        private System.Windows.Forms.RadioButton radBtnYönetici;
        private System.Windows.Forms.LinkLabel linkLblŞifreUnuttum;
        private System.Windows.Forms.CheckBox cBoxOturumAçık;
        private System.Windows.Forms.ProgressBar progressBarYükleme;
        private System.Windows.Forms.Timer timerZaman;
        private System.Windows.Forms.TextBox txtBoxŞifre;
        private System.Windows.Forms.PictureBox picBoxGöster;
        private System.Windows.Forms.PictureBox picBoxAyarlar;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.ToolTip Açıklama;
    }
}


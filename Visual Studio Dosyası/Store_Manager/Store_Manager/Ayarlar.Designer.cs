namespace Store_Manager
{
    partial class Ayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayarlar));
            this.zamanlayıcı = new System.Windows.Forms.Timer(this.components);
            this.lblStoreManager = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelÜst = new System.Windows.Forms.Panel();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.picBoxÇıkış = new System.Windows.Forms.PictureBox();
            this.lblKullanıcı = new System.Windows.Forms.Label();
            this.lblDil = new System.Windows.Forms.Label();
            this.cmbBoxDil = new System.Windows.Forms.ComboBox();
            this.lblAyarlar = new System.Windows.Forms.Label();
            this.panelSol = new System.Windows.Forms.FlowLayoutPanel();
            this.picBoxAyarlayıcı = new System.Windows.Forms.PictureBox();
            this.btnGenelAyarlar = new System.Windows.Forms.Button();
            this.btnHesap = new System.Windows.Forms.Button();
            this.lblTema = new System.Windows.Forms.Label();
            this.cmbBoxTema = new System.Windows.Forms.ComboBox();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtBoxTelNo = new System.Windows.Forms.TextBox();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.txtBoxAdres = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtBoxSoyadı = new System.Windows.Forms.TextBox();
            this.lblSoyadı = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.txtBoxAdı = new System.Windows.Forms.TextBox();
            this.txtBoxŞifre = new System.Windows.Forms.TextBox();
            this.txtBoxKulAdı = new System.Windows.Forms.TextBox();
            this.lblAdı = new System.Windows.Forms.Label();
            this.lblŞifre = new System.Windows.Forms.Label();
            this.lblKulAdı = new System.Windows.Forms.Label();
            this.panelÜst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxÇıkış)).BeginInit();
            this.panelSol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAyarlayıcı)).BeginInit();
            this.SuspendLayout();
            // 
            // zamanlayıcı
            // 
            this.zamanlayıcı.Tick += new System.EventHandler(this.zamanlayıcı_Tick);
            // 
            // lblStoreManager
            // 
            this.lblStoreManager.AutoSize = true;
            this.lblStoreManager.BackColor = System.Drawing.Color.Transparent;
            this.lblStoreManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStoreManager.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStoreManager.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblStoreManager.Location = new System.Drawing.Point(370, 1);
            this.lblStoreManager.Name = "lblStoreManager";
            this.lblStoreManager.Size = new System.Drawing.Size(226, 42);
            this.lblStoreManager.TabIndex = 5;
            this.lblStoreManager.Text = "Store Manager";
            this.lblStoreManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(268, 46);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(196, 396);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // panelÜst
            // 
            this.panelÜst.BackColor = System.Drawing.Color.LightGray;
            this.panelÜst.Controls.Add(this.picBoxLogo);
            this.panelÜst.Controls.Add(this.picBoxÇıkış);
            this.panelÜst.Controls.Add(this.lblStoreManager);
            this.panelÜst.Controls.Add(this.flowLayoutPanel1);
            this.panelÜst.Controls.Add(this.lblKullanıcı);
            this.panelÜst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelÜst.Location = new System.Drawing.Point(0, 0);
            this.panelÜst.Name = "panelÜst";
            this.panelÜst.Size = new System.Drawing.Size(892, 46);
            this.panelÜst.TabIndex = 37;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(309, -4);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(55, 55);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 6;
            this.picBoxLogo.TabStop = false;
            // 
            // picBoxÇıkış
            // 
            this.picBoxÇıkış.Image = global::Store_Manager.Properties.Resources.Çıkış_2;
            this.picBoxÇıkış.Location = new System.Drawing.Point(840, 3);
            this.picBoxÇıkış.Name = "picBoxÇıkış";
            this.picBoxÇıkış.Size = new System.Drawing.Size(52, 40);
            this.picBoxÇıkış.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxÇıkış.TabIndex = 9;
            this.picBoxÇıkış.TabStop = false;
            this.picBoxÇıkış.Click += new System.EventHandler(this.picBoxÇıkış_Click);
            // 
            // lblKullanıcı
            // 
            this.lblKullanıcı.AutoSize = true;
            this.lblKullanıcı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblKullanıcı.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanıcı.Location = new System.Drawing.Point(12, 9);
            this.lblKullanıcı.Name = "lblKullanıcı";
            this.lblKullanıcı.Size = new System.Drawing.Size(130, 29);
            this.lblKullanıcı.TabIndex = 1;
            this.lblKullanıcı.Text = "Kullanıcı Adı";
            // 
            // lblDil
            // 
            this.lblDil.AutoSize = true;
            this.lblDil.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDil.Location = new System.Drawing.Point(442, 198);
            this.lblDil.Name = "lblDil";
            this.lblDil.Size = new System.Drawing.Size(32, 17);
            this.lblDil.TabIndex = 10;
            this.lblDil.Text = "Dil :";
            this.lblDil.Visible = false;
            // 
            // cmbBoxDil
            // 
            this.cmbBoxDil.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxDil.FormattingEnabled = true;
            this.cmbBoxDil.Items.AddRange(new object[] {
            "English",
            "Türkçe"});
            this.cmbBoxDil.Location = new System.Drawing.Point(534, 189);
            this.cmbBoxDil.Name = "cmbBoxDil";
            this.cmbBoxDil.Size = new System.Drawing.Size(121, 32);
            this.cmbBoxDil.TabIndex = 9;
            this.cmbBoxDil.Visible = false;
            this.cmbBoxDil.SelectedIndexChanged += new System.EventHandler(this.cmbBoxDil_SelectedIndexChanged);
            // 
            // lblAyarlar
            // 
            this.lblAyarlar.AutoSize = true;
            this.lblAyarlar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelSol.SetFlowBreak(this.lblAyarlar, true);
            this.lblAyarlar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAyarlar.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAyarlar.Location = new System.Drawing.Point(57, 0);
            this.lblAyarlar.Name = "lblAyarlar";
            this.lblAyarlar.Size = new System.Drawing.Size(81, 28);
            this.lblAyarlar.TabIndex = 4;
            this.lblAyarlar.Text = "Ayarlar";
            // 
            // panelSol
            // 
            this.panelSol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelSol.Controls.Add(this.picBoxAyarlayıcı);
            this.panelSol.Controls.Add(this.lblAyarlar);
            this.panelSol.Controls.Add(this.btnGenelAyarlar);
            this.panelSol.Controls.Add(this.btnHesap);
            this.panelSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSol.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelSol.Location = new System.Drawing.Point(0, 46);
            this.panelSol.Name = "panelSol";
            this.panelSol.Size = new System.Drawing.Size(199, 519);
            this.panelSol.TabIndex = 38;
            // 
            // picBoxAyarlayıcı
            // 
            this.picBoxAyarlayıcı.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxAyarlayıcı.Image = global::Store_Manager.Properties.Resources.Ayarlayıcı;
            this.picBoxAyarlayıcı.Location = new System.Drawing.Point(144, 3);
            this.picBoxAyarlayıcı.Name = "picBoxAyarlayıcı";
            this.picBoxAyarlayıcı.Size = new System.Drawing.Size(52, 22);
            this.picBoxAyarlayıcı.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAyarlayıcı.TabIndex = 8;
            this.picBoxAyarlayıcı.TabStop = false;
            this.picBoxAyarlayıcı.Click += new System.EventHandler(this.picBoxAyarlayıcı_Click);
            // 
            // btnGenelAyarlar
            // 
            this.btnGenelAyarlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGenelAyarlar.FlatAppearance.BorderSize = 0;
            this.btnGenelAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenelAyarlar.Font = new System.Drawing.Font("Comic Sans MS", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenelAyarlar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGenelAyarlar.Image = global::Store_Manager.Properties.Resources.GenelAyarlar;
            this.btnGenelAyarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenelAyarlar.Location = new System.Drawing.Point(12, 31);
            this.btnGenelAyarlar.Name = "btnGenelAyarlar";
            this.btnGenelAyarlar.Size = new System.Drawing.Size(184, 74);
            this.btnGenelAyarlar.TabIndex = 10;
            this.btnGenelAyarlar.Text = "Genel Ayarlar";
            this.btnGenelAyarlar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenelAyarlar.UseVisualStyleBackColor = false;
            this.btnGenelAyarlar.Click += new System.EventHandler(this.btnGenelAyarlar_Click);
            // 
            // btnHesap
            // 
            this.btnHesap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnHesap.FlatAppearance.BorderSize = 0;
            this.btnHesap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesap.Font = new System.Drawing.Font("Comic Sans MS", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesap.ForeColor = System.Drawing.SystemColors.Window;
            this.btnHesap.Image = global::Store_Manager.Properties.Resources.Hesap;
            this.btnHesap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHesap.Location = new System.Drawing.Point(12, 111);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(184, 74);
            this.btnHesap.TabIndex = 11;
            this.btnHesap.Text = "Hesap";
            this.btnHesap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHesap.UseVisualStyleBackColor = false;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTema.Location = new System.Drawing.Point(442, 278);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(52, 17);
            this.lblTema.TabIndex = 40;
            this.lblTema.Text = "Tema :";
            this.lblTema.Visible = false;
            // 
            // cmbBoxTema
            // 
            this.cmbBoxTema.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxTema.FormattingEnabled = true;
            this.cmbBoxTema.Items.AddRange(new object[] {
            "Varsayılan",
            "Kırmızı",
            "Mavi",
            "Yeşil"});
            this.cmbBoxTema.Location = new System.Drawing.Point(534, 269);
            this.cmbBoxTema.Name = "cmbBoxTema";
            this.cmbBoxTema.Size = new System.Drawing.Size(121, 32);
            this.cmbBoxTema.TabIndex = 39;
            this.cmbBoxTema.Visible = false;
            this.cmbBoxTema.SelectedIndexChanged += new System.EventHandler(this.cmbBoxTema_SelectedIndexChanged);
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Location = new System.Drawing.Point(515, 321);
            this.txtBoxMail.MaxLength = 30;
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(164, 22);
            this.txtBoxMail.TabIndex = 50;
            this.txtBoxMail.Visible = false;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMail.Location = new System.Drawing.Point(421, 324);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(51, 17);
            this.lblMail.TabIndex = 55;
            this.lblMail.Text = "E-Mail:";
            this.lblMail.Visible = false;
            // 
            // txtBoxTelNo
            // 
            this.txtBoxTelNo.Location = new System.Drawing.Point(515, 291);
            this.txtBoxTelNo.MaxLength = 10;
            this.txtBoxTelNo.Name = "txtBoxTelNo";
            this.txtBoxTelNo.Size = new System.Drawing.Size(164, 22);
            this.txtBoxTelNo.TabIndex = 49;
            this.txtBoxTelNo.Visible = false;
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTelNo.Location = new System.Drawing.Point(421, 294);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(82, 17);
            this.lblTelNo.TabIndex = 54;
            this.lblTelNo.Text = "Telefon No:";
            this.lblTelNo.Visible = false;
            // 
            // txtBoxAdres
            // 
            this.txtBoxAdres.Location = new System.Drawing.Point(515, 261);
            this.txtBoxAdres.Name = "txtBoxAdres";
            this.txtBoxAdres.Size = new System.Drawing.Size(164, 22);
            this.txtBoxAdres.TabIndex = 48;
            this.txtBoxAdres.Visible = false;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAdres.Location = new System.Drawing.Point(421, 264);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(49, 17);
            this.lblAdres.TabIndex = 53;
            this.lblAdres.Text = "Adres:";
            this.lblAdres.Visible = false;
            // 
            // txtBoxSoyadı
            // 
            this.txtBoxSoyadı.Location = new System.Drawing.Point(515, 231);
            this.txtBoxSoyadı.Name = "txtBoxSoyadı";
            this.txtBoxSoyadı.Size = new System.Drawing.Size(164, 22);
            this.txtBoxSoyadı.TabIndex = 47;
            this.txtBoxSoyadı.Visible = false;
            // 
            // lblSoyadı
            // 
            this.lblSoyadı.AutoSize = true;
            this.lblSoyadı.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSoyadı.Location = new System.Drawing.Point(421, 234);
            this.lblSoyadı.Name = "lblSoyadı";
            this.lblSoyadı.Size = new System.Drawing.Size(55, 17);
            this.lblSoyadı.TabIndex = 51;
            this.lblSoyadı.Text = "Soyadı:";
            this.lblSoyadı.Visible = false;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.White;
            this.btnGüncelle.FlatAppearance.BorderSize = 0;
            this.btnGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGüncelle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGüncelle.Location = new System.Drawing.Point(424, 379);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(255, 50);
            this.btnGüncelle.TabIndex = 52;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Visible = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // txtBoxAdı
            // 
            this.txtBoxAdı.Location = new System.Drawing.Point(515, 201);
            this.txtBoxAdı.Name = "txtBoxAdı";
            this.txtBoxAdı.Size = new System.Drawing.Size(164, 22);
            this.txtBoxAdı.TabIndex = 46;
            this.txtBoxAdı.Visible = false;
            // 
            // txtBoxŞifre
            // 
            this.txtBoxŞifre.Location = new System.Drawing.Point(515, 171);
            this.txtBoxŞifre.Name = "txtBoxŞifre";
            this.txtBoxŞifre.Size = new System.Drawing.Size(164, 22);
            this.txtBoxŞifre.TabIndex = 44;
            this.txtBoxŞifre.Visible = false;
            // 
            // txtBoxKulAdı
            // 
            this.txtBoxKulAdı.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxKulAdı.Location = new System.Drawing.Point(515, 141);
            this.txtBoxKulAdı.Name = "txtBoxKulAdı";
            this.txtBoxKulAdı.Size = new System.Drawing.Size(164, 22);
            this.txtBoxKulAdı.TabIndex = 42;
            this.txtBoxKulAdı.Visible = false;
            // 
            // lblAdı
            // 
            this.lblAdı.AutoSize = true;
            this.lblAdı.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAdı.Location = new System.Drawing.Point(421, 204);
            this.lblAdı.Name = "lblAdı";
            this.lblAdı.Size = new System.Drawing.Size(32, 17);
            this.lblAdı.TabIndex = 45;
            this.lblAdı.Text = "Adı:";
            this.lblAdı.Visible = false;
            // 
            // lblŞifre
            // 
            this.lblŞifre.AutoSize = true;
            this.lblŞifre.ForeColor = System.Drawing.SystemColors.Window;
            this.lblŞifre.Location = new System.Drawing.Point(421, 174);
            this.lblŞifre.Name = "lblŞifre";
            this.lblŞifre.Size = new System.Drawing.Size(41, 17);
            this.lblŞifre.TabIndex = 43;
            this.lblŞifre.Text = "Şifre:";
            this.lblŞifre.Visible = false;
            // 
            // lblKulAdı
            // 
            this.lblKulAdı.AutoSize = true;
            this.lblKulAdı.ForeColor = System.Drawing.SystemColors.Window;
            this.lblKulAdı.Location = new System.Drawing.Point(421, 144);
            this.lblKulAdı.Name = "lblKulAdı";
            this.lblKulAdı.Size = new System.Drawing.Size(88, 17);
            this.lblKulAdı.TabIndex = 41;
            this.lblKulAdı.Text = "Kullanıcı Adı:";
            this.lblKulAdı.Visible = false;
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(892, 565);
            this.Controls.Add(this.txtBoxMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtBoxTelNo);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.txtBoxAdres);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.txtBoxSoyadı);
            this.Controls.Add(this.lblSoyadı);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.txtBoxAdı);
            this.Controls.Add(this.txtBoxŞifre);
            this.Controls.Add(this.txtBoxKulAdı);
            this.Controls.Add(this.lblAdı);
            this.Controls.Add(this.lblŞifre);
            this.Controls.Add(this.lblKulAdı);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.cmbBoxTema);
            this.Controls.Add(this.panelSol);
            this.Controls.Add(this.panelÜst);
            this.Controls.Add(this.cmbBoxDil);
            this.Controls.Add(this.lblDil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ayarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.Activated += new System.EventHandler(this.Ayarlar_Activated);
            this.Load += new System.EventHandler(this.Ayarlar_Load);
            this.panelÜst.ResumeLayout(false);
            this.panelÜst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxÇıkış)).EndInit();
            this.panelSol.ResumeLayout(false);
            this.panelSol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAyarlayıcı)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer zamanlayıcı;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.PictureBox picBoxÇıkış;
        private System.Windows.Forms.Label lblStoreManager;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelÜst;
        private System.Windows.Forms.Label lblKullanıcı;
        private System.Windows.Forms.Label lblDil;
        private System.Windows.Forms.ComboBox cmbBoxDil;
        private System.Windows.Forms.Label lblAyarlar;
        private System.Windows.Forms.FlowLayoutPanel panelSol;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.ComboBox cmbBoxTema;
        private System.Windows.Forms.Button btnGenelAyarlar;
        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.PictureBox picBoxAyarlayıcı;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtBoxTelNo;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.TextBox txtBoxAdres;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtBoxSoyadı;
        private System.Windows.Forms.Label lblSoyadı;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.TextBox txtBoxAdı;
        private System.Windows.Forms.TextBox txtBoxŞifre;
        private System.Windows.Forms.TextBox txtBoxKulAdı;
        private System.Windows.Forms.Label lblAdı;
        private System.Windows.Forms.Label lblŞifre;
        private System.Windows.Forms.Label lblKulAdı;
    }
}
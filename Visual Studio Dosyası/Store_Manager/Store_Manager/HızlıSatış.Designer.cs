namespace Store_Manager
{
    partial class HızlıSatış
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HızlıSatış));
            this.panelÜst = new System.Windows.Forms.Panel();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.picBoxÇıkış = new System.Windows.Forms.PictureBox();
            this.lblStoreManager = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblKulAdı = new System.Windows.Forms.Label();
            this.btnHızlıSatış = new System.Windows.Forms.Button();
            this.txtBoxTaksitSayısı = new System.Windows.Forms.TextBox();
            this.lblSatışTürü = new System.Windows.Forms.Label();
            this.cmbBoxMüşteriAdıSoyadı = new System.Windows.Forms.ComboBox();
            this.rBtnKrediKartı = new System.Windows.Forms.RadioButton();
            this.rBtnSenet = new System.Windows.Forms.RadioButton();
            this.rBtnPeşin = new System.Windows.Forms.RadioButton();
            this.txtBoxÜcreti = new System.Windows.Forms.TextBox();
            this.cmbBoxÜrünNumarası = new System.Windows.Forms.ComboBox();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.Sepettekiler = new System.Windows.Forms.ListBox();
            this.Açıklama = new System.Windows.Forms.ToolTip(this.components);
            this.panelÜst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxÇıkış)).BeginInit();
            this.SuspendLayout();
            // 
            // panelÜst
            // 
            this.panelÜst.BackColor = System.Drawing.Color.LightGray;
            this.panelÜst.Controls.Add(this.picBoxLogo);
            this.panelÜst.Controls.Add(this.picBoxÇıkış);
            this.panelÜst.Controls.Add(this.lblStoreManager);
            this.panelÜst.Controls.Add(this.flowLayoutPanel1);
            this.panelÜst.Controls.Add(this.lblKulAdı);
            this.panelÜst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelÜst.Location = new System.Drawing.Point(0, 0);
            this.panelÜst.Name = "panelÜst";
            this.panelÜst.Size = new System.Drawing.Size(892, 46);
            this.panelÜst.TabIndex = 2;
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
            // lblKulAdı
            // 
            this.lblKulAdı.AutoSize = true;
            this.lblKulAdı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblKulAdı.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKulAdı.Location = new System.Drawing.Point(12, 9);
            this.lblKulAdı.Name = "lblKulAdı";
            this.lblKulAdı.Size = new System.Drawing.Size(130, 29);
            this.lblKulAdı.TabIndex = 1;
            this.lblKulAdı.Text = "Kullanıcı Adı";
            // 
            // btnHızlıSatış
            // 
            this.btnHızlıSatış.BackColor = System.Drawing.SystemColors.Window;
            this.btnHızlıSatış.FlatAppearance.BorderSize = 0;
            this.btnHızlıSatış.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHızlıSatış.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHızlıSatış.ForeColor = System.Drawing.Color.Black;
            this.btnHızlıSatış.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHızlıSatış.Location = new System.Drawing.Point(348, 504);
            this.btnHızlıSatış.Name = "btnHızlıSatış";
            this.btnHızlıSatış.Size = new System.Drawing.Size(184, 49);
            this.btnHızlıSatış.TabIndex = 11;
            this.btnHızlıSatış.Text = "Hızlı Satış Yap";
            this.btnHızlıSatış.UseVisualStyleBackColor = false;
            this.btnHızlıSatış.Click += new System.EventHandler(this.btnHızlıSatış_Click);
            // 
            // txtBoxTaksitSayısı
            // 
            this.txtBoxTaksitSayısı.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxTaksitSayısı.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxTaksitSayısı.Location = new System.Drawing.Point(293, 215);
            this.txtBoxTaksitSayısı.MaxLength = 10;
            this.txtBoxTaksitSayısı.Multiline = true;
            this.txtBoxTaksitSayısı.Name = "txtBoxTaksitSayısı";
            this.txtBoxTaksitSayısı.Size = new System.Drawing.Size(303, 27);
            this.txtBoxTaksitSayısı.TabIndex = 54;
            this.txtBoxTaksitSayısı.Text = "Taksit Sayısı";
            this.txtBoxTaksitSayısı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxTaksitSayısı.Visible = false;
            // 
            // lblSatışTürü
            // 
            this.lblSatışTürü.AutoSize = true;
            this.lblSatışTürü.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatışTürü.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSatışTürü.Location = new System.Drawing.Point(263, 185);
            this.lblSatışTürü.Name = "lblSatışTürü";
            this.lblSatışTürü.Size = new System.Drawing.Size(99, 24);
            this.lblSatışTürü.TabIndex = 53;
            this.lblSatışTürü.Text = "Satış Türü:";
            // 
            // cmbBoxMüşteriAdıSoyadı
            // 
            this.cmbBoxMüşteriAdıSoyadı.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxMüşteriAdıSoyadı.FormattingEnabled = true;
            this.cmbBoxMüşteriAdıSoyadı.Location = new System.Drawing.Point(293, 114);
            this.cmbBoxMüşteriAdıSoyadı.Name = "cmbBoxMüşteriAdıSoyadı";
            this.cmbBoxMüşteriAdıSoyadı.Size = new System.Drawing.Size(303, 32);
            this.cmbBoxMüşteriAdıSoyadı.TabIndex = 52;
            this.cmbBoxMüşteriAdıSoyadı.Text = "Müşteri Adı & Soyadı";
            // 
            // rBtnKrediKartı
            // 
            this.rBtnKrediKartı.AutoSize = true;
            this.rBtnKrediKartı.ForeColor = System.Drawing.SystemColors.Window;
            this.rBtnKrediKartı.Location = new System.Drawing.Point(520, 188);
            this.rBtnKrediKartı.Name = "rBtnKrediKartı";
            this.rBtnKrediKartı.Size = new System.Drawing.Size(95, 21);
            this.rBtnKrediKartı.TabIndex = 51;
            this.rBtnKrediKartı.TabStop = true;
            this.rBtnKrediKartı.Text = "Kredi Kartı";
            this.rBtnKrediKartı.UseVisualStyleBackColor = true;
            // 
            // rBtnSenet
            // 
            this.rBtnSenet.AutoSize = true;
            this.rBtnSenet.ForeColor = System.Drawing.SystemColors.Window;
            this.rBtnSenet.Location = new System.Drawing.Point(448, 188);
            this.rBtnSenet.Name = "rBtnSenet";
            this.rBtnSenet.Size = new System.Drawing.Size(66, 21);
            this.rBtnSenet.TabIndex = 50;
            this.rBtnSenet.TabStop = true;
            this.rBtnSenet.Text = "Senet";
            this.rBtnSenet.UseVisualStyleBackColor = true;
            this.rBtnSenet.CheckedChanged += new System.EventHandler(this.rBtnSenet_CheckedChanged);
            // 
            // rBtnPeşin
            // 
            this.rBtnPeşin.AutoSize = true;
            this.rBtnPeşin.ForeColor = System.Drawing.SystemColors.Window;
            this.rBtnPeşin.Location = new System.Drawing.Point(378, 188);
            this.rBtnPeşin.Name = "rBtnPeşin";
            this.rBtnPeşin.Size = new System.Drawing.Size(64, 21);
            this.rBtnPeşin.TabIndex = 49;
            this.rBtnPeşin.TabStop = true;
            this.rBtnPeşin.Text = "Peşin";
            this.rBtnPeşin.UseVisualStyleBackColor = true;
            // 
            // txtBoxÜcreti
            // 
            this.txtBoxÜcreti.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxÜcreti.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxÜcreti.Location = new System.Drawing.Point(293, 152);
            this.txtBoxÜcreti.MaxLength = 10;
            this.txtBoxÜcreti.Multiline = true;
            this.txtBoxÜcreti.Name = "txtBoxÜcreti";
            this.txtBoxÜcreti.ReadOnly = true;
            this.txtBoxÜcreti.Size = new System.Drawing.Size(303, 30);
            this.txtBoxÜcreti.TabIndex = 48;
            this.txtBoxÜcreti.Text = "Ücreti (₺)";
            this.txtBoxÜcreti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbBoxÜrünNumarası
            // 
            this.cmbBoxÜrünNumarası.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxÜrünNumarası.FormattingEnabled = true;
            this.cmbBoxÜrünNumarası.Location = new System.Drawing.Point(293, 76);
            this.cmbBoxÜrünNumarası.Name = "cmbBoxÜrünNumarası";
            this.cmbBoxÜrünNumarası.Size = new System.Drawing.Size(303, 32);
            this.cmbBoxÜrünNumarası.TabIndex = 47;
            this.cmbBoxÜrünNumarası.Text = "Ürün Numarası";
            this.cmbBoxÜrünNumarası.SelectedIndexChanged += new System.EventHandler(this.cmbBoxÜrünNumarası_SelectedIndexChanged);
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.BackColor = System.Drawing.SystemColors.Window;
            this.btnSepeteEkle.FlatAppearance.BorderSize = 0;
            this.btnSepeteEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSepeteEkle.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepeteEkle.ForeColor = System.Drawing.Color.Black;
            this.btnSepeteEkle.Location = new System.Drawing.Point(293, 248);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(303, 41);
            this.btnSepeteEkle.TabIndex = 46;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = false;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // Sepettekiler
            // 
            this.Sepettekiler.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sepettekiler.FormattingEnabled = true;
            this.Sepettekiler.HorizontalScrollbar = true;
            this.Sepettekiler.ItemHeight = 24;
            this.Sepettekiler.Location = new System.Drawing.Point(293, 294);
            this.Sepettekiler.MultiColumn = true;
            this.Sepettekiler.Name = "Sepettekiler";
            this.Sepettekiler.Size = new System.Drawing.Size(303, 196);
            this.Sepettekiler.TabIndex = 55;
            // 
            // HızlıSatış
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(892, 565);
            this.Controls.Add(this.Sepettekiler);
            this.Controls.Add(this.txtBoxTaksitSayısı);
            this.Controls.Add(this.lblSatışTürü);
            this.Controls.Add(this.cmbBoxMüşteriAdıSoyadı);
            this.Controls.Add(this.rBtnKrediKartı);
            this.Controls.Add(this.rBtnSenet);
            this.Controls.Add(this.rBtnPeşin);
            this.Controls.Add(this.txtBoxÜcreti);
            this.Controls.Add(this.cmbBoxÜrünNumarası);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.btnHızlıSatış);
            this.Controls.Add(this.panelÜst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HızlıSatış";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HızlıSatış";
            this.Activated += new System.EventHandler(this.HızlıSatış_Activated);
            this.Load += new System.EventHandler(this.HızlıSatış_Load);
            this.panelÜst.ResumeLayout(false);
            this.panelÜst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxÇıkış)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelÜst;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.PictureBox picBoxÇıkış;
        private System.Windows.Forms.Label lblStoreManager;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblKulAdı;
        private System.Windows.Forms.Button btnHızlıSatış;
        private System.Windows.Forms.TextBox txtBoxTaksitSayısı;
        private System.Windows.Forms.Label lblSatışTürü;
        private System.Windows.Forms.ComboBox cmbBoxMüşteriAdıSoyadı;
        private System.Windows.Forms.RadioButton rBtnKrediKartı;
        private System.Windows.Forms.RadioButton rBtnSenet;
        private System.Windows.Forms.RadioButton rBtnPeşin;
        private System.Windows.Forms.TextBox txtBoxÜcreti;
        private System.Windows.Forms.ComboBox cmbBoxÜrünNumarası;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.ListBox Sepettekiler;
        private System.Windows.Forms.ToolTip Açıklama;
    }
}
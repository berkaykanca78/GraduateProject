namespace Store_Manager
{
    partial class ÇalışanAnaMenü
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÇalışanAnaMenü));
            this.panelSol = new System.Windows.Forms.FlowLayoutPanel();
            this.picBoxAyarlayıcı = new System.Windows.Forms.PictureBox();
            this.lblAnaMenü = new System.Windows.Forms.Label();
            this.btnMüşteri = new System.Windows.Forms.Button();
            this.btnSatış = new System.Windows.Forms.Button();
            this.btnÜrün = new System.Windows.Forms.Button();
            this.btnMağaza = new System.Windows.Forms.Button();
            this.panelÜst = new System.Windows.Forms.Panel();
            this.picBoxHızlıSatış = new System.Windows.Forms.PictureBox();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.picBoxÇıkış = new System.Windows.Forms.PictureBox();
            this.lblStoreManager = new System.Windows.Forms.Label();
            this.picBoxAyarlar = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.picBoxOturumKapat = new System.Windows.Forms.PictureBox();
            this.lblKulAdı = new System.Windows.Forms.Label();
            this.zamanlayıcı = new System.Windows.Forms.Timer(this.components);
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.hatırlatıcı = new System.Windows.Forms.NotifyIcon(this.components);
            this.hatırlatıcı2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Açıklama = new System.Windows.Forms.ToolTip(this.components);
            this.panelSol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAyarlayıcı)).BeginInit();
            this.panelÜst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHızlıSatış)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxÇıkış)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAyarlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOturumKapat)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSol
            // 
            this.panelSol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelSol.Controls.Add(this.picBoxAyarlayıcı);
            this.panelSol.Controls.Add(this.lblAnaMenü);
            this.panelSol.Controls.Add(this.btnMüşteri);
            this.panelSol.Controls.Add(this.btnSatış);
            this.panelSol.Controls.Add(this.btnÜrün);
            this.panelSol.Controls.Add(this.btnMağaza);
            this.panelSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSol.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelSol.Location = new System.Drawing.Point(0, 46);
            this.panelSol.Name = "panelSol";
            this.panelSol.Size = new System.Drawing.Size(199, 519);
            this.panelSol.TabIndex = 7;
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
            // lblAnaMenü
            // 
            this.lblAnaMenü.AutoSize = true;
            this.lblAnaMenü.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAnaMenü.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelSol.SetFlowBreak(this.lblAnaMenü, true);
            this.lblAnaMenü.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnaMenü.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAnaMenü.Location = new System.Drawing.Point(37, 0);
            this.lblAnaMenü.Name = "lblAnaMenü";
            this.lblAnaMenü.Size = new System.Drawing.Size(101, 28);
            this.lblAnaMenü.TabIndex = 4;
            this.lblAnaMenü.Text = "Ana Menü";
            // 
            // btnMüşteri
            // 
            this.btnMüşteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnMüşteri.FlatAppearance.BorderSize = 0;
            this.btnMüşteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMüşteri.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMüşteri.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMüşteri.Image = global::Store_Manager.Properties.Resources.Müşteri;
            this.btnMüşteri.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMüşteri.Location = new System.Drawing.Point(12, 31);
            this.btnMüşteri.Name = "btnMüşteri";
            this.btnMüşteri.Size = new System.Drawing.Size(184, 115);
            this.btnMüşteri.TabIndex = 1;
            this.btnMüşteri.Text = "Müşteri";
            this.btnMüşteri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMüşteri.UseVisualStyleBackColor = false;
            this.btnMüşteri.Click += new System.EventHandler(this.btnMüşteri_Click);
            // 
            // btnSatış
            // 
            this.btnSatış.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSatış.FlatAppearance.BorderSize = 0;
            this.btnSatış.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatış.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatış.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSatış.Image = global::Store_Manager.Properties.Resources.Satış;
            this.btnSatış.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSatış.Location = new System.Drawing.Point(12, 152);
            this.btnSatış.Name = "btnSatış";
            this.btnSatış.Size = new System.Drawing.Size(184, 115);
            this.btnSatış.TabIndex = 3;
            this.btnSatış.Text = "Satış";
            this.btnSatış.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatış.UseVisualStyleBackColor = false;
            this.btnSatış.Click += new System.EventHandler(this.btnSatış_Click);
            // 
            // btnÜrün
            // 
            this.btnÜrün.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnÜrün.FlatAppearance.BorderSize = 0;
            this.btnÜrün.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÜrün.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÜrün.ForeColor = System.Drawing.SystemColors.Window;
            this.btnÜrün.Image = global::Store_Manager.Properties.Resources.Ürün;
            this.btnÜrün.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnÜrün.Location = new System.Drawing.Point(12, 273);
            this.btnÜrün.Name = "btnÜrün";
            this.btnÜrün.Size = new System.Drawing.Size(184, 115);
            this.btnÜrün.TabIndex = 4;
            this.btnÜrün.Text = "Ürün";
            this.btnÜrün.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnÜrün.UseVisualStyleBackColor = false;
            this.btnÜrün.Click += new System.EventHandler(this.btnÜrün_Click);
            // 
            // btnMağaza
            // 
            this.btnMağaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnMağaza.FlatAppearance.BorderSize = 0;
            this.btnMağaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMağaza.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMağaza.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMağaza.Image = global::Store_Manager.Properties.Resources.Mağaza;
            this.btnMağaza.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMağaza.Location = new System.Drawing.Point(12, 394);
            this.btnMağaza.Name = "btnMağaza";
            this.btnMağaza.Size = new System.Drawing.Size(184, 115);
            this.btnMağaza.TabIndex = 5;
            this.btnMağaza.Text = "Mağaza";
            this.btnMağaza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMağaza.UseVisualStyleBackColor = false;
            this.btnMağaza.Click += new System.EventHandler(this.btnMağaza_Click);
            // 
            // panelÜst
            // 
            this.panelÜst.BackColor = System.Drawing.Color.LightGray;
            this.panelÜst.Controls.Add(this.picBoxHızlıSatış);
            this.panelÜst.Controls.Add(this.picBoxLogo);
            this.panelÜst.Controls.Add(this.picBoxÇıkış);
            this.panelÜst.Controls.Add(this.lblStoreManager);
            this.panelÜst.Controls.Add(this.picBoxAyarlar);
            this.panelÜst.Controls.Add(this.flowLayoutPanel1);
            this.panelÜst.Controls.Add(this.picBoxOturumKapat);
            this.panelÜst.Controls.Add(this.lblKulAdı);
            this.panelÜst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelÜst.Location = new System.Drawing.Point(0, 0);
            this.panelÜst.Name = "panelÜst";
            this.panelÜst.Size = new System.Drawing.Size(892, 46);
            this.panelÜst.TabIndex = 6;
            // 
            // picBoxHızlıSatış
            // 
            this.picBoxHızlıSatış.Image = global::Store_Manager.Properties.Resources.HızlıSatış;
            this.picBoxHızlıSatış.Location = new System.Drawing.Point(666, 3);
            this.picBoxHızlıSatış.Name = "picBoxHızlıSatış";
            this.picBoxHızlıSatış.Size = new System.Drawing.Size(52, 40);
            this.picBoxHızlıSatış.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxHızlıSatış.TabIndex = 10;
            this.picBoxHızlıSatış.TabStop = false;
            this.picBoxHızlıSatış.Click += new System.EventHandler(this.picBoxHızlıSatış_Click);
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
            // picBoxAyarlar
            // 
            this.picBoxAyarlar.Image = global::Store_Manager.Properties.Resources.Ayarlar2;
            this.picBoxAyarlar.Location = new System.Drawing.Point(724, 3);
            this.picBoxAyarlar.Name = "picBoxAyarlar";
            this.picBoxAyarlar.Size = new System.Drawing.Size(52, 40);
            this.picBoxAyarlar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAyarlar.TabIndex = 8;
            this.picBoxAyarlar.TabStop = false;
            this.picBoxAyarlar.Click += new System.EventHandler(this.picBoxAyarlar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(268, 46);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(196, 396);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // picBoxOturumKapat
            // 
            this.picBoxOturumKapat.Image = ((System.Drawing.Image)(resources.GetObject("picBoxOturumKapat.Image")));
            this.picBoxOturumKapat.Location = new System.Drawing.Point(782, 3);
            this.picBoxOturumKapat.Name = "picBoxOturumKapat";
            this.picBoxOturumKapat.Size = new System.Drawing.Size(52, 40);
            this.picBoxOturumKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxOturumKapat.TabIndex = 7;
            this.picBoxOturumKapat.TabStop = false;
            this.picBoxOturumKapat.Click += new System.EventHandler(this.picBoxOturumKapat_Click);
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
            // zamanlayıcı
            // 
            this.zamanlayıcı.Tick += new System.EventHandler(this.zamanlayıcı_Tick);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.LightGray;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(217, 83);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(182, 62);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "Buton1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Visible = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.LightGray;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(455, 83);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(182, 62);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "Buton2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Visible = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.LightGray;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(698, 83);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(182, 62);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "Buton3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Visible = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // hatırlatıcı
            // 
            this.hatırlatıcı.Visible = true;
            this.hatırlatıcı.BalloonTipClicked += new System.EventHandler(this.hatırlatıcı_BalloonTipClicked);
            // 
            // hatırlatıcı2
            // 
            this.hatırlatıcı2.Visible = true;
            this.hatırlatıcı2.BalloonTipClicked += new System.EventHandler(this.hatırlatıcı2_BalloonTipClicked);
            // 
            // ÇalışanAnaMenü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(892, 565);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.panelSol);
            this.Controls.Add(this.panelÜst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ÇalışanAnaMenü";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÇalışanAnaMenü";
            this.Activated += new System.EventHandler(this.ÇalışanAnaMenü_Activated);
            this.Load += new System.EventHandler(this.ÇalışanAnaMenü_Load);
            this.panelSol.ResumeLayout(false);
            this.panelSol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAyarlayıcı)).EndInit();
            this.panelÜst.ResumeLayout(false);
            this.panelÜst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHızlıSatış)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxÇıkış)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAyarlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOturumKapat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelSol;
        private System.Windows.Forms.PictureBox picBoxAyarlayıcı;
        private System.Windows.Forms.Label lblAnaMenü;
        private System.Windows.Forms.Button btnMüşteri;
        private System.Windows.Forms.Button btnSatış;
        private System.Windows.Forms.Button btnÜrün;
        private System.Windows.Forms.Button btnMağaza;
        private System.Windows.Forms.Panel panelÜst;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.PictureBox picBoxÇıkış;
        private System.Windows.Forms.Label lblStoreManager;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblKulAdı;
        private System.Windows.Forms.Timer zamanlayıcı;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.NotifyIcon hatırlatıcı;
        private System.Windows.Forms.PictureBox picBoxHızlıSatış;
        private System.Windows.Forms.PictureBox picBoxAyarlar;
        private System.Windows.Forms.PictureBox picBoxOturumKapat;
        private System.Windows.Forms.NotifyIcon hatırlatıcı2;
        private System.Windows.Forms.ToolTip Açıklama;
    }
}
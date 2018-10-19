namespace Store_Manager
{
    partial class ŞifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ŞifremiUnuttum));
            this.timerZaman = new System.Windows.Forms.Timer(this.components);
            this.btnYeniŞifre = new System.Windows.Forms.Button();
            this.progressBarYükleme = new System.Windows.Forms.ProgressBar();
            this.panelAlt = new System.Windows.Forms.Panel();
            this.lblŞifremiUnuttum = new System.Windows.Forms.Label();
            this.panelÜst = new System.Windows.Forms.Panel();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.picBoxAyarlar = new System.Windows.Forms.PictureBox();
            this.picBoxÇıkış = new System.Windows.Forms.PictureBox();
            this.txtBoxKulAdıMail = new System.Windows.Forms.TextBox();
            this.txtBoxResim = new System.Windows.Forms.TextBox();
            this.lblCaptcha = new System.Windows.Forms.Label();
            this.btnYeniResim = new System.Windows.Forms.Button();
            this.Açıklama = new System.Windows.Forms.ToolTip(this.components);
            this.panelAlt.SuspendLayout();
            this.panelÜst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAyarlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxÇıkış)).BeginInit();
            this.SuspendLayout();
            // 
            // timerZaman
            // 
            this.timerZaman.Tick += new System.EventHandler(this.timerZaman_Tick);
            // 
            // btnYeniŞifre
            // 
            this.btnYeniŞifre.BackColor = System.Drawing.SystemColors.Window;
            this.btnYeniŞifre.FlatAppearance.BorderSize = 0;
            this.btnYeniŞifre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniŞifre.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniŞifre.ForeColor = System.Drawing.Color.Black;
            this.btnYeniŞifre.Location = new System.Drawing.Point(50, 287);
            this.btnYeniŞifre.Name = "btnYeniŞifre";
            this.btnYeniŞifre.Size = new System.Drawing.Size(303, 41);
            this.btnYeniŞifre.TabIndex = 27;
            this.btnYeniŞifre.Text = "Yeni Şifre Gönder";
            this.btnYeniŞifre.UseVisualStyleBackColor = false;
            this.btnYeniŞifre.Click += new System.EventHandler(this.btnYeniŞifre_Click);
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
            // panelAlt
            // 
            this.panelAlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelAlt.Controls.Add(this.progressBarYükleme);
            this.panelAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAlt.Location = new System.Drawing.Point(0, 399);
            this.panelAlt.Name = "panelAlt";
            this.panelAlt.Size = new System.Drawing.Size(400, 56);
            this.panelAlt.TabIndex = 17;
            // 
            // lblŞifremiUnuttum
            // 
            this.lblŞifremiUnuttum.AutoSize = true;
            this.lblŞifremiUnuttum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblŞifremiUnuttum.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblŞifremiUnuttum.ForeColor = System.Drawing.SystemColors.Window;
            this.lblŞifremiUnuttum.Location = new System.Drawing.Point(95, 22);
            this.lblŞifremiUnuttum.Name = "lblŞifremiUnuttum";
            this.lblŞifremiUnuttum.Size = new System.Drawing.Size(237, 39);
            this.lblŞifremiUnuttum.TabIndex = 1;
            this.lblŞifremiUnuttum.Text = "Şifremi Unuttum";
            this.lblŞifremiUnuttum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelÜst
            // 
            this.panelÜst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelÜst.Controls.Add(this.picBoxLogo);
            this.panelÜst.Controls.Add(this.picBoxAyarlar);
            this.panelÜst.Controls.Add(this.lblŞifremiUnuttum);
            this.panelÜst.Controls.Add(this.picBoxÇıkış);
            this.panelÜst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelÜst.Location = new System.Drawing.Point(0, 0);
            this.panelÜst.Name = "panelÜst";
            this.panelÜst.Size = new System.Drawing.Size(400, 85);
            this.panelÜst.TabIndex = 15;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(26, 12);
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
            // txtBoxKulAdıMail
            // 
            this.txtBoxKulAdıMail.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxKulAdıMail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxKulAdıMail.Location = new System.Drawing.Point(50, 138);
            this.txtBoxKulAdıMail.MaxLength = 30;
            this.txtBoxKulAdıMail.Multiline = true;
            this.txtBoxKulAdıMail.Name = "txtBoxKulAdıMail";
            this.txtBoxKulAdıMail.Size = new System.Drawing.Size(303, 31);
            this.txtBoxKulAdıMail.TabIndex = 28;
            this.txtBoxKulAdıMail.Text = "Kullanıcı Adı Veya E-Mail Adresi";
            this.txtBoxKulAdıMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxKulAdıMail.Click += new System.EventHandler(this.txtBoxKulAdıMail_Click);
            // 
            // txtBoxResim
            // 
            this.txtBoxResim.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxResim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxResim.Location = new System.Drawing.Point(50, 239);
            this.txtBoxResim.MaxLength = 10;
            this.txtBoxResim.Multiline = true;
            this.txtBoxResim.Name = "txtBoxResim";
            this.txtBoxResim.Size = new System.Drawing.Size(303, 31);
            this.txtBoxResim.TabIndex = 30;
            this.txtBoxResim.Text = "Karakterleri buraya giriniz";
            this.txtBoxResim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxResim.Click += new System.EventHandler(this.txtBoxResim_Click);
            // 
            // lblCaptcha
            // 
            this.lblCaptcha.AutoSize = true;
            this.lblCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCaptcha.ForeColor = System.Drawing.Color.White;
            this.lblCaptcha.Location = new System.Drawing.Point(43, 184);
            this.lblCaptcha.Name = "lblCaptcha";
            this.lblCaptcha.Size = new System.Drawing.Size(175, 38);
            this.lblCaptcha.TabIndex = 31;
            this.lblCaptcha.Text = "CAPTCHA";
            this.lblCaptcha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnYeniResim
            // 
            this.btnYeniResim.BackColor = System.Drawing.Color.White;
            this.btnYeniResim.FlatAppearance.BorderSize = 0;
            this.btnYeniResim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniResim.Image = global::Store_Manager.Properties.Resources.recaptcha;
            this.btnYeniResim.Location = new System.Drawing.Point(312, 184);
            this.btnYeniResim.Name = "btnYeniResim";
            this.btnYeniResim.Size = new System.Drawing.Size(41, 39);
            this.btnYeniResim.TabIndex = 32;
            this.btnYeniResim.UseVisualStyleBackColor = false;
            this.btnYeniResim.Click += new System.EventHandler(this.btnYeniResim_Click);
            // 
            // ŞifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(400, 455);
            this.Controls.Add(this.btnYeniResim);
            this.Controls.Add(this.lblCaptcha);
            this.Controls.Add(this.txtBoxResim);
            this.Controls.Add(this.txtBoxKulAdıMail);
            this.Controls.Add(this.btnYeniŞifre);
            this.Controls.Add(this.panelAlt);
            this.Controls.Add(this.panelÜst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ŞifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ŞifremiUnuttum";
            this.Activated += new System.EventHandler(this.ŞifremiUnuttum_Activated);
            this.Load += new System.EventHandler(this.ŞifremiUnuttum_Load);
            this.panelAlt.ResumeLayout(false);
            this.panelÜst.ResumeLayout(false);
            this.panelÜst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAyarlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxÇıkış)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.PictureBox picBoxÇıkış;
        private System.Windows.Forms.Timer timerZaman;
        private System.Windows.Forms.Button btnYeniŞifre;
        private System.Windows.Forms.ProgressBar progressBarYükleme;
        private System.Windows.Forms.Panel panelAlt;
        private System.Windows.Forms.PictureBox picBoxAyarlar;
        private System.Windows.Forms.Label lblŞifremiUnuttum;
        private System.Windows.Forms.Panel panelÜst;
        private System.Windows.Forms.TextBox txtBoxKulAdıMail;
        private System.Windows.Forms.TextBox txtBoxResim;
        private System.Windows.Forms.Label lblCaptcha;
        private System.Windows.Forms.Button btnYeniResim;
        private System.Windows.Forms.ToolTip Açıklama;
    }
}
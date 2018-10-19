namespace Store_Manager
{
    partial class AlarmMailGönder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmMailGönder));
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.btnMailGönder = new System.Windows.Forms.Button();
            this.txtBoxKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.txtBoxMailAdresiniz = new System.Windows.Forms.TextBox();
            this.txtBoxÜrünAdı = new System.Windows.Forms.TextBox();
            this.txtBoxÜrünAdedi = new System.Windows.Forms.TextBox();
            this.cmbBoxTedarikçiAdıSoyadı = new System.Windows.Forms.ComboBox();
            this.txtBoxMailŞifre = new System.Windows.Forms.TextBox();
            this.picBoxGöster = new System.Windows.Forms.PictureBox();
            this.Açıklama = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGöster)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxMail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxMail.Location = new System.Drawing.Point(226, 279);
            this.txtBoxMail.MaxLength = 30;
            this.txtBoxMail.Multiline = true;
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(303, 27);
            this.txtBoxMail.TabIndex = 20;
            this.txtBoxMail.Text = "Tedarikçi E - Mail";
            this.txtBoxMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMailGönder
            // 
            this.btnMailGönder.BackColor = System.Drawing.SystemColors.Window;
            this.btnMailGönder.FlatAppearance.BorderSize = 0;
            this.btnMailGönder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMailGönder.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMailGönder.ForeColor = System.Drawing.Color.Black;
            this.btnMailGönder.Location = new System.Drawing.Point(226, 378);
            this.btnMailGönder.Name = "btnMailGönder";
            this.btnMailGönder.Size = new System.Drawing.Size(303, 41);
            this.btnMailGönder.TabIndex = 22;
            this.btnMailGönder.Text = "Mail Gönder";
            this.btnMailGönder.UseVisualStyleBackColor = false;
            this.btnMailGönder.Click += new System.EventHandler(this.btnMailGönder_Click);
            // 
            // txtBoxKullanıcıAdı
            // 
            this.txtBoxKullanıcıAdı.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxKullanıcıAdı.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxKullanıcıAdı.Location = new System.Drawing.Point(226, 208);
            this.txtBoxKullanıcıAdı.MaxLength = 11;
            this.txtBoxKullanıcıAdı.Multiline = true;
            this.txtBoxKullanıcıAdı.Name = "txtBoxKullanıcıAdı";
            this.txtBoxKullanıcıAdı.ReadOnly = true;
            this.txtBoxKullanıcıAdı.Size = new System.Drawing.Size(303, 27);
            this.txtBoxKullanıcıAdı.TabIndex = 18;
            this.txtBoxKullanıcıAdı.Text = "Kullanıcı Adınız";
            this.txtBoxKullanıcıAdı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxMailAdresiniz
            // 
            this.txtBoxMailAdresiniz.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxMailAdresiniz.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxMailAdresiniz.Location = new System.Drawing.Point(226, 135);
            this.txtBoxMailAdresiniz.MaxLength = 15;
            this.txtBoxMailAdresiniz.Multiline = true;
            this.txtBoxMailAdresiniz.Name = "txtBoxMailAdresiniz";
            this.txtBoxMailAdresiniz.ReadOnly = true;
            this.txtBoxMailAdresiniz.Size = new System.Drawing.Size(303, 27);
            this.txtBoxMailAdresiniz.TabIndex = 16;
            this.txtBoxMailAdresiniz.Text = "E - Mail Adresiniz";
            this.txtBoxMailAdresiniz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxÜrünAdı
            // 
            this.txtBoxÜrünAdı.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxÜrünAdı.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxÜrünAdı.Location = new System.Drawing.Point(226, 312);
            this.txtBoxÜrünAdı.MaxLength = 30;
            this.txtBoxÜrünAdı.Multiline = true;
            this.txtBoxÜrünAdı.Name = "txtBoxÜrünAdı";
            this.txtBoxÜrünAdı.ReadOnly = true;
            this.txtBoxÜrünAdı.Size = new System.Drawing.Size(303, 27);
            this.txtBoxÜrünAdı.TabIndex = 24;
            this.txtBoxÜrünAdı.Text = "Ürün Adı";
            this.txtBoxÜrünAdı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxÜrünAdedi
            // 
            this.txtBoxÜrünAdedi.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxÜrünAdedi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxÜrünAdedi.Location = new System.Drawing.Point(226, 345);
            this.txtBoxÜrünAdedi.MaxLength = 30;
            this.txtBoxÜrünAdedi.Multiline = true;
            this.txtBoxÜrünAdedi.Name = "txtBoxÜrünAdedi";
            this.txtBoxÜrünAdedi.Size = new System.Drawing.Size(303, 27);
            this.txtBoxÜrünAdedi.TabIndex = 25;
            this.txtBoxÜrünAdedi.Text = "Ürün Adedi";
            this.txtBoxÜrünAdedi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxÜrünAdedi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxÜrünAdedi_KeyPress);
            // 
            // cmbBoxTedarikçiAdıSoyadı
            // 
            this.cmbBoxTedarikçiAdıSoyadı.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxTedarikçiAdıSoyadı.FormattingEnabled = true;
            this.cmbBoxTedarikçiAdıSoyadı.Location = new System.Drawing.Point(226, 241);
            this.cmbBoxTedarikçiAdıSoyadı.Name = "cmbBoxTedarikçiAdıSoyadı";
            this.cmbBoxTedarikçiAdıSoyadı.Size = new System.Drawing.Size(303, 32);
            this.cmbBoxTedarikçiAdıSoyadı.TabIndex = 29;
            this.cmbBoxTedarikçiAdıSoyadı.Text = "Tedarikçi Adı & Soyadı";
            this.cmbBoxTedarikçiAdıSoyadı.SelectedIndexChanged += new System.EventHandler(this.cmbBoxTedarikçiAdıSoyadı_SelectedIndexChanged);
            // 
            // txtBoxMailŞifre
            // 
            this.txtBoxMailŞifre.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxMailŞifre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxMailŞifre.Location = new System.Drawing.Point(226, 168);
            this.txtBoxMailŞifre.MaxLength = 30;
            this.txtBoxMailŞifre.Multiline = true;
            this.txtBoxMailŞifre.Name = "txtBoxMailŞifre";
            this.txtBoxMailŞifre.Size = new System.Drawing.Size(303, 34);
            this.txtBoxMailŞifre.TabIndex = 30;
            this.txtBoxMailŞifre.Text = "E - Mail Şifreniz";
            this.txtBoxMailŞifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picBoxGöster
            // 
            this.picBoxGöster.BackColor = System.Drawing.Color.White;
            this.picBoxGöster.Image = global::Store_Manager.Properties.Resources.Göz;
            this.picBoxGöster.Location = new System.Drawing.Point(504, 175);
            this.picBoxGöster.Name = "picBoxGöster";
            this.picBoxGöster.Size = new System.Drawing.Size(25, 20);
            this.picBoxGöster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxGöster.TabIndex = 33;
            this.picBoxGöster.TabStop = false;
            this.picBoxGöster.Click += new System.EventHandler(this.picBoxGöster_Click);
            // 
            // AlarmMailGönder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(892, 565);
            this.Controls.Add(this.picBoxGöster);
            this.Controls.Add(this.txtBoxMailŞifre);
            this.Controls.Add(this.cmbBoxTedarikçiAdıSoyadı);
            this.Controls.Add(this.txtBoxÜrünAdedi);
            this.Controls.Add(this.txtBoxÜrünAdı);
            this.Controls.Add(this.txtBoxMail);
            this.Controls.Add(this.btnMailGönder);
            this.Controls.Add(this.txtBoxKullanıcıAdı);
            this.Controls.Add(this.txtBoxMailAdresiniz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlarmMailGönder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlarmMailGönder";
            this.Load += new System.EventHandler(this.AlarmMailGönder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGöster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.Button btnMailGönder;
        private System.Windows.Forms.TextBox txtBoxKullanıcıAdı;
        private System.Windows.Forms.TextBox txtBoxMailAdresiniz;
        private System.Windows.Forms.TextBox txtBoxÜrünAdı;
        private System.Windows.Forms.TextBox txtBoxÜrünAdedi;
        private System.Windows.Forms.ComboBox cmbBoxTedarikçiAdıSoyadı;
        private System.Windows.Forms.TextBox txtBoxMailŞifre;
        private System.Windows.Forms.PictureBox picBoxGöster;
        private System.Windows.Forms.ToolTip Açıklama;
    }
}
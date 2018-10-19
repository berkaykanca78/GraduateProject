namespace Store_Manager
{
    partial class MüşteriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MüşteriEkle));
            this.txtBoxAdres = new System.Windows.Forms.TextBox();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.txtBoxTelNo = new System.Windows.Forms.TextBox();
            this.btnMüşteriEkle = new System.Windows.Forms.Button();
            this.txtBoxTCNo = new System.Windows.Forms.TextBox();
            this.txtBoxSoyadı = new System.Windows.Forms.TextBox();
            this.txtBoxAdı = new System.Windows.Forms.TextBox();
            this.Açıklama = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtBoxAdres
            // 
            this.txtBoxAdres.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxAdres.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxAdres.Location = new System.Drawing.Point(227, 259);
            this.txtBoxAdres.MaxLength = 15;
            this.txtBoxAdres.Multiline = true;
            this.txtBoxAdres.Name = "txtBoxAdres";
            this.txtBoxAdres.Size = new System.Drawing.Size(303, 52);
            this.txtBoxAdres.TabIndex = 6;
            this.txtBoxAdres.Text = "Adres";
            this.txtBoxAdres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxAdres.Click += new System.EventHandler(this.txtBoxAdres_Click);
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxMail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxMail.Location = new System.Drawing.Point(227, 226);
            this.txtBoxMail.MaxLength = 30;
            this.txtBoxMail.Multiline = true;
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(303, 27);
            this.txtBoxMail.TabIndex = 5;
            this.txtBoxMail.Text = "E - Mail";
            this.txtBoxMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxMail.Click += new System.EventHandler(this.txtBoxMail_Click);
            // 
            // txtBoxTelNo
            // 
            this.txtBoxTelNo.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxTelNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxTelNo.Location = new System.Drawing.Point(227, 193);
            this.txtBoxTelNo.MaxLength = 10;
            this.txtBoxTelNo.Multiline = true;
            this.txtBoxTelNo.Name = "txtBoxTelNo";
            this.txtBoxTelNo.Size = new System.Drawing.Size(303, 27);
            this.txtBoxTelNo.TabIndex = 4;
            this.txtBoxTelNo.Text = "Telefon Numarası";
            this.txtBoxTelNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxTelNo.Click += new System.EventHandler(this.txtBoxTelNo_Click);
            this.txtBoxTelNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTelNo_KeyPress);
            // 
            // btnMüşteriEkle
            // 
            this.btnMüşteriEkle.BackColor = System.Drawing.SystemColors.Window;
            this.btnMüşteriEkle.FlatAppearance.BorderSize = 0;
            this.btnMüşteriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMüşteriEkle.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMüşteriEkle.ForeColor = System.Drawing.Color.Black;
            this.btnMüşteriEkle.Location = new System.Drawing.Point(227, 347);
            this.btnMüşteriEkle.Name = "btnMüşteriEkle";
            this.btnMüşteriEkle.Size = new System.Drawing.Size(303, 41);
            this.btnMüşteriEkle.TabIndex = 7;
            this.btnMüşteriEkle.Text = "Müşteri Ekle";
            this.btnMüşteriEkle.UseVisualStyleBackColor = false;
            this.btnMüşteriEkle.Click += new System.EventHandler(this.btnMüşteriEkle_Click);
            // 
            // txtBoxTCNo
            // 
            this.txtBoxTCNo.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxTCNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxTCNo.Location = new System.Drawing.Point(227, 160);
            this.txtBoxTCNo.MaxLength = 11;
            this.txtBoxTCNo.Multiline = true;
            this.txtBoxTCNo.Name = "txtBoxTCNo";
            this.txtBoxTCNo.Size = new System.Drawing.Size(303, 27);
            this.txtBoxTCNo.TabIndex = 3;
            this.txtBoxTCNo.Text = "TC Kimlik Numarası";
            this.txtBoxTCNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxTCNo.Click += new System.EventHandler(this.txtBoxTCNo_Click);
            this.txtBoxTCNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTCNo_KeyPress);
            this.txtBoxTCNo.Leave += new System.EventHandler(this.txtBoxTCNo_Leave);
            // 
            // txtBoxSoyadı
            // 
            this.txtBoxSoyadı.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxSoyadı.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxSoyadı.Location = new System.Drawing.Point(227, 127);
            this.txtBoxSoyadı.MaxLength = 15;
            this.txtBoxSoyadı.Multiline = true;
            this.txtBoxSoyadı.Name = "txtBoxSoyadı";
            this.txtBoxSoyadı.Size = new System.Drawing.Size(303, 27);
            this.txtBoxSoyadı.TabIndex = 2;
            this.txtBoxSoyadı.Text = "Soyadı";
            this.txtBoxSoyadı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxSoyadı.Click += new System.EventHandler(this.txtBoxSoyadı_Click);
            this.txtBoxSoyadı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSoyadı_KeyPress);
            // 
            // txtBoxAdı
            // 
            this.txtBoxAdı.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxAdı.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxAdı.Location = new System.Drawing.Point(227, 94);
            this.txtBoxAdı.MaxLength = 15;
            this.txtBoxAdı.Multiline = true;
            this.txtBoxAdı.Name = "txtBoxAdı";
            this.txtBoxAdı.Size = new System.Drawing.Size(303, 27);
            this.txtBoxAdı.TabIndex = 1;
            this.txtBoxAdı.Text = "Adı";
            this.txtBoxAdı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxAdı.Click += new System.EventHandler(this.txtBoxAdı_Click);
            this.txtBoxAdı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxAdı_KeyPress);
            // 
            // MüşteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(892, 565);
            this.Controls.Add(this.txtBoxAdres);
            this.Controls.Add(this.txtBoxMail);
            this.Controls.Add(this.txtBoxTelNo);
            this.Controls.Add(this.btnMüşteriEkle);
            this.Controls.Add(this.txtBoxTCNo);
            this.Controls.Add(this.txtBoxSoyadı);
            this.Controls.Add(this.txtBoxAdı);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MüşteriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri";
            this.Activated += new System.EventHandler(this.Müşteri_Activated);
            this.Load += new System.EventHandler(this.Müşteri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxAdres;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.TextBox txtBoxTelNo;
        private System.Windows.Forms.Button btnMüşteriEkle;
        private System.Windows.Forms.TextBox txtBoxTCNo;
        private System.Windows.Forms.TextBox txtBoxSoyadı;
        private System.Windows.Forms.TextBox txtBoxAdı;
        private System.Windows.Forms.ToolTip Açıklama;
    }
}
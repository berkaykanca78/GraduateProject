namespace Store_Manager
{
    partial class SatışYap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatışYap));
            this.txtBoxTaksitSayısı = new System.Windows.Forms.TextBox();
            this.lblSatışTürü = new System.Windows.Forms.Label();
            this.cmbBoxMüşteriAdıSoyadı = new System.Windows.Forms.ComboBox();
            this.rBtnKrediKartı = new System.Windows.Forms.RadioButton();
            this.rBtnSenet = new System.Windows.Forms.RadioButton();
            this.rBtnPeşin = new System.Windows.Forms.RadioButton();
            this.txtBoxToplamÜcret = new System.Windows.Forms.TextBox();
            this.cmbBoxÜrünNumarası = new System.Windows.Forms.ComboBox();
            this.btnSatışYap = new System.Windows.Forms.Button();
            this.Açıklama = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtBoxTaksitSayısı
            // 
            this.txtBoxTaksitSayısı.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxTaksitSayısı.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxTaksitSayısı.Location = new System.Drawing.Point(234, 259);
            this.txtBoxTaksitSayısı.MaxLength = 10;
            this.txtBoxTaksitSayısı.Multiline = true;
            this.txtBoxTaksitSayısı.Name = "txtBoxTaksitSayısı";
            this.txtBoxTaksitSayısı.Size = new System.Drawing.Size(303, 27);
            this.txtBoxTaksitSayısı.TabIndex = 45;
            this.txtBoxTaksitSayısı.Text = "Taksit Sayısı";
            this.txtBoxTaksitSayısı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxTaksitSayısı.Visible = false;
            // 
            // lblSatışTürü
            // 
            this.lblSatışTürü.AutoSize = true;
            this.lblSatışTürü.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatışTürü.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSatışTürü.Location = new System.Drawing.Point(178, 229);
            this.lblSatışTürü.Name = "lblSatışTürü";
            this.lblSatışTürü.Size = new System.Drawing.Size(99, 24);
            this.lblSatışTürü.TabIndex = 44;
            this.lblSatışTürü.Text = "Satış Türü:";
            // 
            // cmbBoxMüşteriAdıSoyadı
            // 
            this.cmbBoxMüşteriAdıSoyadı.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxMüşteriAdıSoyadı.FormattingEnabled = true;
            this.cmbBoxMüşteriAdıSoyadı.Location = new System.Drawing.Point(234, 158);
            this.cmbBoxMüşteriAdıSoyadı.Name = "cmbBoxMüşteriAdıSoyadı";
            this.cmbBoxMüşteriAdıSoyadı.Size = new System.Drawing.Size(303, 32);
            this.cmbBoxMüşteriAdıSoyadı.TabIndex = 43;
            this.cmbBoxMüşteriAdıSoyadı.Text = "Müşteri Adı & Soyadı";
            // 
            // rBtnKrediKartı
            // 
            this.rBtnKrediKartı.AutoSize = true;
            this.rBtnKrediKartı.ForeColor = System.Drawing.SystemColors.Window;
            this.rBtnKrediKartı.Location = new System.Drawing.Point(484, 232);
            this.rBtnKrediKartı.Name = "rBtnKrediKartı";
            this.rBtnKrediKartı.Size = new System.Drawing.Size(95, 21);
            this.rBtnKrediKartı.TabIndex = 42;
            this.rBtnKrediKartı.TabStop = true;
            this.rBtnKrediKartı.Text = "Kredi Kartı";
            this.rBtnKrediKartı.UseVisualStyleBackColor = true;
            // 
            // rBtnSenet
            // 
            this.rBtnSenet.AutoSize = true;
            this.rBtnSenet.ForeColor = System.Drawing.SystemColors.Window;
            this.rBtnSenet.Location = new System.Drawing.Point(379, 232);
            this.rBtnSenet.Name = "rBtnSenet";
            this.rBtnSenet.Size = new System.Drawing.Size(66, 21);
            this.rBtnSenet.TabIndex = 41;
            this.rBtnSenet.TabStop = true;
            this.rBtnSenet.Text = "Senet";
            this.rBtnSenet.UseVisualStyleBackColor = true;
            this.rBtnSenet.CheckedChanged += new System.EventHandler(this.rBtnSenet_CheckedChanged);
            // 
            // rBtnPeşin
            // 
            this.rBtnPeşin.AutoSize = true;
            this.rBtnPeşin.ForeColor = System.Drawing.SystemColors.Window;
            this.rBtnPeşin.Location = new System.Drawing.Point(299, 232);
            this.rBtnPeşin.Name = "rBtnPeşin";
            this.rBtnPeşin.Size = new System.Drawing.Size(64, 21);
            this.rBtnPeşin.TabIndex = 40;
            this.rBtnPeşin.TabStop = true;
            this.rBtnPeşin.Text = "Peşin";
            this.rBtnPeşin.UseVisualStyleBackColor = true;
            // 
            // txtBoxToplamÜcret
            // 
            this.txtBoxToplamÜcret.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxToplamÜcret.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxToplamÜcret.Location = new System.Drawing.Point(234, 196);
            this.txtBoxToplamÜcret.MaxLength = 10;
            this.txtBoxToplamÜcret.Multiline = true;
            this.txtBoxToplamÜcret.Name = "txtBoxToplamÜcret";
            this.txtBoxToplamÜcret.Size = new System.Drawing.Size(303, 30);
            this.txtBoxToplamÜcret.TabIndex = 39;
            this.txtBoxToplamÜcret.Text = "Toplam Ücret (₺)";
            this.txtBoxToplamÜcret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbBoxÜrünNumarası
            // 
            this.cmbBoxÜrünNumarası.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxÜrünNumarası.FormattingEnabled = true;
            this.cmbBoxÜrünNumarası.Location = new System.Drawing.Point(234, 120);
            this.cmbBoxÜrünNumarası.Name = "cmbBoxÜrünNumarası";
            this.cmbBoxÜrünNumarası.Size = new System.Drawing.Size(303, 32);
            this.cmbBoxÜrünNumarası.TabIndex = 38;
            this.cmbBoxÜrünNumarası.Text = "Ürün Numarası";
            this.cmbBoxÜrünNumarası.SelectedIndexChanged += new System.EventHandler(this.cmbBoxÜrünNumarası_SelectedIndexChanged);
            // 
            // btnSatışYap
            // 
            this.btnSatışYap.BackColor = System.Drawing.SystemColors.Window;
            this.btnSatışYap.FlatAppearance.BorderSize = 0;
            this.btnSatışYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatışYap.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatışYap.ForeColor = System.Drawing.Color.Black;
            this.btnSatışYap.Location = new System.Drawing.Point(234, 292);
            this.btnSatışYap.Name = "btnSatışYap";
            this.btnSatışYap.Size = new System.Drawing.Size(303, 41);
            this.btnSatışYap.TabIndex = 36;
            this.btnSatışYap.Text = "Satış Yap";
            this.btnSatışYap.UseVisualStyleBackColor = false;
            this.btnSatışYap.Click += new System.EventHandler(this.btnSatışYap_Click);
            // 
            // SatışYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(892, 565);
            this.Controls.Add(this.txtBoxTaksitSayısı);
            this.Controls.Add(this.lblSatışTürü);
            this.Controls.Add(this.cmbBoxMüşteriAdıSoyadı);
            this.Controls.Add(this.rBtnKrediKartı);
            this.Controls.Add(this.rBtnSenet);
            this.Controls.Add(this.rBtnPeşin);
            this.Controls.Add(this.txtBoxToplamÜcret);
            this.Controls.Add(this.cmbBoxÜrünNumarası);
            this.Controls.Add(this.btnSatışYap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SatışYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatışYap";
            this.Activated += new System.EventHandler(this.SatışYap_Activated);
            this.Load += new System.EventHandler(this.SatışYap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxTaksitSayısı;
        private System.Windows.Forms.Label lblSatışTürü;
        private System.Windows.Forms.ComboBox cmbBoxMüşteriAdıSoyadı;
        private System.Windows.Forms.RadioButton rBtnKrediKartı;
        private System.Windows.Forms.RadioButton rBtnSenet;
        private System.Windows.Forms.RadioButton rBtnPeşin;
        private System.Windows.Forms.TextBox txtBoxToplamÜcret;
        private System.Windows.Forms.ComboBox cmbBoxÜrünNumarası;
        private System.Windows.Forms.Button btnSatışYap;
        private System.Windows.Forms.ToolTip Açıklama;
    }
}
namespace Store_Manager
{
    partial class BorçÖde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorçÖde));
            this.txtBoxKalanTaksitSayısı = new System.Windows.Forms.TextBox();
            this.cmbBoxMüşteriAdıSoyadı = new System.Windows.Forms.ComboBox();
            this.txtBoxÖdenecekÜcret = new System.Windows.Forms.TextBox();
            this.btnBorçÖde = new System.Windows.Forms.Button();
            this.txtBoxKalanBorç = new System.Windows.Forms.TextBox();
            this.cmbBoxÜrünNumarası = new System.Windows.Forms.ComboBox();
            this.Açıklama = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtBoxKalanTaksitSayısı
            // 
            this.txtBoxKalanTaksitSayısı.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxKalanTaksitSayısı.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxKalanTaksitSayısı.Location = new System.Drawing.Point(234, 233);
            this.txtBoxKalanTaksitSayısı.MaxLength = 10;
            this.txtBoxKalanTaksitSayısı.Multiline = true;
            this.txtBoxKalanTaksitSayısı.Name = "txtBoxKalanTaksitSayısı";
            this.txtBoxKalanTaksitSayısı.ReadOnly = true;
            this.txtBoxKalanTaksitSayısı.Size = new System.Drawing.Size(303, 28);
            this.txtBoxKalanTaksitSayısı.TabIndex = 54;
            this.txtBoxKalanTaksitSayısı.Text = "Kalan Taksit Sayısı";
            this.txtBoxKalanTaksitSayısı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbBoxMüşteriAdıSoyadı
            // 
            this.cmbBoxMüşteriAdıSoyadı.DisplayMember = "Customer_TC_No";
            this.cmbBoxMüşteriAdıSoyadı.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxMüşteriAdıSoyadı.FormattingEnabled = true;
            this.cmbBoxMüşteriAdıSoyadı.Location = new System.Drawing.Point(234, 120);
            this.cmbBoxMüşteriAdıSoyadı.Name = "cmbBoxMüşteriAdıSoyadı";
            this.cmbBoxMüşteriAdıSoyadı.Size = new System.Drawing.Size(303, 32);
            this.cmbBoxMüşteriAdıSoyadı.TabIndex = 52;
            this.cmbBoxMüşteriAdıSoyadı.Text = "Müşteri Adı & Soyadı";
            this.cmbBoxMüşteriAdıSoyadı.ValueMember = "Customer_TC_No";
            this.cmbBoxMüşteriAdıSoyadı.SelectedIndexChanged += new System.EventHandler(this.cmbBoxMüşteriAdıSoyadı_SelectedIndexChanged);
            // 
            // txtBoxÖdenecekÜcret
            // 
            this.txtBoxÖdenecekÜcret.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxÖdenecekÜcret.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxÖdenecekÜcret.Location = new System.Drawing.Point(234, 196);
            this.txtBoxÖdenecekÜcret.MaxLength = 10;
            this.txtBoxÖdenecekÜcret.Multiline = true;
            this.txtBoxÖdenecekÜcret.Name = "txtBoxÖdenecekÜcret";
            this.txtBoxÖdenecekÜcret.ReadOnly = true;
            this.txtBoxÖdenecekÜcret.Size = new System.Drawing.Size(303, 31);
            this.txtBoxÖdenecekÜcret.TabIndex = 48;
            this.txtBoxÖdenecekÜcret.Text = "Ödenecek Ücret (₺)";
            this.txtBoxÖdenecekÜcret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBorçÖde
            // 
            this.btnBorçÖde.BackColor = System.Drawing.SystemColors.Window;
            this.btnBorçÖde.FlatAppearance.BorderSize = 0;
            this.btnBorçÖde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorçÖde.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBorçÖde.ForeColor = System.Drawing.Color.Black;
            this.btnBorçÖde.Location = new System.Drawing.Point(234, 304);
            this.btnBorçÖde.Name = "btnBorçÖde";
            this.btnBorçÖde.Size = new System.Drawing.Size(303, 41);
            this.btnBorçÖde.TabIndex = 46;
            this.btnBorçÖde.Text = "Borç Öde";
            this.btnBorçÖde.UseVisualStyleBackColor = false;
            this.btnBorçÖde.Click += new System.EventHandler(this.btnBorçÖde_Click);
            // 
            // txtBoxKalanBorç
            // 
            this.txtBoxKalanBorç.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxKalanBorç.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxKalanBorç.Location = new System.Drawing.Point(234, 267);
            this.txtBoxKalanBorç.MaxLength = 10;
            this.txtBoxKalanBorç.Multiline = true;
            this.txtBoxKalanBorç.Name = "txtBoxKalanBorç";
            this.txtBoxKalanBorç.ReadOnly = true;
            this.txtBoxKalanBorç.Size = new System.Drawing.Size(303, 31);
            this.txtBoxKalanBorç.TabIndex = 56;
            this.txtBoxKalanBorç.Text = "Kalan Borç (₺)";
            this.txtBoxKalanBorç.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbBoxÜrünNumarası
            // 
            this.cmbBoxÜrünNumarası.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxÜrünNumarası.FormattingEnabled = true;
            this.cmbBoxÜrünNumarası.Location = new System.Drawing.Point(234, 158);
            this.cmbBoxÜrünNumarası.Name = "cmbBoxÜrünNumarası";
            this.cmbBoxÜrünNumarası.Size = new System.Drawing.Size(303, 32);
            this.cmbBoxÜrünNumarası.TabIndex = 57;
            this.cmbBoxÜrünNumarası.Text = "Ürün Numarası";
            this.cmbBoxÜrünNumarası.SelectedIndexChanged += new System.EventHandler(this.cmbBoxÜrünNumarası_SelectedIndexChanged);
            // 
            // BorçÖde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(892, 565);
            this.Controls.Add(this.cmbBoxÜrünNumarası);
            this.Controls.Add(this.txtBoxKalanBorç);
            this.Controls.Add(this.txtBoxKalanTaksitSayısı);
            this.Controls.Add(this.cmbBoxMüşteriAdıSoyadı);
            this.Controls.Add(this.txtBoxÖdenecekÜcret);
            this.Controls.Add(this.btnBorçÖde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BorçÖde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorçÖde";
            this.Activated += new System.EventHandler(this.BorçÖde_Activated);
            this.Load += new System.EventHandler(this.BorçÖde_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxKalanTaksitSayısı;
        private System.Windows.Forms.ComboBox cmbBoxMüşteriAdıSoyadı;
        private System.Windows.Forms.TextBox txtBoxÖdenecekÜcret;
        private System.Windows.Forms.Button btnBorçÖde;
        private System.Windows.Forms.TextBox txtBoxKalanBorç;
        private System.Windows.Forms.ComboBox cmbBoxÜrünNumarası;
        private System.Windows.Forms.ToolTip Açıklama;
    }
}
namespace Store_Manager
{
    partial class MağazayaÜrünEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MağazayaÜrünEkle));
            this.btnÜrünEkle = new System.Windows.Forms.Button();
            this.cmbBoxDepoNo = new System.Windows.Forms.ComboBox();
            this.cmbBoxÜrünNumarası = new System.Windows.Forms.ComboBox();
            this.cmbBoxMağazaNo = new System.Windows.Forms.ComboBox();
            this.Açıklama = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnÜrünEkle
            // 
            this.btnÜrünEkle.BackColor = System.Drawing.SystemColors.Window;
            this.btnÜrünEkle.FlatAppearance.BorderSize = 0;
            this.btnÜrünEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÜrünEkle.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÜrünEkle.ForeColor = System.Drawing.Color.Black;
            this.btnÜrünEkle.Location = new System.Drawing.Point(227, 263);
            this.btnÜrünEkle.Name = "btnÜrünEkle";
            this.btnÜrünEkle.Size = new System.Drawing.Size(303, 41);
            this.btnÜrünEkle.TabIndex = 22;
            this.btnÜrünEkle.Text = "Mağazaya Ürün Ekle";
            this.btnÜrünEkle.UseVisualStyleBackColor = false;
            this.btnÜrünEkle.Click += new System.EventHandler(this.btnÜrünEkle_Click);
            // 
            // cmbBoxDepoNo
            // 
            this.cmbBoxDepoNo.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxDepoNo.FormattingEnabled = true;
            this.cmbBoxDepoNo.Location = new System.Drawing.Point(227, 118);
            this.cmbBoxDepoNo.Name = "cmbBoxDepoNo";
            this.cmbBoxDepoNo.Size = new System.Drawing.Size(303, 32);
            this.cmbBoxDepoNo.TabIndex = 26;
            this.cmbBoxDepoNo.Text = "Depo Numarası";
            this.cmbBoxDepoNo.SelectedIndexChanged += new System.EventHandler(this.cmbBoxDepoNo_SelectedIndexChanged);
            // 
            // cmbBoxÜrünNumarası
            // 
            this.cmbBoxÜrünNumarası.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxÜrünNumarası.FormattingEnabled = true;
            this.cmbBoxÜrünNumarası.Location = new System.Drawing.Point(227, 156);
            this.cmbBoxÜrünNumarası.Name = "cmbBoxÜrünNumarası";
            this.cmbBoxÜrünNumarası.Size = new System.Drawing.Size(303, 32);
            this.cmbBoxÜrünNumarası.TabIndex = 27;
            this.cmbBoxÜrünNumarası.Text = "Ürün Numarası";
            // 
            // cmbBoxMağazaNo
            // 
            this.cmbBoxMağazaNo.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxMağazaNo.FormattingEnabled = true;
            this.cmbBoxMağazaNo.Location = new System.Drawing.Point(227, 194);
            this.cmbBoxMağazaNo.Name = "cmbBoxMağazaNo";
            this.cmbBoxMağazaNo.Size = new System.Drawing.Size(303, 32);
            this.cmbBoxMağazaNo.TabIndex = 28;
            this.cmbBoxMağazaNo.Text = "Mağaza Numarası";
            // 
            // MağazayaÜrünEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(892, 565);
            this.Controls.Add(this.cmbBoxMağazaNo);
            this.Controls.Add(this.cmbBoxÜrünNumarası);
            this.Controls.Add(this.cmbBoxDepoNo);
            this.Controls.Add(this.btnÜrünEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MağazayaÜrünEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MağazayaÜrünEkle";
            this.Activated += new System.EventHandler(this.MağazayaÜrünEkle_Activated);
            this.Load += new System.EventHandler(this.MağazayaÜrünEkle_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnÜrünEkle;
        private System.Windows.Forms.ComboBox cmbBoxDepoNo;
        private System.Windows.Forms.ComboBox cmbBoxÜrünNumarası;
        private System.Windows.Forms.ComboBox cmbBoxMağazaNo;
        private System.Windows.Forms.ToolTip Açıklama;
    }
}
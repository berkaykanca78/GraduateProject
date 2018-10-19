namespace Store_Manager
{
    partial class DepoEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepoEkle));
            this.txtBoxAdres = new System.Windows.Forms.TextBox();
            this.txtBoxTelNo = new System.Windows.Forms.TextBox();
            this.btnDepoEkle = new System.Windows.Forms.Button();
            this.txtBoxDepoNo = new System.Windows.Forms.TextBox();
            this.Açıklama = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtBoxAdres
            // 
            this.txtBoxAdres.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxAdres.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxAdres.Location = new System.Drawing.Point(227, 192);
            this.txtBoxAdres.MaxLength = 15;
            this.txtBoxAdres.Multiline = true;
            this.txtBoxAdres.Name = "txtBoxAdres";
            this.txtBoxAdres.Size = new System.Drawing.Size(303, 52);
            this.txtBoxAdres.TabIndex = 25;
            this.txtBoxAdres.Text = "Adres";
            this.txtBoxAdres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxTelNo
            // 
            this.txtBoxTelNo.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxTelNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxTelNo.Location = new System.Drawing.Point(227, 159);
            this.txtBoxTelNo.MaxLength = 10;
            this.txtBoxTelNo.Multiline = true;
            this.txtBoxTelNo.Name = "txtBoxTelNo";
            this.txtBoxTelNo.Size = new System.Drawing.Size(303, 27);
            this.txtBoxTelNo.TabIndex = 24;
            this.txtBoxTelNo.Text = "Telefon Numarası";
            this.txtBoxTelNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDepoEkle
            // 
            this.btnDepoEkle.BackColor = System.Drawing.SystemColors.Window;
            this.btnDepoEkle.FlatAppearance.BorderSize = 0;
            this.btnDepoEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepoEkle.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepoEkle.ForeColor = System.Drawing.Color.Black;
            this.btnDepoEkle.Location = new System.Drawing.Point(227, 278);
            this.btnDepoEkle.Name = "btnDepoEkle";
            this.btnDepoEkle.Size = new System.Drawing.Size(303, 41);
            this.btnDepoEkle.TabIndex = 26;
            this.btnDepoEkle.Text = "Depo Ekle";
            this.btnDepoEkle.UseVisualStyleBackColor = false;
            this.btnDepoEkle.Click += new System.EventHandler(this.btnDepoEkle_Click);
            // 
            // txtBoxDepoNo
            // 
            this.txtBoxDepoNo.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxDepoNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxDepoNo.Location = new System.Drawing.Point(227, 124);
            this.txtBoxDepoNo.MaxLength = 15;
            this.txtBoxDepoNo.Multiline = true;
            this.txtBoxDepoNo.Name = "txtBoxDepoNo";
            this.txtBoxDepoNo.Size = new System.Drawing.Size(303, 29);
            this.txtBoxDepoNo.TabIndex = 23;
            this.txtBoxDepoNo.Text = "Depo Numarası";
            this.txtBoxDepoNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxDepoNo.Leave += new System.EventHandler(this.txtBoxDepoNo_Leave);
            // 
            // DepoEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(892, 565);
            this.Controls.Add(this.txtBoxAdres);
            this.Controls.Add(this.txtBoxTelNo);
            this.Controls.Add(this.btnDepoEkle);
            this.Controls.Add(this.txtBoxDepoNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepoEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepoEkle";
            this.Activated += new System.EventHandler(this.DepoEkle_Activated);
            this.Load += new System.EventHandler(this.DepoEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxAdres;
        private System.Windows.Forms.TextBox txtBoxTelNo;
        private System.Windows.Forms.Button btnDepoEkle;
        private System.Windows.Forms.TextBox txtBoxDepoNo;
        private System.Windows.Forms.ToolTip Açıklama;
    }
}
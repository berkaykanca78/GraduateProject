namespace Store_Manager
{
    partial class MağazaEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MağazaEkle));
            this.txtBoxAdres = new System.Windows.Forms.TextBox();
            this.txtBoxTelNo = new System.Windows.Forms.TextBox();
            this.btnMağazaEkle = new System.Windows.Forms.Button();
            this.txtBoxMağazaNo = new System.Windows.Forms.TextBox();
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
            this.txtBoxAdres.TabIndex = 21;
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
            this.txtBoxTelNo.TabIndex = 19;
            this.txtBoxTelNo.Text = "Telefon Numarası";
            this.txtBoxTelNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMağazaEkle
            // 
            this.btnMağazaEkle.BackColor = System.Drawing.SystemColors.Window;
            this.btnMağazaEkle.FlatAppearance.BorderSize = 0;
            this.btnMağazaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMağazaEkle.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMağazaEkle.ForeColor = System.Drawing.Color.Black;
            this.btnMağazaEkle.Location = new System.Drawing.Point(227, 278);
            this.btnMağazaEkle.Name = "btnMağazaEkle";
            this.btnMağazaEkle.Size = new System.Drawing.Size(303, 41);
            this.btnMağazaEkle.TabIndex = 22;
            this.btnMağazaEkle.Text = "Mağaza Ekle";
            this.btnMağazaEkle.UseVisualStyleBackColor = false;
            this.btnMağazaEkle.Click += new System.EventHandler(this.btnMağazaEkle_Click);
            // 
            // txtBoxMağazaNo
            // 
            this.txtBoxMağazaNo.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxMağazaNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxMağazaNo.Location = new System.Drawing.Point(227, 124);
            this.txtBoxMağazaNo.MaxLength = 15;
            this.txtBoxMağazaNo.Multiline = true;
            this.txtBoxMağazaNo.Name = "txtBoxMağazaNo";
            this.txtBoxMağazaNo.Size = new System.Drawing.Size(303, 29);
            this.txtBoxMağazaNo.TabIndex = 16;
            this.txtBoxMağazaNo.Text = "Mağaza Numarası";
            this.txtBoxMağazaNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxMağazaNo.Leave += new System.EventHandler(this.txtBoxMağazaNo_Leave);
            // 
            // MağazaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(892, 565);
            this.Controls.Add(this.txtBoxAdres);
            this.Controls.Add(this.txtBoxTelNo);
            this.Controls.Add(this.btnMağazaEkle);
            this.Controls.Add(this.txtBoxMağazaNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MağazaEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MağazaEkle";
            this.Activated += new System.EventHandler(this.MağazaEkle_Activated);
            this.Load += new System.EventHandler(this.MağazaEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxAdres;
        private System.Windows.Forms.TextBox txtBoxTelNo;
        private System.Windows.Forms.Button btnMağazaEkle;
        private System.Windows.Forms.TextBox txtBoxMağazaNo;
        private System.Windows.Forms.ToolTip Açıklama;
    }
}
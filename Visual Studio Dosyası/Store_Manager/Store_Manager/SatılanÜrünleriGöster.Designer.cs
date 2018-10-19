namespace Store_Manager
{
    partial class SatılanÜrünleriGöster
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatılanÜrünleriGöster));
            this.SoldProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Store_ManagerDataSet = new Store_Manager.Store_ManagerDataSet();
            this.btnSıfırla = new System.Windows.Forms.Button();
            this.txtBoxÜrünTürü = new System.Windows.Forms.TextBox();
            this.txtBoxÜrünAdı = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.raporSatılanÜrünleriGöster = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SoldProductsTableAdapter = new Store_Manager.Store_ManagerDataSetTableAdapters.SoldProductsTableAdapter();
            this.Açıklama = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SoldProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Store_ManagerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SoldProductsBindingSource
            // 
            this.SoldProductsBindingSource.DataMember = "SoldProducts";
            this.SoldProductsBindingSource.DataSource = this.Store_ManagerDataSet;
            // 
            // Store_ManagerDataSet
            // 
            this.Store_ManagerDataSet.DataSetName = "Store_ManagerDataSet";
            this.Store_ManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSıfırla
            // 
            this.btnSıfırla.BackColor = System.Drawing.Color.LightGray;
            this.btnSıfırla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSıfırla.Location = new System.Drawing.Point(425, 54);
            this.btnSıfırla.Name = "btnSıfırla";
            this.btnSıfırla.Size = new System.Drawing.Size(203, 27);
            this.btnSıfırla.TabIndex = 28;
            this.btnSıfırla.Text = "Sıfırla";
            this.btnSıfırla.UseVisualStyleBackColor = false;
            this.btnSıfırla.Click += new System.EventHandler(this.btnSıfırla_Click);
            // 
            // txtBoxÜrünTürü
            // 
            this.txtBoxÜrünTürü.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxÜrünTürü.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxÜrünTürü.Location = new System.Drawing.Point(116, 54);
            this.txtBoxÜrünTürü.MaxLength = 15;
            this.txtBoxÜrünTürü.Multiline = true;
            this.txtBoxÜrünTürü.Name = "txtBoxÜrünTürü";
            this.txtBoxÜrünTürü.Size = new System.Drawing.Size(303, 27);
            this.txtBoxÜrünTürü.TabIndex = 26;
            this.txtBoxÜrünTürü.Text = "Ürün Türü";
            this.txtBoxÜrünTürü.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxÜrünAdı
            // 
            this.txtBoxÜrünAdı.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxÜrünAdı.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxÜrünAdı.Location = new System.Drawing.Point(116, 21);
            this.txtBoxÜrünAdı.MaxLength = 15;
            this.txtBoxÜrünAdı.Multiline = true;
            this.txtBoxÜrünAdı.Name = "txtBoxÜrünAdı";
            this.txtBoxÜrünAdı.Size = new System.Drawing.Size(303, 27);
            this.txtBoxÜrünAdı.TabIndex = 25;
            this.txtBoxÜrünAdı.Text = "Ürün Adı";
            this.txtBoxÜrünAdı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.LightGray;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Location = new System.Drawing.Point(425, 21);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(203, 27);
            this.btnAra.TabIndex = 27;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // raporSatılanÜrünleriGöster
            // 
            this.raporSatılanÜrünleriGöster.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "VeriKümesi";
            reportDataSource1.Value = this.SoldProductsBindingSource;
            this.raporSatılanÜrünleriGöster.LocalReport.DataSources.Add(reportDataSource1);
            this.raporSatılanÜrünleriGöster.LocalReport.ReportEmbeddedResource = "Store_Manager.SatılanÜrünleriGöster.rdlc";
            this.raporSatılanÜrünleriGöster.Location = new System.Drawing.Point(0, 154);
            this.raporSatılanÜrünleriGöster.Name = "raporSatılanÜrünleriGöster";
            this.raporSatılanÜrünleriGöster.ServerReport.BearerToken = null;
            this.raporSatılanÜrünleriGöster.Size = new System.Drawing.Size(892, 411);
            this.raporSatılanÜrünleriGöster.TabIndex = 29;
            // 
            // SoldProductsTableAdapter
            // 
            this.SoldProductsTableAdapter.ClearBeforeFill = true;
            // 
            // SatılanÜrünleriGöster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(892, 565);
            this.Controls.Add(this.raporSatılanÜrünleriGöster);
            this.Controls.Add(this.btnSıfırla);
            this.Controls.Add(this.txtBoxÜrünTürü);
            this.Controls.Add(this.txtBoxÜrünAdı);
            this.Controls.Add(this.btnAra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SatılanÜrünleriGöster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatılanÜrünleriGöster";
            this.Activated += new System.EventHandler(this.SatılanÜrünleriGöster_Activated);
            this.Load += new System.EventHandler(this.SatılanÜrünleriGöster_Load);
            this.Leave += new System.EventHandler(this.SatılanÜrünleriGöster_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.SoldProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Store_ManagerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSıfırla;
        private System.Windows.Forms.TextBox txtBoxÜrünTürü;
        private System.Windows.Forms.TextBox txtBoxÜrünAdı;
        private System.Windows.Forms.Button btnAra;
        private Microsoft.Reporting.WinForms.ReportViewer raporSatılanÜrünleriGöster;
        private System.Windows.Forms.BindingSource SoldProductsBindingSource;
        private Store_ManagerDataSet Store_ManagerDataSet;
        private Store_ManagerDataSetTableAdapters.SoldProductsTableAdapter SoldProductsTableAdapter;
        private System.Windows.Forms.ToolTip Açıklama;
    }
}
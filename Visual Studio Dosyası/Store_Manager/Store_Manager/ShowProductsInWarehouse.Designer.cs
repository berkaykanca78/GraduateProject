namespace Store_Manager
{
    partial class ShowProductsInWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowProductsInWarehouse));
            this.ProductWarehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Store_ManagerDataSet = new Store_Manager.Store_ManagerDataSet();
            this.raporDepodakiÜrünleriGöster = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnSıfırla = new System.Windows.Forms.Button();
            this.txtBoxÜrünTürü = new System.Windows.Forms.TextBox();
            this.txtBoxÜrünAdı = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.ProductWarehouseTableAdapter = new Store_Manager.Store_ManagerDataSetTableAdapters.ProductWarehouseTableAdapter();
            this.Açıklama = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProductWarehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Store_ManagerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductWarehouseBindingSource
            // 
            this.ProductWarehouseBindingSource.DataMember = "ProductWarehouse";
            this.ProductWarehouseBindingSource.DataSource = this.Store_ManagerDataSet;
            // 
            // Store_ManagerDataSet
            // 
            this.Store_ManagerDataSet.DataSetName = "Store_ManagerDataSet";
            this.Store_ManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raporDepodakiÜrünleriGöster
            // 
            this.raporDepodakiÜrünleriGöster.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.ProductWarehouseBindingSource;
            this.raporDepodakiÜrünleriGöster.LocalReport.DataSources.Add(reportDataSource1);
            this.raporDepodakiÜrünleriGöster.LocalReport.ReportEmbeddedResource = "Store_Manager.ShowProductsInWarehouse.rdlc";
            this.raporDepodakiÜrünleriGöster.Location = new System.Drawing.Point(0, 154);
            this.raporDepodakiÜrünleriGöster.Name = "raporDepodakiÜrünleriGöster";
            this.raporDepodakiÜrünleriGöster.ServerReport.BearerToken = null;
            this.raporDepodakiÜrünleriGöster.Size = new System.Drawing.Size(892, 411);
            this.raporDepodakiÜrünleriGöster.TabIndex = 0;
            // 
            // btnSıfırla
            // 
            this.btnSıfırla.BackColor = System.Drawing.Color.LightGray;
            this.btnSıfırla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSıfırla.Location = new System.Drawing.Point(425, 54);
            this.btnSıfırla.Name = "btnSıfırla";
            this.btnSıfırla.Size = new System.Drawing.Size(203, 27);
            this.btnSıfırla.TabIndex = 24;
            this.btnSıfırla.Text = "Reset";
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
            this.txtBoxÜrünTürü.TabIndex = 22;
            this.txtBoxÜrünTürü.Text = "Product Type";
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
            this.txtBoxÜrünAdı.TabIndex = 21;
            this.txtBoxÜrünAdı.Text = "Product Name";
            this.txtBoxÜrünAdı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.LightGray;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Location = new System.Drawing.Point(425, 21);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(203, 27);
            this.btnAra.TabIndex = 23;
            this.btnAra.Text = "Search";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // ProductWarehouseTableAdapter
            // 
            this.ProductWarehouseTableAdapter.ClearBeforeFill = true;
            // 
            // ShowProductsInWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(892, 565);
            this.Controls.Add(this.btnSıfırla);
            this.Controls.Add(this.txtBoxÜrünTürü);
            this.Controls.Add(this.txtBoxÜrünAdı);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.raporDepodakiÜrünleriGöster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowProductsInWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowProductsInWarehouse";
            this.Activated += new System.EventHandler(this.ShowProductsInWarehouse_Activated);
            this.Load += new System.EventHandler(this.ShowProductsInWarehouse_Load);
            this.Leave += new System.EventHandler(this.ShowProductsInWarehouse_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.ProductWarehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Store_ManagerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer raporDepodakiÜrünleriGöster;
        private System.Windows.Forms.Button btnSıfırla;
        private System.Windows.Forms.TextBox txtBoxÜrünTürü;
        private System.Windows.Forms.TextBox txtBoxÜrünAdı;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.BindingSource ProductWarehouseBindingSource;
        private Store_ManagerDataSet Store_ManagerDataSet;
        private Store_ManagerDataSetTableAdapters.ProductWarehouseTableAdapter ProductWarehouseTableAdapter;
        private System.Windows.Forms.ToolTip Açıklama;
    }
}
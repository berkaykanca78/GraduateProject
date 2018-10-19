namespace Store_Manager
{
    partial class MüşterileriGöster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MüşterileriGöster));
            this.CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Store_ManagerDataSet = new Store_Manager.Store_ManagerDataSet();
            this.raporMüşteriGöster = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnSıfırla = new System.Windows.Forms.Button();
            this.txtBoxSoyadı = new System.Windows.Forms.TextBox();
            this.txtBoxAdı = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.CustomerTableAdapter = new Store_Manager.Store_ManagerDataSetTableAdapters.CustomerTableAdapter();
            this.Açıklama = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Store_ManagerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerBindingSource
            // 
            this.CustomerBindingSource.DataMember = "Customer";
            this.CustomerBindingSource.DataSource = this.Store_ManagerDataSet;
            // 
            // Store_ManagerDataSet
            // 
            this.Store_ManagerDataSet.DataSetName = "Store_ManagerDataSet";
            this.Store_ManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raporMüşteriGöster
            // 
            this.raporMüşteriGöster.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "VeriKümesi";
            reportDataSource1.Value = this.CustomerBindingSource;
            this.raporMüşteriGöster.LocalReport.DataSources.Add(reportDataSource1);
            this.raporMüşteriGöster.LocalReport.ReportEmbeddedResource = "Store_Manager.MüşterileriGöster.rdlc";
            this.raporMüşteriGöster.Location = new System.Drawing.Point(0, 154);
            this.raporMüşteriGöster.Name = "raporMüşteriGöster";
            this.raporMüşteriGöster.ServerReport.BearerToken = null;
            this.raporMüşteriGöster.Size = new System.Drawing.Size(892, 411);
            this.raporMüşteriGöster.TabIndex = 0;
            // 
            // btnSıfırla
            // 
            this.btnSıfırla.BackColor = System.Drawing.Color.LightGray;
            this.btnSıfırla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSıfırla.Location = new System.Drawing.Point(425, 54);
            this.btnSıfırla.Name = "btnSıfırla";
            this.btnSıfırla.Size = new System.Drawing.Size(203, 27);
            this.btnSıfırla.TabIndex = 16;
            this.btnSıfırla.Text = "Sıfırla";
            this.btnSıfırla.UseVisualStyleBackColor = false;
            this.btnSıfırla.Click += new System.EventHandler(this.btnSıfırla_Click);
            // 
            // txtBoxSoyadı
            // 
            this.txtBoxSoyadı.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxSoyadı.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxSoyadı.Location = new System.Drawing.Point(116, 54);
            this.txtBoxSoyadı.MaxLength = 15;
            this.txtBoxSoyadı.Multiline = true;
            this.txtBoxSoyadı.Name = "txtBoxSoyadı";
            this.txtBoxSoyadı.Size = new System.Drawing.Size(303, 27);
            this.txtBoxSoyadı.TabIndex = 14;
            this.txtBoxSoyadı.Text = "Soyad";
            this.txtBoxSoyadı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxAdı
            // 
            this.txtBoxAdı.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxAdı.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxAdı.Location = new System.Drawing.Point(116, 21);
            this.txtBoxAdı.MaxLength = 15;
            this.txtBoxAdı.Multiline = true;
            this.txtBoxAdı.Name = "txtBoxAdı";
            this.txtBoxAdı.Size = new System.Drawing.Size(303, 27);
            this.txtBoxAdı.TabIndex = 13;
            this.txtBoxAdı.Text = "Ad";
            this.txtBoxAdı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.LightGray;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Location = new System.Drawing.Point(425, 21);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(203, 27);
            this.btnAra.TabIndex = 15;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // CustomerTableAdapter
            // 
            this.CustomerTableAdapter.ClearBeforeFill = true;
            // 
            // MüşterileriGöster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(892, 565);
            this.Controls.Add(this.btnSıfırla);
            this.Controls.Add(this.txtBoxSoyadı);
            this.Controls.Add(this.txtBoxAdı);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.raporMüşteriGöster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MüşterileriGöster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MüşterileriGöster";
            this.Activated += new System.EventHandler(this.MüşterileriGöster_Activated);
            this.Load += new System.EventHandler(this.MüşterileriGöster_Load);
            this.Leave += new System.EventHandler(this.MüşterileriGöster_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Store_ManagerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer raporMüşteriGöster;
        private System.Windows.Forms.Button btnSıfırla;
        private System.Windows.Forms.TextBox txtBoxSoyadı;
        private System.Windows.Forms.TextBox txtBoxAdı;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.BindingSource CustomerBindingSource;
        private Store_ManagerDataSet Store_ManagerDataSet;
        private Store_ManagerDataSetTableAdapters.CustomerTableAdapter CustomerTableAdapter;
        private System.Windows.Forms.ToolTip Açıklama;
    }
}
namespace Store_Manager
{
    partial class BorçTakibi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorçTakibi));
            this.DebtInnerJoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Store_ManagerDataSet = new Store_Manager.Store_ManagerDataSet();
            this.raporBorçTakibi = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DebtInnerJoinTableAdapter = new Store_Manager.Store_ManagerDataSetTableAdapters.DebtInnerJoinTableAdapter();
            this.btnSıfırla = new System.Windows.Forms.Button();
            this.txtBoxSoyadı = new System.Windows.Forms.TextBox();
            this.txtBoxAdı = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.Açıklama = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DebtInnerJoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Store_ManagerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DebtInnerJoinBindingSource
            // 
            this.DebtInnerJoinBindingSource.DataMember = "DebtInnerJoin";
            this.DebtInnerJoinBindingSource.DataSource = this.Store_ManagerDataSet;
            // 
            // Store_ManagerDataSet
            // 
            this.Store_ManagerDataSet.DataSetName = "Store_ManagerDataSet";
            this.Store_ManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raporBorçTakibi
            // 
            this.raporBorçTakibi.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "VeriKümesi";
            reportDataSource1.Value = this.DebtInnerJoinBindingSource;
            this.raporBorçTakibi.LocalReport.DataSources.Add(reportDataSource1);
            this.raporBorçTakibi.LocalReport.ReportEmbeddedResource = "Store_Manager.BorçTakibi.rdlc";
            this.raporBorçTakibi.Location = new System.Drawing.Point(0, 154);
            this.raporBorçTakibi.Name = "raporBorçTakibi";
            this.raporBorçTakibi.ServerReport.BearerToken = null;
            this.raporBorçTakibi.Size = new System.Drawing.Size(892, 411);
            this.raporBorçTakibi.TabIndex = 0;
            // 
            // DebtInnerJoinTableAdapter
            // 
            this.DebtInnerJoinTableAdapter.ClearBeforeFill = true;
            // 
            // btnSıfırla
            // 
            this.btnSıfırla.BackColor = System.Drawing.Color.LightGray;
            this.btnSıfırla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSıfırla.Location = new System.Drawing.Point(425, 54);
            this.btnSıfırla.Name = "btnSıfırla";
            this.btnSıfırla.Size = new System.Drawing.Size(203, 27);
            this.btnSıfırla.TabIndex = 20;
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
            this.txtBoxSoyadı.TabIndex = 18;
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
            this.txtBoxAdı.TabIndex = 17;
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
            this.btnAra.TabIndex = 19;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // BorçTakibi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(892, 565);
            this.Controls.Add(this.btnSıfırla);
            this.Controls.Add(this.txtBoxSoyadı);
            this.Controls.Add(this.txtBoxAdı);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.raporBorçTakibi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BorçTakibi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorçTakibi";
            this.Activated += new System.EventHandler(this.BorçTakibi_Activated);
            this.Load += new System.EventHandler(this.BorçTakibi_Load);
            this.Leave += new System.EventHandler(this.BorçTakibi_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.DebtInnerJoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Store_ManagerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer raporBorçTakibi;
        private System.Windows.Forms.BindingSource DebtInnerJoinBindingSource;
        private Store_ManagerDataSet Store_ManagerDataSet;
        private Store_ManagerDataSetTableAdapters.DebtInnerJoinTableAdapter DebtInnerJoinTableAdapter;
        private System.Windows.Forms.Button btnSıfırla;
        private System.Windows.Forms.TextBox txtBoxSoyadı;
        private System.Windows.Forms.TextBox txtBoxAdı;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ToolTip Açıklama;
    }
}
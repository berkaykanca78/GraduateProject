namespace Store_Manager
{
    partial class DebtFollowUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebtFollowUp));
            this.DebtInnerJoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Store_ManagerDataSet = new Store_Manager.Store_ManagerDataSet();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.reportDebtFollowUp = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DebtInnerJoinTableAdapter = new Store_Manager.Store_ManagerDataSetTableAdapters.DebtInnerJoinTableAdapter();
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
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightGray;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(425, 54);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(203, 27);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxSurname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxSurname.Location = new System.Drawing.Point(116, 54);
            this.txtBoxSurname.MaxLength = 15;
            this.txtBoxSurname.Multiline = true;
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(303, 27);
            this.txtBoxSurname.TabIndex = 15;
            this.txtBoxSurname.Text = "Surname";
            this.txtBoxSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxName.Location = new System.Drawing.Point(116, 21);
            this.txtBoxName.MaxLength = 15;
            this.txtBoxName.Multiline = true;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(303, 27);
            this.txtBoxName.TabIndex = 14;
            this.txtBoxName.Text = "Name";
            this.txtBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(425, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(203, 27);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // reportDebtFollowUp
            // 
            this.reportDebtFollowUp.AutoScroll = true;
            this.reportDebtFollowUp.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.DebtInnerJoinBindingSource;
            this.reportDebtFollowUp.LocalReport.DataSources.Add(reportDataSource1);
            this.reportDebtFollowUp.LocalReport.ReportEmbeddedResource = "Store_Manager.DebtFollowUp.rdlc";
            this.reportDebtFollowUp.Location = new System.Drawing.Point(0, 154);
            this.reportDebtFollowUp.Name = "reportDebtFollowUp";
            this.reportDebtFollowUp.ServerReport.BearerToken = null;
            this.reportDebtFollowUp.Size = new System.Drawing.Size(892, 411);
            this.reportDebtFollowUp.TabIndex = 13;
            // 
            // DebtInnerJoinTableAdapter
            // 
            this.DebtInnerJoinTableAdapter.ClearBeforeFill = true;
            // 
            // DebtFollowUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(892, 565);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtBoxSurname);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.reportDebtFollowUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DebtFollowUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DebtFollowUp";
            this.Activated += new System.EventHandler(this.DebtFollowUp_Activated);
            this.Load += new System.EventHandler(this.DebtFollowUp_Load);
            this.Leave += new System.EventHandler(this.DebtFollowUp_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.DebtInnerJoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Store_ManagerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtBoxSurname;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Button btnSearch;
        private Microsoft.Reporting.WinForms.ReportViewer reportDebtFollowUp;
        private System.Windows.Forms.BindingSource DebtInnerJoinBindingSource;
        private Store_ManagerDataSet Store_ManagerDataSet;
        private Store_ManagerDataSetTableAdapters.DebtInnerJoinTableAdapter DebtInnerJoinTableAdapter;
        private System.Windows.Forms.ToolTip Açıklama;
    }
}
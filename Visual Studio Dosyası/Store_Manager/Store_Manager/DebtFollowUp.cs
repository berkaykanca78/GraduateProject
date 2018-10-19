using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Manager
{
    public partial class DebtFollowUp : Form
    {
        public DebtFollowUp()
        {
            InitializeComponent();
        }
        private void DebtFollowUp_Load(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            if (Ayarlar.tema == "Varsayılan")
            {
                this.BackColor = Color.FromArgb(37, 46, 59);
            }
            else if (Ayarlar.tema == "Kırmızı")
            {
                this.BackColor = Color.Red;
            }
            else if (Ayarlar.tema == "Mavi")
            {
                this.BackColor = Color.Blue;
            }
            else if (Ayarlar.tema == "Yeşil")
            {
                this.BackColor = Color.Green;
            }
            Açıklama.SetToolTip(txtBoxName, "Name");
            Açıklama.SetToolTip(txtBoxSurname, "Surname");
            this.DebtInnerJoinTableAdapter.Fill(this.Store_ManagerDataSet.DebtInnerJoin);
            reportDebtFollowUp.RefreshReport();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.DebtInnerJoinTableAdapter.FillBy(this.Store_ManagerDataSet.DebtInnerJoin, "%" + txtBoxName.Text + "%", "%" + txtBoxSurname.Text + "%");
            reportDebtFollowUp.RefreshReport();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.DebtInnerJoinTableAdapter.Fill(this.Store_ManagerDataSet.DebtInnerJoin);
            reportDebtFollowUp.RefreshReport();
            txtBoxName.Text = "Name";
            txtBoxSurname.Text = "Surname";
        }

        private void DebtFollowUp_Leave(object sender, EventArgs e)
        {
            this.DebtInnerJoinTableAdapter.Fill(this.Store_ManagerDataSet.DebtInnerJoin);
            reportDebtFollowUp.RefreshReport();
            txtBoxName.Text = "Name";
            txtBoxSurname.Text = "Surname";
        }
        private void DebtFollowUp_Activated(object sender, EventArgs e)
        {
            if (Ayarlar.tema == "Varsayılan")
            {
                this.BackColor = Color.FromArgb(37, 46, 59);
            }
            else if (Ayarlar.tema == "Kırmızı")
            {
                this.BackColor = Color.Red;
            }
            else if (Ayarlar.tema == "Mavi")
            {
                this.BackColor = Color.Blue;
            }
            else if (Ayarlar.tema == "Yeşil")
            {
                this.BackColor = Color.Green;
            }
            Açıklama.SetToolTip(txtBoxName, "Name");
            Açıklama.SetToolTip(txtBoxSurname, "Surname");
            this.DebtInnerJoinTableAdapter.Fill(this.Store_ManagerDataSet.DebtInnerJoin);
            reportDebtFollowUp.RefreshReport();
            txtBoxName.Text = "Name";
            txtBoxSurname.Text = "Surname";
        }
    }
}

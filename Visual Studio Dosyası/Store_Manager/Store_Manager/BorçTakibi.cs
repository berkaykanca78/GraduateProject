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
    public partial class BorçTakibi : Form
    {
        public BorçTakibi()
        {
            InitializeComponent();
        }
        private void BorçTakibi_Load(object sender, EventArgs e)
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
            Açıklama.SetToolTip(txtBoxAdı, "Adı");
            Açıklama.SetToolTip(txtBoxSoyadı, "Soyadı");
            this.DebtInnerJoinTableAdapter.Fill(this.Store_ManagerDataSet.DebtInnerJoin);
            raporBorçTakibi.RefreshReport();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            DebtInnerJoinTableAdapter.FillBy(this.Store_ManagerDataSet.DebtInnerJoin, "%" + txtBoxAdı.Text + "%", "%" + txtBoxSoyadı.Text + "%");
            raporBorçTakibi.RefreshReport();
        }
        private void btnSıfırla_Click(object sender, EventArgs e)
        {
            this.DebtInnerJoinTableAdapter.Fill(this.Store_ManagerDataSet.DebtInnerJoin);
            raporBorçTakibi.RefreshReport();
            txtBoxAdı.Text = "Adı";
            txtBoxSoyadı.Text = "Soyadı";
        }
        private void BorçTakibi_Leave(object sender, EventArgs e)
        {
            this.DebtInnerJoinTableAdapter.Fill(this.Store_ManagerDataSet.DebtInnerJoin);
            raporBorçTakibi.RefreshReport();
            txtBoxAdı.Text = "Adı";
            txtBoxSoyadı.Text = "Soyadı";
        }
        private void BorçTakibi_Activated(object sender, EventArgs e)
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
            Açıklama.SetToolTip(txtBoxAdı, "Adı");
            Açıklama.SetToolTip(txtBoxSoyadı, "Soyadı");
            this.DebtInnerJoinTableAdapter.Fill(this.Store_ManagerDataSet.DebtInnerJoin);
            raporBorçTakibi.RefreshReport();
            txtBoxAdı.Text = "Adı";
            txtBoxSoyadı.Text = "Soyadı";
        }
    }
}

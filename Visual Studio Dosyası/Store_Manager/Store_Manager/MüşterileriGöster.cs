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
    public partial class MüşterileriGöster : Form
    {
        public MüşterileriGöster()
        {
            InitializeComponent();
        }

        private void MüşterileriGöster_Load(object sender, EventArgs e)
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
            CustomerTableAdapter.Fill(this.Store_ManagerDataSet.Customer);
            raporMüşteriGöster.RefreshReport();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            CustomerTableAdapter.FillBy(this.Store_ManagerDataSet.Customer, "%" + txtBoxAdı.Text + "%", "%" + txtBoxSoyadı.Text + "%");
            raporMüşteriGöster.RefreshReport();
        }
        private void btnSıfırla_Click(object sender, EventArgs e)
        {
            CustomerTableAdapter.Fill(this.Store_ManagerDataSet.Customer);
            raporMüşteriGöster.RefreshReport();
            txtBoxAdı.Text = "Adı";
            txtBoxSoyadı.Text = "Soyadı";
        }
        private void MüşterileriGöster_Leave(object sender, EventArgs e)
        {
            CustomerTableAdapter.Fill(this.Store_ManagerDataSet.Customer);
            raporMüşteriGöster.RefreshReport();
            txtBoxAdı.Text = "Adı";
            txtBoxSoyadı.Text = "Soyadı";
        }
        private void MüşterileriGöster_Activated(object sender, EventArgs e)
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
            CustomerTableAdapter.Fill(this.Store_ManagerDataSet.Customer);
            raporMüşteriGöster.RefreshReport();
            txtBoxAdı.Text = "Adı";
            txtBoxSoyadı.Text = "Soyadı";
        }
    }
}

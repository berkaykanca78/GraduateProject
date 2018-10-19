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
    public partial class ShowCustomers : Form
    {
        public ShowCustomers()
        {
            InitializeComponent();
        }

        private void ShowCustomers_Load(object sender, EventArgs e)
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
            Açıklama.SetToolTip(txtBoxAdı, "Name");
            Açıklama.SetToolTip(txtBoxSoyadı, "Surname");
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
            txtBoxAdı.Text = "Name";
            txtBoxSoyadı.Text = "Surname";
        }
        private void ShowCustomers_Leave(object sender, EventArgs e)
        {
            CustomerTableAdapter.Fill(this.Store_ManagerDataSet.Customer);
            raporMüşteriGöster.RefreshReport();
            txtBoxAdı.Text = "Name";
            txtBoxSoyadı.Text = "Surname";
        }
        private void ShowCustomers_Activated(object sender, EventArgs e)
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
            Açıklama.SetToolTip(txtBoxAdı, "Name");
            Açıklama.SetToolTip(txtBoxSoyadı, "Surname");
            CustomerTableAdapter.Fill(this.Store_ManagerDataSet.Customer);
            raporMüşteriGöster.RefreshReport();
            txtBoxAdı.Text = "Name";
            txtBoxSoyadı.Text = "Surname";
        }
    }
}

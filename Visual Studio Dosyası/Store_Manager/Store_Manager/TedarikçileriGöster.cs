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
    public partial class TedarikçileriGöster : Form
    {
        public TedarikçileriGöster()
        {
            InitializeComponent();
        }
        private void TedarikçileriGöster_Load(object sender, EventArgs e)
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
            SupplierTableAdapter.Fill(this.Store_ManagerDataSet.Supplier);
            raporTedarikçileriGöster.RefreshReport();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            SupplierTableAdapter.FillBy(this.Store_ManagerDataSet.Supplier, "%" + txtBoxAdı.Text + "%", "%" + txtBoxSoyadı.Text + "%");
            raporTedarikçileriGöster.RefreshReport();
        }
        private void btnSıfırla_Click(object sender, EventArgs e)
        {
            SupplierTableAdapter.Fill(this.Store_ManagerDataSet.Supplier);
            raporTedarikçileriGöster.RefreshReport();
            txtBoxAdı.Text = "Adı";
            txtBoxSoyadı.Text = "Soyadı";
        }
        private void TedarikçileriGöster_Leave(object sender, EventArgs e)
        {
            SupplierTableAdapter.Fill(this.Store_ManagerDataSet.Supplier);
            raporTedarikçileriGöster.RefreshReport();
            txtBoxAdı.Text = "Adı";
            txtBoxSoyadı.Text = "Soyadı";
        }
        private void TedarikçileriGöster_Activated(object sender, EventArgs e)
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
            SupplierTableAdapter.Fill(this.Store_ManagerDataSet.Supplier);
            raporTedarikçileriGöster.RefreshReport();
            txtBoxAdı.Text = "Adı";
            txtBoxSoyadı.Text = "Soyadı";
        }
    }
}

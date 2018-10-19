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
    public partial class ShowSuppliers : Form
    {
        public ShowSuppliers()
        {
            InitializeComponent();
        }

        private void ShowSuppliers_Load(object sender, EventArgs e)
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
            this.SupplierTableAdapter.Fill(this.Store_ManagerDataSet.Supplier);
            this.raporTedarikçiGöster.RefreshReport();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SupplierTableAdapter.FillBy(this.Store_ManagerDataSet.Supplier, "%" + txtBoxName.Text + "%", "%" + txtBoxSurname.Text + "%");
            this.raporTedarikçiGöster.RefreshReport();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.SupplierTableAdapter.Fill(this.Store_ManagerDataSet.Supplier);
            this.raporTedarikçiGöster.RefreshReport();
            txtBoxName.Text = "Name";
            txtBoxSurname.Text = "Surname";
        }
        private void ShowSuppliers_Leave(object sender, EventArgs e)
        {
            this.SupplierTableAdapter.Fill(this.Store_ManagerDataSet.Supplier);
            this.raporTedarikçiGöster.RefreshReport();
            txtBoxName.Text = "Name";
            txtBoxSurname.Text = "Surname";
        }
        private void ShowSuppliers_Activated(object sender, EventArgs e)
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
            this.SupplierTableAdapter.Fill(this.Store_ManagerDataSet.Supplier);
            this.raporTedarikçiGöster.RefreshReport();
            txtBoxName.Text = "Name";
            txtBoxSurname.Text = "Surname";
        }
    }
}

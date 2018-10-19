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
    public partial class ShowProductsInWarehouse : Form
    {
        public ShowProductsInWarehouse()
        {
            InitializeComponent();
        }
        private void ShowProductsInWarehouse_Load(object sender, EventArgs e)
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
            Açıklama.SetToolTip(txtBoxÜrünAdı, "Product Name");
            Açıklama.SetToolTip(txtBoxÜrünTürü, "Product Type");
            this.ProductWarehouseTableAdapter.Fill(this.Store_ManagerDataSet.ProductWarehouse);
            this.raporDepodakiÜrünleriGöster.RefreshReport();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            ProductWarehouseTableAdapter.FillBy(this.Store_ManagerDataSet.ProductWarehouse, "%" + txtBoxÜrünAdı.Text + "%", "%" + txtBoxÜrünTürü.Text + "%");
            raporDepodakiÜrünleriGöster.RefreshReport();
        }
        private void btnSıfırla_Click(object sender, EventArgs e)
        {
            this.ProductWarehouseTableAdapter.Fill(this.Store_ManagerDataSet.ProductWarehouse);
            this.raporDepodakiÜrünleriGöster.RefreshReport();
            txtBoxÜrünAdı.Text = "Product Name";
            txtBoxÜrünTürü.Text = "Product Type";
        }
        private void ShowProductsInWarehouse_Leave(object sender, EventArgs e)
        {
            this.ProductWarehouseTableAdapter.Fill(this.Store_ManagerDataSet.ProductWarehouse);
            this.raporDepodakiÜrünleriGöster.RefreshReport();
            txtBoxÜrünAdı.Text = "Product Name";
            txtBoxÜrünTürü.Text = "Product Type";
        }
        private void ShowProductsInWarehouse_Activated(object sender, EventArgs e)
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
            Açıklama.SetToolTip(txtBoxÜrünAdı, "Product Name");
            Açıklama.SetToolTip(txtBoxÜrünTürü, "Product Type");
            this.ProductWarehouseTableAdapter.Fill(this.Store_ManagerDataSet.ProductWarehouse);
            this.raporDepodakiÜrünleriGöster.RefreshReport();
            txtBoxÜrünAdı.Text = "Product Name";
            txtBoxÜrünTürü.Text = "Product Type";
        }
    }
}

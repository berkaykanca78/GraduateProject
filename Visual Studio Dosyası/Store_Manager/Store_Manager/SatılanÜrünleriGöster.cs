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
    public partial class SatılanÜrünleriGöster : Form
    {
        public SatılanÜrünleriGöster()
        {
            InitializeComponent();
        }

        private void SatılanÜrünleriGöster_Load(object sender, EventArgs e)
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
            Açıklama.SetToolTip(txtBoxÜrünAdı, "Ürün Adı");
            Açıklama.SetToolTip(txtBoxÜrünTürü, "Ürün Türü");
            this.SoldProductsTableAdapter.Fill(this.Store_ManagerDataSet.SoldProducts);
            this.raporSatılanÜrünleriGöster.RefreshReport();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            this.SoldProductsTableAdapter.FillBy(this.Store_ManagerDataSet.SoldProducts, "%" + txtBoxÜrünAdı.Text + "%", "%" + txtBoxÜrünTürü.Text + "%");
            this.raporSatılanÜrünleriGöster.RefreshReport();
        }

        private void btnSıfırla_Click(object sender, EventArgs e)
        {
            this.SoldProductsTableAdapter.Fill(this.Store_ManagerDataSet.SoldProducts);
            this.raporSatılanÜrünleriGöster.RefreshReport();
            txtBoxÜrünAdı.Text = "Ürün Adı";
            txtBoxÜrünTürü.Text = "Ürün Türü";
        }

        private void SatılanÜrünleriGöster_Leave(object sender, EventArgs e)
        {
            this.SoldProductsTableAdapter.Fill(this.Store_ManagerDataSet.SoldProducts);
            this.raporSatılanÜrünleriGöster.RefreshReport();
            txtBoxÜrünAdı.Text = "Ürün Adı";
            txtBoxÜrünTürü.Text = "Ürün Türü";
        }

        private void SatılanÜrünleriGöster_Activated(object sender, EventArgs e)
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
            Açıklama.SetToolTip(txtBoxÜrünAdı, "Ürün Adı");
            Açıklama.SetToolTip(txtBoxÜrünTürü, "Ürün Türü");
            this.SoldProductsTableAdapter.Fill(this.Store_ManagerDataSet.SoldProducts);
            this.raporSatılanÜrünleriGöster.RefreshReport();
            txtBoxÜrünAdı.Text = "Ürün Adı";
            txtBoxÜrünTürü.Text = "Ürün Türü";
        }
    }
}

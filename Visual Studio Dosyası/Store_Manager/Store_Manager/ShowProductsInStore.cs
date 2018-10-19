﻿using System;
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
    public partial class ShowProductsInStore : Form
    {
        public ShowProductsInStore()
        {
            InitializeComponent();
        }

        private void ShowProductsInStore_Load(object sender, EventArgs e)
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
            this.ProductStoreTableAdapter.Fill(this.Store_ManagerDataSet.ProductStore);
            this.raporMağazadakiÜrünleriGöster.RefreshReport();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            this.ProductStoreTableAdapter.FillBy(this.Store_ManagerDataSet.ProductStore, "%" + txtBoxÜrünAdı.Text + "%", "%" + txtBoxÜrünTürü.Text + "%");
            this.raporMağazadakiÜrünleriGöster.RefreshReport();
        }

        private void btnSıfırla_Click(object sender, EventArgs e)
        {
            this.ProductStoreTableAdapter.Fill(this.Store_ManagerDataSet.ProductStore);
            this.raporMağazadakiÜrünleriGöster.RefreshReport();
            txtBoxÜrünAdı.Text = "Product Name";
            txtBoxÜrünTürü.Text = "Product Type";
        }

        private void ShowProductsInStore_Leave(object sender, EventArgs e)
        {
            this.ProductStoreTableAdapter.Fill(this.Store_ManagerDataSet.ProductStore);
            this.raporMağazadakiÜrünleriGöster.RefreshReport();
            txtBoxÜrünAdı.Text = "Product Name";
            txtBoxÜrünTürü.Text = "Product Type";
        }

        private void ShowProductsInStore_Activated(object sender, EventArgs e)
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
            this.ProductStoreTableAdapter.Fill(this.Store_ManagerDataSet.ProductStore);
            this.raporMağazadakiÜrünleriGöster.RefreshReport();
            txtBoxÜrünAdı.Text = "Product Name";
            txtBoxÜrünTürü.Text = "Product Type";
        }
    }
}

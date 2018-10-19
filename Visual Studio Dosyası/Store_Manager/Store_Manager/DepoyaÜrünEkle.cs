using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Manager
{
    public partial class DepoyaÜrünEkle : Form
    {
        string baglantiString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
        static string komutString = "";
        SqlConnection baglanti;
        SqlCommand komut;
        public DepoyaÜrünEkle()
        {
            InitializeComponent();
        }
        public void DepoNumarasıVeriGetir()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Warehouse";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbBoxDepoNo.Items.Add(dr["Warehouse_No"]);
            }
            baglanti.Close();
        }
        public void TedarikçiTCNoVeriGetir()
        {
            cmbBoxTedarikçiAdıSoyadı.Items.Clear();
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT Supplier_TC_No,(Supplier_Name + ' ' + Supplier_Surname) AS SupplierNameSurname FROM Supplier";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            baglanti.Open();
            DataTable tbl = new DataTable();
            tbl.Load(komut.ExecuteReader());
            baglanti.Close();
            cmbBoxTedarikçiAdıSoyadı.DataSource = tbl;
            cmbBoxTedarikçiAdıSoyadı.DisplayMember = "SupplierNameSurname";
            cmbBoxTedarikçiAdıSoyadı.ValueMember = "Supplier_TC_No";
        }
        public void UrunEkle()
        {
            baglanti = new SqlConnection(baglantiString);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komutString = "INSERT INTO Product (Product_No,Product_Name,Product_Firm_Name,Product_Type,Product_Price,Supplier_TC_No,Warehouse_No,Store_Mail,Warehouse_Mail) " +
            "VALUES (@Product_No,@Product_Name,@Product_Firm_Name,@Product_Type,@Product_Price,@Supplier_TC_No,@Warehouse_No,@Store_Mail,@Warehouse_Mail)";
            komut = new SqlCommand(komutString, baglanti);
            komut.Parameters.AddWithValue("@Product_No", txtBoxÜrünNo.Text);
            komut.Parameters.AddWithValue("@Product_Name", txtBoxÜrünAdı.Text);
            komut.Parameters.AddWithValue("@Product_Firm_Name", txtBoxFirmaAdı.Text);
            komut.Parameters.AddWithValue("@Product_Type", txtBoxÜrünTürü.Text);
            komut.Parameters.AddWithValue("@Product_Price", txtBoxÜrünFiyatı.Text);
            komut.Parameters.AddWithValue("@Supplier_TC_No", cmbBoxTedarikçiAdıSoyadı.SelectedValue.ToString());
            komut.Parameters.AddWithValue("@Warehouse_No", cmbBoxDepoNo.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@Store_Mail", false);
            komut.Parameters.AddWithValue("@Warehouse_Mail", false);
            komut.ExecuteNonQuery();
            baglanti.Dispose();
            baglanti.Close();
        }
        public void FalseYap()
        {
            string conString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
            SqlConnection baglanti = new SqlConnection(conString);
            baglanti.Open();
            string kayit = "UPDATE Product SET Warehouse_Mail=@Warehouse_Mail WHERE Product_Name='" + txtBoxÜrünAdı.Text + "'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@Warehouse_Mail", false);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void ÜrünEkle_Load(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            DepoNumarasıVeriGetir();
            TedarikçiTCNoVeriGetir();
            if (Ayarlar.dil == "English")
            {
                Açıklama.SetToolTip(txtBoxFirmaAdı, "Firm Name");
                Açıklama.SetToolTip(txtBoxÜrünAdı, "Product Name");
                Açıklama.SetToolTip(txtBoxÜrünFiyatı, "Product Price");
                Açıklama.SetToolTip(txtBoxÜrünNo, "Product Number");
                Açıklama.SetToolTip(txtBoxÜrünTürü, "Product Type");
                Açıklama.SetToolTip(cmbBoxDepoNo, "Warehouse Number");
                Açıklama.SetToolTip(cmbBoxTedarikçiAdıSoyadı, "Supplier Name & Surname");
                cmbBoxDepoNo.Text = "Warehouse No";
                txtBoxFirmaAdı.Text = "Firm Name";
                cmbBoxTedarikçiAdıSoyadı.Text = "Supplier Name & Surname";
                txtBoxÜrünAdı.Text = "Product Name";
                txtBoxÜrünFiyatı.Text = "Product Price";
                txtBoxÜrünNo.Text = "Product Number";
                txtBoxÜrünTürü.Text = "Product Type";
                btnÜrünEkle.Text = "Add Product";
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                Açıklama.SetToolTip(txtBoxFirmaAdı, "Firma Adı");
                Açıklama.SetToolTip(txtBoxÜrünAdı, "Ürün Adı");
                Açıklama.SetToolTip(txtBoxÜrünFiyatı, "Ürün Fiyatı");
                Açıklama.SetToolTip(txtBoxÜrünNo, "Ürün Numarası");
                Açıklama.SetToolTip(txtBoxÜrünTürü, "Ürün Türü");
                Açıklama.SetToolTip(cmbBoxDepoNo, "Depo Numarası");
                Açıklama.SetToolTip(cmbBoxTedarikçiAdıSoyadı, "Tedarikçi Adı & Soyadı");
                cmbBoxDepoNo.Text = "Depo Numarası";
                txtBoxFirmaAdı.Text = "Firma Adı";
                cmbBoxTedarikçiAdıSoyadı.Text = "Tedarikçi Adı & Soyadı";
                txtBoxÜrünAdı.Text = "Ürün Adı";
                txtBoxÜrünFiyatı.Text = "Ürün Fiyatı";
                txtBoxÜrünNo.Text = "Ürün Numarası";
                txtBoxÜrünTürü.Text = "Ürün Türü";
                btnÜrünEkle.Text = "Ürün Ekle";
            }
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
        }
        private void ÜrünEkle_Activated(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            if (Ayarlar.dil == "English")
            {
                Açıklama.SetToolTip(txtBoxFirmaAdı, "Firm Name");
                Açıklama.SetToolTip(txtBoxÜrünAdı, "Product Name");
                Açıklama.SetToolTip(txtBoxÜrünFiyatı, "Product Price");
                Açıklama.SetToolTip(txtBoxÜrünNo, "Product Number");
                Açıklama.SetToolTip(txtBoxÜrünTürü, "Product Type");
                Açıklama.SetToolTip(cmbBoxDepoNo, "Warehouse Number");
                Açıklama.SetToolTip(cmbBoxTedarikçiAdıSoyadı, "Supplier Name & Surname");
                txtBoxFirmaAdı.Text = "Firm Name";
                cmbBoxTedarikçiAdıSoyadı.Text = "Supplier Name & Surname";
                cmbBoxDepoNo.Text = "Warehouse No";
                txtBoxÜrünAdı.Text = "Product Name";
                txtBoxÜrünFiyatı.Text = "Product Price";
                txtBoxÜrünNo.Text = "Product Number";
                txtBoxÜrünTürü.Text = "Product Type";
                btnÜrünEkle.Text = "Add Product";
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                Açıklama.SetToolTip(txtBoxFirmaAdı, "Firma Adı");
                Açıklama.SetToolTip(txtBoxÜrünAdı, "Ürün Adı");
                Açıklama.SetToolTip(txtBoxÜrünFiyatı, "Ürün Fiyatı");
                Açıklama.SetToolTip(txtBoxÜrünNo, "Ürün Numarası");
                Açıklama.SetToolTip(txtBoxÜrünTürü, "Ürün Türü");
                Açıklama.SetToolTip(cmbBoxDepoNo, "Depo Numarası");
                Açıklama.SetToolTip(cmbBoxTedarikçiAdıSoyadı, "Tedarikçi Adı & Soyadı");
                cmbBoxDepoNo.Text = "Depo Numarası";
                txtBoxFirmaAdı.Text = "Firma Adı";
                cmbBoxTedarikçiAdıSoyadı.Text = "Tedarikçi Adı & Soyadı";
                txtBoxÜrünAdı.Text = "Ürün Adı";
                txtBoxÜrünFiyatı.Text = "Ürün Fiyatı";
                txtBoxÜrünNo.Text = "Ürün Numarası";
                txtBoxÜrünTürü.Text = "Ürün Türü";
                btnÜrünEkle.Text = "Ürün Ekle";
            }
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
        }
        private void btnÜrünEkle_Click(object sender, EventArgs e)
        {
            if (Ayarlar.dil == "English")
            {
                UrunEkle();
                FalseYap();
                MessageBoxManager.Unregister();
                MessageBoxManager.OK = "OK";
                MessageBoxManager.Register();
                MessageBox.Show("Added Product To Warehouse.", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                UrunEkle();
                FalseYap();
                MessageBoxManager.Unregister();
                MessageBoxManager.OK = "Tamam";
                MessageBoxManager.Register();
                MessageBox.Show("Depoya Ürün Eklenmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtBoxÜrünNo_Click(object sender, EventArgs e)
        {
            txtBoxÜrünNo.Text = "";
        }
        private void txtBoxÜrünAdı_Click(object sender, EventArgs e)
        {
            txtBoxÜrünAdı.Text = "";
        }
        private void txtBoxFirmaAdı_Click(object sender, EventArgs e)
        {
            txtBoxFirmaAdı.Text = "";
        }
        private void txtBoxÜrünTürü_Click(object sender, EventArgs e)
        {
            txtBoxÜrünTürü.Text = "";
        }
        private void txtBoxÜrünFiyatı_Click(object sender, EventArgs e)
        {
            txtBoxÜrünFiyatı.Text = "";
        }
    }
}

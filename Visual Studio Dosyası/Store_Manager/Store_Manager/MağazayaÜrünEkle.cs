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
    public partial class MağazayaÜrünEkle : Form
    {
        public static string ürünAdı = "";
        public MağazayaÜrünEkle()
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
        public void MağazaNumarasıVeriGetir()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Store";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbBoxMağazaNo.Items.Add(dr["Store_No"]);
            }
            baglanti.Close();
        }
        public void ÜrünNumarasıVeriGetir()
        {
            cmbBoxÜrünNumarası.Items.Clear();
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Product WHERE Warehouse_No='" + cmbBoxDepoNo.SelectedItem.ToString() + "'";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbBoxÜrünNumarası.Items.Add(dr["Product_No"]);
            }
            baglanti.Close();
        }
        public void MağazayaDepodanUrunEkle()
        {
            string conString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
            SqlConnection baglanti = new SqlConnection(conString);
            baglanti.Open();
            string kayit = "UPDATE Product SET Warehouse_No=NULL,Store_No=@Store_No WHERE Product_No='"+cmbBoxÜrünNumarası.SelectedItem.ToString()+"'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@Store_No", cmbBoxMağazaNo.SelectedItem.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void ürünAdıGetir()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Product WHERE Store_No='" + cmbBoxMağazaNo.SelectedItem.ToString() + "'";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ürünAdı=dr["Product_Name"].ToString();
            }
            baglanti.Close();
        }
        public void FalseYap()
        {
            string conString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
            SqlConnection baglanti = new SqlConnection(conString);
            baglanti.Open();
            string kayit = "UPDATE Product SET Store_Mail=@Store_Mail WHERE Product_Name='" + ürünAdı.ToString() + "'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@Store_Mail", false);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void MağazayaÜrünEkle_Load(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            cmbBoxÜrünNumarası.Items.Clear();
            DepoNumarasıVeriGetir();
            MağazaNumarasıVeriGetir();
            if (Ayarlar.dil == "English")
            {
                Açıklama.SetToolTip(cmbBoxDepoNo, "Warehouse Number");
                Açıklama.SetToolTip(cmbBoxMağazaNo, "Store Number");
                Açıklama.SetToolTip(cmbBoxÜrünNumarası, "Product Number");
                cmbBoxDepoNo.Text = "Warehouse No";
                cmbBoxÜrünNumarası.Text = "Product Number";
                cmbBoxMağazaNo.Text = "Store No";
                btnÜrünEkle.Text = "Add Product To Store";
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                Açıklama.SetToolTip(cmbBoxDepoNo, "Depo Numarası");
                Açıklama.SetToolTip(cmbBoxMağazaNo, "Mağaza Numarası");
                Açıklama.SetToolTip(cmbBoxÜrünNumarası, "Ürün Numarası");
                cmbBoxDepoNo.Text = "Depo Numarası";
                cmbBoxÜrünNumarası.Text = "Ürün Numarası";
                cmbBoxMağazaNo.Text = "Mağaza Numarası";
                btnÜrünEkle.Text = "Mağazaya Ürün Ekle";
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
        private void cmbBoxDepoNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ÜrünNumarasıVeriGetir();
        }
        private void MağazayaÜrünEkle_Activated(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            cmbBoxÜrünNumarası.Items.Clear();
            if (Ayarlar.dil == "English")
            {
                Açıklama.SetToolTip(cmbBoxDepoNo, "Warehouse Number");
                Açıklama.SetToolTip(cmbBoxMağazaNo, "Store Number");
                Açıklama.SetToolTip(cmbBoxÜrünNumarası, "Product Number");
                cmbBoxDepoNo.Text = "Warehouse No";
                cmbBoxÜrünNumarası.Text = "Product Number";
                cmbBoxMağazaNo.Text = "Store No";
                btnÜrünEkle.Text = "Add Product To Store";
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                Açıklama.SetToolTip(cmbBoxDepoNo, "Depo Numarası");
                Açıklama.SetToolTip(cmbBoxMağazaNo, "Mağaza Numarası");
                Açıklama.SetToolTip(cmbBoxÜrünNumarası, "Ürün Numarası");
                cmbBoxDepoNo.Text = "Depo Numarası";
                cmbBoxÜrünNumarası.Text = "Ürün Numarası";
                cmbBoxMağazaNo.Text = "Mağaza Numarası";
                btnÜrünEkle.Text = "Mağazaya Ürün Ekle";
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
                MağazayaDepodanUrunEkle();
                ürünAdıGetir();
                FalseYap();
                MessageBoxManager.Unregister();
                MessageBoxManager.OK = "OK";
                MessageBoxManager.Register();
                MessageBox.Show("Added Product From Warehouse To Store.", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                MağazayaDepodanUrunEkle();
                ürünAdıGetir();
                FalseYap();
                MessageBoxManager.Unregister();
                MessageBoxManager.OK = "Tamam";
                MessageBoxManager.Register();
                MessageBox.Show("Mağazaya Depodan Ürün Eklenmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

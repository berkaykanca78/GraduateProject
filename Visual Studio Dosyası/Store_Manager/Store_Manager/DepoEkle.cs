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
    public partial class DepoEkle : Form
    {
        string baglantiString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
        static string komutString = "";
        SqlConnection baglanti;
        SqlCommand komut;
        public static bool Kontrol = false;
        public DepoEkle()
        {
            InitializeComponent();
        }
        public void DepoyuEkle()
        {
            if (Kontrol == true)
            {
                if (Ayarlar.dil == "English")
                {
                    MessageBoxManager.Unregister();
                    MessageBoxManager.OK = "OK";
                    MessageBoxManager.Register();
                    MessageBox.Show("Your Warehouse Number Is In Our Database.Please Select A New Warehouse Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Ayarlar.dil == "Türkçe")
                {
                    MessageBoxManager.Unregister();
                    MessageBoxManager.OK = "Tamam";
                    MessageBoxManager.Register();
                    MessageBox.Show("Depo Numaranız Veritabanımızda Vardır.Lütfen Başka Bir Depo Numarası Seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            baglanti = new SqlConnection(baglantiString);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komutString = "INSERT INTO Warehouse (Warehouse_No,Warehouse_Address,Warehouse_Phone_No) " +
            "VALUES (@Warehouse_No,@Warehouse_Address,@Warehouse_Phone_No)";
            komut = new SqlCommand(komutString, baglanti);
            komut.Parameters.AddWithValue("@Warehouse_No", txtBoxDepoNo.Text);
            komut.Parameters.AddWithValue("@Warehouse_Address", txtBoxAdres.Text);
            komut.Parameters.AddWithValue("@Warehouse_Phone_No", txtBoxTelNo.Text);
            komut.ExecuteNonQuery();
            baglanti.Dispose();
            baglanti.Close();
            if (Ayarlar.dil == "English")
            {
                MessageBoxManager.Unregister();
                MessageBoxManager.OK = "OK";
                MessageBoxManager.Register();
                MessageBox.Show("Warehouse Registration Has Been Created", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                MessageBoxManager.Unregister();
                MessageBoxManager.OK = "Tamam";
                MessageBoxManager.Register();
                MessageBox.Show("Depo Kaydı Oluşturulmuştur.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void DepoEkle_Load(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            if (Ayarlar.dil == "English")
            {
                txtBoxAdres.Text = "Address";
                txtBoxTelNo.Text = "Phone Number";
                txtBoxDepoNo.Text = "Warehouse Number";
                btnDepoEkle.Text = "Add Warehouse";
                Açıklama.SetToolTip(txtBoxAdres, "Address");
                Açıklama.SetToolTip(txtBoxDepoNo, "Warehouse Number");
                Açıklama.SetToolTip(txtBoxTelNo, "Phone Number");
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                txtBoxAdres.Text = "Adres";
                txtBoxTelNo.Text = "Telefon Numarası";
                txtBoxDepoNo.Text = "Depo Numarası";
                btnDepoEkle.Text = "Depo Ekle";
                Açıklama.SetToolTip(txtBoxAdres, "Adres");
                Açıklama.SetToolTip(txtBoxDepoNo, "Depo Numarası");
                Açıklama.SetToolTip(txtBoxTelNo, "Telefon Numarası");
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
        private void DepoEkle_Activated(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            if (Ayarlar.dil == "English")
            {
                txtBoxAdres.Text = "Address";
                txtBoxTelNo.Text = "Phone Number";
                txtBoxDepoNo.Text = "Warehouse Number";
                btnDepoEkle.Text = "Add Warehouse";
                Açıklama.SetToolTip(txtBoxAdres, "Address");
                Açıklama.SetToolTip(txtBoxDepoNo, "Warehouse Number");
                Açıklama.SetToolTip(txtBoxTelNo, "Phone Number");
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                txtBoxAdres.Text = "Adres";
                txtBoxTelNo.Text = "Telefon Numarası";
                txtBoxDepoNo.Text = "Depo Numarası";
                btnDepoEkle.Text = "Depo Ekle";
                Açıklama.SetToolTip(txtBoxAdres, "Adres");
                Açıklama.SetToolTip(txtBoxDepoNo, "Depo Numarası");
                Açıklama.SetToolTip(txtBoxTelNo, "Telefon Numarası");
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
        private void btnDepoEkle_Click(object sender, EventArgs e)
        {
            DepoyuEkle();
        }
        private void txtBoxDepoNo_Leave(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(baglantiString);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komut = new SqlCommand("SELECT * FROM Warehouse WHERE Warehouse_No='" + txtBoxDepoNo.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Kontrol = true;
            }
            baglanti.Close();
        }
    }
}

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
    public partial class MağazaEkle : Form
    {
        string baglantiString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
        static string komutString = "";
        SqlConnection baglanti;
        SqlCommand komut;
        public static bool Kontrol = false;
        public MağazaEkle()
        {
            InitializeComponent();
        }
        public void MagazaEkle()
        {
            if (Kontrol == true)
            {
                if (Ayarlar.dil == "English")
                {
                    MessageBoxManager.Unregister();
                    MessageBoxManager.OK = "OK";
                    MessageBoxManager.Register();
                    MessageBox.Show("Your Store Number Is In Our Database.Please Select A New Store Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Ayarlar.dil == "Türkçe")
                {
                    MessageBoxManager.Unregister();
                    MessageBoxManager.OK = "Tamam";
                    MessageBoxManager.Register();
                    MessageBox.Show("Mağaza Numaranız Veritabanımızda Vardır.Lütfen Başka Bir Mağaza Numarası Seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            baglanti = new SqlConnection(baglantiString);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komutString = "INSERT INTO Store (Store_No,Store_Address,Store_Phone_No) " +
            "VALUES (@Store_No,@Store_Address,@Store_Phone_No)";
            komut = new SqlCommand(komutString, baglanti);
            komut.Parameters.AddWithValue("@Store_No", txtBoxMağazaNo.Text);
            komut.Parameters.AddWithValue("@Store_Address", txtBoxAdres.Text);
            komut.Parameters.AddWithValue("@Store_Phone_No", txtBoxTelNo.Text);
            komut.ExecuteNonQuery();
            baglanti.Dispose();
            baglanti.Close();
            if (Ayarlar.dil == "English")
            {
                MessageBoxManager.Unregister();
                MessageBoxManager.OK = "OK";
                MessageBoxManager.Register();
                MessageBox.Show("Store Registration Has Been Created", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                MessageBoxManager.Unregister();
                MessageBoxManager.OK = "Tamam";
                MessageBoxManager.Register();
                MessageBox.Show("Mağaza Kaydı Oluşturulmuştur.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void MağazaEkle_Load(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            if (Ayarlar.dil == "English")
            {
                Açıklama.SetToolTip(txtBoxAdres, "Address");
                Açıklama.SetToolTip(txtBoxMağazaNo, "Store Number");
                Açıklama.SetToolTip(txtBoxTelNo, "Phone Number");
                txtBoxAdres.Text = "Address";
                txtBoxTelNo.Text = "Phone Number";
                txtBoxMağazaNo.Text = "Store Number";
                btnMağazaEkle.Text = "Add Store";
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                Açıklama.SetToolTip(txtBoxAdres, "Adres");
                Açıklama.SetToolTip(txtBoxMağazaNo, "Mağaza Numarası");
                Açıklama.SetToolTip(txtBoxTelNo, "Telefon Numarası");
                txtBoxAdres.Text = "Adres";
                txtBoxTelNo.Text = "Telefon Numarası";
                txtBoxMağazaNo.Text = "Mağaza Numarası";
                btnMağazaEkle.Text = "Mağaza Ekle";
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
        private void MağazaEkle_Activated(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            if (Ayarlar.dil == "English")
            {
                Açıklama.SetToolTip(txtBoxAdres, "Address");
                Açıklama.SetToolTip(txtBoxMağazaNo, "Store Number");
                Açıklama.SetToolTip(txtBoxTelNo, "Phone Number");
                txtBoxAdres.Text = "Address";
                txtBoxTelNo.Text = "Phone Number";
                txtBoxMağazaNo.Text = "Store Number";
                btnMağazaEkle.Text = "Add Store";
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                Açıklama.SetToolTip(txtBoxAdres, "Adres");
                Açıklama.SetToolTip(txtBoxMağazaNo, "Mağaza Numarası");
                Açıklama.SetToolTip(txtBoxTelNo, "Telefon Numarası");
                txtBoxAdres.Text = "Adres";
                txtBoxTelNo.Text = "Telefon Numarası";
                txtBoxMağazaNo.Text = "Mağaza Numarası";
                btnMağazaEkle.Text = "Mağaza Ekle";
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
        private void btnMağazaEkle_Click(object sender, EventArgs e)
        {
                MagazaEkle();
        }
        private void txtBoxMağazaNo_Leave(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(baglantiString);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komut = new SqlCommand("SELECT * FROM Store WHERE Store_No='" + txtBoxMağazaNo.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Kontrol = true;
            }
            baglanti.Close();
        }
    }
}

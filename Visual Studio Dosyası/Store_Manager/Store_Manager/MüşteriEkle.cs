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
    public partial class MüşteriEkle : Form
    {
        string baglantiString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
        static string komutString = "";
        SqlConnection baglanti;
        SqlCommand komut;
        public static bool Kontrol = false;
        public MüşteriEkle()
        {
            InitializeComponent();
        }
        public void MusteriEkle()
        {
            if (Kontrol == true)
            {
                if (Ayarlar.dil == "English")
                {
                    MessageBoxManager.Unregister();
                    MessageBoxManager.OK = "OK";
                    MessageBoxManager.Register();
                    MessageBox.Show("Your Customer TC Number Is In Our Database.Please Select A New Customer TC Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Ayarlar.dil == "Türkçe")
                {
                    MessageBoxManager.Unregister();
                    MessageBoxManager.OK = "Tamam";
                    MessageBoxManager.Register();
                    MessageBox.Show("Müşterinizin TC Numarası Veritabanımızda Vardır.Lütfen Başka Bir Müşteri TC Numarası Seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            baglanti = new SqlConnection(baglantiString);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komutString = "INSERT INTO Customer (Customer_Name,Customer_Surname,Customer_Address,Customer_E_Mail,Customer_Phone_No,Customer_TC_No,Customer_Debt,Customer_Point) " +
            "VALUES (@Customer_Name,@Customer_Surname,@Customer_Address,@Customer_E_Mail,@Customer_Phone_No,@Customer_TC_No,@Customer_Debt,@Customer_Point)";
            komut = new SqlCommand(komutString, baglanti);
            komut.Parameters.AddWithValue("@Customer_Name", txtBoxAdı.Text);
            komut.Parameters.AddWithValue("@Customer_Surname", txtBoxSoyadı.Text);
            komut.Parameters.AddWithValue("@Customer_TC_No", txtBoxTCNo.Text);
            komut.Parameters.AddWithValue("@Customer_Phone_No", txtBoxTelNo.Text);
            komut.Parameters.AddWithValue("@Customer_E_Mail", txtBoxMail.Text);
            komut.Parameters.AddWithValue("@Customer_Address", txtBoxAdres.Text);
            komut.Parameters.AddWithValue("@Customer_Debt", 0);
            komut.Parameters.AddWithValue("@Customer_Point", 0);
            komut.ExecuteNonQuery();
            baglanti.Dispose();
            baglanti.Close();
            if (Ayarlar.dil == "English")
            {
                MessageBoxManager.Unregister();
                MessageBoxManager.OK = "OK";
                MessageBoxManager.Register();
                MessageBox.Show("Customer Registration Has Been Created", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                MessageBoxManager.Unregister();
                MessageBoxManager.OK = "Tamam";
                MessageBoxManager.Register();
                MessageBox.Show("Müşteri Kaydı Oluşturulmuştur.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Müşteri_Load(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            if (Ayarlar.dil == "English")
            {
                Açıklama.SetToolTip(txtBoxAdres, "Address");
                Açıklama.SetToolTip(txtBoxAdı, "Name");
                Açıklama.SetToolTip(txtBoxMail, "E - Mail");
                Açıklama.SetToolTip(txtBoxSoyadı, "Surname");
                Açıklama.SetToolTip(txtBoxTCNo, "TC Number");
                Açıklama.SetToolTip(txtBoxTelNo, "Phone Number");
                txtBoxAdres.Text = "Address";
                txtBoxAdı.Text = "Name";
                txtBoxMail.Text = "E - Mail";
                txtBoxSoyadı.Text = "Surname";
                txtBoxTCNo.Text = "TC Number";
                txtBoxTelNo.Text = "Phone Number";
                btnMüşteriEkle.Text = "Add Customer";
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                Açıklama.SetToolTip(txtBoxAdres, "Adres");
                Açıklama.SetToolTip(txtBoxAdı, "Adı");
                Açıklama.SetToolTip(txtBoxMail, "Mail Adresi");
                Açıklama.SetToolTip(txtBoxSoyadı, "Soyadı");
                Açıklama.SetToolTip(txtBoxTCNo, "TC Kimlik Numarası");
                Açıklama.SetToolTip(txtBoxTelNo, "Telefon Numarası");
                txtBoxAdres.Text = "Adres";
                txtBoxAdı.Text = "Adı";
                txtBoxMail.Text = "E - Mail";
                txtBoxSoyadı.Text = "Soyadı";
                txtBoxTCNo.Text = "TC Kimlik Numarası";
                txtBoxTelNo.Text = "Telefon Numarası";
                btnMüşteriEkle.Text = "Müşteri Ekle";
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
        private void Müşteri_Activated(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            if (Ayarlar.dil == "English")
            {
                Açıklama.SetToolTip(txtBoxAdres, "Address");
                Açıklama.SetToolTip(txtBoxAdı, "Name");
                Açıklama.SetToolTip(txtBoxMail, "E - Mail");
                Açıklama.SetToolTip(txtBoxSoyadı, "Surname");
                Açıklama.SetToolTip(txtBoxTCNo, "TC Number");
                Açıklama.SetToolTip(txtBoxTelNo, "Phone Number");
                txtBoxAdres.Text = "Address";
                txtBoxAdı.Text = "Name";
                txtBoxMail.Text = "E - Mail";
                txtBoxSoyadı.Text = "Surname";
                txtBoxTCNo.Text = "TC Number";
                txtBoxTelNo.Text = "Phone Number";
                btnMüşteriEkle.Text = "Add Customer";
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                Açıklama.SetToolTip(txtBoxAdres, "Adres");
                Açıklama.SetToolTip(txtBoxAdı, "Adı");
                Açıklama.SetToolTip(txtBoxMail, "Mail Adresi");
                Açıklama.SetToolTip(txtBoxSoyadı, "Soyadı");
                Açıklama.SetToolTip(txtBoxTCNo, "TC Kimlik Numarası");
                Açıklama.SetToolTip(txtBoxTelNo, "Telefon Numarası");
                txtBoxAdres.Text = "Adres";
                txtBoxAdı.Text = "Adı";
                txtBoxMail.Text = "E - Mail";
                txtBoxSoyadı.Text = "Soyadı";
                txtBoxTCNo.Text = "TC Kimlik Numarası";
                txtBoxTelNo.Text = "Telefon Numarası";
                btnMüşteriEkle.Text = "Müşteri Ekle";
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
        private void txtBoxAdı_Click(object sender, EventArgs e)
        {
            txtBoxAdı.Text = "";
        }
        private void txtBoxSoyadı_Click(object sender, EventArgs e)
        {
            txtBoxSoyadı.Text = "";
        }
        private void txtBoxTCNo_Click(object sender, EventArgs e)
        {
            txtBoxTCNo.Text = "";
        }
        private void txtBoxTelNo_Click(object sender, EventArgs e)
        {
            txtBoxTelNo.Text = "";
        }
        private void txtBoxMail_Click(object sender, EventArgs e)
        {
            txtBoxMail.Text = "";
        }
        private void txtBoxAdres_Click(object sender, EventArgs e)
        {
            txtBoxAdres.Text = "";
        }

        private void btnMüşteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle();
        }
        private void txtBoxTCNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtBoxTelNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtBoxAdı_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        private void txtBoxSoyadı_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        private void txtBoxTCNo_Leave(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(baglantiString);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komut = new SqlCommand("SELECT * FROM Customer WHERE Customer_TC_No='" + txtBoxTCNo.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Kontrol = true;
            }
            baglanti.Close();
        }
    }
}

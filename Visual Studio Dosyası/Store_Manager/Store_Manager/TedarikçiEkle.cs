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
    public partial class TedarikçiEkle : Form
    {
        string baglantiString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
        static string komutString = "";
        SqlConnection baglanti;
        SqlCommand komut;
        public static bool Kontrol = false;
        public TedarikçiEkle()
        {
            InitializeComponent();
        }
        public void TedarikciEkle()
        {
            if (Kontrol == true)
            {
                if (Ayarlar.dil == "English")
                {
                    MessageBoxManager.Unregister();
                    MessageBoxManager.OK = "OK";
                    MessageBoxManager.Register();
                    MessageBox.Show("Your Supplier TC Number Is In Our Database.Please Select A New Supplier TC Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Ayarlar.dil == "Türkçe")
                {
                    MessageBoxManager.Unregister();
                    MessageBoxManager.OK = "Tamam";
                    MessageBoxManager.Register();
                    MessageBox.Show("Tedarikçinin TC Numarası Veritabanımızda Vardır.Lütfen Başka Bir Tedarikçi TC Numarası Seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            baglanti = new SqlConnection(baglantiString);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komutString = "INSERT INTO Supplier (Supplier_TC_No,Supplier_Firm_Name,Supplier_Name,Supplier_Surname,Supplier_Address,Supplier_Phone_No,Supplier_E_Mail) " +
            "VALUES (@Supplier_TC_No,@Supplier_Firm_Name,@Supplier_Name,@Supplier_Surname,@Supplier_Address,@Supplier_Phone_No,@Supplier_E_Mail)";
            komut = new SqlCommand(komutString, baglanti);
            komut.Parameters.AddWithValue("@Supplier_TC_No", txtBoxTCNo.Text);
            komut.Parameters.AddWithValue("@Supplier_Firm_Name", txtBoxFirmaAdı.Text);
            komut.Parameters.AddWithValue("@Supplier_Name", txtBoxAdı.Text);
            komut.Parameters.AddWithValue("@Supplier_Surname", txtBoxSoyadı.Text);
            komut.Parameters.AddWithValue("@Supplier_Address", txtBoxAdres.Text);
            komut.Parameters.AddWithValue("@Supplier_Phone_No", txtBoxTelNo.Text);
            komut.Parameters.AddWithValue("@Supplier_E_Mail", txtBoxMail.Text);
            komut.ExecuteNonQuery();
            baglanti.Dispose();
            baglanti.Close();
            if (Ayarlar.dil == "English")
            {
                MessageBoxManager.Unregister();
                MessageBoxManager.OK = "OK";
                MessageBoxManager.Register();
                MessageBox.Show("Supplier Registration Has Been Created", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                MessageBoxManager.Unregister();
                MessageBoxManager.OK = "Tamam";
                MessageBoxManager.Register();
                MessageBox.Show("Tedarikçi Kaydı Oluşturulmuştur.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void TedarikçiEkle_Load(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            if (Ayarlar.dil == "English")
            {
                Açıklama.SetToolTip(txtBoxAdres, "Address");
                Açıklama.SetToolTip(txtBoxAdı, "Name");
                Açıklama.SetToolTip(txtBoxFirmaAdı, "Firm Name");
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
                txtBoxFirmaAdı.Text = "Firm Name";
                btnTedarikçiEkle.Text = "Add Supplier";
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                Açıklama.SetToolTip(txtBoxAdres, "Adres");
                Açıklama.SetToolTip(txtBoxAdı, "Adı");
                Açıklama.SetToolTip(txtBoxFirmaAdı, "Firma Adı");
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
                btnTedarikçiEkle.Text = "Tedarikçi Ekle";
                txtBoxFirmaAdı.Text = "Firma Adı";
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
        private void TedarikçiEkle_Activated(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            if (Ayarlar.dil == "English")
            {
                Açıklama.SetToolTip(txtBoxAdres, "Address");
                Açıklama.SetToolTip(txtBoxAdı, "Name");
                Açıklama.SetToolTip(txtBoxFirmaAdı, "Firm Name");
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
                txtBoxFirmaAdı.Text = "Firm Name";
                btnTedarikçiEkle.Text = "Add Supplier";
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                Açıklama.SetToolTip(txtBoxAdres, "Adres");
                Açıklama.SetToolTip(txtBoxAdı, "Adı");
                Açıklama.SetToolTip(txtBoxFirmaAdı, "Firma Adı");
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
                btnTedarikçiEkle.Text = "Tedarikçi Ekle";
                txtBoxFirmaAdı.Text = "Firma Adı";
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

        private void btnTedarikçiEkle_Click(object sender, EventArgs e)
        {
            TedarikciEkle();
        }
        private void txtBoxTCNo_Leave(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(baglantiString);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komut = new SqlCommand("SELECT * FROM Supplier WHERE Supplier_TC_No='" + txtBoxTCNo.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Kontrol = true;
            }
            baglanti.Close();
        }
    }
}

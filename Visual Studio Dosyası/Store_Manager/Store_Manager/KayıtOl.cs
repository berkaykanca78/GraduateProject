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
    public partial class KayıtOl : Form
    {
        public KayıtOl()
        {
            InitializeComponent();
        }
        string baglantiString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
        static string komutString = "";
        SqlConnection baglanti;
        SqlCommand komut;
        public static bool Kontrol = false;
        public void Kayıt_Ol()
        {
            if (Kontrol == true)
            {
                if (Ayarlar.dil == "English")
                {
                    MessageBoxManager.Unregister();
                    MessageBoxManager.OK = "OK";
                    MessageBoxManager.Register();
                    MessageBox.Show("Your User Name Is In Our Database.Please Select A New User Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Ayarlar.dil == "Türkçe")
                {
                    MessageBoxManager.Unregister();
                    MessageBoxManager.OK = "Tamam";
                    MessageBoxManager.Register();
                    MessageBox.Show("Kullanıcı Adınız Veritabanımızda Vardır.Lütfen Başka Bir Kullanıcı Adı Seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            baglanti = new SqlConnection(baglantiString);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            if(radBtnYönetici.Checked==false && radBtnÇalışan.Checked == false)
            {
                if (Ayarlar.dil == "Türkçe")
                {
                    MessageBox.Show("Lütfen Yetki Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Ayarlar.dil == "English")
                {
                    MessageBox.Show("Please Choose Authority.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (radBtnÇalışan.Checked == true)
            {
                komutString = "INSERT INTO Employee (Employee_Name,Employee_Surname,Employee_User_Name,Employee_Password,Employee_Address,Employee_E_Mail,Employee_Phone_No,Employee_TC_No) " +
            "VALUES (@Employee_Name,@Employee_Surname,@Employee_User_Name,@Employee_Password,@Employee_Address,@Employee_E_Mail,@Employee_Phone_No,@Employee_TC_No)";
                komut = new SqlCommand(komutString, baglanti);
                if (txtBoxŞifre.Text == txtBoxŞifreTekrar.Text)
                {
                    komut.Parameters.AddWithValue("@Employee_Name", txtBoxAd.Text);
                    komut.Parameters.AddWithValue("@Employee_Surname", txtBoxSoyad.Text);
                    komut.Parameters.AddWithValue("@Employee_User_Name", txtBoxKulAdı.Text);
                    komut.Parameters.AddWithValue("@Employee_Password", txtBoxŞifre.Text);
                    komut.Parameters.AddWithValue("@Employee_Address", txtBoxAdres.Text);
                    komut.Parameters.AddWithValue("@Employee_E_Mail", txtBoxMail.Text);
                    komut.Parameters.AddWithValue("@Employee_Phone_No", txtBoxTelNo.Text);
                    komut.Parameters.AddWithValue("@Employee_TC_No", txtBoxTCKimlikNo.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Dispose();
                    baglanti.Close();
                    timerZaman.Start();
                }
                else if (txtBoxŞifre.Text != txtBoxŞifreTekrar.Text)
                {
                    if (Ayarlar.dil == "Türkçe")
                    {
                        MessageBox.Show("Şifreleriniz Birbiri İle Uyuşmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (Ayarlar.dil == "English")
                    {
                        MessageBox.Show("Your Password Is Not Equal To Password Again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    baglanti.Dispose();
                    baglanti.Close();
                }
            }
            else if (radBtnYönetici.Checked == true)
            {
                komutString = "INSERT INTO Manager (Manager_Name,Manager_Surname,Manager_User_Name,Manager_Password,Manager_Address,Manager_E_Mail,Manager_Phone_No,Manager_TC_No) " +
            "VALUES (@Manager_Name,@Manager_Surname,@Manager_User_Name,@Manager_Password,@Manager_Address,@Manager_E_Mail,@Manager_Phone_No,@Manager_TC_No)";
                komut = new SqlCommand(komutString, baglanti);
                if (txtBoxŞifre.Text == txtBoxŞifreTekrar.Text)
                {
                    komut.Parameters.AddWithValue("@Manager_Name", txtBoxAd.Text);
                    komut.Parameters.AddWithValue("@Manager_Surname", txtBoxSoyad.Text);
                    komut.Parameters.AddWithValue("@Manager_User_Name", txtBoxKulAdı.Text);
                    komut.Parameters.AddWithValue("@Manager_Password", txtBoxŞifre.Text);
                    komut.Parameters.AddWithValue("@Manager_Address", txtBoxAdres.Text);
                    komut.Parameters.AddWithValue("@Manager_E_Mail", txtBoxMail.Text);
                    komut.Parameters.AddWithValue("@Manager_Phone_No", txtBoxTelNo.Text);
                    komut.Parameters.AddWithValue("@Manager_TC_No", txtBoxTCKimlikNo.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Dispose();
                    baglanti.Close();
                    timerZaman.Start();
                }
                else if (txtBoxŞifre.Text != txtBoxŞifreTekrar.Text)
                {
                    if (Ayarlar.dil == "Türkçe")
                    {
                        MessageBox.Show("Şifreleriniz Birbiri İle Uyuşmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (Ayarlar.dil == "English")
                    {
                        MessageBox.Show("Your Password Is Not Equal To Password Again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    baglanti.Dispose();
                    baglanti.Close();
                }
            }
        }
        private void picBoxÇıkış_Click(object sender, EventArgs e)
        {
            picBoxÇıkış.Focus();
            OturumAç oturumaç = new OturumAç();
            this.Hide();
            oturumaç.Show();
        }

        private void picBoxAyarlar_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show();
        }

        private void KayıtOl_Load(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            progressBarYükleme.Value = 0;
            if (Ayarlar.dil == "English")
            {
                Açıklama.SetToolTip(txtBoxAd, "Name");
                Açıklama.SetToolTip(txtBoxAdres, "Address");
                Açıklama.SetToolTip(txtBoxKulAdı, "User Name");
                Açıklama.SetToolTip(txtBoxMail, "E - Mail");
                Açıklama.SetToolTip(txtBoxSoyad, "Surname");
                Açıklama.SetToolTip(txtBoxTCKimlikNo, "TC Number");
                Açıklama.SetToolTip(txtBoxTelNo, "Phone Number");
                Açıklama.SetToolTip(txtBoxŞifre, "Password");
                Açıklama.SetToolTip(txtBoxŞifreTekrar, "Paswoord Again");
                Açıklama.SetToolTip(picBoxAyarlar, "Settings");
                Açıklama.SetToolTip(picBoxÇıkış, "Exit");
                txtBoxKulAdı.Text = "User Name"; txtBoxŞifre.Text = "Password";
                txtBoxAd.Text = "Name"; txtBoxAdres.Text = "Address";
                txtBoxMail.Text = "E - Mail"; txtBoxSoyad.Text = "Surname";
                txtBoxTCKimlikNo.Text = "ID Number"; txtBoxTelNo.Text = "Phone Number";
                txtBoxŞifreTekrar.Text = "Password Again";
                btnKayıtOl.Text = "Sign Up";
                radBtnYönetici.Text = "Manager"; radBtnÇalışan.Text = "Employee";
                lblKayıtOl.Text = "Sign Up";
                MessageBoxManager.Unregister();
                MessageBoxManager.OK = "OK";
                MessageBoxManager.Yes = "Yes";
                MessageBoxManager.No = "No";
                MessageBoxManager.Register();
                if (Ayarlar.tema == "Varsayılan")
                {
                    panelAlt.BackColor = Color.FromArgb(40, 40, 40);
                    panelÜst.BackColor = Color.FromArgb(40, 40, 40);
                    picBoxAyarlar.BackColor = Color.FromArgb(40, 40, 40);
                    picBoxÇıkış.BackColor = Color.FromArgb(40, 40, 40);
                    lblKayıtOl.BackColor = Color.FromArgb(40, 40, 40);
                    this.BackColor = Color.FromArgb(64, 64, 64);
                }
                else if (Ayarlar.tema == "Kırmızı")
                {
                    panelÜst.BackColor = Color.DarkRed;
                    panelAlt.BackColor = Color.DarkRed;
                    picBoxAyarlar.BackColor = Color.DarkRed;
                    picBoxÇıkış.BackColor = Color.DarkRed;
                    lblKayıtOl.BackColor = Color.DarkRed;
                    this.BackColor = Color.Red;
                }
                else if (Ayarlar.tema == "Mavi")
                {
                    panelÜst.BackColor = Color.DarkBlue;
                    panelAlt.BackColor = Color.DarkBlue;
                    picBoxAyarlar.BackColor = Color.DarkBlue;
                    picBoxÇıkış.BackColor = Color.DarkBlue;
                    lblKayıtOl.BackColor = Color.DarkBlue;
                    this.BackColor = Color.Blue;
                }
                else if (Ayarlar.tema == "Yeşil")
                {
                    panelÜst.BackColor = Color.DarkGreen;
                    panelAlt.BackColor = Color.DarkGreen;
                    picBoxAyarlar.BackColor = Color.DarkGreen;
                    picBoxÇıkış.BackColor = Color.DarkGreen;
                    lblKayıtOl.BackColor = Color.DarkGreen;
                    this.BackColor = Color.Green;
                }
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                Açıklama.SetToolTip(txtBoxAd, "Adı");
                Açıklama.SetToolTip(txtBoxAdres, "Adres");
                Açıklama.SetToolTip(txtBoxKulAdı, "Kullanıcı Adı");
                Açıklama.SetToolTip(txtBoxMail, "Mail Adresi");
                Açıklama.SetToolTip(txtBoxSoyad, "Soyadı");
                Açıklama.SetToolTip(txtBoxTCKimlikNo, "TC Kimlik Numarası");
                Açıklama.SetToolTip(txtBoxTelNo, "Telefon Numarası");
                Açıklama.SetToolTip(txtBoxŞifre, "Şifre");
                Açıklama.SetToolTip(txtBoxŞifreTekrar, "Şifre Tekrar");
                Açıklama.SetToolTip(picBoxAyarlar, "Ayarlar");
                Açıklama.SetToolTip(picBoxÇıkış, "Çıkış");
                txtBoxKulAdı.Text = "Kullanıcı Adı"; txtBoxŞifre.Text = "Şifre";
                txtBoxAd.Text = "Ad"; txtBoxAdres.Text = "Adres";
                txtBoxMail.Text = "E - Mail"; txtBoxSoyad.Text = "Soyad";
                txtBoxTCKimlikNo.Text = "TC Kimlik Numarası"; txtBoxTelNo.Text = "Telefon Numarası";
                txtBoxŞifreTekrar.Text = "Şifre Tekrar";
                btnKayıtOl.Text = "Kayıt Ol";
                radBtnYönetici.Text = "Yönetici"; radBtnÇalışan.Text = "Çalışan";
                lblKayıtOl.Text = "Kayıt Ol";
                MessageBoxManager.Unregister();
                MessageBoxManager.OK = "Tamam";
                MessageBoxManager.Yes = "Evet";
                MessageBoxManager.No = "Hayır";
                MessageBoxManager.Register();
                if (Ayarlar.tema == "Varsayılan")
                {
                    panelAlt.BackColor = Color.FromArgb(40, 40, 40);
                    panelÜst.BackColor = Color.FromArgb(40, 40, 40);
                    picBoxAyarlar.BackColor = Color.FromArgb(40, 40, 40);
                    picBoxÇıkış.BackColor = Color.FromArgb(40, 40, 40);
                    lblKayıtOl.BackColor = Color.FromArgb(40, 40, 40);
                    this.BackColor = Color.FromArgb(64, 64, 64);
                }
                else if (Ayarlar.tema == "Kırmızı")
                {
                    panelÜst.BackColor = Color.DarkRed;
                    panelAlt.BackColor = Color.DarkRed;
                    picBoxAyarlar.BackColor = Color.DarkRed;
                    picBoxÇıkış.BackColor = Color.DarkRed;
                    lblKayıtOl.BackColor = Color.DarkRed;
                    this.BackColor = Color.Red;
                }
                else if (Ayarlar.tema == "Mavi")
                {
                    panelÜst.BackColor = Color.DarkBlue;
                    panelAlt.BackColor = Color.DarkBlue;
                    picBoxAyarlar.BackColor = Color.DarkBlue;
                    picBoxÇıkış.BackColor = Color.DarkBlue;
                    lblKayıtOl.BackColor = Color.DarkBlue;
                    this.BackColor = Color.Blue;
                }
                else if (Ayarlar.tema == "Yeşil")
                {
                    panelÜst.BackColor = Color.DarkGreen;
                    panelAlt.BackColor = Color.DarkGreen;
                    picBoxAyarlar.BackColor = Color.DarkGreen;
                    picBoxÇıkış.BackColor = Color.DarkGreen;
                    lblKayıtOl.BackColor = Color.DarkGreen;
                    this.BackColor = Color.Green;
                }
            }
        }

        private void KayıtOl_Activated(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            progressBarYükleme.Value = 0;
            if (Ayarlar.dil == "English")
            {
                Açıklama.SetToolTip(txtBoxAd, "Name");
                Açıklama.SetToolTip(txtBoxAdres, "Address");
                Açıklama.SetToolTip(txtBoxKulAdı, "User Name");
                Açıklama.SetToolTip(txtBoxMail, "E - Mail");
                Açıklama.SetToolTip(txtBoxSoyad, "Surname");
                Açıklama.SetToolTip(txtBoxTCKimlikNo, "TC Number");
                Açıklama.SetToolTip(txtBoxTelNo, "Phone Number");
                Açıklama.SetToolTip(txtBoxŞifre, "Password");
                Açıklama.SetToolTip(txtBoxŞifreTekrar, "Paswoord Again");
                Açıklama.SetToolTip(picBoxAyarlar, "Settings");
                Açıklama.SetToolTip(picBoxÇıkış, "Exit");
                txtBoxKulAdı.Text = "User Name"; txtBoxŞifre.Text = "Password";
                txtBoxAd.Text = "Name"; txtBoxAdres.Text = "Address";
                txtBoxMail.Text = "E - Mail"; txtBoxSoyad.Text = "Surname";
                txtBoxTCKimlikNo.Text = "ID Number"; txtBoxTelNo.Text = "Phone Number";
                txtBoxŞifreTekrar.Text = "Password Again";
                btnKayıtOl.Text = "Sign Up";
                radBtnYönetici.Text = "Manager"; radBtnÇalışan.Text = "Employee";
                lblKayıtOl.Text = "Sign Up";
                MessageBoxManager.Unregister();
                MessageBoxManager.OK = "OK";
                MessageBoxManager.Yes = "Yes";
                MessageBoxManager.No = "No";
                MessageBoxManager.Register();
                if (Ayarlar.tema == "Varsayılan")
                {
                    panelAlt.BackColor = Color.FromArgb(40, 40, 40);
                    panelÜst.BackColor = Color.FromArgb(40, 40, 40);
                    picBoxAyarlar.BackColor = Color.FromArgb(40, 40, 40);
                    picBoxÇıkış.BackColor = Color.FromArgb(40, 40, 40);
                    lblKayıtOl.BackColor = Color.FromArgb(40, 40, 40);
                    this.BackColor = Color.FromArgb(64, 64, 64);
                }
                else if (Ayarlar.tema == "Kırmızı")
                {
                    panelÜst.BackColor = Color.DarkRed;
                    panelAlt.BackColor = Color.DarkRed;
                    picBoxAyarlar.BackColor = Color.DarkRed;
                    picBoxÇıkış.BackColor = Color.DarkRed;
                    lblKayıtOl.BackColor = Color.DarkRed;
                    this.BackColor = Color.Red;
                }
                else if (Ayarlar.tema == "Mavi")
                {
                    panelÜst.BackColor = Color.DarkBlue;
                    panelAlt.BackColor = Color.DarkBlue;
                    picBoxAyarlar.BackColor = Color.DarkBlue;
                    picBoxÇıkış.BackColor = Color.DarkBlue;
                    lblKayıtOl.BackColor = Color.DarkBlue;
                    this.BackColor = Color.Blue;
                }
                else if (Ayarlar.tema == "Yeşil")
                {
                    panelÜst.BackColor = Color.DarkGreen;
                    panelAlt.BackColor = Color.DarkGreen;
                    picBoxAyarlar.BackColor = Color.DarkGreen;
                    picBoxÇıkış.BackColor = Color.DarkGreen;
                    lblKayıtOl.BackColor = Color.DarkGreen;
                    this.BackColor = Color.Green;
                }
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                Açıklama.SetToolTip(txtBoxAd, "Adı");
                Açıklama.SetToolTip(txtBoxAdres, "Adres");
                Açıklama.SetToolTip(txtBoxKulAdı, "Kullanıcı Adı");
                Açıklama.SetToolTip(txtBoxMail, "Mail Adresi");
                Açıklama.SetToolTip(txtBoxSoyad, "Soyadı");
                Açıklama.SetToolTip(txtBoxTCKimlikNo, "TC Kimlik Numarası");
                Açıklama.SetToolTip(txtBoxTelNo, "Telefon Numarası");
                Açıklama.SetToolTip(txtBoxŞifre, "Şifre");
                Açıklama.SetToolTip(txtBoxŞifreTekrar, "Şifre Tekrar");
                Açıklama.SetToolTip(picBoxAyarlar, "Ayarlar");
                Açıklama.SetToolTip(picBoxÇıkış, "Çıkış");
                txtBoxKulAdı.Text = "Kullanıcı Adı"; txtBoxŞifre.Text = "Şifre";
                txtBoxAd.Text = "Ad"; txtBoxAdres.Text = "Adres";
                txtBoxMail.Text = "E - Mail"; txtBoxSoyad.Text = "Soyad";
                txtBoxTCKimlikNo.Text = "TC Kimlik Numarası"; txtBoxTelNo.Text = "Telefon Numarası";
                txtBoxŞifreTekrar.Text = "Şifre Tekrar";
                btnKayıtOl.Text = "Kayıt Ol";
                radBtnYönetici.Text = "Yönetici"; radBtnÇalışan.Text = "Çalışan";
                lblKayıtOl.Text = "Kayıt Ol";
                MessageBoxManager.Unregister();
                MessageBoxManager.OK = "Tamam";
                MessageBoxManager.Yes = "Evet";
                MessageBoxManager.No = "Hayır";
                MessageBoxManager.Register();
                if (Ayarlar.tema == "Varsayılan")
                {
                    panelAlt.BackColor = Color.FromArgb(40, 40, 40);
                    panelÜst.BackColor = Color.FromArgb(40, 40, 40);
                    picBoxAyarlar.BackColor = Color.FromArgb(40, 40, 40);
                    picBoxÇıkış.BackColor = Color.FromArgb(40, 40, 40);
                    lblKayıtOl.BackColor = Color.FromArgb(40, 40, 40);
                    this.BackColor = Color.FromArgb(64, 64, 64);
                }
                else if (Ayarlar.tema == "Kırmızı")
                {
                    panelÜst.BackColor = Color.DarkRed;
                    panelAlt.BackColor = Color.DarkRed;
                    picBoxAyarlar.BackColor = Color.DarkRed;
                    picBoxÇıkış.BackColor = Color.DarkRed;
                    lblKayıtOl.BackColor = Color.DarkRed;
                    this.BackColor = Color.Red;
                }
                else if (Ayarlar.tema == "Mavi")
                {
                    panelÜst.BackColor = Color.DarkBlue;
                    panelAlt.BackColor = Color.DarkBlue;
                    picBoxAyarlar.BackColor = Color.DarkBlue;
                    picBoxÇıkış.BackColor = Color.DarkBlue;
                    lblKayıtOl.BackColor = Color.DarkBlue;
                    this.BackColor = Color.Blue;
                }
                else if (Ayarlar.tema == "Yeşil")
                {
                    panelÜst.BackColor = Color.DarkGreen;
                    panelAlt.BackColor = Color.DarkGreen;
                    picBoxAyarlar.BackColor = Color.DarkGreen;
                    picBoxÇıkış.BackColor = Color.DarkGreen;
                    lblKayıtOl.BackColor = Color.DarkGreen;
                    this.BackColor = Color.Green;
                }
            }
        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            Kayıt_Ol();
        }

        private void timerZaman_Tick(object sender, EventArgs e)
        {
            progressBarYükleme.Visible = true;
            progressBarYükleme.Value += 5;
            if (progressBarYükleme.Value == 100)
            {
                timerZaman.Stop();
                if (Ayarlar.dil == "Türkçe")
                {
                    radBtnYönetici.Checked = false;
                    radBtnÇalışan.Checked = false;
                    MessageBox.Show("Kaydınız Oluşturulmuştur.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Ayarlar.dil == "English")
                {
                    radBtnYönetici.Checked = false;
                    radBtnÇalışan.Checked = false;
                    MessageBox.Show("Your Registration Has Been Created", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                progressBarYükleme.Visible = false;
            }
        }

        private void txtBoxTCKimlikNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxTelNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
        private void txtBoxSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
        private void txtBoxKulAdı_Click(object sender, EventArgs e)
        {
            txtBoxKulAdı.Text = "";
        }
        private void txtBoxŞifre_Click(object sender, EventArgs e)
        {
            txtBoxŞifre.Text = "";
        }
        private void txtBoxŞifreTekrar_Click(object sender, EventArgs e)
        {
            txtBoxŞifreTekrar.Text = "";
        }
        private void txtBoxAd_Click(object sender, EventArgs e)
        {
            txtBoxAd.Text = "";
        }
        private void txtBoxSoyad_Click(object sender, EventArgs e)
        {
            txtBoxSoyad.Text = "";
        }
        private void txtBoxTCKimlikNo_Click(object sender, EventArgs e)
        {
            txtBoxTCKimlikNo.Text = "";
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
        private void radBtnÇalışan_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnÇalışan.Checked == true)
            {
                baglanti = new SqlConnection(baglantiString);
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                komut = new SqlCommand("SELECT * FROM Employee WHERE Employee_User_Name='" + txtBoxKulAdı.Text + "'", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    Kontrol = true;
                }
                baglanti.Close();
            }
        }
        private void radBtnYönetici_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnYönetici.Checked == true)
            {
                baglanti = new SqlConnection(baglantiString);
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                komut = new SqlCommand("SELECT * FROM Manager WHERE Manager_User_Name='" + txtBoxKulAdı.Text + "'", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    Kontrol = true;
                }
                baglanti.Close();
            }
        }
        private void txtBoxKulAdı_Leave(object sender, EventArgs e)
        {
            if (radBtnÇalışan.Checked == true)
            {
                baglanti = new SqlConnection(baglantiString);
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                komut = new SqlCommand("SELECT * FROM Employee WHERE Employee_User_Name='" + txtBoxKulAdı.Text + "'", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    Kontrol = true;
                }
                baglanti.Close();
            }
            else if (radBtnYönetici.Checked == true)
            {
                baglanti = new SqlConnection(baglantiString);
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                komut = new SqlCommand("SELECT * FROM Manager WHERE Manager_User_Name='" + txtBoxKulAdı.Text + "'", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    Kontrol = true;
                }
                baglanti.Close();
            }
        }
    }
}

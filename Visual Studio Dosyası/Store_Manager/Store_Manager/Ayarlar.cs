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
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }
        string baglantiString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
        static string komutString = "";
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader okuyucu;
        public static string dil = "";
        public static string tema = "";
        public int ayarlayıcıSayaç = 0;
        public void HesapBilgileriGetir()
        {
            if (OturumAç.yetki == "Çalışan")
            {
                baglanti = new SqlConnection(baglantiString);
                if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }
                komutString = "SELECT * FROM Employee WHERE Employee_User_Name='" + OturumAç.kullanıcıAdı + "'";
                komut = new SqlCommand(komutString, baglanti);
                komut.ExecuteNonQuery();
                okuyucu = komut.ExecuteReader();
                if (okuyucu.Read())
                {
                    txtBoxKulAdı.Text = okuyucu["Employee_User_Name"].ToString();
                    txtBoxŞifre.Text = okuyucu["Employee_Password"].ToString();
                    txtBoxAdı.Text = okuyucu["Employee_Name"].ToString();
                    txtBoxSoyadı.Text = okuyucu["Employee_Surname"].ToString();
                    txtBoxAdres.Text = okuyucu["Employee_Address"].ToString();
                    txtBoxTelNo.Text = okuyucu["Employee_Phone_No"].ToString();
                    txtBoxMail.Text = okuyucu["Employee_E_Mail"].ToString();
                }
                baglanti.Dispose();
                baglanti.Close();
            }
            else if (OturumAç.yetki == "Yönetici")
            {
                baglanti = new SqlConnection(baglantiString);
                if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }
                komutString = "SELECT * FROM Manager WHERE Manager_User_Name='" + OturumAç.kullanıcıAdı + "'";
                komut = new SqlCommand(komutString, baglanti);
                komut.ExecuteNonQuery();
                okuyucu = komut.ExecuteReader();
                if (okuyucu.Read())
                {
                    txtBoxKulAdı.Text = okuyucu["Manager_User_Name"].ToString();
                    txtBoxŞifre.Text = okuyucu["Manager_Password"].ToString();
                    txtBoxAdı.Text = okuyucu["Manager_Name"].ToString();
                    txtBoxSoyadı.Text = okuyucu["Manager_Surname"].ToString();
                    txtBoxAdres.Text = okuyucu["Manager_Address"].ToString();
                    txtBoxTelNo.Text = okuyucu["Manager_Phone_No"].ToString();
                    txtBoxMail.Text = okuyucu["Manager_E_Mail"].ToString();
                }
                baglanti.Dispose();
                baglanti.Close();
            }
        }
        public void Güncelle()
        {
            if (OturumAç.yetki == "Çalışan")
            {
                baglanti = new SqlConnection(baglantiString);
                if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }
                komutString = "UPDATE Employee SET Employee_Name=@Employee_Name,Employee_Surname=@Employee_Surname," +
                "Employee_User_Name=@Employee_User_Name,Employee_Password=@Employee_Password,Employee_Address=@Employee_Address," +
                "Employee_E_Mail=@Employee_E_Mail,Employee_Phone_No=@Employee_Phone_No WHERE Employee_User_Name='" + OturumAç.kullanıcıAdı + "'";
                komut = new SqlCommand(komutString, baglanti);
                komut.Parameters.AddWithValue("@Employee_Name", txtBoxAdı.Text);
                komut.Parameters.AddWithValue("@Employee_Surname", txtBoxSoyadı.Text);
                komut.Parameters.AddWithValue("@Employee_User_Name", txtBoxKulAdı.Text);
                komut.Parameters.AddWithValue("@Employee_Password", txtBoxŞifre.Text);
                komut.Parameters.AddWithValue("@Employee_Address", txtBoxAdres.Text);
                komut.Parameters.AddWithValue("@Employee_Phone_No", txtBoxTelNo.Text);
                komut.Parameters.AddWithValue("@Employee_E_Mail", txtBoxMail.Text);
                OturumAç.kullanıcıAdı = txtBoxKulAdı.Text;
                ÇalışanAnaMenü.kullanıcı= txtBoxKulAdı.Text;
                Properties.Settings.Default["kullanıcıAdı"] = txtBoxKulAdı.Text;
                Properties.Settings.Default["şifre"] = txtBoxŞifre.Text;
                Properties.Settings.Default["yetki"] = "Çalışan";
                Properties.Settings.Default.Save();
                komut.ExecuteNonQuery();
                baglanti.Dispose();
                baglanti.Close();
            }
            else if (OturumAç.yetki == "Yönetici")
            {
                baglanti = new SqlConnection(baglantiString);
                if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }
                komutString = "UPDATE Manager SET Manager_Name=@Manager_Name,Manager_Surname=@Manager_Surname," +
                "Manager_User_Name=@Manager_User_Name,Manager_Password=@Manager_Password,Manager_Address=@Manager_Address," +
                "Manager_E_Mail=@Manager_E_Mail,Manager_Phone_No=@Manager_Phone_No WHERE Manager_User_Name='" + OturumAç.kullanıcıAdı + "'";
                komut = new SqlCommand(komutString, baglanti);
                komut.Parameters.AddWithValue("@Manager_Name", txtBoxAdı.Text);
                komut.Parameters.AddWithValue("@Manager_Surname", txtBoxSoyadı.Text);
                komut.Parameters.AddWithValue("@Manager_User_Name", txtBoxKulAdı.Text);
                komut.Parameters.AddWithValue("@Manager_Password", txtBoxŞifre.Text);
                komut.Parameters.AddWithValue("@Manager_Address", txtBoxAdres.Text);
                komut.Parameters.AddWithValue("@Manager_Phone_No", txtBoxTelNo.Text);
                komut.Parameters.AddWithValue("@Manager_E_Mail", txtBoxMail.Text);
                OturumAç.kullanıcıAdı = txtBoxKulAdı.Text;
                lblKullanıcı.Text = txtBoxKulAdı.Text;
                Properties.Settings.Default["kullanıcıAdı"] = txtBoxKulAdı.Text;
                Properties.Settings.Default["şifre"] = txtBoxŞifre.Text;
                Properties.Settings.Default["yetki"] = "Yönetici";
                Properties.Settings.Default.Save();
                komut.ExecuteNonQuery();
                baglanti.Dispose();
                baglanti.Close();
            }
            if (dil == "Türkçe")
            {
                MessageBoxManager.Unregister();
                MessageBoxManager.OK = "Tamam";
                MessageBoxManager.Yes = "Evet";
                MessageBoxManager.No = "Hayır";
                MessageBoxManager.Register();
                MessageBox.Show("Bilgileriniz Güncellenmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dil == "English")
            {
                MessageBoxManager.Unregister();
                MessageBoxManager.OK = "OK";
                MessageBoxManager.Yes = "Yes";
                MessageBoxManager.No = "No";
                MessageBoxManager.Register();
                MessageBox.Show("Your Informations Are Updated.", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void picBoxÇıkış_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Ayarlar_Load(object sender, EventArgs e)
        {
            lblKullanıcı.Text = "[" + OturumAç.kullanıcıAdı + "]";
            if (ÇalışanAnaMenü.menuAyar == true)
            {
                btnHesap.Visible = true;
                HesapBilgileriGetir();
                if (Ayarlar.dil == "Türkçe")
                {
                    cmbBoxDil.SelectedIndex = 1;
                    lblDil.Text = "Dil :";
                    lblAyarlar.Text = "Ayarlar";
                    lblTema.Text = "Tema :";
                    btnGenelAyarlar.Text = "Genel Ayarlar";
                    btnHesap.Text = "Hesap";
                    lblAdres.Text = "Adres:";
                    lblAdı.Text = "Adı:";
                    lblKulAdı.Text = "Kullanıcı Adı:";
                    lblMail.Text = "E-Mail:";
                    lblSoyadı.Text = "Soyadı.";
                    lblTelNo.Text = "Telefon No:";
                    lblŞifre.Text = "Şifre:";
                    btnGüncelle.Text = "Güncelle";
                    MessageBoxManager.Unregister();
                    MessageBoxManager.OK = "Tamam";
                    MessageBoxManager.Yes = "Evet";
                    MessageBoxManager.No = "Hayır";
                    MessageBoxManager.Register();
                    if (tema == "Varsayılan")
                    {
                        panelSol.BackColor = Color.FromArgb(26, 32, 40);
                        btnGenelAyarlar.BackColor = Color.FromArgb(26, 32, 40);
                        btnHesap.BackColor = Color.FromArgb(26, 32, 40);
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.FromArgb(37, 46, 59);
                        cmbBoxTema.SelectedIndex = 0;
                    }
                    else if (tema == "Kırmızı")
                    {
                        panelSol.BackColor = Color.DarkRed;
                        btnGenelAyarlar.BackColor = Color.DarkRed;
                        btnHesap.BackColor = Color.DarkRed;
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.Red;
                        cmbBoxTema.SelectedIndex = 1;
                    }
                    else if (tema == "Mavi")
                    {
                        panelSol.BackColor = Color.DarkBlue;
                        btnGenelAyarlar.BackColor = Color.DarkBlue;
                        btnHesap.BackColor = Color.DarkBlue;
                        panelÜst.BackColor = Color.FromName("ActiveCaption");
                        BackColor = Color.Blue;
                        cmbBoxTema.SelectedIndex = 2;
                    }
                    else if (tema == "Yeşil")
                    {
                        panelSol.BackColor = Color.DarkGreen;
                        btnGenelAyarlar.BackColor = Color.DarkGreen;
                        btnHesap.BackColor = Color.DarkBlue;
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.Green;
                        cmbBoxTema.SelectedIndex = 3;
                    }
                }
                else if (Ayarlar.dil == "English")
                {
                    cmbBoxDil.SelectedIndex = 0;
                    lblDil.Text = "Language :";
                    lblAyarlar.Text = "Settings";
                    lblTema.Text = "Thema :";
                    btnGenelAyarlar.Text = "General Settings";
                    btnHesap.Text = "Account";
                    lblAdres.Text = "Address:";
                    lblAdı.Text = "Name:";
                    lblKulAdı.Text = "User Name:";
                    lblMail.Text = "E-Mail:";
                    lblSoyadı.Text = "Surname:";
                    lblTelNo.Text = "Phone No:";
                    lblŞifre.Text = "Password:";
                    btnGüncelle.Text = "Update";
                    MessageBoxManager.Unregister();
                    MessageBoxManager.OK = "OK";
                    MessageBoxManager.Yes = "Yes";
                    MessageBoxManager.No = "No";
                    MessageBoxManager.Register();
                    if (tema == "Varsayılan")
                    {
                        panelSol.BackColor = Color.FromArgb(26, 32, 40);
                        btnGenelAyarlar.BackColor = Color.FromArgb(26, 32, 40);
                        btnHesap.BackColor = Color.FromArgb(26, 32, 40);
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.FromArgb(37, 46, 59);
                        cmbBoxTema.SelectedIndex = 0;
                    }
                    else if (tema == "Kırmızı")
                    {
                        panelSol.BackColor = Color.DarkRed;
                        btnGenelAyarlar.BackColor = Color.DarkRed;
                        btnHesap.BackColor = Color.DarkRed;
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.Red;
                        cmbBoxTema.SelectedIndex = 1;
                    }
                    else if (tema == "Mavi")
                    {
                        panelSol.BackColor = Color.DarkBlue;
                        btnGenelAyarlar.BackColor = Color.DarkBlue;
                        btnHesap.BackColor = Color.DarkBlue;
                        panelÜst.BackColor = Color.FromName("ActiveCaption");
                        BackColor = Color.Blue;
                        cmbBoxTema.SelectedIndex = 2;
                    }
                    else if (tema == "Yeşil")
                    {
                        panelSol.BackColor = Color.DarkGreen;
                        btnGenelAyarlar.BackColor = Color.DarkGreen;
                        btnHesap.BackColor = Color.DarkGreen;
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.Green;
                        cmbBoxTema.SelectedIndex = 3;
                    }
                }
            }
            else if (YöneticiAnaMenü.menuAyar == true)
            {
                btnHesap.Visible = true;
                HesapBilgileriGetir();
                if (Ayarlar.dil == "Türkçe")
                {
                    cmbBoxDil.SelectedIndex = 1;
                    lblDil.Text = "Dil :";
                    lblAyarlar.Text = "Ayarlar";
                    lblTema.Text = "Tema :";
                    btnGenelAyarlar.Text = "Genel Ayarlar";
                    btnHesap.Text = "Hesap";
                    lblAdres.Text = "Adres:";
                    lblAdı.Text = "Adı:";
                    lblKulAdı.Text = "Kullanıcı Adı:";
                    lblMail.Text = "E-Mail:";
                    lblSoyadı.Text = "Soyadı:";
                    lblTelNo.Text = "Telefon No:";
                    lblŞifre.Text = "Şifre:";
                    btnGüncelle.Text = "Güncelle";
                    MessageBoxManager.Unregister();
                    MessageBoxManager.OK = "Tamam";
                    MessageBoxManager.Yes = "Evet";
                    MessageBoxManager.No = "Hayır";
                    MessageBoxManager.Register();
                    if (tema == "Varsayılan")
                    {
                        panelSol.BackColor = Color.FromArgb(26, 32, 40);
                        btnGenelAyarlar.BackColor = Color.FromArgb(26, 32, 40);
                        btnHesap.BackColor = Color.FromArgb(26, 32, 40);
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.FromArgb(37, 46, 59);
                        cmbBoxTema.SelectedIndex = 0;
                    }
                    else if (tema == "Kırmızı")
                    {
                        panelSol.BackColor = Color.DarkRed;
                        btnGenelAyarlar.BackColor = Color.DarkRed;
                        btnHesap.BackColor = Color.DarkRed;
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.Red;
                        cmbBoxTema.SelectedIndex = 1;
                    }
                    else if (tema == "Mavi")
                    {
                        panelSol.BackColor = Color.DarkBlue;
                        btnGenelAyarlar.BackColor = Color.DarkBlue;
                        btnHesap.BackColor = Color.DarkBlue;
                        panelÜst.BackColor = Color.FromName("ActiveCaption");
                        BackColor = Color.Blue;
                        cmbBoxTema.SelectedIndex = 2;
                    }
                    else if (tema == "Yeşil")
                    {
                        panelSol.BackColor = Color.DarkGreen;
                        btnGenelAyarlar.BackColor = Color.DarkGreen;
                        btnHesap.BackColor = Color.DarkBlue;
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.Green;
                        cmbBoxTema.SelectedIndex = 3;
                    }
                }
                else if (Ayarlar.dil == "English")
                {
                    cmbBoxDil.SelectedIndex = 0;
                    lblDil.Text = "Language :";
                    lblAyarlar.Text = "Settings";
                    lblTema.Text = "Thema :";
                    btnGenelAyarlar.Text = "General Settings";
                    btnHesap.Text = "Account";
                    lblAdres.Text = "Address:";
                    lblAdı.Text = "Name:";
                    lblKulAdı.Text = "User Name:";
                    lblMail.Text = "E-Mail:";
                    lblSoyadı.Text = "Surname:";
                    lblTelNo.Text = "Phone No:";
                    lblŞifre.Text = "Password:";
                    btnGüncelle.Text = "Update";
                    MessageBoxManager.Unregister();
                    MessageBoxManager.OK = "OK";
                    MessageBoxManager.Yes = "Yes";
                    MessageBoxManager.No = "No";
                    MessageBoxManager.Register();
                    if (tema == "Varsayılan")
                    {
                        panelSol.BackColor = Color.FromArgb(26, 32, 40);
                        btnGenelAyarlar.BackColor = Color.FromArgb(26, 32, 40);
                        btnHesap.BackColor = Color.FromArgb(26, 32, 40);
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.FromArgb(37, 46, 59);
                        cmbBoxTema.SelectedIndex = 0;
                    }
                    else if (tema == "Kırmızı")
                    {
                        panelSol.BackColor = Color.DarkRed;
                        btnGenelAyarlar.BackColor = Color.DarkRed;
                        btnHesap.BackColor = Color.DarkRed;
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.Red;
                        cmbBoxTema.SelectedIndex = 1;
                    }
                    else if (tema == "Mavi")
                    {
                        panelSol.BackColor = Color.DarkBlue;
                        btnGenelAyarlar.BackColor = Color.DarkBlue;
                        btnHesap.BackColor = Color.DarkBlue;
                        panelÜst.BackColor = Color.FromName("ActiveCaption");
                        BackColor = Color.Blue;
                        cmbBoxTema.SelectedIndex = 2;
                    }
                    else if (tema == "Yeşil")
                    {
                        panelSol.BackColor = Color.DarkGreen;
                        btnGenelAyarlar.BackColor = Color.DarkGreen;
                        btnHesap.BackColor = Color.DarkGreen;
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.Green;
                        cmbBoxTema.SelectedIndex = 3;
                    }
                }
            }
            else if (OturumAç.oturumAyar == true)
            {
                btnHesap.Visible = false;
            }
        }
        private void cmbBoxDil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxDil.SelectedIndex == 0)
            {
                dil = "English"; lblAyarlar.Text = "Settings"; lblDil.Text = "Language :"; lblTema.Text = "Thema :";
                btnGenelAyarlar.Text = "General Settings"; btnHesap.Text = "Account"; lblAdres.Text = "Address:";
                lblAdı.Text = "Name:"; lblKulAdı.Text = "User Name:"; lblMail.Text = "E-Mail:"; lblSoyadı.Text = "Surname:";
                lblTelNo.Text = "Phone No:"; lblŞifre.Text = "Password:"; btnGüncelle.Text = "Update";
                Properties.Settings.Default["dil"] = dil;
                Properties.Settings.Default.Save();
            }
            else if (cmbBoxDil.SelectedIndex == 1)
            {
                dil = "Türkçe"; lblAyarlar.Text = "Ayarlar"; lblDil.Text = "Dil :"; lblTema.Text = "Tema :";
                btnGenelAyarlar.Text = "Genel Ayarlar"; btnHesap.Text = "Hesap"; lblAdres.Text = "Adres:";
                lblAdı.Text = "Adı:"; lblKulAdı.Text = "Kullanıcı Adı:"; lblMail.Text = "E-Mail:"; lblSoyadı.Text = "Soyadı:";
                lblTelNo.Text = "Telefon No:"; lblŞifre.Text = "Şifre:"; btnGüncelle.Text = "Güncelle";
                Properties.Settings.Default["dil"] = dil;
                Properties.Settings.Default.Save();
            }
        }
        private void cmbBoxTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxTema.SelectedIndex == 0)
            {
                tema = "Varsayılan";
                panelSol.BackColor = Color.FromArgb(26, 32, 40);
                btnGenelAyarlar.BackColor = Color.FromArgb(26, 32, 40);
                btnHesap.BackColor = Color.FromArgb(26, 32, 40);
                panelÜst.BackColor = Color.LightGray;
                BackColor = Color.FromArgb(37, 46, 59);
                Properties.Settings.Default["tema"] = tema;
                Properties.Settings.Default.Save();
            }
            else if (cmbBoxTema.SelectedIndex == 1)
            {
                tema = "Kırmızı";
                panelSol.BackColor = Color.DarkRed;
                btnGenelAyarlar.BackColor = Color.DarkRed;
                btnHesap.BackColor = Color.DarkRed;
                panelÜst.BackColor = Color.LightGray;
                BackColor = Color.Red;
                Properties.Settings.Default["tema"] = tema;
                Properties.Settings.Default.Save();
            }
            else if (cmbBoxTema.SelectedIndex == 2)
            {
                tema = "Mavi";
                panelSol.BackColor = Color.DarkBlue;
                btnGenelAyarlar.BackColor = Color.DarkBlue;
                btnHesap.BackColor = Color.DarkBlue;
                panelÜst.BackColor = Color.FromName("ActiveCaption");
                BackColor = Color.Blue;
                Properties.Settings.Default["tema"] = tema;
                Properties.Settings.Default.Save();
            }
            else if (cmbBoxTema.SelectedIndex == 3)
            {
                tema = "Yeşil";
                panelSol.BackColor = Color.DarkGreen;
                btnGenelAyarlar.BackColor = Color.DarkGreen;
                btnHesap.BackColor = Color.DarkGreen;
                panelÜst.BackColor = Color.LightGray;
                BackColor = Color.Green;
                Properties.Settings.Default["tema"] = tema;
                Properties.Settings.Default.Save();
            }
        }
        private void btnGenelAyarlar_Click(object sender, EventArgs e)
        {
            lblDil.Visible = true;
            lblTema.Visible = true;
            cmbBoxDil.Visible = true;
            cmbBoxTema.Visible = true;
            lblKulAdı.Visible = false;
            lblŞifre.Visible = false;
            lblAdı.Visible = false;
            lblSoyadı.Visible = false;
            lblAdres.Visible = false;
            lblTelNo.Visible = false;
            lblMail.Visible = false;
            txtBoxKulAdı.Visible = false;
            txtBoxŞifre.Visible = false;
            txtBoxAdı.Visible = false;
            txtBoxSoyadı.Visible = false;
            txtBoxAdres.Visible = false;
            txtBoxTelNo.Visible = false;
            txtBoxMail.Visible = false;
            btnGüncelle.Visible = false;
            if (dil == "Türkçe")
            {
                cmbBoxDil.SelectedIndex = 1;
                if (tema == "Varsayılan")
                {
                    cmbBoxTema.SelectedIndex = 0;
                }
                else if (tema == "Kırmızı")
                {
                    cmbBoxTema.SelectedIndex = 1;
                }
                else if (tema == "Mavi")
                {
                    cmbBoxTema.SelectedIndex = 2;
                }
                else if (tema == "Yeşil")
                {
                    cmbBoxTema.SelectedIndex = 3;
                }
            }
            else if (dil == "English")
            {
                cmbBoxDil.SelectedIndex = 0;
                if (tema == "Varsayılan")
                {
                    cmbBoxTema.SelectedIndex = 0;
                }
                else if (tema == "Kırmızı")
                {
                    cmbBoxTema.SelectedIndex = 1;
                }
                else if (tema == "Mavi")
                {
                    cmbBoxTema.SelectedIndex = 2;
                }
                else if (tema == "Yeşil")
                {
                    cmbBoxTema.SelectedIndex = 3;
                }
            }
        }
        private void btnHesap_Click(object sender, EventArgs e)
        {
            lblDil.Visible = false;
            lblTema.Visible = false;
            cmbBoxDil.Visible = false;
            cmbBoxTema.Visible = false;
            lblKullanıcı.Visible = true;
            lblKulAdı.Visible = true;
            lblŞifre.Visible = true;
            lblAdı.Visible = true;
            lblSoyadı.Visible = true;
            lblAdres.Visible = true;
            lblTelNo.Visible = true;
            lblMail.Visible = true;
            txtBoxKulAdı.Visible = true;
            txtBoxŞifre.Visible = true;
            txtBoxAdı.Visible = true;
            txtBoxSoyadı.Visible = true;
            txtBoxAdres.Visible = true;
            txtBoxTelNo.Visible = true;
            txtBoxMail.Visible = true;
            btnGüncelle.Visible = true;
        }
        private void picBoxAyarlayıcı_Click(object sender, EventArgs e)
        {
            zamanlayıcı.Enabled = true;
        }
        private void zamanlayıcı_Tick(object sender, EventArgs e)
        {
            ayarlayıcıSayaç++;
            if (ayarlayıcıSayaç % 2 == 1)
            {
                if (panelSol.Width != 149)
                {
                    zamanlayıcı.Enabled = false;
                }
                else
                {
                    cmbBoxDil.Enabled = false;
                    cmbBoxTema.Enabled = false;
                    panelSol.Width = 50;
                    btnGenelAyarlar.Left = 70;
                    btnHesap.Left = 300;
                    lblDil.Left = 275;
                    lblTema.Left = 275;
                    lblKulAdı.Left = 250;
                    txtBoxKulAdı.Left = 318;
                    lblŞifre.Left = 250;
                    txtBoxŞifre.Left = 318;
                    lblAdı.Left = 250;
                    txtBoxAdı.Left = 318;
                    lblSoyadı.Left = 250;
                    txtBoxSoyadı.Left = 318;
                    lblAdres.Left = 250;
                    txtBoxAdres.Left = 318;
                    lblTelNo.Left = 250;
                    txtBoxTelNo.Left = 318;
                    lblMail.Left = 250;
                    txtBoxMail.Left = 318;
                    btnGüncelle.Left = 250;
                    cmbBoxDil.Left = 360;
                    cmbBoxTema.Left = 360;
                }
                lblAyarlar.Text = "";
            }
            else if (ayarlayıcıSayaç % 2 == 0)
            {
                if (panelSol.Width != 50)
                {
                    zamanlayıcı.Enabled = false;
                }
                else
                {
                    panelSol.Width = 149;
                    cmbBoxDil.Enabled = true;
                    cmbBoxTema.Enabled = true;
                    if (dil == "Türkçe")
                    {
                        lblAyarlar.Text = "Ayarlar";
                        btnGenelAyarlar.Left = 170;
                        btnHesap.Left = 350;
                        lblDil.Left = 320;
                        lblTema.Left = 320;
                        lblKulAdı.Left = 320;
                        txtBoxKulAdı.Left = 388;
                        lblŞifre.Left = 320;
                        txtBoxŞifre.Left = 388;
                        lblAdı.Left = 320;
                        txtBoxAdı.Left = 388;
                        lblSoyadı.Left = 320;
                        txtBoxSoyadı.Left = 388;
                        lblAdres.Left = 320;
                        txtBoxAdres.Left = 388;
                        lblTelNo.Left = 320;
                        txtBoxTelNo.Left = 388;
                        lblMail.Left = 320;
                        txtBoxMail.Left = 388;
                        btnGüncelle.Left = 320;
                        cmbBoxDil.Left = 405;
                        cmbBoxTema.Left = 405;
                    }
                    else if (dil == "English")
                    {
                        lblAyarlar.Text = "Settings";
                        btnGenelAyarlar.Left = 170;
                        btnHesap.Left = 350;
                        lblDil.Left = 320;
                        lblTema.Left = 320;
                        lblKulAdı.Left = 320;
                        txtBoxKulAdı.Left = 388;
                        lblŞifre.Left = 320;
                        txtBoxŞifre.Left = 388;
                        lblAdı.Left = 320;
                        txtBoxAdı.Left = 388;
                        lblSoyadı.Left = 320;
                        txtBoxSoyadı.Left = 388;
                        lblAdres.Left = 320;
                        txtBoxAdres.Left = 388;
                        lblTelNo.Left = 320;
                        txtBoxTelNo.Left = 388;
                        lblMail.Left = 320;
                        txtBoxMail.Left = 388;
                        btnGüncelle.Left = 320;
                        cmbBoxDil.Left = 405;
                        cmbBoxTema.Left = 405;
                    }
                }
            }
            zamanlayıcı.Enabled = false;
        }
        private void Ayarlar_Activated(object sender, EventArgs e)
        {
            lblKullanıcı.Text = "[" + OturumAç.kullanıcıAdı + "]";
            if (ÇalışanAnaMenü.menuAyar == true)
            {
                btnHesap.Visible = true;
                HesapBilgileriGetir();
                if (Ayarlar.dil == "Türkçe")
                {
                    cmbBoxDil.SelectedIndex = 1;
                    lblDil.Text = "Dil :";
                    lblAyarlar.Text = "Ayarlar";
                    lblTema.Text = "Tema :";
                    btnGenelAyarlar.Text = "Genel Ayarlar";
                    btnHesap.Text = "Hesap";
                    lblAdres.Text = "Adres:";
                    lblAdı.Text = "Adı:";
                    lblKulAdı.Text = "Kullanıcı Adı:";
                    lblMail.Text = "E-Mail.";
                    lblSoyadı.Text = "Soyadı:";
                    lblTelNo.Text = "Telefon No:";
                    lblŞifre.Text = "Şifre:";
                    btnGüncelle.Text = "Güncelle";
                    MessageBoxManager.Unregister();
                    MessageBoxManager.OK = "Tamam";
                    MessageBoxManager.Yes = "Evet";
                    MessageBoxManager.No = "Hayır";
                    MessageBoxManager.Register();
                    if (tema == "Varsayılan")
                    {
                        panelSol.BackColor = Color.FromArgb(26, 32, 40);
                        btnGenelAyarlar.BackColor = Color.FromArgb(26, 32, 40);
                        btnHesap.BackColor = Color.FromArgb(26, 32, 40);
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.FromArgb(37, 46, 59);
                        cmbBoxTema.SelectedIndex = 0;
                    }
                    else if (tema == "Kırmızı")
                    {
                        panelSol.BackColor = Color.DarkRed;
                        btnGenelAyarlar.BackColor = Color.DarkRed;
                        btnHesap.BackColor = Color.DarkRed;
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.Red;
                        cmbBoxTema.SelectedIndex = 1;
                    }
                    else if (tema == "Mavi")
                    {
                        panelSol.BackColor = Color.DarkBlue;
                        btnGenelAyarlar.BackColor = Color.DarkBlue;
                        btnHesap.BackColor = Color.DarkBlue;
                        panelÜst.BackColor = Color.FromName("ActiveCaption");
                        BackColor = Color.Blue;
                        cmbBoxTema.SelectedIndex = 2;
                    }
                    else if (tema == "Yeşil")
                    {
                        panelSol.BackColor = Color.DarkGreen;
                        btnGenelAyarlar.BackColor = Color.DarkGreen;
                        btnHesap.BackColor = Color.DarkBlue;
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.Green;
                        cmbBoxTema.SelectedIndex = 3;
                    }
                }
                else if (Ayarlar.dil == "English")
                {
                    cmbBoxDil.SelectedIndex = 0;
                    lblDil.Text = "Language :";
                    lblAyarlar.Text = "Settings";
                    lblTema.Text = "Thema :";
                    btnGenelAyarlar.Text = "General Settings";
                    btnHesap.Text = "Account";
                    lblAdres.Text = "Address:";
                    lblAdı.Text = "Name:";
                    lblKulAdı.Text = "User Name:";
                    lblMail.Text = "E-Mail:";
                    lblSoyadı.Text = "Surname:";
                    lblTelNo.Text = "Phone No:";
                    lblŞifre.Text = "Password:";
                    btnGüncelle.Text = "Update";
                    MessageBoxManager.Unregister();
                    MessageBoxManager.OK = "OK";
                    MessageBoxManager.Yes = "Yes";
                    MessageBoxManager.No = "No";
                    MessageBoxManager.Register();
                    if (tema == "Varsayılan")
                    {
                        panelSol.BackColor = Color.FromArgb(26, 32, 40);
                        btnGenelAyarlar.BackColor = Color.FromArgb(26, 32, 40);
                        btnHesap.BackColor = Color.FromArgb(26, 32, 40);
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.FromArgb(37, 46, 59);
                        cmbBoxTema.SelectedIndex = 0;
                    }
                    else if (tema == "Kırmızı")
                    {
                        panelSol.BackColor = Color.DarkRed;
                        btnGenelAyarlar.BackColor = Color.DarkRed;
                        btnHesap.BackColor = Color.DarkRed;
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.Red;
                        cmbBoxTema.SelectedIndex = 1;
                    }
                    else if (tema == "Mavi")
                    {
                        panelSol.BackColor = Color.DarkBlue;
                        btnGenelAyarlar.BackColor = Color.DarkBlue;
                        btnHesap.BackColor = Color.DarkBlue;
                        panelÜst.BackColor = Color.FromName("ActiveCaption");
                        BackColor = Color.Blue;
                        cmbBoxTema.SelectedIndex = 2;
                    }
                    else if (tema == "Yeşil")
                    {
                        panelSol.BackColor = Color.DarkGreen;
                        btnGenelAyarlar.BackColor = Color.DarkGreen;
                        btnHesap.BackColor = Color.DarkGreen;
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.Green;
                        cmbBoxTema.SelectedIndex = 3;
                    }
                }
            }
            else if (YöneticiAnaMenü.menuAyar == true)
            {
                btnHesap.Visible = true;
                HesapBilgileriGetir();
                if (Ayarlar.dil == "Türkçe")
                {
                    cmbBoxDil.SelectedIndex = 1;
                    lblDil.Text = "Dil :";
                    lblAyarlar.Text = "Ayarlar";
                    lblTema.Text = "Tema :";
                    btnGenelAyarlar.Text = "Genel Ayarlar";
                    btnHesap.Text = "Hesap";
                    lblAdres.Text = "Adres:";
                    lblAdı.Text = "Adı:";
                    lblKulAdı.Text = "Kullanıcı Adı:";
                    lblMail.Text = "E-Mail:";
                    lblSoyadı.Text = "Soyadı:";
                    lblTelNo.Text = "Telefon No:";
                    lblŞifre.Text = "Şifre:";
                    btnGüncelle.Text = "Güncelle";
                    MessageBoxManager.Unregister();
                    MessageBoxManager.OK = "Tamam";
                    MessageBoxManager.Yes = "Evet";
                    MessageBoxManager.No = "Hayır";
                    MessageBoxManager.Register();
                    if (tema == "Varsayılan")
                    {
                        panelSol.BackColor = Color.FromArgb(26, 32, 40);
                        btnGenelAyarlar.BackColor = Color.FromArgb(26, 32, 40);
                        btnHesap.BackColor = Color.FromArgb(26, 32, 40);
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.FromArgb(37, 46, 59);
                        cmbBoxTema.SelectedIndex = 0;
                    }
                    else if (tema == "Kırmızı")
                    {
                        panelSol.BackColor = Color.DarkRed;
                        btnGenelAyarlar.BackColor = Color.DarkRed;
                        btnHesap.BackColor = Color.DarkRed;
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.Red;
                        cmbBoxTema.SelectedIndex = 1;
                    }
                    else if (tema == "Mavi")
                    {
                        panelSol.BackColor = Color.DarkBlue;
                        btnGenelAyarlar.BackColor = Color.DarkBlue;
                        btnHesap.BackColor = Color.DarkBlue;
                        panelÜst.BackColor = Color.FromName("ActiveCaption");
                        BackColor = Color.Blue;
                        cmbBoxTema.SelectedIndex = 2;
                    }
                    else if (tema == "Yeşil")
                    {
                        panelSol.BackColor = Color.DarkGreen;
                        btnGenelAyarlar.BackColor = Color.DarkGreen;
                        btnHesap.BackColor = Color.DarkBlue;
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.Green;
                        cmbBoxTema.SelectedIndex = 3;
                    }
                }
                else if (Ayarlar.dil == "English")
                {
                    cmbBoxDil.SelectedIndex = 0;
                    lblDil.Text = "Language :";
                    lblAyarlar.Text = "Settings";
                    lblTema.Text = "Thema :";
                    btnGenelAyarlar.Text = "General Settings";
                    btnHesap.Text = "Account";
                    lblAdres.Text = "Address:";
                    lblAdı.Text = "Name:";
                    lblKulAdı.Text = "User Name:";
                    lblMail.Text = "E-Mail:";
                    lblSoyadı.Text = "Surname:";
                    lblTelNo.Text = "Phone No:";
                    lblŞifre.Text = "Password.";
                    btnGüncelle.Text = "Update";
                    MessageBoxManager.Unregister();
                    MessageBoxManager.OK = "OK";
                    MessageBoxManager.Yes = "Yes";
                    MessageBoxManager.No = "No";
                    MessageBoxManager.Register();
                    if (tema == "Varsayılan")
                    {
                        panelSol.BackColor = Color.FromArgb(26, 32, 40);
                        btnGenelAyarlar.BackColor = Color.FromArgb(26, 32, 40);
                        btnHesap.BackColor = Color.FromArgb(26, 32, 40);
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.FromArgb(37, 46, 59);
                        cmbBoxTema.SelectedIndex = 0;
                    }
                    else if (tema == "Kırmızı")
                    {
                        panelSol.BackColor = Color.DarkRed;
                        btnGenelAyarlar.BackColor = Color.DarkRed;
                        btnHesap.BackColor = Color.DarkRed;
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.Red;
                        cmbBoxTema.SelectedIndex = 1;
                    }
                    else if (tema == "Mavi")
                    {
                        panelSol.BackColor = Color.DarkBlue;
                        btnGenelAyarlar.BackColor = Color.DarkBlue;
                        btnHesap.BackColor = Color.DarkBlue;
                        panelÜst.BackColor = Color.FromName("ActiveCaption");
                        BackColor = Color.Blue;
                        cmbBoxTema.SelectedIndex = 2;
                    }
                    else if (tema == "Yeşil")
                    {
                        panelSol.BackColor = Color.DarkGreen;
                        btnGenelAyarlar.BackColor = Color.DarkGreen;
                        btnHesap.BackColor = Color.DarkGreen;
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.Green;
                        cmbBoxTema.SelectedIndex = 3;
                    }
                }
            }
            else if (OturumAç.oturumAyar == true)
            {
                btnHesap.Visible = false;
                lblKullanıcı.Visible = false;
                if (Ayarlar.dil == "Türkçe")
                {
                    cmbBoxDil.SelectedIndex = 1;
                    lblDil.Text = "Dil :";
                    lblAyarlar.Text = "Ayarlar";
                    lblTema.Text = "Tema :";
                    btnGenelAyarlar.Text = "Genel Ayarlar";
                    btnHesap.Text = "Hesap";
                    lblAdres.Text = "Adres:";
                    lblAdı.Text = "Adı:";
                    lblKulAdı.Text = "Kullanıcı Adı:";
                    lblMail.Text = "E-Mail:";
                    lblSoyadı.Text = "Soyadı:";
                    lblTelNo.Text = "Telefon No:";
                    lblŞifre.Text = "Şifre:";
                    btnGüncelle.Text = "Güncelle";
                    MessageBoxManager.Unregister();
                    MessageBoxManager.OK = "Tamam";
                    MessageBoxManager.Yes = "Evet";
                    MessageBoxManager.No = "Hayır";
                    MessageBoxManager.Register();
                    if (tema == "Varsayılan")
                    {
                        panelSol.BackColor = Color.FromArgb(26, 32, 40);
                        btnGenelAyarlar.BackColor = Color.FromArgb(26, 32, 40);
                        btnHesap.BackColor = Color.FromArgb(26, 32, 40);
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.FromArgb(37, 46, 59);
                        cmbBoxTema.SelectedIndex = 0;
                    }
                    else if (tema == "Kırmızı")
                    {
                        panelSol.BackColor = Color.DarkRed;
                        btnGenelAyarlar.BackColor = Color.DarkRed;
                        btnHesap.BackColor = Color.DarkRed;
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.Red;
                        cmbBoxTema.SelectedIndex = 1;
                    }
                    else if (tema == "Mavi")
                    {
                        panelSol.BackColor = Color.DarkBlue;
                        btnGenelAyarlar.BackColor = Color.DarkBlue;
                        btnHesap.BackColor = Color.DarkBlue;
                        panelÜst.BackColor = Color.FromName("ActiveCaption");
                        BackColor = Color.Blue;
                        cmbBoxTema.SelectedIndex = 2;
                    }
                    else if (tema == "Yeşil")
                    {
                        panelSol.BackColor = Color.DarkGreen;
                        btnGenelAyarlar.BackColor = Color.DarkGreen;
                        btnHesap.BackColor = Color.DarkBlue;
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.Green;
                        cmbBoxTema.SelectedIndex = 3;
                    }
                }
                else if (Ayarlar.dil == "English")
                {
                    cmbBoxDil.SelectedIndex = 0;
                    lblDil.Text = "Language :";
                    lblAyarlar.Text = "Settings";
                    lblTema.Text = "Thema :";
                    btnGenelAyarlar.Text = "General Settings";
                    btnHesap.Text = "Account";
                    lblAdres.Text = "Address:";
                    lblAdı.Text = "Name:";
                    lblKulAdı.Text = "User Name:";
                    lblMail.Text = "E-Mail:";
                    lblSoyadı.Text = "Surname:";
                    lblTelNo.Text = "Phone No:";
                    lblŞifre.Text = "Password.";
                    btnGüncelle.Text = "Update";
                    MessageBoxManager.Unregister();
                    MessageBoxManager.OK = "OK";
                    MessageBoxManager.Yes = "Yes";
                    MessageBoxManager.No = "No";
                    MessageBoxManager.Register();
                    if (tema == "Varsayılan")
                    {
                        panelSol.BackColor = Color.FromArgb(26, 32, 40);
                        btnGenelAyarlar.BackColor = Color.FromArgb(26, 32, 40);
                        btnHesap.BackColor = Color.FromArgb(26, 32, 40);
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.FromArgb(37, 46, 59);
                        cmbBoxTema.SelectedIndex = 0;
                    }
                    else if (tema == "Kırmızı")
                    {
                        panelSol.BackColor = Color.DarkRed;
                        btnGenelAyarlar.BackColor = Color.DarkRed;
                        btnHesap.BackColor = Color.DarkRed;
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.Red;
                        cmbBoxTema.SelectedIndex = 1;
                    }
                    else if (tema == "Mavi")
                    {
                        panelSol.BackColor = Color.DarkBlue;
                        btnGenelAyarlar.BackColor = Color.DarkBlue;
                        btnHesap.BackColor = Color.DarkBlue;
                        panelÜst.BackColor = Color.FromName("ActiveCaption");
                        BackColor = Color.Blue;
                        cmbBoxTema.SelectedIndex = 2;
                    }
                    else if (tema == "Yeşil")
                    {
                        panelSol.BackColor = Color.DarkGreen;
                        btnGenelAyarlar.BackColor = Color.DarkGreen;
                        btnHesap.BackColor = Color.DarkGreen;
                        panelÜst.BackColor = Color.LightGray;
                        BackColor = Color.Green;
                        cmbBoxTema.SelectedIndex = 3;
                    }
                }
            }
        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Güncelle();
        }
    }
}

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
    public partial class OturumAç : Form
    {
        string baglantiString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
        static string komutString = "";
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader okuyucu;
        static int şifreSayaç = 0;
        public static string kullanıcıAdı = "";
        public static string şifre = "";
        public static string yetki = "";
        public static bool oturumAyar = false;
        public OturumAç()
        {
            InitializeComponent();
        }
        public void Oturum_Aç()
        {
            if (Ayarlar.dil == "Türkçe")
            {
                if (radBtnÇalışan.Checked == false & radBtnYönetici.Checked == false)
                {
                    MessageBox.Show("Lütfen Yetki Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (radBtnÇalışan.Checked == true & radBtnYönetici.Checked == false)
                {
                    baglanti = new SqlConnection(baglantiString);
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    komutString = "SELECT * FROM Employee WHERE Employee_User_Name='" + txtBoxKulAdı.Text + "' and Employee_Password='" + txtBoxŞifre.Text + "'";
                    komut = new SqlCommand(komutString, baglanti);
                    komut.ExecuteNonQuery();
                    okuyucu = komut.ExecuteReader();
                    if (okuyucu.Read())
                    {
                        if (cBoxOturumAçık.Checked == true)
                        {
                            Properties.Settings.Default["kullanıcıAdı"] = txtBoxKulAdı.Text;
                            Properties.Settings.Default["şifre"] = txtBoxŞifre.Text;
                            Properties.Settings.Default["yetki"] = yetki;
                            Properties.Settings.Default.Save();
                        }
                        timerZaman.Start();
                    }
                    else if (!(okuyucu.Read()))
                    {
                        MessageBox.Show("Kullanıcı Adınız ve/veya Şifreniz ve/veya Yetkiniz Hatalı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        timerZaman.Stop();
                    }
                    baglanti.Dispose();
                    baglanti.Close();
                }
                else if (radBtnYönetici.Checked == true & radBtnÇalışan.Checked == false)
                {
                    baglanti = new SqlConnection(baglantiString);
                    if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                    komutString = "SELECT * FROM Manager WHERE Manager_User_Name='" + txtBoxKulAdı.Text + "' and Manager_Password='" + txtBoxŞifre.Text + "'";
                    komut = new SqlCommand(komutString, baglanti);
                    komut.ExecuteNonQuery();
                    okuyucu = komut.ExecuteReader();
                    if (okuyucu.Read())
                    {
                        if (cBoxOturumAçık.Checked == true)
                        {
                            Properties.Settings.Default["kullanıcıAdı"] = txtBoxKulAdı.Text;
                            Properties.Settings.Default["şifre"] = txtBoxŞifre.Text;
                            Properties.Settings.Default["yetki"] = yetki;
                            Properties.Settings.Default.Save();
                        }
                        timerZaman.Start();
                    }
                    else if (!(okuyucu.Read()))
                    {
                        MessageBox.Show("Kullanıcı Adınız ve/veya Şifreniz ve/veya Yetkiniz Hatalı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        timerZaman.Stop();
                    }
                    baglanti.Dispose();
                    baglanti.Close();
                }
            }
            else if (Ayarlar.dil == "English")
            {
                if (radBtnÇalışan.Checked == false & radBtnYönetici.Checked == false)
                {
                    MessageBox.Show("Please Choose Authority.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (radBtnÇalışan.Checked == true & radBtnYönetici.Checked == false)
                {
                    baglanti = new SqlConnection(baglantiString);
                    if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                    komutString = "SELECT * FROM Employee WHERE Employee_User_Name='" + txtBoxKulAdı.Text + "' and Employee_Password='" + txtBoxŞifre.Text + "'";
                    komut = new SqlCommand(komutString, baglanti);
                    komut.ExecuteNonQuery();
                    okuyucu = komut.ExecuteReader();
                    if (okuyucu.Read())
                    {
                        if (cBoxOturumAçık.Checked == true)
                        {
                            Properties.Settings.Default["kullanıcıAdı"] = txtBoxKulAdı.Text;
                            Properties.Settings.Default["şifre"] = txtBoxŞifre.Text;
                            Properties.Settings.Default["yetki"] = yetki;
                            Properties.Settings.Default.Save();
                        }
                        timerZaman.Start();
                    }
                    else if (!okuyucu.Read())
                    {
                        MessageBox.Show("Your User Name and/or Your Password and/or Your Authority Are Wrong.", "Warming", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        timerZaman.Stop();
                    }
                    baglanti.Dispose();
                    baglanti.Close();
                }
                else if (radBtnYönetici.Checked == true & radBtnÇalışan.Checked == false)
                {
                    baglanti = new SqlConnection(baglantiString);
                    if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                    komutString = "SELECT * FROM Manager WHERE Manager_User_Name='" + txtBoxKulAdı.Text + "' and Manager_Password='" + txtBoxŞifre.Text + "'";
                    komut = new SqlCommand(komutString, baglanti);
                    komut.ExecuteNonQuery();
                    okuyucu = komut.ExecuteReader();
                    if (okuyucu.Read())
                    {
                        if (cBoxOturumAçık.Checked == true)
                        {
                            Properties.Settings.Default["kullanıcıAdı"] = txtBoxKulAdı.Text;
                            Properties.Settings.Default["şifre"] = txtBoxŞifre.Text;
                            Properties.Settings.Default["yetki"] = yetki;
                            Properties.Settings.Default.Save();
                        }
                        timerZaman.Start();
                    }
                    else if (!okuyucu.Read())
                    {
                        MessageBox.Show("Your User Name and/or Your Password and/or Your Authority Are Wrong.", "Warming", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        timerZaman.Stop();
                    }
                    baglanti.Dispose();
                    baglanti.Close();
                }
            }
        }
        private void picBoxÇıkış_Click(object sender, EventArgs e)
        {
            if (Ayarlar.dil == "English")
            {
                DialogResult secenek = MessageBox.Show("Are You Sure Want To Exit From Program ?", "Warming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secenek == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                DialogResult secenek = MessageBox.Show("Programı Kapatmak İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secenek == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
        private void btnOturumAç_Click(object sender, EventArgs e)
        {
            Oturum_Aç();
        }
        private void timerZaman_Tick(object sender, EventArgs e)
        {
            progressBarYükleme.Visible = true;
            progressBarYükleme.Value += 5;
            if (progressBarYükleme.Value == 100)
            {
                timerZaman.Stop();
                if (radBtnÇalışan.Checked == true & radBtnYönetici.Checked == false)
                {
                    ÇalışanAnaMenü calisanmenu = new ÇalışanAnaMenü();
                    this.Hide();
                    calisanmenu.Show();
                }
                else if (radBtnYönetici.Checked == true & radBtnÇalışan.Checked == false)
                {
                    YöneticiAnaMenü yoneticimenu = new YöneticiAnaMenü();
                    this.Hide();
                    yoneticimenu.Show();
                }
                progressBarYükleme.Visible = false;
            }
        }
        private void picBoxGöster_Click(object sender, EventArgs e)
        {
            şifreSayaç++;
            if (txtBoxŞifre.Text == "Şifre" || txtBoxŞifre.Text == "Password")
            {
                if (şifreSayaç % 2 == 1)
                {
                    txtBoxŞifre.PasswordChar = '*';
                    txtBoxŞifre.MaxLength = 15;
                }
                else if (şifreSayaç % 2 == 0)
                {
                    txtBoxŞifre.PasswordChar = '\0';
                    txtBoxŞifre.MaxLength = 15;
                }
            }
            else if (txtBoxŞifre.Text != "Şifre" || txtBoxŞifre.Text != "Password")
            {
                if (şifreSayaç % 2 == 1)
                {
                    txtBoxŞifre.PasswordChar = '\0';
                    txtBoxŞifre.MaxLength = 15;
                }
                else if (şifreSayaç % 2 == 0)
                {
                    txtBoxŞifre.PasswordChar = '*';
                    txtBoxŞifre.MaxLength = 15;
                }
            }
        }
        private void picBoxAyarlar_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show();
            oturumAyar = true;
        }
        private void OturumAç_Activated(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            oturumAyar = true;
            if (cBoxOturumAçık.Checked == true)
            {
                txtBoxKulAdı.Text = kullanıcıAdı;
                txtBoxŞifre.Text = şifre;
                if (yetki == "Çalışan")
                {
                    radBtnÇalışan.Checked = true;
                }
                else if (yetki == "Yönetici")
                {
                    radBtnYönetici.Checked = true;
                }
                if (radBtnÇalışan.Checked == true & radBtnYönetici.Checked == false)
                {
                    baglanti = new SqlConnection(baglantiString);
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    komutString = "SELECT * FROM Employee WHERE Employee_User_Name='" + txtBoxKulAdı.Text + "' and Employee_Password='" + txtBoxŞifre.Text + "'";
                    komut = new SqlCommand(komutString, baglanti);
                    komut.ExecuteNonQuery();
                    okuyucu = komut.ExecuteReader();
                    if (okuyucu.Read())
                    {
                        timerZaman.Start();
                    }
                    else if (!(okuyucu.Read()))
                    {
                        timerZaman.Stop();
                    }
                    baglanti.Dispose();
                    baglanti.Close();
                }
                else if (radBtnYönetici.Checked == true & radBtnÇalışan.Checked == false)
                {
                    baglanti = new SqlConnection(baglantiString);
                    if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                    komutString = "SELECT * FROM Manager WHERE Manager_User_Name='" + txtBoxKulAdı.Text + "' and Manager_Password='" + txtBoxŞifre.Text + "'";
                    komut = new SqlCommand(komutString, baglanti);
                    komut.ExecuteNonQuery();
                    okuyucu = komut.ExecuteReader();
                    if (okuyucu.Read())
                    {
                        timerZaman.Start();
                    }
                    else if (!(okuyucu.Read()))
                    {
                        timerZaman.Stop();
                    }
                    baglanti.Dispose();
                    baglanti.Close();
                }
                if (Ayarlar.tema == "Varsayılan")
                {
                    panelAlt.BackColor = Color.FromArgb(40, 40, 40);
                    panelÜst.BackColor = Color.FromArgb(40, 40, 40);
                    picBoxAyarlar.BackColor = Color.FromArgb(40, 40, 40);
                    picBoxÇıkış.BackColor = Color.FromArgb(40, 40, 40);
                    lblStoreManager.BackColor = Color.FromArgb(40, 40, 40);
                    this.BackColor = Color.FromArgb(64, 64, 64);
                }
                else if (Ayarlar.tema == "Kırmızı")
                {
                    panelÜst.BackColor = Color.DarkRed;
                    panelAlt.BackColor = Color.DarkRed;
                    picBoxAyarlar.BackColor = Color.DarkRed;
                    picBoxÇıkış.BackColor = Color.DarkRed;
                    lblStoreManager.BackColor = Color.DarkRed;
                    this.BackColor = Color.Red;
                }
                else if (Ayarlar.tema == "Mavi")
                {
                    panelÜst.BackColor = Color.DarkBlue;
                    panelAlt.BackColor = Color.DarkBlue;
                    picBoxAyarlar.BackColor = Color.DarkBlue;
                    picBoxÇıkış.BackColor = Color.DarkBlue;
                    lblStoreManager.BackColor = Color.DarkBlue;
                    this.BackColor = Color.Blue;
                }
                else if (Ayarlar.tema == "Yeşil")
                {
                    panelÜst.BackColor = Color.DarkGreen;
                    panelAlt.BackColor = Color.DarkGreen;
                    picBoxAyarlar.BackColor = Color.DarkGreen;
                    picBoxÇıkış.BackColor = Color.DarkGreen;
                    lblStoreManager.BackColor = Color.DarkGreen;
                    this.BackColor = Color.Green;
                }
                if (Ayarlar.dil == "English")
                {
                    Açıklama.SetToolTip(txtBoxKulAdı, "User Name");
                    Açıklama.SetToolTip(txtBoxŞifre, "Password");
                    Açıklama.SetToolTip(picBoxAyarlar, "Settings");
                    Açıklama.SetToolTip(picBoxÇıkış, "Exit");
                    btnKayıtOl.Text = "Sign Up"; btnOturumAç.Text = "Log In";
                    radBtnYönetici.Text = "Manager"; radBtnÇalışan.Text = "Employee";
                    cBoxOturumAçık.Text = "Keep me log in"; linkLblŞifreUnuttum.Text = "Forget your password ?";
                    MessageBoxManager.Unregister();
                    MessageBoxManager.OK = "OK";
                    MessageBoxManager.Yes = "Yes";
                    MessageBoxManager.No = "No";
                    MessageBoxManager.Register();
                }
                else if (Ayarlar.dil == "Türkçe")
                {
                    Açıklama.SetToolTip(txtBoxKulAdı, "Kullanıcı Adı");
                    Açıklama.SetToolTip(txtBoxŞifre, "Şifre");
                    Açıklama.SetToolTip(picBoxAyarlar, "Ayarlar");
                    Açıklama.SetToolTip(picBoxÇıkış, "Çıkış");
                    btnKayıtOl.Text = "Kayıt Ol"; btnOturumAç.Text = "Oturum Aç";
                    radBtnYönetici.Text = "Yönetici"; radBtnÇalışan.Text = "Çalışan";
                    cBoxOturumAçık.Text = "Oturumumu Açık Tut"; linkLblŞifreUnuttum.Text = "Şifrenizi Mi Unuttunuz?";
                    MessageBoxManager.Unregister();
                    MessageBoxManager.OK = "Tamam";
                    MessageBoxManager.Yes = "Evet";
                    MessageBoxManager.No = "Hayır";
                    MessageBoxManager.Register();
                }
            }
            else
            {
                if (Ayarlar.dil == "English")
                {
                    Açıklama.SetToolTip(txtBoxKulAdı, "User Name");
                    Açıklama.SetToolTip(txtBoxŞifre, "Password");
                    Açıklama.SetToolTip(picBoxAyarlar, "Settings");
                    Açıklama.SetToolTip(picBoxÇıkış, "Exit");
                    txtBoxKulAdı.Text = "User Name"; txtBoxŞifre.Text = "Password";
                    btnKayıtOl.Text = "Sign Up"; btnOturumAç.Text = "Log In";
                    radBtnYönetici.Text = "Manager"; radBtnÇalışan.Text = "Employee";
                    cBoxOturumAçık.Text = "Keep me log in"; linkLblŞifreUnuttum.Text = "Forget your password ?";
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
                        lblStoreManager.BackColor = Color.FromArgb(40, 40, 40);
                        this.BackColor = Color.FromArgb(64, 64, 64);
                    }
                    else if (Ayarlar.tema == "Kırmızı")
                    {
                        panelÜst.BackColor = Color.DarkRed;
                        panelAlt.BackColor = Color.DarkRed;
                        picBoxAyarlar.BackColor = Color.DarkRed;
                        picBoxÇıkış.BackColor = Color.DarkRed;
                        lblStoreManager.BackColor = Color.DarkRed;
                        this.BackColor = Color.Red;
                    }
                    else if (Ayarlar.tema == "Mavi")
                    {
                        panelÜst.BackColor = Color.DarkBlue;
                        panelAlt.BackColor = Color.DarkBlue;
                        picBoxAyarlar.BackColor = Color.DarkBlue;
                        picBoxÇıkış.BackColor = Color.DarkBlue;
                        lblStoreManager.BackColor = Color.DarkBlue;
                        this.BackColor = Color.Blue;
                    }
                    else if (Ayarlar.tema == "Yeşil")
                    {
                        panelÜst.BackColor = Color.DarkGreen;
                        panelAlt.BackColor = Color.DarkGreen;
                        picBoxAyarlar.BackColor = Color.DarkGreen;
                        picBoxÇıkış.BackColor = Color.DarkGreen;
                        lblStoreManager.BackColor = Color.DarkGreen;
                        this.BackColor = Color.Green;
                    }
                }
                else if (Ayarlar.dil == "Türkçe")
                {
                    Açıklama.SetToolTip(txtBoxKulAdı, "Kullanıcı Adı");
                    Açıklama.SetToolTip(txtBoxŞifre, "Şifre");
                    Açıklama.SetToolTip(picBoxAyarlar, "Ayarlar");
                    Açıklama.SetToolTip(picBoxÇıkış, "Çıkış");
                    txtBoxKulAdı.Text = "Kullanıcı Adı"; txtBoxŞifre.Text = "Şifre";
                    btnKayıtOl.Text = "Kayıt Ol"; btnOturumAç.Text = "Oturum Aç";
                    radBtnYönetici.Text = "Yönetici"; radBtnÇalışan.Text = "Çalışan";
                    cBoxOturumAçık.Text = "Oturumumu Açık Tut"; linkLblŞifreUnuttum.Text = "Şifrenizi Mi Unuttunuz?";
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
                        lblStoreManager.BackColor = Color.FromArgb(40, 40, 40);
                        this.BackColor = Color.FromArgb(64, 64, 64);
                    }
                    else if (Ayarlar.tema == "Kırmızı")
                    {
                        panelÜst.BackColor = Color.DarkRed;
                        panelAlt.BackColor = Color.DarkRed;
                        picBoxAyarlar.BackColor = Color.DarkRed;
                        picBoxÇıkış.BackColor = Color.DarkRed;
                        lblStoreManager.BackColor = Color.DarkRed;
                        this.BackColor = Color.Red;
                    }
                    else if (Ayarlar.tema == "Mavi")
                    {
                        panelÜst.BackColor = Color.DarkBlue;
                        panelAlt.BackColor = Color.DarkBlue;
                        picBoxAyarlar.BackColor = Color.DarkBlue;
                        picBoxÇıkış.BackColor = Color.DarkBlue;
                        lblStoreManager.BackColor = Color.DarkBlue;
                        this.BackColor = Color.Blue;
                    }
                    else if (Ayarlar.tema == "Yeşil")
                    {
                        panelÜst.BackColor = Color.DarkGreen;
                        panelAlt.BackColor = Color.DarkGreen;
                        picBoxAyarlar.BackColor = Color.DarkGreen;
                        picBoxÇıkış.BackColor = Color.DarkGreen;
                        lblStoreManager.BackColor = Color.DarkGreen;
                        this.BackColor = Color.Green;
                    }
                }
            }
        }
        private void OturumAç_Load(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            oturumAyar = true;
            if (txtBoxKulAdı.Text != "" & txtBoxŞifre.Text != "")
            {
                txtBoxKulAdı.Text = Properties.Settings.Default["kullanıcıAdı"].ToString();
                txtBoxŞifre.Text = Properties.Settings.Default["şifre"].ToString();
                Ayarlar.tema = Properties.Settings.Default["tema"].ToString();
                Ayarlar.dil = Properties.Settings.Default["dil"].ToString();
                yetki = Properties.Settings.Default["yetki"].ToString();
                if (txtBoxKulAdı.Text.Count() > 1)
                {
                    cBoxOturumAçık.Checked = true;
                }
            }
            else
            {
                if (Ayarlar.dil == "English")
                {
                    Açıklama.SetToolTip(txtBoxKulAdı, "User Name");
                    Açıklama.SetToolTip(txtBoxŞifre, "Password");
                    Açıklama.SetToolTip(picBoxAyarlar, "Settings");
                    Açıklama.SetToolTip(picBoxÇıkış, "Exit");
                    txtBoxKulAdı.Text = "User Name"; txtBoxŞifre.Text = "Password";
                    btnKayıtOl.Text = "Sign Up"; btnOturumAç.Text = "Log In";
                    radBtnYönetici.Text = "Manager"; radBtnÇalışan.Text = "Employee";
                    cBoxOturumAçık.Text = "Keep me log in"; linkLblŞifreUnuttum.Text = "Forget your password ?";
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
                        lblStoreManager.BackColor = Color.FromArgb(40, 40, 40);
                        this.BackColor = Color.FromArgb(64, 64, 64);
                    }
                    else if (Ayarlar.tema == "Kırmızı")
                    {
                        panelÜst.BackColor = Color.DarkRed;
                        panelAlt.BackColor = Color.DarkRed;
                        picBoxAyarlar.BackColor = Color.DarkRed;
                        picBoxÇıkış.BackColor = Color.DarkRed;
                        lblStoreManager.BackColor = Color.DarkRed;
                        this.BackColor = Color.Red;
                    }
                    else if (Ayarlar.tema == "Mavi")
                    {
                        panelÜst.BackColor = Color.DarkBlue;
                        panelAlt.BackColor = Color.DarkBlue;
                        picBoxAyarlar.BackColor = Color.DarkBlue;
                        picBoxÇıkış.BackColor = Color.DarkBlue;
                        lblStoreManager.BackColor = Color.DarkBlue;
                        this.BackColor = Color.Blue;
                    }
                    else if (Ayarlar.tema == "Yeşil")
                    {
                        panelÜst.BackColor = Color.DarkGreen;
                        panelAlt.BackColor = Color.DarkGreen;
                        picBoxAyarlar.BackColor = Color.DarkGreen;
                        picBoxÇıkış.BackColor = Color.DarkGreen;
                        lblStoreManager.BackColor = Color.DarkGreen;
                        this.BackColor = Color.Green;
                    }
                }
                else if (Ayarlar.dil == "Türkçe")
                {
                    Açıklama.SetToolTip(txtBoxKulAdı, "Kullanıcı Adı");
                    Açıklama.SetToolTip(txtBoxŞifre, "Şifre");
                    Açıklama.SetToolTip(picBoxAyarlar, "Ayarlar");
                    Açıklama.SetToolTip(picBoxÇıkış, "Çıkış");
                    txtBoxKulAdı.Text = "Kullanıcı Adı"; txtBoxŞifre.Text = "Şifre";
                    btnKayıtOl.Text = "Kayıt Ol"; btnOturumAç.Text = "Oturum Aç";
                    radBtnYönetici.Text = "Yönetici"; radBtnÇalışan.Text = "Çalışan";
                    cBoxOturumAçık.Text = "Oturumumu Açık Tut"; linkLblŞifreUnuttum.Text = "Şifrenizi Mi Unuttunuz?";
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
                        lblStoreManager.BackColor = Color.FromArgb(40, 40, 40);
                        this.BackColor = Color.FromArgb(64, 64, 64);
                    }
                    else if (Ayarlar.tema == "Kırmızı")
                    {
                        panelÜst.BackColor = Color.DarkRed;
                        panelAlt.BackColor = Color.DarkRed;
                        picBoxAyarlar.BackColor = Color.DarkRed;
                        picBoxÇıkış.BackColor = Color.DarkRed;
                        lblStoreManager.BackColor = Color.DarkRed;
                        this.BackColor = Color.Red;
                    }
                    else if (Ayarlar.tema == "Mavi")
                    {
                        panelÜst.BackColor = Color.DarkBlue;
                        panelAlt.BackColor = Color.DarkBlue;
                        picBoxAyarlar.BackColor = Color.DarkBlue;
                        picBoxÇıkış.BackColor = Color.DarkBlue;
                        lblStoreManager.BackColor = Color.DarkBlue;
                        this.BackColor = Color.Blue;
                    }
                    else if (Ayarlar.tema == "Yeşil")
                    {
                        panelÜst.BackColor = Color.DarkGreen;
                        panelAlt.BackColor = Color.DarkGreen;
                        picBoxAyarlar.BackColor = Color.DarkGreen;
                        picBoxÇıkış.BackColor = Color.DarkGreen;
                        lblStoreManager.BackColor = Color.DarkGreen;
                        this.BackColor = Color.Green;
                    }
                }
            }
        }
        private void txtBoxKulAdı_TextChanged(object sender, EventArgs e)
        {
            kullanıcıAdı = txtBoxKulAdı.Text;
        }

        private void txtBoxŞifre_TextChanged(object sender, EventArgs e)
        {
            şifre = txtBoxŞifre.Text;
            if (txtBoxŞifre.Text == "Şifre" || txtBoxŞifre.Text == "Password")
            {
                if (şifreSayaç % 2 == 1)
                {
                    txtBoxŞifre.PasswordChar = '*';
                    txtBoxŞifre.MaxLength = 15;
                }
                else if (şifreSayaç % 2 == 0)
                {
                    txtBoxŞifre.PasswordChar = '\0';
                    txtBoxŞifre.MaxLength = 15;
                }
            }
            else if (txtBoxŞifre.Text != "Şifre" || txtBoxŞifre.Text != "Password")
            {
                if (şifreSayaç % 2 == 1)
                {
                    txtBoxŞifre.PasswordChar = '\0';
                    txtBoxŞifre.MaxLength = 15;
                }
                else if (şifreSayaç % 2 == 0)
                {
                    txtBoxŞifre.PasswordChar = '*';
                    txtBoxŞifre.MaxLength = 15;
                }
            }
        }

        private void radBtnÇalışan_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnÇalışan.Checked == true)
            {
                yetki = "Çalışan";
            }
        }

        private void radBtnYönetici_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnYönetici.Checked == true)
            {
                yetki = "Yönetici";
            }
        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            KayıtOl kayıtol = new KayıtOl();
            this.Hide();
            kayıtol.Show();
        }

        private void linkLblŞifreUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ŞifremiUnuttum şifremiunuttum = new ŞifremiUnuttum();
            this.Hide();
            şifremiunuttum.Show();
        }

        private void txtBoxKulAdı_Click(object sender, EventArgs e)
        {
            txtBoxKulAdı.Text = "";
        }

        private void txtBoxŞifre_Click(object sender, EventArgs e)
        {
            txtBoxŞifre.Text = "";
        }
    }
}

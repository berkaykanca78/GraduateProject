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
using System.Net.Mail;
using System.Net;

namespace Store_Manager
{
    public partial class ŞifremiUnuttum : Form
    {
        public ŞifremiUnuttum()
        {
            InitializeComponent();
        }
        string baglantiString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
        static string komutString = "";
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader okuyucu;
        string[] karakter = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z","0","1","2","3","4","5","6","7","8","9"};
        Random rastgele = new Random();
        string yazı = "";
        string mailiçeriği = "";
        public void VeriGetirÇalışan()
        {
            baglanti = new SqlConnection(baglantiString);
            if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }
            komutString = "SELECT * FROM Employee WHERE Employee_User_Name='" + txtBoxKulAdıMail.Text + "' or Employee_E_Mail='" + txtBoxKulAdıMail.Text + "'";
            komut = new SqlCommand(komutString, baglanti);
            komut.ExecuteNonQuery();
            okuyucu = komut.ExecuteReader();
            if (okuyucu.Read())
            {
                string kullanıcıadı = okuyucu["Employee_User_Name"].ToString();
                string email = okuyucu["Employee_E_Mail"].ToString();
                MailGönder(kullanıcıadı, email);
            }
            else
            {
                baglanti.Dispose();
                baglanti.Close();
            }
            baglanti.Dispose();
            baglanti.Close();
        }
        public void VeriGetirYönetici()
        {
            baglanti = new SqlConnection(baglantiString);
            if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }
            komutString = "SELECT * FROM Manager WHERE Manager_User_Name='" + txtBoxKulAdıMail.Text + "' or Manager_E_Mail='" + txtBoxKulAdıMail.Text + "'";
            komut = new SqlCommand(komutString, baglanti);
            komut.ExecuteNonQuery();
            okuyucu = komut.ExecuteReader();
            if (okuyucu.Read())
            {
                string kullanıcıadı = okuyucu["Manager_User_Name"].ToString();
                string email = okuyucu["Manager_E_Mail"].ToString();
                MailGönder(kullanıcıadı,email);
            }
            else 
            {
                baglanti.Dispose();
                baglanti.Close();
            }
            baglanti.Dispose();
            baglanti.Close();
        }
        public void ÇalışanŞifreDeğiştir()
        {
            baglanti = new SqlConnection(baglantiString);
            if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }
            komutString = "UPDATE Employee SET Employee_Password=@Employee_Password WHERE Employee_User_Name='" + txtBoxKulAdıMail.Text + "' or Employee_E_Mail='" + txtBoxKulAdıMail.Text + "'";
            komut = new SqlCommand(komutString, baglanti);
            komut.Parameters.AddWithValue("@Employee_Password", yazı);
            komut.ExecuteNonQuery();
            baglanti.Dispose();
            baglanti.Close();
        }
        public void YöneticiŞifreDeğiştir()
        {
            baglanti = new SqlConnection(baglantiString);
            if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }
            komutString = "UPDATE Manager SET Manager_Password=@Manager_Password WHERE Manager_User_Name='" + txtBoxKulAdıMail.Text + "' or Manager_E_Mail='" + txtBoxKulAdıMail.Text + "'";
            komut = new SqlCommand(komutString, baglanti);
            komut.Parameters.AddWithValue("@Manager_Password", yazı);
            komut.ExecuteNonQuery();
            baglanti.Dispose();
            baglanti.Close();
        }
        public void MailGönder(string kulAdı,string mailAdres)
        {
            mailiçeriği = "Kullanıcı Adınız : " + kulAdı + " E -Mail Adresiniz : " + mailAdres + " Yeni Şifreniz : " + yazı;
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential("brkyknc@gmail.com", "Berkay_678");
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("brkyknc@gmail.com", "Store Manager Şifre Yönetimi");
            mail.To.Add(mailAdres);
            mail.Subject = "Yeni Oturum Şifreniz";
            mail.IsBodyHtml = true;
            mail.Body = mailiçeriği;
            sc.Send(mail);
            timerZaman.Start();
        }
        private void ŞifremiUnuttum_Load(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            progressBarYükleme.Value = 0;
            for (int i = 0; i < 10; i++)
            {
                int sayi = rastgele.Next(0, karakter.Length);
                string harf = karakter[sayi].ToString();
                yazı += harf;
            }
            lblCaptcha.Text = yazı;
            if (Ayarlar.dil == "English")
            {
                Açıklama.SetToolTip(txtBoxKulAdıMail, "User Name Or E - Mail Adress");
                Açıklama.SetToolTip(txtBoxResim, "Write Charachters Here");
                Açıklama.SetToolTip(picBoxAyarlar, "Settings");
                Açıklama.SetToolTip(picBoxÇıkış, "Exit");
                txtBoxKulAdıMail.Text = "User Name Or E-Mail Address";
                txtBoxResim.Text = "Write characters here"; btnYeniŞifre.Text = "Send New Password";
                lblŞifremiUnuttum.Text = "Forgot Password";
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
                    lblŞifremiUnuttum.BackColor = Color.FromArgb(40, 40, 40);
                    this.BackColor = Color.FromArgb(64, 64, 64);
                }
                else if (Ayarlar.tema == "Kırmızı")
                {
                    panelÜst.BackColor = Color.DarkRed;
                    panelAlt.BackColor = Color.DarkRed;
                    picBoxAyarlar.BackColor = Color.DarkRed;
                    picBoxÇıkış.BackColor = Color.DarkRed;
                    lblŞifremiUnuttum.BackColor = Color.DarkRed;
                    this.BackColor = Color.Red;
                }
                else if (Ayarlar.tema == "Mavi")
                {
                    panelÜst.BackColor = Color.DarkBlue;
                    panelAlt.BackColor = Color.DarkBlue;
                    picBoxAyarlar.BackColor = Color.DarkBlue;
                    picBoxÇıkış.BackColor = Color.DarkBlue;
                    lblŞifremiUnuttum.BackColor = Color.DarkBlue;
                    this.BackColor = Color.Blue;
                }
                else if (Ayarlar.tema == "Yeşil")
                {
                    panelÜst.BackColor = Color.DarkGreen;
                    panelAlt.BackColor = Color.DarkGreen;
                    picBoxAyarlar.BackColor = Color.DarkGreen;
                    picBoxÇıkış.BackColor = Color.DarkGreen;
                    lblŞifremiUnuttum.BackColor = Color.DarkGreen;
                    this.BackColor = Color.Green;
                }
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                Açıklama.SetToolTip(txtBoxKulAdıMail, "Kullanıcı Adı Veya Mail Adresi");
                Açıklama.SetToolTip(txtBoxResim, "Karakterleri Buraya Giriniz");
                Açıklama.SetToolTip(picBoxAyarlar, "Ayarlar");
                Açıklama.SetToolTip(picBoxÇıkış, "Çıkış");
                txtBoxKulAdıMail.Text = "Kullanıcı Adı Veya E-Mail Adresi";
                txtBoxResim.Text = "Karakterleri buraya yazınız"; btnYeniŞifre.Text = "Yeni Şifre Gönder";
                lblŞifremiUnuttum.Text = "Şifremi Unuttum";
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
                    lblŞifremiUnuttum.BackColor = Color.FromArgb(40, 40, 40);
                    this.BackColor = Color.FromArgb(64, 64, 64);
                }
                else if (Ayarlar.tema == "Kırmızı")
                {
                    panelÜst.BackColor = Color.DarkRed;
                    panelAlt.BackColor = Color.DarkRed;
                    picBoxAyarlar.BackColor = Color.DarkRed;
                    picBoxÇıkış.BackColor = Color.DarkRed;
                    lblŞifremiUnuttum.BackColor = Color.DarkRed;
                    this.BackColor = Color.Red;
                }
                else if (Ayarlar.tema == "Mavi")
                {
                    panelÜst.BackColor = Color.DarkBlue;
                    panelAlt.BackColor = Color.DarkBlue;
                    picBoxAyarlar.BackColor = Color.DarkBlue;
                    picBoxÇıkış.BackColor = Color.DarkBlue;
                    lblŞifremiUnuttum.BackColor = Color.DarkBlue;
                    this.BackColor = Color.Blue;
                }
                else if (Ayarlar.tema == "Yeşil")
                {
                    panelÜst.BackColor = Color.DarkGreen;
                    panelAlt.BackColor = Color.DarkGreen;
                    picBoxAyarlar.BackColor = Color.DarkGreen;
                    picBoxÇıkış.BackColor = Color.DarkGreen;
                    lblŞifremiUnuttum.BackColor = Color.DarkGreen;
                    this.BackColor = Color.Green;
                }
            }
        }

        private void ŞifremiUnuttum_Activated(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            progressBarYükleme.Value = 0;
            yazı = "";
            for (int i = 0; i < 10; i++)
            {
                int sayi = rastgele.Next(0, karakter.Length);
                string harf = karakter[sayi].ToString();
                yazı += harf;
            }
            lblCaptcha.Text = yazı;
            if (Ayarlar.dil == "English")
            {
                Açıklama.SetToolTip(txtBoxKulAdıMail, "User Name Or E - Mail Adress");
                Açıklama.SetToolTip(txtBoxResim, "Write Charachters Here");
                Açıklama.SetToolTip(picBoxAyarlar, "Settings");
                Açıklama.SetToolTip(picBoxÇıkış, "Exit");
                txtBoxKulAdıMail.Text = "User Name Or E-Mail Address";
                txtBoxResim.Text = "Write characters here"; btnYeniŞifre.Text = "Send New Password";
                lblŞifremiUnuttum.Text = "Forgot Password";
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
                    lblŞifremiUnuttum.BackColor = Color.FromArgb(40, 40, 40);
                    this.BackColor = Color.FromArgb(64, 64, 64);
                }
                else if (Ayarlar.tema == "Kırmızı")
                {
                    panelÜst.BackColor = Color.DarkRed;
                    panelAlt.BackColor = Color.DarkRed;
                    picBoxAyarlar.BackColor = Color.DarkRed;
                    picBoxÇıkış.BackColor = Color.DarkRed;
                    lblŞifremiUnuttum.BackColor = Color.DarkRed;
                    this.BackColor = Color.Red;
                }
                else if (Ayarlar.tema == "Mavi")
                {
                    panelÜst.BackColor = Color.DarkBlue;
                    panelAlt.BackColor = Color.DarkBlue;
                    picBoxAyarlar.BackColor = Color.DarkBlue;
                    picBoxÇıkış.BackColor = Color.DarkBlue;
                    lblŞifremiUnuttum.BackColor = Color.DarkBlue;
                    this.BackColor = Color.Blue;
                }
                else if (Ayarlar.tema == "Yeşil")
                {
                    panelÜst.BackColor = Color.DarkGreen;
                    panelAlt.BackColor = Color.DarkGreen;
                    picBoxAyarlar.BackColor = Color.DarkGreen;
                    picBoxÇıkış.BackColor = Color.DarkGreen;
                    lblŞifremiUnuttum.BackColor = Color.DarkGreen;
                    this.BackColor = Color.Green;
                }
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                Açıklama.SetToolTip(txtBoxKulAdıMail, "Kullanıcı Adı Veya Mail Adresi");
                Açıklama.SetToolTip(txtBoxResim, "Karakterleri Buraya Giriniz");
                Açıklama.SetToolTip(picBoxAyarlar, "Ayarlar");
                Açıklama.SetToolTip(picBoxÇıkış, "Çıkış");
                txtBoxKulAdıMail.Text = "Kullanıcı Adı Veya E-Mail Adresi";
                txtBoxResim.Text = "Karakterleri buraya yazınız"; btnYeniŞifre.Text = "Yeni Şifre Gönder";
                lblŞifremiUnuttum.Text = "Şifremi Unuttum";
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
                    lblŞifremiUnuttum.BackColor = Color.FromArgb(40, 40, 40);
                    this.BackColor = Color.FromArgb(64, 64, 64);
                }
                else if (Ayarlar.tema == "Kırmızı")
                {
                    panelÜst.BackColor = Color.DarkRed;
                    panelAlt.BackColor = Color.DarkRed;
                    picBoxAyarlar.BackColor = Color.DarkRed;
                    picBoxÇıkış.BackColor = Color.DarkRed;
                    lblŞifremiUnuttum.BackColor = Color.DarkRed;
                    this.BackColor = Color.Red;
                }
                else if (Ayarlar.tema == "Mavi")
                {
                    panelÜst.BackColor = Color.DarkBlue;
                    panelAlt.BackColor = Color.DarkBlue;
                    picBoxAyarlar.BackColor = Color.DarkBlue;
                    picBoxÇıkış.BackColor = Color.DarkBlue;
                    lblŞifremiUnuttum.BackColor = Color.DarkBlue;
                    this.BackColor = Color.Blue;
                }
                else if (Ayarlar.tema == "Yeşil")
                {
                    panelÜst.BackColor = Color.DarkGreen;
                    panelAlt.BackColor = Color.DarkGreen;
                    picBoxAyarlar.BackColor = Color.DarkGreen;
                    picBoxÇıkış.BackColor = Color.DarkGreen;
                    lblŞifremiUnuttum.BackColor = Color.DarkGreen;
                    this.BackColor = Color.Green;
                }
            }
        }

        private void picBoxAyarlar_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show();
        }

        private void picBoxÇıkış_Click(object sender, EventArgs e)
        {
            picBoxÇıkış.Focus();
            OturumAç oturumaç = new OturumAç();
            this.Hide();
            oturumaç.Show();
        }

        private void btnYeniResim_Click(object sender, EventArgs e)
        {
            yazı = "";
            for (int i = 0; i < 10; i++)
            {
                int sayi = rastgele.Next(0, karakter.Length);
                string harf = karakter[sayi].ToString();
                yazı += harf;
            }
            lblCaptcha.Text = yazı;
        }

        private void btnYeniŞifre_Click(object sender, EventArgs e)
        {
            if (lblCaptcha.Text != txtBoxResim.Text)
            {
                if (Ayarlar.dil == "Türkçe")
                {
                    MessageBox.Show("Lütfen Resimdeki Karakterlerin Aynısı Yazınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Ayarlar.dil == "English")
                {
                    MessageBox.Show("Please Write Same Characters From Picture.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (lblCaptcha.Text == txtBoxResim.Text)
            {
                yazı = "";
                for (int i = 0; i < 10; i++)
                {
                    int sayi = rastgele.Next(0, karakter.Length);
                    string harf = karakter[sayi].ToString();
                    yazı += harf;
                }
                VeriGetirÇalışan();
                ÇalışanŞifreDeğiştir();
                VeriGetirYönetici();
                YöneticiŞifreDeğiştir();
            }
        }

        private void txtBoxKulAdıMail_Click(object sender, EventArgs e)
        {
            txtBoxKulAdıMail.Text = "";
        }

        private void txtBoxResim_Click(object sender, EventArgs e)
        {
            txtBoxResim.Text = "";
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
                    MessageBox.Show("Yeni Şifreniz E-Mail Adresinize Gönderilmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Ayarlar.dil == "English")
                {
                    MessageBox.Show("Your New Password Has Been Sent To Your E-Mail Address.", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                progressBarYükleme.Visible = false;
            }
        }
    }
}

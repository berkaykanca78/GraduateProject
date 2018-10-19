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
    public partial class AlarmMailGönder : Form
    {
        public static string Mail = "";
        public static int şifreSayaç = 0;
        public static string mailiçeriği = "";
        public AlarmMailGönder()
        {
            InitializeComponent();
        }
        public void MailGonderildiDepo()
        {
            if (ÇalışanAnaMenü.yer == "Depo" || YöneticiAnaMenü.yer=="Depo")
            {
                string conString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
                SqlConnection baglanti = new SqlConnection(conString);
                baglanti.Open();
                string kayit = "UPDATE Product SET Warehouse_Mail=@Warehouse_Mail WHERE Product_Name='" + txtBoxÜrünAdı.Text + "'";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@Warehouse_Mail", true);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
        }
        public void MailGonderildiMagaza()
        {
            if (ÇalışanAnaMenü.yer == "Mağaza" || YöneticiAnaMenü.yer == "Mağaza")
            {
                string conString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
                SqlConnection baglanti = new SqlConnection(conString);
                baglanti.Open();
                string kayit = "UPDATE Product SET Store_Mail=@Store_Mail WHERE Product_Name='" + txtBoxÜrünAdı.Text + "'";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@Store_Mail", true);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
        }
        private void Çalışan()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Employee WHERE Employee_User_Name='" + OturumAç.kullanıcıAdı + "'";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtBoxMailAdresiniz.Text = dr["Employee_E_Mail"].ToString();
                txtBoxKullanıcıAdı.Text= dr["Employee_User_Name"].ToString();
                txtBoxÜrünAdı.Text = ÇalışanAnaMenü.ürün;
            }
            baglanti.Close();
        }
        private void Yönetici()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Manager WHERE Manager_User_Name='"+OturumAç.kullanıcıAdı+"'";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtBoxMailAdresiniz.Text = dr["Manager_E_Mail"].ToString();
                txtBoxKullanıcıAdı.Text = dr["Manager_User_Name"].ToString();
                txtBoxÜrünAdı.Text = YöneticiAnaMenü.ürün;
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
        public void TedarikçiEMail()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Supplier WHERE Supplier_TC_No='"+cmbBoxTedarikçiAdıSoyadı.SelectedValue.ToString()+"'";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();         
            while (dr.Read())
            {
               txtBoxMail.Text = dr["Supplier_E_Mail"].ToString();
            }
            dr.Close();
            baglanti.Close();
        }
        private void AlarmMailGönder_Load(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            if (Ayarlar.dil == "English")
            {
                Açıklama.SetToolTip(txtBoxKullanıcıAdı, "User Name");
                Açıklama.SetToolTip(txtBoxMail, "E-Mail Address For Sending E-Mail");
                Açıklama.SetToolTip(txtBoxMailAdresiniz, "Your E-Mail Address");
                Açıklama.SetToolTip(txtBoxMailŞifre, "Password");
                Açıklama.SetToolTip(txtBoxÜrünAdedi, "Number Of Products");
                Açıklama.SetToolTip(txtBoxÜrünAdı, "Product Name");
                Açıklama.SetToolTip(cmbBoxTedarikçiAdıSoyadı, "Supplier Name & Surname");
                txtBoxKullanıcıAdı.Text = "Your User Name";
                txtBoxMail.Text = "Supplier E - Mail";
                txtBoxMailAdresiniz.Text = "Your E - Mail";
                txtBoxMailŞifre.Text = "Your E - Mail Password";
                cmbBoxTedarikçiAdıSoyadı.Text = "Supplier Name & Surname";
                txtBoxÜrünAdedi.Text = "Number Of Products";
                txtBoxÜrünAdı.Text = "Product Name";
                btnMailGönder.Text = "Send An E - Mail";
                MessageBoxManager.Unregister();
                MessageBoxManager.OK = "OK";
                MessageBoxManager.Register();
                Çalışan();
                Yönetici();
                TedarikçiTCNoVeriGetir();
                TedarikçiEMail();
                Mail = txtBoxMail.Text;
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                Açıklama.SetToolTip(txtBoxKullanıcıAdı, "Kullanıcı Adınız");
                Açıklama.SetToolTip(txtBoxMail, "Gönderilecek Mail Adresi");
                Açıklama.SetToolTip(txtBoxMailAdresiniz, "Mail Adresiniz");
                Açıklama.SetToolTip(txtBoxMailŞifre, "Şifre");
                Açıklama.SetToolTip(txtBoxÜrünAdedi, "Ürün Adedi");
                Açıklama.SetToolTip(txtBoxÜrünAdı, "Ürün Adı");
                Açıklama.SetToolTip(cmbBoxTedarikçiAdıSoyadı, "Tedarikçi Adı & Soyadı");
                txtBoxKullanıcıAdı.Text = "Kullanıcı Adınız";
                txtBoxMail.Text = "Tedarikçi E - Mail";
                txtBoxMailAdresiniz.Text = "E - Mail Adresiniz";
                txtBoxMailŞifre.Text = "E - Mail Şifreniz";
                cmbBoxTedarikçiAdıSoyadı.Text = "Tedarikçi Adı & Soyadı";
                txtBoxÜrünAdedi.Text = "Ürün Adedi";
                txtBoxÜrünAdı.Text = "Ürün Adı";
                btnMailGönder.Text = "Mail Gönder";
                MessageBoxManager.Unregister();
                MessageBoxManager.OK = "Tamam";
                MessageBoxManager.Register();
                Çalışan();
                Yönetici();
                TedarikçiTCNoVeriGetir();
                TedarikçiEMail();
                Mail = txtBoxMail.Text;
            }
        }
        private void cmbBoxTedarikçiAdıSoyadı_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxTedarikçiAdıSoyadı.SelectedIndex != 0)
            {
                TedarikçiEMail();
            }
            else
            {
                txtBoxMail.Text = Mail;
            }
        }
        private void btnMailGönder_Click(object sender, EventArgs e)
        {
            if (txtBoxMailAdresiniz.Text.Contains("gmail.com") == true)
            {
                MailGonderildiDepo();
                MailGonderildiMagaza();
                mailiçeriği = "İstenilen Ürün : " + txtBoxÜrünAdı.Text + " Ürün Adedi : " + txtBoxÜrünAdedi.Text + " Sipariş Tarihi : " + DateTime.Now.ToString();
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.gmail.com";
                sc.EnableSsl = true;
                sc.Credentials = new NetworkCredential(txtBoxMailAdresiniz.Text, txtBoxMailŞifre.Text);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(txtBoxMailAdresiniz.Text);
                mail.To.Add(txtBoxMail.Text);
                mail.Subject = "Ürün Siparişi";
                mail.IsBodyHtml = true;
                mail.Body = mailiçeriği;
                sc.Send(mail);
                if (Ayarlar.dil == "Türkçe")
                {
                    MessageBox.Show("Sipariş Mailiniz Gönderilmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Ayarlar.dil == "English")
                {
                    MessageBox.Show("Your Order Mail Has Been Sent.", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtBoxMailAdresiniz.Text.Contains("gmail.com") == false)
            {
                MailGonderildiDepo();
                MailGonderildiMagaza();
                mailiçeriği = "İstenilen Ürün : " + txtBoxÜrünAdı.Text + " Ürün Adedi : " + txtBoxÜrünAdedi.Text + " Sipariş Tarihi : " + DateTime.Now.ToString();
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.live.com";
                sc.EnableSsl = true;
                sc.Credentials = new NetworkCredential(txtBoxMailAdresiniz.Text, txtBoxMailŞifre.Text);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(txtBoxMailAdresiniz.Text);
                mail.To.Add(txtBoxMail.Text);
                mail.Subject = "Ürün Siparişi";
                mail.IsBodyHtml = true;
                mail.Body = mailiçeriği;
                sc.Send(mail);
                if (Ayarlar.dil == "Türkçe")
                {
                    MessageBox.Show("Sipariş Mailiniz Gönderilmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Ayarlar.dil == "English")
                {
                    MessageBox.Show("Your Order Mail Has Been Sent.", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void picBoxGöster_Click(object sender, EventArgs e)
        {
            şifreSayaç++;
            if (şifreSayaç % 2 == 1)
            {
                txtBoxMailŞifre.PasswordChar = '*';
                txtBoxMailŞifre.MaxLength = 15;
            }
            else if (şifreSayaç % 2 == 0)
            {
                txtBoxMailŞifre.PasswordChar = '\0';
                txtBoxMailŞifre.MaxLength = 15;
            }
        }
        private void txtBoxÜrünAdedi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

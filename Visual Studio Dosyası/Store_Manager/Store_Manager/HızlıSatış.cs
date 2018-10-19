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
using System.IO;

namespace Store_Manager
{
    public partial class HızlıSatış : Form
    {
        public string SepetUrl = Application.StartupPath + "\\Sepet.txt";
        public string kullanıcıAdı = OturumAç.kullanıcıAdı;
        public static int ÜrünNumarasıIndex;
        public static string SatanKisi_TC;
        public static string Hangisi;
        public HızlıSatış()
        {
            InitializeComponent();
        }
        public void CalisanTCGetir()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Employee WHERE Employee_User_Name='" + kullanıcıAdı + "'";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SatanKisi_TC = dr["Employee_TC_No"].ToString();
                Hangisi = "Çalışan";
            }
            baglanti.Close();
        }
        public void YoneticiTCGetir()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Manager WHERE Manager_User_Name='" + kullanıcıAdı + "'";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SatanKisi_TC = dr["Manager_TC_No"].ToString();
                Hangisi = "Yönetici";
            }
            baglanti.Close();
        }
        public void ÜrünNumarasıVeriGetir()
        {
            cmbBoxÜrünNumarası.Items.Clear();
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Product WHERE Store_No IS NOT Null";
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
        public void MüşteriTCNoVeriGetir()
        {
            cmbBoxMüşteriAdıSoyadı.Items.Clear();
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT Customer_TC_No,(Customer_Name + ' ' + Customer_Surname) AS CustomerNameSurname FROM Customer";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            baglanti.Open();
            DataTable tbl = new DataTable();
            tbl.Load(komut.ExecuteReader());
            baglanti.Close();
            cmbBoxMüşteriAdıSoyadı.DataSource = tbl;
            cmbBoxMüşteriAdıSoyadı.DisplayMember = "CustomerNameSurname";
            cmbBoxMüşteriAdıSoyadı.ValueMember = "Customer_TC_No";
        }
        public void UcretOku()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Product WHERE Product_No='" + cmbBoxÜrünNumarası.SelectedItem.ToString() + "'";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtBoxÜcreti.Text = dr["Product_Price"].ToString();
            }
            baglanti.Close();
        }
        private void picBoxÇıkış_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void picBoxAyarlar_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show();
        }
        private void HızlıSatış_Load(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            lblKulAdı.Text = "[" + kullanıcıAdı + "]";
            ÜrünNumarasıVeriGetir();
            MüşteriTCNoVeriGetir();
            CalisanTCGetir();
            YoneticiTCGetir();
            if (Ayarlar.dil == "English")
            {
                Açıklama.SetToolTip(cmbBoxÜrünNumarası, "Product Number");
                Açıklama.SetToolTip(cmbBoxMüşteriAdıSoyadı, "Customer Name & Surname");
                Açıklama.SetToolTip(txtBoxÜcreti, "Price");
                Açıklama.SetToolTip(txtBoxTaksitSayısı, "Installment No");
                Açıklama.SetToolTip(Sepettekiler, "In Basket");
                Sepettekiler.Text = "In Basket";
                Sepettekiler.Items.Add("Product Number:");
                Sepettekiler.Items.Add("Customer TC No:");
                Sepettekiler.Items.Add("Price:");
                Sepettekiler.Items.Add("Sale Type");
                Sepettekiler.Items.Add("Installment No:");
                Sepettekiler.Items.Add("Installment Price:");
                Sepettekiler.Items.Add("Add Point:");
                btnHızlıSatış.Text = "Do Quick Sale";
                cmbBoxMüşteriAdıSoyadı.Text = "Customer Name & Surname";
                cmbBoxÜrünNumarası.Text = "Product No";
                lblSatışTürü.Text = "Sale Type:";
                rBtnKrediKartı.Text = "Credit Card";
                rBtnPeşin.Text = "Cash";
                rBtnSenet.Text = "Bill";
                txtBoxÜcreti.Text = "Price (₺)";
                btnSepeteEkle.Text = "Add To Basket";
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                Açıklama.SetToolTip(cmbBoxÜrünNumarası, "Ürün Numarası");
                Açıklama.SetToolTip(cmbBoxMüşteriAdıSoyadı, "Müşteri Adı & Soyadı");
                Açıklama.SetToolTip(txtBoxÜcreti, "Ücreti");
                Açıklama.SetToolTip(txtBoxTaksitSayısı, "Taksit Sayısı");
                Açıklama.SetToolTip(Sepettekiler, "Sepettekiler");
                Sepettekiler.Text = "Sepettekiler";
                Sepettekiler.Items.Add("Ürün Numarası:");
                Sepettekiler.Items.Add("Müşteri TC No:");
                Sepettekiler.Items.Add("Ücreti:");
                Sepettekiler.Items.Add("Satış Türü:");
                Sepettekiler.Items.Add("Taksit Sayısı:");
                Sepettekiler.Items.Add("Taksit Ücreti:");
                Sepettekiler.Items.Add("Eklenecek Puan:");
                btnHızlıSatış.Text = "Hızlı Satış Yap";
                cmbBoxMüşteriAdıSoyadı.Text = "Müşteri Adı & Soyadı";
                cmbBoxÜrünNumarası.Text = "Ürün Numarası";
                lblSatışTürü.Text = "Satış Türü:";
                rBtnKrediKartı.Text = "Kredi Kartı";
                rBtnPeşin.Text = "Peşin";
                rBtnSenet.Text = "Senet";
                txtBoxÜcreti.Text = "Ücreti (₺)";
                btnSepeteEkle.Text = "Sepete Ekle";
            }
        }
        private void HızlıSatış_Activated(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            lblKulAdı.Text = "[" + kullanıcıAdı + "]";
            if (Ayarlar.dil == "English")
            {
                Sepettekiler.Text = "In Basket";
                Açıklama.SetToolTip(cmbBoxÜrünNumarası, "Product Number");
                Açıklama.SetToolTip(cmbBoxMüşteriAdıSoyadı, "Customer Name & Surname");
                Açıklama.SetToolTip(txtBoxÜcreti, "Price");
                Açıklama.SetToolTip(txtBoxTaksitSayısı, "Installment No");
                Açıklama.SetToolTip(Sepettekiler, "In Basket");
                btnHızlıSatış.Text = "Do Quick Sale";
                cmbBoxMüşteriAdıSoyadı.Text = "Customer Name & Surname";
                cmbBoxÜrünNumarası.Text = "Product No";
                lblSatışTürü.Text = "Sale Type:";
                rBtnKrediKartı.Text = "Credit Card";
                rBtnPeşin.Text = "Cash";
                rBtnSenet.Text = "Bill";
                txtBoxÜcreti.Text = "Price (₺)";
                btnSepeteEkle.Text = "Add To Basket";
                if (Ayarlar.tema == "Varsayılan")
                {
                    panelÜst.BackColor = Color.LightGray;
                    this.BackColor = Color.FromArgb(37, 46, 59);
                }
                else if (Ayarlar.tema == "Kırmızı")
                {
                    panelÜst.BackColor = Color.LightGray;
                    this.BackColor = Color.Red;
                }
                else if (Ayarlar.tema == "Mavi")
                {
                    panelÜst.BackColor = Color.FromName("ActiveCaption");
                    this.BackColor = Color.Blue;
                }
                else if (Ayarlar.tema == "Yeşil")
                {
                    panelÜst.BackColor = Color.LightGray;
                    this.BackColor = Color.Green;
                }
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                Açıklama.SetToolTip(cmbBoxÜrünNumarası, "Ürün Numarası");
                Açıklama.SetToolTip(cmbBoxMüşteriAdıSoyadı, "Müşteri Adı & Soyadı");
                Açıklama.SetToolTip(txtBoxÜcreti, "Ücreti");
                Açıklama.SetToolTip(txtBoxTaksitSayısı, "Taksit Sayısı");
                Açıklama.SetToolTip(Sepettekiler, "Sepettekiler");
                Sepettekiler.Text = "Sepettekiler";
                btnHızlıSatış.Text = "Hızlı Satış Yap";
                cmbBoxMüşteriAdıSoyadı.Text = "Müşteri Adı & Soyadı";
                cmbBoxÜrünNumarası.Text = "Ürün Numarası";
                lblSatışTürü.Text = "Satış Türü:";
                rBtnKrediKartı.Text = "Kredi Kartı";
                rBtnPeşin.Text = "Peşin";
                rBtnSenet.Text = "Senet";
                txtBoxÜcreti.Text = "Ücreti (₺)";
                btnSepeteEkle.Text = "Sepete Ekle";
                if (Ayarlar.tema == "Varsayılan")
                {
                    panelÜst.BackColor = Color.LightGray;
                    this.BackColor = Color.FromArgb(37, 46, 59);
                }
                else if (Ayarlar.tema == "Kırmızı")
                {
                    panelÜst.BackColor = Color.LightGray;
                    this.BackColor = Color.Red;
                }
                else if (Ayarlar.tema == "Mavi")
                {
                    panelÜst.BackColor = Color.FromName("ActiveCaption");
                    this.BackColor = Color.Blue;
                }
                else if (Ayarlar.tema == "Yeşil")
                {
                    panelÜst.BackColor = Color.LightGray;
                    this.BackColor = Color.Green;
                }
            }
        }
        private void cmbBoxÜrünNumarası_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcretOku();
            ÜrünNumarasıIndex = Int32.Parse(cmbBoxÜrünNumarası.SelectedIndex.ToString());
        }
        private void rBtnSenet_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnSenet.Checked == true)
            {
                txtBoxTaksitSayısı.Visible = true;
            }
            else
            {
                txtBoxTaksitSayısı.Visible = false;
            }
        }
        public void Yaz()
        {
            FileStream fs = new FileStream(SepetUrl, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            if (rBtnKrediKartı.Checked == true && rBtnPeşin.Checked == false && rBtnSenet.Checked == false)
            {
                sw.WriteLine(cmbBoxÜrünNumarası.SelectedItem.ToString());
                sw.WriteLine(cmbBoxMüşteriAdıSoyadı.SelectedValue.ToString());
                sw.WriteLine(txtBoxÜcreti.Text);
                sw.WriteLine("Credit Card");
                sw.WriteLine(0);
                sw.WriteLine(0);
                sw.WriteLine(2);
                cmbBoxÜrünNumarası.Items.RemoveAt(ÜrünNumarasıIndex);
                cmbBoxÜrünNumarası.Text = "Ürün Numarası";
            }
            else if (rBtnPeşin.Checked == true && rBtnKrediKartı.Checked == false && rBtnSenet.Checked == false)
            {
                sw.WriteLine(cmbBoxÜrünNumarası.SelectedItem.ToString());
                sw.WriteLine(cmbBoxMüşteriAdıSoyadı.SelectedValue.ToString());
                sw.WriteLine(txtBoxÜcreti.Text);
                sw.WriteLine("Cash");
                sw.WriteLine(0);
                sw.WriteLine(0);
                sw.WriteLine(3);
                cmbBoxÜrünNumarası.Items.RemoveAt(ÜrünNumarasıIndex);
                cmbBoxÜrünNumarası.Text = "Ürün Numarası";
            }
            else if (rBtnSenet.Checked == true && rBtnPeşin.Checked == false && rBtnKrediKartı.Checked == false)
            {
                sw.WriteLine(cmbBoxÜrünNumarası.SelectedItem.ToString());
                sw.WriteLine(cmbBoxMüşteriAdıSoyadı.SelectedValue.ToString());
                sw.WriteLine(txtBoxÜcreti.Text);
                sw.WriteLine("Bill");
                sw.WriteLine(txtBoxTaksitSayısı.Text);
                int TP = Int32.Parse(txtBoxÜcreti.Text);
                int IN = Int32.Parse(txtBoxTaksitSayısı.Text);
                int R = TP / IN;
                sw.WriteLine(R.ToString());
                sw.WriteLine(0);
                cmbBoxÜrünNumarası.Items.RemoveAt(ÜrünNumarasıIndex);
                cmbBoxÜrünNumarası.Text = "Ürün Numarası";
            }
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public void Oku()
        {
            FileStream fs = new FileStream(SepetUrl, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();
            while (yazi != null)
            {
                Sepettekiler.Items.Add(yazi);
                yazi = sw.ReadLine();
            }
            sw.Close();
            fs.Close();
        }
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            Yaz();
            Oku();
            if (Ayarlar.dil == "Türkçe")
            {
                for (int i = 7; i < Sepettekiler.Items.Count; i++)
                {
                    if (Sepettekiler.Items[i].ToString() == "Bill")
                    {
                        Sepettekiler.Items[i] = "Taksit";
                    }
                    else if (Sepettekiler.Items[i].ToString() == "Credit Card")
                    {
                        Sepettekiler.Items[i] = "Kredi Kartı";
                    }
                    if (Sepettekiler.Items[i].ToString() == "Cash")
                    {
                        Sepettekiler.Items[i] = "Nakit";
                    }
                }
                cmbBoxMüşteriAdıSoyadı.Text = "Müşteri Adı & Soyadı";
                txtBoxÜcreti.Text = "Ücreti (₺)";
                rBtnPeşin.Focus();
                txtBoxTaksitSayısı.Visible = false;
            }
            else if (Ayarlar.dil == "English")
            {
                cmbBoxMüşteriAdıSoyadı.Text = "Customer Name & Surname";
                txtBoxÜcreti.Text = "Price (₺)";
                rBtnPeşin.Focus();
                txtBoxTaksitSayısı.Visible = false;
            }

        }
        public void HızlıSatışYap()
        {
            if (Sepettekiler.Items.Count != 0)
            {
                if (Hangisi == "Çalışan")
                {
                    for (int i = 7; i < Sepettekiler.Items.Count; i = i + 7)
                    {
                        SqlConnection baglanti = new SqlConnection();
                        baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
                        SqlCommand komut = new SqlCommand();
                        baglanti.Open();
                        string komutString = "INSERT INTO Sale (Sale_Date,Product_No,Customer_TC_No,Total_Price,Sale_Type,Installment_No,Installment_Price,Employee_TC_No) " +
                        "VALUES (@Sale_Date,@Product_No,@Customer_TC_No,@Total_Price,@Sale_Type,@Installment_No,@Installment_Price,@Employee_TC_No)";
                        komut = new SqlCommand(komutString, baglanti);
                        komut.Parameters.AddWithValue("@Sale_Date", SqlDbType.DateTime).Value = DateTime.Now;
                        komut.Parameters.AddWithValue("@Product_No", Sepettekiler.Items[i].ToString());
                        komut.Parameters.AddWithValue("@Customer_TC_No", Sepettekiler.Items[i + 1].ToString());
                        komut.Parameters.AddWithValue("@Total_Price", Sepettekiler.Items[i + 2].ToString());
                        komut.Parameters.AddWithValue("@Sale_Type", Sepettekiler.Items[i + 3].ToString());
                        komut.Parameters.AddWithValue("@Installment_No", Sepettekiler.Items[i + 4].ToString());
                        komut.Parameters.AddWithValue("@Installment_Price", Sepettekiler.Items[i + 5].ToString());
                        komut.Parameters.AddWithValue("@Employee_TC_No", SatanKisi_TC);
                        komut.ExecuteNonQuery();
                        baglanti.Dispose();
                        baglanti.Close();
                    }
                    for (int i = 7; i < Sepettekiler.Items.Count; i = i + 7)
                    {
                        SqlConnection baglanti = new SqlConnection();
                        baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
                        SqlCommand komut = new SqlCommand();
                        baglanti.Open();
                        string komutString = "UPDATE Customer SET Customer_Point=Customer_Point+@Customer_Point,Customer_Debt=Customer_Debt+@Customer_Debt WHERE Customer_TC_No=@Customer_TC_No";
                        komut = new SqlCommand(komutString, baglanti);
                        komut.Parameters.AddWithValue("@Customer_TC_No", Sepettekiler.Items[i + 1].ToString());
                        komut.Parameters.AddWithValue("@Customer_Point", Sepettekiler.Items[i + 6].ToString());
                        if (Sepettekiler.Items[i + 3].ToString() == "Bill")
                        {
                            komut.Parameters.AddWithValue("@Customer_Debt", Sepettekiler.Items[i + 2].ToString());
                        }
                        else if (Sepettekiler.Items[i + 3].ToString() != "Bill")
                        {
                            komut.Parameters.AddWithValue("@Customer_Debt", 0);
                        }
                        komut.ExecuteNonQuery();
                        baglanti.Dispose();
                        baglanti.Close();
                    }
                    MağazadanÜrünüSil();
                }
                else if (Hangisi == "Yönetici")
                {
                    for (int i = 7; i < Sepettekiler.Items.Count; i = i + 7)
                    {
                        SqlConnection baglanti = new SqlConnection();
                        baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
                        SqlCommand komut = new SqlCommand();
                        baglanti.Open();
                        string komutString = "INSERT INTO Sale (Sale_Date,Product_No,Customer_TC_No,Total_Price,Sale_Type,Installment_No,Installment_Price,Manager_TC_No) " +
                        "VALUES (@Sale_Date,@Product_No,@Customer_TC_No,@Total_Price,@Sale_Type,@Installment_No,@Installment_Price,@Manager_TC_No)";
                        komut = new SqlCommand(komutString, baglanti);
                        komut.Parameters.AddWithValue("@Sale_Date", SqlDbType.DateTime).Value = DateTime.Now;
                        komut.Parameters.AddWithValue("@Product_No", Sepettekiler.Items[i].ToString());
                        komut.Parameters.AddWithValue("@Customer_TC_No", Sepettekiler.Items[i + 1].ToString());
                        komut.Parameters.AddWithValue("@Total_Price", Sepettekiler.Items[i + 2].ToString());
                        komut.Parameters.AddWithValue("@Sale_Type", Sepettekiler.Items[i + 3].ToString());
                        komut.Parameters.AddWithValue("@Installment_No", Sepettekiler.Items[i + 4].ToString());
                        komut.Parameters.AddWithValue("@Installment_Price", Sepettekiler.Items[i + 5].ToString());
                        komut.Parameters.AddWithValue("@Manager_TC_No", SatanKisi_TC);
                        komut.ExecuteNonQuery();
                        baglanti.Dispose();
                        baglanti.Close();
                    }
                    for (int i = 7; i < Sepettekiler.Items.Count; i = i + 7)
                    {
                        SqlConnection baglanti = new SqlConnection();
                        baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
                        SqlCommand komut = new SqlCommand();
                        baglanti.Open();
                        string komutString = "UPDATE Customer SET Customer_Point=Customer_Point+@Customer_Point,Customer_Debt=Customer_Debt+@Customer_Debt WHERE Customer_TC_No=@Customer_TC_No";
                        komut = new SqlCommand(komutString, baglanti);
                        komut.Parameters.AddWithValue("@Customer_TC_No", Sepettekiler.Items[i + 1].ToString());
                        komut.Parameters.AddWithValue("@Customer_Point", Sepettekiler.Items[i + 6].ToString());
                        if (Sepettekiler.Items[i + 3].ToString() == "Bill")
                        {
                            komut.Parameters.AddWithValue("@Customer_Debt", Sepettekiler.Items[i + 2].ToString());
                        }
                        else if (Sepettekiler.Items[i + 3].ToString() != "Bill")
                        {
                            komut.Parameters.AddWithValue("@Customer_Debt", 0);
                        }
                        komut.ExecuteNonQuery();
                        baglanti.Dispose();
                        baglanti.Close();
                    }
                    MağazadanÜrünüSil();
                }
            }
        }
        public void MağazadanÜrünüSil()
        {
            for (int i = 7; i < Sepettekiler.Items.Count; i = i + 7)
            {
                string conString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
                SqlConnection baglanti = new SqlConnection(conString);
                baglanti.Open();
                string kayit = "UPDATE Product SET Store_No=NULL WHERE Product_No='" + Sepettekiler.Items[i].ToString() + "'";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                ÜrünNumarasıVeriGetir();
            }
        }
        private void btnHızlıSatış_Click(object sender, EventArgs e)
        {
            if (Ayarlar.dil == "English")
            {
                HızlıSatışYap();
                MessageBoxManager.Unregister();
                MessageBoxManager.OK = "OK";
                MessageBoxManager.Register();
                MessageBox.Show("Product Sale Was Maded", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (File.Exists(Application.StartupPath + "\\Sepet.txt"))
                {
                    File.Delete(SepetUrl);
                }
                Hide();
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                for (int i = 7; i < Sepettekiler.Items.Count; i++)
                {
                    if (Sepettekiler.Items[i].ToString() == "Taksit")
                    {
                        Sepettekiler.Items[i] = "Bill";
                    }
                    else if (Sepettekiler.Items[i].ToString() == "Kredi Kartı")
                    {
                        Sepettekiler.Items[i] = "Credit Card";
                    }
                    if (Sepettekiler.Items[i].ToString() == "Nakit")
                    {
                        Sepettekiler.Items[i] = "Cash";
                    }
                }
                HızlıSatışYap();
                MessageBoxManager.Unregister();
                MessageBoxManager.OK = "Tamam";
                MessageBoxManager.Register();
                MessageBox.Show("Ürün Satışı Yapılmıştır.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (File.Exists(Application.StartupPath + "\\Sepet.txt"))
                {
                    File.Delete(SepetUrl);
                }
                Hide();
            }
        }
    }
}

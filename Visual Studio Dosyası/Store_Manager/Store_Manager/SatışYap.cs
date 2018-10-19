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
    public partial class SatışYap : Form
    {
        public string SatışUrl = Application.StartupPath + "\\Satış.txt";
        string baglantiString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
        static string komutString = "";
        SqlConnection baglanti;
        SqlCommand komut;
        public static string kullanıcı = OturumAç.kullanıcıAdı;
        public static string SatanKisi_TC;
        public static string Hangisi;
        public static int enBuyuk;
        public static int Bizim;
        public static string durum = "OK";
        public SatışYap()
        {
            InitializeComponent();
        }
        public void MaxPuan()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT MAX(Customer_Point) AS MaxCustomer FROM Customer";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                enBuyuk=Int32.Parse(dr["MaxCustomer"].ToString());
            }
            baglanti.Close();
        }
        public void ÜyePuanı()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Customer WHERE Customer_TC_No='" + cmbBoxMüşteriAdıSoyadı.SelectedValue.ToString() + "'";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Bizim = Int32.Parse(dr["Customer_Point"].ToString());
            }
            baglanti.Close();
        }
        public void PuanEkle()
        {
            baglanti = new SqlConnection(baglantiString);
            if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }
            if (rBtnKrediKartı.Checked == true)
            {
                komutString = "UPDATE Customer SET Customer_Point=Customer_Point+@Customer_Point WHERE Customer_TC_No=@Customer_TC_No";
                komut = new SqlCommand(komutString, baglanti);
                komut.Parameters.AddWithValue("@Customer_Point", 2);
                komut.Parameters.AddWithValue("@Customer_TC_No", cmbBoxMüşteriAdıSoyadı.SelectedValue.ToString());
                komut.ExecuteNonQuery();
                baglanti.Dispose();
                baglanti.Close();
            }
            else if (rBtnPeşin.Checked == true)
            {
                komutString = "UPDATE Customer SET Customer_Point=Customer_Point+@Customer_Point WHERE Customer_TC_No=@Customer_TC_No";
                komut = new SqlCommand(komutString, baglanti);
                komut.Parameters.AddWithValue("@Customer_Point", 3);
                komut.Parameters.AddWithValue("@Customer_TC_No", cmbBoxMüşteriAdıSoyadı.SelectedValue.ToString());
                komut.ExecuteNonQuery();
                baglanti.Dispose();
                baglanti.Close();
            }
            else if (rBtnSenet.Checked == true)
            {
                komutString = "UPDATE Customer SET Customer_Point=Customer_Point+@Customer_Point WHERE Customer_TC_No=@Customer_TC_No";
                komut = new SqlCommand(komutString, baglanti);
                komut.Parameters.AddWithValue("@Customer_Point", 0);
                komut.Parameters.AddWithValue("@Customer_TC_No", cmbBoxMüşteriAdıSoyadı.SelectedValue.ToString());
                komut.ExecuteNonQuery();
                baglanti.Dispose();
                baglanti.Close();
            }
        }
        public void CalisanTCGetir()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Employee WHERE Employee_User_Name='" + kullanıcı + "'";
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
            komut.CommandText = "SELECT * FROM Manager WHERE Manager_User_Name='" + kullanıcı + "'";
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
        public void ToplamUcretOku()
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
                txtBoxToplamÜcret.Text = dr["Product_Price"].ToString();
            }
            baglanti.Close();
        }
        public void UcretGuncelle()
        {
            baglanti = new SqlConnection(baglantiString);
            if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }
            komutString = "UPDATE Product SET Product_Price=@Product_Price WHERE Product_No=@Product_No";
            komut = new SqlCommand(komutString, baglanti);
            komut.Parameters.AddWithValue("@Product_No", cmbBoxÜrünNumarası.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@Product_Price", txtBoxToplamÜcret.Text);
            komut.ExecuteNonQuery();
            baglanti.Dispose();
            baglanti.Close();
        }
        public void SatısYap()
        {
            baglanti = new SqlConnection(baglantiString);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            if (Hangisi == "Çalışan")
            {
                komutString = "INSERT INTO Sale (Sale_Date,Product_No,Employee_TC_No,Customer_TC_No,Total_Price,Sale_Type,Installment_No,Installment_Price) " +
                "VALUES (@Sale_Date,@Product_No,@Employee_TC_No,@Customer_TC_No,@Total_Price,@Sale_Type,@Installment_No,@Installment_Price)";
                komut = new SqlCommand(komutString, baglanti);
                komut.Parameters.AddWithValue("@Sale_Date", SqlDbType.DateTime).Value = DateTime.Now;
                komut.Parameters.AddWithValue("@Product_No", cmbBoxÜrünNumarası.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@Employee_TC_No", SatanKisi_TC);
                komut.Parameters.AddWithValue("@Customer_TC_No", cmbBoxMüşteriAdıSoyadı.SelectedValue.ToString());
                komut.Parameters.AddWithValue("@Total_Price", txtBoxToplamÜcret.Text);
                if (rBtnKrediKartı.Checked == true)
                {
                    komut.Parameters.AddWithValue("@Sale_Type", "Credit Card");
                    komut.Parameters.AddWithValue("@Installment_No", 0);
                    komut.Parameters.AddWithValue("@Installment_Price", 0);
                    komut.ExecuteNonQuery();
                    baglanti.Dispose();
                    baglanti.Close();
                }
                else if (rBtnPeşin.Checked == true)
                {
                    komut.Parameters.AddWithValue("@Sale_Type", "Cash");
                    komut.Parameters.AddWithValue("@Installment_No", 0);
                    komut.Parameters.AddWithValue("@Installment_Price", 0);
                    komut.ExecuteNonQuery();
                    baglanti.Dispose();
                    baglanti.Close();
                }
                else if (rBtnSenet.Checked == true)
                {
                    komut.Parameters.AddWithValue("@Sale_Type", "Bill");
                    komut.Parameters.AddWithValue("@Installment_No", txtBoxTaksitSayısı.Text);
                    int TP = Int32.Parse(txtBoxToplamÜcret.Text);
                    int IN = Int32.Parse(txtBoxTaksitSayısı.Text);
                    int R = TP/IN;
                    komut.Parameters.AddWithValue("@Installment_Price",R.ToString());
                    komut.ExecuteNonQuery();
                    baglanti.Dispose();
                    baglanti.Close();
                }
            }
            else if (Hangisi == "Yönetici")
            {
                komutString = "INSERT INTO Sale (Sale_Date,Product_No,Manager_TC_No,Customer_TC_No,Total_Price,Sale_Type,Installment_No,Installment_Price) " +
                "VALUES (@Sale_Date,@Product_No,@Manager_TC_No,@Customer_TC_No,@Total_Price,@Sale_Type,@Installment_No,@Installment_Price)";
                komut = new SqlCommand(komutString, baglanti);
                komut.Parameters.AddWithValue("@Sale_Date", SqlDbType.DateTime).Value = DateTime.Now;
                komut.Parameters.AddWithValue("@Product_No", cmbBoxÜrünNumarası.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@Manager_TC_No", SatanKisi_TC);
                komut.Parameters.AddWithValue("@Customer_TC_No", cmbBoxMüşteriAdıSoyadı.SelectedValue.ToString());
                komut.Parameters.AddWithValue("@Total_Price", txtBoxToplamÜcret.Text);
                if (rBtnKrediKartı.Checked == true)
                {
                    komut.Parameters.AddWithValue("@Sale_Type", "Credit Card");
                    komut.Parameters.AddWithValue("@Installment_No", 0);
                    komut.Parameters.AddWithValue("@Installment_Price", 0);
                    komut.ExecuteNonQuery();
                    baglanti.Dispose();
                    baglanti.Close();
                }
                else if (rBtnPeşin.Checked == true)
                {
                    komut.Parameters.AddWithValue("@Sale_Type", "Cash");
                    komut.Parameters.AddWithValue("@Installment_No", 0);
                    komut.Parameters.AddWithValue("@Installment_Price", 0);
                    komut.ExecuteNonQuery();
                    baglanti.Dispose();
                    baglanti.Close();
                }
                else if (rBtnSenet.Checked == true)
                {
                    komut.Parameters.AddWithValue("@Sale_Type", "Bill");
                    komut.Parameters.AddWithValue("@Installment_No", txtBoxTaksitSayısı.Text);
                    int TP = Int32.Parse(txtBoxToplamÜcret.Text);
                    int IN = Int32.Parse(txtBoxTaksitSayısı.Text);
                    int R = TP / IN; 
                    komut.Parameters.AddWithValue("@Installment_Price", R.ToString());
                    komut.ExecuteNonQuery();
                    baglanti.Dispose();
                    baglanti.Close();
                }
            }
        }
        public void BorcEkle()
        {
            baglanti = new SqlConnection(baglantiString);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komutString = "UPDATE Customer SET Customer_Debt=@Customer_Debt+Customer_Debt WHERE Customer_TC_No='" + cmbBoxMüşteriAdıSoyadı.SelectedValue.ToString() + "'";
            komut = new SqlCommand(komutString, baglanti);
            if (rBtnSenet.Checked == true)
            {
                komut.Parameters.AddWithValue("@Customer_Debt", txtBoxToplamÜcret.Text);
                komut.ExecuteNonQuery();
                baglanti.Dispose();
                baglanti.Close();
            }
            else
            {
                komut.Parameters.AddWithValue("@Customer_Debt", 0);
                komut.ExecuteNonQuery();
                baglanti.Dispose();
                baglanti.Close();
            }
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
        public void MağazadanÜrünüSil()
        {
            string conString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
            SqlConnection baglanti = new SqlConnection(conString);
            baglanti.Open();
            string kayit = "UPDATE Product SET Store_No=NULL WHERE Product_No='" + cmbBoxÜrünNumarası.SelectedItem.ToString() + "'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            ÜrünNumarasıVeriGetir();
        }
        private void SatışYap_Load(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            MüşteriTCNoVeriGetir();
            ÜrünNumarasıVeriGetir();
            txtBoxTaksitSayısı.Visible = false;
            CalisanTCGetir();
            YoneticiTCGetir();
            rBtnPeşin.Checked = true;
            if (Ayarlar.dil == "English")
            {
                Açıklama.SetToolTip(cmbBoxMüşteriAdıSoyadı, "Customer Name & Surname");
                Açıklama.SetToolTip(cmbBoxÜrünNumarası, "Product Number");
                Açıklama.SetToolTip(txtBoxTaksitSayısı, "Installment Number");
                Açıklama.SetToolTip(txtBoxToplamÜcret, "Total Price");
                cmbBoxMüşteriAdıSoyadı.Text = "Customer Name & Surname";
                cmbBoxÜrünNumarası.Text = "Product Number";
                txtBoxToplamÜcret.Text = "Total Price";
                lblSatışTürü.Text = "Sale Type:";
                rBtnKrediKartı.Text = "Credit Card";
                rBtnPeşin.Text = "Cash";
                rBtnSenet.Text = "Installment";
                txtBoxTaksitSayısı.Text = "Installment Number";
                btnSatışYap.Text = "Make Sale";
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                Açıklama.SetToolTip(cmbBoxMüşteriAdıSoyadı, "Müşteri Adı & Soyadı");
                Açıklama.SetToolTip(cmbBoxÜrünNumarası, "Ürün Numarası");
                Açıklama.SetToolTip(txtBoxTaksitSayısı, "Taksit Sayısı");
                Açıklama.SetToolTip(txtBoxToplamÜcret, "Toplam Ücret");
                cmbBoxMüşteriAdıSoyadı.Text = "Müşteri Adı & Soyadı";
                cmbBoxÜrünNumarası.Text = "Ürün Numarası";
                txtBoxToplamÜcret.Text = "Toplam Ücret";
                lblSatışTürü.Text = "Satış Türü:";
                rBtnKrediKartı.Text = "Kredi Kartı";
                rBtnPeşin.Text = "Peşin";
                rBtnSenet.Text = "Senet";
                txtBoxTaksitSayısı.Text = "Taksit Sayısı";
                btnSatışYap.Text = "Satış Yap";
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
        private void SatışYap_Activated(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            ÜrünNumarasıVeriGetir();
            txtBoxTaksitSayısı.Visible = false;
            rBtnPeşin.Checked = true;
            durum = "OK";
            if (Ayarlar.dil == "English")
            {
                Açıklama.SetToolTip(cmbBoxMüşteriAdıSoyadı, "Customer Name & Surname");
                Açıklama.SetToolTip(cmbBoxÜrünNumarası, "Product Number");
                Açıklama.SetToolTip(txtBoxTaksitSayısı, "Installment Number");
                Açıklama.SetToolTip(txtBoxToplamÜcret, "Total Price");
                cmbBoxMüşteriAdıSoyadı.Text = "Customer Name & Surname";
                cmbBoxÜrünNumarası.Text = "Product Number";
                txtBoxToplamÜcret.Text = "Total Price";
                lblSatışTürü.Text = "Sale Type:";
                rBtnKrediKartı.Text = "Credit Card";
                rBtnPeşin.Text = "Cash";
                rBtnSenet.Text = "Installment";
                txtBoxTaksitSayısı.Text = "Installment Number";
                btnSatışYap.Text = "Make Sale";
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                Açıklama.SetToolTip(cmbBoxMüşteriAdıSoyadı, "Müşteri Adı & Soyadı");
                Açıklama.SetToolTip(cmbBoxÜrünNumarası, "Ürün Numarası");
                Açıklama.SetToolTip(txtBoxTaksitSayısı, "Taksit Sayısı");
                Açıklama.SetToolTip(txtBoxToplamÜcret, "Toplam Ücret");
                cmbBoxMüşteriAdıSoyadı.Text = "Müşteri Adı & Soyadı";
                cmbBoxÜrünNumarası.Text = "Ürün Numarası";
                txtBoxToplamÜcret.Text = "Toplam Ücret";
                lblSatışTürü.Text = "Satış Türü:";
                rBtnKrediKartı.Text = "Kredi Kartı";
                rBtnPeşin.Text = "Peşin";
                rBtnSenet.Text = "Senet";
                txtBoxTaksitSayısı.Text = "Taksit Sayısı";
                btnSatışYap.Text = "Satış Yap";
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
        public void Yaz()
        {
            FileStream fs = new FileStream(SatışUrl, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(cmbBoxMüşteriAdıSoyadı.Text.ToString());
            sw.WriteLine(cmbBoxÜrünNumarası.SelectedIndex.ToString());
            sw.WriteLine(txtBoxToplamÜcret.Text);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        private void btnSatışYap_Click(object sender, EventArgs e)
        {
            if (Ayarlar.dil == "English")
            {
                MessageBoxManager.Unregister();
                MessageBoxManager.Yes = "Yes";
                MessageBoxManager.No = "No";
                MessageBoxManager.OK = "Tamam";
                MessageBoxManager.Register();
                MaxPuan();
                ÜyePuanı();
                if (Bizim>=enBuyuk && Bizim!=0)
                {
                    if (durum == "OK")
                    {
                        DialogResult secenek = MessageBox.Show("Are you sure you want to pay 5% discount to our loyal customer ?", "Warming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (secenek == DialogResult.No)
                        {
                            SatısYap();
                            BorcEkle();
                            UcretGuncelle();
                            MağazadanÜrünüSil();
                            PuanEkle();
                            MessageBox.Show("Product Sale Was Maded", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (secenek == DialogResult.Yes)
                        {
                            Yaz();
                            SatışYap satisYap = new SatışYap();
                            satisYap.MdiParent = ActiveForm;
                            satisYap.FormBorderStyle = FormBorderStyle.None;
                            satisYap.StartPosition = FormStartPosition.CenterParent;
                            satisYap.Dock = DockStyle.Fill;
                            satisYap.Show();
                            ListBox satışBox = new ListBox();
                            FileStream fs = new FileStream(SatışUrl, FileMode.Open, FileAccess.Read);
                            StreamReader sw = new StreamReader(fs);
                            string yazi = sw.ReadLine();
                            while (yazi != null)
                            {
                                satışBox.Items.Add(yazi);
                                yazi = sw.ReadLine();
                            }
                            if (satışBox.Items.Count != 0)
                            {
                                satisYap.cmbBoxMüşteriAdıSoyadı.Text = satışBox.Items[0].ToString();
                                satisYap.cmbBoxÜrünNumarası.SelectedIndex = Int32.Parse(satışBox.Items[1].ToString());
                                int ücret = Int32.Parse(satışBox.Items[2].ToString());
                                int yüzde = (ücret * 5) / 100;
                                ücret = ücret - yüzde;
                                int eklenecek = 5-(ücret % 5);
                                if ((ücret % 5) !=0 ) { ücret += eklenecek; }
                                satisYap.txtBoxToplamÜcret.Text = ücret.ToString();
                            }
                            fs.Close();
                            durum = "NOT OK";
                        }
                    }
                    else if(durum=="NOT OK")
                    {
                        SatısYap();
                        BorcEkle();
                        UcretGuncelle();
                        MağazadanÜrünüSil();
                        PuanEkle();
                        MessageBox.Show("Product Sale Was Maded", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (File.Exists(Application.StartupPath + "\\Satış.txt"))
                        {
                            File.Delete(Application.StartupPath + "\\Satış.txt");
                        }
                        Hide();
                    }
                }
                else if(Bizim<enBuyuk || Bizim==0)
                {
                    SatısYap();
                    BorcEkle();
                    UcretGuncelle();
                    MağazadanÜrünüSil();
                    PuanEkle();
                    MessageBox.Show("Product Sale Was Maded", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                MessageBoxManager.Unregister();
                MessageBoxManager.Yes = "Evet";
                MessageBoxManager.No = "Hayır";
                MessageBoxManager.OK = "Tamam";
                MessageBoxManager.Register();
                MaxPuan();
                ÜyePuanı();
                if (Bizim >= enBuyuk && Bizim != 0)
                {
                    if (durum == "OK")
                    {
                        DialogResult secenek = MessageBox.Show("Borcuna Sadık Müşterimize %5'lik İndirim Yapmak İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (secenek == DialogResult.No)
                        {
                            SatısYap();
                            BorcEkle();
                            UcretGuncelle();
                            MağazadanÜrünüSil();
                            PuanEkle();
                            MessageBox.Show("Ürün Satışı Yapılmıştır.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (secenek == DialogResult.Yes)
                        {
                            Yaz();
                            SatışYap satisYap = new SatışYap();
                            satisYap.MdiParent = ActiveForm;
                            satisYap.FormBorderStyle = FormBorderStyle.None;
                            satisYap.StartPosition = FormStartPosition.CenterParent;
                            satisYap.Dock = DockStyle.Fill;
                            satisYap.Show();
                            ListBox satışBox = new ListBox();
                            FileStream fs = new FileStream(SatışUrl, FileMode.Open, FileAccess.Read);
                            StreamReader sw = new StreamReader(fs);
                            string yazi = sw.ReadLine();
                            while (yazi != null)
                            {
                                satışBox.Items.Add(yazi);
                                yazi = sw.ReadLine();
                            }
                            if (satışBox.Items.Count != 0)
                            {
                                satisYap.cmbBoxMüşteriAdıSoyadı.Text = satışBox.Items[0].ToString();
                                satisYap.cmbBoxÜrünNumarası.SelectedIndex = Int32.Parse(satışBox.Items[1].ToString());
                                int ücret = Int32.Parse(satışBox.Items[2].ToString());
                                int yüzde = (ücret * 5) / 100;
                                ücret = ücret - yüzde;
                                int eklenecek = 5 - (ücret % 5);
                                if ((ücret % 5) != 0) { ücret += eklenecek; }
                                satisYap.txtBoxToplamÜcret.Text = ücret.ToString();
                            }
                            fs.Close();
                            durum = "NOT OK";
                        }
                    }
                    else if(durum=="NOT OK")
                    {
                        SatısYap();
                        BorcEkle();
                        UcretGuncelle();
                        MağazadanÜrünüSil();
                        PuanEkle();
                        MessageBox.Show("Ürün Satışı Yapılmıştır.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (File.Exists(Application.StartupPath + "\\Satış.txt"))
                        {
                            File.Delete(Application.StartupPath + "\\Satış.txt");
                        }
                        Hide();
                    }
                }
                else if (Bizim < enBuyuk || Bizim == 0)
                {
                    SatısYap();
                    BorcEkle();
                    UcretGuncelle();
                    MağazadanÜrünüSil();
                    PuanEkle();
                    MessageBox.Show("Ürün Satışı Yapılmıştır.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void cmbBoxÜrünNumarası_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToplamUcretOku();
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
    }
}

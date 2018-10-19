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
    public partial class BorçÖde : Form
    {
        string baglantiString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
        static string komutString = "";
        SqlConnection baglanti;
        SqlCommand komut;
        public static string SatışNumarası;
        public static string durum="";
        public static string ürünNumarası = "";
        public static string ToplamUcret= "";
        public static string ToplamTaksit= "";
        public static string TaksitUcret = "";
        public static string satışTarihi= "";
        public static int gün=0;
        public static ListBox ÜrünNoListBox = new ListBox();
        public static DateTime satış;
        public BorçÖde()
        {
            InitializeComponent();
        }
        public void GunHesapla()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678"; ;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Sale WHERE Product_No='" + cmbBoxÜrünNumarası.SelectedItem.ToString() + "'";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                satış = DateTime.Parse(dr["Sale_Date"].ToString());
                gün=GunFarkikBul(satış, DateTime.Now);
            }
            baglanti.Close();
        }
        public void GunHesaplaDahaÖnceBorcÖdenmisse()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678"; ;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Sale WHERE Product_No='" + cmbBoxÜrünNumarası.SelectedItem.ToString() + "'";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                satış = DateTime.Parse(dr["Sale_Date"].ToString());
                gün = GunFarkikBul(satış, DateTime.Now);
            }
            baglanti.Close();
        }
        public int GunFarkikBul(DateTime dt1, DateTime dt2)
        {
            TimeSpan zaman = new TimeSpan();
            zaman = dt1 - dt2;
            return Math.Abs(zaman.Days);
        }
        public void Puanla()
        {
            baglanti = new SqlConnection(baglantiString);
            if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }
            if (gün > 30)
            {
                komutString = "UPDATE Customer SET Customer_Point=Customer_Point-@Customer_Point WHERE Customer_TC_No=@Customer_TC_No";
                komut = new SqlCommand(komutString, baglanti);
                komut.Parameters.AddWithValue("@Customer_Point", 5);
                komut.Parameters.AddWithValue("@Customer_TC_No", cmbBoxMüşteriAdıSoyadı.SelectedValue.ToString());
                komut.ExecuteNonQuery();
                baglanti.Dispose();
                baglanti.Close();
            }
            else if (gün <= 30)
            {
                komutString = "UPDATE Customer SET Customer_Point=Customer_Point+@Customer_Point WHERE Customer_TC_No=@Customer_TC_No";
                komut = new SqlCommand(komutString, baglanti);
                komut.Parameters.AddWithValue("@Customer_Point", 5);
                komut.Parameters.AddWithValue("@Customer_TC_No", cmbBoxMüşteriAdıSoyadı.SelectedValue.ToString());
                komut.ExecuteNonQuery();
                baglanti.Dispose();
                baglanti.Close();
            }
        }
        public void MüşteriTCNoVeriGetir()
        {
            string baglan = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
            SqlConnection cnn = new SqlConnection();
            SqlDataAdapter adp = new SqlDataAdapter("SELECT Customer_TC_No,(Customer_Name + ' ' + Customer_Surname) AS CustomerNameSurname FROM Customer", baglan);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cmbBoxMüşteriAdıSoyadı.DisplayMember = "CustomerNameSurname";
            cmbBoxMüşteriAdıSoyadı.ValueMember = "Customer_TC_No";
            cmbBoxMüşteriAdıSoyadı.DataSource = dt;
        }
        public void SatısNumarasıVerileriGetir()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678"; ;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Sale WHERE Customer_TC_No='" + cmbBoxMüşteriAdıSoyadı.SelectedValue.ToString() + "' AND Installment_No<>0 AND Product_No='"+cmbBoxÜrünNumarası.SelectedItem.ToString()+"'";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SatışNumarası = (dr["Sale_No"].ToString());
            }
            baglanti.Close();
        }
        public void DahaOnceBorcOdenmis()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678"; ;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT D.*,S.* FROM Debt D INNER JOIN Sale S ON D.Sale_No=S.Sale_No WHERE D.Customer_TC_No='"+cmbBoxMüşteriAdıSoyadı.SelectedValue.ToString()+"' AND D.Sale_No='"+SatışNumarası+"' AND S.Product_No='"+cmbBoxÜrünNumarası.SelectedItem.ToString()+ "' AND D.Debt_Date=(SELECT MAX(Debt_Date) FROM Debt WHERE Sale_No='" + SatışNumarası + "')";
            //komut.CommandText = "SELECT * FROM Debt WHERE Customer_TC_No='" + cmbBoxMüşteriAdıSoyadı.SelectedValue.ToString() + "' AND Remaining_Installment_No<>0 AND Sale_No='" + SatışNumarası + "' AND Debt_Date=(SELECT MAX(Debt_Date) FROM Debt WHERE Sale_No='" + SatışNumarası + "')";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                ToplamUcret = dr["Remaining_Debt"].ToString();
                ToplamTaksit = dr["Remaining_Installment_No"].ToString();
                TaksitUcret = dr["Installment_Price"].ToString();
                satış = DateTime.Parse(dr["Debt_Date"].ToString());
                gün = GunFarkikBul(satış, DateTime.Now);
                txtBoxKalanBorç.Text = (Int32.Parse(ToplamUcret)- Int32.Parse(TaksitUcret)).ToString();
                txtBoxKalanTaksitSayısı.Text = (Int32.Parse(ToplamTaksit) - 1).ToString();
                baglanti.Close();
            }
            else
            {
                DahaOnceBorcOdenmemis();
            }
        }
        public void ÜrünNumarasıVerileriGetir()
        {
            ÜrünNoListBox.Items.Clear();
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678"; ;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Sale WHERE Customer_TC_No='" + cmbBoxMüşteriAdıSoyadı.SelectedValue.ToString() + "' AND Installment_No<>0";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ÜrünNoListBox.Items.Add(dr["Product_No"]);
                Kontrol();
            }
            baglanti.Close();
        }
        public void Kontrol()
        {
            for (int i = 0; i < ÜrünNoListBox.Items.Count; i = i + 1)
            {
                SqlConnection baglanti = new SqlConnection();
                baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678"; ;
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "SELECT S.*,D.* FROM Sale S INNER JOIN Debt D ON S.Sale_No=D.Sale_No WHERE S.Sale_Type='Bill' AND S.Customer_TC_No='" + cmbBoxMüşteriAdıSoyadı.SelectedValue.ToString() + "' AND S.Product_No='"+ ÜrünNoListBox.Items[i].ToString() + "' AND D.Remaining_Installment_No=0";
                komut.Connection = baglanti;
                komut.CommandType = CommandType.Text;
                SqlDataReader dr;
                baglanti.Open();
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    ÜrünNoListBox.Items.Remove(dr["Product_No"]);
                }
                baglanti.Close();
            }
        }
        public void ÖdenecekÜcret()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678"; ;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Sale WHERE Customer_TC_No='" + cmbBoxMüşteriAdıSoyadı.SelectedValue.ToString() + "' AND Product_No='" + cmbBoxÜrünNumarası.SelectedItem.ToString() + "'";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtBoxÖdenecekÜcret.Text = dr["Installment_Price"].ToString();
            }
            baglanti.Close();
        }
        public void DahaOnceBorcOdenmemis()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678"; ;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Sale WHERE Customer_TC_No='" + cmbBoxMüşteriAdıSoyadı.SelectedValue.ToString() + "' AND Product_No='" + cmbBoxÜrünNumarası.SelectedItem.ToString() + "'";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ToplamUcret = dr["Total_Price"].ToString();
                ToplamTaksit = dr["Installment_No"].ToString();
                TaksitUcret = dr["Installment_Price"].ToString();
                txtBoxKalanBorç.Text = (Int32.Parse(ToplamUcret) - Int32.Parse(TaksitUcret)).ToString();
                txtBoxKalanTaksitSayısı.Text = (Int32.Parse(ToplamTaksit) - 1).ToString();
            }
            baglanti.Close();
        }
        public void BorcOde()
        {
            baglanti = new SqlConnection(baglantiString);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            } 
            komutString = "UPDATE Customer SET Customer_Debt=Customer_Debt-@Customer_Debt FROM Customer C INNER JOIN Sale S ON C.Customer_TC_No = S.Customer_TC_No INNER JOIN Product P ON S.Product_No = P.Product_No WHERE C.Customer_TC_No ='" + cmbBoxMüşteriAdıSoyadı.SelectedValue.ToString() + "' AND P.Product_No='"+cmbBoxÜrünNumarası.SelectedItem.ToString()+"'";
            komut = new SqlCommand(komutString, baglanti);
            komut.Parameters.AddWithValue("@Customer_Debt", txtBoxÖdenecekÜcret.Text);
            komut.ExecuteNonQuery();
            baglanti.Dispose();
            baglanti.Close();
        }
        public void BorcBilgileriTut()
        {
            baglanti = new SqlConnection(baglantiString);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komutString = "INSERT INTO Debt(Debt_Date,Customer_TC_No,Sale_No,Remaining_Debt,Remaining_Installment_No,Installment_Price) " +
            "VALUES (@Debt_Date,@Customer_TC_No,@Sale_No,@Remaining_Debt,@Remaining_Installment_No,@Installment_Price)";
            komut = new SqlCommand(komutString, baglanti);
            komut.Parameters.AddWithValue("@Debt_Date", SqlDbType.DateTime).Value = DateTime.Now;
            komut.Parameters.AddWithValue("@Customer_TC_No", cmbBoxMüşteriAdıSoyadı.SelectedValue.ToString());
            komut.Parameters.AddWithValue("@Sale_No", SatışNumarası);
            komut.Parameters.AddWithValue("@Remaining_Debt", txtBoxKalanBorç.Text);
            komut.Parameters.AddWithValue("@Remaining_Installment_No", txtBoxKalanTaksitSayısı.Text);
            komut.Parameters.AddWithValue("@Installment_Price",txtBoxÖdenecekÜcret.Text);
            komut.ExecuteNonQuery();
            baglanti.Dispose();
            baglanti.Close();
        }
        private void BorçÖde_Load(object sender, EventArgs e)
        {
            MüşteriTCNoVeriGetir();
            cmbBoxÜrünNumarası.Items.Clear();
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            if (Ayarlar.dil == "English")
            {
                cmbBoxMüşteriAdıSoyadı.Text = "Customer Name & Surname";
                cmbBoxÜrünNumarası.Text = "Product Number";
                txtBoxÖdenecekÜcret.Text = "Amount Payable";
                txtBoxKalanTaksitSayısı.Text = "Remaining Number Of Installment";
                txtBoxKalanBorç.Text = "Remaining Debt";
                btnBorçÖde.Text = "Pay Debt";
                Açıklama.SetToolTip(cmbBoxMüşteriAdıSoyadı, "Customer Name & Surname");
                Açıklama.SetToolTip(cmbBoxÜrünNumarası, "Product Number");
                Açıklama.SetToolTip(txtBoxÖdenecekÜcret, "Amount Payable");
                Açıklama.SetToolTip(txtBoxKalanTaksitSayısı, "Remaining Number Of Installment");
                Açıklama.SetToolTip(txtBoxKalanBorç, "Remaining Debt");
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                cmbBoxMüşteriAdıSoyadı.Text = "Müşteri Adı & Soyadı";
                cmbBoxÜrünNumarası.Text = "Ürün Numarası";
                txtBoxÖdenecekÜcret.Text = "Ödenecek Ücret";
                txtBoxKalanTaksitSayısı.Text = "Kalan Taksit Sayısı";
                txtBoxKalanBorç.Text = "Kalan Borç";
                btnBorçÖde.Text = "Borç Öde";
                Açıklama.SetToolTip(cmbBoxMüşteriAdıSoyadı, "Müşteri Adı & Soyadı");
                Açıklama.SetToolTip(cmbBoxÜrünNumarası, "Ürün Numarası");
                Açıklama.SetToolTip(txtBoxÖdenecekÜcret, "Ödenecek Ücret");
                Açıklama.SetToolTip(txtBoxKalanTaksitSayısı, "Kalan Taksit Sayısı");
                Açıklama.SetToolTip(txtBoxKalanBorç, "Kalan Borç");
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
        private void BorçÖde_Activated(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            if (Ayarlar.dil == "English")
            {
                cmbBoxMüşteriAdıSoyadı.Text = "Customer Name & Surname";
                cmbBoxÜrünNumarası.Text = "Product Number";
                txtBoxÖdenecekÜcret.Text = "Amount Payable";
                txtBoxKalanTaksitSayısı.Text = "Remaining Number Of Installment";
                txtBoxKalanBorç.Text = "Remaining Debt";
                btnBorçÖde.Text = "Pay Debt";
                Açıklama.SetToolTip(cmbBoxMüşteriAdıSoyadı, "Customer Name & Surname");
                Açıklama.SetToolTip(cmbBoxÜrünNumarası, "Product Number");
                Açıklama.SetToolTip(txtBoxÖdenecekÜcret, "Amount Payable");
                Açıklama.SetToolTip(txtBoxKalanTaksitSayısı, "Remaining Number Of Installment");
                Açıklama.SetToolTip(txtBoxKalanBorç, "Remaining Debt");
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                cmbBoxMüşteriAdıSoyadı.Text = "Müşteri Adı & Soyadı";
                cmbBoxÜrünNumarası.Text = "Ürün Numarası";
                txtBoxÖdenecekÜcret.Text = "Ödenecek Ücret";
                txtBoxKalanTaksitSayısı.Text = "Kalan Taksit Sayısı";
                txtBoxKalanBorç.Text = "Kalan Borç";
                btnBorçÖde.Text = "Borç Öde";
                Açıklama.SetToolTip(cmbBoxMüşteriAdıSoyadı, "Müşteri Adı & Soyadı");
                Açıklama.SetToolTip(cmbBoxÜrünNumarası, "Ürün Numarası");
                Açıklama.SetToolTip(txtBoxÖdenecekÜcret, "Ödenecek Ücret");
                Açıklama.SetToolTip(txtBoxKalanTaksitSayısı, "Kalan Taksit Sayısı");
                Açıklama.SetToolTip(txtBoxKalanBorç, "Kalan Borç");
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
        private void cmbBoxMüşteriAdıSoyadı_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ayarlar.dil == "English")
            {
                cmbBoxÜrünNumarası.Text = "Product Number";
                txtBoxÖdenecekÜcret.Text = "Amount Payable";
                txtBoxKalanTaksitSayısı.Text = "Remaining Number Of Installment";
                txtBoxKalanBorç.Text = "Remaining Debt";
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                cmbBoxÜrünNumarası.Text = "Ürün Numarası";
                txtBoxÖdenecekÜcret.Text = "Ödenecek Ücret";
                txtBoxKalanTaksitSayısı.Text = "Kalan Taksit Sayısı";
                txtBoxKalanBorç.Text = "Kalan Borç";
            }
            ÜrünNumarasıVerileriGetir();
            cmbBoxÜrünNumarası.Items.Clear();
            for(int i = 0; i < ÜrünNoListBox.Items.Count; i++)
            {
                cmbBoxÜrünNumarası.Items.Add(ÜrünNoListBox.Items[i].ToString());
            }
        }
        private void cmbBoxÜrünNumarası_SelectedIndexChanged(object sender, EventArgs e)
        {
            SatısNumarasıVerileriGetir();
            ÖdenecekÜcret();
            DahaOnceBorcOdenmis();
            GunHesapla();
        }
        private void btnBorçÖde_Click(object sender, EventArgs e)
        {
            if (Ayarlar.dil == "English")
            {
                BorcOde();
                BorcBilgileriTut();
                Puanla();
                MessageBoxManager.Unregister();
                MessageBoxManager.OK = "OK";
                MessageBoxManager.Register();
                MessageBox.Show("Debt Payment Was Maded", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                BorcOde();
                BorcBilgileriTut();
                Puanla();
                MessageBoxManager.Unregister();
                MessageBoxManager.OK = "Tamam";
                MessageBoxManager.Register();
                MessageBox.Show("Borç Ödemesi Yapılmıştır.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

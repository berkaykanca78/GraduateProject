using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Manager
{
    public partial class YöneticiAnaMenü : Form
    {
        public static string kullanıcı = OturumAç.kullanıcıAdı;
        public int ayarlayıcıSayaç = 0;
        public static bool menuAyar = false;
        public static string durum = "";
        public static string ürün = "";
        public static string ürün2 = "";
        public static string yer = "";
        MüşteriEkle musteriEkle = new MüşteriEkle();
        MüşterileriGöster musterileriGoster = new MüşterileriGöster();
        ShowCustomers showCustomers = new ShowCustomers();
        DepoyaÜrünEkle urunEkle = new DepoyaÜrünEkle();
        DepodakiÜrünleriGöster depodakiUrunleriGoster = new DepodakiÜrünleriGöster();
        MağazayaÜrünEkle magazayaUrunEkle = new MağazayaÜrünEkle();
        MağazadakiÜrünleriGöster magazadakiUrunleriGoster = new MağazadakiÜrünleriGöster();
        TedarikçiEkle tedarikciEkle = new TedarikçiEkle();
        TedarikçileriGöster tedarikcileriGoster = new TedarikçileriGöster();
        MağazaEkle magazaEkle = new MağazaEkle();
        SatışYap satisYap = new SatışYap();
        BorçÖde borcOde = new BorçÖde();
        BorçTakibi borcTakibi = new BorçTakibi();
        DebtFollowUp debtFollowUp = new DebtFollowUp();
        ShowSuppliers showSuppliers = new ShowSuppliers();
        ShowProductsInWarehouse showProductsInWarehouse = new ShowProductsInWarehouse();
        ShowProductsInStore showProductsInStore = new ShowProductsInStore();
        DepoEkle depoEkle = new DepoEkle();
        SatılanÜrünleriGöster satılanÜrünleriGöster = new SatılanÜrünleriGöster();
        ShowSoldProducts showSoldProducts = new ShowSoldProducts();
        AlarmMailGönder alarm = new AlarmMailGönder();
        public YöneticiAnaMenü()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        public void AlarmMağazaKontrol()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT Product_Name, COUNT(Product_Name) AS Repeat FROM Product WHERE Store_No IS NOT Null AND Store_Mail=0 GROUP BY Product_Name HAVING(COUNT(Product_Name) > 1)";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ListBox listRepeat = new ListBox();
                listRepeat.Items.Add(dr["Product_Name"].ToString());
                listRepeat.Items.Add(dr["Repeat"].ToString());
                for (int i = 0; i < listRepeat.Items.Count; i++)
                {
                    if (("3") == listRepeat.Items[i].ToString())
                    {
                        hatırlatıcı2.Icon = new Icon(Application.StartupPath + "\\Error.ico");
                        if (Ayarlar.dil == "Türkçe")
                        {
                            hatırlatıcı2.ShowBalloonTip(5000, "Önemli", listRepeat.Items[i - 1].ToString() + "'den Mağazada 3 tane kaldı.", ToolTipIcon.Info);
                            ürün2 = listRepeat.Items[i - 1].ToString();
                        }
                        else if (Ayarlar.dil == "English")
                        {
                            hatırlatıcı2.ShowBalloonTip(5000, "Important", listRepeat.Items[i - 1].ToString() + " products left 3 in Store.", ToolTipIcon.Info);
                            ürün2 = listRepeat.Items[i - 1].ToString();
                        }
                    }
                }
            }
            baglanti.Close();
        }
        public void AlarmDepoKontrol()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=LAPTOP-8FMK7RPK;Initial Catalog=Store_Manager;Persist Security Info=True;User ID=sa;Password=Berkay_678";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT Product_Name, COUNT(Product_Name) AS Repeat FROM Product WHERE Warehouse_No IS NOT Null AND Warehouse_Mail=0 GROUP BY Product_Name HAVING(COUNT(Product_Name) > 1)";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ListBox listRepeat = new ListBox();
                listRepeat.Items.Add(dr["Product_Name"].ToString());
                listRepeat.Items.Add(dr["Repeat"].ToString());
                for (int i = 0; i < listRepeat.Items.Count; i++)
                {
                    if (("5") == listRepeat.Items[i].ToString())
                    {
                        hatırlatıcı.Icon = new Icon(Application.StartupPath + "\\Error.ico");
                        if (Ayarlar.dil == "Türkçe")
                        {
                            hatırlatıcı.ShowBalloonTip(5000, "Önemli", listRepeat.Items[i - 1].ToString() + "'den Depoda 5 tane kaldı.", ToolTipIcon.Info);
                            ürün = listRepeat.Items[i - 1].ToString();
                        }
                        else if (Ayarlar.dil == "English")
                        {
                            hatırlatıcı.ShowBalloonTip(5000, "Important", listRepeat.Items[i - 1].ToString() + " products left 5 in Warehouse.", ToolTipIcon.Info);
                            ürün = listRepeat.Items[i - 1].ToString();
                        }
                    }
                }
            }
            baglanti.Close();
        }
        private void YöneticiAnaMenü_Load(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            lblKulAdı.Text = "[" + OturumAç.kullanıcıAdı + "]";
            AlarmMağazaKontrol();
            AlarmDepoKontrol();
            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = false;
            musteriEkle.Hide();
            musterileriGoster.Hide();
            urunEkle.Hide();
            depodakiUrunleriGoster.Hide();
            magazayaUrunEkle.Hide();
            magazadakiUrunleriGoster.Hide();
            tedarikciEkle.Hide();
            tedarikcileriGoster.Hide();
            depoEkle.Hide();
            magazaEkle.Hide();
            satisYap.Hide();
            borcOde.Hide();
            borcTakibi.Hide();
            debtFollowUp.Hide();
            showCustomers.Hide();
            showSuppliers.Hide();
            showProductsInWarehouse.Hide();
            showProductsInStore.Hide();
            satılanÜrünleriGöster.Hide();
            showSoldProducts.Hide();
            alarm.Hide();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    if (Ayarlar.tema == "Varsayılan")
                    {
                        ctrl.BackColor = Color.FromArgb(37, 46, 59);
                    }
                    else if (Ayarlar.tema == "Kırmızı")
                    {
                        ctrl.BackColor = Color.Red;
                    }
                    else if (Ayarlar.tema == "Mavi")
                    {
                        ctrl.BackColor = Color.Blue;
                    }
                    else if (Ayarlar.tema == "Yeşil")
                    {
                        ctrl.BackColor = Color.Green;
                    }
                }
            }
            menuAyar = true;
            if (Ayarlar.dil == "English")
            {
                Açıklama.SetToolTip(picBoxAyarlar, "Settings");
                Açıklama.SetToolTip(picBoxÇıkış, "Exit");
                Açıklama.SetToolTip(picBoxHızlıSatış, "Quick Sale");
                Açıklama.SetToolTip(picBoxOturumKapat, "Log Out");
                lblAnaMenü.Text = "Main Menu";
                btnDepo.Text = "Warehouse";
                btnMağaza.Text = "Store";
                btnMüşteri.Text = "Customer";
                btnSatış.Text = "Sales";
                btnTedarikçi.Text = "Supplier";
                btnÜrün.Text = "Product";
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                Açıklama.SetToolTip(picBoxAyarlar, "Ayarlar");
                Açıklama.SetToolTip(picBoxÇıkış, "Çıkış");
                Açıklama.SetToolTip(picBoxHızlıSatış, "Hızlı Satış");
                Açıklama.SetToolTip(picBoxOturumKapat, "Oturum Kapat");
                lblAnaMenü.Text = "Ana Menü";
                btnDepo.Text = "Depo";
                btnMağaza.Text = "Mağaza";
                btnMüşteri.Text = "Müşteri";
                btnSatış.Text = "Satış";
                btnTedarikçi.Text = "Tedarikçi";
                btnÜrün.Text = "Ürün";
            }
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
                    this.zamanlayıcı.Enabled = false;
                }
                else
                {
                    panelSol.Width = 50;
                    btn1.Left = 70;
                    btn2.Left = 300;
                }
                lblAnaMenü.Text = "";
            }
            else if (ayarlayıcıSayaç % 2 == 0)
            {
                if (panelSol.Width != 50)
                {
                    this.zamanlayıcı.Enabled = false;
                }
                else
                {
                    panelSol.Width = 149;
                    if (Ayarlar.dil == "Türkçe")
                    {
                        lblAnaMenü.Text = "Ana Menü";
                        btn1.Left = 170;
                        btn2.Left = 350;
                    }
                    else if (Ayarlar.dil == "English")
                    {
                        lblAnaMenü.Text = "Main Menu";
                        btn1.Left = 170;
                        btn2.Left = 350;
                    }
                }
            }
            zamanlayıcı.Enabled = false;
        }
        private void picBoxAyarlar_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show();
            menuAyar = true;
        }
        private void YöneticiAnaMenü_Activated(object sender, EventArgs e)
        {
            Açıklama.ToolTipIcon = ToolTipIcon.Info;
            Açıklama.IsBalloon = true;
            lblKulAdı.Text = "[" + OturumAç.kullanıcıAdı + "]";
            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = false;
            musteriEkle.Hide();
            musterileriGoster.Hide();
            urunEkle.Hide();
            depodakiUrunleriGoster.Hide();
            magazayaUrunEkle.Hide();
            magazadakiUrunleriGoster.Hide();
            tedarikciEkle.Hide();
            tedarikcileriGoster.Hide();
            depoEkle.Hide();
            magazaEkle.Hide();
            satisYap.Hide();
            borcOde.Hide();
            borcTakibi.Hide();
            debtFollowUp.Hide();
            showCustomers.Hide();
            showSuppliers.Hide();
            showProductsInWarehouse.Hide();
            showProductsInStore.Hide();
            satılanÜrünleriGöster.Hide();
            showSoldProducts.Hide();
            alarm.Hide();
            AlarmMağazaKontrol();
            AlarmDepoKontrol();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    if (Ayarlar.tema == "Varsayılan")
                    {
                        ctrl.BackColor = Color.FromArgb(37, 46, 59);
                    }
                    else if (Ayarlar.tema == "Kırmızı")
                    {
                        ctrl.BackColor = Color.Red;
                    }
                    else if (Ayarlar.tema == "Mavi")
                    {
                        ctrl.BackColor = Color.Blue;
                    }
                    else if (Ayarlar.tema == "Yeşil")
                    {
                        ctrl.BackColor = Color.Green;
                    }
                }
            }
            if (Ayarlar.dil == "English")
            {
                Açıklama.SetToolTip(picBoxAyarlar, "Settings");
                Açıklama.SetToolTip(picBoxÇıkış, "Exit");
                Açıklama.SetToolTip(picBoxHızlıSatış, "Quick Sale");
                Açıklama.SetToolTip(picBoxOturumKapat, "Log Out");
                lblAnaMenü.Text = "Main Menu";
                btnDepo.Text = "Warehouse";
                btnMağaza.Text = "Store";
                btnMüşteri.Text = "Customer";
                btnSatış.Text = "Sales";
                btnTedarikçi.Text = "Supplier";
                btnÜrün.Text = "Product";
                if (Ayarlar.tema == "Varsayılan")
                {
                    panelSol.BackColor = Color.FromArgb(26, 32, 40);
                    panelÜst.BackColor = Color.LightGray;
                    btnDepo.BackColor = Color.FromArgb(26, 32, 40);
                    btnMağaza.BackColor = Color.FromArgb(26, 32, 40);
                    btnMüşteri.BackColor = Color.FromArgb(26, 32, 40);
                    btnSatış.BackColor = Color.FromArgb(26, 32, 40);
                    btnTedarikçi.BackColor = Color.FromArgb(26, 32, 40);
                    btnÜrün.BackColor = Color.FromArgb(26, 32, 40);
                }
                else if (Ayarlar.tema == "Kırmızı")
                {
                    panelSol.BackColor = Color.DarkRed;
                    panelÜst.BackColor = Color.LightGray;
                    btnDepo.BackColor = Color.DarkRed;
                    btnMağaza.BackColor = Color.DarkRed;
                    btnMüşteri.BackColor = Color.DarkRed;
                    btnSatış.BackColor = Color.DarkRed;
                    btnTedarikçi.BackColor = Color.DarkRed;
                    btnÜrün.BackColor = Color.DarkRed;
                }
                else if (Ayarlar.tema == "Mavi")
                {
                    panelSol.BackColor = Color.DarkBlue;
                    panelÜst.BackColor = Color.FromName("ActiveCaption");
                    btnDepo.BackColor = Color.DarkBlue;
                    btnMağaza.BackColor = Color.DarkBlue;
                    btnMüşteri.BackColor = Color.DarkBlue;
                    btnSatış.BackColor = Color.DarkBlue;
                    btnTedarikçi.BackColor = Color.DarkBlue;
                    btnÜrün.BackColor = Color.DarkBlue;
                }
                else if (Ayarlar.tema == "Yeşil")
                {
                    panelSol.BackColor = Color.DarkGreen;
                    panelÜst.BackColor = Color.LightGray;
                    btnDepo.BackColor = Color.DarkGreen;
                    btnMağaza.BackColor = Color.DarkGreen;
                    btnMüşteri.BackColor = Color.DarkGreen;
                    btnSatış.BackColor = Color.DarkGreen;
                    btnTedarikçi.BackColor = Color.DarkGreen;
                    btnÜrün.BackColor = Color.DarkGreen;
                }
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                Açıklama.SetToolTip(picBoxAyarlar, "Ayarlar");
                Açıklama.SetToolTip(picBoxÇıkış, "Çıkış");
                Açıklama.SetToolTip(picBoxHızlıSatış, "Hızlı Satış");
                Açıklama.SetToolTip(picBoxOturumKapat, "Oturum Kapat");
                lblAnaMenü.Text = "Ana Menü";
                btnDepo.Text = "Depo";
                btnMağaza.Text = "Mağaza";
                btnMüşteri.Text = "Müşteri";
                btnSatış.Text = "Satış";
                btnTedarikçi.Text = "Tedarikçi";
                btnÜrün.Text = "Ürün";
                if (Ayarlar.tema == "Varsayılan")
                {
                    panelSol.BackColor = Color.FromArgb(26, 32, 40);
                    panelÜst.BackColor = Color.LightGray;
                    btnDepo.BackColor = Color.FromArgb(26, 32, 40);
                    btnMağaza.BackColor = Color.FromArgb(26, 32, 40);
                    btnMüşteri.BackColor = Color.FromArgb(26, 32, 40);
                    btnSatış.BackColor = Color.FromArgb(26, 32, 40);
                    btnTedarikçi.BackColor = Color.FromArgb(26, 32, 40);
                    btnÜrün.BackColor = Color.FromArgb(26, 32, 40);
                }
                else if (Ayarlar.tema == "Kırmızı")
                {
                    panelSol.BackColor = Color.DarkRed;
                    panelÜst.BackColor = Color.LightGray;
                    btnDepo.BackColor = Color.DarkRed;
                    btnMağaza.BackColor = Color.DarkRed;
                    btnMüşteri.BackColor = Color.DarkRed;
                    btnSatış.BackColor = Color.DarkRed;
                    btnTedarikçi.BackColor = Color.DarkRed;
                    btnÜrün.BackColor = Color.DarkRed;
                }
                else if (Ayarlar.tema == "Mavi")
                {
                    panelSol.BackColor = Color.DarkBlue;
                    panelÜst.BackColor = Color.FromName("ActiveCaption");
                    btnDepo.BackColor = Color.DarkBlue;
                    btnMağaza.BackColor = Color.DarkBlue;
                    btnMüşteri.BackColor = Color.DarkBlue;
                    btnSatış.BackColor = Color.DarkBlue;
                    btnTedarikçi.BackColor = Color.DarkBlue;
                    btnÜrün.BackColor = Color.DarkBlue;
                }
                else if (Ayarlar.tema == "Yeşil")
                {
                    panelSol.BackColor = Color.DarkGreen;
                    panelÜst.BackColor = Color.LightGray;
                    btnDepo.BackColor = Color.DarkGreen;
                    btnMağaza.BackColor = Color.DarkGreen;
                    btnMüşteri.BackColor = Color.DarkGreen;
                    btnSatış.BackColor = Color.DarkGreen;
                    btnTedarikçi.BackColor = Color.DarkGreen;
                    btnÜrün.BackColor = Color.DarkGreen;
                }
            }
            if (ayarlayıcıSayaç % 2 == 1)
            {
                lblAnaMenü.Text = "";
            }
        }
        private void picBoxOturumKapat_Click(object sender, EventArgs e)
        {
            picBoxOturumKapat.Focus();
            if (Ayarlar.dil == "English")
            {
                DialogResult secenek = MessageBox.Show("Are You Sure Want To Sign Out ?", "Warming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secenek == DialogResult.Yes)
                {
                    Properties.Settings.Default["kullanıcıAdı"] = "";
                    Properties.Settings.Default["şifre"] = "";
                    Properties.Settings.Default["yetki"] = "";
                    Properties.Settings.Default.Save();
                    OturumAç oturumAç = new OturumAç();
                    this.Hide();
                    oturumAç.Show();
                    menuAyar = false;
                    if (File.Exists(Application.StartupPath + "\\Satış.txt"))
                    {
                        File.Delete(Application.StartupPath + "\\Satış.txt");
                    }
                    if (File.Exists(Application.StartupPath + "\\Sepet.txt"))
                    {
                        File.Delete(Application.StartupPath + "\\Sepet.txt");
                    }
                }
                else if (secenek == DialogResult.No)
                {
                    picBoxOturumKapat.Focus();
                }
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                DialogResult secenek = MessageBox.Show("Oturumunuzu Kapatmak İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secenek == DialogResult.Yes)
                {
                    Properties.Settings.Default["kullanıcıAdı"] = "";
                    Properties.Settings.Default["şifre"] = "";
                    Properties.Settings.Default["yetki"] = "";
                    Properties.Settings.Default.Save();
                    OturumAç oturumAç = new OturumAç();
                    this.Hide();
                    oturumAç.Show();
                    menuAyar = false;
                    if (File.Exists(Application.StartupPath + "\\Satış.txt"))
                    {
                        File.Delete(Application.StartupPath + "\\Satış.txt");
                    }
                    if (File.Exists(Application.StartupPath + "\\Sepet.txt"))
                    {
                        File.Delete(Application.StartupPath + "\\Sepet.txt");
                    }
                }
                else if (secenek == DialogResult.No)
                {
                    picBoxOturumKapat.Focus();
                }
            }
        }
        private void picBoxÇıkış_Click(object sender, EventArgs e)
        {
            picBoxÇıkış.Focus();
            if (Ayarlar.dil == "English")
            {
                DialogResult secenek = MessageBox.Show("Are You Sure Want To Exit From Program ?", "Warming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secenek == DialogResult.Yes)
                {
                    Application.Exit();
                    if (File.Exists(Application.StartupPath + "\\Satış.txt"))
                    {
                        File.Delete(Application.StartupPath + "\\Satış.txt");
                    }
                    if (File.Exists(Application.StartupPath + "\\Sepet.txt"))
                    {
                        File.Delete(Application.StartupPath + "\\Sepet.txt");
                    }
                }
            }
            else if (Ayarlar.dil == "Türkçe")
            {
                DialogResult secenek = MessageBox.Show("Programı Kapatmak İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secenek == DialogResult.Yes)
                {
                    Application.Exit();
                    if (File.Exists(Application.StartupPath + "\\Satış.txt"))
                    {
                        File.Delete(Application.StartupPath + "\\Satış.txt");
                    }
                    if (File.Exists(Application.StartupPath + "\\Sepet.txt"))
                    {
                        File.Delete(Application.StartupPath + "\\Sepet.txt");
                    }
                }
            }
        }
        private void picBoxHızlıSatış_Click(object sender, EventArgs e)
        {
            HızlıSatış hızlısatış = new HızlıSatış();
            hızlısatış.Show();
        }
        private void btnMüşteri_Click(object sender, EventArgs e)
        {
            btn1.Visible = true;
            btn2.Visible = false;
            btn3.Visible = true;
            if (Ayarlar.dil == "Türkçe")
            {
                btn1.Text = "Müşteri Ekle";
                btn3.Text = "Müşterileri Göster";
            }
            else if (Ayarlar.dil == "English")
            {
                btn1.Text = "Add Customer";
                btn3.Text = "Show Customers";
            }
            musteriEkle.Hide();
            musterileriGoster.Hide();
            urunEkle.Hide();
            depodakiUrunleriGoster.Hide();
            magazayaUrunEkle.Hide();
            magazadakiUrunleriGoster.Hide();
            tedarikciEkle.Hide();
            tedarikcileriGoster.Hide();
            depoEkle.Hide();
            magazaEkle.Hide();
            satisYap.Hide();
            borcOde.Hide();
            borcTakibi.Hide();
            debtFollowUp.Hide();
            showCustomers.Hide();
            showSuppliers.Hide();
            showProductsInWarehouse.Hide();
            showProductsInStore.Hide();
            satılanÜrünleriGöster.Hide();
            showSoldProducts.Hide();
            alarm.Hide();
        }
        private void btnÜrün_Click(object sender, EventArgs e)
        {
            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            if (Ayarlar.dil == "Türkçe")
            {
                btn1.Text = "Depoya Ürün Ekle";
                btn2.Text = "Depodan Mağazaya Ürün Ekle";
                btn3.Text = "Satılan Ürünleri Göster";
            }
            else if (Ayarlar.dil == "English")
            {
                btn1.Text = "Add Product To Warehouse";
                btn2.Text = "Add Product From Warehouse To Store";
                btn3.Text = "Show Sold Products";
            }
            musteriEkle.Hide();
            musterileriGoster.Hide();
            urunEkle.Hide();
            depodakiUrunleriGoster.Hide();
            magazayaUrunEkle.Hide();
            magazadakiUrunleriGoster.Hide();
            tedarikciEkle.Hide();
            tedarikcileriGoster.Hide();
            depoEkle.Hide();
            magazaEkle.Hide();
            satisYap.Hide();
            borcOde.Hide();
            borcTakibi.Hide();
            debtFollowUp.Hide();
            showCustomers.Hide();
            showSuppliers.Hide();
            showProductsInWarehouse.Hide();
            showProductsInStore.Hide();
            satılanÜrünleriGöster.Hide();
            showSoldProducts.Hide();
            alarm.Hide();
        }
        private void btnDepo_Click(object sender, EventArgs e)
        {
            btn1.Visible = true;
            btn2.Visible = false;
            btn3.Visible = true;
            if (Ayarlar.dil == "Türkçe")
            {
                btn1.Text = "Depo Ekle";
                btn3.Text = "Depodaki Ürünleri Göster";
            }
            else if (Ayarlar.dil == "English")
            {
                btn1.Text = "Add Warehouse";
                btn3.Text = "Show Products In Warehouse";
            }
            musteriEkle.Hide();
            musterileriGoster.Hide();
            urunEkle.Hide();
            depodakiUrunleriGoster.Hide();
            magazayaUrunEkle.Hide();
            magazadakiUrunleriGoster.Hide();
            tedarikciEkle.Hide();
            tedarikcileriGoster.Hide();
            depoEkle.Hide();
            magazaEkle.Hide();
            satisYap.Hide();
            borcOde.Hide();
            borcTakibi.Hide();
            debtFollowUp.Hide();
            showCustomers.Hide();
            showSuppliers.Hide();
            showProductsInWarehouse.Hide();
            showProductsInStore.Hide();
            satılanÜrünleriGöster.Hide();
            showSoldProducts.Hide();
            alarm.Hide();
        }
        private void btnMağaza_Click(object sender, EventArgs e)
        {
            btn1.Visible = true;
            btn2.Visible = false;
            btn3.Visible = true;
            if (Ayarlar.dil == "Türkçe")
            {
                btn1.Text = "Mağaza Ekle";
                btn3.Text = "Mağazadaki Ürünleri Göster";
            }
            else if (Ayarlar.dil == "English")
            {
                btn1.Text = "Add Store";
                btn3.Text = "Show Products In Store";
            }
            musteriEkle.Hide();
            musterileriGoster.Hide();
            urunEkle.Hide();
            depodakiUrunleriGoster.Hide();
            magazayaUrunEkle.Hide();
            magazadakiUrunleriGoster.Hide();
            tedarikciEkle.Hide();
            tedarikcileriGoster.Hide();
            depoEkle.Hide();
            magazaEkle.Hide();
            satisYap.Hide();
            borcOde.Hide();
            borcTakibi.Hide();
            debtFollowUp.Hide();
            showCustomers.Hide();
            showSuppliers.Hide();
            showProductsInWarehouse.Hide();
            showProductsInStore.Hide();
            satılanÜrünleriGöster.Hide();
            showSoldProducts.Hide();
            alarm.Hide();
        }
        private void btnTedarikçi_Click(object sender, EventArgs e)
        {
            btn1.Visible = true;
            btn2.Visible = false;
            btn3.Visible = true;
            if (Ayarlar.dil == "Türkçe")
            {
                btn1.Text = "Tedarikçi Ekle";
                btn3.Text = "Tedarikçileri Göster";
            }
            else if (Ayarlar.dil == "English")
            {
                btn1.Text = "Add Supplier";
                btn3.Text = "Show Suppliers";
            }
            musteriEkle.Hide();
            musterileriGoster.Hide();
            urunEkle.Hide();
            depodakiUrunleriGoster.Hide();
            magazayaUrunEkle.Hide();
            magazadakiUrunleriGoster.Hide();
            tedarikciEkle.Hide();
            tedarikcileriGoster.Hide();
            depoEkle.Hide();
            magazaEkle.Hide();
            satisYap.Hide();
            borcOde.Hide();
            borcTakibi.Hide();
            debtFollowUp.Hide();
            showCustomers.Hide();
            showSuppliers.Hide();
            showProductsInWarehouse.Hide();
            showProductsInStore.Hide();
            satılanÜrünleriGöster.Hide();
            showSoldProducts.Hide();
            alarm.Hide();
        }
        private void btnSatış_Click(object sender, EventArgs e)
        {
            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            if (Ayarlar.dil == "Türkçe")
            {
                btn1.Text = "Satış Yap";
                btn2.Text = "Borç Öde";
                btn3.Text = "Borç Takibi";
            }
            else if (Ayarlar.dil == "English")
            {
                btn1.Text = "Make Sale";
                btn2.Text = "Pay Debt";
                btn3.Text = "Debt Follow Up";
            }
            musteriEkle.Hide();
            musterileriGoster.Hide();
            urunEkle.Hide();
            depodakiUrunleriGoster.Hide();
            magazayaUrunEkle.Hide();
            magazadakiUrunleriGoster.Hide();
            tedarikciEkle.Hide();
            tedarikcileriGoster.Hide();
            depoEkle.Hide();
            magazaEkle.Hide();
            satisYap.Hide();
            borcOde.Hide();
            borcTakibi.Hide();
            debtFollowUp.Hide();
            showCustomers.Hide();
            showSuppliers.Hide();
            showProductsInWarehouse.Hide();
            showProductsInStore.Hide();
            satılanÜrünleriGöster.Hide();
            showSoldProducts.Hide();
            alarm.Hide();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "Müşteri Ekle" || btn1.Text == "Add Customer")
            {
                musteriEkle.MdiParent = this;
                musteriEkle.FormBorderStyle = FormBorderStyle.None;
                musteriEkle.StartPosition = FormStartPosition.CenterParent;
                musteriEkle.Dock = DockStyle.Fill;
                musteriEkle.Show();
            }
            else if (btn1.Text == "Tedarikçi Ekle" || btn1.Text == "Add Supplier")
            {
                tedarikciEkle.MdiParent = this;
                tedarikciEkle.FormBorderStyle = FormBorderStyle.None;
                tedarikciEkle.StartPosition = FormStartPosition.CenterParent;
                tedarikciEkle.Dock = DockStyle.Fill;
                tedarikciEkle.Show();
            }
            else if (btn1.Text == "Mağaza Ekle" || btn1.Text == "Add Store")
            {
                magazaEkle.MdiParent = this;
                magazaEkle.FormBorderStyle = FormBorderStyle.None;
                magazaEkle.StartPosition = FormStartPosition.CenterParent;
                magazaEkle.Dock = DockStyle.Fill;
                magazaEkle.Show();
            }
            else if (btn1.Text == "Depo Ekle" || btn1.Text == "Add Warehouse")
            {
                depoEkle.MdiParent = this;
                depoEkle.FormBorderStyle = FormBorderStyle.None;
                depoEkle.StartPosition = FormStartPosition.CenterParent;
                depoEkle.Dock = DockStyle.Fill;
                depoEkle.Show();
            }
            else if (btn1.Text == "Satış Yap" || btn1.Text == "Make Sale")
            {
                satisYap.MdiParent = this;
                satisYap.FormBorderStyle = FormBorderStyle.None;
                satisYap.StartPosition = FormStartPosition.CenterParent;
                satisYap.Dock = DockStyle.Fill;
                satisYap.Show();
            }
            else if (btn1.Text == "Depoya Ürün Ekle" || btn1.Text == "Add Product To Warehouse")
            {
                urunEkle.MdiParent = this;
                urunEkle.FormBorderStyle = FormBorderStyle.None;
                urunEkle.StartPosition = FormStartPosition.CenterParent;
                urunEkle.Dock = DockStyle.Fill;
                urunEkle.Show();
            }
            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = false;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "Depodan Mağazaya Ürün Ekle" || btn2.Text == "Add Product From Warehouse To Store")
            {
                magazayaUrunEkle.MdiParent = this;
                magazayaUrunEkle.FormBorderStyle = FormBorderStyle.None;
                magazayaUrunEkle.StartPosition = FormStartPosition.CenterParent;
                magazayaUrunEkle.Dock = DockStyle.Fill;
                magazayaUrunEkle.Show();
            }
            else if (btn2.Text == "Borç Öde" || btn2.Text == "Pay Debt")
            {
                borcOde.MdiParent = this;
                borcOde.FormBorderStyle = FormBorderStyle.None;
                borcOde.StartPosition = FormStartPosition.CenterParent;
                borcOde.Dock = DockStyle.Fill;
                borcOde.Show();
            }
            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = false;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text == "Müşterileri Göster" || btn3.Text == "Show Customers")
            {
                if (Ayarlar.dil == "Türkçe")
                {
                    musterileriGoster.MdiParent = this;
                    musterileriGoster.FormBorderStyle = FormBorderStyle.None;
                    musterileriGoster.StartPosition = FormStartPosition.CenterParent;
                    musterileriGoster.Dock = DockStyle.Fill;
                    musterileriGoster.Show();
                }
                else if (Ayarlar.dil == "English")
                {
                    showCustomers.MdiParent = this;
                    showCustomers.FormBorderStyle = FormBorderStyle.None;
                    showCustomers.StartPosition = FormStartPosition.CenterParent;
                    showCustomers.Dock = DockStyle.Fill;
                    showCustomers.Show();
                }
            }
            else if (btn3.Text == "Mağazadaki Ürünleri Göster" || btn3.Text == "Show Products In Store")
            {
                if (Ayarlar.dil == "Türkçe")
                {
                    magazadakiUrunleriGoster.MdiParent = this;
                    magazadakiUrunleriGoster.FormBorderStyle = FormBorderStyle.None;
                    magazadakiUrunleriGoster.StartPosition = FormStartPosition.CenterParent;
                    magazadakiUrunleriGoster.Dock = DockStyle.Fill;
                    magazadakiUrunleriGoster.Show();
                }
                else if (Ayarlar.dil == "English")
                {
                    showProductsInStore.MdiParent = this;
                    showProductsInStore.FormBorderStyle = FormBorderStyle.None;
                    showProductsInStore.StartPosition = FormStartPosition.CenterParent;
                    showProductsInStore.Dock = DockStyle.Fill;
                    showProductsInStore.Show();
                }
            }
            else if (btn3.Text == "Tedarikçileri Göster" || btn3.Text == "Show Suppliers")
            {
                if (Ayarlar.dil == "Türkçe")
                {
                    tedarikcileriGoster.MdiParent = this;
                    tedarikcileriGoster.FormBorderStyle = FormBorderStyle.None;
                    tedarikcileriGoster.StartPosition = FormStartPosition.CenterParent;
                    tedarikcileriGoster.Dock = DockStyle.Fill;
                    tedarikcileriGoster.Show();
                }
                else if (Ayarlar.dil == "English")
                {
                    showSuppliers.MdiParent = this;
                    showSuppliers.FormBorderStyle = FormBorderStyle.None;
                    showSuppliers.StartPosition = FormStartPosition.CenterParent;
                    showSuppliers.Dock = DockStyle.Fill;
                    showSuppliers.Show();
                }
            }
            else if (btn3.Text == "Depodaki Ürünleri Göster" || btn3.Text == "Show Products In Warehouse")
            {
                if (Ayarlar.dil == "Türkçe")
                {
                    depodakiUrunleriGoster.MdiParent = this;
                    depodakiUrunleriGoster.FormBorderStyle = FormBorderStyle.None;
                    depodakiUrunleriGoster.StartPosition = FormStartPosition.CenterParent;
                    depodakiUrunleriGoster.Dock = DockStyle.Fill;
                    depodakiUrunleriGoster.Show();
                }
                else if (Ayarlar.dil == "English")
                {
                    showProductsInWarehouse.MdiParent = this;
                    showProductsInWarehouse.FormBorderStyle = FormBorderStyle.None;
                    showProductsInWarehouse.StartPosition = FormStartPosition.CenterParent;
                    showProductsInWarehouse.Dock = DockStyle.Fill;
                    showProductsInWarehouse.Show();
                }
            }
            else if (btn3.Text == "Borç Takibi" || btn3.Text == "Debt Follow Up")
            {
                if (Ayarlar.dil == "Türkçe")
                {
                    borcTakibi.MdiParent = this;
                    borcTakibi.FormBorderStyle = FormBorderStyle.None;
                    borcTakibi.StartPosition = FormStartPosition.CenterParent;
                    borcTakibi.Dock = DockStyle.Fill;
                    borcTakibi.Show();
                }
                else if (Ayarlar.dil == "English")
                {
                    debtFollowUp.MdiParent = this;
                    debtFollowUp.FormBorderStyle = FormBorderStyle.None;
                    debtFollowUp.StartPosition = FormStartPosition.CenterParent;
                    debtFollowUp.Dock = DockStyle.Fill;
                    debtFollowUp.Show();
                } 
            }
            else if (btn3.Text == "Satılan Ürünleri Göster" || btn3.Text == "Show Sold Products")
            {
                if (Ayarlar.dil == "Türkçe")
                {
                    satılanÜrünleriGöster.MdiParent = this;
                    satılanÜrünleriGöster.FormBorderStyle = FormBorderStyle.None;
                    satılanÜrünleriGöster.StartPosition = FormStartPosition.CenterParent;
                    satılanÜrünleriGöster.Dock = DockStyle.Fill;
                    satılanÜrünleriGöster.Show();
                }
                else if (Ayarlar.dil == "English")
                {
                    showSoldProducts.MdiParent = this;
                    showSoldProducts.FormBorderStyle = FormBorderStyle.None;
                    showSoldProducts.StartPosition = FormStartPosition.CenterParent;
                    showSoldProducts.Dock = DockStyle.Fill;
                    showSoldProducts.Show();
                }
            }
            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = false;
        }

        private void hatırlatıcı_BalloonTipClicked(object sender, EventArgs e)
        {
            alarm.MdiParent = this;
            alarm.FormBorderStyle = FormBorderStyle.None;
            alarm.StartPosition = FormStartPosition.CenterParent;
            alarm.Dock = DockStyle.Fill;
            alarm.Show();
            hatırlatıcı2.Visible = false;
            yer = "Depo";
        }
        private void hatırlatıcı2_BalloonTipClicked(object sender, EventArgs e)
        {
            ürün = ürün2;
            alarm.MdiParent = this;
            alarm.FormBorderStyle = FormBorderStyle.None;
            alarm.StartPosition = FormStartPosition.CenterParent;
            alarm.Dock = DockStyle.Fill;
            alarm.Show();
            yer = "Mağaza";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SimpleTCP;
using System.Net;

namespace ServerClientTCP
{
    public partial class Form1 : Form
    {
        SimpleTcpClient client = new SimpleTcpClient();
        SimpleTcpServer server = new SimpleTcpServer();
        public SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = Deneme ; Integrated Security= True");
        string Ad, OdaAd, IpAdres, KullaniciAd, Sifre, KullaniciIp, KullaniciPort, ClientIp, ClientPort, ArkIp, ArkPort, SecilenOda, SecilenKisi;
        int YetkiId;
        public static int PortNumber;
        private String loginName;

        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            BilgiAl();

            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;

            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            Mesajlar.Invoke((MethodInvoker)delegate ()
            {
                Mesajlar.Items.Add(e.MessageString + "\n");
                e.ReplyLine(string.Format("\n" + loginName + " said:", e.MessageString));
                //client.WriteLine("dfgdfgd");
            });
        }
        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            Mesajlar.Invoke((MethodInvoker)delegate ()
            {
                client.DataReceived += Client_DataReceived;
                Mesajlar.Items.Add(e.MessageString);
            });
        }
        public void BilgiAl()
        {
            IpAdres = Dns.GetHostAddresses(Dns.GetHostName())[1].ToString();
            txtHost.Text = IpAdres.ToString();
            txtPort.Text = RandomPort().ToString();
        }
        public static int RandomPort()
        {
            List<int> PortNo = new List<int>();
            List<int> PorttanSil = new List<int>();
            Random rndm = new Random();

            for (int j = 0; j < 7001; j++)
            {
                int port = rndm.Next(2001, 9001);
                PortNo.Add(port);
            }

            Form1 frm = new Form1();
            frm.con.Open();

            string sorgu = "Select * from PorttanSil";

            SqlCommand portsil = new SqlCommand(sorgu, frm.con);
            SqlDataReader PortSil = portsil.ExecuteReader();

            while (PortSil.Read())
            {
                PorttanSil.Add(Convert.ToInt32(PortSil["PortNo"]));
            }

            frm.con.Close();

            for (int j = 0; j < PortNo.Count; j++)
            {
                for (int k = 0; k < PorttanSil.Count; k++)
                {
                    if (PortNo[j] == PorttanSil[k])
                    {
                        PortNo.Remove(PorttanSil[k]);
                    }
                }
            }

            Random rdm = new Random();
            int rdmnext = rdm.Next(PortNo.Count);
            PortNumber = PortNo[rdmnext];
            PortNo.Remove(PortNo[rdmnext]);

            return PortNumber;
        }
        private void CikisBtn_Click(object sender, EventArgs e)
        {
            txtLoginName.Clear();
            SifreTxt.Clear();
            GirisBtn.Visible = true;
            CikisBtn.Visible = false;
            KayitAdTxt.Enabled = true;
            KayitSifreTxt.Enabled = true;
            txtPort.Enabled = true;
            txtHost.Enabled = true;
            KayitBtn.Enabled = true;
            Kisiler.Items.Clear();
            Kullanicilar.Items.Clear();
            OdaKisiLb.Items.Clear();
            Odalar.Items.Clear();
            KullaniciOdalar.Items.Clear();
        }
        public void GirisBtn_Click(object sender, EventArgs e)
        {
            KayitAdTxt.Enabled = false;
            KayitSifreTxt.Enabled = false;
            txtPort.Enabled = false;
            txtHost.Enabled = false;
            KayitBtn.Enabled = false;

            KullaniciAd = txtLoginName.Text;
            Sifre = SifreTxt.Text.ToString();

            if (KullaniciAd != "" && Sifre != "")
            {
                con.Open();
                SqlCommand GirisKontrol = new SqlCommand("Select * from Kullanici where KullaniciAd= '" + KullaniciAd + "' and Sifre='" + Sifre + "' ", con);
                SqlDataReader verioku = GirisKontrol.ExecuteReader(); //Veri iceride var mı yok mu, uyuyor mu diye bakıyor

                if (verioku.Read())
                {
                    KullaniciIp = verioku["IPAdres"].ToString();
                    KullaniciPort = verioku["PortNo"].ToString();

                    MessageBox.Show("Giriş Başarılı", "Giriş Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GirisBtn.Visible = false;
                    CikisBtn.Visible = true;

                    System.Net.IPAddress IP = System.Net.IPAddress.Parse(KullaniciIp);
                    server.Start(IP, Convert.ToInt32(KullaniciPort));

                    if (server.IsStarted)
                    {
                        MessageBox.Show("Server Başlatıldı..");
                    }
                    con.Close();
                    KullaniciGetir();
                    KisiGetir();
                    OdaGetir();
                    KullaniciOdaGetir();
                }
                else
                {
                    MessageBox.Show("Girilen Bilgiler Uyuşmuyor. Lütfen Tekrar Deneyiniz.", "Giriş Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }

            if (IpAdres != KullaniciIp)
            {
                BilgiAl();
                con.Open();

                string sorgu = "Update Kullanici set IPAdres='" + IpAdres + "' where KullaniciAd='" + KullaniciAd + "'";
                SqlCommand veridegis = new SqlCommand(sorgu, con);
                veridegis.ExecuteNonQuery();

                con.Close();
                ////////////
                con.Open();

                string sorgu2 = "Update Arkadaslar set ClientIP='" + IpAdres + "' where ClientName='" + KullaniciAd + "'";
                SqlCommand veridegis2 = new SqlCommand(sorgu2, con);
                veridegis2.ExecuteNonQuery();

                con.Close();
            }
        }
        private void OdaKurBtn_Click(object sender, EventArgs e)
        {
            con.Open();

            string sorgu = "Select * from Oda";

            SqlCommand odaveri = new SqlCommand(sorgu, con);
            SqlDataReader odaoku = odaveri.ExecuteReader();

            if (odaoku.Read())
            {
                OdaAd = odaoku["OdaAdi"].ToString();

                if (OdaAd != OdaAdiTxt.Text)
                {

                    odaveri.Connection = con;
                    odaveri.CommandType = CommandType.StoredProcedure;
                    odaveri.CommandText = "OdaEkle";

                    odaveri.Parameters.Add("OdaAdi", SqlDbType.NVarChar, 100).Value = OdaAdiTxt.Text;
                    odaveri.Parameters.Add("OdaIp", SqlDbType.NVarChar, 50).Value = IpAdres;
                    odaveri.Parameters.Add("OdaPort", SqlDbType.NVarChar, 50).Value = RandomPort().ToString();
                    odaveri.Parameters.Add("KurucuAd", SqlDbType.NVarChar, 100).Value = txtLoginName.Text;
                    odaveri.Parameters.Add("OdadakiKisiSayisi", SqlDbType.Int).Value = 0;
                    odaveri.Parameters.Add("Durum", SqlDbType.Bit).Value = true;
                    odaoku.Close();
                    odaveri.ExecuteNonQuery();
                    Odalar.Items.Add(OdaAdiTxt.Text);
                    MessageBox.Show("Oda Oluşturma Başarılı");
                }
                else
                {
                    MessageBox.Show("Oda Oluşturma Başarısız.");
                }
            }
            con.Close();
            KullaniciOdaGetir();
            OdaGetir();
        }
        private void OdayaKatilBtn_Click(object sender, EventArgs e)
        {
            con.Open();

            string sorgu = "Select * from OdaKisi where OdaAdi='" + Odalar.SelectedItem.ToString() + "' ";

            SqlCommand OdaKisi = new SqlCommand(sorgu, con);
            SqlDataReader odabilgisi = OdaKisi.ExecuteReader();

            if (odabilgisi.Read())
            {
                if (!(odabilgisi["KullaniciAdi"].ToString() == KullaniciAd && odabilgisi["OdaAdi"].ToString() == Odalar.SelectedItem.ToString()))
                {
                    OdaKisi.Connection = con;
                    OdaKisi.CommandType = CommandType.StoredProcedure;
                    OdaKisi.CommandText = "OdayaKisiEkle";

                    OdaKisi.Parameters.Add("OdaAdi", SqlDbType.NVarChar, 100).Value = Odalar.SelectedItem.ToString();
                    OdaKisi.Parameters.Add("KullaniciAdi", SqlDbType.NVarChar, 100).Value = KullaniciAd;
                    OdaKisi.Parameters.Add("Durum", SqlDbType.Bit).Value = true;

                    odabilgisi.Close();
                    OdaKisi.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarılı");
                }
                else
                {
                    MessageBox.Show("Odaya Daha Önce Kaydoldunuz");
                }
            }
            con.Close();
            KullaniciOdaGetir();
        }
        private void KayitBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string sorgu = "Select * from Kullanici";
            SqlCommand Kullanici = new SqlCommand(sorgu, con);

            SqlDataReader adoku = Kullanici.ExecuteReader();

            if (adoku.Read())
            {
                Ad = adoku["KullaniciAd"].ToString();

                if (Ad != KayitAdTxt.Text)
                {

                    Kullanici.Connection = con;
                    Kullanici.CommandType = CommandType.StoredProcedure;
                    Kullanici.CommandText = "KullaniciEkle";

                    Kullanici.Parameters.Add("KullaniciAd", SqlDbType.NVarChar, 100).Value = KayitAdTxt.Text;
                    Kullanici.Parameters.Add("Sifre", SqlDbType.NVarChar, 5).Value = KayitSifreTxt.Text;
                    Kullanici.Parameters.Add("IPAdres", SqlDbType.NVarChar, 50).Value = txtHost.Text;
                    Kullanici.Parameters.Add("PortNo", SqlDbType.NVarChar, 50).Value = txtPort.Text;
                    Kullanici.Parameters.Add("KullanciYetkiId", SqlDbType.Int).Value = 1;
                    Kullanici.Parameters.Add("Durum", SqlDbType.Bit).Value = true;
                    adoku.Close();
                    Kullanici.ExecuteNonQuery();
                    MessageBox.Show("Kullanici Ekleme Başarılı.");
                }
                else
                {
                    MessageBox.Show("Kullanici Ekleme Başarısız.");
                }
            }

            con.Close();

            KayitAdTxt.Clear();
            KayitSifreTxt.Clear();
            txtPort.Clear();
            txtPort.Text = RandomPort().ToString();
        }
        public void KullaniciGetir()
        {
            con.Open();
            string sorgu = "Select * from Kullanici";

            SqlCommand KullaniciGetir = new SqlCommand(sorgu, con);
            SqlDataReader KullaniciOku = KullaniciGetir.ExecuteReader();
            while (KullaniciOku.Read())
            {
                if (!Kullanicilar.Items.Contains(KullaniciOku["KullaniciAd"]))
                {
                    Kullanicilar.Items.Add(KullaniciOku["KullaniciAd"]);
                    if (Kullanicilar.Items.Contains(KullaniciAd))
                    {
                        Kullanicilar.Items.Remove(KullaniciAd);
                    }
                }
            }
            con.Close();
        }
        public void KisiGetir()
        {
            con.Open();
            string sorgu = "Select * from Arkadaslar";
            SqlCommand kisigetir = new SqlCommand(sorgu, con);
            SqlDataReader kisioku = kisigetir.ExecuteReader();

            while (kisioku.Read())
            {
                if (KullaniciAd == kisioku["KullaniciAd"].ToString())
                {
                    Kisiler.Items.Add(kisioku["ClientName"]);
                }
            }
            con.Close();
        }
        public void OdaGetir()
        {
            con.Open();
            string sorgu = "Select * from Oda";
            SqlCommand odagetir = new SqlCommand(sorgu, con);
            SqlDataReader odaoku = odagetir.ExecuteReader();

            while (odaoku.Read())
            {
                if (!Odalar.Items.Contains(odaoku["OdaAdi"]))
                {
                    Odalar.Items.Add(odaoku["OdaAdi"]);
                }
            }
            con.Close();
        }
        public void KullaniciOdaGetir()
        {
            con.Open();
            string sorgu = "Select * from OdaKisi where KullaniciAdi ='" + KullaniciAd + "'";
            SqlCommand odagetir = new SqlCommand(sorgu, con);
            SqlDataReader odaoku = odagetir.ExecuteReader();

            while (odaoku.Read())
            {
                if (!KullaniciOdalar.Items.Contains(odaoku["OdaAdi"]))
                {
                    KullaniciOdalar.Items.Add(odaoku["OdaAdi"]);
                }
            }
            con.Close();
        }
        private void Kisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();

            string sorgu = "Select * from Arkadaslar where ClientName='" + Kisiler.SelectedItem.ToString() + "'";
            SqlCommand vericek = new SqlCommand(sorgu, con);
            SqlDataReader verioku = vericek.ExecuteReader();

            if (verioku.Read())
            {
                if (Kisiler.SelectedItem.ToString() == verioku["ClientName"].ToString())
                {
                    ClientIp = verioku["ClientIP"].ToString();
                    ClientPort = verioku["ClientPort"].ToString();
                }
            }

            con.Close();
        }
        private void ArkadasBtn_Click(object sender, EventArgs e)
        {
            con.Open();

            string sorgu = "Select * from Kullanici where KullaniciAd='" + Kullanicilar.SelectedItem.ToString() + "'";

            SqlCommand vericek = new SqlCommand(sorgu, con);
            SqlDataReader verioku = vericek.ExecuteReader();

            if (verioku.Read())
            {
                ClientIp = verioku["IPAdres"].ToString();
                ClientPort = verioku["PortNo"].ToString();
            }
            con.Close();
            ////////////
            con.Open();

            ArkIp = txtHost.Text;
            ArkPort = RandomPort().ToString();

            string sorgu2 = "Select * from Arkadaslar";

            SqlCommand Kisi = new SqlCommand(sorgu2, con);
            SqlDataReader kisiad = Kisi.ExecuteReader();

            if (kisiad.Read())
            {
                if (!(kisiad["KullaniciAd"].ToString() == KullaniciAd && kisiad["ClientName"].ToString() == Kullanicilar.SelectedItem.ToString()))
                {
                    Kisi.Connection = con;
                    Kisi.CommandType = CommandType.StoredProcedure;
                    Kisi.CommandText = "ArkadasEkle";

                    Kisi.Parameters.Add("KullaniciAd", SqlDbType.NVarChar, 100).Value = txtLoginName.Text;
                    Kisi.Parameters.Add("ClientName", SqlDbType.NVarChar, 100).Value = Kullanicilar.SelectedItem.ToString();
                    Kisi.Parameters.Add("ClientIP", SqlDbType.NVarChar, 50).Value = ClientIp;
                    Kisi.Parameters.Add("ClientPort", SqlDbType.NVarChar, 50).Value = ClientPort;
                    Kisi.Parameters.Add("ArkIp", SqlDbType.NVarChar, 50).Value = ArkIp;
                    Kisi.Parameters.Add("ArkPort", SqlDbType.NVarChar, 50).Value = ArkPort;
                    Kisi.Parameters.Add("Durum", SqlDbType.Bit).Value = true;
                    kisiad.Close();
                    Kisi.ExecuteNonQuery();

                    MessageBox.Show("Arkadaş Ekleme Başarılı.");
                    Kisiler.Items.Clear();
                }
                else
                {
                    MessageBox.Show(Kullanicilar.SelectedItem.ToString() + " Adlı kullanıcı Zaten Arkadaşınız.");
                }
            }
            con.Close();
            KisiGetir();

        }
        private void ArkadasSilBtn_Click(object sender, EventArgs e)
        {
            con.Open();

            string sorgu = "delete from Arkadaslar where ClientName='" + Kisiler.SelectedItem.ToString() + "'";

            SqlCommand arksil = new SqlCommand(sorgu, con);
            arksil.ExecuteNonQuery();

            MessageBox.Show(Kisiler.SelectedItem.ToString() + " Adlı kullanıcı Artık Arkadaşınız Değil.");

            con.Close();
            Kisiler.Items.Clear();
            KisiGetir();
        }
        public void OdayaEkle()
        {
            con.Open();
            string sorgu = "select * from OdaKisi where OdaAdi='" + KullaniciOdalar.SelectedItem.ToString() + "' and KullaniciAdi='" + txtLoginName.Text + "' ";

            SqlCommand yetkial = new SqlCommand(sorgu, con);
            SqlDataReader yetkioku = yetkial.ExecuteReader();

            while (yetkioku.Read())
            {
                YetkiId = Convert.ToInt32(yetkioku["KullanciYetkiId"]);
            }
            con.Close();
            ////////////
            con.Open();
            if (YetkiId == 2)
            {
                string sorgu2 = "insert into OdaKisi(OdaAdi,KullaniciAdi,KullanciYetkiId,Durum) " +
                    "values('" + KullaniciOdalar.SelectedItem.ToString() + "','" + Kisiler.SelectedItem.ToString() + "',1,1)";
                SqlCommand odakatil = new SqlCommand(sorgu2, con);
                odakatil.ExecuteNonQuery();

                MessageBox.Show(Kisiler.SelectedItem.ToString() + " Adlı kullanıcı Odaya Eklendi.");
            }
            else
            {
                MessageBox.Show("Odanın Kurucusu Olmadığınız İçin Ekleyemezsiniz");
            }
            con.Close();
            OdaKisiLb.SelectedIndex = -1;
            OdaKisiLb.Items.Clear();
            KullaniciOdaKisiGetir();
        }
        private void OdayaEkleBtn_Click(object sender, EventArgs e)
        {
            OdayaEkle();
        }
        private void OdaAyrilBtn_Click(object sender, EventArgs e)
        {
            con.Open();

            string sorgu = "delete from OdaKisi where OdaAdi='" + KullaniciOdalar.SelectedItem.ToString() + "' and KullaniciAdi='" + KullaniciAd + "' ";

            SqlCommand odaayril = new SqlCommand(sorgu, con);
            odaayril.ExecuteNonQuery();

            MessageBox.Show("Odadan Ayrıldınız.");

            con.Close();
            Odalar.Items.Clear();
            OdaGetir();
            KullaniciOdalar.Items.Clear();
            KullaniciOdaGetir();
        }
        private void OdaSilBtn_Click(object sender, EventArgs e)
        {
            con.Open();

            string sorgu = "Delete from Oda where OdaAdi='" + KullaniciOdalar.SelectedItem.ToString() + "' ";

            SqlCommand odasil = new SqlCommand(sorgu, con);
            odasil.ExecuteNonQuery();

            MessageBox.Show("Oda Silme Başarılı");

            Odalar.Items.Clear();
            KullaniciOdalar.Items.Clear();

            con.Close();

            OdaGetir();
            KullaniciOdaGetir();
        }
        private void OdadanCikarBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string sorgu = "select * from OdaKisi where OdaAdi='" + KullaniciOdalar.SelectedItem.ToString() + "' and KullaniciAdi='" + txtLoginName.Text + "' ";

            SqlCommand yetkial = new SqlCommand(sorgu, con);
            SqlDataReader yetkioku = yetkial.ExecuteReader();

            while (yetkioku.Read())
            {
                YetkiId = Convert.ToInt32(yetkioku["KullanciYetkiId"]);
            }
            con.Close();
            ////////////
            con.Open();
            if (YetkiId == 2)
            {
                string sorgu2 = "Delete from OdaKisi where OdaAdi='" + KullaniciOdalar.SelectedItem.ToString() + "' and KullaniciAdi='" + OdaKisiLb.SelectedItem.ToString() + "' ";

                SqlCommand odasil = new SqlCommand(sorgu2, con);
                odasil.ExecuteNonQuery();

                MessageBox.Show(OdaKisiLb.SelectedItem.ToString() + " Adlı kullanıcı Odadan Çıkarıldı.");

            }
            con.Close();
            OdaKisiLb.SelectedIndex = -1;
            OdaKisiLb.Items.Clear();
            KullaniciOdaKisiGetir();
        }
        public void KullaniciOdaKisiGetir()
        {
            con.Open();
            string sorgu = "Select * from OdaKisi";

            SqlCommand odakisigetir = new SqlCommand(sorgu, con);
            SqlDataReader odakisioku = odakisigetir.ExecuteReader();

            while (odakisioku.Read())
            {
                if (KullaniciOdalar.SelectedItem.ToString() == odakisioku["OdaAdi"].ToString())
                {
                    if (!OdaKisiLb.Items.Contains(odakisioku["KullaniciAdi"]))
                    {
                        OdaKisiLb.Items.Add(odakisioku["KullaniciAdi"]);
                    }
                }
            }
            con.Close();
        }
        private void KullaniciOdalar_DoubleClick(object sender, EventArgs e)
        {
            OdaSohbet os = new OdaSohbet();
            SecilenOda = KullaniciOdalar.SelectedItem.ToString();

            os.KullaniciAdi = txtLoginName.Text;
            os.SecilenOda = SecilenOda;
            os.Show();

            OdaKisiLb.Items.Clear();
            KullaniciOdaKisiGetir();
        }
        private void Kisiler_DoubleClick(object sender, EventArgs e)
        {
            KisiMesaj km = new KisiMesaj();
            SecilenKisi = Kisiler.SelectedItem.ToString();

            con.Open();

            string sorgu = "Select * from Arkadaslar where ClientName='" + Kisiler.SelectedItem.ToString() + "'";
            SqlCommand vericek = new SqlCommand(sorgu, con);
            SqlDataReader verioku = vericek.ExecuteReader();

            if (verioku.Read())
            {
                if (KullaniciAd == verioku["KullaniciAd"].ToString() && Kisiler.SelectedItem.ToString() == verioku["ClientName"].ToString())
                {
                    ArkIp = verioku["ArkIp"].ToString();
                    ArkPort = verioku["ArkPort"].ToString();
                }
            }

            con.Close();

            km.ArkIp = ArkIp;
            km.ArkPort = ArkPort;
            km.KullaniciAd = KullaniciAd;
            km.SecilenKisi = SecilenKisi;

            km.Show();
        }
    }
}

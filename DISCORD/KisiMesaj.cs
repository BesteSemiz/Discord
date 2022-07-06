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
    public partial class KisiMesaj : Form
    {
        SimpleTcpClient kisiclient = new SimpleTcpClient();
        SimpleTcpServer kisiserver = new SimpleTcpServer();
        Form1 frm = new Form1();
        public string KullaniciAd, KullaniciAdi, Alici, SecilenKisi, KullaniciIp, KullaniciPort, ArkIp, ArkPort;
        int i = 0;
        private String loginName;

        public KisiMesaj()
        {
            InitializeComponent();
        }
        public void MesajKaydet()
        {
            frm.con.Open();

            string sorgu = "Select * from Mesajlar";

            SqlCommand Kullanici = new SqlCommand(sorgu, frm.con);
            Kullanici.Connection = frm.con;
            Kullanici.CommandType = CommandType.StoredProcedure;
            Kullanici.CommandText = "MesajEkle";

            Kullanici.Parameters.Add("KullaniciAd", SqlDbType.NVarChar, 100).Value = KullaniciAd;
            Kullanici.Parameters.Add("Mesaj", SqlDbType.NVarChar, 2000).Value = textBox3.Text;
            Kullanici.Parameters.Add("AliciAd", SqlDbType.NVarChar, 100).Value = SecilenKisi;
            Kullanici.Parameters.Add("Durum", SqlDbType.Bit).Value = true;

            Kullanici.ExecuteNonQuery();

            frm.con.Close();
        }
        private void GonderBtn_Click(object sender, EventArgs e)
        {
            Mesajlar.Items.Clear();
            MesajKaydet();
            MesajGetir();
            textBox3.Clear();
        }
        private void KisiMesaj_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (kisiserver.IsStarted)
            {
                kisiserver.Stop();
                Mesajlar.Items.Add("Server Durduruldu.");
            }
        }
        public void MesajGetir()
        {
            frm.con.Open();

            string sorgu2 = "Select * from Mesajlar";

            SqlCommand MesajGetir = new SqlCommand(sorgu2, frm.con);
            SqlDataReader MesajOku = MesajGetir.ExecuteReader();

            while (MesajOku.Read())
            {
                KullaniciAdi = MesajOku["KullaniciAd"].ToString();
                Alici = MesajOku["AliciAd"].ToString();

                if ((KullaniciAdi == KullaniciAd && Alici == SecilenKisi) || (KullaniciAdi == SecilenKisi && Alici == KullaniciAd))
                {
                    Mesajlar.Items.Add(MesajOku["KullaniciAd"] + ": " + MesajOku["Mesaj"]);
                }
            }
            frm.con.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 5)
            {
                Mesajlar.Items.Clear();
                MesajGetir();
                i = 0;
            }
        }
        public void KullaniciBilgi()
        {
            frm.con.Open();

            SqlCommand GirisKontrol = new SqlCommand("Select * from Kullanici", frm.con);
            SqlDataReader verioku = GirisKontrol.ExecuteReader(); //Veri iceride var mı yok mu, uyuyor mu diye bakıyor

            if (verioku.Read())
            {
                KullaniciIp = verioku["IPAdres"].ToString();
                KullaniciPort = verioku["PortNo"].ToString();
            }
            frm.con.Close();
        }
        public void KisiServer()
        {
            frm.con.Open();

            string sorgu = "Select * from Arkadaslar where ClientName='" + SecilenKisi + "' ";

            SqlCommand arkveri = new SqlCommand(sorgu, frm.con);
            SqlDataReader arkverioku = arkveri.ExecuteReader();

            while (arkverioku.Read())
            {
                ArkIp = arkverioku["ArkIp"].ToString();
                ArkPort = arkverioku["ArkPort"].ToString();
            }
            frm.con.Close();

            System.Net.IPAddress OdaIP = System.Net.IPAddress.Parse(ArkIp);
            kisiserver.Start(OdaIP, Convert.ToInt32(ArkPort));
            if (kisiserver.IsStarted)
            {
                Mesajlar.Items.Add("Kişiye Bağlanıldı");
            }
        }
        private void KisiMesaj_Load(object sender, EventArgs e)
        {
            timer1.Start();
            KisiServer();

            kisiclient = new SimpleTcpClient();
            kisiclient.StringEncoder = Encoding.UTF8;
            kisiclient.DataReceived += Client_DataReceived;

            kisiserver = new SimpleTcpServer();
            kisiserver.Delimiter = 0x13;
            kisiserver.StringEncoder = Encoding.UTF8;
            kisiserver.DataReceived += Server_DataReceived;

          
            MesajGetir();
            KullaniciBilgi();
        }
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            Mesajlar.Invoke((MethodInvoker)delegate ()
            {
                Mesajlar.Items.Add(e.MessageString + "\n");
                e.ReplyLine(string.Format("\n" + loginName + " said:", e.MessageString));
            });
        }
        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            Mesajlar.Invoke((MethodInvoker)delegate ()
            {
                kisiclient.DataReceived += Client_DataReceived;
                Mesajlar.Items.Add(e.MessageString);
            });
        }
    }
}

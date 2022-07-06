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
    public partial class OdaSohbet : Form
    {
        SimpleTcpServer odaserver = new SimpleTcpServer();
        SimpleTcpClient odaclient = new SimpleTcpClient();
        Form1 frm = new Form1();
        private String loginName;
        public string KullaniciAdi, KullaniciAd, Alici, OdaIp, OdaPort, SecilenOda;
        int i = 0;
        public OdaSohbet()
        {
            InitializeComponent();
        }
        private void OdaSohbet_Load(object sender, EventArgs e)
        {
            timer1.Start();

            odaserver = new SimpleTcpServer();
            odaserver.Delimiter = 0x13;
            odaserver.StringEncoder = Encoding.UTF8;
            odaserver.DataReceived += Odaserver_DataReceived;

            odaclient = new SimpleTcpClient();
            odaclient.StringEncoder = Encoding.UTF8;
            odaclient.DataReceived += Odaclient_DataReceived;

            KullaniciOdaMesajGetir();
        }
        private void Odaclient_DataReceived(object sender, SimpleTCP.Message e)
        {
            OdaMesajlar.Invoke((MethodInvoker)delegate ()
            {
                odaclient.DataReceived += Odaclient_DataReceived;
                OdaMesajlar.Items.Add(e.MessageString);
            });
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 5)
            {
                OdaMesajlar.Items.Clear();
                KullaniciOdaMesajGetir();
                i= 0;
            }
        }
        private void GonderBtn_Click(object sender, EventArgs e)
        {
            OdaMesajlar.Items.Clear();
            OdaMesajKaydet();
            KullaniciOdaMesajGetir();
            OdaMesajTB.Clear();
        }
        private void Odaserver_DataReceived(object sender, SimpleTCP.Message e)
        {
            OdaMesajlar.Invoke((MethodInvoker)delegate ()
            {
                OdaMesajlar.Items.Add(e.MessageString + "\n");
                e.ReplyLine(string.Format("\n" + loginName + " said:", e.MessageString));
            });
        }
        public void KullaniciOdaServer()
        {
            frm.con.Open();

            string sorgu = "Select * from Oda where OdaAdi='" + SecilenOda + "' ";

            SqlCommand odaveri = new SqlCommand(sorgu, frm.con);
            SqlDataReader odaverioku = odaveri.ExecuteReader();

            while (odaverioku.Read())
            {
                OdaIp = odaverioku["OdaIp"].ToString();
                OdaPort = odaverioku["OdaPort"].ToString();
            }
            frm.con.Close();

            System.Net.IPAddress OdaIP = System.Net.IPAddress.Parse(OdaIp);
            odaserver.Start(OdaIP, Convert.ToInt32(OdaPort));
            if (odaserver.IsStarted)
            {
                OdaMesajlar.Items.Add("Odaya Bağlanıldı");
            }
        }
        public void OdaMesajKaydet()
        {
            frm.con.Open();

            string sorgu = "Select * from Mesajlar";

            SqlCommand Kullanici = new SqlCommand(sorgu, frm.con);
            Kullanici.Connection = frm.con;
            Kullanici.CommandType = CommandType.StoredProcedure;
            Kullanici.CommandText = "MesajEkle";

            Kullanici.Parameters.Add("KullaniciAd", SqlDbType.NVarChar, 100).Value = KullaniciAdi;
            Kullanici.Parameters.Add("Mesaj", SqlDbType.NVarChar, 2000).Value = OdaMesajTB.Text;
            Kullanici.Parameters.Add("AliciAd", SqlDbType.NVarChar, 100).Value = SecilenOda;
            Kullanici.Parameters.Add("Durum", SqlDbType.Bit).Value = true;

            Kullanici.ExecuteNonQuery();

            frm.con.Close();
        }
        public void KullaniciOdaMesajGetir()
        {
            frm.con.Open();

            string sorgu2 = "Select * from Mesajlar";

            SqlCommand MesajGetir = new SqlCommand(sorgu2, frm.con);
            SqlDataReader MesajOku = MesajGetir.ExecuteReader();

            while (MesajOku.Read())
            {
                KullaniciAd = MesajOku["KullaniciAd"].ToString();
                Alici = MesajOku["AliciAd"].ToString();

                if (Alici == SecilenOda)
                {
                    OdaMesajlar.Items.Add(MesajOku["KullaniciAd"] + ": " + MesajOku["Mesaj"]);
                }
            }
            frm.con.Close();
        }
    }
}

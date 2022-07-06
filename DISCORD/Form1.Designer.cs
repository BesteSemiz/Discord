
namespace ServerClientTCP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.GirisBtn = new System.Windows.Forms.Button();
            this.SifreTxt = new System.Windows.Forms.TextBox();
            this.KayitAdTxt = new System.Windows.Forms.TextBox();
            this.KayitSifreTxt = new System.Windows.Forms.TextBox();
            this.KayitBtn = new System.Windows.Forms.Button();
            this.CikisBtn = new System.Windows.Forms.Button();
            this.ArkadasBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.KisilerTP = new System.Windows.Forms.TabPage();
            this.Kisiler = new System.Windows.Forms.ListBox();
            this.KullanicilarTP = new System.Windows.Forms.TabPage();
            this.Kullanicilar = new System.Windows.Forms.ListBox();
            this.OdaKisiTP = new System.Windows.Forms.TabPage();
            this.OdaKisiLb = new System.Windows.Forms.ListBox();
            this.OdaKurBtn = new System.Windows.Forms.Button();
            this.OdayaEkleBtn = new System.Windows.Forms.Button();
            this.OdaAdiTxt = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.KullaniciOdaTP = new System.Windows.Forms.TabPage();
            this.KullaniciOdalar = new System.Windows.Forms.ListBox();
            this.OdalarTP = new System.Windows.Forms.TabPage();
            this.Odalar = new System.Windows.Forms.ListBox();
            this.OdayaKatilBtn = new System.Windows.Forms.Button();
            this.OdaAyrilBtn = new System.Windows.Forms.Button();
            this.OdaSilBtn = new System.Windows.Forms.Button();
            this.ArkadasSilBtn = new System.Windows.Forms.Button();
            this.OdadanCikarBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.KisilerTP.SuspendLayout();
            this.KullanicilarTP.SuspendLayout();
            this.OdaKisiTP.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.KullaniciOdaTP.SuspendLayout();
            this.OdalarTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(39, 78);
            this.txtHost.Name = "txtHost";
            this.txtHost.PlaceholderText = "Server Ip";
            this.txtHost.Size = new System.Drawing.Size(125, 27);
            this.txtHost.TabIndex = 9;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(189, 78);
            this.txtPort.Name = "txtPort";
            this.txtPort.PlaceholderText = "Server Port";
            this.txtPort.Size = new System.Drawing.Size(125, 27);
            this.txtPort.TabIndex = 10;
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(494, 22);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.PlaceholderText = "Kullanıcı Adı";
            this.txtLoginName.Size = new System.Drawing.Size(125, 27);
            this.txtLoginName.TabIndex = 11;
            // 
            // GirisBtn
            // 
            this.GirisBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.GirisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GirisBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GirisBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.GirisBtn.Location = new System.Drawing.Point(650, 22);
            this.GirisBtn.Name = "GirisBtn";
            this.GirisBtn.Size = new System.Drawing.Size(94, 29);
            this.GirisBtn.TabIndex = 12;
            this.GirisBtn.Text = "Giris";
            this.GirisBtn.UseVisualStyleBackColor = false;
            this.GirisBtn.Click += new System.EventHandler(this.GirisBtn_Click);
            // 
            // SifreTxt
            // 
            this.SifreTxt.Location = new System.Drawing.Point(494, 78);
            this.SifreTxt.MaxLength = 5;
            this.SifreTxt.Name = "SifreTxt";
            this.SifreTxt.PlaceholderText = "Sifre";
            this.SifreTxt.Size = new System.Drawing.Size(125, 27);
            this.SifreTxt.TabIndex = 13;
            // 
            // KayitAdTxt
            // 
            this.KayitAdTxt.Location = new System.Drawing.Point(39, 22);
            this.KayitAdTxt.Name = "KayitAdTxt";
            this.KayitAdTxt.PlaceholderText = "Kayıt Ad";
            this.KayitAdTxt.Size = new System.Drawing.Size(125, 27);
            this.KayitAdTxt.TabIndex = 16;
            // 
            // KayitSifreTxt
            // 
            this.KayitSifreTxt.Location = new System.Drawing.Point(189, 22);
            this.KayitSifreTxt.Name = "KayitSifreTxt";
            this.KayitSifreTxt.PlaceholderText = "Kayıt Sifre";
            this.KayitSifreTxt.Size = new System.Drawing.Size(125, 27);
            this.KayitSifreTxt.TabIndex = 17;
            // 
            // KayitBtn
            // 
            this.KayitBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.KayitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KayitBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KayitBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.KayitBtn.Location = new System.Drawing.Point(334, 22);
            this.KayitBtn.Name = "KayitBtn";
            this.KayitBtn.Size = new System.Drawing.Size(90, 90);
            this.KayitBtn.TabIndex = 18;
            this.KayitBtn.Text = "Kayıt";
            this.KayitBtn.UseVisualStyleBackColor = false;
            this.KayitBtn.Click += new System.EventHandler(this.KayitBtn_Click);
            // 
            // CikisBtn
            // 
            this.CikisBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CikisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CikisBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CikisBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.CikisBtn.Location = new System.Drawing.Point(650, 78);
            this.CikisBtn.Name = "CikisBtn";
            this.CikisBtn.Size = new System.Drawing.Size(94, 29);
            this.CikisBtn.TabIndex = 19;
            this.CikisBtn.Text = "Cikis";
            this.CikisBtn.UseVisualStyleBackColor = false;
            this.CikisBtn.Click += new System.EventHandler(this.CikisBtn_Click);
            // 
            // ArkadasBtn
            // 
            this.ArkadasBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ArkadasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ArkadasBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ArkadasBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ArkadasBtn.Location = new System.Drawing.Point(469, 467);
            this.ArkadasBtn.Name = "ArkadasBtn";
            this.ArkadasBtn.Size = new System.Drawing.Size(132, 29);
            this.ArkadasBtn.TabIndex = 20;
            this.ArkadasBtn.Text = "Arkadaş Ekle";
            this.ArkadasBtn.UseVisualStyleBackColor = false;
            this.ArkadasBtn.Click += new System.EventHandler(this.ArkadasBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.KisilerTP);
            this.tabControl1.Controls.Add(this.KullanicilarTP);
            this.tabControl1.Controls.Add(this.OdaKisiTP);
            this.tabControl1.Location = new System.Drawing.Point(459, 122);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(285, 329);
            this.tabControl1.TabIndex = 21;
            // 
            // KisilerTP
            // 
            this.KisilerTP.Controls.Add(this.Kisiler);
            this.KisilerTP.Location = new System.Drawing.Point(4, 29);
            this.KisilerTP.Name = "KisilerTP";
            this.KisilerTP.Padding = new System.Windows.Forms.Padding(3);
            this.KisilerTP.Size = new System.Drawing.Size(277, 296);
            this.KisilerTP.TabIndex = 0;
            this.KisilerTP.Text = "Kisiler";
            this.KisilerTP.UseVisualStyleBackColor = true;
            // 
            // Kisiler
            // 
            this.Kisiler.FormattingEnabled = true;
            this.Kisiler.ItemHeight = 20;
            this.Kisiler.Location = new System.Drawing.Point(6, 6);
            this.Kisiler.Name = "Kisiler";
            this.Kisiler.Size = new System.Drawing.Size(265, 284);
            this.Kisiler.TabIndex = 0;
            this.Kisiler.SelectedIndexChanged += new System.EventHandler(this.Kisiler_SelectedIndexChanged);
            this.Kisiler.DoubleClick += new System.EventHandler(this.Kisiler_DoubleClick);
            // 
            // KullanicilarTP
            // 
            this.KullanicilarTP.Controls.Add(this.Kullanicilar);
            this.KullanicilarTP.Location = new System.Drawing.Point(4, 29);
            this.KullanicilarTP.Name = "KullanicilarTP";
            this.KullanicilarTP.Padding = new System.Windows.Forms.Padding(3);
            this.KullanicilarTP.Size = new System.Drawing.Size(277, 296);
            this.KullanicilarTP.TabIndex = 1;
            this.KullanicilarTP.Text = "Kullanicilar";
            this.KullanicilarTP.UseVisualStyleBackColor = true;
            // 
            // Kullanicilar
            // 
            this.Kullanicilar.FormattingEnabled = true;
            this.Kullanicilar.ItemHeight = 20;
            this.Kullanicilar.Location = new System.Drawing.Point(6, 6);
            this.Kullanicilar.Name = "Kullanicilar";
            this.Kullanicilar.Size = new System.Drawing.Size(268, 284);
            this.Kullanicilar.TabIndex = 0;
            // 
            // OdaKisiTP
            // 
            this.OdaKisiTP.Controls.Add(this.OdaKisiLb);
            this.OdaKisiTP.Location = new System.Drawing.Point(4, 29);
            this.OdaKisiTP.Name = "OdaKisiTP";
            this.OdaKisiTP.Padding = new System.Windows.Forms.Padding(3);
            this.OdaKisiTP.Size = new System.Drawing.Size(277, 296);
            this.OdaKisiTP.TabIndex = 2;
            this.OdaKisiTP.Text = "Odadaki Kisiler";
            this.OdaKisiTP.UseVisualStyleBackColor = true;
            // 
            // OdaKisiLb
            // 
            this.OdaKisiLb.FormattingEnabled = true;
            this.OdaKisiLb.ItemHeight = 20;
            this.OdaKisiLb.Location = new System.Drawing.Point(6, 10);
            this.OdaKisiLb.Name = "OdaKisiLb";
            this.OdaKisiLb.Size = new System.Drawing.Size(265, 284);
            this.OdaKisiLb.TabIndex = 2;
            // 
            // OdaKurBtn
            // 
            this.OdaKurBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.OdaKurBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OdaKurBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OdaKurBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.OdaKurBtn.Location = new System.Drawing.Point(221, 469);
            this.OdaKurBtn.Name = "OdaKurBtn";
            this.OdaKurBtn.Size = new System.Drawing.Size(93, 29);
            this.OdaKurBtn.TabIndex = 23;
            this.OdaKurBtn.Text = "Oda Kur";
            this.OdaKurBtn.UseVisualStyleBackColor = false;
            this.OdaKurBtn.Click += new System.EventHandler(this.OdaKurBtn_Click);
            // 
            // OdayaEkleBtn
            // 
            this.OdayaEkleBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.OdayaEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OdayaEkleBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OdayaEkleBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.OdayaEkleBtn.Location = new System.Drawing.Point(469, 502);
            this.OdayaEkleBtn.Name = "OdayaEkleBtn";
            this.OdayaEkleBtn.Size = new System.Drawing.Size(132, 29);
            this.OdayaEkleBtn.TabIndex = 24;
            this.OdayaEkleBtn.Text = "Odaya Ekle";
            this.OdayaEkleBtn.UseVisualStyleBackColor = false;
            this.OdayaEkleBtn.Click += new System.EventHandler(this.OdayaEkleBtn_Click);
            // 
            // OdaAdiTxt
            // 
            this.OdaAdiTxt.Location = new System.Drawing.Point(39, 469);
            this.OdaAdiTxt.Name = "OdaAdiTxt";
            this.OdaAdiTxt.PlaceholderText = "Oda Adı Giriniz";
            this.OdaAdiTxt.Size = new System.Drawing.Size(165, 27);
            this.OdaAdiTxt.TabIndex = 25;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.KullaniciOdaTP);
            this.tabControl2.Controls.Add(this.OdalarTP);
            this.tabControl2.Location = new System.Drawing.Point(39, 122);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(275, 329);
            this.tabControl2.TabIndex = 26;
            // 
            // KullaniciOdaTP
            // 
            this.KullaniciOdaTP.Controls.Add(this.KullaniciOdalar);
            this.KullaniciOdaTP.Location = new System.Drawing.Point(4, 29);
            this.KullaniciOdaTP.Name = "KullaniciOdaTP";
            this.KullaniciOdaTP.Padding = new System.Windows.Forms.Padding(3);
            this.KullaniciOdaTP.Size = new System.Drawing.Size(267, 296);
            this.KullaniciOdaTP.TabIndex = 0;
            this.KullaniciOdaTP.Text = "Kullanici Odalar";
            this.KullaniciOdaTP.UseVisualStyleBackColor = true;
            // 
            // KullaniciOdalar
            // 
            this.KullaniciOdalar.FormattingEnabled = true;
            this.KullaniciOdalar.ItemHeight = 20;
            this.KullaniciOdalar.Location = new System.Drawing.Point(6, 6);
            this.KullaniciOdalar.Name = "KullaniciOdalar";
            this.KullaniciOdalar.Size = new System.Drawing.Size(253, 284);
            this.KullaniciOdalar.TabIndex = 23;
            this.KullaniciOdalar.DoubleClick += new System.EventHandler(this.KullaniciOdalar_DoubleClick);
            // 
            // OdalarTP
            // 
            this.OdalarTP.Controls.Add(this.Odalar);
            this.OdalarTP.Location = new System.Drawing.Point(4, 29);
            this.OdalarTP.Name = "OdalarTP";
            this.OdalarTP.Padding = new System.Windows.Forms.Padding(3);
            this.OdalarTP.Size = new System.Drawing.Size(267, 296);
            this.OdalarTP.TabIndex = 1;
            this.OdalarTP.Text = "Odalar";
            this.OdalarTP.UseVisualStyleBackColor = true;
            // 
            // Odalar
            // 
            this.Odalar.FormattingEnabled = true;
            this.Odalar.ItemHeight = 20;
            this.Odalar.Location = new System.Drawing.Point(3, 6);
            this.Odalar.Name = "Odalar";
            this.Odalar.Size = new System.Drawing.Size(258, 284);
            this.Odalar.TabIndex = 0;
            // 
            // OdayaKatilBtn
            // 
            this.OdayaKatilBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.OdayaKatilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OdayaKatilBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OdayaKatilBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.OdayaKatilBtn.Location = new System.Drawing.Point(39, 509);
            this.OdayaKatilBtn.Name = "OdayaKatilBtn";
            this.OdayaKatilBtn.Size = new System.Drawing.Size(151, 29);
            this.OdayaKatilBtn.TabIndex = 27;
            this.OdayaKatilBtn.Text = "Odaya Katıl";
            this.OdayaKatilBtn.UseVisualStyleBackColor = false;
            this.OdayaKatilBtn.Click += new System.EventHandler(this.OdayaKatilBtn_Click);
            // 
            // OdaAyrilBtn
            // 
            this.OdaAyrilBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.OdaAyrilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OdaAyrilBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OdaAyrilBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.OdaAyrilBtn.Location = new System.Drawing.Point(196, 509);
            this.OdaAyrilBtn.Name = "OdaAyrilBtn";
            this.OdaAyrilBtn.Size = new System.Drawing.Size(163, 29);
            this.OdaAyrilBtn.TabIndex = 28;
            this.OdaAyrilBtn.Text = "Odadan Ayrıl";
            this.OdaAyrilBtn.UseVisualStyleBackColor = false;
            this.OdaAyrilBtn.Click += new System.EventHandler(this.OdaAyrilBtn_Click);
            // 
            // OdaSilBtn
            // 
            this.OdaSilBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.OdaSilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OdaSilBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OdaSilBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.OdaSilBtn.Location = new System.Drawing.Point(365, 509);
            this.OdaSilBtn.Name = "OdaSilBtn";
            this.OdaSilBtn.Size = new System.Drawing.Size(93, 29);
            this.OdaSilBtn.TabIndex = 29;
            this.OdaSilBtn.Text = "Oda Sil";
            this.OdaSilBtn.UseVisualStyleBackColor = false;
            this.OdaSilBtn.Click += new System.EventHandler(this.OdaSilBtn_Click);
            // 
            // ArkadasSilBtn
            // 
            this.ArkadasSilBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ArkadasSilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ArkadasSilBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ArkadasSilBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ArkadasSilBtn.Location = new System.Drawing.Point(612, 467);
            this.ArkadasSilBtn.Name = "ArkadasSilBtn";
            this.ArkadasSilBtn.Size = new System.Drawing.Size(132, 29);
            this.ArkadasSilBtn.TabIndex = 30;
            this.ArkadasSilBtn.Text = "Arkadaş Sil";
            this.ArkadasSilBtn.UseVisualStyleBackColor = false;
            this.ArkadasSilBtn.Click += new System.EventHandler(this.ArkadasSilBtn_Click);
            // 
            // OdadanCikarBtn
            // 
            this.OdadanCikarBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.OdadanCikarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OdadanCikarBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OdadanCikarBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.OdadanCikarBtn.Location = new System.Drawing.Point(612, 502);
            this.OdadanCikarBtn.Name = "OdadanCikarBtn";
            this.OdadanCikarBtn.Size = new System.Drawing.Size(132, 29);
            this.OdadanCikarBtn.TabIndex = 31;
            this.OdadanCikarBtn.Text = "Odadan Çıkar";
            this.OdadanCikarBtn.UseVisualStyleBackColor = false;
            this.OdadanCikarBtn.Click += new System.EventHandler(this.OdadanCikarBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(779, 550);
            this.Controls.Add(this.OdadanCikarBtn);
            this.Controls.Add(this.ArkadasSilBtn);
            this.Controls.Add(this.OdaSilBtn);
            this.Controls.Add(this.OdaAyrilBtn);
            this.Controls.Add(this.OdayaKatilBtn);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.OdaAdiTxt);
            this.Controls.Add(this.OdayaEkleBtn);
            this.Controls.Add(this.OdaKurBtn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ArkadasBtn);
            this.Controls.Add(this.CikisBtn);
            this.Controls.Add(this.KayitBtn);
            this.Controls.Add(this.KayitSifreTxt);
            this.Controls.Add(this.KayitAdTxt);
            this.Controls.Add(this.SifreTxt);
            this.Controls.Add(this.GirisBtn);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtHost);
            this.Name = "Form1";
            this.Text = "DISCORD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.KisilerTP.ResumeLayout(false);
            this.KullanicilarTP.ResumeLayout(false);
            this.OdaKisiTP.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.KullaniciOdaTP.ResumeLayout(false);
            this.OdalarTP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox Mesajlar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Button GirisBtn;
        private System.Windows.Forms.TextBox SifreTxt;
        private System.Windows.Forms.TextBox KayitAdTxt;
        private System.Windows.Forms.TextBox KayitSifreTxt;
        private System.Windows.Forms.Button KayitBtn;
        private System.Windows.Forms.Button CikisBtn;
        private System.Windows.Forms.Button ArkadasBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage KisilerTP;
        private System.Windows.Forms.TabPage KullanicilarTP;
        private System.Windows.Forms.ListBox Kullanicilar;
        private System.Windows.Forms.Button OdaKurBtn;
        private System.Windows.Forms.Button OdayaEkleBtn;
        private System.Windows.Forms.TextBox OdaAdiTxt;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage KullaniciOdaTP;
        private System.Windows.Forms.ListBox KullaniciOdalar;
        private System.Windows.Forms.TabPage OdalarTP;
        private System.Windows.Forms.ListBox Odalar;
        private System.Windows.Forms.Button OdayaKatilBtn;
        private System.Windows.Forms.Button OdaAyrilBtn;
        private System.Windows.Forms.Button OdaSilBtn;
        private System.Windows.Forms.Button ArkadasSilBtn;
        private System.Windows.Forms.Button OdadanCikarBtn;
        private System.Windows.Forms.TabPage OdaKisiTP;
        private System.Windows.Forms.ListBox OdaKisiLb;
        private System.Windows.Forms.ListBox Kisiler;
        private System.Windows.Forms.Timer timer1;
    }
}


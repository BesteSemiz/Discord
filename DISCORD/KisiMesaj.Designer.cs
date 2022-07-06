namespace ServerClientTCP
{
    partial class KisiMesaj
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Mesajlar = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GonderBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(23, 385);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "Mesaj Yaz";
            this.textBox3.Size = new System.Drawing.Size(285, 27);
            this.textBox3.TabIndex = 9;
            // 
            // Mesajlar
            // 
            this.Mesajlar.FormattingEnabled = true;
            this.Mesajlar.ItemHeight = 20;
            this.Mesajlar.Location = new System.Drawing.Point(23, 39);
            this.Mesajlar.Name = "Mesajlar";
            this.Mesajlar.Size = new System.Drawing.Size(384, 324);
            this.Mesajlar.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GonderBtn
            // 
            this.GonderBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.GonderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GonderBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GonderBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.GonderBtn.Location = new System.Drawing.Point(314, 385);
            this.GonderBtn.Name = "GonderBtn";
            this.GonderBtn.Size = new System.Drawing.Size(93, 29);
            this.GonderBtn.TabIndex = 7;
            this.GonderBtn.Text = "Gönder";
            this.GonderBtn.UseVisualStyleBackColor = false;
            this.GonderBtn.Click += new System.EventHandler(this.GonderBtn_Click);
            // 
            // KisiMesaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Mesajlar);
            this.Controls.Add(this.GonderBtn);
            this.Name = "KisiMesaj";
            this.Text = "KisiMesaj";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KisiMesaj_FormClosing);
            this.Load += new System.EventHandler(this.KisiMesaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox Mesajlar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button GonderBtn;
    }
}
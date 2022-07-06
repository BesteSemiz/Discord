namespace ServerClientTCP
{
    partial class OdaSohbet
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
            this.OdaMesajlar = new System.Windows.Forms.ListBox();
            this.GonderBtn = new System.Windows.Forms.Button();
            this.OdaMesajTB = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // OdaMesajlar
            // 
            this.OdaMesajlar.FormattingEnabled = true;
            this.OdaMesajlar.ItemHeight = 20;
            this.OdaMesajlar.Location = new System.Drawing.Point(12, 52);
            this.OdaMesajlar.Name = "OdaMesajlar";
            this.OdaMesajlar.Size = new System.Drawing.Size(296, 384);
            this.OdaMesajlar.TabIndex = 0;
            // 
            // GonderBtn
            // 
            this.GonderBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.GonderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GonderBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GonderBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.GonderBtn.Location = new System.Drawing.Point(214, 447);
            this.GonderBtn.Name = "GonderBtn";
            this.GonderBtn.Size = new System.Drawing.Size(94, 29);
            this.GonderBtn.TabIndex = 1;
            this.GonderBtn.Text = "Gönder";
            this.GonderBtn.UseVisualStyleBackColor = false;
            this.GonderBtn.Click += new System.EventHandler(this.GonderBtn_Click);
            // 
            // OdaMesajTB
            // 
            this.OdaMesajTB.Location = new System.Drawing.Point(12, 447);
            this.OdaMesajTB.Name = "OdaMesajTB";
            this.OdaMesajTB.PlaceholderText = "Mesaj Giriniz";
            this.OdaMesajTB.Size = new System.Drawing.Size(196, 27);
            this.OdaMesajTB.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OdaSohbet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(320, 486);
            this.Controls.Add(this.OdaMesajTB);
            this.Controls.Add(this.GonderBtn);
            this.Controls.Add(this.OdaMesajlar);
            this.Name = "OdaSohbet";
            this.Text = "OdaSohbet";
            this.Load += new System.EventHandler(this.OdaSohbet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OdaMesajlar;
        private System.Windows.Forms.Button GonderBtn;
        private System.Windows.Forms.TextBox OdaMesajTB;
        private System.Windows.Forms.Timer timer1;
    }
}
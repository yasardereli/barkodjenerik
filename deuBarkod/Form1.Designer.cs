namespace deuBarkod
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbYaziciAdi = new System.Windows.Forms.TextBox();
            this.tbAdet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.tbYazilacak = new System.Windows.Forms.TextBox();
            this.tbYazilacakDosya = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbYazilacakDosya);
            this.groupBox2.Controls.Add(this.tbYazilacak);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbYaziciAdi);
            this.groupBox2.Controls.Add(this.tbAdet);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnYazdir);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 130);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Etiketi Bas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Yazıcı Adı";
            // 
            // tbYaziciAdi
            // 
            this.tbYaziciAdi.Location = new System.Drawing.Point(126, 34);
            this.tbYaziciAdi.Name = "tbYaziciAdi";
            this.tbYaziciAdi.Size = new System.Drawing.Size(138, 20);
            this.tbYaziciAdi.TabIndex = 46;
            this.tbYaziciAdi.Text = "Zebra";
            // 
            // tbAdet
            // 
            this.tbAdet.FormattingEnabled = true;
            this.tbAdet.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.tbAdet.Location = new System.Drawing.Point(21, 34);
            this.tbAdet.Name = "tbAdet";
            this.tbAdet.Size = new System.Drawing.Size(80, 21);
            this.tbAdet.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Adet";
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(299, 24);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(106, 38);
            this.btnYazdir.TabIndex = 11;
            this.btnYazdir.Text = "SF ";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // tbYazilacak
            // 
            this.tbYazilacak.Location = new System.Drawing.Point(21, 77);
            this.tbYazilacak.Multiline = true;
            this.tbYazilacak.Name = "tbYazilacak";
            this.tbYazilacak.Size = new System.Drawing.Size(171, 20);
            this.tbYazilacak.TabIndex = 23;
            // 
            // tbYazilacakDosya
            // 
            this.tbYazilacakDosya.Location = new System.Drawing.Point(215, 77);
            this.tbYazilacakDosya.Name = "tbYazilacakDosya";
            this.tbYazilacakDosya.Size = new System.Drawing.Size(171, 20);
            this.tbYazilacakDosya.TabIndex = 48;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 150);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Etiket Yazdırma - DEU Bilgi İşlem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tbAdet;
        private System.Windows.Forms.TextBox tbYazilacak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbYaziciAdi;
        private System.Windows.Forms.TextBox tbYazilacakDosya;
    }
}


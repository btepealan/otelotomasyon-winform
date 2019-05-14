namespace PL.Hotel
{
    partial class frmSatisIslemi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCikisTarihi = new System.Windows.Forms.TextBox();
            this.txtGirisTarihi = new System.Windows.Forms.TextBox();
            this.btnOdaSec = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cbMisafirSayisi = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContent.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 100);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(800, 350);
            this.pnlContent.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMusteriAdi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCikisTarihi);
            this.groupBox2.Controls.Add(this.txtGirisTarihi);
            this.groupBox2.Controls.Add(this.btnOdaSec);
            this.groupBox2.Controls.Add(this.btnOnayla);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cbMisafirSayisi);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtToplamTutar);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtOdaNo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 310);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Konaklama Bilgileri";
            // 
            // txtCikisTarihi
            // 
            this.txtCikisTarihi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCikisTarihi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCikisTarihi.Location = new System.Drawing.Point(82, 48);
            this.txtCikisTarihi.Name = "txtCikisTarihi";
            this.txtCikisTarihi.ReadOnly = true;
            this.txtCikisTarihi.Size = new System.Drawing.Size(135, 20);
            this.txtCikisTarihi.TabIndex = 31;
            // 
            // txtGirisTarihi
            // 
            this.txtGirisTarihi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtGirisTarihi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGirisTarihi.Location = new System.Drawing.Point(82, 23);
            this.txtGirisTarihi.Name = "txtGirisTarihi";
            this.txtGirisTarihi.ReadOnly = true;
            this.txtGirisTarihi.Size = new System.Drawing.Size(135, 20);
            this.txtGirisTarihi.TabIndex = 30;
            // 
            // btnOdaSec
            // 
            this.btnOdaSec.Location = new System.Drawing.Point(138, 204);
            this.btnOdaSec.Name = "btnOdaSec";
            this.btnOdaSec.Size = new System.Drawing.Size(75, 23);
            this.btnOdaSec.TabIndex = 29;
            this.btnOdaSec.Text = "Oda Seç";
            this.btnOdaSec.UseVisualStyleBackColor = true;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(9, 204);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(75, 23);
            this.btnOnayla.TabIndex = 28;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Misafir Sayısı";
            // 
            // cbMisafirSayisi
            // 
            this.cbMisafirSayisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbMisafirSayisi.FormattingEnabled = true;
            this.cbMisafirSayisi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbMisafirSayisi.Location = new System.Drawing.Point(82, 124);
            this.cbMisafirSayisi.Name = "cbMisafirSayisi";
            this.cbMisafirSayisi.Size = new System.Drawing.Size(135, 21);
            this.cbMisafirSayisi.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Toplam Tutar";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtToplamTutar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtToplamTutar.Location = new System.Drawing.Point(82, 100);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(135, 20);
            this.txtToplamTutar.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Çıkış Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Oda No";
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtOdaNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOdaNo.Location = new System.Drawing.Point(82, 75);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.ReadOnly = true;
            this.txtOdaNo.Size = new System.Drawing.Size(135, 20);
            this.txtOdaNo.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "GirisTarihi";
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMusteriAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMusteriAdi.Location = new System.Drawing.Point(82, 151);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.ReadOnly = true;
            this.txtMusteriAdi.Size = new System.Drawing.Size(135, 20);
            this.txtMusteriAdi.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Musteri Adı";
            // 
            // frmSatisIslemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSatisIslemi";
            this.Text = "frmSatisIslemi";
            this.Load += new System.EventHandler(this.frmSatisIslemi_Load);
            this.pnlContent.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCikisTarihi;
        private System.Windows.Forms.TextBox txtGirisTarihi;
        private System.Windows.Forms.Button btnOdaSec;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbMisafirSayisi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.Label label1;
    }
}
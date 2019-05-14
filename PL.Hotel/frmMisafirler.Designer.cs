namespace PL.Hotel
{
    partial class frmMisafirler
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.gbMisafirBilgi = new System.Windows.Forms.GroupBox();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMisafirAdi = new System.Windows.Forms.TextBox();
            this.txtMisafirSoyadi = new System.Windows.Forms.TextBox();
            this.txtMisafirTC = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.cbMisafirCinsiyet = new System.Windows.Forms.ComboBox();
            this.dtpMisafirDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBul = new System.Windows.Forms.Button();
            this.txtOdaAra = new System.Windows.Forms.TextBox();
            this.dgvMisafirListesi = new System.Windows.Forms.DataGridView();
            this.pnlContent.SuspendLayout();
            this.gbMisafirBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisafirListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(210)))), ((int)(((byte)(125)))));
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 59);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.btnEkle);
            this.pnlContent.Controls.Add(this.btnDuzenle);
            this.pnlContent.Controls.Add(this.btnSil);
            this.pnlContent.Controls.Add(this.gbMisafirBilgi);
            this.pnlContent.Controls.Add(this.btnBul);
            this.pnlContent.Controls.Add(this.txtOdaAra);
            this.pnlContent.Controls.Add(this.dgvMisafirListesi);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 59);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1000, 591);
            this.pnlContent.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(721, 308);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(109, 40);
            this.btnEkle.TabIndex = 76;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuzenle.Location = new System.Drawing.Point(721, 351);
            this.btnDuzenle.Margin = new System.Windows.Forms.Padding(2);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(109, 40);
            this.btnDuzenle.TabIndex = 75;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSil.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(721, 395);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(109, 40);
            this.btnSil.TabIndex = 74;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // gbMisafirBilgi
            // 
            this.gbMisafirBilgi.Controls.Add(this.txtAdres);
            this.gbMisafirBilgi.Controls.Add(this.label8);
            this.gbMisafirBilgi.Controls.Add(this.txtMisafirAdi);
            this.gbMisafirBilgi.Controls.Add(this.txtMisafirSoyadi);
            this.gbMisafirBilgi.Controls.Add(this.txtMisafirTC);
            this.gbMisafirBilgi.Controls.Add(this.txtTelefon);
            this.gbMisafirBilgi.Controls.Add(this.label2);
            this.gbMisafirBilgi.Controls.Add(this.label3);
            this.gbMisafirBilgi.Controls.Add(this.label4);
            this.gbMisafirBilgi.Controls.Add(this.label5);
            this.gbMisafirBilgi.Controls.Add(this.label6);
            this.gbMisafirBilgi.Controls.Add(this.label7);
            this.gbMisafirBilgi.Controls.Add(this.txtMail);
            this.gbMisafirBilgi.Controls.Add(this.cbMisafirCinsiyet);
            this.gbMisafirBilgi.Controls.Add(this.dtpMisafirDogumTarihi);
            this.gbMisafirBilgi.Controls.Add(this.label13);
            this.gbMisafirBilgi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbMisafirBilgi.Location = new System.Drawing.Point(63, 220);
            this.gbMisafirBilgi.Margin = new System.Windows.Forms.Padding(2);
            this.gbMisafirBilgi.Name = "gbMisafirBilgi";
            this.gbMisafirBilgi.Padding = new System.Windows.Forms.Padding(2);
            this.gbMisafirBilgi.Size = new System.Drawing.Size(275, 325);
            this.gbMisafirBilgi.TabIndex = 72;
            this.gbMisafirBilgi.TabStop = false;
            this.gbMisafirBilgi.Text = "Misafir Bilgileri";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(110, 243);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(154, 67);
            this.txtAdres.TabIndex = 19;
            this.txtAdres.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 249);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Adres:";
            // 
            // txtMisafirAdi
            // 
            this.txtMisafirAdi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMisafirAdi.Location = new System.Drawing.Point(110, 25);
            this.txtMisafirAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtMisafirAdi.Name = "txtMisafirAdi";
            this.txtMisafirAdi.Size = new System.Drawing.Size(122, 25);
            this.txtMisafirAdi.TabIndex = 0;
            // 
            // txtMisafirSoyadi
            // 
            this.txtMisafirSoyadi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMisafirSoyadi.Location = new System.Drawing.Point(110, 57);
            this.txtMisafirSoyadi.Margin = new System.Windows.Forms.Padding(2);
            this.txtMisafirSoyadi.Name = "txtMisafirSoyadi";
            this.txtMisafirSoyadi.Size = new System.Drawing.Size(122, 25);
            this.txtMisafirSoyadi.TabIndex = 1;
            // 
            // txtMisafirTC
            // 
            this.txtMisafirTC.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMisafirTC.Location = new System.Drawing.Point(110, 88);
            this.txtMisafirTC.Margin = new System.Windows.Forms.Padding(2);
            this.txtMisafirTC.Name = "txtMisafirTC";
            this.txtMisafirTC.Size = new System.Drawing.Size(122, 25);
            this.txtMisafirTC.TabIndex = 2;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefon.Location = new System.Drawing.Point(110, 120);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(122, 25);
            this.txtTelefon.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyadı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cinsiyet:";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(110, 153);
            this.txtMail.Margin = new System.Windows.Forms.Padding(2);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(122, 25);
            this.txtMail.TabIndex = 14;
            // 
            // cbMisafirCinsiyet
            // 
            this.cbMisafirCinsiyet.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMisafirCinsiyet.FormattingEnabled = true;
            this.cbMisafirCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cbMisafirCinsiyet.Location = new System.Drawing.Point(110, 185);
            this.cbMisafirCinsiyet.Margin = new System.Windows.Forms.Padding(2);
            this.cbMisafirCinsiyet.Name = "cbMisafirCinsiyet";
            this.cbMisafirCinsiyet.Size = new System.Drawing.Size(84, 28);
            this.cbMisafirCinsiyet.TabIndex = 15;
            // 
            // dtpMisafirDogumTarihi
            // 
            this.dtpMisafirDogumTarihi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMisafirDogumTarihi.Location = new System.Drawing.Point(110, 216);
            this.dtpMisafirDogumTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtpMisafirDogumTarihi.Name = "dtpMisafirDogumTarihi";
            this.dtpMisafirDogumTarihi.Size = new System.Drawing.Size(127, 25);
            this.dtpMisafirDogumTarihi.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 220);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "DoğumTarihi:";
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(519, 23);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 71;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // txtOdaAra
            // 
            this.txtOdaAra.Location = new System.Drawing.Point(403, 26);
            this.txtOdaAra.Name = "txtOdaAra";
            this.txtOdaAra.Size = new System.Drawing.Size(100, 20);
            this.txtOdaAra.TabIndex = 70;
            // 
            // dgvMisafirListesi
            // 
            this.dgvMisafirListesi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMisafirListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisafirListesi.Location = new System.Drawing.Point(63, 63);
            this.dgvMisafirListesi.Name = "dgvMisafirListesi";
            this.dgvMisafirListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMisafirListesi.Size = new System.Drawing.Size(837, 152);
            this.dgvMisafirListesi.TabIndex = 69;
            this.dgvMisafirListesi.DoubleClick += new System.EventHandler(this.dgvMisafirListesi_DoubleClick);
            // 
            // frmMisafirler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMisafirler";
            this.Text = "frmMisafirler";
            this.Load += new System.EventHandler(this.frmMisafirler_Load);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.gbMisafirBilgi.ResumeLayout(false);
            this.gbMisafirBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisafirListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.TextBox txtOdaAra;
        private System.Windows.Forms.DataGridView dgvMisafirListesi;
        private System.Windows.Forms.GroupBox gbMisafirBilgi;
        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMisafirAdi;
        private System.Windows.Forms.TextBox txtMisafirSoyadi;
        private System.Windows.Forms.TextBox txtMisafirTC;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ComboBox cbMisafirCinsiyet;
        private System.Windows.Forms.DateTimePicker dtpMisafirDogumTarihi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
    }
}
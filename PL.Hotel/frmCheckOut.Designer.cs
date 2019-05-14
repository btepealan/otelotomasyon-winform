namespace PL.Hotel
{
    partial class frmCheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckOut));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnErkenCikis = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvExtralar = new System.Windows.Forms.DataGridView();
            this.btnYazdır = new System.Windows.Forms.Button();
            this.btnOnayla2 = new System.Windows.Forms.Button();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.btnCikisOnayla = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKonaklamaBorc = new System.Windows.Forms.TextBox();
            this.txtBorc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtExtraBorc = new System.Windows.Forms.TextBox();
            this.txtKazanc = new System.Windows.Forms.TextBox();
            this.txtKalanBorc = new System.Windows.Forms.TextBox();
            this.ppdiaFatura = new System.Windows.Forms.PrintPreviewDialog();
            this.pdocFatura = new System.Drawing.Printing.PrintDocument();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtralar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(210)))), ((int)(((byte)(125)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1000, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Çıkış İşlemleri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlContent.Controls.Add(this.btnErkenCikis);
            this.pnlContent.Controls.Add(this.btnCheckout);
            this.pnlContent.Controls.Add(this.btnSorgula);
            this.pnlContent.Controls.Add(this.txtTcNo);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.dgvExtralar);
            this.pnlContent.Controls.Add(this.btnYazdır);
            this.pnlContent.Controls.Add(this.btnOnayla2);
            this.pnlContent.Controls.Add(this.btnOdemeYap);
            this.pnlContent.Controls.Add(this.btnCikisOnayla);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 65);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1000, 485);
            this.pnlContent.TabIndex = 3;
            // 
            // btnErkenCikis
            // 
            this.btnErkenCikis.Location = new System.Drawing.Point(634, 20);
            this.btnErkenCikis.Name = "btnErkenCikis";
            this.btnErkenCikis.Size = new System.Drawing.Size(117, 23);
            this.btnErkenCikis.TabIndex = 113;
            this.btnErkenCikis.Text = "Erken Check-Out";
            this.btnErkenCikis.UseVisualStyleBackColor = true;
            this.btnErkenCikis.Click += new System.EventHandler(this.btnErkenCikis_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(504, 20);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(124, 23);
            this.btnCheckout.TabIndex = 112;
            this.btnCheckout.Text = "Check-Out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // btnSorgula
            // 
            this.btnSorgula.AutoSize = true;
            this.btnSorgula.Location = new System.Drawing.Point(257, 19);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(177, 25);
            this.btnSorgula.TabIndex = 111;
            this.btnSorgula.Text = "BORÇ SORGULA";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // txtTcNo
            // 
            this.txtTcNo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTcNo.Location = new System.Drawing.Point(114, 19);
            this.txtTcNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTcNo.MaxLength = 11;
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(122, 25);
            this.txtTcNo.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 109;
            this.label2.Text = "TC Kimlik No:";
            // 
            // dgvExtralar
            // 
            this.dgvExtralar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvExtralar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtralar.Location = new System.Drawing.Point(12, 63);
            this.dgvExtralar.Name = "dgvExtralar";
            this.dgvExtralar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExtralar.Size = new System.Drawing.Size(650, 282);
            this.dgvExtralar.TabIndex = 108;
            this.dgvExtralar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvExtralar_MouseDoubleClick);
            // 
            // btnYazdır
            // 
            this.btnYazdır.Location = new System.Drawing.Point(467, 350);
            this.btnYazdır.Margin = new System.Windows.Forms.Padding(2);
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(140, 47);
            this.btnYazdır.TabIndex = 107;
            this.btnYazdır.Text = "Yazdır";
            this.btnYazdır.UseVisualStyleBackColor = true;
            this.btnYazdır.Click += new System.EventHandler(this.btnYazdır_Click);
            // 
            // btnOnayla2
            // 
            this.btnOnayla2.Location = new System.Drawing.Point(179, 350);
            this.btnOnayla2.Margin = new System.Windows.Forms.Padding(2);
            this.btnOnayla2.Name = "btnOnayla2";
            this.btnOnayla2.Size = new System.Drawing.Size(140, 47);
            this.btnOnayla2.TabIndex = 103;
            this.btnOnayla2.Text = "Check-out-2";
            this.btnOnayla2.UseVisualStyleBackColor = true;
            this.btnOnayla2.Click += new System.EventHandler(this.btnOnayla2_Click);
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Location = new System.Drawing.Point(323, 350);
            this.btnOdemeYap.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(140, 47);
            this.btnOdemeYap.TabIndex = 106;
            this.btnOdemeYap.Text = "Ödeme Yap";
            this.btnOdemeYap.UseVisualStyleBackColor = true;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // btnCikisOnayla
            // 
            this.btnCikisOnayla.Location = new System.Drawing.Point(35, 350);
            this.btnCikisOnayla.Margin = new System.Windows.Forms.Padding(2);
            this.btnCikisOnayla.Name = "btnCikisOnayla";
            this.btnCikisOnayla.Size = new System.Drawing.Size(140, 47);
            this.btnCikisOnayla.TabIndex = 105;
            this.btnCikisOnayla.Text = "Check-Out";
            this.btnCikisOnayla.UseVisualStyleBackColor = true;
            this.btnCikisOnayla.Click += new System.EventHandler(this.btnCikisOnayla_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKonaklamaBorc);
            this.groupBox1.Controls.Add(this.txtBorc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtExtraBorc);
            this.groupBox1.Controls.Add(this.txtKazanc);
            this.groupBox1.Controls.Add(this.txtKalanBorc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(681, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 196);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Bilgileri";
            // 
            // txtKonaklamaBorc
            // 
            this.txtKonaklamaBorc.Location = new System.Drawing.Point(121, 95);
            this.txtKonaklamaBorc.Name = "txtKonaklamaBorc";
            this.txtKonaklamaBorc.ReadOnly = true;
            this.txtKonaklamaBorc.Size = new System.Drawing.Size(90, 22);
            this.txtKonaklamaBorc.TabIndex = 92;
            this.txtKonaklamaBorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKonaklamaBorc.Visible = false;
            // 
            // txtBorc
            // 
            this.txtBorc.Location = new System.Drawing.Point(121, 16);
            this.txtBorc.Name = "txtBorc";
            this.txtBorc.ReadOnly = true;
            this.txtBorc.Size = new System.Drawing.Size(90, 22);
            this.txtBorc.TabIndex = 69;
            this.txtBorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 94;
            this.label3.Text = "Konaklama Borcu";
            this.label3.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 89;
            this.label9.Text = "Toplam Borç";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 95;
            this.label4.Text = "Extralar";
            this.label4.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(6, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 17);
            this.label14.TabIndex = 91;
            this.label14.Text = "Kalan";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(6, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 17);
            this.label13.TabIndex = 90;
            this.label13.Text = "Ödenen";
            // 
            // txtExtraBorc
            // 
            this.txtExtraBorc.Location = new System.Drawing.Point(121, 120);
            this.txtExtraBorc.Name = "txtExtraBorc";
            this.txtExtraBorc.ReadOnly = true;
            this.txtExtraBorc.Size = new System.Drawing.Size(90, 22);
            this.txtExtraBorc.TabIndex = 93;
            this.txtExtraBorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExtraBorc.Visible = false;
            // 
            // txtKazanc
            // 
            this.txtKazanc.Location = new System.Drawing.Point(121, 41);
            this.txtKazanc.Name = "txtKazanc";
            this.txtKazanc.ReadOnly = true;
            this.txtKazanc.Size = new System.Drawing.Size(90, 22);
            this.txtKazanc.TabIndex = 85;
            this.txtKazanc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKalanBorc
            // 
            this.txtKalanBorc.Location = new System.Drawing.Point(121, 67);
            this.txtKalanBorc.Name = "txtKalanBorc";
            this.txtKalanBorc.ReadOnly = true;
            this.txtKalanBorc.Size = new System.Drawing.Size(90, 22);
            this.txtKalanBorc.TabIndex = 70;
            this.txtKalanBorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ppdiaFatura
            // 
            this.ppdiaFatura.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdiaFatura.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdiaFatura.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdiaFatura.Document = this.pdocFatura;
            this.ppdiaFatura.Enabled = true;
            this.ppdiaFatura.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdiaFatura.Icon")));
            this.ppdiaFatura.Name = "ppdiaFatura";
            this.ppdiaFatura.Visible = false;
            // 
            // pdocFatura
            // 
            this.pdocFatura.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdocFatura_PrintPage);
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCheckOut";
            this.Text = "frmCheckOut";
            this.Load += new System.EventHandler(this.frmCheckOut_Load);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtralar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBorc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtKazanc;
        private System.Windows.Forms.TextBox txtKalanBorc;
        private System.Windows.Forms.Button btnOnayla2;
        private System.Windows.Forms.Button btnOdemeYap;
        private System.Windows.Forms.Button btnCikisOnayla;
        private System.Windows.Forms.Button btnYazdır;
        private System.Windows.Forms.PrintPreviewDialog ppdiaFatura;
        private System.Drawing.Printing.PrintDocument pdocFatura;
        private System.Windows.Forms.DataGridView dgvExtralar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtKonaklamaBorc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExtraBorc;
        private System.Windows.Forms.Button btnErkenCikis;
        private System.Windows.Forms.Button btnCheckout;
    }
}
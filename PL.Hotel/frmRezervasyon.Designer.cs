namespace PL.Hotel
{
    partial class frmRezervasyon
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRezervasyon = new System.Windows.Forms.DataGridView();
            this.dtpGiris = new System.Windows.Forms.DateTimePicker();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMisafirAdi = new System.Windows.Forms.TextBox();
            this.txtMisafirSoyadi = new System.Windows.Forms.TextBox();
            this.txtMisafirTC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRezIptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyon)).BeginInit();
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
            this.label1.TabIndex = 3;
            this.label1.Text = "Rezervasyon Ekranı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvRezervasyon
            // 
            this.dgvRezervasyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervasyon.Location = new System.Drawing.Point(12, 129);
            this.dgvRezervasyon.Name = "dgvRezervasyon";
            this.dgvRezervasyon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervasyon.Size = new System.Drawing.Size(658, 190);
            this.dgvRezervasyon.TabIndex = 4;
            this.dgvRezervasyon.DoubleClick += new System.EventHandler(this.dgvRezervasyon_DoubleClick);
            // 
            // dtpGiris
            // 
            this.dtpGiris.Location = new System.Drawing.Point(99, 103);
            this.dtpGiris.Name = "dtpGiris";
            this.dtpGiris.Size = new System.Drawing.Size(156, 20);
            this.dtpGiris.TabIndex = 5;
            this.dtpGiris.ValueChanged += new System.EventHandler(this.dtpGiris_ValueChanged);
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(447, 103);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(156, 20);
            this.txtTc.TabIndex = 9;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // btnCheckin
            // 
            this.btnCheckin.Location = new System.Drawing.Point(326, 325);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(105, 42);
            this.btnCheckin.TabIndex = 10;
            this.btnCheckin.Text = "CHECK-IN";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMisafirAdi);
            this.groupBox1.Controls.Add(this.txtMisafirSoyadi);
            this.groupBox1.Controls.Add(this.txtMisafirTC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(29, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 154);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // txtMisafirAdi
            // 
            this.txtMisafirAdi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMisafirAdi.Location = new System.Drawing.Point(103, 33);
            this.txtMisafirAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtMisafirAdi.Name = "txtMisafirAdi";
            this.txtMisafirAdi.Size = new System.Drawing.Size(122, 25);
            this.txtMisafirAdi.TabIndex = 7;
            // 
            // txtMisafirSoyadi
            // 
            this.txtMisafirSoyadi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMisafirSoyadi.Location = new System.Drawing.Point(103, 65);
            this.txtMisafirSoyadi.Margin = new System.Windows.Forms.Padding(2);
            this.txtMisafirSoyadi.Name = "txtMisafirSoyadi";
            this.txtMisafirSoyadi.Size = new System.Drawing.Size(122, 25);
            this.txtMisafirSoyadi.TabIndex = 8;
            // 
            // txtMisafirTC
            // 
            this.txtMisafirTC.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMisafirTC.Location = new System.Drawing.Point(103, 96);
            this.txtMisafirTC.Margin = new System.Windows.Forms.Padding(2);
            this.txtMisafirTC.Name = "txtMisafirTC";
            this.txtMisafirTC.Size = new System.Drawing.Size(122, 25);
            this.txtMisafirTC.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Soyadı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "TC Kimlik No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Giriş Tarihi:";
            // 
            // btnRezIptal
            // 
            this.btnRezIptal.Location = new System.Drawing.Point(326, 382);
            this.btnRezIptal.Name = "btnRezIptal";
            this.btnRezIptal.Size = new System.Drawing.Size(105, 42);
            this.btnRezIptal.TabIndex = 14;
            this.btnRezIptal.Text = "REZERVASYON İPTAL";
            this.btnRezIptal.UseVisualStyleBackColor = true;
            this.btnRezIptal.Click += new System.EventHandler(this.btnRezIptal_Click);
            // 
            // frmRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 491);
            this.Controls.Add(this.btnRezIptal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.dtpGiris);
            this.Controls.Add(this.dgvRezervasyon);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRezervasyon";
            this.Text = "frmRezervasyon";
            this.Load += new System.EventHandler(this.frmRezervasyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRezervasyon;
        private System.Windows.Forms.DateTimePicker dtpGiris;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMisafirAdi;
        private System.Windows.Forms.TextBox txtMisafirSoyadi;
        private System.Windows.Forms.TextBox txtMisafirTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRezIptal;
    }
}
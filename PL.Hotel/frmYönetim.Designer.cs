namespace PL.Hotel
{
    partial class frmYönetim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYönetim));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsAnasayfa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsPersonelIslemleri = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsExtraTurleri = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsKasaIslemleri = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsRaporlar = new System.Windows.Forms.ToolStripButton();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.toolStrip1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1050, 46);
            this.pnlHeader.TabIndex = 6;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAnasayfa,
            this.toolStripSeparator1,
            this.tsPersonelIslemleri,
            this.toolStripSeparator2,
            this.tsExtraTurleri,
            this.toolStripSeparator3,
            this.tsKasaIslemleri,
            this.toolStripSeparator4,
            this.tsRaporlar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1050, 46);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsAnasayfa
            // 
            this.tsAnasayfa.AutoSize = false;
            this.tsAnasayfa.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tsAnasayfa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsAnasayfa.Image = ((System.Drawing.Image)(resources.GetObject("tsAnasayfa.Image")));
            this.tsAnasayfa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAnasayfa.Name = "tsAnasayfa";
            this.tsAnasayfa.Size = new System.Drawing.Size(100, 43);
            this.tsAnasayfa.Text = " &Anasayfa";
            this.tsAnasayfa.Click += new System.EventHandler(this.tsAnasayfa_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // tsPersonelIslemleri
            // 
            this.tsPersonelIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("tsPersonelIslemleri.Image")));
            this.tsPersonelIslemleri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPersonelIslemleri.Name = "tsPersonelIslemleri";
            this.tsPersonelIslemleri.Size = new System.Drawing.Size(122, 43);
            this.tsPersonelIslemleri.Text = " &Personel İşlemleri";
            this.tsPersonelIslemleri.Click += new System.EventHandler(this.tsPersonelIslemleri_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 46);
            // 
            // tsExtraTurleri
            // 
            this.tsExtraTurleri.AutoSize = false;
            this.tsExtraTurleri.Image = ((System.Drawing.Image)(resources.GetObject("tsExtraTurleri.Image")));
            this.tsExtraTurleri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsExtraTurleri.Name = "tsExtraTurleri";
            this.tsExtraTurleri.Size = new System.Drawing.Size(100, 43);
            this.tsExtraTurleri.Text = " &Extra Türleri";
            this.tsExtraTurleri.Click += new System.EventHandler(this.tsExtraTurleri_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 46);
            // 
            // tsKasaIslemleri
            // 
            this.tsKasaIslemleri.AutoSize = false;
            this.tsKasaIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("tsKasaIslemleri.Image")));
            this.tsKasaIslemleri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsKasaIslemleri.Name = "tsKasaIslemleri";
            this.tsKasaIslemleri.Size = new System.Drawing.Size(100, 43);
            this.tsKasaIslemleri.Text = " &Kasa İşlemleri";
            this.tsKasaIslemleri.Click += new System.EventHandler(this.tsKasaIslemleri_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 46);
            // 
            // tsRaporlar
            // 
            this.tsRaporlar.AutoSize = false;
            this.tsRaporlar.Image = ((System.Drawing.Image)(resources.GetObject("tsRaporlar.Image")));
            this.tsRaporlar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRaporlar.Name = "tsRaporlar";
            this.tsRaporlar.Size = new System.Drawing.Size(114, 43);
            this.tsRaporlar.Text = "&Raporlar";
            this.tsRaporlar.Click += new System.EventHandler(this.tsRaporlar_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 46);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1050, 554);
            this.pnlContent.TabIndex = 7;
            // 
            // frmYönetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmYönetim";
            this.Text = "frmYönetim";
            this.pnlHeader.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsAnasayfa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsPersonelIslemleri;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsExtraTurleri;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsKasaIslemleri;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsRaporlar;
        private System.Windows.Forms.Panel pnlContent;
    }
}
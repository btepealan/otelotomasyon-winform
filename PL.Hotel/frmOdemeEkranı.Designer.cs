namespace PL.Hotel
{
    partial class frmOdemeEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdemeEkranı));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlContent1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsMusteriOdemeleri = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsOtelOdemeleri = new System.Windows.Forms.ToolStripButton();
            this.pnlContent.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(1093, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ödeme İşlemleri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlContent.Controls.Add(this.pnlContent1);
            this.pnlContent.Controls.Add(this.toolStrip1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 80);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1093, 570);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlContent1
            // 
            this.pnlContent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent1.Location = new System.Drawing.Point(0, 44);
            this.pnlContent1.Name = "pnlContent1";
            this.pnlContent1.Size = new System.Drawing.Size(1093, 526);
            this.pnlContent1.TabIndex = 101;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMusteriOdemeleri,
            this.toolStripSeparator1,
            this.tsOtelOdemeleri});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1093, 44);
            this.toolStrip1.TabIndex = 100;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsMusteriOdemeleri
            // 
            this.tsMusteriOdemeleri.Image = ((System.Drawing.Image)(resources.GetObject("tsMusteriOdemeleri.Image")));
            this.tsMusteriOdemeleri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMusteriOdemeleri.Name = "tsMusteriOdemeleri";
            this.tsMusteriOdemeleri.Size = new System.Drawing.Size(125, 41);
            this.tsMusteriOdemeleri.Text = "&Müşteri Ödemeleri";
            this.tsMusteriOdemeleri.Click += new System.EventHandler(this.tsMusteriOdemeleri_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // tsOtelOdemeleri
            // 
            this.tsOtelOdemeleri.Image = ((System.Drawing.Image)(resources.GetObject("tsOtelOdemeleri.Image")));
            this.tsOtelOdemeleri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOtelOdemeleri.Name = "tsOtelOdemeleri";
            this.tsOtelOdemeleri.Size = new System.Drawing.Size(107, 41);
            this.tsOtelOdemeleri.Text = "&Otel Ödemeleri";
            this.tsOtelOdemeleri.Click += new System.EventHandler(this.tsOtelOdemeleri_Click);
            // 
            // frmOdemeEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 650);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmOdemeEkranı";
            this.Text = "frmOdemeEkranı";
            this.Load += new System.EventHandler(this.frmOdemeEkranı_Load);
            this.pnlContent.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsMusteriOdemeleri;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsOtelOdemeleri;
        private System.Windows.Forms.Panel pnlContent1;
    }
}
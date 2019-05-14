namespace PL.Hotel
{
    partial class frmOdalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdalar));
            this.pblHeader = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsKat1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsKat2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsKat3 = new System.Windows.Forms.ToolStripButton();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pblHeader.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pblHeader
            // 
            this.pblHeader.Controls.Add(this.toolStrip1);
            this.pblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pblHeader.Location = new System.Drawing.Point(0, 0);
            this.pblHeader.Name = "pblHeader";
            this.pblHeader.Size = new System.Drawing.Size(1000, 54);
            this.pblHeader.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsKat1,
            this.toolStripSeparator1,
            this.tsKat2,
            this.toolStripSeparator2,
            this.tsKat3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1000, 54);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsKat1
            // 
            this.tsKat1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsKat1.Image = ((System.Drawing.Image)(resources.GetObject("tsKat1.Image")));
            this.tsKat1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsKat1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsKat1.Name = "tsKat1";
            this.tsKat1.Size = new System.Drawing.Size(109, 51);
            this.tsKat1.Text = "   Kat 1";
            this.tsKat1.Click += new System.EventHandler(this.tsKat1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // tsKat2
            // 
            this.tsKat2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsKat2.Image = ((System.Drawing.Image)(resources.GetObject("tsKat2.Image")));
            this.tsKat2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsKat2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsKat2.Name = "tsKat2";
            this.tsKat2.Size = new System.Drawing.Size(109, 51);
            this.tsKat2.Text = "   Kat 2";
            this.tsKat2.Click += new System.EventHandler(this.tsKat2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // tsKat3
            // 
            this.tsKat3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsKat3.Image = ((System.Drawing.Image)(resources.GetObject("tsKat3.Image")));
            this.tsKat3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsKat3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsKat3.Name = "tsKat3";
            this.tsKat3.Size = new System.Drawing.Size(109, 51);
            this.tsKat3.Text = "   Kat 3";
            this.tsKat3.Click += new System.EventHandler(this.tsKat3_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 54);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1000, 546);
            this.pnlContent.TabIndex = 2;
            // 
            // frmOdalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOdalar";
            this.Text = "frmOdalar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOdalar_Load);
            this.pblHeader.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pblHeader;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsKat1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsKat2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsKat3;
        private System.Windows.Forms.Panel pnlContent;
    }
}
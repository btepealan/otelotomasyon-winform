namespace PL.Hotel
{
    partial class frmExtraa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExtraa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tsEkle = new System.Windows.Forms.ToolStripButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExtraTur = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.dgvExtralar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtralar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 100);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(210)))), ((int)(((byte)(125)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGuncelle,
            this.toolStripButton3,
            this.tsEkle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(346, 100);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsGuncelle
            // 
            this.tsGuncelle.AutoSize = false;
            this.tsGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(210)))), ((int)(((byte)(125)))));
            this.tsGuncelle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("tsGuncelle.Image")));
            this.tsGuncelle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsGuncelle.Name = "tsGuncelle";
            this.tsGuncelle.Size = new System.Drawing.Size(90, 100);
            this.tsGuncelle.Text = "toolStripButton2";
            this.tsGuncelle.Click += new System.EventHandler(this.tsGuncelle_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(210)))), ((int)(((byte)(125)))));
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(90, 100);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // tsEkle
            // 
            this.tsEkle.AutoSize = false;
            this.tsEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(210)))), ((int)(((byte)(125)))));
            this.tsEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEkle.Image = ((System.Drawing.Image)(resources.GetObject("tsEkle.Image")));
            this.tsEkle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEkle.Name = "tsEkle";
            this.tsEkle.Size = new System.Drawing.Size(90, 100);
            this.tsEkle.Text = "toolStripButton1";
            this.tsEkle.Click += new System.EventHandler(this.tsEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(79, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Extra";
            // 
            // txtExtraTur
            // 
            this.txtExtraTur.Location = new System.Drawing.Point(138, 327);
            this.txtExtraTur.Name = "txtExtraTur";
            this.txtExtraTur.Size = new System.Drawing.Size(112, 20);
            this.txtExtraTur.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(79, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Price";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(138, 353);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(82, 20);
            this.txtFiyat.TabIndex = 39;
            // 
            // dgvExtralar
            // 
            this.dgvExtralar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvExtralar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvExtralar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtralar.Location = new System.Drawing.Point(12, 150);
            this.dgvExtralar.Name = "dgvExtralar";
            this.dgvExtralar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExtralar.Size = new System.Drawing.Size(318, 171);
            this.dgvExtralar.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(226, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 43;
            // 
            // frmExtraa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(346, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtExtraTur);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.dgvExtralar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExtraa";
            this.Text = "frmExtraa";
            this.Load += new System.EventHandler(this.frmExtraa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtralar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExtraTur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.DataGridView dgvExtralar;
        private System.Windows.Forms.ToolStripButton tsEkle;
        private System.Windows.Forms.Label label1;
    }
}
namespace BLL.Hotel.Repositories
{
    partial class frmMusteriOdemeDetaylari
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvMusteriOdemeHareketler = new System.Windows.Forms.DataGridView();
            this.cbOdemeler = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriOdemeHareketler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 11);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 439);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(788, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 439);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(12, 439);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 11);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(210)))), ((int)(((byte)(125)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(12, 11);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(776, 53);
            this.panel5.TabIndex = 4;
            // 
            // dgvMusteriOdemeHareketler
            // 
            this.dgvMusteriOdemeHareketler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriOdemeHareketler.Location = new System.Drawing.Point(65, 119);
            this.dgvMusteriOdemeHareketler.Name = "dgvMusteriOdemeHareketler";
            this.dgvMusteriOdemeHareketler.Size = new System.Drawing.Size(678, 237);
            this.dgvMusteriOdemeHareketler.TabIndex = 5;
            // 
            // cbOdemeler
            // 
            this.cbOdemeler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOdemeler.FormattingEnabled = true;
            this.cbOdemeler.Items.AddRange(new object[] {
            "Hepsi",
            "Harcamalar",
            "Ödemeler"});
            this.cbOdemeler.Location = new System.Drawing.Point(65, 81);
            this.cbOdemeler.Name = "cbOdemeler";
            this.cbOdemeler.Size = new System.Drawing.Size(144, 21);
            this.cbOdemeler.TabIndex = 6;
            this.cbOdemeler.SelectedIndexChanged += new System.EventHandler(this.cbOdemeler_SelectedIndexChanged);
            // 
            // frmMusteriOdemeDetaylari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbOdemeler);
            this.Controls.Add(this.dgvMusteriOdemeHareketler);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMusteriOdemeDetaylari";
            this.Text = "frmMusteriOdemeDetaylari";
            this.Load += new System.EventHandler(this.frmMusteriOdemeDetaylari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriOdemeHareketler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvMusteriOdemeHareketler;
        private System.Windows.Forms.ComboBox cbOdemeler;
    }
}
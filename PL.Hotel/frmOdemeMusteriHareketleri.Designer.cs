namespace PL.Hotel
{
    partial class frmOdemeMusteriHareketleri
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
            this.dgvHareketler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHareketler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHareketler
            // 
            this.dgvHareketler.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHareketler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHareketler.Location = new System.Drawing.Point(13, 58);
            this.dgvHareketler.Name = "dgvHareketler";
            this.dgvHareketler.Size = new System.Drawing.Size(636, 185);
            this.dgvHareketler.TabIndex = 0;
            // 
            // frmOdemeMusteriHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 295);
            this.Controls.Add(this.dgvHareketler);
            this.Name = "frmOdemeMusteriHareketleri";
            this.Text = "frmOdemeMusteriHareketleri";
            this.Load += new System.EventHandler(this.frmOdemeMusteriHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHareketler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHareketler;
    }
}
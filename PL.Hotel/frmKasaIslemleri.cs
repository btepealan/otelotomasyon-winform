using BLL.Hotel.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Hotel
{
    public partial class frmKasaIslemleri : Form
    {
        public frmKasaIslemleri()
        {
            InitializeComponent();
        }
        TransTypeRepository Tr = new TransTypeRepository();
        PaymentsRepository Pr = new PaymentsRepository();
        private void frmKasaIslemleri_Load(object sender, EventArgs e)
        {
            dtpTarih.Value = DateTime.Now;
            dgvKasaHareketler.DataSource = Pr.GetAllPaymentsModelByDate(dtpTarih.Value);
            GunlukToplamlariGoster();
        }

        private void cbSorgulamaTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSorgulamaTuru.SelectedItem.ToString() == "Kasaya Giren Para")
            {
                dgvKasaHareketler.DataSource = Pr.GetAllPaymentsModelByDate(dtpTarih.Value, "Gelir");
                GunlukToplamlariGoster();

            }
            else if (cbSorgulamaTuru.SelectedItem.ToString() == "Kasadan Çıkan Para")
            {
                dgvKasaHareketler.DataSource = Pr.GetAllPaymentsModelByDate(dtpTarih.Value, "Gider");
                GunlukToplamlariGoster();

            }
            else
            {
                dgvKasaHareketler.DataSource = Pr.GetAllPaymentsModelByDate(dtpTarih.Value);
                GunlukToplamlariGoster();
            }

        }
        private void GunlukToplamlariGoster()
        {
            decimal GirenToplam = 0;
            decimal CikanToplam = 0;
            foreach (DataGridViewRow dr in dgvKasaHareketler.Rows)
            {
                GirenToplam += Convert.ToDecimal(dr.Cells[4].Value);
                CikanToplam += Convert.ToDecimal(dr.Cells[5].Value);
            }
            txtGiren.Text = string.Format("{0:#,##0}", GirenToplam);
            txtCikan.Text = string.Format("{0:#,##0}", CikanToplam);
            txtBakiye.Text = string.Format("{0:#,##0}", GirenToplam - CikanToplam);
            if (GirenToplam - CikanToplam > 0) txtBakiye.ForeColor = Color.Green;
            else if (GirenToplam - CikanToplam < 0) txtBakiye.ForeColor = Color.Red;
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            cbSorgulamaTuru.SelectedIndex = 1;
            cbSorgulamaTuru.SelectedIndex = 0;
        }
    }
}

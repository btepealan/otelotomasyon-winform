using BLL.Hotel.Repositories;
using DAL.Hotel.Context;
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
    public partial class frmMusteriOdeme : Form
    {
        public frmMusteriOdeme()
        {
            InitializeComponent();
        }
        SaleRepository Sr = new SaleRepository();
        RoomRepository Rr = new RoomRepository();
        PaymentsRepository Pr = new PaymentsRepository();
        int SalesId;
        private void cbMusteriTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbMusteriTuru.SelectedItem.ToString() == "Aktif Müşteriler")
            {
                dgvMusteriler.DataSource = Sr.GetActiveGuest();
            }
            else if (cbMusteriTuru.SelectedItem.ToString() == "Rezervasyonlu Müşteriler")
            {
                dgvMusteriler.DataSource = Sr.GetReservationGuest();

            }
        }

        private void dgvMusteriler_DoubleClick(object sender, EventArgs e)
        {
            frmMusteriOdemeDetaylari frm = new frmMusteriOdemeDetaylari();
            frm.GuestId= Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells[0].Value);
            frm.StartPosition = FormStartPosition.CenterScreen;
            
            frm.ShowDialog();
            //int GuestId = Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells[0].Value);
        }

        private void dgvMusteriler_MouseClick(object sender, MouseEventArgs e)
        {
            txtAdi.Text = (dgvMusteriler.SelectedRows[0].Cells[1].Value).ToString();
            txtSoyadi.Text = (dgvMusteriler.SelectedRows[0].Cells[2].Value).ToString();
            txtOdaNo.Text = Rr.GetRoomNo(Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells[0].Value));

            //List<decimal> liste = Pr.PaymentTransBySalesId(Sr.GetSaleIdByGuest(Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells[0].Value)));

            //txtBorc.Text = string.Format("{0:#,##0}", liste[0]);
            //txtKazanc.Text = string.Format("{0:#,##0}", liste[1]);
            //txtKalanBorc.Text = string.Format("{0:#,##0}", liste[2]);

            SalesId = Sr.GetSaleIdByGuest(Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells[0].Value));
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            //Payment pym = new Payment();
            //pym.Date = DateTime.Now;
            //pym.TransType = "Tahsilat";
            //pym.Credit = Convert.ToDecimal(txtOdenenPara.Text);
            //pym.Debt = 0;
            //pym.SalesId = SalesId;
            //pym.Status = true;
            //pym.Description = txtAciklama.Text;
            //if (Pr.PaymentsAdd(pym)) MessageBox.Show("Eklendi");
            //else MessageBox.Show("Eklenmedi");

        }

        private void dgvMusteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

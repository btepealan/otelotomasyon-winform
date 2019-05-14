using BLL.Hotel.Repositories;
using DAL.Hotel;
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
    public partial class frmCheckin : Form
    {
        public frmCheckin()
        {
            InitializeComponent();
        }
        GuestRepository Gr = new GuestRepository();
        SaleRepository Sr = new SaleRepository();
        PaymentsRepository Pr = new PaymentsRepository();
        RoomRepository Rr = new RoomRepository();
        int SId,GId,RId;
        private void btnCheckin_Click(object sender, EventArgs e)
        {
            //if (Gr.UpdateGuestStatusForCheckin(GId))
            //{
            //    if (Sr.UpdateSaleStatusForCheckin(SId))
            //    {
            //        //if (Pr.UpdatePaymentStatusForCheckin(SId))
            //        //{
            //        //    MessageBox.Show("Checkin işlemi tamamlandı.");
            //        //}
            //        //else MessageBox.Show("Payment update olmadı");
            //    }
            //    else MessageBox.Show("Sale update olmadı");
            //}
            //else MessageBox.Show("Guest update olmadı");

        }

        private void frmCheckin_Load(object sender, EventArgs e)
        {
           //DgvDuzenle(Pr.GetPaymentsByGuest(7));
            //DgvDuzenle(Pr.GetPaymentsByGuest(Sr.GetSales()));

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            //DgvDuzenle(Gr.GetGuestBySearch(txtAdaGore.Text, txtSoyadaGore.Text, txtTcyeGore.Text));
        }

        private void txtSoyadaGore_TextChanged(object sender, EventArgs e)
        {
            //DgvDuzenle(Gr.GetGuestBySearch(txtAdaGore.Text, txtSoyadaGore.Text, txtTcyeGore.Text));

        }

        private void txtTcyeGore_TextChanged(object sender, EventArgs e)
        {
            //DgvDuzenle(Gr.GetGuestBySearch(txtAdaGore.Text, txtSoyadaGore.Text, txtTcyeGore.Text));
        }

        private void dgvMusteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMusteriler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GId= Convert.ToInt32(dgvMusteriler.CurrentRow.Cells[0].Value.ToString());
            SId = Sr.GetSaleIdByGuest(GId);
            RId = Convert.ToInt32(dgvMusteriler.CurrentRow.Cells[6].Value.ToString());

            Sale SBilgileri= Sr.GetSaleById(SId);
            txtCheckin.Text = SBilgileri.CheckIn.ToShortDateString();
            txtCheckout.Text = SBilgileri.CheckOut.ToShortDateString();
            Room RBilgileri = Rr.GetRoom(RId);
            txtOdaNo.Text = RBilgileri.RoomNumber;
            txtKat.Text = RBilgileri.FloorNumber.ToString();
        }
        private void DgvDuzenle(List<PaymentModel> liste)
        {
            dgvMusteriler.DataSource = liste;
            //dgvMusteriler.Columns[0].Visible = false;
            //dgvMusteriler.Columns[5].Visible = false;
            //dgvMusteriler.Columns[6].Visible = false;

        }
    }
}

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
    public partial class frmMusteriOdemeleri : Form
    {
        public frmMusteriOdemeleri()
        {
            InitializeComponent();
        }
        TransTypeRepository Tr = new TransTypeRepository();
        GuestRepository Gr = new GuestRepository();
        RoomRepository Rr = new RoomRepository();
        PaymentsRepository Pr = new PaymentsRepository();
        GuestTransRepository Gtr = new GuestTransRepository();
        int Gid;
        private void frmMusteriOdemeleri_Load(object sender, EventArgs e)
        {
            dgvMusteriler.DataSource = Gr.GetAllGuest();
            cbGelirTurleri.DataSource = Tr.GetTransTypeByDefin("Gelir");
        }

        private void dgvMusteriler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Gid=Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells[0].Value);
            txtTcNo.Text = dgvMusteriler.SelectedRows[0].Cells[3].Value.ToString();
            txtOdaNo.Text= Rr.GetRoomNo(Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells[6].Value));

            List<decimal> liste = Gtr.PaymentsByGuest(Gid);

            txtBorc.Text = string.Format("{0:#,##0}", liste[0]);
            txtKazanc.Text = string.Format("{0:#,##0}", liste[1]);
            txtKalanBorc.Text = string.Format("{0:#,##0}", liste[2]);
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.Date = DateTime.Now;
            pay.TransType = Tr.TransIdByTransType(cbGelirTurleri.SelectedItem.ToString());
            try
            {
                pay.Incoming = Convert.ToDecimal(txtOdenen.Text);
            }
            catch (Exception)
            {
                pay.Incoming = 0;
            }
            pay.Outgoing = 0;
            pay.GuestId = Gid;
            pay.PersonnelId = General.PersonelId;
            pay.Status = true;
            pay.Description = txtAciklama.Text;

            if (Pr.AddPaymentByIncoming(pay, cbGelirTurleri.SelectedItem.ToString()))
            {
                MessageBox.Show("Ödeme işleminiz başarıyla gerçekleşti.");
                Temizle();
            }
            else MessageBox.Show("Ödeme işleminiz başarısız.", "İşlem gerçekleşmedi.");
        }

        private void Temizle()
        {
            txtOdaNo.Clear();
            txtTcNo.Clear();
            txtOdenen.Clear();
            txtAciklama.Clear();
            txtKalanBorc.Clear();
            txtKazanc.Clear();
            txtBorc.Clear();
        }
        int GId;
        private void dgvMusteriler_DoubleClick(object sender, EventArgs e)
        {
            GId=Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells[0].Value);
            frmOdemeMusteriHareketleri frm = new frmOdemeMusteriHareketleri();
            frm.GId = GId;
            frm.ShowDialog();
        }
    }
}

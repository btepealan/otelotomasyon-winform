using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL.Hotel.Repositories
{
    public partial class frmMusteriOdemeDetaylari : Form
    {
        public frmMusteriOdemeDetaylari()
        {
            InitializeComponent();
        }
        PaymentsRepository Pr = new PaymentsRepository();
        SaleRepository Sr = new SaleRepository();
        public int GuestId { get; set; }
        int SalesId;
        private void frmMusteriOdemeDetaylari_Load(object sender, EventArgs e)
        {
            SalesId = Sr.GetSaleIdByGuest(GuestId);
        }

        private void cbOdemeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbOdemeler.SelectedItem.ToString() == "Hepsi")
            //{
            //    dgvMusteriOdemeHareketler.DataSource = Pr.PaylistByGuestId(GuestId,);
            //}
            //else if (cbOdemeler.SelectedItem.ToString() == "Ödemeler")
            //{
            //    dgvMusteriOdemeHareketler.DataSource = Sr.GetReservationGuest();
            //}
            //else dgvMusteriOdemeHareketler.DataSource = Sr.GetReservationGuest();
            //dgvMusteriOdemeHareketler.DataSource = Pr.PaylistByGuestId(SalesId, cbOdemeler.SelectedItem.ToString());
        }
    }
}

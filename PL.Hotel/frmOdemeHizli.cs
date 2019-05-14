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
    public partial class frmOdemeHizli : Form
    {
        public frmOdemeHizli()
        {
            InitializeComponent();
        }
        TransTypeRepository Tr = new TransTypeRepository();
        PaymentsRepository Pr = new PaymentsRepository();
        public string Tc { get; set; }
        public int GId { get; set; }
        private void frmOdemeHizli_Load(object sender, EventArgs e)
        {
            cbGelirTurleri.DataSource = Tr.GetTransTypeByDefin("Gelir");
            txtTcNo.Text = Tc;

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
            pay.GuestId = GId;
            pay.PersonnelId = General.PersonelId;
            pay.Status = true;
            pay.Description = txtAciklama.Text;

            if (Pr.AddPaymentByIncoming(pay, cbGelirTurleri.SelectedItem.ToString()))
            {
                MessageBox.Show("Ödeme işleminiz başarıyla gerçekleşti.");
                this.Close();
            }
            else MessageBox.Show("Ödeme işleminiz başarısız.", "İşlem gerçekleşmedi.");
        }

        
    }
}

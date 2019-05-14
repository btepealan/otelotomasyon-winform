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
    public partial class frmOtelOdemeleri : Form
    {
        public frmOtelOdemeleri()
        {
            InitializeComponent();
        }

        PersonnelRepository Per = new PersonnelRepository();
        TransTypeRepository Tr = new TransTypeRepository();
        PaymentsRepository Pr = new PaymentsRepository();
        int PerId;
        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            if (cbGiderTurleri.SelectedItem.ToString() == "Maaş Ödemeleri")
            {
                if (txtPrim.Text.Trim() != "")
                {
                    Payment pay = new Payment();
                    pay.Date = DateTime.Now;
                    pay.TransType = Tr.TransIdByTransType(cbGiderTurleri.SelectedItem.ToString());
                    pay.Incoming = 0;
                    try
                    {
                        pay.Outgoing = Convert.ToDecimal(txtTutar.Text) + Convert.ToDecimal(txtPrim.Text);
                    }
                    catch (Exception)
                    {
                        pay.Outgoing = 0;
                    }

                    pay.GuestId = 0;
                    pay.PersonnelId = PerId;
                    pay.Status = true;
                    pay.Description = txtAciklama.Text;

                    if (Pr.AddPaymentByOutgoing(pay))
                    {
                        MessageBox.Show("Ödeme işleminiz başarıyla gerçekleşti.");
                        Temizle();
                    }
                    else MessageBox.Show("Ödeme işleminiz başarısız.", "İşlem gerçekleşmedi.");
                }
                else MessageBox.Show("Prim boş geçilemez.");
            }
            else
            {

                Payment pay = new Payment();
                pay.Date = DateTime.Now;
                pay.TransType = Tr.TransIdByTransType(cbGiderTurleri.SelectedItem.ToString());
                pay.Incoming = 0;
                try
                {
                    pay.Outgoing = Convert.ToDecimal(txtTutar.Text);
                }
                catch (Exception)
                {
                    pay.Outgoing = 0;
                }

                pay.GuestId = 0;
                pay.PersonnelId = 0;
                pay.Status = true;
                pay.Description = txtAciklama.Text;

                if (Pr.AddPaymentByOutgoing(pay))
                {
                    MessageBox.Show("Ödeme işleminiz başarıyla gerçekleşti.");
                    Temizle();
                }
                else MessageBox.Show("Ödeme işleminiz başarısız.", "İşlem gerçekleşmedi.");

            }

        }

        private void frmOtelOdemeleri_Load(object sender, EventArgs e)
        {
            dgvPersoneller.DataSource = Per.GetPersonnels();
            cbGiderTurleri.DataSource = Tr.GetTransTypeByDefin("Gider");
            txtPrim.Text = "0";
        }

        private void dgvPersoneller_DoubleClick(object sender, EventArgs e)
        {
            PerId = Convert.ToInt32(dgvPersoneller.SelectedRows[0].Cells[0].Value);
            txtTcNo.Text = dgvPersoneller.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void cbGelirTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Temizle()
        {
            txtTcNo.Clear();
            txtTutar.Clear();
            txtAciklama.Clear();
            txtPrim.Clear();
        }
    }
}

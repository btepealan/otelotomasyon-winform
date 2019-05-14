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
    public partial class frmOdemeEkranı : Form
    {
        public frmOdemeEkranı()
        {
            InitializeComponent();
        }
        PaymentsRepository pr = new PaymentsRepository();
        GuestRepository gr = new GuestRepository();
        RoomRepository Rp = new RoomRepository();
        SaleRepository sr = new SaleRepository();
        PersonnelRepository Pp = new PersonnelRepository();
        //int SId, GId;

        private void frmOdemeEkranı_Load(object sender, EventArgs e)
        {
            //dgvPayments.DataSource = pr.PaymentsByDate(dtpTarih.Value);
            //cbIslemTurleri.SelectedIndex = 0;
            //GunlukToplamlariGoster();
            //dtpTarih.Value = DateTime.Now;
            //dgvPayments.DataSource = pr.GetPaymentsByGuest(sr.GetSales(),txtTcKimlikNo.Text);
            frmMusteriOdemeleri frm = new frmMusteriOdemeleri();
            FormAc(frm);
        }

        
        private void FormAc(Form AF)
        {
            foreach (Control F in this.pnlContent1.Controls)
            {
                if (F is Form)
                {
                    Form MF = (Form)F;
                    MF.Close();
                }
            }
            AF.TopLevel = false;
            this.pnlContent1.Controls.Add(AF);
            AF.Dock = DockStyle.Fill;
            AF.Show();
        }

        private void tsOtelOdemeleri_Click(object sender, EventArgs e)
        {
            if (Pp.AdminControl(General.PersonelId))
            {
                frmOtelOdemeleri frm = new frmOtelOdemeleri();
                FormAc(frm);
            }
            else MessageBox.Show("Buraya Giriş Yetkiniz Bulunmamaktadır.");
        }

        private void tsMusteriOdemeleri_Click(object sender, EventArgs e)
        {
            frmMusteriOdemeleri frm = new frmMusteriOdemeleri();
            FormAc(frm);
        }     
    }
}

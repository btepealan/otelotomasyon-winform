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
    public partial class frmSatisIslemi : Form
    {
        public frmSatisIslemi()
        {
            InitializeComponent();
        }
        RoomRepository Rp = new RoomRepository();
        SaleRepository Sp = new SaleRepository();
        GuestRepository Gp = new GuestRepository();
        GuestTransRepository Gtp = new GuestTransRepository();
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public string OdaNo { get; set; }
        public int Gid { get; set; }
        public decimal ToplamTutar { get; set; }

        //private void btnOdaSec_Click(object sender, EventArgs e)
        //{
        //    frmOdaSec frm = new frmOdaSec();
        //    frm.ShowDialog();
        //    txtOdaNo.Text = OdaNo;
        //    txtGirisTarihi.Text = Giris.ToShortDateString();
        //    txtCikisTarihi.Text = Cikis.ToShortDateString();
        //    TimeSpan fark = Cikis - Giris;
        //    int gunsayisi = fark.Days;
        //    decimal OdaFiyat = Rp.GetRoomPrice(OdaNo);
        //    txtToplamTutar.Text = ((gunsayisi + 1) * OdaFiyat).ToString();
        //}

        private void btnOnayla_Click(object sender, EventArgs e)
        {

            //if (txtAdi.Text.Trim() == "" || txtSoyadi.Text == "" || txtTc.Text == "")
            //{
            //    MessageBox.Show("Zorunlu alanlar girilmedi.", "Dikkat Eksik Bilgi!");
            //}
            
            Sale sa = new Sale();
            sa.RoomId = Rp.GetRoomId(OdaNo);
            sa.CheckIn = Giris;
            sa.CheckOut = Cikis;
            sa.NoOfGuests = 1;
            sa.TotalPrice = ToplamTutar;
            sa.PersonnelId = General.PersonelId;
            sa.GuestId = Gid;
            if (Giris.Date == DateTime.Now.Date) { sa.Status = true; }
            else sa.Status = false;
            Sp.AddSales(sa);

            GuestTransaction gtrans = new GuestTransaction();
            gtrans.Date = DateTime.Now;
            /*if (Giris.Date == DateTime.Now.Date)*/  gtrans.TransType = "Konaklama Ücreti"; 
            //else { gtrans.TransType = "Rezervasyon Ücreti"; }

            gtrans.Debt = ToplamTutar;
            gtrans.Credit = 0;
            gtrans.GuestId = Gid;
            gtrans.Status = true;
            if (Giris.Date == DateTime.Now.Date) gtrans.Description = "Konaklama Açılış";
            else { gtrans.Description = "Rezervasyon"; }
            if (Gtp.AddGTrans(gtrans))
            { MessageBox.Show("Kayıt yapıldı"); }
            else { MessageBox.Show("Kayıt yapılmadı"); }

        }

        private void frmSatisIslemi_Load(object sender, EventArgs e)
        {
            txtToplamTutar.Text = ToplamTutar.ToString();
            txtOdaNo.Text = OdaNo;
            txtGirisTarihi.Text = Giris.ToShortDateString();
            txtCikisTarihi.Text = Cikis.ToShortDateString();
        }
    }
}

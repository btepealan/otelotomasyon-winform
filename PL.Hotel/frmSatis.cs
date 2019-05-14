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
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        RoomRepository Rp = new RoomRepository();
        SaleRepository Sp = new SaleRepository();
        GuestRepository Gp = new GuestRepository();
        GuestTransRepository GTrans = new GuestTransRepository();
        public static DateTime Giris { get; set; }
        public static DateTime Cikis { get; set; }
        public static string OdaNo { get; set; }
        public decimal ToplamTutar { get; set; }
         
        int Gid;
        private void frmSatis_Load(object sender, EventArgs e)
        {
            //dgvMusteriler.DataSource = Gp.GetAllGuest();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            //dgvMusteriler.DataSource = Gp.GetAllGuest();
            //Temizle();
        }
        private void Temizle()
        {
            //foreach(Control item in panel2.Controls)
            //{
            //    if(item is TextBox)
            //    {
            //        item.Text = "";
            //    }
            //}
            //txtAdi.Clear();
            //txtSoyadi.Clear();
            //txtTc.Clear();
            //txtAdres.te
        }

        private void dgvMusteriler_DoubleClick(object sender, EventArgs e)
        {
            //Gid = Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells[0].Value);
            frmSatisIslemi frm = new frmSatisIslemi();
            frm.Gid = Gid;
            frm.Giris = Giris;
            frm.Cikis = Cikis;
            frm.OdaNo = OdaNo;
            frm.ToplamTutar = ToplamTutar;
            frm.Show();
        }

        private void btnOdaSec_Click(object sender, EventArgs e)
        {
            frmOdaSec frm = new frmOdaSec();
            frm.ShowDialog();
            TimeSpan fark = Cikis - Giris;
            int gunsayisi = fark.Days;
            decimal OdaFiyat = Rp.GetRoomPrice(OdaNo);
            ToplamTutar = ((gunsayisi+1) * OdaFiyat);
            txtToplamTutar.Text = ToplamTutar.ToString();
            txtOdaNo.Text = OdaNo;
            txtGirisTarihi.Text = Giris.ToShortDateString();
            txtCikisTarihi.Text = Cikis.ToShortDateString();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text.Trim() == "" || txtSoyadi.Text == "" || txtTc.Text == "")
            {
                MessageBox.Show("Zorunlu alanlar girilmedi.", "Dikkat Eksik Bilgi!");
            }
            Guest gue = new Guest();
           
                gue.FirstName = txtAdi.Text;
                gue.LastName = txtSoyadi.Text;

            gue.IdentificationNo = txtTc.Text;
            gue.RoomId = Rp.GetRoomId(OdaNo);
            gue.Adress = txtAdres.Text;
            gue.Gender = cbCinsiyet.SelectedItem.ToString();
            gue.Birthday = dtpDogumTarihi.Value;
            gue.ContactNo = txtTelefon.Text;
            gue.Email = txtEmail.Text;
            if (Giris.Date == DateTime.Now.Date) { gue.Status = true; }
            else { gue.Status = false; }
            if (Gp.AddGuest(gue))
            {
                Guest gst = Gp.GetGuest();
                Sale sa = new Sale();
                sa.RoomId = gst.RoomId;
                sa.CheckIn = Giris;
                sa.CheckOut = Cikis;
                sa.NoOfGuests = Convert.ToInt32(cbMisafirSayisi.SelectedItem.ToString());
                try
                {
                    sa.TotalPrice = ToplamTutar;
                }
                catch (FormatException)
                {
                    throw;
                }
                if (Giris.Date == DateTime.Now.Date) sa.Status = true;
                else { sa.Status = false; }
                sa.PersonnelId = General.PersonelId;
                sa.GuestId = gst.Id;
                if (Sp.AddSales(sa))
                {
                    GuestTransaction Gtr = new GuestTransaction();
                    Gtr.Date = DateTime.Now;
                    /*if (Giris.Date == DateTime.Now.Date)*/
                    Gtr.TransType = "Konaklama Ücreti";
                    //else { gtrans.TransType = "Rezervasyon Ücreti"; }
                    try
                    {
                        Gtr.Debt = ToplamTutar;
                    }
                    catch (FormatException)
                    {
                        throw;
                    }
                    Gtr.Credit = 0;
                    Gtr.GuestId = gst.Id;
                    Gtr.Status = true;
                    if (Giris.Date == DateTime.Now.Date) Gtr.Description = "Konaklama Açılış";
                    else { Gtr.Description = "Rezervasyon"; }
                    if (GTrans.AddGTrans(Gtr))
                    { MessageBox.Show("Kayıt yapıldı"); }
                    else MessageBox.Show("Misafir harekeleri oluşturulamadı");

                }
                else MessageBox.Show("Satış Yapılamadı");
            }
            else MessageBox.Show("Yapılmadı");
        }
    }
}

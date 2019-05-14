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
    public partial class frmCheckOut : Form
    {
        public frmCheckOut()
        {
            InitializeComponent();
        }
        PaymentsRepository pr = new PaymentsRepository();
        GuestRepository gr = new GuestRepository();
        SaleRepository sr = new SaleRepository();
        RoomRepository rr = new RoomRepository();
        GuestTransRepository gtr = new GuestTransRepository();
        CheckOutRepo Cr = new CheckOutRepo();
        string TcKimlikNo;
        int GId,RId,SId;
        decimal GerekliOdeme;
        Font fntBaslik = new Font("Times New Roman", 16, FontStyle.Bold);
        Font fntIcerik = new Font("Times New Roman", 12, FontStyle.Regular);
        SolidBrush sb = new SolidBrush(Color.Black);
        private void frmCheckOut_Load(object sender, EventArgs e)
        {

        }

        private void btnBorcSorgula_Click(object sender, EventArgs e)
        {

            //List<Decimal> pay = pr.PaymentTransBySalesId(sr.GetSaleIdByGuest(gr.GetGuestIdByTC(txtTKCNO.Text)));
            //if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && txtTKCNO.Text.Trim() != "" && txtOdaNo.Text.Trim() != "")
            //{
            //    txtBorc.Text = pay[0].ToString();
            //    txtKazanc.Text = pay[1].ToString();
            //    txtKalanBorc.Text = pay[2].ToString();
            //}
            //else
            //    MessageBox.Show("Eksik Bilgi Girdiniz");


        }

        private void btnCikisOnayla_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtKalanBorc.Text) == 0)
            {

                if (Cr.NormalCheckOut(GId,RId))
                {
                    MessageBox.Show("Çıkış işlemi tamamlandı");

                }
                else MessageBox.Show("Çıkış İşlemi Tamamlanamadı");
            }
            else
                MessageBox.Show("Sistemde kayıtlı borç görünmekte");
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        { 
            frmOdemeHizli frm = new frmOdemeHizli();
            frm.GId = GId;
            frm.Tc = TcKimlikNo;
            frm.ShowDialog();
            Guest gst = gr.GetGuestByTC(txtTcNo.Text);
            dgvExtralar.DataSource = gtr.GetExtrasByGuestId(gst);
            BorcSorgula();
            //    FormAcikmi(frm);

        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            btnCheckout.Visible = true;
            btnErkenCikis.Visible = true;
            TcKimlikNo = txtTcNo.Text;
            if (txtTcNo.Text.Trim() != "")
            {
                Guest gst = gr.GetGuestByTC(txtTcNo.Text);
                GId = gst.Id;
                RId = gst.RoomId;
                
                if (gst == null)
                {
                    MessageBox.Show("Bu Tc Kimlik No'ya sahip birisi bulunamadı.");
                }
                else
                {
                    dgvExtralar.DataSource = gtr.GetExtrasByGuestId(gst);
                    BorcSorgula();
                }
                
            }
            else MessageBox.Show("Eksik Bilgi Girişi !");
        }
        private void BorcSorgula()
        {
            decimal GirenToplam = 0;
            decimal CikanToplam = 0;
            foreach (DataGridViewRow dr in dgvExtralar.Rows)
            {
                GirenToplam += Convert.ToDecimal(dr.Cells[5].Value);
                CikanToplam += Convert.ToDecimal(dr.Cells[6].Value);
            }
            txtBorc.Text = string.Format("{0:#,##0}", GirenToplam);
            txtKazanc.Text = string.Format("{0:#,##0}", CikanToplam);
            txtKalanBorc.Text = string.Format("{0:#,##0}", GirenToplam - CikanToplam);
        }
        private void dgvExtralar_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void btnErkenCikis_Click(object sender, EventArgs e)
        {
            txtKonaklamaBorc.Visible = true;
            txtExtraBorc.Visible = true;
            btnCikisOnayla.Enabled = false;
            btnOnayla2.Enabled = true;
            decimal KonaklamaOdenen=0,ExtraOdenen=0,ExtraHarcanan=0;

            Sale sl =sr.GetSaleByGuest(GId);
            TimeSpan fark = DateTime.Now.Date - sl.CheckIn.Date;
            int GunSayisi = fark.Days;
            decimal OdaFiyat = rr.GetRoomPrice(rr.GetRoomNo(RId));
            //Ödenmesi gereken Konaklama Fiyatı
            GerekliOdeme = (GunSayisi+1) * OdaFiyat;
            foreach (DataGridViewRow dr in dgvExtralar.Rows)
            {
                if(dr.Cells[4].Value.ToString()=="Konaklama Ücreti")
                {
                    KonaklamaOdenen+= Convert.ToDecimal(dr.Cells[6].Value);
                }
            }
            foreach (DataGridViewRow dr1 in dgvExtralar.Rows)
            {
                if (dr1.Cells[4].Value.ToString() == "Extra Ücreti")
                {
                    ExtraHarcanan += Convert.ToDecimal(dr1.Cells[5]);
                    ExtraOdenen += Convert.ToDecimal(dr1.Cells[6].Value);
                }
            }
            txtKonaklamaBorc.Text = (GerekliOdeme-KonaklamaOdenen).ToString();
            txtExtraBorc.Text=(ExtraHarcanan-ExtraOdenen).ToString();
        }

        private void btnOnayla2_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtKonaklamaBorc.Text) == 0 && Convert.ToDecimal(txtExtraBorc.Text) == 0)
            {
                if (Cr.EarlyCheckOut(GId, RId, GerekliOdeme))
                {
                    MessageBox.Show("CheckOut işlemi başarıyla gerçekleşti");
                }
                else MessageBox.Show("Ödeme Gerçekleşmedi");
            }
            else MessageBox.Show("Ödenmemiş borç bulunmaktadır.");
        }
        #region FaturaYazdır        

        private void pdocFatura_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            List<GuestTransaction> liste = new List<GuestTransaction>();
            liste = gtr.GetGTransByGuestId(GId);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), fntBaslik, sb, 700, 50);
            e.Graphics.DrawString("Ödeme Bilgileri ", fntBaslik, sb, 300, 100);
            //e.Graphics.DrawString("Adı:  " + txtAdi.Text, fntBaslik, sb, 50, 150);
            //e.Graphics.DrawString("Soyadı:  " + txtSoyadi.Text, fntBaslik, sb, 50, 200);
            e.Graphics.DrawString("TC            Tarih        İşlem Tipi         Borç      Ödenen     Acıklama", fntBaslik, sb, 50, 250);
            e.Graphics.DrawString("_______________________________________________________________________", fntBaslik, sb, 50, 300);

            for (int i = 0; i < liste.Count; i++)
            {
                e.Graphics.DrawString(TcKimlikNo, fntIcerik, sb, 50, 400 + (30 * i));
                e.Graphics.DrawString(liste[i].Date.ToShortDateString(), fntIcerik, sb, 160, 400 + (30 * i));
                e.Graphics.DrawString(liste[i].TransType.ToString(), fntIcerik, sb, 290, 400 + (30 * i));
                e.Graphics.DrawString(liste[i].Debt.ToString(), fntIcerik, sb, 400, 400 + (30 * i));
                e.Graphics.DrawString(liste[i].Credit.ToString(), fntIcerik, sb, 500, 400 + (30 * i));
                e.Graphics.DrawString(liste[i].Description.ToString(), fntIcerik, sb, 600, 400 + (30 * i));
            }

        }


        private void btnYazdır_Click(object sender, EventArgs e)
        {
            ppdiaFatura.ShowDialog();
        }

        #endregion


        //private void FormAcikmi(Form AcilacakForm)
        //{
        //    bool Varmi = false;
        //    for (int i = 0; i < this.MdiChildren.Length; i++)
        //    {
        //        if (AcilacakForm.Name == MdiChildren[i].Name)
        //        {
        //            MdiChildren[i].Focus();
        //            Varmi = true;
        //        }
        //    }
        //    if (Varmi == false)
        //    {
        //        AcilacakForm.MdiParent = this;
        //        AcilacakForm.Show();
        //    }
        //    else
        //    {
        //        AcilacakForm.Dispose();
        //    }
        //}
    }
}

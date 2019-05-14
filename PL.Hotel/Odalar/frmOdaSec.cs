using BLL.Hotel.Repositories;
using DAL.Hotel.Context;
using PL.Hotel.Odalar;
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
    public partial class frmOdaSec : Form
    {
        public frmOdaSec()
        {
            InitializeComponent();
        }
        SaleRepository ss = new SaleRepository();
        RoomRepository rr = new RoomRepository();
        DateTime Gara;
        DateTime Cara;
        int FNo;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormAc(Form AF)
        {
            foreach (Control F in this.pnlContent.Controls)
            {
                if (F is Form)
                {
                    Form MF = (Form)F;
                    MF.Close();
                }
            }
            AF.TopLevel = false;
            this.pnlContent.Controls.Add(AF);
            AF.Dock = DockStyle.Fill;
            AF.Show();
            if (pnlContent.Controls == null) { this.Close(); }
            
        }

        private void tsKat1_Click(object sender, EventArgs e)
        {
            frmKat1Sec frm = new frmKat1Sec();
            FormAc(frm);
            

        }

        private void frmOdaSec_Load(object sender, EventArgs e)
        {
            frmKat1Sec frm = new frmKat1Sec();
            FormAc(frm);

        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsKat2_Click(object sender, EventArgs e)
        {
            frmKat2Sec frm = new frmKat2Sec();
            FormAc(frm);
        }

        private void tsKat3_Click(object sender, EventArgs e)
        {
            frmKat3Sec frm = new frmKat3Sec();
            FormAc(frm);
        }

        //private void dtpGirisAra_ValueChanged(object sender, EventArgs e)
        //{
        //    Gara = dtpGirisAra.Value;
        //    Cara = dtpCikisAra.Value;
        //    OdalarıGetir(Gara, Cara);
        //}

        //private void dtpCikisAra_ValueChanged(object sender, EventArgs e)
        //{
        //    Gara = dtpGirisAra.Value;
        //    Cara = dtpCikisAra.Value;
        //    OdalarıGetir(Gara, Cara);
        //}
        //private void OdalarıGetir(DateTime g, DateTime c)
        //{
        //    List<DateTime> Gunler = new List<DateTime>();
        //    DateTime q = g.Date;
        //    for (int j = 0; j <= (c.Date - g.Date).TotalDays; j++)
        //    {
        //        Gunler.Add(q);
        //        q = q.Date.AddDays(1);
        //    }

        //    foreach (Room item in rr.GetRooms())
        //    {
        //        item.State = false;
        //    }
        //    //List<int> Dolular = new List<int>();
        //    foreach (Sale S in ss.GetSales())
        //    {
        //        foreach (DateTime dt in Gunler)
        //        {
        //            if (dt.Date >= S.CheckIn.Date && dt.Date <= S.CheckOut.Date)
        //            {
        //                foreach (Room item in rr.GetRooms())
        //                {
        //                    if (S.RoomId == item.Id) { item.State = true; }
        //                }
        //                //Dolular.Add(S.RoomId);
        //            }
        //        }
        //    }
        //    foreach (Control item in pnlContent.Controls)
        //    {
        //        if (item is Button)
        //        {
        //            foreach (Room rm in rr.GetRooms())
        //            {
        //                if (rm.RoomNumber == item.Text)
        //                {
        //                    if (rm.State) { item.BackgroundImage = ımageList1.Images[0]; item.ForeColor = Color.DarkRed;item.BackColor = Color.LightSalmon; }
        //                    else {item.BackgroundImage = ımageList1.Images[1]; item.ForeColor = Color.DarkOliveGreen; item.BackColor = Color.GreenYellow; }
        //                }
        //            }
        //        }
        //    }
        //}

        //private void btn101_Click(object sender, EventArgs e)
        //{
        //    //string odano = (sender as Button).Text;
        //    //frmSatis frmSatis = new frmSatis();
        //    //frmSatis.OdaNo = odano;
        //    //frmSatis.Giris = Gara;
        //    //frmSatis.Cikis = Cara;
        //    //this.Close();
        //}

        //private void btn102_Click(object sender, EventArgs e)
        //{
        //    string odano = (sender as Button).Text;
        //    frmSatis frmSatis = new frmSatis();
        //    frmSatis.OdaNo = odano;
        //    frmSatis.Giris = Gara;
        //    frmSatis.Cikis = Cara;
        //    this.Close();
        //}

        //private void btn103_Click(object sender, EventArgs e)
        //{
        //    string odano = (sender as Button).Text;
        //    frmSatis frmSatis = new frmSatis();
        //    frmSatis.OdaNo = odano;
        //    frmSatis.Giris = Gara;
        //    frmSatis.Cikis = Cara;
        //    this.Close();
        //}

        //private void btn104_Click(object sender, EventArgs e)
        //{
        //    string odano = (sender as Button).Text;
        //    frmSatis frmSatis = new frmSatis();
        //    frmSatis.OdaNo = odano;
        //    frmSatis.Giris = Gara;
        //    frmSatis.Cikis = Cara;
        //    this.Close();
        //}

        //private void btn105_Click(object sender, EventArgs e)
        //{
        //    string odano = (sender as Button).Text;
        //    frmSatis frmSatis = new frmSatis();
        //    frmSatis.OdaNo = odano;
        //    frmSatis.Giris = Gara;
        //    frmSatis.Cikis = Cara;
        //    this.Close();
        //}
    }
}

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
    public partial class frmOdalar : Form
    {
        public frmOdalar()
        {
            InitializeComponent();
        }
        //SaleRepository ss = new SaleRepository();
        //RoomRepository rr = new RoomRepository();
        //DateTime Gara=DateTime.Now;
        //DateTime Cara=DateTime.Now.AddDays(1);
        //private void frmOdalar_Load(object sender, EventArgs e)
        //{
            
        //    Gara = dtpGirisAra.Value;
        //    Cara = dtpCikisAra.Value;
        //    OdalarıGetir(Gara, Cara.AddDays(1));
        //}
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
        //        if (item is Label)
        //        {
        //            foreach (Room rm in rr.GetRooms())
        //            {
        //                if (rm.RoomNumber == item.Name.Substring(1))
        //                {
        //                    if (rm.State) item.BackColor = Color.Red;
        //                    else item.BackColor = Color.GreenYellow;
        //                }
        //            }
        //        }
        //    }
        //}

        //private void pnlContent_Paint(object sender, PaintEventArgs e)
        //{

        //}

        private void tsKat1_Click(object sender, EventArgs e)
        {
            frmKat1 frm = new frmKat1();
            FormAc(frm);
        }

        private void frmOdalar_Load(object sender, EventArgs e)
        {
            frmKat1 frm = new frmKat1();
            FormAc(frm);
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
        }

        private void tsKat2_Click(object sender, EventArgs e)
        {
            frmKat2 frm = new frmKat2();
            FormAc(frm);
        }

        private void tsKat3_Click(object sender, EventArgs e)
        {
            frmKat3 frm = new frmKat3();
            FormAc(frm);
        }
    }
}

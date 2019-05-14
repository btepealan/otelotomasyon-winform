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

namespace PL.Hotel.Odalar
{
    public partial class frmKat2Sec : Form
    {
        public frmKat2Sec()
        {
            InitializeComponent();
        }
        SaleRepository ss = new SaleRepository();
        RoomRepository rr = new RoomRepository();
        DateTime Gara;
        DateTime Cara;
        private void frmKat2Sec_Load(object sender, EventArgs e)
        {
            Gara = dtpGirisAra.Value;
            Cara = dtpCikisAra.Value;
            OdalarıGetir(Gara, Cara);
        }

        private void dtpGirisAra_ValueChanged(object sender, EventArgs e)
        {
            Gara = dtpGirisAra.Value;
            Cara = dtpCikisAra.Value;
            OdalarıGetir(Gara, Cara);
        }

        private void dtpCikisAra_ValueChanged(object sender, EventArgs e)
        {
            Gara = dtpGirisAra.Value;
            Cara = dtpCikisAra.Value;
            OdalarıGetir(Gara, Cara);
        }
        private void OdalarıGetir(DateTime g, DateTime c)
        {
            List<DateTime> Gunler = new List<DateTime>();
            DateTime q = g.Date;
            for (int j = 0; j <= (c.Date - g.Date).TotalDays; j++)
            {
                Gunler.Add(q);
                q = q.Date.AddDays(1);
            }

            foreach (Room item in rr.GetRoomsByFloor(2))
            {
                item.State = false;
            }
            //List<int> Dolular = new List<int>();
            foreach (Sale S in ss.GetSales())
            {
                foreach (DateTime dt in Gunler)
                {
                    if (dt.Date >= S.CheckIn.Date && dt.Date <= S.CheckOut.Date)
                    {
                        foreach (Room item in rr.GetRoomsByFloor(2))
                        {
                            if (S.RoomId == item.Id) { item.State = true; }
                        }
                        //Dolular.Add(S.RoomId);
                    }
                }
            }
            foreach (Control item in pnlOdasec2.Controls)
            {
                if (item is Button)
                {
                    foreach (Room rm in rr.GetRoomsByFloor(2))
                    {
                        if (rm.RoomNumber == item.Text)
                        {
                            if (rm.State) { item.BackgroundImage = ımageList1.Images[0]; item.ForeColor = Color.DarkRed; item.BackColor = Color.LightSalmon; }
                            else { item.BackgroundImage = ımageList1.Images[1]; item.ForeColor = Color.DarkOliveGreen; item.BackColor = Color.GreenYellow; }
                        }
                    }
                }
            }
        }
        private void btn201_Click(object sender, EventArgs e)
        {
            string odano = (sender as Button).Text;
            frmSatis frmSatis = new frmSatis();
            frmSatis.OdaNo = odano;
            frmSatis.Giris = Gara;
            frmSatis.Cikis = Cara;
            txtOdaNo.Text = odano;
        }
    }
}

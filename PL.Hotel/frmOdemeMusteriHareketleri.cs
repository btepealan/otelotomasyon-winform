using BLL.Hotel.Repositories;
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
    public partial class frmOdemeMusteriHareketleri : Form
    {
        public frmOdemeMusteriHareketleri()
        {
            InitializeComponent();
        }
        GuestTransRepository Gt = new GuestTransRepository();
        public int GId { get; set; }
        private void frmOdemeMusteriHareketleri_Load(object sender, EventArgs e)
        {
            dgvHareketler.DataSource = Gt.GetGTransByGuestId(GId);
            dgvHareketler.Columns[0].Visible = false;
            dgvHareketler.Columns[5].Visible = false;
            dgvHareketler.Columns[6].Visible = false;
            dgvHareketler.Columns[8].Visible = false;
        }
    }
}

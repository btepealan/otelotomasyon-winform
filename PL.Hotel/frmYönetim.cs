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
    public partial class frmYönetim : Form
    {
        public frmYönetim()
        {
            InitializeComponent();
        }
        PersonnelRepository Pp = new PersonnelRepository();
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
        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pnlContent.Controls.Clear();
            //frmPersonel frm = new frmPersonel();
            //frm.TopLevel = false;
            //pnlContent.Controls.Add(frm);
            //frm.Show();
            //frm.Dock = DockStyle.Fill;
            //frm.BringToFront();
            //frm.tsGuncelle.Enabled = false;
            //frm.tsSil.Enabled = false;
            frmPersonel frm = new frmPersonel();
            FormAc(frm);
        }

        private void personelGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            frmPersonel frm = new frmPersonel();
            frm.TopLevel = false;
            pnlContent.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.tsEkle.Enabled = false;
            frm.tsSil.Enabled = false;
        }

        private void personelSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            frmPersonel frm = new frmPersonel();
            frm.TopLevel = false;
            pnlContent.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.tsGuncelle.Enabled = false;
            frm.tsEkle.Enabled = false;
        }

        private void ekstraEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            frmExtraa frm = new frmExtraa();
            frm.TopLevel = false;
            pnlContent.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            //frm.tsGuncelle.Enabled = false;
            //frm.tsSil.Enabled = false;

        }

        private void ekstraGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            frmExtraa frm = new frmExtraa();
            frm.TopLevel = false;
            pnlContent.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            //frm.tsEkle.Enabled = false;
            //frm.tsSil.Enabled = false;
        }

        private void ekstraSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            frmExtraa frm = new frmExtraa();
            frm.TopLevel = false;
            pnlContent.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            //frm.tsGuncelle.Enabled = false;
            //frm.tsEkle.Enabled = false;
        }

        private void tsAnasayfa_Click(object sender, EventArgs e)
        {
            frmOtelAnasayfa frm = new frmOtelAnasayfa();
            frm.Show();
        }

        private void tsPersonelIslemleri_Click(object sender, EventArgs e)
        {
            if (Pp.AdminControl(General.PersonelId))
            {
                frmPersonel frm = new frmPersonel();
                FormAc(frm);
            }
            else MessageBox.Show("Buraya Giriş Yetkiniz Bulunmamaktadır.");
        }

        private void tsExtraTurleri_Click(object sender, EventArgs e)
        {
            frmExtraa frm = new frmExtraa();
            FormAc(frm);
        }

        private void tsKasaIslemleri_Click(object sender, EventArgs e)
        {
            if (Pp.AdminControl(General.PersonelId))
            {
                frmKasaDuzenlemeler frm = new frmKasaDuzenlemeler();
                FormAc(frm);
            }
            else MessageBox.Show("Buraya Giriş Yetkiniz Bulunmamaktadır.");
            
        }

        private void tsRaporlar_Click(object sender, EventArgs e)
        {
            if (Pp.AdminControl(General.PersonelId))
            {
                frmRaporlar frm = new frmRaporlar();
                FormAc(frm);
            }
            else MessageBox.Show("Buraya Giriş Yetkiniz Bulunmamaktadır.");
            
        }
    }
}

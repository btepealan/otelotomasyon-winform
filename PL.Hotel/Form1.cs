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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OtelResContext ent = new OtelResContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            ent.Database.CreateIfNotExists();

            if (checkBox1.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var sonuc = (from p in ent.Personnel
                         where p.Uname == txtKullaniciAdi.Text && p.Upwd == txtSifre.Text
                         select p);

            if (sonuc.Count() > 0)
            {
                frmOtelAnasayfa frm = new frmOtelAnasayfa();

                foreach (Personnel item in sonuc)
                {
                    General.PersonelAdi = item.PersonName;
                    General.PersonelId = item.Id;
                }

                frm.Show();
                this.Hide();
                //MessageBox.Show("Giriş Yaptınız");
            }
            else MessageBox.Show("Giriş Yapamadınız");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

       
    }
}


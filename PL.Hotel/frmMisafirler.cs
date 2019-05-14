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
    public partial class frmMisafirler : Form
    {
        public frmMisafirler()
        {
            InitializeComponent();
        }
        RoomRepository Rr = new RoomRepository();
        GuestRepository Gr = new GuestRepository();
        SaleRepository Sr = new SaleRepository();
        int OdaId,GId;
        private void frmMisafirler_Load(object sender, EventArgs e)
        {

        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (txtOdaAra.Text.Trim() != "")
            {
                OdaId = Rr.GetRoomId(txtOdaAra.Text);
                GridDuzenle(Gr.GetGuestsInRoom(OdaId));
            }
            else MessageBox.Show("Eksik bilgi girdiniz.");
        }
        private void GridDuzenle(List<Guest> list)
        {
            dgvMisafirListesi.DataSource = list;
            dgvMisafirListesi.Columns[0].Visible = false;
            dgvMisafirListesi.Columns[5].Visible = false;
            dgvMisafirListesi.Columns[6].Visible = false;
            dgvMisafirListesi.Columns[11].Visible = false;
        }
        private void dgvMisafirListesi_DoubleClick(object sender, EventArgs e)
        {
            GId = Convert.ToInt32(dgvMisafirListesi.SelectedRows[0].Cells[0].Value);
            txtMisafirAdi.Text=dgvMisafirListesi.SelectedRows[0].Cells[1].Value.ToString();
            dtpMisafirDogumTarihi.Value= Convert.ToDateTime(dgvMisafirListesi.SelectedRows[0].Cells[8].Value);
            txtMisafirSoyadi.Text = dgvMisafirListesi.SelectedRows[0].Cells[2].Value.ToString();
            txtMisafirTC.Text = dgvMisafirListesi.SelectedRows[0].Cells[3].Value.ToString();
            txtTelefon.Text = dgvMisafirListesi.SelectedRows[0].Cells[9].Value == null ? "" : dgvMisafirListesi.SelectedRows[0].Cells[9].Value.ToString();
            txtMail.Text = dgvMisafirListesi.SelectedRows[0].Cells[10].Value == null ? "" : dgvMisafirListesi.SelectedRows[0].Cells[10].Value.ToString();
            txtAdres.Text = dgvMisafirListesi.SelectedRows[0].Cells[7].Value == null ? "" : dgvMisafirListesi.SelectedRows[0].Cells[7].Value.ToString();
            cbMisafirCinsiyet.SelectedIndex = -1;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtMisafirAdi.Text.Trim() != "" && txtMisafirSoyadi.Text.Trim() != "" && txtMisafirTC.Text.Trim() != "")
            {
                Guest gst = new Guest();
                gst.FirstName = txtMisafirAdi.Text;
                gst.LastName = txtMisafirSoyadi.Text;
                gst.IdentificationNo = txtMisafirTC.Text;
                gst.RoomId = OdaId;
                gst.ContactNo = txtTelefon.Text;
                gst.Email = txtMail.Text;
                gst.Gender = cbMisafirCinsiyet.SelectedItem.ToString();
                gst.Status = true;
                gst.Adress = txtAdres.Text;
                gst.Birthday = dtpMisafirDogumTarihi.Value;
                gst.Deleted = false;

                if (Gr.AddGuest(gst))
                {
                    GridDuzenle(Gr.GetGuestsInRoom(OdaId));
                    Temizle();
                }
            }
            else MessageBox.Show("Eksik bilgi girdiniz.");
        }
        private void Temizle()
        {
            txtOdaAra.Clear();
            txtMisafirAdi.Clear();
            txtMisafirSoyadi.Clear();
            txtMisafirTC.Clear();
            txtTelefon.Clear();
            txtMail.Clear();
            txtAdres.Clear();
            txtMisafirAdi.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Gr.Delete(GId))
                {
                    MessageBox.Show("Ziyaretçi bilgileri silindi.", "Silme gerçekleşti.");
                    GridDuzenle(Gr.GetGuestsInRoom(OdaId));
                    Temizle();
                }
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (txtMisafirAdi.Text.Trim() != "" && txtMisafirSoyadi.Text.Trim() != "" && txtMisafirTC.Text.Trim() != "")
            {
                Guest gt = new Guest();
                gt.IdentificationNo = txtMisafirTC.Text;
                gt.Id = GId;
                if (Gr.UpdateControl(gt)) { MessageBox.Show("Başka kişiye ait Tc Kimlik No girdiniz,"); Temizle(); }
                else
                {
                    gt.FirstName = txtMisafirAdi.Text;
                    gt.LastName = txtMisafirSoyadi.Text;
                    gt.RoomId = OdaId;
                    gt.ContactNo = txtTelefon.Text;
                    gt.Email = txtMail.Text;

                    gt.Gender = cbMisafirCinsiyet.SelectedItem.ToString();
                    gt.Status = true;
                    gt.Adress = txtAdres.Text;
                    gt.Birthday = dtpMisafirDogumTarihi.Value;

                    if (Gr.UpdateGuest(gt))
                    {
                        GridDuzenle(Gr.GetGuestsInRoom(OdaId));
                        Temizle();
                    }
                }
                
            }
            else MessageBox.Show("Eksik bilgi girdiniz.");
        }
    }
}

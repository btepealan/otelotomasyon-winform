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
    public partial class frmExtraIslemler : Form
    {
        public frmExtraIslemler()
        {
            InitializeComponent();
        }
        RoomRepository Rr = new RoomRepository();
        SaleRepository Sr = new SaleRepository();
        ExtraRepository Er = new ExtraRepository();
        GuestRepository Gr = new GuestRepository();
        ExtraType ET = new ExtraType();
        int RId,GId,ExtraTypeId;
        private void frmExtraIslemler_Load(object sender, EventArgs e)
        {
            cbEkstra.DataSource = Er.GetExtraTypes();
            txtDate.Text = DateTime.Now.ToShortDateString();
            SatisListe = Sr.GetSaleforFullRoom(DateTime.Now);
            GridDuzenle(Rr.GetFullRooms(SatisListe));
        }

        private void txtUnit_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUnit.Text))
            {
                txtSum.Text = (Convert.ToInt32(txtUnit.Text) * Convert.ToDecimal(txtPrice.Text)).ToString();
            }
            else
            {
                txtSum.Clear();
            }
        }
        private void GridDuzenle(List<Room> liste)
        {
            dgvOdalar.DataSource = liste;
            dgvOdalar.Columns[0].Visible = false;
            dgvOdalar.Columns[1].Width = 100;
            dgvOdalar.Columns[1].HeaderText = "      Oda No";
            dgvOdalar.Columns[1].DefaultCellStyle.Alignment =DataGridViewContentAlignment.MiddleCenter;
            dgvOdalar.Columns[2].Visible = false;
            dgvOdalar.Columns[3].Visible = false;
            dgvOdalar.Columns[4].Visible = false;
            dgvOdalar.Columns[5].Visible = false;


        }
        private void cbEkstra_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExtraTypeId = (cbEkstra.SelectedItem as ExtraType).Id;
            if (cbEkstra.SelectedIndex != -1)
            {
                txtPrice.Text = (cbEkstra.SelectedItem as ExtraType).Price.ToString();
            }
        }
        List<Sale> SatisListe = new List<Sale>();
        private void btnAdminn_Click(object sender, EventArgs e)
        {
            if (GId != 0)
            {
                dgvOdalar.Visible = true;
                groupBox1.Visible = true;
                dgvExtralar.Visible = true;
                txtDegisenAdet.Visible = true;
                txtDegisenTutar.Visible = true;
                btnDuzenle.Visible = true;
                btnSil.Visible = true;
                label10.Visible = true;
                label9.Visible = true;
                numDegisenAdet.Visible = true;
                Guest guestt = Gr.GetGuestById(GId);
                txtAdi.Text = guestt.FirstName;
                txtSoyad.Text = guestt.LastName;
                GridDuzenle2(Er.GetExtraTransactions(GId));
            }
            else MessageBox.Show("Lütfen Oda Seçiniz.");
            
        }
        private void GridDuzenle2(List<ExtraTransactions> listex)
        {
            dgvExtralar.DataSource = listex;
            dgvExtralar.Columns[0].Visible = false;
            dgvExtralar.Columns[1].Visible = false;
            dgvExtralar.Columns[2].Visible = false;
            dgvExtralar.Columns[6].Visible = false;
            dgvExtralar.Columns[7].Visible = false;
            dgvExtralar.Columns[8].Visible = false;
            dgvExtralar.Columns[10].Visible = false;

        }
        private void nudAdet_ValueChanged(object sender, EventArgs e)
        {
            txtUnit.Text = nudAdet.Value.ToString();
            txtSum.Text = (Convert.ToDecimal(txtPrice.Text) * Convert.ToDecimal(txtUnit.Text)).ToString();
        }
        private void Temizle()
        {
            txtDate.Clear();
            txtPrice.Clear();
            txtSum.Clear();
            txtUnit.Clear();
        }
        int ExId,TypId,RmId,ExGId;
        DateTime Exdt;

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Er.DeleteExtra(ExId))
                {
                    MessageBox.Show("Ziyaretçi bilgileri silindi.", "Silme gerçekleşti.");
                    GridDuzenle2(Er.GetExtraTransactions(GId));
                    Temizle();
                }
            }
        }

        private void dgvExtralar_DoubleClick(object sender, EventArgs e)
        {
            ExId = Convert.ToInt32(dgvExtralar.SelectedRows[0].Cells[0].Value);
            TypId = Convert.ToInt32(dgvExtralar.SelectedRows[0].Cells[1].Value);
            RmId = Convert.ToInt32(dgvExtralar.SelectedRows[0].Cells[2].Value);
            ExGId = Convert.ToInt32(dgvExtralar.SelectedRows[0].Cells[8].Value);
            Exdt = Convert.ToDateTime(dgvExtralar.SelectedRows[0].Cells[5].Value);
            txtDegisenAdet.Text = dgvExtralar.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void numDegisenAdet_ValueChanged(object sender, EventArgs e)
        {
            txtDegisenAdet.Text = numDegisenAdet.Value.ToString();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (txtDegisenAdet.Text.Trim() != "" && txtDegisenTutar.Text.Trim() != "" && ExId !=0)
            {
                ExtraTransactions ext = new ExtraTransactions();
                ext.Id = ExId;
                ext.RoomId = RmId;
                ext.TransactionDate = Exdt;
                ext.TypeId = TypId;
                ext.GuestId = ExGId;
                ext.Status = true;
                ext.Deleted = false;
                ext.Unit=Convert.ToInt32(txtDegisenAdet.Text);
                ext.Sum = Convert.ToDecimal(txtDegisenTutar.Text);

                if (Er.UpdateExtraTrans(ext))
                {
                    MessageBox.Show("Eklendi");
                    GridDuzenle2(Er.GetExtraTransactions(GId));

                }
                else MessageBox.Show("Düzenleme İşlemi Başarısız oldu.");
            }
            else MessageBox.Show("Eksik Bilgi Girişi");
        }

        private void btnOda_Click(object sender, EventArgs e)
        {
            if (txtOdaNo.Text.Trim() != "")
            {
                ExtraTransactions ex = new ExtraTransactions();
                ex.TypeId = ExtraTypeId;
                ex.RoomId = RId;
                ex.GuestId = GId;
                try
                {
                    ex.Unit = Convert.ToInt32(txtUnit.Text);

                }
                catch (Exception)
                {

                    throw;
                }
                try
                {
                    ex.Sum = Convert.ToDecimal(txtSum.Text);

                }
                catch (Exception)
                {

                    throw;
                }
                ex.TransactionDate = DateTime.Now;
                ex.Status = true;
                ex.Deleted = false;

                if (Er.AddExtraAndGTrans(ex, GId))
                {
                    MessageBox.Show("Extra harcaması yapıldı.");
                    Temizle();
                }
                else MessageBox.Show("İşlem gerçekleşmedi.");

            }
            else MessageBox.Show("Lütfen Oda Bilgilerini seçiniz.");
        }

        private void dgvOdalar_DoubleClick(object sender, EventArgs e)
        {
            RId = Convert.ToInt32(dgvOdalar.SelectedRows[0].Cells[0].Value);
            txtOdaNo.Text = dgvOdalar.SelectedRows[0].Cells[1].Value.ToString();
            foreach (Sale item in SatisListe)
            {
                if (item.RoomId == RId) GId = item.GuestId;
            }
        }
    }
}

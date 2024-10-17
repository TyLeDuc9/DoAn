using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TyNhanLongKhoi_BUS;
using TyNhanLongKhoi_DAL;

namespace TyNhanLongKhoi_GUI
{
    public partial class frmDocGia : DevExpress.XtraEditors.XtraForm
    {
        public frmDocGia()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            DocGia docGia = new DocGia();
            docGia.MaDocGia = txtMaDocGia.Text;
            docGia.SoThe = txtSoThe.Text;
            docGia.TenDocGia = txtHoTenDocGia.Text;
            docGia.SDT = txtSDTDocGia.Text;
            docGia.Email = txtEmailDocGia.Text;
            docGia.DiaChi = txtDiaChi.Text;

            docGiaLibrary.InsertOrUpdate(docGia);


            var listDocGias = docGiaLibrary.GetAll();
            LayDanhSachDocGia(listDocGias);
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {

            var listDocGias = docGiaLibrary.GetAll();
            LayDanhSachDocGia(listDocGias);
        }
        private void LayDanhSachDocGia(List<DocGia> listDocGia)
        {

            dgvDocGia.Rows.Clear();
            foreach (var item in listDocGia)
            {
                int index = dgvDocGia.Rows.Add();
                dgvDocGia.Rows[index].Cells[0].Value = item.MaDocGia;
                dgvDocGia.Rows[index].Cells[1].Value = item.SoThe;
                dgvDocGia.Rows[index].Cells[2].Value = item.TenDocGia;
                dgvDocGia.Rows[index].Cells[3].Value = item.SDT;
                dgvDocGia.Rows[index].Cells[4].Value = item.Email;
                dgvDocGia.Rows[index].Cells[5].Value = item.DiaChi;

            }
        }
        private DocGiaLibrary docGiaLibrary = new DocGiaLibrary();

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DocGia docGia = new DocGia();
            docGia.MaDocGia = txtMaDocGia.Text;
            docGiaLibrary.Delete(docGia);
            var listDocGia = docGiaLibrary.GetAll();
            LayDanhSachDocGia(listDocGia);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có muốn thoát", "Confirm", MessageBoxButtons.YesNo
              , MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMaDocGia.Text = dgvDocGia.SelectedRows[0].Cells[0].Value.ToString();
            DocGia docGia = docGiaLibrary.FindById(txtMaDocGia.Text);
            if (docGia != null)
            {
                txtSoThe.Text = docGia.SoThe;
                txtHoTenDocGia.Text = docGia.TenDocGia;
                txtSDTDocGia.Text = docGia.SDT;
                txtEmailDocGia.Text = docGia.Email;
                txtDiaChi.Text = docGia.DiaChi;

            }
        }
    }
}
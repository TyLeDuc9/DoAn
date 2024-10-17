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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private NhanVienLibrary nhanVienLibrary = new NhanVienLibrary();

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

            var listNhanViens = nhanVienLibrary.GetAll();
            LayDanhSachNhanVien(listNhanViens);

        }
        private void LayDanhSachNhanVien(List<NhanVien> listNhanVien)
        {

            dgvNhanVien.Rows.Clear();
            foreach (var item in listNhanVien)
            {
                int index = dgvNhanVien.Rows.Add();
                dgvNhanVien.Rows[index].Cells[0].Value = item.MaNhanVien;
                dgvNhanVien.Rows[index].Cells[1].Value = item.HoTen;
                dgvNhanVien.Rows[index].Cells[2].Value = item.NgaySinh;
                dgvNhanVien.Rows[index].Cells[3].Value = item.Email;
                dgvNhanVien.Rows[index].Cells[4].Value = item.SDT;
                dgvNhanVien.Rows[index].Cells[5].Value = item.GioiTinh;


            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            NhanVien nhanVien = new NhanVien();
            nhanVien.MaNhanVien = txtMaNhanVien.Text;
            //nhanVien.NgaySinh = txtNgaySinh.Text;
            nhanVien.HoTen = txtHoTenNhanVien.Text;
            nhanVien.Email = txtEmailNhanVien.Text;
            nhanVien.SDT = txtSDTNhanVien.Text;
            nhanVien.GioiTinh = cbGioiTinh.Text;


            nhanVienLibrary.InsertOrUpdate(nhanVien);


            var listNhanViens = nhanVienLibrary.GetAll();
            LayDanhSachNhanVien(listNhanViens);
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMaNhanVien.Text = dgvNhanVien.SelectedRows[0].Cells[0].Value.ToString();
            NhanVien nhanVien = nhanVienLibrary.FindById(txtMaNhanVien.Text);
            if (nhanVien != null)
            {
                txtMaNhanVien.Text = nhanVien.MaNhanVien;

                txtHoTenNhanVien.Text = nhanVien.HoTen;
                txtEmailNhanVien.Text = nhanVien.Email;
                txtSDTNhanVien.Text = nhanVien.SDT;
                cbGioiTinh.Text = nhanVien.GioiTinh;



            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            NhanVien nhanVien = new NhanVien();
            nhanVien.MaNhanVien = txtMaNhanVien.Text;
            nhanVienLibrary.Delete(nhanVien);
            var listNhanVien = nhanVienLibrary.GetAll();
            LayDanhSachNhanVien(listNhanVien);
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
    }
}
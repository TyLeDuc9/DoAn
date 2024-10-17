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
    public partial class frmTacGia : DevExpress.XtraEditors.XtraForm
    {
        public frmTacGia()
        {
            InitializeComponent();
        }
        private TacGiaLibrary tacGiaLibrary= new TacGiaLibrary();

        private void grbQuanLyNhanVien_Enter(object sender, EventArgs e)
        {

        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {

            var listTacGias = tacGiaLibrary.GetAll();
            LayDanhSachTacGia(listTacGias);
        }
        private void LayDanhSachTacGia(List<TacGia> listTacGia)
        {

            dgvTacGia.Rows.Clear();
            foreach (var item in listTacGia)
            {
                int index = dgvTacGia.Rows.Add();
                dgvTacGia.Rows[index].Cells[0].Value = item.MaTacGia;
                dgvTacGia.Rows[index].Cells[1].Value = item.TenTacGia;
                dgvTacGia.Rows[index].Cells[2].Value = item.DiaChi;
                dgvTacGia.Rows[index].Cells[3].Value = item.Email;
                dgvTacGia.Rows[index].Cells[4].Value = item.SDT;
            }
        }

        private void dgvTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMaTacGia.Text = dgvTacGia.SelectedRows[0].Cells[0].Value.ToString();
            TacGia tacGia= tacGiaLibrary.FindById(txtMaTacGia.Text);
            if (tacGia != null)
            {

                txtMaTacGia.Text = tacGia.MaTacGia;
                txtTenTacGia.Text = tacGia.TenTacGia;
                txtDiaChi.Text=tacGia.DiaChi;
                txtEmail.Text = tacGia.Email;
                txtSDT.Text = tacGia.SDT;

      
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TacGia tacGia=new TacGia();
            tacGia.MaTacGia=txtMaTacGia.Text;
            tacGia.TenTacGia = txtTenTacGia.Text;
            tacGia.DiaChi = txtDiaChi.Text;
            tacGia.Email = txtEmail.Text;
            tacGia.SDT = txtSDT.Text;
            tacGiaLibrary.InsertOrUpdate(tacGia);


            var listTacGias = tacGiaLibrary.GetAll();
            LayDanhSachTacGia(listTacGias);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

             TacGia tacGia=new TacGia();
             tacGia.MaTacGia = txtMaTacGia.Text;
             tacGiaLibrary.Delete(tacGia);
             var listTacGia=tacGiaLibrary.GetAll();
             LayDanhSachTacGia(listTacGia);
            
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
namespace TyNhanLongKhoi_GUI
{
    partial class frmTacGia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTacGia));
            this.dgvTacGia = new System.Windows.Forms.DataGridView();
            this.MDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiemNhanVien = new System.Windows.Forms.TextBox();
            this.lblTimKiemSach = new System.Windows.Forms.Label();
            this.grbTimKiemSach = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenTacGia = new System.Windows.Forms.TextBox();
            this.txtMaTacGia = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.grbQuanLyNhanVien = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).BeginInit();
            this.grbTimKiemSach.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbQuanLyNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTacGia
            // 
            this.dgvTacGia.AllowUserToAddRows = false;
            this.dgvTacGia.AllowUserToDeleteRows = false;
            this.dgvTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MDG,
            this.HT,
            this.SDT,
            this.GT,
            this.NS});
            this.dgvTacGia.Location = new System.Drawing.Point(5, 362);
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.ReadOnly = true;
            this.dgvTacGia.RowHeadersWidth = 51;
            this.dgvTacGia.RowTemplate.Height = 24;
            this.dgvTacGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTacGia.Size = new System.Drawing.Size(807, 196);
            this.dgvTacGia.TabIndex = 42;
            this.dgvTacGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTacGia_CellClick);
            // 
            // MDG
            // 
            this.MDG.HeaderText = "Mã Tác Giả";
            this.MDG.MinimumWidth = 6;
            this.MDG.Name = "MDG";
            this.MDG.ReadOnly = true;
            this.MDG.Width = 125;
            // 
            // HT
            // 
            this.HT.HeaderText = "Họ Tên Tác Giả";
            this.HT.MinimumWidth = 6;
            this.HT.Name = "HT";
            this.HT.ReadOnly = true;
            this.HT.Width = 125;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "Địa Chỉ";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 125;
            // 
            // GT
            // 
            this.GT.HeaderText = "Email";
            this.GT.MinimumWidth = 6;
            this.GT.Name = "GT";
            this.GT.ReadOnly = true;
            this.GT.Width = 125;
            // 
            // NS
            // 
            this.NS.HeaderText = "SDT";
            this.NS.MinimumWidth = 6;
            this.NS.Name = "NS";
            this.NS.ReadOnly = true;
            this.NS.Width = 125;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(592, 20);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 30);
            this.btnTimKiem.TabIndex = 16;
            this.btnTimKiem.Text = "Tìm Kiếm";
            // 
            // txtTimKiemNhanVien
            // 
            this.txtTimKiemNhanVien.Location = new System.Drawing.Point(340, 22);
            this.txtTimKiemNhanVien.Name = "txtTimKiemNhanVien";
            this.txtTimKiemNhanVien.Size = new System.Drawing.Size(233, 25);
            this.txtTimKiemNhanVien.TabIndex = 13;
            // 
            // lblTimKiemSach
            // 
            this.lblTimKiemSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemSach.ForeColor = System.Drawing.Color.Black;
            this.lblTimKiemSach.Location = new System.Drawing.Point(36, 24);
            this.lblTimKiemSach.Name = "lblTimKiemSach";
            this.lblTimKiemSach.Size = new System.Drawing.Size(298, 23);
            this.lblTimKiemSach.TabIndex = 0;
            this.lblTimKiemSach.Text = "Nhập thông tin (tên hoặc mã nhân viên )";
            this.lblTimKiemSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbTimKiemSach
            // 
            this.grbTimKiemSach.BackColor = System.Drawing.Color.LightBlue;
            this.grbTimKiemSach.Controls.Add(this.btnTimKiem);
            this.grbTimKiemSach.Controls.Add(this.txtTimKiemNhanVien);
            this.grbTimKiemSach.Controls.Add(this.lblTimKiemSach);
            this.grbTimKiemSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTimKiemSach.ForeColor = System.Drawing.Color.Red;
            this.grbTimKiemSach.Location = new System.Drawing.Point(5, 290);
            this.grbTimKiemSach.Name = "grbTimKiemSach";
            this.grbTimKiemSach.Size = new System.Drawing.Size(807, 66);
            this.grbTimKiemSach.TabIndex = 41;
            this.grbTimKiemSach.TabStop = false;
            this.grbTimKiemSach.Text = "Tìm Kiếm";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(5, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 70);
            this.panel1.TabIndex = 40;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(645, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(126, 45);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.ImageOptions.Image")));
            this.btnCapNhat.Location = new System.Drawing.Point(444, 13);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(126, 45);
            this.btnCapNhat.TabIndex = 16;
            this.btnCapNhat.Text = "Cập Nhật";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(238, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(126, 45);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(54, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(126, 45);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm/Sửa";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.Black;
            this.lblTen.Location = new System.Drawing.Point(421, 45);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(104, 17);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Họ Tên Tác Giả";
            this.lblTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChi.Location = new System.Drawing.Point(152, 103);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(233, 18);
            this.txtDiaChi.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Location = new System.Drawing.Point(536, 103);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(233, 18);
            this.txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(461, 103);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 17);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSDT
            // 
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSDT.Location = new System.Drawing.Point(151, 155);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(233, 18);
            this.txtSDT.TabIndex = 3;
            // 
            // txtTenTacGia
            // 
            this.txtTenTacGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenTacGia.Location = new System.Drawing.Point(541, 44);
            this.txtTenTacGia.Name = "txtTenTacGia";
            this.txtTenTacGia.Size = new System.Drawing.Size(233, 18);
            this.txtTenTacGia.TabIndex = 2;
            // 
            // txtMaTacGia
            // 
            this.txtMaTacGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaTacGia.Location = new System.Drawing.Point(150, 44);
            this.txtMaTacGia.Name = "txtMaTacGia";
            this.txtMaTacGia.Size = new System.Drawing.Size(233, 18);
            this.txtMaTacGia.TabIndex = 1;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.Color.Black;
            this.lblSDT.Location = new System.Drawing.Point(36, 156);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(92, 17);
            this.lblSDT.TabIndex = 4;
            this.lblSDT.Text = "Số Điện Thoại";
            this.lblSDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.Color.Black;
            this.lblDiaChi.Location = new System.Drawing.Point(75, 103);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(53, 17);
            this.lblDiaChi.TabIndex = 3;
            this.lblDiaChi.Text = "Địa Chỉ";
            this.lblDiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacGia.ForeColor = System.Drawing.Color.Black;
            this.lblTacGia.Location = new System.Drawing.Point(64, 45);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(79, 17);
            this.lblTacGia.TabIndex = 1;
            this.lblTacGia.Text = "Mã Tác Giả";
            this.lblTacGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbQuanLyNhanVien
            // 
            this.grbQuanLyNhanVien.BackColor = System.Drawing.Color.LightBlue;
            this.grbQuanLyNhanVien.Controls.Add(this.txtDiaChi);
            this.grbQuanLyNhanVien.Controls.Add(this.txtEmail);
            this.grbQuanLyNhanVien.Controls.Add(this.lblEmail);
            this.grbQuanLyNhanVien.Controls.Add(this.txtSDT);
            this.grbQuanLyNhanVien.Controls.Add(this.txtTenTacGia);
            this.grbQuanLyNhanVien.Controls.Add(this.txtMaTacGia);
            this.grbQuanLyNhanVien.Controls.Add(this.lblSDT);
            this.grbQuanLyNhanVien.Controls.Add(this.lblDiaChi);
            this.grbQuanLyNhanVien.Controls.Add(this.lblTen);
            this.grbQuanLyNhanVien.Controls.Add(this.lblTacGia);
            this.grbQuanLyNhanVien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbQuanLyNhanVien.ForeColor = System.Drawing.Color.Red;
            this.grbQuanLyNhanVien.Location = new System.Drawing.Point(5, 3);
            this.grbQuanLyNhanVien.Name = "grbQuanLyNhanVien";
            this.grbQuanLyNhanVien.Size = new System.Drawing.Size(807, 205);
            this.grbQuanLyNhanVien.TabIndex = 39;
            this.grbQuanLyNhanVien.TabStop = false;
            this.grbQuanLyNhanVien.Text = "Tác Giả";
            this.grbQuanLyNhanVien.Enter += new System.EventHandler(this.grbQuanLyNhanVien_Enter);
            // 
            // frmTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 560);
            this.Controls.Add(this.dgvTacGia);
            this.Controls.Add(this.grbTimKiemSach);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbQuanLyNhanVien);
            this.Name = "frmTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tác Giả";
            this.Load += new System.EventHandler(this.frmTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).EndInit();
            this.grbTimKiemSach.ResumeLayout(false);
            this.grbTimKiemSach.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.grbQuanLyNhanVien.ResumeLayout(false);
            this.grbQuanLyNhanVien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTacGia;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemNhanVien;
        private System.Windows.Forms.Label lblTimKiemSach;
        private System.Windows.Forms.GroupBox grbTimKiemSach;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenTacGia;
        private System.Windows.Forms.TextBox txtMaTacGia;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.GroupBox grbQuanLyNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn HT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NS;
    }
}
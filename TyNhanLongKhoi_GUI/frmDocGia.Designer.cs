namespace TyNhanLongKhoi_GUI
{
    partial class frmDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocGia));
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.txtSoThe = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.MDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.grbQuanLyDocGia = new System.Windows.Forms.GroupBox();
            this.txtEmailDocGia = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSDTDocGia = new System.Windows.Forms.TextBox();
            this.txtHoTenDocGia = new System.Windows.Forms.TextBox();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblSoThe = new System.Windows.Forms.Label();
            this.lblHoTenDocGia = new System.Windows.Forms.Label();
            this.lblMaDocGia = new System.Windows.Forms.Label();
            this.txtTimKiemSach = new System.Windows.Forms.TextBox();
            this.lblTimKiemSach = new System.Windows.Forms.Label();
            this.grbTimKiemSach = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.grbQuanLyDocGia.SuspendLayout();
            this.grbTimKiemSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(648, 13);
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
            this.btnCapNhat.Location = new System.Drawing.Point(437, 13);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(126, 45);
            this.btnCapNhat.TabIndex = 16;
            this.btnCapNhat.Text = "Cập Nhật";
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(39, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(126, 45);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm/Sửa";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(9, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 70);
            this.panel1.TabIndex = 36;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(241, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(126, 45);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtSoThe
            // 
            this.txtSoThe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoThe.Location = new System.Drawing.Point(541, 34);
            this.txtSoThe.Name = "txtSoThe";
            this.txtSoThe.Size = new System.Drawing.Size(233, 18);
            this.txtSoThe.TabIndex = 14;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChi.Location = new System.Drawing.Point(541, 135);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(233, 18);
            this.txtDiaChi.TabIndex = 13;
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.AllowUserToAddRows = false;
            this.dgvDocGia.AllowUserToDeleteRows = false;
            this.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MDG,
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column3});
            this.dgvDocGia.Location = new System.Drawing.Point(5, 339);
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.ReadOnly = true;
            this.dgvDocGia.RowHeadersWidth = 51;
            this.dgvDocGia.RowTemplate.Height = 24;
            this.dgvDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocGia.Size = new System.Drawing.Size(799, 209);
            this.dgvDocGia.TabIndex = 34;
            this.dgvDocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocGia_CellClick);
            // 
            // MDG
            // 
            this.MDG.HeaderText = "Mã ĐG";
            this.MDG.MinimumWidth = 6;
            this.MDG.Name = "MDG";
            this.MDG.ReadOnly = true;
            this.MDG.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Số Thẻ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số ĐT";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Email";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Địa Chỉ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.Color.Black;
            this.lblDiaChi.Location = new System.Drawing.Point(434, 136);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(53, 17);
            this.lblDiaChi.TabIndex = 12;
            this.lblDiaChi.Text = "Địa Chỉ";
            this.lblDiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbQuanLyDocGia
            // 
            this.grbQuanLyDocGia.AutoSize = true;
            this.grbQuanLyDocGia.BackColor = System.Drawing.Color.LightBlue;
            this.grbQuanLyDocGia.Controls.Add(this.txtSoThe);
            this.grbQuanLyDocGia.Controls.Add(this.txtDiaChi);
            this.grbQuanLyDocGia.Controls.Add(this.lblDiaChi);
            this.grbQuanLyDocGia.Controls.Add(this.txtEmailDocGia);
            this.grbQuanLyDocGia.Controls.Add(this.lblEmail);
            this.grbQuanLyDocGia.Controls.Add(this.txtSDTDocGia);
            this.grbQuanLyDocGia.Controls.Add(this.txtHoTenDocGia);
            this.grbQuanLyDocGia.Controls.Add(this.txtMaDocGia);
            this.grbQuanLyDocGia.Controls.Add(this.lblSDT);
            this.grbQuanLyDocGia.Controls.Add(this.lblSoThe);
            this.grbQuanLyDocGia.Controls.Add(this.lblHoTenDocGia);
            this.grbQuanLyDocGia.Controls.Add(this.lblMaDocGia);
            this.grbQuanLyDocGia.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbQuanLyDocGia.ForeColor = System.Drawing.Color.Red;
            this.grbQuanLyDocGia.Location = new System.Drawing.Point(9, 8);
            this.grbQuanLyDocGia.Name = "grbQuanLyDocGia";
            this.grbQuanLyDocGia.Size = new System.Drawing.Size(799, 177);
            this.grbQuanLyDocGia.TabIndex = 33;
            this.grbQuanLyDocGia.TabStop = false;
            this.grbQuanLyDocGia.Text = "Độc Giả";
            // 
            // txtEmailDocGia
            // 
            this.txtEmailDocGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailDocGia.Location = new System.Drawing.Point(146, 134);
            this.txtEmailDocGia.Name = "txtEmailDocGia";
            this.txtEmailDocGia.Size = new System.Drawing.Size(233, 18);
            this.txtEmailDocGia.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(45, 135);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 17);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSDTDocGia
            // 
            this.txtSDTDocGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSDTDocGia.Location = new System.Drawing.Point(541, 83);
            this.txtSDTDocGia.Name = "txtSDTDocGia";
            this.txtSDTDocGia.Size = new System.Drawing.Size(233, 18);
            this.txtSDTDocGia.TabIndex = 7;
            // 
            // txtHoTenDocGia
            // 
            this.txtHoTenDocGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoTenDocGia.Location = new System.Drawing.Point(146, 83);
            this.txtHoTenDocGia.Name = "txtHoTenDocGia";
            this.txtHoTenDocGia.Size = new System.Drawing.Size(233, 18);
            this.txtHoTenDocGia.TabIndex = 3;
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaDocGia.Location = new System.Drawing.Point(146, 34);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(233, 18);
            this.txtMaDocGia.TabIndex = 1;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.Color.Black;
            this.lblSDT.Location = new System.Drawing.Point(434, 84);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(92, 17);
            this.lblSDT.TabIndex = 4;
            this.lblSDT.Text = "Số Điện Thoại";
            this.lblSDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoThe
            // 
            this.lblSoThe.AutoSize = true;
            this.lblSoThe.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoThe.ForeColor = System.Drawing.Color.Black;
            this.lblSoThe.Location = new System.Drawing.Point(434, 35);
            this.lblSoThe.Name = "lblSoThe";
            this.lblSoThe.Size = new System.Drawing.Size(50, 17);
            this.lblSoThe.TabIndex = 3;
            this.lblSoThe.Text = "Số Thẻ";
            this.lblSoThe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoTenDocGia
            // 
            this.lblHoTenDocGia.AutoSize = true;
            this.lblHoTenDocGia.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTenDocGia.ForeColor = System.Drawing.Color.Black;
            this.lblHoTenDocGia.Location = new System.Drawing.Point(45, 84);
            this.lblHoTenDocGia.Name = "lblHoTenDocGia";
            this.lblHoTenDocGia.Size = new System.Drawing.Size(53, 17);
            this.lblHoTenDocGia.TabIndex = 2;
            this.lblHoTenDocGia.Text = "Họ Tên";
            this.lblHoTenDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaDocGia
            // 
            this.lblMaDocGia.AutoSize = true;
            this.lblMaDocGia.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDocGia.ForeColor = System.Drawing.Color.Black;
            this.lblMaDocGia.Location = new System.Drawing.Point(45, 35);
            this.lblMaDocGia.Name = "lblMaDocGia";
            this.lblMaDocGia.Size = new System.Drawing.Size(81, 17);
            this.lblMaDocGia.TabIndex = 1;
            this.lblMaDocGia.Text = "Mã Độc Giả";
            this.lblMaDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTimKiemSach
            // 
            this.txtTimKiemSach.Location = new System.Drawing.Point(318, 20);
            this.txtTimKiemSach.Name = "txtTimKiemSach";
            this.txtTimKiemSach.Size = new System.Drawing.Size(233, 25);
            this.txtTimKiemSach.TabIndex = 13;
            // 
            // lblTimKiemSach
            // 
            this.lblTimKiemSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemSach.ForeColor = System.Drawing.Color.Black;
            this.lblTimKiemSach.Location = new System.Drawing.Point(45, 20);
            this.lblTimKiemSach.Name = "lblTimKiemSach";
            this.lblTimKiemSach.Size = new System.Drawing.Size(298, 23);
            this.lblTimKiemSach.TabIndex = 0;
            this.lblTimKiemSach.Text = "Nhập thông tin (tên hoặc mã độc giả )";
            this.lblTimKiemSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbTimKiemSach
            // 
            this.grbTimKiemSach.BackColor = System.Drawing.Color.LightBlue;
            this.grbTimKiemSach.Controls.Add(this.btnTimKiem);
            this.grbTimKiemSach.Controls.Add(this.txtTimKiemSach);
            this.grbTimKiemSach.Controls.Add(this.lblTimKiemSach);
            this.grbTimKiemSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTimKiemSach.ForeColor = System.Drawing.Color.Red;
            this.grbTimKiemSach.Location = new System.Drawing.Point(9, 267);
            this.grbTimKiemSach.Name = "grbTimKiemSach";
            this.grbTimKiemSach.Size = new System.Drawing.Size(799, 66);
            this.grbTimKiemSach.TabIndex = 35;
            this.grbTimKiemSach.TabStop = false;
            this.grbTimKiemSach.Text = "Tìm Kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(569, 17);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 30);
            this.btnTimKiem.TabIndex = 16;
            this.btnTimKiem.Text = "Tìm Kiếm";
            // 
            // frmDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDocGia);
            this.Controls.Add(this.grbQuanLyDocGia);
            this.Controls.Add(this.grbTimKiemSach);
            this.Name = "frmDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Độc Giả";
            this.Load += new System.EventHandler(this.frmDocGia_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.grbQuanLyDocGia.ResumeLayout(false);
            this.grbQuanLyDocGia.PerformLayout();
            this.grbTimKiemSach.ResumeLayout(false);
            this.grbTimKiemSach.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.TextBox txtSoThe;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DataGridView dgvDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.GroupBox grbQuanLyDocGia;
        private System.Windows.Forms.TextBox txtEmailDocGia;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSDTDocGia;
        private System.Windows.Forms.TextBox txtHoTenDocGia;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblSoThe;
        private System.Windows.Forms.Label lblHoTenDocGia;
        private System.Windows.Forms.Label lblMaDocGia;
        private System.Windows.Forms.TextBox txtTimKiemSach;
        private System.Windows.Forms.Label lblTimKiemSach;
        private System.Windows.Forms.GroupBox grbTimKiemSach;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
    }
}
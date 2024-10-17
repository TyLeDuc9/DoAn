namespace TyNhanLongKhoi_GUI
{
    partial class frmMuonTraSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuonTraSach));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.grbPhieuMuonSach = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNhanVienLapPhieu = new System.Windows.Forms.Label();
            this.lblMuon = new System.Windows.Forms.Label();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.txtTimKiemSach = new System.Windows.Forms.TextBox();
            this.lblTimKiemSach = new System.Windows.Forms.Label();
            this.lblChiTiet = new System.Windows.Forms.Label();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSach = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.grbTimKiemSach = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.grbPhieuMuonSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSach)).BeginInit();
            this.grbTimKiemSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(9, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 70);
            this.panel1.TabIndex = 37;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(646, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(126, 45);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.ImageOptions.Image")));
            this.btnCapNhat.Location = new System.Drawing.Point(443, 13);
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
            this.btnXoa.Location = new System.Drawing.Point(241, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(126, 45);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(42, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(126, 45);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm/Sửa";
            // 
            // grbPhieuMuonSach
            // 
            this.grbPhieuMuonSach.BackColor = System.Drawing.Color.LightBlue;
            this.grbPhieuMuonSach.Controls.Add(this.textBox2);
            this.grbPhieuMuonSach.Controls.Add(this.txtGhiChu);
            this.grbPhieuMuonSach.Controls.Add(this.label2);
            this.grbPhieuMuonSach.Controls.Add(this.dateTimePicker2);
            this.grbPhieuMuonSach.Controls.Add(this.dateTimePicker1);
            this.grbPhieuMuonSach.Controls.Add(this.label1);
            this.grbPhieuMuonSach.Controls.Add(this.lblMaSach);
            this.grbPhieuMuonSach.Controls.Add(this.txtTinhTrang);
            this.grbPhieuMuonSach.Controls.Add(this.textBox1);
            this.grbPhieuMuonSach.Controls.Add(this.lblNhanVienLapPhieu);
            this.grbPhieuMuonSach.Controls.Add(this.lblMuon);
            this.grbPhieuMuonSach.Controls.Add(this.lblMaPhieu);
            this.grbPhieuMuonSach.Location = new System.Drawing.Point(9, 44);
            this.grbPhieuMuonSach.Name = "grbPhieuMuonSach";
            this.grbPhieuMuonSach.Size = new System.Drawing.Size(799, 172);
            this.grbPhieuMuonSach.TabIndex = 34;
            this.grbPhieuMuonSach.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(590, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 23);
            this.textBox2.TabIndex = 23;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(590, 127);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(144, 23);
            this.txtGhiChu.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(488, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ghi Chú";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(590, 72);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(144, 23);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(186, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 23);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(488, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ngày Trả";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSach.ForeColor = System.Drawing.Color.Black;
            this.lblMaSach.Location = new System.Drawing.Point(491, 24);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(61, 17);
            this.lblMaSach.TabIndex = 17;
            this.lblMaSach.Text = "Mã Sách";
            this.lblMaSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(186, 127);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(144, 23);
            this.txtTinhTrang.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 23);
            this.textBox1.TabIndex = 4;
            // 
            // lblNhanVienLapPhieu
            // 
            this.lblNhanVienLapPhieu.AutoSize = true;
            this.lblNhanVienLapPhieu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVienLapPhieu.ForeColor = System.Drawing.Color.Black;
            this.lblNhanVienLapPhieu.Location = new System.Drawing.Point(74, 130);
            this.lblNhanVienLapPhieu.Name = "lblNhanVienLapPhieu";
            this.lblNhanVienLapPhieu.Size = new System.Drawing.Size(72, 17);
            this.lblNhanVienLapPhieu.TabIndex = 2;
            this.lblNhanVienLapPhieu.Text = "Tình Trạng";
            this.lblNhanVienLapPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMuon
            // 
            this.lblMuon.AutoSize = true;
            this.lblMuon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuon.ForeColor = System.Drawing.Color.Black;
            this.lblMuon.Location = new System.Drawing.Point(66, 77);
            this.lblMuon.Name = "lblMuon";
            this.lblMuon.Size = new System.Drawing.Size(80, 17);
            this.lblMuon.TabIndex = 1;
            this.lblMuon.Text = "Ngày Mượn";
            this.lblMuon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaPhieu
            // 
            this.lblMaPhieu.AutoSize = true;
            this.lblMaPhieu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieu.ForeColor = System.Drawing.Color.Black;
            this.lblMaPhieu.Location = new System.Drawing.Point(81, 21);
            this.lblMaPhieu.Name = "lblMaPhieu";
            this.lblMaPhieu.Size = new System.Drawing.Size(65, 17);
            this.lblMaPhieu.TabIndex = 0;
            this.lblMaPhieu.Text = "Mã Phiếu";
            this.lblMaPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTimKiemSach
            // 
            this.txtTimKiemSach.Location = new System.Drawing.Point(302, 21);
            this.txtTimKiemSach.Name = "txtTimKiemSach";
            this.txtTimKiemSach.Size = new System.Drawing.Size(233, 25);
            this.txtTimKiemSach.TabIndex = 12;
            // 
            // lblTimKiemSach
            // 
            this.lblTimKiemSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemSach.ForeColor = System.Drawing.Color.Black;
            this.lblTimKiemSach.Location = new System.Drawing.Point(31, 21);
            this.lblTimKiemSach.Name = "lblTimKiemSach";
            this.lblTimKiemSach.Size = new System.Drawing.Size(269, 23);
            this.lblTimKiemSach.TabIndex = 0;
            this.lblTimKiemSach.Text = "Nhập thông tin (tên sách hoặc mã sách )";
            this.lblTimKiemSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChiTiet
            // 
            this.lblChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTiet.ForeColor = System.Drawing.Color.Red;
            this.lblChiTiet.Location = new System.Drawing.Point(302, -4);
            this.lblChiTiet.Name = "lblChiTiet";
            this.lblChiTiet.Size = new System.Drawing.Size(208, 30);
            this.lblChiTiet.TabIndex = 33;
            this.lblChiTiet.Text = "Chi Tiết Mượn Trả";
            this.lblChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ghi Chú";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tình Trạng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày Trả";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày Mượn";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã Sách";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Phiếu";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // txtSach
            // 
            this.txtSach.AllowUserToAddRows = false;
            this.txtSach.AllowUserToDeleteRows = false;
            this.txtSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.txtSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.txtSach.Location = new System.Drawing.Point(9, 370);
            this.txtSach.Name = "txtSach";
            this.txtSach.ReadOnly = true;
            this.txtSach.RowHeadersWidth = 51;
            this.txtSach.RowTemplate.Height = 24;
            this.txtSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.txtSach.Size = new System.Drawing.Size(799, 178);
            this.txtSach.TabIndex = 36;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(552, 18);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 30);
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.Text = "Tìm Kiếm";
            // 
            // grbTimKiemSach
            // 
            this.grbTimKiemSach.BackColor = System.Drawing.Color.LightBlue;
            this.grbTimKiemSach.Controls.Add(this.btnTimKiem);
            this.grbTimKiemSach.Controls.Add(this.txtTimKiemSach);
            this.grbTimKiemSach.Controls.Add(this.lblTimKiemSach);
            this.grbTimKiemSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTimKiemSach.ForeColor = System.Drawing.Color.Red;
            this.grbTimKiemSach.Location = new System.Drawing.Point(9, 298);
            this.grbTimKiemSach.Name = "grbTimKiemSach";
            this.grbTimKiemSach.Size = new System.Drawing.Size(803, 66);
            this.grbTimKiemSach.TabIndex = 35;
            this.grbTimKiemSach.TabStop = false;
            this.grbTimKiemSach.Text = "Tìm Kiếm";
            // 
            // frmMuonTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbPhieuMuonSach);
            this.Controls.Add(this.lblChiTiet);
            this.Controls.Add(this.txtSach);
            this.Controls.Add(this.grbTimKiemSach);
            this.Name = "frmMuonTraSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mượn Trả Sách";
            this.Load += new System.EventHandler(this.frmMuonTraSach_Load);
            this.panel1.ResumeLayout(false);
            this.grbPhieuMuonSach.ResumeLayout(false);
            this.grbPhieuMuonSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSach)).EndInit();
            this.grbTimKiemSach.ResumeLayout(false);
            this.grbTimKiemSach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.GroupBox grbPhieuMuonSach;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNhanVienLapPhieu;
        private System.Windows.Forms.Label lblMuon;
        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.TextBox txtTimKiemSach;
        private System.Windows.Forms.Label lblTimKiemSach;
        private System.Windows.Forms.Label lblChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView txtSach;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.GroupBox grbTimKiemSach;
    }
}
namespace TyNhanLongKhoi_GUI
{
    partial class frmBaoCaoThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoThongKe));
            this.grbThongKe = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.radSachTre = new System.Windows.Forms.RadioButton();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTKe = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongKe
            // 
            this.grbThongKe.BackColor = System.Drawing.Color.LightBlue;
            this.grbThongKe.Controls.Add(this.btnCapNhat);
            this.grbThongKe.Controls.Add(this.btnThoat);
            this.grbThongKe.Controls.Add(this.radSachTre);
            this.grbThongKe.Controls.Add(this.radTatCa);
            this.grbThongKe.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongKe.ForeColor = System.Drawing.Color.Red;
            this.grbThongKe.Location = new System.Drawing.Point(4, 105);
            this.grbThongKe.Name = "grbThongKe";
            this.grbThongKe.Size = new System.Drawing.Size(811, 106);
            this.grbThongKe.TabIndex = 23;
            this.grbThongKe.TabStop = false;
            this.grbThongKe.Text = "Tùy Chọn Thống Kê";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.ImageOptions.Image")));
            this.btnCapNhat.Location = new System.Drawing.Point(483, 26);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(119, 45);
            this.btnCapNhat.TabIndex = 19;
            this.btnCapNhat.Text = "Thống Kê";
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(635, 26);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 45);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            // 
            // radSachTre
            // 
            this.radSachTre.AutoSize = true;
            this.radSachTre.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSachTre.ForeColor = System.Drawing.Color.Black;
            this.radSachTre.Location = new System.Drawing.Point(270, 38);
            this.radSachTre.Name = "radSachTre";
            this.radSachTre.Size = new System.Drawing.Size(127, 23);
            this.radSachTre.TabIndex = 13;
            this.radSachTre.TabStop = true;
            this.radSachTre.Text = "Sách Trễ Hạn";
            this.radSachTre.UseVisualStyleBackColor = true;
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTatCa.ForeColor = System.Drawing.Color.Black;
            this.radTatCa.Location = new System.Drawing.Point(72, 39);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(116, 23);
            this.radTatCa.TabIndex = 12;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất Cả Sách";
            this.radTatCa.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(4, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(811, 390);
            this.dataGridView1.TabIndex = 24;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Sách";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Sách";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tên Tác Giả";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên NXB";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Năm XB";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // lblTKe
            // 
            this.lblTKe.AutoSize = true;
            this.lblTKe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTKe.ForeColor = System.Drawing.Color.Red;
            this.lblTKe.Location = new System.Drawing.Point(340, 35);
            this.lblTKe.Name = "lblTKe";
            this.lblTKe.Size = new System.Drawing.Size(136, 23);
            this.lblTKe.TabIndex = 22;
            this.lblTKe.Text = "Thống Kê Sách";
            this.lblTKe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 608);
            this.Controls.Add(this.grbThongKe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTKe);
            this.Name = "frmBaoCaoThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo - Thống Kê";
            this.grbThongKe.ResumeLayout(false);
            this.grbThongKe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongKe;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.RadioButton radSachTre;
        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblTKe;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
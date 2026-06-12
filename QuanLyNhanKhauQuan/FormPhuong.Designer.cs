namespace QuanLyNhanKhauQuan
{
    partial class FormPhuong
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaPhuong;
        private System.Windows.Forms.Label lblTenPhuong;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtMaPhuong;
        private System.Windows.Forms.TextBox txtTenPhuong;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvPhuong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMaPhuong = new System.Windows.Forms.Label();
            this.lblTenPhuong = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtMaPhuong = new System.Windows.Forms.TextBox();
            this.txtTenPhuong = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvPhuong = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.lblTieuDe.Location = new System.Drawing.Point(285, 18);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(211, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ PHƯỜNG";
            // 
            // lblMaPhuong
            // 
            this.lblMaPhuong.Location = new System.Drawing.Point(30, 75);
            this.lblMaPhuong.Name = "lblMaPhuong";
            this.lblMaPhuong.Size = new System.Drawing.Size(110, 25);
            this.lblMaPhuong.TabIndex = 1;
            this.lblMaPhuong.Text = "Mã phường";
            // 
            // lblTenPhuong
            // 
            this.lblTenPhuong.Location = new System.Drawing.Point(30, 115);
            this.lblTenPhuong.Name = "lblTenPhuong";
            this.lblTenPhuong.Size = new System.Drawing.Size(110, 25);
            this.lblTenPhuong.TabIndex = 2;
            this.lblTenPhuong.Text = "Tên phường";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.Location = new System.Drawing.Point(30, 155);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(110, 25);
            this.lblDienThoai.TabIndex = 3;
            this.lblDienThoai.Text = "Điện thoại";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Location = new System.Drawing.Point(430, 75);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(90, 25);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.Location = new System.Drawing.Point(430, 115);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(90, 25);
            this.lblGhiChu.TabIndex = 5;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // txtMaPhuong
            // 
            this.txtMaPhuong.Location = new System.Drawing.Point(145, 72);
            this.txtMaPhuong.Name = "txtMaPhuong";
            this.txtMaPhuong.Size = new System.Drawing.Size(230, 25);
            this.txtMaPhuong.TabIndex = 6;
            // 
            // txtTenPhuong
            // 
            this.txtTenPhuong.Location = new System.Drawing.Point(145, 112);
            this.txtTenPhuong.Name = "txtTenPhuong";
            this.txtTenPhuong.Size = new System.Drawing.Size(230, 25);
            this.txtTenPhuong.TabIndex = 7;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(145, 152);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(230, 25);
            this.txtDienThoai.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(520, 72);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(260, 25);
            this.txtDiaChi.TabIndex = 9;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(520, 112);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(260, 25);
            this.txtGhiChu.TabIndex = 10;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(145, 195);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(260, 195);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 35);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(375, 195);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(490, 195);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 35);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvPhuong
            // 
            this.dgvPhuong.AllowUserToAddRows = false;
            this.dgvPhuong.AllowUserToDeleteRows = false;
            this.dgvPhuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhuong.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhuong.Location = new System.Drawing.Point(30, 294);
            this.dgvPhuong.Name = "dgvPhuong";
            this.dgvPhuong.ReadOnly = true;
            this.dgvPhuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhuong.Size = new System.Drawing.Size(750, 226);
            this.dgvPhuong.TabIndex = 16;
            this.dgvPhuong.SelectionChanged += new System.EventHandler(this.dgvPhuong_SelectionChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(520, 249);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(260, 25);
            this.txtTimKiem.TabIndex = 15;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(386, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tìm kiếm";
            // 
            // FormPhuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(820, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblMaPhuong);
            this.Controls.Add(this.lblTenPhuong);
            this.Controls.Add(this.lblDienThoai);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.txtMaPhuong);
            this.Controls.Add(this.txtTenPhuong);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvPhuong);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FormPhuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phường";
            this.Load += new System.EventHandler(this.FormPhuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.Label label1;
	}
}

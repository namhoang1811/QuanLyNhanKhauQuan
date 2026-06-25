namespace QuanLyNhanKhauQuan
{
    partial class FormTaiKhoan
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblViTri;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtViTri;
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
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblViTri = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvPhuong = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboQuyen = new System.Windows.Forms.ComboBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
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
            this.lblTieuDe.Size = new System.Drawing.Size(233, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.Location = new System.Drawing.Point(30, 75);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(110, 25);
            this.lblTenDangNhap.TabIndex = 1;
            this.lblTenDangNhap.Text = "Tài khoản (*)";
            // 
            // lblHoTen
            // 
            this.lblHoTen.Location = new System.Drawing.Point(30, 115);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(110, 25);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên (*)";
            // 
            // lblQuyen
            // 
            this.lblQuyen.Location = new System.Drawing.Point(30, 155);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(110, 25);
            this.lblQuyen.TabIndex = 3;
            this.lblQuyen.Text = "Quyền (*)";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Location = new System.Drawing.Point(430, 75);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(90, 25);
            this.lblMatKhau.TabIndex = 4;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // lblViTri
            // 
            this.lblViTri.Location = new System.Drawing.Point(430, 115);
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Size = new System.Drawing.Size(90, 25);
            this.lblViTri.TabIndex = 5;
            this.lblViTri.Text = "Vị trí (*)";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(145, 72);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(230, 25);
            this.txtTenDangNhap.TabIndex = 0;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(145, 112);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(230, 25);
            this.txtHoTen.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(520, 72);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(260, 25);
            this.txtMatKhau.TabIndex = 1;
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(520, 112);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(260, 25);
            this.txtViTri.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(145, 195);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(260, 195);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 35);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(375, 195);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(490, 195);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 35);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.BtnLamMoi_Click);
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
            this.dgvPhuong.TabIndex = 11;
            this.dgvPhuong.SelectionChanged += new System.EventHandler(this.DgvTaiKhoan_SelectionChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(520, 249);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(260, 25);
            this.txtTimKiem.TabIndex = 10;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.TxtTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(430, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tìm kiếm";
            // 
            // cboQuyen
            // 
            this.cboQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuyen.Location = new System.Drawing.Point(145, 152);
            this.cboQuyen.Name = "cboQuyen";
            this.cboQuyen.Size = new System.Drawing.Size(230, 25);
            this.cboQuyen.TabIndex = 4;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.Location = new System.Drawing.Point(430, 155);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(90, 25);
            this.lblDienThoai.TabIndex = 18;
            this.lblDienThoai.Text = "Điện thoại";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(520, 152);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(260, 25);
            this.txtDienThoai.TabIndex = 5;
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(820, 545);
            this.Controls.Add(this.lblDienThoai);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.cboQuyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblQuyen);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblViTri);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtViTri);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvPhuong);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FormTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.FormPhuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboQuyen;
		private System.Windows.Forms.Label lblDienThoai;
		private System.Windows.Forms.TextBox txtDienThoai;
	}
}

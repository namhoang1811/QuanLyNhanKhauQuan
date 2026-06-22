namespace QuanLyNhanKhauQuan
{
    partial class FormNguoiPhuThuoc
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaPhuThuoc;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgheNghiep;
        private System.Windows.Forms.Label lblQuanHe;
        private System.Windows.Forms.Label lblNhanKhau;

        private System.Windows.Forms.TextBox txtMaPhuThuoc;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.TextBox txtNgheNghiep;
        private System.Windows.Forms.ComboBox cboQuanHe;
        private System.Windows.Forms.ComboBox cboNhanKhau;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;

        private System.Windows.Forms.DataGridView dgvNguoiPhuThuoc;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMaPhuThuoc = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgheNghiep = new System.Windows.Forms.Label();
            this.lblQuanHe = new System.Windows.Forms.Label();
            this.lblNhanKhau = new System.Windows.Forms.Label();

            this.txtMaPhuThuoc = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.txtNgheNghiep = new System.Windows.Forms.TextBox();
            this.cboQuanHe = new System.Windows.Forms.ComboBox();
            this.cboNhanKhau = new System.Windows.Forms.ComboBox();

            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();

            this.dgvNguoiPhuThuoc = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiPhuThuoc)).BeginInit();
            this.SuspendLayout();

            // lblTieuDe
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(35, 78, 112);
            this.lblTieuDe.Location = new System.Drawing.Point(250, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(325, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ NGƯỜI PHỤ THUỘC";

            // lblMaPhuThuoc
            this.lblMaPhuThuoc.Location = new System.Drawing.Point(30, 70);
            this.lblMaPhuThuoc.Name = "lblMaPhuThuoc";
            this.lblMaPhuThuoc.Size = new System.Drawing.Size(120, 25);
            this.lblMaPhuThuoc.TabIndex = 1;
            this.lblMaPhuThuoc.Text = "Mã phụ thuộc";

            // lblHoTen
            this.lblHoTen.Location = new System.Drawing.Point(30, 110);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(120, 25);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên";

            // lblNgaySinh
            this.lblNgaySinh.Location = new System.Drawing.Point(30, 150);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(120, 25);
            this.lblNgaySinh.TabIndex = 3;
            this.lblNgaySinh.Text = "Ngày sinh";

            // lblGioiTinh
            this.lblGioiTinh.Location = new System.Drawing.Point(30, 190);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(120, 25);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới tính";

            // lblNgheNghiep
            this.lblNgheNghiep.Location = new System.Drawing.Point(430, 70);
            this.lblNgheNghiep.Name = "lblNgheNghiep";
            this.lblNgheNghiep.Size = new System.Drawing.Size(120, 25);
            this.lblNgheNghiep.TabIndex = 5;
            this.lblNgheNghiep.Text = "Nghề nghiệp";

            // lblQuanHe
            this.lblQuanHe.Location = new System.Drawing.Point(430, 110);
            this.lblQuanHe.Name = "lblQuanHe";
            this.lblQuanHe.Size = new System.Drawing.Size(120, 25);
            this.lblQuanHe.TabIndex = 6;
            this.lblQuanHe.Text = "Quan hệ";

            // lblNhanKhau
            this.lblNhanKhau.Location = new System.Drawing.Point(430, 150);
            this.lblNhanKhau.Name = "lblNhanKhau";
            this.lblNhanKhau.Size = new System.Drawing.Size(120, 25);
            this.lblNhanKhau.TabIndex = 7;
            this.lblNhanKhau.Text = "Chủ hộ";

            // txtMaPhuThuoc
            this.txtMaPhuThuoc.Location = new System.Drawing.Point(155, 68);
            this.txtMaPhuThuoc.Name = "txtMaPhuThuoc";
            this.txtMaPhuThuoc.Size = new System.Drawing.Size(230, 25);
            this.txtMaPhuThuoc.TabIndex = 8;

            // txtHoTen
            this.txtHoTen.Location = new System.Drawing.Point(155, 108);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(230, 25);
            this.txtHoTen.TabIndex = 9;

            // dtpNgaySinh
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(155, 148);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(230, 25);
            this.dtpNgaySinh.TabIndex = 10;

            // rdoNam
            this.rdoNam.AutoSize = true;
            this.rdoNam.Checked = true;
            this.rdoNam.Location = new System.Drawing.Point(155, 188);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(58, 23);
            this.rdoNam.TabIndex = 11;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;

            // rdoNu
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(230, 188);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(44, 23);
            this.rdoNu.TabIndex = 12;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;

            // txtNgheNghiep
            this.txtNgheNghiep.Location = new System.Drawing.Point(550, 68);
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.Size = new System.Drawing.Size(230, 25);
            this.txtNgheNghiep.TabIndex = 13;

            // cboQuanHe
            this.cboQuanHe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuanHe.Location = new System.Drawing.Point(550, 108);
            this.cboQuanHe.Name = "cboQuanHe";
            this.cboQuanHe.Size = new System.Drawing.Size(230, 25);
            this.cboQuanHe.TabIndex = 14;

            // cboNhanKhau
            this.cboNhanKhau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanKhau.Location = new System.Drawing.Point(550, 148);
            this.cboNhanKhau.Name = "cboNhanKhau";
            this.cboNhanKhau.Size = new System.Drawing.Size(230, 25);
            this.cboNhanKhau.TabIndex = 15;

            // btnThem
            this.btnThem.Location = new System.Drawing.Point(155, 235);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnSua
            this.btnSua.Location = new System.Drawing.Point(270, 235);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 35);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnXoa
            this.btnXoa.Location = new System.Drawing.Point(385, 235);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // btnLamMoi
            this.btnLamMoi.Location = new System.Drawing.Point(500, 235);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 35);
            this.btnLamMoi.TabIndex = 19;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // dgvNguoiPhuThuoc
            this.dgvNguoiPhuThuoc.AllowUserToAddRows = false;
            this.dgvNguoiPhuThuoc.AllowUserToDeleteRows = false;
            this.dgvNguoiPhuThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguoiPhuThuoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvNguoiPhuThuoc.Location = new System.Drawing.Point(30, 292);
            this.dgvNguoiPhuThuoc.Name = "dgvNguoiPhuThuoc";
            this.dgvNguoiPhuThuoc.ReadOnly = true;
            this.dgvNguoiPhuThuoc.RowHeadersWidth = 51;
            this.dgvNguoiPhuThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNguoiPhuThuoc.Size = new System.Drawing.Size(750, 240);
            this.dgvNguoiPhuThuoc.TabIndex = 20;
            this.dgvNguoiPhuThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguoiPhuThuoc_CellClick);

            // FormNguoiPhuThuoc
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.ClientSize = new System.Drawing.Size(820, 555);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblMaPhuThuoc);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblNgheNghiep);
            this.Controls.Add(this.lblQuanHe);
            this.Controls.Add(this.lblNhanKhau);
            this.Controls.Add(this.txtMaPhuThuoc);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.rdoNam);
            this.Controls.Add(this.rdoNu);
            this.Controls.Add(this.txtNgheNghiep);
            this.Controls.Add(this.cboQuanHe);
            this.Controls.Add(this.cboNhanKhau);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvNguoiPhuThuoc);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FormNguoiPhuThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý người phụ thuộc";
            this.Load += new System.EventHandler(this.FormNguoiPhuThuoc_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiPhuThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
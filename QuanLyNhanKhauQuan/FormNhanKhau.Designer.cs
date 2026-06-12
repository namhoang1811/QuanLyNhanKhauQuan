namespace QuanLyNhanKhauQuan
{
    partial class FormNhanKhau
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaNhanKhau;
        private System.Windows.Forms.Label lblHoTenChuHo;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblNgheNghiep;
        private System.Windows.Forms.Label lblNoiLamViec;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblToDanPho;
        private System.Windows.Forms.Label lblTinhTrang;

        private System.Windows.Forms.TextBox txtMaNhanKhau;
        private System.Windows.Forms.TextBox txtHoTenChuHo;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtNgheNghiep;
        private System.Windows.Forms.TextBox txtNoiLamViec;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.ComboBox cboToDanPho;
        private System.Windows.Forms.ComboBox cboTinhTrang;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;

        private System.Windows.Forms.DataGridView dgvNhanKhau;

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
            this.lblMaNhanKhau = new System.Windows.Forms.Label();
            this.lblHoTenChuHo = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblNgheNghiep = new System.Windows.Forms.Label();
            this.lblNoiLamViec = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblToDanPho = new System.Windows.Forms.Label();
            this.lblTinhTrang = new System.Windows.Forms.Label();

            this.txtMaNhanKhau = new System.Windows.Forms.TextBox();
            this.txtHoTenChuHo = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtNgheNghiep = new System.Windows.Forms.TextBox();
            this.txtNoiLamViec = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.cboToDanPho = new System.Windows.Forms.ComboBox();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();

            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();

            this.dgvNhanKhau = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanKhau)).BeginInit();
            this.SuspendLayout();

            // lblTieuDe
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(35, 78, 112);
            this.lblTieuDe.Location = new System.Drawing.Point(250, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(340, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ NHÂN KHẨU / HỘ KHẨU";

            // lblMaNhanKhau
            this.lblMaNhanKhau.Location = new System.Drawing.Point(25, 62);
            this.lblMaNhanKhau.Name = "lblMaNhanKhau";
            this.lblMaNhanKhau.Size = new System.Drawing.Size(115, 25);
            this.lblMaNhanKhau.TabIndex = 1;
            this.lblMaNhanKhau.Text = "Mã nhân khẩu";

            // lblHoTenChuHo
            this.lblHoTenChuHo.Location = new System.Drawing.Point(25, 98);
            this.lblHoTenChuHo.Name = "lblHoTenChuHo";
            this.lblHoTenChuHo.Size = new System.Drawing.Size(115, 25);
            this.lblHoTenChuHo.TabIndex = 2;
            this.lblHoTenChuHo.Text = "Họ tên chủ hộ";

            // lblNgaySinh
            this.lblNgaySinh.Location = new System.Drawing.Point(25, 134);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(115, 25);
            this.lblNgaySinh.TabIndex = 3;
            this.lblNgaySinh.Text = "Ngày sinh";

            // lblGioiTinh
            this.lblGioiTinh.Location = new System.Drawing.Point(25, 170);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(115, 25);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới tính";

            // lblCCCD
            this.lblCCCD.Location = new System.Drawing.Point(25, 206);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(115, 25);
            this.lblCCCD.TabIndex = 5;
            this.lblCCCD.Text = "CCCD";

            // lblNgheNghiep
            this.lblNgheNghiep.Location = new System.Drawing.Point(25, 242);
            this.lblNgheNghiep.Name = "lblNgheNghiep";
            this.lblNgheNghiep.Size = new System.Drawing.Size(115, 25);
            this.lblNgheNghiep.TabIndex = 6;
            this.lblNgheNghiep.Text = "Nghề nghiệp";

            // lblNoiLamViec
            this.lblNoiLamViec.Location = new System.Drawing.Point(445, 62);
            this.lblNoiLamViec.Name = "lblNoiLamViec";
            this.lblNoiLamViec.Size = new System.Drawing.Size(115, 25);
            this.lblNoiLamViec.TabIndex = 7;
            this.lblNoiLamViec.Text = "Nơi làm việc";

            // lblDiaChi
            this.lblDiaChi.Location = new System.Drawing.Point(445, 98);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(115, 25);
            this.lblDiaChi.TabIndex = 8;
            this.lblDiaChi.Text = "Địa chỉ";

            // lblDienThoai
            this.lblDienThoai.Location = new System.Drawing.Point(445, 134);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(115, 25);
            this.lblDienThoai.TabIndex = 9;
            this.lblDienThoai.Text = "Điện thoại";

            // lblToDanPho
            this.lblToDanPho.Location = new System.Drawing.Point(445, 170);
            this.lblToDanPho.Name = "lblToDanPho";
            this.lblToDanPho.Size = new System.Drawing.Size(115, 25);
            this.lblToDanPho.TabIndex = 10;
            this.lblToDanPho.Text = "Tổ dân phố";

            // lblTinhTrang
            this.lblTinhTrang.Location = new System.Drawing.Point(445, 206);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(115, 25);
            this.lblTinhTrang.TabIndex = 11;
            this.lblTinhTrang.Text = "Tình trạng";

            // txtMaNhanKhau
            this.txtMaNhanKhau.Location = new System.Drawing.Point(145, 60);
            this.txtMaNhanKhau.Name = "txtMaNhanKhau";
            this.txtMaNhanKhau.Size = new System.Drawing.Size(245, 25);
            this.txtMaNhanKhau.TabIndex = 12;

            // txtHoTenChuHo
            this.txtHoTenChuHo.Location = new System.Drawing.Point(145, 96);
            this.txtHoTenChuHo.Name = "txtHoTenChuHo";
            this.txtHoTenChuHo.Size = new System.Drawing.Size(245, 25);
            this.txtHoTenChuHo.TabIndex = 13;

            // dtpNgaySinh
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(145, 132);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(245, 25);
            this.dtpNgaySinh.TabIndex = 14;

            // rdoNam
            this.rdoNam.AutoSize = true;
            this.rdoNam.Checked = true;
            this.rdoNam.Location = new System.Drawing.Point(145, 168);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(58, 23);
            this.rdoNam.TabIndex = 15;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;

            // rdoNu
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(220, 168);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(44, 23);
            this.rdoNu.TabIndex = 16;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;

            // txtCCCD
            this.txtCCCD.Location = new System.Drawing.Point(145, 204);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(245, 25);
            this.txtCCCD.TabIndex = 17;

            // txtNgheNghiep
            this.txtNgheNghiep.Location = new System.Drawing.Point(145, 240);
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.Size = new System.Drawing.Size(245, 25);
            this.txtNgheNghiep.TabIndex = 18;

            // txtNoiLamViec
            this.txtNoiLamViec.Location = new System.Drawing.Point(565, 60);
            this.txtNoiLamViec.Name = "txtNoiLamViec";
            this.txtNoiLamViec.Size = new System.Drawing.Size(245, 25);
            this.txtNoiLamViec.TabIndex = 19;

            // txtDiaChi
            this.txtDiaChi.Location = new System.Drawing.Point(565, 96);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(245, 25);
            this.txtDiaChi.TabIndex = 20;

            // txtDienThoai
            this.txtDienThoai.Location = new System.Drawing.Point(565, 132);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(245, 25);
            this.txtDienThoai.TabIndex = 21;

            // cboToDanPho
            this.cboToDanPho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboToDanPho.Location = new System.Drawing.Point(565, 168);
            this.cboToDanPho.Name = "cboToDanPho";
            this.cboToDanPho.Size = new System.Drawing.Size(245, 25);
            this.cboToDanPho.TabIndex = 22;

            // cboTinhTrang
            this.cboTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrang.Location = new System.Drawing.Point(565, 204);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(245, 25);
            this.cboTinhTrang.TabIndex = 23;

            // btnThem
            this.btnThem.Location = new System.Drawing.Point(145, 288);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnSua
            this.btnSua.Location = new System.Drawing.Point(260, 288);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 35);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnXoa
            this.btnXoa.Location = new System.Drawing.Point(375, 288);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // btnLamMoi
            this.btnLamMoi.Location = new System.Drawing.Point(490, 288);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 35);
            this.btnLamMoi.TabIndex = 27;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // dgvNhanKhau
            this.dgvNhanKhau.AllowUserToAddRows = false;
            this.dgvNhanKhau.AllowUserToDeleteRows = false;
            this.dgvNhanKhau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanKhau.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanKhau.Location = new System.Drawing.Point(25, 345);
            this.dgvNhanKhau.Name = "dgvNhanKhau";
            this.dgvNhanKhau.ReadOnly = true;
            this.dgvNhanKhau.RowHeadersWidth = 51;
            this.dgvNhanKhau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanKhau.Size = new System.Drawing.Size(785, 250);
            this.dgvNhanKhau.TabIndex = 28;
            this.dgvNhanKhau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanKhau_CellClick);

            // FormNhanKhau
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.ClientSize = new System.Drawing.Size(840, 615);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblMaNhanKhau);
            this.Controls.Add(this.lblHoTenChuHo);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblCCCD);
            this.Controls.Add(this.lblNgheNghiep);
            this.Controls.Add(this.lblNoiLamViec);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblDienThoai);
            this.Controls.Add(this.lblToDanPho);
            this.Controls.Add(this.lblTinhTrang);
            this.Controls.Add(this.txtMaNhanKhau);
            this.Controls.Add(this.txtHoTenChuHo);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.rdoNam);
            this.Controls.Add(this.rdoNu);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtNgheNghiep);
            this.Controls.Add(this.txtNoiLamViec);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.cboToDanPho);
            this.Controls.Add(this.cboTinhTrang);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvNhanKhau);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FormNhanKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân khẩu";
            this.Load += new System.EventHandler(this.FormNhanKhau_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanKhau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
namespace QuanLyNhanKhauQuan
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblXinChao;
        private System.Windows.Forms.Button btnPhuong;
        private System.Windows.Forms.Button btnToDanPho;
        private System.Windows.Forms.Button btnNhanKhau;
        private System.Windows.Forms.Button btnNguoiPhuThuoc;
        private System.Windows.Forms.Button btnNghiepVu;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnDangXuat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblXinChao = new System.Windows.Forms.Label();
            this.btnPhuong = new System.Windows.Forms.Button();
            this.btnToDanPho = new System.Windows.Forms.Button();
            this.btnNhanKhau = new System.Windows.Forms.Button();
            this.btnNguoiPhuThuoc = new System.Windows.Forms.Button();
            this.btnNghiepVu = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(35, 78, 112);
            this.lblTieuDe.Location = new System.Drawing.Point(110, 32);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(520, 32);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "PHẦN MỀM QUẢN LÝ NHÂN KHẨU CẤP QUẬN";
            this.lblXinChao.AutoSize = true;
            this.lblXinChao.Location = new System.Drawing.Point(30, 92);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(70, 17);
            this.lblXinChao.TabIndex = 1;
            this.lblXinChao.Text = "Xin chào:";
            this.btnPhuong.Location = new System.Drawing.Point(70, 140);
            this.btnPhuong.Name = "btnPhuong";
            this.btnPhuong.Size = new System.Drawing.Size(210, 55);
            this.btnPhuong.TabIndex = 0;
            this.btnPhuong.Text = "Quản lý phường";
            this.btnPhuong.Click += new System.EventHandler(this.btnPhuong_Click);
            this.btnToDanPho.Location = new System.Drawing.Point(300, 140);
            this.btnToDanPho.Name = "btnToDanPho";
            this.btnToDanPho.Size = new System.Drawing.Size(210, 55);
            this.btnToDanPho.TabIndex = 1;
            this.btnToDanPho.Text = "Quản lý tổ dân phố";
            this.btnToDanPho.Click += new System.EventHandler(this.btnToDanPho_Click);
            this.btnNhanKhau.Location = new System.Drawing.Point(530, 140);
            this.btnNhanKhau.Name = "btnNhanKhau";
            this.btnNhanKhau.Size = new System.Drawing.Size(210, 55);
            this.btnNhanKhau.TabIndex = 2;
            this.btnNhanKhau.Text = "Quản lý nhân khẩu / hộ khẩu";
            this.btnNhanKhau.Click += new System.EventHandler(this.btnNhanKhau_Click);
            this.btnNguoiPhuThuoc.Location = new System.Drawing.Point(70, 220);
            this.btnNguoiPhuThuoc.Name = "btnNguoiPhuThuoc";
            this.btnNguoiPhuThuoc.Size = new System.Drawing.Size(210, 55);
            this.btnNguoiPhuThuoc.TabIndex = 3;
            this.btnNguoiPhuThuoc.Text = "Quản lý người phụ thuộc";
            this.btnNguoiPhuThuoc.Click += new System.EventHandler(this.btnNguoiPhuThuoc_Click);
            this.btnNghiepVu.Location = new System.Drawing.Point(300, 220);
            this.btnNghiepVu.Name = "btnNghiepVu";
            this.btnNghiepVu.Size = new System.Drawing.Size(210, 55);
            this.btnNghiepVu.TabIndex = 4;
            this.btnNghiepVu.Text = "Nghiệp vụ hộ khẩu";
            this.btnNghiepVu.Click += new System.EventHandler(this.btnNghiepVu_Click);
            this.btnTimKiem.Location = new System.Drawing.Point(530, 220);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(210, 55);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm thông tin";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            this.btnBaoCao.Location = new System.Drawing.Point(185, 300);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(210, 55);
            this.btnBaoCao.TabIndex = 6;
            this.btnBaoCao.Text = "Báo cáo / thống kê";
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            this.btnDangXuat.Location = new System.Drawing.Point(415, 300);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(210, 55);
            this.btnDangXuat.TabIndex = 7;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.ClientSize = new System.Drawing.Size(812, 400);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblXinChao);
            this.Controls.Add(this.btnPhuong);
            this.Controls.Add(this.btnToDanPho);
            this.Controls.Add(this.btnNhanKhau);
            this.Controls.Add(this.btnNguoiPhuThuoc);
            this.Controls.Add(this.btnNghiepVu);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.btnDangXuat);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình chính";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

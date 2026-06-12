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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuong)).BeginInit();
            this.SuspendLayout();
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(35, 78, 112);
            this.lblTieuDe.Location = new System.Drawing.Point(285, 18);
            this.lblTieuDe.Text = "QUẢN LÝ PHƯỜNG";
            this.lblMaPhuong.Location = new System.Drawing.Point(30, 75);
            this.lblMaPhuong.Size = new System.Drawing.Size(110, 25);
            this.lblMaPhuong.Text = "Mã phường";
            this.lblTenPhuong.Location = new System.Drawing.Point(30, 115);
            this.lblTenPhuong.Size = new System.Drawing.Size(110, 25);
            this.lblTenPhuong.Text = "Tên phường";
            this.lblDienThoai.Location = new System.Drawing.Point(30, 155);
            this.lblDienThoai.Size = new System.Drawing.Size(110, 25);
            this.lblDienThoai.Text = "Điện thoại";
            this.lblDiaChi.Location = new System.Drawing.Point(430, 75);
            this.lblDiaChi.Size = new System.Drawing.Size(90, 25);
            this.lblDiaChi.Text = "Địa chỉ";
            this.lblGhiChu.Location = new System.Drawing.Point(430, 115);
            this.lblGhiChu.Size = new System.Drawing.Size(90, 25);
            this.lblGhiChu.Text = "Ghi chú";
            this.txtMaPhuong.Location = new System.Drawing.Point(145, 72);
            this.txtMaPhuong.Size = new System.Drawing.Size(230, 25);
            this.txtTenPhuong.Location = new System.Drawing.Point(145, 112);
            this.txtTenPhuong.Size = new System.Drawing.Size(230, 25);
            this.txtDienThoai.Location = new System.Drawing.Point(145, 152);
            this.txtDienThoai.Size = new System.Drawing.Size(230, 25);
            this.txtDiaChi.Location = new System.Drawing.Point(520, 72);
            this.txtDiaChi.Size = new System.Drawing.Size(260, 25);
            this.txtGhiChu.Location = new System.Drawing.Point(520, 112);
            this.txtGhiChu.Size = new System.Drawing.Size(260, 25);
            this.btnThem.Location = new System.Drawing.Point(145, 200);
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnSua.Location = new System.Drawing.Point(260, 200);
            this.btnSua.Size = new System.Drawing.Size(100, 35);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnXoa.Location = new System.Drawing.Point(375, 200);
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnLamMoi.Location = new System.Drawing.Point(490, 200);
            this.btnLamMoi.Size = new System.Drawing.Size(100, 35);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            this.dgvPhuong.AllowUserToAddRows = false;
            this.dgvPhuong.AllowUserToDeleteRows = false;
            this.dgvPhuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhuong.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhuong.Location = new System.Drawing.Point(30, 260);
            this.dgvPhuong.ReadOnly = true;
            this.dgvPhuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhuong.Size = new System.Drawing.Size(750, 260);
            this.dgvPhuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhuong_CellClick);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.ClientSize = new System.Drawing.Size(820, 545);
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
    }
}

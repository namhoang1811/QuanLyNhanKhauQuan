namespace QuanLyNhanKhauQuan
{
    partial class FormNghiepVu
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaNghiepVu;
        private System.Windows.Forms.Label lblNhanKhau;
        private System.Windows.Forms.Label lblLoaiNghiepVu;
        private System.Windows.Forms.Label lblNgayThucHien;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.Label lblGhiChu;

        private System.Windows.Forms.TextBox txtMaNghiepVu;
        private System.Windows.Forms.ComboBox cboNhanKhau;
        private System.Windows.Forms.ComboBox cboLoaiNghiepVu;
        private System.Windows.Forms.DateTimePicker dtpNgayThucHien;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvNghiepVu;

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
            this.lblMaNghiepVu = new System.Windows.Forms.Label();
            this.lblNhanKhau = new System.Windows.Forms.Label();
            this.lblLoaiNghiepVu = new System.Windows.Forms.Label();
            this.lblNgayThucHien = new System.Windows.Forms.Label();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();

            this.txtMaNghiepVu = new System.Windows.Forms.TextBox();
            this.cboNhanKhau = new System.Windows.Forms.ComboBox();
            this.cboLoaiNghiepVu = new System.Windows.Forms.ComboBox();
            this.dtpNgayThucHien = new System.Windows.Forms.DateTimePicker();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvNghiepVu = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvNghiepVu)).BeginInit();
            this.SuspendLayout();

            // lblTieuDe
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(35, 78, 112);
            this.lblTieuDe.Location = new System.Drawing.Point(285, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(260, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "NGHIỆP VỤ HỘ KHẨU";

            // lblMaNghiepVu
            this.lblMaNghiepVu.Location = new System.Drawing.Point(30, 70);
            this.lblMaNghiepVu.Name = "lblMaNghiepVu";
            this.lblMaNghiepVu.Size = new System.Drawing.Size(120, 25);
            this.lblMaNghiepVu.TabIndex = 1;
            this.lblMaNghiepVu.Text = "Mã nghiệp vụ";

            // lblNhanKhau
            this.lblNhanKhau.Location = new System.Drawing.Point(30, 110);
            this.lblNhanKhau.Name = "lblNhanKhau";
            this.lblNhanKhau.Size = new System.Drawing.Size(120, 25);
            this.lblNhanKhau.TabIndex = 2;
            this.lblNhanKhau.Text = "Nhân khẩu";

            // lblLoaiNghiepVu
            this.lblLoaiNghiepVu.Location = new System.Drawing.Point(30, 150);
            this.lblLoaiNghiepVu.Name = "lblLoaiNghiepVu";
            this.lblLoaiNghiepVu.Size = new System.Drawing.Size(120, 25);
            this.lblLoaiNghiepVu.TabIndex = 3;
            this.lblLoaiNghiepVu.Text = "Loại nghiệp vụ";

            // lblNgayThucHien
            this.lblNgayThucHien.Location = new System.Drawing.Point(430, 70);
            this.lblNgayThucHien.Name = "lblNgayThucHien";
            this.lblNgayThucHien.Size = new System.Drawing.Size(120, 25);
            this.lblNgayThucHien.TabIndex = 4;
            this.lblNgayThucHien.Text = "Ngày thực hiện";

            // lblNoiDung
            this.lblNoiDung.Location = new System.Drawing.Point(430, 110);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(120, 25);
            this.lblNoiDung.TabIndex = 5;
            this.lblNoiDung.Text = "Nội dung";

            // lblGhiChu
            this.lblGhiChu.Location = new System.Drawing.Point(430, 150);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(120, 25);
            this.lblGhiChu.TabIndex = 6;
            this.lblGhiChu.Text = "Ghi chú";

            // txtMaNghiepVu
            this.txtMaNghiepVu.Location = new System.Drawing.Point(155, 68);
            this.txtMaNghiepVu.Name = "txtMaNghiepVu";
            this.txtMaNghiepVu.Size = new System.Drawing.Size(230, 25);
            this.txtMaNghiepVu.TabIndex = 7;

            // cboNhanKhau
            this.cboNhanKhau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanKhau.Location = new System.Drawing.Point(155, 108);
            this.cboNhanKhau.Name = "cboNhanKhau";
            this.cboNhanKhau.Size = new System.Drawing.Size(230, 25);
            this.cboNhanKhau.TabIndex = 8;

            // cboLoaiNghiepVu
            this.cboLoaiNghiepVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiNghiepVu.Location = new System.Drawing.Point(155, 148);
            this.cboLoaiNghiepVu.Name = "cboLoaiNghiepVu";
            this.cboLoaiNghiepVu.Size = new System.Drawing.Size(230, 25);
            this.cboLoaiNghiepVu.TabIndex = 9;

            // dtpNgayThucHien
            this.dtpNgayThucHien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThucHien.Location = new System.Drawing.Point(555, 68);
            this.dtpNgayThucHien.Name = "dtpNgayThucHien";
            this.dtpNgayThucHien.Size = new System.Drawing.Size(230, 25);
            this.dtpNgayThucHien.TabIndex = 10;

            // txtNoiDung
            this.txtNoiDung.Location = new System.Drawing.Point(555, 108);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(230, 25);
            this.txtNoiDung.TabIndex = 11;

            // txtGhiChu
            this.txtGhiChu.Location = new System.Drawing.Point(555, 148);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(230, 25);
            this.txtGhiChu.TabIndex = 12;

            // btnThem
            this.btnThem.Location = new System.Drawing.Point(155, 205);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 35);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Ghi nhận";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnLamMoi
            this.btnLamMoi.Location = new System.Drawing.Point(295, 205);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(120, 35);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // dgvNghiepVu
            this.dgvNghiepVu.AllowUserToAddRows = false;
            this.dgvNghiepVu.AllowUserToDeleteRows = false;
            this.dgvNghiepVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNghiepVu.BackgroundColor = System.Drawing.Color.White;
            this.dgvNghiepVu.Location = new System.Drawing.Point(30, 270);
            this.dgvNghiepVu.Name = "dgvNghiepVu";
            this.dgvNghiepVu.ReadOnly = true;
            this.dgvNghiepVu.RowHeadersWidth = 51;
            this.dgvNghiepVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNghiepVu.Size = new System.Drawing.Size(755, 250);
            this.dgvNghiepVu.TabIndex = 15;
            this.dgvNghiepVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNghiepVu_CellClick);

            // FormNghiepVu
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.ClientSize = new System.Drawing.Size(820, 545);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblMaNghiepVu);
            this.Controls.Add(this.lblNhanKhau);
            this.Controls.Add(this.lblLoaiNghiepVu);
            this.Controls.Add(this.lblNgayThucHien);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.txtMaNghiepVu);
            this.Controls.Add(this.cboNhanKhau);
            this.Controls.Add(this.cboLoaiNghiepVu);
            this.Controls.Add(this.dtpNgayThucHien);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvNghiepVu);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FormNghiepVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nghiệp vụ hộ khẩu";
            this.Load += new System.EventHandler(this.FormNghiepVu_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvNghiepVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
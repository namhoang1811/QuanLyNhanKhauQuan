namespace QuanLyNhanKhauQuan
{
    partial class FormToDanPho
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaToDanPho;
        private System.Windows.Forms.Label lblTenToDanPho;
        private System.Windows.Forms.Label lblPhuong;
        private System.Windows.Forms.Label lblCSKV;
        private System.Windows.Forms.Label lblToTruong;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblGhiChu;

        private System.Windows.Forms.TextBox txtMaToDanPho;
        private System.Windows.Forms.TextBox txtTenToDanPho;
        private System.Windows.Forms.ComboBox cboPhuong;
        private System.Windows.Forms.TextBox txtCSKV;
        private System.Windows.Forms.TextBox txtToTruong;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtGhiChu;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;

        private System.Windows.Forms.DataGridView dgvToDanPho;

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
            this.lblMaToDanPho = new System.Windows.Forms.Label();
            this.lblTenToDanPho = new System.Windows.Forms.Label();
            this.lblPhuong = new System.Windows.Forms.Label();
            this.lblCSKV = new System.Windows.Forms.Label();
            this.lblToTruong = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtMaToDanPho = new System.Windows.Forms.TextBox();
            this.txtTenToDanPho = new System.Windows.Forms.TextBox();
            this.cboPhuong = new System.Windows.Forms.ComboBox();
            this.txtCSKV = new System.Windows.Forms.TextBox();
            this.txtToTruong = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvToDanPho = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToDanPho)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.lblTieuDe.Location = new System.Drawing.Point(260, 18);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(251, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ TỔ DÂN PHỐ";
            // 
            // lblMaToDanPho
            // 
            this.lblMaToDanPho.Location = new System.Drawing.Point(30, 75);
            this.lblMaToDanPho.Name = "lblMaToDanPho";
            this.lblMaToDanPho.Size = new System.Drawing.Size(120, 25);
            this.lblMaToDanPho.TabIndex = 1;
            this.lblMaToDanPho.Text = "Mã tổ dân phố";
            // 
            // lblTenToDanPho
            // 
            this.lblTenToDanPho.Location = new System.Drawing.Point(30, 115);
            this.lblTenToDanPho.Name = "lblTenToDanPho";
            this.lblTenToDanPho.Size = new System.Drawing.Size(120, 25);
            this.lblTenToDanPho.TabIndex = 2;
            this.lblTenToDanPho.Text = "Tên tổ dân phố";
            // 
            // lblPhuong
            // 
            this.lblPhuong.Location = new System.Drawing.Point(30, 155);
            this.lblPhuong.Name = "lblPhuong";
            this.lblPhuong.Size = new System.Drawing.Size(120, 25);
            this.lblPhuong.TabIndex = 3;
            this.lblPhuong.Text = "Phường";
            // 
            // lblCSKV
            // 
            this.lblCSKV.Location = new System.Drawing.Point(30, 195);
            this.lblCSKV.Name = "lblCSKV";
            this.lblCSKV.Size = new System.Drawing.Size(120, 25);
            this.lblCSKV.TabIndex = 4;
            this.lblCSKV.Text = "CSKV";
            // 
            // lblToTruong
            // 
            this.lblToTruong.Location = new System.Drawing.Point(430, 75);
            this.lblToTruong.Name = "lblToTruong";
            this.lblToTruong.Size = new System.Drawing.Size(120, 25);
            this.lblToTruong.TabIndex = 5;
            this.lblToTruong.Text = "Tổ trưởng";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.Location = new System.Drawing.Point(430, 115);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(120, 25);
            this.lblDienThoai.TabIndex = 6;
            this.lblDienThoai.Text = "Điện thoại";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.Location = new System.Drawing.Point(430, 155);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(120, 25);
            this.lblGhiChu.TabIndex = 7;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // txtMaToDanPho
            // 
            this.txtMaToDanPho.Location = new System.Drawing.Point(155, 72);
            this.txtMaToDanPho.Name = "txtMaToDanPho";
            this.txtMaToDanPho.Size = new System.Drawing.Size(230, 25);
            this.txtMaToDanPho.TabIndex = 8;
            // 
            // txtTenToDanPho
            // 
            this.txtTenToDanPho.Location = new System.Drawing.Point(155, 112);
            this.txtTenToDanPho.Name = "txtTenToDanPho";
            this.txtTenToDanPho.Size = new System.Drawing.Size(230, 25);
            this.txtTenToDanPho.TabIndex = 9;
            // 
            // cboPhuong
            // 
            this.cboPhuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhuong.Location = new System.Drawing.Point(155, 152);
            this.cboPhuong.Name = "cboPhuong";
            this.cboPhuong.Size = new System.Drawing.Size(230, 25);
            this.cboPhuong.TabIndex = 10;
            // 
            // txtCSKV
            // 
            this.txtCSKV.Location = new System.Drawing.Point(155, 192);
            this.txtCSKV.Name = "txtCSKV";
            this.txtCSKV.Size = new System.Drawing.Size(230, 25);
            this.txtCSKV.TabIndex = 11;
            // 
            // txtToTruong
            // 
            this.txtToTruong.Location = new System.Drawing.Point(550, 72);
            this.txtToTruong.Name = "txtToTruong";
            this.txtToTruong.Size = new System.Drawing.Size(230, 25);
            this.txtToTruong.TabIndex = 12;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(550, 112);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(230, 25);
            this.txtDienThoai.TabIndex = 13;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(550, 152);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(230, 25);
            this.txtGhiChu.TabIndex = 14;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(155, 235);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(270, 235);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 35);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(385, 235);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(500, 235);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 35);
            this.btnLamMoi.TabIndex = 18;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvToDanPho
            // 
            this.dgvToDanPho.AllowUserToAddRows = false;
            this.dgvToDanPho.AllowUserToDeleteRows = false;
            this.dgvToDanPho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvToDanPho.BackgroundColor = System.Drawing.Color.White;
            this.dgvToDanPho.Location = new System.Drawing.Point(30, 292);
            this.dgvToDanPho.Name = "dgvToDanPho";
            this.dgvToDanPho.ReadOnly = true;
            this.dgvToDanPho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvToDanPho.Size = new System.Drawing.Size(750, 240);
            this.dgvToDanPho.TabIndex = 19;
            this.dgvToDanPho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvToDanPho_CellClick);
            // 
            // FormToDanPho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(820, 555);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblMaToDanPho);
            this.Controls.Add(this.lblTenToDanPho);
            this.Controls.Add(this.lblPhuong);
            this.Controls.Add(this.lblCSKV);
            this.Controls.Add(this.lblToTruong);
            this.Controls.Add(this.lblDienThoai);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.txtMaToDanPho);
            this.Controls.Add(this.txtTenToDanPho);
            this.Controls.Add(this.cboPhuong);
            this.Controls.Add(this.txtCSKV);
            this.Controls.Add(this.txtToTruong);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvToDanPho);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FormToDanPho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tổ dân phố";
            this.Load += new System.EventHandler(this.FormToDanPho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvToDanPho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
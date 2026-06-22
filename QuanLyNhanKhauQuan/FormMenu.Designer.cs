namespace QuanLyNhanKhauQuan {
	partial class FormMenu {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLyTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPhuong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToDanPho = new System.Windows.Forms.ToolStripMenuItem();
            this.qToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHoKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhanKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.nghiệpVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTachHo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhapKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChuyenDi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhapMoiSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaoTu = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helloUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýDanhMụcToolStripMenuItem,
            this.qToolStripMenuItem,
            this.nghiệpVụToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.thôngTinToolStripMenuItem,
            this.toolStripMenuItem1,
            this.helloUser});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(820, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQuanLyTaiKhoan,
            this.menuDoiMatKhau,
            this.menuDangXuat,
            this.menuThoat});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "&Hệ thống";
            // 
            // menuQuanLyTaiKhoan
            // 
            this.menuQuanLyTaiKhoan.Name = "menuQuanLyTaiKhoan";
            this.menuQuanLyTaiKhoan.Size = new System.Drawing.Size(180, 22);
            this.menuQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.menuQuanLyTaiKhoan.Click += new System.EventHandler(this.MenuQuanLyTaiKhoan_Click);
            // 
            // menuDoiMatKhau
            // 
            this.menuDoiMatKhau.Name = "menuDoiMatKhau";
            this.menuDoiMatKhau.Size = new System.Drawing.Size(180, 22);
            this.menuDoiMatKhau.Text = "Đổi mật khẩu";
            // 
            // menuDangXuat
            // 
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(180, 22);
            this.menuDangXuat.Text = "Đăng xuất";
            this.menuDangXuat.Click += new System.EventHandler(this.MenuDangXuat_Click);
            // 
            // menuThoat
            // 
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Size = new System.Drawing.Size(180, 22);
            this.menuThoat.Text = "Thoát";
            this.menuThoat.Click += new System.EventHandler(this.MenuThoat_Click);
            // 
            // quảnLýDanhMụcToolStripMenuItem
            // 
            this.quảnLýDanhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPhuong,
            this.menuToDanPho});
            this.quảnLýDanhMụcToolStripMenuItem.Name = "quảnLýDanhMụcToolStripMenuItem";
            this.quảnLýDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.quảnLýDanhMụcToolStripMenuItem.Text = "Quản lý &Danh mục";
            // 
            // menuPhuong
            // 
            this.menuPhuong.Name = "menuPhuong";
            this.menuPhuong.Size = new System.Drawing.Size(135, 22);
            this.menuPhuong.Text = "Phường";
            this.menuPhuong.Click += new System.EventHandler(this.MenuPhuong_Click);
            // 
            // menuToDanPho
            // 
            this.menuToDanPho.Name = "menuToDanPho";
            this.menuToDanPho.Size = new System.Drawing.Size(135, 22);
            this.menuToDanPho.Text = "Tổ dân phố";
            this.menuToDanPho.Click += new System.EventHandler(this.MenuToDanPho_Click);
            // 
            // qToolStripMenuItem
            // 
            this.qToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHoKhau,
            this.menuNhanKhau});
            this.qToolStripMenuItem.Name = "qToolStripMenuItem";
            this.qToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.qToolStripMenuItem.Text = "Quản lý &Nhân khẩu";
            // 
            // menuHoKhau
            // 
            this.menuHoKhau.Name = "menuHoKhau";
            this.menuHoKhau.Size = new System.Drawing.Size(132, 22);
            this.menuHoKhau.Text = "Hộ khẩu";
            // 
            // menuNhanKhau
            // 
            this.menuNhanKhau.Name = "menuNhanKhau";
            this.menuNhanKhau.Size = new System.Drawing.Size(132, 22);
            this.menuNhanKhau.Text = "Nhân khẩu";
            // 
            // nghiệpVụToolStripMenuItem
            // 
            this.nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTachHo,
            this.menuNhapKhau,
            this.menuChuyenDi,
            this.menuNhapMoiSinh,
            this.menuBaoTu});
            this.nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            this.nghiệpVụToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.nghiệpVụToolStripMenuItem.Text = "Nghiệp &vụ";
            // 
            // menuTachHo
            // 
            this.menuTachHo.Name = "menuTachHo";
            this.menuTachHo.Size = new System.Drawing.Size(152, 22);
            this.menuTachHo.Text = "Tách hộ";
            // 
            // menuNhapKhau
            // 
            this.menuNhapKhau.Name = "menuNhapKhau";
            this.menuNhapKhau.Size = new System.Drawing.Size(152, 22);
            this.menuNhapKhau.Text = "Nhập hộ";
            // 
            // menuChuyenDi
            // 
            this.menuChuyenDi.Name = "menuChuyenDi";
            this.menuChuyenDi.Size = new System.Drawing.Size(152, 22);
            this.menuChuyenDi.Text = "Chuyển đi";
            // 
            // menuNhapMoiSinh
            // 
            this.menuNhapMoiSinh.Name = "menuNhapMoiSinh";
            this.menuNhapMoiSinh.Size = new System.Drawing.Size(152, 22);
            this.menuNhapMoiSinh.Text = "Nhập mới sinh";
            // 
            // menuBaoTu
            // 
            this.menuBaoTu.Name = "menuBaoTu";
            this.menuBaoTu.Size = new System.Drawing.Size(152, 22);
            this.menuBaoTu.Text = "Báo tử";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.báoCáoToolStripMenuItem.Text = "&Báo cáo";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNhom});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.thôngTinToolStripMenuItem.Text = "&Thông tin";
            // 
            // menuNhom
            // 
            this.menuNhom.Name = "menuNhom";
            this.menuNhom.Size = new System.Drawing.Size(108, 22);
            this.menuNhom.Text = "Nhóm";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = "`";
            // 
            // helloUser
            // 
            this.helloUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helloUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.helloUser.Name = "helloUser";
            this.helloUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.helloUser.Size = new System.Drawing.Size(98, 20);
            this.helloUser.Text = "Xin chào, User";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 581);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Nhân khẩu Quận 1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quảnLýDanhMụcToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem qToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nghiệpVụToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuNhom;
		private System.Windows.Forms.ToolStripMenuItem menuPhuong;
		private System.Windows.Forms.ToolStripMenuItem menuToDanPho;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem helloUser;
		private System.Windows.Forms.ToolStripMenuItem menuQuanLyTaiKhoan;
		private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
		private System.Windows.Forms.ToolStripMenuItem menuThoat;
		private System.Windows.Forms.ToolStripMenuItem menuHoKhau;
		private System.Windows.Forms.ToolStripMenuItem menuNhanKhau;
		private System.Windows.Forms.ToolStripMenuItem menuTachHo;
		private System.Windows.Forms.ToolStripMenuItem menuNhapKhau;
		private System.Windows.Forms.ToolStripMenuItem menuChuyenDi;
		private System.Windows.Forms.ToolStripMenuItem menuNhapMoiSinh;
		private System.Windows.Forms.ToolStripMenuItem menuBaoTu;
		private System.Windows.Forms.ToolStripMenuItem menuDoiMatKhau;
	}
}
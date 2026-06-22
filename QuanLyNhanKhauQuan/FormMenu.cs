using System;
using System.Windows.Forms;

namespace QuanLyNhanKhauQuan {
	public partial class FormMenu : Form {
		private string tenDangNhap;
		public FormMenu(string tenDangNhap, string quyen) {
			InitializeComponent();
			this.tenDangNhap = tenDangNhap;
			if(quyen != "Admin")
				menuQuanLyTaiKhoan.Available = false; // Ẩn menu Quản lý tài khoản nếu không phải Admin
			Load += FormMenu_Load;
		}
		private void FormMenu_Load(object sender, EventArgs e) {
			// Mở FormPhuong mặc định ngay khi FormMenu vừa tải xong
			helloUser.Text = $"Xin chào, {tenDangNhap}";
			MoFormCon(typeof(FormPhuong));
		}
		private void MoFormCon(Type loaiForm, params object[] thamSo) {
			// 1. Kiểm tra xem Form đã mở trong danh sách MdiChildren chưa
			foreach(Form f in MdiChildren) {
				if(f.GetType() == loaiForm) {
					f.Activate(); // Nếu đã mở rồi thì đưa nó lên trên cùng (focus)
					return;
				}
			}
			// 2. Nếu chưa mở, dùng Reflection để khởi tạo và hiển thị Form mới
			Form formMoi = (Form)Activator.CreateInstance(loaiForm, thamSo);
			formMoi.MdiParent = this; // Chỉ định frmMain là form cha
																
			// --- Tối ưu hiển thị cho Form con ---
			formMoi.FormBorderStyle = FormBorderStyle.None; // Xóa viền và thanh tiêu đề
			formMoi.Dock = DockStyle.Fill;                  // Tự động lấp đầy FormMenu
			formMoi.Show();
		}


		// Hệ thống
		private void MenuQuanLyTaiKhoan_Click(object sender, EventArgs e) {
			MoFormCon(typeof(FormTaiKhoan), tenDangNhap);
		}
		private void MenuDoiMatKhau_Click(object sender, EventArgs e) {
			MoFormCon(typeof(FormDoiMatKhau), tenDangNhap);
		}
		private void MenuDangXuat_Click(object sender, EventArgs e) {
			var result = MessageBoxHelper.YesNoQuestion("Bạn có chắc chắn muốn Đăng xuất hệ thống?");
			if(result == DialogResult.Yes)
				Application.Restart();
		}
		private void MenuThoat_Click(object sender, EventArgs e) {
			var result = MessageBoxHelper.YesNoQuestion("Bạn có chắc chắn muốn Thoát hệ thống?");
			if(result == DialogResult.Yes) 
				Application.Exit();
		}

		// Quản lý Danh mục
		private void MenuPhuong_Click(object sender, EventArgs e) {
			MoFormCon(typeof(FormPhuong));
		}

		private void MenuToDanPho_Click(object sender, EventArgs e) {
			MoFormCon(typeof(FormToDanPho));
		}

		// Quản lý Nhân khẩu
		private void MenuNhaKhauHoKhau_Click(object sender, EventArgs e) {
			MoFormCon(typeof(FormNhanKhau));
		}
		private void MenuNguoiPhuThuoc_Click(object sender, EventArgs e) {
			MoFormCon(typeof(FormNguoiPhuThuoc));
		}
		// Nghiệp vụ

		private void MenuNghiepVu_Click(object sender, EventArgs e) {
			MoFormCon(typeof(FormNghiepVu));
		}

		private void MenuThongTin_Click(object sender, EventArgs e) {

		}
		// Báo cáo

	}
}

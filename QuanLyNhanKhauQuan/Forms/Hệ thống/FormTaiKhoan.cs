using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNhanKhauQuan {
	public partial class FormTaiKhoan : Form {
		public FormTaiKhoan() {
			InitializeComponent();
		}

		private void FormPhuong_Load(object sender, EventArgs e) {
			NapQuyen();
			TaiDuLieu();
			CapNhatTrangThaiNutBam(false);
		}
		private void NapQuyen() {
			cboQuyen.Items.Clear();
			cboQuyen.Items.Add("Admin");
			cboQuyen.Items.Add("Member");
			cboQuyen.SelectedIndex = -1;
		}

		private void TaiDuLieu() {
			// 1. Tạm thời ngắt sự kiện để DataGridView không tự động nhảy vào hàm SelectionChanged
			dgvPhuong.SelectionChanged -= DgvTaiKhoan_SelectionChanged;
			// 2. Đổ dữ liệu mới vào bảng
			dgvPhuong.DataSource = Db.LayDuLieu("SELECT TenDangNhap, null, HoTen, ViTri, Quyen, DienThoai FROM tblPhuong ORDER BY NgaySua DESC");
			// 3. Hủy bỏ hoàn toàn ô đang được focus ngầm
			dgvPhuong.CurrentCell = null;
			// 4. Bật lại sự kiện để bảng phản hồi với thao tác của người dùng như bình thường
			dgvPhuong.SelectionChanged += DgvTaiKhoan_SelectionChanged;
		}

		private bool KiemTraDuLieu(bool isCreate) {
			if(!txtTenDangNhap.KiemTraTrong("tên đăng nhập"))
				return false;
			if(isCreate && !txtMatKhau.KiemTraTrong("mật khẩu"))
				return false;
			if(!txtHoTen.KiemTraTrong("vị trí"))
				return false;
			if(!txtViTri.KiemTraTrong("họ và tên"))
				return false;
			if(!cboQuyen.KiemTraChon("quyền"))
				return false;
			return true;
		}

		private void XoaTrang() {
			txtTenDangNhap.Clear();
			txtMatKhau.Clear();
			txtHoTen.Clear();
			txtViTri.Clear();
			cboQuyen.SelectedIndex = -1;
			txtDienThoai.Clear();
			txtTimKiem.Clear();
			txtTenDangNhap.Enabled = true;
			txtTenDangNhap.Focus();
			CapNhatTrangThaiNutBam(false);
		}

		private void BtnThem_Click(object sender, EventArgs e) {
			try {
				if(!KiemTraDuLieu(true))
					return;
				Db.ThucThiSP("sp_TaiKhoan_Them", 
					new SqlParameter("@TenDangNhap", txtTenDangNhap.Text.Trim()), 
					new SqlParameter("@MatKhau", txtMatKhau.Text), 
					new SqlParameter("@HoTen", txtHoTen.Text.Trim()), 
					new SqlParameter("@ViTri", txtViTri.Text.Trim()), 
					new SqlParameter("@Quyen", cboQuyen.Text.Trim()),
					new SqlParameter("@DienThoai", txtDienThoai.Text.Trim()));
				MessageBoxHelper.ThongBao("Thêm tài khoản thành công.");
				TaiDuLieu();
				XoaTrang();
			} catch(Exception ex) {
				ex.BaoLoi();
			}
		}

		private void BtnSua_Click(object sender, EventArgs e) {
			try {
				if(!KiemTraDuLieu(false))
					return;
				Db.ThucThiSP("sp_TaiKhoan_Sua",
					new SqlParameter("@TenDangNhap", txtTenDangNhap.Text.Trim()),
					new SqlParameter("@MatKhau", txtMatKhau.Text),
					new SqlParameter("@HoTen", txtHoTen.Text.Trim()),
					new SqlParameter("@ViTri", txtViTri.Text.Trim()),
					new SqlParameter("@Quyen", cboQuyen.Text.Trim()),
					new SqlParameter("@DienThoai", txtDienThoai.Text.Trim()));
				MessageBoxHelper.ThongBao("Cập nhật tài khoản thành công.");
				TaiDuLieu();
			} catch(Exception ex) {
				ex.BaoLoi();
			}
		}
		private void BtnXoa_Click(object sender, EventArgs e) {
			try {
				if(!txtTenDangNhap.KiemTraTrong("tên đăng nhập cần xóa"))
					return;
				Db.ThucThiSP("sp_TaiKhoan_Xoa", new SqlParameter("@TenDangNhap", txtTenDangNhap.Text.Trim()));
				MessageBoxHelper.ThongBao("Xóa tài khoản thành công.");
				TaiDuLieu();
				XoaTrang();
			} catch(Exception ex) {
				ex.BaoLoi();
			}
		}

		private void BtnLamMoi_Click(object sender, EventArgs e) {
			XoaTrang();
			TaiDuLieu();
		}

		private void TxtTimKiem_TextChanged(object sender, EventArgs e) {
			var dt = dgvPhuong.DataSource as DataTable;
			if(dt != null) {
				string tuKhoa = txtTimKiem.Text.Trim();
				// 2. Nếu ô tìm kiếm trống, xóa bộ lọc để hiện lại toàn bộ danh sách
				if(string.IsNullOrEmpty(tuKhoa)) {
					dt.DefaultView.RowFilter = string.Empty;
				} else {
					// 3. Sử dụng cú pháp tương tự mệnh đề WHERE trong SQL để lọc
					// Lọc tương đối (LIKE) trên cả 2 cột: Mã Phường và Tên Phường
					// Lưu ý: Cú pháp RowFilter không phân biệt chữ hoa chữ thường
					dt.DefaultView.RowFilter = $"TenDangNhap LIKE '%{tuKhoa}%' OR HoTen LIKE '%{tuKhoa}%' OR ViTri LIKE '%{tuKhoa}%' OR DienThoai LIKE '%{tuKhoa}%'";
				}
			}
		}

		private void DgvTaiKhoan_SelectionChanged(object sender, EventArgs e) {
			if(dgvPhuong.SelectedRows.Count == 0)
				return;
			DataGridViewRow row = dgvPhuong.SelectedRows[0];
			txtTenDangNhap.NapTextBox(row.Cells["TenDangNhap"]);
			txtMatKhau.NapTextBox(row.Cells["MatKhau"]);
			txtHoTen.NapTextBox(row.Cells["HoTen"]);
			txtViTri.NapTextBox(row.Cells["ViTri"]);
			cboQuyen.ChonTheoCell(row.Cells["Quyen"]);
			txtDienThoai.NapTextBox(row.Cells["DienThoai"]);
			txtTenDangNhap.Enabled = false;
			CapNhatTrangThaiNutBam(true);
		}

		private void CapNhatTrangThaiNutBam(bool daChonDong) {
			btnThem.Visible = !daChonDong;
			btnSua.Visible = daChonDong;
			btnXoa.Visible = daChonDong;
			btnLamMoi.Visible = daChonDong;
		}

	}
}

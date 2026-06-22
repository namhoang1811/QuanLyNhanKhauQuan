using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNhanKhauQuan {
	public partial class FormPhuong : Form {
		public FormPhuong() {
			InitializeComponent();
		}

		private void FormPhuong_Load(object sender, EventArgs e) {
			TaiDuLieu();
			CapNhatTrangThaiNutBam(false);
		}

		private void TaiDuLieu() {
			// 1. Tạm thời ngắt sự kiện để DataGridView không tự động nhảy vào hàm SelectionChanged
			dgvPhuong.SelectionChanged -= dgvPhuong_SelectionChanged;
			// 2. Đổ dữ liệu mới vào bảng
			dgvPhuong.DataSource = Db.LayDuLieu("SELECT MaPhuong, TenPhuong, DienThoai, DiaChi, GhiChu FROM tblPhuong ORDER BY MaPhuong");
			// 3. Hủy bỏ hoàn toàn ô đang được focus ngầm
			dgvPhuong.CurrentCell = null;
			// 4. Bật lại sự kiện để bảng phản hồi với thao tác của người dùng như bình thường
			dgvPhuong.SelectionChanged += dgvPhuong_SelectionChanged;
		}

		private bool KiemTraDuLieu() {
			if(!txtMaPhuong.KiemTraTrong("mã phường"))
				return false;
			if(!txtTenPhuong.KiemTraTrong("tên phường"))
				return false;
			if(!txtDienThoai.KiemTraTrong("điện thoại"))
				return false;
			if(!txtDienThoai.KiemTraSoDienThoai())
				return false;
			if(!txtDiaChi.KiemTraTrong("địa chỉ"))
				return false;
			return true;
		}

		private void XoaTrang() {
			txtMaPhuong.Clear();
			txtTenPhuong.Clear();
			txtDienThoai.Clear();
			txtDiaChi.Clear();
			txtGhiChu.Clear();
			txtTimKiem.Clear();
			txtMaPhuong.Enabled = true;
			txtMaPhuong.Focus();
			CapNhatTrangThaiNutBam(false);
		}

		private void btnThem_Click(object sender, EventArgs e) {
			try {
				if(!KiemTraDuLieu())
					return;
				Db.ThucThiSP("sp_Phuong_Them", new SqlParameter("@MaPhuong", txtMaPhuong.Text.Trim()), new SqlParameter("@TenPhuong", txtTenPhuong.Text.Trim()), new SqlParameter("@DienThoai", txtDienThoai.Text.Trim()), new SqlParameter("@DiaChi", txtDiaChi.Text.Trim()), new SqlParameter("@GhiChu", txtGhiChu.Text.Trim()));
				MessageBoxHelper.ThongBao("Thêm phường thành công.");
				TaiDuLieu();
				XoaTrang();
			} catch(Exception ex) {
				ex.BaoLoi();
			}
		}

		private void btnSua_Click(object sender, EventArgs e) {
			try {
				if(!KiemTraDuLieu())
					return;
				Db.ThucThiSP("sp_Phuong_Sua", new SqlParameter("@MaPhuong", txtMaPhuong.Text.Trim()), new SqlParameter("@TenPhuong", txtTenPhuong.Text.Trim()), new SqlParameter("@DienThoai", txtDienThoai.Text.Trim()), new SqlParameter("@DiaChi", txtDiaChi.Text.Trim()), new SqlParameter("@GhiChu", txtGhiChu.Text.Trim()));
				MessageBoxHelper.ThongBao("Cập nhật phường thành công.");
				TaiDuLieu();
			} catch(Exception ex) {
				ex.BaoLoi();
			}
		}

		private void btnXoa_Click(object sender, EventArgs e) {
			try {
				if(!txtMaPhuong.KiemTraTrong("mã phường cần xóa"))
					return;
				if(!MessageBoxHelper.Hoi("Xóa phường sẽ bị chặn nếu đã có tổ dân phố. Bạn muốn tiếp tục?"))
					return;
				Db.ThucThiSP("sp_Phuong_Xoa", new SqlParameter("@MaPhuong", txtMaPhuong.Text.Trim()));
				MessageBoxHelper.ThongBao("Xóa phường thành công.");
				TaiDuLieu();
				XoaTrang();
			} catch(Exception ex) {
				ex.BaoLoi();
			}
		}

		private void btnLamMoi_Click(object sender, EventArgs e) {
			XoaTrang();
			TaiDuLieu();
		}

		private void txtTimKiem_TextChanged(object sender, EventArgs e) {
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
					dt.DefaultView.RowFilter = $"MaPhuong LIKE '%{tuKhoa}%' OR TenPhuong LIKE '%{tuKhoa}%'";
				}
			}
		}

		private void dgvPhuong_SelectionChanged(object sender, EventArgs e) {
			if(dgvPhuong.SelectedRows.Count == 0)
				return;
			DataGridViewRow row = dgvPhuong.SelectedRows[0];
			txtMaPhuong.Text = Convert.ToString(row.Cells["MaPhuong"].Value);
			txtTenPhuong.Text = Convert.ToString(row.Cells["TenPhuong"].Value);
			txtDienThoai.Text = Convert.ToString(row.Cells["DienThoai"].Value);
			txtDiaChi.Text = Convert.ToString(row.Cells["DiaChi"].Value);
			txtGhiChu.Text = Convert.ToString(row.Cells["GhiChu"].Value);
			txtMaPhuong.Enabled = false;
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

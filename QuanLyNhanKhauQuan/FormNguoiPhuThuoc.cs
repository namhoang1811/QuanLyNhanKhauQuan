using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNhanKhauQuan {
	public partial class FormNguoiPhuThuoc : Form {
		public FormNguoiPhuThuoc() {
			InitializeComponent();
		}

		private void FormNguoiPhuThuoc_Load(object sender, EventArgs e) {
			NapQuanHe();
			NapNhanKhau();
			TaiDuLieu();
			XoaTrang();
		}

		private void NapQuanHe() {
			cboQuanHe.Items.Clear();

			cboQuanHe.Items.Add("Vợ");
			cboQuanHe.Items.Add("Chồng");
			cboQuanHe.Items.Add("Con");
			cboQuanHe.Items.Add("Cha");
			cboQuanHe.Items.Add("Mẹ");
			cboQuanHe.Items.Add("Anh");
			cboQuanHe.Items.Add("Chị");
			cboQuanHe.Items.Add("Em");
			cboQuanHe.Items.Add("Ông");
			cboQuanHe.Items.Add("Bà");
			cboQuanHe.Items.Add("Khác");

			cboQuanHe.SelectedIndex = -1;
		}

		private void NapNhanKhau() {
			cboNhanKhau.NapComboBox(
					"SELECT MaNhanKhau, HoTenChuHo FROM tblNhanKhau ORDER BY HoTenChuHo",
					"HoTenChuHo",
					"MaNhanKhau");

			cboNhanKhau.SelectedIndex = -1;
		}

		private void TaiDuLieu() {
			dgvNguoiPhuThuoc.DataSource = Db.LayDuLieu(
					"SELECT " +
					"p.MaPhuThuoc, " +
					"p.HoTen, " +
					"p.NgaySinh, " +
					"p.GioiTinh, " +
					"p.NgheNghiep, " +
					"p.QuanHe, " +
					"n.HoTenChuHo " +
					"FROM tblNguoiPhuThuoc p " +
					"INNER JOIN tblNhanKhau n ON p.MaNhanKhau = n.MaNhanKhau " +
					"ORDER BY p.MaPhuThuoc");
		}

		private string LayGioiTinh() {
			if(rdoNam.Checked) {
				return "Nam";
			}

			return "Nữ";
		}

		private void ChonComboBoxTheoText(ComboBox comboBox, string text) {
			for(int i = 0; i < comboBox.Items.Count; i++) {
				if(comboBox.GetItemText(comboBox.Items[i]) == text) {
					comboBox.SelectedIndex = i;
					return;
				}
			}

			comboBox.SelectedIndex = -1;
		}

		private bool KiemTraDuLieu() {
			if(!txtMaPhuThuoc.KiemTraTrong("mã phụ thuộc")) {
				return false;
			}

			if(!txtHoTen.KiemTraTrong("họ tên")) {
				return false;
			}

			if(dtpNgaySinh.Value.Date > DateTime.Today) {
				MessageBox.Show(
						"Ngày sinh không được lớn hơn ngày hiện tại.",
						"Dữ liệu không hợp lệ",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning);

				dtpNgaySinh.Focus();
				return false;
			}

			if(string.IsNullOrWhiteSpace(cboQuanHe.Text)) {
				MessageBox.Show(
						"Vui lòng chọn quan hệ với chủ hộ.",
						"Thiếu dữ liệu",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning);

				cboQuanHe.Focus();
				return false;
			}

			if(cboNhanKhau.SelectedValue == null || string.IsNullOrWhiteSpace(cboNhanKhau.Text)) {
				MessageBox.Show(
						"Vui lòng chọn chủ hộ.",
						"Thiếu dữ liệu",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning);

				cboNhanKhau.Focus();
				return false;
			}

			return true;
		}

		private void XoaTrang() {
			txtMaPhuThuoc.Clear();
			txtHoTen.Clear();

			dtpNgaySinh.Value = DateTime.Today.AddYears(-10);

			rdoNam.Checked = true;
			rdoNu.Checked = false;

			txtNgheNghiep.Clear();

			cboQuanHe.SelectedIndex = -1;
			cboNhanKhau.SelectedIndex = -1;

			txtMaPhuThuoc.Enabled = true;
			txtMaPhuThuoc.Focus();
		}

		private void btnThem_Click(object sender, EventArgs e) {
			try {
				if(!KiemTraDuLieu()) {
					return;
				}

				Db.ThucThiSP(
						"sp_NguoiPhuThuoc_Them",
						new SqlParameter("@MaPhuThuoc", txtMaPhuThuoc.Text.Trim()),
						new SqlParameter("@HoTen", txtHoTen.Text.Trim()),
						new SqlParameter("@NgaySinh", dtpNgaySinh.Value.Date),
						new SqlParameter("@GioiTinh", LayGioiTinh()),
						new SqlParameter("@NgheNghiep", txtNgheNghiep.Text.Trim()),
						new SqlParameter("@QuanHe", cboQuanHe.Text.Trim()),
						new SqlParameter("@MaNhanKhau", cboNhanKhau.SelectedValue.ToString()));

				MessageBox.Show(
						"Thêm người phụ thuộc thành công.",
						"Thành công",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);

				TaiDuLieu();
				XoaTrang();
			} catch(Exception ex) {
				Db.BaoLoi(ex);
			}
		}

		private void btnSua_Click(object sender, EventArgs e) {
			try {
				if(!KiemTraDuLieu()) {
					return;
				}

				Db.ThucThiSP(
						"sp_NguoiPhuThuoc_Sua",
						new SqlParameter("@MaPhuThuoc", txtMaPhuThuoc.Text.Trim()),
						new SqlParameter("@HoTen", txtHoTen.Text.Trim()),
						new SqlParameter("@NgaySinh", dtpNgaySinh.Value.Date),
						new SqlParameter("@GioiTinh", LayGioiTinh()),
						new SqlParameter("@NgheNghiep", txtNgheNghiep.Text.Trim()),
						new SqlParameter("@QuanHe", cboQuanHe.Text.Trim()),
						new SqlParameter("@MaNhanKhau", cboNhanKhau.SelectedValue.ToString()));

				MessageBox.Show(
						"Cập nhật người phụ thuộc thành công.",
						"Thành công",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);

				TaiDuLieu();
			} catch(Exception ex) {
				Db.BaoLoi(ex);
			}
		}

		private void btnXoa_Click(object sender, EventArgs e) {
			try {
				if(!txtMaPhuThuoc.KiemTraTrong("mã phụ thuộc cần xóa")) {
					return;
				}

				DialogResult result = MessageBox.Show(
						"Bạn có chắc muốn xóa người phụ thuộc này không?",
						"Xác nhận xóa",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question);

				if(result != DialogResult.Yes) {
					return;
				}

				Db.ThucThiSP(
						"sp_NguoiPhuThuoc_Xoa",
						new SqlParameter("@MaPhuThuoc", txtMaPhuThuoc.Text.Trim()));

				MessageBox.Show(
						"Xóa người phụ thuộc thành công.",
						"Thành công",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);

				TaiDuLieu();
				XoaTrang();
			} catch(Exception ex) {
				Db.BaoLoi(ex);
			}
		}

		private void btnLamMoi_Click(object sender, EventArgs e) {
			XoaTrang();
			TaiDuLieu();
		}

		private void dgvNguoiPhuThuoc_CellClick(object sender, DataGridViewCellEventArgs e) {
			if(e.RowIndex < 0) {
				return;
			}

			DataGridViewRow row = dgvNguoiPhuThuoc.Rows[e.RowIndex];

			txtMaPhuThuoc.Text = Convert.ToString(row.Cells["MaPhuThuoc"].Value);
			txtHoTen.Text = Convert.ToString(row.Cells["HoTen"].Value);

			if(row.Cells["NgaySinh"].Value != null) {
				dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
			}

			string gioiTinh = Convert.ToString(row.Cells["GioiTinh"].Value);

			rdoNam.Checked = gioiTinh == "Nam";
			rdoNu.Checked = gioiTinh != "Nam";

			txtNgheNghiep.Text = Convert.ToString(row.Cells["NgheNghiep"].Value);

			ChonComboBoxTheoText(
					cboQuanHe,
					Convert.ToString(row.Cells["QuanHe"].Value));

			cboNhanKhau.Text = Convert.ToString(row.Cells["HoTenChuHo"].Value);

			txtMaPhuThuoc.Enabled = false;
		}
	}
}
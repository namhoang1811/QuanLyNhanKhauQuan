using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyNhanKhauQuan {
	public partial class FormNhanKhau : Form {
		public FormNhanKhau() {
			InitializeComponent();
		}

		private void FormNhanKhau_Load(object sender, EventArgs e) {
			NapTinhTrang();
			NapToDanPho();
			TaiDuLieu();
			XoaTrang();
		}

		private void NapTinhTrang() {
			cboTinhTrang.Items.Clear();

			cboTinhTrang.Items.Add("Đang cư trú");
			cboTinhTrang.Items.Add("Chuyển đi");
			cboTinhTrang.Items.Add("Đã tách hộ");
			cboTinhTrang.Items.Add("Đã nhập hộ");
			cboTinhTrang.Items.Add("Đã báo tử");

			cboTinhTrang.SelectedIndex = 0;
		}

		private void NapToDanPho() {
			cboToDanPho.NapComboBox(
					"SELECT MaToDanPho, TenToDanPho FROM tblToDanPho ORDER BY TenToDanPho",
					"TenToDanPho",
					"MaToDanPho");

			cboToDanPho.SelectedIndex = -1;
		}

		private void TaiDuLieu() {
			dgvNhanKhau.DataSource = Db.LayDuLieu(
					"SELECT " +
					"n.MaNhanKhau, " +
					"n.HoTenChuHo, " +
					"n.NgaySinh, " +
					"n.GioiTinh, " +
					"n.CCCD, " +
					"n.NgheNghiep, " +
					"n.NoiLamViec, " +
					"n.DiaChi, " +
					"n.DienThoai, " +
					"t.TenToDanPho, " +
					"n.TinhTrang " +
					"FROM tblNhanKhau n " +
					"INNER JOIN tblToDanPho t ON n.MaToDanPho = t.MaToDanPho " +
					"ORDER BY n.MaNhanKhau");
		}

		private string LayGioiTinh() {
			if(rdoNam.Checked) {
				return "Nam";
			}

			return "Nữ";
		}

		private bool LaSo(string value) {
			return Regex.IsMatch(value, @"^\d+$");
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
			if(!txtMaNhanKhau.KiemTraTrong("mã nhân khẩu")) {
				return false;
			}

			if(!txtHoTenChuHo.KiemTraTrong("họ tên chủ hộ")) {
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

			if(!txtCCCD.KiemTraTrong("CCCD")) {
				return false;
			}

			if(!LaSo(txtCCCD.Text.Trim())) {
				MessageBox.Show(
						"CCCD chỉ được nhập chữ số.",
						"Dữ liệu không hợp lệ",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning);

				txtCCCD.Focus();
				return false;
			}

			if(txtCCCD.Text.Trim().Length != 12) {
				MessageBox.Show(
						"CCCD phải đủ 12 chữ số.",
						"Dữ liệu không hợp lệ",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning);

				txtCCCD.Focus();
				return false;
			}

			if(!txtDiaChi.KiemTraTrong("địa chỉ")) {
				return false;
			}

			if(!txtDienThoai.KiemTraTrong("điện thoại")) {
				return false;
			}

			if(!txtDienThoai.KiemTraSoDienThoai()) {
				return false;
			}

			if(cboToDanPho.SelectedValue == null || string.IsNullOrWhiteSpace(cboToDanPho.Text)) {
				MessageBox.Show(
						"Vui lòng chọn tổ dân phố.",
						"Thiếu dữ liệu",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning);

				cboToDanPho.Focus();
				return false;
			}

			if(string.IsNullOrWhiteSpace(cboTinhTrang.Text)) {
				MessageBox.Show(
						"Vui lòng chọn tình trạng.",
						"Thiếu dữ liệu",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning);

				cboTinhTrang.Focus();
				return false;
			}

			return true;
		}

		private void XoaTrang() {
			txtMaNhanKhau.Clear();
			txtHoTenChuHo.Clear();

			dtpNgaySinh.Value = DateTime.Today.AddYears(-25);

			rdoNam.Checked = true;
			rdoNu.Checked = false;

			txtCCCD.Clear();
			txtNgheNghiep.Clear();
			txtNoiLamViec.Clear();
			txtDiaChi.Clear();
			txtDienThoai.Clear();

			cboToDanPho.SelectedIndex = -1;
			cboTinhTrang.SelectedIndex = 0;

			txtMaNhanKhau.Enabled = true;
			txtMaNhanKhau.Focus();
		}

		private void btnThem_Click(object sender, EventArgs e) {
			try {
				if(!KiemTraDuLieu()) {
					return;
				}

				Db.ThucThiSP(
						"sp_NhanKhau_Them",
						new SqlParameter("@MaNhanKhau", txtMaNhanKhau.Text.Trim()),
						new SqlParameter("@HoTenChuHo", txtHoTenChuHo.Text.Trim()),
						new SqlParameter("@NgaySinh", dtpNgaySinh.Value.Date),
						new SqlParameter("@GioiTinh", LayGioiTinh()),
						new SqlParameter("@CCCD", txtCCCD.Text.Trim()),
						new SqlParameter("@NgheNghiep", txtNgheNghiep.Text.Trim()),
						new SqlParameter("@NoiLamViec", txtNoiLamViec.Text.Trim()),
						new SqlParameter("@DiaChi", txtDiaChi.Text.Trim()),
						new SqlParameter("@DienThoai", txtDienThoai.Text.Trim()),
						new SqlParameter("@MaToDanPho", cboToDanPho.SelectedValue.ToString()),
						new SqlParameter("@TinhTrang", cboTinhTrang.Text.Trim()));

				MessageBox.Show(
						"Thêm nhân khẩu thành công.",
						"Thành công",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);

				TaiDuLieu();
				XoaTrang();
			} catch(Exception ex) {
				ex.BaoLoi();
			}
		}

		private void btnSua_Click(object sender, EventArgs e) {
			try {
				if(!KiemTraDuLieu()) {
					return;
				}

				Db.ThucThiSP(
						"sp_NhanKhau_Sua",
						new SqlParameter("@MaNhanKhau", txtMaNhanKhau.Text.Trim()),
						new SqlParameter("@HoTenChuHo", txtHoTenChuHo.Text.Trim()),
						new SqlParameter("@NgaySinh", dtpNgaySinh.Value.Date),
						new SqlParameter("@GioiTinh", LayGioiTinh()),
						new SqlParameter("@CCCD", txtCCCD.Text.Trim()),
						new SqlParameter("@NgheNghiep", txtNgheNghiep.Text.Trim()),
						new SqlParameter("@NoiLamViec", txtNoiLamViec.Text.Trim()),
						new SqlParameter("@DiaChi", txtDiaChi.Text.Trim()),
						new SqlParameter("@DienThoai", txtDienThoai.Text.Trim()),
						new SqlParameter("@MaToDanPho", cboToDanPho.SelectedValue.ToString()),
						new SqlParameter("@TinhTrang", cboTinhTrang.Text.Trim()));

				MessageBox.Show(
						"Cập nhật nhân khẩu thành công.",
						"Thành công",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);

				TaiDuLieu();
			} catch(Exception ex) {
				ex.BaoLoi();
			}
		}

		private void btnXoa_Click(object sender, EventArgs e) {
			try {
				if(!txtMaNhanKhau.KiemTraTrong("mã nhân khẩu cần xóa")) {
					return;
				}

				DialogResult result = MessageBox.Show(
						"Xóa nhân khẩu sẽ bị chặn nếu còn người phụ thuộc hoặc nghiệp vụ. Bạn muốn tiếp tục?",
						"Xác nhận xóa",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question);

				if(result != DialogResult.Yes) {
					return;
				}

				Db.ThucThiSP(
						"sp_NhanKhau_Xoa",
						new SqlParameter("@MaNhanKhau", txtMaNhanKhau.Text.Trim()));

				MessageBox.Show(
						"Xóa nhân khẩu thành công.",
						"Thành công",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);

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

		private void dgvNhanKhau_CellClick(object sender, DataGridViewCellEventArgs e) {
			if(e.RowIndex < 0) {
				return;
			}

			DataGridViewRow row = dgvNhanKhau.Rows[e.RowIndex];

			txtMaNhanKhau.Text = Convert.ToString(row.Cells["MaNhanKhau"].Value);
			txtHoTenChuHo.Text = Convert.ToString(row.Cells["HoTenChuHo"].Value);

			if(row.Cells["NgaySinh"].Value != null) {
				dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
			}

			string gioiTinh = Convert.ToString(row.Cells["GioiTinh"].Value);

			rdoNam.Checked = gioiTinh == "Nam";
			rdoNu.Checked = gioiTinh != "Nam";

			txtCCCD.Text = Convert.ToString(row.Cells["CCCD"].Value);
			txtNgheNghiep.Text = Convert.ToString(row.Cells["NgheNghiep"].Value);
			txtNoiLamViec.Text = Convert.ToString(row.Cells["NoiLamViec"].Value);
			txtDiaChi.Text = Convert.ToString(row.Cells["DiaChi"].Value);
			txtDienThoai.Text = Convert.ToString(row.Cells["DienThoai"].Value);

			cboToDanPho.Text = Convert.ToString(row.Cells["TenToDanPho"].Value);

			ChonComboBoxTheoText(
					cboTinhTrang,
					Convert.ToString(row.Cells["TinhTrang"].Value));

			txtMaNhanKhau.Enabled = false;
		}
	}
}
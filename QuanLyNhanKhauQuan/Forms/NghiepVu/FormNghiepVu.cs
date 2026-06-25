using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNhanKhauQuan {
	public partial class FormNghiepVu : Form {
		public FormNghiepVu() {
			InitializeComponent();
		}

		private void FormNghiepVu_Load(object sender, EventArgs e) {
			NapLoaiNghiepVu();
			NapNhanKhau();
			TaiDuLieu();
			LamMoi();
		}

		private void NapLoaiNghiepVu() {
			cboLoaiNghiepVu.Items.Clear();
			cboLoaiNghiepVu.Items.Add("Tách hộ");
			cboLoaiNghiepVu.Items.Add("Nhập hộ");
			cboLoaiNghiepVu.Items.Add("Chuyển đi");
			cboLoaiNghiepVu.Items.Add("Nhập mới sinh");
			cboLoaiNghiepVu.Items.Add("Báo tử");
			cboLoaiNghiepVu.SelectedIndex = -1;
		}

		private void NapNhanKhau() {
			cboNhanKhau.NapComboBox(
					"SELECT MaNhanKhau, HoTenChuHo FROM tblNhanKhau ORDER BY HoTenChuHo",
					"HoTenChuHo",
					"MaNhanKhau");

			cboNhanKhau.SelectedIndex = -1;
		}

		private void TaiDuLieu() {
			dgvNghiepVu.DataSource = Db.LayDuLieu(
					"SELECT " +
					"nv.MaNghiepVu, " +
					"n.HoTenChuHo, " +
					"nv.LoaiNghiepVu, " +
					"nv.NgayThucHien, " +
					"nv.NoiDung, " +
					"nv.GhiChu " +
					"FROM tblNghiepVuHoKhau nv " +
					"INNER JOIN tblNhanKhau n ON nv.MaNhanKhau = n.MaNhanKhau " +
					"ORDER BY nv.NgayThucHien DESC");
		}

		private bool KiemTraDuLieu() {
			if(!txtMaNghiepVu.KiemTraTrong("mã nghiệp vụ")) {
				return false;
			}

			if(cboNhanKhau.SelectedValue == null || string.IsNullOrWhiteSpace(cboNhanKhau.Text)) {
				MessageBox.Show(
						"Vui lòng chọn nhân khẩu.",
						"Thiếu dữ liệu",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning);

				cboNhanKhau.Focus();
				return false;
			}

			if(string.IsNullOrWhiteSpace(cboLoaiNghiepVu.Text)) {
				MessageBox.Show(
						"Vui lòng chọn loại nghiệp vụ.",
						"Thiếu dữ liệu",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning);

				cboLoaiNghiepVu.Focus();
				return false;
			}

			if(!dtpNgayThucHien.KiemTraNgayKhongVuotHienTai("Ngày thực hiện"))  return false;
			if(!txtNoiDung.KiemTraTrong("nội dung nghiệp vụ")) return false;

			return true;
		}

		private string LayTinhTrangTheoNghiepVu() {
			if(cboLoaiNghiepVu.Text == "Chuyển đi") {
				return "Chuyển đi";
			}

			if(cboLoaiNghiepVu.Text == "Tách hộ") {
				return "Đã tách hộ";
			}

			if(cboLoaiNghiepVu.Text == "Nhập hộ") {
				return "Đã nhập hộ";
			}

			if(cboLoaiNghiepVu.Text == "Báo tử") {
				return "Đã báo tử";
			}

			return "Đang cư trú";
		}

		private void CapNhatTinhTrangTheoNghiepVu() {
			Db.ThucThiSP(
					"sp_NhanKhau_CapNhatTinhTrang",
					new SqlParameter("@MaNhanKhau", cboNhanKhau.SelectedValue.ToString()),
					new SqlParameter("@TinhTrang", LayTinhTrangTheoNghiepVu()));
		}

		private void btnThem_Click(object sender, EventArgs e) {
			try {
				if(!KiemTraDuLieu()) return;
				Db.ThucThiSP(
						"sp_NghiepVu_Them",
						new SqlParameter("@MaNghiepVu", txtMaNghiepVu.Text.Trim()),
						new SqlParameter("@MaNhanKhau", cboNhanKhau.SelectedValue.ToString()),
						new SqlParameter("@LoaiNghiepVu", cboLoaiNghiepVu.Text.Trim()),
						new SqlParameter("@NgayThucHien", dtpNgayThucHien.Value.Date),
						new SqlParameter("@NoiDung", txtNoiDung.Text.Trim()),
						new SqlParameter("@GhiChu", txtGhiChu.Text.Trim()));
				CapNhatTinhTrangTheoNghiepVu();
				MessageBox.Show(
						"Ghi nhận nghiệp vụ thành công.",
						"Thành công",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);
				TaiDuLieu();
				LamMoi();
			} catch(SqlException ex) {
				ex.BaoLoi();
			} catch(Exception ex) {
				ex.BaoLoi();
			}
		}

		private void btnLamMoi_Click(object sender, EventArgs e) {
			LamMoi();
			TaiDuLieu();
		}

		private void LamMoi() {
			txtMaNghiepVu.Clear();

			cboNhanKhau.SelectedIndex = -1;
			cboLoaiNghiepVu.SelectedIndex = -1;

			dtpNgayThucHien.Value = DateTime.Today;
			txtNoiDung.Clear();
			txtGhiChu.Clear();

			txtMaNghiepVu.Focus();
		}

		private void dgvNghiepVu_CellClick(object sender, DataGridViewCellEventArgs e) {
			if(e.RowIndex < 0) {
				return;
			}
			DataGridViewRow row = dgvNghiepVu.Rows[e.RowIndex];
			txtMaNghiepVu.Text = Convert.ToString(row.Cells["MaNghiepVu"].Value);
			cboNhanKhau.Text = Convert.ToString(row.Cells["HoTenChuHo"].Value);
			cboLoaiNghiepVu.NapComboBox(row.Cells["LoaiNghiepVu"]);
			if(row.Cells["NgayThucHien"].Value != null) {
				dtpNgayThucHien.Value = Convert.ToDateTime(row.Cells["NgayThucHien"].Value);
			}
			txtNoiDung.Text = Convert.ToString(row.Cells["NoiDung"].Value);
			txtGhiChu.Text = Convert.ToString(row.Cells["GhiChu"].Value);
		}
	}
}
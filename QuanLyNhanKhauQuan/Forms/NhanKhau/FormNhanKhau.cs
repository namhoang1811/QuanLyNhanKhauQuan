using System;
using System.Data.SqlClient;
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

		private string LayGioiTinh() => rdoNam.Checked ? "Nam" : "Nữ";

		private bool KiemTraDuLieu() {
			if(!txtMaNhanKhau.KiemTraTrong("Mã nhân khẩu")) return false;
			if(!txtHoTenChuHo.KiemTraTrong("Họ tên chủ hộ")) return false;
			if(!dtpNgaySinh.KiemTraNgayKhongVuotHienTai("Ngày sinh")) return false;
			if(!txtCCCD.KiemTraCCCD()) return false;
			if(!txtDiaChi.KiemTraTrong("Địa chỉ")) return false;
			if(!txtDienThoai.KiemTraTrong("Điện thoại")) return false;
			if(!txtDienThoai.KiemTraSoDienThoai()) return false;
			if(!cboToDanPho.KiemTraChon("Dân phố")) return false;
			if(!cboTinhTrang.KiemTraChon("Tình trạng")) return false;
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
				if(!KiemTraDuLieu()) return;
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
				if(!KiemTraDuLieu()) return;
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
				if(!txtMaNhanKhau.KiemTraTrong("mã nhân khẩu cần xóa")) return;
				DialogResult result = MessageBox.Show(
						"Xóa nhân khẩu sẽ bị chặn nếu còn người phụ thuộc hoặc nghiệp vụ. Bạn muốn tiếp tục?",
						"Xác nhận xóa",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question);
				if(result != DialogResult.Yes) return;
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
			if(e.RowIndex < 0) return;
			DataGridViewRow row = dgvNhanKhau.Rows[e.RowIndex];
			txtMaNhanKhau.NapTextBox(row.Cells["MaNhanKhau"]);
			txtHoTenChuHo.NapTextBox(row.Cells["HoTenChuHo"]);
			if(row.Cells["NgaySinh"].Value != null) 
				dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
			string gioiTinh = Convert.ToString(row.Cells["GioiTinh"].Value);
			rdoNam.Checked = gioiTinh == "Nam";
			rdoNu.Checked = gioiTinh != "Nam";
			txtCCCD.NapTextBox(row.Cells["CCCD"]);
			txtNgheNghiep.NapTextBox(row.Cells["NgheNghiep"]);
			txtNoiLamViec.NapTextBox(row.Cells["NoiLamViec"]);
			txtDiaChi.NapTextBox(row.Cells["DiaChi"]);
			txtDienThoai.NapTextBox(row.Cells["DienThoai"]);
			cboToDanPho.NapComboBox(row.Cells["TenToDanPho"]);
			cboTinhTrang.NapComboBox(row.Cells["TinhTrang"]);
			txtMaNhanKhau.Enabled = false;
		}
	}
}
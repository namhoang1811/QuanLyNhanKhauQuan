using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyNhanKhauQuan {
	public partial class FormDangKy : Form {
		public FormDangKy() {
			InitializeComponent();
		}

		private void FormPhuong_Load(object sender, EventArgs e) {
		}


		private bool KiemTraDuLieu(bool isCreate) {
			if(!txtTenDangNhap.KiemTraTrong("Tên đăng nhập")) return false;
			if(isCreate && !txtMatKhau.KiemTraTrong("Mật khẩu")) return false;
			if(!txtHoTen.KiemTraTrong("Họ tên")) return false;
			if(!txtViTri.KiemTraTrong("Vị trí")) return false;
			return true;
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
					new SqlParameter("@Quyen", "Member"),
					new SqlParameter("@DienThoai", string.IsNullOrWhiteSpace(txtDienThoai.Text) ? (object)DBNull.Value : txtDienThoai.Text.Trim()),
					new SqlParameter("@NguoiTao", "auto"));
				var form = new FormMenu(txtTenDangNhap.Text.Trim(), "Member");
				Hide();
				form.ShowDialog();

			} catch(Exception ex) {
				ex.BaoLoi();
			}
		}

		private void TxtDienThoai_KeyPress(object sender, KeyPressEventArgs e) {
			TextBox txt = sender as TextBox;
			if(char.IsControl(e.KeyChar))
				return;
			if(!char.IsDigit(e.KeyChar) && e.KeyChar != '+') {
				e.Handled = true; // Hủy thao tác nhập
				return;
			}
			if(e.KeyChar == '+') {
				if(txt.Text.Contains("+") || txt.SelectionStart != 0) {
					e.Handled = true; // Hủy thao tác nhập
				}
			}
		}

		private void TxtDienThoai_TextChanged(object sender, EventArgs e) {
			TextBox txt = sender as TextBox;
			if(!Regex.IsMatch(txt.Text, @"^\+?[0-9]*$") && txt.Text != "") {
				MessageBox.Show("Số điện thoại không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txt.Text = string.Empty;
			}
		}
	}
}

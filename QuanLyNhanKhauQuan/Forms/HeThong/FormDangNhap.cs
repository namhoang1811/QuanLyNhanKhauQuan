using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNhanKhauQuan {
	public partial class FormDangNhap : Form {
		public FormDangNhap() {
			InitializeComponent();
		}

		private void FormDangNhap_Load(object sender, EventArgs e) {
			txtTenDangNhap.Focus();
		}

		private void BtnDangNhap_Click(object sender, EventArgs e) {
			try {
				if(!txtTenDangNhap.KiemTraTrong("tên đăng nhập")) return;
				if(!txtMatKhau.KiemTraTrong("mật khẩu")) return;
				var taiKhoan = txtTenDangNhap.Text.Trim();
				var matKhauDaHash = Db.HashPasswordSHA512ToBytes(txtMatKhau.Text);
				var ketQua = Db.LayGiaTri(
								"SELECT Quyen FROM tblTaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau AND TrangThai = 1;",
								new SqlParameter("@TenDangNhap", taiKhoan),
								new SqlParameter("@MatKhau", matKhauDaHash));
				if(ketQua != null && ketQua != DBNull.Value) {
					var quyen = Convert.ToString(ketQua);
					var form = new FormMenu(taiKhoan, quyen);
					Hide();
					form.ShowDialog();
					Close();
				} else {
					MessageBox.Show(
							"Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng kiểm tra lại.",
							"Đăng nhập thất bại",
							MessageBoxButtons.OK,
							MessageBoxIcon.Warning);
					txtMatKhau.Clear();
					txtMatKhau.Focus();
				}
			} catch(Exception ex) {
				ex.BaoLoi();
			}
		}

		private void BtnThoat_Click(object sender, EventArgs e) {
			var result = MessageBoxHelper.YesNoQuestion("Bạn có chắc chắn muốn thoát hệ thống?");
			if(result == DialogResult.Yes) {
				// Lệnh này sẽ đóng tất cả các Form và ngắt hoàn toàn ứng dụng
				Application.Exit();
			}
		}

	}
}
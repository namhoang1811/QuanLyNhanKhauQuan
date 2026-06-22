using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
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
				if(!txtTenDangNhap.KiemTraTrong("tên đăng nhập"))
					return;
				if(!txtTenDangNhap.KiemTraTrong("mật khẩu"))
					return;
				var taiKhoan = txtTenDangNhap.Text.Trim();
				var matKhauDaHash = HashPasswordSHA512ToBytes(txtMatKhau.Text);
				var ketQua = Db.LayGiaTri(
						@"IF EXISTS (
								SELECT 1 FROM tblTaiKhoan
								WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau AND TrangThai = 1
							)
							SELECT 1 ELSE SELECT 0;",
						new SqlParameter("@TenDangNhap", taiKhoan),
						new SqlParameter("@MatKhau", matKhauDaHash));
				var isExist = Convert.ToInt32(ketQua) == 1;
				if(isExist) {
					var form = new FormMenu(taiKhoan);
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

		private byte[] HashPasswordSHA512ToBytes(string password) {
			using(SHA512 sha512 = SHA512.Create()) {
				// Chuyển chuỗi sang mảng byte theo chuẩn ASCII/ANSI để khớp với '123' trong SQL
				byte[] sourceBytes = Encoding.ASCII.GetBytes(password);

				// Trả về mảng byte đã băm (đúng 64 bytes cho SHA512)
				return sha512.ComputeHash(sourceBytes);
			}
		}
	}
}
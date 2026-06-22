using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNhanKhauQuan {
	public partial class FormDoiMatKhau : Form {
		private string tenDangNhap;
		public FormDoiMatKhau(string tenDangNhap) {
			InitializeComponent();
			this.tenDangNhap = tenDangNhap;
		}


		private void BtnThem_Click(object sender, EventArgs e) {
			try {
				var matKhauDaHash = Db.HashPasswordSHA512ToBytes(txtMatKhauCu.Text);
				var ketQua = Db.LayGiaTri(
					@"IF EXISTS ( SELECT 1 FROM tblTaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau AND TrangThai = 1 ) SELECT 1 ELSE SELECT 0;",
						new SqlParameter("@TenDangNhap", tenDangNhap),
						new SqlParameter("@MatKhau", matKhauDaHash));
				var isExist = Convert.ToInt32(ketQua) == 1;
				if(!isExist) {
					MessageBox.Show("Mật khẩu cũ không chính xác.", "Mật khẩu sai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				if(txtMatKhauMoi.Text != txtXacNhanMatKhau.Text) {
					MessageBox.Show("Mật khẩu mới và Xác nhận mật khẩu không khớp.", "Mật khẩu không khớp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtMatKhauMoi.Clear();
					txtXacNhanMatKhau.Clear();
					txtMatKhauMoi.Focus();
					return;
				}
				// Kiểm tra dữ liệu
				Db.ThucThiSP("sp_TaiKhoan_DoiMatKhau", 
					new SqlParameter("@TenDangNhap", tenDangNhap), 
					new SqlParameter("@MatKhau", txtMatKhauCu.Text));
				MessageBoxHelper.ThongBao("Thay đổi mật khẩu thành công.");
				Application.Restart();
			} catch(Exception ex) {
				ex.BaoLoi();
			}
		}

	}
}

using System;
using System.Windows.Forms;

namespace QuanLyNhanKhauQuan {
	internal static class TextBoxHelper {
		
		public static void NapTextBox(this TextBox textBox, DataGridViewCell cell) {
			textBox.Text = Convert.ToString(cell.Value);
		}

		public static bool KiemTraTrong(this TextBox textBox, string tenTruong) {
			if(string.IsNullOrWhiteSpace(textBox.Text)) {
				MessageBox.Show(
						"Vui lòng nhập " + tenTruong + ".",
						"Thiếu dữ liệu",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning);
				textBox.Focus();
				return false;
			}
			return true;
		}

		public static bool KiemTraSoDienThoai(this TextBox textBox) {
			string sdt = textBox.Text.Trim();
			if(sdt.Length < 9 || sdt.Length > 11) {
				MessageBox.Show(
						"Số điện thoại phải từ 9 đến 11 chữ số.",
						"Dữ liệu không hợp lệ",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning);
				textBox.Focus();
				return false;
			}
			foreach(char c in sdt) {
				if(!char.IsDigit(c)) {
					MessageBox.Show(
							"Số điện thoại chỉ được nhập chữ số.",
							"Dữ liệu không hợp lệ",
							MessageBoxButtons.OK,
							MessageBoxIcon.Warning);

					textBox.Focus();
					return false;
				}
			}

			return true;
		}

		public static bool KiemTraCCCD(this TextBox textBox) {
			string cccd = textBox.Text.Trim();
			if(cccd.Length != 12) {
				MessageBox.Show(
						"CCCD phải đủ 12 chữ số.",
						"Dữ liệu không hợp lệ",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning);
				textBox.Focus();
				return false;
			}
			foreach(char c in cccd) {
				if(!char.IsDigit(c)) {
					MessageBox.Show(
							"CCCD chỉ được nhập chữ số.",
							"Dữ liệu không hợp lệ",
							MessageBoxButtons.OK,
							MessageBoxIcon.Warning);
					textBox.Focus();
					return false;
				}
			}
			return true;
		}
	}
}

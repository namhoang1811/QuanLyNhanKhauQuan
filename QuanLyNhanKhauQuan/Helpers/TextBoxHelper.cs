using System.Windows.Forms;

namespace QuanLyNhanKhauQuan {
	internal static class TextBoxHelper {
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
	}
}

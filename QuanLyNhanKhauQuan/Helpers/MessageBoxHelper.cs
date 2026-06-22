using System.Windows.Forms;

namespace QuanLyNhanKhauQuan {
	internal static class MessageBoxHelper {
		public static void ThongBao(string noiDung) {
			MessageBox.Show(
					noiDung,
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);
		}

		public static bool Hoi(string noiDung) {
			DialogResult result = MessageBox.Show(
					noiDung,
					"Xác nhận",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question);
			return result == DialogResult.Yes;
		}
	}

}

using System.Windows.Forms;

namespace QuanLyNhanKhauQuan {
	internal static class MessageBoxHelper {

		public static DialogResult YesNoQuestion(string noiDung, string caption = "Xác nhận") {
			return MessageBox.Show(noiDung, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}

		public static void ThongBao(string noiDung) {
			MessageBox.Show(noiDung, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public static bool Hoi(string noiDung) {
			DialogResult result = MessageBox.Show( noiDung, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			return result == DialogResult.Yes;
		}
	}

}

using System;
using System.Windows.Forms;

namespace QuanLyNhanKhauQuan {
	internal static class DateTimePickerHelper {
		public static bool KiemTraNgayKhongVuotHienTai(DateTimePicker dateTimePicker, string tenTruong) {
			if(dateTimePicker.Value.Date > DateTime.Now.Date) {
				MessageBox.Show(
						tenTruong + " không được lớn hơn ngày hiện tại.",
						"Dữ liệu không hợp lệ",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning);
				dateTimePicker.Focus();
				return false;
			}
			return true;
		}
	}
}

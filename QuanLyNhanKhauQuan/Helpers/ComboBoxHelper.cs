using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhanKhauQuan {
	internal static class ComboBoxHelper {
		
		public static void NapComboBox(this ComboBox comboBox, DataGridViewCell cell) {
			var text = Convert.ToString(cell.Value);
			for(int i = 0; i < comboBox.Items.Count; i++) {
				if(comboBox.GetItemText(comboBox.Items[i]) == text) {
					comboBox.SelectedIndex = i;
					return;
				}
			}
			comboBox.SelectedIndex = -1;
		}

		public static void NapComboBox(this ComboBox comboBox, string sql, string displayMember, string valueMember) {
			DataTable table = Db.LayDuLieu(sql);
			comboBox.DataSource = table;
			comboBox.DisplayMember = displayMember;
			comboBox.ValueMember = valueMember;
			comboBox.SelectedIndex = -1;
		}

		public static bool KiemTraChon(this ComboBox comboBox, string tenTruong) {
			if(comboBox.SelectedIndex < 0 || string.IsNullOrWhiteSpace(comboBox.Text)) {
				MessageBox.Show(
						"Vui lòng chọn " + tenTruong + ".",
						"Thiếu dữ liệu",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning);
				comboBox.Focus();
				return false;
			}
			return true;
		}
	}
}

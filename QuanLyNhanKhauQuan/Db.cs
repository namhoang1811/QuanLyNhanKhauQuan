using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyNhanKhauQuan {
	public static class Db {
		public static string ChuoiKetNoi {
			get {
				return ConfigurationManager.ConnectionStrings["ChuoiKetNoi"].ConnectionString;
			}
		}
		public static DataTable LayDuLieu(string sql, params SqlParameter[] parameters) {
			using(SqlConnection connection = new SqlConnection(ChuoiKetNoi))
			using(SqlCommand command = new SqlCommand(sql, connection))
			using(SqlDataAdapter adapter = new SqlDataAdapter(command)) {
				if(parameters != null) {
					command.Parameters.AddRange(parameters);
				}
				DataTable table = new DataTable();
				adapter.Fill(table);
				return table;
			}
		}

		public static DataTable LayDuLieuSP(string tenThuTuc, params SqlParameter[] parameters) {
			using(SqlConnection connection = new SqlConnection(ChuoiKetNoi))
			using(SqlCommand command = new SqlCommand(tenThuTuc, connection))
			using(SqlDataAdapter adapter = new SqlDataAdapter(command)) {
				command.CommandType = CommandType.StoredProcedure;

				if(parameters != null) {
					command.Parameters.AddRange(parameters);
				}

				DataTable table = new DataTable();
				adapter.Fill(table);
				return table;
			}
		}

		public static int ThucThiSP(string tenThuTuc, params SqlParameter[] parameters) {
			using(SqlConnection connection = new SqlConnection(ChuoiKetNoi))
			using(SqlCommand command = new SqlCommand(tenThuTuc, connection)) {
				command.CommandType = CommandType.StoredProcedure;
				if(parameters != null) {
					command.Parameters.AddRange(parameters);
				}
				connection.Open();
				return command.ExecuteNonQuery();
			}
		}

		public static object LayGiaTri(string sql, params SqlParameter[] parameters) {
			using(SqlConnection connection = new SqlConnection(ChuoiKetNoi))
			using(SqlCommand command = new SqlCommand(sql, connection)) {
				if(parameters != null) {
					command.Parameters.AddRange(parameters);
				}
				connection.Open();
				return command.ExecuteScalar();
			}
		}

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

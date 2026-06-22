using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanKhauQuan {
	internal static class Db {
		public static string ChuoiKetNoi => ConfigurationManager.ConnectionStrings["ChuoiKetNoi"].ConnectionString;

		public static DataTable LayDuLieu(string sql, params SqlParameter[] parameters) {
			using(SqlConnection connection = new SqlConnection(ChuoiKetNoi))
			using(SqlCommand command = new SqlCommand(sql, connection))
			using(SqlDataAdapter adapter = new SqlDataAdapter(command)) {
				if(parameters != null) 
					command.Parameters.AddRange(parameters);
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
				if(parameters != null) 
					command.Parameters.AddRange(parameters);
				DataTable table = new DataTable();
				adapter.Fill(table);
				return table;
			}
		}

		public static int ThucThiSP(string tenThuTuc, params SqlParameter[] parameters) {
			using(SqlConnection connection = new SqlConnection(ChuoiKetNoi))
			using(SqlCommand command = new SqlCommand(tenThuTuc, connection)) {
				command.CommandType = CommandType.StoredProcedure;
				if(parameters != null)
					command.Parameters.AddRange(parameters);
				connection.Open();
				return command.ExecuteNonQuery();
			}
		}

		public static object LayGiaTri(string sql, params SqlParameter[] parameters) {
			using(SqlConnection connection = new SqlConnection(ChuoiKetNoi))
			using(SqlCommand command = new SqlCommand(sql, connection)) {
				if(parameters != null) 
					command.Parameters.AddRange(parameters);
				connection.Open();
				return command.ExecuteScalar();
			}
		}

	}
}

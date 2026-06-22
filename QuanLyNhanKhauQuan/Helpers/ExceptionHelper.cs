using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyNhanKhauQuan {
	internal static class ExceptionHelper {
		public static void BaoLoi(this Exception exception) {
			MessageBox.Show(LayThongBaoLoi(exception), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public static string LayThongBaoLoi(this Exception exception) {
			SqlException sqlException = exception as SqlException;
			if(sqlException == null && exception.InnerException != null) 
				sqlException = exception.InnerException as SqlException;
			if(sqlException == null) 
				return "Có lỗi xảy ra:\n" + exception.Message;
			foreach(SqlError error in sqlException.Errors) {
				string message = error.Message;
				string constraintName = LayTenRangBuoc(message);
				string tableName = LayTenBang(message);
				if(error.Number == 547) {
					if(constraintName.StartsWith("FK_"))
						return TaoThongBaoKhoaNgoai(constraintName, tableName, message);
					if(constraintName.StartsWith("CK_"))
						return TaoThongBaoCheck(constraintName);
					return "Không thể thực hiện vì dữ liệu vi phạm ràng buộc khóa ngoại hoặc điều kiện kiểm tra.\n\nChi tiết kỹ thuật:\n" + message;
				}

				if(error.Number == 2627 || error.Number == 2601) 
					return "Dữ liệu đã tồn tại. Vui lòng kiểm tra lại mã, CCCD hoặc thông tin không được trùng.\n\nChi tiết kỹ thuật:\n" + message;
				if(error.Number == 515) 
					return "Không được để trống trường bắt buộc. Vui lòng nhập đầy đủ dữ liệu trước khi lưu.\n\nChi tiết kỹ thuật:\n" + message;
				if(error.Number == 245 || error.Number == 8114) 
					return "Sai kiểu dữ liệu. Vui lòng kiểm tra lại số, ngày tháng và các trường chọn.\n\nChi tiết kỹ thuật:\n" + message;
				if(error.Number == 18456) 
					return "Không đăng nhập được SQL Server. Vui lòng kiểm tra tài khoản SQL Server trong App.config.";
				if(error.Number == 4060) 
					return "Không mở được cơ sở dữ liệu. Vui lòng chạy file SQL trước và kiểm tra tên database QuanLyNhanKhauQuan.";
				if(error.Number == 53 || error.Number == 2) 
					return "Không kết nối được SQL Server. Vui lòng kiểm tra tên máy chủ, SQL Server đã bật chưa và chuỗi kết nối trong App.config.";
			}
			return "Có lỗi SQL xảy ra:\n" + sqlException.Message;
		}

		private static string LayTenRangBuoc(string message) {
			Match match = Regex.Match(message, "constraint \\\"([^\\\"]+)\\\"", RegexOptions.IgnoreCase);
			if(match.Success) 
				return match.Groups[1].Value;
			return string.Empty;
		}

		private static string LayTenBang(string message) {
			Match match = Regex.Match(message, "table \\\"dbo\\.([^\\\"]+)\\\"", RegexOptions.IgnoreCase);
			if(match.Success) 
				return match.Groups[1].Value;
			return string.Empty;
		}

		private static string TaoThongBaoKhoaNgoai(string constraintName, string tableName, string message) {
			if(constraintName == "FK_tblToDanPho_tblPhuong") 
				return "Không thể xóa phường này vì đang có tổ dân phố thuộc phường.\n\nCách xử lý: xóa hoặc chuyển các tổ dân phố sang phường khác trước.";
			if(constraintName == "FK_tblNhanKhau_tblToDanPho") 
				return "Không thể xóa tổ dân phố này vì đang có nhân khẩu thuộc tổ dân phố.\n\nCách xử lý: xóa hoặc chuyển nhân khẩu sang tổ dân phố khác trước.";
			if(constraintName == "FK_tblNguoiPhuThuoc_tblNhanKhau") 
				return "Không thể xóa nhân khẩu này vì đang có người phụ thuộc đi kèm.\n\nCách xử lý: xóa người phụ thuộc của nhân khẩu trước.";
			if(constraintName == "FK_tblNghiepVuHoKhau_tblNhanKhau") 
				return "Không thể xóa nhân khẩu này vì đang phát sinh nghiệp vụ hộ khẩu như tách hộ, nhập hộ, chuyển đi, khai sinh hoặc báo tử.\n\nCách xử lý: kiểm tra lịch sử nghiệp vụ trước khi xóa.";
			if(!string.IsNullOrWhiteSpace(tableName))
				return "Không thể xóa hoặc cập nhật vì dữ liệu đang được sử dụng ở bảng " + tableName + ".\n\nVui lòng xử lý dữ liệu liên quan trước.";
			return "Không thể xóa hoặc cập nhật vì dữ liệu đang được sử dụng ở bảng khác.\n\nChi tiết kỹ thuật:\n" + message;
		}

		private static string TaoThongBaoCheck(string constraintName) {
			if(constraintName.Contains("DienThoai")) 
				return "Số điện thoại không hợp lệ. Số điện thoại chỉ gồm chữ số và có độ dài từ 9 đến 11 ký tự.";
			if(constraintName.Contains("CCCD")) 
				return "CCCD không hợp lệ. CCCD phải gồm đúng 12 chữ số.";
			if(constraintName.Contains("GioiTinh")) 
				return "Giới tính không hợp lệ. Chỉ được chọn Nam hoặc Nữ.";
			if(constraintName.Contains("Ngay")) 
				return "Ngày nhập không hợp lệ. Ngày không được lớn hơn ngày hiện tại.";
			if(constraintName.Contains("Loai")) 
				return "Loại nghiệp vụ không hợp lệ. Vui lòng chọn đúng loại nghiệp vụ trong danh sách.";
			return "Dữ liệu không hợp lệ theo điều kiện ràng buộc của cơ sở dữ liệu: " + constraintName;
		}
	}
}

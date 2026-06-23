# 🏙️ Quản Lý Nhân Khẩu Quận

> **🎓 Bài tập lớn môn "Lập trình Hướng sự kiện" - Đại học Mở Hà Nội (HOU)**

Dự án phần mềm Quản lý Nhân khẩu cấp Quận được phát triển trên nền tảng C# .NET (Windows Forms), cung cấp giải pháp quản lý cư dân, hộ khẩu, phường/xã và hệ thống tài khoản phân quyền chi tiết. Điểm nhấn của dự án là hệ thống xuất báo cáo và biểu đồ chuyên nghiệp sử dụng **SAP Crystal Reports**.

## 🚀 Công nghệ sử dụng
* **Ngôn ngữ:** C# (.NET WinForms)
* **Cơ sở dữ liệu:** Microsoft SQL Server (ADO.NET)
* **Báo cáo & Thống kê:** SAP Crystal Reports

## ⚠️ Yêu cầu hệ thống (Prerequisites)
Để mở file thiết kế (`.rpt`) và chạy được project mà không bị lỗi thiếu thư viện báo cáo, máy tính của bạn **bắt buộc** phải cài đặt bộ công cụ SAP Crystal Reports for Visual Studio.

**🔗 Link tải trực tiếp (Bản 64-bit hỗ trợ VS 2022 trở lên):** [Tải SAP Crystal Reports SP40 64b Installer](https://origin-az.softwaredownloads.sap.com/public/file/0020000000374512026)

> **💡 Lưu ý cực kỳ quan trọng khi cài đặt thư viện báo cáo:**
> 1. Tải file cài đặt `.exe` từ link trên về máy.
> 2. **Tắt hoàn toàn Visual Studio** trước khi tiến hành cài đặt để tránh lỗi xung đột.
> 3. Chạy file cài đặt với quyền Admin (Run as Administrator) và Next cho đến khi hoàn thành.
> 4. Project này bắt buộc phải biên dịch ở nền tảng **64-bit (x64)** để tương thích với bộ thư viện mới nhất của SAP.

## ⚙️ Hướng dẫn Cài đặt & Chạy dự án
1. **Clone dự án về máy:**
   ```bash
   git clone [https://github.com/namhoang1811/QuanLyNhanKhauQuan.git](https://github.com/namhoang1811/QuanLyNhanKhauQuan.git)
   ```
2. **Thiết lập Cơ sở dữ liệu:**
   * Mở SQL Server Management Studio (SSMS).
   * Chạy file script SQL (nằm trong thư mục `Database`) để tạo CSDL và cấu trúc bảng.
   * Mở mã nguồn bằng Visual Studio, tìm file cấu hình kết nối và sửa lại `ConnectionString` cho khớp với tên Server SQL của bạn.
3. **Build dự án:**
   * Đảm bảo cấu hình Build đang để ở chế độ **x64** *(Chuột phải Project -> Properties -> Build -> Platform target: x64)*.
   * Chọn `Build -> Rebuild Solution` (hoặc ấn `Ctrl + Shift + B`) để nạp lại toàn bộ thư viện.
4. **Khởi chạy:** Nhấn `F5` hoặc nút Start để khởi động phần mềm.

## 💡 Tính năng chính
* **Quản lý hệ thống:** Đăng nhập, quản lý và phân quyền tài khoản (Admin/Member).
* **Quản lý danh mục:** Quản lý thông tin địa bàn Phường/Xã.
* **Nghiệp vụ cốt lõi:** Quản lý chi tiết nhân khẩu, hộ khẩu, người phụ thuộc trên địa bàn.
* **Hệ thống Báo cáo (Crystal Reports):** * Xuất danh sách tài khoản, danh sách cư dân dạng bảng biểu chuyên nghiệp, căn chỉnh chuẩn in ấn.
  * Tích hợp biểu đồ thống kê trực quan (Pie Chart) để phân tích dữ liệu ngay trên đầu báo cáo.

## 👥 Nhóm Tác Giả (Nhóm 09)
Dự án được thực hiện bởi các thành viên:
* **Hoàng Hồ Nam** *(Trưởng nhóm / GitHub Repo Owner - [@namhoang1811](https://github.com/namhoang1811))*
* **Nguyễn Quang Hưng**
* **Vũ Tuấn Anh**
* **Nguyễn Thế Phong**
* **Nguyễn Duy Hưởng**

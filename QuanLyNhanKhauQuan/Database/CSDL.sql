IF DB_ID(N'QuanLyNhanKhauQuan') IS NOT NULL 
BEGIN
    ALTER DATABASE QuanLyNhanKhauQuan SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QuanLyNhanKhauQuan;
END
GO

CREATE DATABASE QuanLyNhanKhauQuan;
GO

USE QuanLyNhanKhauQuan;
GO

CREATE TABLE tblTaiKhoan
(
    TenDangNhap VARCHAR(50) NOT NULL PRIMARY KEY,
    MatKhau VARBINARY(64) NOT NULL, -- SHA2_512
    HoTen NVARCHAR(100) NOT NULL,
    Quyen NVARCHAR(30) NOT NULL DEFAULT N'Admin',
    TrangThai BIT NOT NULL DEFAULT 1,
    NguoiTao VARCHAR(50) NOT NULL,
    NguoiSua VARCHAR(50) NOT NULL,
    NgayTao DateTime NOT NULL DEFAULT GETDATE(),
    NgaySua DateTime NOT NULL DEFAULT GETDATE(),
);
GO

CREATE TABLE tblPhuong
(
    MaPhuong VARCHAR(20) NOT NULL PRIMARY KEY,
    TenPhuong NVARCHAR(100) NOT NULL UNIQUE,
    DienThoai VARCHAR(11) NOT NULL,
    DiaChi NVARCHAR(200) NOT NULL,
    GhiChu NVARCHAR(200) NULL,
    NguoiTao VARCHAR(50) NOT NULL,
    NguoiSua VARCHAR(50) NOT NULL,
    NgayTao DateTime NOT NULL DEFAULT GETDATE(),
    NgaySua DateTime NOT NULL DEFAULT GETDATE(),
    CONSTRAINT CK_tblPhuong_DienThoai CHECK (DienThoai NOT LIKE '%[^0-9]%' AND LEN(DienThoai) BETWEEN 9 AND 11)
);
GO

CREATE TABLE tblToDanPho
(
    MaToDanPho VARCHAR(20) NOT NULL PRIMARY KEY,
    TenToDanPho NVARCHAR(100) NOT NULL,
    MaPhuong VARCHAR(20) NOT NULL,
    CSKV NVARCHAR(100) NOT NULL,
    ToTruong NVARCHAR(100) NOT NULL,
    DienThoai VARCHAR(11) NOT NULL,
    GhiChu NVARCHAR(200) NULL,
    NguoiTao VARCHAR(50) NOT NULL,
    NguoiSua VARCHAR(50) NOT NULL,
    NgayTao DateTime NOT NULL DEFAULT GETDATE(),
    NgaySua DateTime NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_tblToDanPho_tblPhuong FOREIGN KEY (MaPhuong) REFERENCES tblPhuong(MaPhuong),
    CONSTRAINT CK_tblToDanPho_DienThoai CHECK (DienThoai NOT LIKE '%[^0-9]%' AND LEN(DienThoai) BETWEEN 9 AND 11)
);
GO

CREATE TABLE tblHoKhau
(
    MaHoKhau VARCHAR(20) NOT NULL PRIMARY KEY,
    MaToDanPho VARCHAR(20) NOT NULL,
    MaPhuong VARCHAR(20) NOT NULL,
    DiaChi NVARCHAR(200) NOT NULL,
    GhiChu NVARCHAR(200) NULL,
    NguoiTao VARCHAR(50) NOT NULL,
    NguoiSua VARCHAR(50) NOT NULL,
    NgayTao DateTime NOT NULL DEFAULT GETDATE(),
    NgaySua DateTime NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_tblHoKhau_tblToDanPho FOREIGN KEY (MaToDanPho) REFERENCES tblToDanPho(MaToDanPho),
    CONSTRAINT FK_tblHoKhau_tblPhuong FOREIGN KEY (MaPhuong) REFERENCES tblPhuong(MaPhuong)

);

CREATE TABLE tblNhanKhau
(
    MaNhanKhau VARCHAR(20) NOT NULL PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE NOT NULL,
    GioiTinh NVARCHAR(5) NOT NULL,
    CCCD VARCHAR(12) NOT NULL UNIQUE,
    NgheNghiep NVARCHAR(100) NOT NULL,
    NoiLamViec NVARCHAR(150) NOT NULL,
    DienThoai VARCHAR(11) NOT NULL,
    MaHoKhau VARCHAR(20) NOT NULL,
    QuanHeChuHo NVARCHAR(30) NOT NULL,
    TrangThai NVARCHAR(30) NOT NULL DEFAULT N'Đang sống',
    NguoiTao VARCHAR(50) NOT NULL,
    NguoiSua VARCHAR(50) NOT NULL,
    NgayTao DateTime NOT NULL DEFAULT GETDATE(),
    NgaySua DateTime NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_tblNhanKhau_tblHoKhau FOREIGN KEY (MaHoKhau) REFERENCES tblHoKhau(MaHoKhau),
    CONSTRAINT CK_tblNhanKhau_GioiTinh CHECK (GioiTinh IN (N'Nam', N'Nữ', N'Khác')),
    CONSTRAINT CK_tblNhanKhau_TrangThai CHECK (TrangThai IN (N'Đang sống', N'Đã chết')),
    CONSTRAINT CK_tblNhanKhau_DienThoai CHECK (DienThoai NOT LIKE '%[^0-9]%' AND LEN(DienThoai) BETWEEN 9 AND 11)
);

CREATE TABLE tblNhatKyNghiepVu
(
    MaNghiepVu VARCHAR(20) NOT NULL PRIMARY KEY,
    MaNhanKhau VARCHAR(20) NOT NULL,
    LoaiNghiepVu NVARCHAR(50) NOT NULL,
    NoiDung NVARCHAR(300) NOT NULL,
    GhiChu NVARCHAR(200) NULL,
    NguoiTao VARCHAR(50) NOT NULL,
    NguoiSua VARCHAR(50) NOT NULL,
    NgayTao DateTime NOT NULL DEFAULT GETDATE(),
    NgaySua DateTime NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_tblNhatKyNghiepVu_tblNhanKhau FOREIGN KEY (MaNhanKhau) REFERENCES tblNhanKhau(MaNhanKhau),
    CONSTRAINT CK_tblNhatKyNghiepVu_Loai CHECK (LoaiNghiepVu IN (N'Tách hộ', N'Nhập hộ', N'Chuyển đi', N'Nhập mới sinh', N'Báo tử'))
);
GO

INSERT INTO TaiKhoan VALUES ('admin', HASHBYTES('SHA2_512', '123'), N'Quản trị viên', N'Admin', 1);
GO

INSERT INTO tblPhuong VALUES
('P01', N'Phường Minh Khai', '0243811001', N'Số 1 Minh Khai', N'Khu trung tâm'),
('P02', N'Phường Bạch Mai', '0243811002', N'Số 2 Bạch Mai', N''),
('P03', N'Phường Đồng Tâm', '0243811003', N'Số 3 Đồng Tâm', N''),
('P04', N'Phường Trương Định', '0243811004', N'Số 4 Trương Định', N''),
('P05', N'Phường Thanh Nhàn', '0243811005', N'Số 5 Thanh Nhàn', N''),
('P06', N'Phường Quỳnh Mai', '0243811006', N'Số 6 Quỳnh Mai', N''),
('P07', N'Phường Cầu Dền', '0243811007', N'Số 7 Cầu Dền', N''),
('P08', N'Phường Bách Khoa', '0243811008', N'Số 8 Bách Khoa', N''),
('P09', N'Phường Phố Huế', '0243811009', N'Số 9 Phố Huế', N''),
('P10', N'Phường Vĩnh Tuy', '0243811010', N'Số 10 Vĩnh Tuy', N'');
GO

INSERT INTO tblToDanPho VALUES
('T01', N'Tổ dân phố 01', 'P01', N'Nguyễn Văn An', N'Trần Văn Bình', '0911000001', N''),
('T02', N'Tổ dân phố 02', 'P02', N'Lê Văn Cường', N'Phạm Thị Dung', '0911000002', N''),
('T03', N'Tổ dân phố 03', 'P03', N'Hoàng Văn Đức', N'Nguyễn Thị Hoa', '0911000003', N''),
('T04', N'Tổ dân phố 04', 'P04', N'Trần Văn Hải', N'Lê Thị Hạnh', '0911000004', N''),
('T05', N'Tổ dân phố 05', 'P05', N'Phạm Văn Khánh', N'Đỗ Văn Long', '0911000005', N''),
('T06', N'Tổ dân phố 06', 'P06', N'Vũ Văn Lâm', N'Bùi Thị Mai', '0911000006', N''),
('T07', N'Tổ dân phố 07', 'P07', N'Đặng Văn Minh', N'Ngô Văn Nam', '0911000007', N''),
('T08', N'Tổ dân phố 08', 'P08', N'Bùi Văn Phúc', N'Phan Thị Quỳnh', '0911000008', N''),
('T09', N'Tổ dân phố 09', 'P09', N'Ngô Văn Sơn', N'Vũ Thị Thảo', '0911000009', N''),
('T10', N'Tổ dân phố 10', 'P10', N'Phan Văn Tùng', N'Đặng Thị Yến', '0911000010', N'');
GO


INSERT INTO tblNghiepVuHoKhau VALUES
('NV01', 'NK01', N'Nhập hộ', '2026-01-05', N'Nhập hộ khẩu thường trú tại tổ dân phố 01', N''),
('NV02', 'NK02', N'Nhập hộ', '2026-01-06', N'Nhập hộ khẩu thường trú tại tổ dân phố 02', N''),
('NV03', 'NK03', N'Tách hộ', '2026-01-10', N'Tách hộ độc lập', N''),
('NV04', 'NK04', N'Nhập mới sinh', '2026-02-01', N'Bổ sung nhân khẩu mới sinh trong hộ', N''),
('NV05', 'NK05', N'Nhập hộ', '2026-02-03', N'Nhập hộ thường trú', N''),
('NV06', 'NK06', N'Chuyển đi', '2026-02-15', N'Chuyển hộ khẩu sang địa bàn khác', N''),
('NV07', 'NK07', N'Nhập hộ', '2026-03-02', N'Nhập hộ khẩu tại tổ dân phố 07', N''),
('NV08', 'NK08', N'Tách hộ', '2026-03-08', N'Tách hộ riêng cùng địa bàn', N''),
('NV09', 'NK09', N'Nhập hộ', '2026-03-15', N'Nhập hộ thường trú', N''),
('NV10', 'NK10', N'Nhập hộ', '2026-04-01', N'Nhập hộ thường trú', N'');
GO

CREATE PROCEDURE sp_Phuong_Them @MaPhuong VARCHAR(20), @TenPhuong NVARCHAR(100), @DienThoai VARCHAR(11), @DiaChi NVARCHAR(200), @GhiChu NVARCHAR(200)
AS BEGIN INSERT INTO tblPhuong VALUES (@MaPhuong, @TenPhuong, @DienThoai, @DiaChi, @GhiChu); END
GO
CREATE PROCEDURE sp_Phuong_Sua @MaPhuong VARCHAR(20), @TenPhuong NVARCHAR(100), @DienThoai VARCHAR(11), @DiaChi NVARCHAR(200), @GhiChu NVARCHAR(200)
AS BEGIN UPDATE tblPhuong SET TenPhuong=@TenPhuong, DienThoai=@DienThoai, DiaChi=@DiaChi, GhiChu=@GhiChu WHERE MaPhuong=@MaPhuong; END
GO
CREATE PROCEDURE sp_Phuong_Xoa @MaPhuong VARCHAR(20)
AS BEGIN DELETE FROM tblPhuong WHERE MaPhuong=@MaPhuong; END
GO

CREATE PROCEDURE sp_ToDanPho_Them @MaToDanPho VARCHAR(20), @TenToDanPho NVARCHAR(100), @MaPhuong VARCHAR(20), @CSKV NVARCHAR(100), @ToTruong NVARCHAR(100), @DienThoai VARCHAR(11), @GhiChu NVARCHAR(200)
AS BEGIN INSERT INTO tblToDanPho VALUES (@MaToDanPho, @TenToDanPho, @MaPhuong, @CSKV, @ToTruong, @DienThoai, @GhiChu); END
GO
CREATE PROCEDURE sp_ToDanPho_Sua @MaToDanPho VARCHAR(20), @TenToDanPho NVARCHAR(100), @MaPhuong VARCHAR(20), @CSKV NVARCHAR(100), @ToTruong NVARCHAR(100), @DienThoai VARCHAR(11), @GhiChu NVARCHAR(200)
AS BEGIN UPDATE tblToDanPho SET TenToDanPho=@TenToDanPho, MaPhuong=@MaPhuong, CSKV=@CSKV, ToTruong=@ToTruong, DienThoai=@DienThoai, GhiChu=@GhiChu WHERE MaToDanPho=@MaToDanPho; END
GO
CREATE PROCEDURE sp_ToDanPho_Xoa @MaToDanPho VARCHAR(20)
AS BEGIN DELETE FROM tblToDanPho WHERE MaToDanPho=@MaToDanPho; END
GO

CREATE PROCEDURE sp_NhanKhau_Them @MaNhanKhau VARCHAR(20), @HoTenChuHo NVARCHAR(100), @NgaySinh DATE, @GioiTinh NVARCHAR(5), @CCCD VARCHAR(12), @NgheNghiep NVARCHAR(100), @NoiLamViec NVARCHAR(150), @DiaChi NVARCHAR(200), @DienThoai VARCHAR(11), @MaToDanPho VARCHAR(20), @TinhTrang NVARCHAR(30)
AS BEGIN INSERT INTO tblNhanKhau VALUES (@MaNhanKhau, @HoTenChuHo, @NgaySinh, @GioiTinh, @CCCD, @NgheNghiep, @NoiLamViec, @DiaChi, @DienThoai, @MaToDanPho, @TinhTrang); END
GO
CREATE PROCEDURE sp_NhanKhau_Sua @MaNhanKhau VARCHAR(20), @HoTenChuHo NVARCHAR(100), @NgaySinh DATE, @GioiTinh NVARCHAR(5), @CCCD VARCHAR(12), @NgheNghiep NVARCHAR(100), @NoiLamViec NVARCHAR(150), @DiaChi NVARCHAR(200), @DienThoai VARCHAR(11), @MaToDanPho VARCHAR(20), @TinhTrang NVARCHAR(30)
AS BEGIN UPDATE tblNhanKhau SET HoTenChuHo=@HoTenChuHo, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, CCCD=@CCCD, NgheNghiep=@NgheNghiep, NoiLamViec=@NoiLamViec, DiaChi=@DiaChi, DienThoai=@DienThoai, MaToDanPho=@MaToDanPho, TinhTrang=@TinhTrang WHERE MaNhanKhau=@MaNhanKhau; END
GO
CREATE PROCEDURE sp_NhanKhau_Xoa @MaNhanKhau VARCHAR(20)
AS BEGIN DELETE FROM tblNhanKhau WHERE MaNhanKhau=@MaNhanKhau; END
GO
CREATE PROCEDURE sp_NhanKhau_CapNhatTinhTrang @MaNhanKhau VARCHAR(20), @TinhTrang NVARCHAR(30)
AS BEGIN UPDATE tblNhanKhau SET TinhTrang=@TinhTrang WHERE MaNhanKhau=@MaNhanKhau; END
GO

CREATE PROCEDURE sp_NguoiPhuThuoc_Them @MaPhuThuoc VARCHAR(20), @HoTen NVARCHAR(100), @NgaySinh DATE, @GioiTinh NVARCHAR(5), @NgheNghiep NVARCHAR(100), @QuanHe NVARCHAR(30), @MaNhanKhau VARCHAR(20)
AS BEGIN INSERT INTO tblNguoiPhuThuoc VALUES (@MaPhuThuoc, @HoTen, @NgaySinh, @GioiTinh, @NgheNghiep, @QuanHe, @MaNhanKhau); END
GO
CREATE PROCEDURE sp_NguoiPhuThuoc_Sua @MaPhuThuoc VARCHAR(20), @HoTen NVARCHAR(100), @NgaySinh DATE, @GioiTinh NVARCHAR(5), @NgheNghiep NVARCHAR(100), @QuanHe NVARCHAR(30), @MaNhanKhau VARCHAR(20)
AS BEGIN UPDATE tblNguoiPhuThuoc SET HoTen=@HoTen, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, NgheNghiep=@NgheNghiep, QuanHe=@QuanHe, MaNhanKhau=@MaNhanKhau WHERE MaPhuThuoc=@MaPhuThuoc; END
GO
CREATE PROCEDURE sp_NguoiPhuThuoc_Xoa @MaPhuThuoc VARCHAR(20)
AS BEGIN DELETE FROM tblNguoiPhuThuoc WHERE MaPhuThuoc=@MaPhuThuoc; END
GO

CREATE PROCEDURE sp_NghiepVu_Them @MaNghiepVu VARCHAR(20), @MaNhanKhau VARCHAR(20), @LoaiNghiepVu NVARCHAR(50), @NgayThucHien DATE, @NoiDung NVARCHAR(300), @GhiChu NVARCHAR(200)
AS BEGIN INSERT INTO tblNghiepVuHoKhau VALUES (@MaNghiepVu, @MaNhanKhau, @LoaiNghiepVu, @NgayThucHien, @NoiDung, @GhiChu); END
GO

CREATE PROCEDURE sp_NhanKhau_TimKiem @TieuChi NVARCHAR(50), @TuKhoa NVARCHAR(100)
AS
BEGIN
    SELECT MaNhanKhau, HoTenChuHo, NgaySinh, GioiTinh, CCCD, DiaChi, DienThoai, TinhTrang
    FROM tblNhanKhau
    WHERE (@TieuChi = N'Họ tên chủ hộ' AND HoTenChuHo LIKE N'%' + @TuKhoa + N'%')
       OR (@TieuChi = N'CCCD' AND CCCD LIKE '%' + @TuKhoa + '%')
       OR (@TieuChi = N'Điện thoại' AND DienThoai LIKE '%' + @TuKhoa + '%')
       OR (@TieuChi = N'Tình trạng' AND TinhTrang LIKE N'%' + @TuKhoa + N'%')
    ORDER BY MaNhanKhau;
END
GO

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
	ViTri NVARCHAR(50) NOT NULL,	
    Quyen VARCHAR(30) NOT NULL DEFAULT 'Admin',
	DienThoai VARCHAR(11),
    TrangThai BIT NOT NULL DEFAULT 1,
    NguoiTao VARCHAR(50),
    NguoiSua VARCHAR(50),
    NgayTao DateTime NOT NULL DEFAULT GETDATE(),
    NgaySua DateTime NOT NULL DEFAULT GETDATE(),
    CONSTRAINT CK_tblTaiKhoan_DienThoai CHECK (DienThoai IS NULL OR (DienThoai NOT LIKE '%[^0-9]%' AND LEN(DienThoai) BETWEEN 9 AND 11))
);
GO

CREATE TABLE tblPhuong
(
    MaPhuong VARCHAR(20) NOT NULL PRIMARY KEY,
    TenPhuong NVARCHAR(100) NOT NULL UNIQUE,
    DienThoai VARCHAR(11) NOT NULL,
    DiaChi NVARCHAR(200) NOT NULL,
    GhiChu NVARCHAR(200) NULL,
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
    CONSTRAINT FK_tblToDanPho_tblPhuong FOREIGN KEY (MaPhuong) REFERENCES tblPhuong(MaPhuong),
    CONSTRAINT CK_tblToDanPho_DienThoai CHECK (DienThoai NOT LIKE '%[^0-9]%' AND LEN(DienThoai) BETWEEN 9 AND 11)
);
GO

CREATE TABLE tblNhanKhau(
	MaNhanKhau varchar(20) NOT NULL PRIMARY KEY,
	HoTenChuHo nvarchar(100) NOT NULL,
	NgaySinh date NOT NULL,
	GioiTinh nvarchar(5) NOT NULL,
	CCCD varchar(12) NOT NULL,
	NgheNghiep nvarchar(100) NULL,
	NoiLamViec nvarchar(150) NULL,
	DiaChi nvarchar(200) NOT NULL,
	DienThoai varchar(11) NOT NULL,
	MaToDanPho varchar(20) NOT NULL,
	TinhTrang nvarchar(30) NOT NULL,
	CONSTRAINT FK_tblNhanKhau_tblToDanPho FOREIGN KEY (MaToDanPho) REFERENCES tblToDanPho(MaToDanPho),
	CONSTRAINT CK_tblNhanKhau_DienThoai CHECK (DienThoai NOT LIKE '%[^0-9]%' AND LEN(DienThoai) BETWEEN 9 AND 11)
);

CREATE TABLE tblNguoiPhuThuoc(
	MaPhuThuoc varchar(20) NOT NULL PRIMARY KEY,
	HoTen nvarchar(100) NOT NULL,
	NgaySinh date NOT NULL,
	GioiTinh nvarchar(5) NOT NULL,
	NgheNghiep nvarchar(100) NULL,
	QuanHe nvarchar(30) NOT NULL,
	MaNhanKhau varchar(20) NOT NULL,
	CONSTRAINT FK_tblNguoiPhuThuoc_tblNhanKhau FOREIGN KEY (MaNhanKhau) REFERENCES tblNhanKhau(MaNhanKhau),
);

CREATE TABLE tblNghiepVuHoKhau
(
    MaNghiepVu VARCHAR(20) NOT NULL PRIMARY KEY,
    MaNhanKhau VARCHAR(20) NOT NULL,
    LoaiNghiepVu NVARCHAR(50) NOT NULL,
	NgayThucHien DATE NOT NULL,
    NoiDung NVARCHAR(300) NOT NULL,
    GhiChu NVARCHAR(200) NULL,
    CONSTRAINT FK_tblNhatKyNghiepVu_tblNhanKhau FOREIGN KEY (MaNhanKhau) REFERENCES tblNhanKhau(MaNhanKhau),
    CONSTRAINT CK_tblNhatKyNghiepVu_Loai CHECK (LoaiNghiepVu IN (N'Tách hộ', N'Nhập hộ', N'Chuyển đi', N'Nhập mới sinh', N'Báo tử'))
);
GO

INSERT INTO tblTaiKhoan(TenDangNhap, MatKhau, HoTen, ViTri, Quyen, DienThoai) 
	VALUES ('admin', HASHBYTES('SHA2_512', '123'), N'Nguyễn Văn A', N'Chủ tịch', 'Admin', '0909123456');
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

INSERT INTO dbo.tblNhanKhau VALUES 
('NK01', N'Nguyễn Văn Hùng', '1980-05-12', N'Nam', '001080000001', N'Kỹ sư', N'Công ty xây dựng Hà Nội', N'12 Minh Khai', '0988000001', 'T01', N'Đang cư trú'),
('NK02', N'Trần Thị Lan', '1985-07-20', N'Nữ', '001085000002', N'Giáo viên', N'Trường THCS Bạch Mai', N'18 Bạch Mai', '0988000002', 'T02', N'Đang cư trú'),
('NK03', N'Lê Văn Nam', '1979-03-10', N'Nam', '001079000003', N'Kinh doanh', N'Cửa hàng gia đình', N'25 Đồng Tâm', '0988000003', 'T03', N'Đang cư trú'),
('NK04', N'Phạm Thị Mai', '1990-09-15', N'Nữ', '001090000004', N'Kế toán', N'Công ty thương mại', N'30 Trương Định', '0988000004', 'T04', N'Đang cư trú'),
('NK05', N'Hoàng Văn Phúc', '1975-12-01', N'Nam', '001075000005', N'Công chức', N'UBND quận', N'45 Thanh Nhàn', '0988000005', 'T05', N'Đang cư trú'),
('NK06', N'Đỗ Thị Hạnh', '1988-11-22', N'Nữ', '001088000006', N'Nhân viên', N'Công ty dịch vụ', N'16 Quỳnh Mai', '0988000006', 'T06', N'Đang cư trú'),
('NK07', N'Vũ Văn Long', '1982-01-08', N'Nam', '001082000007', N'Lái xe', N'Hợp tác xã vận tải', N'21 Cầu Dền', '0988000007', 'T07', N'Đang cư trú'),
('NK08', N'Bùi Thị Thu', '1992-04-18', N'Nữ', '001092000008', N'Bác sĩ', N'Bệnh viện Bạch Mai', N'9 Bách Khoa', '0988000008', 'T08', N'Đang cư trú'),
('NK09', N'Ngô Văn Quân', '1983-06-30', N'Nam', '001083000009', N'Công nhân', N'Nhà máy cơ khí', N'5 Phố Huế', '0988000009', 'T09', N'Đang cư trú'),
('NK10', N'Đặng Thị Yến', '1986-08-25', N'Nữ', '001086000010', N'Bán hàng', N'Siêu thị Vĩnh Tuy', N'40 Vĩnh Tuy', '0988000010', 'T10', N'Đang cư trú');
GO

INSERT INTO dbo.tblNguoiPhuThuoc VALUES 
('PT01', N'Nguyễn Thị Hoa', '1982-10-12', N'Nữ', N'Nội trợ', N'Vợ', 'NK01'),
('PT02', N'Nguyễn Minh Anh', '2010-02-03', N'Nữ', N'Học sinh', N'Con', 'NK01'),
('PT03', N'Trần Văn Minh', '2012-09-20', N'Nam', N'Học sinh', N'Con', 'NK02'),
('PT04', N'Lê Thị Hương', '1981-01-11', N'Nữ', N'Nhân viên', N'Vợ', 'NK03'),
('PT05', N'Lê Gia Bảo', '2015-06-07', N'Nam', N'Học sinh', N'Con', 'NK03'),
('PT06', N'Phạm Minh Châu', '2018-04-14', N'Nữ', N'Mầm non', N'Con', 'NK04'),
('PT07', N'Hoàng Thị Nhung', '1978-08-01', N'Nữ', N'Nội trợ', N'Vợ', 'NK05'),
('PT08', N'Đỗ Gia Huy', '2014-12-22', N'Nam', N'Học sinh', N'Con', 'NK06'),
('PT09', N'Vũ Thanh Tùng', '2011-03-19', N'Nam', N'Học sinh', N'Con', 'NK07'),
('PT10', N'Bùi Mai Phương', '2016-07-27', N'Nữ', N'Học sinh', N'Con', 'NK08');
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


CREATE OR ALTER PROCEDURE sp_TaiKhoan_Them @TenDangNhap VARCHAR(50), @MatKhau VARCHAR(64), @HoTen NVARCHAR(100), @ViTri NVARCHAR(50), @Quyen VARCHAR(20), @DienThoai NVARCHAR(11), @NguoiTao VARCHAR(50)
AS BEGIN 
	INSERT INTO tblTaiKhoan(TenDangNhap, MatKhau, HoTen, ViTri, Quyen, DienThoai, NguoiTao, NguoiSua) 
	VALUES (@TenDangNhap, HASHBYTES('SHA2_512', @MatKhau), @HoTen, @ViTri, @Quyen, @DienThoai, @NguoiTao, @NguoiTao); 
END
GO
CREATE OR ALTER PROCEDURE sp_TaiKhoan_Sua @TenDangNhap VARCHAR(50), @MatKhau VARCHAR(64), @HoTen NVARCHAR(100), @ViTri NVARCHAR(50), @Quyen VARCHAR(20), @DienThoai NVARCHAR(11), @NguoiSua VARCHAR(50)
AS BEGIN 
	IF @MatKhau IS NULL OR @MatKhau = ''
		UPDATE tblTaiKhoan SET HoTen=@HoTen, @ViTri= @ViTri, Quyen= @Quyen, DienThoai = @DienThoai WHERE TenDangNhap = @TenDangNhap;
	ELSE
		UPDATE tblTaiKhoan SET MatKhau = HASHBYTES('SHA2_512', @MatKhau), HoTen = @HoTen, @ViTri= @ViTri, Quyen= @Quyen, DienThoai= @DienThoai, NguoiSua = @NguoiSua, NgaySua = GETDATE() WHERE TenDangNhap = @TenDangNhap;
	END
GO
CREATE OR ALTER PROCEDURE sp_TaiKhoan_DoiMatKhau @TenDangNhap VARCHAR(50), @MatKhau VARCHAR(64)
AS BEGIN 
		UPDATE tblTaiKhoan SET MatKhau = HASHBYTES('SHA2_512', @MatKhau), NguoiSua = @TenDangNhap, NgaySua = GETDATE() WHERE TenDangNhap = @TenDangNhap;
	END
GO
CREATE PROCEDURE sp_TaiKhoan_Xoa @TenDangNhap VARCHAR(50)
AS BEGIN 
		DELETE FROM tblTaiKhoan WHERE TenDangNhap = @TenDangNhap; 
	END
GO

CREATE OR ALTER PROCEDURE sp_Phuong_Them @MaPhuong VARCHAR(20), @TenPhuong NVARCHAR(100), @DienThoai VARCHAR(11), @DiaChi NVARCHAR(200), @GhiChu NVARCHAR(200)
AS BEGIN INSERT INTO tblPhuong VALUES (@MaPhuong, @TenPhuong, @DienThoai, @DiaChi, @GhiChu); END
GO
CREATE OR ALTER PROCEDURE sp_Phuong_Sua @MaPhuong VARCHAR(20), @TenPhuong NVARCHAR(100), @DienThoai VARCHAR(11), @DiaChi NVARCHAR(200), @GhiChu NVARCHAR(200)
AS BEGIN UPDATE tblPhuong SET TenPhuong=@TenPhuong, DienThoai=@DienThoai, DiaChi=@DiaChi, GhiChu=@GhiChu WHERE MaPhuong=@MaPhuong; END
GO
CREATE OR ALTER PROCEDURE sp_Phuong_Xoa @MaPhuong VARCHAR(20)
AS BEGIN DELETE FROM tblPhuong WHERE MaPhuong=@MaPhuong; END
GO

CREATE OR ALTER PROCEDURE sp_ToDanPho_Them @MaToDanPho VARCHAR(20), @TenToDanPho NVARCHAR(100), @MaPhuong VARCHAR(20), @CSKV NVARCHAR(100), @ToTruong NVARCHAR(100), @DienThoai VARCHAR(11), @GhiChu NVARCHAR(200)
AS BEGIN INSERT INTO tblToDanPho VALUES (@MaToDanPho, @TenToDanPho, @MaPhuong, @CSKV, @ToTruong, @DienThoai, @GhiChu); END
GO
CREATE OR ALTER PROCEDURE sp_ToDanPho_Sua @MaToDanPho VARCHAR(20), @TenToDanPho NVARCHAR(100), @MaPhuong VARCHAR(20), @CSKV NVARCHAR(100), @ToTruong NVARCHAR(100), @DienThoai VARCHAR(11), @GhiChu NVARCHAR(200)
AS BEGIN UPDATE tblToDanPho SET TenToDanPho=@TenToDanPho, MaPhuong=@MaPhuong, CSKV=@CSKV, ToTruong=@ToTruong, DienThoai=@DienThoai, GhiChu=@GhiChu WHERE MaToDanPho=@MaToDanPho; END
GO
CREATE OR ALTER PROCEDURE sp_ToDanPho_Xoa @MaToDanPho VARCHAR(20)
AS BEGIN DELETE FROM tblToDanPho WHERE MaToDanPho=@MaToDanPho; END
GO

CREATE OR ALTER PROCEDURE sp_NhanKhau_Them @MaNhanKhau VARCHAR(20), @HoTenChuHo NVARCHAR(100), @NgaySinh DATE, @GioiTinh NVARCHAR(5), @CCCD VARCHAR(12), @NgheNghiep NVARCHAR(100), @NoiLamViec NVARCHAR(150), @DiaChi NVARCHAR(200), @DienThoai VARCHAR(11), @MaToDanPho VARCHAR(20), @TinhTrang NVARCHAR(30)
AS BEGIN INSERT INTO tblNhanKhau VALUES (@MaNhanKhau, @HoTenChuHo, @NgaySinh, @GioiTinh, @CCCD, @NgheNghiep, @NoiLamViec, @DiaChi, @DienThoai, @MaToDanPho, @TinhTrang); END
GO
CREATE OR ALTER PROCEDURE sp_NhanKhau_Sua @MaNhanKhau VARCHAR(20), @HoTenChuHo NVARCHAR(100), @NgaySinh DATE, @GioiTinh NVARCHAR(5), @CCCD VARCHAR(12), @NgheNghiep NVARCHAR(100), @NoiLamViec NVARCHAR(150), @DiaChi NVARCHAR(200), @DienThoai VARCHAR(11), @MaToDanPho VARCHAR(20), @TinhTrang NVARCHAR(30)
AS BEGIN UPDATE tblNhanKhau SET HoTenChuHo=@HoTenChuHo, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, CCCD=@CCCD, NgheNghiep=@NgheNghiep, NoiLamViec=@NoiLamViec, DiaChi=@DiaChi, DienThoai=@DienThoai, MaToDanPho=@MaToDanPho, TinhTrang=@TinhTrang WHERE MaNhanKhau=@MaNhanKhau; END
GO
CREATE OR ALTER PROCEDURE sp_NhanKhau_Xoa @MaNhanKhau VARCHAR(20)
AS BEGIN DELETE FROM tblNhanKhau WHERE MaNhanKhau=@MaNhanKhau; END
GO
CREATE OR ALTER PROCEDURE sp_NhanKhau_CapNhatTinhTrang @MaNhanKhau VARCHAR(20), @TinhTrang NVARCHAR(30)
AS BEGIN UPDATE tblNhanKhau SET TinhTrang=@TinhTrang WHERE MaNhanKhau=@MaNhanKhau; END
GO

CREATE OR ALTER PROCEDURE sp_NguoiPhuThuoc_Them @MaPhuThuoc VARCHAR(20), @HoTen NVARCHAR(100), @NgaySinh DATE, @GioiTinh NVARCHAR(5), @NgheNghiep NVARCHAR(100), @QuanHe NVARCHAR(30), @MaNhanKhau VARCHAR(20)
AS BEGIN INSERT INTO tblNguoiPhuThuoc VALUES (@MaPhuThuoc, @HoTen, @NgaySinh, @GioiTinh, @NgheNghiep, @QuanHe, @MaNhanKhau); END
GO
CREATE OR ALTER PROCEDURE sp_NguoiPhuThuoc_Sua @MaPhuThuoc VARCHAR(20), @HoTen NVARCHAR(100), @NgaySinh DATE, @GioiTinh NVARCHAR(5), @NgheNghiep NVARCHAR(100), @QuanHe NVARCHAR(30), @MaNhanKhau VARCHAR(20)
AS BEGIN UPDATE tblNguoiPhuThuoc SET HoTen=@HoTen, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, NgheNghiep=@NgheNghiep, QuanHe=@QuanHe, MaNhanKhau=@MaNhanKhau WHERE MaPhuThuoc=@MaPhuThuoc; END
GO
CREATE OR ALTER PROCEDURE sp_NguoiPhuThuoc_Xoa @MaPhuThuoc VARCHAR(20)
AS BEGIN DELETE FROM tblNguoiPhuThuoc WHERE MaPhuThuoc=@MaPhuThuoc; END
GO

CREATE OR ALTER PROCEDURE sp_NghiepVu_Them @MaNghiepVu VARCHAR(20), @MaNhanKhau VARCHAR(20), @LoaiNghiepVu NVARCHAR(50), @NgayThucHien DATE, @NoiDung NVARCHAR(300), @GhiChu NVARCHAR(200)
AS BEGIN INSERT INTO tblNghiepVuHoKhau VALUES (@MaNghiepVu, @MaNhanKhau, @LoaiNghiepVu, @NgayThucHien, @NoiDung, @GhiChu); END
GO

CREATE OR ALTER PROCEDURE sp_NhanKhau_TimKiem @TieuChi NVARCHAR(50), @TuKhoa NVARCHAR(100)
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

CREATE DATABASE QuanLyNhaSach_CNPM
GO

USE QuanLyNhaSach_CNPM
GO

CREATE TABLE THELOAISACH
(
	MaTheLoai INT IDENTITY PRIMARY KEY,
	TenTheLoai NVARCHAR(100)
)
GO

CREATE TABLE TACGIA
(
	MaTacGia INT IDENTITY PRIMARY KEY,
	TenTacGia NVARCHAR(100)
)

CREATE TABLE DAUSACH
(
	MaDauSach INT IDENTITY PRIMARY KEY,
	TenDauSach NVARCHAR(100),
	MaTheLoai INT FOREIGN KEY REFERENCES THELOAISACH(MaTheLoai),
)

CREATE TABLE CT_TACGIA
(
	MaDauSach INT FOREIGN KEY REFERENCES DAUSACH(MaDauSach),
	MaTacGia INT FOREIGN KEY REFERENCES TACGIA(MaTacGia),
	CONSTRAINT PK_CTTACGIA PRIMARY KEY (MaDauSach,MaTacGia)
)

CREATE TABLE SACH
(
	MaSach INT IDENTITY  PRIMARY KEY,
	MaDauSach INT FOREIGN KEY REFERENCES DAUSACH(MaDauSach),
	NhaXuatBan NVARCHAR(100) NOT NULL,
	NamXuatBan INT NOT NULL,
	SoLuongTon INT NOT NULL DEFAULT 0,
	DonGiaNhap FLOAT NOT NULL DEFAULT 0,
)
GO

CREATE TABLE PHIEUNHAPSACH
(
	SoPhieuNhap INT IDENTITY PRIMARY KEY,
	NgayLap DATE NOT NULL DEFAULT GETDATE(),
	TongTien FLOAT DEFAULT 0,
)
GO

CREATE TABLE CT_PHIEUNHAPSACH
(
	SoPhieuNhap INT NOT NULL FOREIGN KEY REFERENCES PHIEUNHAPSACH(SoPhieuNhap),
	MaSach INT NOT NULL FOREIGN KEY REFERENCES SACH(MaSach),
	SoLuongNhap INT NOT NULL DEFAULT 0,
	DonGiaNhap FLOAT NOT NULL DEFAULT 0,
	ThanhTien FLOAT NOT NULL DEFAULT 0,	
	CONSTRAINT PK_CTPHIEUNHAPSACH PRIMARY KEY (SoPhieuNhap,MaSach)
)

CREATE TABLE KHACHHANG
(
	MaKhachHang INT IDENTITY PRIMARY KEY,
	TenKhachHang NVARCHAR(100) NOT NULL DEFAULT ' ',
	DiaChi NVARCHAR(200)NOT NULL DEFAULT ' ',
	SoDienThoai VARCHAR(11)NOT NULL DEFAULT ' ',
	Email VARCHAR(100)NOT NULL DEFAULT ' ',
	SoTienNo FLOAT NOT NULL DEFAULT 0
)
GO

CREATE TABLE HOADON
(
	SoHoaDon INT IDENTITY PRIMARY KEY,
	MaKhachHang INT NOT NULL FOREIGN KEY REFERENCES KHACHHANG(MaKhachHang),
	NgayLap DATE NOT NULL DEFAULT GETDATE(),
	TongTien FLOAT NOT NULL DEFAULT 0,
	ThanhToan float NOT NULL DEFAULT 0,
	ConLai FLOAT NOT NULL DEFAULT 0
)
GO

CREATE TABLE CT_HOADON
(
	SoHoaDon INT NOT NULL FOREIGN KEY REFERENCES HOADON(SoHoaDon),
	MaSach INT NOT NULL FOREIGN KEY REFERENCES SACH(MaSach),
	SoLuong INT NOT NULL DEFAULT 0,
	DonGiaBan FLOAT NOT NULL DEFAULT 0,
	ThanhTien FLOAT DEFAULT 0,
	CONSTRAINT PK_CTHD PRIMARY KEY(SoHoaDon,MaSach)
)
GO


CREATE TABLE PHIEUTHUTIEN
(
	SoPhieuThu INT IDENTITY PRIMARY KEY,
	MaKhachHang INT NOT NULL FOREIGN KEY REFERENCES KHACHHANG(MaKhachHang),
	NgayLap DATE NOT NULL DEFAULT GETDATE(),
	SoTienThu FLOAT NOT NULL DEFAULT 0
)
GO


CREATE TABLE BAOCAOTON
(
	Thang INT NOT NULL CHECK(Thang >=1 and Thang <=12) DEFAULT MONTH(GETDATE()) ,
	Nam INT NOT NULL CHECK(Nam!=0) DEFAULT YEAR(GETDATE()),
	MaSach INT NOT NULL FOREIGN KEY REFERENCES SACH(MaSach),
	TonDau INT NOT NULL DEFAULT 0,
	PhatSinh INT NOT NULL DEFAULT 0,
	TonCuoi INT NOT NULL DEFAULT 0,
	CONSTRAINT PK_ReportCountInfo PRIMARY KEY( Thang,Nam,MaSach)
)
GO

CREATE TABLE BAOCAOCONGNO
(
	Thang INT NOT NULL,
	Nam INT NOT NULL,
	MaKhachHang INT NOT NULL FOREIGN KEY REFERENCES KHACHHANG(MaKhachHang),
	NoDau FLOAT NOT NULL DEFAULT 0,
	PhatSinh FLOAT NOT NULL DEFAULT 0,
	NoCuoi FLOAT NOT NULL DEFAULT 0,
	CONSTRAINT PK_CTBAOCAONO PRIMARY KEY (Thang,Nam,MaKhachHang)
)
GO


CREATE TABLE CHUCNANG
(
	MaChucNang INT PRIMARY KEY,
	TenChucNang NVARCHAR(100),
	TenManHinhDuocLoad VARCHAR(100)
)
GO

CREATE TABLE NHOMNGUOIDUNG
(
	MaNhom INT IDENTITY PRIMARY KEY,
	TenNhom NVARCHAR(100)
)
GO


CREATE TABLE PHANQUYEN
(
	MaNhom INT FOREIGN KEY REFERENCES NHOMNGUOIDUNG(MaNhom),
	MaChucNang INT FOREIGN KEY REFERENCES CHUCNANG(MaChucNang)
	CONSTRAINT PK_PHANQUYEN PRIMARY KEY(MaNhom,MaChucNang)
) 
GO

CREATE TABLE NGUOIDUNG
(
	TenDangNhap VARCHAR(100) NOT NULL DEFAULT '' PRIMARY KEY,
	TenHienThi NVARCHAR(100),
	MatKhau VARCHAR(100) NOT NULL DEFAULT '',
	MaNhom INT NOT NULL FOREIGN KEY REFERENCES NHOMNGUOIDUNG(MaNhom)
)
GO 

CREATE TABLE THAMSO
(
	TenThamSo	VARCHAR(100) NOT NULL PRIMARY KEY,
	GiaTri		FLOAT NOT NULL DEFAULT 0
)
GO

INSERT THAMSO VALUES('TiLeTinhDonGiaBan',1.05)
INSERT THAMSO VALUES('SoTienNoToiDa',20)
INSERT THAMSO VALUES('SoLuongTonToiThieu',20)
INSERT THAMSO VALUES('SoLuongTonToiDa',300)
INSERT THAMSO VALUES('SoLuongNhapToiThieu ',150)
INSERT THAMSO VALUES('ApDungQD4 ',1)
GO

INSERT NHOMNGUOIDUNG(TenNhom)values('admin')
INSERT NGUOIDUNG VALUES('admin','admin','admin',2)
go


CREATE PROC USP_AddAuthor
@name NVARCHAR(100)
AS
BEGIN
INSERT TACGIA(TenTacGia) VALUES (@name)
END
GO

CREATE PROC USP_AddAuthorInfo
@idAuthor INT
AS
BEGIN
	DECLARE @idBookTitle INT
	SELECT @idBookTitle=MAX(MaDauSach) FROM DAUSACH
	INSERT CT_TACGIA(MaDauSach,MaTacGia)VALUES(@idBookTitle,@idAuthor)
END 
GO

CREATE PROC USP_AddAuthorInfoByBookTitleID
@id INT,
@idAuthor INT
AS
BEGIN
	INSERT CT_TACGIA(MaDauSach,MaTacGia)VALUES(@id,@idAuthor)
END 
GO

CREATE PROC USP_AddBookTitle
@name NVARCHAR(100),
@idCategory INT
AS
BEGIN
	INSERT DAUSACH(TenDauSach,MaTheLoai)VALUES(@name,@idCategory)
END 
GO

CREATE PROC USP_AddCategory
@name NVARCHAR(100)
AS
BEGIN
INSERT THELOAISACH(TenTheLoai) VALUES (@name)
END
GO

CREATE PROC USP_AddCustomer
@name NVARCHAR(100),
@address NVARCHAR(100),
@phoneNumber VARCHAR(100),
@email VARCHAR(100),
@owe FLOAT
AS
BEGIN
	INSERT KHACHHANG(TenKhachHang,DiaChi,SoDienThoai,Email,SoTienNo) VALUES(
	@name,
	@address,
	@phoneNumber,
	@email,
	@owe
	)
END
GO

CREATE PROC USP_GetAccountByUserName
@userName VARCHAR(100)
AS
BEGIN
	SELECT TenDangNhap as userName,TenHienThi as displayName,MatKhau as passWord,MaNhom as type FROM NGUOIDUNG WHERE TenDangNhap=@userName
END
GO

CREATE PROC USP_GetAuthorsByBookTitleID
@id INT
AS 
BEGIN
	SELECT t.MaTacGia as id,t.TenTacGia as name FROM CT_TACGIA ct,TACGIA t WHERE ct.MaDauSach=@id and ct.MaTacGia=t.MaTacGia
END
GO

CREATE PROC USP_GetBookTitleByBookTitleID
@id INT
AS 
BEGIN
	SELECT MaDauSach as id,TenDauSach as name,MaTheLoai as idCategory FROM DAUSACH WHERE MaDauSach=@id
END
GO

CREATE PROC USP_GetCustomerByCustomerID
@id INT
AS
BEGIN
	SELECT  MaKhachHang as id,TenKhachHang name,DiaChi as address,SoDienThoai as phoneNumber,Email as email,SoTienNo as owe FROM KHACHHANG WHERE MaKhachHang=@id
END
GO

CREATE PROC USP_GetCountVersionByBookTitleID
@id INT
AS
BEGIN
	SELECT COUNT(SACH.MaSach) as countVersion
	FROM SACH
	WHERE SACH.MaDauSach= @id
END
GO

CREATE PROC USP_GetListAuthor
AS
BEGIN
SELECT MaTacGia as id,TenTacGia as name FROM TACGIA 
END
GO

CREATE PROC USP_GetListCategory
AS
BEGIN
SELECT MaTheLoai as id,TenTheLoai as name FROM THELOAISACH 
END
GO

CREATE PROC USP_GetListCustomer
AS
BEGIN
SELECT MaKhachHang as id,TenKhachHang name,DiaChi as address,SoDienThoai as phoneNumber,Email as email,SoTienNo as owe FROM KHACHHANG
END
GO

CREATE PROC USP_GetListNameAuthorByBookTitleID
@id INT
AS
BEGIN
	SELECT t.TenTacGia as author
	FROM TACGIA t, CT_TACGIA ct,DAUSACH d
	WHERE t.MaTacGia=ct.MaTacGia and d.MaDauSach=ct.MaDauSach and d.MaDauSach=@id
END
GO

CREATE PROC USP_GetTotalCountByBookTitleID
@id INT
AS
BEGIN
	SELECT SUM(SACH.SoLuongTon) as totalCount
	FROM SACH
	WHERE SACH.MaDauSach= @id
END
GO

CREATE PROC USP_LoadListBookTitle
AS
BEGIN
	SELECT d.MaDauSach as id,d.TenDauSach as name,th.TenTheLoai as category
	FROM DAUSACH d, THELOAISACH th
	WHERE d.MaTheLoai=th.MaTheLoai
END
GO

CREATE PROC USP_Login
@userName VARCHAR(100),
@passWord VARCHAR(100)
AS
BEGIN
SELECT * FROM dbo.NGUOIDUNG WHERE @userName=TenDangNhap AND @passWord=MatKhau
END
GO

CREATE PROC USP_RemoveAuthorByAuthorID
@id INT
AS
BEGIN
DELETE TACGIA WHERE MaTacGia =@id
END
GO

CREATE PROC USP_RemoveBookTitleByBookTitleID
@id INT
AS
BEGIN
	DELETE CT_TACGIA WHERE MaDauSach=@id
	DELETE DAUSACH WHERE MaDauSach=@id
END
GO

CREATE PROC USP_RemoveCategoryByCategoryID
@id INT
AS
BEGIN
DELETE THELOAISACH WHERE MaTheLoai =@id
END
GO

CREATE PROC USP_RemoveCustomerByCustomerID
@id INT
AS
BEGIN
	DELETE KHACHHANG WHERE MaKhachHang= @id
END
GO

CREATE PROC USP_UpdateAuthor
@id INT,
@name NVARCHAR(100)
AS
BEGIN
UPDATE TACGIA SET TenTacGia=@name WHERE MaTacGia = @id
END
GO

CREATE PROC USP_UpdateBookTitle
@id INT,	
@name NVARCHAR(100),
@idCategory INT
AS
BEGIN
	UPDATE DAUSACH 
	SET TenDauSach=@name, MaTheLoai=@idCategory
	WHERE MaDauSach=@id

	DELETE CT_TACGIA WHERE MaDauSach=@id
END
GO

CREATE PROC USP_UpdateCategory
@id INT,
@name NVARCHAR(100)
AS
BEGIN
UPDATE THELOAISACH SET TenTheLoai=@name WHERE MaTheLoai = @id
END
GO

CREATE PROC USP_UpdateCustomer
@id INT,
@name NVARCHAR(100),
@address NVARCHAR(100),
@phoneNumber VARCHAR(100),
@email VARCHAR(100),
@owe FLOAT
AS
BEGIN
	UPDATE KHACHHANG 
	SET
		TenKhachHang=@name,
		DiaChi=@address,
		SoDienThoai=@phoneNumber,
		Email=@email,
		SoTienNo=@owe
	WHERE MaKhachHang=@id
END
GO

CREATE PROC USP_GetNewIDImportBook
AS
BEGIN
	SELECT MAX(SoPhieuNhap)+1 FROM PHIEUNHAPSACH
END
GO

CREATE PROC USP_GetPublishingByBookTitleID
@id INT
AS
BEGIN
	SELECT NhaXuatBan as publishCompany,NamXuatBan as publishYear FROM SACH WHERE MaDauSach=@id
END
GO

CREATE PROC USP_AddBook
@idBookTitle INT,
@publishCompany NVARCHAR(100),
@publishYear INT
AS
BEGIN
	INSERT SACH(MaDauSach,NhaXuatBan,NamXuatBan,SoLuongTon,DonGiaNhap)VALUES(
	@idBookTitle,
	@publishCompany,
	@publishYear,
	0,
	0
	)
END
GO

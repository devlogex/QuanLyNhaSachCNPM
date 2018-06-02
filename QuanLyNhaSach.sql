CREATE DATABASE QuanLyNhaSach
GO

USE QuanLyNhaSach
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

CREATE TABLE NGUOIDUNG
(
	TenDangNhap VARCHAR(100) NOT NULL DEFAULT '' PRIMARY KEY,
	TenHienThi NVARCHAR(100),
	MatKhau VARCHAR(100) NOT NULL DEFAULT '',
	LoaiTaiKhoan INT NOT NULL DEFAULT 0 --0:ADMIN , 1:STAFF
)
GO 
INSERT NGUOIDUNG VALUES('admin','admin','admin',0)
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

CREATE PROC USP_GetMinImport
AS
BEGIN
	SELECT GiaTri FROM THAMSO WHERE TenThamSo='SoLuongNhapToiThieu'
END
GO

CREATE PROC USP_SetMinImport
@minImport INT
AS
BEGIN
	UPDATE THAMSO SET GiaTri=@minImport WHERE TenThamSo='SoLuongNhapToiThieu'
END
GO

CREATE PROC USP_GetMaxCount
AS
BEGIN
	SELECT GiaTri FROM THAMSO WHERE TenThamSo='SoLuongTonToiDa'
END
GO

CREATE PROC USP_SetMaxCount
@maxCount INT
AS
BEGIN
	UPDATE THAMSO SET GiaTri=@maxCount WHERE TenThamSo='SoLuongTonToiDa'
END
GO

CREATE PROC USP_GetMinCount
AS
BEGIN
	SELECT GiaTri FROM THAMSO WHERE TenThamSo='SoLuongTonToiThieu'
END
GO

CREATE PROC USP_SetMinCount
@minCount INT
AS
BEGIN
	UPDATE THAMSO SET GiaTri=@minCount WHERE TenThamSo='SoLuongTonToiThieu'
END
GO

CREATE PROC USP_GetMaxOwe
AS
BEGIN
	SELECT GiaTri FROM THAMSO WHERE TenThamSo='SoTienNoToiDa'
END
GO

CREATE PROC USP_SetMaxOwe
@maxOwe INT
AS
BEGIN
	UPDATE THAMSO SET GiaTri=@maxOwe WHERE TenThamSo='SoTienNoToiDa'
END
GO

CREATE PROC USP_GetPercentPrice
AS
BEGIN
	SELECT GiaTri FROM THAMSO WHERE TenThamSo='TiLeTinhDonGiaBan'
END
GO

CREATE PROC USP_SetPercentPrice
@percentPrice FLOAT
AS
BEGIN
	UPDATE THAMSO SET GiaTri=@percentPrice WHERE TenThamSo='TiLeTinhDonGiaBan'
END
GO

CREATE PROC USP_GetCheck
AS
BEGIN
	SELECT GiaTri FROM THAMSO WHERE TenThamSo='ApDungQD4'
END
GO

CREATE PROC USP_SetCheck
@check INT
AS
BEGIN
	UPDATE THAMSO SET GiaTri=@check WHERE TenThamSo='ApDungQD4'
END
GO

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
	SELECT TenDangNhap as userName,TenHienThi as displayName,MatKhau as passWord,LoaiTaiKhoan as type FROM NGUOIDUNG WHERE TenDangNhap=@userName
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

CREATE PROC USP_GetNewIDBookTitle
AS
BEGIN
	SELECT MAX(MaDauSach)+1 FROM DAUSACH
END
GO

CREATE PROC USP_GetNewIDBook
AS
BEGIN
	SELECT MAX(MaSach)+1 FROM SACH
END
GO


CREATE PROC USP_GetNewIDCollectMoney
AS
BEGIN
	SELECT MAX(SoPhieuThu)+1 FROM PHIEUTHUTIEN
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

CREATE PROC USP_GetListBook
AS
BEGIN
	SELECT s.MaSach as id,s.MaDauSach as idBookTitle,d.TenDauSach as name,s.NhaXuatBan as publishCompany,s.NamXuatBan as publishYear,s.SoLuongTon as count,s.DonGiaNhap as priceIn
	FROM SACH s, DAUSACH d
	WHERE S.MaDauSach=D.MaDauSach
END
GO

CREATE PROC USP_GetCategoryBookByBookTitleID
@id INT
AS
BEGIN
	SELECT th.MaTheLoai as id,th.TenTheLoai as name FROM THELOAISACH th,DAUSACH d WHERE d.MaDauSach=@id AND d.MaTheLoai=th.MaTheLoai
END
GO

CREATE PROC USP_InsertImportBookIntoDatabase
@date DATE
AS
BEGIN
	INSERT PHIEUNHAPSACH(NgayLap,TongTien) VALUES (@date,0)
END
GO

CREATE PROC USP_InsertImportBookInfoIntoDatabase
@idBook INT,
@count INT,
@priceIn FLOAT,
@money FLOAT
AS
BEGIN
	DECLARE @importBookID INT
	SELECT @importBookID=MAX(SoPhieuNhap) FROM PHIEUNHAPSACH
	IF((SELECT count(*) FROM CT_PHIEUNHAPSACH WHERE SoPhieuNhap=@importBookID AND MaSach=@idBook)=0)
	BEGIN
		INSERT CT_PHIEUNHAPSACH(SoPhieuNhap,MaSach,	SoLuongNhap ,DonGiaNhap,ThanhTien)VALUES(
			@importBookID,
			@idBook,
			@count,
			@priceIn,
			@money
			)

	END
	ELSE
	BEGIN
		UPDATE CT_PHIEUNHAPSACH
		SET	SoLuongNhap=SoLuongNhap+ @count,
			DonGiaNhap= @priceIn,
			ThanhTien=ThanhTien+ @money
		WHERE SoPhieuNhap= @importBookID and MaSach=@idBook
	END
	UPDATE SACH SET DonGiaNhap=@priceIn, SoLuongTon=SoLuongTon+@count WHERE MaSach=@idBook

END
GO

CREATE PROC USP_GetListBookTitle
AS 
BEGIN
	SELECT MaDauSach as id,TenDauSach as name,MaTheLoai as idCategory FROM DAUSACH
END
GO

CREATE PROC USP_GetNewIDBill
AS
BEGIN
	SELECT MAX(SoHoaDon)+1 FROM HOADON
END
GO

CREATE PROC USP_InsertBillIntoDatabase
	@idCustomer INT ,
	@date DATE,
	@totalMoney FLOAT,
	@receiveMoney FLOAT,
	@moneyOwe FLOAT
AS
BEGIN
	INSERT HOADON ( MaKhachHang,NgayLap,TongTien,ThanhToan,ConLai )VALUES
	(
		@idCustomer,
		@date,
		@totalMoney,
		@receiveMoney,
		@moneyOwe
	)
	IF(@moneyOwe >0)
		UPDATE KHACHHANG SET SoTienNo=SoTienNo+@moneyOwe WHERE MaKhachHang=@idCustomer
END
GO

CREATE PROC USP_InsertBillInfoIntoDatabase
	@idBook INT ,
	@count INT ,
	@priceOut FLOAT,
	@totalPrice FLOAT
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill=MAX(SoHoaDon) FROM HOADON
	INSERT CT_HOADON (SoHoaDon,MaSach ,SoLuong ,DonGiaBan ,	ThanhTien )VALUES
	(
		@idBill,
		@idBook  ,
		@count  ,
		@priceOut ,
		@totalPrice 
	)
	UPDATE SACH SET SoLuongTon=SoLuongTon-@count WHERE MaSach=@idBook
END
GO

CREATE PROC USP_GetNewIDCustomer
AS
BEGIN
	SELECT MAX(MaKhachHang+1) FROM KHACHHANG
END
GO

CREATE PROC USP_InsertCollectMoneyIntoDatabase
@idCustomer INT,
@date DATE,
@money FLOAT
AS
BEGIN
	INSERT PHIEUTHUTIEN(MaKhachHang,NgayLap,SoTienThu)VALUES
	(
		@idCustomer,
		@date,
		@money
	)
	UPDATE KHACHHANG SET SoTienNo=SoTienNo-@money WHERE MaKhachHang=@idCustomer
END
GO

CREATE PROC USP_GetListImportBookInfoByTime
@month INT,
@year INT
AS
BEGIN
	SELECT p.SoPhieuNhap as idImportBook,cp.MaSach as idBook,cp.SoLuongNhap as count,cp.DonGiaNhap as priceIn 
	FROM PHIEUNHAPSACH p,CT_PHIEUNHAPSACH cp 
	WHERE p.SoPhieuNhap=cp.SoPhieuNhap AND MONTH(p.NgayLap)=@month AND YEAR(p.NgayLap)=@year 
END
GO

CREATE PROC USP_GetListBillInfoByTime
@month INT,
@year INT
AS
BEGIN
	SELECT h.SoHoaDon as idBill,ch.MaSach as idBook,ch.SoLuong as count,ch.DonGiaBan as priceOut
	FROM HOADON h,CT_HOADON ch
	WHERE h.SoHoaDon=ch.SoHoaDon AND MONTH(h.NgayLap)=@month AND YEAR(h.NgayLap)=@year 
END
GO

CREATE PROC USP_GetReportCountByTime
@month INT,
@year INT
AS
BEGIN
	SELECT Thang as month, Nam as year, MaSach as idBook, TonDau as firstCount, PhatSinh as addCount, TonCuoi as lastCount
	FROM BAOCAOTON
	WHERE Thang=@month AND Nam=@year
END
GO

CREATE PROC USP_LoadReportCount
@month INT,
@year INT
AS
BEGIN
	SELECT MaSach as idBook,TonDau as firstCount, PhatSinh as addCount, TonCuoi as lastCount
	FROM BAOCAOTON
	WHERE Thang=@month AND Nam=@year
END
GO

CREATE PROC USP_RemoveReportCount
@month INT,
@year INT
AS
BEGIN
	DELETE BAOCAOTON WHERE Thang=@month and Nam=@year
END
GO

CREATE PROC USP_GetReportCountByTimeAndBookID
@month INT,
@year INT,
@idBook INT
AS
BEGIN
	SELECT Thang as month, Nam as year, MaSach as idBook, TonDau as firstCount, PhatSinh as addCount, TonCuoi as lastCount
	FROM BAOCAOTON
	WHERE Thang=@month and Nam=@year and MaSach=@idBook
END
GO

CREATE PROC USP_InsertReportCount 
@month INT,
@year INT, 
@idBook INT, 
@firstCount INT, 
@addCount INT, 
@lastCount INT
AS
BEGIN
	INSERT BAOCAOTON VALUES
	(
		@month ,
	@year , 
	@idBook , 
	@firstCount , 
	@addCount , 
	@lastCount
	)
END
GO



CREATE PROC USP_GetListCollectMoneyByTime
@month INT,
@year INT
AS
BEGIN
	SELECT SoPhieuThu as iD,MaKhachHang as idCustomer,NgayLap as date, SoTienThu as money
	FROM PHIEUTHUTIEN 
	WHERE MONTH(NgayLap)=@month AND YEAR(NgayLap)=@year 
END
GO

CREATE PROC USP_GetListBillByTime
@month INT,
@year INT
AS
BEGIN
	SELECT SoHoaDon as iD,MaKhachHang as idCustomer,NgayLap as date, TongTien as value, ConLai as owe
	FROM HOADON 
	WHERE MONTH(NgayLap)=@month AND YEAR(NgayLap)=@year 
END
GO

CREATE PROC USP_GetReportOwe
@month INT,
@year INT
AS
BEGIN
	SELECT Thang as month, Nam as year, MaKhachHang as idCustomer, NoDau as firstOwe, PhatSinh as addOwe, NoCuoi as lastOwe
	FROM BAOCAOCONGNO
	WHERE Thang=@month AND Nam=@year
END
GO

CREATE PROC USP_LoadReportOwe
@month INT,
@year INT
AS
BEGIN
	SELECT MaKhachHang as idCustomer,NoDau as firstOwe, PhatSinh as addOwe, NoCuoi as lastOwe
	FROM BAOCAOCONGNO
	WHERE Thang=@month AND Nam=@year
END
GO

CREATE PROC USP_GetReportOweByTimeAndCustomerID
@month INT,
@year INT,
@idCustomer INT
AS
BEGIN
	SELECT Thang as month, Nam as year, MaKhachHang as idCustomer, NoDau as firstOwe, PhatSinh as addOwe, NoCuoi as lastOwe
	FROM BAOCAOCONGNO
	WHERE Thang=@month and Nam=@year and MaKhachHang=@idCustomer
END
GO

CREATE PROC USP_InsertReportOwe 
@month INT,
@year INT, 
@idCustomer INT, 
@firstOwe INT, 
@addOwe INT,
@lastOwe INT
AS
BEGIN
	INSERT BAOCAOCONGNO VALUES
	(
		@month ,
	@year , 
	@idCustomer , 
	@firstOwe , 
	@addOwe , 
	@lastOwe
	)
END
GO


CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) 
RETURNS NVARCHAR(4000) 
AS 
BEGIN 
	IF @strInput IS NULL 
		RETURN @strInput 
	IF @strInput = '' 
		RETURN @strInput 
	DECLARE @RT NVARCHAR(4000) 
	DECLARE @SIGN_CHARS NCHAR(136) 
	DECLARE @UNSIGN_CHARS NCHAR (136) 
	SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208)
	SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
	DECLARE @COUNTER int 
	DECLARE @COUNTER1 int 
	SET @COUNTER = 1 
	WHILE (@COUNTER <=LEN(@strInput)) 
	BEGIN 
		SET @COUNTER1 = 1 
		WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
		BEGIN 
			IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
			BEGIN 
				IF @COUNTER=1 
					SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
				ELSE 
					SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
					BREAK 
			END 
				SET @COUNTER1 = @COUNTER1 +1 
		END 
		SET @COUNTER = @COUNTER +1 
	END 
	SET @strInput = replace(@strInput,' ','-') 
	RETURN @strInput 
END
GO

CREATE PROC USP_GetListBillByCustomerID
@id INT
AS
BEGIN
	SELECT SoHoaDon as idBill, HOADON.MaKhachHang as idCustomer,TenKhachHang as nameCustomer,NgayLap as date, TongTien as value
	FROM HOADON , KHACHHANG
	WHERE HOADON.MaKhachHang=@id and HOADON.MaKhachHang=KHACHHANG.MaKhachHang
END
GO

CREATE PROC USP_LoadListBillInfo
@id INT
AS
BEGIN
	SELECT ct.MaSach as id,d.MaDauSach AS idBookTitle,d.TenDauSach as name, th.TenTheLoai as category,ct.SoLuong as count,ct.DonGiaBan as priceOut
	FROM CT_HOADON ct, SACH s, DAUSACH d,THELOAISACH th
	WHERE SoHoaDon=@id AND ct.MaSach =s.MaSach and s.MaDauSach=d.MaDauSach and d.MaTheLoai=th.MaTheLoai
END
GO

CREATE PROC USP_GetPublishingByBookID
@id INT
AS
BEGIN
	SELECT NhaXuatBan as publishCompany,NamXuatBan as publishYear
	FROM SACH
	WHERE MaSach=@id
END
GO

CREATE PROC USP_UpdateAccountByUserName 
@userName VARCHAR(100),
@displayName NVARCHAR(100),
@passWord VARCHAR(100)
AS
BEGIN
	UPDATE NGUOIDUNG SET TenHienThi=@displayName , MatKhau=@passWord WHERE TenDangNhap=@userName
END
GO

CREATE PROC USP_InsertAccount 
@userName VARCHAR(100),
@displayName NVARCHAR(100),
@passWord VARCHAR(100)
AS
BEGIN
	INSERT NGUOIDUNG VALUES( @userName,@displayName , @passWord,1)
END
GO

CREATE PROC USP_GetListAccount
AS
BEGIN
	SELECT TenDangNhap as userName,TenHienThi as displayName,MatKhau as passWord,LoaiTaiKhoan as type
	FROM NGUOIDUNG 
	WHERE LoaiTaiKhoan=1
END
GO

CREATE PROC USP_RemoveAccountByUserName 
@userName VARCHAR(100)
AS
BEGIN
	DELETE NGUOIDUNG WHERE TenDangNhap=@userName
END
GO


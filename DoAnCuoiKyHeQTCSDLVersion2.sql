CREATE DATABASE QuanLyTiemGame_version2;
GO

USE QuanLyTiemGame_version2;
GO

-- Nhập dữ liệu
CREATE TABLE TaiKhoan(
id INT IDENTITY(1,1) PRIMARY KEY, -- 1, 2,...
ma_tai_khoan VARCHAR(15) UNIQUE, --Tùy các bảng NV, KH, Admin
ten_dang_nhap VARCHAR(20) UNIQUE,
mat_khau VARCHAR(20),
ngay_tao_tai_khoan DATE, -- y-m-d
STATUS INT DEFAULT 0, -- 0
)
GO

--Nhập dữ liệu
CREATE TABLE Admin(
id INT IDENTITY(1,1) PRIMARY KEY,
ma_tai_khoan VARCHAR(15) FOREIGN KEY REFERENCES TaiKhoan(ma_tai_khoan), --AD01....
ho_ten NVARCHAR(50)
)
GO

--Nhập dữ liệu
CREATE TABLE NhanVien(
id INT IDENTITY(1,1) PRIMARY KEY,
ma_nhan_vien VARCHAR(15) UNIQUE FOREIGN KEY REFERENCES TaiKhoan(ma_tai_khoan) ON DELETE CASCADE, -- NV01...
ho_ten NVARCHAR(50),
ngay_sinh DATE,
gioi_tinh NVARCHAR(10), -- Nam, Nữ, Khác
so_dien_thoai CHAR(15),
dia_chi NVARCHAR(100),    
vai_tro NVARCHAR(20) -- Bảo vệ, Thu ngân,....
)
GO

-- Nhập dữ liệu
CREATE TABLE KhachHang(
id INT IDENTITY(1,1) PRIMARY KEY,
ma_khach_hang VARCHAR(15) UNIQUE FOREIGN KEY REFERENCES TaiKhoan(ma_tai_khoan) ON DELETE CASCADE, --KH01...
so_phut_con_lai INT, -- 75
)
GO

--Nhập dữ liệu
CREATE TABLE LichSuNapTien(
id INT IDENTITY(1,1) PRIMARY KEY,
ma_khach_hang VARCHAR(15) UNIQUE FOREIGN KEY REFERENCES KhachHang(ma_khach_hang) ON DELETE CASCADE,
ngay_nap DATETIME,
so_tien_nap INT,
)
GO

--Nhập dữ liệu
CREATE TABLE May(
id INT IDENTITY(1,1) PRIMARY KEY,
ma_may VARCHAR(15) UNIQUE, --MAY01, ...
loai_may VARCHAR(10), --(VIP, Thường)
gia_tien_mot_gio INT, --thường: 5000, VIP: 10000
trang_thai NVARCHAR(10) -- Tắt Bật
)
GO


CREATE TABLE KhachHang_May(
id INT IDENTITY(1,1) PRIMARY KEY,
ma_may VARCHAR(15) FOREIGN KEY REFERENCES May(ma_may),
ma_khach_hang VARCHAR(15) FOREIGN KEY REFERENCES KhachHang(ma_khach_hang) null,
thoi_gian_mo_may DATETIME,
)
GO

--Nhập dữ liệu
CREATE TABLE UuDai(
id INT IDENTITY(1,1) PRIMARY KEY,
ma_uu_dai VARCHAR(15) UNIQUE, --ABCD0001
giam_gia INT NULL, --10000
qua_tang VARCHAR(50) NULL -- Sting, ...
)
GO

--Nhập dữ liệu
CREATE TABLE DichVu(
id INT IDENTITY(1,1) PRIMARY KEY,
ma_dich_vu VARCHAR(15), --UNIQUE, --: khong the unique duoc , --TD01....
loai_dich_vu VARCHAR(50),
ten_mon NVARCHAR(50), -- Mì tôm
gia INT,
so_luong INT CHECK(so_luong >= 0)
)
GO




CREATE TABLE HoaDon(
ma_hoa_don INT IDENTITY(1,1) PRIMARY KEY,
id_may int null,
ten_thu_ngan NVARCHAR(50),
ngay_thu DATETIME,
tong_tien_thu INT,
)
GO

CREATE TABLE ChiTietHoaDon(
ma_hoa_don INT FOREIGN KEY REFERENCES HoaDon(ma_hoa_don) NOT NULL, -- = id trong KhachHang_May nhung khong la foreign key
id_dich_vu INT FOREIGN KEY REFERENCES DichVu(id) NULL,
so_luong INT,
ma_uu_dai VARCHAR(15) FOREIGN KEY REFERENCES UuDai(ma_uu_dai) NULL,
)
GO

-- MODIFY DATABASE
-- Add Column so_luong to HoaDon
ALTER TABLE HoaDon
ADD so_luong INT NULL

-- Add Column luong-thang to NhanVien
ALTER TABLE NhanVien
ADD luong_thang INT NULL


-- thêm cột trạng thái cho ưu đãi (cho trường hợp đang áp dụng ưu đãi nhưng phải dừng áp dụng, nhưng không thể xoá vì ảnh hưởng đến doanh thu)
-- mặc định là khi thêm vào là đang áp dụng
alter table UuDai add status_uu_dai bit default 1 with values

--thêm cột trạng thái cho dịch vụ, khi xoá chỉ cần bật status về false là được, mặc định là đã được phục vụ, nên là bit 1
alter table DichVu add status_dich_vu bit default 1 with values

--thêm cột trạng thái cho nhân viên, khi xoá chỉ cần bật status về false là được, mặc định là đang đi làm, nên là bit 1
alter table NhanVien add status_nhan_vien bit default 1 with values

--thêm cột trạng thái cho tài khoản, khi xoá chỉ cần bật status về false là được, mặc định là đang hoạt động, nên là bit 1
alter table TaiKhoan add status_tai_khoan bit default 1 with values




--thay doi ten qua-tang trong UuDai thanh idQuaTangDichVu
-- khoa ngoai tham chieu toi id trong DichVu
-- them 1 cot ngay bat dau va ket thuc uu dai

sp_rename 'UuDai.qua_tang', 'Id_qua_tang_dich_vu', 'COLUMN'
alter table UuDai 
alter column Id_qua_tang_dich_vu int 
alter table UuDai add constraint fk_UuDai_DichVu foreign key (Id_qua_tang_dich_vu) references DichVu(id)
ALTER TABLE UuDai ADD StartDay datetime
ALTER TABLE UuDai ADD EndDay datetime

-- PROCEDURE --

CREATE PROCEDURE proc_TinhTien @ma_khachhang_may INT
AS
	INSERT INTO HoaDon(ma_hoa_don)
	VALUES(@ma_khachhang_may)
GO

CREATE PROCEDURE proc_TruTien @ma_khach_hang VARCHAR(15)
AS
	DECLARE @thoi_gian_mo_may DATETIME, @thoi_gian_su_dung DATETIME
	SET @thoi_gian_mo_may = (SELECT thoi_gian_mo_may FROM KhachHang_May WHERE ma_khach_hang = @ma_khach_hang)
	SET @thoi_gian_su_dung = (SELECT DATEDIFF(minute, @thoi_gian_mo_may, GETDATE()))

	UPDATE KhachHang SET so_phut_con_lai = (so_phut_con_lai - CONVERT(INT, @thoi_gian_su_dung)) WHERE ma_khach_hang = @ma_khach_hang
GO
-- Hai proc trên phục vụ cho trigger TatMay. Không gọi trực tiếp trong C#

-- Khách hàng
-- Cách gọi trong C#: Statement: EXEC proc_ThemKhachHang @ten_dang_nhap = 'abc', @mat_khau = 'xyx'
CREATE PROCEDURE proc_ThemKhachHang @ten_dang_nhap VARCHAR(20), @mat_khau VARCHAR(20)
AS
	DECLARE @idMax INT, @ma_khach_hang VARCHAR(15)
	SET @idMax = (SELECT MAX(id) FROM KhachHang)
	SET @ma_khach_hang = 'KH' + CONVERT(VARCHAR, (@idMax + 1))

	INSERT INTO TaiKhoan(ma_tai_khoan, ten_dang_nhap, mat_khau, ngay_tao_tai_khoan)
	VALUES(@ma_khach_hang, @ten_dang_nhap, @mat_khau, FORMAT(GetDate(), 'yyyy-MM-dd'))
	INSERT INTO KhachHang(ma_khach_hang, so_phut_con_lai)
	VALUES(@ma_khach_hang, 0)
GO




execute proc_ThemDichVu '1', 'nuoc', 'ca phe den', 25000, 40
execute proc_ThemDichVu '2', 'thucAn', 'gaXotThai', 50000, 20


CREATE PROCEDURE proc_ThayDoiMatKhauKhachHang @ten_dang_nhap VARCHAR(20), @mat_khau VARCHAR(20)
AS
	UPDATE TaiKhoan SET mat_khau = @mat_khau
	WHERE ten_dang_nhap = @ten_dang_nhap
GO

CREATE PROCEDURE proc_XoaKhachHang @ten_dang_nhap VARCHAR(20)
AS
	DELETE FROM TaiKhoan 
	WHERE ten_dang_nhap = @ten_dang_nhap 
GO

CREATE PROCEDURE proc_NapTienKhachHang @ten_dang_nhap VARCHAR(20), @so_tien_nap INT
AS
	DECLARE @so_phut_nap INT, @gia_tren_gio INT, @ma_khach_hang VARCHAR(15)
	SET @gia_tren_gio = 5000
	SET @so_phut_nap = CONVERT(INT, (@so_tien_nap/@gia_tren_gio*60))
	SET @ma_khach_hang = (SELECT ma_tai_khoan FROM TaiKhoan WHERE ten_dang_nhap = @ten_dang_nhap)

	UPDATE KhachHang SET so_phut_con_lai = (so_phut_con_lai + @so_phut_nap)
	WHERE ma_khach_hang = @ma_khach_hang
GO

-- Nhân viên










-- Máy




execute proc_ThemUuDai 'B31', null , 1, '5/1/2022', '6/1/2022' 

execute proc_ThemMay 'VIP'











CREATE PROCEDURE proc_ThemDichVuVaoHoaDon @ma_dich_vu VARCHAR(15), @so_luong_mua INT, @ma_hoa_don INT, @ma_uu_dai VARCHAR(15)
AS
	INSERT INTO HoaDon VALUES(@ma_hoa_don, @ma_dich_vu, @ma_uu_dai, @so_luong_mua)
GO

CREATE PROCEDURE proc_GiamSoLuongDichVu @ma_dich_vu VARCHAR(15), @so_luong_mua INT
AS
	UPDATE DichVu
	SET so_luong = so_luong - @so_luong_mua
	WHERE ma_dich_vu = @ma_dich_vu
GO


CREATE PROCEDURE proc_OrderDichVu @ma_dich_vu VARCHAR(15), @so_luong_mua INT, @ma_may VARCHAR(15), @ma_uu_dai VARCHAR(15) = NULL
AS
	BEGIN TRANSACTION
	BEGIN TRY
		DECLARE @check INT, @ma_hoa_don INT
		SET @check = dbo.KiemTraSoLuong(@ma_dich_vu, @so_luong_mua)
		SET @ma_hoa_don = (SELECT id FROM KhachHang_May WHERE ma_may = @ma_may)
		
		IF (@check = 1)
			BEGIN
				EXEC proc_ThemDichVuVaoHoaDon 
					@ma_dich_vu = @ma_dich_vu,
					@so_luong_mua = @so_luong_mua,
					@ma_hoa_don = @ma_hoa_don,
					@ma_uu_dai = @ma_uu_dai

				EXEC proc_GiamSoLuongDichVu @ma_dich_vu = @ma_dich_vu, @so_luong_mua = @so_luong_mua

			END
		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
GO

-- Thực đơn


-- Ưu đãi



-- TRIGGER --
drop trigger trg_TatMay

CREATE TRIGGER trg_MoMay
ON May
AFTER UPDATE
AS
	IF UPDATE(trang_thai)
	BEGIN
		DECLARE @trang_thai_moi NVARCHAR(10), @trang_thai_cu NVARCHAR(10)
		SELECT @trang_thai_moi = new.trang_thai FROM INSERTED new
		SELECT @trang_thai_cu = old.trang_thai FROM DELETED old

		IF (@trang_thai_cu = N'Tắt' AND @trang_thai_moi = N'Bật')
			BEGIN
				DECLARE @ma_may VARCHAR(15), @ma_khach_hang VARCHAR(15)
				SELECT @ma_may = new.ma_may FROM INSERTED new
				SET @ma_khach_hang = NULL

				INSERT INTO KhachHang_May(ma_may, ma_khach_hang, thoi_gian_mo_may)
				VALUES(@ma_may, @ma_khach_hang, GETDATE())

				PRINT N'Mở máy thành công'
			END
	END
GO


CREATE TRIGGER trg_TatMay
ON May
AFTER UPDATE
AS
	IF UPDATE(trang_thai) 
	BEGIN
		DECLARE @trang_thai_moi NVARCHAR(10), @trang_thai_cu NVARCHAR(10)
		SELECT @trang_thai_moi = new.trang_thai FROM INSERTED new
		SELECT @trang_thai_cu = old.trang_thai FROM DELETED old

		DECLARE @ma_may VARCHAR(15)
		SELECT @ma_may = new.ma_may FROM INSERTED new
		DECLARE @id INT, @ma_khach_hang VARCHAR(15)
		SET @id = (SELECT id FROM KhachHang_May WHERE ma_may = @ma_may)
		SET @ma_khach_hang = (SELECT ma_khach_hang FROM KhachHang_May WHERE ma_may = @ma_may)

		IF (@trang_thai_cu = N'Bật' AND @trang_thai_moi = N'Tắt')
		BEGIN
			IF (@ma_khach_hang is NULL)
				BEGIN
					EXEC proc_TinhTien @ma_khachhang_may = @id

					DELETE FROM KhachHang_May WHERE ma_may = @ma_may
					--UPDATE May SET trang_thai = N'Tắt' WHERE ma_may = @ma_may

					PRINT N'Tắt máy thành công'
				END
			ELSE 
				BEGIN 
					EXEC proc_TruTien @ma_khach_hang = @ma_khach_hang
					DELETE FROM KhachHang_May WHERE ma_may = @ma_may
					--UPDATE May SET trang_thai = N'Tắt' WHERE ma_may = @ma_may

					PRINT N'Tắt máy thành công'
				END
		END
	END
GO


-- FUNCTION --
-- + Chức năng XemChiTiet Khác với View(XemDanhSach)

-- Cách gọi trong C#, Statement: SELECT * FROM XemThongTinKhachHang('Tên đăng nhập')
CREATE FUNCTION XemThongTinKhachHang(@ten_dang_nhap VARCHAR(20)) RETURNS TABLE
AS
	RETURN (SELECT KhachHang.ma_khach_hang, 
					TaiKhoan.ten_dang_nhap,
					KhachHang.so_phut_con_lai,
					TaiKhoan.ngay_tao_tai_khoan
			FROM KhachHang JOIN TaiKhoan 
				ON KhachHang.ma_khach_hang = TaiKhoan.ma_tai_khoan
			WHERE ten_dang_nhap = @ten_dang_nhap)
GO

CREATE FUNCTION XemLichSuNapTienKhachHang(@ten_dang_nhap VARCHAR(20)) RETURNS TABLE
AS
	RETURN (SELECT KhachHang.ma_khach_hang, 
					TaiKhoan.ten_dang_nhap,
					LichSuNapTien.ngay_nap,
					LichSuNapTien.so_tien_nap
			FROM KhachHang JOIN TaiKhoan ON KhachHang.ma_khach_hang = TaiKhoan.ma_tai_khoan
				JOIN LichSuNapTien ON KhachHang.ma_khach_hang = LichSuNapTien.ma_khach_hang
			WHERE ten_dang_nhap = @ten_dang_nhap)
GO



CREATE FUNCTION XemDoanhThuTheoNamVaThang(@name INT, @thang INT) RETURNS TABLE
AS
	RETURN (SELECT * 
			FROM DoanhThu
			WHERE YEAR(ngay_thu) = @name AND MONTH(ngay_thu) = @thang)
GO





CREATE FUNCTION CheckKhachHang(@ten_dang_nhap VARCHAR(20), @mat_khau VARCHAR(20)) RETURNS INT
AS
BEGIN
	RETURN (SELECT COUNT(*)
					FROM KhachHang JOIN TaiKhoan ON KhachHang.ma_khach_hang = TaiKhoan.ma_tai_khoan
					WHERE ten_dang_nhap = @ten_dang_nhap AND mat_khau = @mat_khau)
END
GO

CREATE FUNCTION SoPhutConLaiKhachHang(@ten_dang_nhap VARCHAR(20)) RETURNS INT
AS
BEGIN
	RETURN ( SELECT so_phut_con_lai 
				FROM TaiKhoan JOIN KhachHang ON KhachHang.ma_khach_hang = TaiKhoan.ma_tai_khoan
				WHERE ten_dang_nhap = @ten_dang_nhap
			)
END
GO

CREATE FUNCTION KiemTraSoLuong(@ma_dich_vu VARCHAR(15), @so_luong_mua INT) RETURNS INT
AS
BEGIN
	DECLARE @sl INT
	SET @sl = (SELECT so_luong FROM DichVu WHERE ma_dich_vu = @ma_dich_vu)
	IF (@sl > @so_luong_mua)
		RETURN 1
	RETURN 0
END
GO

-- VIEW --
-- Cách gọi trên C#, Statement: SELECT * FROM <VIEW_NAME>

CREATE VIEW XemDanhSachKhachHang AS
SELECT KhachHang.ma_khach_hang, 
		TaiKhoan.ten_dang_nhap,
		KhachHang.so_phut_con_lai,
		TaiKhoan.ngay_tao_tai_khoan
FROM KhachHang JOIN TaiKhoan 
	ON KhachHang.ma_khach_hang = TaiKhoan.ma_tai_khoan
GO





select * from dbo.XemDanhSachHoaDon
select * from dbo.XemChiTietHoaDon(1)
select * from dbo.XemChiTietHoaDon(2)









CREATE VIEW XemLichSuNapTien AS
SELECT * 
FROM LichSuNapTien
GO



CREATE VIEW XemDanhSachThucAn AS
SELECT * 
FROM DichVu
WHERE loai_dich_vu = N'Thức ăn'
GO

CREATE VIEW XemDanhSachNuocUong AS
SELECT * 
FROM DichVu
WHERE loai_dich_vu = N'Đồ uống'
GO

CREATE VIEW XemDanhSachTheGame AS
SELECT * 
FROM DichVu
WHERE loai_dich_vu = N'Thẻ game'
GO

CREATE VIEW XemDanhThu AS
SELECT * 
FROM DoanhThu
GO



--===========================================================================================================
CREATE VIEW XemDanhSachDichVu AS
SELECT * 
FROM DichVu
GO

CREATE VIEW XemDanhSachTaiKhoan AS
SELECT * 
FROM TaiKhoan
GO

CREATE VIEW XemDanhSachHoaDon AS
SELECT *
FROM HoaDon
GO

CREATE VIEW XemDanhSachNhanVien AS
SELECT NhanVien.ma_nhan_vien,
		NhanVien.ho_ten,
		NhanVien.gioi_tinh,
		NhanVien.ngay_sinh,
		NhanVien.so_dien_thoai,
		NhanVien.dia_chi,
		NhanVien.vai_tro,
		TaiKhoan.ten_dang_nhap,
		TaiKhoan.mat_khau,
		TaiKhoan.ngay_tao_tai_khoan,
		TaiKhoan.status_tai_khoan
FROM NhanVien JOIN TaiKhoan
	ON NhanVien.ma_nhan_vien = TaiKhoan.ma_tai_khoan
GO

CREATE VIEW XemDanhSachUuDai AS
SELECT *
FROM UuDai
GO

CREATE VIEW XemDanhSachMay AS
SELECT * 
FROM May
GO

CREATE PROCEDURE proc_SuaNhanVien 
	@ten_dang_nhap VARCHAR(20), 
	@mat_khau VARCHAR(20),
	@ho_ten NVARCHAR(50),
	@ngay_sinh DATE,
	@gioi_tinh NVARCHAR(10),
	@so_dien_thoai CHAR(15),
	@dia_chi NVARCHAR(100),
	@vai_tro NVARCHAR(20)
AS
	DECLARE @ma_nhan_vien VARCHAR(15)
	SET @ma_nhan_vien = (SELECT ma_tai_khoan FROM TaiKhoan WHERE ten_dang_nhap = @ten_dang_nhap)

	-- UPDATE Thông tin
	UPDATE NhanVien
	SET ho_ten = @ho_ten,
		ngay_sinh = @ngay_sinh,
		gioi_tinh = @gioi_tinh,
		so_dien_thoai = @so_dien_thoai,
		dia_chi = @dia_chi,
		vai_tro = @vai_tro
	WHERE ma_nhan_vien = @ma_nhan_vien
	UPDATE TaiKhoan
	SET ten_dang_nhap = @ten_dang_nhap,
		mat_khau = @mat_khau
	WHERE ma_tai_khoan = @ma_nhan_vien
GO

CREATE PROCEDURE proc_SuaThongTinDichVu 
	@id int,
	@ma_dich_vu NVARCHAR(15),
	@loai_dich_vu NVARCHAR(10),
	@ten_mon nvarchar (30),
	@gia INT,
	@so_luong int
AS
	UPDATE DichVu
	SET loai_dich_vu = @loai_dich_vu, ten_mon = @ten_mon, gia = @gia, ma_dich_vu = @ma_dich_vu, so_luong = @so_luong
	where id = @id
GO

CREATE PROCEDURE proc_SuaThongTinMay 
	@ma_may NVARCHAR(15),
	@loai_may NVARCHAR(10),
	@gia_tien_mot_gio INT
AS
	UPDATE May 
	SET loai_may = @loai_may, gia_tien_mot_gio = @gia_tien_mot_gio
	WHERE ma_may = @ma_may
GO

CREATE PROCEDURE proc_SuaThongTinUuDai
	@ma_uu_dai NVARCHAR(15),
	@giam_gia int,
	@id_dich_vu int,
	@Start_day datetime,
	@End_day datetime
AS
	UPDATE UuDai
	SET giam_gia = @giam_gia, Id_qua_tang_dich_vu= @id_dich_vu, StartDay= @Start_day, EndDay = @End_day
	WHERE ma_uu_dai = @ma_uu_dai
GO

CREATE PROCEDURE proc_ThemDichVu @ma_dich_vu VARCHAR(20), @ten_dich_vu varchar(20) , @ten_mon VARCHAR(20),
									@gia_moi_san_pham int, @so_luong int
AS
	DECLARE @idMax INT
	SET @idMax = (SELECT MAX(id) FROM DichVu)
	

	INSERT INTO DichVu(ma_dich_vu, loai_dich_vu, ten_mon, gia, so_luong)
	VALUES(@ma_dich_vu, @ten_dich_vu, @ten_mon, @gia_moi_san_pham, @so_luong)
GO

CREATE PROCEDURE proc_ThemMay @loai_may NVARCHAR(10)
AS
	DECLARE @idMax INT, @ma_may VARCHAR(15), @gia_tien INT
	SET @idMax = (SELECT MAX(id) FROM May)
	SET @ma_may = 'MAY' + CONVERT(VARCHAR, (@idMax + 1))
	IF (@loai_may = N'VIP')
	BEGIN
		SET @gia_tien = 8000
	END
	IF (@loai_may = N'Thường')
	BEGIN
		SET @gia_tien = 5000
	END

	INSERT INTO May(ma_may, loai_may, gia_tien_mot_gio, trang_thai)
	VALUES(@ma_may, @loai_may, @gia_tien, N'off')
GO

CREATE PROCEDURE proc_ThemNhanVien 
	@ten_dang_nhap VARCHAR(20), 
	@mat_khau VARCHAR(20),
	@ho_ten NVARCHAR(50),
	@ngay_sinh DATE,
	@gioi_tinh NVARCHAR(10),
	@so_dien_thoai CHAR(15),
	@dia_chi NVARCHAR(100),
	@vai_tro NVARCHAR(20)
AS
	DECLARE @idMax INT, @ma_nhan_vien VARCHAR(15)
	SET @idMax = (SELECT MAX(id) FROM NhanVien)
	SET @ma_nhan_vien = 'NV' + CONVERT(VARCHAR, (@idMax + 1))

	INSERT INTO TaiKhoan(ma_tai_khoan, ten_dang_nhap, mat_khau, ngay_tao_tai_khoan)
	VALUES(@ma_nhan_vien, @ten_dang_nhap, @mat_khau, FORMAT(GetDate(), 'yyyy-MM-dd'))
	INSERT INTO NhanVien(ma_nhan_vien, ho_ten, ngay_sinh, gioi_tinh, so_dien_thoai, dia_chi, vai_tro)
	VALUES(@ma_nhan_vien, @ho_ten, @ngay_sinh, @gioi_tinh, @so_dien_thoai, @dia_chi, @vai_tro)
GO

CREATE PROCEDURE proc_ThemHoaDon
	@id_may int, 
	@ten_thu_ngan NVARCHAR(50),
	@ngay_thu DATETIME,
	@tong_tien_thu int
AS
	DECLARE @idMax INT
	SET @idMax = (SELECT MAX(ma_hoa_don) FROM HoaDon)

	INSERT INTO HoaDon(id_may, ten_thu_ngan, ngay_thu, tong_tien_thu)
	VALUES(@id_may, @ten_thu_ngan, @ngay_thu, @tong_tien_thu)
GO

CREATE PROCEDURE proc_ThemUuDai @ma_uu_dai NVARCHAR(10), @giam_gia int, @id_dich_vu int, @ngay_bat_dau datetime, @ngay_ket_thuc datetime
AS
	DECLARE @idMax INT
	

	INSERT INTO UuDai(ma_uu_dai, giam_gia, Id_qua_tang_dich_vu, StartDay, EndDay )
	VALUES(@ma_uu_dai, @giam_gia, @id_dich_vu, @ngay_bat_dau, @ngay_ket_thuc)
GO

--không nên xoá dịch vụ vì nó còn được bảng khác tham chiếu tới và ảnh hưởng tới việc kiểm kê
CREATE PROCEDURE proc_XoaDichVu @id VARCHAR(20)
AS
	--DELETE FROM DichVu WHERE id = @id
	update DichVu
	set status_dich_vu = 0
	where id = @id
GO


CREATE PROCEDURE proc_XoaMay @ma_may NVARCHAR(15)
AS
	DECLARE @trang_thai NVARCHAR(10)
	SET @trang_thai = (SELECT trang_thai FROM May WHERE ma_may = @ma_may)
	
	IF (@trang_thai = N'off')
	BEGIN
		DELETE FROM May WHERE ma_may = @ma_may
	END
	ELSE
	BEGIN
		PRINT N'Vui lòng không sử dụng máy khi quyết định xóa'
	END
GO

CREATE PROCEDURE proc_XoaNhanVien @ten_dang_nhap VARCHAR(20)
AS
	--DELETE FROM TaiKhoan WHERE ten_dang_nhap = @ten_dang_nhap
	update TaiKhoan
	set status_tai_khoan = 0
	where ten_dang_nhap = @ten_dang_nhap
GO

--Nếu muốn xoá ưu đãi trong thời gian đang áp dụng thì hỏi lại có xác nhận hay không (để thực hiện kiểm kê doanh thu)
--nếu ưu đãi chưa được áp dụng thì xoá
CREATE PROCEDURE proc_XoaUuDai @ma_uu_dai NVARCHAR(15), @status_uu_dai BIT = 1
AS
	DECLARE @trang_thai_su_dung int
	--SET @trang_thai_su_dung = (SELECT UuDai.StartDay FROM UuDai WHERE UuDai.ma_uu_dai = @ma_uu_dai)
	if ((SELECT UuDai.StartDay FROM UuDai WHERE UuDai.ma_uu_dai = @ma_uu_dai) > (SELECT CAST( GETDATE() AS Date )))
	begin
		SET @trang_thai_su_dung = 1
		DELETE FROM UuDai WHERE UuDai.ma_uu_dai = @ma_uu_dai
		
	end
	else 
	begin
		print N'Việc xoá những ưu đãi có thể ảnh hưởng đến quá trình kiểm kê'
		print N'Bạn muốn tạm nhưng ưu đãi?'
		update UuDai
		set status_uu_dai = 0
		where ma_uu_dai = @ma_uu_dai
	end
GO

CREATE FUNCTION XemChiTietHoaDon(@MaHoaDon INT) RETURNS TABLE
AS
	RETURN (SELECT * 
			FROM ChiTietHoaDon
			WHERE ChiTietHoaDon.ma_hoa_don like '%' + @MaHoaDon +'%')
GO





--CREATE FUNCTION XemThongTinMay(@ma_may varchar(10)) RETURNS TABLE
--AS
--	RETURN (SELECT * 
--			FROM May
--			WHERE May.ma_may= @ma_may)
--GO

--CREATE FUNCTION XemThongTinMay(@ma_may varchar(10)) RETURNS TABLE
--AS		
--	RETURN (SELECT * 
--			FROM May
--			WHERE May.ma_may like '%' + @ma_may +'%' )
--GO

CREATE FUNCTION XemThongTinMay(@ma_may varchar(10) , @loai_may nvarchar(20) , @gia_moi_gio int , @trang_thai nvarchar(10) ) 
RETURNS @bang_tam table (id INT ,
							ma_may VARCHAR(15), --MAY01, ...
							loai_may VARCHAR(10), --(VIP, Thường)
							gia_tien_mot_gio INT, --thường: 5000, VIP: 10000
							trang_thai NVARCHAR(10)) -- Tắt Bật)
AS
begin
	insert into @bang_tam
						SELECT * 
						FROM May
	
	if (@ma_may != '')
		delete 
		from @bang_tam 
		where ma_may not like '%' + @ma_may +'%'
	
	if (@loai_may != '')
		delete 
		from @bang_tam 
		where loai_may not like '%' + @loai_may +'%'
	
	if (@gia_moi_gio != 0)
		delete 
		from @bang_tam
		where gia_tien_mot_gio != @gia_moi_gio

	if (@trang_thai != '')
		delete 
		from @bang_tam 
		where trang_thai not like '%' + @trang_thai +'%'
	return
end
GO

CREATE FUNCTION XemThongTinDichVu(@ma_dich_vu varchar(15), @loai_dich_vu varchar(50), @ten_mon nvarchar(50), @gia int, @status_dich_vu int)
RETURNS @bang_tam TABLE (id int,
						ma_dich_vu varchar(10),
						loai_dich_vu varchar(50),
						ten_mon nvarchar(50),
						gia int,
						so_luong int,
						status_dich_vu bit)
AS
begin
	insert into @bang_tam
						SELECT * 
						FROM DichVu
	
	if (@ma_dich_vu != '')
		delete 
		from @bang_tam 
		where ma_dich_vu not like '%' + @ma_dich_vu +'%'
	
	if (@loai_dich_vu != '')
		delete 
		from @bang_tam 
		where loai_dich_vu not like '%' + @loai_dich_vu +'%'
	
	if (@ten_mon != '')
		delete 
		from @bang_tam
		where ten_mon not like '%' +  @ten_mon + '%'

	if (@gia != 0)
		delete 
		from @bang_tam 
		where gia != @gia

	if (@status_dich_vu != 2)
		delete 
		from @bang_tam 
		where status_dich_vu != @status_dich_vu
	return
end
GO

CREATE FUNCTION XemThongTinUuDai(@MaUuDai nvarchar(10), @giam_gia int, @id_qua int, @start_day datetime, @end_day datetime, @Ngay_cu_the datetime, @status_uu_dai int)
RETURNS @bang_tam TABLE (id int,
						ma_uu_dai varchar(15),
						giam_gia int,
						Id_qua_tang_dich_vu int,
						Startday datetime,
						Endday datetime,
						status_uu_dai bit) 
AS
	begin
	insert into @bang_tam
						SELECT * 
						FROM UuDai
	
	if (@MaUuDai != '')
		delete 
		from @bang_tam 
		where ma_uu_dai not like '%' + @MaUuDai +'%'
	
	if (@giam_gia != 0)
		delete 
		from @bang_tam 
		where giam_gia != @giam_gia
	
	if (@id_qua != 0)
		delete 
		from @bang_tam
		where Id_qua_tang_dich_vu !=  @id_qua 

	if (@end_day != '' )
		delete 
		from @bang_tam 
		where Endday not like '%' +  @end_day + '%'

	if (@start_day != '')
		delete 
		from @bang_tam 
		where Startday not like '%' +  @start_day + '%'

	if (@Ngay_cu_the != '')
		delete
		from @bang_tam
		where (Startday >= @Ngay_cu_the or Endday <= @Ngay_cu_the)

	if (@status_uu_dai != 2 )
		delete 
		from @bang_tam 
		where status_uu_dai != @status_uu_dai
	return
end
GO


CREATE FUNCTION XemThongTinNhanVien(@ma_nhan_vien nvarchar(10), @ho_ten nvarchar (20), @gioitinh nvarchar(10), @ngay_sinh datetime,
									@dia_chi nvarchar (20), @vai_tro nvarchar (20), @status int, @ten_dang_nhap nvarchar (20), 
									@ngay_tao datetime) 
RETURNS @bang_tam TABLE ( 
							ma_nhan_vien VARCHAR(15), -- NV01...
							ho_ten NVARCHAR(50),
							gioi_tinh NVARCHAR(10),
							ngay_sinh date,
							so_dien_thoai char(15),
							dia_chi NVARCHAR(100),    
							vai_tro NVARCHAR(20), -- Bảo vệ, Thu ngân,....
							ten_dang_nhap varchar(20),
							mat_khau varchar(20),
							ngay_tao_tai_khoan date,
							status_tai_khoan bit)
AS
	begin
	insert into @bang_tam 
		SELECT NhanVien.ma_nhan_vien,
			NhanVien.ho_ten,
			NhanVien.gioi_tinh,
			NhanVien.ngay_sinh,
			NhanVien.so_dien_thoai,
			NhanVien.dia_chi,
			NhanVien.vai_tro,
			TaiKhoan.ten_dang_nhap,
			TaiKhoan.mat_khau,
			TaiKhoan.ngay_tao_tai_khoan,
			TaiKhoan.status_tai_khoan
		FROM NhanVien JOIN TaiKhoan on NhanVien.ma_nhan_vien = TaiKhoan.ma_tai_khoan
	
	if (@ma_nhan_vien != '')
		delete 
		from @bang_tam 
		where ma_nhan_vien not like '%' + @ma_nhan_vien+'%'
	
	if (@ho_ten != '')
		delete 
		from @bang_tam 
		where ho_ten not like '%' + @ho_ten +'%'
	
	if (@gioitinh != '')
		delete 
		from @bang_tam
		where gioi_tinh not like '%' + @gioitinh + '%'

	if (@ngay_sinh != '')
		delete 
		from @bang_tam 
		where ngay_sinh not like '%' + @ngay_sinh +'%'

	if (@dia_chi != '')
		delete 
		from @bang_tam 
		where dia_chi not like '%' + @dia_chi +'%'

	if (@vai_tro != '')
		delete 
		from @bang_tam 
		where vai_tro not like '%' + @vai_tro+'%'
	
	if (@ten_dang_nhap != '')
		delete 
		from @bang_tam 
		where ten_dang_nhap not like '%' + @ten_dang_nhap +'%'

	if (@ngay_tao != '')
		delete 
		from @bang_tam 
		where ngay_tao_tai_khoan not like '%' + @ngay_tao +'%'

	if (@status != 2)
		delete 
		from @bang_tam 
		where status_tai_khoan != @status
	return
end
GO


-----------phần test 
USE QuanLyTiemGame_version2;

--them theo thu tu ben kia, them tai khoan roi moi them nhan vien

select * from XemDanhSachHoaDon
select * from XemDanhSachDichVu
select * from XemDanhSachNhanVien 
select * from XemDanhSachUuDai
select * from XemDanhSachMay
select * from XemDanhSachTaiKhoan 

execute proc_SuaNhanVien 'vovanduc', '1', 'Võ Đức', '11/2/2002', 'Nam', '0869990187', 'HCM', 'Thu Ngan'
execute proc_SuaThongTinDichVu 1, '1', 'nước', 'rồng đỏ', 15000, 30 
execute proc_SuaThongtinMay 'may02', 'dell insprision', 7000
execute proc_SuaThongTinUuDai 'uudai13', 15, null, '2022/12/22 7:00:00', '2022/12/22 23:59:00'
-- truyen paramater voi du lieu la datetime thi theo yyyy/mm/dd hh/mm/ss
-- truyen argument voi du lieu la datetime thi theo mm/dd/yyyy hh/mm/ss


execute proc_ThemDichVu '2', 'món ăn', 'rau muốn xào tỏi', 25000, 30
execute proc_ThemMay 'dell insprision 15 500'
execute proc_ThemNhanVien 'vovanduc1', '0', N'Võ Văn Đức', '11/2/2001', N'Nam', '09812345', N'Quãng Ngãi', N'Thu Ngân'
execute proc_ThemUuDai 'uudai14', null, 4, '2021/11/15 00:00:00', '2021/11/15 23:59:00'

execute proc_ThemHoaDon 4, 'quang huy', '2022/11/14 7:00:00', 50000
execute proc_ThemHoaDon @id_may=5, @ten_thu_ngan='quang huy', @ngay_thu='2022/11/14 7:00:00', @tong_tien_thu=50000
--viet kieu nay thi phai chinh xac

execute proc_XoaDichVu '4' 
--chua tat may
update May 
	set trang_thai = 'off'
	where ma_may = 'may02'
execute proc_XoaMay 'MAY8'
execute proc_XoaNhanVien 'vovanduc'
execute proc_XoaUuDai 'uudai13'
execute proc_XoaUuDai 'uudai14'

select * from XemChiTietHoaDon(1)

select * from XemDanhSachDichVu
select * from XemThongTinDichVu('bò')

select * from XemDanhSachNhanVien
select * from XemThongTinNhanVien('an')

select * from XemDanhSachUuDai
select * from XemThongTinUuDai('1')

select * from XemDanhSachMay
select * from XemThongTinMay('1', 'asus', 0, '');

select * from XemDanhSachMay
SELECT * 
						FROM May
						WHERE May.trang_thai  like '%'+  'on' + '%' 

select * from XemDanhSachNhanVien
select * from XemThongTinNhanVien('', 'đức', '','','','',2,'','')

select * from XemDanhSachMay
select * from XemThongTinMay('1', '', 8000, '');
SELECT * FROM XemThongTinMay('1', '', 8000, 'off')

select * from XemDanhSachMay where gia_tien_mot_gio = 7000

select * from XemDanhSachDichVu
SELECT * FROM XemThongTinDichVu( '1','','',0,2)

select * from XemDanhSachNhanVien

select * from XemThongTinNhanVien('','khắc','', '', '','',2,'','')
select * from XemThongTinNhanVien('nv2','Nguyễn Khắc Quang Huy','Nam', '', 'Bình Dương','Thu Ngân',2,'quanghuy','')

select * from XemDanhSachUuDai
select * from XemThongTinUuDai('',0,0,'','','2022/01/13',2)
select * from XemThongTinUuDai('uudai1',0,0,'','','',2);

declare @startday datetime
set @startday = '2023/1/12'
 
declare @endday datetime
set @endday = '2023/1/14'

declare @middleday datetime
set @middleday = '2023/1/13'

if (@middleday > @startday and @middleday < @endday)
	print('hehe')
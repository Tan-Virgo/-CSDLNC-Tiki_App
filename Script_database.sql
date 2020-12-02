--===================================================
--==          ĐỒ ÁN QUẢN LÝ BÁN HÀNG ONLINE        ==
--==            MÔN CƠ SỞ DỮ LIỆU NÂNG CAO         ==
--===================================================

-- NHÓM 12:
-- 18120534 - Hoàng Công Sơn
-- 18120553 - Nguyễn Lê Ngọc Tần
-- 18120614 - Nguyễn Văn Trị



--====================================================================================
-- Tạo DATABASE
CREATE DATABASE QLBanHangOnline
GO

USE QLBanHangOnline
GO

-- Khách hàng
CREATE TABLE KhachHang
(
	MaKhachHang CHAR(10) PRIMARY KEY,
	Ten_KH NVARCHAR(50),
	NgaySinh_KH DATETIME,
	GioiTinh_KH NVARCHAR(3),
	SDT_KH CHAR(10),
	Email_KH VARCHAR(50),
	SoXu INT
)
GO

-- Giỏ hàng
CREATE TABLE GioHang
(
	MaGioHang CHAR(10) PRIMARY KEY,
	TienTamTinh MONEY,
	KhachHang CHAR(10)
)
GO

-- Địa chỉ nhận hàng
CREATE TABLE DiaChiNhanHang
(
	MaDCNH CHAR(10) PRIMARY KEY,
	HoTen NVARCHAR(50),
	SDT CHAR(10),
	TP NVARCHAR(20),
	Quan NVARCHAR(20),
	SoNha NVARCHAR(20),
	MacDinh BIT DEFAULT 0, -- 0: ko mặc định, 1: mặc định
	KhachHang CHAR(10)
)
GO

-- Khuyến mãi
CREATE TABLE KhuyenMai
(
	MaKhuyenMai CHAR(10) PRIMARY KEY,
	Ngay_KM DATETIME,
	ThoiHan DATETIME,
	MucGiam INT
)
GO

-- Khuyến mãi cho khách hàng
CREATE TABLE KH_KhuyenMai
(
	MaKhachHang CHAR(10),
	MaKhuyenMai CHAR(10),
	NgayNhanKM DATETIME

	PRIMARY KEY (MaKhachHang, MaKhuyenMai)
)
GO

-- Đánh giá của khách hàng
CREATE TABLE DanhGiaKH
(
	ThoiGian DATETIME PRIMARY KEY,
	Sao SMALLINT DEFAULT 1,
	Comment NVARCHAR(100),
	DonHang CHAR(10)
)
GO

-- Đơn hàng
CREATE TABLE DonHang
(
	MaDonHang CHAR(10) PRIMARY KEY,
	NgayDat DATETIME,
	SuDungXu BIT DEFAULT 0,
	PhiVanChuyen MONEY,
	ThanhTien MONEY,
	TinhTrang NVARCHAR(10), --???
	DiaChiNhan CHAR(10),
	NhanVienGiao CHAR(10),
	HTThanhToan CHAR(10),
	HTVanChuyen CHAR(10),
	GioHang CHAR(10)
)
GO

-- Đổi sản phẩm
CREATE TABLE DoiSP
(
	MaDoiSP CHAR(10) PRIMARY KEY,
	NgayGhiNhanDoi DATETIME,
	LyDoDoi NVARCHAR(50),
	NgayXacNhanDoi DATETIME,
	TinhTrangDoi NVARCHAR(10), ---????
	DonHang CHAR(10)
)
GO

-- Trả sản phẩm
CREATE TABLE TraSP
(
	MaTraSP CHAR(10) PRIMARY KEY,
	NgayGhiNhanTra DATETIME,
	LyDoTra NVARCHAR(50),
	NgayXacNhanTra DATETIME,
	SoTienTra MONEY,
	TinhTrangTra NVARCHAR(10), --??
	DonHang CHAR(10)
)
GO

-- Hình thức thanh toán
CREATE TABLE HinhThucThanhToan
(
	MaHTThanhToan CHAR(10) PRIMARY KEY,
	TenHTThanhToan NVARCHAR(50)
)
GO

-- Hình thức vận chuyển
CREATE TABLE HinhThucVanChuyen
(
	MaHTVanChuyen CHAR(10) PRIMARY KEY,
	TenHTVanChuyen CHAR(50),
	SoTien_1KM MONEY
)
GO

-- Nhân viên giao hàng
CREATE TABLE NhanVienGiaoHang
(
	MaNhanVien CHAR(10) PRIMARY KEY,
	Ten_NV NVARCHAR(50),
	SDT_NV CHAR(10),
	TP NVARCHAR(20),
	Quan NVARCHAR(20)
)
GO

-- Lịch sử giao hàng
CREATE TABLE LichSuGiaoHang
(
	MaDonHang CHAR(10),
	ThoiGian DATETIME,
	TrangThai NVARCHAR(20), --???
	GhiChu NVARCHAR(50)

	PRIMARY KEY (MaDonHang, ThoiGian)
)
GO

-- Sản phẩm
CREATE TABLE SanPham
(
	MaSanPham CHAR(10) PRIMARY KEY,
	Ten_SP NVARCHAR(50),
	GiaBan MONEY,
	Sao SMALLINT DEFAULT 5,
	MoTa NVARCHAR(100),
	LoaiSP CHAR(10)
)
GO

-- Loại sản phẩm
CREATE TABLE LoaiSP
(
	MaLoai CHAR(10) PRIMARY KEY,
	TenLoai NVARCHAR(50)
)
GO

-- Chi tiết giỏ hàng
CREATE TABLE ChiTietGioHang
(
	MaGioHang CHAR(10),
	MaSanPham CHAR(10),
	SoLuong INT

	PRIMARY KEY (MaGioHang, MaSanPham)
)
GO

-- Nhà bán
CREATE TABLE NhaBan
(
	MaNhaBan CHAR(10) PRIMARY KEY,
	Ten_NB NVARCHAR(50),
	DiaChi_NB NVARCHAR(50),
	SDT_NB CHAR(10),
	Email_NB VARCHAR(50),
	NgayHopTac DATETIME,
	LoaiNhaBan NVARCHAR(30)
)
GO

-- Sản phẩm nhà bán cung cấp
CREATE TABLE NhaBan_SanPham
(
	MaNhaBan CHAR(10),
	MaSanPham CHAR(10),
	DonGia MONEY

	PRIMARY KEY (MaNhaBan, MaSanPham)
)
GO

-- Nhà bán lưu kho nhập kho cho TIKI
CREATE TABLE PhieuNhapKho
(
	MaNhap CHAR(10) PRIMARY KEY,
	NgayNhap DATETIME,
	NhaBan CHAR(10),
	KhoHang CHAR(10)
)
GO

-- Chi tiết sản phẩm nhập kho

CREATE TABLE ChiTiet_NhapKho
(
	MaNhap CHAR(10),
	MaSanPham CHAR(10),
	SoLuong INT,
	DonGiaNhap MONEY

	PRIMARY KEY (MaNhap, MaSanPham)
)
GO

-- Kho hàng
CREATE TABLE KhoHang
(
	MaKho CHAR(10) PRIMARY KEY,
	DiaChi_Kho NVARCHAR(50),
	SDT_Kho CHAR(10)
)
GO

-- Xuất kho
CREATE TABLE PhieuXuatKho
(
	MaXuat CHAR(10) PRIMARY KEY,
	NgayXuat DATETIME,
	KhoHang CHAR(10),
	DonHang CHAR(10)
)
GO

-- Chi tiết sản phẩm xuất kho
CREATE TABLE ChiTiet_XuatKho
(
	MaXuat CHAR(10),
	MaSanPham CHAR(10),
	SoLuong INT,
	DonGiaXuat MONEY

	PRIMARY KEY (MaXuat, MaSanPham)
)
GO

-- Phiếu gửi hàng của nhà bán qua kho
CREATE TABLE PhieuGuiHang
(
	MaPhieu CHAR(10) PRIMARY KEY,
	NgayGiao DATETIME,
	NgayNhan DATETIME,
	NhaBan CHAR(10),
	DonHang CHAR(10)
)
GO

-- Chi tiết sản phẩm trong phiếu giao hàng
CREATE TABLE ChiTiet_PhieuGui
(
	MaPhieu CHAR(10),
	MaSanPham CHAR(10),
	SoLuong INT,
	DonGia MONEY
)
GO

-- Tài khoản
CREATE TABLE TaiKhoan
(
	ID CHAR(50) PRIMARY KEY,
	Username CHAR(30),
	Password CHAR(10),
	VaiTro NVARCHAR(30)
)
GO





--======================================================================================
-- Thiết đặt khóa ngoại

ALTER TABLE GioHang ADD
	CONSTRAINT FK_GioHang_KhachHang FOREIGN KEY (KhachHang) REFERENCES KhachHang(MaKhachHang)

ALTER TABLE DiaChiNhanHang ADD
	CONSTRAINT FK_DiaChiNhanHang_KhachHang FOREIGN KEY (KhachHang) REFERENCES KhachHang(MaKhachHang)

ALTER TABLE KH_KhuyenMai ADD
	CONSTRAINT FK_KH_KhuyenMai_KhachHang FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)

ALTER TABLE KH_KhuyenMai ADD
	CONSTRAINT FK_KH_KhuyenMai_KhuyenMai FOREIGN KEY (MaKhuyenMai) REFERENCES KhuyenMai(MaKhuyenMai)

ALTER TABLE DanhGiaKH ADD
	CONSTRAINT FK_DanhGiaKH_DonHang FOREIGN KEY (DonHang) REFERENCES DonHang(MaDonHang)

ALTER TABLE DonHang ADD
	CONSTRAINT FK_DonHang_DiaChiNhanHang FOREIGN KEY (DiaChiNhan) REFERENCES DiaChiNhanHang(MaDCNH)

ALTER TABLE DonHang ADD
	CONSTRAINT FK_DonHang_NhanVienGiaoHang FOREIGN KEY (NhanVienGiao) REFERENCES NhanVienGiaoHang(MaNhanVien)

ALTER TABLE DonHang ADD
	CONSTRAINT FK_DonHang_HinhThucThanhToan FOREIGN KEY (HTThanhToan) REFERENCES HinhThucThanhToan(MaHTThanhToan)

ALTER TABLE DonHang ADD
	CONSTRAINT FK_DonHang_HinhThucVanChuyen FOREIGN KEY (HTVanChuyen) REFERENCES HinhThucVanChuyen(MaHTVanChuyen)

ALTER TABLE DonHang ADD
	CONSTRAINT FK_DonHang_GioHang FOREIGN KEY (GioHang) REFERENCES GioHang(MaGioHang)

ALTER TABLE DoiSP ADD
	CONSTRAINT FK_DoiSP_DonHang FOREIGN KEY (DonHang) REFERENCES DonHang(MaDonHang)
	
ALTER TABLE TraSP ADD
	CONSTRAINT FK_TraSP_DonHang FOREIGN KEY (DonHang) REFERENCES DonHang(MaDonHang)

ALTER TABLE LichSuGiaoHang ADD
	CONSTRAINT FK_LichSuGiaoHang_DonHang FOREIGN KEY (MaDonHang) REFERENCES DonHang(MaDonHang)

ALTER TABLE SanPham ADD
	CONSTRAINT FK_SanPham_LoaiSP FOREIGN KEY (LoaiSP) REFERENCES LoaiSP(MaLoai)

ALTER TABLE ChiTietGioHang ADD
	CONSTRAINT FK_ChiTietGioHang_DonHang FOREIGN KEY (MaGioHang) REFERENCES GioHang(MaGioHang)

ALTER TABLE ChiTietGioHang ADD
	CONSTRAINT FK_ChiTietGioHang_SanPham FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)

ALTER TABLE NhaBan_SanPham ADD
	CONSTRAINT FK_NhaBan_SanPham_NhaBan FOREIGN KEY (MaNhaBan) REFERENCES NhaBan(MaNhaBan)

ALTER TABLE PhieuNhapKho ADD
	CONSTRAINT FK_PhieuNhapKho_NhaBan FOREIGN KEY (NhaBan) REFERENCES NhaBan(MaNhaBan)

ALTER TABLE PhieuNhapKho ADD
	CONSTRAINT FK_PhieuNhapKho_KhoHang FOREIGN KEY (KhoHang) REFERENCES KhoHang(MaKho)

ALTER TABLE ChiTiet_NhapKho ADD
	CONSTRAINT FK_ChiTiet_NhapKho_PhieuNhapKho FOREIGN KEY (MaNhap) REFERENCES PhieuNhapKho(MaNhap)

ALTER TABLE ChiTiet_NhapKho ADD
	CONSTRAINT FK_ChiTiet_NhapKho_SanPham FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)

ALTER TABLE PhieuXuatKho ADD
	CONSTRAINT FK_PhieuXuatKho_DonHang FOREIGN KEY (DonHang) REFERENCES DonHang(MaDonHang)

ALTER TABLE PhieuXuatKho ADD
	CONSTRAINT FK_PhieuXuatKho_KhoHang FOREIGN KEY (KhoHang) REFERENCES KhoHang(MaKho)

ALTER TABLE ChiTiet_XuatKho ADD
	CONSTRAINT FK_ChiTiet_XuatKho_PhieuXuatKho FOREIGN KEY (MaXuat) REFERENCES PhieuXuatKho(MaXuat)

ALTER TABLE ChiTiet_XuatKho ADD
	CONSTRAINT FK_ChiTiet_XuatKho_SanPham FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)

ALTER TABLE PhieuGuiHang ADD
	CONSTRAINT FK_PhieuGuiHang_NhaBan FOREIGN KEY (NhaBan) REFERENCES NhaBan(MaNhaBan)

ALTER TABLE PhieuGuiHang ADD
	CONSTRAINT FK_PhieuGuiHang_DonHang FOREIGN KEY (DonHang) REFERENCES DonHang(MaDonHang)

ALTER TABLE ChiTiet_PhieuGui ADD
	CONSTRAINT FK_ChiTiet_PhieuGui_PhieuGuiHang FOREIGN KEY (MaPhieu) REFERENCES PhieuGuiHang(MaPhieu)

ALTER TABLE ChiTiet_PhieuGui ADD
	CONSTRAINT FK_ChiTiet_PhieuGui_SanPham FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)




-- =========================================================================================
-- CÁC RBTV

-- Giới tính là Nam hoặc Nữ
ALTER TABLE KhachHang ADD
	CONSTRAINT Check_Gender Check (GioiTinh_KH like N'Nam' OR GioiTinh_KH like N'Nữ')

-- Số xu của khách hàng phải là số nguyên dương
ALTER TABLE KhachHang ADD
	CONSTRAINT Check_SoXu Check (SoXu >= 0)

-- Mức giảm giá từ 0 - 100
ALTER TABLE KhuyenMai ADD
	CONSTRAINT Check_MucGiam Check (MucGiam >= 0 AND MucGiam <= 100)

-- Sao từ 1 - 5
ALTER TABLE DanhGiaKH ADD
	CONSTRAINT Check_Sao_DanhGiaKH Check (Sao >= 1 AND Sao <= 5)

ALTER TABLE SanPham ADD
	CONSTRAINT Check_Sao_SanPham Check (Sao >= 1 AND Sao <= 5)

-- Khi đổi trả sản phẩm, ngày xác nhận phải >= ngày ghi nhận
ALTER TABLE DoiSP ADD
	CONSTRAINT Check_NgayDoi Check (NgayXacNhanDoi >= NgayGhiNhanDoi)

ALTER TABLE TraSP ADD
	CONSTRAINT Check_NgayTra Check (NgayXacNhanTra >= NgayGhiNhanTra)

-- Vai trò chỉ có thể là ADMIN, Nhà bán, khách hàng
ALTER TABLE TaiKhoan ADD
	CONSTRAINT Check_VaiTro Check (VaiTro like N'ADMIN' OR VaiTro LIKE N'Nhà bán' OR VaiTro like N'Khách hàng')








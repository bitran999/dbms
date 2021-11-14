/*create database QuanLyCuaHangTienLoi*/
use QuanLyCuaHangTienLoi
go
CREATE TABLE CHUCVU
( MaChucVu nchar(10) PRIMARY KEY not null,
TenChucVu nvarchar(50) ,
Luong float,
CONSTRAINT CheckLuong CHECK(Luong > 5000000)
);


CREATE TABLE NHANVIEN
( MaNV nchar(10) PRIMARY KEY not null,
TenNV nvarchar(50),
GioiTinh nchar(10),
NgaySinh date,
DiaChi nvarchar(50),
Users nchar(10) UNIQUE,
Pass nchar(10),
SDT nchar(10)UNIQUE,
MaChucVu nchar(10),
CONSTRAINT fk_NV_CV
FOREIGN KEY (MaChucVu)
REFERENCES CHUCVU (MaChucVu)
ON DELETE SET NULL
);

create table NHACUNGCAP
( MaNCC nchar(10) PRIMARY KEY not null,
TenNCC nvarchar(50),
DiaChi nvarchar(50),
SDT nchar(10) UNIQUE,
STK nchar(15) UNIQUE
);

create table KHACHHANG
(MaKH varchar(5) PRIMARY KEY CONSTRAINT IDKH DEFAULT dbo.AUTO_IDKH(),
TenKH nvarchar(50),
GioiTinh nchar(10),
NgaySinh date,
DiaChi nvarchar(50),
SDT nchar(10) UNIQUE,
Email nchar(30) UNIQUE
);


create table KHOHANG
(MaMH nchar(10) PRIMARY KEY not null,
TrangThai nchar(10),
SoLuong int default 0,
CONSTRAINT CheckSoLuong CHECK(SoLuong >=0)
);

create table HOADONNHANHANG
(MaHDN varchar(6) CONSTRAINT IDHDN DEFAULT dbo.AUTO_IDHDN() UNIQUE,
MaNCC nchar(10),
MaMH nchar(10),
SoLuong int,
NgayGiao date,
GiaTri float default 0,
CONSTRAINT CheckSL CHECK(SoLuong >=0),
PRIMARY KEY(MaHDN,MaNCC,MaMH),
CONSTRAINT fk_HoaDonNhan_NCC FOREIGN KEY(MaNCC)
REFERENCES NHACUNGCAP(MaNCC) ON DELETE CASCADE, 
CONSTRAINT fk_HoaDonNhan_Kho FOREIGN KEY(MaMH) 
REFERENCES KHOHANG(MaMH)	ON DELETE CASCADE
);


create table MATHANG
(MaMH nchar(10) PRIMARY KEY not null,
TenMH nvarchar(50),
Gia float,
GiaGoc float,
NgaySX date,
HanSD nchar(10),
CONSTRAINT CheckGia CHECK(Gia >0),
CONSTRAINT CheckGiaGoc check(GiaGoc>=0),
CONSTRAINT fk_MatHang_Kho
FOREIGN KEY(MaMH) REFERENCES KHOHANG(MaMH) ON DELETE CASCADE, 
CONSTRAINT CheckDate CHECK(NgaySX<HanSD ));

create table HOADON
(MaHD varchar(5)PRIMARY KEY CONSTRAINT IDHD DEFAULT dbo.AUTO_IDHD(),
NgayLHD date,
MaKH varchar(5),
MaNV nchar(10),
GiaTri float default 0,
CONSTRAINT fk_HoaDon_KhachHang
FOREIGN KEY (MaKH)
REFERENCES KHACHHANG (MaKH) ON DELETE SET NULL, 
CONSTRAINT fk_HoaDon_NhanVien FOREIGN KEY (MaNV)
REFERENCES NHANVIEN (MaNV) ON DELETE SET NULL, );

create table CHITIETHOADON
(MaHD varchar(5),
MaMH nchar(10),
SoLuong int,
GiaTriMH float default 0,
CONSTRAINT CheckSLMua CHECK(SoLuong>0),
PRIMARY KEY(MaHD,MaMH),
CONSTRAINT fk_CTHD_HoaDon
FOREIGN KEY(MaHD) REFERENCES HOADON(MaHD)ON DELETE CASCADE,
CONSTRAINT fk_CTHD_MatHang
FOREIGN KEY(MaMH) REFERENCES MATHANG(MaMH)ON DELETE CASCADE
);


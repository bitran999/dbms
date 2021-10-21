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
STK nchar(15)
);

create table KHACHHANG
(MaKH nchar(10) PRIMARY KEY not null,
TenKH nvarchar(50),
GioiTinh nchar(10),
NgaySinh date,
DiaChi nvarchar(50),
SDT nchar(10) UNIQUE,
Email nchar(30) UNIQUE
);

create table PHANLOAIMATHANG
(MaLoaiMH nchar(10) PRIMARY KEY not null,
TenLoaiMH nvarchar(50)
);

create table KHOHANG
(MaMH nchar(10) PRIMARY KEY not null,
TrangThai nchar(10),
SoLuong int,
CONSTRAINT CheckSoLuong CHECK(SoLuong >=0)
);

create table HANGNHACUNGCAP
(MaNCC nchar(10),
MaMH nchar(10),
SoLuong int,
CONSTRAINT CheckSL CHECK(SoLuong >=0),
PRIMARY KEY(MaNCC,MaMH),
CONSTRAINT fk_HangNCC_NCC
FOREIGN KEY(MaNCC) REFERENCES NHACUNGCAP(MaNCC) ON DELETE CASCADE, 
CONSTRAINT fk_HangNCC_Kho
FOREIGN KEY(MaMH) REFERENCES KHOHANG(MaMH)	ON DELETE CASCADE
);


create table MATHANG
(MaMH nchar(10) PRIMARY KEY not null,
TenMH nvarchar(50),
Gia float,
NgaySX date,
HanSD nchar(10),
MaLoaiMH nchar(10),
CONSTRAINT CheckGia CHECK(Gia >0),
CONSTRAINT fk_MatHang_Kho
FOREIGN KEY(MaMH) REFERENCES KHOHANG(MaMH) ON DELETE CASCADE, 
CONSTRAINT fk_MatHang_PhanLoaiMH FOREIGN KEY (MaLoaiMH)
REFERENCES PHANLOAIMATHANG (MaLoaiMH) ON DELETE SET NULL ,
CONSTRAINT CheckDate CHECK(NgaySX<HanSD ));

create table HOADON
(MaHD nchar(10)	PRIMARY KEY not null,
NgayLHD date,
MaKH nchar(10),
MaNV nchar(10),
CONSTRAINT fk_HoaDon_KhachHang
FOREIGN KEY (MaKH)
REFERENCES KHACHHANG (MaKH) ON DELETE SET NULL, 
CONSTRAINT fk_HoaDon_NhanVien FOREIGN KEY (MaNV)
REFERENCES NHANVIEN (MaNV) ON DELETE SET NULL, );

create table CHITIETHOADON
(MaHD nchar(10),
MaMH nchar(10),
SoLuong int,
CONSTRAINT CheckSLMua CHECK(SoLuong>0),
PRIMARY KEY(MaHD,MaMH),
CONSTRAINT fk_CTHD_HoaDon
FOREIGN KEY(MaHD) REFERENCES HOADON(MaHD)ON DELETE CASCADE,
CONSTRAINT fk_CTHD_MatHang
FOREIGN KEY(MaMH) REFERENCES MATHANG(MaMH)ON DELETE CASCADE
);


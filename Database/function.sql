use QuanLyCuaHangTienLoi
go 

--proceduce--


--Các thủ tục thêm database--

--Thêm khách hàng--
create proc Add_KhachHang
	@MaKH nchar(10),
	@TenKH nvarchar(50),
	@GioiTinh nchar(10),
	@NgaySinh date,
	@DiaChi nvarchar(50),
	@SDT nchar(10),
	@Email nchar(30)
as
	insert into KHACHHANG
	values(@MaKH,@TenKH,@GioiTinh,@NgaySinh,@DiaChi,@SDT,@Email)

go
--Thêm hóa đơn
create proc Add_HoaDon
	@MaHD nchar(10),
	@NgayLHD date,
	@MaKH nchar(10),
	@MaNV nchar(10)
as
	insert into HOADON values(@MaHD,@NgayLHD,@MaKH,@MaNV)

go
--Thêm chi tiết hóa đơn--
create proc Add_ChiTietHoaDon
	@MaHD nchar(10),
	@MaMH nchar(10),
	@SoLuong int
as
	Insert into CHITIETHOADON (MaHD,MaMH,SoLuong)
	values(@MaHD,@MaMH,@SoLuong)
go
--Thêm chức vụ.--
create proc Add_ChucVu
	@MaChucVu nchar(10),
	@TenChucVu nvarchar(50),
	@Luong float
as
	insert into CHUCVU values(@MaChucVu,@TenChucVu,@Luong)
go
--Thêm hàng nhà cung cấp.--
create proc Add_HangNhaCungCap
	@MaNCC nchar(10),
	@MaMH nchar(10),
	@SoLuong int
as
	insert into HANGNHACUNGCAP values(@MaNCC,@MaMH,@SoLuong)
go
--Thêm mã mặt hàng vào kho hàng.--
create proc Add_KhoHang
	@MaMH nchar(10)
as
	insert into KHOHANG values(@MaMH,NULL,NULL)
go
--Thêm mặt hàng.--
create proc Add_MatHang
	@MaMH nchar(10),
	@TenMH nvarchar(50),
	@Gia float,
	@NgaySX date,
	@HanSD nchar(10),
	@MaLoaiMH nchar(10)
as
	insert into MATHANG 
	values(@MaMH,@TenMH,@Gia,@NgaySX,@HanSD,@MaLoaiMH)
go
--Thêm nhà cung cấp.--
create proc Add_NhaCungCap
	@MaNCC nchar(10),
	@TenNCC nvarchar(50),
	@DiaChi nvarchar(50),
	@SDT nchar(10),
	@STK nchar(15)
as
	insert into NHACUNGCAP 
	values(@MaNCC,@TenNCC,@DiaChi,@SDT,@STK)
go
--Thêm nhân viên.--
create proc Add_NhanVien
	@MaNV nchar(10),
	@TenNV nvarchar(50),
	@GioiTinh nchar(10),
	@NgaySinh date,
	@DiaChi nvarchar(50),
	@Users nchar(10),
	@Pass nchar(10),
	@SDT nchar(10),
	@MaChucVu nchar(10)
as
	Insert into NHANVIEN
	values(@MaNV,@TenNV,@GioiTinh,@NgaySinh,@DiaChi,@Users,@Pass,@SDT,@MaChucVu)
go
--Thêm phân loại mặt hàng.--
create proc Add_PhanLoaiMatHang
	@MaLoaiMH nchar(10),
	@TenLoaiMH nvarchar(50)
as
	insert into PHANLOAIMATHANG 
	values(@MaLoaiMH,@TenLoaiMH)
go


--Các hàm sửa trong database--
--Cập nhật chi tiết hóa đơn--
create proc Update_ChiTietHoaDon
	@MaHD nchar(10),
	@MaMH nchar(10),
	@SoLuong int
as
	update CHITIETHOADON 
	set SoLuong=@SoLuong 
	where MaHD=@MaHD and MaMH=@MaMH
go
--Cập nhật chức vụ--
create proc Update_ChucVu
	@MaChucVu nchar(10),
	@TenChucVu nvarchar(50),
	@Luong float
as
	update CHUCVU 
	set TenChucVu=@TenChucVu,Luong=@Luong 
	where MaChucVu=@MaChucVu
go
--Cập nhật hàng nhà cung cấp--
create proc Update_HangNhaCungCap
	@MaNCC nchar(10),
	@MaMH nchar(10),
	@SoLuong int
as
	update HANGNHACUNGCAP
	SET SoLuong=@SoLuong 
	where MaNCC=@MaNCC and MaMH=@MaMH
go
--Cập nhật hóa đơn--
create proc Update_HoaDon
	@MaHD nchar(10),
	@NgayLHD date,
	@MaKH nchar(10),
	@MaNV nchar(10)
as
	update HOADON 
	set NgayLHD=@NgayLHD,MaKH=@MaKH,MaNV=@MaNV 
	where MaHD=@MaHD
go
create proc Update_KhachHang
	@MaKH nchar(10),
	@TenKH nvarchar(50),
	@GioiTinh nchar(10),
	@NgaySinh date,
	@DiaChi nvarchar(50),
	@SDT nchar(10),
	@Email nchar(30)
as
	update KHACHHANG 
	set	TenKH=@TenKH,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,DiaChi=@DiaChi,SDT=@SDT, Email=@Email 
	where MaKH=@MaKH
go
--Cập nhật mặt hàng--
create proc Update_MatHang
@MaMH nchar(10),
@TenMH nvarchar(50),
@Gia float,
@NgaySX date,
@HanSD nchar(10),
@MaLoaiMH nchar(10)
as
	update MATHANG 
	set	TenMH=@TenMH,Gia=@Gia,NgaySX=@NgaySX,HanSD=@HanSD,MaLoaiMH=@MaLoaiMH 
	where MaMH=@MaMH
go
--Cập nhật nhà cung cấp--
create proc Update_NhaCungCap
	@MaNCC nchar(10),
	@TenNCC nvarchar(50),
	@DiaChi nvarchar(50),
	@SDT nchar(10),
	@STK nchar(15)
as
	update NHACUNGCAP 
	set TenNCC=@TenNCC,DiaChi=@DiaChi,SDT=@SDT,STK=@STK 
	where MaNCC=@MaNCC
go
--Cập nhật nhân viên--
create	proc Update_NhanVien
	@MaNV nchar(10),
	@TenNV nvarchar(50),
	@GioiTinh nchar(10),
	@NgaySinh date,
	@DiaChi nvarchar(50),
	@Users nchar(10),
	@Pass nchar(10),
	@SDT nchar(10),
	@MaChucVu nchar(10)
as
	update NHANVIEN 
	set TenNV=@TenNV,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,
	Users=@Users,Pass=@Pass,SDT=@SDT,MaChucVu=@MaChucVu
	where MaNV=@MaNV
go

--Cập nhật phân loại mặt hàng--

create proc Update_PhanLoaiMatHang
	@MaLoaiMH nchar(10),
	@TenLoaiMH nvarchar(50)
as
	update PHANLOAIMATHANG 
	set TenLoaiMH=@TenLoaiMH
	where MaLoaiMH=@MaLoaiMH
go
--Cập nhật số lượng trong bảng kho hàng--
create proc Update_SoLuongMH
	@MaMH nchar(10),
	@SL int
as
	update KHOHANG 
	set SoLuong= @SL
	where MaMH=@MaMH
go
--Cập nhật thông tin nhân viên--
create proc Update_ThongTinNhanVien
	@MaNV nchar(10),
	@TenNV nvarchar(50),
	@GioiTinh nvarchar(50),
	@NgaySinh date,
	@DiaChi nvarchar(50),
	@SDT nchar(10)
as
begin
	update NHANVIEN set
	TenNV=@TenNV,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,DiaChi=@DiaChi, SDT=@SDT
	where MaNV=@MaNV
end
go

--Trigger--
-- Cập nhật kho hàng khi có đơn hàng mới hoặc cập nhật --
create  trigger Update_HangTrongKho_Them_Don
on CHITIETHOADON after insert 
as 
begin
	update KHOHANG
	set SoLuong=KHOHANG.SoLuong-(
		select SoLuong
		from inserted
		where inserted.MaMH=KHOHANG.MaMH
	)
	from KHOHANG
	join inserted on KHOHANG.MaMH=inserted.MaMH
end
go
-- Cập nhật kho hàng khi có đơn hàng bị hủy --
create  trigger Update_HangTrongKho_Huy_Don
on CHITIETHOADON after delete 
as 
begin
	update KHOHANG
	set SoLuong=KHOHANG.SoLuong+(
		select SoLuong
		from deleted
		where deleted.MaMH=KHOHANG.MaMH
	)
	from KHOHANG
	join deleted on KHOHANG.MaMH=deleted.MaMH
end

go
-- Cập nhật hàng trong kho sau khi cập nhật hóa đơn --
create trigger Update_HangTrongKho_Sua_Don
on CHITIETHOADON for update 
as
begin 
	update KHOHANG
	set SoLuong =KHOHANG.SoLuong - 
	(select SoLuong	from inserted where inserted.MaMH=KHOHANG.MaMH)+
	(select SoLuong	from deleted where deleted.MaMH=KHOHANG.MaMH)
	from KHOHANG
	join deleted on KHOHANG.MaMH=deleted.MaMH
end
go
--Cập nhật giá trị chi tiết hóa đơn --
create trigger Update_TongGiaTriMH_ChiTietHoaDon
on CHITIETHOADON for insert,update,delete
as
begin 
	update CHITIETHOADON
	set GiaTriMH =CHITIETHOADON.SoLuong*
	(select Gia from MATHANG where CHITIETHOADON.MaMH=MATHANG.MaMH)
	from CHITIETHOADON
end
go
--Cập nhật tổng giá trị  hóa đơn  --
create trigger Update_GiaTri_HoaDon
on CHITIETHOADON for insert,update,delete
as
begin 
	update HOADON
	set GiaTri =(select sum(GiaTriMH) from CHITIETHOADON
	where HOADON.MaHD=CHITIETHOADON.MaHD
	group by MaHD )
	from HOADON
end
go
--Cập nhật trạng thái hàng hóa trong kho--
create trigger Update_HangTrongKho
on KHOHANG for insert,update,delete
as
begin
	update KHOHANG	set  TrangThai=N'Còn' where SoLuong>0
	update KHOHANG set  TrangThai=N'Hết' where SoLuong=0
end
go
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
	insert into HOADON(MaHD,NgayLHD,MaKH,MaNV) values(@MaHD,@NgayLHD,@MaKH,@MaNV)

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
--Các hàm xóa--
--Xóa chi tiết hóa đơn.--
create proc Delete_ChiTietHoaDon
	@MaHD nchar(10),
	@MaMH nchar(10)
as
	delete from CHITIETHOADON where MaHD=@MaHD and MaMH=@MaMH;
go
--Xóa chức vụ.--
create proc Delete_ChucVu
	@MaChucVu nchar(10)
as
	delete from CHUCVU where MaChucVu=@MaChucVu
go
--Xóa hàng nhà cung cấp.--
create proc Delete_HangNhaCungCap
	@MaNCC nchar(10),
	@MaMH nchar(10)
as
	delete from HANGNHACUNGCAP where MaNCC=@MaNCC and MaMH=@MaMH
go
--Xóa hóa đơn.--
create proc Delete_HoaDon
	@MaHD nchar(10)
as
	delete from HOADON where MaHD=@MaHD
go
--Xóa khách hàng.--
create proc Delete_KhachHang
	@MaKH nchar(10)
as
	delete from KHACHHANG where MaKH=@MaKH
go
--Xóa mặt hàng trong kho hàng.--
create proc Delete_KhoHang
	@MaMH nchar(10)
as
	delete from KHOHANG where MaMH=@MaMH
go
--Xóa mặt hàng.--
create proc Delete_MatHang
	@MaMH nchar(10)
as
	delete from MATHANG where MaMH=@MaMH
go
--Xóa nhà cung cấp.--
create proc Delete_NhaCungCap
	@MaNCC nchar(10)
as
	delete from NHACUNGCAP where MaNCC=@MaNCC
go
--Xóa nhân viên.--
create proc Delete_NhanVien
	@MaNV nchar(10)
as
	delete from NHANVIEN where MaNV=@MaNV
go


--Load dữ liệu từ các bảng--
--Load dữ liệu chi tiết hóa đơn.--
create proc Load_ChiTietHoaDon
as
select * from CHITIETHOADON
go

--Load dữ liệu chức vụ.--
create proc Load_ChucVu
as
select * from CHUCVU
go

--Load dữ liệu nhà cung cấp.--
create proc Load_HangNhaCungCap
as
select * from HANGNHACUNGCAP
go

--Load dữ liệu hóa đơn.--

create proc Load_HoaDon
as
select * from HOADON
go

--Load dữ liệu khách hàng.--
create proc Load_KhachHang
as
select * from KHACHHANG
go

--Load dữ liệu kho hàng.--
create proc Load_KhoHang
as
select * from KHOHANG
go

--Load dữ liệu mặt hàng.--
create proc Load_MatHang
as
select * from MATHANG
go

--Load dữ liệu hàng nhà cung cấp.--
create proc Load_NhaCungCap
as
	select * from NHACUNGCAP
go

--Load dữ liệu nhân viên.--
create proc Load_NhanVien
as
select * from NHANVIEN
go

--Load MaMH trong HangNhaCungCap--
create proc LoadMaMH_HNCC
as
begin
select	distinct HANGNHACUNGCAP.MaMH
	from HANGNHACUNGCAP
end
go

--Load MaMH trong cả HangNhaCungCap và ChiTietHoaDon--
create proc LoadHangNCC_CTHD
as
begin
	select distinct HANGNHACUNGCAP.MaMH
	from HANGNHACUNGCAP, CHITIETHOADON
	where HANGNHACUNGCAP.MaMH=CHITIETHOADON.MaMH
end
go

--Load thông tin nhân viên--
create proc Load_ThongTinNV
@MaNV nchar(10)
as
begin
	select TenNV,GioiTinh,NgaySinh,DiaChi,SDT,TenChucVu,Luong 
	from NHANVIEN,CHUCVU
	where NHANVIEN.MaChucVu=CHUCVU.MaChucVu and MaNV=@MaNV 
end
go

--Thông tin hóa đơn và khách hàng ứng với mã hóa đơn--
create proc info_HoaDon_KhachHang
	@MaHD nchar(10)
as
begin
	select
	MaHD,NgayLHD,HOADON.MaKH,MaNV,TenKH,GioiTinh,NgaySinh,DiaChi,SDT,Email 
	from HOADON,KHACHHANG
	where HOADON.MaKH=KHACHHANG.MaKH and HOADON.MaHD=@MaHD
end
go
--Thông tin về giá cả số lượng ứng với từng loại mặt hàng--
create proc info_HoaDon_MatHang
	@MaHD nchar(10),
	@TenMH nvarchar(50)
as
begin
	select *
	from CHITIETHOADON,MATHANG
	where CHITIETHOADON.MaMH=MATHANG.MaMH and TenMH=@TenMH and CHITIETHOADON.MaHD=@MaHD
end
go
--Thông tin về tất cả các tên mặt hàng ứng với MaHD được nhận--
create proc info_AllTenMH
	@MaHD nchar(10)
as
begin
	select *
	from CHITIETHOADON, MATHANG
	where CHITIETHOADON.MaMH=MATHANG.MaMH and CHITIETHOADON.MaHD=@MaHD
end
go
--Thông tin về tên sản phẩm và giá tương ứng với MaMH.--
create proc info_MaMH_TenMH_Gia
	@MaMH nchar(10)
as
begin
	select *
	from MATHANG
	where MaMH=@MaMH
end
go
--Thông tin bảng hóa đơn--
create proc info_HoaDon
	@MaHD nchar(10)
as
begin
	select *
	from HOADON
	where MaHD=@MaHD
end
go
--Liệt kê các mã mặt hàng--
--Xem kho hàng--
create proc XemKhoHang
as
begin
	select KHOHANG.MaMH,TenMH,Gia, TrangThai,SoLuong
	from KHOHANG,MATHANG 
	where KHOHANG.MaMH=MATHANG.MaMH 
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


---Kiểm tra--
--Kiểm tra khi thay đổi Username--
create function Check_UserName(@User nvarchar(10))
returns int
as
begin 
	if (@User=(select Users from NHANVIEN where Users=@User))
	begin
		return 1;
	end
	return 0;
end
go
--Kiểm tra xem mật khẩu mới có khác mật khẩu cũ--
create function Check_PassWord(@MaNV nchar(10),@Pass nvarchar(10))
returns int
as
begin 
	if (@Pass=(select Pass from NHANVIEN where MaNV=@MaNV))
	begin
		return 1;
	end
	return 0;
end
go
---Tìm kiếm--
--Tìm khách hàng--
create proc Search_KhachHang
@Tim nvarchar(50)
as
	select * from KHACHHANG
	where MaKH like N'%'+@Tim +'%'
	or TenKH like N'%'+@Tim +'%'
	or GioiTinh like N'%'+@Tim +'%'
	or DiaChi like N'%'+@Tim +'%'
	or SDT like N'%'+@Tim +'%'
	or Email like N'%'+@Tim+'%'
	or NgaySinh like N'%'+@Tim +'%'
go
--Tìm kiếm mặt hàng--
create proc Search_MatHang
	@Tim nvarchar(30)
as
select * from MATHANG
	where MaMH like N'%'+@Tim +'%'
	or TenMH like N'%'+@Tim +'%'
	or Gia like N'%'+@Tim +'%'
	or HanSD like N'%'+@Tim +'%'
go
--Tìm kiếm nhà cung cấp.--
create proc Search_NhaCungCap
	@Tim nvarchar(30)
as
	select * from NHACUNGCAP
	where MaNCC like N'%'+@Tim +'%'
	or TenNCC like N'%'+@Tim +'%'
	or DiaChi like N'%'+@Tim+'%'
	or SDT like N'%'+@Tim +'%'
	or STK like N'%'+@Tim +'%'
go
--Tìm kiếm nhân viên.--
create proc Search_NhanVien
	@TimKiem nvarchar(30)
as
	select * from NHANVIEN
	where MaNV like N'%'+@TimKiem +'%'
	or TenNV like N'%'+@TimKiem +'%'
	or GioiTinh like N'%'+@TimKiem +'%'
	or DiaChi like N'%'+@TimKiem +'%'
	or SDT like N'%'+@TimKiem +'%'
	or MaChucVu like N'%'+@TimKiem +'%'
go
--Tìm MaNV khi đăng nhập users thành công và kiểm tra đăng nhập--
create proc NhanVien_DangNhap
	@Users nchar(10),
	@Pass nchar(10)
as
begin
	select MaNV
	from NHANVIEN
	where Users=@Users and Pass=@Pass;
end
go
--Tìm kiếm trong kho hàng--
create proc Search_KhoHang
	@Tim nvarchar(30)
as
begin
	select KHOHANG.MaMH,TenMH,Gia, TrangThai,SoLuong 
	from KHOHANG, MATHANG
	where KHOHANG.MaMH=MATHANG.MaMH and 
	KHOHANG.MaMH like N'%'+@Tim +'%'
	or TrangThai like N'%'+@Tim +'%'
	or SoLuong like N'%'+@Tim +'%'
	or TenMH like N'%'+@Tim +'%'
	or Gia like N'%'+@Tim +'%'
end
go


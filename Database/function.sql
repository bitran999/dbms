use QuanLyCuaHangTienLoi
go 

--proceduce--


--Các thủ tục thêm database--

--Thêm khách hàng--
create proc Add_KhachHang
	@TenKH nvarchar(50),
	@GioiTinh nchar(10),
	@NgaySinh date,
	@DiaChi nvarchar(50),
	@SDT nchar(10),
	@Email nchar(30)
as
	insert into KHACHHANG(TenKH,GioiTinh,NgaySinh,DiaChi,SDT,Email)
	values(@TenKH,@GioiTinh,@NgaySinh,@DiaChi,@SDT,@Email)

go

--Thêm hóa đơn
create proc Add_HoaDon
	@NgayLHD date,
	@MaKH nchar(5),
	@MaNV nchar(10)
as
	insert into HOADON(NgayLHD,MaKH,MaNV) values(@NgayLHD,@MaKH,@MaNV)

go
--Thêm chi tiết hóa đơn--
create proc Add_ChiTietHoaDon
	@MaHD nchar(5),
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
create  proc Add_HoaDonNhanHang
	@MaNCC nchar(10),
	@MaMH nchar(10),
	@NgayGiao date,
	@SoLuong int
as
	insert into HOADONNHANHANG(MaNCC,MaMH,NgayGiao,SoLuong) values(@MaNCC,@MaMH,@NgayGiao,@SoLuong)
go
--Thêm mã mặt hàng vào kho hàng.--
create proc Add_KhoHang
	@MaMH nchar(10)
as
	insert into KHOHANG values(@MaMH,NULL,NULL)
go
--Thêm mã mặt hàng vào kho hàng.--
create proc Add_KhoHang_All
	@MaMH nchar(10),@SoLuong int
as
	insert into KHOHANG(MaMH,SoLuong) values(@MaMH,@SoLuong)
go
--Thêm mặt hàng.--
create proc Add_MatHang
	@MaMH nchar(10),
	@TenMH nvarchar(50),
	@Gia float,
	@GiaGoc float,
	@NgaySX date,
	@HanSD nchar(10)
as
	insert into MATHANG 
	values(@MaMH,@TenMH,@Gia,@GiaGoc,@NgaySX,@HanSD)
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
	@MaHD nchar(5),
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
create proc Update_HoaDonNhanHang
	@MaHDN nchar(6),
	@SoLuong int
as
	update HOADONNHANHANG
	SET SoLuong=@SoLuong
	where MaHDN=@MaHDN
go
--Cập nhật hóa đơn--
create  proc Update_HoaDon
	@MaHD nchar(5),
	@NgayLHD date,
	@MaKH nchar(5),
	@MaNV nchar(10),
	@GiaTri float
as
	update HOADON 
	set NgayLHD=@NgayLHD,MaKH=@MaKH,MaNV=@MaNV ,GiaTri=@GiaTri
	where MaHD=@MaHD
go
create proc Update_KhachHang
	@MaKH nchar(5),
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
create  proc Update_MatHang
@MaMH nchar(10),
@TenMH nvarchar(50),
@Gia float,
@GiaGoc float,
@NgaySX date,
@HanSD nchar(10)
as
	update MATHANG 
	set	TenMH=@TenMH,Gia=@Gia,NgaySX=@NgaySX,HanSD=@HanSD,GiaGoc=@GiaGoc
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
--Cập nhật nhân viên cho admin--
create	proc Update_NhanVien_Admin
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
	Users=@Users,Pass=@Pass,SDT=@SDT,MaChucVu=@MaChucVu,DiaChi=@DiaChi
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
	update NHANVIEN 
	set
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
create proc Delete_HoaDonNhan
	@MaHDN nchar(6)
as
	delete from HOADONNHANHANG where MaHDN=@MaHDN
go
--Xóa hóa đơn.--
create proc Delete_HoaDon
	@MaHD nchar(10)
as
	delete from HOADON where MaHD=@MaHD
	delete from CHITIETHOADON where MaHD=@MaHD
go
--Xóa khách hàng.--
create proc Delete_KhachHang
	@MaKH nchar(5)
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
create   proc Load_HoaDonNhan
	@MaNCC varchar(10)
as
	select * from HOADONNHANHANG
	where MaNCC=@MaNCC;
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
create  proc Load_KhoHang
as
select * from KHOHANG
go

--Load dữ liệu mặt hàng.--
create  proc Load_MatHang
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


--Load thông tin nhân viên--
create proc Load_ThongTinNV
@MaNV nchar(10)
as
begin
	select MaNV, TenNV,GioiTinh,NgaySinh,DiaChi,Users,Pass,SDT,NHANVIEN.MaChucVu,TenChucVu,Luong 
	from NHANVIEN,CHUCVU
	where NHANVIEN.MaChucVu=CHUCVU.MaChucVu and MaNV=@MaNV 
end
go

--Thông tin hóa đơn và khách hàng ứng với mã hóa đơn--
create proc info_HoaDon_KhachHang
	@MaHD nchar(5)
as
begin
	select
	MaHD,NgayLHD,HOADON.MaKH,MaNV,TenKH,GioiTinh,NgaySinh,DiaChi,SDT,Email 
	from HOADON,KHACHHANG
	where HOADON.MaKH=KHACHHANG.MaKH and HOADON.MaHD=@MaHD
end
go
--Load thông tin toàn bộ của nhân viên--
create proc Load_Info_NhanVien
as
begin
	select MaNV,TenNV ,GioiTinh ,NgaySinh,DiaChi,Users,Pass ,SDT ,NHANVIEN.MaChucVu,TenChucVu ,Luong 
	from NHANVIEN inner join CHUCVU on NHANVIEN.MaChucVu=CHUCVU.MaChucVu
end
go
--Thông tin về giá cả số lượng ứng với từng loại mặt hàng--
create proc info_HoaDon_MatHang
	@MaHD nchar(5),
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
	@MaHD nchar(5)
as
begin
	select *
	from CHITIETHOADON, MATHANG
	where CHITIETHOADON.MaMH=MATHANG.MaMH and CHITIETHOADON.MaHD=@MaHD
end
go

---Lấy  mặt hàng theo mã---
create   proc Load_MatHang_MaMH
	@MaMH nchar(10)
as
begin
	select MaMH,TenMH,Gia,GiaGoc,NgaySX,HanSD from MATHANG where MaMH=@MaMH
end
go
--Thông tin bảng hóa đơn theo id--
create proc info_HoaDon
	@MaHD nchar(5)
as
begin
	select *
	from HOADON
	where MaHD=@MaHD
end
go
--Thông tin bảng chi tiet hóa đơn theo id--
create proc info_ChiTietHoaDon
	@MaHD nchar(5)
as
begin
	select *
	from CHITIETHOADON
	where MaHD=@MaHD
end
go
---Thông tin chi tiết hóa đơn theo mã hóa đơn và mã sản phẩm--
create  proc info_ChiTietHoaDon_FindOne
	@MaHD nchar(5),@MaMH nvarchar(10)
as
begin
	select *
	from CHITIETHOADON
	where MaHD=@MaHD and MaMH=@MaMH
end
go
--Lấy nhà cung cấp theo mã nhà cung cấp--
create proc Load_NhaCungCap_MaNCC
	@MaNCC nchar(10)
as
	select * from NHACUNGCAP where MaNCC=@MaNCC
go
---Lấy ra lợi nhuận mỗi hóa đơn--
create proc LoiNhuan_HoaDon
	@MaHD varchar(5)
as
begin
	select sum((Gia-GiaGoc)*SoLuong)as LoiNhuan
	from MATHANG 
	join CHITIETHOADON on CHITIETHOADON.MaMH=MATHANG.MaMH
	where MaHD=@MaHD
end
go
--Trigger--
-- Cập nhật kho hàng khi có đơn hàng mới hoặc cập nhật --
create   trigger Update_HangTrongKho_Insert_ChiTietHoaDon
on CHITIETHOADON for insert 
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
create  trigger Update_HangTrongKho_Delete_ChiTietHoaDon
on CHITIETHOADON for delete 
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
create  trigger Update_HangTrongKho_Update_ChiTietHoaDon
on CHITIETHOADON after update 
as
begin 
	update KHOHANG
	set KHOHANG.SoLuong=KHOHANG.SoLuong- i.SoLuong+d.SoLuong
	from KHOHANG
	inner join inserted as i on KHOHANG.MaMH=i.MaMH
	inner join deleted as d on i.MaMH=d.MaMH
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
--Cập nhật giá đơn nhận hàng --
create  trigger Update_HoaDonNhan
on HOADONNHANHANG for insert,update,delete
as
begin 
	update HOADONNHANHANG
	set GiaTri =HOADONNHANHANG.SoLuong*
	(select GiaGoc from MATHANG where HOADONNHANHANG.MaMH=MATHANG.MaMH)
	from HOADONNHANHANG
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
-- Cập nhật kho hàng khi xóa hóa đơn nhận hàng --
create trigger Update_HangTrongKho_Delete_HoaDonNhan
on HOADONNHANHANG for delete 
as 
begin
	update KHOHANG
	set SoLuong=KHOHANG.SoLuong-(
		select SoLuong
		from deleted
		where deleted.MaMH=KHOHANG.MaMH
	)
	from KHOHANG
	join deleted on KHOHANG.MaMH=deleted.MaMH
end
go
-- Cập nhật kho hàng khi có hàng mới nhận --
create  trigger Update_HangTrongKho_Insert_HoaDonNhan
on HOADONNHANHANG for insert 
as 
begin
	update KHOHANG
	set SoLuong=KHOHANG.SoLuong+(
		select SoLuong
		from inserted
		where inserted.MaMH=KHOHANG.MaMH
	)
	from KHOHANG
	join inserted on KHOHANG.MaMH=inserted.MaMH
end
go
-- Cập nhật hàng trong kho sau khi cập nhật hóa đơn nhận hàng--
create  trigger Update_HangTrongKho_Update_HoaDonNhan
on HOADONNHANHANG after update 
as
begin 
	update KHOHANG
	set KHOHANG.SoLuong=KHOHANG.SoLuong+i.SoLuong-d.SoLuong
	from KHOHANG
	inner join inserted as i on KHOHANG.MaMH=i.MaMH
	inner join deleted as d on i.MaMH=d.MaMH
end
go
go
---Kiểm tra--
--Kiểm tra khi thay đổi Username-- Do
/*
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
*/
--Kiểm tra khi thay đổi Username--
create proc Check_UserName
	@Users nchar(10)
as
begin
	select *
	from NHANVIEN
	where Users=@Users
end
go
--Kiểm tra xem mật khẩu mới có khác mật khẩu cũ--
create proc Check_PassWord(@MaNV nchar(10),@Pass nvarchar(10))
as
begin 
	select *
	from NHANVIEN
	where MaNV=@MaNV and Pass=@Pass
end
go
--Kiểm tra xem mã nhân viên đã có chưa--
create proc Check_MaNV(@MaNV nchar(10))
as
begin 
	select *
	from NHANVIEN
	where MaNV=@MaNV
end
go
--Đổi mật khẩu--
create proc Change_PassWord(@MaNV nchar(10),@Pass nvarchar(10))
as
begin 
	update NHANVIEN
	set Pass=@Pass
	where MaNV=@MaNV
end
go
--Kiểm tra xem khách hàng đã có số điện thoại hay email trùng chưa
create proc Check_Customer(@SDT nchar(10),@Email nvarchar(30))
as
begin 
	select *
	from KHACHHANG
	where SDT=@SDT or Email=@Email
end
go

--Hàm kiểm tra số lượng và trạng thái của sản phẩm trong kho--
create proc Check_MatHang_Category(@MaMH nchar(10))
as
begin 
	select TrangThai,SoLuong
	from KHOHANG
	where MaMH=@MaMH
end
go
--Kiểm tra xem đã có số điện thoại hay số tài khoản nhà cung cấp--
create proc Check_NhaCC
	(@SDT nchar(10),@STK nvarchar(15))
as
begin 
	select *
	from NHACUNGCAP
	where SDT=@SDT or STK=@STK
end
go
--Hàm tạo mã khách hàng tự động----

CREATE FUNCTION AUTO_IDKH()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(MaKH) FROM KHACHHANG) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaKH, 3)) FROM KHACHHANG
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'KH00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'KH0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
go
--Hàm tạo mã hóa đơn tự động--
CREATE FUNCTION AUTO_IDHD()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(MaHD) FROM HOADON) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaHD, 3)) FROM HOADON
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'HD00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'HD0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
go
--Hàm tạo mã hóa đơn nhận hàng tự động--
CREATE FUNCTION AUTO_IDHDN()
RETURNS VARCHAR(6)
AS
BEGIN
	DECLARE @ID VARCHAR(6)
	IF (SELECT COUNT(MaHDN) FROM HOADONNHANHANG) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaHDN, 3)) FROM HOADONNHANHANG
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'HDN00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'HDN0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
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
--Tìm kiếm mặt hàng theo mã nhà cung cấp--
create proc Search_MatHang_NCC
	@Tim nvarchar(30)
as
	select * from HOADONNHANHANG
	where MaNCC like N'%'+@Tim +'%'
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
	select MaNV from NHANVIEN
	where MaNV like N'%'+@TimKiem +'%'
	or TenNV like N'%'+@TimKiem +'%'
	or GioiTinh like N'%'+@TimKiem +'%'
	or DiaChi like N'%'+@TimKiem +'%'
	or SDT like N'%'+@TimKiem +'%'
	or MaChucVu like N'%'+@TimKiem +'%'
go
--Tìm MaNV khi đăng nhập users thành công và kiểm tra đăng nhập--
create proc NhanVien_DangNhap
	@UserName nchar(10),
	@PassWord nchar(10)
as
begin
	select MaNV
	from NHANVIEN
	where Users=@UserName and Pass=@PassWord;
end
go
--Tìm kiếm trong kho hàng--
create  proc Search_KhoHang
	@Tim nvarchar(30)
as
begin
	select MaMH, TrangThai,SoLuong 
	from KHOHANG
	where MaMH like N'%'+@Tim +'%'
	or TrangThai like N'%'+@Tim +'%'
	or SoLuong like N'%'+@Tim +'%'
end
go
--Lấy tất cả hóa đơn theo ngày--
create  proc Load_Bill_Date
	@DateFront date,@DateBack date
as 
begin
	select *from HOADON
	where NgayLHD<=@DateBack and NgayLHD>=@DateFront
end 
go
--Lấy hàng hóa theo hạn sử dụng --
----------------Đã hêt hạn--------
create    proc Load_MatHang_HetHan
	as 
begin
	select KHOHANG.MaMH,TrangThai,SoLuong 
	from KHOHANG
	join  MATHANG on MATHANG.MaMH=KHOHANG.MaMH
	where MATHANG.HanSD<getdate()
end 
go
----------------Chưa hêt hạn--------
create  proc Load_MatHang_ChuaHetHSD
	as 
begin
		select KHOHANG.MaMH,TrangThai,SoLuong 
	from KHOHANG
	join  MATHANG on MATHANG.MaMH=KHOHANG.MaMH
	where MATHANG.HanSD>=getdate()
end 
go
------------------------------------------------
------------------------------------------------
create proc delete_all
as
begin
	delete from NHANVIEN
	delete from KHACHHANG
	delete from KHOHANG
	delete  from HOADON
	delete  from CHITIETHOADON
	delete from HOADONNHANHANG
	delete  from NHACUNGCAP
	delete  from CHUCVU
	delete  from MATHANG
end
-----
go
create  proc get_all
as
begin
	select * from NHANVIEN
	select * from KHACHHANG
	select * from KHOHANG
	select *  from HOADON
	select *  from CHITIETHOADON
	select * from HOADONNHANHANG
	select *  from NHACUNGCAP
	select *  from CHUCVU
	select *  from MATHANG
end
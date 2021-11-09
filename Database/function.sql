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
	@HanSD nchar(10)
as
	insert into MATHANG 
	values(@MaMH,@TenMH,@Gia,@NgaySX,@HanSD)
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
	@MaHD nchar(5),
	@NgayLHD date,
	@MaKH nchar(5),
	@MaNV nchar(10)
as
	update HOADON 
	set NgayLHD=@NgayLHD,MaKH=@MaKH,MaNV=@MaNV 
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
create proc Update_MatHang
@MaMH nchar(10),
@TenMH nvarchar(50),
@Gia float,
@NgaySX date,
@HanSD nchar(10),
@MaLoaiMH nchar(10)
as
	update MATHANG 
	set	TenMH=@TenMH,Gia=@Gia,NgaySX=@NgaySX,HanSD=@HanSD
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
--Load thông tin trả về kho hàng, chi tiết các loại mặt hàng
create proc Load_Info_WareHouse
as
begin
	select MATHANG.MaMH as [Mã Mặt Hàng],
	TenMH as [Tên Mặt Hàng],
	Gia as [Giá],
	NgaySX as [Ngày Sản Xuất],
	HanSD as[Hạn Sử Dụng],
	TrangThai as[Trạng Thái],
	SoLuong as[Số Lượng]
	from MATHANG inner join KHOHANG on MATHANG.MaMH=KHOHANG.MaMH
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
create proc info_ChiTietHoaDon_FindOne
	@MaHD nchar(5),@MaMH nvarchar(10)
as
begin
	select *
	from CHITIETHOADON
	where MaHD=@MaHD and MaMH=@MaMH
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
create  trigger Update_HangTrongKho_Sua_Don
on CHITIETHOADON after update 
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
			WHEN @ID >= 0 and @ID < 9 THEN 'KH0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'KH' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
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
			WHEN @ID >= 0 and @ID < 9 THEN 'HD0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'HD' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
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
------------------------------------------------
create proc delete_all
as
begin
	delete from NHANVIEN
	delete from KHACHHANG
	delete from KHOHANG
	delete  from HOADON
	delete  from CHITIETHOADON
	delete from HANGNHACUNGCAP
	delete  from NHACUNGCAP
	delete  from CHUCVU
	delete  from MATHANG
end
-----
go
create proc get_all
as
begin
	select * from NHANVIEN
	select * from KHACHHANG
	select * from KHOHANG
	select *  from HOADON
	select *  from CHITIETHOADON
	select * from HANGNHACUNGCAP
	select *  from NHACUNGCAP
	select *  from CHUCVU
	select *  from MATHANG
end
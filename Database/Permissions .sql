create login QLCHTLAdmin  with password='12345'
create user manager for login QLCHTLAdmin
create login QLCHTLNormal  with password='12345'
create user staff for login QLCHTLNormal

grant select,insert,update,delete on NHANVIEN to manager
grant select,insert,update,delete on CHUCVU to manager
grant select,insert,update,delete on HOADON to manager
grant select,insert,update,delete on CHITIETHOADON to manager
grant select,insert,update,delete on MATHANG to manager
grant select,insert,update,delete on KHOHANG to manager
grant select,insert,update,delete on HOADONNHANHANG to manager
grant select,insert,update,delete on KHACHHANG to manager
grant select,insert,update,delete on NHACUNGCAP to manager
-------
grant select,update on NHANVIEN to staff
grant select on CHUCVU to staff
grant insert on HOADON to staff
grant insert on CHITIETHOADON to staff
grant select on MATHANG to staff
grant select on KHOHANG to staff
grant select,insert,update on KHACHHANG to staff

------------
grant execute on dbo.
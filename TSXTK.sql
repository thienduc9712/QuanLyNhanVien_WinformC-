create proc ThemNV
@_idNV char(10),
@_idThe char(10),
@_TenNV nvarchar(50),
@_HovaTen nvarchar(50),
@_GioiTinh nvarchar(10),
@_NgaySinh date,
@_NoiSinh nvarchar (50),
@_NguyenQuan nvarchar(50),
@_HoKhauThuongChu nvarchar(50),
@_ChoOHienNay nvarchar(50),
@_SDT char(20),
@_DanToc nvarchar(20),
@_CMND varchar(20),
@_NoiCap nvarchar(50),
@_NgayCap date,
@_TinhTrangHonNhan nvarchar(50),
@_TrinhDohocVan nvarchar(50),
@_idPB char(10),
@_idCV char(10)
as
INSERT INTO NhanVien (idNV,idThe,TenNV,HovaTen,GioiTinh,NgaySinh,NoiSinh,NguyenQuan,HoKhauThuongChu,ChoOHienNay,SDT,DanToc,CMND,NoiCap,NgayCap,TinhTrangHonNhan,TrinhDohocVan,idPB,idCV)
values (@_idNV,@_idThe,@_TenNV,@_HovaTen,@_GioiTinh,@_NgaySinh,@_NoiSinh,@_NguyenQuan,@_HoKhauThuongChu,@_ChoOHienNay,@_SDT,@_DanToc,@_CMND,@_NoiCap,@_NgayCap,@_TinhTrangHonNhan,@_TrinhDohocVan,@_idPB,@_idCV)

create proc SuaNV
@_idNV char(10),
@_idThe char(10),
@_TenNV nvarchar(50),
@_HovaTen nvarchar(50),
@_GioiTinh nvarchar(10),
@_NgaySinh date,
@_NoiSinh nvarchar (50),
@_NguyenQuan nvarchar(50),
@_HoKhauThuongChu nvarchar(50),
@_ChoOHienNay nvarchar(50),
@_SDT char(20),
@_DanToc nvarchar(20),
@_CMND varchar(20),
@_NoiCap nvarchar(50),
@_NgayCap date,
@_TinhTrangHonNhan nvarchar(50),
@_TrinhDohocVan nvarchar(50),
@_idPB char(10),
@_idCV char(10)
as
UPDATE NhanVien
Set  idThe = @_idThe,TenNV = @_TenNV,HovaTen = @_HovaTen,GioiTinh = @_GioiTinh,NgaySinh = @_NgaySinh,NguyenQuan = @_NguyenQuan, HoKhauThuongChu = @_HoKhauThuongChu, ChoOHienNay = @_ChoOHienNay,SDT = @_SDT, DanToc = @_DanToc,CMND = @_CMND, NoiCap = @_NoiCap,NgayCap = @_NgayCap, TinhTrangHonNhan = @_TinhTrangHonNhan, TrinhDohocVan = @_TrinhDohocVan, idPB = @_idPB, idCV = @_idCV
Where idNV = @_idNV

create proc XoaNV
@_idNV char(10)
as
Delete from NhanVien where idNV = @_idNV

create proc TimNV
@_TenNV nvarchar(50)
as
SELECT * FROM NhanVien WHERE TenNV like @_TenNV

create proc ThemPB
@_idPB char(10),
@_TenPB nvarchar(50),
@_DiaDiem nvarchar(50),
@_SoLuongNV int,
@_TruongPhong nvarchar(50)
as
INSERT INTO PhongBan (idPB, TenPB, DiaDiem,SoLuongNV,TruongPhong) 
values (@_idPB, @_TenPB, @_DiaDiem, @_SoLuongNV, @_TruongPhong)

create proc SuaPB
@_idPB char(10),
@_TenPB nvarchar(50),
@_DiaDiem nvarchar(50),
@_SoLuongNV int,
@_TruongPhong nvarchar(50)
as
Update PhongBan
set TenPB = @_TenPB, DiaDiem = @_DiaDiem, SoLuongNV = @_SoLuongNV, TruongPhong = @_TruongPhong where idPB = @_idPB

create proc XoaPB
@_idPB char(10)
as
Delete from PhongBan where idPB = @_idPB

create proc TimPB
@_TenPB nvarchar(50)
as
SELECT * FROM PhongBan WHERE TenPB like @_TenPB

create proc ThemBL
@_idBL char(10),
@_Thang nvarchar(20),
@_Nãm nvarchar(20),
@_idCV char(10),
@_TenNV nvarchar(50),
@_LuongChinh int,
@_PhuCap int,
@_HoTro int,
@_TongThuNhap int,
@_DongBH int
as
INSERT INTO BangLuong(idBL, Thang, Nam,idCV,TenNV, LuongChinh,PhuCap,HoTro,TongThuNhap,DongBH) 
values (@_idBL, @_Thang, @_Nãm,@_idCV, @_TenNV, @_LuongChinh,@_PhuCap,@_HoTro,@_TongThuNhap,@_DongBH)

create proc SuaBL
@_idBL char(10),
@_Thang nvarchar(20),
@_Nãm nvarchar(20),
@_idCV char(10),
@_TenNV nvarchar(50),
@_LuongChinh int,
@_PhuCap int,
@_HoTro int,
@_TongThuNhap int,
@_DongBH int
as
Update BangLuong
set Thang = @_Thang,Nam = @_Nãm,idCV = @_idCV ,TenNV = @_TenNV, LuongChinh = @_LuongChinh,PhuCap= @_PhuCap, HoTro = @_HoTro,TongThuNhap= @_TongThuNhap, DongBH= @_DongBH 
where idBL = @_idBL

create proc XoaBL
@_idBL char(10)
as
Delete from BangLuong where idBL = @_idBL

create proc TimBL
@_Thang nvarchar(20)
as
SELECT * FROM BangLuong WHERE Thang like @_Thang

create proc ThemCV
@_idCV char(10),
@_TenCV nvarchar(50)
as
INSERT INTO ChucVu(idCV, TenCV) 
values (@_idCV, @_TenCV)

create proc SuaCV
@_idCV char(10),
@_TenCV nvarchar(50)
as
Update ChucVu
set TenCV = @_TenCV
where idCV = @_idCV

create proc XoaCV
@_idCV char(10)
as
Delete from ChucVu where idCV = @_idCV

create proc TimCV
@_idCV char(10)
as
SELECT * FROM ChucVu WHERE idCV like @_idCV

create proc ThemTK
@_idTK char(10),
@_TenTK nvarchar(50),
@_MatKhau nvarchar(50),
@_idNV char(10)
as
INSERT INTO TaiKhoan(idTK, TenTK,MatKhau,idNV) 
values (@_idTK, @_TenTK,@_MatKhau,@_idNV)

create proc SuaTK
@_idTK char(10),
@_TenTK nvarchar(50),
@_MatKhau nvarchar(50),
@_idNV char(10)
as
Update TaiKhoan
set TenTK = @_TenTK,MatKhau = @_MatKhau, idNV  =@_idNV
where idTK = @_idTK

create proc XoaTK
@_idTK char(10)
as
Delete from TaiKhoan where idTK = @_idTK

create proc TimTK
@_idNV char(10)
as
SELECT * FROM TaiKhoan WHERE idNV like @_idNV


create proc SuaBCC
@_idBCC char(10),
@_Thang nvarchar(20),
@_Nam nvarchar(20),
@_TenNV nvarchar(50),
@_idNV char(10),
@_N1 nvarchar(10),
@_N2 nvarchar(10),
@_N3 nvarchar(10),
@_N4 nvarchar(10),
@_N5 nvarchar(10),
@_N6 nvarchar(10),
@_N7 nvarchar(10),
@_N8 nvarchar(10),
@_N9 nvarchar(10),
@_N10 nvarchar(10),
@_N11 nvarchar(10),
@_N12 nvarchar(10),
@_N13 nvarchar(10),
@_N14 nvarchar(10),
@_N15 nvarchar(10),
@_N16 nvarchar(10),
@_N17 nvarchar(10),
@_N18 nvarchar(10),
@_N19 nvarchar(10),
@_N20 nvarchar(10),
@_N21 nvarchar(10),
@_N22 nvarchar(10),
@_N23 nvarchar(10),
@_N24 nvarchar(10),
@_N25 nvarchar(10),
@_N26 nvarchar(10),
@_N27 nvarchar(10),
@_N28 nvarchar(10),
@_N29 nvarchar(10),
@_N30 nvarchar(10),
@_N31 nvarchar(10),
@_DiMuon int,
@_NghiKhongLuong int,
@_NghiLe int,
@_NghiPhep int,
@_TongCong int
as
Update BangChamCong
set Thang = @_Thang,Nam = @_Nam, TenNV  = @_TenNV,idNV= @_idNV,N1=@_N1,N2=@_N2,N3=@_N3,N4=@_N4,N5=@_N5,N6=@_N6,N7=@_N7,N8=@_N8,N9=@_N9,N10=@_N10,N11=@_N11,N12=@_N12,N13=@_N13,N14=@_N14,N15=@_N15,N16=@_N16,N17=@_N17,N18=@_N18,N19=@_N19,N20=@_N20,N21=@_N21,N22=@_N22,N23=@_N23,N24=@_N24,N25=@_N25,N26=@_N26,N27=@_N27,N28=@_N28,N29=@_N29,N30=@_N30,N31=@_N31,DiMuon= @_DiMuon,NghiKhongLuong = @_NghiKhongLuong,NghiLe= @_NghiLe, NghiPhep= @_NghiPhep,TongCong= @_TongCong
where idBCC = @_idBCC

create proc TimThangBCC
@_Thang nvarchar(20)
as
SELECT * FROM BangChamCong WHERE Thang like @_Thang

create proc TimNamBCC
@_Nam nvarchar(20)
as
SELECT * FROM BangChamCong WHERE Nam like @_Nam

create proc XoaBCC
@_Thang nvarchar(20)
as
Delete from BangChamCong where Thang = @_Thang
create table PhongBan(
idPB int primary key identity (1,1),
TenPB nvarchar(50),
DiaDiem nvarchar(50),
SoLuongNV int,
TruongPhong nvarchar(50)
)
create table ChucVu(
idCV int primary key identity (1,1),
TenCV nvarchar(50),
)
create table BangLuong(
idBL int primary key identity (1,1),
Thang nvarchar(20),
Nam nvarchar(20),
idCV int REFERENCES ChucVu(idCV),
TenNV nvarchar(50),
LuongChinh int,
PhuCap int,
HoTro int,
TongThuNhap int,
DongBH int
)
create table NhanVien(
idNV int primary key identity (1,1),
idThe int,
TenNV nvarchar(50),
HovaTen nvarchar(50),
GioiTinh nvarchar(10),
NgaySinh date,
NoiSinh nvarchar (50),
NguyenQuan nvarchar(50),
HoKhauThuongChu nvarchar(50),
ChoOHienNay nvarchar(50),
SDT char(20),
DanToc nvarchar(20),
CMND varchar(20),
NoiCap nvarchar(50),
NgayCap date,
TinhTrangHonNhan nvarchar(50),
TrinhDohocVan nvarchar(50),
idPB int REFERENCES PhongBan(idPB),
idCV int REFERENCES ChucVu(idCV)
)
create table BangChamCong(
idBCC int primary key identity (1,1),
Thang nvarchar(20),
Nam nvarchar(20),
TenNV nvarchar(50),
idNV int REFERENCES NhanVien(idNV),
N1 nvarchar(10),
N2 nvarchar(10),
N3 nvarchar(10),
N4 nvarchar(10),
N5 nvarchar(10),
N6 nvarchar(10),
N7 nvarchar(10),
N8 nvarchar(10),
N9 nvarchar(10),
N10 nvarchar(10),
N11 nvarchar(10),
N12 nvarchar(10),
N13 nvarchar(10),
N14 nvarchar(10),
N15 nvarchar(10),
N16 nvarchar(10),
N17 nvarchar(10),
N18 nvarchar(10),
N19 nvarchar(10),
N20 nvarchar(10),
N21 nvarchar(10),
N22 nvarchar(10),
N23 nvarchar(10),
N24 nvarchar(10),
N25 nvarchar(10),
N26 nvarchar(10),
N27 nvarchar(10),
N28 nvarchar(10),
N29 nvarchar(10),
N30 nvarchar(10),
N31 nvarchar(10),
DiMuon int,
NghiKhongLuong int,
NghiLe int,
NghiPhep int,
TongCong int
)


create table TaiKhoan(
idTK int primary key identity (1,1),
TenTK nvarchar(50),
MatKhau nvarchar(50),
idNV int REFERENCES NhanVien(idNV),
)



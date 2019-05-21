create database QLTV
use QLTV
set dateformat DMY

create table LOAIDOCGIA
(
	MaLDG varchar(6) primary key,
	TenLDG nvarchar(40)
)

create table THELOAI
(
	MaTL varchar(6) primary key,
	TenTL nvarchar(40)
)

create table TACGIA
(
	MaTG varchar(6) primary key,
	TenTG nvarchar(40)
)

create table NHANVIEN
(
	MaNV varchar(6) primary key,
	TenNV nvarchar(40),
	MatKhau varchar(10),
	TaiKhoan varchar(10)
)

create table DOCGIA
(
	MaDG varchar(6) primary key,
	HoTen nvarchar(40),
	MaLDG varchar(6) references LOAIDOCGIA(MaLDG),
	NgaySinh datetime,
	DiaChi nvarchar(150),
	Email varchar(40),
	NgayLapThe datetime,
	NgayHetHan datetime,
	TinhTrangThe bit, -- 0: het han, 1: con han
	TongNo money
)

create table SACH
(
	MaSach varchar(6) primary key,
	TenSach nvarchar(40),
	MaTL varchar(6) references THELOAI(MaTL),
	MaTG varchar(6) references TACGIA(MaTG),
	NamXB int,
	NXB nvarchar(150),
	NgayNhap datetime,
	TriGia money,
	TinhTrang bit,
	AnhBia varchar(100)
)

create table PHIEUPHAT
(
	MaPP varchar(6) primary key,
	MaDG varchar(6) references DOCGIA(MaDG),
	SoTienThu money,
	ConLai money,
	MaNV varchar(6) references NHANVIEN(MaNV)
)

create table PHIEUMUON
(
	MaPM varchar(6) primary key,
	MaDG varchar(6) references DOCGIA(MaDG),
	NgayMuon datetime,
	MaNV varchar(6) references NHANVIEN(MaNV)
)

create table CTPHIEUMUON
(
	MaPM varchar(6) not null references PHIEUMUON(MaPM),
	MaSach varchar(6) not null references SACH(MaSach)
)
ALTER TABLE CTPHIEUMUON ADD CONSTRAINT ctphieumuon_pk PRIMARY KEY (MaPM, MaSach)

create table TRASACH
(
	MaPT varchar(6) primary key,
	MaPM varchar(6) references PHIEUMUON(MaPM),
	MaDG varchar(6) references DOCGIA(MaDG),
	NgayTra datetime,
	MaNV varchar(6) references NHANVIEN(MaNV),
	TienPhatKyNay money
)

create table CTTRASACH
(
	MaPT varchar(6) not null references TRASACH(MaPT),
	MaSach varchar(6) not null references SACH(MaSach),
	SoNgayMuon int,
	TienPhat money
)
ALTER TABLE CTTRASACH ADD CONSTRAINT cttrasach_pk PRIMARY KEY (MaPT, MaSach) 

create table BAOCAOTHELOAI
(
	MaBCTL varchar(6) primary key,
	ThangBaoCao int,
	TongSoLuotMuon int
)

create table CTBAOCAOTHELOAI
(
	MaCTBCTL varchar(6) primary key,
	MaBCTL varchar(6) references BAOCAOTHELOAI(MaBCTL),
	MaTL varchar(6) references THELOAI(MaTL),
	SoLuotMuon int,
	Tile float
)


create table BAOCAOSACHTRATRE
(
	MaBCSTT varchar(6) primary key,
	Ngay datetime
)

create table CTBAOCAOSACHTRATRE
(
	MaCT varchar(6) primary key,
	MaBCSTT varchar(6) references BAOCAOSACHTRATRE(MaBCSTT),
	MaSach varchar(6) references SACH(MaSach),
	MaPM varchar(6) references PHIEUMUON(MaPM),
	SoNgayTraTre int
)

create table THAMSO
(
	TuoiToiDa int,
	TuoiToiThieu int,
	ThoiHanThe int,
	SoLuongTGToiDa int,
	DieuKienNhanSach int,
	SoSachMuonToiDa int,
	ThoiGianMuonToiDa int,
	TienPhatMotNgay money
)


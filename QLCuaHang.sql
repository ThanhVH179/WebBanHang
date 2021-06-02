create database QLCuaHang;
use QLCuaHang;

create table QUANLY(
id int not null identity(1,1) primary key,
hoTen nvarchar(100),
userName varchar(50),
pass varchar(255),
);
create table SANPHAM(
maSP varchar(20) not null primary key,
tenSP nvarchar(100) not null,
maLoai varchar(20) not null,
gia money not null,
hinh varchar(200) not null,
giamGia int not null,
ngayNhap date not null,
constraint fk_product_cate foreign key (maLoai) references LOAI(maLoai)
);

create table LOAI(
maLoai varchar(20) not null primary key,
tenLoai nvarchar(100) not null
);

create table GIOHANG(
maCart int identity(1,1) not null primary key,
tenKH nvarchar(100) not null,
sdt varchar(13) not null,
diaChi nvarchar(100) not null,
tongTien money default '0',
ngayTao date
);

create table CHITIETGIOHANG(
maDetail int identity(1,1) not null primary key,
maCart int not null,
IdSP int not null,
soLuong int not null,
tongTien money default '0',
constraint fk_detail_cart foreign key (maCart) references GIOHANG(maCart)
);

create table KHACHHANG(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](30) NOT NULL,
	[SDT] [varchar](12) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[NgayDK] [date] NULL,
);



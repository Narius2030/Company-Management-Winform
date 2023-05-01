--drop database QLCT

create database QLCT
go
USE QLCT
go
--Drop table NHANSU,TAIKHOAN,TIENLUONG,PHONGBAN,CHUCVU,CHAMCONG,CHECKIN_OUT,DUAN,PHANCONGDUAN,TRANGTHAINHANVIEN


CREATE TABLE NHANSU(
	MaNV varchar(5) PRIMARY KEY,
	HovaTendem varchar(40) NULL,
	Ten varchar(10) NULL,
	NgaySinh Date NULL,
	DiaChi varchar(50) NULL,
	CCCD varchar(12) NULL,
	MaPB varchar(4) NULL,
	GioiTinh varchar(4) NULL,
	SDT varchar(10) NULL,
	Email varchar(320) NULL,
	MaCV varchar(6) NULL,
	TrinhDo varchar(30)NULL
)
Go

Insert into NHANSU Values ('NV003', 'Nguyen Thi', 'Hoa', '1992-12-11', '111 Vo Van Ngan', '321654988614', 'P001', 'Nam', '0945681625', 'NV003@gmail.com', 'TPNS','Senior'),
						('NV008', 'Nguyen Van', 'Long', '1968-05-23', '111 Vo Van Ngan', '321653988613', 'P001', 'Nam', '0945781623', 'NV008@gmail.com', 'NVHC','fresher'),
						('NV001', 'Nguyen Ngoc', 'Hoang', '1972-08-13', '111 Vo Van Ngan', '321654988612', 'P001', 'Nam', '0945681624', 'NV001@gmail.com', 'TD','Junior'),
						('NV004', 'Nguyen Hoang', 'Nhan', '1999-12-28', '111 Vo Van Ngan', '321654988615', 'P003', 'Nam', '0945681628', 'NV004@gmail.com', 'TPMT','Senior'),
						('NV010', 'Nguyen Vo', 'Nhan', '1999-12-28', '111 Vo Van Ngan', '321654999615', 'P003', 'Nam', '0945681628', 'NV010@gmail.com', 'NVQC','Intership'),
						('NV009', 'Nguyen Vo', 'Si', '1999-12-28', '111 Vo Van Ngan', '321667999615', 'P003', 'Nam', '0945751628', 'NV009@gmail.com', 'NVTCSK','fresher'),
						('NV005', 'Nguyen Huynh', 'Hau', '1989-08-15', '111 Vo Van Ngan', '321654988616', 'P002', 'Nam', '0945681629', 'NV005@gmail.com', 'TPTC','Senior'),
						('NV011', 'Nguyen Huynh', 'Long', '1989-08-15', '111 Vo Van Ngan', '321654999616', 'P002', 'Nam', '0931681629', 'NV011@gmail.com', 'KT','Junior'),
						('NV006', 'Nguyen Tran', 'Duc', '1996-08-11', '111 Vo Van Ngan', '321654988611', 'P004', 'Nam', '0945681627', 'NV006@gmail.com', 'TPKD','Senior'),
						('NV012', 'Nguyen Tran', 'Hoang', '1996-08-11', '111 Vo Van Ngan', '321654568611', 'P004', 'Nam', '0947891627', 'NV012@gmail.com', 'NVKD','fresher'),
						('NV013', 'Nguyen Tran', 'Lam', '1996-08-11', '111 Vo Van Ngan', '32178968611', 'P004', 'Nam', '0948991627', 'NV012@gmail.com', 'NVCSKH','Junior'),
						('NV007', 'Nguyen Quang', 'Huy', '1985-10-13', '111 Vo Van Ngan', '321654988621', 'P005', 'Nam', '0945681624', 'NV007@gmail.com', 'TPKT','Senior'),
						('NV002', 'Nguyen Van', 'Luan', '1968-05-23', '111 Vo Van Ngan', '321654988613', 'P005', 'Nam', '0945681623', 'NV002@gmail.com', 'LTV','Junior'),
						('NV015', 'Nguyen Van', 'Nguyen', '1968-05-23', '111 Vo Van Ngan', '321654789613', 'P005', 'Nam', '0945576623', 'NV013@gmail.com', 'KS','Intership'),
						('NV014', 'Nguyen Van', 'Bang', '1968-05-23', '111 Vo Van Ngan', '321654789613', 'P005', 'Nam', '0945123623', 'NV014@gmail.com', 'KS','Intership')

Insert into NHANSU (MaNV,HovaTendem,Ten,NgaySinh,DiaChi,CCCD,GioiTinh,SDT,Email, MaCV) Values ('NV100', 'Cao Van', 'Hung', '1968-07-23', '111 Vo Van Ngan', '321654781213','Nam', '0987123623', 'NV100@gmail.com', 'GD')
GO

create table TAIKHOAN(
	taikhoan varchar(5) primary key,
	matkhau char(20),
	MaCV varchar(6)
)
go
insert into TAIKHOAN VALUES ('NV001','NV001','TD'),
							('NV002','NV002','LTV'),
							('NV003','NV003','TPNS'),
							('NV004','NV004','TPMT'),
							('NV005','NV005','TPTC'),
							('NV006','NV006','TPKD'),
							('NV007','NV007','TPKT'),
							('NV008','NV008','NVHC'),
							('NV009','NV009','NVTCSK'),
							('NV010','NV010','NVQC'),
							('NV011','NV011','KT'),
							('NV012','NV012','NVKD'),
							('NV013','NV013','NVCSKH'),
							('NV014','NV014','KS'),
							('NV015','NV015','KS'),
							('NV100','NV100','GD')
go

create table TIENLUONG (
	MaNV varchar(5),
	MaCV varchar(6),
	Thang int,
	Nam int,
	LuongCB numeric(18,2),
	LuongThuong numeric(18,2),
	LuongPhat numeric(18,2),
	LuongThucTe float
	primary key (MaNV,Thang, Nam)
)
go

--delete from TIENLUONG
--drop table TIENLUONG

----------------------------------------------------------
CREATE TABLE PHONGBAN(
	MaPB varchar(4) PRIMARY KEY,
	TenPB varchar(40) NULL,
	MaTP varchar(5) NULL
)
Go

Insert into PHONGBAN Values ('P001', 'Nhan su', 'NV003')
Insert into PHONGBAN Values ('P005', 'Ky thuat', 'NV007')
Insert into PHONGBAN Values ('P002', 'Tai chinh', 'NV005')
Insert into PHONGBAN Values ('P003', 'Marketing', 'NV004')
Insert into PHONGBAN Values ('P004', 'Kinh doanh', 'NV006')

GO
CREATE TABLE CHUCVU (
	MaCV VARCHAR(6) PRIMARY KEY,
	TenCV VARCHAR(40),
	HeSoLuong FLOAT(4) NULL
)
go
INSERT INTO CHUCVU VALUES
	('TPNS', 'Truong phong nhan su', '8.0'), 
	('TD', 'Tuyen dung', '4.4'),
	('NVHC', 'Nhan vien hanh chinh', '4.0'), 
	('TPKT', 'Truong phong ky thuat', '7.6'),
	('LTV', 'Lap trinh vien', '5.6'),
	('TPMT', 'Truong phong marketing', '7.4'),
	('NVTCSK', 'Nhan vien to chuc su kien', '4.6'),
	('NVQC', 'Nhan vien quang cao', '4.5'),
	('TPKD', 'Truong phong kinh doanh', '7.0'),
	('NVKD', 'Nhan vien kinh doanh', '4.6'),
	('NVCSKH', 'Nhan vien cham soc khach hang', '4.6'),
	('TPTC', 'Truong Phong tai chinh', '6.0'),
	('KT', 'Ke Toan', '4.8'),
	('KS', 'Ky Su', '5.0'),
	('GD', 'Giam doc', '10.5')
go

--delete from CHAMCONG
--drop table CHAMCONG

create table CHAMCONG(
	MaNV varchar(5),
	Thang int,
	Nam int,
	NgDilam int,
	SoNgNghiPhep int,
	primary key(MaNV, Thang, Nam)
);
go
--insert CHAMCONG values ('NV001', 1, 2022, 0),
--										('NV002', 1, 2022, 0),
--										('NV003', 1, 2022, 0),
--										('NV004', 1, 2022, 0),
--										('NV005', 1, 2022, 0),
--										('NV006', 1, 2022, 0),
--										('NV007', 1, 2022, 0),
--										('NV008', 1, 2022, 0),
--										('NV009', 1, 2022, 0),
--										('NV010', 1, 2022, 0),
--										('NV011', 1, 2022, 0),
--										('NV012', 1, 2022, 0),
--										('NV013', 1, 2022, 0),
--										('NV014', 1, 2022, 0),
--										('NV015', 1, 2022, 0)

--go


--delete from CHECKIN_OUT
--drop table CHECKIN_OUT

create table CHECKIN_OUT(
	MaNV varchar(5),
	Ngay date,
	CheckInSang bit,
	CheckOutChieu bit,
	LyDoNghi varchar(20),
	primary key(MaNV, Ngay)
);
go

create table DUAN (
	MaDA varchar(6) primary key,
	TenDA varchar(20),
	MaPB varchar(4),
	VonDH numeric(18,2),
	TruongDA varchar(5),
	NgayBD DATE,
	NgayKT DATE,
	TrangThai varchar(20),
	Tiendo int
)
go

insert into DUAN values
	('PdX', 'Product X', 'P002', 20000000, 'NV005', '2023-01-01', '2023-02-01', 'Finish', 0),
	('PdY', 'Product Y', 'P003', 21000000, 'NV004', '2023-02-09', '2023-05-10', 'Implement',0),
	('PdZ', 'Product Z', 'P001', 20000000, 'NV003', '2022-03-10', '2023-04-20', 'Plan',0),
	('PdT', 'Product T', 'P004', 21000000, 'NV006', '2023-03-12', '2023-05-12', 'Begin',0)
go


CREATE TABLE PHANCONGDUAN (
	MaDA varchar(6),
	MaNV varchar(5),
	CongViec varchar(20),
	NgayBD DATE,
	NgayKT DATE,
	TienDo INT,
	PRIMARY KEY(MaNV, NgayBD, NgayKT)
)
go
INSERT INTO PHANCONGDUAN values
('PdY', 'NV014','Dev' ,'2023-02-10', '2023-05-01', 20)
go

CREATE TABLE TRANGTHAINHANVIEN(
	MaNV varchar(5),
	TrinhDo varchar(30),
	TrangThai varchar(15),
	DanhGia INT,
	PRIMARY KEY(MaNV)
)
go

INSERT INTO TRANGTHAINHANVIEN VALUES 
('NV001','Junior', 'Ban', '7'),
('NV002','Junior', 'Ban', '7'),
('NV003','Senior', 'Ban', '10'),
('NV004','Senior', 'Ranh', '8'),
('NV005','Senior', 'Ranh', '9'),
('NV006','Senior', 'Ranh', '9'),
('NV007','Senior', 'Ranh', '9'),
('NV008','fresher', 'Ranh', '5'),
('NV009','fresher', 'Ranh', '5'),
('NV010','Intership', 'Ranh', '5'),
('NV011', 'Junior', 'Ranh', '5'),
('NV012','fresher', 'Ranh', '5'),
('NV013','Junior', 'Ranh', '5'),
('NV014', 'Intership', 'Ranh', '5'),
('NV015','Intership', 'Ranh', '5')
go

CREATE TABLE NGHIPHEP
(
	MANV VARCHAR(5) NOT NULL,
	NGAYNGHI DATE NOT NULL,
	LYDO VARCHAR(20) NOT NULL,
	PRIMARY KEY(MANV, NGAYNGHI)
)

alter table NHANSU with check add foreign key (MaPB) references PHONGBAN(MaPB);
alter table NHANSU with check add foreign key (MaCV) references CHUCVU(MaCV);
alter table TAIKHOAN with check add foreign key (taikhoan) references NHANSU(MaNV);
alter table TAIKHOAN with check add foreign key (MaCV) references CHUCVU(MaCV);
alter table TIENLUONG with check add foreign key (MaNV) references NHANSU(MaNV);
alter table TIENLUONG with check add foreign key (MaCV) references CHUCVU(MaCV);
alter table PHONGBAN with check add foreign key (MaTP) references NHANSU(MaNV);
alter table CHAMCONG with check add foreign key (MaNV) references NHANSU(MaNV);
alter table CHECKIN_OUT with check add foreign key (MaNV) references NHANSU(MaNV);
--alter table CHECKIN_OUT with check add foreign key (MaCV) references CHUCVU(MaCV);
alter table DUAN with check add foreign key (MaPB) references PHONGBAN(MaPB);
alter table DUAN with check add foreign key (TruongDA) references NHANSU(MaNV);
alter table PHANCONGDUAN with check add foreign key (MaDA) references DUAN(MaDA);
alter table PHANCONGDUAN with check add foreign key (MaNV) references NHANSU(MaNV);
alter table TRANGTHAINHANVIEN with check add foreign key (MaNV) references NHANSU(MaNV);
alter table NGHIPHEP with check add foreign key (MANV) references NHANSU(MaNV);
go

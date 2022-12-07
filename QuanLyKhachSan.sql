CREATE DATABASE QuanLyKhachSan;
GO
USE QuanLyKhachSan;
GO

CREATE TABLE LoaiPhong (
    maLoai CHAR(7) NOT NULL PRIMARY KEY,
    tenLoai NVARCHAR(200) NOT NULL,
    giaPhong MONEY NOT NULL
);
GO

INSERT INTO LoaiPhong VALUES
	('LP00001', N'Tiêu chuẩn', 300000),
	('LP00002', N'Cao cấp', 600000),
	('LP00003', N'Hạng sang', 1200000),
	('LP00004', N'Thượng hạng', 2400000);
GO

CREATE TABLE Phong (
    maPhong CHAR(7) NOT NULL PRIMARY KEY,
    tenPhong VARCHAR(7) NOT NULL,
    maLoai CHAR(7) NOT NULL,
    tinhTrang NVARCHAR(100) NULL DEFAULT N'Hoạt động',
    soKhachToiDa INT NOT NULL,
    CONSTRAINT fk_p_maloai FOREIGN KEY (maLoai) REFERENCES LoaiPhong (maLoai)
);
GO

INSERT INTO Phong VALUES
	('PH00001', 'S1', 'LP00004', N'Hoạt động', 2),
	('PH00002', 'S2', 'LP00004', N'Hoạt động', 1),
	('PH00003', 'A1', 'LP00003', N'Hoạt động', 3),
	('PH00004', 'A2', 'LP00003', N'Hoạt động', 2),
	('PH00005', 'B1', 'LP00002', N'Hoạt động', 4),
	('PH00006', 'B2', 'LP00002', N'Hoạt động', 3),
	('PH00007', 'C1', 'LP00001', N'Hoạt động', 5),
	('PH00008', 'C1', 'LP00001', N'Hoạt động', 4);
GO

CREATE TABLE ChucVu (
	maCV char(7) primary key,
	tenCV nvarchar(100) not null,
	moTa nvarchar(250) not null,
	tinhTrang nvarchar(50) not null
);
GO

insert into ChucVu values
	('CV00001', N'Quản lý', N'Quản lý là việc quản trị của một tổ chức, cho dù đó là một doanh nghiệp.', N'Đủ nhân viên'),
	('CV00002', N'Nhân viên lễ tân', N'Nhân viên lễ tân là người phụ trách quầy lễ tân, đón tiếp khách khi tới và rời khỏi khách sạn', N'Đủ nhân viên'),
	('CV00003', N'Nhân viên thu ngân', N'Nhân viên thu ngân quản lý tất cả thu chi trong các hoạt động kinh doanh của khách sạn', N'Thiếu nhân viên'),
	('CV00004', N'Nhân viên trực tổng đài', N'Nhân viên trực tổng đài là người tiếp nhận điện thoại và chuyển tới các bộ phận có liên quan để giải đáp, xử lý mọi vấn đề của khách hàng', N'Đủ nhân viên'),
	('CV00005', N'Nhân viên đặt phòng', N'Nhân viên đặt phòng là người chịu trách nhiệm xử lý các yêu cầu đặt phòng từ khách hàng, sắp xếp phòng cho khách, cập nhật thông tin mới nhất từ khách lên hệ thống, xác nhận với khách về yêu cầu đặt phòng đã được thực hiện', N'Đủ nhân viên'),
	('CV00006', N'Nhân viên hành lý', N'Nhân viên hành lý là người xách hành lý cho khách, dẫn khách lên phòng, hướng dẫn cho khách cách sử dụng các thiết bị trong phòng, các địa chỉ cần liên hệ trong khách sạn', N'Thiếu nhân viên'); 
GO

CREATE TABLE NhanVien (
    maNV CHAR(7) NOT NULL PRIMARY KEY,
    hoTen NVARCHAR(100) NOT NULL,
    diaChi NVARCHAR(150) NOT NULL,
    SDT VARCHAR(11) NOT NULL UNIQUE,
	canCuoc VARCHAR(12) NOT NULL UNIQUE,
    gioiTinh NVARCHAR(4) NOT NULL,
	matKhau VARCHAR(50) NULL,
	hoatDong INT NULL DEFAULT 1,
	mucLuong MONEY NULL,
	maCV char(7) foreign key references ChucVu(maCV)
);
GO

INSERT INTO NhanVien VALUES
	('NV00000', N'admin', N'admin', 'admin','admin', N'admi', 'admin', 1, 0,'CV00001'),
	('NV00001', N'Lê Anh Quốc', N'Thừa Thiên Huế', '0901962923','192187903', N'Nam', 'aquoc', 1, 20000000,'CV00001'),
	('NV00002', N'Ngô Hồng Phương Vy', N'Gia Lai', '0388121664', '046202009308', N'Nữ', 'pvy', 1, 21000000,'CV00001'),
	('NV00003', N'Hồ Quang Phúc', N'Đà Nẵng', '0332455684', '212589083', N'Nam', 'qphuc', 1, 10000000, 'CV00002'),
	('NV00004', N'Trần Đức Mạnh', N'Quảng Ngãi', '0941230357', '197417407', N'Nam', 'dmanh', 1, 250000000,'CV00003'),
	('NV00005', N'Trần Thị Kim Ngân', N'Quảng Nam', '0868991913', '44202004147', N'Nữ', 'kngan', 1, 40000000, 'CV00004'),
	('NV00006', N'Huỳnh Tấn Lực', N'Đà Nẵng', '0868721913', '93242004127', N'Nam', 'tluc', 1, 12000000, 'CV00005'),
	('NV00007', N'Lê Phan Hoàng Phúc', N'Đà Nẵng', '0828721912', '04242092747', N'Nam', 'hphuc', 1, 21500000, 'CV00006');
GO

CREATE TABLE HoaDon (
    maHD CHAR(7) NOT NULL PRIMARY KEY,
    maPhong CHAR(7) NOT NULL,
    maNV CHAR(7) NOT NULL,
    ngayBatDau DATE NOT NULL,
    ngayThanhToan DATE NOT NULL,
    giaPhong MONEY NOT NULL,
    tinhTrang NVARCHAR(200) NOT NULL,
    CONSTRAINT fk_hd_maphong FOREIGN KEY (maPhong) REFERENCES Phong (maPhong),
	CONSTRAINT fk_hd_manv FOREIGN KEY (maNV) REFERENCES NhanVien (maNV)
);
GO

INSERT INTO HoaDon VALUES
	('HD00001', 'PH00005', 'NV00001', '2022-11-28', '2022-12-01', '600000', N'Đã thanh toán'),
	('HD00002', 'PH00008', 'NV00002', '2022-11-15', '2022-12-02', '350000', N'Đã thanh toán'),
	('HD00003', 'PH00006', 'NV00005', '2022-11-25', '2022-12-03', '600000', N'Đã thanh toán'),
	('HD00004', 'PH00002', 'NV00003', '2022-11-30', '2022-12-05', '2400000', N'Đã thanh toán'),
	('HD00005', 'PH00007', 'NV00002', '2022-11-05', '2022-12-06', '300000', N'Đã thanh toán'),
	('HD00006', 'PH00001', 'NV00004', '2022-11-03', '2022-12-07', '120000',	N'Đã thanh toán'),
	('HD00007', 'PH00002','NV00001', '2022-12-06', '2022-12-07', '2400000', N'Đã thanh toán');
GO

CREATE TABLE KhachHang (
	maKH CHAR(7) NOT NULL PRIMARY KEY,
	hoTen NVARCHAR(100) NOT NULL,
	diaChi NVARCHAR(150) NOT NULL,
	SDT VARCHAR(11) NOT NULL UNIQUE,
	canCuoc VARCHAR(12) NOT NULL UNIQUE,
	gioiTinh NVARCHAR(4) NOT NULL
)
GO

INSERT INTO KhachHang VALUES
	('KH00001', N'Nguyễn Văn Phong', N'Tp. Hồ Chí Minh', '0338894202', '215572619', N'Nam'),
	('KH00002', N'Trần Đinh Sang', N'Hà Nội', '0342012065', '045202006194', N'Nam'),
	('KH00003', N'Văn Thị Nở', N'Tp. Hồ Chí Minh', '0912768911', '049202002636', N'Nữ'),
	('KH00004', N'Lê Văn Mạnh', N'Hải Dương', '0934972421', '206393041', N'Nam'),
	('KH00005', N'Đỗ Thị Như Như', N'Đồng Nai', '0935183250', '206468001', N'Nữ');
GO

CREATE TABLE ChiTietHoaDon (
	maHD CHAR(7) NOT NULL,
	maKH CHAR(7) NOT NULL,
	CONSTRAINT fk_cthd_mahd FOREIGN KEY (maHD) REFERENCES HoaDon (maHD),
	CONSTRAINT fk_cthd_makh FOREIGN KEY (maKH) REFERENCES KhachHang (maKH)
)
GO

INSERT INTO ChiTietHoaDon VALUES
	('HD00001', 'KH00001'),
	('HD00001', 'KH00002'),
	('HD00002', 'KH00003'),
	('HD00002', 'KH00004'),
	('HD00003', 'KH00005');
GO

create table PhanQuyen (
	maQuyen char(7) primary key,
	tenQuyen nvarchar(50),
);
GO

insert into PhanQuyen values
('PQ00001', N'Quản trị viên'),
('PQ00002', N'Nhân viên');
GO

create table ChiTietQuyen (
	maQuyen char(7),
	maCV char(7),
	primary key(MaQuyen, MaCV),
	CONSTRAINT fk_ctq_maquyen FOREIGN KEY (maQuyen) REFERENCES PhanQuyen (maQuyen),
	CONSTRAINT fk_ctq_macv FOREIGN KEY (maCV) REFERENCES ChucVu (maCV)
);
GO

insert into ChiTietQuyen values
('PQ00001','CV00001'),
('PQ00002','CV00002'),
('PQ00002','CV00003'),
('PQ00002','CV00004'),
('PQ00002','CV00005'),
('PQ00002','CV00006');

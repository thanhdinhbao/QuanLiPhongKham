create database PMBST
go
USE PMBST
GO


CREATE TABLE BENHNHAN(
	MaBenhNhan nvarchar(10) NOT NULL PRIMARY KEY,
	HoTen nvarchar(30) NULL,
	GioiTinh nvarchar(4) NULL,
	NamSinh int NULL,
	DiaChi nvarchar(50) NULL,
	SoDienThoai nvarchar(20) NULL,
	CMND nvarchar(20) NULL,

) 
GO


CREATE TABLE CACHDUNG(
	MaLoaiCachDung nvarchar(5) NOT NULL PRIMARY KEY,
	TenLoaiCachDung nvarchar(30) NULL,
)
GO


CREATE TABLE CT_DSKB(
	MaCTDSKB nvarchar(10) NOT NULL PRIMARY KEY,
	MaDSKB nvarchar(10) NULL,
	MaBenhNhan nvarchar(10) NULL,
) 
GO


CREATE TABLE DANHSACHKHAMBENH(
	MaDSKB nvarchar(10) NOT NULL PRIMARY KEY,
	NgayKhamBenh smalldatetime NULL,
) 
GO


CREATE TABLE DONTHUOC(
	MaDT nvarchar(10) NOT NULL  PRIMARY KEY,
	MaPK nvarchar(10) NULL,
	MaLoaiThuoc nvarchar(5) NULL,
	SoLuong int NULL,
) 
GO



CREATE TABLE HOADON(
	MaHoaDon nvarchar(10) NOT NULL PRIMARY KEY,
	MaPK nvarchar(10) NULL,
	TienKham int NULL,
	TienThuoc int NULL,
) 
GO


CREATE TABLE LOAIBENH(
	MaLoaiBenh nvarchar(5) NOT NULL PRIMARY KEY,
	TenLoaiBenh nvarchar(30) NULL,
) 
GO

CREATE TABLE LOAIDONVI(
	MaLoaiDonVi nvarchar(5) NOT NULL PRIMARY KEY,
	TenLoaiDonVi nvarchar(10) NULL,

) 
Go



CREATE TABLE LOAITHUOC(
	MaLoaiThuoc nvarchar(5) NOT NULL PRIMARY KEY,
	TenLoaiThuoc nvarchar(30) NULL,
	MaLoaiDonVi nvarchar(5) NULL,
	MaLoaiCachDung nvarchar(5) NULL,
	DonGia int NULL,
) 
Go


CREATE TABLE PHIEUKHAM(
	MaPK nvarchar(10) NOT NULL PRIMARY KEY,
	MaCTDSKB nvarchar(10) NULL,
	TrieuChung nvarchar(50) NULL,
	MaLoaiBenh nvarchar(5) NULL,
) 
Go

CREATE TABLE TAIKHOAN(
	TenTaiKhoan nvarchar(30) NOT NULL PRIMARY KEY,
	TenHienThi nvarchar(30) NULL,
	ChucVu nvarchar(20) NULL,
	Quyen int NULL,
	MatKhau nvarchar(64) NULL
	) 
Go


CREATE TABLE THAMSO(
	MaThamSo nvarchar(5) NOT NULL PRIMARY KEY,
	TenThamSo nvarchar(30) NULL,
	TriGiaThamSo int NULL,

		) 
Go

INSERT BENHNHAN (MaBenhNhan, HoTen, GioiTinh, NamSinh, DiaChi, SoDienThoai, CMND) VALUES (N'BN0000001', N'Nguyễn Lê Trường Vũ', N'Nam', 2003, N'Châu Thành', N'034567895', N'2215689785')
INSERT BENHNHAN (MaBenhNhan, HoTen, GioiTinh, NamSinh, DiaChi, SoDienThoai, CMND) VALUES (N'BN0000002', N'Nguyễn Thị Tú Minh', N'Nữ', 2003, N'Long Xuyên', N'034567777', N'2215689555')
INSERT BENHNHAN (MaBenhNhan, HoTen, GioiTinh, NamSinh, DiaChi, SoDienThoai, CMND) VALUES (N'BN0000003', N'Trần Văn Trọng', N'Nam', 2002, N' Chợ Mới', N'0903862104', N'026011104')
GO
INSERT CACHDUNG (MaLoaiCachDung, TenLoaiCachDung) VALUES (N'CD01', N'1-Uống sau khi ăn')
INSERT CACHDUNG (MaLoaiCachDung, TenLoaiCachDung)  VALUES (N'CD02', N'2-Nhai')
INSERT CACHDUNG (MaLoaiCachDung, TenLoaiCachDung)  VALUES (N'CD03', N'3-Pha với nước')
INSERT CACHDUNG (MaLoaiCachDung, TenLoaiCachDung)  VALUES (N'CD04', N'4-Cà nhuyễn ')
GO
INSERT CT_DSKB (MaCTDSKB, MaDSKB, MaBenhNhan) VALUES (N'CT0000001', N'DS20240605', N'BN0000001')
INSERT CT_DSKB (MaCTDSKB, MaDSKB, MaBenhNhan) VALUES (N'CT0000002', N'DS20240425', N'BN0000001')
INSERT CT_DSKB (MaCTDSKB, MaDSKB, MaBenhNhan) VALUES (N'CT0000003', N'DS20240425', N'BN0000003')
INSERT CT_DSKB (MaCTDSKB, MaDSKB, MaBenhNhan) VALUES (N'CT0000004', N'DS20240102', N'BN0000001')
GO
INSERT DANHSACHKHAMBENH (MaDSKB, NgayKhamBenh) VALUES (N'DS20240605', CAST(N'2024-06-05T00:00:00' AS SmallDateTime))
INSERT DANHSACHKHAMBENH (MaDSKB, NgayKhamBenh) VALUES (N'DS20240425', CAST(N'2024-04-25T00:00:00' AS SmallDateTime))
INSERT DANHSACHKHAMBENH (MaDSKB, NgayKhamBenh) VALUES (N'DS20240102', CAST(N'2024-01-02T00:00:00' AS SmallDateTime))
GO
INSERT DONTHUOC (MaDT, MaPK, MaLoaiThuoc, SoLuong) VALUES (N'DT00000001', N'PK0000001', N'LT01', 5)
INSERT DONTHUOC (MaDT, MaPK, MaLoaiThuoc, SoLuong) VALUES (N'DT00000002', N'PK0000001', N'LT10', 10)
INSERT DONTHUOC (MaDT, MaPK, MaLoaiThuoc, SoLuong) VALUES (N'DT00000003', N'PK0000002', N'LT02', 3)
INSERT DONTHUOC (MaDT, MaPK, MaLoaiThuoc, SoLuong) VALUES (N'DT00000005', N'PK0000002', N'LT05', 3)
INSERT DONTHUOC (MaDT, MaPK, MaLoaiThuoc, SoLuong) VALUES (N'DT00000008', N'PK0000002', N'LT07', 3)
INSERT DONTHUOC (MaDT, MaPK, MaLoaiThuoc, SoLuong) VALUES (N'DT00000009', N'PK0000003', N'LT04', 2)
INSERT DONTHUOC (MaDT, MaPK, MaLoaiThuoc, SoLuong) VALUES (N'DT00000011', N'PK0000003', N'LT08', 2)
INSERT DONTHUOC (MaDT, MaPK, MaLoaiThuoc, SoLuong) VALUES (N'DT00000012', N'PK0000004', N'LT06', 1)
GO
INSERT HOADON (MaHoaDon, MaPK, TienKham, TienThuoc) VALUES (N'HD00000001', N'PK0000001', 30000, 25000)
INSERT HOADON (MaHoaDon, MaPK, TienKham, TienThuoc) VALUES (N'HD00000002', N'PK0000002', 30000, 13500)
INSERT HOADON (MaHoaDon, MaPK, TienKham, TienThuoc) VALUES (N'HD00000003', N'PK0000003', 30000, 6000)
INSERT HOADON (MaHoaDon, MaPK, TienKham, TienThuoc) VALUES (N'HD00000004', N'PK0000004', 30000, 2000)
GO
INSERT LOAIBENH (MaLoaiBenh, TenLoaiBenh) VALUES (N'LB01', N'Ho')
INSERT LOAIBENH (MaLoaiBenh, TenLoaiBenh) VALUES (N'LB02', N'Viêm họng')
INSERT LOAIBENH (MaLoaiBenh, TenLoaiBenh) VALUES (N'LB03', N'Cảm')
INSERT LOAIBENH (MaLoaiBenh, TenLoaiBenh) VALUES (N'LB04', N'Sốt')
INSERT LOAIBENH (MaLoaiBenh, TenLoaiBenh) VALUES (N'LB05', N'Nhức đầu')
GO
INSERT LOAIDONVI (MaLoaiDonVi, TenLoaiDonVi) VALUES (N'DV01', N'viên')
INSERT LOAIDONVI (MaLoaiDonVi, TenLoaiDonVi) VALUES (N'DV02', N'chai')
GO
INSERT  LOAITHUOC (MaLoaiThuoc, TenLoaiThuoc, MaLoaiDonVi, MaLoaiCachDung, DonGia) VALUES (N'LT01', N'Paracetamon', N'DV01', N'CD01', 2000)
INSERT  LOAITHUOC (MaLoaiThuoc, TenLoaiThuoc, MaLoaiDonVi, MaLoaiCachDung, DonGia) VALUES (N'LT02', N'TataMon', N'DV01', N'CD02', 3000)
INSERT  LOAITHUOC (MaLoaiThuoc, TenLoaiThuoc, MaLoaiDonVi, MaLoaiCachDung, DonGia) VALUES (N'LT03', N'Citeron', N'DV02', N'CD01', 1500)
INSERT  LOAITHUOC (MaLoaiThuoc, TenLoaiThuoc, MaLoaiDonVi, MaLoaiCachDung, DonGia) VALUES (N'LT04', N'Pastra', N'DV02', N'CD03', 1000)
INSERT  LOAITHUOC (MaLoaiThuoc, TenLoaiThuoc, MaLoaiDonVi, MaLoaiCachDung, DonGia) VALUES (N'LT05', N'Halothane', N'DV02', N'CD01', 2000)
INSERT  LOAITHUOC (MaLoaiThuoc, TenLoaiThuoc, MaLoaiDonVi, MaLoaiCachDung, DonGia) VALUES (N'LT06', N'Isoflurane', N'DV01', N'CD02', 2000)
INSERT  LOAITHUOC (MaLoaiThuoc, TenLoaiThuoc, MaLoaiDonVi, MaLoaiCachDung, DonGia) VALUES (N'LT07', N'Propofol', N'DV01', N'CD03', 1500)
INSERT  LOAITHUOC (MaLoaiThuoc, TenLoaiThuoc, MaLoaiDonVi, MaLoaiCachDung, DonGia) VALUES (N'LT08', N'Codeine', N'DV01', N'CD01', 1000)
INSERT  LOAITHUOC (MaLoaiThuoc, TenLoaiThuoc, MaLoaiDonVi, MaLoaiCachDung, DonGia) VALUES (N'LT09', N'Fentanyl', N'DV02', N'CD03', 2000)
INSERT  LOAITHUOC (MaLoaiThuoc, TenLoaiThuoc, MaLoaiDonVi, MaLoaiCachDung, DonGia) VALUES (N'LT10', N'Morphine', N'DV02', N'CD04', 1000)

GO
INSERT PHIEUKHAM (MaPK,MaCTDSKB, TrieuChung, MaLoaiBenh) VALUES (N'PK0000001', N'CT0000001', N'Ho dai dẳng', N'LB01')
INSERT PHIEUKHAM (MaPK,MaCTDSKB, TrieuChung, MaLoaiBenh) VALUES (N'PK0000002', N'CT0000002', N'Ho dữ dội', N'LB01')
INSERT PHIEUKHAM (MaPK,MaCTDSKB, TrieuChung, MaLoaiBenh) VALUES (N'PK0000003', N'CT0000003', N'Đau rát họng', N'LB02')
INSERT PHIEUKHAM (MaPK,MaCTDSKB, TrieuChung, MaLoaiBenh) VALUES (N'PK0000004', N'CT0000004', N'Ho', N'LB01')
GO

INSERT TAIKHOAN (TenTaiKhoan, TenHienThi, ChucVu, Quyen, MatKhau) VALUES (N'admin', N'TTTL', N'Quản trị viên', 123456, N'Thanhhuy2021')
INSERT TAIKHOAN (TenTaiKhoan, TenHienThi, ChucVu, Quyen, MatKhau) VALUES (N'tk1', N'Nguyễn Thị Thu Hằng', N'Tiếp tân', 2, N'Thanhhuy2022')
INSERT TAIKHOAN (TenTaiKhoan, TenHienThi, ChucVu, Quyen, MatKhau) VALUES (N'tk2', N'Nguyễn Tư Bắc', N'Bác sĩ', 34, N'Thanhhuy2023')
INSERT TAIKHOAN (TenTaiKhoan, TenHienThi, ChucVu, Quyen, MatKhau) VALUES (N'tk3', N'Lê Thị Diễm', N'Thu Ngân', 56, N'Thanhhuy2024')
GO
INSERT THAMSO (MaThamSo, TenThamSo, TriGiaThamSo) VALUES (N'TS01', N'SoBenhNhanToiDa', 2)
INSERT THAMSO (MaThamSo, TenThamSo, TriGiaThamSo) VALUES (N'TS02', N'TienKham', 30000)
GO
ALTER TABLE CT_DSKB    ADD FOREIGN KEY(MaBenhNhan)
REFERENCES BENHNHAN (MaBenhNhan)
ON DELETE CASCADE
GO
ALTER TABLE CT_DSKB  ADD FOREIGN KEY(MaDSKB)
REFERENCES DANHSACHKHAMBENH (MaDSKB)
GO
ALTER TABLE DONTHUOC   ADD FOREIGN KEY(MaLoaiThuoc)
REFERENCES LOAITHUOC (MaLoaiThuoc)
GO
ALTER TABLE DONTHUOC   ADD FOREIGN KEY(MaPK)
REFERENCES PHIEUKHAM (MaPK)
ON DELETE CASCADE -- một hàng trong bảng "PHIEUKHAM" được xóa, tất cả các hàng tương ứng trong bảng "DONTTHUOC" cũng sẽ bị xóa tự động
GO
ALTER TABLE HOADON  WITH CHECK ADD FOREIGN KEY(MaPK)
REFERENCES PHIEUKHAM ([MaPK])
ON DELETE CASCADE
GO
ALTER TABLE LOAITHUOC   ADD FOREIGN KEY(MaLoaiDonVi)
REFERENCES LOAIDONVI (MaLoaiDonVi)
GO
ALTER TABLE LOAITHUOC  ADD FOREIGN KEY(MaLoaiCachDung)
REFERENCES CACHDUNG (MaLoaiCachDung)
GO
ALTER TABLE PHIEUKHAM  ADD FOREIGN KEY(MaCTDSKB)
REFERENCES CT_DSKB (MaCTDSKB)
ON DELETE CASCADE
GO
ALTER TABLE PHIEUKHAM  ADD FOREIGN KEY (MaLoaiBenh)
REFERENCES LOAIBENH (MaLoaiBenh)
GO


create procedure BaoCaoDoanhThu --exec BaoCaoDoanhThu @thang='6', @nam='2019'
@thang int,
@nam int
as
begin
select CAST(day(DANHSACHKHAMBENH.NgayKhamBenh) AS nvarchar)+'/'+CAST(month(DANHSACHKHAMBENH.NgayKhamBenh) AS nvarchar)+'/'+CAST(year(DANHSACHKHAMBENH.NgayKhamBenh) AS nvarchar) as Ngay,
	count(PHIEUKHAM.MaPK) as SoBenhNhan,
	sum(TienKham)+sum(TienThuoc) as DoanhThu
from CT_DSKB 
inner join PHIEUKHAM on CT_DSKB.MaCTDSKB=PHIEUKHAM.MaCTDSKB
inner join HOADON on HOADON.MaPK=PHIEUKHAM.MaPK
inner join DANHSACHKHAMBENH on DANHSACHKHAMBENH.MaDSKB=CT_DSKB.MaDSKB
where Month(NgayKhamBenh)=@thang and year(NgayKhamBenh)=@nam
group by DANHSACHKHAMBENH.NgayKhamBenh
end
GO



create procedure GetDanhSachKhamBenh
@ngayKhamBenh smalldatetime
as
begin
select BENHNHAN.MaBenhNhan,HoTen,GioiTinh,NamSinh,DiaChi, SoDienThoai,CMND 
from BENHNHAN inner join CT_DSKB on BENHNHAN.MaBenhNhan=CT_DSKB.MaBenhNhan
inner join DANHSACHKHAMBENH on DANHSACHKHAMBENH.MaDSKB=CT_DSKB.MaDSKB
where DANHSACHKHAMBENH.NgayKhamBenh=@ngayKhamBenh
end
GO


create procedure GetThongTinVeThuoc --exec GetThongTinVeThuoc
as
begin
select MaLoaiThuoc,TenLoaiThuoc, TenLoaiDonVi, TenLoaiCachDung, DonGia 
from LOAITHUOC inner join LOAIDONVI on LOAIDONVI.MaLoaiDonVi=LOAITHUOC.MaLoaiDonVi
inner join CACHDUNG on CACHDUNG.MaLoaiCachDung=LOAITHUOC.MaLoaiCachDung
end
GO




create procedure KiemTraBenhNhanCoTrongDanhSach --exec KiemTraBenhNhanCoTrongDanhSach @maBenhNhan='BN0000001', @maDSKB='DS20240605'
@maBenhNhan nvarchar(10),
@maDSKB nvarchar(10)
as
begin
select MaCTDSKB from CT_DSKB
where MaBenhNhan=@maBenhNhan and MaDSKB=@maDSKB
end
GO


create procedure LayThongTinDonThuoc --exec LayThongTinDonThuoc @MaPK='PK0000002'
@MaPK nvarchar(10)
as
begin
select TenLoaiThuoc, SoLuong, TenLoaiDonVi, TenLoaiCachDung
from DONTHUOC inner join LOAITHUOC on DONTHUOC.MaLoaiThuoc=LOAITHUOC.MaLoaiThuoc
inner join LOAIDONVI on LOAIDONVI.MaLoaiDonVi=LOAITHUOC.MaLoaiDonVi
inner join CACHDUNG on CACHDUNG.MaLoaiCachDung=LOAITHUOC.MaLoaiCachDung
where MaPK=@MaPK
end
GO





create procedure LayThongTinHoaDon --exec LayThongTinHoaDon @MaPK='PK0000013'
@MaPK nvarchar(10)
as
begin
select PHIEUKHAM.MaPK, BENHNHAN.MaBenhNhan, HoTen, MaHoaDon, TienKham, TienThuoc, MaDSKB
from PHIEUKHAM inner join CT_DSKB on CT_DSKB.MaCTDSKB=PHIEUKHAM.MaCTDSKB
inner join BENHNHAN on BENHNHAN.MaBenhNhan=CT_DSKB.MaBenhNhan
inner join HOADON on HOADON.MaPK= PHIEUKHAM.MaPK
where PHIEUKHAM.MaPK like @MaPK
end
GO




create procedure LayThongTinTienThuoc --exec LayThongTinTienThuoc @MaPK='PK0000002'
@MaPK nvarchar(10)
as
begin
select TenLoaiThuoc, SoLuong, TenLoaiDonVi, DonGia*SoLuong as ThanhTien
from DONTHUOC inner join LOAITHUOC on DONTHUOC.MaLoaiThuoc=LOAITHUOC.MaLoaiThuoc
inner join LOAIDONVI on LOAIDONVI.MaLoaiDonVi=LOAITHUOC.MaLoaiDonVi
inner join CACHDUNG on CACHDUNG.MaLoaiCachDung=LOAITHUOC.MaLoaiCachDung
where MaPK=@MaPK
end
GO


create procedure ThongKeSuDungThuoc --exec ThongKeSuDungThuoc @thang='6', @nam='2024'
@thang int,
@nam int
as
begin
select A.MaLoaiThuoc, TenLoaiThuoc, TenLoaiDonVi, A.SoLuongBan, A.SoLanDung
from
(
	select DONTHUOC.MaLoaiThuoc, sum(SoLuong) as SoLuongBan, count(DONTHUOC.MaPK) as SoLanDung
	from DONTHUOC inner join PHIEUKHAM on DONTHUOC.MaPK=PHIEUKHAM.MaPK
	inner join CT_DSKB on CT_DSKB.MaCTDSKB=PHIEUKHAM.MaCTDSKB
	inner join DANHSACHKHAMBENH on DANHSACHKHAMBENH.MaDSKB=CT_DSKB.MaDSKB
	where month(NgayKhamBenh)=@thang and year(NgayKhamBenh)=@nam
	group by DONTHUOC.MaLoaiThuoc
)A inner join LOAITHUOC on A.MaLoaiThuoc=LOAITHUOC.MaLoaiThuoc
inner join LOAIDONVI on LOAIDONVI.MaLoaiDonVi=LOAITHUOC.MaLoaiDonVi
end
GO



create procedure TimBenhNhan --exec TimBenhNhan @maBN='', @hoTen='', @cmnd='', @gioiTinh='', @namSinh='2003', @sdt='', @diaChi=''
@maBN nvarchar(10), 
@hoTen nvarchar(30), 
@cmnd nvarchar(20), 
@gioiTinh nvarchar(4), 
@namSinh nvarchar(4), 
@sdt nvarchar(20), 
@diaChi nvarchar(50)
as
begin
select * from BENHNHAN 
where
MaBenhNhan like '%'+@maBN +'%' and
HoTen like '%'+@hoTen +'%' and
CMND like '%'+@cmnd +'%' and
GioiTinh like '%'+@gioiTinh +'%' and
NamSinh like '%'+@namSinh +'%' and
SoDienThoai like '%'+@sdt +'%' and
DiaChi like '%'+@diaChi +'%'
end
GO


create procedure TimKiemThuoc --exec TimKiemThuoc @maLoaiThuoc='', @tenLoaiThuoc='', @tenLoaiDonVi='', @tenLoaiCachDung='', @donGia=''
@maLoaiThuoc nvarchar(5),
@tenLoaiThuoc nvarchar(30),
@tenLoaiDonVi nvarchar(10),
@tenLoaiCachDung nvarchar(30),
@donGia nvarchar(20)
as
begin
select MaLoaiThuoc,TenLoaiThuoc, TenLoaiDonVi, TenLoaiCachDung, DonGia 
from LOAITHUOC inner join LOAIDONVI on LOAIDONVI.MaLoaiDonVi=LOAITHUOC.MaLoaiDonVi
inner join CACHDUNG on CACHDUNG.MaLoaiCachDung=LOAITHUOC.MaLoaiCachDung
where MaLoaiThuoc like @maLoaiThuoc+'%' 
and TenLoaiThuoc like @tenLoaiThuoc+'%'
and TenLoaiDonVi like @tenLoaiDonVi+'%'
and TenLoaiCachDung like @tenLoaiCachDung+'%'
and DonGia like @donGia+'%'
end
GO



--exec TraCuuDanhSachBenhNhanKhamBenh @maPK='',@maBenhNhan='', @tenBenhNhan=N'Nguyễn Thị', @MaDSKB_NgayKham='', @cmnd='', @sdt=''

create procedure TraCuuDanhSachBenhNhanKhamBenh 
@maPK nvarchar(10),
@maBenhNhan nvarchar(10),
@tenBenhNhan nvarchar(30),
@MaDSKB_NgayKham nvarchar(10),
@cmnd nvarchar(20),
@sdt nvarchar(20)
as
begin
select top 50 MaPK, BENHNHAN.MaBenhNhan, HoTen,NgayKhamBenh, TenLoaiBenh, TrieuChung 
from BENHNHAN inner join CT_DSKB on BENHNHAN.MaBenhNhan=CT_DSKB.MaBenhNhan
inner join DANHSACHKHAMBENH on DANHSACHKHAMBENH.MaDSKB=CT_DSKB.MaDSKB
inner join PHIEUKHAM on PHIEUKHAM.MaCTDSKB=CT_DSKB.MaCTDSKB
inner join LOAIBENH on LOAIBENH.MaLoaiBenh= PHIEUKHAM.MaLoaiBenh
where MaPK like @maPK+'%' 
and BENHNHAN.MaBenhNhan like '%'+@maBenhNhan+'%'
and HoTen like '%'+@tenBenhNhan+'%'
and CT_DSKB.MaDSKB like '%'+@MaDSKB_NgayKham+'%'
and BENHNHAN.CMND like @cmnd+'%'
and BENHNHAN.SoDienThoai like @sdt+'%'
end
GO

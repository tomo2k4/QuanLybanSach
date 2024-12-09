--1. Bảng người dùng
CREATE TABLE tbl_user (
    id_user INT PRIMARY KEY NOT NULL IDENTITY(1,1), -- Khóa chính tự tăng
    username VARCHAR(50) NOT NULL UNIQUE, -- Tài khoản phải duy nhất và không được để trống
    password VARCHAR(50) NOT NULL, -- Mật khẩu đã mã hóa, không được để trống
    typeuser VARCHAR(20) NOT NULL -- Loại người dùng (ví dụ: 'admin' hoặc 'user')
);

--2. Bảng Thể loại
CREATE TABLE tbl_theloai(
	id_theloai INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	tentheloai NVARCHAR(200)
);

--3. Bảng Tác giả
CREATE TABLE tbl_tacgia(
	id_tacgia INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	tentacgia NVARCHAR(200),
	linhvuc NVARCHAR(MAX),
	gioithieu NTEXT
);

--4. Bảng Sách
CREATE TABLE tbl_sach(
	id_sach INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	tensach NVARCHAR(200),
	id_tacgia INT,
	FOREIGN KEY (id_tacgia) REFERENCES tbl_tacgia(id_tacgia),
	id_theloai INT,
	FOREIGN KEY (id_theloai) REFERENCES tbl_theloai(id_theloai),
	nhaxuatban NVARCHAR(100), 
	giasach MONEY,
	soluong INT,
	ngaynhan DATETIME,
	trangthai NTEXT,
	anhsach IMAGE
);

--5. Bảng thanhvien
CREATE TABLE tbl_thanhvien (
    id_thanhvien INT PRIMARY KEY NOT NULL IDENTITY(1,1), -- Khóa chính tự tăng
    hoten NVARCHAR(200) NOT NULL, -- Họ tên bắt buộc
    email VARCHAR(100), -- Email không bắt buộc
    sodt VARCHAR(20) NOT NULL UNIQUE, -- Số điện thoại phải duy nhất và không được để trống
    gioitinh NVARCHAR(20), -- Giới tính
	anhhoso IMAGE,
    id_user INT, -- Khóa ngoại liên kết với bảng tbl_NguoiDung
    CONSTRAINT fk_nguoidung FOREIGN KEY (id_user) REFERENCES tbl_NguoiDung(id_user) ON DELETE CASCADE
);

--6. Bảng Hoa Don Mua
CREATE TABLE tbl_Hoadon(
	idBiller INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	id_sach INT ,
	FOREIGN KEY (id_sach) REFERENCES tbl_sach(id_sach),
	tensach NVARCHAR(200),
	id_docgia INT,
	FOREIGN KEY (id_docgia) REFERENCES tbl_docgia(id_docgia),
	hoten NVARCHAR(200) NOT NULL,
	ngaymua DATETIME
);

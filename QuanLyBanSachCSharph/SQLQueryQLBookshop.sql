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
    id_user INT, -- Khóa ngoại liên kết với bảng tbl_user
    CONSTRAINT fk_nguoidung FOREIGN KEY (id_user) REFERENCES tbl_user(id_user) ON DELETE CASCADE
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

--7. Bảng Độc Giả
CREATE TABLE tbl_docgia (
    id_docgia INT PRIMARY KEY NOT NULL IDENTITY(1,1), -- Khóa chính tự tăng
    tendocgia NVARCHAR(200) NOT NULL, -- Tên độc giả, bắt buộc
	sodt VARCHAR(20) NOT NULL UNIQUE,
    email VARCHAR(100), -- Email, không bắt buộc
    gioitinh NVARCHAR(20), -- Giới tính
    tongtienthanhtoan MONEY DEFAULT 0 -- Tổng tiền thanh toán, mặc định là 0
);


-- 2. Bảng Thể Loại Sách
INSERT INTO tbl_theloai (tentheloai) 
VALUES (N'Văn học'),
	   (N'Thơ'),
	   (N'Truyện Tranh'), 
       (N'Ẩm thực'), 
	   (N'Cổ tích'), 
	   (N'Công nghệ thông tin'), 
	   (N'Kỹ năng sống'), 
	   (N'Kinh Tế'), 
	   (N'Trẻ Em'), 
	   (N'Trinh Thám'), 
	   (N'Kinh dị'), 
	   (N'Khám Phá Thế Giới');


--3. Bảng Tác giả
INSERT INTO tbl_tacgia (tentacgia, linhvuc, gioithieu) 
VALUES (N'Nam Cao', N'Văn học', N'Tác giả nổi tiếng với các tác phẩm phản ánh xã hội Việt Nam trước cách mạng'),
	   (N'Tố Hữu', N'Thơ ca', N'Nhà thơ nổi tiếng với các bài thơ cách mạng và kháng chiến'), 
	   (N' Louie Stowell', N'Hài hước', N'Nổi tiếng với các cuốn sách hài hước dành cho trẻ em, đặc biệt là về vị thần Bắc Âu, Loki'),
	   (N'Rosie Nguyễn (Nguyễn Hoàng Nguyên)', N'Hài kịch', N'Nhà văn, một travel blogger và làm giảng viên của một lớp học kĩ năng và yoga'),
	   (N'Dale Carnegie',N'Nhà văn và giảng viên', N' nhà văn và giảng viên người Mỹ nổi tiếng với các cuốn sách về cải thiện bản thân, giao tiếp công cộng và kỹ năng xã hội'),
	   (N'Nguyễn Nhật Ánh', N'Nhà văn',N'nhà văn nổi tiếng của Việt Nam, chuyên viết các tác phẩm văn học thiếu nhi và thanh thiếu niên' );

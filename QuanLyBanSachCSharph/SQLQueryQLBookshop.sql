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
	trangthai NVARCHAR(20),
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

-- 1. Bảng tbl_user
INSERT INTO tbl_user (username, password, typeuser) VALUES
('user1', 'password1', 'admin'),
('user2', 'password2', 'user'),
('user3', 'password3', 'admin'),
('user4', 'password4', 'user'),
('user5', 'password5', 'admin'),
('user6', 'password6', 'user'),
('user7', 'password7', 'admin'),
('user8', 'password8', 'user'),
('user9', 'password9', 'admin'),
('user10', 'password10', 'user'),
('user11', 'password11', 'admin'),
('user12', 'password12', 'user'),
('user13', 'password13', 'admin'),
('user14', 'password14', 'user'),
('user15', 'password15', 'admin'),
('user16', 'password16', 'user'),
('user17', 'password17', 'admin'),
('user18', 'password18', 'user'),
('user19', 'password19', 'admin'),
('user20', 'password20', 'user');
GO

-- 2. Bảng tbl_theloai
INSERT INTO tbl_theloai (tentheloai) VALUES
(N'Tiểu thuyết'),
(N'Truyện ngắn'),
(N'Truyện tranh'),
(N'Khoa học viễn tưởng'),
(N'Tâm lý học'),
(N'Kinh tế'),
(N'Lịch sử'),
(N'Triết học'),
(N'Văn học nước ngoài'),
(N'Văn học Việt Nam'),
(N'Tự truyện'),
(N'Học tập'),
(N'Tôn giáo'),
(N'Chính trị'),
(N'Khoa học tự nhiên'),
(N'Sức khỏe'),
(N'Gia đình'),
(N'Nghệ thuật'),
(N'Âm nhạc'),
(N'Thể thao');
GO

-- 3. Bảng tbl_tacgia
INSERT INTO tbl_tacgia (tentacgia, linhvuc, gioithieu) VALUES
(N'Nguyễn Nhật Ánh', N'Văn học', N'Nhà văn nổi tiếng của Việt Nam.'),
(N'J.K. Rowling', N'Truyện tranh', N'Tác giả của Harry Potter.'),
(N'Haruki Murakami', N'Tiểu thuyết', N'Nhà văn người Nhật.'),
(N'George Orwell', N'Tâm lý học', N'Tác giả của Animal Farm và 1984.'),
(N'Paulo Coelho', N'Tiểu thuyết', N'Nhà văn Brazil.'),
(N'Leo Tolstoy', N'Kinh điển', N'Tác giả chiến tranh và hòa bình.'),
(N'Chimamanda Ngozi Adichie', N'Văn học phi thường', N'Nhà văn Nigeria nổi bật.'),
(N'Yuval Noah Harari', N'Lịch sử', N'Tác giả Sapiens.'),
(N'Adam Grant', N'Kinh doanh', N'Tác giả người Do Thái.'),
(N'Malcolm Gladwell', N'Tâm lý học xã hội', N'Tác giả Blink.'),
(N'Margaret Atwood', N'Viễn tưởng', N'Tác giả của Câu chuyện hầu gái.'),
(N'Kazuo Ishiguro', N'Tiểu thuyết', N'Tác giả giành giải Nobel.'),
(N'Nguyễn Huy Thiệp', N'Văn học', N'Tác giả nổi tiếng Việt.'),
(N'Khaled Hosseini', N'Tiểu thuyết', N'Tác giả của Kite Runner.'),
(N'Stephen King', N'Kinh dị', N'Ông vua của kinh dị.'),
(N'Dan Brown', N'Tiểu thuyết', N'Tác giả của Mật mã Da Vinci.'),
(N'F. Scott Fitzgerald', N'Tiểu thuyết', N'Tác giả của Gatsby Vĩ đại.'),
(N'Mark Twain', N'Truyện tranh', N'Tác giả Huck Finn.'),
(N'Charles Dickens', N'Kinh điển', N'Tác giả của Oliver Twist.'),
(N'Victor Hugo', N'Văn học', N'Tác giả của Les Misérables.');
GO

-- 4. Bảng tbl_sach
INSERT INTO tbl_sach (tensach, id_tacgia, id_theloai, nhaxuatban, giasach, soluong, ngaynhan, trangthai, anhsach) VALUES
(N'Sách A', 1, 1, N'Nhà xuất bản Giáo dục', 100000, 50, GETDATE(), N'Còn hàng', NULL),
(N'Sách B', 2, 2, N'Nhà xuất bản Trẻ', 120000, 30, GETDATE(), N'Còn hàng', NULL),
(N'Sách C', 3, 3, N'Nhà xuất bản Kim Đồng', 150000, 40, GETDATE(), N'Còn hàng', NULL),
(N'Sách D', 4, 4, N'Nhà xuất bản Văn Học', 200000, 20, GETDATE(), N'Còn hàng', NULL),
(N'Sách E', 5, 5, N'Nhà xuất bản Khoa Học', 250000, 10, GETDATE(), N'Còn hàng', NULL),
(N'Sách F', 6, 1, N'Nhà xuất bản Giáo dục', 180000, 25, GETDATE(), N'Còn hàng', NULL),
(N'Sách G', 7, 2, N'Nhà xuất bản Trẻ', 90000, 15, GETDATE(), N'Hết hàng', NULL),
(N'Sách H', 8, 3, N'Nhà xuất bản Kim Đồng', 120000, 35, GETDATE(), N'Còn hàng', NULL),
(N'Sách I', 9, 4, N'Nhà xuất bản Văn Học', 110000, 20, GETDATE(), N'Hết hàng', NULL),
(N'Sách J', 10, 5, N'Nhà xuất bản Khoa Học', 300000, 12, GETDATE(), N'Còn hàng', NULL),
(N'Sách K', 11, 1, N'Nhà xuất bản Giáo dục', 70000, 8, GETDATE(), N'Còn hàng', NULL),
(N'Sách L', 12, 2, N'Nhà xuất bản Trẻ', 140000, 50, GETDATE(), N'Còn hàng', NULL),
(N'Sách M', 13, 3, N'Nhà xuất bản Kim Đồng', 175000, 45, GETDATE(), N'Còn hàng', NULL),
(N'Sách N', 14, 4, N'Nhà xuất bản Văn Học', 160000, 25, GETDATE(), N'Hết hàng', NULL),
(N'Sách O', 15, 5, N'Nhà xuất bản Khoa Học', 190000, 5, GETDATE(), N'Còn hàng', NULL),
(N'Sách P', 16, 1, N'Nhà xuất bản Giáo dục', 85000, 12, GETDATE(), N'Còn hàng', NULL),
(N'Sách Q', 17, 2, N'Nhà xuất bản Trẻ', 92000, 14, GETDATE(), N'Hết hàng', NULL),
(N'Sách R', 18, 3, N'Nhà xuất bản Kim Đồng', 110000, 16, GETDATE(), N'Còn hàng', NULL),
(N'Sách S', 19, 4, N'Nhà xuất bản Văn Học', 105000, 30, GETDATE(), N'Còn hàng', NULL),
(N'Sách T', 20, 5, N'Nhà xuất bản Khoa Học', 195000, 18, GETDATE(), N'Còn hàng', NULL);
GO

GO

-- 5. Bảng tbl_thanhvien
INSERT INTO tbl_thanhvien (hoten, email, sodt, gioitinh, id_user) VALUES
(N'Nguyễn Văn A', 'nguyenvana@gmail.com', '0123456789', N'Nam', 1),
(N'Lê Thị B', 'lethib@gmail.com', '0987654321', N'Nữ', 2),
(N'Trần Văn C', 'tranvanc@gmail.com', '0111222333', N'Nam', 3),
(N'Phạm Thị D', 'phamthid@gmail.com', '0321122111', N'Nữ', 4),
(N'Hoàng Văn E', 'hoangvane@gmail.com', '0333444555', N'Nam', 5),
(N'Đặng Thị F', 'dangthif@gmail.com', '0123344556', N'Nữ', 6),
(N'Bùi Văn G', 'buivang@gmail.com', '0567894321', N'Nam', 7),
(N'Ngô Thị H', 'ngothih@gmail.com', '0678901234', N'Nữ', 8),
(N'Lý Văn I', 'lyvani@gmail.com', '0765432198', N'Nam', 9),
(N'Vũ Thị J', 'vuthij@gmail.com', '0898765432', N'Nữ', 10),
(N'Tôn Nữ A', 'tonnua@gmail.com', '0901234567', N'Nữ', 11),
(N'Hồ Văn B', 'hovanb@gmail.com', '0789012345', N'Nam', 12),
(N'Lê Thị C', 'lethic@gmail.com', '0912345678', N'Nữ', 13),
(N'Nguyễn Thị D', 'nguyenthid@gmail.com', '0934567890', N'Nữ', 14),
(N'Trần Văn E', 'tranvane@gmail.com', '0123654789', N'Nam', 15),
(N'Võ Văn F', 'vovanf@gmail.com', '0987645321', N'Nam', 16),
(N'Phạm Văn G', 'phamvang@gmail.com', '0765432109', N'Nam', 17),
(N'Nguyễn Thị H', 'nguyenthih@gmail.com', '0654321098', N'Nữ', 18),
(N'Trần Văn I', 'tranvani@gmail.com', '0789345612', N'Nam', 19),
(N'Lê Văn J', 'levanj@gmail.com', '0932187456', N'Nam', 20);
GO

-- 6. Bảng tbl_docgia
INSERT INTO tbl_docgia (tendocgia, sodt, email, gioitinh, tongtienthanhtoan) VALUES
(N'Nguyễn Văn K', '0987123456', 'nguyenvank@gmail.com', N'Nam', 0),
(N'Lê Thị L', '0987234567', 'lethil@gmail.com', N'Nữ', 50000),
(N'Trần Văn M', '0987345678', 'tranvanm@gmail.com', N'Nam', 150000),
(N'Phạm Thị N', '0987456789', 'phamthin@gmail.com', N'Nữ', 200000),
(N'Hoàng Văn O', '0987567890', 'hoangvano@gmail.com', N'Nam', 250000),
(N'Đặng Thị P', '0987678901', 'dangthip@gmail.com', N'Nữ', 300000),
(N'Bùi Văn Q', '0987789012', 'buivanq@gmail.com', N'Nam', 350000),
(N'Ngô Thị R', '0987890123', 'ngothir@gmail.com', N'Nữ', 400000),
(N'Lý Văn S', '0987901234', 'lyvans@gmail.com', N'Nam', 450000),
(N'Vũ Thị T', '0988012345', 'vuthit@gmail.com', N'Nữ', 500000),
(N'Tôn Nữ U', '0988123456', 'tonnua@gmail.com', N'Nữ', 550000),
(N'Hồ Văn V', '0988234567', 'hovanv@gmail.com', N'Nam', 600000),
(N'Lê Thị W', '0988345678', 'lethiw@gmail.com', N'Nữ', 650000),
(N'Nguyễn Thị X', '0988456789', 'nguyenthix@gmail.com', N'Nữ', 700000),
(N'Trần Văn Y', '0988567890', 'tranvany@gmail.com', N'Nam', 750000),
(N'Võ Văn Z', '0988678901', 'vovanz@gmail.com', N'Nam', 800000),
(N'Phạm Văn AA', '0988789012', 'phamvana@gmail.com', N'Nam', 850000),
(N'Nguyễn Thị BB', '0988890123', 'nguyenthibb@gmail.com', N'Nữ', 900000),
(N'Trần Văn CC', '0988901234', 'tranvancc@gmail.com', N'Nam', 950000),
(N'Lê Văn DD', '0989012345', 'levandd@gmail.com', N'Nam', 1000000);
GO

-- 7. Bảng tbl_Hoadon
INSERT INTO tbl_Hoadon (id_sach, tensach, id_docgia, hoten, ngaymua) VALUES
(1, N'Sách A', 1, N'Nguyễn Văn A', GETDATE()),
(2, N'Sách B', 2, N'Lê Thị B', GETDATE()),
(3, N'Sách C', 3, N'Trần Văn C', GETDATE()),
(4, N'Sách D', 4, N'Phạm Thị D', GETDATE()),
(5, N'Sách E', 5, N'Hoàng Văn E', GETDATE()),
(6, N'Sách F', 6, N'Đặng Thị F', GETDATE()),
(7, N'Sách G', 7, N'Bùi Văn G', GETDATE()),
(8, N'Sách H', 8, N'Ngô Thị H', GETDATE()),
(9, N'Sách I', 9, N'Lý Văn I', GETDATE()),
(10, N'Sách J', 10, N'Vũ Thị J', GETDATE()),
(11, N'Sách K', 11, N'Tôn Nữ A', GETDATE()),
(12, N'Sách L', 12, N'Hồ Văn B', GETDATE()),
(13, N'Sách M', 13, N'Lê Thị C', GETDATE()),
(14, N'Sách N', 14, N'Nguyễn Thị D', GETDATE()),
(15, N'Sách O', 15, N'Trần Văn E', GETDATE()),
(16, N'Sách P', 16, N'Võ Văn F', GETDATE()),
(17, N'Sách Q', 17, N'Phạm Văn G', GETDATE()),
(18, N'Sách R', 18, N'Nguyễn Thị H', GETDATE()),
(19, N'Sách S', 19, N'Trần Văn I', GETDATE()),
(20, N'Sách T', 20, N'Lê Văn J', GETDATE());
GO




































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


	   --5. Bảng Sách
INSERT INTO tbl_sach (tensach, id_tacgia, id_theloai, nhaxuatban, giasach, soluong, ngaynhan, trangthai, anhsach) 
VALUES (N'Chí Phèo', 1, 1, N'Nhà xuất bản văn học', 150000, 1, '2024-02-20', N'abc', 'D:\img_books\ms1.jpg'),
	   (N'Tuổi trẻ đáng giá bao nhiêu', 4, 3, N'Nhã Nam', 70000, 1, '2024-02-22', N'abc', 'D:\img_books\ms2.jpg'),
       (N'Giải thuật và lập trình', 3, 6, N'Nhà Xuất Bản Trẻ', 89000, 7, '2024-02-24', N'abc', 'D:\img_books\ms3.jpg'),
	   (N'Đắc Nhân Tâm', 5, 7, N'Nhà xuất bản thế giới', 130000, 1, '2024-02-27', N'abc', 'D:\img_books\ms4.jpg'),
	   (N'những tập thơ TỐ HỮU', 2,7,'Nhà xuất bản văn học', 90000, 1, '2024-02-27', N'abc', 'D:\img_books\ms5.jpg');






	   -- Xóa bảng tbl_Hoadon
DROP TABLE IF EXISTS tbl_Hoadon;

-- Xóa bảng tbl_sach
DROP TABLE IF EXISTS tbl_sach;

-- Xóa bảng tbl_thanhvien
DROP TABLE IF EXISTS tbl_thanhvien;

-- Xóa bảng tbl_tacgia
DROP TABLE IF EXISTS tbl_tacgia;

-- Xóa bảng tbl_theloai
DROP TABLE IF EXISTS tbl_theloai;

-- Xóa bảng tbl_docgia
DROP TABLE IF EXISTS tbl_docgia;

-- Xóa bảng tbl_user
DROP TABLE IF EXISTS tbl_user;

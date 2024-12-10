using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanSachCSharph.Controllers;
using QuanLyBanSachCSharph.Models;

namespace QuanLyBanSachCSharph.Views
{
    public partial class MgBook : Form
    {
        private SachController book;
        private TheloaiController theLoai; // Đối tượng để kết nối dữ liệu thể loại
        private Dictionary<string, string> theLoaiMap; // Lưu trữ dữ liệu thể loại
        public MgBook()
        {
            InitializeComponent();

            book = new SachController();
            // Khởi tạo đối tượng TheLoaiController
            theLoai = new TheloaiController();

            // Tải dữ liệu thể loại vào ComboBox khi form mở
            this.Load += MgBook_Load;


        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Hàm xóa dữ liệu các trường nhập sau khi thêm sách
        private void ResetFields()
        {
            txtMasach.Clear();
            txtTensach.Clear();
            txtTacgia.Clear();
            txtMatg.Clear();
            txtMatl.Clear();
            cmbTheloai.SelectedIndex = 0; // Đặt ComboBox về trạng thái không chọn gì
            txtNhaxuatban.Clear();
            txtSoluong.Clear();
            txtGiasach.Clear();
            picboxAnh.Image = null;
            dtimerNhap.Value = DateTime.Now;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các trường nhập
                string tensach = txtTensach.Text.Trim();
                string tacgia = txtTacgia.Text.Trim();
                string matacgia = txtMatg.Text.Trim();
                string matheloai = txtMatl.Text.Trim();
                string nhaxuatban = txtNhaxuatban.Text.Trim();
                DateTime ngaynhap = dtimerNhap.Value;

                // Kiểm tra số lượng và giá sách
                int soluong = 0;
                double giasach = 0;

                if (!int.TryParse(txtSoluong.Text.Trim(), out soluong) || soluong < 0)
                {
                    MessageBox.Show("Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtGiasach.Text.Trim(), out giasach) || giasach < 0)
                {
                    MessageBox.Show("Giá sách không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra hình ảnh
                byte[] img = null;
                if (picboxAnh.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        picboxAnh.Image.Save(ms, picboxAnh.Image.RawFormat);
                        img = ms.ToArray();
                    }
                }

                // Tạo đối tượng sách
                SachModel sach = new SachModel()
                {
                    tensach = tensach,
                    tentacgia = tacgia,
                    idtacgia = matacgia,
                    idtheloai = matheloai,
                    soluong = soluong.ToString(),
                    giasach = giasach.ToString(),
                    nhaxuatban = nhaxuatban,
                    ngaynhan = ngaynhap.ToString("yyyy-MM-dd"),
                    anhsach = img
                };

                // Gọi phương thức thêm sách
                if (Kiemtra())
                {
                    if (book.AddBook(sach))
                    {
                        ShowTable();
                        MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetFields(); // Xóa các trường nhập
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm sách. Hãy thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ các trường bắt buộc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức tải dữ liệu thể loại vào ComboBox
        public void InsertCmbTheLoai(ComboBox cmbTheLoai)
        {
            // Xóa dữ liệu cũ trong ComboBox
            cmbTheLoai.Items.Clear();
            cmbTheLoai.Items.Add("Chọn thể loại"); // Thêm mục mặc định

            // Lấy dữ liệu thể loại từ cơ sở dữ liệu
            theLoaiMap = theLoai.GetTheLoaiMap();

            // Thêm các thể loại vào ComboBox
            foreach (string tenTheLoai in theLoaiMap.Keys)
            {
                cmbTheLoai.Items.Add(tenTheLoai);
            }

            // Đặt mục mặc định được chọn
            cmbTheLoai.SelectedIndex = 0;
        }

        // Sự kiện khi form tải
        private void MgBook_Load(object sender, EventArgs e)
        {
            InsertCmbTheLoai(cmbTheloai);
        }
        private void btnTaianh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opt = new OpenFileDialog();
            opt.Filter = "Select Photo(*.jpg; *.png *.gif)| *.jpg; *.png; *.gif";
            if (opt.ShowDialog() == DialogResult.OK)
            {
                picboxAnh.Image = Image.FromFile(opt.FileName);

            }


        }
        bool Kiemtra()
        {
            return !string.IsNullOrWhiteSpace(txtTensach.Text) &&
           !string.IsNullOrWhiteSpace(txtTacgia.Text) &&
           !string.IsNullOrWhiteSpace(txtMatg.Text) &&
           !string.IsNullOrWhiteSpace(txtMatl.Text) &&
           picboxAnh.Image != null;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetFields();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã chọn sách nào trong bảng chưa
                if (tblSach.SelectedRows.Count > 0)
                {
                    // Lấy ID sách từ hàng được chọn
                    string id_sach = tblSach.SelectedRows[0].Cells["id_sach"].Value.ToString();

                    // Lấy dữ liệu từ các trường nhập
                    string tensach = txtTensach.Text.Trim();
                    string tacgia = txtTacgia.Text.Trim();
                    string matacgia = txtMatg.Text.Trim();
                    string matheloai = txtMatl.Text.Trim();
                    string nhaxuatban = txtNhaxuatban.Text.Trim();
                    DateTime ngaynhap = dtimerNhap.Value;

                    // Kiểm tra số lượng và giá sách
                    int soluong = 0;
                    double giasach = 0;

                    if (!int.TryParse(txtSoluong.Text.Trim(), out soluong) || soluong < 0)
                    {
                        MessageBox.Show("Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!double.TryParse(txtGiasach.Text.Trim(), out giasach) || giasach < 0)
                    {
                        MessageBox.Show("Giá sách không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Kiểm tra hình ảnh
                    byte[] img = null;
                    if (picboxAnh.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            picboxAnh.Image.Save(ms, picboxAnh.Image.RawFormat);
                            img = ms.ToArray();
                        }
                    }

                    // Tạo đối tượng sách
                    SachModel sach = new SachModel()
                    {
                        idsach = id_sach,
                        tensach = tensach,
                        tentacgia = tacgia,
                        idtacgia = matacgia,
                        idtheloai = matheloai,
                        soluong = soluong.ToString(),
                        giasach = giasach.ToString(),
                        nhaxuatban = nhaxuatban,
                        ngaynhan = ngaynhap.ToString("yyyy-MM-dd"),
                        anhsach = img
                    };

                    // Gọi phương thức sửa sách
                    if (book.UpdateBook(sach))
                    {
                        ShowTable();
                        MessageBox.Show("Sửa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetFields(); // Xóa các trường nhập
                    }
                    else
                    {
                        MessageBox.Show("Không thể sửa sách. Hãy thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sách để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã chọn sách nào trong bảng chưa
                if (tblSach.SelectedRows.Count > 0)
                {
                    // Lấy ID sách từ hàng được chọn
                    int id_sach = Convert.ToInt32(tblSach.SelectedRows[0].Cells["id_sach"].Value);

                    // Hiển thị hộp thoại xác nhận
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Gọi phương thức xóa sách
                        if (book.DeleteBook(id_sach))
                        {
                            ShowTable();
                            MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa sách. Hãy thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void txtMatl_TextChanged(object sender, EventArgs e)
        {

        }

        private void tblSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem hàng được chọn có hợp lệ không
                if (e.RowIndex >= 0)
                {
                    // Lấy hàng được chọn
                    DataGridViewRow selectedRow = tblSach.Rows[e.RowIndex];

                    // Gán dữ liệu từ bảng vào các ô nhập liệu
                    txtMasach.Text = selectedRow.Cells["id_sach"].Value?.ToString();
                    txtTensach.Text = selectedRow.Cells["tensach"].Value?.ToString();
                    //txtTacgia.Text = selectedRow.Cells["tentacgia"].Value?.ToString();
                    txtMatg.Text = selectedRow.Cells["id_tacgia"].Value?.ToString();
                    txtMatl.Text = selectedRow.Cells["id_theloai"].Value?.ToString();
                    //cmbTheloai.SelectedIndex = cmbTheloai.FindStringExact(selectedRow.Cells["tentheloai"].Value?.ToString());
                    txtNhaxuatban.Text = selectedRow.Cells["nhaxuatban"].Value?.ToString();
                    txtSoluong.Text = selectedRow.Cells["soluong"].Value?.ToString();
                    txtGiasach.Text = selectedRow.Cells["giasach"].Value?.ToString();
                    dtimerNhap.Value = Convert.ToDateTime(selectedRow.Cells["ngaynhan"].Value ?? DateTime.Now);

                    // Xử lý hình ảnh
                    if (selectedRow.Cells["anhsach"].Value != DBNull.Value && selectedRow.Cells["anhsach"].Value != null)
                    {
                        try
                        {
                            byte[] imgData = (byte[])selectedRow.Cells["anhsach"].Value;
                            if (imgData.Length > 0)
                            {
                                using (MemoryStream ms = new MemoryStream(imgData))
                                {
                                    picboxAnh.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                picboxAnh.Image = null; // Nếu hình ảnh rỗng
                            }
                        }
                        catch
                        {
                            picboxAnh.Image = null; // Nếu có lỗi khi xử lý hình ảnh
                            MessageBox.Show("Hình ảnh không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        picboxAnh.Image = null; // Nếu không có hình ảnh
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MgBook_Load_1(object sender, EventArgs e)
        {
            ShowTable();
        }

        private void picLoad_Click(object sender, EventArgs e)
        {
            try
            {
                // Xóa dữ liệu hiện tại trong DataGridView
                tblSach.DataSource = null;

                // Lấy lại toàn bộ dữ liệu từ bảng sách
                DataTable allBooks = book.GetAllBooks();

                if (allBooks != null && allBooks.Rows.Count > 0)
                {
                    tblSach.DataSource = allBooks;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lại dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbTheloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTheLoai = cmbTheloai.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedTheLoai) && selectedTheLoai != "Chọn thể loại")
            {
                if (theLoaiMap.TryGetValue(selectedTheLoai, out string maTheLoai)) // Lấy mã thể loại
                {
                    // Console.WriteLine($"Thể loại đã chọn: {selectedTheLoai} - Mã: {maTheLoai}");
                    txtMatl.Text = maTheLoai.ToString();
                }
            }

        }
        /*
        public void ShowData()
        {
            tblSach.DataSource = book.GetAllBooks();
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)tblSach.Columns[10];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;



        }
        */
        public void ShowTable()
        {
            try
            {
                // Lấy dữ liệu từ bảng tbl_sach
                DataTable data = book.GetAllBooks();

                if (data != null && data.Rows.Count > 0)
                {
                    tblSach.DataSource = data;

                    // Định dạng cột hình ảnh
                    if (tblSach.Columns.Contains("anhsach"))
                    {
                        DataGridViewImageColumn imgCol = (DataGridViewImageColumn)tblSach.Columns["anhsach"];
                        imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    }

                    // Định dạng kích thước các cột nếu cần
                    tblSach.Columns["id_sach"].HeaderText = "Mã Sách";
                    tblSach.Columns["tensach"].HeaderText = "Tên Sách";
                    tblSach.Columns["id_tacgia"].HeaderText = "Mã Tác Giả";
                    tblSach.Columns["id_theloai"].HeaderText = "Mã Thể Loại";
                    tblSach.Columns["nhaxuatban"].HeaderText = "Nhà Xuất Bản";
                    tblSach.Columns["giasach"].HeaderText = "Giá Sách";
                    tblSach.Columns["soluong"].HeaderText = "Số Lượng";
                    tblSach.Columns["ngaynhan"].HeaderText = "Ngày Nhận";
                    tblSach.Columns["trangthai"].HeaderText = "Trạng Thái";
                    tblSach.Columns["anhsach"].HeaderText = "Ảnh Sách";
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Phương thức để nhận dữ liệu từ form DSTacGia
        public void AddtgData(string tenTg, string maTg)
        {
            txtTacgia.Text = tenTg; // Gán tên tác giả
            txtMatg.Text = maTg;    // Gán mã tác giả
        }
        private void btnshowDialogAuthor_Click(object sender, EventArgs e)
        {
            // Tạo một instance của form DSTacGia, truyền form cha (MgBook)
            DSTacGia formDialog = new DSTacGia(this);

            // Hiển thị form dưới dạng modal
            formDialog.ShowDialog();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string searchTerm = txtTim.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Gọi phương thức tìm kiếm từ SachController
                DataTable results = book.SearchBooks(searchTerm);

                if (results != null && results.Rows.Count > 0)
                {
                    tblSach.DataSource = results;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tblSach.DataSource = null; // Xóa dữ liệu hiện tại
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

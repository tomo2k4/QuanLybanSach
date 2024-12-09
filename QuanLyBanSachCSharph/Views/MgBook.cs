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
            txtTensach.Clear();
            txtTacgia.Clear();
            txtMatg.Clear();
            txtMatl.Clear();
            cmbTheloai.TabIndex = 0;
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


        }

        private void btnSua_Click(object sender, EventArgs e)
        {


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {



        }

        private void txtMatl_TextChanged(object sender, EventArgs e)
        {

        }

        private void tblSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MgBook_Load_1(object sender, EventArgs e)
        {
            ShowData();
        }

        private void picLoad_Click(object sender, EventArgs e)
        {
            ResetFields();

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
        public void ShowData()
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






    }
}

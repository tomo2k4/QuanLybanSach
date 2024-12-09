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

namespace QuanLyBanSachCSharph.Views
{
    public partial class MgBook : Form
    {
        public MgBook()
        {
            InitializeComponent();
            // Khởi tạo đối tượng TheLoaiController
            theLoai = new TheloaiController();

            // Tải dữ liệu thể loại vào ComboBox khi form mở
            this.Load += MgBook_Load;


        }
        private TheloaiController theLoai; // Đối tượng để kết nối dữ liệu thể loại
        private Dictionary<string, string> theLoaiMap; // Lưu trữ dữ liệu thể loại
        private void CloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tensach = txtTensach.Text;


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
            opt.Filter = "Select Photo(*.jpg; *.png *.gif)| *.jpg; *.phy; *.gif";
            if (opt.ShowDialog() == DialogResult.OK)
            {
                picboxAnh.Image = Image.FromFile(opt.FileName);

            }


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {


        }
        bool Kiemtra()
        {
            if ((txtTensach.Text == "") || (txtTacgia.Text == "") ||
                (txtSoluong.Text == "") || (txtGiasach.Text == "") ||
                (picboxAnh.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
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
    }
}

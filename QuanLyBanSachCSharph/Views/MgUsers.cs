using QuanLyBanSachCSharph.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSachCSharph.Views
{
    public partial class MgUsers : Form
    {
        private UserController userController = new UserController();

        public MgUsers()
        {
            InitializeComponent();
            LoadUsers(); // Nạp dữ liệu người dùng khi form khởi tạo
            SetNull(); // Thiết lập các ô input rỗng khi mới mở form
        }

        // Load lại danh sách người dùng
        private void LoadUsers()
        {
            try
            {
                DataTable dt = userController.SearchMember("");
                tblUser.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading users: " + ex.Message);
            }
        }

        // Làm rỗng các ô input
        private void SetNull()
        {
            txtClientName.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            cbSex.SelectedIndex = -1;
        }

        // Thêm thành viên mới
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUser addForm = new AddUser();
            addForm.Show();
        }

        // Tìm kiếm thành viên
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearch.Text.Trim(); // Lấy từ ô tìm kiếm
                DataTable dt = userController.SearchMember(keyword); // Gọi hàm tìm kiếm
                tblUser.DataSource = dt; // Cập nhật bảng với kết quả tìm kiếm
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Cập nhật thông tin thành viên
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = Convert.ToInt32(tblUser.SelectedRows[0].Cells["id_user"].Value); // Lấy id người dùng đã chọn
                string name = txtClientName.Text.Trim();
                string phone = txtPhoneNumber.Text.Trim();
                string email = string.IsNullOrWhiteSpace(txtEmail.Text) ? "" : txtEmail.Text.Trim();
                string sex = cbSex.SelectedItem?.ToString();

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone))
                {
                    MessageBox.Show("Name and phone are required.");
                    return;
                }

                userController.UpdateMember(userId, name, phone, email, sex); // Gọi hàm UpdateMember
                MessageBox.Show("Updated user successfully!");
                LoadUsers(); // Load lại danh sách người dùng
                SetNull(); // Làm rỗng các ô input
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Xóa thành viên
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = Convert.ToInt32(tblUser.SelectedRows[0].Cells["id_user"].Value); // Lấy id người dùng đã chọn
                userController.DeleteMember(userId); // Gọi hàm DeleteMember
                MessageBox.Show("Deleted user successfully!");
                LoadUsers(); // Load lại danh sách người dùng
                SetNull(); // Làm rỗng các ô input
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            SetNull();
        }

        // Xử lý khi người dùng chọn một dòng trong DataGridView
        private void tblUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu có dòng được chọn
            if (tblUser.SelectedRows.Count > 0)
            {
                var selectedRow = tblUser.SelectedRows[0];

                // Kiểm tra và gán giá trị nếu không null
                txtClientName.Text = selectedRow.Cells["hoten"].Value?.ToString() ?? string.Empty;
                txtUsername.Text = selectedRow.Cells["username"].Value?.ToString() ?? string.Empty;
                txtPhoneNumber.Text = selectedRow.Cells["sodt"].Value?.ToString() ?? string.Empty;
                txtEmail.Text = selectedRow.Cells["email"].Value?.ToString() ?? string.Empty;
                cbSex.SelectedItem = selectedRow.Cells["gioitinh"].Value?.ToString() ?? null;
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }


        // Đóng ứng dụng
        private void CloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picLoad_Click(object sender, EventArgs e)
        {
            LoadUsers();
            SetNull();
        }
    }
}

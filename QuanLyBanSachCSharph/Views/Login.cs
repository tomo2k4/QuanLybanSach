using QuanLyBanSachCSharph.Controllers;
using QuanLyBanSachCSharph.Models;
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
    public partial class Login : Form
    {
        // Khởi tạo đối tượng của controller
        private readonly NguoidungController NguoidungCon;

        public Login()
        {
            InitializeComponent();
            NguoidungCon = new NguoidungController();


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lblopen_Click(object sender, EventArgs e)
        {

        }

        private void MinForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eyeclose_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Kiểm tra đầu vào
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Vui lòng nhập đầy đủ thông tin!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Gửi dữ liệu tới Controller
            NguoidungModel user = new NguoidungModel { UserName = username, Password = password };
            try
            {
                bool isAuthenticated = NguoidungCon.Authenticate(user);
                if (isAuthenticated)
                {
                    lblMessage.Text = "Đăng nhập thành công!";
                    lblMessage.ForeColor = System.Drawing.Color.Green;

                    // Chuyển sang form chính (Main Form)
                    this.Hide();
                    Signin mainForm = new Signin();
                    mainForm.Show();
                }
                else
                {
                    lblMessage.Text = "Tên đăng nhập hoặc mật khẩu không đúng!";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

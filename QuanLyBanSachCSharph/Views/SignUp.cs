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
    public partial class SignUp : Form
    {

        private UserController userController = new UserController();

        public SignUp()
        {
            InitializeComponent();
            SetDefault();
        }

        public void SetDefault()
        {
            txtPassword.UseSystemPasswordChar = true;
            eyeOpen1.Visible = true;
            eyeClose1.Visible = false;

            txtConfirmPassword.UseSystemPasswordChar = true;
            eyeOpen2.Visible = true;
            eyeClose2.Visible = false;
        }

        // Làm rỗng các ô input
        private void SetNull()
        {
            txtFullname.Clear();
            txtPhoneNumber.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();

            SetDefault();
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eyeOpen1_Click(object sender, EventArgs e)
        {
            // Đặt kiểu hiển thị của TextBox về bình thường để hiển thị mật khẩu
            txtPassword.UseSystemPasswordChar = false;

            // Ẩn lblopen và hiện lblclose
            eyeOpen1.Visible = false;
            eyeClose1.Visible = true;

        }
        private void eyeClose1_Click(object sender, EventArgs e)
        {
            // Đặt kiểu hiển thị của TextBox ẩn mật khẩu
            txtPassword.UseSystemPasswordChar = true;

            // Ẩn lblopen và hiện lblclose
            eyeOpen1.Visible = true;
            eyeClose1.Visible = false;
        }
        private void eyeOpen2_Click(object sender, EventArgs e)
        {
            // Đặt kiểu hiển thị của TextBox về bình thường để hiển thị mật khẩu
            txtConfirmPassword.UseSystemPasswordChar = false;

            // Ẩn lblopen và hiện lblclose
            eyeOpen2.Visible = false;
            eyeClose2.Visible = true;

        }
        private void eyeClose2_Click(object sender, EventArgs e)
        {
            // Đặt kiểu hiển thị của TextBox ẩn mật khẩu
            txtConfirmPassword.UseSystemPasswordChar = true;

            // Ẩn lblopen và hiện lblclose
            eyeOpen2.Visible = true;
            eyeClose2.Visible = false;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtFullname.Text.Trim();
                string username = txtUserName.Text.Trim();
                string phone = txtPhoneNumber.Text.Trim();
                string email = string.IsNullOrWhiteSpace(txtEmail.Text) ? "" : txtEmail.Text.Trim();
                string password = txtPassword.Text.Trim();
                string confirm = txtConfirmPassword.Text.Trim();

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone))
                {
                    MessageBox.Show("Name and phone are required.");
                    return;
                }
                else if (password != confirm)
                {
                    MessageBox.Show("Passwords are not similar.");
                    return;
                }

                userController.AddMember(name, phone, email, null, username, password, "user");

                MessageBox.Show("Added new user successfully!");
                SetNull(); // Làm rỗng các ô input
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            this.Hide();
            login.Show();
        }
    }
}

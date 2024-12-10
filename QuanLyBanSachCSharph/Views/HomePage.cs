using BookShop;
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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            DesignUI();
            UpdateTotalMembers();
            UpdateTotalBooks();
            UpdateTotalRevenue();

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
        private void DesignUI()
        {
            pnlbooks.Visible = false;
            pnlUser.Visible = false;

        }

        private void UpdateTotalMembers()
        {
            try
            {
                NguoidungController nguoidungController = new NguoidungController();
                int totalMembers = nguoidungController.GetTotalMembers(); // Gọi phương thức từ controller
                label6.Text = totalMembers.ToString(); // Hiển thị số lượng lên label6
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy tổng số thành viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTotalBooks()
        {
            try
            {
                SachController sachController = new SachController();
                int totalBooks = sachController.GetTotalBooks(); // Lấy tổng số sách từ controller
                label7.Text = totalBooks.ToString(); // Cập nhật tổng số sách lên label6
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy tổng số sách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTotalRevenue()
        {
            try
            {
                BillController hoadonController = new BillController();
                decimal totalRevenue = hoadonController.GetTotalRevenue(); // Lấy tổng doanh thu từ controller
                label9.Text = totalRevenue.ToString("C"); // Cập nhật tổng doanh thu lên label6 dưới định dạng tiền tệ
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tính tổng doanh thu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HideMenu()
        {
            if (pnlbooks.Visible == true)
            {
                pnlbooks.Visible = false;
            }
            if (pnlUser.Visible == true)
            {
                pnlUser.Visible = false;
            }
        }

        private void ShowMenu(Panel pnl)
        {
            if (!pnl.Visible)
            {
                HideMenu();
                pnl.Visible = true;
            }
            else
            {
                pnl.Visible = false;
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            ShowMenu(pnlbooks);
        }

        private void btnGenres_Click(object sender, EventArgs e)
        {
            HideMenu();
            openChildForm(new Theloai());

        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            HideMenu();
            openChildForm(new Billing());
        }

        private void btnMgBook_Click(object sender, EventArgs e)
        {
            HideMenu();
            openChildForm(new MgBook());

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ShowMenu(pnlUser);
        }

        private void btnMgUser_Click(object sender, EventArgs e)
        {
            HideMenu();
            openChildForm(new MgUsers());
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMgClient_Click(object sender, EventArgs e)
        {
            HideMenu();
            openChildForm(new MgClients());
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close(); // Đóng form con hiện tại nếu có.

            activeForm = childForm; // Đặt form mới làm form con hiện tại.
            childForm.TopLevel = false; // Không cho phép form con hoạt động độc lập.
            childForm.FormBorderStyle = FormBorderStyle.None; // Loại bỏ viền form.
            childForm.Dock = DockStyle.Fill; // Đặt form con lấp đầy panel.
            pnlCover.Controls.Add(childForm); // Thêm form con vào panel.
            pnlCover.Tag = childForm; // Gán tag cho form con.
            childForm.BringToFront(); // Đưa form con lên phía trước.
            childForm.Show(); // Hiển thị form con.
        }


        private void pnlCover_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại (form chính)
            this.Hide(); // Ẩn form chính thay vì đóng nó

            // Tạo đối tượng form đăng nhập và hiển thị lại
            Login loginForm = new Login();
            loginForm.Show(); // Mở form đăng nhập

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

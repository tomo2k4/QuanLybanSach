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
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
        private void DesignUI()
        {
            pnlbooks.Visible = false;
            pnlUser.Visible = false;

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
            //openChildForm(new Biiling());
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
    }
}

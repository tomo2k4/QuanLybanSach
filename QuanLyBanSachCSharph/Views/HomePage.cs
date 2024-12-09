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

        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            HideMenu();

        }

        private void btnMgBook_Click(object sender, EventArgs e)
        {
            HideMenu();

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ShowMenu(pnlUser);
        }

        private void btnMgUser_Click(object sender, EventArgs e)
        {
            HideMenu();

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
        }
    }
}

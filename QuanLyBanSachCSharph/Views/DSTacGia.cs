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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QuanLyBanSachCSharph.Views
{
    public partial class DSTacGia : Form
    {
        private TacGiaController dstg;
        private MgBook parentForm;
        public DSTacGia(MgBook parent)
        {
            InitializeComponent();
            dstg = new TacGiaController();
            parentForm = parent; // Lưu tham chiếu form cha


        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void DSTacGia_Load(object sender, EventArgs e)
        {
            LoadAuthorData();
        }

        private void LoadAuthorData()
        {
            try
            {
                // Gọi phương thức lấy dữ liệu từ bảng tbl_tacgia
                DataTable authors = dstg.GetAuthors();
                tblTacGia.DataSource = authors; // dgvAuthors là DataGridView trong form
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu tác giả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChontg_Click(object sender, EventArgs e)
        {
            if (tblTacGia.SelectedRows.Count > 0)
            {
                // Lấy dữ liệu từ dòng được chọn
                string maTacGia = tblTacGia.SelectedRows[0].Cells["id_tacgia"].Value.ToString();
                string tenTacGia = tblTacGia.SelectedRows[0].Cells["tentacgia"].Value.ToString();

                // Gửi dữ liệu sang form MgBook
                parentForm.AddtgData(tenTacGia, maTacGia);

                // Đóng form hiện tại
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tác giả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.SqlClient;


namespace QuanLyBanSachCSharph.Controllers
{
    public class DBConnect
    {
        // Chuỗi kết nối
        private readonly string connectionString;

        // Constructor: Khởi tạo chuỗi kết nối
        public DBConnect()
        {
            // Đường dẫn tới file .mdf trong dự án
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\source\repos\ManagementBookShop\QuanLyBanSachCSharph\QuanlyBookshop.mdf;Integrated Security=True;Connect Timeout=30";
        }

        // Hàm trả về kết nối
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Hàm kiểm tra kết nối 
        public bool TestConnection()
        {
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Kết nối thành công tới cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kết nối CSDL thất bại: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

    }
}

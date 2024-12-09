using Microsoft.Data.SqlClient;
using QuanLyBanSachCSharph.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSachCSharph.Controllers
{
    public class NguoidungController
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\3 - 1\dot NET\QuanLyBanSach\QuanLyBanSachCSharph\QuanLyBanSach.mdf"";Integrated Security=True;Connect Timeout=30";

        // Phương thức kiểm tra đăng nhập
        public bool Authenticate(NguoidungModel user)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM tbl_user WHERE username = @username AND password = @password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", user.UserName);
                    cmd.Parameters.AddWithValue("@password", user.Password);

                    int result = (int)cmd.ExecuteScalar();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi kiểm tra đăng nhập: " + ex.Message);
                }
            }
        }
    }
}

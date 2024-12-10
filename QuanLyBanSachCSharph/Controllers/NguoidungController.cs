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
        private readonly DBConnect dbConnect = new DBConnect();

        // Phương thức kiểm tra đăng nhập
        public bool Authenticate(NguoidungModel user)
        {
            using (SqlConnection conn = dbConnect.GetConnection())
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


        public int GetTotalMembers()
        {
            int totalMembers = 0;
            string query = "SELECT COUNT(*) AS total FROM tbl_thanhvien";

            using (SqlConnection conn = dbConnect.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        totalMembers = (int)cmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi lấy tổng số thành viên: " + ex.Message);
                }
            }

            return totalMembers;
        }


    }
}

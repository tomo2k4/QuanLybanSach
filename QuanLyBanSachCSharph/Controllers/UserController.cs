using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Policy;
using QuanLyBanSachCSharph.Controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography.Xml;


namespace QuanLyBanSachCSharph.Controllers
{
    internal class UserController
    {
        private DBConnect DBConnect = new DBConnect();

        // Thêm thành viên mới
        public void AddMember(string fullName, string phoneNumber, string email, string gender, string username, string password, string userType)
        {
            // Kiểm tra nếu username đã tồn tại
            string checkUsernameQuery = "SELECT COUNT(*) FROM tbl_user WHERE username = @username";

            string insertUserQuery = "INSERT INTO tbl_user (username, password, typeuser) VALUES (@username, @password, @typeuser); SELECT SCOPE_IDENTITY();";
            string insertMemberQuery = "INSERT INTO tbl_thanhvien (hoten, sodt, email, gioitinh, id_user) VALUES (@hoten, @sodt, @email, @gioitinh, @id_user)";

            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();

                    // Kiểm tra xem username có tồn tại hay không
                    SqlCommand cmdCheck = new SqlCommand(checkUsernameQuery, conn);
                    cmdCheck.Parameters.AddWithValue("@username", username);
                    int userCount = (int)cmdCheck.ExecuteScalar();

                    if (userCount > 0)
                    {
                        throw new Exception("Username already exists. Please choose another one.");
                    }

                    // Thêm người dùng vào bảng tbl_user
                    SqlCommand cmd = new SqlCommand(insertUserQuery, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); // Lưu ý mã hóa mật khẩu trước khi lưu vào DB
                    cmd.Parameters.AddWithValue("@typeuser", userType);

                    // Lấy id_user vừa thêm vào
                    int userId = Convert.ToInt32(cmd.ExecuteScalar());

                    // Thêm thành viên vào bảng tbl_thanhvien
                    SqlCommand cmdMember = new SqlCommand(insertMemberQuery, conn);
                    cmdMember.Parameters.AddWithValue("@hoten", fullName);
                    cmdMember.Parameters.AddWithValue("@sodt", phoneNumber);
                    cmdMember.Parameters.AddWithValue("@email", string.IsNullOrEmpty(email) ? DBNull.Value : email);
                    cmdMember.Parameters.AddWithValue("@gioitinh", string.IsNullOrEmpty(gender) ? DBNull.Value : gender);
                    cmdMember.Parameters.AddWithValue("@id_user", userId);

                    cmdMember.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while adding member: " + ex.Message);
            }
        }

        // Cập nhật thông tin thành viên
        public void UpdateMember(int memberId, string fullName, string phoneNumber, string email, string gender)
        {
            string updateMemberQuery = "UPDATE tbl_thanhvien SET hoten = @hoten, sodt = @sodt, email = @email, gioitinh = @gioitinh WHERE id_thanhvien = @id_thanhvien";

            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();

                    // Cập nhật thông tin thành viên trong bảng tbl_thanhvien
                    SqlCommand cmdMember = new SqlCommand(updateMemberQuery, conn);
                    cmdMember.Parameters.AddWithValue("@hoten", fullName);
                    cmdMember.Parameters.AddWithValue("@sodt", phoneNumber);
                    cmdMember.Parameters.AddWithValue("@email", string.IsNullOrEmpty(email) ? DBNull.Value : email);
                    cmdMember.Parameters.AddWithValue("@gioitinh", string.IsNullOrEmpty(gender) ? DBNull.Value : gender);
                    cmdMember.Parameters.AddWithValue("@id_thanhvien", memberId);
                    cmdMember.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while updating member: " + ex.Message);
            }
        }

        // Xóa thành viên
        public void DeleteMember(int memberId)
        {
            string deleteMemberQuery = "DELETE FROM tbl_thanhvien WHERE id_thanhvien = @id_thanhvien";
            string deleteUserQuery = "DELETE FROM tbl_user WHERE id_user = (SELECT id_user FROM tbl_thanhvien WHERE id_thanhvien = @id_thanhvien)";

            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();

                    // Xóa thành viên khỏi bảng tbl_thanhvien
                    SqlCommand cmdMember = new SqlCommand(deleteMemberQuery, conn);
                    cmdMember.Parameters.AddWithValue("@id_thanhvien", memberId);
                    cmdMember.ExecuteNonQuery();

                    // Xóa người dùng khỏi bảng tbl_user
                    SqlCommand cmdUser = new SqlCommand(deleteUserQuery, conn);
                    cmdUser.Parameters.AddWithValue("@id_thanhvien", memberId);
                    cmdUser.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while deleting member: " + ex.Message);
            }
        }

        // Tìm kiếm thành viên
        public DataTable SearchMember(string keyword)
        {
            string query = "SELECT * FROM tbl_thanhvien WHERE hoten LIKE @Keyword OR sodt LIKE @Keyword OR email LIKE @Keyword";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    conn.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while searching member: " + ex.Message);
            }
        }
    }
}

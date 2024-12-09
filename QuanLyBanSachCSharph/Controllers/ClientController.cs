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

namespace QuanLyBanSachCSharph.Controllers
{
    //id_docgia INT PRIMARY KEY NOT NULL IDENTITY(1,1), -- Khóa chính tự tăng
    //tendocgia NVARCHAR(200) NOT NULL, -- Tên độc giả, bắt buộc	
    //sodt VARCHAR(20) NOT NULL UNIQUE,
    //email VARCHAR(100), -- Email, không bắt buộc
    //gioitinh NVARCHAR(20), -- Giới tính
    //tongtienthanhtoan MONEY DEFAULT 0 -- Tổng tiền thanh toán, mặc định là 0
    internal class ClientController
    {
        private DBConnect DBConnect = new DBConnect();

        // Thêm độc giả mới
        public void AddCLient(String clientName, string phoneNumber, string email, string sex)
        {
            string query = "INSERT INTO tbl_docgia (tendocgia, sodt, email, gioitinh) VALUES (@tendocgia, @sodt, @email, @gioitinh)";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@tendocgia", clientName);
                    cmd.Parameters.AddWithValue("@sodt", phoneNumber); 
                    cmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(email) ? DBNull.Value : email);
                    cmd.Parameters.AddWithValue("@gioitinh", string.IsNullOrEmpty(sex) ? DBNull.Value : sex);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }                 
            }
            catch (Exception ex)
            {
                throw new Exception("Error while adding client: " + ex.Message);
            }
        }

        // Cập nhật thông tin độc giả
        public void UpdateClient(int clientId, string clientName, string phoneNumber, string email, string sex)
        {
            string query = "UPDATE tbl_docgia SET tendocgia = @tendocgia, sodt = @sodt, email = @email, gioitinh = @gioitinh WHERE id_docgia = @id_docgia";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@tendocgia", clientName);
                    cmd.Parameters.AddWithValue("@sodt", phoneNumber);
                    cmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(email) ? DBNull.Value : email);
                    cmd.Parameters.AddWithValue("@gioitinh", string.IsNullOrEmpty(sex) ? DBNull.Value : sex);
                    cmd.Parameters.AddWithValue("@id_docgia", clientId);                    
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while updating client: " + ex.Message);
            }
        }

        // Xóa độc giả
        public void DeleteClient(int clientId)
        {
            string query = "DELETE FROM tbl_docgia WHERE id_docgia = @id_docgia";
            {
                try
                {
                    using (SqlConnection conn = DBConnect.GetConnection())
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id_docgia", clientId);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error while updating client: " + ex.Message);
                }
            }
        }

        // Tìm kiếm độc giả
        public DataTable SearchClient(string keyword)
        {
            string query = "SELECT * FROM tbl_docgia WHERE tendocgia LIKE @Keyword OR sodt LIKE @Keyword OR email LIKE @Keyword";
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
                throw new Exception("Error while deleting client: " + ex.Message);
            }
        }
    }
}

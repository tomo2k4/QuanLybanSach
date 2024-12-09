using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSachCSharph.Controllers
{
    public class TheloaiController
    {
        private readonly DBConnect dbConnect = new DBConnect();

        // Lấy danh sách thể loại từ cơ sở dữ liệu và trả về Dictionary
        public Dictionary<string, string> GetTheLoaiMap()
        {
            Dictionary<string, string> theLoaiMap = new Dictionary<string, string>();
            using (SqlConnection conn = dbConnect.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_theloai, tentheloai FROM tbl_theloai";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string idTheLoai = reader["id_theloai"].ToString();
                            string tenTheLoai = reader["tentheloai"].ToString();
                            theLoaiMap[tenTheLoai] = idTheLoai; // Lưu key là tên thể loại, value là ID
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải danh sách thể loại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return theLoaiMap;
        }




    }
}

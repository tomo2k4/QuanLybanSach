using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSachCSharph.Controllers
{
    public class TacGiaController
    {
        private DBConnect DBConnect = new DBConnect();

        public DataTable GetAuthors()
        {
            string query = "SELECT id_tacgia, tentacgia, linhvuc, gioithieu FROM tbl_tacgia";

            using (SqlConnection conn = DBConnect.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable authorsTable = new DataTable();
                    sda.Fill(authorsTable);
                    return authorsTable;
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi lấy dữ liệu tác giả: " + ex.Message);
                }
            }
        }
    }
}

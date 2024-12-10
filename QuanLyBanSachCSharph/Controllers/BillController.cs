using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSachCSharph.Controllers
{
    internal class BillController
    {
        DBConnect DBConnect = new DBConnect();

        public DataTable GetBooks()
        {
            string query = "SELECT * FROM Books";

            using (SqlConnection conn = DBConnect.GetConnection())
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                var ds = new DataSet();
                sda.Fill(ds);

                // Return the first table from the DataSet
                return ds.Tables[0];
            }
        }


        public void UpdateBookStock(int newQty, int key)
        {
            string query = $"UPDATE Books SET BQty = {newQty} WHERE BId = {key};";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Updated Successfully!");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public float CalculateTotal(int quantity, float price)
        {
            return quantity * price;
        }

        // Phương thức tính tổng doanh thu
        public decimal GetTotalRevenue()
        {
            decimal totalRevenue = 0;
            string query = "SELECT SUM(giasach) FROM tbl_Hoadon INNER JOIN tbl_sach ON tbl_Hoadon.id_sach = tbl_sach.id_sach";

            using (SqlConnection conn = DBConnect.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        totalRevenue = (decimal)cmd.ExecuteScalar(); // Lấy tổng giá trị doanh thu từ cơ sở dữ liệu
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi tính tổng doanh thu: " + ex.Message);
                }
            }

            return totalRevenue;
        }


    }
}

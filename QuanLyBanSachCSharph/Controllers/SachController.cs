using Microsoft.Data.SqlClient;
using QuanLyBanSachCSharph.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSachCSharph.Controllers
{
    public class SachController
    {
        private readonly DBConnect dbConnect = new DBConnect();

        public bool AddBook(SachModel obj)
        {
            using (SqlConnection conn = dbConnect.GetConnection())
            {
                try
                {
                    conn.Open();

                    // Kiểm tra id_tacgia
                    string checkTacGiaQuery = "SELECT COUNT(*) FROM tbl_tacgia WHERE id_tacgia = @IdTacGia";
                    using (SqlCommand cmdCheckTacGia = new SqlCommand(checkTacGiaQuery, conn))
                    {
                        cmdCheckTacGia.Parameters.AddWithValue("@IdTacGia", obj.idtacgia);
                        int tacGiaCount = (int)cmdCheckTacGia.ExecuteScalar();
                        if (tacGiaCount <= 0)
                        {
                            MessageBox.Show("id_tacgia không tồn tại trong bảng tbl_tacgia.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                    // Kiểm tra id_theloai
                    string checkTheLoaiQuery = "SELECT COUNT(*) FROM tbl_theloai WHERE id_theloai = @IdTheLoai";
                    using (SqlCommand cmdCheckTheLoai = new SqlCommand(checkTheLoaiQuery, conn))
                    {
                        cmdCheckTheLoai.Parameters.AddWithValue("@IdTheLoai", obj.idtheloai);
                        int theLoaiCount = (int)cmdCheckTheLoai.ExecuteScalar();
                        if (theLoaiCount <= 0)
                        {
                            MessageBox.Show("id_theloai không tồn tại trong bảng tbl_theloai.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                    // Thực hiện câu lệnh INSERT
                    string insertQuery = @"
                        INSERT INTO tbl_sach 
                        (tensach, id_tacgia, id_theloai, nhaxuatban, giasach, soluong, ngaynhan, anhsach) 
                        VALUES 
                        (@TenSach, @IdTacGia, @IdTheLoai, @NhaXuatBan, @GiaSach, @SoLuong, @NgayNhan, @AnhSach)";

                    using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                    {
                        cmdInsert.Parameters.AddWithValue("@TenSach", obj.tensach);
                        cmdInsert.Parameters.AddWithValue("@IdTacGia", obj.idtacgia);
                        cmdInsert.Parameters.AddWithValue("@IdTheLoai", obj.idtheloai);
                        cmdInsert.Parameters.AddWithValue("@NhaXuatBan", obj.nhaxuatban ?? (object)DBNull.Value); // Xử lý null
                        cmdInsert.Parameters.AddWithValue("@GiaSach", obj.giasach ?? "0"); // Xử lý null
                        cmdInsert.Parameters.AddWithValue("@SoLuong", obj.soluong ?? "0"); // Xử lý null
                        cmdInsert.Parameters.AddWithValue("@NgayNhan", obj.ngaynhan ?? DateTime.Now.ToString("yyyy-MM-dd"));
                        cmdInsert.Parameters.AddWithValue("@AnhSach", obj.anhsach ?? (object)DBNull.Value); // Xử lý null

                        int rowsAffected = cmdInsert.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm sách. Hãy thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public DataTable GetAllBooks()
        {
            DataTable booksTable = new DataTable();

            try
            {
                using (SqlConnection conn = dbConnect.GetConnection())
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    id_sach, 
                    tensach, 
                    id_tacgia, 
                    id_theloai, 
                    nhaxuatban, 
                    giasach, 
                    soluong, 
                    ngaynhan, 
                    trangthai, 
                    anhsach 
                FROM tbl_sach";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(booksTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi khi lấy dữ liệu sách: " + ex.Message);
            }

            return booksTable;
        }









    }
}

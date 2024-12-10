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

                    // Check if id_tacgia exists
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

                    // Check if id_theloai exists
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

                    // Insert book data into tbl_sach
                    string insertQuery = @"
                INSERT INTO tbl_sach 
                (tensach, id_tacgia, id_theloai, nhaxuatban, giasach, soluong, ngaynhan, trangthai, anhsach) 
                VALUES 
                (@TenSach, @IdTacGia, @IdTheLoai, @NhaXuatBan, @GiaSach, @SoLuong, @NgayNhan, @TrangThai, @AnhSach)";

                    using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                    {
                        cmdInsert.Parameters.AddWithValue("@TenSach", obj.tensach ?? (object)DBNull.Value);
                        cmdInsert.Parameters.AddWithValue("@IdTacGia", obj.idtacgia);
                        cmdInsert.Parameters.AddWithValue("@IdTheLoai", obj.idtheloai);
                        cmdInsert.Parameters.AddWithValue("@NhaXuatBan", obj.nhaxuatban ?? (object)DBNull.Value);
                        cmdInsert.Parameters.AddWithValue("@GiaSach", obj.giasach ?? (object)DBNull.Value);
                        cmdInsert.Parameters.AddWithValue("@SoLuong", obj.soluong ?? (object)DBNull.Value);
                        cmdInsert.Parameters.AddWithValue("@NgayNhan", obj.ngaynhan ?? DateTime.Now.ToString("yyyy-MM-dd"));

                        // Handle null or binary data for anhsach
                        if (obj.anhsach != null)
                        {
                            cmdInsert.Parameters.AddWithValue("@AnhSach", obj.anhsach);
                        }
                        else
                        {
                            cmdInsert.Parameters.AddWithValue("@AnhSach", DBNull.Value);
                        }

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
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Lỗi SQL: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
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

        public DataTable SearchBooks(string searchTerm)
        {
            using (SqlConnection conn = dbConnect.GetConnection())
            {
                try
                {
                    conn.Open();

                    // Truy vấn tìm kiếm theo nhiều trường
                    string searchQuery = @"
                        SELECT s.id_sach, s.tensach, s.id_tacgia, tg.tentacgia, s.id_theloai, tl.tentheloai, 
                               s.nhaxuatban, s.giasach, s.soluong, s.ngaynhan, s.trangthai, s.anhsach
                        FROM tbl_sach s
                        LEFT JOIN tbl_tacgia tg ON s.id_tacgia = tg.id_tacgia
                        LEFT JOIN tbl_theloai tl ON s.id_theloai = tl.id_theloai
                        WHERE s.id_sach LIKE @SearchTerm 
                           OR s.tensach LIKE @SearchTerm
                           OR tg.tentacgia LIKE @SearchTerm
                           OR s.id_tacgia LIKE @SearchTerm
                           OR tl.tentheloai LIKE @SearchTerm
                           OR s.id_theloai LIKE @SearchTerm";

                    using (SqlCommand cmd = new SqlCommand(searchQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable searchResults = new DataTable();
                        adapter.Fill(searchResults);
                        return searchResults;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi tìm kiếm: " + ex.Message);
                }
            }
        }

        public bool UpdateBook(SachModel obj)
        {
            using (SqlConnection conn = dbConnect.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                UPDATE tbl_sach
                SET tensach = @TenSach, id_tacgia = @IdTacGia, id_theloai = @IdTheLoai, 
                    nhaxuatban = @NhaXuatBan, giasach = @GiaSach, soluong = @SoLuong, 
                    ngaynhan = @NgayNhan, anhsach = @AnhSach
                WHERE id_sach = @IdSach";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdSach", obj.idsach);
                        cmd.Parameters.AddWithValue("@TenSach", obj.tensach);
                        cmd.Parameters.AddWithValue("@IdTacGia", obj.idtacgia);
                        cmd.Parameters.AddWithValue("@IdTheLoai", obj.idtheloai);
                        cmd.Parameters.AddWithValue("@NhaXuatBan", obj.nhaxuatban ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@GiaSach", obj.giasach ?? "0");
                        cmd.Parameters.AddWithValue("@SoLuong", obj.soluong ?? "0");
                        cmd.Parameters.AddWithValue("@NgayNhan", obj.ngaynhan ?? DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@AnhSach", obj.anhsach ?? (object)DBNull.Value);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi sửa sách: " + ex.Message);
                }
            }
        }

        public bool DeleteBook(int idSach)
        {
            using (SqlConnection conn = dbConnect.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM tbl_sach WHERE id_sach = @IdSach";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdSach", idSach);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi xóa sách: " + ex.Message);
                }
            }
        }



        public int GetTotalBooks()
        {
            int totalBooks = 0;
            string query = "SELECT COUNT(*) AS total FROM tbl_sach";

            using (SqlConnection conn = dbConnect.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        totalBooks = (int)cmd.ExecuteScalar(); // Lấy kết quả đếm từ cơ sở dữ liệu
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi lấy tổng số sách: " + ex.Message);
                }
            }

            return totalBooks;
        }




    }
}

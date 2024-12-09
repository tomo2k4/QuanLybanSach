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
            String query = "SELECT * FROM Books";

            using (SqlConnection conn = DBConnect.GetConnection())
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                var ds = new DataSet();
                sda.Fill(ds);
                conn.Close();

                return ds.Tables[0];
            }
        }

        public void UpdateBook(int newQty, int key)
        {
            string query = "UPDATE Books SET BQty = {newQty} WHERE BId = {key};";
            try
            {
                using (SqlConnection conn = DBConnect.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool ValidateStock(int stock, int requestedQuantity)
        {
            return requestedQuantity > 0 && requestedQuantity < stock;
        }

        public float CalculateTotal(int quantity, float price)
        {
            return quantity * price;
        }
    }
}

using Microsoft.Data.SqlClient;
using System.Data;
using QuanLyBanSachCSharph.Controllers;

namespace BookShop
{
    public partial class Billing : Form
    {
        private BillController billController = new BillController();
        private DBConnect dbConnect = new DBConnect();
        private float gridTotal = 0;
        private int stock = 0;
        private int key = 0;
        private int n = 0;

        public Billing()
        {
            InitializeComponent();
            ShowData();
        }

        private void ShowData()
        {
            dgvList.DataSource = billController.GetBooks();
        }

        private void UpdateBook()
        {
            int newQty = stock - Convert.ToInt32(tbQuantity.Text);
            try
            {
                billController.UpdateBookStock(key, newQty);

                MessageBox.Show("Book Updated Successfully!");
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reset()
        {
            tbBookName.Text = "";
            tbQuantity.Text = "";
            tbClientName.Text = "";
            tbPrice.Text = "";

            key = 0; // Reset giá trị khóa
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbQuantity.Text) || !int.TryParse(tbQuantity.Text, out int quantity) || quantity > stock || quantity <= 0)
            {
                MessageBox.Show("No Enough Stock!");
                return;
            }
            else if (tbBookName.Text == "" || tbQuantity.Text == "" || tbClientName.Text == "" || tbPrice.Text == "")
            {
                MessageBox.Show("Info Missing!");
                return;
            }
            else
            {
                //int quantity = Convert.ToInt32(tbQuantity.Text);
                float price;
                bool isValidPrice = float.TryParse(tbPrice.Text, out price);

                float total = billController.CalculateTotal(quantity, price);

                DataGridViewRow newRow = new DataGridViewRow();

                // Đảm bảo rằng các cột trong dgvBill đã được tạo
                if (dgvBill.Columns.Count == 0)
                {
                    dgvBill.Columns.Add("Column1", "ID");
                    dgvBill.Columns.Add("Column2", "Books");
                    dgvBill.Columns.Add("Column3", "Quantity");
                    dgvBill.Columns.Add("Column4", "Price");
                    dgvBill.Columns.Add("Column5", "Total");
                }

                newRow.CreateCells(dgvBill);

                newRow.Cells[0].Value = ++n;
                newRow.Cells[1].Value = tbBookName.Text;
                newRow.Cells[2].Value = tbQuantity.Text;
                newRow.Cells[3].Value = tbPrice.Text;
                newRow.Cells[4].Value = total;

                dgvBill.Rows.Add(newRow);

                UpdateBook();
                gridTotal = gridTotal + total;
                lblTotal.Text = "Total: " + gridTotal;

                Reset();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvList.SelectedRows.Count > 0) // Kiểm tra có hàng nào được chọn
            {

                tbBookName.Text = dgvList.SelectedRows[0].Cells[1].Value.ToString();
                tbQuantity.Text = dgvList.SelectedRows[0].Cells[4].Value.ToString();
                tbPrice.Text = dgvList.SelectedRows[0].Cells[5].Value.ToString();

                key = Convert.ToInt32(dgvList.SelectedRows[0].Cells[0].Value.ToString());
                stock = Convert.ToInt32(dgvList.SelectedRows[0].Cells[4].Value.ToString());
            }
            else
            {
                key = 0;
                stock = 0;
            }
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

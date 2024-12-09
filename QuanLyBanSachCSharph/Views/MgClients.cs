using QuanLyBanSachCSharph.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSachCSharph.Views
{
    public partial class MgClients : Form
    {
        private ClientController clientController = new ClientController();

        public MgClients()
        {
            InitializeComponent();
            LoadClients();
            SetNull();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtClientName.Text.Trim();
                string phone = txtPhoneNumber.Text.Trim();
                // email và sex có thể để null
                string email = string.IsNullOrWhiteSpace(txtEmail.Text) ? "" : txtEmail.Text.Trim();
                string? sex = cbSex.SelectedItem?.ToString();

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone))
                {
                    MessageBox.Show("Name and phone are required.");
                    return;
                }

                clientController.AddCLient(name, phone, email, sex);

                MessageBox.Show("Added new client successfully!");
                LoadClients();
                SetNull();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (tblClient.SelectedRows.Count > 0)
                {
                    int clientId = Convert.ToInt32(tblClient.SelectedRows[0].Cells["id_docgia"].Value);
                    string name = txtClientName.Text.Trim();
                    string phone = txtPhoneNumber.Text.Trim();
                    // email và sex có thể để null
                    string email = string.IsNullOrWhiteSpace(txtEmail.Text) ? "" : txtEmail.Text.Trim(); ;
                    string? sex = cbSex.SelectedItem?.ToString();

                    if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone))
                    {
                        MessageBox.Show("Name and phone are required.");
                        return;
                    }

                    clientController.UpdateClient(clientId, name, phone, email, sex);

                    MessageBox.Show("Updated client info successfully!");
                    LoadClients();
                    SetNull();
                }
                else
                {
                    MessageBox.Show("Please select a client to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (tblClient.SelectedRows.Count > 0)
                {
                    int clientId = Convert.ToInt32(tblClient.SelectedRows[0].Cells["id_docgia"].Value);

                    clientController.DeleteClient(clientId);

                    MessageBox.Show("Deleted client successfully!");
                    LoadClients();
                }
                else
                {
                    MessageBox.Show("Please choose client to delete!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearch.Text;
                DataTable result = clientController.SearchClient(keyword);
                tblClient.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetNull();
        }

        private void LoadClients()
        {
            try
            {
                DataTable clients = clientController.SearchClient("");
                tblClient.DataSource = clients;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SetNull()
        {
            txtSearch.Text = ""; // Xóa ô tìm kiếm
            txtClientName.Text = ""; // Xóa ô nhập tên khách hàng
            txtPhoneNumber.Text = ""; // Xóa ô nhập số điện thoại
            txtEmail.Text = ""; // Xóa ô nhập email
            cbSex.SelectedIndex = -1; // Đặt trạng thái ban đầu của ComboBox
        }

        private void picLoad_Click(object sender, EventArgs e)
        {
            LoadClients();
            SetNull();
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tblClient_CellContentClick(object sender, EventArgs e)
        {
            if (tblClient.SelectedRows.Count > 0)
            {
                txtClientName.Text = tblClient.SelectedRows[0].Cells["tendocgia"].Value.ToString();
                txtPhoneNumber.Text = tblClient.SelectedRows[0].Cells["sodt"].Value.ToString();
                txtEmail.Text = tblClient.SelectedRows[0].Cells["email"].Value == DBNull.Value ? "" : tblClient.SelectedRows[0].Cells["email"].Value.ToString();
                cbSex.SelectedItem = tblClient.SelectedRows[0].Cells["gioitinh"].Value == DBNull.Value ? null : tblClient.SelectedRows[0].Cells["gioitinh"].Value.ToString();
            }
        }
    }
}

namespace QuanLyBanSachCSharph.Views
{
    partial class Clients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnReset = new Button();
            lblMiniTitle = new Label();
            lblList = new Label();
            tbAddress = new TextBox();
            tbPhoneNumber = new TextBox();
            tbClientName = new TextBox();
            lblAddress = new Label();
            lblPhoneNumber = new Label();
            lblClientName = new Label();
            dgvList = new DataGridView();
            btnBooks = new Button();
            panel1 = new Panel();
            btnDashboard = new Button();
            btnClients = new Button();
            btnLogOut = new Button();
            lblTitle = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(lblMiniTitle);
            panel2.Controls.Add(lblList);
            panel2.Controls.Add(tbAddress);
            panel2.Controls.Add(tbPhoneNumber);
            panel2.Controls.Add(tbClientName);
            panel2.Controls.Add(lblAddress);
            panel2.Controls.Add(lblPhoneNumber);
            panel2.Controls.Add(lblClientName);
            panel2.Controls.Add(dgvList);
            panel2.Location = new Point(205, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1047, 737);
            panel2.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.Font = new Font("Microsoft Sans Serif", 15.75F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(293, 201);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 42);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.ForestGreen;
            btnEdit.Font = new Font("Microsoft Sans Serif", 15.75F);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(415, 201);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 42);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.ForestGreen;
            btnDelete.Font = new Font("Microsoft Sans Serif", 15.75F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(535, 201);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 42);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.ForestGreen;
            btnReset.Font = new Font("Microsoft Sans Serif", 15.75F);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(655, 201);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 42);
            btnReset.TabIndex = 15;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // lblMiniTitle
            // 
            lblMiniTitle.AutoSize = true;
            lblMiniTitle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMiniTitle.ForeColor = Color.ForestGreen;
            lblMiniTitle.Location = new Point(460, 10);
            lblMiniTitle.Name = "lblMiniTitle";
            lblMiniTitle.Size = new Size(119, 25);
            lblMiniTitle.TabIndex = 12;
            lblMiniTitle.Text = "BookShop";
            // 
            // lblList
            // 
            lblList.AutoSize = true;
            lblList.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblList.ForeColor = Color.ForestGreen;
            lblList.Location = new Point(443, 264);
            lblList.Name = "lblList";
            lblList.Size = new Size(160, 31);
            lblList.TabIndex = 10;
            lblList.Text = "Clients List";
            // 
            // tbAddress
            // 
            tbAddress.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAddress.Location = new Point(508, 136);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(220, 31);
            tbAddress.TabIndex = 8;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPhoneNumber.Location = new Point(268, 136);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(220, 31);
            tbPhoneNumber.TabIndex = 7;
            // 
            // tbClientName
            // 
            tbClientName.Enabled = false;
            tbClientName.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbClientName.Location = new Point(26, 136);
            tbClientName.Name = "tbClientName";
            tbClientName.Size = new Size(220, 31);
            tbClientName.TabIndex = 6;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = SystemColors.Window;
            lblAddress.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(508, 101);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(91, 25);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(268, 102);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(155, 25);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClientName.Location = new Point(26, 102);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(129, 25);
            lblClientName.TabIndex = 2;
            lblClientName.Text = "Client Name";
            // 
            // dgvList
            // 
            dgvList.BackgroundColor = Color.White;
            dgvList.BorderStyle = BorderStyle.Fixed3D;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(0, 317);
            dgvList.MultiSelect = false;
            dgvList.Name = "dgvList";
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.Size = new Size(1047, 420);
            dgvList.TabIndex = 1;
            // 
            // btnBooks
            // 
            btnBooks.BackColor = Color.Black;
            btnBooks.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBooks.ForeColor = Color.White;
            btnBooks.Location = new Point(14, 125);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(170, 52);
            btnBooks.TabIndex = 13;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnClients);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnBooks);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 737);
            panel1.TabIndex = 2;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Black;
            btnDashboard.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(14, 325);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(170, 52);
            btnDashboard.TabIndex = 18;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnClients
            // 
            btnClients.BackColor = Color.ForestGreen;
            btnClients.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClients.ForeColor = Color.White;
            btnClients.Location = new Point(14, 224);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(170, 52);
            btnClients.TabIndex = 17;
            btnClients.Text = "Clients";
            btnClients.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Black;
            btnLogOut.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(11, 671);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(173, 50);
            btnLogOut.TabIndex = 16;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(14, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(173, 37);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "BookShop";
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1264, 761);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Users";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lblTotal;
        private Button btnPrintBill;
        private Button btnReset;
        private Label lblMiniTitle;
        private Label lblList;
        private TextBox tbAddress;
        private TextBox tbPhoneNumber;
        private TextBox tbUsername;
        private Label lblAddress;
        private Label lblPhoneNumber;
        private Label lblUserName;
        private DataGridView dgvList;
        private Button btnBooks;
        private Panel panel1;
        private Button btnLogOut;
        private Label lblTitle;
        private Button btnDashboard;
        private Button btnUsers;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private TextBox tbClientName;
        private Label lblClientName;
        private Button btnClients;
    }
}
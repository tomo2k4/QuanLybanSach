
namespace QuanLyBanSachCSharph.Views
{
    partial class MgClients
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MgClients));
            lblTitle = new Label();
            picLoad = new PictureBox();
            txtSearch = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            CloseForm = new PictureBox();
            lbClientList = new Label();
            pnTitle = new Panel();
            btnSearch = new Button();
            tblClient = new DataGridView();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            lblPhoneNumber = new Label();
            txtClientName = new TextBox();
            lblCientName = new Label();
            txtPhoneNumber = new TextBox();
            lblEmail = new Label();
            pnFiller = new Panel();
            txtEmail = new TextBox();
            lblSex = new Label();
            cbSex = new ComboBox();
            picClientName = new PictureBox();
            picSex = new PictureBox();
            picPhoneNum = new PictureBox();
            picEmail = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picLoad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseForm).BeginInit();
            pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblClient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClientName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPhoneNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEmail).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Brown;
            lblTitle.Location = new Point(398, 9);
            lblTitle.Margin = new Padding(6, 0, 6, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(240, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BOOKSHOP";
            // 
            // picLoad
            // 
            picLoad.Image = (Image)resources.GetObject("picLoad.Image");
            picLoad.Location = new Point(932, 81);
            picLoad.Margin = new Padding(5);
            picLoad.Name = "picLoad";
            picLoad.Size = new Size(55, 53);
            picLoad.SizeMode = PictureBoxSizeMode.CenterImage;
            picLoad.TabIndex = 54;
            picLoad.TabStop = false;
            picLoad.Click += picLoad_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Microsoft Sans Serif", 12F);
            txtSearch.Location = new Point(567, 92);
            txtSearch.Margin = new Padding(5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(198, 30);
            txtSearch.TabIndex = 63;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // CloseForm
            // 
            CloseForm.Image = (Image)resources.GetObject("CloseForm.Image");
            CloseForm.Location = new Point(945, 0);
            CloseForm.Margin = new Padding(5);
            CloseForm.Name = "CloseForm";
            CloseForm.Size = new Size(55, 53);
            CloseForm.SizeMode = PictureBoxSizeMode.CenterImage;
            CloseForm.TabIndex = 22;
            CloseForm.TabStop = false;
            CloseForm.Click += CloseForm_Click;
            // 
            // lbClientList
            // 
            lbClientList.AutoSize = true;
            lbClientList.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbClientList.ForeColor = Color.Brown;
            lbClientList.Location = new Point(397, 92);
            lbClientList.Margin = new Padding(6, 0, 6, 0);
            lbClientList.Name = "lbClientList";
            lbClientList.Size = new Size(159, 32);
            lbClientList.TabIndex = 60;
            lbClientList.Text = "Client List ";
            // 
            // pnTitle
            // 
            pnTitle.Controls.Add(lblTitle);
            pnTitle.Controls.Add(CloseForm);
            pnTitle.Location = new Point(0, 0);
            pnTitle.Margin = new Padding(5);
            pnTitle.Name = "pnTitle";
            pnTitle.Size = new Size(1000, 77);
            pnTitle.TabIndex = 57;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.IndianRed;
            btnSearch.Font = new Font("Microsoft Sans Serif", 13.2000008F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(774, 80);
            btnSearch.Margin = new Padding(5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(149, 61);
            btnSearch.TabIndex = 55;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tblClient
            // 
            tblClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblClient.Location = new Point(45, 151);
            tblClient.Margin = new Padding(5);
            tblClient.MultiSelect = false;
            tblClient.Name = "tblClient";
            tblClient.RowHeadersWidth = 51;
            tblClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblClient.Size = new Size(924, 262);
            tblClient.TabIndex = 53;
            tblClient.CellContentClick += tblClient_CellContentClick;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Brown;
            btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(723, 732);
            btnClear.Margin = new Padding(5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(149, 46);
            btnClear.TabIndex = 48;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(516, 732);
            btnDelete.Margin = new Padding(5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(149, 46);
            btnDelete.TabIndex = 47;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Brown;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(315, 732);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(149, 46);
            btnUpdate.TabIndex = 46;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Brown;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(115, 732);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(149, 46);
            btnAdd.TabIndex = 45;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(209, 598);
            lblPhoneNumber.Margin = new Padding(6, 0, 6, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(176, 29);
            lblPhoneNumber.TabIndex = 39;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // txtClientName
            // 
            txtClientName.Font = new Font("Microsoft Sans Serif", 12F);
            txtClientName.Location = new Point(195, 511);
            txtClientName.Margin = new Padding(5);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(297, 30);
            txtClientName.TabIndex = 37;
            // 
            // lblCientName
            // 
            lblCientName.AutoSize = true;
            lblCientName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCientName.Location = new Point(209, 470);
            lblCientName.Margin = new Padding(6, 0, 6, 0);
            lblCientName.Name = "lblCientName";
            lblCientName.Size = new Size(146, 29);
            lblCientName.TabIndex = 35;
            lblCientName.Text = "Client Name";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Microsoft Sans Serif", 12F);
            txtPhoneNumber.Location = new Point(197, 640);
            txtPhoneNumber.Margin = new Padding(5);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(297, 30);
            txtPhoneNumber.TabIndex = 65;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(626, 598);
            lblEmail.Margin = new Padding(6, 0, 6, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(74, 29);
            lblEmail.TabIndex = 52;
            lblEmail.Text = "Email";
            // 
            // pnFiller
            // 
            pnFiller.BackColor = Color.LightCoral;
            pnFiller.Dock = DockStyle.Bottom;
            pnFiller.Location = new Point(0, 798);
            pnFiller.Name = "pnFiller";
            pnFiller.Size = new Size(1000, 52);
            pnFiller.TabIndex = 67;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F);
            txtEmail.Location = new Point(614, 640);
            txtEmail.Margin = new Padding(5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(297, 30);
            txtEmail.TabIndex = 68;
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSex.Location = new Point(627, 470);
            lblSex.Margin = new Padding(6, 0, 6, 0);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(94, 29);
            lblSex.TabIndex = 69;
            lblSex.Text = "Gender";
            // 
            // cbSex
            // 
            cbSex.Font = new Font("Microsoft Sans Serif", 12F);
            cbSex.FormattingEnabled = true;
            cbSex.Items.AddRange(new object[] { "Male", "Female" });
            cbSex.Location = new Point(614, 506);
            cbSex.Margin = new Padding(3, 4, 3, 4);
            cbSex.Name = "cbSex";
            cbSex.Size = new Size(182, 33);
            cbSex.TabIndex = 71;
            // 
            // picClientName
            // 
            picClientName.Image = Properties.Resources.icons8_book_64;
            picClientName.Location = new Point(114, 470);
            picClientName.Margin = new Padding(3, 4, 3, 4);
            picClientName.Name = "picClientName";
            picClientName.Size = new Size(73, 76);
            picClientName.TabIndex = 72;
            picClientName.TabStop = false;
            // 
            // picSex
            // 
            picSex.Image = (Image)resources.GetObject("picSex.Image");
            picSex.Location = new Point(534, 470);
            picSex.Margin = new Padding(3, 4, 3, 4);
            picSex.Name = "picSex";
            picSex.Size = new Size(73, 73);
            picSex.TabIndex = 73;
            picSex.TabStop = false;
            // 
            // picPhoneNum
            // 
            picPhoneNum.Image = (Image)resources.GetObject("picPhoneNum.Image");
            picPhoneNum.Location = new Point(114, 598);
            picPhoneNum.Margin = new Padding(3, 4, 3, 4);
            picPhoneNum.Name = "picPhoneNum";
            picPhoneNum.Size = new Size(73, 80);
            picPhoneNum.TabIndex = 74;
            picPhoneNum.TabStop = false;
            // 
            // picEmail
            // 
            picEmail.Image = Properties.Resources.icons8_email_64;
            picEmail.Location = new Point(534, 598);
            picEmail.Margin = new Padding(3, 4, 3, 4);
            picEmail.Name = "picEmail";
            picEmail.Size = new Size(73, 77);
            picEmail.TabIndex = 75;
            picEmail.TabStop = false;
            // 
            // MgClients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 850);
            Controls.Add(picEmail);
            Controls.Add(picPhoneNum);
            Controls.Add(picSex);
            Controls.Add(picClientName);
            Controls.Add(cbSex);
            Controls.Add(lblSex);
            Controls.Add(txtEmail);
            Controls.Add(pnFiller);
            Controls.Add(txtPhoneNumber);
            Controls.Add(picLoad);
            Controls.Add(txtSearch);
            Controls.Add(lbClientList);
            Controls.Add(pnTitle);
            Controls.Add(btnSearch);
            Controls.Add(tblClient);
            Controls.Add(lblEmail);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtClientName);
            Controls.Add(lblCientName);
            Cursor = Cursors.SizeAll;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MgClients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picLoad).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseForm).EndInit();
            pnTitle.ResumeLayout(false);
            pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblClient).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClientName).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSex).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPhoneNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEmail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private Label lblTotal;
        private Button btnPrintBill;
        private TextBox tbUsername;
        private Label lblUserName;
        private Button btnUsers;
        private Label lblTitle;
        private PictureBox picLoad;
        private TextBox txtSearch;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox CloseForm;
        private Label lbClientList;
        private TextBox txtNhaxuatban;
        private Panel pnTitle;
        private Button btnSearch;
        private DataGridView tblClient;
        private DateTimePicker dtimerNhap;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtGiasach;
        private TextBox txtSoluong;
        private ComboBox cmbTheloai;
        private Label lblPhoneNumber;
        private TextBox txtClientName;
        private Label lblCientName;
        private TextBox txtPhoneNumber;
        private Label lblEmail;
        private Panel pnFiller;
        private TextBox txtEmail;
        private Label lblSex;
        private ComboBox cbSex;
        private PictureBox picClientName;
        private PictureBox picSex;
        private PictureBox picPhoneNum;
        private PictureBox picEmail;
    }
}
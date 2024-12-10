
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
            lblTitle.Location = new Point(461, 7);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(190, 36);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BOOKSHOP";
            // 
            // picLoad
            // 
            picLoad.Image = (Image)resources.GetObject("picLoad.Image");
            picLoad.Location = new Point(1070, 66);
            picLoad.Margin = new Padding(4);
            picLoad.Name = "picLoad";
            picLoad.Size = new Size(48, 40);
            picLoad.SizeMode = PictureBoxSizeMode.CenterImage;
            picLoad.TabIndex = 54;
            picLoad.TabStop = false;
            picLoad.Click += picLoad_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Microsoft Sans Serif", 12F);
            txtSearch.Location = new Point(664, 74);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(260, 26);
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
            CloseForm.Location = new Point(1093, 0);
            CloseForm.Margin = new Padding(4);
            CloseForm.Name = "CloseForm";
            CloseForm.Size = new Size(48, 40);
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
            lbClientList.Location = new Point(494, 71);
            lbClientList.Margin = new Padding(5, 0, 5, 0);
            lbClientList.Name = "lbClientList";
            lbClientList.Size = new Size(126, 26);
            lbClientList.TabIndex = 60;
            lbClientList.Text = "Client List ";
            // 
            // pnTitle
            // 
            pnTitle.Controls.Add(lblTitle);
            pnTitle.Controls.Add(CloseForm);
            pnTitle.Dock = DockStyle.Top;
            pnTitle.Location = new Point(0, 0);
            pnTitle.Margin = new Padding(4);
            pnTitle.Name = "pnTitle";
            pnTitle.Size = new Size(1141, 58);
            pnTitle.TabIndex = 57;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.IndianRed;
            btnSearch.Font = new Font("Microsoft Sans Serif", 13.2000008F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(932, 65);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(130, 46);
            btnSearch.TabIndex = 55;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tblClient
            // 
            tblClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblClient.Location = new Point(20, 113);
            tblClient.Margin = new Padding(4);
            tblClient.MultiSelect = false;
            tblClient.Name = "tblClient";
            tblClient.RowHeadersWidth = 51;
            tblClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblClient.Size = new Size(1098, 440);
            tblClient.TabIndex = 53;
            tblClient.CellContentClick += tblClient_CellContentClick;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Brown;
            btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(830, 769);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 44);
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
            btnDelete.Location = new Point(620, 769);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 44);
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
            btnUpdate.Location = new Point(403, 769);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 44);
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
            btnAdd.Location = new Point(187, 769);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 44);
            btnAdd.TabIndex = 45;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(295, 674);
            lblPhoneNumber.Margin = new Padding(5, 0, 5, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(140, 24);
            lblPhoneNumber.TabIndex = 39;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // txtClientName
            // 
            txtClientName.Font = new Font("Microsoft Sans Serif", 12F);
            txtClientName.Location = new Point(283, 609);
            txtClientName.Margin = new Padding(4);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(260, 26);
            txtClientName.TabIndex = 37;
            // 
            // lblCientName
            // 
            lblCientName.AutoSize = true;
            lblCientName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCientName.Location = new Point(295, 578);
            lblCientName.Margin = new Padding(5, 0, 5, 0);
            lblCientName.Name = "lblCientName";
            lblCientName.Size = new Size(113, 24);
            lblCientName.TabIndex = 35;
            lblCientName.Text = "Client Name";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Microsoft Sans Serif", 12F);
            txtPhoneNumber.Location = new Point(284, 706);
            txtPhoneNumber.Margin = new Padding(4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(260, 26);
            txtPhoneNumber.TabIndex = 65;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(660, 674);
            lblEmail.Margin = new Padding(5, 0, 5, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 24);
            lblEmail.TabIndex = 52;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F);
            txtEmail.Location = new Point(649, 706);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 26);
            txtEmail.TabIndex = 68;
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSex.Location = new Point(661, 578);
            lblSex.Margin = new Padding(5, 0, 5, 0);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(74, 24);
            lblSex.TabIndex = 69;
            lblSex.Text = "Gender";
            // 
            // cbSex
            // 
            cbSex.Font = new Font("Microsoft Sans Serif", 12F);
            cbSex.FormattingEnabled = true;
            cbSex.Items.AddRange(new object[] { "Male", "Female" });
            cbSex.Location = new Point(649, 605);
            cbSex.Name = "cbSex";
            cbSex.Size = new Size(160, 28);
            cbSex.TabIndex = 71;
            // 
            // picClientName
            // 
            picClientName.Image = (Image)resources.GetObject("picClientName.Image");
            picClientName.Location = new Point(212, 578);
            picClientName.Name = "picClientName";
            picClientName.Size = new Size(64, 57);
            picClientName.TabIndex = 72;
            picClientName.TabStop = false;
            // 
            // picSex
            // 
            picSex.Image = (Image)resources.GetObject("picSex.Image");
            picSex.Location = new Point(579, 578);
            picSex.Name = "picSex";
            picSex.Size = new Size(64, 55);
            picSex.TabIndex = 73;
            picSex.TabStop = false;
            // 
            // picPhoneNum
            // 
            picPhoneNum.Image = (Image)resources.GetObject("picPhoneNum.Image");
            picPhoneNum.Location = new Point(212, 674);
            picPhoneNum.Name = "picPhoneNum";
            picPhoneNum.Size = new Size(64, 60);
            picPhoneNum.TabIndex = 74;
            picPhoneNum.TabStop = false;
            // 
            // picEmail
            // 
            picEmail.Image = (Image)resources.GetObject("picEmail.Image");
            picEmail.Location = new Point(579, 674);
            picEmail.Name = "picEmail";
            picEmail.Size = new Size(64, 58);
            picEmail.TabIndex = 75;
            picEmail.TabStop = false;
            // 
            // MgClients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1141, 899);
            Controls.Add(picEmail);
            Controls.Add(picPhoneNum);
            Controls.Add(picSex);
            Controls.Add(picClientName);
            Controls.Add(cbSex);
            Controls.Add(lblSex);
            Controls.Add(txtEmail);
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
        private TextBox txtEmail;
        private Label lblSex;
        private ComboBox cbSex;
        private PictureBox picClientName;
        private PictureBox picSex;
        private PictureBox picPhoneNum;
        private PictureBox picEmail;
    }
}
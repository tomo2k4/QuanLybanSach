namespace QuanLyBanSachCSharph.Views
{
    partial class MgUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MgUsers));
            pnFiller = new Panel();
            txtPhoneNumber = new TextBox();
            picLoad = new PictureBox();
            txtSearch = new TextBox();
            lbUserList = new Label();
            pnTitle = new Panel();
            lblTitle = new Label();
            CloseForm = new PictureBox();
            btnSearch = new Button();
            tblUser = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            lblPhoneNumber = new Label();
            txtClientName = new TextBox();
            lblCientName = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnClear = new Button();
            cbSex = new ComboBox();
            lblSex = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            picEmail = new PictureBox();
            picPhoneNum = new PictureBox();
            pictureBox1 = new PictureBox();
            picUsername = new PictureBox();
            picName = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picLoad).BeginInit();
            pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CloseForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPhoneNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picName).BeginInit();
            SuspendLayout();
            // 
            // pnFiller
            // 
            pnFiller.BackColor = Color.LightCoral;
            pnFiller.Dock = DockStyle.Bottom;
            pnFiller.Location = new Point(0, 840);
            pnFiller.Margin = new Padding(3, 2, 3, 2);
            pnFiller.Name = "pnFiller";
            pnFiller.Size = new Size(1140, 60);
            pnFiller.TabIndex = 87;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Microsoft Sans Serif", 12F);
            txtPhoneNumber.Location = new Point(155, 707);
            txtPhoneNumber.Margin = new Padding(4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(260, 26);
            txtPhoneNumber.TabIndex = 4;
            // 
            // picLoad
            // 
            picLoad.Image = (Image)resources.GetObject("picLoad.Image");
            picLoad.Location = new Point(1076, 63);
            picLoad.Margin = new Padding(4);
            picLoad.Name = "picLoad";
            picLoad.Size = new Size(48, 40);
            picLoad.SizeMode = PictureBoxSizeMode.CenterImage;
            picLoad.TabIndex = 79;
            picLoad.TabStop = false;
            picLoad.Click += picLoad_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Microsoft Sans Serif", 12F);
            txtSearch.Location = new Point(670, 71);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(260, 26);
            txtSearch.TabIndex = 6;
            // 
            // lbUserList
            // 
            lbUserList.AutoSize = true;
            lbUserList.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUserList.ForeColor = Color.Brown;
            lbUserList.Location = new Point(494, 71);
            lbUserList.Margin = new Padding(5, 0, 5, 0);
            lbUserList.Name = "lbUserList";
            lbUserList.Size = new Size(114, 26);
            lbUserList.TabIndex = 82;
            lbUserList.Text = "User List ";
            // 
            // pnTitle
            // 
            pnTitle.Controls.Add(lblTitle);
            pnTitle.Controls.Add(CloseForm);
            pnTitle.Dock = DockStyle.Top;
            pnTitle.Location = new Point(0, 0);
            pnTitle.Margin = new Padding(4);
            pnTitle.Name = "pnTitle";
            pnTitle.Size = new Size(1140, 58);
            pnTitle.TabIndex = 81;
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
            // CloseForm
            // 
            CloseForm.Image = (Image)resources.GetObject("CloseForm.Image");
            CloseForm.Location = new Point(1092, 0);
            CloseForm.Margin = new Padding(4);
            CloseForm.Name = "CloseForm";
            CloseForm.Size = new Size(48, 40);
            CloseForm.SizeMode = PictureBoxSizeMode.CenterImage;
            CloseForm.TabIndex = 22;
            CloseForm.TabStop = false;
            CloseForm.Click += CloseForm_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.IndianRed;
            btnSearch.Font = new Font("Microsoft Sans Serif", 13.2000008F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(938, 62);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(130, 46);
            btnSearch.TabIndex = 80;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tblUser
            // 
            tblUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblUser.Location = new Point(20, 113);
            tblUser.Margin = new Padding(4);
            tblUser.Name = "tblUser";
            tblUser.RowHeadersWidth = 51;
            tblUser.Size = new Size(1100, 440);
            tblUser.TabIndex = 78;
            tblUser.CellContentClick += tblUser_CellContentClick;
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
            btnDelete.TabIndex = 73;
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
            btnUpdate.TabIndex = 72;
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
            btnAdd.TabIndex = 71;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(166, 675);
            lblPhoneNumber.Margin = new Padding(5, 0, 5, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(140, 24);
            lblPhoneNumber.TabIndex = 70;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // txtClientName
            // 
            txtClientName.Font = new Font("Microsoft Sans Serif", 12F);
            txtClientName.Location = new Point(154, 610);
            txtClientName.Margin = new Padding(4);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(260, 26);
            txtClientName.TabIndex = 1;
            // 
            // lblCientName
            // 
            lblCientName.AutoSize = true;
            lblCientName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCientName.Location = new Point(166, 579);
            lblCientName.Margin = new Padding(5, 0, 5, 0);
            lblCientName.Name = "lblCientName";
            lblCientName.Size = new Size(61, 24);
            lblCientName.TabIndex = 68;
            lblCientName.Text = "Name";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
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
            btnClear.TabIndex = 74;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // cbSex
            // 
            cbSex.Font = new Font("Microsoft Sans Serif", 12F);
            cbSex.FormattingEnabled = true;
            cbSex.Items.AddRange(new object[] { "Male", "Female" });
            cbSex.Location = new Point(867, 612);
            cbSex.Name = "cbSex";
            cbSex.Size = new Size(160, 28);
            cbSex.TabIndex = 3;
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSex.Location = new Point(876, 579);
            lblSex.Margin = new Padding(5, 0, 5, 0);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(74, 24);
            lblSex.TabIndex = 91;
            lblSex.Text = "Gender";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F);
            txtEmail.Location = new Point(510, 707);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 26);
            txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(521, 675);
            lblEmail.Margin = new Padding(5, 0, 5, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 24);
            lblEmail.TabIndex = 88;
            lblEmail.Text = "Email";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft Sans Serif", 12F);
            txtUsername.Location = new Point(510, 612);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(260, 26);
            txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(521, 579);
            lblUsername.Margin = new Padding(5, 0, 5, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(97, 24);
            lblUsername.TabIndex = 94;
            lblUsername.Text = "Username";
            // 
            // picEmail
            // 
            picEmail.Image = Properties.Resources.icons8_email_64;
            picEmail.Location = new Point(439, 675);
            picEmail.Name = "picEmail";
            picEmail.Size = new Size(64, 58);
            picEmail.TabIndex = 99;
            picEmail.TabStop = false;
            // 
            // picPhoneNum
            // 
            picPhoneNum.Image = (Image)resources.GetObject("picPhoneNum.Image");
            picPhoneNum.Location = new Point(83, 675);
            picPhoneNum.Name = "picPhoneNum";
            picPhoneNum.Size = new Size(64, 60);
            picPhoneNum.TabIndex = 98;
            picPhoneNum.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(797, 579);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 61);
            pictureBox1.TabIndex = 97;
            pictureBox1.TabStop = false;
            // 
            // picUsername
            // 
            picUsername.Image = (Image)resources.GetObject("picUsername.Image");
            picUsername.Location = new Point(439, 579);
            picUsername.Name = "picUsername";
            picUsername.Size = new Size(64, 58);
            picUsername.TabIndex = 100;
            picUsername.TabStop = false;
            // 
            // picName
            // 
            picName.Image = (Image)resources.GetObject("picName.Image");
            picName.Location = new Point(83, 579);
            picName.Name = "picName";
            picName.Size = new Size(64, 61);
            picName.TabIndex = 101;
            picName.TabStop = false;
            // 
            // MgUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1140, 900);
            Controls.Add(picName);
            Controls.Add(picUsername);
            Controls.Add(picEmail);
            Controls.Add(picPhoneNum);
            Controls.Add(pictureBox1);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(cbSex);
            Controls.Add(lblSex);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(pnFiller);
            Controls.Add(txtPhoneNumber);
            Controls.Add(picLoad);
            Controls.Add(txtSearch);
            Controls.Add(lbUserList);
            Controls.Add(pnTitle);
            Controls.Add(btnSearch);
            Controls.Add(tblUser);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtClientName);
            Controls.Add(lblCientName);
            Controls.Add(btnClear);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MgUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MgUsers";
            ((System.ComponentModel.ISupportInitialize)picLoad).EndInit();
            pnTitle.ResumeLayout(false);
            pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CloseForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPhoneNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)picName).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnFiller;
        private TextBox txtPhoneNumber;
        private PictureBox picLoad;
        private TextBox txtSearch;
        private Label lbUserList;
        private Panel pnTitle;
        private Label lblTitle;
        private PictureBox CloseForm;
        private Button btnSearch;
        private DataGridView tblUser;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label lblPhoneNumber;
        private TextBox txtClientName;
        private Label lblCientName;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnClear;
        private ComboBox cbSex;
        private Label lblSex;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtUsername;
        private Label lblUsername;
        private PictureBox picEmail;
        private PictureBox picPhoneNum;
        private PictureBox pictureBox1;
        private PictureBox picUsername;
        private PictureBox picName;
    }
}
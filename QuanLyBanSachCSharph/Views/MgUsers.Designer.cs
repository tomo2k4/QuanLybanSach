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
            panel2 = new Panel();
            txtPhoneNumber = new TextBox();
            picLoad = new PictureBox();
            txtSearch = new TextBox();
            picPhoneNumber = new TextBox();
            lbUserList = new Label();
            panel1 = new Panel();
            label4 = new Label();
            CloseForm = new PictureBox();
            btnSearch = new Button();
            tblUser = new DataGridView();
            picUser = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            lblPhoneNumber = new Label();
            txtClientName = new TextBox();
            lblCientName = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnClear = new Button();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            lblSex = new Label();
            textBox1 = new TextBox();
            picDate = new TextBox();
            lblEmail = new Label();
            txtUsername = new TextBox();
            textBox4 = new TextBox();
            lblUsername = new Label();
            ((System.ComponentModel.ISupportInitialize)picLoad).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CloseForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblUser).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCoral;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 840);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1140, 60);
            panel2.TabIndex = 87;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Microsoft Sans Serif", 12F);
            txtPhoneNumber.Location = new Point(155, 707);
            txtPhoneNumber.Margin = new Padding(4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(260, 26);
            txtPhoneNumber.TabIndex = 85;
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
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Microsoft Sans Serif", 12F);
            txtSearch.Location = new Point(670, 71);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(260, 26);
            txtSearch.TabIndex = 84;
            // 
            // picPhoneNumber
            // 
            picPhoneNumber.Font = new Font("Microsoft Sans Serif", 12F);
            picPhoneNumber.Location = new Point(108, 707);
            picPhoneNumber.Margin = new Padding(4);
            picPhoneNumber.Name = "picPhoneNumber";
            picPhoneNumber.ReadOnly = true;
            picPhoneNumber.Size = new Size(39, 26);
            picPhoneNumber.TabIndex = 83;
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
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(CloseForm);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1140, 58);
            panel1.TabIndex = 81;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(461, 7);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(190, 36);
            label4.TabIndex = 0;
            label4.Text = "BOOKSHOP";
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
            // 
            // picUser
            // 
            picUser.Font = new Font("Microsoft Sans Serif", 12F);
            picUser.Location = new Point(108, 610);
            picUser.Margin = new Padding(4);
            picUser.Name = "picUser";
            picUser.ReadOnly = true;
            picUser.Size = new Size(39, 26);
            picUser.TabIndex = 75;
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
            txtClientName.TabIndex = 69;
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
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(867, 612);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 28);
            comboBox1.TabIndex = 93;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 12F);
            textBox2.Location = new Point(821, 612);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(39, 26);
            textBox2.TabIndex = 92;
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSex.Location = new Point(876, 579);
            lblSex.Margin = new Padding(5, 0, 5, 0);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(43, 24);
            lblSex.TabIndex = 91;
            lblSex.Text = "Sex";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F);
            textBox1.Location = new Point(510, 707);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 26);
            textBox1.TabIndex = 90;
            // 
            // picDate
            // 
            picDate.Font = new Font("Microsoft Sans Serif", 12F);
            picDate.Location = new Point(463, 707);
            picDate.Margin = new Padding(4);
            picDate.Name = "picDate";
            picDate.ReadOnly = true;
            picDate.Size = new Size(39, 26);
            picDate.TabIndex = 89;
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
            txtUsername.TabIndex = 96;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Microsoft Sans Serif", 12F);
            textBox4.Location = new Point(463, 612);
            textBox4.Margin = new Padding(4);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(39, 26);
            textBox4.TabIndex = 95;
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
            // MgUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1140, 900);
            Controls.Add(txtUsername);
            Controls.Add(textBox4);
            Controls.Add(lblUsername);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(lblSex);
            Controls.Add(textBox1);
            Controls.Add(picDate);
            Controls.Add(lblEmail);
            Controls.Add(panel2);
            Controls.Add(txtPhoneNumber);
            Controls.Add(picLoad);
            Controls.Add(txtSearch);
            Controls.Add(picPhoneNumber);
            Controls.Add(lbUserList);
            Controls.Add(panel1);
            Controls.Add(btnSearch);
            Controls.Add(tblUser);
            Controls.Add(picUser);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtClientName);
            Controls.Add(lblCientName);
            Controls.Add(btnClear);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MgUsers";
            Text = "MgUsers";
            ((System.ComponentModel.ISupportInitialize)picLoad).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CloseForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private TextBox txtPhoneNumber;
        private PictureBox picLoad;
        private TextBox txtSearch;
        private TextBox picPhoneNumber;
        private Label lbUserList;
        private Panel panel1;
        private Label label4;
        private PictureBox CloseForm;
        private Button btnSearch;
        private DataGridView tblUser;
        private TextBox picUser;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label lblPhoneNumber;
        private TextBox txtClientName;
        private Label lblCientName;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnClear;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label lblSex;
        private TextBox textBox1;
        private TextBox picDate;
        private Label lblEmail;
        private TextBox txtUsername;
        private TextBox textBox4;
        private Label lblUsername;
    }
}
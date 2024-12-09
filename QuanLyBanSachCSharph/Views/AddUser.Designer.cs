namespace QuanLyBanSachCSharph.Views
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            txtEmail = new TextBox();
            lblEmail = new Label();
            CloseForm = new PictureBox();
            eyeOpen2 = new PictureBox();
            eyeClose2 = new PictureBox();
            txtFullname = new TextBox();
            lblFullname = new Label();
            txtUserName = new TextBox();
            lblUsername = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblTitle = new Label();
            btnAddNew = new Button();
            eyeOpen1 = new PictureBox();
            eyeClose1 = new PictureBox();
            txtConfirmPassword = new TextBox();
            txtPhoneNumber = new TextBox();
            lblConfirmPassword = new Label();
            lblPhoneNumber = new Label();
            lblGender = new Label();
            cbSex = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)CloseForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eyeOpen2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eyeClose2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eyeOpen1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eyeClose1).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            txtEmail.Location = new Point(254, 224);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(223, 32);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            lblEmail.Location = new Point(159, 227);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(72, 25);
            lblEmail.TabIndex = 74;
            lblEmail.Text = "Email:\r\n";
            // 
            // CloseForm
            // 
            CloseForm.Image = (Image)resources.GetObject("CloseForm.Image");
            CloseForm.Location = new Point(586, 11);
            CloseForm.Margin = new Padding(3, 2, 3, 2);
            CloseForm.Name = "CloseForm";
            CloseForm.Size = new Size(42, 30);
            CloseForm.SizeMode = PictureBoxSizeMode.CenterImage;
            CloseForm.TabIndex = 72;
            CloseForm.TabStop = false;
            CloseForm.Click += CloseForm_Click_1;
            // 
            // eyeOpen2
            // 
            eyeOpen2.Image = (Image)resources.GetObject("eyeOpen2.Image");
            eyeOpen2.Location = new Point(484, 427);
            eyeOpen2.Margin = new Padding(3, 2, 3, 2);
            eyeOpen2.Name = "eyeOpen2";
            eyeOpen2.Size = new Size(42, 30);
            eyeOpen2.SizeMode = PictureBoxSizeMode.CenterImage;
            eyeOpen2.TabIndex = 71;
            eyeOpen2.TabStop = false;
            // 
            // eyeClose2
            // 
            eyeClose2.Image = (Image)resources.GetObject("eyeClose2.Image");
            eyeClose2.Location = new Point(484, 427);
            eyeClose2.Margin = new Padding(3, 2, 3, 2);
            eyeClose2.Name = "eyeClose2";
            eyeClose2.Size = new Size(42, 30);
            eyeClose2.SizeMode = PictureBoxSizeMode.CenterImage;
            eyeClose2.TabIndex = 70;
            eyeClose2.TabStop = false;
            // 
            // txtFullname
            // 
            txtFullname.BorderStyle = BorderStyle.FixedSingle;
            txtFullname.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            txtFullname.Location = new Point(254, 126);
            txtFullname.Margin = new Padding(3, 2, 3, 2);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(223, 32);
            txtFullname.TabIndex = 1;
            // 
            // lblFullname
            // 
            lblFullname.AutoSize = true;
            lblFullname.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            lblFullname.Location = new Point(118, 130);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(113, 25);
            lblFullname.TabIndex = 69;
            lblFullname.Text = "Full name:";
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            txtUserName.Location = new Point(254, 327);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(223, 32);
            txtUserName.TabIndex = 5;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            lblUsername.Location = new Point(116, 330);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(117, 25);
            lblUsername.TabIndex = 68;
            lblUsername.Text = "Username:\r\n";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            txtPassword.Location = new Point(254, 379);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(223, 32);
            txtPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            lblPassword.Location = new Point(118, 382);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(113, 25);
            lblPassword.TabIndex = 67;
            lblPassword.Text = "Password:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(208, 52);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(244, 44);
            lblTitle.TabIndex = 66;
            lblTitle.Text = "BOOKSHOP";
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.LightCoral;
            btnAddNew.Cursor = Cursors.Hand;
            btnAddNew.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNew.ForeColor = SystemColors.ButtonHighlight;
            btnAddNew.Location = new Point(208, 491);
            btnAddNew.Margin = new Padding(3, 2, 3, 2);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(244, 50);
            btnAddNew.TabIndex = 8;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // eyeOpen1
            // 
            eyeOpen1.Image = (Image)resources.GetObject("eyeOpen1.Image");
            eyeOpen1.Location = new Point(484, 380);
            eyeOpen1.Margin = new Padding(3, 2, 3, 2);
            eyeOpen1.Name = "eyeOpen1";
            eyeOpen1.Size = new Size(42, 30);
            eyeOpen1.SizeMode = PictureBoxSizeMode.CenterImage;
            eyeOpen1.TabIndex = 65;
            eyeOpen1.TabStop = false;
            // 
            // eyeClose1
            // 
            eyeClose1.Image = (Image)resources.GetObject("eyeClose1.Image");
            eyeClose1.Location = new Point(484, 380);
            eyeClose1.Margin = new Padding(3, 2, 3, 2);
            eyeClose1.Name = "eyeClose1";
            eyeClose1.Size = new Size(42, 30);
            eyeClose1.SizeMode = PictureBoxSizeMode.CenterImage;
            eyeClose1.TabIndex = 64;
            eyeClose1.TabStop = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            txtConfirmPassword.Location = new Point(254, 428);
            txtConfirmPassword.Margin = new Padding(3, 2, 3, 2);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(223, 32);
            txtConfirmPassword.TabIndex = 7;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            txtPhoneNumber.Location = new Point(254, 175);
            txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(223, 32);
            txtPhoneNumber.TabIndex = 2;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            lblConfirmPassword.Location = new Point(39, 431);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(194, 25);
            lblConfirmPassword.TabIndex = 63;
            lblConfirmPassword.Text = "Confirm Password:";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            lblPhoneNumber.Location = new Point(72, 178);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(159, 25);
            lblPhoneNumber.TabIndex = 62;
            lblPhoneNumber.Text = "Phone number:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            lblGender.Location = new Point(141, 277);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(90, 25);
            lblGender.TabIndex = 75;
            lblGender.Text = "Gender:\r\n";
            // 
            // cbSex
            // 
            cbSex.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            cbSex.FormattingEnabled = true;
            cbSex.Items.AddRange(new object[] { "Male", "Female" });
            cbSex.Location = new Point(254, 275);
            cbSex.Name = "cbSex";
            cbSex.Size = new Size(223, 34);
            cbSex.TabIndex = 4;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(640, 580);
            Controls.Add(cbSex);
            Controls.Add(lblGender);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(CloseForm);
            Controls.Add(eyeOpen2);
            Controls.Add(eyeClose2);
            Controls.Add(txtFullname);
            Controls.Add(lblFullname);
            Controls.Add(txtUserName);
            Controls.Add(lblUsername);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblTitle);
            Controls.Add(btnAddNew);
            Controls.Add(eyeOpen1);
            Controls.Add(eyeClose1);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPhoneNumber);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddUser";
            ((System.ComponentModel.ISupportInitialize)CloseForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)eyeOpen2).EndInit();
            ((System.ComponentModel.ISupportInitialize)eyeClose2).EndInit();
            ((System.ComponentModel.ISupportInitialize)eyeOpen1).EndInit();
            ((System.ComponentModel.ISupportInitialize)eyeClose1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label lblEmail;
        private PictureBox CloseForm;
        private PictureBox eyeOpen2;
        private PictureBox eyeClose2;
        private TextBox txtFullname;
        private Label lblFullname;
        private TextBox txtUserName;
        private Label lblUsername;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label lblTitle;
        private Button btnAddNew;
        private PictureBox eyeOpen1;
        private PictureBox eyeClose1;
        private TextBox txtConfirmPassword;
        private TextBox txtPhoneNumber;
        private Label lblConfirmPassword;
        private Label lblPhoneNumber;
        private Label lblGender;
        private ComboBox cbSex;
    }
}
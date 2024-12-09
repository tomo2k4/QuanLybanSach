namespace QuanLyBanSachCSharph.Views
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnSignUp = new Button();
            eyeOpen1 = new PictureBox();
            eyeClose1 = new PictureBox();
            txtConfirmPassword = new TextBox();
            txtPhoneNumber = new TextBox();
            lblConfirmPassword = new Label();
            lblPhoneNumber = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUserName = new TextBox();
            lblUsername = new Label();
            txtFullname = new TextBox();
            lblFullname = new Label();
            eyeOpen2 = new PictureBox();
            eyeClose2 = new PictureBox();
            lblLogin = new Label();
            MinForm = new PictureBox();
            CloseForm = new PictureBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eyeOpen1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eyeClose1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eyeOpen2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eyeClose2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseForm).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(422, 520);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(580, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(244, 44);
            lblTitle.TabIndex = 18;
            lblTitle.Text = "BOOKSHOP";
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.LightCoral;
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = SystemColors.ButtonHighlight;
            btnSignUp.Location = new Point(580, 417);
            btnSignUp.Margin = new Padding(3, 2, 3, 2);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(244, 50);
            btnSignUp.TabIndex = 7;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // eyeOpen1
            // 
            eyeOpen1.Image = (Image)resources.GetObject("eyeOpen1.Image");
            eyeOpen1.Location = new Point(855, 312);
            eyeOpen1.Margin = new Padding(3, 2, 3, 2);
            eyeOpen1.Name = "eyeOpen1";
            eyeOpen1.Size = new Size(42, 30);
            eyeOpen1.SizeMode = PictureBoxSizeMode.CenterImage;
            eyeOpen1.TabIndex = 16;
            eyeOpen1.TabStop = false;
            eyeOpen1.Click += eyeOpen1_Click;
            // 
            // eyeClose1
            // 
            eyeClose1.Image = (Image)resources.GetObject("eyeClose1.Image");
            eyeClose1.Location = new Point(855, 312);
            eyeClose1.Margin = new Padding(3, 2, 3, 2);
            eyeClose1.Name = "eyeClose1";
            eyeClose1.Size = new Size(42, 30);
            eyeClose1.SizeMode = PictureBoxSizeMode.CenterImage;
            eyeClose1.TabIndex = 15;
            eyeClose1.TabStop = false;
            eyeClose1.Click += eyeClose1_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            txtConfirmPassword.Location = new Point(626, 361);
            txtConfirmPassword.Margin = new Padding(3, 2, 3, 2);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(223, 32);
            txtConfirmPassword.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            txtPhoneNumber.Location = new Point(626, 165);
            txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(223, 32);
            txtPhoneNumber.TabIndex = 2;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            lblConfirmPassword.Location = new Point(495, 364);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(112, 25);
            lblConfirmPassword.TabIndex = 12;
            lblConfirmPassword.Text = "   Confirm:";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            lblPhoneNumber.Location = new Point(444, 168);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(159, 25);
            lblPhoneNumber.TabIndex = 11;
            lblPhoneNumber.Text = "Phone number:";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            txtPassword.Location = new Point(626, 312);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(223, 32);
            txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            lblPassword.Location = new Point(490, 315);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(113, 25);
            lblPassword.TabIndex = 19;
            lblPassword.Text = "Password:";
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            txtUserName.Location = new Point(626, 260);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(223, 32);
            txtUserName.TabIndex = 4;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            lblUsername.Location = new Point(488, 263);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(117, 25);
            lblUsername.TabIndex = 21;
            lblUsername.Text = "Username:\r\n";
            // 
            // txtFullname
            // 
            txtFullname.BorderStyle = BorderStyle.FixedSingle;
            txtFullname.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            txtFullname.Location = new Point(626, 112);
            txtFullname.Margin = new Padding(3, 2, 3, 2);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(223, 32);
            txtFullname.TabIndex = 1;
            // 
            // lblFullname
            // 
            lblFullname.AutoSize = true;
            lblFullname.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            lblFullname.Location = new Point(490, 116);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(113, 25);
            lblFullname.TabIndex = 23;
            lblFullname.Text = "Full name:";
            // 
            // eyeOpen2
            // 
            eyeOpen2.Image = (Image)resources.GetObject("eyeOpen2.Image");
            eyeOpen2.Location = new Point(855, 359);
            eyeOpen2.Margin = new Padding(3, 2, 3, 2);
            eyeOpen2.Name = "eyeOpen2";
            eyeOpen2.Size = new Size(42, 30);
            eyeOpen2.SizeMode = PictureBoxSizeMode.CenterImage;
            eyeOpen2.TabIndex = 26;
            eyeOpen2.TabStop = false;
            eyeOpen2.Click += eyeOpen2_Click;
            // 
            // eyeClose2
            // 
            eyeClose2.Image = (Image)resources.GetObject("eyeClose2.Image");
            eyeClose2.Location = new Point(855, 359);
            eyeClose2.Margin = new Padding(3, 2, 3, 2);
            eyeClose2.Name = "eyeClose2";
            eyeClose2.Size = new Size(42, 30);
            eyeClose2.SizeMode = PictureBoxSizeMode.CenterImage;
            eyeClose2.TabIndex = 25;
            eyeClose2.TabStop = false;
            eyeClose2.Click += eyeClose2_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(605, 483);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(195, 18);
            lblLogin.TabIndex = 7;
            lblLogin.Text = "Đã có tài khoản? Đăng nhập";
            lblLogin.Click += lblLogin_Click;
            // 
            // MinForm
            // 
            MinForm.Image = (Image)resources.GetObject("MinForm.Image");
            MinForm.Location = new Point(846, 0);
            MinForm.Margin = new Padding(3, 2, 3, 2);
            MinForm.Name = "MinForm";
            MinForm.Size = new Size(42, 30);
            MinForm.SizeMode = PictureBoxSizeMode.CenterImage;
            MinForm.TabIndex = 30;
            MinForm.TabStop = false;
            // 
            // CloseForm
            // 
            CloseForm.Image = (Image)resources.GetObject("CloseForm.Image");
            CloseForm.Location = new Point(892, 0);
            CloseForm.Margin = new Padding(3, 2, 3, 2);
            CloseForm.Name = "CloseForm";
            CloseForm.Size = new Size(42, 30);
            CloseForm.SizeMode = PictureBoxSizeMode.CenterImage;
            CloseForm.TabIndex = 29;
            CloseForm.TabStop = false;
            CloseForm.Click += CloseForm_Click;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            txtEmail.Location = new Point(626, 210);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(223, 32);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            lblEmail.Location = new Point(531, 213);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(72, 25);
            lblEmail.TabIndex = 31;
            lblEmail.Text = "Email:\r\n";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(933, 520);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(MinForm);
            Controls.Add(CloseForm);
            Controls.Add(lblLogin);
            Controls.Add(eyeOpen2);
            Controls.Add(eyeClose2);
            Controls.Add(txtFullname);
            Controls.Add(lblFullname);
            Controls.Add(txtUserName);
            Controls.Add(lblUsername);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblTitle);
            Controls.Add(btnSignUp);
            Controls.Add(eyeOpen1);
            Controls.Add(eyeClose1);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPhoneNumber);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)eyeOpen1).EndInit();
            ((System.ComponentModel.ISupportInitialize)eyeClose1).EndInit();
            ((System.ComponentModel.ISupportInitialize)eyeOpen2).EndInit();
            ((System.ComponentModel.ISupportInitialize)eyeClose2).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseForm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button btnSignUp;
        private PictureBox eyeOpen1;
        private PictureBox eyeClose1;
        private TextBox txtConfirmPassword;
        private TextBox txtPhoneNumber;
        private Label lblConfirmPassword;
        private Label lblPhoneNumber;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUserName;
        private Label lblUsername;
        private TextBox txtFullname;
        private Label lblFullname;
        private PictureBox eyeOpen2;
        private PictureBox eyeClose2;
        private Label lblLogin;
        private PictureBox MinForm;
        private PictureBox CloseForm;
        private TextBox txtEmail;
        private Label lblEmail;
    }
}
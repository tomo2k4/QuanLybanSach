namespace QuanLyBanSachCSharph.Views
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            CloseForm = new PictureBox();
            MinForm = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblclose = new PictureBox();
            lblopen = new PictureBox();
            btnLogin = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)CloseForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblclose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblopen).BeginInit();
            SuspendLayout();
            // 
            // CloseForm
            // 
            CloseForm.Image = (Image)resources.GetObject("CloseForm.Image");
            CloseForm.Location = new Point(752, 0);
            CloseForm.Name = "CloseForm";
            CloseForm.Size = new Size(48, 40);
            CloseForm.SizeMode = PictureBoxSizeMode.CenterImage;
            CloseForm.TabIndex = 0;
            CloseForm.TabStop = false;
            CloseForm.Click += CloseForm_Click;
            // 
            // MinForm
            // 
            MinForm.Image = (Image)resources.GetObject("MinForm.Image");
            MinForm.Location = new Point(700, 0);
            MinForm.Name = "MinForm";
            MinForm.Size = new Size(48, 40);
            MinForm.SizeMode = PictureBoxSizeMode.CenterImage;
            MinForm.TabIndex = 1;
            MinForm.TabStop = false;
            MinForm.Click += MinForm_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-1, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(294, 416);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 16.2F, FontStyle.Bold);
            label1.Location = new Point(321, 140);
            label1.Name = "label1";
            label1.Size = new Size(150, 34);
            label1.TabIndex = 3;
            label1.Text = "Username:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 16.2F, FontStyle.Bold);
            label2.Location = new Point(321, 219);
            label2.Name = "label2";
            label2.Size = new Size(147, 34);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Roboto", 16.2F, FontStyle.Bold);
            txtUsername.Location = new Point(477, 140);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(255, 40);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Roboto", 16.2F, FontStyle.Bold);
            txtPassword.Location = new Point(478, 220);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(254, 40);
            txtPassword.TabIndex = 6;
            // 
            // lblclose
            // 
            lblclose.Image = (Image)resources.GetObject("lblclose.Image");
            lblclose.Location = new Point(729, 266);
            lblclose.Name = "lblclose";
            lblclose.Size = new Size(48, 40);
            lblclose.SizeMode = PictureBoxSizeMode.CenterImage;
            lblclose.TabIndex = 7;
            lblclose.TabStop = false;
            lblclose.Click += eyeclose_Click;
            // 
            // lblopen
            // 
            lblopen.Image = (Image)resources.GetObject("lblopen.Image");
            lblopen.Location = new Point(729, 220);
            lblopen.Name = "lblopen";
            lblopen.Size = new Size(48, 40);
            lblopen.SizeMode = PictureBoxSizeMode.CenterImage;
            lblopen.TabIndex = 8;
            lblopen.TabStop = false;
            lblopen.Click += pictureBox5_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightCoral;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(478, 295);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(215, 52);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(436, 63);
            label3.Name = "label3";
            label3.Size = new Size(269, 57);
            label3.TabIndex = 10;
            label3.Text = "BOOKSHOP";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(800, 415);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(lblopen);
            Controls.Add(lblclose);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(MinForm);
            Controls.Add(CloseForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)CloseForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblclose).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblopen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox CloseForm;
        private PictureBox MinForm;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private PictureBox lblclose;
        private PictureBox lblopen;
        private Button btnLogin;
        private Label label3;
    }
}
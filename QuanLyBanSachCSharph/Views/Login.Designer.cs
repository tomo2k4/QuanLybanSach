﻿namespace QuanLyBanSachCSharph.Views
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            lblMessage = new Label();
            lblWtk = new Label();
            lblWtkExist = new Label();
            lblAdSign = new Label();
            lblDangki = new Label();
            label8 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)CloseForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblclose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblopen).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // CloseForm
            // 
            CloseForm.Image = (Image)resources.GetObject("CloseForm.Image");
            CloseForm.Location = new Point(374, 2);
            CloseForm.Margin = new Padding(3, 2, 3, 2);
            CloseForm.Name = "CloseForm";
            CloseForm.Size = new Size(42, 30);
            CloseForm.SizeMode = PictureBoxSizeMode.CenterImage;
            CloseForm.TabIndex = 0;
            CloseForm.TabStop = false;
            CloseForm.Click += CloseForm_Click;
            // 
            // MinForm
            // 
            MinForm.Image = (Image)resources.GetObject("MinForm.Image");
            MinForm.Location = new Point(328, 2);
            MinForm.Margin = new Padding(3, 2, 3, 2);
            MinForm.Name = "MinForm";
            MinForm.Size = new Size(42, 30);
            MinForm.SizeMode = PictureBoxSizeMode.CenterImage;
            MinForm.TabIndex = 1;
            MinForm.TabStop = false;
            MinForm.Click += MinForm_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(248, 324);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F);
            label1.Location = new Point(279, 122);
            label1.Name = "label1";
            label1.Size = new Size(102, 24);
            label1.TabIndex = 3;
            label1.Text = "Username:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F);
            label2.Location = new Point(282, 182);
            label2.Name = "label2";
            label2.Size = new Size(97, 24);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            txtUsername.Location = new Point(383, 120);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(223, 28);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            txtPassword.Location = new Point(383, 180);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(222, 28);
            txtPassword.TabIndex = 6;
            // 
            // lblclose
            // 
            lblclose.Image = (Image)resources.GetObject("lblclose.Image");
            lblclose.Location = new Point(608, 178);
            lblclose.Margin = new Padding(3, 2, 3, 2);
            lblclose.Name = "lblclose";
            lblclose.Size = new Size(35, 30);
            lblclose.SizeMode = PictureBoxSizeMode.CenterImage;
            lblclose.TabIndex = 7;
            lblclose.TabStop = false;
            lblclose.Click += lblclose_Click;
            // 
            // lblopen
            // 
            lblopen.Image = (Image)resources.GetObject("lblopen.Image");
            lblopen.Location = new Point(608, 178);
            lblopen.Margin = new Padding(3, 2, 3, 2);
            lblopen.Name = "lblopen";
            lblopen.Size = new Size(35, 30);
            lblopen.SizeMode = PictureBoxSizeMode.CenterImage;
            lblopen.TabIndex = 8;
            lblopen.TabStop = false;
            lblopen.Click += lblopen_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightCoral;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(370, 238);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(207, 39);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(99, 27);
            label3.Name = "label3";
            label3.Size = new Size(244, 44);
            label3.TabIndex = 10;
            label3.Text = "BOOKSHOP";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(398, 208);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(64, 15);
            lblMessage.TabIndex = 11;
            lblMessage.Text = "Thông báo";
            lblMessage.Visible = false;
            // 
            // lblWtk
            // 
            lblWtk.AutoSize = true;
            lblWtk.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWtk.ForeColor = Color.OrangeRed;
            lblWtk.Location = new Point(303, 155);
            lblWtk.Name = "lblWtk";
            lblWtk.Size = new Size(184, 15);
            lblWtk.TabIndex = 12;
            lblWtk.Text = "* Tài khoản không được để trống";
            lblWtk.Visible = false;
            // 
            // lblWtkExist
            // 
            lblWtkExist.AutoSize = true;
            lblWtkExist.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWtkExist.ForeColor = Color.OrangeRed;
            lblWtkExist.Location = new Point(270, 224);
            lblWtkExist.Name = "lblWtkExist";
            lblWtkExist.Size = new Size(142, 15);
            lblWtkExist.TabIndex = 13;
            lblWtkExist.Text = "* Tài khoản không tồn tại";
            lblWtkExist.Visible = false;
            // 
            // lblAdSign
            // 
            lblAdSign.AutoSize = true;
            lblAdSign.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblAdSign.Location = new Point(432, 286);
            lblAdSign.Name = "lblAdSign";
            lblAdSign.Size = new Size(65, 24);
            lblAdSign.TabIndex = 14;
            lblAdSign.Text = "Admin";
            // 
            // lblDangki
            // 
            lblDangki.AutoSize = true;
            lblDangki.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblDangki.ForeColor = Color.Chocolate;
            lblDangki.Location = new Point(511, 77);
            lblDangki.Name = "lblDangki";
            lblDangki.Size = new Size(63, 20);
            lblDangki.TabIndex = 15;
            lblDangki.Text = "Đăng kí";
            lblDangki.Click += lblDangki_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Chocolate;
            label8.Location = new Point(353, 80);
            label8.Name = "label8";
            label8.Size = new Size(157, 17);
            label8.TabIndex = 16;
            label8.Text = "Bạn chưa có tài khoản?";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(677, 325);
            panel1.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.Controls.Add(CloseForm);
            panel2.Controls.Add(MinForm);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(254, 8);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(416, 308);
            panel2.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(677, 325);
            Controls.Add(label8);
            Controls.Add(lblDangki);
            Controls.Add(lblAdSign);
            Controls.Add(lblWtkExist);
            Controls.Add(lblWtk);
            Controls.Add(lblMessage);
            Controls.Add(btnLogin);
            Controls.Add(lblopen);
            Controls.Add(lblclose);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)CloseForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblclose).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblopen).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label lblMessage;
        private Label lblWtk;
        private Label lblWtkExist;
        private Label lblAdSign;
        private Label lblDangki;
        private Label label8;
        private Panel panel1;
        private Panel panel2;
    }
}
namespace QuanLyBanSachCSharph.Views
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            pnlSlide = new Panel();
            btnLogout = new Button();
            pnlUser = new Panel();
            btnMgClient = new Button();
            btnMgUser = new Button();
            btnUser = new Button();
            pnlbooks = new Panel();
            btnMgBook = new Button();
            btnAuthor = new Button();
            btnGenres = new Button();
            btnBook = new Button();
            btnDashboard = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pnlCover = new Panel();
            panel6 = new Panel();
            label9 = new Label();
            label10 = new Label();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            label6 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            label7 = new Label();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            CloseForm = new PictureBox();
            MinForm = new PictureBox();
            label4 = new Label();
            pnlSlide.SuspendLayout();
            pnlUser.SuspendLayout();
            pnlbooks.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlCover.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CloseForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinForm).BeginInit();
            SuspendLayout();
            // 
            // pnlSlide
            // 
            pnlSlide.AutoScroll = true;
            pnlSlide.BackColor = Color.LightCoral;
            pnlSlide.Controls.Add(btnLogout);
            pnlSlide.Controls.Add(pnlUser);
            pnlSlide.Controls.Add(btnUser);
            pnlSlide.Controls.Add(pnlbooks);
            pnlSlide.Controls.Add(btnBook);
            pnlSlide.Controls.Add(btnDashboard);
            pnlSlide.Controls.Add(panel1);
            pnlSlide.Dock = DockStyle.Left;
            pnlSlide.Location = new Point(0, 0);
            pnlSlide.Name = "pnlSlide";
            pnlSlide.Size = new Size(259, 900);
            pnlSlide.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Top;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Roboto Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(0, 620);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(15, 0, 0, 0);
            btnLogout.Size = new Size(259, 67);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlUser
            // 
            pnlUser.Controls.Add(btnMgClient);
            pnlUser.Controls.Add(btnMgUser);
            pnlUser.Dock = DockStyle.Top;
            pnlUser.Location = new Point(0, 506);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(259, 114);
            pnlUser.TabIndex = 6;
            // 
            // btnMgClient
            // 
            btnMgClient.Dock = DockStyle.Top;
            btnMgClient.FlatAppearance.BorderSize = 0;
            btnMgClient.FlatStyle = FlatStyle.Flat;
            btnMgClient.Location = new Point(0, 56);
            btnMgClient.Name = "btnMgClient";
            btnMgClient.Padding = new Padding(40, 0, 0, 0);
            btnMgClient.Size = new Size(259, 56);
            btnMgClient.TabIndex = 1;
            btnMgClient.Text = "Manage Client";
            btnMgClient.TextAlign = ContentAlignment.MiddleLeft;
            btnMgClient.UseVisualStyleBackColor = true;
            btnMgClient.Click += btnMgClient_Click;
            // 
            // btnMgUser
            // 
            btnMgUser.Dock = DockStyle.Top;
            btnMgUser.FlatAppearance.BorderSize = 0;
            btnMgUser.FlatStyle = FlatStyle.Flat;
            btnMgUser.Location = new Point(0, 0);
            btnMgUser.Name = "btnMgUser";
            btnMgUser.Padding = new Padding(40, 0, 0, 0);
            btnMgUser.Size = new Size(259, 56);
            btnMgUser.TabIndex = 0;
            btnMgUser.Text = "Manage User";
            btnMgUser.TextAlign = ContentAlignment.MiddleLeft;
            btnMgUser.UseVisualStyleBackColor = true;
            btnMgUser.Click += btnMgUser_Click;
            // 
            // btnUser
            // 
            btnUser.Dock = DockStyle.Top;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Roboto Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUser.Location = new Point(0, 439);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(15, 0, 0, 0);
            btnUser.Size = new Size(259, 67);
            btnUser.TabIndex = 5;
            btnUser.Text = "User";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // pnlbooks
            // 
            pnlbooks.Controls.Add(btnMgBook);
            pnlbooks.Controls.Add(btnAuthor);
            pnlbooks.Controls.Add(btnGenres);
            pnlbooks.Dock = DockStyle.Top;
            pnlbooks.Location = new Point(0, 267);
            pnlbooks.Name = "pnlbooks";
            pnlbooks.Size = new Size(259, 172);
            pnlbooks.TabIndex = 4;
            // 
            // btnMgBook
            // 
            btnMgBook.Dock = DockStyle.Top;
            btnMgBook.FlatAppearance.BorderSize = 0;
            btnMgBook.FlatStyle = FlatStyle.Flat;
            btnMgBook.Location = new Point(0, 112);
            btnMgBook.Name = "btnMgBook";
            btnMgBook.Padding = new Padding(40, 0, 0, 0);
            btnMgBook.Size = new Size(259, 56);
            btnMgBook.TabIndex = 2;
            btnMgBook.Text = "Manage Books";
            btnMgBook.TextAlign = ContentAlignment.MiddleLeft;
            btnMgBook.UseVisualStyleBackColor = true;
            btnMgBook.Click += btnMgBook_Click;
            // 
            // btnAuthor
            // 
            btnAuthor.Dock = DockStyle.Top;
            btnAuthor.FlatAppearance.BorderSize = 0;
            btnAuthor.FlatStyle = FlatStyle.Flat;
            btnAuthor.Location = new Point(0, 56);
            btnAuthor.Name = "btnAuthor";
            btnAuthor.Padding = new Padding(40, 0, 0, 0);
            btnAuthor.Size = new Size(259, 56);
            btnAuthor.TabIndex = 1;
            btnAuthor.Text = "Authors";
            btnAuthor.TextAlign = ContentAlignment.MiddleLeft;
            btnAuthor.UseVisualStyleBackColor = true;
            btnAuthor.Click += btnAuthor_Click;
            // 
            // btnGenres
            // 
            btnGenres.Dock = DockStyle.Top;
            btnGenres.FlatAppearance.BorderSize = 0;
            btnGenres.FlatStyle = FlatStyle.Flat;
            btnGenres.Location = new Point(0, 0);
            btnGenres.Name = "btnGenres";
            btnGenres.Padding = new Padding(40, 0, 0, 0);
            btnGenres.Size = new Size(259, 56);
            btnGenres.TabIndex = 0;
            btnGenres.Text = "Genres";
            btnGenres.TextAlign = ContentAlignment.MiddleLeft;
            btnGenres.UseVisualStyleBackColor = true;
            btnGenres.Click += btnGenres_Click;
            // 
            // btnBook
            // 
            btnBook.Dock = DockStyle.Top;
            btnBook.FlatAppearance.BorderSize = 0;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Roboto Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBook.Location = new Point(0, 200);
            btnBook.Name = "btnBook";
            btnBook.Padding = new Padding(15, 0, 0, 0);
            btnBook.Size = new Size(259, 67);
            btnBook.TabIndex = 2;
            btnBook.Text = "Books";
            btnBook.TextAlign = ContentAlignment.MiddleLeft;
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Roboto Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(0, 133);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(15, 0, 0, 0);
            btnDashboard.Size = new Size(259, 67);
            btnDashboard.TabIndex = 7;
            btnDashboard.Text = "Home";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 133);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlCover
            // 
            pnlCover.Controls.Add(panel6);
            pnlCover.Controls.Add(panel4);
            pnlCover.Controls.Add(panel5);
            pnlCover.Controls.Add(dataGridView1);
            pnlCover.Controls.Add(panel3);
            pnlCover.Controls.Add(panel2);
            pnlCover.Dock = DockStyle.Fill;
            pnlCover.Location = new Point(259, 0);
            pnlCover.Name = "pnlCover";
            pnlCover.Size = new Size(1141, 900);
            pnlCover.TabIndex = 1;
            pnlCover.Paint += pnlCover_Paint;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Bisque;
            panel6.Controls.Add(label9);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(pictureBox4);
            panel6.Location = new Point(765, 164);
            panel6.Name = "panel6";
            panel6.Size = new Size(303, 190);
            panel6.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(34, 82);
            label9.Name = "label9";
            label9.Size = new Size(98, 72);
            label9.TabIndex = 3;
            label9.Text = "10";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Roboto", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(34, 21);
            label10.Name = "label10";
            label10.Size = new Size(221, 41);
            label10.TabIndex = 2;
            label10.Text = "Total Amount";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(171, 65);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(104, 99);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Bisque;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(81, 164);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 190);
            panel4.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(41, 82);
            label6.Name = "label6";
            label6.Size = new Size(98, 72);
            label6.TabIndex = 3;
            label6.Text = "10";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(41, 21);
            label5.Name = "label5";
            label5.Size = new Size(88, 41);
            label5.TabIndex = 2;
            label5.Text = "User";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(167, 65);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 99);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Bisque;
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(428, 164);
            panel5.Name = "panel5";
            panel5.Size = new Size(294, 190);
            panel5.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(34, 82);
            label7.Name = "label7";
            label7.Size = new Size(98, 72);
            label7.TabIndex = 3;
            label7.Text = "10";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Roboto", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(34, 21);
            label8.Name = "label8";
            label8.Size = new Size(94, 41);
            label8.TabIndex = 2;
            label8.Text = "Book";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(166, 65);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(104, 99);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(81, 399);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(987, 466);
            dataGridView1.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MistyRose;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(1141, 62);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 15);
            label3.Name = "label3";
            label3.Size = new Size(79, 28);
            label3.TabIndex = 1;
            label3.Text = "Admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 15);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 0;
            label2.Text = "Welcome,";
            // 
            // panel2
            // 
            panel2.Controls.Add(CloseForm);
            panel2.Controls.Add(MinForm);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1141, 65);
            panel2.TabIndex = 0;
            // 
            // CloseForm
            // 
            CloseForm.Image = (Image)resources.GetObject("CloseForm.Image");
            CloseForm.Location = new Point(1093, 0);
            CloseForm.Name = "CloseForm";
            CloseForm.Size = new Size(48, 40);
            CloseForm.SizeMode = PictureBoxSizeMode.CenterImage;
            CloseForm.TabIndex = 2;
            CloseForm.TabStop = false;
            CloseForm.Click += CloseForm_Click;
            // 
            // MinForm
            // 
            MinForm.Image = (Image)resources.GetObject("MinForm.Image");
            MinForm.Location = new Point(1041, 0);
            MinForm.Name = "MinForm";
            MinForm.Size = new Size(48, 40);
            MinForm.SizeMode = PictureBoxSizeMode.CenterImage;
            MinForm.TabIndex = 3;
            MinForm.TabStop = false;
            MinForm.Click += MinForm_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(462, 9);
            label4.Name = "label4";
            label4.Size = new Size(217, 44);
            label4.TabIndex = 0;
            label4.Text = "BOOKSHOP";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1400, 900);
            Controls.Add(pnlCover);
            Controls.Add(pnlSlide);
            Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Books";
            Load += HomePage_Load;
            pnlSlide.ResumeLayout(false);
            pnlUser.ResumeLayout(false);
            pnlbooks.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlCover.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CloseForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSlide;
        private PictureBox pictureBox1;
        private Button btnBook;
        private Panel panel1;
        private Panel pnlbooks;
        private Button btnAuthor;
        private Button btnGenres;
        private Button btnMgBook;
        private Panel pnlUser;
        private Button btnMgUser;
        private Button btnUser;
        private Button btnLogout;
        private Button btnDashboard;
        private Panel pnlCover;
        private Panel panel3;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Panel panel5;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox3;
        private Panel panel6;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox4;
        private DataGridView dataGridView1;
        private Panel panel4;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox2;
        private PictureBox CloseForm;
        private PictureBox MinForm;
        private Button btnMgClient;
    }
}
namespace QuanLyBanSachCSharph.Views
{
    partial class Dashboard
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
            btnClients = new Button();
            lblTitle = new Label();
            btnDashboard = new Button();
            panel1 = new Panel();
            btnLogOut = new Button();
            btnBooks = new Button();
            lblMiniTitle = new Label();
            panel2 = new Panel();
            pnTotalStock = new Panel();
            pnTotalAmount = new Panel();
            pnTotalClient = new Panel();
            pnTotalUser = new Panel();
            tbTotalStock = new TextBox();
            tbTotalAmount = new TextBox();
            tbTotalClient = new TextBox();
            tbTotalUser = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnTotalStock.SuspendLayout();
            pnTotalAmount.SuspendLayout();
            pnTotalClient.SuspendLayout();
            pnTotalUser.SuspendLayout();
            SuspendLayout();
            // 
            // btnClients
            // 
            btnClients.BackColor = Color.Black;
            btnClients.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClients.ForeColor = Color.White;
            btnClients.Location = new Point(14, 224);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(170, 52);
            btnClients.TabIndex = 17;
            btnClients.Text = "Clients";
            btnClients.UseVisualStyleBackColor = false;
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
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.ForestGreen;
            btnDashboard.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(14, 325);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(170, 52);
            btnDashboard.TabIndex = 18;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
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
            panel1.TabIndex = 4;
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pnTotalUser);
            panel2.Controls.Add(pnTotalClient);
            panel2.Controls.Add(pnTotalAmount);
            panel2.Controls.Add(pnTotalStock);
            panel2.Controls.Add(lblMiniTitle);
            panel2.Location = new Point(205, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1047, 737);
            panel2.TabIndex = 5;
            // 
            // pnTotalStock
            // 
            pnTotalStock.BackColor = Color.Khaki;
            pnTotalStock.Controls.Add(tbTotalStock);
            pnTotalStock.Location = new Point(163, 178);
            pnTotalStock.Name = "pnTotalStock";
            pnTotalStock.Size = new Size(200, 100);
            pnTotalStock.TabIndex = 13;
            // 
            // pnTotalAmount
            // 
            pnTotalAmount.BackColor = Color.SpringGreen;
            pnTotalAmount.Controls.Add(tbTotalAmount);
            pnTotalAmount.Location = new Point(619, 178);
            pnTotalAmount.Name = "pnTotalAmount";
            pnTotalAmount.Size = new Size(200, 100);
            pnTotalAmount.TabIndex = 14;
            // 
            // pnTotalClient
            // 
            pnTotalClient.BackColor = Color.SkyBlue;
            pnTotalClient.Controls.Add(tbTotalClient);
            pnTotalClient.Location = new Point(163, 399);
            pnTotalClient.Name = "pnTotalClient";
            pnTotalClient.Size = new Size(200, 100);
            pnTotalClient.TabIndex = 14;
            // 
            // pnTotalUser
            // 
            pnTotalUser.BackColor = Color.SlateBlue;
            pnTotalUser.Controls.Add(tbTotalUser);
            pnTotalUser.Location = new Point(619, 399);
            pnTotalUser.Name = "pnTotalUser";
            pnTotalUser.Size = new Size(200, 100);
            pnTotalUser.TabIndex = 15;
            // 
            // tbTotalStock
            // 
            tbTotalStock.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTotalStock.Location = new Point(3, 3);
            tbTotalStock.Name = "tbTotalStock";
            tbTotalStock.Size = new Size(197, 35);
            tbTotalStock.TabIndex = 0;
            tbTotalStock.Text = "Total Stock";
            // 
            // tbTotalAmount
            // 
            tbTotalAmount.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTotalAmount.Location = new Point(0, 3);
            tbTotalAmount.Name = "tbTotalAmount";
            tbTotalAmount.Size = new Size(197, 35);
            tbTotalAmount.TabIndex = 1;
            tbTotalAmount.Text = "Total Amount";
            // 
            // tbTotalClient
            // 
            tbTotalClient.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTotalClient.Location = new Point(0, 3);
            tbTotalClient.Name = "tbTotalClient";
            tbTotalClient.Size = new Size(197, 35);
            tbTotalClient.TabIndex = 2;
            tbTotalClient.Text = "Total Client";
            // 
            // tbTotalUser
            // 
            tbTotalUser.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTotalUser.Location = new Point(0, 3);
            tbTotalUser.Name = "tbTotalUser";
            tbTotalUser.Size = new Size(197, 35);
            tbTotalUser.TabIndex = 2;
            tbTotalUser.Text = "Total User";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1264, 761);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnTotalStock.ResumeLayout(false);
            pnTotalStock.PerformLayout();
            pnTotalAmount.ResumeLayout(false);
            pnTotalAmount.PerformLayout();
            pnTotalClient.ResumeLayout(false);
            pnTotalClient.PerformLayout();
            pnTotalUser.ResumeLayout(false);
            pnTotalUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClients;
        private Label lblTitle;
        private Button btnDashboard;
        private Panel panel1;
        private Button btnLogOut;
        private Button btnBooks;
        private Label lblMiniTitle;
        private Panel panel2;
        private Panel pnTotalAmount;
        private Panel pnTotalStock;
        private Panel pnTotalUser;
        private Panel pnTotalClient;
        private TextBox tbTotalClient;
        private TextBox tbTotalAmount;
        private TextBox tbTotalStock;
        private TextBox tbTotalUser;
    }
}
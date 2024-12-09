namespace BookShop
{
    partial class Billing
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            panel1 = new Panel();
            btnLogOut = new Button();
            lblTitle = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            picboxAnh = new PictureBox();
            CloseForm = new PictureBox();
            lblTotal = new Label();
            btnPrintBill = new Button();
            btnReset = new Button();
            btnAdd = new Button();
            lblMiniTitle = new Label();
            lblBill = new Label();
            lblList = new Label();
            tbPrice = new TextBox();
            tbClientName = new TextBox();
            tbQuantity = new TextBox();
            tbBookName = new TextBox();
            lblPrice = new Label();
            lblClientName = new Label();
            lblQuantity = new Label();
            lblBookName = new Label();
            dgvList = new DataGridView();
            dgvBill = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(191, 983);
            panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Bisque;
            btnLogOut.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.SaddleBrown;
            btnLogOut.Location = new Point(16, 895);
            btnLogOut.Margin = new Padding(3, 4, 3, 4);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(160, 67);
            btnLogOut.TabIndex = 16;
            btnLogOut.Text = "Logout";
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.SaddleBrown;
            lblTitle.Location = new Point(10, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(183, 39);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "BookShop";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FloralWhite;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(picboxAnh);
            panel2.Controls.Add(CloseForm);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(btnPrintBill);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(lblMiniTitle);
            panel2.Controls.Add(lblBill);
            panel2.Controls.Add(lblList);
            panel2.Controls.Add(tbPrice);
            panel2.Controls.Add(tbClientName);
            panel2.Controls.Add(tbQuantity);
            panel2.Controls.Add(tbBookName);
            panel2.Controls.Add(lblPrice);
            panel2.Controls.Add(lblClientName);
            panel2.Controls.Add(lblQuantity);
            panel2.Controls.Add(lblBookName);
            panel2.Controls.Add(dgvList);
            panel2.Controls.Add(dgvBill);
            panel2.Location = new Point(203, 16);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1227, 983);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(30, 337);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 37);
            textBox1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 300);
            label1.Name = "label1";
            label1.Size = new Size(191, 31);
            label1.TabIndex = 25;
            label1.Text = "Client Phone #";
            // 
            // picboxAnh
            // 
            picboxAnh.Location = new Point(455, 89);
            picboxAnh.Margin = new Padding(5, 5, 5, 5);
            picboxAnh.Name = "picboxAnh";
            picboxAnh.Size = new Size(194, 289);
            picboxAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxAnh.TabIndex = 24;
            picboxAnh.TabStop = false;
            // 
            // CloseForm
            // 
            CloseForm.Image = (Image)resources.GetObject("CloseForm.Image");
            CloseForm.Location = new Point(1173, 1);
            CloseForm.Margin = new Padding(5, 5, 5, 5);
            CloseForm.Name = "CloseForm";
            CloseForm.Size = new Size(55, 53);
            CloseForm.SizeMode = PictureBoxSizeMode.CenterImage;
            CloseForm.TabIndex = 23;
            CloseForm.TabStop = false;
            CloseForm.Click += CloseForm_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.FlatStyle = FlatStyle.Flat;
            lblTotal.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Crimson;
            lblTotal.Location = new Point(838, 728);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(296, 46);
            lblTotal.TabIndex = 16;
            lblTotal.Text = "Total:                ";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPrintBill
            // 
            btnPrintBill.BackColor = Color.SaddleBrown;
            btnPrintBill.Font = new Font("Microsoft Sans Serif", 15.75F);
            btnPrintBill.ForeColor = Color.White;
            btnPrintBill.Location = new Point(865, 817);
            btnPrintBill.Margin = new Padding(3, 4, 3, 4);
            btnPrintBill.Name = "btnPrintBill";
            btnPrintBill.Size = new Size(160, 56);
            btnPrintBill.TabIndex = 15;
            btnPrintBill.Text = "Print Bill";
            btnPrintBill.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.SaddleBrown;
            btnReset.Font = new Font("Microsoft Sans Serif", 15.75F);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(306, 400);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(114, 56);
            btnReset.TabIndex = 14;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SaddleBrown;
            btnAdd.Font = new Font("Microsoft Sans Serif", 15.75F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(86, 400);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(160, 56);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add To Bill";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblMiniTitle
            // 
            lblMiniTitle.AutoSize = true;
            lblMiniTitle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMiniTitle.ForeColor = Color.SaddleBrown;
            lblMiniTitle.Location = new Point(499, 13);
            lblMiniTitle.Name = "lblMiniTitle";
            lblMiniTitle.Size = new Size(147, 31);
            lblMiniTitle.TabIndex = 12;
            lblMiniTitle.Text = "BookShop";
            // 
            // lblBill
            // 
            lblBill.AutoSize = true;
            lblBill.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBill.ForeColor = Color.SaddleBrown;
            lblBill.Location = new Point(862, 89);
            lblBill.Name = "lblBill";
            lblBill.Size = new Size(178, 39);
            lblBill.TabIndex = 11;
            lblBill.Text = "Books Bill";
            // 
            // lblList
            // 
            lblList.AutoSize = true;
            lblList.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblList.ForeColor = Color.SaddleBrown;
            lblList.Location = new Point(249, 468);
            lblList.Name = "lblList";
            lblList.Size = new Size(184, 39);
            lblList.TabIndex = 10;
            lblList.Text = "Books List";
            // 
            // tbPrice
            // 
            tbPrice.Enabled = false;
            tbPrice.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPrice.Location = new Point(306, 235);
            tbPrice.Margin = new Padding(3, 4, 3, 4);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(114, 37);
            tbPrice.TabIndex = 9;
            // 
            // tbClientName
            // 
            tbClientName.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbClientName.Location = new Point(30, 235);
            tbClientName.Margin = new Padding(3, 4, 3, 4);
            tbClientName.Name = "tbClientName";
            tbClientName.Size = new Size(251, 37);
            tbClientName.TabIndex = 8;
            // 
            // tbQuantity
            // 
            tbQuantity.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbQuantity.Location = new Point(306, 124);
            tbQuantity.Margin = new Padding(3, 4, 3, 4);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(114, 37);
            tbQuantity.TabIndex = 7;
            // 
            // tbBookName
            // 
            tbBookName.Enabled = false;
            tbBookName.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbBookName.Location = new Point(30, 124);
            tbBookName.Margin = new Padding(3, 4, 3, 4);
            tbBookName.Name = "tbBookName";
            tbBookName.Size = new Size(251, 37);
            tbBookName.TabIndex = 6;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(306, 188);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(76, 31);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price";
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClientName.Location = new Point(30, 188);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(163, 31);
            lblClientName.TabIndex = 4;
            lblClientName.Text = "Client Name";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(306, 79);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(116, 31);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Quantity";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookName.Location = new Point(30, 79);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(155, 31);
            lblBookName.TabIndex = 2;
            lblBookName.Text = "Book Name";
            // 
            // dgvList
            // 
            dgvList.BackgroundColor = Color.White;
            dgvList.BorderStyle = BorderStyle.Fixed3D;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(32, 521);
            dgvList.Margin = new Padding(3, 4, 3, 4);
            dgvList.MultiSelect = false;
            dgvList.Name = "dgvList";
            dgvList.RowHeadersWidth = 51;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.Size = new Size(617, 440);
            dgvList.TabIndex = 1;
            dgvList.CellContentClick += dgvList_CellContentClick;
            // 
            // dgvBill
            // 
            dgvBill.BackgroundColor = Color.White;
            dgvBill.BorderStyle = BorderStyle.Fixed3D;
            dgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBill.Location = new Point(682, 147);
            dgvBill.Margin = new Padding(3, 4, 3, 4);
            dgvBill.Name = "dgvBill";
            dgvBill.RowHeadersWidth = 51;
            dgvBill.Size = new Size(514, 533);
            dgvBill.TabIndex = 0;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1445, 1015);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Billing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formBilling";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picboxAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvList;
        private DataGridView dgvBill;
        private Label lblBookName;
        private TextBox tbPrice;
        private TextBox tbClientName;
        private TextBox tbQuantity;
        private TextBox tbBookName;
        private Label lblPrice;
        private Label lblClientName;
        private Label lblQuantity;
        private Label lblBill;
        private Label lblList;
        private Label lblTitle;
        private Button btnAdd;
        private Label lblMiniTitle;
        private Button btnLogOut;
        private Button btnPrintBill;
        private Button btnReset;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label lblTotal;
        private PictureBox CloseForm;
        private PictureBox picboxAnh;
        private TextBox textBox1;
        private Label label1;
    }
}

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
            label4 = new Label();
            picLoad = new PictureBox();
            txtSearch = new TextBox();
            picPhoneNumber = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            CloseForm = new PictureBox();
            lbClientList = new Label();
            panel1 = new Panel();
            btnSearch = new Button();
            tblClient = new DataGridView();
            picClient = new TextBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            lblPhoneNumber = new Label();
            txtClientName = new TextBox();
            lblCientName = new Label();
            txtPhoneNumber = new TextBox();
            lblEmail = new Label();
            picDate = new TextBox();
            panel2 = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblSex = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)picLoad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseForm).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblClient).BeginInit();
            SuspendLayout();
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
            // picLoad
            // 
            picLoad.Image = (Image)resources.GetObject("picLoad.Image");
            picLoad.Location = new Point(1076, 63);
            picLoad.Margin = new Padding(4);
            picLoad.Name = "picLoad";
            picLoad.Size = new Size(48, 40);
            picLoad.SizeMode = PictureBoxSizeMode.CenterImage;
            picLoad.TabIndex = 54;
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
            txtSearch.TabIndex = 63;
            // 
            // picPhoneNumber
            // 
            picPhoneNumber.Font = new Font("Microsoft Sans Serif", 12F);
            picPhoneNumber.Location = new Point(237, 706);
            picPhoneNumber.Margin = new Padding(4);
            picPhoneNumber.Name = "picPhoneNumber";
            picPhoneNumber.ReadOnly = true;
            picPhoneNumber.Size = new Size(39, 26);
            picPhoneNumber.TabIndex = 62;
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
            CloseForm.Location = new Point(1092, 0);
            CloseForm.Margin = new Padding(4);
            CloseForm.Name = "CloseForm";
            CloseForm.Size = new Size(48, 40);
            CloseForm.SizeMode = PictureBoxSizeMode.CenterImage;
            CloseForm.TabIndex = 22;
            CloseForm.TabStop = false;
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
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(CloseForm);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1140, 58);
            panel1.TabIndex = 57;
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
            btnSearch.TabIndex = 55;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // tblClient
            // 
            tblClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblClient.Location = new Point(20, 113);
            tblClient.Margin = new Padding(4);
            tblClient.Name = "tblClient";
            tblClient.RowHeadersWidth = 51;
            tblClient.Size = new Size(1100, 440);
            tblClient.TabIndex = 53;
            // 
            // picClient
            // 
            picClient.Font = new Font("Microsoft Sans Serif", 12F);
            picClient.Location = new Point(237, 609);
            picClient.Margin = new Padding(4);
            picClient.Name = "picClient";
            picClient.ReadOnly = true;
            picClient.Size = new Size(39, 26);
            picClient.TabIndex = 50;
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
            // picDate
            // 
            picDate.Font = new Font("Microsoft Sans Serif", 12F);
            picDate.Location = new Point(602, 706);
            picDate.Margin = new Padding(4);
            picDate.Name = "picDate";
            picDate.ReadOnly = true;
            picDate.Size = new Size(39, 26);
            picDate.TabIndex = 66;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCoral;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 840);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1140, 60);
            panel2.TabIndex = 67;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F);
            textBox1.Location = new Point(649, 706);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 26);
            textBox1.TabIndex = 68;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 12F);
            textBox2.Location = new Point(603, 609);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(39, 26);
            textBox2.TabIndex = 70;
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSex.Location = new Point(661, 578);
            lblSex.Margin = new Padding(5, 0, 5, 0);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(43, 24);
            lblSex.TabIndex = 69;
            lblSex.Text = "Sex";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(649, 605);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 28);
            comboBox1.TabIndex = 71;
            // 
            // MgClients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1140, 900);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(lblSex);
            Controls.Add(textBox1);
            Controls.Add(panel2);
            Controls.Add(picDate);
            Controls.Add(txtPhoneNumber);
            Controls.Add(picLoad);
            Controls.Add(txtSearch);
            Controls.Add(picPhoneNumber);
            Controls.Add(lbClientList);
            Controls.Add(panel1);
            Controls.Add(btnSearch);
            Controls.Add(tblClient);
            Controls.Add(lblEmail);
            Controls.Add(picClient);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblClient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTotal;
        private Button btnPrintBill;
        private TextBox tbUsername;
        private Label lblUserName;
        private Button btnUsers;
        private Label label4;
        private PictureBox picLoad;
        private TextBox txtSearch;
        private TextBox picPhoneNumber;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox CloseForm;
        private Label lbClientList;
        private TextBox txtNhaxuatban;
        private Label label8;
        private Panel panel1;
        private Button btnSearch;
        private DataGridView tblClient;
        private DateTimePicker dtimerNhap;
        private TextBox picClient;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtGiasach;
        private TextBox txtSoluong;
        private Label label6;
        private ComboBox cmbTheloai;
        private Label label5;
        private Label lblPhoneNumber;
        private TextBox txtClientName;
        private Label lblCientName;
        private TextBox txtPhoneNumber;
        private Label lblEmail;
        private TextBox picDate;
        private Panel panel2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblSex;
        private ComboBox comboBox1;
    }
}
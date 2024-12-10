namespace QuanLyBanSachCSharph.Views
{
    partial class Theloai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Theloai));
            label9 = new Label();
            CloseForm = new PictureBox();
            panel1 = new Panel();
            label4 = new Label();
            tblTheloai = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnHuy = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label3 = new Label();
            txtMatl = new TextBox();
            panel2 = new Panel();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)CloseForm).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblTheloai).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Roboto", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Brown;
            label9.Location = new Point(449, 88);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(163, 34);
            label9.TabIndex = 60;
            label9.Text = "Genres List ";
            // 
            // CloseForm
            // 
            CloseForm.Image = (Image)resources.GetObject("CloseForm.Image");
            CloseForm.Location = new Point(1079, 11);
            CloseForm.Margin = new Padding(4);
            CloseForm.Name = "CloseForm";
            CloseForm.Size = new Size(48, 40);
            CloseForm.SizeMode = PictureBoxSizeMode.CenterImage;
            CloseForm.TabIndex = 22;
            CloseForm.TabStop = false;
            CloseForm.Click += CloseForm_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(CloseForm);
            panel1.Location = new Point(0, 6);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1052, 58);
            panel1.TabIndex = 57;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(461, 7);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(217, 44);
            label4.TabIndex = 0;
            label4.Text = "BOOKSHOP";
            // 
            // tblTheloai
            // 
            tblTheloai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblTheloai.Location = new Point(29, 139);
            tblTheloai.Margin = new Padding(4);
            tblTheloai.Name = "tblTheloai";
            tblTheloai.RowHeadersWidth = 51;
            tblTheloai.Size = new Size(989, 390);
            tblTheloai.TabIndex = 53;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Brown;
            btnHuy.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(791, 666);
            btnHuy.Margin = new Padding(4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(130, 44);
            btnHuy.TabIndex = 48;
            btnHuy.Text = "Clear";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Brown;
            btnXoa.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(569, 666);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(130, 44);
            btnXoa.TabIndex = 47;
            btnXoa.Text = "Delete";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Brown;
            btnSua.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(346, 666);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(130, 44);
            btnSua.TabIndex = 46;
            btnSua.Text = "Update";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Brown;
            btnThem.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(147, 666);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(130, 44);
            btnThem.TabIndex = 45;
            btnThem.Text = "Add";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(397, 562);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 39;
            label3.Text = "Genres";
            // 
            // txtMatl
            // 
            txtMatl.Font = new Font("Roboto", 12F);
            txtMatl.Location = new Point(339, 594);
            txtMatl.Margin = new Padding(4);
            txtMatl.Name = "txtMatl";
            txtMatl.ReadOnly = true;
            txtMatl.Size = new Size(39, 32);
            txtMatl.TabIndex = 62;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCoral;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 806);
            panel2.Name = "panel2";
            panel2.Size = new Size(1056, 93);
            panel2.TabIndex = 64;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(397, 594);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 35);
            textBox1.TabIndex = 65;
            // 
            // Theloai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1056, 899);
            Controls.Add(textBox1);
            Controls.Add(panel2);
            Controls.Add(txtMatl);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(tblTheloai);
            Controls.Add(btnHuy);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Theloai";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Theloai";
            ((System.ComponentModel.ISupportInitialize)CloseForm).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblTheloai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private PictureBox CloseForm;
        private Panel panel1;
        private Label label4;
        private DataGridView tblTheloai;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtMasach;
        private Button btnHuy;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cmbTheloai;
        private Label label3;
        private TextBox txtMatl;
        private Panel panel2;
        private TextBox textBox1;
        private TextBox txtTensach;
        private Label label2;
    }
}
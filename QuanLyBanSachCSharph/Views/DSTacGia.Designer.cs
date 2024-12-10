namespace QuanLyBanSachCSharph.Views
{
    partial class DSTacGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSTacGia));
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            tblTacGia = new DataGridView();
            label1 = new Label();
            CloseForm = new PictureBox();
            btnChontg = new Button();
            ((System.ComponentModel.ISupportInitialize)tblTacGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseForm).BeginInit();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // tblTacGia
            // 
            tblTacGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblTacGia.Location = new Point(14, 92);
            tblTacGia.Margin = new Padding(5, 4, 5, 4);
            tblTacGia.Name = "tblTacGia";
            tblTacGia.RowHeadersWidth = 51;
            tblTacGia.Size = new Size(507, 622);
            tblTacGia.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(165, 26);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(221, 48);
            label1.TabIndex = 1;
            label1.Text = "List Author";
            // 
            // CloseForm
            // 
            CloseForm.Image = (Image)resources.GetObject("CloseForm.Image");
            CloseForm.Location = new Point(487, -1);
            CloseForm.Margin = new Padding(3, 5, 3, 5);
            CloseForm.Name = "CloseForm";
            CloseForm.Size = new Size(49, 40);
            CloseForm.SizeMode = PictureBoxSizeMode.CenterImage;
            CloseForm.TabIndex = 23;
            CloseForm.TabStop = false;
            CloseForm.Click += CloseForm_Click;
            // 
            // btnChontg
            // 
            btnChontg.BackColor = Color.Salmon;
            btnChontg.Location = new Point(140, 737);
            btnChontg.Name = "btnChontg";
            btnChontg.Size = new Size(246, 48);
            btnChontg.TabIndex = 24;
            btnChontg.Text = "Choose a Author";
            btnChontg.UseVisualStyleBackColor = false;
            btnChontg.Click += btnChontg_Click;
            // 
            // DSTacGia
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(535, 810);
            Controls.Add(btnChontg);
            Controls.Add(CloseForm);
            Controls.Add(label1);
            Controls.Add(tblTacGia);
            Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "DSTacGia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DSTacGia";
            Load += DSTacGia_Load;
            ((System.ComponentModel.ISupportInitialize)tblTacGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseForm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView tblTacGia;
        private Label label1;
        private PictureBox CloseForm;
        private Button btnChontg;
    }
}
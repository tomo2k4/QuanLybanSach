namespace QuanLyBanSachCSharph
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            loading = new ProgressBar();
            label2 = new Label();
            lblUpPercent = new Label();
            CountTime = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 26);
            label1.Name = "label1";
            label1.Size = new Size(672, 53);
            label1.TabIndex = 0;
            label1.Text = "Book Shop Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(53, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(695, 378);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // loading
            // 
            loading.Location = new Point(26, 480);
            loading.Name = "loading";
            loading.Size = new Size(750, 30);
            loading.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Medium", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 438);
            label2.Name = "label2";
            label2.Size = new Size(129, 28);
            label2.TabIndex = 3;
            label2.Text = "Loading ...";
            // 
            // lblUpPercent
            // 
            lblUpPercent.AutoSize = true;
            lblUpPercent.Font = new Font("Roboto Medium", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUpPercent.Location = new Point(161, 438);
            lblUpPercent.Name = "lblUpPercent";
            lblUpPercent.Size = new Size(30, 28);
            lblUpPercent.TabIndex = 4;
            lblUpPercent.Text = "%";
            // 
            // CountTime
            // 
            CountTime.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(804, 527);
            Controls.Add(label1);
            Controls.Add(lblUpPercent);
            Controls.Add(label2);
            Controls.Add(loading);
            Controls.Add(pictureBox1);
            ForeColor = Color.RoyalBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ProgressBar loading;
        private Label label2;
        private Label lblUpPercent;
        private System.Windows.Forms.Timer CountTime;
    }
}

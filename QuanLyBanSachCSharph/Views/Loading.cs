using QuanLyBanSachCSharph.Views;

namespace QuanLyBanSachCSharph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sartpos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sartpos += 1;
            loading.Value = sartpos; // Gán giá trị vào thanh loading
            lblUpPercent.Text = sartpos.ToString() + "%"; // Cập nhật % hiển thị

            if (loading.Value >= 100) // Khi đạt 100
            {
                CountTime.Stop(); // Dừng timer
                Login log = new Login(); // Tạo instance của form Login
                log.Show(); // Hiển thị form Login
                this.Hide(); // Ẩn Form1
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loading.Value = 0; // Đặt giá trị bắt đầu của thanh loading
            sartpos = 0; // Đặt lại giá trị sartpos
            CountTime.Start(); // Bắt đầu chạy timer
        }
    }
}

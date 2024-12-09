using QuanLyBanSachCSharph.Views;

namespace QuanLyBanSachCSharph
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new Login());
            //Application.Run(new Signin());
            Application.Run(new HomePage());
            //Application.Run(new MgBook());
            //Application.Run(new Theloai());

            Application.Run(new Billing());
        }
    }
}
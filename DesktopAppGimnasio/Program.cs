using DesktopAppGimnasio.Presenters;
using DesktopAppGimnasio.Views;
using System.Configuration;

namespace DesktopAppGimnasio
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

            String mySqlConnectionString = ConfigurationManager.ConnectionStrings["DesktopAppGimnasio.Properties.Settings.MySQLConnection"].ConnectionString;

            IMainView mainView = new MainView();
            new MainPresenter(mainView, mySqlConnectionString);
            Application.Run((Form) mainView);
        }
    }
}
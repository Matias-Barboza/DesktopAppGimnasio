using DesktopAppGimnasio._Repositories;
using DesktopAppGimnasio.Models;
using DesktopAppGimnasio.Presenters;
using DesktopAppGimnasio.Views;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;

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
            //ISocioView socioView = new SocioView();
            //ISocioRepository socioRepository = new SocioRepository(mySQLConnection);
            //SocioPresenter socioPresenter = new SocioPresenter(socioView, socioRepository);

            IMainView mainView = new MainView();
            new MainPresenter(mainView, mySqlConnectionString);
;
            Application.Run((Form) mainView);
        }
    }
}
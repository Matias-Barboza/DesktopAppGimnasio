using DesktopAppGimnasio._Repositories;
using DesktopAppGimnasio.Models;
using DesktopAppGimnasio.Views;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppGimnasio.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string mySqlConnectionString;

        public MainPresenter(IMainView mainView, string mySqlConnectionString)
        {
            this.mainView = mainView;
            this.mySqlConnectionString = mySqlConnectionString;
            this.mainView.ShowSociosView += ShowSociosView;
            this.mainView.ShowCuotasView += ShowCuotasView;
        }

        private void ShowSociosView(object? sender, EventArgs e)
        {
            ISocioView socioView = SocioView.GetInstance((Form) mainView);
            ISocioRepository socioRepository = new SocioRepository(mySqlConnectionString);
            SocioPresenter socioPresenter = new SocioPresenter(socioView, socioRepository);
        }

        private void ShowCuotasView(object? sender, EventArgs e)
        {
            ICuotaView cuotaView = CuotaView.GetInstance((Form) mainView);
            ICuotaRepository cuotaRepository = new CuotaRepository(mySqlConnectionString);
            CuotaPresenter cuotaPresenter = new CuotaPresenter(cuotaView, cuotaRepository);
        }
    }
}

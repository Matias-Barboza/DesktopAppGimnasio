using DesktopAppGimnasio._Repositories;
using DesktopAppGimnasio.Models;
using DesktopAppGimnasio.Views;

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
            //this.mainView.ShowPresentationView += ShowPresentationView;
            this.mainView.ShowSociosView += ShowSociosView;
            this.mainView.ShowCuotasView += ShowCuotasView;
            this.mainView.ShowTiposCuotasView += ShowTiposCuotasView;
            this.mainView.ShowAboutView += ShowAboutView;
        }

        //private void ShowPresentationView(object? sender, EventArgs e)
        //{
        //    IPresentationView presentationView = PresentationView.GetInstance((Form) mainView);
        //    PresentationPresenter presentationPresenter = new PresentationPresenter(presentationView);
        //}

        private void ShowSociosView(object? sender, EventArgs e)
        {
            ISocioView socioView = SocioView.GetInstance((Form) mainView);
            ISocioRepository socioRepository = new SocioRepository(mySqlConnectionString);
            ICuotaRepository cuotaRepository = new CuotaRepository(mySqlConnectionString);
            SocioPresenter socioPresenter = new SocioPresenter(socioView, socioRepository, cuotaRepository);
        }

        private void ShowCuotasView(object? sender, EventArgs e)
        {
            ICuotaView cuotaView = CuotaView.GetInstance((Form) mainView);
            ICuotaRepository cuotaRepository = new CuotaRepository(mySqlConnectionString);
            ISocioRepository socioRepository = new SocioRepository(mySqlConnectionString);
            ITipoCuotaRepository tipoCuotaRepository = new TipoCuotaRepository(mySqlConnectionString);
            CuotaPresenter cuotaPresenter = new CuotaPresenter(cuotaView, cuotaRepository, socioRepository, tipoCuotaRepository);
        }

        private void ShowTiposCuotasView(object? sender, EventArgs e)
        {
            ITipoCuotaView tipoCuotaView = TipoCuotaView.GetInstance((Form) mainView);
            ITipoCuotaRepository tipoCuotaRepository = new TipoCuotaRepository(mySqlConnectionString);
            TipoCuotaPresenter tipoCuotaPresenter = new TipoCuotaPresenter(tipoCuotaView, tipoCuotaRepository);
        }

        private void ShowAboutView(object? sender, EventArgs e)
        {
            IAcercaDeView acercaDeView = AcercaDeView.GetInstance((Form) mainView);
            AcercaDePresenter acercaDePresenter = new AcercaDePresenter(acercaDeView);
        }
    }
}

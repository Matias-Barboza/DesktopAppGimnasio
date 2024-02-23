namespace DesktopAppGimnasio.Views
{
    public interface IMainView
    {
        //event EventHandler ShowPresentationView;
        event EventHandler ShowSociosView;
        event EventHandler ShowCuotasView;
        event EventHandler ShowTiposCuotasView;
        event EventHandler ShowAboutView;
    }
}

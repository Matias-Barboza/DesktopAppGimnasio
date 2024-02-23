using DesktopAppGimnasio.Views;

namespace DesktopAppGimnasio.Presenters
{
    public class AcercaDePresenter
    {
        private IAcercaDeView view;

        public AcercaDePresenter(IAcercaDeView view) 
        {
            this.view = view;

            this.view.RefreshTabPages();

            this.view.Show();
        }
    }
}

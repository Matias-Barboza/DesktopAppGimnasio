using DesktopAppGimnasio.Views;

namespace DesktopAppGimnasio.Presenters
{
    public class PresentationPresenter
    {
        private IPresentationView view;

        public PresentationPresenter(IPresentationView view) 
        {
            this.view = view;

            this.view.Show();
        }
    }
}

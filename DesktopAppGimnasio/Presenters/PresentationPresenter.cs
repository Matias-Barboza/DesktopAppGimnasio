using DesktopAppGimnasio.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

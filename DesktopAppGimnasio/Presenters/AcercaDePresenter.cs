using DesktopAppGimnasio.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppGimnasio.Views
{
    public interface IMainView
    {
        event EventHandler ShowSociosView;
        event EventHandler ShowCuotasView;
    }
}

using DesktopAppGimnasio._Repositories;
using DesktopAppGimnasio.Models;
using DesktopAppGimnasio.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppGimnasio.Presenters
{
    public class TipoCuotaPresenter
    {
        private ITipoCuotaView view;
        private ITipoCuotaRepository repository;
        private BindingSource tiposCuotaBindingSource;
        private IEnumerable<TipoCuotaModel> tiposCuotaList;

        public TipoCuotaPresenter(ITipoCuotaView view, ITipoCuotaRepository repository) 
        {
            this.view = view;
            this.repository = repository;

            this.view.Show();
        }
    }
}

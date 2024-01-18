using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopAppGimnasio.Models;
using DesktopAppGimnasio.Views;

namespace DesktopAppGimnasio.Presenters
{
    public class SocioPresenter
    {
        private ISocioView view;
        private ISocioRepository repository;
        private BindingSource sociosBindingsource;
        private IEnumerable<SocioModel> sociosList;

        public SocioPresenter(ISocioView view, ISocioRepository repository) 
        {
            this.view = view;
            this.repository = repository;
            this.sociosBindingsource = new BindingSource();

            // Subscribe to Events
            this.view.SearchEvent += SearchSocio;
            this.view.AddNewEvent += AddNewSocio;
            this.view.EditEvent += LoadSelectedSocioToEdit;
            this.view.DeleteEvent += DeleteSelectedSocio;
            this.view.SaveEvent += SaveSocio;
            this.view.CancelEvent += CancelAction;

            this.view.SetSocioListBindindSource(sociosBindingsource);

            LoadAllSocioList();

            this.view.Show();
        }

        private void LoadAllSocioList()
        {
            sociosList = repository.GetAll();
            sociosBindingsource.DataSource = sociosList;
        }

        private void SearchSocio(object? sender, EventArgs e)
        {
            bool emptyValue = String.IsNullOrEmpty(this.view.SearchValue);

            if (!emptyValue)
            {
                sociosList = repository.GetByValue(this.view.SearchValue);
            }
            else 
            {
                sociosList = repository.GetAll();
            }

            sociosBindingsource.DataSource = sociosList;
        }
        private void AddNewSocio(object? sender, EventArgs e)
        {
            
        }
        private void LoadSelectedSocioToEdit(object? sender, EventArgs e)
        {
            
        }
        private void DeleteSelectedSocio(object? sender, EventArgs e)
        {
            
        }
        private void SaveSocio(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

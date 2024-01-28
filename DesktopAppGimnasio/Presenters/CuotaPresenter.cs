using DesktopAppGimnasio.Models;
using DesktopAppGimnasio.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppGimnasio.Presenters
{
    public class CuotaPresenter
    {
        private ICuotaView view;
        private ICuotaRepository repository;
        private BindingSource cuotasBindingSource;
        private IEnumerable<CuotaModel> cuotasList;

        public CuotaPresenter(ICuotaView view, ICuotaRepository repository) 
        {
            
            this.view = view;
            this.repository = repository;
            this.cuotasBindingSource = new BindingSource();


            // Subscribe to Events
            this.view.SearchEvent += SearchCuota;
            this.view.AddNewEvent += AddNewCuota;
            this.view.EditEvent += LoadSelectedCuotaToEdit;
            this.view.DeleteEvent += DeleteSelectedCuota;
            this.view.SaveEvent += SaveCuota;
            this.view.CancelEvent += CancelAction;

            this.view.SetCuotasBindingSource(cuotasBindingSource);

            LoadAllCuotasList();

            this.view.Show();
        }

        private void LoadAllCuotasList()
        {
            cuotasList = repository.GetAll();
            cuotasBindingSource.DataSource = cuotasList;
        }

        private void SearchCuota(object? sender, EventArgs e)
        {
            bool emptyValue = String.IsNullOrEmpty(this.view.SearchValue);

            if (!emptyValue)
            {
                cuotasList = repository.GetByValue(this.view.SearchValue);
            }
            else 
            {
                cuotasList = repository.GetAll();
            }

            cuotasBindingSource.DataSource = cuotasList;
        }

        private void AddNewCuota(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedCuotaToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedCuota(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveCuota(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

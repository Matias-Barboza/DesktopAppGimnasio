using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopAppGimnasio.Models;
using DesktopAppGimnasio.Presenters.CommonTasks;
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
            view.IsEdit = false;
        }
        private void LoadSelectedSocioToEdit(object? sender, EventArgs e)
        {
            SocioModel socio = (SocioModel) sociosBindingsource.Current;

            view.CodigoSocio = socio.CodigoSocio;
            view.DniSocio = socio.DNI;
            view.NombreSocio = socio.Nombre;
            view.ApellidoSocio = socio.Apellido;

            view.IsEdit = true;
        }
        private void DeleteSelectedSocio(object? sender, EventArgs e)
        {
            try
            {
                SocioModel socio = (SocioModel) sociosBindingsource.Current;
                int codigoSocio = socio.CodigoSocio;

                repository.Delete(socio.CodigoSocio);
                view.IsSuccessful = true;
                view.Message = $"El Socio {codigoSocio} fue eliminado exitosamente";
                LoadAllSocioList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "No se pudo realizar la acción debido a un error";
            }
        }


        private void SaveSocio(object? sender, EventArgs e)
        {
            SocioModel socio = new SocioModel();

            socio.CodigoSocio = view.CodigoSocio;
            socio.DNI = view.DniSocio;
            socio.Nombre = view.NombreSocio;
            socio.Apellido = view.ApellidoSocio;

            try
            {
                ModelDataValidation validator = new ModelDataValidation();

                validator.Validate(socio);

                if (view.IsEdit)
                {
                    repository.Edit(socio);
                    view.Message = $"Socio {socio.CodigoSocio} editado exitosamente";
                }
                else
                {
                    repository.Add(socio);
                    view.Message = $"Socio agregado exitosamente";
                }

                view.IsSuccessful = true;
                LoadAllSocioList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            view.CodigoSocio = 0;
            view.DniSocio = "";
            view.NombreSocio = "";
            view.ApellidoSocio = "";
        }
    }
}

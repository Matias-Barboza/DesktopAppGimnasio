using DesktopAppGimnasio.Models;
using DesktopAppGimnasio.Presenters.CommonTasks;
using DesktopAppGimnasio.Views;

namespace DesktopAppGimnasio.Presenters
{
    public class SocioPresenter
    {
        private ISocioView view;
        private ISocioRepository repository;
        private ICuotaRepository repositoryC;
        private BindingSource sociosBindingsource;
        private IEnumerable<SocioModel> sociosList;

        public SocioPresenter(ISocioView view, ISocioRepository repository, ICuotaRepository repositoryC)
        {

            this.view = view;
            this.repository = repository;
            this.repositoryC = repositoryC;
            this.sociosBindingsource = new BindingSource();

            // Subscribe to Events
            this.view.SearchEvent += SearchSocio;
            this.view.AddNewEvent += AddNewSocio;
            this.view.EditEvent += LoadSelectedSocioToEdit;
            this.view.DeleteEvent += DeleteSelectedSocio;
            this.view.SaveEvent += SaveSocio;
            this.view.CancelEvent += CancelAction;

            this.view.RefreshDataGridView += RefreshDataGridView;

            this.view.SetSocioListBindindSource(sociosBindingsource);

            LoadAllSocioList();

            this.view.Show();
        }

        //Common methods
        private void LoadAllSocioList()
        {
            sociosList = repository.GetAll();
            sociosBindingsource.DataSource = sociosList;
        }
        private void RefreshDataGridView(object? sender, EventArgs e)
        {
            LoadAllSocioList();
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
            view.MustEnter = true;
        }

        private void LoadSelectedSocioToEdit(object? sender, EventArgs e)
        {
            SocioModel socio = (SocioModel) sociosBindingsource.Current;

            view.CodigoSocio = socio.CodigoSocio;
            view.DniSocio = socio.DNI;
            view.NombreSocio = socio.Nombre;
            view.ApellidoSocio = socio.Apellido;
            view.EstaActivo = socio.EstaActivo;

            view.IsEdit = true;
            view.MustEnter = true;
        }

        private void DeleteSelectedSocio(object? sender, EventArgs e)
        {

            if (!view.MustEnter) 
            {
                return;
            }

            try
            {
                SocioModel socio = (SocioModel) sociosBindingsource.Current;
                int codigoSocio = socio.CodigoSocio;

                repositoryC.DeleteAllCuotasOfSocio(codigoSocio);
                repository.Delete(codigoSocio);
                view.IsSuccessful = true;
                view.Caption = "Estado de eliminación de socio";
                view.Message = $"El socio {codigoSocio} fue eliminado exitosamente.";
                view.MustEnter = false;
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Caption = "Error en la operación actual: Eliminación de socio";
                view.Message = "No se pudo realizar la acción debido a un error.";
            }
        }


        private void SaveSocio(object? sender, EventArgs e)
        {

            if (!view.MustEnter) 
            {
                return;
            }

            SocioModel socio = new SocioModel();

            socio.CodigoSocio = view.CodigoSocio;
            socio.DNI = view.DniSocio;
            socio.Nombre = view.NombreSocio;
            socio.Apellido = view.ApellidoSocio;
            socio.EstaActivo = (view.IsEdit) ? view.EstaActivo : true;

            try
            {
                ModelDataValidation validator = new ModelDataValidation();

                validator.Validate(socio);

                if (view.IsEdit)
                {
                    repository.Edit(socio);
                    view.Caption = "Estado de edición de socio";
                    view.Message = $"Socio {socio.CodigoSocio} editado exitosamente.";
                }
                else
                {
                    repository.Add(socio);
                    view.Caption = "Estado de adición de socio";
                    view.Message = $"Socio agregado exitosamente.";
                }

                view.IsSuccessful = true;
                CleanViewFields();
                view.MustEnter = false;
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Caption = "Error en la operación actual: Guardar socio";
                view.Message = ex.Message;
            }
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            view.MustEnter = false;
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

using DesktopAppGimnasio.Models;
using DesktopAppGimnasio.Presenters.CommonTasks;
using DesktopAppGimnasio.Views;

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
            this.tiposCuotaBindingSource = new BindingSource();

            // Subscribe to Events
            this.view.EditEvent += LoadSelectedTipoCuotaToEdit;
            this.view.SaveEvent += SaveTipoCuota;
            this.view.CancelEvent += CancelAction;

            this.view.RefreshDataGridView += RefreshDataGridView;

            this.view.SetCuotasBindingSource(tiposCuotaBindingSource);

            LoadAllTiposCuotasList();

            this.view.Show();
        }

        private void LoadAllTiposCuotasList()
        {
            tiposCuotaList = repository.GetAll();
            tiposCuotaBindingSource.DataSource = tiposCuotaList;
        }

        private void RefreshDataGridView(object? sender, EventArgs e)
        {
            LoadAllTiposCuotasList();
        }

        private void LoadSelectedTipoCuotaToEdit(object? sender, EventArgs e)
        {
            TipoCuotaModel tipoCuotaModel = (TipoCuotaModel) tiposCuotaBindingSource.Current;

            view.IdTipoCuota = tipoCuotaModel.IdTipoCuota;
            view.Descripcion = tipoCuotaModel.Descripcion;
            view.Monto = tipoCuotaModel.Monto;

            view.IsEdit = true;
            view.MustEnter = true;
        }


        private void SaveTipoCuota(object? sender, EventArgs e)
        {

            if (!view.MustEnter) 
            {
                return;
            }

            TipoCuotaModel tipoCuotaModel = new TipoCuotaModel();

            tipoCuotaModel.IdTipoCuota = view.IdTipoCuota;
            tipoCuotaModel.Descripcion = view.Descripcion;
            tipoCuotaModel.Monto = view.Monto;

            try
            {
                ModelDataValidation modelDataValidation = new ModelDataValidation();

                modelDataValidation.Validate(tipoCuotaModel);

                if (view.IsEdit) 
                {
                    repository.Edit(tipoCuotaModel);
                    view.Caption = "Estado de edición de tipo de cuota";
                    view.Message = $"Cuota \"{tipoCuotaModel.Descripcion}\" editada correctamente.";
                }

                view.IsSuccessful = true;
                CleanFieldsView();
                view.MustEnter = false;
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Caption = "Error en la operacion actual: Editar tipo de cuota";
                view.Message = ex.Message;
            }
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            view.MustEnter = false;
            view.IsEdit = false;
            CleanFieldsView();
        }

        private void CleanFieldsView()
        {
            view.IdTipoCuota = -1;
            view.Descripcion = "";
            view.Monto = 0;
        }
    }
}

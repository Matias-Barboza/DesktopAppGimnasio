using DesktopAppGimnasio.Models;
using DesktopAppGimnasio.Presenters.CommonTasks;
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

            this.view.HideColumn(4);
            this.view.HideColumn(9);
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
            view.IsEdit = false;
        }

        private void LoadSelectedCuotaToEdit(object? sender, EventArgs e)
        {
            CuotaModel cuota = (CuotaModel) cuotasBindingSource.Current;

            view.CodigoCuota = cuota.CodigoCuota;
            view.CodigoSocio = cuota.CodigoSocio;
            view.MontoAbonado = cuota.MontoAbonado;
            view.FechaDePago = cuota.FechaDePago;
            view.MesQueAbona = cuota.MesQueAbona;
            view.IdTipoCuota = cuota.IdTipoCuota;

            view.IsEdit = true;
        }

        private void DeleteSelectedCuota(object? sender, EventArgs e)
        {
            try 
            {
                CuotaModel cuota = (CuotaModel) cuotasBindingSource.Current;
                int codigoCuota = cuota.CodigoCuota;

                repository.Delete(codigoCuota);
                view.IsSuccessful = true;
                view.Caption = "Estado de eliminación de cuota";
                view.Message = $"Cuota {codigoCuota} eliminada correctamente";
                LoadAllCuotasList();
            }
            catch (Exception ex) 
            {
                view.IsSuccessful = false;
                view.Caption = "Error en la operación actual: Eliminar cuota";
                view.Message = ex.Message;
            }
        }

        private void SaveCuota(object? sender, EventArgs e)
        {
            CuotaModel cuota = new CuotaModel();

            cuota.CodigoCuota = view.CodigoCuota;
            cuota.CodigoSocio = view.CodigoSocio;
            cuota.MontoAbonado = view.MontoAbonado;
            cuota.FechaDePago = view.FechaDePago;
            cuota.MesQueAbona = view.MesQueAbona;
            cuota.IdTipoCuota = (view.IdTipoCuota != -1) ? view.IdTipoCuota + 1 : -1;

            if (cuota.IdTipoCuota == 1)
            {
                cuota.FechaDeVencimiento = cuota.FechaDePago.AddMonths(1);
            }
            else if (cuota.IdTipoCuota == 2)
            {
                cuota.FechaDeVencimiento = cuota.FechaDePago.AddDays(7);
            }
            else 
            {
                cuota.FechaDeVencimiento = cuota.FechaDePago.AddDays(1);
            }

            try
            {
                ModelDataValidation validator = new ModelDataValidation();

                validator.Validate(cuota);

                if(view.IsEdit) 
                {
                    repository.Edit(cuota);
                    view.Caption = "Estado de edición de cuota";
                    view.Message = $"Cuota {cuota.CodigoCuota} editada exitosamente";
                }
                else
                {
                    repository.Add(cuota);
                    view.Caption = "Estado de adición de cuota";
                    view.Message = $"Cuota añadida exitosamente";
                }

                view.IsSuccessful = true;
                LoadAllCuotasList();
                CleanFieldsView();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Caption = "Error en la operación actual: Guardar cuota";
                view.Message = ex.Message;
            }
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanFieldsView();
        }
    
        private void CleanFieldsView()
        {
            view.CodigoCuota = 0;
            view.CodigoSocio = 0;
            view.MontoAbonado = 0;
            view.FechaDePago = DateTime.Today;
            view.MesQueAbona = "";
            view.IdTipoCuota = -1;
        }

    }
}

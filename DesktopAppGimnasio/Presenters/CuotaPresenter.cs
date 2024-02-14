using DesktopAppGimnasio._Repositories;
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
        private ITipoCuotaRepository repositoryTC;
        private BindingSource cuotasBindingSource;
        private BindingSource cuotasVencidasBindingSource;
        private IEnumerable<CuotaModel> cuotasList;
        private IEnumerable<CuotaModel> cuotasVencidasList;

        public CuotaPresenter(ICuotaView view, ICuotaRepository repository, ITipoCuotaRepository repositoryTC)
        {

            this.view = view;
            this.repository = repository;
            this.repositoryTC = repositoryTC;
            this.cuotasBindingSource = new BindingSource();
            this.cuotasVencidasBindingSource = new BindingSource();


            // Subscribe to Events
            this.view.SearchEvent += SearchCuota;
            this.view.SearchDebtsEvent += SearchDebtCuota;
            this.view.AddNewEvent += AddNewCuota;
            this.view.EditEvent += LoadSelectedCuotaToEdit;
            this.view.DeleteEvent += DeleteSelectedCuota;
            this.view.SaveEvent += SaveCuota;
            this.view.CancelEvent += CancelAction;
            this.view.GetAmountsEvent += GetAmounts;
            this.view.RefreshDataGridView += RefreshDataGridView;
            this.view.RefreshDebtsDataGridView += RefreshDebtsDataGridView;

            this.view.SetCuotasBindingSource(cuotasBindingSource);
            this.view.SetCuotasVencidasBindingSource(cuotasVencidasBindingSource);

            LoadAllCuotasList();
            LoadAllCuotasVencidasList();
            this.view.Amounts = GetAllQuotesAmount();

            this.view.HideColumn(9);
            this.view.HideDebtsDataGridColumn(4);
            this.view.HideDebtsDataGridColumn(7);
            this.view.HideDebtsDataGridColumn(8);
            this.view.HideDebtsDataGridColumn(9);

            if (view.MustShowDebtsMessage) 
            {
                view.ShowDebtsMessage(cuotasVencidasList.Count());
            }

            this.view.Show();

        }

        // Common methods
        private void LoadAllCuotasList()
        {
            cuotasList = repository.GetAll();
            cuotasBindingSource.DataSource = cuotasList;
        }

        private void RefreshDataGridView(object? sender, EventArgs e)
        {
            LoadAllCuotasList();
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
            view.MustEnter = true;
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
            view.Cantidad = 0;

            if (view.IdTipoCuota != 0)
            {
                IEnumerable<float> amounts = GetAllQuotesAmount();

                if (cuota.MontoAbonado == amounts.ElementAt(cuota.IdTipoCuota - 1))
                {
                    float amount = amounts.ElementAt(cuota.IdTipoCuota - 1);
                    int value = (int)(cuota.MontoAbonado / amount);

                    view.Cantidad = value;
                }
                else 
                {
                    view.MontoAbonado = cuota.MontoAbonado;
                }

            }

            view.IsEdit = true;
            view.MustEnter = true;
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
                view.Message = $"La cuota {codigoCuota} fué eliminada correctamente";
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

            if (!view.MustEnter) 
            {
                return;
            }


            CuotaModel cuota = new CuotaModel();

            cuota.CodigoCuota = view.CodigoCuota;
            cuota.CodigoSocio = view.CodigoSocio;
            cuota.MontoAbonado = view.MontoAbonado;
            cuota.FechaDePago = view.FechaDePago;
            cuota.MesQueAbona = view.MesQueAbona;
            cuota.IdTipoCuota = (view.IdTipoCuota > 0) ? view.IdTipoCuota : -1;

            try
            {
                ModelDataValidation validator = new ModelDataValidation();

                validator.Validate(cuota);

                if (cuota.IdTipoCuota == 1)
                {
                    cuota.FechaDeVencimiento = cuota.FechaDePago.AddMonths(1);
                }
                else if (cuota.IdTipoCuota == 2)
                {
                    cuota.FechaDeVencimiento = cuota.FechaDePago.AddDays((view.Cantidad * 7));
                }
                else
                {
                    cuota.FechaDeVencimiento = cuota.FechaDePago.AddDays(view.Cantidad);
                }

                if (view.IsEdit) 
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
                CleanFieldsView();
                view.MustEnter = false;
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
            view.IdTipoCuota = 0;
            view.Cantidad = 0;
        }


        // Other methods
        private void LoadAllCuotasVencidasList()
        {
            cuotasVencidasList = repository.GetAllDebts();
            cuotasVencidasBindingSource.DataSource = cuotasVencidasList;
        }

        private void RefreshDebtsDataGridView(object? sender, EventArgs e)
        {
            LoadAllCuotasVencidasList();
        }

        private void SearchDebtCuota(object? sender, EventArgs e)
        {
            bool emptyValue = String.IsNullOrEmpty(view.SearchDebtValue);

            if (!emptyValue)
            {
                cuotasVencidasList = repository.GetDebtsByValue(view.SearchDebtValue);
            }
            else 
            {
                cuotasVencidasList = repository.GetAllDebts();
            }

            cuotasVencidasBindingSource.DataSource = cuotasVencidasList;
        }

        private void GetAmounts(object? sender, EventArgs e)
        {
            view.Amounts = GetAllQuotesAmount();
        }

        private IEnumerable<float> GetAllQuotesAmount()
        {
            IEnumerable<float> amountsList = repositoryTC.GetAllAmounts(); 

            return amountsList;
        }
    }
}

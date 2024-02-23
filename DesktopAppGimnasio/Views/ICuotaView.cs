namespace DesktopAppGimnasio.Views
{
    public interface ICuotaView
    {
        // Properties - Fields
        int CodigoCuota { get; set; }
        int CodigoSocio { get; set; }
        DateTime FechaDePago { get; set; }
        DateTime FechaDeVencimiento { get; set; }
        String MesQueAbona { get; set; }
        float MontoAbonado { get; set; }
        int IdTipoCuota { get; set; }

        int Cantidad { get; set; }
        IEnumerable<float> Amounts { get; set; }
        string SearchValue { get; set; }
        string SearchDebtValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        String Message { get; set; }
        String Caption {  get; set; }
        bool MustEnter { get; set; }
        bool MustShowDebtsMessage {  get; set; }

        // Events
        event EventHandler SearchEvent;
        event EventHandler SearchDebtsEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        event EventHandler GetAmountsEvent;
        event EventHandler RefreshDataGridView;
        event EventHandler RefreshDebtsDataGridView;

        public void SetCuotasBindingSource(BindingSource cuotasList);

        public void SetCuotasVencidasBindingSource(BindingSource cuotasVencidasList);

        public void HideColumn(int index);
        public void HideDebtsDataGridColumn(int index);

        public void ShowDebtsMessage(int count);

        public void Show();
    }
}

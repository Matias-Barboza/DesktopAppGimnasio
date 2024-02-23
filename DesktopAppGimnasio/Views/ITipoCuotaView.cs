namespace DesktopAppGimnasio.Views
{
    public interface ITipoCuotaView
    {
        // Properties - Fields
        int IdTipoCuota { get; set; }
        String Descripcion { get; set; }
        float Monto { get; set; }

        bool IsEdit {  get; set; }
        bool IsSuccessful { get; set; }
        String Message { get; set; }
        String Caption { get; set; }
        bool MustEnter {  get; set; }

        // Events
        event EventHandler EditEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        event EventHandler RefreshDataGridView;

        public void SetCuotasBindingSource(BindingSource tiposCuotaList);

        public void HideColumn(int index);

        public void Show();
    }
}

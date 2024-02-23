namespace DesktopAppGimnasio.Views
{
    public interface ISocioView
    {
        // Properties - Fields
        int CodigoSocio {  get; set; }
        String DniSocio { get; set; }
        String NombreSocio { get; set; }
        String ApellidoSocio { get; set; }
        bool EstaActivo {  get; set; }


        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        String Message {  get; set; }
        String Caption {  get; set; }
        bool MustEnter { get; set; }

        
        // Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        event EventHandler RefreshDataGridView;

        // Methods
        void SetSocioListBindindSource(BindingSource socioList);
        void Show();
    }
}

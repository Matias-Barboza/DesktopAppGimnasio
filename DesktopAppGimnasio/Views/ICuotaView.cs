using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        String Message { get; set; }
        String Caption {  get; set; }

        // Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        public void SetCuotasBindingSource(BindingSource cuotasList);

        public void HideColumn(int index);

        public void Show();
    }
}

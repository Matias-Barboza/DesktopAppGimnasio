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
        public int CodigoCuota { get; set; }
        public int CodigoSocio { get; set; }
        public DateTime FechaDePago { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public String MesQueAbona { get; set; }
        public float MontoAbonado { get; set; }
        public int IdTipoCuota { get; set; }


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

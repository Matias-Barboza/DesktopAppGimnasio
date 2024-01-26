using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAppGimnasio.Views
{
    public partial class CuotaView : Form, ICuotaView
    {
        public CuotaView()
        {
            InitializeComponent();
        }

        public int CodigoCuota { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CodigoSocio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime FechaDePago { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime FechaDeVencimiento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MesQueAbona { get => (String) comboBoxMes.SelectedItem; set => comboBoxMes.SelectedText = value; }
        public float MontoAbonado { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CodigoTipoCuota { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SearchValue { get => textBoxSearchCuota.Text; set => textBoxSearchCuota.Text = value; }
        public bool IsEdit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSuccessful { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetCuotasBindingSource(BindingSource cuotasList)
        {
            dataGridViewCuotas.DataSource = cuotasList;
        }

        private static CuotaView instance;
        public static CuotaView GetInstance(Form parentContainer)
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new CuotaView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }

            return instance;
        }
    }
}

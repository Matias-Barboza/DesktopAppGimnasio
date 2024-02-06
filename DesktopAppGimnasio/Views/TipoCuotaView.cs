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
    public partial class TipoCuotaView : Form, ITipoCuotaView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        private string caption;

        public TipoCuotaView()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
        }

        private void AssociateAndRaiseEvents()
        {
            // Principal Events
            buttonEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                labelOperation.Text = "Operación actual: Editar cuota";
                tabControl.SelectedTab = tabPageEditCuota;
            };
            buttonSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    labelOperation.Text = "Operación actual: Realizada con éxito";
                    tabControl.SelectedTab = tabPageTiposCuotasVisualizer;
                    labelOperation.Text = "Operación actual:";
                }

                MessageBox.Show(Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            buttonCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                labelOperation.Text = "Operación actual:";
            };


            // Other Events
            buttonClose.Click += delegate { this.Close(); };
        }

        public int IdTipoCuota { get => (textBoxIDTipoCuota.Text == "") ? -1 : Convert.ToInt32(textBoxIDTipoCuota.Text); set => textBoxIDTipoCuota.Text = (value == -1) ? String.Empty : textBoxIDTipoCuota.Text = Convert.ToString(value); }
        public string Descripcion { get => textBoxDescripcion.Text; set => textBoxDescripcion.Text = value; }
        public float Monto { get => (textBoxValorActual.Text == "") ? -1 : float.Parse(textBoxValorActual.Text) ; set => throw new NotImplementedException(); }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }
        public string Caption { get => caption; set => caption = value; }

        public event EventHandler EditEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void HideColumn(int index)
        {
            dataGridViewTiposCuotas.Columns[index].Visible = false;
        }

        public void SetCuotasBindingSource(BindingSource tiposCuotaList)
        {
            dataGridViewTiposCuotas.DataSource = tiposCuotaList;
        }

        private static TipoCuotaView instance;
        public static TipoCuotaView GetInstance(Form parentContainer)
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new TipoCuotaView();
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private bool mustEnter;

        public TipoCuotaView()
        {
            InitializeComponent();
        }

        public int IdTipoCuota { get => (textBoxIDTipoCuota.Text == "") ? -1 : Convert.ToInt32(textBoxIDTipoCuota.Text); set => textBoxIDTipoCuota.Text = (value == -1) ? String.Empty : value.ToString(); }
        public string Descripcion { get => textBoxDescripcion.Text; set => textBoxDescripcion.Text = value; }
        public float Monto { get => (textBoxValorActual.Text == "") ? 0 : float.Parse(textBoxValorActual.Text) ; set => textBoxValorActual.Text = (value == 0) ? String.Empty : value.ToString("0.00"); }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }
        public string Caption { get => caption; set => caption = value; }
        public bool MustEnter { get => mustEnter; set => mustEnter = value; }

        public event EventHandler EditEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public event EventHandler RefreshDataGridView;

        public void HideColumn(int index)
        {
            dataGridViewTiposCuotas.Columns[index].Visible = false;
        }

        public void SetCuotasBindingSource(BindingSource tiposCuotaList)
        {
            dataGridViewTiposCuotas.DataSource = tiposCuotaList;
        }

        public void CleanInterfaceProperties()
        {
            Message = string.Empty;
            Caption = string.Empty;
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

        private void buttonEditTipoCuota_MouseClick(object sender, MouseEventArgs e)
        {
            EditEvent?.Invoke(this, EventArgs.Empty);
            labelOperation.Text = "Operación actual: Editar cuota";
            tabControl.SelectedTab = tabPageEditCuota;

            buttonSaveTipoCuota.Enabled = true;
        }

        private void buttonSaveTipoCuota_MouseClick(object sender, MouseEventArgs e)
        {
            SaveEvent?.Invoke(this, EventArgs.Empty);

            if (isSuccessful)
            {
                RefreshDataGridView?.Invoke(this, EventArgs.Empty);
                tabControl.SelectedTab = tabPageTiposCuotasVisualizer;
                MustEnter = false;
            }

            labelOperation.Text = "Operación actual:";

            buttonSaveTipoCuota.Enabled = false;

            MessageBox.Show(Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            CleanInterfaceProperties();
        }

        private void buttonCancelOperation_MouseClick(object sender, MouseEventArgs e)
        {
            CancelEvent?.Invoke(this, EventArgs.Empty);
            labelOperation.Text = "Operación actual:";

            buttonSaveTipoCuota.Enabled = false;
        }

        private void buttonClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}

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
        // Fields
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        private string caption;

        public CuotaView()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
        }

        private void AssociateAndRaiseEvents()
        {
            // Principal Events
            buttonSearchCuota.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            buttonAdd.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                labelOperation.Text = "Operación actual: Añadir cuota";
            };
            buttonEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                labelOperation.Text = "Operación actual: Editar cuota";
                tabControl.SelectedTab = tabPageAddOrEditOrDeleteCuota;
            };
            buttonDelete.Click += delegate
            {
                DialogResult result = MessageBox.Show("¿Está seguro de eliminar la cuota?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            buttonSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    labelOperation.Text = "Operación actual: Realizada con éxito";
                    tabControl.SelectedTab = tabPageCuotasVisualizer;
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
            textBoxSearchCuota.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            buttonClose.Click += delegate { this.Close(); };
        }

        public int CodigoCuota { get => (textBoxCodigoCuota.Text == "") ? 0 : Convert.ToInt32(textBoxCodigoCuota.Text); set => textBoxCodigoCuota.Text = (value == 0) ? String.Empty : value.ToString(); }
        // To Do: - Validar codigo socio, Mes que abona, Monto abonado, Id Tipo Cuota
        public int CodigoSocio { get => (textBoxCodigoSocio.Text == "") ? 0 : Convert.ToInt32(textBoxCodigoSocio.Text); set => textBoxCodigoSocio.Text = (value == 0) ? String.Empty : value.ToString(); }
        public DateTime FechaDePago { get => monthCalendarFechaPago.SelectionStart; set => monthCalendarFechaPago.SetDate(value); }
        public DateTime FechaDeVencimiento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MesQueAbona { get => (String)comboBoxMes.SelectedItem; set => comboBoxMes.SelectedIndex = (value == "") ? -1 : ConvertMonthToInt(value); }
        public float MontoAbonado { get => (textBoxMonto.Text == "") ? 0 : float.Parse(textBoxMonto.Text); set => textBoxMonto.Text = (value == 0) ? String.Empty : value.ToString(); }
        public int IdTipoCuota { get => comboBoxTipoCuota.SelectedIndex; set => comboBoxTipoCuota.SelectedIndex = value; }
        public string SearchValue { get => textBoxSearchCuota.Text; set => textBoxSearchCuota.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }
        public string Caption { get => caption; set => caption = value; }

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

        public void HideColumn(int index)
        {
            dataGridViewCuotas.Columns[index].Visible = false;
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

        public int ConvertMonthToInt(string Month)
        {
            List<String> months = new List<String>()
            {
                "Enero", "Febrero", "Marzo", "Abril", "Mayo",
                "Junio", "Julio", "Agosto", "Septiembre", "Octubre",
                "Noviembre", "Diciembre"
            };

            return months.IndexOf(Month);
        }
    }
}

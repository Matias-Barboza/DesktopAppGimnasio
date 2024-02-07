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
        private IEnumerable<float> amounts;
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
            buttonSearchCuota.MouseClick += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            buttonAdd.MouseClick += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                labelOperation.Text = "Operación actual: Añadir cuota";
            };
            buttonEdit.MouseClick += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                labelOperation.Text = "Operación actual: Editar cuota";
                tabControl.SelectedTab = tabPageAddOrEditOrDeleteCuota;
                buttonAdd.Enabled = false;
            };
            buttonDelete.MouseClick += delegate
            {
                DialogResult result = MessageBox.Show("¿Está seguro de eliminar la cuota?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            buttonSave.MouseClick += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    labelOperation.Text = "Operación actual: Realizada con éxito";
                    tabControl.SelectedTab = tabPageCuotasVisualizer;
                }
                labelOperation.Text = "Operación actual:";

                if (!buttonAdd.Enabled) 
                {
                    buttonAdd.Enabled = true;
                }

                MessageBox.Show(Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            buttonCancel.MouseClick += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                labelOperation.Text = "Operación actual:";

                if (!buttonAdd.Enabled) 
                {
                    buttonAdd.Enabled = true;
                }
            };
            comboBoxTipoCuota.SelectedIndexChanged += delegate
            {
                comboBoxCantidad.Items.Clear();
                comboBoxCantidad.Text = "";
                comboBoxCantidad.SelectedIndex = -1;
                textBoxMonto.Text = "";

                if (comboBoxTipoCuota.SelectedIndex == 0)
                {
                    labelCantidad.Text = "Cantidad de meses";
                    comboBoxCantidad.Items.Add(1);
                    comboBoxCantidad.SelectedIndex = 0;
                }
                else if (comboBoxTipoCuota.SelectedIndex == 1)
                {
                    labelCantidad.Text = "Cantidad de semanas:";
                    comboBoxCantidad.Items.AddRange(new object[3] { 1, 2, 3 });
                }
                else if (comboBoxTipoCuota.SelectedIndex == 2)
                {
                    labelCantidad.Text = "Cantidad de días:";
                    comboBoxCantidad.Items.AddRange(new object[6] { 1, 2, 3, 4, 5, 6 });
                }
            };

            comboBoxCantidad.SelectedIndexChanged += delegate
            {
                GetAmountsEvent?.Invoke(this, EventArgs.Empty);

                float montoCalculado = 0;


                if (comboBoxTipoCuota.SelectedIndex == 0)
                {
                    montoCalculado = Convert.ToInt32(comboBoxCantidad.SelectedItem) * amounts.ElementAt(0);
                }
                else if (comboBoxTipoCuota.SelectedIndex == 1)
                {
                    montoCalculado = Convert.ToInt32(comboBoxCantidad.SelectedItem) * amounts.ElementAt(1);
                }
                else if (comboBoxTipoCuota.SelectedIndex == 2) 
                {
                    montoCalculado = Convert.ToInt32(comboBoxCantidad.SelectedItem) * amounts.ElementAt(2);
                }

                textBoxMonto.Text = montoCalculado.ToString("0.00");
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
        public int CodigoSocio { get => (textBoxCodigoSocio.Text == "") ? 0 : Convert.ToInt32(textBoxCodigoSocio.Text); set => textBoxCodigoSocio.Text = (value == 0) ? String.Empty : value.ToString(); }
        public DateTime FechaDePago { get => monthCalendarFechaPago.SelectionStart; set => monthCalendarFechaPago.SetDate(value); }
        public DateTime FechaDeVencimiento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MesQueAbona { get => (String)comboBoxMes.SelectedItem; set => comboBoxMes.SelectedIndex = (value == "") ? -1 : ConvertMonthToInt(value); }
        public float MontoAbonado { get => (textBoxMonto.Text == "") ? 0 : float.Parse(textBoxMonto.Text); set => textBoxMonto.Text = (value == 0) ? String.Empty : value.ToString("0.00"); }
        public int IdTipoCuota { get => comboBoxTipoCuota.SelectedIndex; set => comboBoxTipoCuota.SelectedIndex = value; }
        public IEnumerable<float> Amounts { get => amounts; set => amounts = value; }
        public int Cantidad { get => (comboBoxCantidad.SelectedItem == "") ? -1 : Convert.ToInt32(comboBoxCantidad.SelectedItem); set => comboBoxCantidad.SelectedIndex = value; }
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

        public event EventHandler GetAmountsEvent;

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

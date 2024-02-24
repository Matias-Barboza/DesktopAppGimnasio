using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private bool mustEnter;
        private bool mustShowDebtsMessage;

        public CuotaView()
        {
            InitializeComponent();
            comboBoxTipoCuota.SelectedIndex = 0;
            MustShowDebtsMessage = true;
        }

        public int CodigoCuota { get => (textBoxCodigoCuota.Text == "") ? 0 : Convert.ToInt32(textBoxCodigoCuota.Text); set => textBoxCodigoCuota.Text = (value == 0) ? String.Empty : value.ToString(); }
        public int CodigoSocio { get => (textBoxCodigoSocio.Text == "") ? 0 : Convert.ToInt32(textBoxCodigoSocio.Text); set => textBoxCodigoSocio.Text = (value == 0) ? String.Empty : value.ToString(); }
        public DateTime FechaDePago { get => monthCalendarFechaPago.SelectionStart; set => monthCalendarFechaPago.SetDate(value); }
        public DateTime FechaDeVencimiento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MesQueAbona { get => ConvertIntToMonth(monthCalendarFechaPago.SelectionStart.Month); set => MesQueAbona = value; }
        public float MontoAbonado { get => (textBoxMonto.Text == "") ? 0 : float.Parse(textBoxMonto.Text); set => textBoxMonto.Text = (value == 0) ? String.Empty : value.ToString("0.00"); }
        public int IdTipoCuota { get => comboBoxTipoCuota.SelectedIndex; set => comboBoxTipoCuota.SelectedIndex = value; }
        public IEnumerable<float> Amounts { get => amounts; set => amounts = value; }
        public int Cantidad { get => (comboBoxCantidad.SelectedItem == "") ? -1 : Convert.ToInt32(comboBoxCantidad.SelectedItem); set => comboBoxCantidad.SelectedIndex = value; }
        public string SearchValue { get => textBoxSearchCuota.Text; set => textBoxSearchCuota.Text = value; }
        public string SearchDebtValue { get => textBoxSearchDebt.Text; set => textBoxSearchDebt.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }
        public string Caption { get => caption; set => caption = value; }
        public bool MustEnter { get => mustEnter; set => mustEnter = value; }
        public bool MustShowDebtsMessage { get => mustShowDebtsMessage; set => mustShowDebtsMessage = value; }

        public event EventHandler SearchEvent;
        public event EventHandler SearchDebtsEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public event EventHandler GetAmountsEvent;
        public event EventHandler RefreshDataGridView;
        public event EventHandler RefreshDebtsDataGridView;

        public void SetCuotasBindingSource(BindingSource cuotasList)
        {
            dataGridViewCuotas.DataSource = cuotasList;
        }

        public void SetCuotasVencidasBindingSource(BindingSource cuotasList)
        {
            dataGridViewCuotasVencidas.DataSource = cuotasList;
        }

        public void HideColumn(int index)
        {
            dataGridViewCuotas.Columns[index].Visible = false;
        }

        public void HideDebtsDataGridColumn(int index)
        {
            dataGridViewCuotasVencidas.Columns[index].Visible = false;
        }

        public void ShowDebtsMessage(int count)
        {
            if (count == 0) 
            {
                return;
            }
            
            DialogResult result = MessageBox.Show($"Existen {count} cuotas vencidas. Revisar por favor.\n¿Desea seguir viendo este mensaje?", "Alerta de cuotas vencidas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) 
            {
                MustShowDebtsMessage = false;
            }
        }

        public void CleanInterfaceProperties()
        {
            Message = string.Empty;
            Caption = string.Empty;
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

        public string ConvertIntToMonth(int month)
        {
            List<String> months = new List<String>()
            {
                "","Enero", "Febrero", "Marzo", "Abril", "Mayo",
                "Junio", "Julio", "Agosto", "Septiembre", "Octubre",
                "Noviembre", "Diciembre"
            };

            return months[month];
        }

        private void buttonSearchCuota_MouseClick(object sender, MouseEventArgs e)
        {
            SearchEvent?.Invoke(this, EventArgs.Empty);
        }

        private void buttonSearchDebt_MouseClick(object sender, MouseEventArgs e)
        {
            SearchDebtsEvent?.Invoke(this, EventArgs.Empty);
        }

        private void buttonAddCuota_MouseClick(object sender, MouseEventArgs e)
        {
            AddNewEvent?.Invoke(this, EventArgs.Empty);
            labelOperation.Text = "Operación actual: Añadir cuota";

            buttonSaveCuota.Enabled = true;
        }

        private void buttonEditCuota_MouseClick(object sender, MouseEventArgs e)
        {
            EditEvent?.Invoke(this, EventArgs.Empty);
            labelOperation.Text = "Operación actual: Editar cuota";
            tabControl.SelectedTab = tabPageAddOrEditCuota;
            
            buttonAddCuota.Enabled = false;
            buttonSaveCuota.Enabled = true;
        }

        private void buttonDeleteCuota_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar la cuota?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MustEnter = true;
                DeleteEvent?.Invoke(this, EventArgs.Empty);
                RefreshDataGridView?.Invoke(this, EventArgs.Empty);
                RefreshDebtsDataGridView?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleanInterfaceProperties();
                MustEnter = false;
            }
        }

        private void buttonSaveCuota_MouseClick(object sender, MouseEventArgs e)
        {
            SaveEvent?.Invoke(this, EventArgs.Empty);

            if (isSuccessful)
            {
                RefreshDataGridView?.Invoke(this, EventArgs.Empty);
                RefreshDebtsDataGridView?.Invoke(this, EventArgs.Empty);
                tabControl.SelectedTab = tabPageCuotasVisualizer;
                MustEnter = false;
            }

            labelOperation.Text = "Operación actual:";

            if (!buttonAddCuota.Enabled)
            {
                buttonAddCuota.Enabled = true;
            }

            buttonSaveCuota.Enabled = false;

            MessageBox.Show(Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            CleanInterfaceProperties();
        }

        private void buttonCancelOperation_MouseClick(object sender, MouseEventArgs e)
        {
            CancelEvent?.Invoke(this, EventArgs.Empty);
            labelOperation.Text = "Operación actual:";

             buttonAddCuota.Enabled = true;
             buttonSaveCuota.Enabled = false;
        }
        private void comboBoxTipoCuota_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoCuota.SelectedIndex == 0)
            {
                comboBoxCantidad.Enabled = false;
                textBoxMonto.Text = string.Empty;
                return;
            }

            comboBoxCantidad.Enabled = true;
            comboBoxCantidad.Items.Clear();
            comboBoxCantidad.Text = "";
            textBoxMonto.Text = "";

            if (comboBoxTipoCuota.SelectedIndex == 1)
            {
                labelCantidad.Text = "Cantidad de meses:";
                comboBoxCantidad.Items.AddRange(new object[2] { "Seleccione una opción", 1 });
            }
            else if (comboBoxTipoCuota.SelectedIndex == 2)
            {
                labelCantidad.Text = "Cantidad de semanas:";
                comboBoxCantidad.Items.AddRange(new object[4] { "Seleccione una opción", 1, 2, 3 });
            }
            else if (comboBoxTipoCuota.SelectedIndex == 3)
            {
                labelCantidad.Text = "Cantidad de días:";
                comboBoxCantidad.Items.AddRange(new object[7] { "Seleccione una opción", 1, 2, 3, 4, 5, 6 });
            }

            comboBoxCantidad.SelectedIndex = 0;
        }

        private void comboBoxCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCantidad.SelectedIndex < 1)
            {
                textBoxMonto.Text = "";
                return;
            }

            float montoCalculado = 0;

            if (comboBoxTipoCuota.SelectedIndex == 1)
            {
                montoCalculado = Convert.ToInt32(comboBoxCantidad.SelectedItem) * amounts.ElementAt(0);
            }
            else if (comboBoxTipoCuota.SelectedIndex == 2)
            {
                montoCalculado = Convert.ToInt32(comboBoxCantidad.SelectedItem) * amounts.ElementAt(1);
            }
            else if (comboBoxTipoCuota.SelectedIndex == 3)
            {
                montoCalculado = Convert.ToInt32(comboBoxCantidad.SelectedItem) * amounts.ElementAt(2);
            }

            textBoxMonto.Text = montoCalculado.ToString("0.00");
        }

        private void textBoxSearchCuota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);
            }
        }

        private void textBoxSearchDebt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchDebtsEvent?.Invoke(this, EventArgs.Empty);
            }
        }

        private void buttonAddCuota_EnabledChanged(object sender, EventArgs e)
        {
            buttonAddCuota.ForeColor = Color.White;
        }

        private void buttonClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void dataGridViewCuotasVencidas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int columnIndexToChange = 6;

            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewCuotasVencidas.Columns["FechaDeVencimiento"].Index)
            {
                if (e.ColumnIndex == columnIndexToChange)
                {
                    e.CellStyle.BackColor = Color.IndianRed;
                }
            }
        }
    }
}

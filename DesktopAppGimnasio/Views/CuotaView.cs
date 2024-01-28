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
                DialogResult result = MessageBox.Show("¿Está seguro de eliminar el socio?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
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

                MessageBox.Show(Message);
            };
            buttonCancel.Click += delegate { 
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

        public int CodigoCuota { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CodigoSocio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime FechaDePago { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime FechaDeVencimiento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MesQueAbona { get => (String) comboBoxMes.SelectedItem; set => comboBoxMes.SelectedText = value; }
        public float MontoAbonado { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CodigoTipoCuota { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SearchValue { get => textBoxSearchCuota.Text; set => textBoxSearchCuota.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }

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

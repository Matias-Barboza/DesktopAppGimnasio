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
    public partial class SocioView : Form, ISocioView
    {
        // Fields
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        private string caption;
        private bool mustEnter;

        // Constructors
        public SocioView()
        {
            InitializeComponent();
        }

        public int CodigoSocio { get => (textBoxCodigoSocio.Text == "") ? 0 : Convert.ToInt32(textBoxCodigoSocio.Text); set => textBoxCodigoSocio.Text = (value == 0) ? String.Empty : value.ToString(); }
        public string DniSocio { get => textBoxDNI.Text; set => textBoxDNI.Text = value; }
        public string NombreSocio { get => textBoxName.Text; set => textBoxName.Text = value; }
        public string ApellidoSocio { get => textBoxLastName.Text; set => textBoxLastName.Text = value; }
        public bool EstaActivo { get => checkBoxEstado.Checked ; set => checkBoxEstado.Checked = value; }
        public string SearchValue { get => textBoxSearchSocio.Text; set => textBoxSearchSocio.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }
        public string Caption { get => caption; set => caption = value; }
        public bool MustEnter { get => mustEnter; set => mustEnter = value; }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public event EventHandler RefreshDataGridView;

        public void SetSocioListBindindSource(BindingSource sociosList)
        {
            dataGridViewSocios.DataSource = sociosList;
        }

        public void CleanInterfaceProperties()
        {
            Message = string.Empty;
            Caption = string.Empty;
        }

        public void ChangeEstadoActividadVisibility(bool visible) 
        {
            labelEstadoActividad.Visible = visible;
            checkBoxEstado.Visible = visible;
        }

        private static SocioView instance;
        public static SocioView GetInstance(Form parentContainer)
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new SocioView();
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

        // Events
        private void buttonSearchSocio_MouseClick(object sender, MouseEventArgs e)
        {
            SearchEvent?.Invoke(this, EventArgs.Empty);
        }

        private void buttonAdd_MouseClick(object sender, MouseEventArgs e)
        {
            AddNewEvent?.Invoke(this, EventArgs.Empty);
            labelOperation.Text = "Operación actual: Añadir socio";

            buttonSave.Enabled = true;
        }

        private void buttonEdit_MouseClick(object sender, MouseEventArgs e)
        {
            EditEvent?.Invoke(this, EventArgs.Empty);
            labelOperation.Text = "Operación actual: Editar socio";
            tabControl.SelectedTab = tabPageAddOrEditSocio;
            
            buttonAdd.Enabled = false;
            buttonSave.Enabled = true;

            ChangeEstadoActividadVisibility(true);
        }

        private void buttonDelete_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar el socio?\nEsto desencadena una eliminación de todas las cuotas que corresponden al socio.", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MustEnter = true;
                DeleteEvent?.Invoke(this, EventArgs.Empty);
                RefreshDataGridView?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleanInterfaceProperties();
                MustEnter = false;
            }
        }

        private void buttonSave_MouseClick(object sender, MouseEventArgs e)
        {
            SaveEvent?.Invoke(this, EventArgs.Empty);

            if (isSuccessful)
            {
                RefreshDataGridView?.Invoke(this, EventArgs.Empty);
                tabControl.SelectedTab = tabPageSociosVisualizer;
                MustEnter = false;
            }

            labelOperation.Text = "Operación actual:";

            if (!buttonAdd.Enabled)
            {
                buttonAdd.Enabled = true;
            }

            buttonSave.Enabled = false;

            ChangeEstadoActividadVisibility(false);

            MessageBox.Show(Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            CleanInterfaceProperties();
        }

        private void buttonCancel_MouseClick(object sender, MouseEventArgs e)
        {
            CancelEvent?.Invoke(this, EventArgs.Empty);
            labelOperation.Text = "Operación actual:";

            buttonAdd.Enabled = true;
            buttonSave.Enabled = false;

            ChangeEstadoActividadVisibility(false);
        }

        private void textBoxSearchSocio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);
            }
        }

        private void buttonClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_EnabledChanged(object sender, EventArgs e)
        {
            buttonAdd.ForeColor = Color.White;
        }
    }
}

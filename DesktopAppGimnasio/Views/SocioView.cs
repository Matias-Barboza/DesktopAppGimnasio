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
    public partial class SocioView : Form, ISocioView
    {
        // Fields
        private bool isEdit;
        private bool isSuccessful;
        private string message;

        // Constructors
        public SocioView()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
        }

        private void AssociateAndRaiseEvents()
        {
            // Principal Events
            buttonSearchSocio.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            buttonAdd.Click += delegate 
            { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                labelOperation.Text = "Operación actual: Añadir socio";
            };
            buttonEdit.Click += delegate 
            { 
                EditEvent?.Invoke(this, EventArgs.Empty);
                labelOperation.Text = "Operación actual: Editar socio";
                tabControl.SelectedTab = tabPageAddOrEditOrDeleteSocio;
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
                    tabControl.SelectedTab = tabPageSociosVisualizer;
                    labelOperation.Text = "Operación actual:";
                }

                MessageBox.Show(Message);
            };
            buttonCancel.Click += delegate { CancelEvent?.Invoke(this, EventArgs.Empty); };
            
            
            // Other Events
            textBoxSearchSocio.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            buttonClose.Click += delegate { this.Close(); };
            
            tabControl.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.D1)
                {
                    tabControl.SelectedTab = tabPageSociosVisualizer;
                }
            };
            
            tabControl.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.D2)
                {
                    tabControl.SelectedTab = tabPageAddOrEditOrDeleteSocio;
                }
            };
        }

        public int CodigoSocio { get => Convert.ToInt32(textBoxCodigoSocio.Text); set => textBoxCodigoSocio.Text = (value == 0) ? String.Empty : value.ToString(); }
        public string DniSocio { get => textBoxDNI.Text; set => textBoxDNI.Text = value; }
        public string NombreSocio { get => textBoxName.Text; set => textBoxName.Text = value; }
        public string ApellidoSocio { get => textBoxLastName.Text; set => textBoxLastName.Text = value; }
        public bool EstaActivo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SearchValue { get => textBoxSearchSocio.Text; set => textBoxSearchSocio.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetSocioListBindindSource(BindingSource sociosList)
        {
            dataGridViewSocios.DataSource = sociosList;
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
    }
}

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
            //tabControl1.TabPages.Remove(tabPageSociosVisualizer);
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
                DeleteEvent?.Invoke(this, EventArgs.Empty);
                labelOperation.Text = "Operación actual: Eliminar socio";
                tabControl.SelectedTab = tabPageAddOrEditOrDeleteSocio;
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
                    tabControl.SelectedIndex = 0;
                }
            };
            
            tabControl.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.D2)
                {
                    tabControl.SelectedIndex = 1;
                }
            };
        }

        public int CodigoSocio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string dniSocio { get => textBoxDNI.Text; set => textBoxDNI.Text = value; }
        public string NombreYApellidoSocio { get => textBoxName.Text; set => textBoxName.Text = value; }
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

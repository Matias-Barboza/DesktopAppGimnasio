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
        //Fields
        private bool isEdit;
        private bool isSuccessful;
        private string message;

        //Constructors
        public SocioView()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
            //tabControl1.TabPages.Remove(tabPageSociosVisualizer);
        }

        private void AssociateAndRaiseEvents()
        {
            buttonSearchSocio.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            textBoxSearchSocio.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
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
        public event EventHandler SaveEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler CancelEvent;

        public void SetSocioListBindindSource(BindingSource sociosList)
        {
            dataGridViewSocios.DataSource = sociosList;
        }
    }
}

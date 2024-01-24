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
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
        }

        public event EventHandler ShowSociosView;
        public event EventHandler ShowCuotasView;

        public void AssociateAndRaiseEvents() 
        {
            buttonSocios.Click += delegate { ShowSociosView?.Invoke(this, EventArgs.Empty); };
            buttonSocios.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.D1)
                {
                    ShowSociosView?.Invoke(this, EventArgs.Empty);
                }
            };

            buttonClose.Click += delegate { this.Close(); };
        }
    }
}

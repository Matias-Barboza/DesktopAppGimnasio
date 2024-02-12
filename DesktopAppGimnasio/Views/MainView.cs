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
            //AssociateAndRaiseEvents();
        }

        public event EventHandler ShowSociosView;
        public event EventHandler ShowCuotasView;
        public event EventHandler ShowTiposCuotasView;

        public void AssociateAndRaiseEvents()
        {
            buttonSocios.MouseClick += delegate
            {
                ShowSociosView?.Invoke(this, EventArgs.Empty);
            };
            buttonSocios.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.D1)
                {
                    ShowSociosView?.Invoke(this, EventArgs.Empty);
                }
            };
            buttonCuotas.MouseClick += delegate
            {
                ShowCuotasView?.Invoke(this, EventArgs.Empty);
            };
            buttonCuotas.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.D2)
                {
                    ShowCuotasView?.Invoke(this, EventArgs.Empty);
                }
            };
            buttonTiposCuotas.MouseClick += delegate
            {
                ShowTiposCuotasView?.Invoke(this, EventArgs.Empty);
            };
            buttonTiposCuotas.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.D3)
                {
                    ShowTiposCuotasView?.Invoke(this, EventArgs.Empty);
                }
            };


            buttonClose.MouseClick += delegate { this.Close(); };
        }

        private void buttonSocios_MouseClick(object sender, MouseEventArgs e)
        {
            ShowSociosView?.Invoke(this, EventArgs.Empty);
        }

        private void buttonCuotas_MouseClick(object sender, MouseEventArgs e)
        {
            ShowCuotasView?.Invoke(this, EventArgs.Empty);
        }

        private void buttonTiposCuotas_MouseClick(object sender, MouseEventArgs e)
        {
            ShowTiposCuotasView?.Invoke(this, EventArgs.Empty);
        }

        private void buttonClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void buttonSocios_KeyDown(object sender, KeyEventArgs e)
        {
            ShowSociosView?.Invoke(this, EventArgs.Empty);
        }

        private void buttonCuotas_KeyDown(object sender, KeyEventArgs e)
        {
            ShowCuotasView?.Invoke(this, EventArgs.Empty);
        }

        private void buttonTiposCuotas_KeyDown(object sender, KeyEventArgs e)
        {
            ShowTiposCuotasView?.Invoke(this, EventArgs.Empty);
        }
    }
}

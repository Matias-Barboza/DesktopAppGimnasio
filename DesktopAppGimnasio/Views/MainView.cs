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
        private bool dragging;
        private Point startPoint;

        public MainView()
        {
            InitializeComponent();
        }

        //public event EventHandler ShowPresentationView;
        public event EventHandler ShowSociosView;
        public event EventHandler ShowCuotasView;
        public event EventHandler ShowTiposCuotasView;
        public event EventHandler ShowAboutView;

        //private void MainView_Load(object sender, EventArgs e)
        //{
        //    ShowPresentationView?.Invoke(this, EventArgs.Empty);
        //}

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
            if(e.KeyCode == Keys.D1) 
            {
                ShowSociosView?.Invoke(this, EventArgs.Empty);
            }
        }

        private void buttonCuotas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D2)
            {
                ShowCuotasView?.Invoke(this, EventArgs.Empty);
            }
        }

        private void buttonTiposCuotas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D3) 
            {
                ShowTiposCuotasView?.Invoke(this, EventArgs.Empty);
            }
        }

        private void buttonInfo_MouseClick(object sender, MouseEventArgs e)
        {
            ShowAboutView?.Invoke(this, EventArgs.Empty);
        }

        private void buttonCloseTB_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void buttonMaximize_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                return;
            }

            this.WindowState = FormWindowState.Maximized;
        }

        private void buttonMinimize_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelMove_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point newPoint = PointToScreen(e.Location);
                Location = new Point(newPoint.X - this.startPoint.X, newPoint.Y - this.startPoint.Y);
            }
        }

        private void panelMove_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}

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
    public partial class AcercaDeView : Form, IAcercaDeView
    {
        public AcercaDeView()
        {
            InitializeComponent();
        }

        public void RefreshTabPages()
        {
            if (!tabControl.TabPages.Contains(tabPageAbout))
            {
                tabControl.TabPages.Add(tabPageAbout);
            }

            if (tabControl.TabPages.Contains(tabPageUserManual))
            {
                tabControl.TabPages.Remove(tabPageUserManual);
            }

            if (tabControl.TabPages.Contains(tabPageAboutDev))
            {
                tabControl.TabPages.Remove(tabPageAboutDev);
            }
        }

        private static AcercaDeView instance;
        public static AcercaDeView GetInstance(Form parentContainer)
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new AcercaDeView();
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

        private void buttonUserManual_MouseClick(object sender, MouseEventArgs e)
        {
            tabControl.TabPages.Add(tabPageUserManual);
            tabControl.TabPages.Remove(tabPageAbout);
            tabControl.TabPages.Remove(tabPageAboutDev);
        }

        private void buttonAboutDev_MouseClick(object sender, MouseEventArgs e)
        {
            tabControl.TabPages.Add(tabPageAboutDev);
            tabControl.TabPages.Remove(tabPageAbout);
            tabControl.TabPages.Remove(tabPageUserManual);
        }

        private void buttonClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            RefreshTabPages();
        }
    }
}

using DesktopAppGimnasio.Properties;
using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
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

        public void LoadPdf()
        {
            string resource = "Manual_de_usuario_Desktop_App_Gimnasio";

            string pdf = "Manual_de_usuario_Desktop_App_Gimnasio.pdf";

            ResourceManager resourceManager = new ResourceManager("DesktopAppGimnasio.Properties.Resources", Assembly.GetExecutingAssembly());

            byte[] bytesFile = (byte[]) resourceManager.GetObject(resource);

            string temporalDirectory = Path.GetTempPath();

            string completePdfPath = Path.Combine(temporalDirectory, pdf);

            File.WriteAllBytes(completePdfPath, bytesFile);

            if (!File.Exists(completePdfPath))
            {
                MessageBox.Show("La ruta del archivo especificado no existe o no fué encontrada.", "Ruta no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] pdfBytes = System.IO.File.ReadAllBytes(completePdfPath);

            LoadPdf(pdfBytes);
        }

        public void LoadPdf(byte[] pdfBytes)
        {
            MemoryStream stream = new MemoryStream(pdfBytes);

            LoadPdf(stream);
        }

        public void LoadPdf(Stream stream)
        {
            PdfDocument pdfDocument = PdfDocument.Load(stream);

            pdfRenderer.Load(pdfDocument);
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

            LoadPdf();
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

        private void buttonBackToAbout_MouseClick(object sender, MouseEventArgs e)
        {
            RefreshTabPages();
        }

        private void buttonBackToAbout1_MouseClick(object sender, MouseEventArgs e)
        {
            RefreshTabPages();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel.LinkVisited = true;

                Process.Start
                    (
                    new ProcessStartInfo()
                    {
                        FileName = linkLabel.Text,
                        UseShellExecute = true,
                    }
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se puede visitar en enlace seleccionado.\n{ex.Message}", "Error en la redirección", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}

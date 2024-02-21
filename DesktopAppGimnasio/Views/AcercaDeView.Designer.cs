namespace DesktopAppGimnasio.Views
{
    partial class AcercaDeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDeView));
            tabControl = new TabControl();
            tabPageAbout = new TabPage();
            buttonAboutDev = new Button();
            buttonUserManual = new Button();
            tabPageUserManual = new TabPage();
            buttonBackToAbout = new Button();
            pdfRenderer = new PdfiumViewer.PdfRenderer();
            tabPageAboutDev = new TabPage();
            buttonBackToAbout1 = new Button();
            textBoxEmailDev = new TextBox();
            labelDeveloperName = new Label();
            labelEmail = new Label();
            linkLabel = new LinkLabel();
            labelLinkedIn = new Label();
            labelLastDateActualization = new Label();
            labelDeveloper = new Label();
            labelAbout = new Label();
            pictureBox = new PictureBox();
            buttonClose = new Button();
            tabControl.SuspendLayout();
            tabPageAbout.SuspendLayout();
            tabPageUserManual.SuspendLayout();
            tabPageAboutDev.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPageAbout);
            tabControl.Controls.Add(tabPageUserManual);
            tabControl.Controls.Add(tabPageAboutDev);
            tabControl.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl.Location = new Point(0, 12);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Point(10, 8);
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(855, 548);
            tabControl.TabIndex = 0;
            tabControl.TabStop = false;
            // 
            // tabPageAbout
            // 
            tabPageAbout.BackColor = Color.FromArgb(99, 111, 113);
            tabPageAbout.Controls.Add(buttonAboutDev);
            tabPageAbout.Controls.Add(buttonUserManual);
            tabPageAbout.Location = new Point(4, 37);
            tabPageAbout.Name = "tabPageAbout";
            tabPageAbout.Padding = new Padding(3);
            tabPageAbout.Size = new Size(847, 507);
            tabPageAbout.TabIndex = 0;
            tabPageAbout.Text = "Acerca de";
            // 
            // buttonAboutDev
            // 
            buttonAboutDev.FlatAppearance.BorderColor = Color.Yellow;
            buttonAboutDev.FlatAppearance.BorderSize = 2;
            buttonAboutDev.FlatStyle = FlatStyle.Flat;
            buttonAboutDev.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAboutDev.ForeColor = Color.Yellow;
            buttonAboutDev.Image = (Image)resources.GetObject("buttonAboutDev.Image");
            buttonAboutDev.ImageAlign = ContentAlignment.TopCenter;
            buttonAboutDev.Location = new Point(354, 268);
            buttonAboutDev.Name = "buttonAboutDev";
            buttonAboutDev.Padding = new Padding(0, 8, 0, 12);
            buttonAboutDev.Size = new Size(168, 160);
            buttonAboutDev.TabIndex = 1;
            buttonAboutDev.Text = "Desarrollo";
            buttonAboutDev.TextAlign = ContentAlignment.BottomCenter;
            buttonAboutDev.UseVisualStyleBackColor = true;
            buttonAboutDev.MouseClick += buttonAboutDev_MouseClick;
            // 
            // buttonUserManual
            // 
            buttonUserManual.FlatAppearance.BorderColor = Color.Yellow;
            buttonUserManual.FlatAppearance.BorderSize = 2;
            buttonUserManual.FlatStyle = FlatStyle.Flat;
            buttonUserManual.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUserManual.ForeColor = Color.Yellow;
            buttonUserManual.Image = (Image)resources.GetObject("buttonUserManual.Image");
            buttonUserManual.ImageAlign = ContentAlignment.TopCenter;
            buttonUserManual.Location = new Point(354, 75);
            buttonUserManual.Name = "buttonUserManual";
            buttonUserManual.Size = new Size(168, 160);
            buttonUserManual.TabIndex = 0;
            buttonUserManual.Text = " Manual de usuario";
            buttonUserManual.TextAlign = ContentAlignment.BottomCenter;
            buttonUserManual.UseVisualStyleBackColor = true;
            buttonUserManual.MouseClick += buttonUserManual_MouseClick;
            // 
            // tabPageUserManual
            // 
            tabPageUserManual.BackColor = Color.FromArgb(113, 127, 129);
            tabPageUserManual.Controls.Add(buttonBackToAbout);
            tabPageUserManual.Controls.Add(pdfRenderer);
            tabPageUserManual.Location = new Point(4, 37);
            tabPageUserManual.Name = "tabPageUserManual";
            tabPageUserManual.Padding = new Padding(3);
            tabPageUserManual.Size = new Size(847, 507);
            tabPageUserManual.TabIndex = 1;
            tabPageUserManual.Text = "Manual de usuario";
            // 
            // buttonBackToAbout
            // 
            buttonBackToAbout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBackToAbout.BackColor = Color.FromArgb(128, 128, 255);
            buttonBackToAbout.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonBackToAbout.FlatAppearance.BorderSize = 2;
            buttonBackToAbout.FlatStyle = FlatStyle.Flat;
            buttonBackToAbout.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBackToAbout.ForeColor = Color.White;
            buttonBackToAbout.Image = (Image)resources.GetObject("buttonBackToAbout.Image");
            buttonBackToAbout.Location = new Point(8, 6);
            buttonBackToAbout.Name = "buttonBackToAbout";
            buttonBackToAbout.Size = new Size(47, 26);
            buttonBackToAbout.TabIndex = 0;
            buttonBackToAbout.UseVisualStyleBackColor = false;
            buttonBackToAbout.MouseClick += buttonBackToAbout_MouseClick;
            // 
            // pdfRenderer
            // 
            pdfRenderer.Location = new Point(8, 38);
            pdfRenderer.Name = "pdfRenderer";
            pdfRenderer.Page = 0;
            pdfRenderer.Rotation = PdfiumViewer.PdfRotation.Rotate0;
            pdfRenderer.Size = new Size(833, 461);
            pdfRenderer.TabIndex = 0;
            pdfRenderer.Text = "pdfRenderer1";
            pdfRenderer.ZoomMode = PdfiumViewer.PdfViewerZoomMode.FitHeight;
            // 
            // tabPageAboutDev
            // 
            tabPageAboutDev.BackColor = Color.FromArgb(136, 150, 151);
            tabPageAboutDev.Controls.Add(buttonBackToAbout1);
            tabPageAboutDev.Controls.Add(textBoxEmailDev);
            tabPageAboutDev.Controls.Add(labelDeveloperName);
            tabPageAboutDev.Controls.Add(labelEmail);
            tabPageAboutDev.Controls.Add(linkLabel);
            tabPageAboutDev.Controls.Add(labelLinkedIn);
            tabPageAboutDev.Controls.Add(labelLastDateActualization);
            tabPageAboutDev.Controls.Add(labelDeveloper);
            tabPageAboutDev.Controls.Add(labelAbout);
            tabPageAboutDev.Controls.Add(pictureBox);
            tabPageAboutDev.Location = new Point(4, 37);
            tabPageAboutDev.Name = "tabPageAboutDev";
            tabPageAboutDev.Size = new Size(847, 507);
            tabPageAboutDev.TabIndex = 2;
            tabPageAboutDev.Text = "Desarrollo";
            // 
            // buttonBackToAbout1
            // 
            buttonBackToAbout1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBackToAbout1.BackColor = Color.FromArgb(128, 128, 255);
            buttonBackToAbout1.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonBackToAbout1.FlatAppearance.BorderSize = 2;
            buttonBackToAbout1.FlatStyle = FlatStyle.Flat;
            buttonBackToAbout1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBackToAbout1.ForeColor = Color.White;
            buttonBackToAbout1.Image = (Image)resources.GetObject("buttonBackToAbout1.Image");
            buttonBackToAbout1.Location = new Point(8, 6);
            buttonBackToAbout1.Name = "buttonBackToAbout1";
            buttonBackToAbout1.Size = new Size(47, 26);
            buttonBackToAbout1.TabIndex = 0;
            buttonBackToAbout1.UseVisualStyleBackColor = false;
            buttonBackToAbout1.MouseClick += buttonBackToAbout1_MouseClick;
            // 
            // textBoxEmailDev
            // 
            textBoxEmailDev.BackColor = Color.FromArgb(136, 150, 151);
            textBoxEmailDev.BorderStyle = BorderStyle.None;
            textBoxEmailDev.Cursor = Cursors.Hand;
            textBoxEmailDev.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxEmailDev.ForeColor = Color.White;
            textBoxEmailDev.Location = new Point(350, 325);
            textBoxEmailDev.Name = "textBoxEmailDev";
            textBoxEmailDev.ReadOnly = true;
            textBoxEmailDev.Size = new Size(334, 26);
            textBoxEmailDev.TabIndex = 2;
            textBoxEmailDev.Text = "matiasbarboza540@gmail.com";
            // 
            // labelDeveloperName
            // 
            labelDeveloperName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelDeveloperName.AutoSize = true;
            labelDeveloperName.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelDeveloperName.ForeColor = Color.White;
            labelDeveloperName.Location = new Point(319, 239);
            labelDeveloperName.Name = "labelDeveloperName";
            labelDeveloperName.Size = new Size(169, 25);
            labelDeveloperName.TabIndex = 7;
            labelDeveloperName.Text = "Matias Barboza";
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(138, 326);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(213, 25);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Correo electrónico: ";
            // 
            // linkLabel
            // 
            linkLabel.ActiveLinkColor = Color.IndianRed;
            linkLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel.AutoSize = true;
            linkLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel.LinkColor = Color.DarkSlateBlue;
            linkLabel.Location = new Point(234, 282);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new Size(467, 25);
            linkLabel.TabIndex = 1;
            linkLabel.TabStop = true;
            linkLabel.Text = "http://www.linkedin.com/in/matias-barboza";
            linkLabel.LinkClicked += linkLabel_LinkClicked;
            // 
            // labelLinkedIn
            // 
            labelLinkedIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelLinkedIn.AutoSize = true;
            labelLinkedIn.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelLinkedIn.ForeColor = Color.White;
            labelLinkedIn.Location = new Point(138, 282);
            labelLinkedIn.Name = "labelLinkedIn";
            labelLinkedIn.Size = new Size(103, 25);
            labelLinkedIn.TabIndex = 4;
            labelLinkedIn.Text = "LinkedIn:";
            // 
            // labelLastDateActualization
            // 
            labelLastDateActualization.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelLastDateActualization.AutoSize = true;
            labelLastDateActualization.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelLastDateActualization.ForeColor = Color.Yellow;
            labelLastDateActualization.Location = new Point(190, 419);
            labelLastDateActualization.Name = "labelLastDateActualization";
            labelLastDateActualization.Size = new Size(324, 25);
            labelLastDateActualization.TabIndex = 3;
            labelLastDateActualization.Text = "Última fecha de actualización:";
            // 
            // labelDeveloper
            // 
            labelDeveloper.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelDeveloper.AutoSize = true;
            labelDeveloper.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelDeveloper.ForeColor = Color.White;
            labelDeveloper.Location = new Point(138, 239);
            labelDeveloper.Name = "labelDeveloper";
            labelDeveloper.Size = new Size(187, 25);
            labelDeveloper.TabIndex = 2;
            labelDeveloper.Text = "Desarrollado por:";
            // 
            // labelAbout
            // 
            labelAbout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelAbout.AutoSize = true;
            labelAbout.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAbout.ForeColor = Color.Yellow;
            labelAbout.Location = new Point(314, 165);
            labelAbout.Name = "labelAbout";
            labelAbout.Size = new Size(208, 25);
            labelAbout.TabIndex = 1;
            labelAbout.Text = "Acerca del sistema";
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(352, 29);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(134, 124);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClose.BackColor = Color.IndianRed;
            buttonClose.FlatAppearance.BorderColor = Color.Firebrick;
            buttonClose.FlatAppearance.BorderSize = 2;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClose.ForeColor = Color.Firebrick;
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.Location = new Point(774, 5);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(76, 39);
            buttonClose.TabIndex = 3;
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.MouseClick += buttonClose_MouseClick;
            // 
            // AcercaDeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(855, 560);
            Controls.Add(buttonClose);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AcercaDeView";
            Text = "AcercaDe";
            tabControl.ResumeLayout(false);
            tabPageAbout.ResumeLayout(false);
            tabPageUserManual.ResumeLayout(false);
            tabPageAboutDev.ResumeLayout(false);
            tabPageAboutDev.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageAbout;
        private TabPage tabPageUserManual;
        private TabPage tabPageAboutDev;
        private Button buttonAboutDev;
        private Button buttonUserManual;
        private Button buttonClose;
        private Button buttonBackToAbout;
        private Label labelLinkedIn;
        private Label labelLastDateActualization;
        private Label labelDeveloper;
        private Label labelAbout;
        private PictureBox pictureBox;
        private Label labelEmail;
        private LinkLabel linkLabel;
        private Label labelDeveloperName;
        private TextBox textBoxEmailDev;
        private PdfiumViewer.PdfRenderer pdfRenderer;
        private Button buttonBackToAbout1;
    }
}
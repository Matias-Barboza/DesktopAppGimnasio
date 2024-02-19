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
            tabPageAboutDev = new TabPage();
            buttonClose = new Button();
            buttonBackToAbout = new Button();
            tabControl.SuspendLayout();
            tabPageAbout.SuspendLayout();
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
            tabPageUserManual.Location = new Point(4, 37);
            tabPageUserManual.Name = "tabPageUserManual";
            tabPageUserManual.Padding = new Padding(3);
            tabPageUserManual.Size = new Size(847, 507);
            tabPageUserManual.TabIndex = 1;
            tabPageUserManual.Text = "Manual de usuario";
            // 
            // tabPageAboutDev
            // 
            tabPageAboutDev.BackColor = Color.FromArgb(136, 150, 151);
            tabPageAboutDev.Location = new Point(4, 37);
            tabPageAboutDev.Name = "tabPageAboutDev";
            tabPageAboutDev.Size = new Size(847, 507);
            tabPageAboutDev.TabIndex = 2;
            tabPageAboutDev.Text = "Desarrollo";
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
            buttonBackToAbout.Location = new Point(692, 5);
            buttonBackToAbout.Name = "buttonBackToAbout";
            buttonBackToAbout.Size = new Size(76, 39);
            buttonBackToAbout.TabIndex = 2;
            buttonBackToAbout.UseVisualStyleBackColor = false;
            buttonBackToAbout.MouseClick += button1_MouseClick;
            // 
            // AcercaDeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(855, 560);
            Controls.Add(buttonBackToAbout);
            Controls.Add(buttonClose);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AcercaDeView";
            Text = "AcercaDe";
            tabControl.ResumeLayout(false);
            tabPageAbout.ResumeLayout(false);
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
    }
}
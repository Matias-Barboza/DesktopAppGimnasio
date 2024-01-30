namespace DesktopAppGimnasio.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            buttonSocios = new Button();
            buttonCuotas = new Button();
            panel1 = new Panel();
            labelSections = new Label();
            buttonClose = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSocios
            // 
            buttonSocios.BackColor = Color.DimGray;
            buttonSocios.Cursor = Cursors.Hand;
            buttonSocios.FlatAppearance.BorderColor = Color.Yellow;
            buttonSocios.FlatAppearance.BorderSize = 2;
            buttonSocios.FlatStyle = FlatStyle.Flat;
            buttonSocios.Font = new Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSocios.ForeColor = Color.Yellow;
            buttonSocios.Image = (Image)resources.GetObject("buttonSocios.Image");
            buttonSocios.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSocios.Location = new Point(3, 156);
            buttonSocios.Name = "buttonSocios";
            buttonSocios.Size = new Size(224, 40);
            buttonSocios.TabIndex = 0;
            buttonSocios.Text = "Socios";
            buttonSocios.UseVisualStyleBackColor = false;
            // 
            // buttonCuotas
            // 
            buttonCuotas.BackColor = Color.DimGray;
            buttonCuotas.Cursor = Cursors.Hand;
            buttonCuotas.FlatAppearance.BorderColor = Color.Yellow;
            buttonCuotas.FlatAppearance.BorderSize = 2;
            buttonCuotas.FlatStyle = FlatStyle.Flat;
            buttonCuotas.Font = new Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCuotas.ForeColor = Color.Yellow;
            buttonCuotas.Image = (Image)resources.GetObject("buttonCuotas.Image");
            buttonCuotas.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCuotas.Location = new Point(3, 202);
            buttonCuotas.Name = "buttonCuotas";
            buttonCuotas.Size = new Size(224, 40);
            buttonCuotas.TabIndex = 1;
            buttonCuotas.Text = "Cuotas";
            buttonCuotas.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(labelSections);
            panel1.Controls.Add(buttonClose);
            panel1.Controls.Add(buttonSocios);
            panel1.Controls.Add(buttonCuotas);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 650);
            panel1.TabIndex = 3;
            // 
            // labelSections
            // 
            labelSections.AutoSize = true;
            labelSections.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            labelSections.ForeColor = SystemColors.ButtonHighlight;
            labelSections.Location = new Point(3, 117);
            labelSections.Name = "labelSections";
            labelSections.Size = new Size(104, 22);
            labelSections.TabIndex = 3;
            labelSections.Text = "Secciones";
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonClose.BackColor = Color.IndianRed;
            buttonClose.Cursor = Cursors.Hand;
            buttonClose.FlatAppearance.BorderColor = Color.Red;
            buttonClose.FlatAppearance.BorderSize = 2;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClose.ForeColor = SystemColors.Control;
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClose.Location = new Point(3, 603);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(224, 40);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "Salir";
            buttonClose.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(230, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(855, 100);
            panel2.TabIndex = 4;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 650);
            Controls.Add(panel2);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSocios;
        private Button buttonCuotas;
        private Panel panel1;
        private Panel panel2;
        private Button buttonClose;
        private Label labelSections;
    }
}
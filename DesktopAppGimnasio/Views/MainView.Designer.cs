﻿namespace DesktopAppGimnasio.Views
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
            buttonTiposCuotas = new Button();
            pictureBoxLogo = new PictureBox();
            labelSections = new Label();
            buttonClose = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // buttonSocios
            // 
            buttonSocios.BackColor = Color.Transparent;
            buttonSocios.Cursor = Cursors.Hand;
            buttonSocios.FlatAppearance.BorderColor = Color.Yellow;
            buttonSocios.FlatAppearance.BorderSize = 2;
            buttonSocios.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonSocios.FlatAppearance.MouseDownBackColor = Color.FromArgb(105, 119, 121);
            buttonSocios.FlatAppearance.MouseOverBackColor = Color.FromArgb(91, 103, 105);
            buttonSocios.FlatStyle = FlatStyle.Flat;
            buttonSocios.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSocios.ForeColor = Color.Yellow;
            buttonSocios.Image = (Image)resources.GetObject("buttonSocios.Image");
            buttonSocios.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSocios.Location = new Point(5, 190);
            buttonSocios.Name = "buttonSocios";
            buttonSocios.Size = new Size(292, 40);
            buttonSocios.TabIndex = 0;
            buttonSocios.Text = "Socios";
            buttonSocios.UseVisualStyleBackColor = false;
            buttonSocios.KeyDown += buttonSocios_KeyDown;
            buttonSocios.MouseClick += buttonSocios_MouseClick;
            // 
            // buttonCuotas
            // 
            buttonCuotas.BackColor = Color.Transparent;
            buttonCuotas.Cursor = Cursors.Hand;
            buttonCuotas.FlatAppearance.BorderColor = Color.Yellow;
            buttonCuotas.FlatAppearance.BorderSize = 2;
            buttonCuotas.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonCuotas.FlatAppearance.MouseDownBackColor = Color.FromArgb(105, 119, 121);
            buttonCuotas.FlatAppearance.MouseOverBackColor = Color.FromArgb(91, 103, 105);
            buttonCuotas.FlatStyle = FlatStyle.Flat;
            buttonCuotas.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCuotas.ForeColor = Color.Yellow;
            buttonCuotas.Image = (Image)resources.GetObject("buttonCuotas.Image");
            buttonCuotas.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCuotas.Location = new Point(5, 236);
            buttonCuotas.Name = "buttonCuotas";
            buttonCuotas.Size = new Size(292, 40);
            buttonCuotas.TabIndex = 1;
            buttonCuotas.Text = "Cuotas";
            buttonCuotas.UseVisualStyleBackColor = false;
            buttonCuotas.KeyDown += buttonCuotas_KeyDown;
            buttonCuotas.MouseClick += buttonCuotas_MouseClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(78, 87, 89);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(buttonTiposCuotas);
            panel1.Controls.Add(pictureBoxLogo);
            panel1.Controls.Add(labelSections);
            panel1.Controls.Add(buttonClose);
            panel1.Controls.Add(buttonSocios);
            panel1.Controls.Add(buttonCuotas);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 700);
            panel1.TabIndex = 3;
            // 
            // buttonTiposCuotas
            // 
            buttonTiposCuotas.BackColor = Color.Transparent;
            buttonTiposCuotas.Cursor = Cursors.Hand;
            buttonTiposCuotas.FlatAppearance.BorderColor = Color.Yellow;
            buttonTiposCuotas.FlatAppearance.BorderSize = 2;
            buttonTiposCuotas.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonTiposCuotas.FlatAppearance.MouseDownBackColor = Color.FromArgb(105, 119, 121);
            buttonTiposCuotas.FlatAppearance.MouseOverBackColor = Color.FromArgb(91, 103, 105);
            buttonTiposCuotas.FlatStyle = FlatStyle.Flat;
            buttonTiposCuotas.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTiposCuotas.ForeColor = Color.Yellow;
            buttonTiposCuotas.Image = (Image)resources.GetObject("buttonTiposCuotas.Image");
            buttonTiposCuotas.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTiposCuotas.Location = new Point(5, 282);
            buttonTiposCuotas.Name = "buttonTiposCuotas";
            buttonTiposCuotas.Size = new Size(292, 40);
            buttonTiposCuotas.TabIndex = 2;
            buttonTiposCuotas.Text = "     Modificar valor de cuota";
            buttonTiposCuotas.UseVisualStyleBackColor = false;
            buttonTiposCuotas.KeyDown += buttonTiposCuotas_KeyDown;
            buttonTiposCuotas.MouseClick += buttonTiposCuotas_MouseClick;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(300, 150);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // labelSections
            // 
            labelSections.AutoSize = true;
            labelSections.BackColor = Color.Yellow;
            labelSections.BorderStyle = BorderStyle.FixedSingle;
            labelSections.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSections.ForeColor = Color.FromArgb(78, 87, 89);
            labelSections.Location = new Point(0, 154);
            labelSections.Name = "labelSections";
            labelSections.Padding = new Padding(0, 3, 210, 3);
            labelSections.Size = new Size(304, 26);
            labelSections.TabIndex = 0;
            labelSections.Text = "Secciones";
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonClose.BackColor = Color.Transparent;
            buttonClose.Cursor = Cursors.Hand;
            buttonClose.FlatAppearance.BorderColor = Color.Yellow;
            buttonClose.FlatAppearance.BorderSize = 2;
            buttonClose.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            buttonClose.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClose.ForeColor = Color.Yellow;
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClose.Location = new Point(3, 648);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(294, 40);
            buttonClose.TabIndex = 3;
            buttonClose.Text = "Salir";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.MouseClick += buttonClose_MouseClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(78, 87, 89);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(855, 150);
            panel2.TabIndex = 4;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1155, 700);
            Controls.Add(panel2);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSocios;
        private Button buttonCuotas;
        private Panel panel1;
        private Panel panel2;
        private Button buttonClose;
        private Label labelSections;
        private PictureBox pictureBoxLogo;
        private Button buttonTiposCuotas;
    }
}
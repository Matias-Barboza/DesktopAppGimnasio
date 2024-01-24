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
            buttonSocios = new Button();
            button2 = new Button();
            panel1 = new Panel();
            buttonClose = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSocios
            // 
            buttonSocios.Location = new Point(3, 106);
            buttonSocios.Name = "buttonSocios";
            buttonSocios.Size = new Size(224, 40);
            buttonSocios.TabIndex = 0;
            buttonSocios.Text = "Socios";
            buttonSocios.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 152);
            button2.Name = "button2";
            button2.Size = new Size(224, 40);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(buttonClose);
            panel1.Controls.Add(buttonSocios);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 650);
            panel1.TabIndex = 3;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(3, 603);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(224, 40);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "Salir";
            buttonClose.UseVisualStyleBackColor = true;
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
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSocios;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private Button buttonClose;
    }
}
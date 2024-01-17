namespace DesktopAppGimnasio.Views
{
    partial class SocioView
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
            panelSuperior = new Panel();
            labelGymName = new Label();
            tabControl1 = new TabControl();
            tabPageAddOrEditOrDeleteSocio = new TabPage();
            panel2 = new Panel();
            labelOperation = new Label();
            labelDNI = new Label();
            textBoxDNI = new TextBox();
            textBoxLastName = new TextBox();
            labelName = new Label();
            labelLastName = new Label();
            textBoxName = new TextBox();
            panel1 = new Panel();
            buttonAdd = new Button();
            button1 = new Button();
            buttonEdit = new Button();
            tabPageCuotasRegister = new TabPage();
            tabPageSociosVisualizer = new TabPage();
            buttonSearchSocio = new Button();
            textBoxSearchSocio = new TextBox();
            dataGridViewSocios = new DataGridView();
            tabPageCuotasVisualizer = new TabPage();
            dataGridCuotas = new DataGridView();
            panelActions = new Panel();
            groupBox1 = new GroupBox();
            buttonSociosVisualizer = new Button();
            buttonExit = new Button();
            buttonCuotasVisualizer = new Button();
            buttonCuotasRegister = new Button();
            buttonAddOrEditOrDeleteSocio = new Button();
            labelOptions = new Label();
            panelSuperior.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageAddOrEditOrDeleteSocio.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tabPageSociosVisualizer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSocios).BeginInit();
            tabPageCuotasVisualizer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCuotas).BeginInit();
            panelActions.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.Controls.Add(labelGymName);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(854, 93);
            panelSuperior.TabIndex = 0;
            // 
            // labelGymName
            // 
            labelGymName.AutoSize = true;
            labelGymName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelGymName.Location = new Point(329, 39);
            labelGymName.Name = "labelGymName";
            labelGymName.Size = new Size(167, 32);
            labelGymName.TabIndex = 0;
            labelGymName.Text = "Complemento";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageAddOrEditOrDeleteSocio);
            tabControl1.Controls.Add(tabPageCuotasRegister);
            tabControl1.Controls.Add(tabPageSociosVisualizer);
            tabControl1.Controls.Add(tabPageCuotasVisualizer);
            tabControl1.Dock = DockStyle.Right;
            tabControl1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(189, 93);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(665, 416);
            tabControl1.TabIndex = 1;
            // 
            // tabPageAddOrEditOrDeleteSocio
            // 
            tabPageAddOrEditOrDeleteSocio.Controls.Add(panel2);
            tabPageAddOrEditOrDeleteSocio.Controls.Add(panel1);
            tabPageAddOrEditOrDeleteSocio.Location = new Point(4, 26);
            tabPageAddOrEditOrDeleteSocio.Name = "tabPageAddOrEditOrDeleteSocio";
            tabPageAddOrEditOrDeleteSocio.Padding = new Padding(3);
            tabPageAddOrEditOrDeleteSocio.Size = new Size(657, 386);
            tabPageAddOrEditOrDeleteSocio.TabIndex = 1;
            tabPageAddOrEditOrDeleteSocio.Text = "Añadir/Editar/Eliminar Socio";
            tabPageAddOrEditOrDeleteSocio.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelOperation);
            panel2.Controls.Add(labelDNI);
            panel2.Controls.Add(textBoxDNI);
            panel2.Controls.Add(textBoxLastName);
            panel2.Controls.Add(labelName);
            panel2.Controls.Add(labelLastName);
            panel2.Controls.Add(textBoxName);
            panel2.Location = new Point(180, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(474, 361);
            panel2.TabIndex = 10;
            // 
            // labelOperation
            // 
            labelOperation.AutoSize = true;
            labelOperation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelOperation.Location = new Point(86, 7);
            labelOperation.Name = "labelOperation";
            labelOperation.Size = new Size(160, 25);
            labelOperation.TabIndex = 6;
            labelOperation.Text = "Operación actual:";
            // 
            // labelDNI
            // 
            labelDNI.AutoSize = true;
            labelDNI.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDNI.Location = new Point(8, 79);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(40, 21);
            labelDNI.TabIndex = 0;
            labelDNI.Text = "DNI:";
            // 
            // textBoxDNI
            // 
            textBoxDNI.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDNI.Location = new Point(8, 106);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(117, 29);
            textBoxDNI.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastName.Location = new Point(8, 250);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(100, 29);
            textBoxLastName.TabIndex = 5;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(8, 155);
            labelName.Name = "labelName";
            labelName.Size = new Size(71, 21);
            labelName.TabIndex = 2;
            labelName.Text = "Nombre:";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLastName.Location = new Point(8, 226);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(67, 21);
            labelLastName.TabIndex = 4;
            labelLastName.Text = "Apellido";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(8, 179);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(185, 29);
            textBoxName.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonEdit);
            panel1.Location = new Point(6, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 364);
            panel1.TabIndex = 9;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(25, 180);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(117, 34);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Añadir";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(25, 262);
            button1.Name = "button1";
            button1.Size = new Size(117, 34);
            button1.TabIndex = 7;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(25, 220);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(117, 34);
            buttonEdit.TabIndex = 8;
            buttonEdit.Text = "Editar";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // tabPageCuotasRegister
            // 
            tabPageCuotasRegister.Location = new Point(4, 26);
            tabPageCuotasRegister.Name = "tabPageCuotasRegister";
            tabPageCuotasRegister.Padding = new Padding(3);
            tabPageCuotasRegister.Size = new Size(657, 386);
            tabPageCuotasRegister.TabIndex = 2;
            tabPageCuotasRegister.Text = "Registrar pago de cuota";
            tabPageCuotasRegister.UseVisualStyleBackColor = true;
            // 
            // tabPageSociosVisualizer
            // 
            tabPageSociosVisualizer.Controls.Add(buttonSearchSocio);
            tabPageSociosVisualizer.Controls.Add(textBoxSearchSocio);
            tabPageSociosVisualizer.Controls.Add(dataGridViewSocios);
            tabPageSociosVisualizer.Location = new Point(4, 26);
            tabPageSociosVisualizer.Name = "tabPageSociosVisualizer";
            tabPageSociosVisualizer.Padding = new Padding(3);
            tabPageSociosVisualizer.Size = new Size(657, 386);
            tabPageSociosVisualizer.TabIndex = 3;
            tabPageSociosVisualizer.Text = "Administración de socios";
            tabPageSociosVisualizer.UseVisualStyleBackColor = true;
            // 
            // buttonSearchSocio
            // 
            buttonSearchSocio.Location = new Point(554, 21);
            buttonSearchSocio.Name = "buttonSearchSocio";
            buttonSearchSocio.Size = new Size(97, 25);
            buttonSearchSocio.TabIndex = 2;
            buttonSearchSocio.Text = "Buscar socio";
            buttonSearchSocio.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchSocio
            // 
            textBoxSearchSocio.Location = new Point(6, 22);
            textBoxSearchSocio.Name = "textBoxSearchSocio";
            textBoxSearchSocio.Size = new Size(540, 25);
            textBoxSearchSocio.TabIndex = 1;
            // 
            // dataGridViewSocios
            // 
            dataGridViewSocios.AllowUserToAddRows = false;
            dataGridViewSocios.AllowUserToDeleteRows = false;
            dataGridViewSocios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSocios.Location = new Point(6, 62);
            dataGridViewSocios.Name = "dataGridViewSocios";
            dataGridViewSocios.ReadOnly = true;
            dataGridViewSocios.RowTemplate.Height = 25;
            dataGridViewSocios.Size = new Size(645, 314);
            dataGridViewSocios.TabIndex = 0;
            // 
            // tabPageCuotasVisualizer
            // 
            tabPageCuotasVisualizer.Controls.Add(dataGridCuotas);
            tabPageCuotasVisualizer.Location = new Point(4, 26);
            tabPageCuotasVisualizer.Name = "tabPageCuotasVisualizer";
            tabPageCuotasVisualizer.Padding = new Padding(3);
            tabPageCuotasVisualizer.Size = new Size(657, 386);
            tabPageCuotasVisualizer.TabIndex = 4;
            tabPageCuotasVisualizer.Text = "Administración de cuotas";
            tabPageCuotasVisualizer.UseVisualStyleBackColor = true;
            // 
            // dataGridCuotas
            // 
            dataGridCuotas.AllowUserToAddRows = false;
            dataGridCuotas.AllowUserToDeleteRows = false;
            dataGridCuotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCuotas.Location = new Point(6, 62);
            dataGridCuotas.Name = "dataGridCuotas";
            dataGridCuotas.ReadOnly = true;
            dataGridCuotas.RowTemplate.Height = 25;
            dataGridCuotas.Size = new Size(645, 314);
            dataGridCuotas.TabIndex = 1;
            // 
            // panelActions
            // 
            panelActions.BackColor = SystemColors.Control;
            panelActions.Controls.Add(groupBox1);
            panelActions.Controls.Add(labelOptions);
            panelActions.Dock = DockStyle.Fill;
            panelActions.Location = new Point(0, 93);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(189, 416);
            panelActions.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSociosVisualizer);
            groupBox1.Controls.Add(buttonExit);
            groupBox1.Controls.Add(buttonCuotasVisualizer);
            groupBox1.Controls.Add(buttonCuotasRegister);
            groupBox1.Controls.Add(buttonAddOrEditOrDeleteSocio);
            groupBox1.Location = new Point(3, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(180, 349);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // buttonSociosVisualizer
            // 
            buttonSociosVisualizer.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSociosVisualizer.Location = new Point(0, 134);
            buttonSociosVisualizer.Name = "buttonSociosVisualizer";
            buttonSociosVisualizer.Size = new Size(180, 54);
            buttonSociosVisualizer.TabIndex = 4;
            buttonSociosVisualizer.Text = "Administración de socios (3)";
            buttonSociosVisualizer.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.Location = new Point(0, 300);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(180, 43);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "Salir";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonCuotasVisualizer
            // 
            buttonCuotasVisualizer.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCuotasVisualizer.Location = new Point(0, 193);
            buttonCuotasVisualizer.Name = "buttonCuotasVisualizer";
            buttonCuotasVisualizer.Size = new Size(180, 54);
            buttonCuotasVisualizer.TabIndex = 2;
            buttonCuotasVisualizer.Text = "Administración de cuotas (4)";
            buttonCuotasVisualizer.UseVisualStyleBackColor = true;
            // 
            // buttonCuotasRegister
            // 
            buttonCuotasRegister.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCuotasRegister.Location = new Point(0, 74);
            buttonCuotasRegister.Name = "buttonCuotasRegister";
            buttonCuotasRegister.Size = new Size(180, 54);
            buttonCuotasRegister.TabIndex = 1;
            buttonCuotasRegister.Text = "Registrar pago de cuota (2)";
            buttonCuotasRegister.UseVisualStyleBackColor = true;
            // 
            // buttonAddOrEditOrDeleteSocio
            // 
            buttonAddOrEditOrDeleteSocio.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddOrEditOrDeleteSocio.Location = new Point(1, 16);
            buttonAddOrEditOrDeleteSocio.Name = "buttonAddOrEditOrDeleteSocio";
            buttonAddOrEditOrDeleteSocio.Size = new Size(180, 54);
            buttonAddOrEditOrDeleteSocio.TabIndex = 0;
            buttonAddOrEditOrDeleteSocio.Text = "Añadir/Editar/Eliminar Socio (1)";
            buttonAddOrEditOrDeleteSocio.UseVisualStyleBackColor = true;
            // 
            // labelOptions
            // 
            labelOptions.AutoSize = true;
            labelOptions.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelOptions.Location = new Point(0, 26);
            labelOptions.Name = "labelOptions";
            labelOptions.Size = new Size(104, 30);
            labelOptions.TabIndex = 0;
            labelOptions.Text = "Opciones";
            // 
            // SocioView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(854, 509);
            Controls.Add(panelActions);
            Controls.Add(tabControl1);
            Controls.Add(panelSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SocioView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel de administración de socios";
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageAddOrEditOrDeleteSocio.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            tabPageSociosVisualizer.ResumeLayout(false);
            tabPageSociosVisualizer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSocios).EndInit();
            tabPageCuotasVisualizer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridCuotas).EndInit();
            panelActions.ResumeLayout(false);
            panelActions.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Label labelGymName;
        private TabControl tabControl1;
        private TabPage tabPageAddOrEditOrDeleteSocio;
        private Panel panelActions;
        private Label labelOptions;
        private GroupBox groupBox1;
        private Button buttonCuotasVisualizer;
        private Button buttonCuotasRegister;
        private Button buttonAddOrEditOrDeleteSocio;
        private Button buttonExit;
        private Button buttonSociosVisualizer;
        private TabPage tabPageSociosVisualizer;
        private DataGridView dataGridViewSocios;
        private TabPage tabPageCuotasVisualizer;
        private DataGridView dataGridCuotas;
        private TabPage tabPageCuotasRegister;
        private TextBox textBoxLastName;
        private Label labelLastName;
        private TextBox textBoxName;
        private Label labelName;
        private TextBox textBoxDNI;
        private Label labelDNI;
        private Label labelOperation;
        private Button buttonEdit;
        private Button button1;
        private Button buttonAdd;
        private Panel panel2;
        private Panel panel1;
        private Button buttonSearchSocio;
        private TextBox textBoxSearchSocio;
    }
}
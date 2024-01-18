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
            tabControl = new TabControl();
            tabPageSociosVisualizer = new TabPage();
            buttonEdit = new Button();
            buttonSearchSocio = new Button();
            textBoxSearchSocio = new TextBox();
            dataGridViewSocios = new DataGridView();
            tabPageAddOrEditOrDeleteSocio = new TabPage();
            panelOperation = new Panel();
            buttonCancel = new Button();
            buttonSave = new Button();
            buttonAdd = new Button();
            buttonDelete = new Button();
            labelOperation = new Label();
            labelDNI = new Label();
            textBoxDNI = new TextBox();
            textBoxLastName = new TextBox();
            labelName = new Label();
            labelLastName = new Label();
            textBoxName = new TextBox();
            buttonClose = new Button();
            tabControl.SuspendLayout();
            tabPageSociosVisualizer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSocios).BeginInit();
            tabPageAddOrEditOrDeleteSocio.SuspendLayout();
            panelOperation.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPageSociosVisualizer);
            tabControl.Controls.Add(tabPageAddOrEditOrDeleteSocio);
            tabControl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl.Location = new Point(0, 50);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(855, 510);
            tabControl.TabIndex = 1;
            // 
            // tabPageSociosVisualizer
            // 
            tabPageSociosVisualizer.Controls.Add(buttonEdit);
            tabPageSociosVisualizer.Controls.Add(buttonSearchSocio);
            tabPageSociosVisualizer.Controls.Add(buttonDelete);
            tabPageSociosVisualizer.Controls.Add(textBoxSearchSocio);
            tabPageSociosVisualizer.Controls.Add(dataGridViewSocios);
            tabPageSociosVisualizer.Location = new Point(4, 30);
            tabPageSociosVisualizer.Name = "tabPageSociosVisualizer";
            tabPageSociosVisualizer.Padding = new Padding(3);
            tabPageSociosVisualizer.Size = new Size(847, 476);
            tabPageSociosVisualizer.TabIndex = 3;
            tabPageSociosVisualizer.Text = "Administración de socios";
            tabPageSociosVisualizer.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEdit.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(717, 62);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(125, 39);
            buttonEdit.TabIndex = 3;
            buttonEdit.Text = "Editar";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonSearchSocio
            // 
            buttonSearchSocio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearchSocio.Location = new Point(554, 20);
            buttonSearchSocio.Name = "buttonSearchSocio";
            buttonSearchSocio.Size = new Size(100, 30);
            buttonSearchSocio.TabIndex = 2;
            buttonSearchSocio.Text = "Buscar socio";
            buttonSearchSocio.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchSocio
            // 
            textBoxSearchSocio.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchSocio.Location = new Point(6, 20);
            textBoxSearchSocio.Name = "textBoxSearchSocio";
            textBoxSearchSocio.Size = new Size(540, 31);
            textBoxSearchSocio.TabIndex = 1;
            // 
            // dataGridViewSocios
            // 
            dataGridViewSocios.AllowUserToAddRows = false;
            dataGridViewSocios.AllowUserToDeleteRows = false;
            dataGridViewSocios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSocios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSocios.Location = new Point(6, 62);
            dataGridViewSocios.Name = "dataGridViewSocios";
            dataGridViewSocios.ReadOnly = true;
            dataGridViewSocios.RowTemplate.Height = 25;
            dataGridViewSocios.Size = new Size(705, 407);
            dataGridViewSocios.TabIndex = 0;
            // 
            // tabPageAddOrEditOrDeleteSocio
            // 
            tabPageAddOrEditOrDeleteSocio.Controls.Add(panelOperation);
            tabPageAddOrEditOrDeleteSocio.Location = new Point(4, 30);
            tabPageAddOrEditOrDeleteSocio.Name = "tabPageAddOrEditOrDeleteSocio";
            tabPageAddOrEditOrDeleteSocio.Padding = new Padding(3);
            tabPageAddOrEditOrDeleteSocio.Size = new Size(847, 476);
            tabPageAddOrEditOrDeleteSocio.TabIndex = 1;
            tabPageAddOrEditOrDeleteSocio.Text = "Añadir/Editar/Eliminar Socio";
            tabPageAddOrEditOrDeleteSocio.UseVisualStyleBackColor = true;
            // 
            // panelOperation
            // 
            panelOperation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelOperation.Controls.Add(buttonCancel);
            panelOperation.Controls.Add(buttonSave);
            panelOperation.Controls.Add(buttonAdd);
            panelOperation.Controls.Add(labelOperation);
            panelOperation.Controls.Add(labelDNI);
            panelOperation.Controls.Add(textBoxDNI);
            panelOperation.Controls.Add(textBoxLastName);
            panelOperation.Controls.Add(labelName);
            panelOperation.Controls.Add(labelLastName);
            panelOperation.Controls.Add(textBoxName);
            panelOperation.Location = new Point(3, 3);
            panelOperation.Name = "panelOperation";
            panelOperation.Size = new Size(841, 474);
            panelOperation.TabIndex = 10;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonCancel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(437, 403);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(165, 34);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonSave.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(257, 403);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(165, 34);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Guardar";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAdd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(257, 356);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(345, 39);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Añadir";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDelete.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(717, 107);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(125, 39);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "Eliminar";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // labelOperation
            // 
            labelOperation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelOperation.AutoSize = true;
            labelOperation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelOperation.Location = new Point(17, 21);
            labelOperation.Name = "labelOperation";
            labelOperation.Size = new Size(160, 25);
            labelOperation.TabIndex = 6;
            labelOperation.Text = "Operación actual:";
            // 
            // labelDNI
            // 
            labelDNI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            textBoxDNI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDNI.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDNI.Location = new Point(8, 106);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(238, 29);
            textBoxDNI.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastName.Location = new Point(8, 250);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(295, 29);
            textBoxLastName.TabIndex = 5;
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            labelLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(8, 179);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(295, 29);
            textBoxName.TabIndex = 3;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClose.Location = new Point(770, 10);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(76, 39);
            buttonClose.TabIndex = 3;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = true;
            // 
            // SocioView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(855, 560);
            Controls.Add(buttonClose);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SocioView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel de administración de socios";
            tabControl.ResumeLayout(false);
            tabPageSociosVisualizer.ResumeLayout(false);
            tabPageSociosVisualizer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSocios).EndInit();
            tabPageAddOrEditOrDeleteSocio.ResumeLayout(false);
            panelOperation.ResumeLayout(false);
            panelOperation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl;
        private TabPage tabPageAddOrEditOrDeleteSocio;
        private TabPage tabPageSociosVisualizer;
        private DataGridView dataGridViewSocios;
        private TextBox textBoxLastName;
        private Label labelLastName;
        private TextBox textBoxName;
        private Label labelName;
        private TextBox textBoxDNI;
        private Label labelDNI;
        private Label labelOperation;
        private Panel panelOperation;
        private Button buttonSearchSocio;
        private TextBox textBoxSearchSocio;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonClose;
        private Button buttonEdit;
        private Button buttonCancel;
        private Button buttonSave;
    }
}
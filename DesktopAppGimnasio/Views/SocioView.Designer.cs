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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SocioView));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tabControl = new TabControl();
            tabPageSociosVisualizer = new TabPage();
            buttonEdit = new Button();
            buttonSearchSocio = new Button();
            buttonDelete = new Button();
            textBoxSearchSocio = new TextBox();
            dataGridViewSocios = new DataGridView();
            tabPageAddOrEditOrDeleteSocio = new TabPage();
            buttonCancel = new Button();
            buttonSave = new Button();
            labelCodigoSocio = new Label();
            buttonAdd = new Button();
            textBoxName = new TextBox();
            labelOperation = new Label();
            labelLastName = new Label();
            textBoxCodigoSocio = new TextBox();
            labelName = new Label();
            textBoxLastName = new TextBox();
            labelDNI = new Label();
            textBoxDNI = new TextBox();
            buttonClose = new Button();
            tabControl.SuspendLayout();
            tabPageSociosVisualizer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSocios).BeginInit();
            tabPageAddOrEditOrDeleteSocio.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPageSociosVisualizer);
            tabControl.Controls.Add(tabPageAddOrEditOrDeleteSocio);
            tabControl.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl.Location = new Point(0, 12);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Point(10, 8);
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(855, 548);
            tabControl.TabIndex = 1;
            // 
            // tabPageSociosVisualizer
            // 
            tabPageSociosVisualizer.BackColor = Color.FromArgb(99, 111, 113);
            tabPageSociosVisualizer.Controls.Add(buttonEdit);
            tabPageSociosVisualizer.Controls.Add(buttonSearchSocio);
            tabPageSociosVisualizer.Controls.Add(buttonDelete);
            tabPageSociosVisualizer.Controls.Add(textBoxSearchSocio);
            tabPageSociosVisualizer.Controls.Add(dataGridViewSocios);
            tabPageSociosVisualizer.Location = new Point(4, 37);
            tabPageSociosVisualizer.Name = "tabPageSociosVisualizer";
            tabPageSociosVisualizer.Padding = new Padding(3);
            tabPageSociosVisualizer.Size = new Size(847, 507);
            tabPageSociosVisualizer.TabIndex = 3;
            tabPageSociosVisualizer.Text = "Administración de socios";
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEdit.BackColor = Color.FromArgb(128, 128, 255);
            buttonEdit.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonEdit.FlatAppearance.BorderSize = 2;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Image = (Image)resources.GetObject("buttonEdit.Image");
            buttonEdit.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEdit.Location = new Point(717, 62);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(125, 39);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "  Editar";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonSearchSocio
            // 
            buttonSearchSocio.BackColor = Color.FromArgb(128, 128, 255);
            buttonSearchSocio.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonSearchSocio.FlatAppearance.BorderSize = 2;
            buttonSearchSocio.FlatStyle = FlatStyle.Flat;
            buttonSearchSocio.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearchSocio.ForeColor = Color.White;
            buttonSearchSocio.Image = (Image)resources.GetObject("buttonSearchSocio.Image");
            buttonSearchSocio.ImageAlign = ContentAlignment.MiddleRight;
            buttonSearchSocio.Location = new Point(409, 20);
            buttonSearchSocio.Name = "buttonSearchSocio";
            buttonSearchSocio.Size = new Size(100, 32);
            buttonSearchSocio.TabIndex = 1;
            buttonSearchSocio.Text = "Buscar";
            buttonSearchSocio.TextAlign = ContentAlignment.MiddleLeft;
            buttonSearchSocio.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDelete.BackColor = Color.FromArgb(128, 128, 255);
            buttonDelete.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonDelete.FlatAppearance.BorderSize = 2;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDelete.Location = new Point(717, 107);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(125, 39);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "    Eliminar";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // textBoxSearchSocio
            // 
            textBoxSearchSocio.BackColor = Color.FromArgb(168, 178, 179);
            textBoxSearchSocio.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearchSocio.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxSearchSocio.ForeColor = Color.Black;
            textBoxSearchSocio.Location = new Point(6, 21);
            textBoxSearchSocio.Name = "textBoxSearchSocio";
            textBoxSearchSocio.Size = new Size(397, 29);
            textBoxSearchSocio.TabIndex = 0;
            // 
            // dataGridViewSocios
            // 
            dataGridViewSocios.AllowUserToAddRows = false;
            dataGridViewSocios.AllowUserToDeleteRows = false;
            dataGridViewSocios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSocios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSocios.BackgroundColor = Color.FromArgb(99, 111, 113);
            dataGridViewSocios.BorderStyle = BorderStyle.None;
            dataGridViewSocios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Gold;
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewSocios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSocios.ColumnHeadersHeight = 50;
            dataGridViewSocios.EnableHeadersVisualStyles = false;
            dataGridViewSocios.GridColor = Color.Goldenrod;
            dataGridViewSocios.Location = new Point(6, 62);
            dataGridViewSocios.MultiSelect = false;
            dataGridViewSocios.Name = "dataGridViewSocios";
            dataGridViewSocios.ReadOnly = true;
            dataGridViewSocios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(99, 111, 113);
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(99, 111, 113);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewSocios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewSocios.RowHeadersVisible = false;
            dataGridViewSocios.RowHeadersWidth = 20;
            dataGridViewSocios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(99, 111, 113);
            dataGridViewCellStyle3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(99, 111, 113);
            dataGridViewSocios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewSocios.RowTemplate.Height = 30;
            dataGridViewSocios.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridViewSocios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSocios.Size = new Size(705, 437);
            dataGridViewSocios.TabIndex = 4;
            // 
            // tabPageAddOrEditOrDeleteSocio
            // 
            tabPageAddOrEditOrDeleteSocio.BackColor = Color.FromArgb(136, 150, 151);
            tabPageAddOrEditOrDeleteSocio.Controls.Add(buttonCancel);
            tabPageAddOrEditOrDeleteSocio.Controls.Add(buttonSave);
            tabPageAddOrEditOrDeleteSocio.Controls.Add(labelCodigoSocio);
            tabPageAddOrEditOrDeleteSocio.Controls.Add(buttonAdd);
            tabPageAddOrEditOrDeleteSocio.Controls.Add(textBoxName);
            tabPageAddOrEditOrDeleteSocio.Controls.Add(labelOperation);
            tabPageAddOrEditOrDeleteSocio.Controls.Add(labelLastName);
            tabPageAddOrEditOrDeleteSocio.Controls.Add(textBoxCodigoSocio);
            tabPageAddOrEditOrDeleteSocio.Controls.Add(labelName);
            tabPageAddOrEditOrDeleteSocio.Controls.Add(textBoxLastName);
            tabPageAddOrEditOrDeleteSocio.Controls.Add(labelDNI);
            tabPageAddOrEditOrDeleteSocio.Controls.Add(textBoxDNI);
            tabPageAddOrEditOrDeleteSocio.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPageAddOrEditOrDeleteSocio.Location = new Point(4, 37);
            tabPageAddOrEditOrDeleteSocio.Name = "tabPageAddOrEditOrDeleteSocio";
            tabPageAddOrEditOrDeleteSocio.Padding = new Padding(3);
            tabPageAddOrEditOrDeleteSocio.Size = new Size(847, 507);
            tabPageAddOrEditOrDeleteSocio.TabIndex = 1;
            tabPageAddOrEditOrDeleteSocio.Text = "Añadir/Editar/Eliminar Socio";
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonCancel.BackColor = Color.FromArgb(128, 128, 255);
            buttonCancel.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonCancel.FlatAppearance.BorderSize = 2;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Image = (Image)resources.GetObject("buttonCancel.Image");
            buttonCancel.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancel.Location = new Point(303, 446);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(240, 38);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonSave.BackColor = Color.FromArgb(128, 128, 255);
            buttonSave.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonSave.FlatAppearance.BorderSize = 2;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = Color.White;
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(303, 402);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(240, 38);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Guardar";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // labelCodigoSocio
            // 
            labelCodigoSocio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelCodigoSocio.AutoSize = true;
            labelCodigoSocio.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCodigoSocio.ForeColor = Color.White;
            labelCodigoSocio.Location = new Point(22, 84);
            labelCodigoSocio.Name = "labelCodigoSocio";
            labelCodigoSocio.Size = new Size(172, 23);
            labelCodigoSocio.TabIndex = 10;
            labelCodigoSocio.Text = "Número de socio:";
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonAdd.BackColor = Color.FromArgb(128, 128, 255);
            buttonAdd.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonAdd.FlatAppearance.BorderSize = 2;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Image = (Image)resources.GetObject("buttonAdd.Image");
            buttonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdd.Location = new Point(303, 358);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(240, 38);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Añadir";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.BackColor = Color.DimGray;
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxName.ForeColor = Color.White;
            textBoxName.Location = new Point(22, 241);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(238, 27);
            textBoxName.TabIndex = 1;
            // 
            // labelOperation
            // 
            labelOperation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelOperation.AutoSize = true;
            labelOperation.BackColor = Color.Transparent;
            labelOperation.BorderStyle = BorderStyle.FixedSingle;
            labelOperation.FlatStyle = FlatStyle.Flat;
            labelOperation.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelOperation.ForeColor = Color.White;
            labelOperation.Location = new Point(227, 26);
            labelOperation.Name = "labelOperation";
            labelOperation.Padding = new Padding(5);
            labelOperation.Size = new Size(220, 38);
            labelOperation.TabIndex = 6;
            labelOperation.Text = "Operación actual:";
            // 
            // labelLastName
            // 
            labelLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelLastName.ForeColor = Color.White;
            labelLastName.Location = new Point(22, 283);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(94, 23);
            labelLastName.TabIndex = 4;
            labelLastName.Text = "Apellido:";
            // 
            // textBoxCodigoSocio
            // 
            textBoxCodigoSocio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCodigoSocio.BackColor = Color.DimGray;
            textBoxCodigoSocio.BorderStyle = BorderStyle.FixedSingle;
            textBoxCodigoSocio.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCodigoSocio.ForeColor = Color.White;
            textBoxCodigoSocio.Location = new Point(22, 111);
            textBoxCodigoSocio.Name = "textBoxCodigoSocio";
            textBoxCodigoSocio.ReadOnly = true;
            textBoxCodigoSocio.Size = new Size(238, 27);
            textBoxCodigoSocio.TabIndex = 11;
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelName.AutoSize = true;
            labelName.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(22, 217);
            labelName.Name = "labelName";
            labelName.Size = new Size(90, 23);
            labelName.TabIndex = 2;
            labelName.Text = "Nombre:";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLastName.BackColor = Color.DimGray;
            textBoxLastName.BorderStyle = BorderStyle.FixedSingle;
            textBoxLastName.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxLastName.ForeColor = Color.White;
            textBoxLastName.Location = new Point(22, 309);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(238, 27);
            textBoxLastName.TabIndex = 2;
            // 
            // labelDNI
            // 
            labelDNI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelDNI.AutoSize = true;
            labelDNI.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelDNI.ForeColor = Color.White;
            labelDNI.Location = new Point(22, 152);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(47, 23);
            labelDNI.TabIndex = 0;
            labelDNI.Text = "DNI:";
            // 
            // textBoxDNI
            // 
            textBoxDNI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDNI.BackColor = Color.DimGray;
            textBoxDNI.BorderStyle = BorderStyle.FixedSingle;
            textBoxDNI.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxDNI.ForeColor = Color.White;
            textBoxDNI.Location = new Point(22, 179);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(238, 27);
            textBoxDNI.TabIndex = 0;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClose.BackColor = Color.IndianRed;
            buttonClose.FlatAppearance.BorderColor = Color.Firebrick;
            buttonClose.FlatAppearance.BorderSize = 2;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClose.ForeColor = Color.Firebrick;
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.Location = new Point(774, 5);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(76, 39);
            buttonClose.TabIndex = 5;
            buttonClose.UseVisualStyleBackColor = false;
            // 
            // SocioView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
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
            tabPageAddOrEditOrDeleteSocio.PerformLayout();
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
        private Button buttonSearchSocio;
        private TextBox textBoxSearchSocio;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonClose;
        private Button buttonEdit;
        private Button buttonCancel;
        private Button buttonSave;
        private Label labelCodigoSocio;
        private TextBox textBoxCodigoSocio;
    }
}
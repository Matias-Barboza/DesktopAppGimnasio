namespace DesktopAppGimnasio.Views
{
    partial class CuotaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuotaView));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            tabControl = new TabControl();
            tabPageDebtorsVisualizer = new TabPage();
            buttonSearchDebt = new Button();
            textBoxSearchDebt = new TextBox();
            dataGridViewCuotasVencidas = new DataGridView();
            tabPageCuotasVisualizer = new TabPage();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonSearchCuota = new Button();
            textBoxSearchCuota = new TextBox();
            dataGridViewCuotas = new DataGridView();
            tabPageAddOrEditOrDeleteCuota = new TabPage();
            labelPesos = new Label();
            labelCodigoCuota = new Label();
            textBoxCodigoCuota = new TextBox();
            labelTipoCuota = new Label();
            comboBoxMes = new ComboBox();
            comboBoxTipoCuota = new ComboBox();
            labelMes = new Label();
            labelFechaPago = new Label();
            monthCalendarFechaPago = new MonthCalendar();
            labelCodigoSocio = new Label();
            textBoxCodigoSocio = new TextBox();
            buttonCancel = new Button();
            buttonSave = new Button();
            buttonAdd = new Button();
            labelOperation = new Label();
            labelMonto = new Label();
            textBoxMonto = new TextBox();
            buttonClose = new Button();
            tabControl.SuspendLayout();
            tabPageDebtorsVisualizer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCuotasVencidas).BeginInit();
            tabPageCuotasVisualizer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCuotas).BeginInit();
            tabPageAddOrEditOrDeleteCuota.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageDebtorsVisualizer);
            tabControl.Controls.Add(tabPageCuotasVisualizer);
            tabControl.Controls.Add(tabPageAddOrEditOrDeleteCuota);
            tabControl.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl.Location = new Point(0, 12);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Point(10, 8);
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(855, 548);
            tabControl.TabIndex = 0;
            // 
            // tabPageDebtorsVisualizer
            // 
            tabPageDebtorsVisualizer.BackColor = Color.FromArgb(99, 111, 113);
            tabPageDebtorsVisualizer.Controls.Add(buttonSearchDebt);
            tabPageDebtorsVisualizer.Controls.Add(textBoxSearchDebt);
            tabPageDebtorsVisualizer.Controls.Add(dataGridViewCuotasVencidas);
            tabPageDebtorsVisualizer.Location = new Point(4, 37);
            tabPageDebtorsVisualizer.Name = "tabPageDebtorsVisualizer";
            tabPageDebtorsVisualizer.Padding = new Padding(3);
            tabPageDebtorsVisualizer.Size = new Size(847, 507);
            tabPageDebtorsVisualizer.TabIndex = 2;
            tabPageDebtorsVisualizer.Text = "Administración de deudas";
            // 
            // buttonSearchDebt
            // 
            buttonSearchDebt.BackColor = Color.FromArgb(128, 128, 255);
            buttonSearchDebt.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonSearchDebt.FlatAppearance.BorderSize = 2;
            buttonSearchDebt.FlatStyle = FlatStyle.Flat;
            buttonSearchDebt.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearchDebt.ForeColor = Color.White;
            buttonSearchDebt.Image = (Image)resources.GetObject("buttonSearchDebt.Image");
            buttonSearchDebt.ImageAlign = ContentAlignment.MiddleRight;
            buttonSearchDebt.Location = new Point(409, 20);
            buttonSearchDebt.Name = "buttonSearchDebt";
            buttonSearchDebt.Size = new Size(100, 32);
            buttonSearchDebt.TabIndex = 11;
            buttonSearchDebt.Text = "Buscar";
            buttonSearchDebt.TextAlign = ContentAlignment.MiddleLeft;
            buttonSearchDebt.UseVisualStyleBackColor = false;
            // 
            // textBoxSearchDebt
            // 
            textBoxSearchDebt.BackColor = Color.FromArgb(168, 178, 179);
            textBoxSearchDebt.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearchDebt.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxSearchDebt.ForeColor = Color.Black;
            textBoxSearchDebt.HideSelection = false;
            textBoxSearchDebt.Location = new Point(6, 21);
            textBoxSearchDebt.Name = "textBoxSearchDebt";
            textBoxSearchDebt.Size = new Size(397, 29);
            textBoxSearchDebt.TabIndex = 10;
            // 
            // dataGridViewCuotasVencidas
            // 
            dataGridViewCuotasVencidas.AllowUserToAddRows = false;
            dataGridViewCuotasVencidas.AllowUserToDeleteRows = false;
            dataGridViewCuotasVencidas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCuotasVencidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCuotasVencidas.BackgroundColor = Color.FromArgb(99, 111, 113);
            dataGridViewCuotasVencidas.BorderStyle = BorderStyle.None;
            dataGridViewCuotasVencidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCuotasVencidas.GridColor = Color.FromArgb(108, 103, 134);
            dataGridViewCuotasVencidas.Location = new Point(6, 62);
            dataGridViewCuotasVencidas.MultiSelect = false;
            dataGridViewCuotasVencidas.Name = "dataGridViewCuotasVencidas";
            dataGridViewCuotasVencidas.ReadOnly = true;
            dataGridViewCuotasVencidas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Yellow;
            dataGridViewCellStyle5.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(108, 103, 134);
            dataGridViewCellStyle5.SelectionForeColor = Color.Yellow;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewCuotasVencidas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCuotasVencidas.RowTemplate.Height = 30;
            dataGridViewCuotasVencidas.Size = new Size(835, 400);
            dataGridViewCuotasVencidas.TabIndex = 1;
            // 
            // tabPageCuotasVisualizer
            // 
            tabPageCuotasVisualizer.BackColor = Color.FromArgb(113, 127, 129);
            tabPageCuotasVisualizer.Controls.Add(buttonEdit);
            tabPageCuotasVisualizer.Controls.Add(buttonDelete);
            tabPageCuotasVisualizer.Controls.Add(buttonSearchCuota);
            tabPageCuotasVisualizer.Controls.Add(textBoxSearchCuota);
            tabPageCuotasVisualizer.Controls.Add(dataGridViewCuotas);
            tabPageCuotasVisualizer.ForeColor = Color.Black;
            tabPageCuotasVisualizer.Location = new Point(4, 37);
            tabPageCuotasVisualizer.Name = "tabPageCuotasVisualizer";
            tabPageCuotasVisualizer.Padding = new Padding(3);
            tabPageCuotasVisualizer.Size = new Size(847, 507);
            tabPageCuotasVisualizer.TabIndex = 0;
            tabPageCuotasVisualizer.Text = "Administración de cuotas";
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
            buttonEdit.Location = new Point(583, 14);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(125, 39);
            buttonEdit.TabIndex = 10;
            buttonEdit.Text = "  Editar";
            buttonEdit.UseVisualStyleBackColor = false;
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
            buttonDelete.Location = new Point(714, 14);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(125, 39);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "   Eliminar";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonSearchCuota
            // 
            buttonSearchCuota.BackColor = Color.FromArgb(128, 128, 255);
            buttonSearchCuota.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonSearchCuota.FlatAppearance.BorderSize = 2;
            buttonSearchCuota.FlatStyle = FlatStyle.Flat;
            buttonSearchCuota.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearchCuota.ForeColor = Color.White;
            buttonSearchCuota.Image = (Image)resources.GetObject("buttonSearchCuota.Image");
            buttonSearchCuota.ImageAlign = ContentAlignment.MiddleRight;
            buttonSearchCuota.Location = new Point(409, 20);
            buttonSearchCuota.Name = "buttonSearchCuota";
            buttonSearchCuota.Size = new Size(100, 32);
            buttonSearchCuota.TabIndex = 9;
            buttonSearchCuota.Text = "Buscar";
            buttonSearchCuota.TextAlign = ContentAlignment.MiddleLeft;
            buttonSearchCuota.UseVisualStyleBackColor = false;
            // 
            // textBoxSearchCuota
            // 
            textBoxSearchCuota.BackColor = Color.FromArgb(168, 178, 179);
            textBoxSearchCuota.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearchCuota.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxSearchCuota.ForeColor = Color.Black;
            textBoxSearchCuota.Location = new Point(6, 21);
            textBoxSearchCuota.Name = "textBoxSearchCuota";
            textBoxSearchCuota.Size = new Size(397, 29);
            textBoxSearchCuota.TabIndex = 8;
            // 
            // dataGridViewCuotas
            // 
            dataGridViewCuotas.AllowUserToAddRows = false;
            dataGridViewCuotas.AllowUserToDeleteRows = false;
            dataGridViewCuotas.AllowUserToResizeColumns = false;
            dataGridViewCuotas.AllowUserToResizeRows = false;
            dataGridViewCuotas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCuotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCuotas.BackgroundColor = Color.FromArgb(113, 127, 129);
            dataGridViewCuotas.BorderStyle = BorderStyle.None;
            dataGridViewCuotas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.Gold;
            dataGridViewCellStyle6.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new Padding(5, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.Gold;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewCuotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCuotas.ColumnHeadersHeight = 50;
            dataGridViewCuotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCuotas.EnableHeadersVisualStyles = false;
            dataGridViewCuotas.GridColor = Color.Goldenrod;
            dataGridViewCuotas.Location = new Point(6, 62);
            dataGridViewCuotas.MultiSelect = false;
            dataGridViewCuotas.Name = "dataGridViewCuotas";
            dataGridViewCuotas.ReadOnly = true;
            dataGridViewCuotas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(99, 111, 113);
            dataGridViewCellStyle7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Yellow;
            dataGridViewCellStyle7.SelectionBackColor = Color.Yellow;
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(99, 111, 113);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewCuotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCuotas.RowHeadersVisible = false;
            dataGridViewCuotas.RowHeadersWidth = 20;
            dataGridViewCuotas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(113, 127, 129);
            dataGridViewCellStyle8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.Yellow;
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = Color.Yellow;
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(113, 127, 129);
            dataGridViewCuotas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCuotas.RowTemplate.Height = 30;
            dataGridViewCuotas.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridViewCuotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCuotas.Size = new Size(835, 438);
            dataGridViewCuotas.TabIndex = 0;
            // 
            // tabPageAddOrEditOrDeleteCuota
            // 
            tabPageAddOrEditOrDeleteCuota.BackColor = Color.FromArgb(136, 150, 151);
            tabPageAddOrEditOrDeleteCuota.Controls.Add(labelPesos);
            tabPageAddOrEditOrDeleteCuota.Controls.Add(labelCodigoCuota);
            tabPageAddOrEditOrDeleteCuota.Controls.Add(textBoxCodigoCuota);
            tabPageAddOrEditOrDeleteCuota.Controls.Add(labelTipoCuota);
            tabPageAddOrEditOrDeleteCuota.Controls.Add(comboBoxMes);
            tabPageAddOrEditOrDeleteCuota.Controls.Add(comboBoxTipoCuota);
            tabPageAddOrEditOrDeleteCuota.Controls.Add(labelMes);
            tabPageAddOrEditOrDeleteCuota.Controls.Add(labelFechaPago);
            tabPageAddOrEditOrDeleteCuota.Controls.Add(monthCalendarFechaPago);
            tabPageAddOrEditOrDeleteCuota.Controls.Add(labelCodigoSocio);
            tabPageAddOrEditOrDeleteCuota.Controls.Add(textBoxCodigoSocio);
            tabPageAddOrEditOrDeleteCuota.Controls.Add(buttonCancel);
            tabPageAddOrEditOrDeleteCuota.Controls.Add(buttonSave);
            tabPageAddOrEditOrDeleteCuota.Controls.Add(buttonAdd);
            tabPageAddOrEditOrDeleteCuota.Controls.Add(labelOperation);
            tabPageAddOrEditOrDeleteCuota.Controls.Add(labelMonto);
            tabPageAddOrEditOrDeleteCuota.Controls.Add(textBoxMonto);
            tabPageAddOrEditOrDeleteCuota.Location = new Point(4, 37);
            tabPageAddOrEditOrDeleteCuota.Name = "tabPageAddOrEditOrDeleteCuota";
            tabPageAddOrEditOrDeleteCuota.Padding = new Padding(3);
            tabPageAddOrEditOrDeleteCuota.Size = new Size(847, 507);
            tabPageAddOrEditOrDeleteCuota.TabIndex = 1;
            tabPageAddOrEditOrDeleteCuota.Text = "Registrar/Editar/Eliminar cuota";
            // 
            // labelPesos
            // 
            labelPesos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelPesos.AutoSize = true;
            labelPesos.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelPesos.ForeColor = Color.White;
            labelPesos.Location = new Point(242, 242);
            labelPesos.Name = "labelPesos";
            labelPesos.Size = new Size(21, 23);
            labelPesos.TabIndex = 33;
            labelPesos.Text = "$";
            // 
            // labelCodigoCuota
            // 
            labelCodigoCuota.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelCodigoCuota.AutoSize = true;
            labelCodigoCuota.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelCodigoCuota.ForeColor = Color.White;
            labelCodigoCuota.Location = new Point(22, 84);
            labelCodigoCuota.Name = "labelCodigoCuota";
            labelCodigoCuota.Size = new Size(144, 23);
            labelCodigoCuota.TabIndex = 32;
            labelCodigoCuota.Text = "Código cuota:";
            // 
            // textBoxCodigoCuota
            // 
            textBoxCodigoCuota.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCodigoCuota.BackColor = Color.DimGray;
            textBoxCodigoCuota.BorderStyle = BorderStyle.FixedSingle;
            textBoxCodigoCuota.Enabled = false;
            textBoxCodigoCuota.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCodigoCuota.ForeColor = Color.White;
            textBoxCodigoCuota.Location = new Point(22, 111);
            textBoxCodigoCuota.Name = "textBoxCodigoCuota";
            textBoxCodigoCuota.Size = new Size(238, 27);
            textBoxCodigoCuota.TabIndex = 31;
            // 
            // labelTipoCuota
            // 
            labelTipoCuota.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTipoCuota.AutoSize = true;
            labelTipoCuota.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipoCuota.ForeColor = Color.White;
            labelTipoCuota.Location = new Point(581, 152);
            labelTipoCuota.Name = "labelTipoCuota";
            labelTipoCuota.Size = new Size(142, 23);
            labelTipoCuota.TabIndex = 30;
            labelTipoCuota.Text = "Tipo de cuota:";
            // 
            // comboBoxMes
            // 
            comboBoxMes.BackColor = Color.DimGray;
            comboBoxMes.FlatStyle = FlatStyle.Flat;
            comboBoxMes.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxMes.ForeColor = Color.White;
            comboBoxMes.FormattingEnabled = true;
            comboBoxMes.Items.AddRange(new object[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
            comboBoxMes.Location = new Point(581, 111);
            comboBoxMes.Name = "comboBoxMes";
            comboBoxMes.Size = new Size(238, 27);
            comboBoxMes.TabIndex = 2;
            // 
            // comboBoxTipoCuota
            // 
            comboBoxTipoCuota.BackColor = Color.DimGray;
            comboBoxTipoCuota.FlatStyle = FlatStyle.Flat;
            comboBoxTipoCuota.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxTipoCuota.ForeColor = Color.White;
            comboBoxTipoCuota.FormattingEnabled = true;
            comboBoxTipoCuota.Items.AddRange(new object[] { "Mensual", "Semanal", "Diaria" });
            comboBoxTipoCuota.Location = new Point(581, 179);
            comboBoxTipoCuota.Name = "comboBoxTipoCuota";
            comboBoxTipoCuota.Size = new Size(238, 27);
            comboBoxTipoCuota.TabIndex = 4;
            // 
            // labelMes
            // 
            labelMes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelMes.AutoSize = true;
            labelMes.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelMes.ForeColor = Color.White;
            labelMes.Location = new Point(581, 84);
            labelMes.Name = "labelMes";
            labelMes.Size = new Size(160, 23);
            labelMes.TabIndex = 26;
            labelMes.Text = "Mes que abona:";
            // 
            // labelFechaPago
            // 
            labelFechaPago.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelFechaPago.AutoSize = true;
            labelFechaPago.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelFechaPago.ForeColor = Color.White;
            labelFechaPago.Location = new Point(296, 84);
            labelFechaPago.Name = "labelFechaPago";
            labelFechaPago.Size = new Size(158, 23);
            labelFechaPago.TabIndex = 25;
            labelFechaPago.Text = "Fecha de pago:";
            // 
            // monthCalendarFechaPago
            // 
            monthCalendarFechaPago.BackColor = Color.FromArgb(168, 178, 179);
            monthCalendarFechaPago.ForeColor = Color.Black;
            monthCalendarFechaPago.Location = new Point(296, 111);
            monthCalendarFechaPago.MaxSelectionCount = 1;
            monthCalendarFechaPago.Name = "monthCalendarFechaPago";
            monthCalendarFechaPago.TabIndex = 3;
            // 
            // labelCodigoSocio
            // 
            labelCodigoSocio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelCodigoSocio.AutoSize = true;
            labelCodigoSocio.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelCodigoSocio.ForeColor = Color.White;
            labelCodigoSocio.Location = new Point(22, 152);
            labelCodigoSocio.Name = "labelCodigoSocio";
            labelCodigoSocio.Size = new Size(172, 23);
            labelCodigoSocio.TabIndex = 22;
            labelCodigoSocio.Text = "Número de socio:";
            // 
            // textBoxCodigoSocio
            // 
            textBoxCodigoSocio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCodigoSocio.BackColor = Color.DimGray;
            textBoxCodigoSocio.BorderStyle = BorderStyle.FixedSingle;
            textBoxCodigoSocio.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCodigoSocio.ForeColor = Color.White;
            textBoxCodigoSocio.Location = new Point(22, 179);
            textBoxCodigoSocio.Name = "textBoxCodigoSocio";
            textBoxCodigoSocio.Size = new Size(238, 27);
            textBoxCodigoSocio.TabIndex = 0;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Guardar";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Añadir";
            buttonAdd.UseVisualStyleBackColor = false;
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
            labelOperation.TabIndex = 19;
            labelOperation.Text = "Operación actual:";
            // 
            // labelMonto
            // 
            labelMonto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelMonto.AutoSize = true;
            labelMonto.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelMonto.ForeColor = Color.White;
            labelMonto.Location = new Point(22, 217);
            labelMonto.Name = "labelMonto";
            labelMonto.Size = new Size(164, 23);
            labelMonto.TabIndex = 12;
            labelMonto.Text = "Monto a abonar:";
            // 
            // textBoxMonto
            // 
            textBoxMonto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxMonto.BackColor = Color.DimGray;
            textBoxMonto.BorderStyle = BorderStyle.FixedSingle;
            textBoxMonto.Enabled = false;
            textBoxMonto.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxMonto.ForeColor = Color.White;
            textBoxMonto.Location = new Point(22, 241);
            textBoxMonto.Name = "textBoxMonto";
            textBoxMonto.Size = new Size(212, 27);
            textBoxMonto.TabIndex = 1;
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
            buttonClose.TabIndex = 6;
            buttonClose.UseVisualStyleBackColor = false;
            // 
            // CuotaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(855, 560);
            Controls.Add(buttonClose);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CuotaView";
            Text = "CuotaView";
            tabControl.ResumeLayout(false);
            tabPageDebtorsVisualizer.ResumeLayout(false);
            tabPageDebtorsVisualizer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCuotasVencidas).EndInit();
            tabPageCuotasVisualizer.ResumeLayout(false);
            tabPageCuotasVisualizer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCuotas).EndInit();
            tabPageAddOrEditOrDeleteCuota.ResumeLayout(false);
            tabPageAddOrEditOrDeleteCuota.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageCuotasVisualizer;
        private TabPage tabPageAddOrEditOrDeleteCuota;
        private DataGridView dataGridViewCuotas;
        private Button buttonEdit;
        private Button buttonSearchCuota;
        private Button buttonDelete;
        private TextBox textBoxSearchCuota;
        private Label labelCodigoSocio;
        private TextBox textBoxCodigoSocio;
        private Button buttonCancel;
        private Button buttonSave;
        private Button buttonAdd;
        private Label labelOperation;
        private Label labelMonto;
        private TextBox textBoxMonto;
        private MonthCalendar monthCalendarFechaPago;
        private Label labelFechaPago;
        private ComboBox comboBoxTipoCuota;
        private Label labelMes;
        private ComboBox comboBoxMes;
        private Label labelTipoCuota;
        private Button buttonClose;
        private TabPage tabPageDebtorsVisualizer;
        private DataGridView dataGridViewCuotasVencidas;
        private Label labelCodigoCuota;
        private TextBox textBoxCodigoCuota;
        private Button buttonSearchDebt;
        private TextBox textBoxSearchDebt;
        private Label labelPesos;
    }
}
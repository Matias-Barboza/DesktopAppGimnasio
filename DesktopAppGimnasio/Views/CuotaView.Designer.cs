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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            comboBoxCantidad = new ComboBox();
            labelCantidad = new Label();
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
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dataGridViewCuotasVencidas.ColumnHeadersHeight = 20;
            dataGridViewCuotasVencidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCuotasVencidas.GridColor = Color.FromArgb(108, 103, 134);
            dataGridViewCuotasVencidas.Location = new Point(6, 62);
            dataGridViewCuotasVencidas.MultiSelect = false;
            dataGridViewCuotasVencidas.Name = "dataGridViewCuotasVencidas";
            dataGridViewCuotasVencidas.ReadOnly = true;
            dataGridViewCuotasVencidas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Yellow;
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(108, 103, 134);
            dataGridViewCellStyle1.SelectionForeColor = Color.Yellow;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewCuotasVencidas.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCuotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCuotas.BackgroundColor = Color.FromArgb(113, 127, 129);
            dataGridViewCuotas.BorderStyle = BorderStyle.None;
            dataGridViewCuotas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Gold;
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewCuotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCuotas.ColumnHeadersHeight = 30;
            dataGridViewCuotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCuotas.EnableHeadersVisualStyles = false;
            dataGridViewCuotas.GridColor = Color.Goldenrod;
            dataGridViewCuotas.Location = new Point(6, 62);
            dataGridViewCuotas.MultiSelect = false;
            dataGridViewCuotas.Name = "dataGridViewCuotas";
            dataGridViewCuotas.ReadOnly = true;
            dataGridViewCuotas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(99, 111, 113);
            dataGridViewCellStyle3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(99, 111, 113);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewCuotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCuotas.RowHeadersVisible = false;
            dataGridViewCuotas.RowHeadersWidth = 20;
            dataGridViewCuotas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(113, 127, 129);
            dataGridViewCellStyle4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Yellow;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(113, 127, 129);
            dataGridViewCuotas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCuotas.RowTemplate.Height = 30;
            dataGridViewCuotas.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridViewCuotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCuotas.Size = new Size(835, 438);
            dataGridViewCuotas.TabIndex = 0;
            // 
            // tabPageAddOrEditOrDeleteCuota
            // 
            tabPageAddOrEditOrDeleteCuota.BackColor = Color.FromArgb(136, 150, 151);
            tabPageAddOrEditOrDeleteCuota.Controls.Add(comboBoxCantidad);
            tabPageAddOrEditOrDeleteCuota.Controls.Add(labelCantidad);
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
            // comboBoxCantidad
            // 
            comboBoxCantidad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxCantidad.BackColor = Color.DimGray;
            comboBoxCantidad.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCantidad.FlatStyle = FlatStyle.Flat;
            comboBoxCantidad.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxCantidad.ForeColor = Color.White;
            comboBoxCantidad.FormattingEnabled = true;
            comboBoxCantidad.Location = new Point(581, 179);
            comboBoxCantidad.Name = "comboBoxCantidad";
            comboBoxCantidad.Size = new Size(238, 27);
            comboBoxCantidad.TabIndex = 34;
            // 
            // labelCantidad
            // 
            labelCantidad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCantidad.AutoSize = true;
            labelCantidad.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelCantidad.ForeColor = Color.White;
            labelCantidad.Location = new Point(581, 152);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(139, 23);
            labelCantidad.TabIndex = 35;
            labelCantidad.Text = "Cantidad de :";
            // 
            // labelPesos
            // 
            labelPesos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelPesos.AutoSize = true;
            labelPesos.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelPesos.ForeColor = Color.White;
            labelPesos.Location = new Point(801, 245);
            labelPesos.Name = "labelPesos";
            labelPesos.Size = new Size(21, 23);
            labelPesos.TabIndex = 33;
            labelPesos.Text = "$";
            // 
            // labelCodigoCuota
            // 
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
            labelTipoCuota.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTipoCuota.AutoSize = true;
            labelTipoCuota.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipoCuota.ForeColor = Color.White;
            labelTipoCuota.Location = new Point(581, 84);
            labelTipoCuota.Name = "labelTipoCuota";
            labelTipoCuota.Size = new Size(142, 23);
            labelTipoCuota.TabIndex = 30;
            labelTipoCuota.Text = "Tipo de cuota:";
            // 
            // comboBoxMes
            // 
            comboBoxMes.BackColor = Color.DimGray;
            comboBoxMes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMes.FlatStyle = FlatStyle.Flat;
            comboBoxMes.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxMes.ForeColor = Color.White;
            comboBoxMes.FormattingEnabled = true;
            comboBoxMes.Items.AddRange(new object[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
            comboBoxMes.Location = new Point(22, 247);
            comboBoxMes.Name = "comboBoxMes";
            comboBoxMes.Size = new Size(238, 27);
            comboBoxMes.TabIndex = 2;
            // 
            // comboBoxTipoCuota
            // 
            comboBoxTipoCuota.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxTipoCuota.BackColor = Color.DimGray;
            comboBoxTipoCuota.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoCuota.FlatStyle = FlatStyle.Flat;
            comboBoxTipoCuota.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxTipoCuota.ForeColor = Color.White;
            comboBoxTipoCuota.FormattingEnabled = true;
            comboBoxTipoCuota.Items.AddRange(new object[] { "Mensual", "Semanal", "Diaria" });
            comboBoxTipoCuota.Location = new Point(581, 111);
            comboBoxTipoCuota.Name = "comboBoxTipoCuota";
            comboBoxTipoCuota.Size = new Size(238, 27);
            comboBoxTipoCuota.TabIndex = 4;
            // 
            // labelMes
            // 
            labelMes.AutoSize = true;
            labelMes.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelMes.ForeColor = Color.White;
            labelMes.Location = new Point(22, 220);
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
            monthCalendarFechaPago.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            monthCalendarFechaPago.BackColor = Color.FromArgb(168, 178, 179);
            monthCalendarFechaPago.ForeColor = Color.Black;
            monthCalendarFechaPago.Location = new Point(296, 111);
            monthCalendarFechaPago.MaxSelectionCount = 1;
            monthCalendarFechaPago.Name = "monthCalendarFechaPago";
            monthCalendarFechaPago.TabIndex = 3;
            // 
            // labelCodigoSocio
            // 
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
            buttonCancel.TabIndex = 7;
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
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Guardar";
            buttonSave.UseVisualStyleBackColor = false;
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
            labelMonto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelMonto.AutoSize = true;
            labelMonto.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelMonto.ForeColor = Color.White;
            labelMonto.Location = new Point(581, 220);
            labelMonto.Name = "labelMonto";
            labelMonto.Size = new Size(164, 23);
            labelMonto.TabIndex = 12;
            labelMonto.Text = "Monto a abonar:";
            // 
            // textBoxMonto
            // 
            textBoxMonto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxMonto.BackColor = Color.DimGray;
            textBoxMonto.BorderStyle = BorderStyle.FixedSingle;
            textBoxMonto.Enabled = false;
            textBoxMonto.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxMonto.ForeColor = Color.White;
            textBoxMonto.Location = new Point(581, 244);
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
        private ComboBox comboBoxCantidad;
        private Label labelCantidad;
    }
}
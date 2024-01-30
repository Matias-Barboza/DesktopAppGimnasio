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
            tabControl = new TabControl();
            tabPageDebtorsVisualizer = new TabPage();
            buttonSearchDebt = new Button();
            textBoxSearchDebt = new TextBox();
            dataGridView1 = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tabControl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl.Location = new Point(0, 50);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(855, 510);
            tabControl.TabIndex = 0;
            // 
            // tabPageDebtorsVisualizer
            // 
            tabPageDebtorsVisualizer.Controls.Add(buttonSearchDebt);
            tabPageDebtorsVisualizer.Controls.Add(textBoxSearchDebt);
            tabPageDebtorsVisualizer.Controls.Add(dataGridView1);
            tabPageDebtorsVisualizer.Location = new Point(4, 30);
            tabPageDebtorsVisualizer.Name = "tabPageDebtorsVisualizer";
            tabPageDebtorsVisualizer.Padding = new Padding(3);
            tabPageDebtorsVisualizer.Size = new Size(847, 476);
            tabPageDebtorsVisualizer.TabIndex = 2;
            tabPageDebtorsVisualizer.Text = "Administración de deudas";
            tabPageDebtorsVisualizer.UseVisualStyleBackColor = true;
            // 
            // buttonSearchDebt
            // 
            buttonSearchDebt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearchDebt.Location = new Point(409, 20);
            buttonSearchDebt.Name = "buttonSearchDebt";
            buttonSearchDebt.Size = new Size(100, 30);
            buttonSearchDebt.TabIndex = 11;
            buttonSearchDebt.Text = "Buscar socio";
            buttonSearchDebt.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchDebt
            // 
            textBoxSearchDebt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchDebt.Location = new Point(6, 20);
            textBoxSearchDebt.Name = "textBoxSearchDebt";
            textBoxSearchDebt.Size = new Size(397, 31);
            textBoxSearchDebt.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 62);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(835, 407);
            dataGridView1.TabIndex = 1;
            // 
            // tabPageCuotasVisualizer
            // 
            tabPageCuotasVisualizer.Controls.Add(buttonEdit);
            tabPageCuotasVisualizer.Controls.Add(buttonDelete);
            tabPageCuotasVisualizer.Controls.Add(buttonSearchCuota);
            tabPageCuotasVisualizer.Controls.Add(textBoxSearchCuota);
            tabPageCuotasVisualizer.Controls.Add(dataGridViewCuotas);
            tabPageCuotasVisualizer.Location = new Point(4, 30);
            tabPageCuotasVisualizer.Name = "tabPageCuotasVisualizer";
            tabPageCuotasVisualizer.Padding = new Padding(3);
            tabPageCuotasVisualizer.Size = new Size(847, 476);
            tabPageCuotasVisualizer.TabIndex = 0;
            tabPageCuotasVisualizer.Text = "Administración de cuotas";
            tabPageCuotasVisualizer.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEdit.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(583, 12);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(125, 39);
            buttonEdit.TabIndex = 10;
            buttonEdit.Text = "Editar";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDelete.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(714, 12);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(125, 39);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "Eliminar";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonSearchCuota
            // 
            buttonSearchCuota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearchCuota.Location = new Point(409, 20);
            buttonSearchCuota.Name = "buttonSearchCuota";
            buttonSearchCuota.Size = new Size(100, 30);
            buttonSearchCuota.TabIndex = 9;
            buttonSearchCuota.Text = "Buscar socio";
            buttonSearchCuota.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchCuota
            // 
            textBoxSearchCuota.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchCuota.Location = new Point(6, 20);
            textBoxSearchCuota.Name = "textBoxSearchCuota";
            textBoxSearchCuota.Size = new Size(397, 31);
            textBoxSearchCuota.TabIndex = 8;
            // 
            // dataGridViewCuotas
            // 
            dataGridViewCuotas.AllowUserToAddRows = false;
            dataGridViewCuotas.AllowUserToDeleteRows = false;
            dataGridViewCuotas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCuotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCuotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCuotas.Location = new Point(6, 62);
            dataGridViewCuotas.MultiSelect = false;
            dataGridViewCuotas.Name = "dataGridViewCuotas";
            dataGridViewCuotas.ReadOnly = true;
            dataGridViewCuotas.RowTemplate.Height = 25;
            dataGridViewCuotas.Size = new Size(835, 407);
            dataGridViewCuotas.TabIndex = 0;
            // 
            // tabPageAddOrEditOrDeleteCuota
            // 
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
            tabPageAddOrEditOrDeleteCuota.Location = new Point(4, 30);
            tabPageAddOrEditOrDeleteCuota.Name = "tabPageAddOrEditOrDeleteCuota";
            tabPageAddOrEditOrDeleteCuota.Padding = new Padding(3);
            tabPageAddOrEditOrDeleteCuota.Size = new Size(847, 476);
            tabPageAddOrEditOrDeleteCuota.TabIndex = 1;
            tabPageAddOrEditOrDeleteCuota.Text = "Registrar/Editar/Eliminar cuota";
            tabPageAddOrEditOrDeleteCuota.UseVisualStyleBackColor = true;
            // 
            // labelPesos
            // 
            labelPesos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelPesos.AutoSize = true;
            labelPesos.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelPesos.Location = new Point(176, 250);
            labelPesos.Name = "labelPesos";
            labelPesos.Size = new Size(22, 25);
            labelPesos.TabIndex = 33;
            labelPesos.Text = "$";
            // 
            // labelCodigoCuota
            // 
            labelCodigoCuota.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelCodigoCuota.AutoSize = true;
            labelCodigoCuota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCodigoCuota.Location = new Point(14, 86);
            labelCodigoCuota.Name = "labelCodigoCuota";
            labelCodigoCuota.Size = new Size(105, 21);
            labelCodigoCuota.TabIndex = 32;
            labelCodigoCuota.Text = "Código cuota:";
            // 
            // textBoxCodigoCuota
            // 
            textBoxCodigoCuota.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCodigoCuota.Enabled = false;
            textBoxCodigoCuota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCodigoCuota.Location = new Point(14, 112);
            textBoxCodigoCuota.Name = "textBoxCodigoCuota";
            textBoxCodigoCuota.Size = new Size(238, 29);
            textBoxCodigoCuota.TabIndex = 31;
            // 
            // labelTipoCuota
            // 
            labelTipoCuota.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTipoCuota.AutoSize = true;
            labelTipoCuota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTipoCuota.Location = new Point(581, 154);
            labelTipoCuota.Name = "labelTipoCuota";
            labelTipoCuota.Size = new Size(106, 21);
            labelTipoCuota.TabIndex = 30;
            labelTipoCuota.Text = "Tipo de cuota:";
            // 
            // comboBoxMes
            // 
            comboBoxMes.FormattingEnabled = true;
            comboBoxMes.Items.AddRange(new object[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
            comboBoxMes.Location = new Point(581, 112);
            comboBoxMes.Name = "comboBoxMes";
            comboBoxMes.Size = new Size(238, 29);
            comboBoxMes.TabIndex = 2;
            // 
            // comboBoxTipoCuota
            // 
            comboBoxTipoCuota.FormattingEnabled = true;
            comboBoxTipoCuota.Items.AddRange(new object[] { "Mensual", "Semanal", "Diaria" });
            comboBoxTipoCuota.Location = new Point(581, 181);
            comboBoxTipoCuota.Name = "comboBoxTipoCuota";
            comboBoxTipoCuota.Size = new Size(238, 29);
            comboBoxTipoCuota.TabIndex = 4;
            // 
            // labelMes
            // 
            labelMes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelMes.AutoSize = true;
            labelMes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelMes.Location = new Point(581, 86);
            labelMes.Name = "labelMes";
            labelMes.Size = new Size(119, 21);
            labelMes.TabIndex = 26;
            labelMes.Text = "Mes que abona:";
            // 
            // labelFechaPago
            // 
            labelFechaPago.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelFechaPago.AutoSize = true;
            labelFechaPago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFechaPago.Location = new Point(296, 86);
            labelFechaPago.Name = "labelFechaPago";
            labelFechaPago.Size = new Size(113, 21);
            labelFechaPago.TabIndex = 25;
            labelFechaPago.Text = "Fecha de pago:";
            // 
            // monthCalendarFechaPago
            // 
            monthCalendarFechaPago.Location = new Point(296, 113);
            monthCalendarFechaPago.MaxSelectionCount = 1;
            monthCalendarFechaPago.Name = "monthCalendarFechaPago";
            monthCalendarFechaPago.TabIndex = 3;
            // 
            // labelCodigoSocio
            // 
            labelCodigoSocio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelCodigoSocio.AutoSize = true;
            labelCodigoSocio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCodigoSocio.Location = new Point(14, 154);
            labelCodigoSocio.Name = "labelCodigoSocio";
            labelCodigoSocio.Size = new Size(132, 21);
            labelCodigoSocio.TabIndex = 22;
            labelCodigoSocio.Text = "Número de socio:";
            // 
            // textBoxCodigoSocio
            // 
            textBoxCodigoSocio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCodigoSocio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCodigoSocio.Location = new Point(14, 181);
            textBoxCodigoSocio.Name = "textBoxCodigoSocio";
            textBoxCodigoSocio.Size = new Size(238, 29);
            textBoxCodigoSocio.TabIndex = 0;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonCancel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(443, 404);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(165, 34);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonSave.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(263, 404);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(165, 34);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Guardar";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAdd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(263, 357);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(345, 39);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Añadir";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // labelOperation
            // 
            labelOperation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelOperation.AutoSize = true;
            labelOperation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelOperation.Location = new Point(23, 22);
            labelOperation.Name = "labelOperation";
            labelOperation.Size = new Size(160, 25);
            labelOperation.TabIndex = 19;
            labelOperation.Text = "Operación actual:";
            // 
            // labelMonto
            // 
            labelMonto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelMonto.AutoSize = true;
            labelMonto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelMonto.Location = new Point(14, 222);
            labelMonto.Name = "labelMonto";
            labelMonto.Size = new Size(156, 21);
            labelMonto.TabIndex = 12;
            labelMonto.Text = "Monto (en números):";
            // 
            // textBoxMonto
            // 
            textBoxMonto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxMonto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMonto.Location = new Point(14, 248);
            textBoxMonto.Name = "textBoxMonto";
            textBoxMonto.Size = new Size(156, 29);
            textBoxMonto.TabIndex = 1;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClose.Location = new Point(770, 10);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(76, 39);
            buttonClose.TabIndex = 6;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = true;
            // 
            // CuotaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(855, 560);
            Controls.Add(buttonClose);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CuotaView";
            Text = "CuotaView";
            tabControl.ResumeLayout(false);
            tabPageDebtorsVisualizer.ResumeLayout(false);
            tabPageDebtorsVisualizer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Label labelCodigoCuota;
        private TextBox textBoxCodigoCuota;
        private Button buttonSearchDebt;
        private TextBox textBoxSearchDebt;
        private Label labelPesos;
    }
}
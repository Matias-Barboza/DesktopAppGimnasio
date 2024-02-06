namespace DesktopAppGimnasio.Views
{
    partial class TipoCuotaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoCuotaView));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            buttonClose = new Button();
            tabControl = new TabControl();
            tabPageTiposCuotasVisualizer = new TabPage();
            buttonEdit = new Button();
            dataGridViewTiposCuotas = new DataGridView();
            tabPageEditCuota = new TabPage();
            buttonSave = new Button();
            buttonCancel = new Button();
            labelIDTipoCuota = new Label();
            textBoxValorActual = new TextBox();
            labelOperation = new Label();
            textBoxIDTipoCuota = new TextBox();
            labelValorActual = new Label();
            labelDescripcion = new Label();
            textBoxDescripcion = new TextBox();
            tabControl.SuspendLayout();
            tabPageTiposCuotasVisualizer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTiposCuotas).BeginInit();
            tabPageEditCuota.SuspendLayout();
            SuspendLayout();
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
            buttonClose.TabIndex = 7;
            buttonClose.UseVisualStyleBackColor = false;
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPageTiposCuotasVisualizer);
            tabControl.Controls.Add(tabPageEditCuota);
            tabControl.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl.Location = new Point(0, 12);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Point(10, 8);
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(855, 548);
            tabControl.TabIndex = 8;
            // 
            // tabPageTiposCuotasVisualizer
            // 
            tabPageTiposCuotasVisualizer.BackColor = Color.FromArgb(99, 111, 113);
            tabPageTiposCuotasVisualizer.Controls.Add(buttonEdit);
            tabPageTiposCuotasVisualizer.Controls.Add(dataGridViewTiposCuotas);
            tabPageTiposCuotasVisualizer.Location = new Point(4, 37);
            tabPageTiposCuotasVisualizer.Name = "tabPageTiposCuotasVisualizer";
            tabPageTiposCuotasVisualizer.Size = new Size(847, 507);
            tabPageTiposCuotasVisualizer.TabIndex = 2;
            tabPageTiposCuotasVisualizer.Text = "Administración de valores de cuotas";
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
            buttonEdit.Location = new Point(714, 14);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(125, 39);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "  Editar";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTiposCuotas
            // 
            dataGridViewTiposCuotas.AllowUserToAddRows = false;
            dataGridViewTiposCuotas.AllowUserToDeleteRows = false;
            dataGridViewTiposCuotas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTiposCuotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTiposCuotas.BackgroundColor = Color.FromArgb(99, 111, 113);
            dataGridViewTiposCuotas.BorderStyle = BorderStyle.None;
            dataGridViewTiposCuotas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.Gold;
            dataGridViewCellStyle7.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.Gold;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewTiposCuotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewTiposCuotas.ColumnHeadersHeight = 50;
            dataGridViewTiposCuotas.EnableHeadersVisualStyles = false;
            dataGridViewTiposCuotas.GridColor = Color.Goldenrod;
            dataGridViewTiposCuotas.Location = new Point(6, 62);
            dataGridViewTiposCuotas.MultiSelect = false;
            dataGridViewTiposCuotas.Name = "dataGridViewTiposCuotas";
            dataGridViewTiposCuotas.ReadOnly = true;
            dataGridViewTiposCuotas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(99, 111, 113);
            dataGridViewCellStyle8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.Yellow;
            dataGridViewCellStyle8.SelectionBackColor = Color.Yellow;
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(99, 111, 113);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridViewTiposCuotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewTiposCuotas.RowHeadersVisible = false;
            dataGridViewTiposCuotas.RowHeadersWidth = 20;
            dataGridViewTiposCuotas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(99, 111, 113);
            dataGridViewCellStyle9.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.Yellow;
            dataGridViewCellStyle9.SelectionBackColor = Color.Yellow;
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(99, 111, 113);
            dataGridViewTiposCuotas.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewTiposCuotas.RowTemplate.Height = 30;
            dataGridViewTiposCuotas.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridViewTiposCuotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTiposCuotas.Size = new Size(835, 438);
            dataGridViewTiposCuotas.TabIndex = 6;
            // 
            // tabPageEditCuota
            // 
            tabPageEditCuota.BackColor = Color.FromArgb(136, 150, 151);
            tabPageEditCuota.Controls.Add(buttonSave);
            tabPageEditCuota.Controls.Add(buttonCancel);
            tabPageEditCuota.Controls.Add(labelIDTipoCuota);
            tabPageEditCuota.Controls.Add(textBoxValorActual);
            tabPageEditCuota.Controls.Add(labelOperation);
            tabPageEditCuota.Controls.Add(textBoxIDTipoCuota);
            tabPageEditCuota.Controls.Add(labelValorActual);
            tabPageEditCuota.Controls.Add(labelDescripcion);
            tabPageEditCuota.Controls.Add(textBoxDescripcion);
            tabPageEditCuota.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPageEditCuota.Location = new Point(4, 37);
            tabPageEditCuota.Name = "tabPageEditCuota";
            tabPageEditCuota.Padding = new Padding(3);
            tabPageEditCuota.Size = new Size(847, 507);
            tabPageEditCuota.TabIndex = 1;
            tabPageEditCuota.Text = "Editar valores de cuotas";
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
            buttonSave.Location = new Point(303, 358);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(240, 38);
            buttonSave.TabIndex = 21;
            buttonSave.Text = "Guardar";
            buttonSave.UseVisualStyleBackColor = false;
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
            buttonCancel.Location = new Point(303, 402);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(240, 38);
            buttonCancel.TabIndex = 17;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // labelIDTipoCuota
            // 
            labelIDTipoCuota.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelIDTipoCuota.AutoSize = true;
            labelIDTipoCuota.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelIDTipoCuota.ForeColor = Color.White;
            labelIDTipoCuota.Location = new Point(22, 84);
            labelIDTipoCuota.Name = "labelIDTipoCuota";
            labelIDTipoCuota.Size = new Size(163, 23);
            labelIDTipoCuota.TabIndex = 19;
            labelIDTipoCuota.Text = "ID tipo de cuota:";
            // 
            // textBoxValorActual
            // 
            textBoxValorActual.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxValorActual.BackColor = Color.DimGray;
            textBoxValorActual.BorderStyle = BorderStyle.FixedSingle;
            textBoxValorActual.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxValorActual.ForeColor = Color.White;
            textBoxValorActual.Location = new Point(22, 241);
            textBoxValorActual.Name = "textBoxValorActual";
            textBoxValorActual.Size = new Size(238, 27);
            textBoxValorActual.TabIndex = 14;
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
            labelOperation.TabIndex = 18;
            labelOperation.Text = "Operación actual:";
            // 
            // textBoxIDTipoCuota
            // 
            textBoxIDTipoCuota.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxIDTipoCuota.BackColor = Color.DimGray;
            textBoxIDTipoCuota.BorderStyle = BorderStyle.FixedSingle;
            textBoxIDTipoCuota.Enabled = false;
            textBoxIDTipoCuota.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxIDTipoCuota.ForeColor = Color.White;
            textBoxIDTipoCuota.Location = new Point(22, 111);
            textBoxIDTipoCuota.Name = "textBoxIDTipoCuota";
            textBoxIDTipoCuota.ReadOnly = true;
            textBoxIDTipoCuota.Size = new Size(238, 27);
            textBoxIDTipoCuota.TabIndex = 20;
            // 
            // labelValorActual
            // 
            labelValorActual.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelValorActual.AutoSize = true;
            labelValorActual.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelValorActual.ForeColor = Color.White;
            labelValorActual.Location = new Point(22, 217);
            labelValorActual.Name = "labelValorActual";
            labelValorActual.Size = new Size(129, 23);
            labelValorActual.TabIndex = 15;
            labelValorActual.Text = "Valor actual:";
            // 
            // labelDescripcion
            // 
            labelDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelDescripcion.ForeColor = Color.White;
            labelDescripcion.Location = new Point(22, 152);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(124, 23);
            labelDescripcion.TabIndex = 12;
            labelDescripcion.Text = "Descripción:";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDescripcion.BackColor = Color.DimGray;
            textBoxDescripcion.BorderStyle = BorderStyle.FixedSingle;
            textBoxDescripcion.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxDescripcion.ForeColor = Color.White;
            textBoxDescripcion.Location = new Point(22, 179);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.ReadOnly = true;
            textBoxDescripcion.Size = new Size(238, 27);
            textBoxDescripcion.TabIndex = 13;
            // 
            // TipoCuotaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(855, 560);
            Controls.Add(buttonClose);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TipoCuotaView";
            Text = "TipoCuotaView";
            tabControl.ResumeLayout(false);
            tabPageTiposCuotasVisualizer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTiposCuotas).EndInit();
            tabPageEditCuota.ResumeLayout(false);
            tabPageEditCuota.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonClose;
        private TabControl tabControl;
        private TabPage tabPageSociosVisualizer;
        private TabPage tabPageEditCuota;
        private Button buttonCancel;
        private Button buttonSave;
        private Button buttonEdit;
        private Label labelIDTipoCuota;
        private TextBox textBoxValorActual;
        private Label labelOperation;
        private TextBox textBoxIDTipoCuota;
        private Label labelValorActual;
        private Label labelDescripcion;
        private TextBox textBoxDescripcion;
        private TabPage tabPageTiposCuotasVisualizer;
        private DataGridView dataGridViewTiposCuotas;
    }
}
namespace CapaPresentacion
{
    partial class FrmTimbrados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtIndex = new System.Windows.Forms.TextBox();
            this.TxtIdTimbrado = new System.Windows.Forms.TextBox();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.LblDetalleTimbrado = new System.Windows.Forms.Label();
            this.ChkActivo = new System.Windows.Forms.CheckBox();
            this.TxtNroHasta = new System.Windows.Forms.TextBox();
            this.TxtNroDesde = new System.Windows.Forms.TextBox();
            this.TxtNroTimbrado = new System.Windows.Forms.TextBox();
            this.LblNroHasta = new System.Windows.Forms.Label();
            this.LblNroDesde = new System.Windows.Forms.Label();
            this.LblFinVigencia = new System.Windows.Forms.Label();
            this.LblInicioVigencia = new System.Windows.Forms.Label();
            this.LblNroTimbrado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.ComboBusqueda = new System.Windows.Forms.ComboBox();
            this.LblBuscarPor = new System.Windows.Forms.Label();
            this.LblListaTimbrados = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.DtInicioVigencia = new System.Windows.Forms.DateTimePicker();
            this.DtFinVigencia = new System.Windows.Forms.DateTimePicker();
            this.BtnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idTimbrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroTimbrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InicioVigencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinVigencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtIndex
            // 
            this.TxtIndex.Location = new System.Drawing.Point(127, 59);
            this.TxtIndex.Name = "TxtIndex";
            this.TxtIndex.Size = new System.Drawing.Size(26, 20);
            this.TxtIndex.TabIndex = 54;
            this.TxtIndex.Text = "-1";
            this.TxtIndex.Visible = false;
            // 
            // TxtIdTimbrado
            // 
            this.TxtIdTimbrado.Location = new System.Drawing.Point(159, 59);
            this.TxtIdTimbrado.Name = "TxtIdTimbrado";
            this.TxtIdTimbrado.Size = new System.Drawing.Size(26, 20);
            this.TxtIdTimbrado.TabIndex = 52;
            this.TxtIdTimbrado.Text = "0";
            this.TxtIdTimbrado.Visible = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.BtnEditar.IconColor = System.Drawing.Color.White;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditar.IconSize = 18;
            this.BtnEditar.Location = new System.Drawing.Point(12, 444);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(173, 26);
            this.BtnEditar.TabIndex = 51;
            this.BtnEditar.Text = "Limpiar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BtnGuardar.IconColor = System.Drawing.Color.White;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.IconSize = 16;
            this.BtnGuardar.Location = new System.Drawing.Point(12, 412);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(173, 27);
            this.BtnGuardar.TabIndex = 50;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LblDetalleTimbrado
            // 
            this.LblDetalleTimbrado.AutoSize = true;
            this.LblDetalleTimbrado.BackColor = System.Drawing.Color.White;
            this.LblDetalleTimbrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDetalleTimbrado.Location = new System.Drawing.Point(11, 24);
            this.LblDetalleTimbrado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDetalleTimbrado.Name = "LblDetalleTimbrado";
            this.LblDetalleTimbrado.Size = new System.Drawing.Size(129, 20);
            this.LblDetalleTimbrado.TabIndex = 49;
            this.LblDetalleTimbrado.Text = "Detalle Timbrado";
            // 
            // ChkActivo
            // 
            this.ChkActivo.AutoSize = true;
            this.ChkActivo.BackColor = System.Drawing.Color.White;
            this.ChkActivo.Checked = true;
            this.ChkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkActivo.Location = new System.Drawing.Point(12, 327);
            this.ChkActivo.Name = "ChkActivo";
            this.ChkActivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkActivo.Size = new System.Drawing.Size(56, 17);
            this.ChkActivo.TabIndex = 48;
            this.ChkActivo.Text = "Activo";
            this.ChkActivo.UseVisualStyleBackColor = false;
            // 
            // TxtNroHasta
            // 
            this.TxtNroHasta.Location = new System.Drawing.Point(9, 286);
            this.TxtNroHasta.Name = "TxtNroHasta";
            this.TxtNroHasta.Size = new System.Drawing.Size(173, 20);
            this.TxtNroHasta.TabIndex = 45;
            this.TxtNroHasta.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNroHasta_Validating);
            // 
            // TxtNroDesde
            // 
            this.TxtNroDesde.Location = new System.Drawing.Point(9, 237);
            this.TxtNroDesde.Name = "TxtNroDesde";
            this.TxtNroDesde.Size = new System.Drawing.Size(173, 20);
            this.TxtNroDesde.TabIndex = 44;
            this.TxtNroDesde.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNroDesde_Validating);
            // 
            // TxtNroTimbrado
            // 
            this.TxtNroTimbrado.Location = new System.Drawing.Point(9, 97);
            this.TxtNroTimbrado.Name = "TxtNroTimbrado";
            this.TxtNroTimbrado.Size = new System.Drawing.Size(173, 20);
            this.TxtNroTimbrado.TabIndex = 41;
            this.TxtNroTimbrado.TabStop = false;
            this.TxtNroTimbrado.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNroTimbrado_Validating);
            // 
            // LblNroHasta
            // 
            this.LblNroHasta.AutoSize = true;
            this.LblNroHasta.BackColor = System.Drawing.Color.White;
            this.LblNroHasta.Location = new System.Drawing.Point(6, 269);
            this.LblNroHasta.Name = "LblNroHasta";
            this.LblNroHasta.Size = new System.Drawing.Size(78, 13);
            this.LblNroHasta.TabIndex = 38;
            this.LblNroHasta.Text = "Número Hasta:";
            // 
            // LblNroDesde
            // 
            this.LblNroDesde.AutoSize = true;
            this.LblNroDesde.BackColor = System.Drawing.Color.White;
            this.LblNroDesde.Location = new System.Drawing.Point(6, 221);
            this.LblNroDesde.Name = "LblNroDesde";
            this.LblNroDesde.Size = new System.Drawing.Size(81, 13);
            this.LblNroDesde.TabIndex = 36;
            this.LblNroDesde.Text = "Número Desde:";
            // 
            // LblFinVigencia
            // 
            this.LblFinVigencia.AutoSize = true;
            this.LblFinVigencia.BackColor = System.Drawing.Color.White;
            this.LblFinVigencia.Location = new System.Drawing.Point(6, 174);
            this.LblFinVigencia.Name = "LblFinVigencia";
            this.LblFinVigencia.Size = new System.Drawing.Size(68, 13);
            this.LblFinVigencia.TabIndex = 35;
            this.LblFinVigencia.Text = "Fin Vigencia:";
            // 
            // LblInicioVigencia
            // 
            this.LblInicioVigencia.AutoSize = true;
            this.LblInicioVigencia.BackColor = System.Drawing.Color.White;
            this.LblInicioVigencia.Location = new System.Drawing.Point(6, 127);
            this.LblInicioVigencia.Name = "LblInicioVigencia";
            this.LblInicioVigencia.Size = new System.Drawing.Size(79, 13);
            this.LblInicioVigencia.TabIndex = 34;
            this.LblInicioVigencia.Text = "Inicio Vigencia:";
            // 
            // LblNroTimbrado
            // 
            this.LblNroTimbrado.AutoSize = true;
            this.LblNroTimbrado.BackColor = System.Drawing.Color.White;
            this.LblNroTimbrado.Location = new System.Drawing.Point(6, 80);
            this.LblNroTimbrado.Name = "LblNroTimbrado";
            this.LblNroTimbrado.Size = new System.Drawing.Size(94, 13);
            this.LblNroTimbrado.TabIndex = 33;
            this.LblNroTimbrado.Text = "Número Timbrado:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 551);
            this.label1.TabIndex = 32;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.White;
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.BtnLimpiar.IconColor = System.Drawing.Color.Black;
            this.BtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLimpiar.IconSize = 18;
            this.BtnLimpiar.Location = new System.Drawing.Point(899, 22);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(43, 26);
            this.BtnLimpiar.TabIndex = 60;
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.White;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscar.IconColor = System.Drawing.Color.Black;
            this.BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscar.IconSize = 16;
            this.BtnBuscar.Location = new System.Drawing.Point(852, 22);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(43, 26);
            this.BtnBuscar.TabIndex = 59;
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(692, 26);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(155, 20);
            this.TxtBusqueda.TabIndex = 55;
            // 
            // ComboBusqueda
            // 
            this.ComboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBusqueda.FormattingEnabled = true;
            this.ComboBusqueda.Location = new System.Drawing.Point(565, 26);
            this.ComboBusqueda.Name = "ComboBusqueda";
            this.ComboBusqueda.Size = new System.Drawing.Size(121, 21);
            this.ComboBusqueda.TabIndex = 58;
            // 
            // LblBuscarPor
            // 
            this.LblBuscarPor.AutoSize = true;
            this.LblBuscarPor.BackColor = System.Drawing.Color.White;
            this.LblBuscarPor.Location = new System.Drawing.Point(498, 29);
            this.LblBuscarPor.Name = "LblBuscarPor";
            this.LblBuscarPor.Size = new System.Drawing.Size(61, 13);
            this.LblBuscarPor.TabIndex = 57;
            this.LblBuscarPor.Text = "Buscar por:";
            // 
            // LblListaTimbrados
            // 
            this.LblListaTimbrados.BackColor = System.Drawing.Color.White;
            this.LblListaTimbrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblListaTimbrados.Location = new System.Drawing.Point(219, 12);
            this.LblListaTimbrados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblListaTimbrados.Name = "LblListaTimbrados";
            this.LblListaTimbrados.Padding = new System.Windows.Forms.Padding(2);
            this.LblListaTimbrados.Size = new System.Drawing.Size(935, 40);
            this.LblListaTimbrados.TabIndex = 56;
            this.LblListaTimbrados.Text = "Lista de Timbrados";
            this.LblListaTimbrados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnSeleccionar,
            this.idTimbrado,
            this.NroTimbrado,
            this.InicioVigencia,
            this.FinVigencia,
            this.NroDesde,
            this.NroHasta,
            this.Activo});
            this.dgvData.Location = new System.Drawing.Point(220, 68);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(934, 384);
            this.dgvData.TabIndex = 61;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting);
            // 
            // DtInicioVigencia
            // 
            this.DtInicioVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtInicioVigencia.Location = new System.Drawing.Point(9, 144);
            this.DtInicioVigencia.Name = "DtInicioVigencia";
            this.DtInicioVigencia.Size = new System.Drawing.Size(173, 20);
            this.DtInicioVigencia.TabIndex = 62;
            this.DtInicioVigencia.Value = new System.DateTime(2023, 9, 10, 0, 0, 0, 0);
            // 
            // DtFinVigencia
            // 
            this.DtFinVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFinVigencia.Location = new System.Drawing.Point(9, 191);
            this.DtFinVigencia.Name = "DtFinVigencia";
            this.DtFinVigencia.Size = new System.Drawing.Size(173, 20);
            this.DtFinVigencia.TabIndex = 63;
            this.DtFinVigencia.Value = new System.DateTime(2023, 9, 10, 0, 0, 0, 0);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.HeaderText = "";
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.ReadOnly = true;
            this.BtnSeleccionar.Width = 30;
            // 
            // idTimbrado
            // 
            this.idTimbrado.HeaderText = "idTimbrado";
            this.idTimbrado.Name = "idTimbrado";
            this.idTimbrado.ReadOnly = true;
            this.idTimbrado.Visible = false;
            // 
            // NroTimbrado
            // 
            this.NroTimbrado.HeaderText = "Número Timbrado";
            this.NroTimbrado.Name = "NroTimbrado";
            this.NroTimbrado.ReadOnly = true;
            this.NroTimbrado.Width = 150;
            // 
            // InicioVigencia
            // 
            this.InicioVigencia.HeaderText = "Inicio Vigencia";
            this.InicioVigencia.Name = "InicioVigencia";
            this.InicioVigencia.ReadOnly = true;
            this.InicioVigencia.Width = 150;
            // 
            // FinVigencia
            // 
            this.FinVigencia.HeaderText = "Fin Vigencia";
            this.FinVigencia.Name = "FinVigencia";
            this.FinVigencia.ReadOnly = true;
            this.FinVigencia.Width = 150;
            // 
            // NroDesde
            // 
            this.NroDesde.HeaderText = "Número Desde";
            this.NroDesde.Name = "NroDesde";
            this.NroDesde.ReadOnly = true;
            this.NroDesde.Width = 150;
            // 
            // NroHasta
            // 
            this.NroHasta.HeaderText = "Número Hasta";
            this.NroHasta.Name = "NroHasta";
            this.NroHasta.ReadOnly = true;
            this.NroHasta.Width = 150;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FrmTimbrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1166, 551);
            this.Controls.Add(this.DtFinVigencia);
            this.Controls.Add(this.DtInicioVigencia);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.ComboBusqueda);
            this.Controls.Add(this.LblBuscarPor);
            this.Controls.Add(this.LblListaTimbrados);
            this.Controls.Add(this.TxtIndex);
            this.Controls.Add(this.TxtIdTimbrado);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblDetalleTimbrado);
            this.Controls.Add(this.ChkActivo);
            this.Controls.Add(this.TxtNroHasta);
            this.Controls.Add(this.TxtNroDesde);
            this.Controls.Add(this.TxtNroTimbrado);
            this.Controls.Add(this.LblNroHasta);
            this.Controls.Add(this.LblNroDesde);
            this.Controls.Add(this.LblFinVigencia);
            this.Controls.Add(this.LblInicioVigencia);
            this.Controls.Add(this.LblNroTimbrado);
            this.Controls.Add(this.label1);
            this.Name = "FrmTimbrados";
            this.Text = "Timbrados";
            this.Load += new System.EventHandler(this.FrmTimbrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIndex;
        private System.Windows.Forms.TextBox TxtIdTimbrado;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.Label LblDetalleTimbrado;
        private System.Windows.Forms.CheckBox ChkActivo;
        private System.Windows.Forms.TextBox TxtNroHasta;
        private System.Windows.Forms.TextBox TxtNroDesde;
        private System.Windows.Forms.TextBox TxtNroTimbrado;
        private System.Windows.Forms.Label LblNroHasta;
        private System.Windows.Forms.Label LblNroDesde;
        private System.Windows.Forms.Label LblFinVigencia;
        private System.Windows.Forms.Label LblInicioVigencia;
        private System.Windows.Forms.Label LblNroTimbrado;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.ComboBox ComboBusqueda;
        private System.Windows.Forms.Label LblBuscarPor;
        private System.Windows.Forms.Label LblListaTimbrados;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DateTimePicker DtInicioVigencia;
        private System.Windows.Forms.DateTimePicker DtFinVigencia;
        private System.Windows.Forms.DataGridViewButtonColumn BtnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTimbrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroTimbrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn InicioVigencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinVigencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroHasta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
    }
}
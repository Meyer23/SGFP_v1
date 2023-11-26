namespace CapaPresentacion
{
    partial class FrmImpuestos
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
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.ComboBusqueda = new System.Windows.Forms.ComboBox();
            this.LblBuscarPor = new System.Windows.Forms.Label();
            this.TxtIdImpuesto = new System.Windows.Forms.TextBox();
            this.LblListaImpuestos = new System.Windows.Forms.Label();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.BtnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactorGravada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactorIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LblDetalleUnidadMedida = new System.Windows.Forms.Label();
            this.ChkActivo = new System.Windows.Forms.CheckBox();
            this.TxtFactorIVA = new System.Windows.Forms.TextBox();
            this.TxtPorcIVA = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtTipoImpuesto = new System.Windows.Forms.TextBox();
            this.LblFactorIVA = new System.Windows.Forms.Label();
            this.LblFactorGravada = new System.Windows.Forms.Label();
            this.LblPorcIVA = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblTipoImpuesto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFactorGravada = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtIndex
            // 
            this.TxtIndex.Location = new System.Drawing.Point(127, 55);
            this.TxtIndex.Name = "TxtIndex";
            this.TxtIndex.Size = new System.Drawing.Size(26, 20);
            this.TxtIndex.TabIndex = 61;
            this.TxtIndex.Text = "-1";
            this.TxtIndex.Visible = false;
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
            this.BtnLimpiar.Location = new System.Drawing.Point(1263, 30);
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
            this.BtnBuscar.Location = new System.Drawing.Point(1216, 30);
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
            this.TxtBusqueda.Location = new System.Drawing.Point(1056, 34);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(155, 20);
            this.TxtBusqueda.TabIndex = 33;
            // 
            // ComboBusqueda
            // 
            this.ComboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBusqueda.FormattingEnabled = true;
            this.ComboBusqueda.Location = new System.Drawing.Point(929, 34);
            this.ComboBusqueda.Name = "ComboBusqueda";
            this.ComboBusqueda.Size = new System.Drawing.Size(121, 21);
            this.ComboBusqueda.TabIndex = 58;
            // 
            // LblBuscarPor
            // 
            this.LblBuscarPor.AutoSize = true;
            this.LblBuscarPor.BackColor = System.Drawing.Color.White;
            this.LblBuscarPor.Location = new System.Drawing.Point(862, 37);
            this.LblBuscarPor.Name = "LblBuscarPor";
            this.LblBuscarPor.Size = new System.Drawing.Size(61, 13);
            this.LblBuscarPor.TabIndex = 57;
            this.LblBuscarPor.Text = "Buscar por:";
            // 
            // TxtIdImpuesto
            // 
            this.TxtIdImpuesto.Location = new System.Drawing.Point(159, 55);
            this.TxtIdImpuesto.Name = "TxtIdImpuesto";
            this.TxtIdImpuesto.Size = new System.Drawing.Size(26, 20);
            this.TxtIdImpuesto.TabIndex = 55;
            this.TxtIdImpuesto.Text = "0";
            this.TxtIdImpuesto.Visible = false;
            // 
            // LblListaImpuestos
            // 
            this.LblListaImpuestos.BackColor = System.Drawing.Color.White;
            this.LblListaImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblListaImpuestos.Location = new System.Drawing.Point(326, 20);
            this.LblListaImpuestos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblListaImpuestos.Name = "LblListaImpuestos";
            this.LblListaImpuestos.Padding = new System.Windows.Forms.Padding(2);
            this.LblListaImpuestos.Size = new System.Drawing.Size(1033, 40);
            this.LblListaImpuestos.TabIndex = 54;
            this.LblListaImpuestos.Text = "Lista de Impuestos";
            this.LblListaImpuestos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.BtnEditar.Location = new System.Drawing.Point(55, 520);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(173, 26);
            this.BtnEditar.TabIndex = 52;
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
            this.BtnGuardar.Location = new System.Drawing.Point(55, 488);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(173, 27);
            this.BtnGuardar.TabIndex = 51;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
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
            this.idImpuesto,
            this.TipoImpuesto,
            this.Descripcion,
            this.PorcIVA,
            this.FactorGravada,
            this.FactorIVA,
            this.Activo});
            this.dgvData.Location = new System.Drawing.Point(326, 81);
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
            this.dgvData.Size = new System.Drawing.Size(1032, 458);
            this.dgvData.TabIndex = 53;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.HeaderText = "";
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.ReadOnly = true;
            this.BtnSeleccionar.Width = 30;
            // 
            // idImpuesto
            // 
            this.idImpuesto.HeaderText = "idImpuesto";
            this.idImpuesto.Name = "idImpuesto";
            this.idImpuesto.ReadOnly = true;
            this.idImpuesto.Visible = false;
            // 
            // TipoImpuesto
            // 
            this.TipoImpuesto.HeaderText = "Tipo Impuesto";
            this.TipoImpuesto.Name = "TipoImpuesto";
            this.TipoImpuesto.ReadOnly = true;
            this.TipoImpuesto.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 150;
            // 
            // PorcIVA
            // 
            this.PorcIVA.HeaderText = "Porc IVA";
            this.PorcIVA.Name = "PorcIVA";
            this.PorcIVA.ReadOnly = true;
            // 
            // FactorGravada
            // 
            this.FactorGravada.HeaderText = "Factor Gravada";
            this.FactorGravada.Name = "FactorGravada";
            this.FactorGravada.ReadOnly = true;
            this.FactorGravada.Width = 150;
            // 
            // FactorIVA
            // 
            this.FactorIVA.HeaderText = "Factor IVA";
            this.FactorIVA.Name = "FactorIVA";
            this.FactorIVA.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // LblDetalleUnidadMedida
            // 
            this.LblDetalleUnidadMedida.AutoSize = true;
            this.LblDetalleUnidadMedida.BackColor = System.Drawing.Color.White;
            this.LblDetalleUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDetalleUnidadMedida.Location = new System.Drawing.Point(11, 20);
            this.LblDetalleUnidadMedida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDetalleUnidadMedida.Name = "LblDetalleUnidadMedida";
            this.LblDetalleUnidadMedida.Size = new System.Drawing.Size(130, 20);
            this.LblDetalleUnidadMedida.TabIndex = 50;
            this.LblDetalleUnidadMedida.Text = "Detalle Impuesto";
            // 
            // ChkActivo
            // 
            this.ChkActivo.AutoSize = true;
            this.ChkActivo.BackColor = System.Drawing.Color.White;
            this.ChkActivo.Checked = true;
            this.ChkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkActivo.Location = new System.Drawing.Point(12, 329);
            this.ChkActivo.Name = "ChkActivo";
            this.ChkActivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkActivo.Size = new System.Drawing.Size(56, 17);
            this.ChkActivo.TabIndex = 49;
            this.ChkActivo.Text = "Activo";
            this.ChkActivo.UseVisualStyleBackColor = false;
            // 
            // TxtFactorIVA
            // 
            this.TxtFactorIVA.Location = new System.Drawing.Point(12, 293);
            this.TxtFactorIVA.Name = "TxtFactorIVA";
            this.TxtFactorIVA.Size = new System.Drawing.Size(273, 20);
            this.TxtFactorIVA.TabIndex = 46;
            this.TxtFactorIVA.Validating += new System.ComponentModel.CancelEventHandler(this.TxtFactorIVA_Validating);
            // 
            // TxtPorcIVA
            // 
            this.TxtPorcIVA.Location = new System.Drawing.Point(12, 185);
            this.TxtPorcIVA.Name = "TxtPorcIVA";
            this.TxtPorcIVA.Size = new System.Drawing.Size(273, 20);
            this.TxtPorcIVA.TabIndex = 44;
            this.TxtPorcIVA.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPorcIVA_Validating);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(12, 133);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(273, 20);
            this.TxtDescripcion.TabIndex = 43;
            this.TxtDescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDescripcion_Validating);
            // 
            // TxtTipoImpuesto
            // 
            this.TxtTipoImpuesto.Location = new System.Drawing.Point(12, 81);
            this.TxtTipoImpuesto.Name = "TxtTipoImpuesto";
            this.TxtTipoImpuesto.Size = new System.Drawing.Size(273, 20);
            this.TxtTipoImpuesto.TabIndex = 42;
            this.TxtTipoImpuesto.TabStop = false;
            this.TxtTipoImpuesto.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTipoImpuesto_Validating);
            // 
            // LblFactorIVA
            // 
            this.LblFactorIVA.AutoSize = true;
            this.LblFactorIVA.BackColor = System.Drawing.Color.White;
            this.LblFactorIVA.Location = new System.Drawing.Point(9, 276);
            this.LblFactorIVA.Name = "LblFactorIVA";
            this.LblFactorIVA.Size = new System.Drawing.Size(60, 13);
            this.LblFactorIVA.TabIndex = 39;
            this.LblFactorIVA.Text = "Factor IVA:";
            // 
            // LblFactorGravada
            // 
            this.LblFactorGravada.AutoSize = true;
            this.LblFactorGravada.BackColor = System.Drawing.Color.White;
            this.LblFactorGravada.Location = new System.Drawing.Point(9, 224);
            this.LblFactorGravada.Name = "LblFactorGravada";
            this.LblFactorGravada.Size = new System.Drawing.Size(84, 13);
            this.LblFactorGravada.TabIndex = 37;
            this.LblFactorGravada.Text = "Factor Gravada:";
            // 
            // LblPorcIVA
            // 
            this.LblPorcIVA.AutoSize = true;
            this.LblPorcIVA.BackColor = System.Drawing.Color.White;
            this.LblPorcIVA.Location = new System.Drawing.Point(9, 168);
            this.LblPorcIVA.Name = "LblPorcIVA";
            this.LblPorcIVA.Size = new System.Drawing.Size(81, 13);
            this.LblPorcIVA.TabIndex = 36;
            this.LblPorcIVA.Text = "Porcentaje IVA:";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.BackColor = System.Drawing.Color.White;
            this.LblDescripcion.Location = new System.Drawing.Point(9, 116);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.LblDescripcion.TabIndex = 35;
            this.LblDescripcion.Text = "Descripción:";
            // 
            // LblTipoImpuesto
            // 
            this.LblTipoImpuesto.AutoSize = true;
            this.LblTipoImpuesto.BackColor = System.Drawing.Color.White;
            this.LblTipoImpuesto.Location = new System.Drawing.Point(9, 64);
            this.LblTipoImpuesto.Name = "LblTipoImpuesto";
            this.LblTipoImpuesto.Size = new System.Drawing.Size(77, 13);
            this.LblTipoImpuesto.TabIndex = 34;
            this.LblTipoImpuesto.Text = "Tipo Impuesto:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 551);
            this.label1.TabIndex = 32;
            // 
            // TxtFactorGravada
            // 
            this.TxtFactorGravada.Location = new System.Drawing.Point(12, 240);
            this.TxtFactorGravada.Name = "TxtFactorGravada";
            this.TxtFactorGravada.Size = new System.Drawing.Size(273, 20);
            this.TxtFactorGravada.TabIndex = 45;
            this.TxtFactorGravada.Validating += new System.ComponentModel.CancelEventHandler(this.TxtFactorGravada_Validating);
            // 
            // FrmImpuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1370, 551);
            this.Controls.Add(this.TxtIndex);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.ComboBusqueda);
            this.Controls.Add(this.LblBuscarPor);
            this.Controls.Add(this.TxtIdImpuesto);
            this.Controls.Add(this.LblListaImpuestos);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.LblDetalleUnidadMedida);
            this.Controls.Add(this.ChkActivo);
            this.Controls.Add(this.TxtFactorIVA);
            this.Controls.Add(this.TxtFactorGravada);
            this.Controls.Add(this.TxtPorcIVA);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtTipoImpuesto);
            this.Controls.Add(this.LblFactorIVA);
            this.Controls.Add(this.LblFactorGravada);
            this.Controls.Add(this.LblPorcIVA);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblTipoImpuesto);
            this.Controls.Add(this.label1);
            this.Name = "FrmImpuestos";
            this.Text = "Impuestos";
            this.Load += new System.EventHandler(this.FrmImpuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIndex;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.ComboBox ComboBusqueda;
        private System.Windows.Forms.Label LblBuscarPor;
        private System.Windows.Forms.TextBox TxtIdImpuesto;
        private System.Windows.Forms.Label LblListaImpuestos;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label LblDetalleUnidadMedida;
        private System.Windows.Forms.CheckBox ChkActivo;
        private System.Windows.Forms.TextBox TxtFactorIVA;
        private System.Windows.Forms.TextBox TxtPorcIVA;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtTipoImpuesto;
        private System.Windows.Forms.Label LblFactorIVA;
        private System.Windows.Forms.Label LblFactorGravada;
        private System.Windows.Forms.Label LblPorcIVA;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblTipoImpuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn BtnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactorGravada;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactorIVA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
        private System.Windows.Forms.TextBox TxtFactorGravada;
    }
}
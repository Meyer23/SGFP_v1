﻿namespace CapaPresentacion
{
    partial class FrmRoles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblRoles = new System.Windows.Forms.Label();
            this.ListaLabelRoles = new System.Windows.Forms.Label();
            this.dgvRolesData = new System.Windows.Forms.DataGridView();
            this.BtnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LblDetalleRol = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.ChkActivo = new System.Windows.Forms.CheckBox();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.TxtIdRol = new System.Windows.Forms.TextBox();
            this.TxtIndex = new System.Windows.Forms.TextBox();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.dgvModulosData = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdModulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visualiza = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Incluye = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Modifica = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvProcesosData = new System.Windows.Forms.DataGridView();
            this.idRolProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Procesar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LblModulos = new System.Windows.Forms.Label();
            this.LblProcesos = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.ComboBusqueda = new System.Windows.Forms.ComboBox();
            this.LblBuscarPor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulosData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesosData)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRoles
            // 
            this.LblRoles.BackColor = System.Drawing.Color.White;
            this.LblRoles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblRoles.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblRoles.Location = new System.Drawing.Point(0, 0);
            this.LblRoles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRoles.Name = "LblRoles";
            this.LblRoles.Size = new System.Drawing.Size(534, 549);
            this.LblRoles.TabIndex = 1;
            // 
            // ListaLabelRoles
            // 
            this.ListaLabelRoles.BackColor = System.Drawing.Color.White;
            this.ListaLabelRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaLabelRoles.Location = new System.Drawing.Point(554, 19);
            this.ListaLabelRoles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ListaLabelRoles.Name = "ListaLabelRoles";
            this.ListaLabelRoles.Size = new System.Drawing.Size(805, 40);
            this.ListaLabelRoles.TabIndex = 20;
            this.ListaLabelRoles.Text = "Roles";
            this.ListaLabelRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvRolesData
            // 
            this.dgvRolesData.AllowUserToAddRows = false;
            this.dgvRolesData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRolesData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRolesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRolesData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnSeleccionar,
            this.idRol,
            this.Descripcion,
            this.Activo});
            this.dgvRolesData.Location = new System.Drawing.Point(554, 72);
            this.dgvRolesData.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRolesData.MultiSelect = false;
            this.dgvRolesData.Name = "dgvRolesData";
            this.dgvRolesData.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRolesData.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRolesData.RowHeadersWidth = 62;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRolesData.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRolesData.RowTemplate.Height = 28;
            this.dgvRolesData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRolesData.Size = new System.Drawing.Size(805, 466);
            this.dgvRolesData.TabIndex = 21;
            this.dgvRolesData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRolesData_CellContentClick);
            this.dgvRolesData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvRolesData_CellPainting);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.HeaderText = "";
            this.BtnSeleccionar.MinimumWidth = 8;
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.ReadOnly = true;
            this.BtnSeleccionar.Width = 30;
            // 
            // idRol
            // 
            this.idRol.HeaderText = "idRol";
            this.idRol.Name = "idRol";
            this.idRol.ReadOnly = true;
            this.idRol.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 250;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.MinimumWidth = 8;
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Activo.Width = 50;
            // 
            // LblDetalleRol
            // 
            this.LblDetalleRol.AutoSize = true;
            this.LblDetalleRol.BackColor = System.Drawing.Color.White;
            this.LblDetalleRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDetalleRol.Location = new System.Drawing.Point(11, 9);
            this.LblDetalleRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDetalleRol.Name = "LblDetalleRol";
            this.LblDetalleRol.Size = new System.Drawing.Size(87, 20);
            this.LblDetalleRol.TabIndex = 22;
            this.LblDetalleRol.Text = "Detalle Rol";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(15, 51);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(420, 20);
            this.TxtNombre.TabIndex = 24;
            this.TxtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombre_Validating);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(12, 36);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(47, 13);
            this.LblNombre.TabIndex = 23;
            this.LblNombre.Text = "Nombre:";
            // 
            // ChkActivo
            // 
            this.ChkActivo.AutoSize = true;
            this.ChkActivo.BackColor = System.Drawing.Color.White;
            this.ChkActivo.Checked = true;
            this.ChkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkActivo.Location = new System.Drawing.Point(448, 51);
            this.ChkActivo.Margin = new System.Windows.Forms.Padding(2);
            this.ChkActivo.Name = "ChkActivo";
            this.ChkActivo.Size = new System.Drawing.Size(56, 17);
            this.ChkActivo.TabIndex = 25;
            this.ChkActivo.Text = "Activo";
            this.ChkActivo.UseVisualStyleBackColor = false;
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
            this.BtnGuardar.Location = new System.Drawing.Point(82, 511);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(173, 27);
            this.BtnGuardar.TabIndex = 26;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtIdRol
            // 
            this.TxtIdRol.Location = new System.Drawing.Point(156, 23);
            this.TxtIdRol.Name = "TxtIdRol";
            this.TxtIdRol.Size = new System.Drawing.Size(26, 20);
            this.TxtIdRol.TabIndex = 27;
            this.TxtIdRol.Text = "0";
            this.TxtIdRol.Visible = false;
            // 
            // TxtIndex
            // 
            this.TxtIndex.Location = new System.Drawing.Point(124, 23);
            this.TxtIndex.Name = "TxtIndex";
            this.TxtIndex.Size = new System.Drawing.Size(26, 20);
            this.TxtIndex.TabIndex = 32;
            this.TxtIndex.Text = "-1";
            this.TxtIndex.Visible = false;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.BtnLimpiar.IconColor = System.Drawing.Color.White;
            this.BtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLimpiar.IconSize = 18;
            this.BtnLimpiar.Location = new System.Drawing.Point(273, 512);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(173, 26);
            this.BtnLimpiar.TabIndex = 33;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // dgvModulosData
            // 
            this.dgvModulosData.AllowUserToAddRows = false;
            this.dgvModulosData.AllowUserToDeleteRows = false;
            this.dgvModulosData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModulosData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Rol,
            this.IdModulo,
            this.Modulo,
            this.Visualiza,
            this.Incluye,
            this.Modifica});
            this.dgvModulosData.Location = new System.Drawing.Point(15, 98);
            this.dgvModulosData.Name = "dgvModulosData";
            this.dgvModulosData.Size = new System.Drawing.Size(500, 164);
            this.dgvModulosData.TabIndex = 34;
            this.dgvModulosData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModulosData_CellValueChanged);
            // 
            // id
            // 
            this.id.HeaderText = "";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "";
            this.Rol.Name = "Rol";
            this.Rol.Visible = false;
            // 
            // IdModulo
            // 
            this.IdModulo.HeaderText = "";
            this.IdModulo.Name = "IdModulo";
            this.IdModulo.Visible = false;
            // 
            // Modulo
            // 
            this.Modulo.HeaderText = "Módulo";
            this.Modulo.Name = "Modulo";
            this.Modulo.Width = 200;
            // 
            // Visualiza
            // 
            this.Visualiza.HeaderText = "Visualiza";
            this.Visualiza.Name = "Visualiza";
            this.Visualiza.Width = 80;
            // 
            // Incluye
            // 
            this.Incluye.HeaderText = "Incluye";
            this.Incluye.Name = "Incluye";
            this.Incluye.Width = 80;
            // 
            // Modifica
            // 
            this.Modifica.HeaderText = "Modifica";
            this.Modifica.Name = "Modifica";
            this.Modifica.Width = 80;
            // 
            // dgvProcesosData
            // 
            this.dgvProcesosData.AllowUserToAddRows = false;
            this.dgvProcesosData.AllowUserToDeleteRows = false;
            this.dgvProcesosData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesosData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRolProceso,
            this.RolId,
            this.idProceso,
            this.Proceso,
            this.Procesar});
            this.dgvProcesosData.Location = new System.Drawing.Point(15, 290);
            this.dgvProcesosData.Name = "dgvProcesosData";
            this.dgvProcesosData.Size = new System.Drawing.Size(500, 164);
            this.dgvProcesosData.TabIndex = 35;
            this.dgvProcesosData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcesosData_CellValueChanged);
            // 
            // idRolProceso
            // 
            this.idRolProceso.HeaderText = "";
            this.idRolProceso.Name = "idRolProceso";
            this.idRolProceso.Visible = false;
            // 
            // RolId
            // 
            this.RolId.HeaderText = "";
            this.RolId.Name = "RolId";
            this.RolId.Visible = false;
            // 
            // idProceso
            // 
            this.idProceso.HeaderText = "";
            this.idProceso.Name = "idProceso";
            this.idProceso.Visible = false;
            // 
            // Proceso
            // 
            this.Proceso.HeaderText = "Proceso";
            this.Proceso.Name = "Proceso";
            this.Proceso.Width = 300;
            // 
            // Procesar
            // 
            this.Procesar.HeaderText = "Procesar";
            this.Procesar.Name = "Procesar";
            this.Procesar.Width = 80;
            // 
            // LblModulos
            // 
            this.LblModulos.AutoSize = true;
            this.LblModulos.BackColor = System.Drawing.Color.White;
            this.LblModulos.Location = new System.Drawing.Point(12, 82);
            this.LblModulos.Name = "LblModulos";
            this.LblModulos.Size = new System.Drawing.Size(47, 13);
            this.LblModulos.TabIndex = 36;
            this.LblModulos.Text = "Módulos";
            // 
            // LblProcesos
            // 
            this.LblProcesos.AutoSize = true;
            this.LblProcesos.BackColor = System.Drawing.Color.White;
            this.LblProcesos.Location = new System.Drawing.Point(12, 274);
            this.LblProcesos.Name = "LblProcesos";
            this.LblProcesos.Size = new System.Drawing.Size(51, 13);
            this.LblProcesos.TabIndex = 37;
            this.LblProcesos.Text = "Procesos";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 18;
            this.iconButton1.Location = new System.Drawing.Point(1277, 29);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(43, 26);
            this.iconButton1.TabIndex = 90;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
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
            this.BtnBuscar.Location = new System.Drawing.Point(1230, 29);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(43, 26);
            this.BtnBuscar.TabIndex = 89;
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(1070, 33);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(155, 20);
            this.TxtBusqueda.TabIndex = 86;
            // 
            // ComboBusqueda
            // 
            this.ComboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBusqueda.FormattingEnabled = true;
            this.ComboBusqueda.Location = new System.Drawing.Point(943, 33);
            this.ComboBusqueda.Name = "ComboBusqueda";
            this.ComboBusqueda.Size = new System.Drawing.Size(121, 21);
            this.ComboBusqueda.TabIndex = 88;
            // 
            // LblBuscarPor
            // 
            this.LblBuscarPor.AutoSize = true;
            this.LblBuscarPor.BackColor = System.Drawing.Color.White;
            this.LblBuscarPor.Location = new System.Drawing.Point(876, 36);
            this.LblBuscarPor.Name = "LblBuscarPor";
            this.LblBuscarPor.Size = new System.Drawing.Size(61, 13);
            this.LblBuscarPor.TabIndex = 87;
            this.LblBuscarPor.Text = "Buscar por:";
            // 
            // FrmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 549);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.ComboBusqueda);
            this.Controls.Add(this.LblBuscarPor);
            this.Controls.Add(this.LblProcesos);
            this.Controls.Add(this.LblModulos);
            this.Controls.Add(this.dgvProcesosData);
            this.Controls.Add(this.dgvModulosData);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TxtIndex);
            this.Controls.Add(this.TxtIdRol);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.ChkActivo);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblDetalleRol);
            this.Controls.Add(this.dgvRolesData);
            this.Controls.Add(this.ListaLabelRoles);
            this.Controls.Add(this.LblRoles);
            this.Name = "FrmRoles";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.FrmRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulosData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesosData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRoles;
        private System.Windows.Forms.Label ListaLabelRoles;
        private System.Windows.Forms.DataGridView dgvRolesData;
        private System.Windows.Forms.Label LblDetalleRol;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.CheckBox ChkActivo;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.TextBox TxtIdRol;
        private System.Windows.Forms.TextBox TxtIndex;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private System.Windows.Forms.DataGridView dgvModulosData;
        private System.Windows.Forms.DataGridViewButtonColumn BtnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdModulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modulo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Visualiza;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Incluye;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Modifica;
        private System.Windows.Forms.DataGridView dgvProcesosData;
        private System.Windows.Forms.Label LblModulos;
        private System.Windows.Forms.Label LblProcesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRolProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolId;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proceso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Procesar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.ComboBox ComboBusqueda;
        private System.Windows.Forms.Label LblBuscarPor;
    }
}
namespace CapaPresentacion
{
    partial class FrmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtIndex = new System.Windows.Forms.TextBox();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.LblDetalleCliente = new System.Windows.Forms.Label();
            this.ChkActivo = new System.Windows.Forms.CheckBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtTelefono2 = new System.Windows.Forms.TextBox();
            this.TxtTelefono1 = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.LblTelefono2 = new System.Windows.Forms.Label();
            this.LblTelefono1 = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblDocumento = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.ComboBusqueda = new System.Windows.Forms.ComboBox();
            this.LblBuscarPor = new System.Windows.Forms.Label();
            this.LblListaClientes = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.BtnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPers = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupTipoPersona = new System.Windows.Forms.GroupBox();
            this.radioButtonJuridica = new System.Windows.Forms.RadioButton();
            this.radioButtonFisica = new System.Windows.Forms.RadioButton();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.LblApellidos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupTipoPersona.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtIndex
            // 
            this.TxtIndex.Location = new System.Drawing.Point(127, 37);
            this.TxtIndex.Name = "TxtIndex";
            this.TxtIndex.Size = new System.Drawing.Size(26, 20);
            this.TxtIndex.TabIndex = 76;
            this.TxtIndex.Text = "-1";
            this.TxtIndex.Visible = false;
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Location = new System.Drawing.Point(159, 37);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(26, 20);
            this.TxtIdCliente.TabIndex = 77;
            this.TxtIdCliente.Text = "0";
            this.TxtIdCliente.Visible = false;
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
            this.BtnEditar.Location = new System.Drawing.Point(11, 484);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(173, 26);
            this.BtnEditar.TabIndex = 75;
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
            this.BtnGuardar.Location = new System.Drawing.Point(11, 452);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(173, 27);
            this.BtnGuardar.TabIndex = 74;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LblDetalleCliente
            // 
            this.LblDetalleCliente.AutoSize = true;
            this.LblDetalleCliente.BackColor = System.Drawing.Color.White;
            this.LblDetalleCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDetalleCliente.Location = new System.Drawing.Point(7, 14);
            this.LblDetalleCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDetalleCliente.Name = "LblDetalleCliente";
            this.LblDetalleCliente.Size = new System.Drawing.Size(112, 20);
            this.LblDetalleCliente.TabIndex = 78;
            this.LblDetalleCliente.Text = "Detalle Cliente";
            // 
            // ChkActivo
            // 
            this.ChkActivo.AutoSize = true;
            this.ChkActivo.BackColor = System.Drawing.Color.White;
            this.ChkActivo.Checked = true;
            this.ChkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkActivo.Location = new System.Drawing.Point(12, 424);
            this.ChkActivo.Name = "ChkActivo";
            this.ChkActivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkActivo.Size = new System.Drawing.Size(56, 17);
            this.ChkActivo.TabIndex = 73;
            this.ChkActivo.Text = "Activo";
            this.ChkActivo.UseVisualStyleBackColor = false;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(12, 307);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(173, 20);
            this.TxtCorreo.TabIndex = 71;
            this.TxtCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCorreo_Validating);
            // 
            // TxtTelefono2
            // 
            this.TxtTelefono2.Location = new System.Drawing.Point(12, 267);
            this.TxtTelefono2.Name = "TxtTelefono2";
            this.TxtTelefono2.Size = new System.Drawing.Size(173, 20);
            this.TxtTelefono2.TabIndex = 70;
            // 
            // TxtTelefono1
            // 
            this.TxtTelefono1.Location = new System.Drawing.Point(12, 227);
            this.TxtTelefono1.Name = "TxtTelefono1";
            this.TxtTelefono1.Size = new System.Drawing.Size(173, 20);
            this.TxtTelefono1.TabIndex = 69;
            this.TxtTelefono1.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTelefono1_Validating);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(12, 187);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(173, 20);
            this.TxtDireccion.TabIndex = 68;
            this.TxtDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDireccion_Validating);
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Location = new System.Drawing.Point(11, 64);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(173, 20);
            this.TxtDocumento.TabIndex = 65;
            this.TxtDocumento.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDocumento_Validating);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(11, 104);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(173, 20);
            this.TxtNombre.TabIndex = 66;
            this.TxtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombre_Validating);
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.BackColor = System.Drawing.Color.White;
            this.LblCorreo.Location = new System.Drawing.Point(9, 290);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(41, 13);
            this.LblCorreo.TabIndex = 64;
            this.LblCorreo.Text = "Correo:";
            // 
            // LblTelefono2
            // 
            this.LblTelefono2.AutoSize = true;
            this.LblTelefono2.BackColor = System.Drawing.Color.White;
            this.LblTelefono2.Location = new System.Drawing.Point(9, 250);
            this.LblTelefono2.Name = "LblTelefono2";
            this.LblTelefono2.Size = new System.Drawing.Size(61, 13);
            this.LblTelefono2.TabIndex = 63;
            this.LblTelefono2.Text = "Teléfono 2:";
            // 
            // LblTelefono1
            // 
            this.LblTelefono1.AutoSize = true;
            this.LblTelefono1.BackColor = System.Drawing.Color.White;
            this.LblTelefono1.Location = new System.Drawing.Point(9, 210);
            this.LblTelefono1.Name = "LblTelefono1";
            this.LblTelefono1.Size = new System.Drawing.Size(61, 13);
            this.LblTelefono1.TabIndex = 62;
            this.LblTelefono1.Text = "Teléfono 1:";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.BackColor = System.Drawing.Color.White;
            this.LblDireccion.Location = new System.Drawing.Point(9, 171);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(55, 13);
            this.LblDireccion.TabIndex = 61;
            this.LblDireccion.Text = "Dirección:";
            // 
            // LblDocumento
            // 
            this.LblDocumento.AutoSize = true;
            this.LblDocumento.BackColor = System.Drawing.Color.White;
            this.LblDocumento.Location = new System.Drawing.Point(8, 47);
            this.LblDocumento.Name = "LblDocumento";
            this.LblDocumento.Size = new System.Drawing.Size(65, 13);
            this.LblDocumento.TabIndex = 58;
            this.LblDocumento.Text = "Documento:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(8, 87);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(52, 13);
            this.LblNombre.TabIndex = 59;
            this.LblNombre.Text = "Nombres:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 532);
            this.label1.TabIndex = 55;
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
            this.BtnLimpiar.Location = new System.Drawing.Point(895, 27);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(43, 26);
            this.BtnLimpiar.TabIndex = 82;
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
            this.BtnBuscar.Location = new System.Drawing.Point(848, 27);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(43, 26);
            this.BtnBuscar.TabIndex = 81;
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(688, 31);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(155, 20);
            this.TxtBusqueda.TabIndex = 80;
            // 
            // ComboBusqueda
            // 
            this.ComboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBusqueda.FormattingEnabled = true;
            this.ComboBusqueda.Location = new System.Drawing.Point(561, 31);
            this.ComboBusqueda.Name = "ComboBusqueda";
            this.ComboBusqueda.Size = new System.Drawing.Size(121, 21);
            this.ComboBusqueda.TabIndex = 79;
            // 
            // LblBuscarPor
            // 
            this.LblBuscarPor.AutoSize = true;
            this.LblBuscarPor.BackColor = System.Drawing.Color.White;
            this.LblBuscarPor.Location = new System.Drawing.Point(494, 34);
            this.LblBuscarPor.Name = "LblBuscarPor";
            this.LblBuscarPor.Size = new System.Drawing.Size(61, 13);
            this.LblBuscarPor.TabIndex = 83;
            this.LblBuscarPor.Text = "Buscar por:";
            // 
            // LblListaClientes
            // 
            this.LblListaClientes.BackColor = System.Drawing.Color.White;
            this.LblListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblListaClientes.Location = new System.Drawing.Point(215, 17);
            this.LblListaClientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblListaClientes.Name = "LblListaClientes";
            this.LblListaClientes.Padding = new System.Windows.Forms.Padding(2);
            this.LblListaClientes.Size = new System.Drawing.Size(760, 40);
            this.LblListaClientes.TabIndex = 84;
            this.LblListaClientes.Text = "Lista de Clientes";
            this.LblListaClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnSeleccionar,
            this.idCliente,
            this.Nombre,
            this.Apellido,
            this.Documento,
            this.Direccion,
            this.Telefono1,
            this.Telefono2,
            this.Correo,
            this.TipoPers,
            this.Activo});
            this.dgvData.Location = new System.Drawing.Point(216, 73);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(759, 384);
            this.dgvData.TabIndex = 82;
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
            // idCliente
            // 
            this.idCliente.HeaderText = "idCliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombres";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellidos";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 150;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 150;
            // 
            // Telefono1
            // 
            this.Telefono1.HeaderText = "Telefono1";
            this.Telefono1.Name = "Telefono1";
            this.Telefono1.ReadOnly = true;
            this.Telefono1.Visible = false;
            // 
            // Telefono2
            // 
            this.Telefono2.HeaderText = "Telefono2";
            this.Telefono2.Name = "Telefono2";
            this.Telefono2.ReadOnly = true;
            this.Telefono2.Visible = false;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Visible = false;
            // 
            // TipoPers
            // 
            this.TipoPers.HeaderText = "TipoPers";
            this.TipoPers.Name = "TipoPers";
            this.TipoPers.ReadOnly = true;
            this.TipoPers.Visible = false;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupTipoPersona
            // 
            this.groupTipoPersona.BackColor = System.Drawing.Color.White;
            this.groupTipoPersona.Controls.Add(this.radioButtonJuridica);
            this.groupTipoPersona.Controls.Add(this.radioButtonFisica);
            this.groupTipoPersona.Location = new System.Drawing.Point(12, 336);
            this.groupTipoPersona.Name = "groupTipoPersona";
            this.groupTipoPersona.Size = new System.Drawing.Size(174, 73);
            this.groupTipoPersona.TabIndex = 72;
            this.groupTipoPersona.TabStop = false;
            this.groupTipoPersona.Text = "Tipo Persona";
            // 
            // radioButtonJuridica
            // 
            this.radioButtonJuridica.AutoSize = true;
            this.radioButtonJuridica.Location = new System.Drawing.Point(3, 39);
            this.radioButtonJuridica.Name = "radioButtonJuridica";
            this.radioButtonJuridica.Size = new System.Drawing.Size(63, 17);
            this.radioButtonJuridica.TabIndex = 1;
            this.radioButtonJuridica.Text = "Jurídica";
            this.radioButtonJuridica.UseVisualStyleBackColor = true;
            // 
            // radioButtonFisica
            // 
            this.radioButtonFisica.AutoSize = true;
            this.radioButtonFisica.Checked = true;
            this.radioButtonFisica.Location = new System.Drawing.Point(3, 16);
            this.radioButtonFisica.Name = "radioButtonFisica";
            this.radioButtonFisica.Size = new System.Drawing.Size(54, 17);
            this.radioButtonFisica.TabIndex = 0;
            this.radioButtonFisica.TabStop = true;
            this.radioButtonFisica.Text = "Física";
            this.radioButtonFisica.UseVisualStyleBackColor = true;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(11, 147);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(173, 20);
            this.TxtApellidos.TabIndex = 67;
            this.TxtApellidos.Validating += new System.ComponentModel.CancelEventHandler(this.TxtApellidos_Validating);
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.BackColor = System.Drawing.Color.White;
            this.LblApellidos.Location = new System.Drawing.Point(8, 130);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(52, 13);
            this.LblApellidos.TabIndex = 60;
            this.LblApellidos.Text = "Apellidos:";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1078, 532);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.LblApellidos);
            this.Controls.Add(this.groupTipoPersona);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.ComboBusqueda);
            this.Controls.Add(this.LblBuscarPor);
            this.Controls.Add(this.LblListaClientes);
            this.Controls.Add(this.TxtIndex);
            this.Controls.Add(this.TxtIdCliente);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblDetalleCliente);
            this.Controls.Add(this.ChkActivo);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtTelefono2);
            this.Controls.Add(this.TxtTelefono1);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtDocumento);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblCorreo);
            this.Controls.Add(this.LblTelefono2);
            this.Controls.Add(this.LblTelefono1);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.LblDocumento);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupTipoPersona.ResumeLayout(false);
            this.groupTipoPersona.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIndex;
        private System.Windows.Forms.TextBox TxtIdCliente;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.Label LblDetalleCliente;
        private System.Windows.Forms.CheckBox ChkActivo;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtTelefono2;
        private System.Windows.Forms.TextBox TxtTelefono1;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.Label LblTelefono2;
        private System.Windows.Forms.Label LblTelefono1;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblDocumento;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.ComboBox ComboBusqueda;
        private System.Windows.Forms.Label LblBuscarPor;
        private System.Windows.Forms.Label LblListaClientes;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox groupTipoPersona;
        private System.Windows.Forms.RadioButton radioButtonJuridica;
        private System.Windows.Forms.RadioButton radioButtonFisica;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.DataGridViewButtonColumn BtnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TipoPers;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
    }
}
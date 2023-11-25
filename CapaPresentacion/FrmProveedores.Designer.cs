namespace CapaPresentacion
{
    partial class FrmProveedores
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
            this.TxtIdProveedor = new System.Windows.Forms.TextBox();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.LblDetalleProveedor = new System.Windows.Forms.Label();
            this.ChkActivo = new System.Windows.Forms.CheckBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtTelefono2 = new System.Windows.Forms.TextBox();
            this.TxtTelefono1 = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtRUC = new System.Windows.Forms.TextBox();
            this.TxtContacto = new System.Windows.Forms.TextBox();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.LblTelefono2 = new System.Windows.Forms.Label();
            this.LblTelefono1 = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblRUC = new System.Windows.Forms.Label();
            this.LblContacto = new System.Windows.Forms.Label();
            this.LblRazonSocial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.ComboBusqueda = new System.Windows.Forms.ComboBox();
            this.LblBuscarPor = new System.Windows.Forms.Label();
            this.LblListaProveedores = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.BtnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.TxtContacto2 = new System.Windows.Forms.TextBox();
            this.LblContacto2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtIndex
            // 
            this.TxtIndex.Location = new System.Drawing.Point(127, 56);
            this.TxtIndex.Name = "TxtIndex";
            this.TxtIndex.Size = new System.Drawing.Size(26, 20);
            this.TxtIndex.TabIndex = 54;
            this.TxtIndex.Text = "-1";
            this.TxtIndex.Visible = false;
            // 
            // TxtIdProveedor
            // 
            this.TxtIdProveedor.Location = new System.Drawing.Point(159, 56);
            this.TxtIdProveedor.Name = "TxtIdProveedor";
            this.TxtIdProveedor.Size = new System.Drawing.Size(26, 20);
            this.TxtIdProveedor.TabIndex = 52;
            this.TxtIdProveedor.Text = "0";
            this.TxtIdProveedor.Visible = false;
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
            this.BtnEditar.Location = new System.Drawing.Point(12, 475);
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
            this.BtnGuardar.Location = new System.Drawing.Point(12, 443);
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
            // LblDetalleProveedor
            // 
            this.LblDetalleProveedor.AutoSize = true;
            this.LblDetalleProveedor.BackColor = System.Drawing.Color.White;
            this.LblDetalleProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDetalleProveedor.Location = new System.Drawing.Point(11, 21);
            this.LblDetalleProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDetalleProveedor.Name = "LblDetalleProveedor";
            this.LblDetalleProveedor.Size = new System.Drawing.Size(135, 20);
            this.LblDetalleProveedor.TabIndex = 49;
            this.LblDetalleProveedor.Text = "Detalle Proveedor";
            // 
            // ChkActivo
            // 
            this.ChkActivo.AutoSize = true;
            this.ChkActivo.BackColor = System.Drawing.Color.White;
            this.ChkActivo.Checked = true;
            this.ChkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkActivo.Location = new System.Drawing.Point(12, 394);
            this.ChkActivo.Name = "ChkActivo";
            this.ChkActivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkActivo.Size = new System.Drawing.Size(56, 17);
            this.ChkActivo.TabIndex = 49;
            this.ChkActivo.Text = "Activo";
            this.ChkActivo.UseVisualStyleBackColor = false;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(12, 368);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(173, 20);
            this.TxtCorreo.TabIndex = 48;
            this.TxtCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCorreo_Validating);
            // 
            // TxtTelefono2
            // 
            this.TxtTelefono2.Location = new System.Drawing.Point(12, 328);
            this.TxtTelefono2.Name = "TxtTelefono2";
            this.TxtTelefono2.Size = new System.Drawing.Size(173, 20);
            this.TxtTelefono2.TabIndex = 47;
            // 
            // TxtTelefono1
            // 
            this.TxtTelefono1.Location = new System.Drawing.Point(12, 288);
            this.TxtTelefono1.Name = "TxtTelefono1";
            this.TxtTelefono1.Size = new System.Drawing.Size(173, 20);
            this.TxtTelefono1.TabIndex = 46;
            this.TxtTelefono1.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTelefono1_Validating);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(12, 248);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(173, 20);
            this.TxtDireccion.TabIndex = 45;
            this.TxtDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDireccion_Validating);
            // 
            // TxtRUC
            // 
            this.TxtRUC.Location = new System.Drawing.Point(12, 80);
            this.TxtRUC.Name = "TxtRUC";
            this.TxtRUC.Size = new System.Drawing.Size(173, 20);
            this.TxtRUC.TabIndex = 41;
            this.TxtRUC.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDocumento_Validating);
            // 
            // TxtContacto
            // 
            this.TxtContacto.Location = new System.Drawing.Point(12, 162);
            this.TxtContacto.Name = "TxtContacto";
            this.TxtContacto.Size = new System.Drawing.Size(173, 20);
            this.TxtContacto.TabIndex = 43;
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Location = new System.Drawing.Point(12, 120);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.Size = new System.Drawing.Size(173, 20);
            this.TxtRazonSocial.TabIndex = 42;
            this.TxtRazonSocial.Validating += new System.ComponentModel.CancelEventHandler(this.TxtRazonSocial_Validating);
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.BackColor = System.Drawing.Color.White;
            this.LblCorreo.Location = new System.Drawing.Point(9, 351);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(41, 13);
            this.LblCorreo.TabIndex = 40;
            this.LblCorreo.Text = "Correo:";
            // 
            // LblTelefono2
            // 
            this.LblTelefono2.AutoSize = true;
            this.LblTelefono2.BackColor = System.Drawing.Color.White;
            this.LblTelefono2.Location = new System.Drawing.Point(9, 311);
            this.LblTelefono2.Name = "LblTelefono2";
            this.LblTelefono2.Size = new System.Drawing.Size(61, 13);
            this.LblTelefono2.TabIndex = 39;
            this.LblTelefono2.Text = "Teléfono 2:";
            // 
            // LblTelefono1
            // 
            this.LblTelefono1.AutoSize = true;
            this.LblTelefono1.BackColor = System.Drawing.Color.White;
            this.LblTelefono1.Location = new System.Drawing.Point(9, 271);
            this.LblTelefono1.Name = "LblTelefono1";
            this.LblTelefono1.Size = new System.Drawing.Size(61, 13);
            this.LblTelefono1.TabIndex = 38;
            this.LblTelefono1.Text = "Teléfono 1:";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.BackColor = System.Drawing.Color.White;
            this.LblDireccion.Location = new System.Drawing.Point(9, 232);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(55, 13);
            this.LblDireccion.TabIndex = 36;
            this.LblDireccion.Text = "Dirección:";
            // 
            // LblRUC
            // 
            this.LblRUC.AutoSize = true;
            this.LblRUC.BackColor = System.Drawing.Color.White;
            this.LblRUC.Location = new System.Drawing.Point(9, 63);
            this.LblRUC.Name = "LblRUC";
            this.LblRUC.Size = new System.Drawing.Size(33, 13);
            this.LblRUC.TabIndex = 35;
            this.LblRUC.Text = "RUC:";
            // 
            // LblContacto
            // 
            this.LblContacto.AutoSize = true;
            this.LblContacto.BackColor = System.Drawing.Color.White;
            this.LblContacto.Location = new System.Drawing.Point(9, 145);
            this.LblContacto.Name = "LblContacto";
            this.LblContacto.Size = new System.Drawing.Size(62, 13);
            this.LblContacto.TabIndex = 34;
            this.LblContacto.Text = "Contacto 1:";
            // 
            // LblRazonSocial
            // 
            this.LblRazonSocial.AutoSize = true;
            this.LblRazonSocial.BackColor = System.Drawing.Color.White;
            this.LblRazonSocial.Location = new System.Drawing.Point(9, 103);
            this.LblRazonSocial.Name = "LblRazonSocial";
            this.LblRazonSocial.Size = new System.Drawing.Size(73, 13);
            this.LblRazonSocial.TabIndex = 33;
            this.LblRazonSocial.Text = "Razón Social:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 575);
            this.label1.TabIndex = 32;
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
            this.BtnBuscar.Location = new System.Drawing.Point(839, 31);
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
            this.TxtBusqueda.Location = new System.Drawing.Point(679, 35);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(155, 20);
            this.TxtBusqueda.TabIndex = 55;
            // 
            // ComboBusqueda
            // 
            this.ComboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBusqueda.FormattingEnabled = true;
            this.ComboBusqueda.Location = new System.Drawing.Point(552, 35);
            this.ComboBusqueda.Name = "ComboBusqueda";
            this.ComboBusqueda.Size = new System.Drawing.Size(121, 21);
            this.ComboBusqueda.TabIndex = 58;
            // 
            // LblBuscarPor
            // 
            this.LblBuscarPor.AutoSize = true;
            this.LblBuscarPor.BackColor = System.Drawing.Color.White;
            this.LblBuscarPor.Location = new System.Drawing.Point(485, 38);
            this.LblBuscarPor.Name = "LblBuscarPor";
            this.LblBuscarPor.Size = new System.Drawing.Size(61, 13);
            this.LblBuscarPor.TabIndex = 57;
            this.LblBuscarPor.Text = "Buscar por:";
            // 
            // LblListaProveedores
            // 
            this.LblListaProveedores.BackColor = System.Drawing.Color.White;
            this.LblListaProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblListaProveedores.Location = new System.Drawing.Point(210, 21);
            this.LblListaProveedores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblListaProveedores.Name = "LblListaProveedores";
            this.LblListaProveedores.Padding = new System.Windows.Forms.Padding(2);
            this.LblListaProveedores.Size = new System.Drawing.Size(760, 40);
            this.LblListaProveedores.TabIndex = 56;
            this.LblListaProveedores.Text = "Lista de Proveedores";
            this.LblListaProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.idProveedor,
            this.RazonSocial,
            this.Documento,
            this.Contacto,
            this.Contacto2,
            this.Direccion,
            this.Telefono1,
            this.Telefono2,
            this.Correo,
            this.Activo});
            this.dgvData.Location = new System.Drawing.Point(211, 82);
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
            this.dgvData.Size = new System.Drawing.Size(759, 384);
            this.dgvData.TabIndex = 61;
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
            // idProveedor
            // 
            this.idProveedor.HeaderText = "idProveedor";
            this.idProveedor.Name = "idProveedor";
            this.idProveedor.ReadOnly = true;
            this.idProveedor.Visible = false;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razón Social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            this.RazonSocial.Width = 150;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "RUC";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // Contacto
            // 
            this.Contacto.HeaderText = "Contacto";
            this.Contacto.Name = "Contacto";
            this.Contacto.ReadOnly = true;
            this.Contacto.Width = 150;
            // 
            // Contacto2
            // 
            this.Contacto2.HeaderText = "Contacto2";
            this.Contacto2.Name = "Contacto2";
            this.Contacto2.ReadOnly = true;
            this.Contacto2.Visible = false;
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
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.BtnLimpiar.Location = new System.Drawing.Point(886, 31);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(43, 26);
            this.BtnLimpiar.TabIndex = 60;
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // TxtContacto2
            // 
            this.TxtContacto2.Location = new System.Drawing.Point(12, 205);
            this.TxtContacto2.Name = "TxtContacto2";
            this.TxtContacto2.Size = new System.Drawing.Size(173, 20);
            this.TxtContacto2.TabIndex = 44;
            // 
            // LblContacto2
            // 
            this.LblContacto2.AutoSize = true;
            this.LblContacto2.BackColor = System.Drawing.Color.White;
            this.LblContacto2.Location = new System.Drawing.Point(9, 188);
            this.LblContacto2.Name = "LblContacto2";
            this.LblContacto2.Size = new System.Drawing.Size(62, 13);
            this.LblContacto2.TabIndex = 62;
            this.LblContacto2.Text = "Contacto 2:";
            // 
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1148, 575);
            this.Controls.Add(this.TxtContacto2);
            this.Controls.Add(this.LblContacto2);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.ComboBusqueda);
            this.Controls.Add(this.LblBuscarPor);
            this.Controls.Add(this.LblListaProveedores);
            this.Controls.Add(this.TxtIndex);
            this.Controls.Add(this.TxtIdProveedor);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblDetalleProveedor);
            this.Controls.Add(this.ChkActivo);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtTelefono2);
            this.Controls.Add(this.TxtTelefono1);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtRUC);
            this.Controls.Add(this.TxtContacto);
            this.Controls.Add(this.TxtRazonSocial);
            this.Controls.Add(this.LblCorreo);
            this.Controls.Add(this.LblTelefono2);
            this.Controls.Add(this.LblTelefono1);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.LblRUC);
            this.Controls.Add(this.LblContacto);
            this.Controls.Add(this.LblRazonSocial);
            this.Controls.Add(this.label1);
            this.Name = "FrmProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FrmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIndex;
        private System.Windows.Forms.TextBox TxtIdProveedor;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.Label LblDetalleProveedor;
        private System.Windows.Forms.CheckBox ChkActivo;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtTelefono2;
        private System.Windows.Forms.TextBox TxtTelefono1;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtRUC;
        private System.Windows.Forms.TextBox TxtContacto;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.Label LblTelefono2;
        private System.Windows.Forms.Label LblTelefono1;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblRUC;
        private System.Windows.Forms.Label LblContacto;
        private System.Windows.Forms.Label LblRazonSocial;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.ComboBox ComboBusqueda;
        private System.Windows.Forms.Label LblBuscarPor;
        private System.Windows.Forms.Label LblListaProveedores;
        private System.Windows.Forms.DataGridView dgvData;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private System.Windows.Forms.TextBox TxtContacto2;
        private System.Windows.Forms.Label LblContacto2;
        private System.Windows.Forms.DataGridViewButtonColumn BtnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
    }
}
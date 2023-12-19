namespace CapaPresentacion
{
    partial class FrmRegistrarVenta
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
            this.components = new System.ComponentModel.Container();
            this.LblPedidos = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxInfoPedido = new System.Windows.Forms.GroupBox();
            this.TxtDoc = new System.Windows.Forms.TextBox();
            this.TxtPuntoEmision = new System.Windows.Forms.TextBox();
            this.LblCodEstablecimiento = new System.Windows.Forms.Label();
            this.TxtCodEstablecimiento = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new FontAwesome.Sharp.IconButton();
            this.dtpFechaVenc = new System.Windows.Forms.DateTimePicker();
            this.LblFechaVencimiento = new System.Windows.Forms.Label();
            this.dtpFinVigencia = new System.Windows.Forms.DateTimePicker();
            this.LblFinVigencia = new System.Windows.Forms.Label();
            this.dtpInicioVigencia = new System.Windows.Forms.DateTimePicker();
            this.LblInicioVigencia = new System.Windows.Forms.Label();
            this.TxtTimbrado = new System.Windows.Forms.TextBox();
            this.LblTimbrado = new System.Windows.Forms.Label();
            this.TxtNroCaja = new System.Windows.Forms.TextBox();
            this.LblNroCaja = new System.Windows.Forms.Label();
            this.TxtCajero = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.groupBoxInfoProductos = new System.Windows.Forms.GroupBox();
            this.TxtUnidadMedida = new System.Windows.Forms.TextBox();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.iconButtonCodProducto = new FontAwesome.Sharp.IconButton();
            this.textBoxCodProducto = new System.Windows.Forms.TextBox();
            this.LblProducto = new System.Windows.Forms.Label();
            this.LblCodProducto = new System.Windows.Forms.Label();
            this.groupBoxInfoVenta = new System.Windows.Forms.GroupBox();
            this.ComboFormaPago = new System.Windows.Forms.ComboBox();
            this.LblFormaPago = new System.Windows.Forms.Label();
            this.ComboTipoDoc = new System.Windows.Forms.ComboBox();
            this.FechaVenta = new System.Windows.Forms.DateTimePicker();
            this.LblTipoDocumento = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.groupBoxInfoCliente = new System.Windows.Forms.GroupBox();
            this.BtnAddCliente = new FontAwesome.Sharp.IconButton();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.LblRazonSocial = new System.Windows.Forms.Label();
            this.BtnBuscarCliente = new FontAwesome.Sharp.IconButton();
            this.TxtRUC = new System.Windows.Forms.TextBox();
            this.LblNroDocumento = new System.Windows.Forms.Label();
            this.TimerNow = new System.Windows.Forms.Timer(this.components);
            this.LblHoraActual = new System.Windows.Forms.Label();
            this.LblMoneda = new System.Windows.Forms.Label();
            this.LblTotalPagar = new System.Windows.Forms.Label();
            this.textBoxTotalPagar = new System.Windows.Forms.TextBox();
            this.BtnCobro = new FontAwesome.Sharp.IconButton();
            this.BtnImprimirFactura = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBoxInfoPedido.SuspendLayout();
            this.groupBoxInfoProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.groupBoxInfoVenta.SuspendLayout();
            this.groupBoxInfoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblPedidos
            // 
            this.LblPedidos.BackColor = System.Drawing.Color.White;
            this.LblPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPedidos.Location = new System.Drawing.Point(2, 4);
            this.LblPedidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPedidos.Name = "LblPedidos";
            this.LblPedidos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LblPedidos.Size = new System.Drawing.Size(1260, 577);
            this.LblPedidos.TabIndex = 26;
            this.LblPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.CodProducto,
            this.Descripcion,
            this.Cantidad,
            this.Unidad,
            this.Precio,
            this.SubTotal,
            this.BtnEliminar});
            this.dgvData.Location = new System.Drawing.Point(19, 298);
            this.dgvData.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.Size = new System.Drawing.Size(674, 257);
            this.dgvData.TabIndex = 80;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.MinimumWidth = 8;
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            this.idProducto.Width = 180;
            // 
            // CodProducto
            // 
            this.CodProducto.HeaderText = "Cod. Producto";
            this.CodProducto.MinimumWidth = 8;
            this.CodProducto.Name = "CodProducto";
            this.CodProducto.ReadOnly = true;
            this.CodProducto.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción Producto";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 300;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 150;
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.MinimumWidth = 9;
            this.Unidad.Name = "Unidad";
            this.Unidad.ReadOnly = true;
            this.Unidad.Width = 175;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 8;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 150;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.MinimumWidth = 8;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 150;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.HeaderText = "";
            this.BtnEliminar.MinimumWidth = 8;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.ReadOnly = true;
            this.BtnEliminar.Width = 30;
            // 
            // groupBoxInfoPedido
            // 
            this.groupBoxInfoPedido.BackColor = System.Drawing.Color.White;
            this.groupBoxInfoPedido.Controls.Add(this.TxtDoc);
            this.groupBoxInfoPedido.Controls.Add(this.TxtPuntoEmision);
            this.groupBoxInfoPedido.Controls.Add(this.LblCodEstablecimiento);
            this.groupBoxInfoPedido.Controls.Add(this.TxtCodEstablecimiento);
            this.groupBoxInfoPedido.Controls.Add(this.BtnAgregar);
            this.groupBoxInfoPedido.Controls.Add(this.dtpFechaVenc);
            this.groupBoxInfoPedido.Controls.Add(this.LblFechaVencimiento);
            this.groupBoxInfoPedido.Controls.Add(this.dtpFinVigencia);
            this.groupBoxInfoPedido.Controls.Add(this.LblFinVigencia);
            this.groupBoxInfoPedido.Controls.Add(this.dtpInicioVigencia);
            this.groupBoxInfoPedido.Controls.Add(this.LblInicioVigencia);
            this.groupBoxInfoPedido.Controls.Add(this.TxtTimbrado);
            this.groupBoxInfoPedido.Controls.Add(this.LblTimbrado);
            this.groupBoxInfoPedido.Controls.Add(this.TxtNroCaja);
            this.groupBoxInfoPedido.Controls.Add(this.LblNroCaja);
            this.groupBoxInfoPedido.Controls.Add(this.TxtCajero);
            this.groupBoxInfoPedido.Controls.Add(this.LblUsuario);
            this.groupBoxInfoPedido.Controls.Add(this.groupBoxInfoProductos);
            this.groupBoxInfoPedido.Controls.Add(this.groupBoxInfoVenta);
            this.groupBoxInfoPedido.Controls.Add(this.groupBoxInfoCliente);
            this.groupBoxInfoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoPedido.Location = new System.Drawing.Point(10, 12);
            this.groupBoxInfoPedido.Name = "groupBoxInfoPedido";
            this.groupBoxInfoPedido.Size = new System.Drawing.Size(1181, 280);
            this.groupBoxInfoPedido.TabIndex = 88;
            this.groupBoxInfoPedido.TabStop = false;
            this.groupBoxInfoPedido.Text = "Registrar Venta";
            // 
            // TxtDoc
            // 
            this.TxtDoc.Enabled = false;
            this.TxtDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDoc.Location = new System.Drawing.Point(523, 143);
            this.TxtDoc.Name = "TxtDoc";
            this.TxtDoc.Size = new System.Drawing.Size(129, 21);
            this.TxtDoc.TabIndex = 119;
            // 
            // TxtPuntoEmision
            // 
            this.TxtPuntoEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPuntoEmision.Location = new System.Drawing.Point(482, 143);
            this.TxtPuntoEmision.Name = "TxtPuntoEmision";
            this.TxtPuntoEmision.Size = new System.Drawing.Size(35, 21);
            this.TxtPuntoEmision.TabIndex = 118;
            // 
            // LblCodEstablecimiento
            // 
            this.LblCodEstablecimiento.AutoSize = true;
            this.LblCodEstablecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodEstablecimiento.Location = new System.Drawing.Point(438, 129);
            this.LblCodEstablecimiento.Name = "LblCodEstablecimiento";
            this.LblCodEstablecimiento.Size = new System.Drawing.Size(46, 13);
            this.LblCodEstablecimiento.TabIndex = 117;
            this.LblCodEstablecimiento.Text = "Factura:";
            // 
            // TxtCodEstablecimiento
            // 
            this.TxtCodEstablecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodEstablecimiento.Location = new System.Drawing.Point(441, 143);
            this.TxtCodEstablecimiento.Name = "TxtCodEstablecimiento";
            this.TxtCodEstablecimiento.Size = new System.Drawing.Size(35, 21);
            this.TxtCodEstablecimiento.TabIndex = 116;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.BtnAgregar.IconColor = System.Drawing.Color.Black;
            this.BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAgregar.Location = new System.Drawing.Point(970, 196);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(82, 72);
            this.BtnAgregar.TabIndex = 69;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // dtpFechaVenc
            // 
            this.dtpFechaVenc.Enabled = false;
            this.dtpFechaVenc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVenc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVenc.Location = new System.Drawing.Point(700, 144);
            this.dtpFechaVenc.Name = "dtpFechaVenc";
            this.dtpFechaVenc.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaVenc.TabIndex = 115;
            this.dtpFechaVenc.Value = new System.DateTime(2023, 11, 29, 0, 0, 0, 0);
            // 
            // LblFechaVencimiento
            // 
            this.LblFechaVencimiento.AutoSize = true;
            this.LblFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaVencimiento.Location = new System.Drawing.Point(697, 129);
            this.LblFechaVencimiento.Name = "LblFechaVencimiento";
            this.LblFechaVencimiento.Size = new System.Drawing.Size(101, 13);
            this.LblFechaVencimiento.TabIndex = 114;
            this.LblFechaVencimiento.Text = "Fecha Vencimiento:";
            // 
            // dtpFinVigencia
            // 
            this.dtpFinVigencia.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinVigencia.Location = new System.Drawing.Point(267, 145);
            this.dtpFinVigencia.Name = "dtpFinVigencia";
            this.dtpFinVigencia.Size = new System.Drawing.Size(100, 21);
            this.dtpFinVigencia.TabIndex = 111;
            this.dtpFinVigencia.Value = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            // 
            // LblFinVigencia
            // 
            this.LblFinVigencia.AutoSize = true;
            this.LblFinVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFinVigencia.Location = new System.Drawing.Point(264, 129);
            this.LblFinVigencia.Name = "LblFinVigencia";
            this.LblFinVigencia.Size = new System.Drawing.Size(83, 13);
            this.LblFinVigencia.TabIndex = 110;
            this.LblFinVigencia.Text = "Fin de Vigencia:";
            // 
            // dtpInicioVigencia
            // 
            this.dtpInicioVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicioVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioVigencia.Location = new System.Drawing.Point(153, 145);
            this.dtpInicioVigencia.Name = "dtpInicioVigencia";
            this.dtpInicioVigencia.Size = new System.Drawing.Size(100, 20);
            this.dtpInicioVigencia.TabIndex = 109;
            this.dtpInicioVigencia.Value = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            // 
            // LblInicioVigencia
            // 
            this.LblInicioVigencia.AutoSize = true;
            this.LblInicioVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInicioVigencia.Location = new System.Drawing.Point(150, 129);
            this.LblInicioVigencia.Name = "LblInicioVigencia";
            this.LblInicioVigencia.Size = new System.Drawing.Size(94, 13);
            this.LblInicioVigencia.TabIndex = 108;
            this.LblInicioVigencia.Text = "Inicio de Vigencia:";
            // 
            // TxtTimbrado
            // 
            this.TxtTimbrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTimbrado.Location = new System.Drawing.Point(8, 145);
            this.TxtTimbrado.Name = "TxtTimbrado";
            this.TxtTimbrado.Size = new System.Drawing.Size(131, 21);
            this.TxtTimbrado.TabIndex = 107;
            // 
            // LblTimbrado
            // 
            this.LblTimbrado.AutoSize = true;
            this.LblTimbrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimbrado.Location = new System.Drawing.Point(6, 129);
            this.LblTimbrado.Name = "LblTimbrado";
            this.LblTimbrado.Size = new System.Drawing.Size(54, 13);
            this.LblTimbrado.TabIndex = 106;
            this.LblTimbrado.Text = "Timbrado:";
            // 
            // TxtNroCaja
            // 
            this.TxtNroCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNroCaja.Location = new System.Drawing.Point(1006, 143);
            this.TxtNroCaja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNroCaja.Name = "TxtNroCaja";
            this.TxtNroCaja.Size = new System.Drawing.Size(139, 21);
            this.TxtNroCaja.TabIndex = 105;
            // 
            // LblNroCaja
            // 
            this.LblNroCaja.AutoSize = true;
            this.LblNroCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNroCaja.Location = new System.Drawing.Point(1006, 128);
            this.LblNroCaja.Name = "LblNroCaja";
            this.LblNroCaja.Size = new System.Drawing.Size(54, 13);
            this.LblNroCaja.TabIndex = 104;
            this.LblNroCaja.Text = "Nro. Caja:";
            // 
            // TxtCajero
            // 
            this.TxtCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCajero.Location = new System.Drawing.Point(847, 144);
            this.TxtCajero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtCajero.Name = "TxtCajero";
            this.TxtCajero.Size = new System.Drawing.Size(139, 21);
            this.TxtCajero.TabIndex = 103;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(844, 129);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(40, 13);
            this.LblUsuario.TabIndex = 102;
            this.LblUsuario.Text = "Cajero:";
            // 
            // groupBoxInfoProductos
            // 
            this.groupBoxInfoProductos.BackColor = System.Drawing.Color.White;
            this.groupBoxInfoProductos.Controls.Add(this.TxtUnidadMedida);
            this.groupBoxInfoProductos.Controls.Add(this.TxtIdProducto);
            this.groupBoxInfoProductos.Controls.Add(this.textBoxPrecio);
            this.groupBoxInfoProductos.Controls.Add(this.LblPrecio);
            this.groupBoxInfoProductos.Controls.Add(this.numericUpDownCantidad);
            this.groupBoxInfoProductos.Controls.Add(this.LblCantidad);
            this.groupBoxInfoProductos.Controls.Add(this.TxtProducto);
            this.groupBoxInfoProductos.Controls.Add(this.iconButtonCodProducto);
            this.groupBoxInfoProductos.Controls.Add(this.textBoxCodProducto);
            this.groupBoxInfoProductos.Controls.Add(this.LblProducto);
            this.groupBoxInfoProductos.Controls.Add(this.LblCodProducto);
            this.groupBoxInfoProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoProductos.Location = new System.Drawing.Point(9, 182);
            this.groupBoxInfoProductos.Name = "groupBoxInfoProductos";
            this.groupBoxInfoProductos.Size = new System.Drawing.Size(955, 86);
            this.groupBoxInfoProductos.TabIndex = 29;
            this.groupBoxInfoProductos.TabStop = false;
            this.groupBoxInfoProductos.Text = "Informacion del Producto";
            // 
            // TxtUnidadMedida
            // 
            this.TxtUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUnidadMedida.Location = new System.Drawing.Point(898, 44);
            this.TxtUnidadMedida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtUnidadMedida.Name = "TxtUnidadMedida";
            this.TxtUnidadMedida.ReadOnly = true;
            this.TxtUnidadMedida.Size = new System.Drawing.Size(52, 21);
            this.TxtUnidadMedida.TabIndex = 75;
            this.TxtUnidadMedida.Visible = false;
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdProducto.Location = new System.Drawing.Point(110, 18);
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.Size = new System.Drawing.Size(20, 20);
            this.TxtIdProducto.TabIndex = 74;
            this.TxtIdProducto.Text = "0";
            this.TxtIdProducto.Visible = false;
            this.TxtIdProducto.TextChanged += new System.EventHandler(this.TxtIdProducto_TextChanged);
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Enabled = false;
            this.textBoxPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecio.Location = new System.Drawing.Point(741, 44);
            this.textBoxPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.ReadOnly = true;
            this.textBoxPrecio.Size = new System.Drawing.Size(147, 21);
            this.textBoxPrecio.TabIndex = 71;
            this.textBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecio_KeyPress);
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.Location = new System.Drawing.Point(738, 25);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(40, 13);
            this.LblPrecio.TabIndex = 70;
            this.LblPrecio.Text = "Precio:";
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCantidad.Location = new System.Drawing.Point(625, 44);
            this.numericUpDownCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(60, 21);
            this.numericUpDownCantidad.TabIndex = 68;
            this.numericUpDownCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(622, 27);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(52, 13);
            this.LblCantidad.TabIndex = 67;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // TxtProducto
            // 
            this.TxtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProducto.Location = new System.Drawing.Point(200, 43);
            this.TxtProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.ReadOnly = true;
            this.TxtProducto.Size = new System.Drawing.Size(391, 21);
            this.TxtProducto.TabIndex = 64;
            // 
            // iconButtonCodProducto
            // 
            this.iconButtonCodProducto.BackColor = System.Drawing.Color.White;
            this.iconButtonCodProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonCodProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButtonCodProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCodProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCodProducto.ForeColor = System.Drawing.Color.White;
            this.iconButtonCodProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButtonCodProducto.IconColor = System.Drawing.Color.Black;
            this.iconButtonCodProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCodProducto.IconSize = 16;
            this.iconButtonCodProducto.Location = new System.Drawing.Point(135, 36);
            this.iconButtonCodProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButtonCodProducto.Name = "iconButtonCodProducto";
            this.iconButtonCodProducto.Size = new System.Drawing.Size(61, 28);
            this.iconButtonCodProducto.TabIndex = 63;
            this.iconButtonCodProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonCodProducto.UseVisualStyleBackColor = false;
            this.iconButtonCodProducto.Click += new System.EventHandler(this.iconButtonCodProducto_Click);
            // 
            // textBoxCodProducto
            // 
            this.textBoxCodProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodProducto.Location = new System.Drawing.Point(10, 43);
            this.textBoxCodProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCodProducto.Name = "textBoxCodProducto";
            this.textBoxCodProducto.ReadOnly = true;
            this.textBoxCodProducto.Size = new System.Drawing.Size(121, 21);
            this.textBoxCodProducto.TabIndex = 62;
            this.textBoxCodProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCodProducto_KeyDown);
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.Location = new System.Drawing.Point(201, 27);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(112, 13);
            this.LblProducto.TabIndex = 61;
            this.LblProducto.Text = "Descripción Producto:";
            // 
            // LblCodProducto
            // 
            this.LblCodProducto.AutoSize = true;
            this.LblCodProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodProducto.Location = new System.Drawing.Point(7, 27);
            this.LblCodProducto.Name = "LblCodProducto";
            this.LblCodProducto.Size = new System.Drawing.Size(89, 13);
            this.LblCodProducto.TabIndex = 0;
            this.LblCodProducto.Text = "Código Producto:";
            // 
            // groupBoxInfoVenta
            // 
            this.groupBoxInfoVenta.BackColor = System.Drawing.Color.White;
            this.groupBoxInfoVenta.Controls.Add(this.ComboFormaPago);
            this.groupBoxInfoVenta.Controls.Add(this.LblFormaPago);
            this.groupBoxInfoVenta.Controls.Add(this.ComboTipoDoc);
            this.groupBoxInfoVenta.Controls.Add(this.FechaVenta);
            this.groupBoxInfoVenta.Controls.Add(this.LblTipoDocumento);
            this.groupBoxInfoVenta.Controls.Add(this.LblFecha);
            this.groupBoxInfoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoVenta.Location = new System.Drawing.Point(6, 25);
            this.groupBoxInfoVenta.Name = "groupBoxInfoVenta";
            this.groupBoxInfoVenta.Size = new System.Drawing.Size(511, 89);
            this.groupBoxInfoVenta.TabIndex = 28;
            this.groupBoxInfoVenta.TabStop = false;
            this.groupBoxInfoVenta.Text = "Informacion Venta";
            // 
            // ComboFormaPago
            // 
            this.ComboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboFormaPago.FormattingEnabled = true;
            this.ComboFormaPago.Location = new System.Drawing.Point(303, 43);
            this.ComboFormaPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboFormaPago.Name = "ComboFormaPago";
            this.ComboFormaPago.Size = new System.Drawing.Size(187, 23);
            this.ComboFormaPago.TabIndex = 102;
            this.ComboFormaPago.SelectedIndexChanged += new System.EventHandler(this.ComboFormaPago_SelectedIndexChanged);
            // 
            // LblFormaPago
            // 
            this.LblFormaPago.AutoSize = true;
            this.LblFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormaPago.Location = new System.Drawing.Point(300, 28);
            this.LblFormaPago.Name = "LblFormaPago";
            this.LblFormaPago.Size = new System.Drawing.Size(67, 13);
            this.LblFormaPago.TabIndex = 101;
            this.LblFormaPago.Text = "Forma Pago:";
            // 
            // ComboTipoDoc
            // 
            this.ComboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTipoDoc.FormattingEnabled = true;
            this.ComboTipoDoc.Location = new System.Drawing.Point(112, 42);
            this.ComboTipoDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboTipoDoc.Name = "ComboTipoDoc";
            this.ComboTipoDoc.Size = new System.Drawing.Size(177, 23);
            this.ComboTipoDoc.TabIndex = 29;
            this.ComboTipoDoc.SelectedIndexChanged += new System.EventHandler(this.ComboTipoDoc_SelectedIndexChanged);
            this.ComboTipoDoc.SelectedValueChanged += new System.EventHandler(this.ComboTipoDoc_SelectedValueChanged);
            // 
            // FechaVenta
            // 
            this.FechaVenta.Enabled = false;
            this.FechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaVenta.Location = new System.Drawing.Point(16, 43);
            this.FechaVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FechaVenta.Name = "FechaVenta";
            this.FechaVenta.Size = new System.Drawing.Size(83, 20);
            this.FechaVenta.TabIndex = 29;
            this.FechaVenta.Value = new System.DateTime(2023, 11, 28, 0, 0, 0, 0);
            // 
            // LblTipoDocumento
            // 
            this.LblTipoDocumento.AutoSize = true;
            this.LblTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoDocumento.Location = new System.Drawing.Point(109, 28);
            this.LblTipoDocumento.Name = "LblTipoDocumento";
            this.LblTipoDocumento.Size = new System.Drawing.Size(89, 13);
            this.LblTipoDocumento.TabIndex = 61;
            this.LblTipoDocumento.Text = "Tipo Documento:";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(13, 28);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(40, 13);
            this.LblFecha.TabIndex = 0;
            this.LblFecha.Text = "Fecha:";
            // 
            // groupBoxInfoCliente
            // 
            this.groupBoxInfoCliente.BackColor = System.Drawing.Color.White;
            this.groupBoxInfoCliente.Controls.Add(this.BtnAddCliente);
            this.groupBoxInfoCliente.Controls.Add(this.TxtIdCliente);
            this.groupBoxInfoCliente.Controls.Add(this.TxtRazonSocial);
            this.groupBoxInfoCliente.Controls.Add(this.LblRazonSocial);
            this.groupBoxInfoCliente.Controls.Add(this.BtnBuscarCliente);
            this.groupBoxInfoCliente.Controls.Add(this.TxtRUC);
            this.groupBoxInfoCliente.Controls.Add(this.LblNroDocumento);
            this.groupBoxInfoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoCliente.Location = new System.Drawing.Point(574, 25);
            this.groupBoxInfoCliente.Name = "groupBoxInfoCliente";
            this.groupBoxInfoCliente.Size = new System.Drawing.Size(498, 89);
            this.groupBoxInfoCliente.TabIndex = 27;
            this.groupBoxInfoCliente.TabStop = false;
            this.groupBoxInfoCliente.Text = "Informacion del Cliente";
            // 
            // BtnAddCliente
            // 
            this.BtnAddCliente.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAddCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddCliente.ForeColor = System.Drawing.Color.Black;
            this.BtnAddCliente.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.BtnAddCliente.IconColor = System.Drawing.Color.Black;
            this.BtnAddCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddCliente.IconSize = 46;
            this.BtnAddCliente.Location = new System.Drawing.Point(387, 12);
            this.BtnAddCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAddCliente.Name = "BtnAddCliente";
            this.BtnAddCliente.Size = new System.Drawing.Size(82, 72);
            this.BtnAddCliente.TabIndex = 64;
            this.BtnAddCliente.Text = "Nuevo Cliente";
            this.BtnAddCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAddCliente.UseVisualStyleBackColor = false;
            this.BtnAddCliente.Click += new System.EventHandler(this.BtnAddCliente_Click);
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Location = new System.Drawing.Point(133, 16);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(20, 21);
            this.TxtIdCliente.TabIndex = 63;
            this.TxtIdCliente.Text = "0";
            this.TxtIdCliente.Visible = false;
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRazonSocial.Location = new System.Drawing.Point(204, 41);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.ReadOnly = true;
            this.TxtRazonSocial.Size = new System.Drawing.Size(167, 21);
            this.TxtRazonSocial.TabIndex = 62;
            // 
            // LblRazonSocial
            // 
            this.LblRazonSocial.AutoSize = true;
            this.LblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRazonSocial.Location = new System.Drawing.Point(201, 26);
            this.LblRazonSocial.Name = "LblRazonSocial";
            this.LblRazonSocial.Size = new System.Drawing.Size(121, 13);
            this.LblRazonSocial.TabIndex = 61;
            this.LblRazonSocial.Text = "Nombre / Razón Social:";
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.BackColor = System.Drawing.Color.White;
            this.BtnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscarCliente.IconColor = System.Drawing.Color.Black;
            this.BtnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscarCliente.IconSize = 16;
            this.BtnBuscarCliente.Location = new System.Drawing.Point(156, 41);
            this.BtnBuscarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(43, 22);
            this.BtnBuscarCliente.TabIndex = 60;
            this.BtnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarCliente.UseVisualStyleBackColor = false;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // TxtRUC
            // 
            this.TxtRUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRUC.Location = new System.Drawing.Point(17, 42);
            this.TxtRUC.Name = "TxtRUC";
            this.TxtRUC.ReadOnly = true;
            this.TxtRUC.Size = new System.Drawing.Size(134, 21);
            this.TxtRUC.TabIndex = 1;
            // 
            // LblNroDocumento
            // 
            this.LblNroDocumento.AutoSize = true;
            this.LblNroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNroDocumento.Location = new System.Drawing.Point(14, 27);
            this.LblNroDocumento.Name = "LblNroDocumento";
            this.LblNroDocumento.Size = new System.Drawing.Size(105, 13);
            this.LblNroDocumento.TabIndex = 0;
            this.LblNroDocumento.Text = "Numero Documento:";
            // 
            // TimerNow
            // 
            this.TimerNow.Interval = 1000;
            // 
            // LblHoraActual
            // 
            this.LblHoraActual.AutoSize = true;
            this.LblHoraActual.BackColor = System.Drawing.Color.White;
            this.LblHoraActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHoraActual.Location = new System.Drawing.Point(1011, 54);
            this.LblHoraActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblHoraActual.Name = "LblHoraActual";
            this.LblHoraActual.Size = new System.Drawing.Size(0, 31);
            this.LblHoraActual.TabIndex = 89;
            // 
            // LblMoneda
            // 
            this.LblMoneda.AutoSize = true;
            this.LblMoneda.BackColor = System.Drawing.Color.White;
            this.LblMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMoneda.Location = new System.Drawing.Point(1088, 484);
            this.LblMoneda.Name = "LblMoneda";
            this.LblMoneda.Size = new System.Drawing.Size(42, 25);
            this.LblMoneda.TabIndex = 93;
            this.LblMoneda.Text = "Gs.";
            // 
            // LblTotalPagar
            // 
            this.LblTotalPagar.AutoSize = true;
            this.LblTotalPagar.BackColor = System.Drawing.Color.White;
            this.LblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalPagar.Location = new System.Drawing.Point(756, 450);
            this.LblTotalPagar.Name = "LblTotalPagar";
            this.LblTotalPagar.Size = new System.Drawing.Size(106, 20);
            this.LblTotalPagar.TabIndex = 81;
            this.LblTotalPagar.Text = "Total Pagar:";
            // 
            // textBoxTotalPagar
            // 
            this.textBoxTotalPagar.Enabled = false;
            this.textBoxTotalPagar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalPagar.Location = new System.Drawing.Point(759, 478);
            this.textBoxTotalPagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTotalPagar.Name = "textBoxTotalPagar";
            this.textBoxTotalPagar.Size = new System.Drawing.Size(315, 32);
            this.textBoxTotalPagar.TabIndex = 82;
            // 
            // BtnCobro
            // 
            this.BtnCobro.BackColor = System.Drawing.Color.Olive;
            this.BtnCobro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCobro.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCobro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCobro.ForeColor = System.Drawing.Color.White;
            this.BtnCobro.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.BtnCobro.IconColor = System.Drawing.Color.White;
            this.BtnCobro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCobro.Location = new System.Drawing.Point(1017, 308);
            this.BtnCobro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCobro.Name = "BtnCobro";
            this.BtnCobro.Size = new System.Drawing.Size(174, 48);
            this.BtnCobro.TabIndex = 94;
            this.BtnCobro.Text = "Medio de Cobro";
            this.BtnCobro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCobro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCobro.UseVisualStyleBackColor = false;
            this.BtnCobro.Click += new System.EventHandler(this.BtnCobro_Click);
            // 
            // BtnImprimirFactura
            // 
            this.BtnImprimirFactura.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnImprimirFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImprimirFactura.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnImprimirFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimirFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimirFactura.ForeColor = System.Drawing.Color.White;
            this.BtnImprimirFactura.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.BtnImprimirFactura.IconColor = System.Drawing.Color.White;
            this.BtnImprimirFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImprimirFactura.Location = new System.Drawing.Point(1017, 370);
            this.BtnImprimirFactura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnImprimirFactura.Name = "BtnImprimirFactura";
            this.BtnImprimirFactura.Size = new System.Drawing.Size(174, 48);
            this.BtnImprimirFactura.TabIndex = 95;
            this.BtnImprimirFactura.Text = "Generar Factura";
            this.BtnImprimirFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImprimirFactura.UseVisualStyleBackColor = false;
            this.BtnImprimirFactura.Click += new System.EventHandler(this.BtnImprimirFactura_Click);
            // 
            // FrmRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 406);
            this.Controls.Add(this.BtnImprimirFactura);
            this.Controls.Add(this.BtnCobro);
            this.Controls.Add(this.LblMoneda);
            this.Controls.Add(this.LblHoraActual);
            this.Controls.Add(this.groupBoxInfoPedido);
            this.Controls.Add(this.textBoxTotalPagar);
            this.Controls.Add(this.LblTotalPagar);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.LblPedidos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmRegistrarVenta";
            this.Text = "Registro de Venta";
            this.Load += new System.EventHandler(this.FrmRegistrarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBoxInfoPedido.ResumeLayout(false);
            this.groupBoxInfoPedido.PerformLayout();
            this.groupBoxInfoProductos.ResumeLayout(false);
            this.groupBoxInfoProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.groupBoxInfoVenta.ResumeLayout(false);
            this.groupBoxInfoVenta.PerformLayout();
            this.groupBoxInfoCliente.ResumeLayout(false);
            this.groupBoxInfoCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPedidos;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox groupBoxInfoPedido;
        private System.Windows.Forms.GroupBox groupBoxInfoProductos;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label LblPrecio;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox TxtProducto;
        private FontAwesome.Sharp.IconButton iconButtonCodProducto;
        private System.Windows.Forms.TextBox textBoxCodProducto;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.Label LblCodProducto;
        private System.Windows.Forms.GroupBox groupBoxInfoVenta;
        private System.Windows.Forms.ComboBox ComboTipoDoc;
        private System.Windows.Forms.DateTimePicker FechaVenta;
        private System.Windows.Forms.Label LblTipoDocumento;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.GroupBox groupBoxInfoCliente;
        private System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.Label LblRazonSocial;
        private FontAwesome.Sharp.IconButton BtnBuscarCliente;
        private System.Windows.Forms.TextBox TxtRUC;
        private System.Windows.Forms.Label LblNroDocumento;
        private System.Windows.Forms.TextBox TxtIdProducto;
        private System.Windows.Forms.Timer TimerNow;
        private System.Windows.Forms.Label LblHoraActual;
        private System.Windows.Forms.Label LblFormaPago;
        private System.Windows.Forms.Label LblMoneda;
        private System.Windows.Forms.Label LblTotalPagar;
        private System.Windows.Forms.TextBox textBoxTotalPagar;
        private System.Windows.Forms.ComboBox ComboFormaPago;
        private System.Windows.Forms.TextBox TxtNroCaja;
        private System.Windows.Forms.Label LblNroCaja;
        private System.Windows.Forms.TextBox TxtCajero;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.DateTimePicker dtpFinVigencia;
        private System.Windows.Forms.Label LblFinVigencia;
        private System.Windows.Forms.DateTimePicker dtpInicioVigencia;
        private System.Windows.Forms.Label LblInicioVigencia;
        private System.Windows.Forms.TextBox TxtTimbrado;
        private System.Windows.Forms.Label LblTimbrado;
        private FontAwesome.Sharp.IconButton BtnAddCliente;
        private System.Windows.Forms.TextBox TxtDoc;
        private System.Windows.Forms.TextBox TxtPuntoEmision;
        private System.Windows.Forms.Label LblCodEstablecimiento;
        private System.Windows.Forms.TextBox TxtCodEstablecimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaVenc;
        private System.Windows.Forms.Label LblFechaVencimiento;
        private FontAwesome.Sharp.IconButton BtnCobro;
        private FontAwesome.Sharp.IconButton BtnImprimirFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEliminar;
        private System.Windows.Forms.TextBox TxtUnidadMedida;
    }
}
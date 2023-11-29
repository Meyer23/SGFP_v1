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
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxInfoPedido = new System.Windows.Forms.GroupBox();
            this.TxtDoc = new System.Windows.Forms.TextBox();
            this.TxtPuntoEmision = new System.Windows.Forms.TextBox();
            this.LblCodEstablecimiento = new System.Windows.Forms.Label();
            this.TxtCodEstablecimiento = new System.Windows.Forms.TextBox();
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
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.BtnAgregar = new FontAwesome.Sharp.IconButton();
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
            this.LblPedidos.Location = new System.Drawing.Point(4, 7);
            this.LblPedidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPedidos.Name = "LblPedidos";
            this.LblPedidos.Padding = new System.Windows.Forms.Padding(4);
            this.LblPedidos.Size = new System.Drawing.Size(1975, 1131);
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
            this.Precio,
            this.SubTotal,
            this.BtnEliminar});
            this.dgvData.Location = new System.Drawing.Point(22, 716);
            this.dgvData.Margin = new System.Windows.Forms.Padding(5, 6, 9, 6);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.Size = new System.Drawing.Size(993, 422);
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
            this.groupBoxInfoPedido.Location = new System.Drawing.Point(22, 38);
            this.groupBoxInfoPedido.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBoxInfoPedido.Name = "groupBoxInfoPedido";
            this.groupBoxInfoPedido.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBoxInfoPedido.Size = new System.Drawing.Size(1890, 672);
            this.groupBoxInfoPedido.TabIndex = 88;
            this.groupBoxInfoPedido.TabStop = false;
            this.groupBoxInfoPedido.Text = "Registrar Venta";
            // 
            // TxtDoc
            // 
            this.TxtDoc.Enabled = false;
            this.TxtDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDoc.Location = new System.Drawing.Point(1131, 287);
            this.TxtDoc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtDoc.Name = "TxtDoc";
            this.TxtDoc.Size = new System.Drawing.Size(234, 31);
            this.TxtDoc.TabIndex = 119;
            // 
            // TxtPuntoEmision
            // 
            this.TxtPuntoEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPuntoEmision.Location = new System.Drawing.Point(1032, 287);
            this.TxtPuntoEmision.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtPuntoEmision.Name = "TxtPuntoEmision";
            this.TxtPuntoEmision.Size = new System.Drawing.Size(60, 31);
            this.TxtPuntoEmision.TabIndex = 118;
            // 
            // LblCodEstablecimiento
            // 
            this.LblCodEstablecimiento.AutoSize = true;
            this.LblCodEstablecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodEstablecimiento.Location = new System.Drawing.Point(804, 287);
            this.LblCodEstablecimiento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblCodEstablecimiento.Name = "LblCodEstablecimiento";
            this.LblCodEstablecimiento.Size = new System.Drawing.Size(84, 25);
            this.LblCodEstablecimiento.TabIndex = 117;
            this.LblCodEstablecimiento.Text = "Factura:";
            // 
            // TxtCodEstablecimiento
            // 
            this.TxtCodEstablecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodEstablecimiento.Location = new System.Drawing.Point(917, 287);
            this.TxtCodEstablecimiento.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtCodEstablecimiento.Name = "TxtCodEstablecimiento";
            this.TxtCodEstablecimiento.Size = new System.Drawing.Size(60, 31);
            this.TxtCodEstablecimiento.TabIndex = 116;
            // 
            // dtpFechaVenc
            // 
            this.dtpFechaVenc.Enabled = false;
            this.dtpFechaVenc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVenc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVenc.Location = new System.Drawing.Point(1032, 354);
            this.dtpFechaVenc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dtpFechaVenc.Name = "dtpFechaVenc";
            this.dtpFechaVenc.Size = new System.Drawing.Size(180, 31);
            this.dtpFechaVenc.TabIndex = 115;
            this.dtpFechaVenc.Value = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            // 
            // LblFechaVencimiento
            // 
            this.LblFechaVencimiento.AutoSize = true;
            this.LblFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaVencimiento.Location = new System.Drawing.Point(804, 359);
            this.LblFechaVencimiento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblFechaVencimiento.Name = "LblFechaVencimiento";
            this.LblFechaVencimiento.Size = new System.Drawing.Size(186, 25);
            this.LblFechaVencimiento.TabIndex = 114;
            this.LblFechaVencimiento.Text = "Fecha Vencimiento:";
            // 
            // dtpFinVigencia
            // 
            this.dtpFinVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinVigencia.Location = new System.Drawing.Point(555, 350);
            this.dtpFinVigencia.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dtpFinVigencia.Name = "dtpFinVigencia";
            this.dtpFinVigencia.Size = new System.Drawing.Size(180, 31);
            this.dtpFinVigencia.TabIndex = 111;
            this.dtpFinVigencia.Value = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            // 
            // LblFinVigencia
            // 
            this.LblFinVigencia.AutoSize = true;
            this.LblFinVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFinVigencia.Location = new System.Drawing.Point(549, 276);
            this.LblFinVigencia.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblFinVigencia.Name = "LblFinVigencia";
            this.LblFinVigencia.Size = new System.Drawing.Size(148, 24);
            this.LblFinVigencia.TabIndex = 110;
            this.LblFinVigencia.Text = "Fin de Vigencia:";
            // 
            // dtpInicioVigencia
            // 
            this.dtpInicioVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicioVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioVigencia.Location = new System.Drawing.Point(297, 350);
            this.dtpInicioVigencia.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dtpInicioVigencia.Name = "dtpInicioVigencia";
            this.dtpInicioVigencia.Size = new System.Drawing.Size(180, 31);
            this.dtpInicioVigencia.TabIndex = 109;
            this.dtpInicioVigencia.Value = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            // 
            // LblInicioVigencia
            // 
            this.LblInicioVigencia.AutoSize = true;
            this.LblInicioVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInicioVigencia.Location = new System.Drawing.Point(291, 276);
            this.LblInicioVigencia.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblInicioVigencia.Name = "LblInicioVigencia";
            this.LblInicioVigencia.Size = new System.Drawing.Size(165, 24);
            this.LblInicioVigencia.TabIndex = 108;
            this.LblInicioVigencia.Text = "Inicio de Vigencia:";
            // 
            // TxtTimbrado
            // 
            this.TxtTimbrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTimbrado.Location = new System.Drawing.Point(18, 350);
            this.TxtTimbrado.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtTimbrado.Name = "TxtTimbrado";
            this.TxtTimbrado.Size = new System.Drawing.Size(237, 31);
            this.TxtTimbrado.TabIndex = 107;
            // 
            // LblTimbrado
            // 
            this.LblTimbrado.AutoSize = true;
            this.LblTimbrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimbrado.Location = new System.Drawing.Point(10, 276);
            this.LblTimbrado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblTimbrado.Name = "LblTimbrado";
            this.LblTimbrado.Size = new System.Drawing.Size(96, 24);
            this.LblTimbrado.TabIndex = 106;
            this.LblTimbrado.Text = "Timbrado:";
            // 
            // TxtNroCaja
            // 
            this.TxtNroCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNroCaja.Location = new System.Drawing.Point(1627, 355);
            this.TxtNroCaja.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNroCaja.Name = "TxtNroCaja";
            this.TxtNroCaja.Size = new System.Drawing.Size(252, 31);
            this.TxtNroCaja.TabIndex = 105;
            // 
            // LblNroCaja
            // 
            this.LblNroCaja.AutoSize = true;
            this.LblNroCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNroCaja.Location = new System.Drawing.Point(1496, 360);
            this.LblNroCaja.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblNroCaja.Name = "LblNroCaja";
            this.LblNroCaja.Size = new System.Drawing.Size(100, 25);
            this.LblNroCaja.TabIndex = 104;
            this.LblNroCaja.Text = "Nro. Caja:";
            // 
            // TxtCajero
            // 
            this.TxtCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCajero.Location = new System.Drawing.Point(1627, 287);
            this.TxtCajero.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCajero.Name = "TxtCajero";
            this.TxtCajero.Size = new System.Drawing.Size(252, 31);
            this.TxtCajero.TabIndex = 103;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(1525, 287);
            this.LblUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(76, 25);
            this.LblUsuario.TabIndex = 102;
            this.LblUsuario.Text = "Cajero:";
            // 
            // groupBoxInfoProductos
            // 
            this.groupBoxInfoProductos.BackColor = System.Drawing.Color.White;
            this.groupBoxInfoProductos.Controls.Add(this.TxtIdProducto);
            this.groupBoxInfoProductos.Controls.Add(this.textBoxPrecio);
            this.groupBoxInfoProductos.Controls.Add(this.LblPrecio);
            this.groupBoxInfoProductos.Controls.Add(this.BtnAgregar);
            this.groupBoxInfoProductos.Controls.Add(this.numericUpDownCantidad);
            this.groupBoxInfoProductos.Controls.Add(this.LblCantidad);
            this.groupBoxInfoProductos.Controls.Add(this.TxtProducto);
            this.groupBoxInfoProductos.Controls.Add(this.iconButtonCodProducto);
            this.groupBoxInfoProductos.Controls.Add(this.textBoxCodProducto);
            this.groupBoxInfoProductos.Controls.Add(this.LblProducto);
            this.groupBoxInfoProductos.Controls.Add(this.LblCodProducto);
            this.groupBoxInfoProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoProductos.Location = new System.Drawing.Point(10, 470);
            this.groupBoxInfoProductos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBoxInfoProductos.Name = "groupBoxInfoProductos";
            this.groupBoxInfoProductos.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBoxInfoProductos.Size = new System.Drawing.Size(1751, 196);
            this.groupBoxInfoProductos.TabIndex = 29;
            this.groupBoxInfoProductos.TabStop = false;
            this.groupBoxInfoProductos.Text = "Informacion Venta";
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdProducto.Location = new System.Drawing.Point(213, 50);
            this.TxtIdProducto.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.Size = new System.Drawing.Size(33, 29);
            this.TxtIdProducto.TabIndex = 74;
            this.TxtIdProducto.Text = "0";
            this.TxtIdProducto.Visible = false;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Enabled = false;
            this.textBoxPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecio.Location = new System.Drawing.Point(1099, 72);
            this.textBoxPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.ReadOnly = true;
            this.textBoxPrecio.Size = new System.Drawing.Size(267, 31);
            this.textBoxPrecio.TabIndex = 71;
            this.textBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecio_KeyPress);
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.Location = new System.Drawing.Point(1093, 38);
            this.LblPrecio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(73, 25);
            this.LblPrecio.TabIndex = 70;
            this.LblPrecio.Text = "Precio:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Green;
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.BtnAgregar.IconColor = System.Drawing.Color.White;
            this.BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAgregar.Location = new System.Drawing.Point(1494, 54);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(203, 133);
            this.BtnAgregar.TabIndex = 69;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCantidad.Location = new System.Drawing.Point(803, 73);
            this.numericUpDownCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(110, 31);
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
            this.LblCantidad.Location = new System.Drawing.Point(794, 38);
            this.LblCantidad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(97, 25);
            this.LblCantidad.TabIndex = 67;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // TxtProducto
            // 
            this.TxtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProducto.Location = new System.Drawing.Point(429, 73);
            this.TxtProducto.Margin = new System.Windows.Forms.Padding(4);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.ReadOnly = true;
            this.TxtProducto.Size = new System.Drawing.Size(306, 31);
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
            this.iconButtonCodProducto.Location = new System.Drawing.Point(186, 97);
            this.iconButtonCodProducto.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonCodProducto.Name = "iconButtonCodProducto";
            this.iconButtonCodProducto.Size = new System.Drawing.Size(111, 52);
            this.iconButtonCodProducto.TabIndex = 63;
            this.iconButtonCodProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonCodProducto.UseVisualStyleBackColor = false;
            this.iconButtonCodProducto.Click += new System.EventHandler(this.iconButtonCodProducto_Click);
            // 
            // textBoxCodProducto
            // 
            this.textBoxCodProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodProducto.Location = new System.Drawing.Point(20, 104);
            this.textBoxCodProducto.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCodProducto.Name = "textBoxCodProducto";
            this.textBoxCodProducto.ReadOnly = true;
            this.textBoxCodProducto.Size = new System.Drawing.Size(130, 31);
            this.textBoxCodProducto.TabIndex = 62;
            this.textBoxCodProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCodProducto_KeyDown);
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.Location = new System.Drawing.Point(424, 38);
            this.LblProducto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(96, 25);
            this.LblProducto.TabIndex = 61;
            this.LblProducto.Text = "Producto:";
            // 
            // LblCodProducto
            // 
            this.LblCodProducto.AutoSize = true;
            this.LblCodProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodProducto.Location = new System.Drawing.Point(13, 50);
            this.LblCodProducto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblCodProducto.Name = "LblCodProducto";
            this.LblCodProducto.Size = new System.Drawing.Size(143, 25);
            this.LblCodProducto.TabIndex = 0;
            this.LblCodProducto.Text = "Cod. Producto:";
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
            this.groupBoxInfoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoVenta.Location = new System.Drawing.Point(0, 61);
            this.groupBoxInfoVenta.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBoxInfoVenta.Name = "groupBoxInfoVenta";
            this.groupBoxInfoVenta.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBoxInfoVenta.Size = new System.Drawing.Size(775, 197);
            this.groupBoxInfoVenta.TabIndex = 28;
            this.groupBoxInfoVenta.TabStop = false;
            this.groupBoxInfoVenta.Text = "Informacion Venta";
            // 
            // ComboFormaPago
            // 
            this.ComboFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboFormaPago.FormattingEnabled = true;
            this.ComboFormaPago.Location = new System.Drawing.Point(440, 121);
            this.ComboFormaPago.Margin = new System.Windows.Forms.Padding(4);
            this.ComboFormaPago.Name = "ComboFormaPago";
            this.ComboFormaPago.Size = new System.Drawing.Size(295, 33);
            this.ComboFormaPago.TabIndex = 102;
            this.ComboFormaPago.SelectedIndexChanged += new System.EventHandler(this.ComboFormaPago_SelectedIndexChanged);
            // 
            // LblFormaPago
            // 
            this.LblFormaPago.AutoSize = true;
            this.LblFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormaPago.Location = new System.Drawing.Point(434, 52);
            this.LblFormaPago.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblFormaPago.Name = "LblFormaPago";
            this.LblFormaPago.Size = new System.Drawing.Size(119, 24);
            this.LblFormaPago.TabIndex = 101;
            this.LblFormaPago.Text = "Forma Pago:";
            // 
            // ComboTipoDoc
            // 
            this.ComboTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTipoDoc.FormattingEnabled = true;
            this.ComboTipoDoc.Location = new System.Drawing.Point(196, 121);
            this.ComboTipoDoc.Margin = new System.Windows.Forms.Padding(4);
            this.ComboTipoDoc.Name = "ComboTipoDoc";
            this.ComboTipoDoc.Size = new System.Drawing.Size(223, 33);
            this.ComboTipoDoc.TabIndex = 29;
            this.ComboTipoDoc.SelectedIndexChanged += new System.EventHandler(this.ComboTipoDoc_SelectedIndexChanged);
            // 
            // FechaVenta
            // 
            this.FechaVenta.Enabled = false;
            this.FechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaVenta.Location = new System.Drawing.Point(23, 121);
            this.FechaVenta.Margin = new System.Windows.Forms.Padding(4);
            this.FechaVenta.Name = "FechaVenta";
            this.FechaVenta.Size = new System.Drawing.Size(148, 31);
            this.FechaVenta.TabIndex = 29;
            this.FechaVenta.Value = new System.DateTime(2023, 11, 28, 0, 0, 0, 0);
            // 
            // LblTipoDocumento
            // 
            this.LblTipoDocumento.AutoSize = true;
            this.LblTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoDocumento.Location = new System.Drawing.Point(200, 52);
            this.LblTipoDocumento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblTipoDocumento.Name = "LblTipoDocumento";
            this.LblTipoDocumento.Size = new System.Drawing.Size(156, 24);
            this.LblTipoDocumento.TabIndex = 61;
            this.LblTipoDocumento.Text = "Tipo Documento:";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(24, 52);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(69, 24);
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
            this.groupBoxInfoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoCliente.Location = new System.Drawing.Point(802, 61);
            this.groupBoxInfoCliente.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBoxInfoCliente.Name = "groupBoxInfoCliente";
            this.groupBoxInfoCliente.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBoxInfoCliente.Size = new System.Drawing.Size(1078, 197);
            this.groupBoxInfoCliente.TabIndex = 27;
            this.groupBoxInfoCliente.TabStop = false;
            this.groupBoxInfoCliente.Text = "Informacion del Cliente";
            // 
            // BtnAddCliente
            // 
            this.BtnAddCliente.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnAddCliente.ForeColor = System.Drawing.Color.White;
            this.BtnAddCliente.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.BtnAddCliente.IconColor = System.Drawing.Color.Black;
            this.BtnAddCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddCliente.Location = new System.Drawing.Point(860, 19);
            this.BtnAddCliente.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAddCliente.Name = "BtnAddCliente";
            this.BtnAddCliente.Size = new System.Drawing.Size(150, 161);
            this.BtnAddCliente.TabIndex = 64;
            this.BtnAddCliente.Text = "Nuevo Cliente";
            this.BtnAddCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAddCliente.UseVisualStyleBackColor = false;
            this.BtnAddCliente.Click += new System.EventHandler(this.BtnAddCliente_Click);
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Location = new System.Drawing.Point(343, 37);
            this.TxtIdCliente.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(33, 34);
            this.TxtIdCliente.TabIndex = 63;
            this.TxtIdCliente.Text = "0";
            this.TxtIdCliente.Visible = false;
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRazonSocial.Location = new System.Drawing.Point(479, 110);
            this.TxtRazonSocial.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.ReadOnly = true;
            this.TxtRazonSocial.Size = new System.Drawing.Size(303, 31);
            this.TxtRazonSocial.TabIndex = 62;
            // 
            // LblRazonSocial
            // 
            this.LblRazonSocial.AutoSize = true;
            this.LblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRazonSocial.Location = new System.Drawing.Point(473, 44);
            this.LblRazonSocial.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblRazonSocial.Name = "LblRazonSocial";
            this.LblRazonSocial.Size = new System.Drawing.Size(209, 24);
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
            this.BtnBuscarCliente.Location = new System.Drawing.Point(343, 101);
            this.BtnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(78, 41);
            this.BtnBuscarCliente.TabIndex = 60;
            this.BtnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarCliente.UseVisualStyleBackColor = false;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // TxtRUC
            // 
            this.TxtRUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRUC.Location = new System.Drawing.Point(17, 110);
            this.TxtRUC.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtRUC.Name = "TxtRUC";
            this.TxtRUC.ReadOnly = true;
            this.TxtRUC.Size = new System.Drawing.Size(242, 31);
            this.TxtRUC.TabIndex = 1;
            // 
            // LblNroDocumento
            // 
            this.LblNroDocumento.AutoSize = true;
            this.LblNroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNroDocumento.Location = new System.Drawing.Point(26, 52);
            this.LblNroDocumento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblNroDocumento.Name = "LblNroDocumento";
            this.LblNroDocumento.Size = new System.Drawing.Size(187, 24);
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
            this.LblHoraActual.Location = new System.Drawing.Point(1853, 100);
            this.LblHoraActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHoraActual.Name = "LblHoraActual";
            this.LblHoraActual.Size = new System.Drawing.Size(0, 54);
            this.LblHoraActual.TabIndex = 89;
            // 
            // LblMoneda
            // 
            this.LblMoneda.AutoSize = true;
            this.LblMoneda.BackColor = System.Drawing.Color.White;
            this.LblMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMoneda.Location = new System.Drawing.Point(1622, 862);
            this.LblMoneda.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblMoneda.Name = "LblMoneda";
            this.LblMoneda.Size = new System.Drawing.Size(72, 39);
            this.LblMoneda.TabIndex = 93;
            this.LblMoneda.Text = "Gs.";
            // 
            // LblTotalPagar
            // 
            this.LblTotalPagar.AutoSize = true;
            this.LblTotalPagar.BackColor = System.Drawing.Color.White;
            this.LblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalPagar.Location = new System.Drawing.Point(1048, 815);
            this.LblTotalPagar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblTotalPagar.Name = "LblTotalPagar";
            this.LblTotalPagar.Size = new System.Drawing.Size(181, 32);
            this.LblTotalPagar.TabIndex = 81;
            this.LblTotalPagar.Text = "Total Pagar:";
            // 
            // textBoxTotalPagar
            // 
            this.textBoxTotalPagar.Enabled = false;
            this.textBoxTotalPagar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalPagar.Location = new System.Drawing.Point(1039, 851);
            this.textBoxTotalPagar.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTotalPagar.Name = "textBoxTotalPagar";
            this.textBoxTotalPagar.Size = new System.Drawing.Size(574, 50);
            this.textBoxTotalPagar.TabIndex = 82;
            // 
            // BtnCobro
            // 
            this.BtnCobro.BackColor = System.Drawing.Color.Olive;
            this.BtnCobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCobro.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.BtnCobro.IconColor = System.Drawing.Color.Black;
            this.BtnCobro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCobro.Location = new System.Drawing.Point(1039, 720);
            this.BtnCobro.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCobro.Name = "BtnCobro";
            this.BtnCobro.Size = new System.Drawing.Size(288, 75);
            this.BtnCobro.TabIndex = 94;
            this.BtnCobro.Text = "Medio de Cobro";
            this.BtnCobro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnCobro.UseVisualStyleBackColor = false;
            this.BtnCobro.Click += new System.EventHandler(this.BtnCobro_Click);
            // 
            // BtnImprimirFactura
            // 
            this.BtnImprimirFactura.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnImprimirFactura.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.BtnImprimirFactura.IconColor = System.Drawing.Color.Black;
            this.BtnImprimirFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImprimirFactura.Location = new System.Drawing.Point(1039, 1050);
            this.BtnImprimirFactura.Name = "BtnImprimirFactura";
            this.BtnImprimirFactura.Size = new System.Drawing.Size(288, 75);
            this.BtnImprimirFactura.TabIndex = 95;
            this.BtnImprimirFactura.Text = "Imprimir Factura";
            this.BtnImprimirFactura.UseVisualStyleBackColor = false;
            // 
            // FrmRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1992, 1364);
            this.Controls.Add(this.BtnImprimirFactura);
            this.Controls.Add(this.BtnCobro);
            this.Controls.Add(this.LblMoneda);
            this.Controls.Add(this.LblHoraActual);
            this.Controls.Add(this.groupBoxInfoPedido);
            this.Controls.Add(this.textBoxTotalPagar);
            this.Controls.Add(this.LblTotalPagar);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.LblPedidos);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEliminar;
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
    }
}
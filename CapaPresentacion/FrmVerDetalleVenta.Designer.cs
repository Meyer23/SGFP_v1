namespace CapaPresentacion
{
    partial class FrmVerDetalleVenta
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
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.LblFactura = new System.Windows.Forms.Label();
            this.groupBoxInfoVenta = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblNroCaja = new System.Windows.Forms.Label();
            this.TxtIdVenta = new System.Windows.Forms.TextBox();
            this.dtpFinVigencia = new System.Windows.Forms.DateTimePicker();
            this.LblFinVigencia = new System.Windows.Forms.Label();
            this.dtpInicioVigencia = new System.Windows.Forms.DateTimePicker();
            this.LblInicioVigencia = new System.Windows.Forms.Label();
            this.TxtCajero = new System.Windows.Forms.TextBox();
            this.LblCajero = new System.Windows.Forms.Label();
            this.TxtFormaPago = new System.Windows.Forms.TextBox();
            this.TxtTipoDoc = new System.Windows.Forms.TextBox();
            this.TxtTimbrado = new System.Windows.Forms.TextBox();
            this.LblTimbrado = new System.Windows.Forms.Label();
            this.TxtDoc = new System.Windows.Forms.TextBox();
            this.TxtPuntoEmision = new System.Windows.Forms.TextBox();
            this.LblCodEstablecimiento = new System.Windows.Forms.Label();
            this.TxtCodEstablecimiento = new System.Windows.Forms.TextBox();
            this.groupBoxInfoCliente = new System.Windows.Forms.GroupBox();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.LblRazonSocial = new System.Windows.Forms.Label();
            this.TxtRUC = new System.Windows.Forms.TextBox();
            this.LblRUC = new System.Windows.Forms.Label();
            this.LblFormaPago = new System.Windows.Forms.Label();
            this.LblTipoDoc = new System.Windows.Forms.Label();
            this.dtpFechaVenc = new System.Windows.Forms.DateTimePicker();
            this.LblFechaVencimiento = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblCompras = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LblTotalVenta = new System.Windows.Forms.Label();
            this.TxtTotalVenta = new System.Windows.Forms.TextBox();
            this.LblAnulado = new System.Windows.Forms.Label();
            this.checkBoxAnulado = new System.Windows.Forms.CheckBox();
            this.PbNoConfirmado = new System.Windows.Forms.PictureBox();
            this.BtnAnularVenta = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.BtnImprimirVenta = new FontAwesome.Sharp.IconButton();
            this.groupBoxInfoVenta.SuspendLayout();
            this.groupBoxInfoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNoConfirmado)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(77, 24);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(155, 20);
            this.TxtBusqueda.TabIndex = 105;
            this.TxtBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBusqueda_KeyDown);
            // 
            // LblFactura
            // 
            this.LblFactura.AutoSize = true;
            this.LblFactura.BackColor = System.Drawing.Color.White;
            this.LblFactura.Location = new System.Drawing.Point(25, 27);
            this.LblFactura.Name = "LblFactura";
            this.LblFactura.Size = new System.Drawing.Size(46, 13);
            this.LblFactura.TabIndex = 106;
            this.LblFactura.Text = "Factura:";
            // 
            // groupBoxInfoVenta
            // 
            this.groupBoxInfoVenta.BackColor = System.Drawing.Color.White;
            this.groupBoxInfoVenta.Controls.Add(this.textBox1);
            this.groupBoxInfoVenta.Controls.Add(this.LblNroCaja);
            this.groupBoxInfoVenta.Controls.Add(this.TxtIdVenta);
            this.groupBoxInfoVenta.Controls.Add(this.dtpFinVigencia);
            this.groupBoxInfoVenta.Controls.Add(this.LblFinVigencia);
            this.groupBoxInfoVenta.Controls.Add(this.dtpInicioVigencia);
            this.groupBoxInfoVenta.Controls.Add(this.LblInicioVigencia);
            this.groupBoxInfoVenta.Controls.Add(this.TxtCajero);
            this.groupBoxInfoVenta.Controls.Add(this.LblCajero);
            this.groupBoxInfoVenta.Controls.Add(this.TxtFormaPago);
            this.groupBoxInfoVenta.Controls.Add(this.TxtTipoDoc);
            this.groupBoxInfoVenta.Controls.Add(this.TxtTimbrado);
            this.groupBoxInfoVenta.Controls.Add(this.LblTimbrado);
            this.groupBoxInfoVenta.Controls.Add(this.TxtDoc);
            this.groupBoxInfoVenta.Controls.Add(this.TxtPuntoEmision);
            this.groupBoxInfoVenta.Controls.Add(this.LblCodEstablecimiento);
            this.groupBoxInfoVenta.Controls.Add(this.TxtCodEstablecimiento);
            this.groupBoxInfoVenta.Controls.Add(this.groupBoxInfoCliente);
            this.groupBoxInfoVenta.Controls.Add(this.LblFormaPago);
            this.groupBoxInfoVenta.Controls.Add(this.LblTipoDoc);
            this.groupBoxInfoVenta.Controls.Add(this.dtpFechaVenc);
            this.groupBoxInfoVenta.Controls.Add(this.LblFechaVencimiento);
            this.groupBoxInfoVenta.Controls.Add(this.dtpFecha);
            this.groupBoxInfoVenta.Controls.Add(this.LblFecha);
            this.groupBoxInfoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoVenta.Location = new System.Drawing.Point(27, 55);
            this.groupBoxInfoVenta.Name = "groupBoxInfoVenta";
            this.groupBoxInfoVenta.Size = new System.Drawing.Size(1193, 229);
            this.groupBoxInfoVenta.TabIndex = 104;
            this.groupBoxInfoVenta.TabStop = false;
            this.groupBoxInfoVenta.Text = "Información de la Venta";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(506, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(129, 22);
            this.textBox1.TabIndex = 111;
            // 
            // LblNroCaja
            // 
            this.LblNroCaja.AutoSize = true;
            this.LblNroCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNroCaja.Location = new System.Drawing.Point(503, 28);
            this.LblNroCaja.Name = "LblNroCaja";
            this.LblNroCaja.Size = new System.Drawing.Size(71, 13);
            this.LblNroCaja.TabIndex = 110;
            this.LblNroCaja.Text = "Número Caja:";
            // 
            // TxtIdVenta
            // 
            this.TxtIdVenta.Location = new System.Drawing.Point(260, 17);
            this.TxtIdVenta.Name = "TxtIdVenta";
            this.TxtIdVenta.Size = new System.Drawing.Size(48, 22);
            this.TxtIdVenta.TabIndex = 107;
            // 
            // dtpFinVigencia
            // 
            this.dtpFinVigencia.Enabled = false;
            this.dtpFinVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinVigencia.Location = new System.Drawing.Point(237, 134);
            this.dtpFinVigencia.Name = "dtpFinVigencia";
            this.dtpFinVigencia.Size = new System.Drawing.Size(97, 20);
            this.dtpFinVigencia.TabIndex = 106;
            this.dtpFinVigencia.Value = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            // 
            // LblFinVigencia
            // 
            this.LblFinVigencia.AutoSize = true;
            this.LblFinVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFinVigencia.Location = new System.Drawing.Point(234, 118);
            this.LblFinVigencia.Name = "LblFinVigencia";
            this.LblFinVigencia.Size = new System.Drawing.Size(65, 13);
            this.LblFinVigencia.TabIndex = 105;
            this.LblFinVigencia.Text = "FinVigencia:";
            // 
            // dtpInicioVigencia
            // 
            this.dtpInicioVigencia.Enabled = false;
            this.dtpInicioVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicioVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioVigencia.Location = new System.Drawing.Point(132, 134);
            this.dtpInicioVigencia.Name = "dtpInicioVigencia";
            this.dtpInicioVigencia.Size = new System.Drawing.Size(97, 20);
            this.dtpInicioVigencia.TabIndex = 104;
            this.dtpInicioVigencia.Value = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            // 
            // LblInicioVigencia
            // 
            this.LblInicioVigencia.AutoSize = true;
            this.LblInicioVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInicioVigencia.Location = new System.Drawing.Point(129, 118);
            this.LblInicioVigencia.Name = "LblInicioVigencia";
            this.LblInicioVigencia.Size = new System.Drawing.Size(79, 13);
            this.LblInicioVigencia.TabIndex = 103;
            this.LblInicioVigencia.Text = "Inicio Vigencia:";
            // 
            // TxtCajero
            // 
            this.TxtCajero.Location = new System.Drawing.Point(369, 44);
            this.TxtCajero.Name = "TxtCajero";
            this.TxtCajero.ReadOnly = true;
            this.TxtCajero.Size = new System.Drawing.Size(129, 22);
            this.TxtCajero.TabIndex = 102;
            // 
            // LblCajero
            // 
            this.LblCajero.AutoSize = true;
            this.LblCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCajero.Location = new System.Drawing.Point(366, 28);
            this.LblCajero.Name = "LblCajero";
            this.LblCajero.Size = new System.Drawing.Size(40, 13);
            this.LblCajero.TabIndex = 101;
            this.LblCajero.Text = "Cajero:";
            // 
            // TxtFormaPago
            // 
            this.TxtFormaPago.Location = new System.Drawing.Point(190, 44);
            this.TxtFormaPago.Name = "TxtFormaPago";
            this.TxtFormaPago.ReadOnly = true;
            this.TxtFormaPago.Size = new System.Drawing.Size(173, 22);
            this.TxtFormaPago.TabIndex = 100;
            // 
            // TxtTipoDoc
            // 
            this.TxtTipoDoc.Location = new System.Drawing.Point(9, 42);
            this.TxtTipoDoc.Name = "TxtTipoDoc";
            this.TxtTipoDoc.ReadOnly = true;
            this.TxtTipoDoc.Size = new System.Drawing.Size(173, 22);
            this.TxtTipoDoc.TabIndex = 99;
            // 
            // TxtTimbrado
            // 
            this.TxtTimbrado.Location = new System.Drawing.Point(9, 136);
            this.TxtTimbrado.Name = "TxtTimbrado";
            this.TxtTimbrado.ReadOnly = true;
            this.TxtTimbrado.Size = new System.Drawing.Size(112, 22);
            this.TxtTimbrado.TabIndex = 98;
            // 
            // LblTimbrado
            // 
            this.LblTimbrado.AutoSize = true;
            this.LblTimbrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimbrado.Location = new System.Drawing.Point(6, 120);
            this.LblTimbrado.Name = "LblTimbrado";
            this.LblTimbrado.Size = new System.Drawing.Size(54, 13);
            this.LblTimbrado.TabIndex = 97;
            this.LblTimbrado.Text = "Timbrado:";
            // 
            // TxtDoc
            // 
            this.TxtDoc.Location = new System.Drawing.Point(91, 86);
            this.TxtDoc.Name = "TxtDoc";
            this.TxtDoc.ReadOnly = true;
            this.TxtDoc.Size = new System.Drawing.Size(90, 22);
            this.TxtDoc.TabIndex = 96;
            // 
            // TxtPuntoEmision
            // 
            this.TxtPuntoEmision.Location = new System.Drawing.Point(50, 86);
            this.TxtPuntoEmision.Name = "TxtPuntoEmision";
            this.TxtPuntoEmision.ReadOnly = true;
            this.TxtPuntoEmision.Size = new System.Drawing.Size(35, 22);
            this.TxtPuntoEmision.TabIndex = 95;
            // 
            // LblCodEstablecimiento
            // 
            this.LblCodEstablecimiento.AutoSize = true;
            this.LblCodEstablecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodEstablecimiento.Location = new System.Drawing.Point(6, 68);
            this.LblCodEstablecimiento.Name = "LblCodEstablecimiento";
            this.LblCodEstablecimiento.Size = new System.Drawing.Size(46, 13);
            this.LblCodEstablecimiento.TabIndex = 94;
            this.LblCodEstablecimiento.Text = "Factura:";
            // 
            // TxtCodEstablecimiento
            // 
            this.TxtCodEstablecimiento.Location = new System.Drawing.Point(9, 86);
            this.TxtCodEstablecimiento.Name = "TxtCodEstablecimiento";
            this.TxtCodEstablecimiento.ReadOnly = true;
            this.TxtCodEstablecimiento.Size = new System.Drawing.Size(35, 22);
            this.TxtCodEstablecimiento.TabIndex = 93;
            // 
            // groupBoxInfoCliente
            // 
            this.groupBoxInfoCliente.BackColor = System.Drawing.Color.White;
            this.groupBoxInfoCliente.Controls.Add(this.TxtIdCliente);
            this.groupBoxInfoCliente.Controls.Add(this.TxtRazonSocial);
            this.groupBoxInfoCliente.Controls.Add(this.LblRazonSocial);
            this.groupBoxInfoCliente.Controls.Add(this.TxtRUC);
            this.groupBoxInfoCliente.Controls.Add(this.LblRUC);
            this.groupBoxInfoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoCliente.Location = new System.Drawing.Point(776, 29);
            this.groupBoxInfoCliente.Name = "groupBoxInfoCliente";
            this.groupBoxInfoCliente.Size = new System.Drawing.Size(411, 75);
            this.groupBoxInfoCliente.TabIndex = 27;
            this.groupBoxInfoCliente.TabStop = false;
            this.groupBoxInfoCliente.Text = "Información del Cliente";
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Location = new System.Drawing.Point(292, 13);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(26, 20);
            this.TxtIdCliente.TabIndex = 63;
            this.TxtIdCliente.Text = "0";
            this.TxtIdCliente.Visible = false;
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Location = new System.Drawing.Point(143, 42);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.ReadOnly = true;
            this.TxtRazonSocial.Size = new System.Drawing.Size(258, 20);
            this.TxtRazonSocial.TabIndex = 62;
            // 
            // LblRazonSocial
            // 
            this.LblRazonSocial.AutoSize = true;
            this.LblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRazonSocial.Location = new System.Drawing.Point(140, 27);
            this.LblRazonSocial.Name = "LblRazonSocial";
            this.LblRazonSocial.Size = new System.Drawing.Size(121, 13);
            this.LblRazonSocial.TabIndex = 61;
            this.LblRazonSocial.Text = "Nombre / Razón Social:";
            // 
            // TxtRUC
            // 
            this.TxtRUC.Location = new System.Drawing.Point(9, 42);
            this.TxtRUC.Name = "TxtRUC";
            this.TxtRUC.ReadOnly = true;
            this.TxtRUC.Size = new System.Drawing.Size(113, 20);
            this.TxtRUC.TabIndex = 1;
            // 
            // LblRUC
            // 
            this.LblRUC.AutoSize = true;
            this.LblRUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRUC.Location = new System.Drawing.Point(6, 27);
            this.LblRUC.Name = "LblRUC";
            this.LblRUC.Size = new System.Drawing.Size(33, 13);
            this.LblRUC.TabIndex = 0;
            this.LblRUC.Text = "RUC:";
            // 
            // LblFormaPago
            // 
            this.LblFormaPago.AutoSize = true;
            this.LblFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormaPago.Location = new System.Drawing.Point(187, 26);
            this.LblFormaPago.Name = "LblFormaPago";
            this.LblFormaPago.Size = new System.Drawing.Size(67, 13);
            this.LblFormaPago.TabIndex = 89;
            this.LblFormaPago.Text = "Forma Pago:";
            // 
            // LblTipoDoc
            // 
            this.LblTipoDoc.AutoSize = true;
            this.LblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoDoc.Location = new System.Drawing.Point(6, 26);
            this.LblTipoDoc.Name = "LblTipoDoc";
            this.LblTipoDoc.Size = new System.Drawing.Size(89, 13);
            this.LblTipoDoc.TabIndex = 8;
            this.LblTipoDoc.Text = "Tipo Documento:";
            // 
            // dtpFechaVenc
            // 
            this.dtpFechaVenc.Enabled = false;
            this.dtpFechaVenc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVenc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVenc.Location = new System.Drawing.Point(304, 86);
            this.dtpFechaVenc.Name = "dtpFechaVenc";
            this.dtpFechaVenc.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaVenc.TabIndex = 3;
            this.dtpFechaVenc.Value = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            // 
            // LblFechaVencimiento
            // 
            this.LblFechaVencimiento.AutoSize = true;
            this.LblFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaVencimiento.Location = new System.Drawing.Point(301, 70);
            this.LblFechaVencimiento.Name = "LblFechaVencimiento";
            this.LblFechaVencimiento.Size = new System.Drawing.Size(101, 13);
            this.LblFechaVencimiento.TabIndex = 2;
            this.LblFechaVencimiento.Text = "Fecha Vencimiento:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(199, 86);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(97, 20);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.Value = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(196, 70);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(40, 13);
            this.LblFecha.TabIndex = 0;
            this.LblFecha.Text = "Fecha:";
            // 
            // LblCompras
            // 
            this.LblCompras.BackColor = System.Drawing.Color.White;
            this.LblCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCompras.Location = new System.Drawing.Point(11, 9);
            this.LblCompras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCompras.Name = "LblCompras";
            this.LblCompras.Padding = new System.Windows.Forms.Padding(2);
            this.LblCompras.Size = new System.Drawing.Size(1216, 556);
            this.LblCompras.TabIndex = 103;
            this.LblCompras.Text = " ";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.Codigo,
            this.Descripcion,
            this.Precio,
            this.Cantidad,
            this.Total,
            this.BtnEliminar});
            this.dgvData.Location = new System.Drawing.Point(27, 300);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(829, 236);
            this.dgvData.TabIndex = 108;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción Producto";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 300;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 150;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.HeaderText = "";
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.ReadOnly = true;
            this.BtnEliminar.Width = 30;
            // 
            // LblTotalVenta
            // 
            this.LblTotalVenta.AutoSize = true;
            this.LblTotalVenta.BackColor = System.Drawing.Color.White;
            this.LblTotalVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalVenta.Location = new System.Drawing.Point(870, 487);
            this.LblTotalVenta.Name = "LblTotalVenta";
            this.LblTotalVenta.Size = new System.Drawing.Size(91, 20);
            this.LblTotalVenta.TabIndex = 128;
            this.LblTotalVenta.Text = "Total Venta";
            // 
            // TxtTotalVenta
            // 
            this.TxtTotalVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalVenta.Location = new System.Drawing.Point(874, 510);
            this.TxtTotalVenta.Name = "TxtTotalVenta";
            this.TxtTotalVenta.ReadOnly = true;
            this.TxtTotalVenta.Size = new System.Drawing.Size(161, 26);
            this.TxtTotalVenta.TabIndex = 129;
            this.TxtTotalVenta.Text = "0";
            // 
            // LblAnulado
            // 
            this.LblAnulado.AutoSize = true;
            this.LblAnulado.BackColor = System.Drawing.Color.White;
            this.LblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnulado.ForeColor = System.Drawing.Color.Red;
            this.LblAnulado.Location = new System.Drawing.Point(870, 24);
            this.LblAnulado.Name = "LblAnulado";
            this.LblAnulado.Size = new System.Drawing.Size(81, 24);
            this.LblAnulado.TabIndex = 133;
            this.LblAnulado.Text = "Anulado";
            // 
            // checkBoxAnulado
            // 
            this.checkBoxAnulado.AutoSize = true;
            this.checkBoxAnulado.Location = new System.Drawing.Point(757, 32);
            this.checkBoxAnulado.Name = "checkBoxAnulado";
            this.checkBoxAnulado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAnulado.TabIndex = 132;
            this.checkBoxAnulado.UseVisualStyleBackColor = true;
            this.checkBoxAnulado.Visible = false;
            // 
            // PbNoConfirmado
            // 
            this.PbNoConfirmado.BackColor = System.Drawing.Color.White;
            this.PbNoConfirmado.Image = global::CapaPresentacion.Properties.Resources.cancelar;
            this.PbNoConfirmado.Location = new System.Drawing.Point(957, 15);
            this.PbNoConfirmado.Name = "PbNoConfirmado";
            this.PbNoConfirmado.Size = new System.Drawing.Size(43, 39);
            this.PbNoConfirmado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbNoConfirmado.TabIndex = 131;
            this.PbNoConfirmado.TabStop = false;
            // 
            // BtnAnularVenta
            // 
            this.BtnAnularVenta.BackColor = System.Drawing.Color.Red;
            this.BtnAnularVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAnularVenta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAnularVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnularVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnularVenta.ForeColor = System.Drawing.Color.White;
            this.BtnAnularVenta.IconChar = FontAwesome.Sharp.IconChar.X;
            this.BtnAnularVenta.IconColor = System.Drawing.Color.White;
            this.BtnAnularVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAnularVenta.IconSize = 16;
            this.BtnAnularVenta.Location = new System.Drawing.Point(874, 408);
            this.BtnAnularVenta.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAnularVenta.Name = "BtnAnularVenta";
            this.BtnAnularVenta.Size = new System.Drawing.Size(142, 27);
            this.BtnAnularVenta.TabIndex = 130;
            this.BtnAnularVenta.Text = "Anular";
            this.BtnAnularVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAnularVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAnularVenta.UseVisualStyleBackColor = false;
            this.BtnAnularVenta.Click += new System.EventHandler(this.BtnAnularVenta_Click);
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
            this.BtnBuscar.Location = new System.Drawing.Point(237, 20);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(43, 26);
            this.BtnBuscar.TabIndex = 107;
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
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
            this.BtnLimpiar.Location = new System.Drawing.Point(287, 20);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(43, 26);
            this.BtnLimpiar.TabIndex = 134;
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnImprimirVenta
            // 
            this.BtnImprimirVenta.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnImprimirVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImprimirVenta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnImprimirVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimirVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimirVenta.ForeColor = System.Drawing.Color.White;
            this.BtnImprimirVenta.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.BtnImprimirVenta.IconColor = System.Drawing.Color.White;
            this.BtnImprimirVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImprimirVenta.IconSize = 16;
            this.BtnImprimirVenta.Location = new System.Drawing.Point(874, 356);
            this.BtnImprimirVenta.Margin = new System.Windows.Forms.Padding(2);
            this.BtnImprimirVenta.Name = "BtnImprimirVenta";
            this.BtnImprimirVenta.Size = new System.Drawing.Size(142, 27);
            this.BtnImprimirVenta.TabIndex = 135;
            this.BtnImprimirVenta.Text = "Imprimir";
            this.BtnImprimirVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnImprimirVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImprimirVenta.UseVisualStyleBackColor = false;
            this.BtnImprimirVenta.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FrmVerDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 569);
            this.Controls.Add(this.BtnImprimirVenta);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.LblAnulado);
            this.Controls.Add(this.checkBoxAnulado);
            this.Controls.Add(this.PbNoConfirmado);
            this.Controls.Add(this.BtnAnularVenta);
            this.Controls.Add(this.LblTotalVenta);
            this.Controls.Add(this.TxtTotalVenta);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.LblFactura);
            this.Controls.Add(this.groupBoxInfoVenta);
            this.Controls.Add(this.LblCompras);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmVerDetalleVenta";
            this.Text = "Consulta de Ventas";
            this.Load += new System.EventHandler(this.FrmVerDetalleVenta_Load);
            this.groupBoxInfoVenta.ResumeLayout(false);
            this.groupBoxInfoVenta.PerformLayout();
            this.groupBoxInfoCliente.ResumeLayout(false);
            this.groupBoxInfoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNoConfirmado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Label LblFactura;
        private System.Windows.Forms.GroupBox groupBoxInfoVenta;
        private System.Windows.Forms.TextBox TxtIdVenta;
        private System.Windows.Forms.DateTimePicker dtpFinVigencia;
        private System.Windows.Forms.Label LblFinVigencia;
        private System.Windows.Forms.DateTimePicker dtpInicioVigencia;
        private System.Windows.Forms.Label LblInicioVigencia;
        private System.Windows.Forms.TextBox TxtCajero;
        private System.Windows.Forms.Label LblCajero;
        private System.Windows.Forms.TextBox TxtFormaPago;
        private System.Windows.Forms.TextBox TxtTipoDoc;
        private System.Windows.Forms.TextBox TxtTimbrado;
        private System.Windows.Forms.Label LblTimbrado;
        private System.Windows.Forms.TextBox TxtDoc;
        private System.Windows.Forms.TextBox TxtPuntoEmision;
        private System.Windows.Forms.Label LblCodEstablecimiento;
        private System.Windows.Forms.TextBox TxtCodEstablecimiento;
        private System.Windows.Forms.GroupBox groupBoxInfoCliente;
        private System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.Label LblRazonSocial;
        private System.Windows.Forms.TextBox TxtRUC;
        private System.Windows.Forms.Label LblRUC;
        private System.Windows.Forms.Label LblFormaPago;
        private System.Windows.Forms.Label LblTipoDoc;
        private System.Windows.Forms.DateTimePicker dtpFechaVenc;
        private System.Windows.Forms.Label LblFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblCompras;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnAnularVenta;
        private System.Windows.Forms.Label LblTotalVenta;
        private System.Windows.Forms.TextBox TxtTotalVenta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblNroCaja;
        private System.Windows.Forms.Label LblAnulado;
        private System.Windows.Forms.CheckBox checkBoxAnulado;
        private System.Windows.Forms.PictureBox PbNoConfirmado;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private FontAwesome.Sharp.IconButton BtnImprimirVenta;
    }
}
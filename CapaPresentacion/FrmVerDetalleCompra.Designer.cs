namespace CapaPresentacion
{
    partial class FrmVerDetalleCompra
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
            this.LblCompras = new System.Windows.Forms.Label();
            this.LblTotalCompra = new System.Windows.Forms.Label();
            this.TxtIdProveedor = new System.Windows.Forms.TextBox();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.LblRazonSocial = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.groupBoxInfoProveedor = new System.Windows.Forms.GroupBox();
            this.TxtRUC = new System.Windows.Forms.TextBox();
            this.LblRUC = new System.Windows.Forms.Label();
            this.TxtTotalCompra = new System.Windows.Forms.TextBox();
            this.groupBoxInfoPedido = new System.Windows.Forms.GroupBox();
            this.TxtIdCompra = new System.Windows.Forms.TextBox();
            this.dtpFinVigencia = new System.Windows.Forms.DateTimePicker();
            this.LblFinVigencia = new System.Windows.Forms.Label();
            this.dtpInicioVigencia = new System.Windows.Forms.DateTimePicker();
            this.LblInicioVigencia = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.TxtFormaPago = new System.Windows.Forms.TextBox();
            this.TxtTipoDoc = new System.Windows.Forms.TextBox();
            this.TxtTimbrado = new System.Windows.Forms.TextBox();
            this.LblTimbrado = new System.Windows.Forms.Label();
            this.TxtDoc = new System.Windows.Forms.TextBox();
            this.TxtPuntoEmision = new System.Windows.Forms.TextBox();
            this.LblCodEstablecimiento = new System.Windows.Forms.Label();
            this.TxtCodEstablecimiento = new System.Windows.Forms.TextBox();
            this.LblFormaPago = new System.Windows.Forms.Label();
            this.LblTipoDoc = new System.Windows.Forms.Label();
            this.TxtObs = new System.Windows.Forms.TextBox();
            this.LblObs = new System.Windows.Forms.Label();
            this.TxtNroPedido = new System.Windows.Forms.TextBox();
            this.LboNroPedido = new System.Windows.Forms.Label();
            this.dtpFechaVenc = new System.Windows.Forms.DateTimePicker();
            this.LblFechaVencimiento = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.LblFecha = new System.Windows.Forms.Label();
            this.checkBoxConfirmado = new System.Windows.Forms.CheckBox();
            this.PbNoConfirmado = new System.Windows.Forms.PictureBox();
            this.LblNoConfirmado = new System.Windows.Forms.Label();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.LblFactura = new System.Windows.Forms.Label();
            this.PbConfirmado = new System.Windows.Forms.PictureBox();
            this.LblConfirmado = new System.Windows.Forms.Label();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.checkBoxAnulado = new System.Windows.Forms.CheckBox();
            this.LblAnulado = new System.Windows.Forms.Label();
            this.BtnConfirmar = new FontAwesome.Sharp.IconButton();
            this.dtpFechaRec = new System.Windows.Forms.DateTimePicker();
            this.LblFechaRec = new System.Windows.Forms.Label();
            this.BtnAnular = new FontAwesome.Sharp.IconButton();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBoxInfoProveedor.SuspendLayout();
            this.groupBoxInfoPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbNoConfirmado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbConfirmado)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCompras
            // 
            this.LblCompras.BackColor = System.Drawing.Color.White;
            this.LblCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCompras.Location = new System.Drawing.Point(2, 11);
            this.LblCompras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCompras.Name = "LblCompras";
            this.LblCompras.Padding = new System.Windows.Forms.Padding(2);
            this.LblCompras.Size = new System.Drawing.Size(1216, 519);
            this.LblCompras.TabIndex = 53;
            // 
            // LblTotalCompra
            // 
            this.LblTotalCompra.AutoSize = true;
            this.LblTotalCompra.BackColor = System.Drawing.Color.White;
            this.LblTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalCompra.Location = new System.Drawing.Point(879, 457);
            this.LblTotalCompra.Name = "LblTotalCompra";
            this.LblTotalCompra.Size = new System.Drawing.Size(89, 16);
            this.LblTotalCompra.TabIndex = 64;
            this.LblTotalCompra.Text = "Total Compra";
            // 
            // TxtIdProveedor
            // 
            this.TxtIdProveedor.Location = new System.Drawing.Point(234, 12);
            this.TxtIdProveedor.Name = "TxtIdProveedor";
            this.TxtIdProveedor.Size = new System.Drawing.Size(26, 20);
            this.TxtIdProveedor.TabIndex = 63;
            this.TxtIdProveedor.Text = "0";
            this.TxtIdProveedor.Visible = false;
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
            this.LblRazonSocial.Size = new System.Drawing.Size(73, 13);
            this.LblRazonSocial.TabIndex = 61;
            this.LblRazonSocial.Text = "Razón Social:";
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
            this.dgvData.Location = new System.Drawing.Point(18, 265);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(829, 236);
            this.dgvData.TabIndex = 62;
            // 
            // groupBoxInfoProveedor
            // 
            this.groupBoxInfoProveedor.BackColor = System.Drawing.Color.White;
            this.groupBoxInfoProveedor.Controls.Add(this.TxtIdProveedor);
            this.groupBoxInfoProveedor.Controls.Add(this.TxtRazonSocial);
            this.groupBoxInfoProveedor.Controls.Add(this.LblRazonSocial);
            this.groupBoxInfoProveedor.Controls.Add(this.TxtRUC);
            this.groupBoxInfoProveedor.Controls.Add(this.LblRUC);
            this.groupBoxInfoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoProveedor.Location = new System.Drawing.Point(776, 29);
            this.groupBoxInfoProveedor.Name = "groupBoxInfoProveedor";
            this.groupBoxInfoProveedor.Size = new System.Drawing.Size(411, 75);
            this.groupBoxInfoProveedor.TabIndex = 27;
            this.groupBoxInfoProveedor.TabStop = false;
            this.groupBoxInfoProveedor.Text = "Información del Proveedor";
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
            // TxtTotalCompra
            // 
            this.TxtTotalCompra.Location = new System.Drawing.Point(882, 477);
            this.TxtTotalCompra.Name = "TxtTotalCompra";
            this.TxtTotalCompra.ReadOnly = true;
            this.TxtTotalCompra.Size = new System.Drawing.Size(125, 20);
            this.TxtTotalCompra.TabIndex = 65;
            this.TxtTotalCompra.Text = "0";
            // 
            // groupBoxInfoPedido
            // 
            this.groupBoxInfoPedido.BackColor = System.Drawing.Color.White;
            this.groupBoxInfoPedido.Controls.Add(this.TxtIdCompra);
            this.groupBoxInfoPedido.Controls.Add(this.dtpFinVigencia);
            this.groupBoxInfoPedido.Controls.Add(this.LblFinVigencia);
            this.groupBoxInfoPedido.Controls.Add(this.dtpInicioVigencia);
            this.groupBoxInfoPedido.Controls.Add(this.LblInicioVigencia);
            this.groupBoxInfoPedido.Controls.Add(this.TxtUsuario);
            this.groupBoxInfoPedido.Controls.Add(this.LblUsuario);
            this.groupBoxInfoPedido.Controls.Add(this.TxtFormaPago);
            this.groupBoxInfoPedido.Controls.Add(this.TxtTipoDoc);
            this.groupBoxInfoPedido.Controls.Add(this.TxtTimbrado);
            this.groupBoxInfoPedido.Controls.Add(this.LblTimbrado);
            this.groupBoxInfoPedido.Controls.Add(this.TxtDoc);
            this.groupBoxInfoPedido.Controls.Add(this.TxtPuntoEmision);
            this.groupBoxInfoPedido.Controls.Add(this.LblCodEstablecimiento);
            this.groupBoxInfoPedido.Controls.Add(this.TxtCodEstablecimiento);
            this.groupBoxInfoPedido.Controls.Add(this.groupBoxInfoProveedor);
            this.groupBoxInfoPedido.Controls.Add(this.LblFormaPago);
            this.groupBoxInfoPedido.Controls.Add(this.LblTipoDoc);
            this.groupBoxInfoPedido.Controls.Add(this.TxtObs);
            this.groupBoxInfoPedido.Controls.Add(this.LblObs);
            this.groupBoxInfoPedido.Controls.Add(this.TxtNroPedido);
            this.groupBoxInfoPedido.Controls.Add(this.LboNroPedido);
            this.groupBoxInfoPedido.Controls.Add(this.dtpFechaVenc);
            this.groupBoxInfoPedido.Controls.Add(this.LblFechaVencimiento);
            this.groupBoxInfoPedido.Controls.Add(this.dtpFecha);
            this.groupBoxInfoPedido.Controls.Add(this.LblFecha);
            this.groupBoxInfoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoPedido.Location = new System.Drawing.Point(18, 87);
            this.groupBoxInfoPedido.Name = "groupBoxInfoPedido";
            this.groupBoxInfoPedido.Size = new System.Drawing.Size(1193, 160);
            this.groupBoxInfoPedido.TabIndex = 60;
            this.groupBoxInfoPedido.TabStop = false;
            this.groupBoxInfoPedido.Text = "Información de la Compra";
            // 
            // TxtIdCompra
            // 
            this.TxtIdCompra.Location = new System.Drawing.Point(216, 17);
            this.TxtIdCompra.Name = "TxtIdCompra";
            this.TxtIdCompra.Size = new System.Drawing.Size(48, 22);
            this.TxtIdCompra.TabIndex = 107;
            this.TxtIdCompra.Visible = false;
            // 
            // dtpFinVigencia
            // 
            this.dtpFinVigencia.Enabled = false;
            this.dtpFinVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinVigencia.Location = new System.Drawing.Point(654, 84);
            this.dtpFinVigencia.Name = "dtpFinVigencia";
            this.dtpFinVigencia.Size = new System.Drawing.Size(97, 20);
            this.dtpFinVigencia.TabIndex = 106;
            this.dtpFinVigencia.Value = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            // 
            // LblFinVigencia
            // 
            this.LblFinVigencia.AutoSize = true;
            this.LblFinVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFinVigencia.Location = new System.Drawing.Point(651, 68);
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
            this.dtpInicioVigencia.Location = new System.Drawing.Point(549, 84);
            this.dtpInicioVigencia.Name = "dtpInicioVigencia";
            this.dtpInicioVigencia.Size = new System.Drawing.Size(97, 20);
            this.dtpInicioVigencia.TabIndex = 104;
            this.dtpInicioVigencia.Value = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            // 
            // LblInicioVigencia
            // 
            this.LblInicioVigencia.AutoSize = true;
            this.LblInicioVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInicioVigencia.Location = new System.Drawing.Point(546, 68);
            this.LblInicioVigencia.Name = "LblInicioVigencia";
            this.LblInicioVigencia.Size = new System.Drawing.Size(79, 13);
            this.LblInicioVigencia.TabIndex = 103;
            this.LblInicioVigencia.Text = "Inicio Vigencia:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(483, 45);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.ReadOnly = true;
            this.TxtUsuario.Size = new System.Drawing.Size(129, 22);
            this.TxtUsuario.TabIndex = 102;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(480, 29);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(46, 13);
            this.LblUsuario.TabIndex = 101;
            this.LblUsuario.Text = "Usuario:";
            // 
            // TxtFormaPago
            // 
            this.TxtFormaPago.Location = new System.Drawing.Point(304, 45);
            this.TxtFormaPago.Name = "TxtFormaPago";
            this.TxtFormaPago.ReadOnly = true;
            this.TxtFormaPago.Size = new System.Drawing.Size(173, 22);
            this.TxtFormaPago.TabIndex = 100;
            // 
            // TxtTipoDoc
            // 
            this.TxtTipoDoc.Location = new System.Drawing.Point(123, 43);
            this.TxtTipoDoc.Name = "TxtTipoDoc";
            this.TxtTipoDoc.ReadOnly = true;
            this.TxtTipoDoc.Size = new System.Drawing.Size(173, 22);
            this.TxtTipoDoc.TabIndex = 99;
            // 
            // TxtTimbrado
            // 
            this.TxtTimbrado.Location = new System.Drawing.Point(426, 86);
            this.TxtTimbrado.Name = "TxtTimbrado";
            this.TxtTimbrado.ReadOnly = true;
            this.TxtTimbrado.Size = new System.Drawing.Size(112, 22);
            this.TxtTimbrado.TabIndex = 98;
            // 
            // LblTimbrado
            // 
            this.LblTimbrado.AutoSize = true;
            this.LblTimbrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimbrado.Location = new System.Drawing.Point(423, 70);
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
            // LblFormaPago
            // 
            this.LblFormaPago.AutoSize = true;
            this.LblFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormaPago.Location = new System.Drawing.Point(301, 27);
            this.LblFormaPago.Name = "LblFormaPago";
            this.LblFormaPago.Size = new System.Drawing.Size(67, 13);
            this.LblFormaPago.TabIndex = 89;
            this.LblFormaPago.Text = "Forma Pago:";
            // 
            // LblTipoDoc
            // 
            this.LblTipoDoc.AutoSize = true;
            this.LblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoDoc.Location = new System.Drawing.Point(120, 27);
            this.LblTipoDoc.Name = "LblTipoDoc";
            this.LblTipoDoc.Size = new System.Drawing.Size(89, 13);
            this.LblTipoDoc.TabIndex = 8;
            this.LblTipoDoc.Text = "Tipo Documento:";
            // 
            // TxtObs
            // 
            this.TxtObs.Location = new System.Drawing.Point(8, 128);
            this.TxtObs.Name = "TxtObs";
            this.TxtObs.ReadOnly = true;
            this.TxtObs.Size = new System.Drawing.Size(1169, 22);
            this.TxtObs.TabIndex = 7;
            // 
            // LblObs
            // 
            this.LblObs.AutoSize = true;
            this.LblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObs.Location = new System.Drawing.Point(5, 111);
            this.LblObs.Name = "LblObs";
            this.LblObs.Size = new System.Drawing.Size(70, 13);
            this.LblObs.TabIndex = 6;
            this.LblObs.Text = "Observación:";
            // 
            // TxtNroPedido
            // 
            this.TxtNroPedido.Location = new System.Drawing.Point(8, 43);
            this.TxtNroPedido.Name = "TxtNroPedido";
            this.TxtNroPedido.ReadOnly = true;
            this.TxtNroPedido.Size = new System.Drawing.Size(100, 22);
            this.TxtNroPedido.TabIndex = 5;
            this.TxtNroPedido.Text = "0";
            // 
            // LboNroPedido
            // 
            this.LboNroPedido.AutoSize = true;
            this.LboNroPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LboNroPedido.Location = new System.Drawing.Point(5, 27);
            this.LboNroPedido.Name = "LboNroPedido";
            this.LboNroPedido.Size = new System.Drawing.Size(83, 13);
            this.LboNroPedido.TabIndex = 4;
            this.LboNroPedido.Text = "Número Pedido:";
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
            // checkBoxConfirmado
            // 
            this.checkBoxConfirmado.AutoSize = true;
            this.checkBoxConfirmado.Location = new System.Drawing.Point(818, 51);
            this.checkBoxConfirmado.Name = "checkBoxConfirmado";
            this.checkBoxConfirmado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxConfirmado.TabIndex = 106;
            this.checkBoxConfirmado.UseVisualStyleBackColor = true;
            this.checkBoxConfirmado.Visible = false;
            // 
            // PbNoConfirmado
            // 
            this.PbNoConfirmado.BackColor = System.Drawing.Color.White;
            this.PbNoConfirmado.Image = global::CapaPresentacion.Properties.Resources.cancelar;
            this.PbNoConfirmado.Location = new System.Drawing.Point(994, 34);
            this.PbNoConfirmado.Name = "PbNoConfirmado";
            this.PbNoConfirmado.Size = new System.Drawing.Size(43, 39);
            this.PbNoConfirmado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbNoConfirmado.TabIndex = 105;
            this.PbNoConfirmado.TabStop = false;
            // 
            // LblNoConfirmado
            // 
            this.LblNoConfirmado.AutoSize = true;
            this.LblNoConfirmado.BackColor = System.Drawing.Color.White;
            this.LblNoConfirmado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNoConfirmado.ForeColor = System.Drawing.Color.DarkOrange;
            this.LblNoConfirmado.Location = new System.Drawing.Point(851, 45);
            this.LblNoConfirmado.Name = "LblNoConfirmado";
            this.LblNoConfirmado.Size = new System.Drawing.Size(137, 24);
            this.LblNoConfirmado.TabIndex = 104;
            this.LblNoConfirmado.Text = "No Confirmado";
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
            this.BtnLimpiar.Location = new System.Drawing.Point(279, 30);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(43, 26);
            this.BtnLimpiar.TabIndex = 103;
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
            this.BtnBuscar.Location = new System.Drawing.Point(232, 30);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(43, 26);
            this.BtnBuscar.TabIndex = 102;
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(72, 34);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(155, 20);
            this.TxtBusqueda.TabIndex = 100;
            this.TxtBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBusqueda_KeyDown);
            // 
            // LblFactura
            // 
            this.LblFactura.AutoSize = true;
            this.LblFactura.BackColor = System.Drawing.Color.White;
            this.LblFactura.Location = new System.Drawing.Point(20, 37);
            this.LblFactura.Name = "LblFactura";
            this.LblFactura.Size = new System.Drawing.Size(46, 13);
            this.LblFactura.TabIndex = 101;
            this.LblFactura.Text = "Factura:";
            // 
            // PbConfirmado
            // 
            this.PbConfirmado.BackColor = System.Drawing.Color.White;
            this.PbConfirmado.Image = global::CapaPresentacion.Properties.Resources.OK;
            this.PbConfirmado.Location = new System.Drawing.Point(994, 34);
            this.PbConfirmado.Name = "PbConfirmado";
            this.PbConfirmado.Size = new System.Drawing.Size(43, 39);
            this.PbConfirmado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbConfirmado.TabIndex = 107;
            this.PbConfirmado.TabStop = false;
            // 
            // LblConfirmado
            // 
            this.LblConfirmado.AutoSize = true;
            this.LblConfirmado.BackColor = System.Drawing.Color.White;
            this.LblConfirmado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConfirmado.ForeColor = System.Drawing.Color.Green;
            this.LblConfirmado.Location = new System.Drawing.Point(881, 45);
            this.LblConfirmado.Name = "LblConfirmado";
            this.LblConfirmado.Size = new System.Drawing.Size(107, 24);
            this.LblConfirmado.TabIndex = 108;
            this.LblConfirmado.Text = "Confirmado";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.BtnGuardar.IconColor = System.Drawing.Color.White;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.IconSize = 16;
            this.BtnGuardar.Location = new System.Drawing.Point(1046, 319);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(142, 27);
            this.BtnGuardar.TabIndex = 110;
            this.BtnGuardar.Text = "Imprimir";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // checkBoxAnulado
            // 
            this.checkBoxAnulado.AutoSize = true;
            this.checkBoxAnulado.Location = new System.Drawing.Point(818, 71);
            this.checkBoxAnulado.Name = "checkBoxAnulado";
            this.checkBoxAnulado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAnulado.TabIndex = 111;
            this.checkBoxAnulado.UseVisualStyleBackColor = true;
            this.checkBoxAnulado.Visible = false;
            // 
            // LblAnulado
            // 
            this.LblAnulado.AutoSize = true;
            this.LblAnulado.BackColor = System.Drawing.Color.White;
            this.LblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnulado.ForeColor = System.Drawing.Color.Red;
            this.LblAnulado.Location = new System.Drawing.Point(907, 43);
            this.LblAnulado.Name = "LblAnulado";
            this.LblAnulado.Size = new System.Drawing.Size(81, 24);
            this.LblAnulado.TabIndex = 112;
            this.LblAnulado.Text = "Anulado";
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnConfirmar.IconColor = System.Drawing.Color.White;
            this.BtnConfirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConfirmar.IconSize = 16;
            this.BtnConfirmar.Location = new System.Drawing.Point(880, 319);
            this.BtnConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(142, 27);
            this.BtnConfirmar.TabIndex = 114;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // dtpFechaRec
            // 
            this.dtpFechaRec.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRec.Location = new System.Drawing.Point(880, 282);
            this.dtpFechaRec.Name = "dtpFechaRec";
            this.dtpFechaRec.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaRec.TabIndex = 118;
            this.dtpFechaRec.Value = new System.DateTime(2023, 11, 2, 22, 3, 29, 0);
            this.dtpFechaRec.ValueChanged += new System.EventHandler(this.dtpFechaRec_ValueChanged);
            // 
            // LblFechaRec
            // 
            this.LblFechaRec.AutoSize = true;
            this.LblFechaRec.BackColor = System.Drawing.Color.White;
            this.LblFechaRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaRec.Location = new System.Drawing.Point(877, 265);
            this.LblFechaRec.Name = "LblFechaRec";
            this.LblFechaRec.Size = new System.Drawing.Size(130, 13);
            this.LblFechaRec.TabIndex = 117;
            this.LblFechaRec.Text = "Asignar Fecha Recepción";
            // 
            // BtnAnular
            // 
            this.BtnAnular.BackColor = System.Drawing.Color.Red;
            this.BtnAnular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAnular.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnular.ForeColor = System.Drawing.Color.White;
            this.BtnAnular.IconChar = FontAwesome.Sharp.IconChar.X;
            this.BtnAnular.IconColor = System.Drawing.Color.White;
            this.BtnAnular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAnular.IconSize = 16;
            this.BtnAnular.Location = new System.Drawing.Point(880, 371);
            this.BtnAnular.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAnular.Name = "BtnAnular";
            this.BtnAnular.Size = new System.Drawing.Size(142, 27);
            this.BtnAnular.TabIndex = 127;
            this.BtnAnular.Text = "Anular";
            this.BtnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAnular.UseVisualStyleBackColor = false;
            this.BtnAnular.Click += new System.EventHandler(this.BtnAnular_Click);
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
            // FrmVerDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 530);
            this.Controls.Add(this.BtnAnular);
            this.Controls.Add(this.dtpFechaRec);
            this.Controls.Add(this.LblFechaRec);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.LblAnulado);
            this.Controls.Add(this.checkBoxAnulado);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblConfirmado);
            this.Controls.Add(this.PbConfirmado);
            this.Controls.Add(this.checkBoxConfirmado);
            this.Controls.Add(this.PbNoConfirmado);
            this.Controls.Add(this.LblNoConfirmado);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.LblFactura);
            this.Controls.Add(this.LblTotalCompra);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.TxtTotalCompra);
            this.Controls.Add(this.groupBoxInfoPedido);
            this.Controls.Add(this.LblCompras);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmVerDetalleCompra";
            this.Text = "Consulta de Compra";
            this.Load += new System.EventHandler(this.FrmVerDetalleCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBoxInfoProveedor.ResumeLayout(false);
            this.groupBoxInfoProveedor.PerformLayout();
            this.groupBoxInfoPedido.ResumeLayout(false);
            this.groupBoxInfoPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbNoConfirmado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbConfirmado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCompras;
        private System.Windows.Forms.Label LblTotalCompra;
        private System.Windows.Forms.TextBox TxtIdProveedor;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.Label LblRazonSocial;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox groupBoxInfoProveedor;
        private System.Windows.Forms.TextBox TxtRUC;
        private System.Windows.Forms.Label LblRUC;
        private System.Windows.Forms.TextBox TxtTotalCompra;
        private System.Windows.Forms.GroupBox groupBoxInfoPedido;
        private System.Windows.Forms.TextBox TxtFormaPago;
        private System.Windows.Forms.TextBox TxtTipoDoc;
        private System.Windows.Forms.TextBox TxtTimbrado;
        private System.Windows.Forms.Label LblTimbrado;
        private System.Windows.Forms.TextBox TxtDoc;
        private System.Windows.Forms.TextBox TxtPuntoEmision;
        private System.Windows.Forms.Label LblCodEstablecimiento;
        private System.Windows.Forms.TextBox TxtCodEstablecimiento;
        private System.Windows.Forms.Label LblFormaPago;
        private System.Windows.Forms.Label LblTipoDoc;
        private System.Windows.Forms.TextBox TxtObs;
        private System.Windows.Forms.Label LblObs;
        private System.Windows.Forms.TextBox TxtNroPedido;
        private System.Windows.Forms.Label LboNroPedido;
        private System.Windows.Forms.DateTimePicker dtpFechaVenc;
        private System.Windows.Forms.Label LblFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.CheckBox checkBoxConfirmado;
        private System.Windows.Forms.PictureBox PbNoConfirmado;
        private System.Windows.Forms.Label LblNoConfirmado;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Label LblFactura;
        private System.Windows.Forms.PictureBox PbConfirmado;
        private System.Windows.Forms.Label LblConfirmado;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.CheckBox checkBoxAnulado;
        private System.Windows.Forms.Label LblAnulado;
        private System.Windows.Forms.DateTimePicker dtpFinVigencia;
        private System.Windows.Forms.Label LblFinVigencia;
        private System.Windows.Forms.DateTimePicker dtpInicioVigencia;
        private System.Windows.Forms.Label LblInicioVigencia;
        private FontAwesome.Sharp.IconButton BtnConfirmar;
        private System.Windows.Forms.TextBox TxtIdCompra;
        private System.Windows.Forms.DateTimePicker dtpFechaRec;
        private System.Windows.Forms.Label LblFechaRec;
        private FontAwesome.Sharp.IconButton BtnAnular;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEliminar;
    }
}
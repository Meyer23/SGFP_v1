namespace CapaPresentacion
{
    partial class FrmVerDetalleNCEmitida
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
            this.LblAnulado = new System.Windows.Forms.Label();
            this.checkBoxAnulado = new System.Windows.Forms.CheckBox();
            this.LblConfirmado = new System.Windows.Forms.Label();
            this.checkBoxConfirmado = new System.Windows.Forms.CheckBox();
            this.LblNoConfirmado = new System.Windows.Forms.Label();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.LblNCRecibida = new System.Windows.Forms.Label();
            this.LblTotalNota = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TxtTotalNota = new System.Windows.Forms.TextBox();
            this.groupBoxInfoPedido = new System.Windows.Forms.GroupBox();
            this.TxtIdVenta = new System.Windows.Forms.TextBox();
            this.TxtIdNCEmitida = new System.Windows.Forms.TextBox();
            this.dtpFinVigencia = new System.Windows.Forms.DateTimePicker();
            this.LblFinVigencia = new System.Windows.Forms.Label();
            this.dtpInicioVigencia = new System.Windows.Forms.DateTimePicker();
            this.LblInicioVigencia = new System.Windows.Forms.Label();
            this.TxtCajero = new System.Windows.Forms.TextBox();
            this.LblCajero = new System.Windows.Forms.Label();
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
            this.LblTipoDoc = new System.Windows.Forms.Label();
            this.TxtObs = new System.Windows.Forms.TextBox();
            this.LblObs = new System.Windows.Forms.Label();
            this.TxtFacturaCompra = new System.Windows.Forms.TextBox();
            this.LboNroFacturaVenta = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblCompras = new System.Windows.Forms.Label();
            this.PbConfirmado = new System.Windows.Forms.PictureBox();
            this.PbNoConfirmado = new System.Windows.Forms.PictureBox();
            this.BtnAnularNCEmitida = new FontAwesome.Sharp.IconButton();
            this.BtnConfirmarNCEmitida = new FontAwesome.Sharp.IconButton();
            this.BtnImprimirNCEmitida = new FontAwesome.Sharp.IconButton();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBoxInfoPedido.SuspendLayout();
            this.groupBoxInfoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbConfirmado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNoConfirmado)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAnulado
            // 
            this.LblAnulado.AutoSize = true;
            this.LblAnulado.BackColor = System.Drawing.Color.White;
            this.LblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnulado.ForeColor = System.Drawing.Color.Red;
            this.LblAnulado.Location = new System.Drawing.Point(916, 28);
            this.LblAnulado.Name = "LblAnulado";
            this.LblAnulado.Size = new System.Drawing.Size(81, 24);
            this.LblAnulado.TabIndex = 161;
            this.LblAnulado.Text = "Anulado";
            // 
            // checkBoxAnulado
            // 
            this.checkBoxAnulado.AutoSize = true;
            this.checkBoxAnulado.Location = new System.Drawing.Point(803, 36);
            this.checkBoxAnulado.Name = "checkBoxAnulado";
            this.checkBoxAnulado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAnulado.TabIndex = 160;
            this.checkBoxAnulado.UseVisualStyleBackColor = true;
            this.checkBoxAnulado.Visible = false;
            // 
            // LblConfirmado
            // 
            this.LblConfirmado.AutoSize = true;
            this.LblConfirmado.BackColor = System.Drawing.Color.White;
            this.LblConfirmado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConfirmado.ForeColor = System.Drawing.Color.Green;
            this.LblConfirmado.Location = new System.Drawing.Point(890, 30);
            this.LblConfirmado.Name = "LblConfirmado";
            this.LblConfirmado.Size = new System.Drawing.Size(107, 24);
            this.LblConfirmado.TabIndex = 158;
            this.LblConfirmado.Text = "Confirmado";
            // 
            // checkBoxConfirmado
            // 
            this.checkBoxConfirmado.AutoSize = true;
            this.checkBoxConfirmado.Location = new System.Drawing.Point(827, 36);
            this.checkBoxConfirmado.Name = "checkBoxConfirmado";
            this.checkBoxConfirmado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxConfirmado.TabIndex = 157;
            this.checkBoxConfirmado.UseVisualStyleBackColor = true;
            this.checkBoxConfirmado.Visible = false;
            // 
            // LblNoConfirmado
            // 
            this.LblNoConfirmado.AutoSize = true;
            this.LblNoConfirmado.BackColor = System.Drawing.Color.White;
            this.LblNoConfirmado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNoConfirmado.ForeColor = System.Drawing.Color.DarkOrange;
            this.LblNoConfirmado.Location = new System.Drawing.Point(860, 30);
            this.LblNoConfirmado.Name = "LblNoConfirmado";
            this.LblNoConfirmado.Size = new System.Drawing.Size(137, 24);
            this.LblNoConfirmado.TabIndex = 156;
            this.LblNoConfirmado.Text = "No Confirmado";
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(119, 25);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(155, 20);
            this.TxtBusqueda.TabIndex = 152;
            this.TxtBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBusqueda_KeyDown);
            // 
            // LblNCRecibida
            // 
            this.LblNCRecibida.AutoSize = true;
            this.LblNCRecibida.BackColor = System.Drawing.Color.White;
            this.LblNCRecibida.Location = new System.Drawing.Point(29, 28);
            this.LblNCRecibida.Name = "LblNCRecibida";
            this.LblNCRecibida.Size = new System.Drawing.Size(84, 13);
            this.LblNCRecibida.TabIndex = 153;
            this.LblNCRecibida.Text = "Nota de Crédito:";
            // 
            // LblTotalNota
            // 
            this.LblTotalNota.AutoSize = true;
            this.LblTotalNota.BackColor = System.Drawing.Color.White;
            this.LblTotalNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalNota.Location = new System.Drawing.Point(892, 495);
            this.LblTotalNota.Name = "LblTotalNota";
            this.LblTotalNota.Size = new System.Drawing.Size(82, 20);
            this.LblTotalNota.TabIndex = 150;
            this.LblTotalNota.Text = "Total Nota";
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
            this.dgvData.Location = new System.Drawing.Point(32, 306);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(829, 236);
            this.dgvData.TabIndex = 149;
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
            // TxtTotalNota
            // 
            this.TxtTotalNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalNota.Location = new System.Drawing.Point(894, 516);
            this.TxtTotalNota.Name = "TxtTotalNota";
            this.TxtTotalNota.ReadOnly = true;
            this.TxtTotalNota.Size = new System.Drawing.Size(192, 26);
            this.TxtTotalNota.TabIndex = 151;
            this.TxtTotalNota.Text = "0";
            // 
            // groupBoxInfoPedido
            // 
            this.groupBoxInfoPedido.BackColor = System.Drawing.Color.White;
            this.groupBoxInfoPedido.Controls.Add(this.TxtIdVenta);
            this.groupBoxInfoPedido.Controls.Add(this.TxtIdNCEmitida);
            this.groupBoxInfoPedido.Controls.Add(this.dtpFinVigencia);
            this.groupBoxInfoPedido.Controls.Add(this.LblFinVigencia);
            this.groupBoxInfoPedido.Controls.Add(this.dtpInicioVigencia);
            this.groupBoxInfoPedido.Controls.Add(this.LblInicioVigencia);
            this.groupBoxInfoPedido.Controls.Add(this.TxtCajero);
            this.groupBoxInfoPedido.Controls.Add(this.LblCajero);
            this.groupBoxInfoPedido.Controls.Add(this.TxtTipoDoc);
            this.groupBoxInfoPedido.Controls.Add(this.TxtTimbrado);
            this.groupBoxInfoPedido.Controls.Add(this.LblTimbrado);
            this.groupBoxInfoPedido.Controls.Add(this.TxtDoc);
            this.groupBoxInfoPedido.Controls.Add(this.TxtPuntoEmision);
            this.groupBoxInfoPedido.Controls.Add(this.LblCodEstablecimiento);
            this.groupBoxInfoPedido.Controls.Add(this.TxtCodEstablecimiento);
            this.groupBoxInfoPedido.Controls.Add(this.groupBoxInfoCliente);
            this.groupBoxInfoPedido.Controls.Add(this.LblTipoDoc);
            this.groupBoxInfoPedido.Controls.Add(this.TxtObs);
            this.groupBoxInfoPedido.Controls.Add(this.LblObs);
            this.groupBoxInfoPedido.Controls.Add(this.TxtFacturaCompra);
            this.groupBoxInfoPedido.Controls.Add(this.LboNroFacturaVenta);
            this.groupBoxInfoPedido.Controls.Add(this.dtpFecha);
            this.groupBoxInfoPedido.Controls.Add(this.LblFecha);
            this.groupBoxInfoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoPedido.Location = new System.Drawing.Point(32, 76);
            this.groupBoxInfoPedido.Name = "groupBoxInfoPedido";
            this.groupBoxInfoPedido.Size = new System.Drawing.Size(1170, 198);
            this.groupBoxInfoPedido.TabIndex = 148;
            this.groupBoxInfoPedido.TabStop = false;
            this.groupBoxInfoPedido.Text = "Información de la Nota de Crédito";
            // 
            // TxtIdVenta
            // 
            this.TxtIdVenta.Location = new System.Drawing.Point(512, 81);
            this.TxtIdVenta.Name = "TxtIdVenta";
            this.TxtIdVenta.Size = new System.Drawing.Size(100, 22);
            this.TxtIdVenta.TabIndex = 108;
            this.TxtIdVenta.Visible = false;
            // 
            // TxtIdNCEmitida
            // 
            this.TxtIdNCEmitida.Location = new System.Drawing.Point(216, 17);
            this.TxtIdNCEmitida.Name = "TxtIdNCEmitida";
            this.TxtIdNCEmitida.Size = new System.Drawing.Size(48, 22);
            this.TxtIdNCEmitida.TabIndex = 107;
            this.TxtIdNCEmitida.Visible = false;
            // 
            // dtpFinVigencia
            // 
            this.dtpFinVigencia.Enabled = false;
            this.dtpFinVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinVigencia.Location = new System.Drawing.Point(237, 92);
            this.dtpFinVigencia.Name = "dtpFinVigencia";
            this.dtpFinVigencia.Size = new System.Drawing.Size(97, 20);
            this.dtpFinVigencia.TabIndex = 106;
            this.dtpFinVigencia.Value = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            // 
            // LblFinVigencia
            // 
            this.LblFinVigencia.AutoSize = true;
            this.LblFinVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFinVigencia.Location = new System.Drawing.Point(234, 76);
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
            this.dtpInicioVigencia.Location = new System.Drawing.Point(132, 92);
            this.dtpInicioVigencia.Name = "dtpInicioVigencia";
            this.dtpInicioVigencia.Size = new System.Drawing.Size(97, 20);
            this.dtpInicioVigencia.TabIndex = 104;
            this.dtpInicioVigencia.Value = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            // 
            // LblInicioVigencia
            // 
            this.LblInicioVigencia.AutoSize = true;
            this.LblInicioVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInicioVigencia.Location = new System.Drawing.Point(129, 76);
            this.LblInicioVigencia.Name = "LblInicioVigencia";
            this.LblInicioVigencia.Size = new System.Drawing.Size(79, 13);
            this.LblInicioVigencia.TabIndex = 103;
            this.LblInicioVigencia.Text = "Inicio Vigencia:";
            // 
            // TxtCajero
            // 
            this.TxtCajero.Location = new System.Drawing.Point(360, 94);
            this.TxtCajero.Name = "TxtCajero";
            this.TxtCajero.ReadOnly = true;
            this.TxtCajero.Size = new System.Drawing.Size(129, 22);
            this.TxtCajero.TabIndex = 102;
            // 
            // LblCajero
            // 
            this.LblCajero.AutoSize = true;
            this.LblCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCajero.Location = new System.Drawing.Point(357, 78);
            this.LblCajero.Name = "LblCajero";
            this.LblCajero.Size = new System.Drawing.Size(40, 13);
            this.LblCajero.TabIndex = 101;
            this.LblCajero.Text = "Cajero:";
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
            this.TxtTimbrado.Location = new System.Drawing.Point(9, 94);
            this.TxtTimbrado.Name = "TxtTimbrado";
            this.TxtTimbrado.ReadOnly = true;
            this.TxtTimbrado.Size = new System.Drawing.Size(112, 22);
            this.TxtTimbrado.TabIndex = 98;
            // 
            // LblTimbrado
            // 
            this.LblTimbrado.AutoSize = true;
            this.LblTimbrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimbrado.Location = new System.Drawing.Point(6, 78);
            this.LblTimbrado.Name = "LblTimbrado";
            this.LblTimbrado.Size = new System.Drawing.Size(54, 13);
            this.LblTimbrado.TabIndex = 97;
            this.LblTimbrado.Text = "Timbrado:";
            // 
            // TxtDoc
            // 
            this.TxtDoc.Location = new System.Drawing.Point(404, 44);
            this.TxtDoc.Name = "TxtDoc";
            this.TxtDoc.ReadOnly = true;
            this.TxtDoc.Size = new System.Drawing.Size(90, 22);
            this.TxtDoc.TabIndex = 96;
            // 
            // TxtPuntoEmision
            // 
            this.TxtPuntoEmision.Location = new System.Drawing.Point(363, 44);
            this.TxtPuntoEmision.Name = "TxtPuntoEmision";
            this.TxtPuntoEmision.ReadOnly = true;
            this.TxtPuntoEmision.Size = new System.Drawing.Size(35, 22);
            this.TxtPuntoEmision.TabIndex = 95;
            // 
            // LblCodEstablecimiento
            // 
            this.LblCodEstablecimiento.AutoSize = true;
            this.LblCodEstablecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodEstablecimiento.Location = new System.Drawing.Point(319, 26);
            this.LblCodEstablecimiento.Name = "LblCodEstablecimiento";
            this.LblCodEstablecimiento.Size = new System.Drawing.Size(84, 13);
            this.LblCodEstablecimiento.TabIndex = 94;
            this.LblCodEstablecimiento.Text = "Nota de Crédito:";
            // 
            // TxtCodEstablecimiento
            // 
            this.TxtCodEstablecimiento.Location = new System.Drawing.Point(322, 44);
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
            this.groupBoxInfoCliente.Location = new System.Drawing.Point(742, 28);
            this.groupBoxInfoCliente.Name = "groupBoxInfoCliente";
            this.groupBoxInfoCliente.Size = new System.Drawing.Size(411, 75);
            this.groupBoxInfoCliente.TabIndex = 27;
            this.groupBoxInfoCliente.TabStop = false;
            this.groupBoxInfoCliente.Text = "Información del Cliente";
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Location = new System.Drawing.Point(234, 12);
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
            this.LblRazonSocial.Size = new System.Drawing.Size(73, 13);
            this.LblRazonSocial.TabIndex = 61;
            this.LblRazonSocial.Text = "Razón Social:";
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
            this.TxtObs.Location = new System.Drawing.Point(9, 150);
            this.TxtObs.Name = "TxtObs";
            this.TxtObs.ReadOnly = true;
            this.TxtObs.Size = new System.Drawing.Size(1134, 22);
            this.TxtObs.TabIndex = 7;
            // 
            // LblObs
            // 
            this.LblObs.AutoSize = true;
            this.LblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObs.Location = new System.Drawing.Point(6, 133);
            this.LblObs.Name = "LblObs";
            this.LblObs.Size = new System.Drawing.Size(70, 13);
            this.LblObs.TabIndex = 6;
            this.LblObs.Text = "Observación:";
            // 
            // TxtFacturaCompra
            // 
            this.TxtFacturaCompra.Location = new System.Drawing.Point(8, 43);
            this.TxtFacturaCompra.Name = "TxtFacturaCompra";
            this.TxtFacturaCompra.ReadOnly = true;
            this.TxtFacturaCompra.Size = new System.Drawing.Size(100, 22);
            this.TxtFacturaCompra.TabIndex = 5;
            this.TxtFacturaCompra.Text = "0";
            // 
            // LboNroFacturaVenta
            // 
            this.LboNroFacturaVenta.AutoSize = true;
            this.LboNroFacturaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LboNroFacturaVenta.Location = new System.Drawing.Point(5, 27);
            this.LboNroFacturaVenta.Name = "LboNroFacturaVenta";
            this.LboNroFacturaVenta.Size = new System.Drawing.Size(77, 13);
            this.LboNroFacturaVenta.TabIndex = 4;
            this.LboNroFacturaVenta.Text = "Factura Venta:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(512, 44);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(97, 20);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.Value = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(509, 28);
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
            this.LblCompras.TabIndex = 147;
            this.LblCompras.Text = " ";
            // 
            // PbConfirmado
            // 
            this.PbConfirmado.BackColor = System.Drawing.Color.White;
            this.PbConfirmado.Image = global::CapaPresentacion.Properties.Resources.OK;
            this.PbConfirmado.Location = new System.Drawing.Point(1003, 19);
            this.PbConfirmado.Name = "PbConfirmado";
            this.PbConfirmado.Size = new System.Drawing.Size(43, 39);
            this.PbConfirmado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbConfirmado.TabIndex = 165;
            this.PbConfirmado.TabStop = false;
            // 
            // PbNoConfirmado
            // 
            this.PbNoConfirmado.BackColor = System.Drawing.Color.White;
            this.PbNoConfirmado.Image = global::CapaPresentacion.Properties.Resources.cancelar;
            this.PbNoConfirmado.Location = new System.Drawing.Point(1003, 19);
            this.PbNoConfirmado.Name = "PbNoConfirmado";
            this.PbNoConfirmado.Size = new System.Drawing.Size(43, 39);
            this.PbNoConfirmado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbNoConfirmado.TabIndex = 164;
            this.PbNoConfirmado.TabStop = false;
            // 
            // BtnAnularNCEmitida
            // 
            this.BtnAnularNCEmitida.BackColor = System.Drawing.Color.Red;
            this.BtnAnularNCEmitida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAnularNCEmitida.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAnularNCEmitida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnularNCEmitida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnularNCEmitida.ForeColor = System.Drawing.Color.White;
            this.BtnAnularNCEmitida.IconChar = FontAwesome.Sharp.IconChar.X;
            this.BtnAnularNCEmitida.IconColor = System.Drawing.Color.White;
            this.BtnAnularNCEmitida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAnularNCEmitida.IconSize = 16;
            this.BtnAnularNCEmitida.Location = new System.Drawing.Point(894, 412);
            this.BtnAnularNCEmitida.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAnularNCEmitida.Name = "BtnAnularNCEmitida";
            this.BtnAnularNCEmitida.Size = new System.Drawing.Size(142, 27);
            this.BtnAnularNCEmitida.TabIndex = 163;
            this.BtnAnularNCEmitida.Text = "Anular";
            this.BtnAnularNCEmitida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAnularNCEmitida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAnularNCEmitida.UseVisualStyleBackColor = false;
            this.BtnAnularNCEmitida.Click += new System.EventHandler(this.BtnAnularNCEmitida_Click);
            // 
            // BtnConfirmarNCEmitida
            // 
            this.BtnConfirmarNCEmitida.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnConfirmarNCEmitida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfirmarNCEmitida.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnConfirmarNCEmitida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmarNCEmitida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmarNCEmitida.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmarNCEmitida.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnConfirmarNCEmitida.IconColor = System.Drawing.Color.White;
            this.BtnConfirmarNCEmitida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConfirmarNCEmitida.IconSize = 16;
            this.BtnConfirmarNCEmitida.Location = new System.Drawing.Point(894, 360);
            this.BtnConfirmarNCEmitida.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConfirmarNCEmitida.Name = "BtnConfirmarNCEmitida";
            this.BtnConfirmarNCEmitida.Size = new System.Drawing.Size(142, 27);
            this.BtnConfirmarNCEmitida.TabIndex = 162;
            this.BtnConfirmarNCEmitida.Text = "Confirmar";
            this.BtnConfirmarNCEmitida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConfirmarNCEmitida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmarNCEmitida.UseVisualStyleBackColor = false;
            this.BtnConfirmarNCEmitida.Click += new System.EventHandler(this.BtnConfirmarNCEmitida_Click);
            // 
            // BtnImprimirNCEmitida
            // 
            this.BtnImprimirNCEmitida.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnImprimirNCEmitida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImprimirNCEmitida.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnImprimirNCEmitida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimirNCEmitida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimirNCEmitida.ForeColor = System.Drawing.Color.White;
            this.BtnImprimirNCEmitida.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.BtnImprimirNCEmitida.IconColor = System.Drawing.Color.White;
            this.BtnImprimirNCEmitida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImprimirNCEmitida.IconSize = 16;
            this.BtnImprimirNCEmitida.Location = new System.Drawing.Point(1060, 360);
            this.BtnImprimirNCEmitida.Margin = new System.Windows.Forms.Padding(2);
            this.BtnImprimirNCEmitida.Name = "BtnImprimirNCEmitida";
            this.BtnImprimirNCEmitida.Size = new System.Drawing.Size(142, 27);
            this.BtnImprimirNCEmitida.TabIndex = 159;
            this.BtnImprimirNCEmitida.Text = "Imprimir";
            this.BtnImprimirNCEmitida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnImprimirNCEmitida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImprimirNCEmitida.UseVisualStyleBackColor = false;
            this.BtnImprimirNCEmitida.Click += new System.EventHandler(this.BtnGuardar_Click);
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
            this.BtnLimpiar.Location = new System.Drawing.Point(326, 21);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(43, 26);
            this.BtnLimpiar.TabIndex = 155;
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click_1);
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
            this.BtnBuscar.Location = new System.Drawing.Point(279, 21);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(43, 26);
            this.BtnBuscar.TabIndex = 154;
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // FrmVerDetalleNCEmitida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 583);
            this.Controls.Add(this.PbConfirmado);
            this.Controls.Add(this.PbNoConfirmado);
            this.Controls.Add(this.BtnAnularNCEmitida);
            this.Controls.Add(this.BtnConfirmarNCEmitida);
            this.Controls.Add(this.LblAnulado);
            this.Controls.Add(this.checkBoxAnulado);
            this.Controls.Add(this.BtnImprimirNCEmitida);
            this.Controls.Add(this.LblConfirmado);
            this.Controls.Add(this.checkBoxConfirmado);
            this.Controls.Add(this.LblNoConfirmado);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.LblNCRecibida);
            this.Controls.Add(this.LblTotalNota);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.TxtTotalNota);
            this.Controls.Add(this.groupBoxInfoPedido);
            this.Controls.Add(this.LblCompras);
            this.Name = "FrmVerDetalleNCEmitida";
            this.Text = "Consulta de Nota de Crédito Emitida";
            this.Load += new System.EventHandler(this.FrmVerDetalleNCEmitida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBoxInfoPedido.ResumeLayout(false);
            this.groupBoxInfoPedido.PerformLayout();
            this.groupBoxInfoCliente.ResumeLayout(false);
            this.groupBoxInfoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbConfirmado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNoConfirmado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbNoConfirmado;
        private FontAwesome.Sharp.IconButton BtnAnularNCEmitida;
        private FontAwesome.Sharp.IconButton BtnConfirmarNCEmitida;
        private System.Windows.Forms.Label LblAnulado;
        private System.Windows.Forms.CheckBox checkBoxAnulado;
        private FontAwesome.Sharp.IconButton BtnImprimirNCEmitida;
        private System.Windows.Forms.Label LblConfirmado;
        private System.Windows.Forms.CheckBox checkBoxConfirmado;
        private System.Windows.Forms.Label LblNoConfirmado;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Label LblNCRecibida;
        private System.Windows.Forms.Label LblTotalNota;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEliminar;
        private System.Windows.Forms.TextBox TxtTotalNota;
        private System.Windows.Forms.GroupBox groupBoxInfoPedido;
        private System.Windows.Forms.TextBox TxtIdVenta;
        private System.Windows.Forms.TextBox TxtIdNCEmitida;
        private System.Windows.Forms.DateTimePicker dtpFinVigencia;
        private System.Windows.Forms.Label LblFinVigencia;
        private System.Windows.Forms.DateTimePicker dtpInicioVigencia;
        private System.Windows.Forms.Label LblInicioVigencia;
        private System.Windows.Forms.TextBox TxtCajero;
        private System.Windows.Forms.Label LblCajero;
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
        private System.Windows.Forms.Label LblTipoDoc;
        private System.Windows.Forms.TextBox TxtObs;
        private System.Windows.Forms.Label LblObs;
        private System.Windows.Forms.TextBox TxtFacturaCompra;
        private System.Windows.Forms.Label LboNroFacturaVenta;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblCompras;
        private System.Windows.Forms.PictureBox PbConfirmado;
    }
}
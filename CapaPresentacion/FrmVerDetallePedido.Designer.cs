﻿namespace CapaPresentacion
{
    partial class FrmVerDetallePedido
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
            this.LblPedidos = new System.Windows.Forms.Label();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.LblNroPedido = new System.Windows.Forms.Label();
            this.groupBoxInfoPedido = new System.Windows.Forms.GroupBox();
            this.TxtIdPedido = new System.Windows.Forms.TextBox();
            this.TxtFormaPago = new System.Windows.Forms.TextBox();
            this.TxtTipoDoc = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.groupBoxInfoProveedor = new System.Windows.Forms.GroupBox();
            this.TxtNumeroPedido = new System.Windows.Forms.TextBox();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.LblRazonSocial = new System.Windows.Forms.Label();
            this.TxtRUC = new System.Windows.Forms.TextBox();
            this.LblRUC = new System.Windows.Forms.Label();
            this.LblFormaPago = new System.Windows.Forms.Label();
            this.LblTipoDoc = new System.Windows.Forms.Label();
            this.TxtObs = new System.Windows.Forms.TextBox();
            this.LblObs = new System.Windows.Forms.Label();
            this.TxtNroPedido = new System.Windows.Forms.TextBox();
            this.LboNroPedido = new System.Windows.Forms.Label();
            this.dtpFechaRequerida = new System.Windows.Forms.DateTimePicker();
            this.LblFechaRequerida = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.LblFecha = new System.Windows.Forms.Label();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtTotalPedido = new System.Windows.Forms.TextBox();
            this.LblTotalCompra = new System.Windows.Forms.Label();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.PbConfirmado = new System.Windows.Forms.PictureBox();
            this.LblConfirmado = new System.Windows.Forms.Label();
            this.LblNoConfirmado = new System.Windows.Forms.Label();
            this.PbNoConfirmado = new System.Windows.Forms.PictureBox();
            this.checkBoxConfirmado = new System.Windows.Forms.CheckBox();
            this.BtnConfirmarPedido = new FontAwesome.Sharp.IconButton();
            this.BtnAnularPedido = new FontAwesome.Sharp.IconButton();
            this.LblAnulado = new System.Windows.Forms.Label();
            this.checkBoxAnulado = new System.Windows.Forms.CheckBox();
            this.groupBoxInfoPedido.SuspendLayout();
            this.groupBoxInfoProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbConfirmado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNoConfirmado)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPedidos
            // 
            this.LblPedidos.BackColor = System.Drawing.Color.White;
            this.LblPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPedidos.Location = new System.Drawing.Point(11, 9);
            this.LblPedidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPedidos.Name = "LblPedidos";
            this.LblPedidos.Padding = new System.Windows.Forms.Padding(2);
            this.LblPedidos.Size = new System.Drawing.Size(1004, 519);
            this.LblPedidos.TabIndex = 25;
            this.LblPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(110, 33);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(155, 20);
            this.TxtBusqueda.TabIndex = 86;
            this.TxtBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBusqueda_KeyDown);
            // 
            // LblNroPedido
            // 
            this.LblNroPedido.AutoSize = true;
            this.LblNroPedido.BackColor = System.Drawing.Color.White;
            this.LblNroPedido.Location = new System.Drawing.Point(22, 36);
            this.LblNroPedido.Name = "LblNroPedido";
            this.LblNroPedido.Size = new System.Drawing.Size(83, 13);
            this.LblNroPedido.TabIndex = 87;
            this.LblNroPedido.Text = "Número Pedido:";
            // 
            // groupBoxInfoPedido
            // 
            this.groupBoxInfoPedido.BackColor = System.Drawing.Color.White;
            this.groupBoxInfoPedido.Controls.Add(this.TxtIdPedido);
            this.groupBoxInfoPedido.Controls.Add(this.TxtFormaPago);
            this.groupBoxInfoPedido.Controls.Add(this.TxtTipoDoc);
            this.groupBoxInfoPedido.Controls.Add(this.TxtUsuario);
            this.groupBoxInfoPedido.Controls.Add(this.LblUsuario);
            this.groupBoxInfoPedido.Controls.Add(this.groupBoxInfoProveedor);
            this.groupBoxInfoPedido.Controls.Add(this.LblFormaPago);
            this.groupBoxInfoPedido.Controls.Add(this.LblTipoDoc);
            this.groupBoxInfoPedido.Controls.Add(this.TxtObs);
            this.groupBoxInfoPedido.Controls.Add(this.LblObs);
            this.groupBoxInfoPedido.Controls.Add(this.TxtNroPedido);
            this.groupBoxInfoPedido.Controls.Add(this.LboNroPedido);
            this.groupBoxInfoPedido.Controls.Add(this.dtpFechaRequerida);
            this.groupBoxInfoPedido.Controls.Add(this.LblFechaRequerida);
            this.groupBoxInfoPedido.Controls.Add(this.dtpFecha);
            this.groupBoxInfoPedido.Controls.Add(this.LblFecha);
            this.groupBoxInfoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoPedido.Location = new System.Drawing.Point(16, 81);
            this.groupBoxInfoPedido.Name = "groupBoxInfoPedido";
            this.groupBoxInfoPedido.Size = new System.Drawing.Size(966, 160);
            this.groupBoxInfoPedido.TabIndex = 90;
            this.groupBoxInfoPedido.TabStop = false;
            this.groupBoxInfoPedido.Text = "Información del Pedido";
            // 
            // TxtIdPedido
            // 
            this.TxtIdPedido.Location = new System.Drawing.Point(183, 12);
            this.TxtIdPedido.Name = "TxtIdPedido";
            this.TxtIdPedido.Size = new System.Drawing.Size(17, 22);
            this.TxtIdPedido.TabIndex = 95;
            this.TxtIdPedido.Visible = false;
            // 
            // TxtFormaPago
            // 
            this.TxtFormaPago.Location = new System.Drawing.Point(227, 86);
            this.TxtFormaPago.Name = "TxtFormaPago";
            this.TxtFormaPago.ReadOnly = true;
            this.TxtFormaPago.Size = new System.Drawing.Size(237, 22);
            this.TxtFormaPago.TabIndex = 94;
            // 
            // TxtTipoDoc
            // 
            this.TxtTipoDoc.Location = new System.Drawing.Point(9, 86);
            this.TxtTipoDoc.Name = "TxtTipoDoc";
            this.TxtTipoDoc.ReadOnly = true;
            this.TxtTipoDoc.Size = new System.Drawing.Size(206, 22);
            this.TxtTipoDoc.TabIndex = 93;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(335, 43);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.ReadOnly = true;
            this.TxtUsuario.Size = new System.Drawing.Size(129, 22);
            this.TxtUsuario.TabIndex = 92;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(332, 27);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(46, 13);
            this.LblUsuario.TabIndex = 91;
            this.LblUsuario.Text = "Usuario:";
            // 
            // groupBoxInfoProveedor
            // 
            this.groupBoxInfoProveedor.BackColor = System.Drawing.Color.White;
            this.groupBoxInfoProveedor.Controls.Add(this.TxtNumeroPedido);
            this.groupBoxInfoProveedor.Controls.Add(this.TxtRazonSocial);
            this.groupBoxInfoProveedor.Controls.Add(this.LblRazonSocial);
            this.groupBoxInfoProveedor.Controls.Add(this.TxtRUC);
            this.groupBoxInfoProveedor.Controls.Add(this.LblRUC);
            this.groupBoxInfoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoProveedor.Location = new System.Drawing.Point(529, 33);
            this.groupBoxInfoProveedor.Name = "groupBoxInfoProveedor";
            this.groupBoxInfoProveedor.Size = new System.Drawing.Size(366, 75);
            this.groupBoxInfoProveedor.TabIndex = 27;
            this.groupBoxInfoProveedor.TabStop = false;
            this.groupBoxInfoProveedor.Text = "Información del Proveedor";
            // 
            // TxtNumeroPedido
            // 
            this.TxtNumeroPedido.Location = new System.Drawing.Point(233, 13);
            this.TxtNumeroPedido.Name = "TxtNumeroPedido";
            this.TxtNumeroPedido.Size = new System.Drawing.Size(26, 20);
            this.TxtNumeroPedido.TabIndex = 64;
            this.TxtNumeroPedido.Visible = false;
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Location = new System.Drawing.Point(132, 42);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.ReadOnly = true;
            this.TxtRazonSocial.Size = new System.Drawing.Size(223, 20);
            this.TxtRazonSocial.TabIndex = 62;
            // 
            // LblRazonSocial
            // 
            this.LblRazonSocial.AutoSize = true;
            this.LblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRazonSocial.Location = new System.Drawing.Point(129, 27);
            this.LblRazonSocial.Name = "LblRazonSocial";
            this.LblRazonSocial.Size = new System.Drawing.Size(73, 13);
            this.LblRazonSocial.TabIndex = 61;
            this.LblRazonSocial.Text = "Razón Social:";
            // 
            // TxtRUC
            // 
            this.TxtRUC.Location = new System.Drawing.Point(10, 42);
            this.TxtRUC.Name = "TxtRUC";
            this.TxtRUC.ReadOnly = true;
            this.TxtRUC.Size = new System.Drawing.Size(113, 20);
            this.TxtRUC.TabIndex = 1;
            // 
            // LblRUC
            // 
            this.LblRUC.AutoSize = true;
            this.LblRUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRUC.Location = new System.Drawing.Point(7, 27);
            this.LblRUC.Name = "LblRUC";
            this.LblRUC.Size = new System.Drawing.Size(33, 13);
            this.LblRUC.TabIndex = 0;
            this.LblRUC.Text = "RUC:";
            // 
            // LblFormaPago
            // 
            this.LblFormaPago.AutoSize = true;
            this.LblFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormaPago.Location = new System.Drawing.Point(229, 68);
            this.LblFormaPago.Name = "LblFormaPago";
            this.LblFormaPago.Size = new System.Drawing.Size(67, 13);
            this.LblFormaPago.TabIndex = 89;
            this.LblFormaPago.Text = "Forma Pago:";
            // 
            // LblTipoDoc
            // 
            this.LblTipoDoc.AutoSize = true;
            this.LblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoDoc.Location = new System.Drawing.Point(6, 68);
            this.LblTipoDoc.Name = "LblTipoDoc";
            this.LblTipoDoc.Size = new System.Drawing.Size(89, 13);
            this.LblTipoDoc.TabIndex = 8;
            this.LblTipoDoc.Text = "Tipo Documento:";
            // 
            // TxtObs
            // 
            this.TxtObs.Location = new System.Drawing.Point(9, 128);
            this.TxtObs.Name = "TxtObs";
            this.TxtObs.ReadOnly = true;
            this.TxtObs.Size = new System.Drawing.Size(886, 22);
            this.TxtObs.TabIndex = 7;
            // 
            // LblObs
            // 
            this.LblObs.AutoSize = true;
            this.LblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObs.Location = new System.Drawing.Point(6, 111);
            this.LblObs.Name = "LblObs";
            this.LblObs.Size = new System.Drawing.Size(70, 13);
            this.LblObs.TabIndex = 6;
            this.LblObs.Text = "Observación:";
            // 
            // TxtNroPedido
            // 
            this.TxtNroPedido.Location = new System.Drawing.Point(9, 43);
            this.TxtNroPedido.Name = "TxtNroPedido";
            this.TxtNroPedido.ReadOnly = true;
            this.TxtNroPedido.Size = new System.Drawing.Size(100, 22);
            this.TxtNroPedido.TabIndex = 5;
            // 
            // LboNroPedido
            // 
            this.LboNroPedido.AutoSize = true;
            this.LboNroPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LboNroPedido.Location = new System.Drawing.Point(6, 27);
            this.LboNroPedido.Name = "LboNroPedido";
            this.LboNroPedido.Size = new System.Drawing.Size(83, 13);
            this.LboNroPedido.TabIndex = 4;
            this.LboNroPedido.Text = "Número Pedido:";
            // 
            // dtpFechaRequerida
            // 
            this.dtpFechaRequerida.Enabled = false;
            this.dtpFechaRequerida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRequerida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRequerida.Location = new System.Drawing.Point(227, 43);
            this.dtpFechaRequerida.Name = "dtpFechaRequerida";
            this.dtpFechaRequerida.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaRequerida.TabIndex = 3;
            this.dtpFechaRequerida.Value = new System.DateTime(2023, 10, 15, 0, 0, 0, 0);
            // 
            // LblFechaRequerida
            // 
            this.LblFechaRequerida.AutoSize = true;
            this.LblFechaRequerida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaRequerida.Location = new System.Drawing.Point(224, 27);
            this.LblFechaRequerida.Name = "LblFechaRequerida";
            this.LblFechaRequerida.Size = new System.Drawing.Size(92, 13);
            this.LblFechaRequerida.TabIndex = 2;
            this.LblFechaRequerida.Text = "Fecha Requerida:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(118, 43);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(97, 20);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.Value = new System.DateTime(2023, 10, 15, 0, 0, 0, 0);
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(115, 27);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(40, 13);
            this.LblFecha.TabIndex = 0;
            this.LblFecha.Text = "Fecha:";
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
            this.BtnLimpiar.Location = new System.Drawing.Point(317, 29);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(43, 26);
            this.BtnLimpiar.TabIndex = 89;
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
            this.BtnBuscar.Location = new System.Drawing.Point(270, 29);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(43, 26);
            this.BtnBuscar.TabIndex = 88;
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
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
            this.Total});
            this.dgvData.Location = new System.Drawing.Point(16, 258);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(816, 236);
            this.dgvData.TabIndex = 91;
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
            // TxtTotalPedido
            // 
            this.TxtTotalPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalPedido.Location = new System.Drawing.Point(837, 468);
            this.TxtTotalPedido.Name = "TxtTotalPedido";
            this.TxtTotalPedido.ReadOnly = true;
            this.TxtTotalPedido.Size = new System.Drawing.Size(177, 26);
            this.TxtTotalPedido.TabIndex = 93;
            this.TxtTotalPedido.Text = "0";
            // 
            // LblTotalCompra
            // 
            this.LblTotalCompra.AutoSize = true;
            this.LblTotalCompra.BackColor = System.Drawing.Color.White;
            this.LblTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalCompra.Location = new System.Drawing.Point(836, 448);
            this.LblTotalCompra.Name = "LblTotalCompra";
            this.LblTotalCompra.Size = new System.Drawing.Size(97, 20);
            this.LblTotalCompra.TabIndex = 92;
            this.LblTotalCompra.Text = "Total Pedido";
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
            this.BtnGuardar.Location = new System.Drawing.Point(837, 407);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(142, 27);
            this.BtnGuardar.TabIndex = 94;
            this.BtnGuardar.Text = "Imprimir";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // PbConfirmado
            // 
            this.PbConfirmado.BackColor = System.Drawing.Color.White;
            this.PbConfirmado.Image = global::CapaPresentacion.Properties.Resources.OK;
            this.PbConfirmado.Location = new System.Drawing.Point(840, 36);
            this.PbConfirmado.Name = "PbConfirmado";
            this.PbConfirmado.Size = new System.Drawing.Size(43, 39);
            this.PbConfirmado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbConfirmado.TabIndex = 95;
            this.PbConfirmado.TabStop = false;
            // 
            // LblConfirmado
            // 
            this.LblConfirmado.AutoSize = true;
            this.LblConfirmado.BackColor = System.Drawing.Color.White;
            this.LblConfirmado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConfirmado.ForeColor = System.Drawing.Color.Green;
            this.LblConfirmado.Location = new System.Drawing.Point(727, 44);
            this.LblConfirmado.Name = "LblConfirmado";
            this.LblConfirmado.Size = new System.Drawing.Size(107, 24);
            this.LblConfirmado.TabIndex = 96;
            this.LblConfirmado.Text = "Confirmado";
            // 
            // LblNoConfirmado
            // 
            this.LblNoConfirmado.AutoSize = true;
            this.LblNoConfirmado.BackColor = System.Drawing.Color.White;
            this.LblNoConfirmado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNoConfirmado.ForeColor = System.Drawing.Color.DarkOrange;
            this.LblNoConfirmado.Location = new System.Drawing.Point(697, 44);
            this.LblNoConfirmado.Name = "LblNoConfirmado";
            this.LblNoConfirmado.Size = new System.Drawing.Size(137, 24);
            this.LblNoConfirmado.TabIndex = 97;
            this.LblNoConfirmado.Text = "No Confirmado";
            // 
            // PbNoConfirmado
            // 
            this.PbNoConfirmado.BackColor = System.Drawing.Color.White;
            this.PbNoConfirmado.Image = global::CapaPresentacion.Properties.Resources.cancelar;
            this.PbNoConfirmado.Location = new System.Drawing.Point(840, 36);
            this.PbNoConfirmado.Name = "PbNoConfirmado";
            this.PbNoConfirmado.Size = new System.Drawing.Size(43, 39);
            this.PbNoConfirmado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbNoConfirmado.TabIndex = 98;
            this.PbNoConfirmado.TabStop = false;
            // 
            // checkBoxConfirmado
            // 
            this.checkBoxConfirmado.AutoSize = true;
            this.checkBoxConfirmado.Location = new System.Drawing.Point(664, 50);
            this.checkBoxConfirmado.Name = "checkBoxConfirmado";
            this.checkBoxConfirmado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxConfirmado.TabIndex = 99;
            this.checkBoxConfirmado.UseVisualStyleBackColor = true;
            this.checkBoxConfirmado.Visible = false;
            // 
            // BtnConfirmarPedido
            // 
            this.BtnConfirmarPedido.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnConfirmarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfirmarPedido.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnConfirmarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmarPedido.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmarPedido.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnConfirmarPedido.IconColor = System.Drawing.Color.White;
            this.BtnConfirmarPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConfirmarPedido.IconSize = 16;
            this.BtnConfirmarPedido.Location = new System.Drawing.Point(837, 305);
            this.BtnConfirmarPedido.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConfirmarPedido.Name = "BtnConfirmarPedido";
            this.BtnConfirmarPedido.Size = new System.Drawing.Size(142, 27);
            this.BtnConfirmarPedido.TabIndex = 101;
            this.BtnConfirmarPedido.Text = "Confirmar";
            this.BtnConfirmarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConfirmarPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmarPedido.UseVisualStyleBackColor = false;
            this.BtnConfirmarPedido.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // BtnAnularPedido
            // 
            this.BtnAnularPedido.BackColor = System.Drawing.Color.Red;
            this.BtnAnularPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAnularPedido.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAnularPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnularPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnularPedido.ForeColor = System.Drawing.Color.White;
            this.BtnAnularPedido.IconChar = FontAwesome.Sharp.IconChar.X;
            this.BtnAnularPedido.IconColor = System.Drawing.Color.White;
            this.BtnAnularPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAnularPedido.IconSize = 16;
            this.BtnAnularPedido.Location = new System.Drawing.Point(837, 355);
            this.BtnAnularPedido.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAnularPedido.Name = "BtnAnularPedido";
            this.BtnAnularPedido.Size = new System.Drawing.Size(142, 27);
            this.BtnAnularPedido.TabIndex = 128;
            this.BtnAnularPedido.Text = "Anular";
            this.BtnAnularPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAnularPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAnularPedido.UseVisualStyleBackColor = false;
            this.BtnAnularPedido.Click += new System.EventHandler(this.BtnAnular_Click);
            // 
            // LblAnulado
            // 
            this.LblAnulado.AutoSize = true;
            this.LblAnulado.BackColor = System.Drawing.Color.White;
            this.LblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnulado.ForeColor = System.Drawing.Color.Red;
            this.LblAnulado.Location = new System.Drawing.Point(751, 44);
            this.LblAnulado.Name = "LblAnulado";
            this.LblAnulado.Size = new System.Drawing.Size(81, 24);
            this.LblAnulado.TabIndex = 129;
            this.LblAnulado.Text = "Anulado";
            // 
            // checkBoxAnulado
            // 
            this.checkBoxAnulado.AutoSize = true;
            this.checkBoxAnulado.Location = new System.Drawing.Point(633, 44);
            this.checkBoxAnulado.Name = "checkBoxAnulado";
            this.checkBoxAnulado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAnulado.TabIndex = 130;
            this.checkBoxAnulado.UseVisualStyleBackColor = true;
            this.checkBoxAnulado.Visible = false;
            // 
            // FrmVerDetallePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 545);
            this.Controls.Add(this.checkBoxAnulado);
            this.Controls.Add(this.LblAnulado);
            this.Controls.Add(this.BtnAnularPedido);
            this.Controls.Add(this.BtnConfirmarPedido);
            this.Controls.Add(this.checkBoxConfirmado);
            this.Controls.Add(this.PbNoConfirmado);
            this.Controls.Add(this.LblNoConfirmado);
            this.Controls.Add(this.LblConfirmado);
            this.Controls.Add(this.PbConfirmado);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtTotalPedido);
            this.Controls.Add(this.LblTotalCompra);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupBoxInfoPedido);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.LblNroPedido);
            this.Controls.Add(this.LblPedidos);
            this.Name = "FrmVerDetallePedido";
            this.Text = "Consulta de Pedido";
            this.Load += new System.EventHandler(this.FrmVerDetallePedido_Load);
            this.groupBoxInfoPedido.ResumeLayout(false);
            this.groupBoxInfoPedido.PerformLayout();
            this.groupBoxInfoProveedor.ResumeLayout(false);
            this.groupBoxInfoProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbConfirmado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNoConfirmado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPedidos;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Label LblNroPedido;
        private System.Windows.Forms.GroupBox groupBoxInfoPedido;
        private System.Windows.Forms.GroupBox groupBoxInfoProveedor;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.Label LblRazonSocial;
        private System.Windows.Forms.TextBox TxtRUC;
        private System.Windows.Forms.Label LblRUC;
        private System.Windows.Forms.Label LblFormaPago;
        private System.Windows.Forms.Label LblTipoDoc;
        private System.Windows.Forms.TextBox TxtObs;
        private System.Windows.Forms.Label LblObs;
        private System.Windows.Forms.TextBox TxtNroPedido;
        private System.Windows.Forms.Label LboNroPedido;
        private System.Windows.Forms.DateTimePicker dtpFechaRequerida;
        private System.Windows.Forms.Label LblFechaRequerida;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.TextBox TxtNumeroPedido;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox TxtTotalPedido;
        private System.Windows.Forms.Label LblTotalCompra;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.TextBox TxtFormaPago;
        private System.Windows.Forms.TextBox TxtTipoDoc;
        private System.Windows.Forms.PictureBox PbConfirmado;
        private System.Windows.Forms.Label LblConfirmado;
        private System.Windows.Forms.Label LblNoConfirmado;
        private System.Windows.Forms.PictureBox PbNoConfirmado;
        private System.Windows.Forms.CheckBox checkBoxConfirmado;
        private FontAwesome.Sharp.IconButton BtnConfirmarPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private FontAwesome.Sharp.IconButton BtnAnularPedido;
        private System.Windows.Forms.TextBox TxtIdPedido;
        private System.Windows.Forms.Label LblAnulado;
        private System.Windows.Forms.CheckBox checkBoxAnulado;
    }
}
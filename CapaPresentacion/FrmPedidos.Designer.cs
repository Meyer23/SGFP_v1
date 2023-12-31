﻿namespace CapaPresentacion
{
    partial class FrmPedidos
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
            this.groupBoxInfoPedido = new System.Windows.Forms.GroupBox();
            this.TxtIdTipoDoc = new System.Windows.Forms.TextBox();
            this.ComboFormaPago = new System.Windows.Forms.ComboBox();
            this.groupBoxInfoProveedor = new System.Windows.Forms.GroupBox();
            this.TxtIdProveedor = new System.Windows.Forms.TextBox();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.LblRazonSocial = new System.Windows.Forms.Label();
            this.BtnBuscarProv = new FontAwesome.Sharp.IconButton();
            this.TxtRUC = new System.Windows.Forms.TextBox();
            this.LblRUC = new System.Windows.Forms.Label();
            this.LblFormaPago = new System.Windows.Forms.Label();
            this.ComboTipoDoc = new System.Windows.Forms.ComboBox();
            this.LblTipoDoc = new System.Windows.Forms.Label();
            this.TxtObs = new System.Windows.Forms.TextBox();
            this.LblObs = new System.Windows.Forms.Label();
            this.TxtNroPedido = new System.Windows.Forms.TextBox();
            this.LboNroPedido = new System.Windows.Forms.Label();
            this.dtpFechaRequerida = new System.Windows.Forms.DateTimePicker();
            this.LblFechaRequerida = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.LblFecha = new System.Windows.Forms.Label();
            this.groupBoxInfoProducto = new System.Windows.Forms.GroupBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.TxtPrecioCompra = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.BtnAgregar = new FontAwesome.Sharp.IconButton();
            this.TxtDescProducto = new System.Windows.Forms.TextBox();
            this.LblDescProducto = new System.Windows.Forms.Label();
            this.BntBuscarProd = new FontAwesome.Sharp.IconButton();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.TxtCodProducto = new System.Windows.Forms.TextBox();
            this.LblCodProducto = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LblTotalCompra = new System.Windows.Forms.Label();
            this.TxtTotalPedido = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.BtnInsertarProductos = new FontAwesome.Sharp.IconButton();
            this.groupBoxInfoPedido.SuspendLayout();
            this.groupBoxInfoProveedor.SuspendLayout();
            this.groupBoxInfoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
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
            this.LblPedidos.Size = new System.Drawing.Size(991, 519);
            this.LblPedidos.TabIndex = 24;
            this.LblPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxInfoPedido
            // 
            this.groupBoxInfoPedido.BackColor = System.Drawing.Color.White;
            this.groupBoxInfoPedido.Controls.Add(this.TxtIdTipoDoc);
            this.groupBoxInfoPedido.Controls.Add(this.ComboFormaPago);
            this.groupBoxInfoPedido.Controls.Add(this.groupBoxInfoProveedor);
            this.groupBoxInfoPedido.Controls.Add(this.LblFormaPago);
            this.groupBoxInfoPedido.Controls.Add(this.ComboTipoDoc);
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
            this.groupBoxInfoPedido.Location = new System.Drawing.Point(16, 21);
            this.groupBoxInfoPedido.Name = "groupBoxInfoPedido";
            this.groupBoxInfoPedido.Size = new System.Drawing.Size(954, 160);
            this.groupBoxInfoPedido.TabIndex = 26;
            this.groupBoxInfoPedido.TabStop = false;
            this.groupBoxInfoPedido.Text = "Información del Pedido";
            // 
            // TxtIdTipoDoc
            // 
            this.TxtIdTipoDoc.Location = new System.Drawing.Point(359, 41);
            this.TxtIdTipoDoc.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIdTipoDoc.Name = "TxtIdTipoDoc";
            this.TxtIdTipoDoc.Size = new System.Drawing.Size(14, 22);
            this.TxtIdTipoDoc.TabIndex = 91;
            this.TxtIdTipoDoc.Visible = false;
            // 
            // ComboFormaPago
            // 
            this.ComboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboFormaPago.FormattingEnabled = true;
            this.ComboFormaPago.Location = new System.Drawing.Point(200, 84);
            this.ComboFormaPago.Name = "ComboFormaPago";
            this.ComboFormaPago.Size = new System.Drawing.Size(173, 24);
            this.ComboFormaPago.TabIndex = 90;
            // 
            // groupBoxInfoProveedor
            // 
            this.groupBoxInfoProveedor.BackColor = System.Drawing.Color.White;
            this.groupBoxInfoProveedor.Controls.Add(this.TxtIdProveedor);
            this.groupBoxInfoProveedor.Controls.Add(this.TxtRazonSocial);
            this.groupBoxInfoProveedor.Controls.Add(this.LblRazonSocial);
            this.groupBoxInfoProveedor.Controls.Add(this.BtnBuscarProv);
            this.groupBoxInfoProveedor.Controls.Add(this.TxtRUC);
            this.groupBoxInfoProveedor.Controls.Add(this.LblRUC);
            this.groupBoxInfoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoProveedor.Location = new System.Drawing.Point(437, 33);
            this.groupBoxInfoProveedor.Name = "groupBoxInfoProveedor";
            this.groupBoxInfoProveedor.Size = new System.Drawing.Size(458, 75);
            this.groupBoxInfoProveedor.TabIndex = 27;
            this.groupBoxInfoProveedor.TabStop = false;
            this.groupBoxInfoProveedor.Text = "Información del Proveedor";
            // 
            // TxtIdProveedor
            // 
            this.TxtIdProveedor.Location = new System.Drawing.Point(128, 18);
            this.TxtIdProveedor.Name = "TxtIdProveedor";
            this.TxtIdProveedor.Size = new System.Drawing.Size(26, 20);
            this.TxtIdProveedor.TabIndex = 63;
            this.TxtIdProveedor.Text = "0";
            this.TxtIdProveedor.Visible = false;
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Location = new System.Drawing.Point(179, 42);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.ReadOnly = true;
            this.TxtRazonSocial.Size = new System.Drawing.Size(223, 20);
            this.TxtRazonSocial.TabIndex = 62;
            // 
            // LblRazonSocial
            // 
            this.LblRazonSocial.AutoSize = true;
            this.LblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRazonSocial.Location = new System.Drawing.Point(176, 27);
            this.LblRazonSocial.Name = "LblRazonSocial";
            this.LblRazonSocial.Size = new System.Drawing.Size(73, 13);
            this.LblRazonSocial.TabIndex = 61;
            this.LblRazonSocial.Text = "Razón Social:";
            // 
            // BtnBuscarProv
            // 
            this.BtnBuscarProv.BackColor = System.Drawing.Color.White;
            this.BtnBuscarProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarProv.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarProv.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarProv.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscarProv.IconColor = System.Drawing.Color.Black;
            this.BtnBuscarProv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscarProv.IconSize = 16;
            this.BtnBuscarProv.Location = new System.Drawing.Point(127, 42);
            this.BtnBuscarProv.Margin = new System.Windows.Forms.Padding(1);
            this.BtnBuscarProv.Name = "BtnBuscarProv";
            this.BtnBuscarProv.Size = new System.Drawing.Size(48, 20);
            this.BtnBuscarProv.TabIndex = 60;
            this.BtnBuscarProv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarProv.UseVisualStyleBackColor = false;
            this.BtnBuscarProv.Click += new System.EventHandler(this.BtnBuscarProv_Click);
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
            this.LblFormaPago.Location = new System.Drawing.Point(198, 68);
            this.LblFormaPago.Name = "LblFormaPago";
            this.LblFormaPago.Size = new System.Drawing.Size(67, 13);
            this.LblFormaPago.TabIndex = 89;
            this.LblFormaPago.Text = "Forma Pago:";
            // 
            // ComboTipoDoc
            // 
            this.ComboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTipoDoc.FormattingEnabled = true;
            this.ComboTipoDoc.Location = new System.Drawing.Point(9, 84);
            this.ComboTipoDoc.Name = "ComboTipoDoc";
            this.ComboTipoDoc.Size = new System.Drawing.Size(173, 24);
            this.ComboTipoDoc.TabIndex = 88;
            this.ComboTipoDoc.SelectedIndexChanged += new System.EventHandler(this.ComboTipoDoc_SelectedIndexChanged);
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
            this.dtpFechaRequerida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRequerida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRequerida.Location = new System.Drawing.Point(227, 43);
            this.dtpFechaRequerida.Name = "dtpFechaRequerida";
            this.dtpFechaRequerida.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaRequerida.TabIndex = 3;
            this.dtpFechaRequerida.Value = new System.DateTime(2023, 11, 2, 0, 0, 0, 0);
            this.dtpFechaRequerida.ValueChanged += new System.EventHandler(this.dtpFechaRequerida_ValueChanged);
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
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(118, 43);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(97, 20);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.Value = new System.DateTime(2023, 11, 2, 0, 0, 0, 0);
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
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
            // groupBoxInfoProducto
            // 
            this.groupBoxInfoProducto.BackColor = System.Drawing.Color.White;
            this.groupBoxInfoProducto.Controls.Add(this.TxtCantidad);
            this.groupBoxInfoProducto.Controls.Add(this.LblCantidad);
            this.groupBoxInfoProducto.Controls.Add(this.TxtPrecioCompra);
            this.groupBoxInfoProducto.Controls.Add(this.LblPrecio);
            this.groupBoxInfoProducto.Controls.Add(this.TxtDescProducto);
            this.groupBoxInfoProducto.Controls.Add(this.LblDescProducto);
            this.groupBoxInfoProducto.Controls.Add(this.BntBuscarProd);
            this.groupBoxInfoProducto.Controls.Add(this.TxtIdProducto);
            this.groupBoxInfoProducto.Controls.Add(this.TxtCodProducto);
            this.groupBoxInfoProducto.Controls.Add(this.LblCodProducto);
            this.groupBoxInfoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoProducto.Location = new System.Drawing.Point(16, 196);
            this.groupBoxInfoProducto.Name = "groupBoxInfoProducto";
            this.groupBoxInfoProducto.Size = new System.Drawing.Size(807, 72);
            this.groupBoxInfoProducto.TabIndex = 28;
            this.groupBoxInfoProducto.TabStop = false;
            this.groupBoxInfoProducto.Text = "Información del Producto";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(542, 38);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(95, 22);
            this.TxtCantidad.TabIndex = 71;
            this.TxtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            this.TxtCantidad.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCantidad_Validating);
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(539, 22);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(52, 13);
            this.LblCantidad.TabIndex = 70;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // TxtPrecioCompra
            // 
            this.TxtPrecioCompra.Location = new System.Drawing.Point(665, 37);
            this.TxtPrecioCompra.Name = "TxtPrecioCompra";
            this.TxtPrecioCompra.Size = new System.Drawing.Size(95, 22);
            this.TxtPrecioCompra.TabIndex = 69;
            this.TxtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecioCompra_KeyPress);
            this.TxtPrecioCompra.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPrecioCompra_Validating);
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.Location = new System.Drawing.Point(662, 21);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(40, 13);
            this.LblPrecio.TabIndex = 68;
            this.LblPrecio.Text = "Precio:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.BtnAgregar.IconColor = System.Drawing.Color.Black;
            this.BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAgregar.Location = new System.Drawing.Point(832, 196);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(82, 72);
            this.BtnAgregar.TabIndex = 30;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtDescProducto
            // 
            this.TxtDescProducto.Location = new System.Drawing.Point(200, 38);
            this.TxtDescProducto.Name = "TxtDescProducto";
            this.TxtDescProducto.ReadOnly = true;
            this.TxtDescProducto.Size = new System.Drawing.Size(327, 22);
            this.TxtDescProducto.TabIndex = 67;
            // 
            // LblDescProducto
            // 
            this.LblDescProducto.AutoSize = true;
            this.LblDescProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescProducto.Location = new System.Drawing.Point(197, 22);
            this.LblDescProducto.Name = "LblDescProducto";
            this.LblDescProducto.Size = new System.Drawing.Size(112, 13);
            this.LblDescProducto.TabIndex = 66;
            this.LblDescProducto.Text = "Descripción Producto:";
            // 
            // BntBuscarProd
            // 
            this.BntBuscarProd.BackColor = System.Drawing.Color.White;
            this.BntBuscarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BntBuscarProd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BntBuscarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BntBuscarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntBuscarProd.ForeColor = System.Drawing.Color.White;
            this.BntBuscarProd.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BntBuscarProd.IconColor = System.Drawing.Color.Black;
            this.BntBuscarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BntBuscarProd.IconSize = 16;
            this.BntBuscarProd.Location = new System.Drawing.Point(138, 39);
            this.BntBuscarProd.Margin = new System.Windows.Forms.Padding(1);
            this.BntBuscarProd.Name = "BntBuscarProd";
            this.BntBuscarProd.Size = new System.Drawing.Size(44, 21);
            this.BntBuscarProd.TabIndex = 65;
            this.BntBuscarProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BntBuscarProd.UseVisualStyleBackColor = false;
            this.BntBuscarProd.Click += new System.EventHandler(this.BntBuscarProd_Click);
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.Location = new System.Drawing.Point(165, 12);
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.Size = new System.Drawing.Size(26, 22);
            this.TxtIdProducto.TabIndex = 64;
            this.TxtIdProducto.Text = "0";
            this.TxtIdProducto.Visible = false;
            // 
            // TxtCodProducto
            // 
            this.TxtCodProducto.Location = new System.Drawing.Point(10, 39);
            this.TxtCodProducto.Name = "TxtCodProducto";
            this.TxtCodProducto.Size = new System.Drawing.Size(124, 22);
            this.TxtCodProducto.TabIndex = 1;
            this.TxtCodProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodProducto_KeyDown);
            // 
            // LblCodProducto
            // 
            this.LblCodProducto.AutoSize = true;
            this.LblCodProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodProducto.Location = new System.Drawing.Point(7, 22);
            this.LblCodProducto.Name = "LblCodProducto";
            this.LblCodProducto.Size = new System.Drawing.Size(89, 13);
            this.LblCodProducto.TabIndex = 0;
            this.LblCodProducto.Text = "Codigo Producto:";
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
            this.dgvData.Location = new System.Drawing.Point(16, 274);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.Size = new System.Drawing.Size(807, 236);
            this.dgvData.TabIndex = 29;
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
            this.idProducto.Width = 150;
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
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 300;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 8;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.HeaderText = "";
            this.BtnEliminar.MinimumWidth = 8;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.ReadOnly = true;
            this.BtnEliminar.Width = 30;
            // 
            // LblTotalCompra
            // 
            this.LblTotalCompra.AutoSize = true;
            this.LblTotalCompra.BackColor = System.Drawing.Color.White;
            this.LblTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalCompra.Location = new System.Drawing.Point(828, 463);
            this.LblTotalCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTotalCompra.Name = "LblTotalCompra";
            this.LblTotalCompra.Size = new System.Drawing.Size(97, 20);
            this.LblTotalCompra.TabIndex = 31;
            this.LblTotalCompra.Text = "Total Pedido";
            // 
            // TxtTotalPedido
            // 
            this.TxtTotalPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalPedido.Location = new System.Drawing.Point(832, 484);
            this.TxtTotalPedido.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTotalPedido.Name = "TxtTotalPedido";
            this.TxtTotalPedido.ReadOnly = true;
            this.TxtTotalPedido.Size = new System.Drawing.Size(160, 26);
            this.TxtTotalPedido.TabIndex = 32;
            this.TxtTotalPedido.Text = "0";
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
            this.BtnGuardar.Location = new System.Drawing.Point(832, 421);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(1);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(125, 27);
            this.BtnGuardar.TabIndex = 51;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnInsertarProductos
            // 
            this.BtnInsertarProductos.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnInsertarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsertarProductos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnInsertarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsertarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertarProductos.ForeColor = System.Drawing.Color.White;
            this.BtnInsertarProductos.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.BtnInsertarProductos.IconColor = System.Drawing.Color.White;
            this.BtnInsertarProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnInsertarProductos.IconSize = 16;
            this.BtnInsertarProductos.Location = new System.Drawing.Point(846, 334);
            this.BtnInsertarProductos.Margin = new System.Windows.Forms.Padding(1);
            this.BtnInsertarProductos.Name = "BtnInsertarProductos";
            this.BtnInsertarProductos.Size = new System.Drawing.Size(125, 52);
            this.BtnInsertarProductos.TabIndex = 53;
            this.BtnInsertarProductos.Text = "Insertar Productos";
            this.BtnInsertarProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInsertarProductos.UseVisualStyleBackColor = false;
            this.BtnInsertarProductos.Click += new System.EventHandler(this.BtnInsertarProductos_Click);
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 535);
            this.Controls.Add(this.BtnInsertarProductos);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtTotalPedido);
            this.Controls.Add(this.LblTotalCompra);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupBoxInfoProducto);
            this.Controls.Add(this.groupBoxInfoPedido);
            this.Controls.Add(this.LblPedidos);
            this.Name = "FrmPedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.groupBoxInfoPedido.ResumeLayout(false);
            this.groupBoxInfoPedido.PerformLayout();
            this.groupBoxInfoProveedor.ResumeLayout(false);
            this.groupBoxInfoProveedor.PerformLayout();
            this.groupBoxInfoProducto.ResumeLayout(false);
            this.groupBoxInfoProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPedidos;
        private System.Windows.Forms.GroupBox groupBoxInfoPedido;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaRequerida;
        private System.Windows.Forms.Label LblFechaRequerida;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox TxtNroPedido;
        private System.Windows.Forms.Label LboNroPedido;
        private System.Windows.Forms.TextBox TxtObs;
        private System.Windows.Forms.Label LblObs;
        private System.Windows.Forms.Label LblTipoDoc;
        private System.Windows.Forms.ComboBox ComboFormaPago;
        private System.Windows.Forms.Label LblFormaPago;
        private System.Windows.Forms.ComboBox ComboTipoDoc;
        private System.Windows.Forms.GroupBox groupBoxInfoProveedor;
        private System.Windows.Forms.TextBox TxtRUC;
        private System.Windows.Forms.Label LblRUC;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.Label LblRazonSocial;
        private FontAwesome.Sharp.IconButton BtnBuscarProv;
        private System.Windows.Forms.TextBox TxtIdProveedor;
        private System.Windows.Forms.GroupBox groupBoxInfoProducto;
        private FontAwesome.Sharp.IconButton BntBuscarProd;
        private System.Windows.Forms.TextBox TxtIdProducto;
        private System.Windows.Forms.TextBox TxtCodProducto;
        private System.Windows.Forms.Label LblCodProducto;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox TxtPrecioCompra;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.TextBox TxtDescProducto;
        private System.Windows.Forms.Label LblDescProducto;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.DataGridView dgvData;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private System.Windows.Forms.Label LblTotalCompra;
        private System.Windows.Forms.TextBox TxtTotalPedido;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private FontAwesome.Sharp.IconButton BtnInsertarProductos;
        private System.Windows.Forms.TextBox TxtIdTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEliminar;
    }
}
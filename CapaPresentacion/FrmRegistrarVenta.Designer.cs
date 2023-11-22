﻿namespace CapaPresentacion
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
            this.BtnConfirmar = new FontAwesome.Sharp.IconButton();
            this.textBoxTotalPagar = new System.Windows.Forms.TextBox();
            this.LblTotalPagar = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxInfoPedido = new System.Windows.Forms.GroupBox();
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
            this.ComboTipoDoc = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LblTipoDocumento = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.groupBoxInfoCliente = new System.Windows.Forms.GroupBox();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.LblRazonSocial = new System.Windows.Forms.Label();
            this.BtnBuscarCliente = new FontAwesome.Sharp.IconButton();
            this.TxtRUC = new System.Windows.Forms.TextBox();
            this.LblNroDocumento = new System.Windows.Forms.Label();
            this.TimerNow = new System.Windows.Forms.Timer(this.components);
            this.LblHoraActual = new System.Windows.Forms.Label();
            this.BtnCargarCobro = new FontAwesome.Sharp.IconButton();
            this.LblTipoValor = new System.Windows.Forms.Label();
            this.TxtTipoValor = new System.Windows.Forms.TextBox();
            this.LblImporte = new System.Windows.Forms.Label();
            this.TxtImporte = new System.Windows.Forms.TextBox();
            this.LblVuelto = new System.Windows.Forms.Label();
            this.TxtVuelto = new System.Windows.Forms.TextBox();
            this.groupBoxFormaPago = new System.Windows.Forms.GroupBox();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.LblDocumento = new System.Windows.Forms.Label();
            this.dgvData_Cobro = new System.Windows.Forms.DataGridView();
            this.TipoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteVuelto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblMoneda = new System.Windows.Forms.Label();
            this.TxtCobroParcial = new System.Windows.Forms.TextBox();
            this.LblTotalFraccionado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBoxInfoPedido.SuspendLayout();
            this.groupBoxInfoProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.groupBoxInfoVenta.SuspendLayout();
            this.groupBoxInfoCliente.SuspendLayout();
            this.groupBoxFormaPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData_Cobro)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPedidos
            // 
            this.LblPedidos.BackColor = System.Drawing.Color.White;
            this.LblPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPedidos.Location = new System.Drawing.Point(12, 9);
            this.LblPedidos.Name = "LblPedidos";
            this.LblPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.LblPedidos.Size = new System.Drawing.Size(2265, 1099);
            this.LblPedidos.TabIndex = 26;
            this.LblPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfirmar.Enabled = false;
            this.BtnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnConfirmar.IconColor = System.Drawing.Color.White;
            this.BtnConfirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConfirmar.IconSize = 18;
            this.BtnConfirmar.Location = new System.Drawing.Point(642, 1047);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(245, 40);
            this.BtnConfirmar.TabIndex = 87;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            this.BtnConfirmar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnConfirmar_KeyDown);
            // 
            // textBoxTotalPagar
            // 
            this.textBoxTotalPagar.Enabled = false;
            this.textBoxTotalPagar.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalPagar.Location = new System.Drawing.Point(417, 900);
            this.textBoxTotalPagar.Name = "textBoxTotalPagar";
            this.textBoxTotalPagar.Size = new System.Drawing.Size(470, 81);
            this.textBoxTotalPagar.TabIndex = 82;
            // 
            // LblTotalPagar
            // 
            this.LblTotalPagar.AutoSize = true;
            this.LblTotalPagar.BackColor = System.Drawing.Color.White;
            this.LblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalPagar.Location = new System.Drawing.Point(412, 846);
            this.LblTotalPagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTotalPagar.Name = "LblTotalPagar";
            this.LblTotalPagar.Size = new System.Drawing.Size(156, 29);
            this.LblTotalPagar.TabIndex = 81;
            this.LblTotalPagar.Text = "Total Pagar:";
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
            this.dgvData.Location = new System.Drawing.Point(18, 468);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4, 5, 7, 5);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.Size = new System.Drawing.Size(1130, 321);
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
            this.groupBoxInfoPedido.Controls.Add(this.groupBoxInfoProductos);
            this.groupBoxInfoPedido.Controls.Add(this.groupBoxInfoVenta);
            this.groupBoxInfoPedido.Controls.Add(this.groupBoxInfoCliente);
            this.groupBoxInfoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoPedido.Location = new System.Drawing.Point(18, 32);
            this.groupBoxInfoPedido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInfoPedido.Name = "groupBoxInfoPedido";
            this.groupBoxInfoPedido.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInfoPedido.Size = new System.Drawing.Size(1467, 426);
            this.groupBoxInfoPedido.TabIndex = 88;
            this.groupBoxInfoPedido.TabStop = false;
            this.groupBoxInfoPedido.Text = "Registrar Venta";
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
            this.groupBoxInfoProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoProductos.Location = new System.Drawing.Point(12, 217);
            this.groupBoxInfoProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInfoProductos.Name = "groupBoxInfoProductos";
            this.groupBoxInfoProductos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInfoProductos.Size = new System.Drawing.Size(1433, 185);
            this.groupBoxInfoProductos.TabIndex = 29;
            this.groupBoxInfoProductos.TabStop = false;
            this.groupBoxInfoProductos.Text = "Informacion Venta";
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.Location = new System.Drawing.Point(174, 42);
            this.TxtIdProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.Size = new System.Drawing.Size(28, 41);
            this.TxtIdProducto.TabIndex = 74;
            this.TxtIdProducto.Text = "0";
            this.TxtIdProducto.Visible = false;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Enabled = false;
            this.textBoxPrecio.Location = new System.Drawing.Point(899, 115);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.ReadOnly = true;
            this.textBoxPrecio.Size = new System.Drawing.Size(219, 41);
            this.textBoxPrecio.TabIndex = 71;
            this.textBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecio_KeyPress);
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.Location = new System.Drawing.Point(894, 54);
            this.LblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.BtnAgregar.Location = new System.Drawing.Point(1222, 45);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(166, 111);
            this.BtnAgregar.TabIndex = 69;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Location = new System.Drawing.Point(644, 113);
            this.numericUpDownCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(90, 41);
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
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(639, 59);
            this.LblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(97, 25);
            this.LblCantidad.TabIndex = 67;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // TxtProducto
            // 
            this.TxtProducto.Location = new System.Drawing.Point(310, 113);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.ReadOnly = true;
            this.TxtProducto.Size = new System.Drawing.Size(251, 41);
            this.TxtProducto.TabIndex = 64;
            // 
            // iconButtonCodProducto
            // 
            this.iconButtonCodProducto.BackColor = System.Drawing.Color.White;
            this.iconButtonCodProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonCodProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButtonCodProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCodProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCodProducto.ForeColor = System.Drawing.Color.White;
            this.iconButtonCodProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButtonCodProducto.IconColor = System.Drawing.Color.Black;
            this.iconButtonCodProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCodProducto.IconSize = 16;
            this.iconButtonCodProducto.Location = new System.Drawing.Point(148, 113);
            this.iconButtonCodProducto.Name = "iconButtonCodProducto";
            this.iconButtonCodProducto.Size = new System.Drawing.Size(91, 43);
            this.iconButtonCodProducto.TabIndex = 63;
            this.iconButtonCodProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonCodProducto.UseVisualStyleBackColor = false;
            this.iconButtonCodProducto.Click += new System.EventHandler(this.iconButtonCodProducto_Click);
            // 
            // textBoxCodProducto
            // 
            this.textBoxCodProducto.Location = new System.Drawing.Point(7, 113);
            this.textBoxCodProducto.Name = "textBoxCodProducto";
            this.textBoxCodProducto.ReadOnly = true;
            this.textBoxCodProducto.Size = new System.Drawing.Size(107, 41);
            this.textBoxCodProducto.TabIndex = 62;
            this.textBoxCodProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCodProducto_KeyDown);
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.Location = new System.Drawing.Point(305, 59);
            this.LblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(96, 25);
            this.LblProducto.TabIndex = 61;
            this.LblProducto.Text = "Producto:";
            // 
            // LblCodProducto
            // 
            this.LblCodProducto.AutoSize = true;
            this.LblCodProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodProducto.Location = new System.Drawing.Point(8, 60);
            this.LblCodProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCodProducto.Name = "LblCodProducto";
            this.LblCodProducto.Size = new System.Drawing.Size(143, 25);
            this.LblCodProducto.TabIndex = 0;
            this.LblCodProducto.Text = "Cod. Producto:";
            // 
            // groupBoxInfoVenta
            // 
            this.groupBoxInfoVenta.BackColor = System.Drawing.Color.White;
            this.groupBoxInfoVenta.Controls.Add(this.ComboTipoDoc);
            this.groupBoxInfoVenta.Controls.Add(this.dateTimePicker1);
            this.groupBoxInfoVenta.Controls.Add(this.LblTipoDocumento);
            this.groupBoxInfoVenta.Controls.Add(this.LblFecha);
            this.groupBoxInfoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoVenta.Location = new System.Drawing.Point(0, 51);
            this.groupBoxInfoVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInfoVenta.Name = "groupBoxInfoVenta";
            this.groupBoxInfoVenta.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInfoVenta.Size = new System.Drawing.Size(626, 164);
            this.groupBoxInfoVenta.TabIndex = 28;
            this.groupBoxInfoVenta.TabStop = false;
            this.groupBoxInfoVenta.Text = "Informacion Venta";
            // 
            // ComboTipoDoc
            // 
            this.ComboTipoDoc.FormattingEnabled = true;
            this.ComboTipoDoc.Location = new System.Drawing.Point(253, 99);
            this.ComboTipoDoc.Name = "ComboTipoDoc";
            this.ComboTipoDoc.Size = new System.Drawing.Size(183, 37);
            this.ComboTipoDoc.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 35);
            this.dateTimePicker1.TabIndex = 29;
            this.dateTimePicker1.Value = new System.DateTime(2023, 11, 12, 15, 20, 55, 0);
            // 
            // LblTipoDocumento
            // 
            this.LblTipoDocumento.AutoSize = true;
            this.LblTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoDocumento.Location = new System.Drawing.Point(251, 43);
            this.LblTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTipoDocumento.Name = "LblTipoDocumento";
            this.LblTipoDocumento.Size = new System.Drawing.Size(162, 25);
            this.LblTipoDocumento.TabIndex = 61;
            this.LblTipoDocumento.Text = "Tipo Documento:";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(20, 43);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(73, 25);
            this.LblFecha.TabIndex = 0;
            this.LblFecha.Text = "Fecha:";
            // 
            // groupBoxInfoCliente
            // 
            this.groupBoxInfoCliente.BackColor = System.Drawing.Color.White;
            this.groupBoxInfoCliente.Controls.Add(this.TxtIdCliente);
            this.groupBoxInfoCliente.Controls.Add(this.TxtRazonSocial);
            this.groupBoxInfoCliente.Controls.Add(this.LblRazonSocial);
            this.groupBoxInfoCliente.Controls.Add(this.BtnBuscarCliente);
            this.groupBoxInfoCliente.Controls.Add(this.TxtRUC);
            this.groupBoxInfoCliente.Controls.Add(this.LblNroDocumento);
            this.groupBoxInfoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoCliente.Location = new System.Drawing.Point(656, 51);
            this.groupBoxInfoCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInfoCliente.Name = "groupBoxInfoCliente";
            this.groupBoxInfoCliente.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInfoCliente.Size = new System.Drawing.Size(789, 164);
            this.groupBoxInfoCliente.TabIndex = 27;
            this.groupBoxInfoCliente.TabStop = false;
            this.groupBoxInfoCliente.Text = "Informacion del Cliente";
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Location = new System.Drawing.Point(281, 31);
            this.TxtIdCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(28, 35);
            this.TxtIdCliente.TabIndex = 63;
            this.TxtIdCliente.Text = "0";
            this.TxtIdCliente.Visible = false;
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Location = new System.Drawing.Point(392, 92);
            this.TxtRazonSocial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.ReadOnly = true;
            this.TxtRazonSocial.Size = new System.Drawing.Size(249, 35);
            this.TxtRazonSocial.TabIndex = 62;
            // 
            // LblRazonSocial
            // 
            this.LblRazonSocial.AutoSize = true;
            this.LblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRazonSocial.Location = new System.Drawing.Point(387, 37);
            this.LblRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRazonSocial.Name = "LblRazonSocial";
            this.LblRazonSocial.Size = new System.Drawing.Size(218, 25);
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
            this.BtnBuscarCliente.Location = new System.Drawing.Point(281, 84);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(64, 34);
            this.BtnBuscarCliente.TabIndex = 60;
            this.BtnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarCliente.UseVisualStyleBackColor = false;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // TxtRUC
            // 
            this.TxtRUC.Location = new System.Drawing.Point(14, 92);
            this.TxtRUC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRUC.Name = "TxtRUC";
            this.TxtRUC.ReadOnly = true;
            this.TxtRUC.Size = new System.Drawing.Size(199, 35);
            this.TxtRUC.TabIndex = 1;
            // 
            // LblNroDocumento
            // 
            this.LblNroDocumento.AutoSize = true;
            this.LblNroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNroDocumento.Location = new System.Drawing.Point(21, 43);
            this.LblNroDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNroDocumento.Name = "LblNroDocumento";
            this.LblNroDocumento.Size = new System.Drawing.Size(192, 25);
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
            this.LblHoraActual.Location = new System.Drawing.Point(1516, 83);
            this.LblHoraActual.Name = "LblHoraActual";
            this.LblHoraActual.Size = new System.Drawing.Size(0, 46);
            this.LblHoraActual.TabIndex = 89;
            // 
            // BtnCargarCobro
            // 
            this.BtnCargarCobro.BackColor = System.Drawing.Color.Crimson;
            this.BtnCargarCobro.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.BtnCargarCobro.Enabled = false;
            this.BtnCargarCobro.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCargarCobro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCargarCobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarCobro.ForeColor = System.Drawing.Color.White;
            this.BtnCargarCobro.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.BtnCargarCobro.IconColor = System.Drawing.Color.White;
            this.BtnCargarCobro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCargarCobro.IconSize = 18;
            this.BtnCargarCobro.Location = new System.Drawing.Point(18, 812);
            this.BtnCargarCobro.Name = "BtnCargarCobro";
            this.BtnCargarCobro.Size = new System.Drawing.Size(307, 63);
            this.BtnCargarCobro.TabIndex = 91;
            this.BtnCargarCobro.Text = "Medio de Cobro (F12)";
            this.BtnCargarCobro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCargarCobro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCargarCobro.UseVisualStyleBackColor = false;
            this.BtnCargarCobro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnCargarCobro_KeyDown);
            // 
            // LblTipoValor
            // 
            this.LblTipoValor.AutoSize = true;
            this.LblTipoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoValor.Location = new System.Drawing.Point(21, 53);
            this.LblTipoValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTipoValor.Name = "LblTipoValor";
            this.LblTipoValor.Size = new System.Drawing.Size(155, 25);
            this.LblTipoValor.TabIndex = 71;
            this.LblTipoValor.Text = "Tipo Valor (F11)";
            // 
            // TxtTipoValor
            // 
            this.TxtTipoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTipoValor.Location = new System.Drawing.Point(26, 101);
            this.TxtTipoValor.Name = "TxtTipoValor";
            this.TxtTipoValor.Size = new System.Drawing.Size(193, 41);
            this.TxtTipoValor.TabIndex = 72;
            this.TxtTipoValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTipoValor_KeyDown);
            this.TxtTipoValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTipoValor_KeyPress);
            // 
            // LblImporte
            // 
            this.LblImporte.AutoSize = true;
            this.LblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImporte.Location = new System.Drawing.Point(291, 53);
            this.LblImporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblImporte.Name = "LblImporte";
            this.LblImporte.Size = new System.Drawing.Size(83, 25);
            this.LblImporte.TabIndex = 74;
            this.LblImporte.Text = "Importe:";
            // 
            // TxtImporte
            // 
            this.TxtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImporte.Location = new System.Drawing.Point(296, 101);
            this.TxtImporte.Name = "TxtImporte";
            this.TxtImporte.Size = new System.Drawing.Size(193, 41);
            this.TxtImporte.TabIndex = 75;
            this.TxtImporte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtImporte_KeyDown);
            this.TxtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtImporte_KeyPress);
            // 
            // LblVuelto
            // 
            this.LblVuelto.AutoSize = true;
            this.LblVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVuelto.Location = new System.Drawing.Point(526, 53);
            this.LblVuelto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblVuelto.Name = "LblVuelto";
            this.LblVuelto.Size = new System.Drawing.Size(74, 25);
            this.LblVuelto.TabIndex = 76;
            this.LblVuelto.Text = "Vuelto:";
            // 
            // TxtVuelto
            // 
            this.TxtVuelto.Enabled = false;
            this.TxtVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVuelto.Location = new System.Drawing.Point(531, 101);
            this.TxtVuelto.Name = "TxtVuelto";
            this.TxtVuelto.Size = new System.Drawing.Size(193, 41);
            this.TxtVuelto.TabIndex = 77;
            // 
            // groupBoxFormaPago
            // 
            this.groupBoxFormaPago.BackColor = System.Drawing.Color.White;
            this.groupBoxFormaPago.Controls.Add(this.TxtCobroParcial);
            this.groupBoxFormaPago.Controls.Add(this.LblTotalFraccionado);
            this.groupBoxFormaPago.Controls.Add(this.TxtDocumento);
            this.groupBoxFormaPago.Controls.Add(this.LblDocumento);
            this.groupBoxFormaPago.Controls.Add(this.dgvData_Cobro);
            this.groupBoxFormaPago.Controls.Add(this.TxtVuelto);
            this.groupBoxFormaPago.Controls.Add(this.LblVuelto);
            this.groupBoxFormaPago.Controls.Add(this.TxtImporte);
            this.groupBoxFormaPago.Controls.Add(this.LblImporte);
            this.groupBoxFormaPago.Controls.Add(this.TxtTipoValor);
            this.groupBoxFormaPago.Controls.Add(this.LblTipoValor);
            this.groupBoxFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFormaPago.Location = new System.Drawing.Point(1169, 468);
            this.groupBoxFormaPago.Name = "groupBoxFormaPago";
            this.groupBoxFormaPago.Size = new System.Drawing.Size(1093, 619);
            this.groupBoxFormaPago.TabIndex = 92;
            this.groupBoxFormaPago.TabStop = false;
            this.groupBoxFormaPago.Text = "Detalle Cobro";
            this.groupBoxFormaPago.Visible = false;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocumento.Location = new System.Drawing.Point(26, 210);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(193, 41);
            this.TxtDocumento.TabIndex = 83;
            this.TxtDocumento.Visible = false;
            this.TxtDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDocumento_KeyDown);
            this.TxtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDocumento_KeyPress);
            // 
            // LblDocumento
            // 
            this.LblDocumento.AutoSize = true;
            this.LblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDocumento.Location = new System.Drawing.Point(21, 162);
            this.LblDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDocumento.Name = "LblDocumento";
            this.LblDocumento.Size = new System.Drawing.Size(118, 25);
            this.LblDocumento.TabIndex = 82;
            this.LblDocumento.Text = "Documento:";
            this.LblDocumento.Visible = false;
            // 
            // dgvData_Cobro
            // 
            this.dgvData_Cobro.AllowUserToAddRows = false;
            this.dgvData_Cobro.AllowUserToDeleteRows = false;
            this.dgvData_Cobro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData_Cobro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoValor,
            this.NroDocumento,
            this.Importe,
            this.ImporteVuelto});
            this.dgvData_Cobro.Location = new System.Drawing.Point(26, 313);
            this.dgvData_Cobro.Margin = new System.Windows.Forms.Padding(4, 5, 7, 5);
            this.dgvData_Cobro.Name = "dgvData_Cobro";
            this.dgvData_Cobro.ReadOnly = true;
            this.dgvData_Cobro.RowHeadersWidth = 62;
            this.dgvData_Cobro.Size = new System.Drawing.Size(672, 286);
            this.dgvData_Cobro.TabIndex = 81;
            this.dgvData_Cobro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_Cobro_CellContentClick);
            this.dgvData_Cobro.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_Cobro_CellPainting);
            // 
            // TipoValor
            // 
            this.TipoValor.HeaderText = "Tipo Valor";
            this.TipoValor.MinimumWidth = 8;
            this.TipoValor.Name = "TipoValor";
            this.TipoValor.ReadOnly = true;
            this.TipoValor.Width = 150;
            // 
            // NroDocumento
            // 
            this.NroDocumento.HeaderText = "Nro. Documento";
            this.NroDocumento.MinimumWidth = 8;
            this.NroDocumento.Name = "NroDocumento";
            this.NroDocumento.ReadOnly = true;
            this.NroDocumento.Width = 150;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 8;
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 150;
            // 
            // ImporteVuelto
            // 
            this.ImporteVuelto.HeaderText = "Importe Vuelto";
            this.ImporteVuelto.MinimumWidth = 8;
            this.ImporteVuelto.Name = "ImporteVuelto";
            this.ImporteVuelto.ReadOnly = true;
            this.ImporteVuelto.Width = 150;
            // 
            // LblMoneda
            // 
            this.LblMoneda.AutoSize = true;
            this.LblMoneda.BackColor = System.Drawing.Color.White;
            this.LblMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMoneda.Location = new System.Drawing.Point(349, 916);
            this.LblMoneda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMoneda.Name = "LblMoneda";
            this.LblMoneda.Size = new System.Drawing.Size(61, 36);
            this.LblMoneda.TabIndex = 93;
            this.LblMoneda.Text = "Gs.";
            // 
            // TxtCobroParcial
            // 
            this.TxtCobroParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCobroParcial.Location = new System.Drawing.Point(296, 217);
            this.TxtCobroParcial.Name = "TxtCobroParcial";
            this.TxtCobroParcial.Size = new System.Drawing.Size(266, 53);
            this.TxtCobroParcial.TabIndex = 85;
            // 
            // LblTotalFraccionado
            // 
            this.LblTotalFraccionado.AutoSize = true;
            this.LblTotalFraccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalFraccionado.Location = new System.Drawing.Point(291, 174);
            this.LblTotalFraccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTotalFraccionado.Name = "LblTotalFraccionado";
            this.LblTotalFraccionado.Size = new System.Drawing.Size(148, 29);
            this.LblTotalFraccionado.TabIndex = 84;
            this.LblTotalFraccionado.Text = "Parcial Total";
            // 
            // FrmRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2289, 1117);
            this.Controls.Add(this.LblMoneda);
            this.Controls.Add(this.groupBoxFormaPago);
            this.Controls.Add(this.BtnCargarCobro);
            this.Controls.Add(this.LblHoraActual);
            this.Controls.Add(this.groupBoxInfoPedido);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.textBoxTotalPagar);
            this.Controls.Add(this.LblTotalPagar);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.LblPedidos);
            this.Name = "FrmRegistrarVenta";
            this.Text = "Registro de Venta";
            this.Load += new System.EventHandler(this.FrmRegistrarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBoxInfoPedido.ResumeLayout(false);
            this.groupBoxInfoProductos.ResumeLayout(false);
            this.groupBoxInfoProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.groupBoxInfoVenta.ResumeLayout(false);
            this.groupBoxInfoVenta.PerformLayout();
            this.groupBoxInfoCliente.ResumeLayout(false);
            this.groupBoxInfoCliente.PerformLayout();
            this.groupBoxFormaPago.ResumeLayout(false);
            this.groupBoxFormaPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData_Cobro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPedidos;
        private FontAwesome.Sharp.IconButton BtnConfirmar;
        private System.Windows.Forms.TextBox textBoxTotalPagar;
        private System.Windows.Forms.Label LblTotalPagar;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
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
        private FontAwesome.Sharp.IconButton BtnCargarCobro;
        private System.Windows.Forms.Label LblTipoValor;
        private System.Windows.Forms.TextBox TxtTipoValor;
        private System.Windows.Forms.Label LblImporte;
        private System.Windows.Forms.TextBox TxtImporte;
        private System.Windows.Forms.Label LblVuelto;
        private System.Windows.Forms.TextBox TxtVuelto;
        private System.Windows.Forms.GroupBox groupBoxFormaPago;
        private System.Windows.Forms.Label LblMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEliminar;
        private System.Windows.Forms.DataGridView dgvData_Cobro;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.Label LblDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteVuelto;
        private System.Windows.Forms.TextBox TxtCobroParcial;
        private System.Windows.Forms.Label LblTotalFraccionado;
    }
}
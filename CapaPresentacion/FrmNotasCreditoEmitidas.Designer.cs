﻿namespace CapaPresentacion
{
    partial class FrmNotasCreditoEmitidas
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
            this.TxtTotalNota = new System.Windows.Forms.TextBox();
            this.LblTotalNota = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxInfoProducto = new System.Windows.Forms.GroupBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.TxtPrecioVenta = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new FontAwesome.Sharp.IconButton();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.TxtDescProducto = new System.Windows.Forms.TextBox();
            this.LblDescProducto = new System.Windows.Forms.Label();
            this.BntBuscarProd = new FontAwesome.Sharp.IconButton();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.TxtCodProducto = new System.Windows.Forms.TextBox();
            this.LblCodProducto = new System.Windows.Forms.Label();
            this.groupBoxInfoNC = new System.Windows.Forms.GroupBox();
            this.TxtNroCaja = new System.Windows.Forms.TextBox();
            this.LblNroCaja = new System.Windows.Forms.Label();
            this.TxtCajero = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.TxtIdVenta = new System.Windows.Forms.TextBox();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.dtpFinVigencia = new System.Windows.Forms.DateTimePicker();
            this.LblFinVigencia = new System.Windows.Forms.Label();
            this.dtpInicioVigencia = new System.Windows.Forms.DateTimePicker();
            this.LblInicioVigencia = new System.Windows.Forms.Label();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.TxtTimbrado = new System.Windows.Forms.TextBox();
            this.LblTimbrado = new System.Windows.Forms.Label();
            this.TxtDoc = new System.Windows.Forms.TextBox();
            this.TxtPuntoEmision = new System.Windows.Forms.TextBox();
            this.LblCodEstablecimiento = new System.Windows.Forms.Label();
            this.TxtCodEstablecimiento = new System.Windows.Forms.TextBox();
            this.BtnBuscarVenta = new FontAwesome.Sharp.IconButton();
            this.groupBoxInfoCliente = new System.Windows.Forms.GroupBox();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.BtnBuscarCliente = new FontAwesome.Sharp.IconButton();
            this.TxtRUC = new System.Windows.Forms.TextBox();
            this.LblRUC = new System.Windows.Forms.Label();
            this.ComboTipoDoc = new System.Windows.Forms.ComboBox();
            this.LblTipoDoc = new System.Windows.Forms.Label();
            this.TxtObs = new System.Windows.Forms.TextBox();
            this.LblObs = new System.Windows.Forms.Label();
            this.TxtNroFactura = new System.Windows.Forms.TextBox();
            this.LboNroFactura = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblNCRecibida = new System.Windows.Forms.Label();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBoxInfoProducto.SuspendLayout();
            this.groupBoxInfoNC.SuspendLayout();
            this.groupBoxInfoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtTotalNota
            // 
            this.TxtTotalNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalNota.Location = new System.Drawing.Point(897, 530);
            this.TxtTotalNota.Name = "TxtTotalNota";
            this.TxtTotalNota.ReadOnly = true;
            this.TxtTotalNota.Size = new System.Drawing.Size(182, 26);
            this.TxtTotalNota.TabIndex = 70;
            this.TxtTotalNota.Text = "0";
            // 
            // LblTotalNota
            // 
            this.LblTotalNota.AutoSize = true;
            this.LblTotalNota.BackColor = System.Drawing.Color.White;
            this.LblTotalNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalNota.Location = new System.Drawing.Point(893, 509);
            this.LblTotalNota.Name = "LblTotalNota";
            this.LblTotalNota.Size = new System.Drawing.Size(159, 20);
            this.LblTotalNota.TabIndex = 69;
            this.LblTotalNota.Text = "Total Nota de Crédito";
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
            this.dgvData.Location = new System.Drawing.Point(25, 320);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(844, 236);
            this.dgvData.TabIndex = 68;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting);
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
            // groupBoxInfoProducto
            // 
            this.groupBoxInfoProducto.BackColor = System.Drawing.Color.White;
            this.groupBoxInfoProducto.Controls.Add(this.TxtCantidad);
            this.groupBoxInfoProducto.Controls.Add(this.LblCantidad);
            this.groupBoxInfoProducto.Controls.Add(this.TxtPrecioVenta);
            this.groupBoxInfoProducto.Controls.Add(this.LblPrecio);
            this.groupBoxInfoProducto.Controls.Add(this.TxtDescProducto);
            this.groupBoxInfoProducto.Controls.Add(this.LblDescProducto);
            this.groupBoxInfoProducto.Controls.Add(this.BntBuscarProd);
            this.groupBoxInfoProducto.Controls.Add(this.TxtIdProducto);
            this.groupBoxInfoProducto.Controls.Add(this.TxtCodProducto);
            this.groupBoxInfoProducto.Controls.Add(this.LblCodProducto);
            this.groupBoxInfoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoProducto.Location = new System.Drawing.Point(25, 242);
            this.groupBoxInfoProducto.Name = "groupBoxInfoProducto";
            this.groupBoxInfoProducto.Size = new System.Drawing.Size(844, 72);
            this.groupBoxInfoProducto.TabIndex = 67;
            this.groupBoxInfoProducto.TabStop = false;
            this.groupBoxInfoProducto.Text = "Información del Producto";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(549, 38);
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
            this.LblCantidad.Location = new System.Drawing.Point(546, 22);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(52, 13);
            this.LblCantidad.TabIndex = 70;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.Enabled = false;
            this.TxtPrecioVenta.Location = new System.Drawing.Point(671, 38);
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.Size = new System.Drawing.Size(95, 22);
            this.TxtPrecioVenta.TabIndex = 69;
            this.TxtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecioVenta_KeyPress);
            this.TxtPrecioVenta.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPrecioVenta_Validating);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.BtnAgregar.IconColor = System.Drawing.Color.Black;
            this.BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAgregar.Location = new System.Drawing.Point(882, 242);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(82, 72);
            this.BtnAgregar.TabIndex = 56;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.Location = new System.Drawing.Point(668, 22);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(40, 13);
            this.LblPrecio.TabIndex = 68;
            this.LblPrecio.Text = "Precio:";
            // 
            // TxtDescProducto
            // 
            this.TxtDescProducto.Location = new System.Drawing.Point(199, 38);
            this.TxtDescProducto.Name = "TxtDescProducto";
            this.TxtDescProducto.ReadOnly = true;
            this.TxtDescProducto.Size = new System.Drawing.Size(327, 22);
            this.TxtDescProducto.TabIndex = 67;
            // 
            // LblDescProducto
            // 
            this.LblDescProducto.AutoSize = true;
            this.LblDescProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescProducto.Location = new System.Drawing.Point(196, 22);
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
            this.BntBuscarProd.Margin = new System.Windows.Forms.Padding(2);
            this.BntBuscarProd.Name = "BntBuscarProd";
            this.BntBuscarProd.Size = new System.Drawing.Size(43, 22);
            this.BntBuscarProd.TabIndex = 65;
            this.BntBuscarProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BntBuscarProd.UseVisualStyleBackColor = false;
            this.BntBuscarProd.Click += new System.EventHandler(this.BntBuscarProd_Click);
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.Location = new System.Drawing.Point(164, 12);
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.Size = new System.Drawing.Size(26, 22);
            this.TxtIdProducto.TabIndex = 64;
            this.TxtIdProducto.Text = "0";
            this.TxtIdProducto.Visible = false;
            // 
            // TxtCodProducto
            // 
            this.TxtCodProducto.Location = new System.Drawing.Point(9, 39);
            this.TxtCodProducto.Name = "TxtCodProducto";
            this.TxtCodProducto.Size = new System.Drawing.Size(124, 22);
            this.TxtCodProducto.TabIndex = 1;
            this.TxtCodProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodProducto_KeyDown);
            // 
            // LblCodProducto
            // 
            this.LblCodProducto.AutoSize = true;
            this.LblCodProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodProducto.Location = new System.Drawing.Point(6, 22);
            this.LblCodProducto.Name = "LblCodProducto";
            this.LblCodProducto.Size = new System.Drawing.Size(89, 13);
            this.LblCodProducto.TabIndex = 0;
            this.LblCodProducto.Text = "Codigo Producto:";
            // 
            // groupBoxInfoNC
            // 
            this.groupBoxInfoNC.BackColor = System.Drawing.Color.White;
            this.groupBoxInfoNC.Controls.Add(this.TxtNroCaja);
            this.groupBoxInfoNC.Controls.Add(this.LblNroCaja);
            this.groupBoxInfoNC.Controls.Add(this.TxtCajero);
            this.groupBoxInfoNC.Controls.Add(this.LblUsuario);
            this.groupBoxInfoNC.Controls.Add(this.TxtIdVenta);
            this.groupBoxInfoNC.Controls.Add(this.dtpFechaVenta);
            this.groupBoxInfoNC.Controls.Add(this.dtpFinVigencia);
            this.groupBoxInfoNC.Controls.Add(this.LblFinVigencia);
            this.groupBoxInfoNC.Controls.Add(this.dtpInicioVigencia);
            this.groupBoxInfoNC.Controls.Add(this.LblInicioVigencia);
            this.groupBoxInfoNC.Controls.Add(this.BtnLimpiar);
            this.groupBoxInfoNC.Controls.Add(this.TxtTimbrado);
            this.groupBoxInfoNC.Controls.Add(this.LblTimbrado);
            this.groupBoxInfoNC.Controls.Add(this.TxtDoc);
            this.groupBoxInfoNC.Controls.Add(this.TxtPuntoEmision);
            this.groupBoxInfoNC.Controls.Add(this.LblCodEstablecimiento);
            this.groupBoxInfoNC.Controls.Add(this.TxtCodEstablecimiento);
            this.groupBoxInfoNC.Controls.Add(this.BtnBuscarVenta);
            this.groupBoxInfoNC.Controls.Add(this.groupBoxInfoCliente);
            this.groupBoxInfoNC.Controls.Add(this.ComboTipoDoc);
            this.groupBoxInfoNC.Controls.Add(this.LblTipoDoc);
            this.groupBoxInfoNC.Controls.Add(this.TxtObs);
            this.groupBoxInfoNC.Controls.Add(this.LblObs);
            this.groupBoxInfoNC.Controls.Add(this.TxtNroFactura);
            this.groupBoxInfoNC.Controls.Add(this.LboNroFactura);
            this.groupBoxInfoNC.Controls.Add(this.dtpFecha);
            this.groupBoxInfoNC.Controls.Add(this.LblFecha);
            this.groupBoxInfoNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoNC.Location = new System.Drawing.Point(16, 21);
            this.groupBoxInfoNC.Name = "groupBoxInfoNC";
            this.groupBoxInfoNC.Size = new System.Drawing.Size(1084, 215);
            this.groupBoxInfoNC.TabIndex = 66;
            this.groupBoxInfoNC.TabStop = false;
            this.groupBoxInfoNC.Text = "Información de la Nota Crédito";
            // 
            // TxtNroCaja
            // 
            this.TxtNroCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNroCaja.Location = new System.Drawing.Point(914, 151);
            this.TxtNroCaja.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNroCaja.Name = "TxtNroCaja";
            this.TxtNroCaja.Size = new System.Drawing.Size(139, 21);
            this.TxtNroCaja.TabIndex = 111;
            // 
            // LblNroCaja
            // 
            this.LblNroCaja.AutoSize = true;
            this.LblNroCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNroCaja.Location = new System.Drawing.Point(855, 154);
            this.LblNroCaja.Name = "LblNroCaja";
            this.LblNroCaja.Size = new System.Drawing.Size(54, 13);
            this.LblNroCaja.TabIndex = 110;
            this.LblNroCaja.Text = "Nro. Caja:";
            // 
            // TxtCajero
            // 
            this.TxtCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCajero.Location = new System.Drawing.Point(914, 123);
            this.TxtCajero.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCajero.Name = "TxtCajero";
            this.TxtCajero.Size = new System.Drawing.Size(139, 21);
            this.TxtCajero.TabIndex = 109;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(869, 128);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(40, 13);
            this.LblUsuario.TabIndex = 108;
            this.LblUsuario.Text = "Cajero:";
            // 
            // TxtIdVenta
            // 
            this.TxtIdVenta.Location = new System.Drawing.Point(620, 154);
            this.TxtIdVenta.Name = "TxtIdVenta";
            this.TxtIdVenta.Size = new System.Drawing.Size(100, 22);
            this.TxtIdVenta.TabIndex = 107;
            this.TxtIdVenta.Visible = false;
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVenta.Location = new System.Drawing.Point(620, 124);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaVenta.TabIndex = 106;
            this.dtpFechaVenta.Value = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            this.dtpFechaVenta.Visible = false;
            // 
            // dtpFinVigencia
            // 
            this.dtpFinVigencia.Enabled = false;
            this.dtpFinVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinVigencia.Location = new System.Drawing.Point(237, 133);
            this.dtpFinVigencia.Name = "dtpFinVigencia";
            this.dtpFinVigencia.Size = new System.Drawing.Size(97, 20);
            this.dtpFinVigencia.TabIndex = 105;
            this.dtpFinVigencia.Value = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            // 
            // LblFinVigencia
            // 
            this.LblFinVigencia.AutoSize = true;
            this.LblFinVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFinVigencia.Location = new System.Drawing.Point(234, 117);
            this.LblFinVigencia.Name = "LblFinVigencia";
            this.LblFinVigencia.Size = new System.Drawing.Size(83, 13);
            this.LblFinVigencia.TabIndex = 104;
            this.LblFinVigencia.Text = "Fin de Vigencia:";
            // 
            // dtpInicioVigencia
            // 
            this.dtpInicioVigencia.Enabled = false;
            this.dtpInicioVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicioVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioVigencia.Location = new System.Drawing.Point(130, 133);
            this.dtpInicioVigencia.Name = "dtpInicioVigencia";
            this.dtpInicioVigencia.Size = new System.Drawing.Size(97, 20);
            this.dtpInicioVigencia.TabIndex = 103;
            this.dtpInicioVigencia.Value = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            // 
            // LblInicioVigencia
            // 
            this.LblInicioVigencia.AutoSize = true;
            this.LblInicioVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInicioVigencia.Location = new System.Drawing.Point(127, 117);
            this.LblInicioVigencia.Name = "LblInicioVigencia";
            this.LblInicioVigencia.Size = new System.Drawing.Size(94, 13);
            this.LblInicioVigencia.TabIndex = 102;
            this.LblInicioVigencia.Text = "Inicio de Vigencia:";
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
            this.BtnLimpiar.Location = new System.Drawing.Point(177, 39);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(43, 26);
            this.BtnLimpiar.TabIndex = 101;
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // TxtTimbrado
            // 
            this.TxtTimbrado.Enabled = false;
            this.TxtTimbrado.Location = new System.Drawing.Point(9, 133);
            this.TxtTimbrado.Name = "TxtTimbrado";
            this.TxtTimbrado.Size = new System.Drawing.Size(112, 22);
            this.TxtTimbrado.TabIndex = 98;
            this.TxtTimbrado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTimbrado_KeyPress);
            // 
            // LblTimbrado
            // 
            this.LblTimbrado.AutoSize = true;
            this.LblTimbrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimbrado.Location = new System.Drawing.Point(6, 117);
            this.LblTimbrado.Name = "LblTimbrado";
            this.LblTimbrado.Size = new System.Drawing.Size(54, 13);
            this.LblTimbrado.TabIndex = 97;
            this.LblTimbrado.Text = "Timbrado:";
            // 
            // TxtDoc
            // 
            this.TxtDoc.Enabled = false;
            this.TxtDoc.Location = new System.Drawing.Point(319, 88);
            this.TxtDoc.Name = "TxtDoc";
            this.TxtDoc.Size = new System.Drawing.Size(90, 22);
            this.TxtDoc.TabIndex = 96;
            this.TxtDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDoc_KeyPress);
            // 
            // TxtPuntoEmision
            // 
            this.TxtPuntoEmision.Enabled = false;
            this.TxtPuntoEmision.Location = new System.Drawing.Point(278, 88);
            this.TxtPuntoEmision.Name = "TxtPuntoEmision";
            this.TxtPuntoEmision.Size = new System.Drawing.Size(35, 22);
            this.TxtPuntoEmision.TabIndex = 95;
            this.TxtPuntoEmision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPuntoEmision_KeyPress);
            // 
            // LblCodEstablecimiento
            // 
            this.LblCodEstablecimiento.AutoSize = true;
            this.LblCodEstablecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodEstablecimiento.Location = new System.Drawing.Point(234, 70);
            this.LblCodEstablecimiento.Name = "LblCodEstablecimiento";
            this.LblCodEstablecimiento.Size = new System.Drawing.Size(84, 13);
            this.LblCodEstablecimiento.TabIndex = 94;
            this.LblCodEstablecimiento.Text = "Nota de Crédito:";
            // 
            // TxtCodEstablecimiento
            // 
            this.TxtCodEstablecimiento.Enabled = false;
            this.TxtCodEstablecimiento.Location = new System.Drawing.Point(237, 88);
            this.TxtCodEstablecimiento.Name = "TxtCodEstablecimiento";
            this.TxtCodEstablecimiento.Size = new System.Drawing.Size(35, 22);
            this.TxtCodEstablecimiento.TabIndex = 93;
            this.TxtCodEstablecimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodEstablecimiento_KeyPress);
            // 
            // BtnBuscarVenta
            // 
            this.BtnBuscarVenta.BackColor = System.Drawing.Color.White;
            this.BtnBuscarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarVenta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarVenta.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarVenta.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscarVenta.IconColor = System.Drawing.Color.Black;
            this.BtnBuscarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscarVenta.IconSize = 16;
            this.BtnBuscarVenta.Location = new System.Drawing.Point(130, 39);
            this.BtnBuscarVenta.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscarVenta.Name = "BtnBuscarVenta";
            this.BtnBuscarVenta.Size = new System.Drawing.Size(43, 26);
            this.BtnBuscarVenta.TabIndex = 92;
            this.BtnBuscarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarVenta.UseVisualStyleBackColor = false;
            this.BtnBuscarVenta.Click += new System.EventHandler(this.BtnBuscarVenta_Click);
            // 
            // groupBoxInfoCliente
            // 
            this.groupBoxInfoCliente.BackColor = System.Drawing.Color.White;
            this.groupBoxInfoCliente.Controls.Add(this.TxtIdCliente);
            this.groupBoxInfoCliente.Controls.Add(this.TxtNombre);
            this.groupBoxInfoCliente.Controls.Add(this.LblNombre);
            this.groupBoxInfoCliente.Controls.Add(this.BtnBuscarCliente);
            this.groupBoxInfoCliente.Controls.Add(this.TxtRUC);
            this.groupBoxInfoCliente.Controls.Add(this.LblRUC);
            this.groupBoxInfoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoCliente.Location = new System.Drawing.Point(652, 43);
            this.groupBoxInfoCliente.Name = "groupBoxInfoCliente";
            this.groupBoxInfoCliente.Size = new System.Drawing.Size(411, 75);
            this.groupBoxInfoCliente.TabIndex = 27;
            this.groupBoxInfoCliente.TabStop = false;
            this.groupBoxInfoCliente.Text = "Información del Cliente";
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Location = new System.Drawing.Point(127, 18);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(26, 20);
            this.TxtIdCliente.TabIndex = 63;
            this.TxtIdCliente.Text = "0";
            this.TxtIdCliente.Visible = false;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(178, 42);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.ReadOnly = true;
            this.TxtNombre.Size = new System.Drawing.Size(223, 20);
            this.TxtNombre.TabIndex = 62;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(175, 27);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(121, 13);
            this.LblNombre.TabIndex = 61;
            this.LblNombre.Text = "Nombre / Razón Social:";
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
            this.BtnBuscarCliente.Location = new System.Drawing.Point(127, 40);
            this.BtnBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(43, 22);
            this.BtnBuscarCliente.TabIndex = 60;
            this.BtnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarCliente.UseVisualStyleBackColor = false;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
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
            // ComboTipoDoc
            // 
            this.ComboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTipoDoc.FormattingEnabled = true;
            this.ComboTipoDoc.Location = new System.Drawing.Point(9, 88);
            this.ComboTipoDoc.Name = "ComboTipoDoc";
            this.ComboTipoDoc.Size = new System.Drawing.Size(173, 24);
            this.ComboTipoDoc.TabIndex = 88;
            // 
            // LblTipoDoc
            // 
            this.LblTipoDoc.AutoSize = true;
            this.LblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoDoc.Location = new System.Drawing.Point(6, 72);
            this.LblTipoDoc.Name = "LblTipoDoc";
            this.LblTipoDoc.Size = new System.Drawing.Size(89, 13);
            this.LblTipoDoc.TabIndex = 8;
            this.LblTipoDoc.Text = "Tipo Documento:";
            // 
            // TxtObs
            // 
            this.TxtObs.Location = new System.Drawing.Point(8, 182);
            this.TxtObs.Name = "TxtObs";
            this.TxtObs.Size = new System.Drawing.Size(1055, 22);
            this.TxtObs.TabIndex = 7;
            // 
            // LblObs
            // 
            this.LblObs.AutoSize = true;
            this.LblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObs.Location = new System.Drawing.Point(5, 165);
            this.LblObs.Name = "LblObs";
            this.LblObs.Size = new System.Drawing.Size(70, 13);
            this.LblObs.TabIndex = 6;
            this.LblObs.Text = "Observación:";
            // 
            // TxtNroFactura
            // 
            this.TxtNroFactura.Location = new System.Drawing.Point(8, 43);
            this.TxtNroFactura.Name = "TxtNroFactura";
            this.TxtNroFactura.Size = new System.Drawing.Size(113, 22);
            this.TxtNroFactura.TabIndex = 5;
            this.TxtNroFactura.Text = "0";
            this.TxtNroFactura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNroFactura_KeyDown);
            // 
            // LboNroFactura
            // 
            this.LboNroFactura.AutoSize = true;
            this.LboNroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LboNroFactura.Location = new System.Drawing.Point(5, 27);
            this.LboNroFactura.Name = "LboNroFactura";
            this.LboNroFactura.Size = new System.Drawing.Size(117, 13);
            this.LboNroFactura.TabIndex = 4;
            this.LboNroFactura.Text = "Número Factura Venta:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(439, 88);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(97, 20);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.Value = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(436, 72);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(40, 13);
            this.LblFecha.TabIndex = 0;
            this.LblFecha.Text = "Fecha:";
            // 
            // LblNCRecibida
            // 
            this.LblNCRecibida.BackColor = System.Drawing.Color.White;
            this.LblNCRecibida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNCRecibida.Location = new System.Drawing.Point(11, 9);
            this.LblNCRecibida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNCRecibida.Name = "LblNCRecibida";
            this.LblNCRecibida.Padding = new System.Windows.Forms.Padding(2);
            this.LblNCRecibida.Size = new System.Drawing.Size(1111, 563);
            this.LblNCRecibida.TabIndex = 65;
            this.LblNCRecibida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.BtnGuardar.Location = new System.Drawing.Point(897, 467);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(125, 27);
            this.BtnGuardar.TabIndex = 71;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FrmNotasCreditoEmitidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 591);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtTotalNota);
            this.Controls.Add(this.LblTotalNota);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupBoxInfoProducto);
            this.Controls.Add(this.groupBoxInfoNC);
            this.Controls.Add(this.LblNCRecibida);
            this.Name = "FrmNotasCreditoEmitidas";
            this.Text = "Notas de Crédito Emitidas";
            this.Load += new System.EventHandler(this.FrmNotasCreditoEmitidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBoxInfoProducto.ResumeLayout(false);
            this.groupBoxInfoProducto.PerformLayout();
            this.groupBoxInfoNC.ResumeLayout(false);
            this.groupBoxInfoNC.PerformLayout();
            this.groupBoxInfoCliente.ResumeLayout(false);
            this.groupBoxInfoCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.TextBox TxtTotalNota;
        private System.Windows.Forms.Label LblTotalNota;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEliminar;
        private System.Windows.Forms.GroupBox groupBoxInfoProducto;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox TxtPrecioVenta;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.TextBox TxtDescProducto;
        private System.Windows.Forms.Label LblDescProducto;
        private FontAwesome.Sharp.IconButton BntBuscarProd;
        private System.Windows.Forms.TextBox TxtIdProducto;
        private System.Windows.Forms.TextBox TxtCodProducto;
        private System.Windows.Forms.Label LblCodProducto;
        private System.Windows.Forms.GroupBox groupBoxInfoNC;
        private System.Windows.Forms.TextBox TxtIdVenta;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.DateTimePicker dtpFinVigencia;
        private System.Windows.Forms.Label LblFinVigencia;
        private System.Windows.Forms.DateTimePicker dtpInicioVigencia;
        private System.Windows.Forms.Label LblInicioVigencia;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private System.Windows.Forms.TextBox TxtTimbrado;
        private System.Windows.Forms.Label LblTimbrado;
        private System.Windows.Forms.TextBox TxtDoc;
        private System.Windows.Forms.TextBox TxtPuntoEmision;
        private System.Windows.Forms.Label LblCodEstablecimiento;
        private System.Windows.Forms.TextBox TxtCodEstablecimiento;
        private FontAwesome.Sharp.IconButton BtnBuscarVenta;
        private System.Windows.Forms.GroupBox groupBoxInfoCliente;
        private System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private FontAwesome.Sharp.IconButton BtnBuscarCliente;
        private System.Windows.Forms.TextBox TxtRUC;
        private System.Windows.Forms.Label LblRUC;
        private System.Windows.Forms.ComboBox ComboTipoDoc;
        private System.Windows.Forms.Label LblTipoDoc;
        private System.Windows.Forms.TextBox TxtObs;
        private System.Windows.Forms.Label LblObs;
        private System.Windows.Forms.TextBox TxtNroFactura;
        private System.Windows.Forms.Label LboNroFactura;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblNCRecibida;
        private System.Windows.Forms.TextBox TxtNroCaja;
        private System.Windows.Forms.Label LblNroCaja;
        private System.Windows.Forms.TextBox TxtCajero;
        private System.Windows.Forms.Label LblUsuario;
    }
}
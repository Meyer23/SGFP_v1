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
            this.BtnConfirmar = new FontAwesome.Sharp.IconButton();
            this.textBoxTotalPagar = new System.Windows.Forms.TextBox();
            this.LblTotalPagar = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBoxFormaPago = new System.Windows.Forms.GroupBox();
            this.TxtTipoValor = new System.Windows.Forms.TextBox();
            this.LblTipoValor = new System.Windows.Forms.Label();
            this.ChkValidaDocumento = new System.Windows.Forms.CheckBox();
            this.LblImporte = new System.Windows.Forms.Label();
            this.TxtImporte = new System.Windows.Forms.TextBox();
            this.TxtVuelto = new System.Windows.Forms.TextBox();
            this.LblVuelto = new System.Windows.Forms.Label();
            this.ValidarMedioCobro = new System.Windows.Forms.GroupBox();
            this.LblBanco = new System.Windows.Forms.Label();
            this.ComboBanco = new System.Windows.Forms.ComboBox();
            this.LblNroCuenta = new System.Windows.Forms.Label();
            this.TxtNroCuenta = new System.Windows.Forms.TextBox();
            this.LblNroCheque = new System.Windows.Forms.Label();
            this.TxtNroCheque = new System.Windows.Forms.TextBox();
            this.LblFechaVencim = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBoxInfoPedido.SuspendLayout();
            this.groupBoxInfoProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.groupBoxInfoVenta.SuspendLayout();
            this.groupBoxInfoCliente.SuspendLayout();
            this.groupBoxFormaPago.SuspendLayout();
            this.ValidarMedioCobro.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblPedidos
            // 
            this.LblPedidos.BackColor = System.Drawing.Color.White;
            this.LblPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPedidos.Location = new System.Drawing.Point(12, 9);
            this.LblPedidos.Name = "LblPedidos";
            this.LblPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.LblPedidos.Size = new System.Drawing.Size(1997, 1099);
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
            this.BtnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnConfirmar.IconColor = System.Drawing.Color.White;
            this.BtnConfirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConfirmar.IconSize = 18;
            this.BtnConfirmar.Location = new System.Drawing.Point(594, 872);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(245, 40);
            this.BtnConfirmar.TabIndex = 87;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            // 
            // textBoxTotalPagar
            // 
            this.textBoxTotalPagar.Location = new System.Drawing.Point(598, 828);
            this.textBoxTotalPagar.Name = "textBoxTotalPagar";
            this.textBoxTotalPagar.Size = new System.Drawing.Size(245, 26);
            this.textBoxTotalPagar.TabIndex = 82;
            // 
            // LblTotalPagar
            // 
            this.LblTotalPagar.AutoSize = true;
            this.LblTotalPagar.BackColor = System.Drawing.Color.White;
            this.LblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalPagar.Location = new System.Drawing.Point(462, 826);
            this.LblTotalPagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTotalPagar.Name = "LblTotalPagar";
            this.LblTotalPagar.Size = new System.Drawing.Size(129, 26);
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
            this.dgvData.Size = new System.Drawing.Size(848, 321);
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
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 35);
            this.dateTimePicker1.TabIndex = 29;
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
            this.BtnCargarCobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarCobro.ForeColor = System.Drawing.Color.White;
            this.BtnCargarCobro.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.BtnCargarCobro.IconColor = System.Drawing.Color.White;
            this.BtnCargarCobro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCargarCobro.IconSize = 18;
            this.BtnCargarCobro.Location = new System.Drawing.Point(18, 812);
            this.BtnCargarCobro.Name = "BtnCargarCobro";
            this.BtnCargarCobro.Size = new System.Drawing.Size(245, 40);
            this.BtnCargarCobro.TabIndex = 91;
            this.BtnCargarCobro.Text = "Medio de Cobro (F12)";
            this.BtnCargarCobro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCargarCobro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCargarCobro.UseVisualStyleBackColor = false;
            this.BtnCargarCobro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnCargarCobro_KeyDown);
            // 
            // groupBoxFormaPago
            // 
            this.groupBoxFormaPago.BackColor = System.Drawing.Color.White;
            this.groupBoxFormaPago.Controls.Add(this.ValidarMedioCobro);
            this.groupBoxFormaPago.Controls.Add(this.TxtVuelto);
            this.groupBoxFormaPago.Controls.Add(this.LblVuelto);
            this.groupBoxFormaPago.Controls.Add(this.TxtImporte);
            this.groupBoxFormaPago.Controls.Add(this.LblImporte);
            this.groupBoxFormaPago.Controls.Add(this.ChkValidaDocumento);
            this.groupBoxFormaPago.Controls.Add(this.TxtTipoValor);
            this.groupBoxFormaPago.Controls.Add(this.LblTipoValor);
            this.groupBoxFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFormaPago.Location = new System.Drawing.Point(929, 468);
            this.groupBoxFormaPago.Name = "groupBoxFormaPago";
            this.groupBoxFormaPago.Size = new System.Drawing.Size(1061, 619);
            this.groupBoxFormaPago.TabIndex = 92;
            this.groupBoxFormaPago.TabStop = false;
            this.groupBoxFormaPago.Text = "Detalle Cobro";
            this.groupBoxFormaPago.Visible = false;
            // 
            // TxtTipoValor
            // 
            this.TxtTipoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTipoValor.Location = new System.Drawing.Point(26, 101);
            this.TxtTipoValor.Name = "TxtTipoValor";
            this.TxtTipoValor.Size = new System.Drawing.Size(193, 41);
            this.TxtTipoValor.TabIndex = 72;
            this.TxtTipoValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTipoValor_KeyDown);
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
            // ChkValidaDocumento
            // 
            this.ChkValidaDocumento.AutoSize = true;
            this.ChkValidaDocumento.Enabled = false;
            this.ChkValidaDocumento.Location = new System.Drawing.Point(26, 164);
            this.ChkValidaDocumento.Name = "ChkValidaDocumento";
            this.ChkValidaDocumento.Size = new System.Drawing.Size(114, 33);
            this.ChkValidaDocumento.TabIndex = 73;
            this.ChkValidaDocumento.Text = "Validar";
            this.ChkValidaDocumento.UseVisualStyleBackColor = true;
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
            // ValidarMedioCobro
            // 
            this.ValidarMedioCobro.Controls.Add(this.dateTimePicker2);
            this.ValidarMedioCobro.Controls.Add(this.LblFechaVencim);
            this.ValidarMedioCobro.Controls.Add(this.TxtNroCheque);
            this.ValidarMedioCobro.Controls.Add(this.LblNroCheque);
            this.ValidarMedioCobro.Controls.Add(this.TxtNroCuenta);
            this.ValidarMedioCobro.Controls.Add(this.LblNroCuenta);
            this.ValidarMedioCobro.Controls.Add(this.ComboBanco);
            this.ValidarMedioCobro.Controls.Add(this.LblBanco);
            this.ValidarMedioCobro.Location = new System.Drawing.Point(26, 243);
            this.ValidarMedioCobro.Name = "ValidarMedioCobro";
            this.ValidarMedioCobro.Size = new System.Drawing.Size(852, 328);
            this.ValidarMedioCobro.TabIndex = 78;
            this.ValidarMedioCobro.TabStop = false;
            this.ValidarMedioCobro.Text = "Datos del Cobro";
            this.ValidarMedioCobro.Visible = false;
            // 
            // LblBanco
            // 
            this.LblBanco.AutoSize = true;
            this.LblBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBanco.Location = new System.Drawing.Point(7, 53);
            this.LblBanco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBanco.Name = "LblBanco";
            this.LblBanco.Size = new System.Drawing.Size(74, 25);
            this.LblBanco.TabIndex = 75;
            this.LblBanco.Text = "Banco:";
            // 
            // ComboBanco
            // 
            this.ComboBanco.FormattingEnabled = true;
            this.ComboBanco.Location = new System.Drawing.Point(12, 90);
            this.ComboBanco.Name = "ComboBanco";
            this.ComboBanco.Size = new System.Drawing.Size(195, 37);
            this.ComboBanco.TabIndex = 76;
            // 
            // LblNroCuenta
            // 
            this.LblNroCuenta.AutoSize = true;
            this.LblNroCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNroCuenta.Location = new System.Drawing.Point(7, 161);
            this.LblNroCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNroCuenta.Name = "LblNroCuenta";
            this.LblNroCuenta.Size = new System.Drawing.Size(123, 25);
            this.LblNroCuenta.TabIndex = 77;
            this.LblNroCuenta.Text = "Nro. Cuenta:";
            // 
            // TxtNroCuenta
            // 
            this.TxtNroCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNroCuenta.Location = new System.Drawing.Point(12, 206);
            this.TxtNroCuenta.Name = "TxtNroCuenta";
            this.TxtNroCuenta.Size = new System.Drawing.Size(195, 41);
            this.TxtNroCuenta.TabIndex = 78;
            // 
            // LblNroCheque
            // 
            this.LblNroCheque.AutoSize = true;
            this.LblNroCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNroCheque.Location = new System.Drawing.Point(254, 53);
            this.LblNroCheque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNroCheque.Name = "LblNroCheque";
            this.LblNroCheque.Size = new System.Drawing.Size(129, 25);
            this.LblNroCheque.TabIndex = 79;
            this.LblNroCheque.Text = "Nro. Cheque:";
            this.LblNroCheque.Visible = false;
            // 
            // TxtNroCheque
            // 
            this.TxtNroCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNroCheque.Location = new System.Drawing.Point(259, 86);
            this.TxtNroCheque.Name = "TxtNroCheque";
            this.TxtNroCheque.Size = new System.Drawing.Size(195, 41);
            this.TxtNroCheque.TabIndex = 80;
            this.TxtNroCheque.Visible = false;
            // 
            // LblFechaVencim
            // 
            this.LblFechaVencim.AutoSize = true;
            this.LblFechaVencim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaVencim.Location = new System.Drawing.Point(500, 59);
            this.LblFechaVencim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFechaVencim.Name = "LblFechaVencim";
            this.LblFechaVencim.Size = new System.Drawing.Size(186, 25);
            this.LblFechaVencim.TabIndex = 81;
            this.LblFechaVencim.Text = "Fecha Vencimiento:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(505, 92);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(193, 35);
            this.dateTimePicker2.TabIndex = 82;
            // 
            // FrmRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2289, 1117);
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
            this.ValidarMedioCobro.ResumeLayout(false);
            this.ValidarMedioCobro.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnCargarCobro;
        private System.Windows.Forms.GroupBox groupBoxFormaPago;
        private System.Windows.Forms.TextBox TxtTipoValor;
        private System.Windows.Forms.Label LblTipoValor;
        private System.Windows.Forms.CheckBox ChkValidaDocumento;
        private System.Windows.Forms.TextBox TxtImporte;
        private System.Windows.Forms.Label LblImporte;
        private System.Windows.Forms.TextBox TxtVuelto;
        private System.Windows.Forms.Label LblVuelto;
        private System.Windows.Forms.GroupBox ValidarMedioCobro;
        private System.Windows.Forms.Label LblBanco;
        private System.Windows.Forms.ComboBox ComboBanco;
        private System.Windows.Forms.TextBox TxtNroCuenta;
        private System.Windows.Forms.Label LblNroCuenta;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label LblFechaVencim;
        private System.Windows.Forms.TextBox TxtNroCheque;
        private System.Windows.Forms.Label LblNroCheque;
    }
}
namespace CapaPresentacion
{
    partial class FrmVerDetalleMovStock
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
            this.LblTotalCompra = new System.Windows.Forms.Label();
            this.TxtTotalCantidad = new System.Windows.Forms.TextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxInfoPedido = new System.Windows.Forms.GroupBox();
            this.TxtIdMovStock = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.TxtTipoMov = new System.Windows.Forms.TextBox();
            this.LblTipoMov = new System.Windows.Forms.Label();
            this.TxtObs = new System.Windows.Forms.TextBox();
            this.LblObs = new System.Windows.Forms.Label();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.LboDocumento = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblPedidos = new System.Windows.Forms.Label();
            this.BtnAgregar = new FontAwesome.Sharp.IconButton();
            this.LblAnulado = new System.Windows.Forms.Label();
            this.checkBoxAnulado = new System.Windows.Forms.CheckBox();
            this.LblConfirmado = new System.Windows.Forms.Label();
            this.PbConfirmado = new System.Windows.Forms.PictureBox();
            this.checkBoxConfirmado = new System.Windows.Forms.CheckBox();
            this.LblNoConfirmado = new System.Windows.Forms.Label();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.LblDocumento = new System.Windows.Forms.Label();
            this.BtnImprimir = new FontAwesome.Sharp.IconButton();
            this.PbNoConfirmado = new System.Windows.Forms.PictureBox();
            this.BtnConfirmar = new FontAwesome.Sharp.IconButton();
            this.BtnAnular = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBoxInfoPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbConfirmado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNoConfirmado)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTotalCompra
            // 
            this.LblTotalCompra.AutoSize = true;
            this.LblTotalCompra.BackColor = System.Drawing.Color.White;
            this.LblTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalCompra.Location = new System.Drawing.Point(811, 460);
            this.LblTotalCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTotalCompra.Name = "LblTotalCompra";
            this.LblTotalCompra.Size = new System.Drawing.Size(95, 16);
            this.LblTotalCompra.TabIndex = 60;
            this.LblTotalCompra.Text = "Total Cantidad";
            // 
            // TxtTotalCantidad
            // 
            this.TxtTotalCantidad.Location = new System.Drawing.Point(813, 478);
            this.TxtTotalCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTotalCantidad.Name = "TxtTotalCantidad";
            this.TxtTotalCantidad.ReadOnly = true;
            this.TxtTotalCantidad.Size = new System.Drawing.Size(122, 20);
            this.TxtTotalCantidad.TabIndex = 61;
            this.TxtTotalCantidad.Text = "0";
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
            this.Cantidad,
            this.BtnEliminar});
            this.dgvData.Location = new System.Drawing.Point(12, 263);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.Size = new System.Drawing.Size(793, 236);
            this.dgvData.TabIndex = 59;
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
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
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
            this.groupBoxInfoPedido.Controls.Add(this.TxtIdMovStock);
            this.groupBoxInfoPedido.Controls.Add(this.TxtUsuario);
            this.groupBoxInfoPedido.Controls.Add(this.LblUsuario);
            this.groupBoxInfoPedido.Controls.Add(this.TxtTipoMov);
            this.groupBoxInfoPedido.Controls.Add(this.LblTipoMov);
            this.groupBoxInfoPedido.Controls.Add(this.TxtObs);
            this.groupBoxInfoPedido.Controls.Add(this.LblObs);
            this.groupBoxInfoPedido.Controls.Add(this.TxtDocumento);
            this.groupBoxInfoPedido.Controls.Add(this.LboDocumento);
            this.groupBoxInfoPedido.Controls.Add(this.dtpFecha);
            this.groupBoxInfoPedido.Controls.Add(this.LblFecha);
            this.groupBoxInfoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoPedido.Location = new System.Drawing.Point(12, 102);
            this.groupBoxInfoPedido.Name = "groupBoxInfoPedido";
            this.groupBoxInfoPedido.Size = new System.Drawing.Size(793, 136);
            this.groupBoxInfoPedido.TabIndex = 56;
            this.groupBoxInfoPedido.TabStop = false;
            this.groupBoxInfoPedido.Text = "Información del Movimiento Stock";
            // 
            // TxtIdMovStock
            // 
            this.TxtIdMovStock.Location = new System.Drawing.Point(158, 17);
            this.TxtIdMovStock.Name = "TxtIdMovStock";
            this.TxtIdMovStock.Size = new System.Drawing.Size(23, 22);
            this.TxtIdMovStock.TabIndex = 105;
            this.TxtIdMovStock.Visible = false;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(430, 41);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.ReadOnly = true;
            this.TxtUsuario.Size = new System.Drawing.Size(129, 22);
            this.TxtUsuario.TabIndex = 104;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(427, 25);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(46, 13);
            this.LblUsuario.TabIndex = 103;
            this.LblUsuario.Text = "Usuario:";
            // 
            // TxtTipoMov
            // 
            this.TxtTipoMov.Location = new System.Drawing.Point(9, 43);
            this.TxtTipoMov.Name = "TxtTipoMov";
            this.TxtTipoMov.ReadOnly = true;
            this.TxtTipoMov.Size = new System.Drawing.Size(173, 22);
            this.TxtTipoMov.TabIndex = 100;
            // 
            // LblTipoMov
            // 
            this.LblTipoMov.AutoSize = true;
            this.LblTipoMov.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoMov.Location = new System.Drawing.Point(6, 27);
            this.LblTipoMov.Name = "LblTipoMov";
            this.LblTipoMov.Size = new System.Drawing.Size(88, 13);
            this.LblTipoMov.TabIndex = 8;
            this.LblTipoMov.Text = "Tipo Movimiento:";
            // 
            // TxtObs
            // 
            this.TxtObs.Location = new System.Drawing.Point(9, 96);
            this.TxtObs.Name = "TxtObs";
            this.TxtObs.ReadOnly = true;
            this.TxtObs.Size = new System.Drawing.Size(749, 22);
            this.TxtObs.TabIndex = 7;
            // 
            // LblObs
            // 
            this.LblObs.AutoSize = true;
            this.LblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObs.Location = new System.Drawing.Point(6, 79);
            this.LblObs.Name = "LblObs";
            this.LblObs.Size = new System.Drawing.Size(70, 13);
            this.LblObs.TabIndex = 6;
            this.LblObs.Text = "Observación:";
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Location = new System.Drawing.Point(198, 43);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.ReadOnly = true;
            this.TxtDocumento.Size = new System.Drawing.Size(100, 22);
            this.TxtDocumento.TabIndex = 5;
            // 
            // LboDocumento
            // 
            this.LboDocumento.AutoSize = true;
            this.LboDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LboDocumento.Location = new System.Drawing.Point(195, 27);
            this.LboDocumento.Name = "LboDocumento";
            this.LboDocumento.Size = new System.Drawing.Size(65, 13);
            this.LboDocumento.TabIndex = 4;
            this.LboDocumento.Text = "Documento:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(315, 43);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(97, 20);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.Value = new System.DateTime(2023, 11, 2, 0, 0, 0, 0);
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(312, 27);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(40, 13);
            this.LblFecha.TabIndex = 0;
            this.LblFecha.Text = "Fecha:";
            // 
            // LblPedidos
            // 
            this.LblPedidos.BackColor = System.Drawing.Color.White;
            this.LblPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPedidos.Location = new System.Drawing.Point(3, 7);
            this.LblPedidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPedidos.Name = "LblPedidos";
            this.LblPedidos.Padding = new System.Windows.Forms.Padding(2);
            this.LblPedidos.Size = new System.Drawing.Size(962, 519);
            this.LblPedidos.TabIndex = 55;
            this.LblPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.BtnAgregar.IconColor = System.Drawing.Color.Black;
            this.BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAgregar.Location = new System.Drawing.Point(723, 175);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(82, 72);
            this.BtnAgregar.TabIndex = 58;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // LblAnulado
            // 
            this.LblAnulado.AutoSize = true;
            this.LblAnulado.BackColor = System.Drawing.Color.White;
            this.LblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnulado.ForeColor = System.Drawing.Color.Red;
            this.LblAnulado.Location = new System.Drawing.Point(809, 53);
            this.LblAnulado.Name = "LblAnulado";
            this.LblAnulado.Size = new System.Drawing.Size(81, 24);
            this.LblAnulado.TabIndex = 118;
            this.LblAnulado.Text = "Anulado";
            // 
            // checkBoxAnulado
            // 
            this.checkBoxAnulado.AutoSize = true;
            this.checkBoxAnulado.Location = new System.Drawing.Point(732, 64);
            this.checkBoxAnulado.Name = "checkBoxAnulado";
            this.checkBoxAnulado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAnulado.TabIndex = 117;
            this.checkBoxAnulado.UseVisualStyleBackColor = true;
            this.checkBoxAnulado.Visible = false;
            // 
            // LblConfirmado
            // 
            this.LblConfirmado.AutoSize = true;
            this.LblConfirmado.BackColor = System.Drawing.Color.White;
            this.LblConfirmado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConfirmado.ForeColor = System.Drawing.Color.Green;
            this.LblConfirmado.Location = new System.Drawing.Point(783, 55);
            this.LblConfirmado.Name = "LblConfirmado";
            this.LblConfirmado.Size = new System.Drawing.Size(107, 24);
            this.LblConfirmado.TabIndex = 116;
            this.LblConfirmado.Text = "Confirmado";
            // 
            // PbConfirmado
            // 
            this.PbConfirmado.BackColor = System.Drawing.Color.White;
            this.PbConfirmado.Image = global::CapaPresentacion.Properties.Resources.OK;
            this.PbConfirmado.Location = new System.Drawing.Point(896, 44);
            this.PbConfirmado.Name = "PbConfirmado";
            this.PbConfirmado.Size = new System.Drawing.Size(43, 39);
            this.PbConfirmado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbConfirmado.TabIndex = 115;
            this.PbConfirmado.TabStop = false;
            // 
            // checkBoxConfirmado
            // 
            this.checkBoxConfirmado.AutoSize = true;
            this.checkBoxConfirmado.Location = new System.Drawing.Point(732, 44);
            this.checkBoxConfirmado.Name = "checkBoxConfirmado";
            this.checkBoxConfirmado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxConfirmado.TabIndex = 114;
            this.checkBoxConfirmado.UseVisualStyleBackColor = true;
            this.checkBoxConfirmado.Visible = false;
            // 
            // LblNoConfirmado
            // 
            this.LblNoConfirmado.AutoSize = true;
            this.LblNoConfirmado.BackColor = System.Drawing.Color.White;
            this.LblNoConfirmado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNoConfirmado.ForeColor = System.Drawing.Color.DarkOrange;
            this.LblNoConfirmado.Location = new System.Drawing.Point(753, 55);
            this.LblNoConfirmado.Name = "LblNoConfirmado";
            this.LblNoConfirmado.Size = new System.Drawing.Size(137, 24);
            this.LblNoConfirmado.TabIndex = 113;
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
            this.BtnLimpiar.Location = new System.Drawing.Point(301, 37);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(43, 26);
            this.BtnLimpiar.TabIndex = 122;
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
            this.BtnBuscar.Location = new System.Drawing.Point(254, 37);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(43, 26);
            this.BtnBuscar.TabIndex = 121;
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(94, 41);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(155, 20);
            this.TxtBusqueda.TabIndex = 119;
            this.TxtBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBusqueda_KeyDown);
            // 
            // LblDocumento
            // 
            this.LblDocumento.AutoSize = true;
            this.LblDocumento.BackColor = System.Drawing.Color.White;
            this.LblDocumento.Location = new System.Drawing.Point(23, 44);
            this.LblDocumento.Name = "LblDocumento";
            this.LblDocumento.Size = new System.Drawing.Size(65, 13);
            this.LblDocumento.TabIndex = 120;
            this.LblDocumento.Text = "Documento:";
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.ForeColor = System.Drawing.Color.White;
            this.BtnImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.BtnImprimir.IconColor = System.Drawing.Color.White;
            this.BtnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImprimir.IconSize = 16;
            this.BtnImprimir.Location = new System.Drawing.Point(813, 413);
            this.BtnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(142, 27);
            this.BtnImprimir.TabIndex = 124;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // PbNoConfirmado
            // 
            this.PbNoConfirmado.BackColor = System.Drawing.Color.White;
            this.PbNoConfirmado.Image = global::CapaPresentacion.Properties.Resources.cancelar;
            this.PbNoConfirmado.Location = new System.Drawing.Point(896, 44);
            this.PbNoConfirmado.Name = "PbNoConfirmado";
            this.PbNoConfirmado.Size = new System.Drawing.Size(43, 39);
            this.PbNoConfirmado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbNoConfirmado.TabIndex = 125;
            this.PbNoConfirmado.TabStop = false;
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
            this.BtnConfirmar.Location = new System.Drawing.Point(814, 328);
            this.BtnConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(138, 27);
            this.BtnConfirmar.TabIndex = 126;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
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
            this.BtnAnular.Location = new System.Drawing.Point(814, 369);
            this.BtnAnular.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAnular.Name = "BtnAnular";
            this.BtnAnular.Size = new System.Drawing.Size(138, 27);
            this.BtnAnular.TabIndex = 129;
            this.BtnAnular.Text = "Anular";
            this.BtnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAnular.UseVisualStyleBackColor = false;
            this.BtnAnular.Click += new System.EventHandler(this.BtnAnular_Click);
            // 
            // FrmVerDetalleMovStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 534);
            this.Controls.Add(this.BtnAnular);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.PbNoConfirmado);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.LblDocumento);
            this.Controls.Add(this.LblAnulado);
            this.Controls.Add(this.checkBoxAnulado);
            this.Controls.Add(this.LblConfirmado);
            this.Controls.Add(this.PbConfirmado);
            this.Controls.Add(this.checkBoxConfirmado);
            this.Controls.Add(this.LblNoConfirmado);
            this.Controls.Add(this.LblTotalCompra);
            this.Controls.Add(this.TxtTotalCantidad);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupBoxInfoPedido);
            this.Controls.Add(this.LblPedidos);
            this.Controls.Add(this.BtnAgregar);
            this.Name = "FrmVerDetalleMovStock";
            this.Text = "Consulta de Movimientos Stock";
            this.Load += new System.EventHandler(this.FrmVerDetalleMovStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBoxInfoPedido.ResumeLayout(false);
            this.groupBoxInfoPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbConfirmado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNoConfirmado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblTotalCompra;
        private System.Windows.Forms.TextBox TxtTotalCantidad;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox groupBoxInfoPedido;
        private System.Windows.Forms.Label LblTipoMov;
        private System.Windows.Forms.TextBox TxtObs;
        private System.Windows.Forms.Label LblObs;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.Label LboDocumento;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblPedidos;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private System.Windows.Forms.Label LblAnulado;
        private System.Windows.Forms.CheckBox checkBoxAnulado;
        private System.Windows.Forms.Label LblConfirmado;
        private System.Windows.Forms.PictureBox PbConfirmado;
        private System.Windows.Forms.CheckBox checkBoxConfirmado;
        private System.Windows.Forms.Label LblNoConfirmado;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Label LblDocumento;
        private FontAwesome.Sharp.IconButton BtnImprimir;
        private System.Windows.Forms.TextBox TxtTipoMov;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.PictureBox PbNoConfirmado;
        private FontAwesome.Sharp.IconButton BtnConfirmar;
        private System.Windows.Forms.TextBox TxtIdMovStock;
        private FontAwesome.Sharp.IconButton BtnAnular;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEliminar;
    }
}
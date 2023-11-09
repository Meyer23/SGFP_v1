namespace CapaPresentacion
{
    partial class FrmMovimientosStock
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
            this.ComboTipoMov = new System.Windows.Forms.ComboBox();
            this.LblTipoMov = new System.Windows.Forms.Label();
            this.TxtObs = new System.Windows.Forms.TextBox();
            this.LblObs = new System.Windows.Forms.Label();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.LboDocumento = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.LblFecha = new System.Windows.Forms.Label();
            this.BtnAgregar = new FontAwesome.Sharp.IconButton();
            this.groupBoxInfoProducto = new System.Windows.Forms.GroupBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.TxtDescProducto = new System.Windows.Forms.TextBox();
            this.LblDescProducto = new System.Windows.Forms.Label();
            this.BntBuscarProd = new FontAwesome.Sharp.IconButton();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.TxtCodProducto = new System.Windows.Forms.TextBox();
            this.LblCodProducto = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.TxtTotalCantidad = new System.Windows.Forms.TextBox();
            this.LblTotalCompra = new System.Windows.Forms.Label();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxInfoPedido.SuspendLayout();
            this.groupBoxInfoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPedidos
            // 
            this.LblPedidos.BackColor = System.Drawing.Color.White;
            this.LblPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPedidos.Location = new System.Drawing.Point(7, 12);
            this.LblPedidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPedidos.Name = "LblPedidos";
            this.LblPedidos.Padding = new System.Windows.Forms.Padding(2);
            this.LblPedidos.Size = new System.Drawing.Size(945, 519);
            this.LblPedidos.TabIndex = 25;
            this.LblPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxInfoPedido
            // 
            this.groupBoxInfoPedido.BackColor = System.Drawing.Color.White;
            this.groupBoxInfoPedido.Controls.Add(this.ComboTipoMov);
            this.groupBoxInfoPedido.Controls.Add(this.LblTipoMov);
            this.groupBoxInfoPedido.Controls.Add(this.TxtObs);
            this.groupBoxInfoPedido.Controls.Add(this.LblObs);
            this.groupBoxInfoPedido.Controls.Add(this.TxtDocumento);
            this.groupBoxInfoPedido.Controls.Add(this.LboDocumento);
            this.groupBoxInfoPedido.Controls.Add(this.dtpFecha);
            this.groupBoxInfoPedido.Controls.Add(this.LblFecha);
            this.groupBoxInfoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoPedido.Location = new System.Drawing.Point(16, 26);
            this.groupBoxInfoPedido.Name = "groupBoxInfoPedido";
            this.groupBoxInfoPedido.Size = new System.Drawing.Size(793, 136);
            this.groupBoxInfoPedido.TabIndex = 27;
            this.groupBoxInfoPedido.TabStop = false;
            this.groupBoxInfoPedido.Text = "Información del Pedido";
            // 
            // ComboTipoMov
            // 
            this.ComboTipoMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTipoMov.FormattingEnabled = true;
            this.ComboTipoMov.Items.AddRange(new object[] {
            "ENTRADA",
            "SALIDA"});
            this.ComboTipoMov.Location = new System.Drawing.Point(9, 43);
            this.ComboTipoMov.Name = "ComboTipoMov";
            this.ComboTipoMov.Size = new System.Drawing.Size(173, 24);
            this.ComboTipoMov.TabIndex = 88;
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
            // BtnAgregar
            // 
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.BtnAgregar.IconColor = System.Drawing.Color.Black;
            this.BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAgregar.Location = new System.Drawing.Point(727, 180);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(82, 72);
            this.BtnAgregar.TabIndex = 32;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // groupBoxInfoProducto
            // 
            this.groupBoxInfoProducto.BackColor = System.Drawing.Color.White;
            this.groupBoxInfoProducto.Controls.Add(this.TxtCantidad);
            this.groupBoxInfoProducto.Controls.Add(this.LblCantidad);
            this.groupBoxInfoProducto.Controls.Add(this.TxtDescProducto);
            this.groupBoxInfoProducto.Controls.Add(this.LblDescProducto);
            this.groupBoxInfoProducto.Controls.Add(this.BntBuscarProd);
            this.groupBoxInfoProducto.Controls.Add(this.TxtIdProducto);
            this.groupBoxInfoProducto.Controls.Add(this.TxtCodProducto);
            this.groupBoxInfoProducto.Controls.Add(this.LblCodProducto);
            this.groupBoxInfoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoProducto.Location = new System.Drawing.Point(16, 180);
            this.groupBoxInfoProducto.Name = "groupBoxInfoProducto";
            this.groupBoxInfoProducto.Size = new System.Drawing.Size(705, 72);
            this.groupBoxInfoProducto.TabIndex = 31;
            this.groupBoxInfoProducto.TabStop = false;
            this.groupBoxInfoProducto.Text = "Información del Producto";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(551, 38);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(95, 22);
            this.TxtCantidad.TabIndex = 71;
            this.TxtCantidad.Text = "1";
            this.TxtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(548, 22);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(52, 13);
            this.LblCantidad.TabIndex = 70;
            this.LblCantidad.Text = "Cantidad:";
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
            this.Descripcion,
            this.Cantidad,
            this.BtnEliminar});
            this.dgvData.Location = new System.Drawing.Point(16, 268);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.Size = new System.Drawing.Size(793, 236);
            this.dgvData.TabIndex = 33;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting);
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
            this.BtnGuardar.Location = new System.Drawing.Point(819, 425);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(1);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(125, 27);
            this.BtnGuardar.TabIndex = 54;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtTotalCantidad
            // 
            this.TxtTotalCantidad.Location = new System.Drawing.Point(821, 480);
            this.TxtTotalCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTotalCantidad.Name = "TxtTotalCantidad";
            this.TxtTotalCantidad.ReadOnly = true;
            this.TxtTotalCantidad.Size = new System.Drawing.Size(122, 20);
            this.TxtTotalCantidad.TabIndex = 53;
            this.TxtTotalCantidad.Text = "0";
            // 
            // LblTotalCompra
            // 
            this.LblTotalCompra.AutoSize = true;
            this.LblTotalCompra.BackColor = System.Drawing.Color.White;
            this.LblTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalCompra.Location = new System.Drawing.Point(819, 462);
            this.LblTotalCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTotalCompra.Name = "LblTotalCompra";
            this.LblTotalCompra.Size = new System.Drawing.Size(95, 16);
            this.LblTotalCompra.TabIndex = 52;
            this.LblTotalCompra.Text = "Total Cantidad";
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
            // FrmMovimientosStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 540);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtTotalCantidad);
            this.Controls.Add(this.LblTotalCompra);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBoxInfoProducto);
            this.Controls.Add(this.groupBoxInfoPedido);
            this.Controls.Add(this.LblPedidos);
            this.Name = "FrmMovimientosStock";
            this.Text = "Movimientos Stock";
            this.groupBoxInfoPedido.ResumeLayout(false);
            this.groupBoxInfoPedido.PerformLayout();
            this.groupBoxInfoProducto.ResumeLayout(false);
            this.groupBoxInfoProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPedidos;
        private System.Windows.Forms.GroupBox groupBoxInfoPedido;
        private System.Windows.Forms.ComboBox ComboTipoMov;
        private System.Windows.Forms.Label LblTipoMov;
        private System.Windows.Forms.TextBox TxtObs;
        private System.Windows.Forms.Label LblObs;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.Label LboDocumento;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label LblFecha;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private System.Windows.Forms.GroupBox groupBoxInfoProducto;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox TxtDescProducto;
        private System.Windows.Forms.Label LblDescProducto;
        private FontAwesome.Sharp.IconButton BntBuscarProd;
        private System.Windows.Forms.TextBox TxtIdProducto;
        private System.Windows.Forms.TextBox TxtCodProducto;
        private System.Windows.Forms.Label LblCodProducto;
        private System.Windows.Forms.DataGridView dgvData;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.TextBox TxtTotalCantidad;
        private System.Windows.Forms.Label LblTotalCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEliminar;
    }
}
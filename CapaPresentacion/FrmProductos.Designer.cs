namespace CapaPresentacion
{
    partial class FrmProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtIndex = new System.Windows.Forms.TextBox();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.LblDetalleProducto = new System.Windows.Forms.Label();
            this.ChkActivo = new System.Windows.Forms.CheckBox();
            this.TxtExistenciaMinima = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtCosto = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.LblUnidadMedida = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblExistenciaMinima = new System.Windows.Forms.Label();
            this.LblExistencia = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblCosto = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.ComboBusqueda = new System.Windows.Forms.ComboBox();
            this.LblBuscarPor = new System.Windows.Forms.Label();
            this.LblListaProductos = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.TxtExistencia = new System.Windows.Forms.TextBox();
            this.groupBoxUbicacion = new System.Windows.Forms.GroupBox();
            this.TxtColumna = new System.Windows.Forms.TextBox();
            this.LblColumna = new System.Windows.Forms.Label();
            this.TxtFila = new System.Windows.Forms.TextBox();
            this.LblFila = new System.Windows.Forms.Label();
            this.TxtEstante = new System.Windows.Forms.TextBox();
            this.LblEstante = new System.Windows.Forms.Label();
            this.ComboCategoria = new System.Windows.Forms.ComboBox();
            this.ComboUnidadMedida = new System.Windows.Forms.ComboBox();
            this.BtnSubir = new FontAwesome.Sharp.IconButton();
            this.Imagen = new System.Windows.Forms.PictureBox();
            this.LblImagen = new System.Windows.Forms.Label();
            this.BtnUltimasCompras = new FontAwesome.Sharp.IconButton();
            this.BtnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExistenciaMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBoxUbicacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtIndex
            // 
            this.TxtIndex.Location = new System.Drawing.Point(127, 35);
            this.TxtIndex.Name = "TxtIndex";
            this.TxtIndex.Size = new System.Drawing.Size(26, 20);
            this.TxtIndex.TabIndex = 54;
            this.TxtIndex.Text = "-1";
            this.TxtIndex.Visible = false;
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.Location = new System.Drawing.Point(159, 35);
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.Size = new System.Drawing.Size(26, 20);
            this.TxtIdProducto.TabIndex = 52;
            this.TxtIdProducto.Text = "0";
            this.TxtIdProducto.Visible = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.BtnEditar.IconColor = System.Drawing.Color.White;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditar.IconSize = 18;
            this.BtnEditar.Location = new System.Drawing.Point(15, 511);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(173, 26);
            this.BtnEditar.TabIndex = 51;
            this.BtnEditar.Text = "Limpiar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
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
            this.BtnGuardar.Location = new System.Drawing.Point(15, 480);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(173, 27);
            this.BtnGuardar.TabIndex = 50;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LblDetalleProducto
            // 
            this.LblDetalleProducto.AutoSize = true;
            this.LblDetalleProducto.BackColor = System.Drawing.Color.White;
            this.LblDetalleProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDetalleProducto.Location = new System.Drawing.Point(11, 12);
            this.LblDetalleProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDetalleProducto.Name = "LblDetalleProducto";
            this.LblDetalleProducto.Size = new System.Drawing.Size(127, 20);
            this.LblDetalleProducto.TabIndex = 49;
            this.LblDetalleProducto.Text = "Detalle Producto";
            // 
            // ChkActivo
            // 
            this.ChkActivo.AutoSize = true;
            this.ChkActivo.BackColor = System.Drawing.Color.White;
            this.ChkActivo.Checked = true;
            this.ChkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkActivo.Location = new System.Drawing.Point(12, 458);
            this.ChkActivo.Name = "ChkActivo";
            this.ChkActivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkActivo.Size = new System.Drawing.Size(56, 17);
            this.ChkActivo.TabIndex = 48;
            this.ChkActivo.Text = "Activo";
            this.ChkActivo.UseVisualStyleBackColor = false;
            // 
            // TxtExistenciaMinima
            // 
            this.TxtExistenciaMinima.Location = new System.Drawing.Point(10, 340);
            this.TxtExistenciaMinima.Name = "TxtExistenciaMinima";
            this.TxtExistenciaMinima.Size = new System.Drawing.Size(173, 20);
            this.TxtExistenciaMinima.TabIndex = 45;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(10, 260);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.ReadOnly = true;
            this.TxtPrecio.Size = new System.Drawing.Size(173, 20);
            this.TxtPrecio.TabIndex = 44;
            this.TxtPrecio.Text = "0";
            // 
            // TxtCosto
            // 
            this.TxtCosto.Location = new System.Drawing.Point(10, 221);
            this.TxtCosto.Name = "TxtCosto";
            this.TxtCosto.ReadOnly = true;
            this.TxtCosto.Size = new System.Drawing.Size(173, 20);
            this.TxtCosto.TabIndex = 43;
            this.TxtCosto.Text = "0";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(10, 99);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(173, 20);
            this.TxtDescripcion.TabIndex = 42;
            this.TxtDescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDescripcion_Validating);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(10, 59);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(173, 20);
            this.TxtCodigo.TabIndex = 41;
            this.TxtCodigo.TabStop = false;
            this.TxtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodigo_Validating);
            // 
            // LblUnidadMedida
            // 
            this.LblUnidadMedida.AutoSize = true;
            this.LblUnidadMedida.BackColor = System.Drawing.Color.White;
            this.LblUnidadMedida.Location = new System.Drawing.Point(7, 164);
            this.LblUnidadMedida.Name = "LblUnidadMedida";
            this.LblUnidadMedida.Size = new System.Drawing.Size(97, 13);
            this.LblUnidadMedida.TabIndex = 40;
            this.LblUnidadMedida.Text = "Unidad de Medida:";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.BackColor = System.Drawing.Color.White;
            this.LblCategoria.Location = new System.Drawing.Point(7, 124);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(57, 13);
            this.LblCategoria.TabIndex = 39;
            this.LblCategoria.Text = "Categoría:";
            // 
            // LblExistenciaMinima
            // 
            this.LblExistenciaMinima.AutoSize = true;
            this.LblExistenciaMinima.BackColor = System.Drawing.Color.White;
            this.LblExistenciaMinima.Location = new System.Drawing.Point(7, 323);
            this.LblExistenciaMinima.Name = "LblExistenciaMinima";
            this.LblExistenciaMinima.Size = new System.Drawing.Size(96, 13);
            this.LblExistenciaMinima.TabIndex = 38;
            this.LblExistenciaMinima.Text = "Existencia Mínima:";
            // 
            // LblExistencia
            // 
            this.LblExistencia.AutoSize = true;
            this.LblExistencia.BackColor = System.Drawing.Color.White;
            this.LblExistencia.Location = new System.Drawing.Point(7, 283);
            this.LblExistencia.Name = "LblExistencia";
            this.LblExistencia.Size = new System.Drawing.Size(58, 13);
            this.LblExistencia.TabIndex = 37;
            this.LblExistencia.Text = "Existencia:";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.BackColor = System.Drawing.Color.White;
            this.LblPrecio.Location = new System.Drawing.Point(7, 244);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(40, 13);
            this.LblPrecio.TabIndex = 36;
            this.LblPrecio.Text = "Precio:";
            // 
            // LblCosto
            // 
            this.LblCosto.AutoSize = true;
            this.LblCosto.BackColor = System.Drawing.Color.White;
            this.LblCosto.Location = new System.Drawing.Point(7, 204);
            this.LblCosto.Name = "LblCosto";
            this.LblCosto.Size = new System.Drawing.Size(37, 13);
            this.LblCosto.TabIndex = 35;
            this.LblCosto.Text = "Costo:";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.BackColor = System.Drawing.Color.White;
            this.LblDescripcion.Location = new System.Drawing.Point(7, 82);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.LblDescripcion.TabIndex = 34;
            this.LblDescripcion.Text = "Descripción:";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.BackColor = System.Drawing.Color.White;
            this.LblCodigo.Location = new System.Drawing.Point(7, 42);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(43, 13);
            this.LblCodigo.TabIndex = 33;
            this.LblCodigo.Text = "Código:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 544);
            this.label1.TabIndex = 32;
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
            this.BtnLimpiar.Location = new System.Drawing.Point(1126, 17);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(43, 26);
            this.BtnLimpiar.TabIndex = 60;
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
            this.BtnBuscar.Location = new System.Drawing.Point(1079, 17);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(43, 26);
            this.BtnBuscar.TabIndex = 59;
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(919, 21);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(155, 20);
            this.TxtBusqueda.TabIndex = 55;
            // 
            // ComboBusqueda
            // 
            this.ComboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBusqueda.FormattingEnabled = true;
            this.ComboBusqueda.Location = new System.Drawing.Point(792, 21);
            this.ComboBusqueda.Name = "ComboBusqueda";
            this.ComboBusqueda.Size = new System.Drawing.Size(121, 21);
            this.ComboBusqueda.TabIndex = 58;
            // 
            // LblBuscarPor
            // 
            this.LblBuscarPor.AutoSize = true;
            this.LblBuscarPor.BackColor = System.Drawing.Color.White;
            this.LblBuscarPor.Location = new System.Drawing.Point(725, 24);
            this.LblBuscarPor.Name = "LblBuscarPor";
            this.LblBuscarPor.Size = new System.Drawing.Size(61, 13);
            this.LblBuscarPor.TabIndex = 57;
            this.LblBuscarPor.Text = "Buscar por:";
            // 
            // LblListaProductos
            // 
            this.LblListaProductos.BackColor = System.Drawing.Color.White;
            this.LblListaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblListaProductos.Location = new System.Drawing.Point(376, 9);
            this.LblListaProductos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblListaProductos.Name = "LblListaProductos";
            this.LblListaProductos.Padding = new System.Windows.Forms.Padding(2);
            this.LblListaProductos.Size = new System.Drawing.Size(982, 40);
            this.LblListaProductos.TabIndex = 56;
            this.LblListaProductos.Text = "Lista de Productos";
            this.LblListaProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnSeleccionar,
            this.idProducto,
            this.Codigo,
            this.Descripcion,
            this.Costo,
            this.Precio,
            this.Existencia,
            this.ExistenciaMinima,
            this.Categoria,
            this.UnidadMedida,
            this.Estante,
            this.Fila,
            this.Columna,
            this.Activo});
            this.dgvData.Location = new System.Drawing.Point(376, 68);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(982, 439);
            this.dgvData.TabIndex = 61;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting);
            // 
            // TxtExistencia
            // 
            this.TxtExistencia.Location = new System.Drawing.Point(10, 300);
            this.TxtExistencia.Name = "TxtExistencia";
            this.TxtExistencia.ReadOnly = true;
            this.TxtExistencia.Size = new System.Drawing.Size(173, 20);
            this.TxtExistencia.TabIndex = 62;
            this.TxtExistencia.Text = "0";
            // 
            // groupBoxUbicacion
            // 
            this.groupBoxUbicacion.BackColor = System.Drawing.Color.White;
            this.groupBoxUbicacion.Controls.Add(this.TxtColumna);
            this.groupBoxUbicacion.Controls.Add(this.LblColumna);
            this.groupBoxUbicacion.Controls.Add(this.TxtFila);
            this.groupBoxUbicacion.Controls.Add(this.LblFila);
            this.groupBoxUbicacion.Controls.Add(this.TxtEstante);
            this.groupBoxUbicacion.Controls.Add(this.LblEstante);
            this.groupBoxUbicacion.Location = new System.Drawing.Point(12, 366);
            this.groupBoxUbicacion.Name = "groupBoxUbicacion";
            this.groupBoxUbicacion.Size = new System.Drawing.Size(173, 86);
            this.groupBoxUbicacion.TabIndex = 63;
            this.groupBoxUbicacion.TabStop = false;
            this.groupBoxUbicacion.Text = "Ubicación";
            // 
            // TxtColumna
            // 
            this.TxtColumna.Location = new System.Drawing.Point(58, 57);
            this.TxtColumna.Name = "TxtColumna";
            this.TxtColumna.Size = new System.Drawing.Size(76, 20);
            this.TxtColumna.TabIndex = 53;
            // 
            // LblColumna
            // 
            this.LblColumna.AutoSize = true;
            this.LblColumna.BackColor = System.Drawing.Color.White;
            this.LblColumna.Location = new System.Drawing.Point(6, 60);
            this.LblColumna.Name = "LblColumna";
            this.LblColumna.Size = new System.Drawing.Size(51, 13);
            this.LblColumna.TabIndex = 52;
            this.LblColumna.Text = "Columna:";
            // 
            // TxtFila
            // 
            this.TxtFila.Location = new System.Drawing.Point(58, 35);
            this.TxtFila.Name = "TxtFila";
            this.TxtFila.Size = new System.Drawing.Size(76, 20);
            this.TxtFila.TabIndex = 51;
            // 
            // LblFila
            // 
            this.LblFila.AutoSize = true;
            this.LblFila.BackColor = System.Drawing.Color.White;
            this.LblFila.Location = new System.Drawing.Point(26, 38);
            this.LblFila.Name = "LblFila";
            this.LblFila.Size = new System.Drawing.Size(26, 13);
            this.LblFila.TabIndex = 50;
            this.LblFila.Text = "Fila:";
            // 
            // TxtEstante
            // 
            this.TxtEstante.Location = new System.Drawing.Point(58, 13);
            this.TxtEstante.Name = "TxtEstante";
            this.TxtEstante.Size = new System.Drawing.Size(76, 20);
            this.TxtEstante.TabIndex = 49;
            // 
            // LblEstante
            // 
            this.LblEstante.AutoSize = true;
            this.LblEstante.BackColor = System.Drawing.Color.White;
            this.LblEstante.Location = new System.Drawing.Point(6, 16);
            this.LblEstante.Name = "LblEstante";
            this.LblEstante.Size = new System.Drawing.Size(46, 13);
            this.LblEstante.TabIndex = 48;
            this.LblEstante.Text = "Estante:";
            // 
            // ComboCategoria
            // 
            this.ComboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCategoria.FormattingEnabled = true;
            this.ComboCategoria.Location = new System.Drawing.Point(10, 140);
            this.ComboCategoria.Name = "ComboCategoria";
            this.ComboCategoria.Size = new System.Drawing.Size(173, 21);
            this.ComboCategoria.TabIndex = 87;
            // 
            // ComboUnidadMedida
            // 
            this.ComboUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboUnidadMedida.FormattingEnabled = true;
            this.ComboUnidadMedida.Location = new System.Drawing.Point(10, 180);
            this.ComboUnidadMedida.Name = "ComboUnidadMedida";
            this.ComboUnidadMedida.Size = new System.Drawing.Size(173, 21);
            this.ComboUnidadMedida.TabIndex = 88;
            // 
            // BtnSubir
            // 
            this.BtnSubir.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnSubir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSubir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubir.ForeColor = System.Drawing.Color.White;
            this.BtnSubir.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.BtnSubir.IconColor = System.Drawing.Color.White;
            this.BtnSubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSubir.IconSize = 16;
            this.BtnSubir.Location = new System.Drawing.Point(220, 164);
            this.BtnSubir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSubir.Name = "BtnSubir";
            this.BtnSubir.Size = new System.Drawing.Size(109, 27);
            this.BtnSubir.TabIndex = 90;
            this.BtnSubir.Text = "Subir";
            this.BtnSubir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSubir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSubir.UseVisualStyleBackColor = false;
            this.BtnSubir.Click += new System.EventHandler(this.BtnSubir_Click);
            // 
            // Imagen
            // 
            this.Imagen.BackColor = System.Drawing.Color.White;
            this.Imagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Imagen.Location = new System.Drawing.Point(220, 59);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(109, 100);
            this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen.TabIndex = 89;
            this.Imagen.TabStop = false;
            // 
            // LblImagen
            // 
            this.LblImagen.AutoSize = true;
            this.LblImagen.BackColor = System.Drawing.Color.White;
            this.LblImagen.Location = new System.Drawing.Point(217, 42);
            this.LblImagen.Name = "LblImagen";
            this.LblImagen.Size = new System.Drawing.Size(45, 13);
            this.LblImagen.TabIndex = 91;
            this.LblImagen.Text = "Imagen:";
            // 
            // BtnUltimasCompras
            // 
            this.BtnUltimasCompras.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnUltimasCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUltimasCompras.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnUltimasCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUltimasCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUltimasCompras.ForeColor = System.Drawing.Color.White;
            this.BtnUltimasCompras.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.BtnUltimasCompras.IconColor = System.Drawing.Color.White;
            this.BtnUltimasCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnUltimasCompras.IconSize = 18;
            this.BtnUltimasCompras.Location = new System.Drawing.Point(201, 480);
            this.BtnUltimasCompras.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUltimasCompras.Name = "BtnUltimasCompras";
            this.BtnUltimasCompras.Size = new System.Drawing.Size(141, 26);
            this.BtnUltimasCompras.TabIndex = 92;
            this.BtnUltimasCompras.Text = "Últimas Compras";
            this.BtnUltimasCompras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUltimasCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUltimasCompras.UseVisualStyleBackColor = false;
            this.BtnUltimasCompras.Visible = false;
            this.BtnUltimasCompras.Click += new System.EventHandler(this.BtnUltimasCompras_Click);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.HeaderText = "";
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.ReadOnly = true;
            this.BtnSeleccionar.Width = 30;
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
            this.Codigo.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 150;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Visible = false;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 150;
            // 
            // Existencia
            // 
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.Name = "Existencia";
            this.Existencia.ReadOnly = true;
            // 
            // ExistenciaMinima
            // 
            this.ExistenciaMinima.HeaderText = "ExistenciaMinima";
            this.ExistenciaMinima.Name = "ExistenciaMinima";
            this.ExistenciaMinima.ReadOnly = true;
            this.ExistenciaMinima.Visible = false;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // UnidadMedida
            // 
            this.UnidadMedida.HeaderText = "Unidad de Medida";
            this.UnidadMedida.Name = "UnidadMedida";
            this.UnidadMedida.ReadOnly = true;
            this.UnidadMedida.Width = 150;
            // 
            // Estante
            // 
            this.Estante.HeaderText = "Estante";
            this.Estante.Name = "Estante";
            this.Estante.ReadOnly = true;
            this.Estante.Visible = false;
            // 
            // Fila
            // 
            this.Fila.HeaderText = "Fila";
            this.Fila.Name = "Fila";
            this.Fila.ReadOnly = true;
            this.Fila.Visible = false;
            // 
            // Columna
            // 
            this.Columna.HeaderText = "Columna";
            this.Columna.Name = "Columna";
            this.Columna.ReadOnly = true;
            this.Columna.Visible = false;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1370, 544);
            this.Controls.Add(this.BtnUltimasCompras);
            this.Controls.Add(this.LblImagen);
            this.Controls.Add(this.BtnSubir);
            this.Controls.Add(this.Imagen);
            this.Controls.Add(this.ComboUnidadMedida);
            this.Controls.Add(this.ComboCategoria);
            this.Controls.Add(this.groupBoxUbicacion);
            this.Controls.Add(this.TxtExistencia);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.ComboBusqueda);
            this.Controls.Add(this.LblBuscarPor);
            this.Controls.Add(this.LblListaProductos);
            this.Controls.Add(this.TxtIndex);
            this.Controls.Add(this.TxtIdProducto);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblDetalleProducto);
            this.Controls.Add(this.ChkActivo);
            this.Controls.Add(this.TxtExistenciaMinima);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtCosto);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.LblUnidadMedida);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.LblExistenciaMinima);
            this.Controls.Add(this.LblExistencia);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.LblCosto);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBoxUbicacion.ResumeLayout(false);
            this.groupBoxUbicacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIndex;
        private System.Windows.Forms.TextBox TxtIdProducto;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.Label LblDetalleProducto;
        private System.Windows.Forms.CheckBox ChkActivo;
        private System.Windows.Forms.TextBox TxtExistenciaMinima;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtCosto;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label LblUnidadMedida;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblExistenciaMinima;
        private System.Windows.Forms.Label LblExistencia;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblCosto;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.ComboBox ComboBusqueda;
        private System.Windows.Forms.Label LblBuscarPor;
        private System.Windows.Forms.Label LblListaProductos;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox TxtExistencia;
        private System.Windows.Forms.GroupBox groupBoxUbicacion;
        private System.Windows.Forms.TextBox TxtEstante;
        private System.Windows.Forms.Label LblEstante;
        private System.Windows.Forms.TextBox TxtColumna;
        private System.Windows.Forms.Label LblColumna;
        private System.Windows.Forms.TextBox TxtFila;
        private System.Windows.Forms.Label LblFila;
        private System.Windows.Forms.ComboBox ComboCategoria;
        private System.Windows.Forms.ComboBox ComboUnidadMedida;
        private FontAwesome.Sharp.IconButton BtnSubir;
        private System.Windows.Forms.PictureBox Imagen;
        private System.Windows.Forms.Label LblImagen;
        private FontAwesome.Sharp.IconButton BtnUltimasCompras;
        private System.Windows.Forms.DataGridViewButtonColumn BtnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExistenciaMinima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
    }
}
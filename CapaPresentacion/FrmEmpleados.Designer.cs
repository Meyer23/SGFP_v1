namespace CapaPresentacion
{
    partial class FrmEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.LblNombres = new System.Windows.Forms.Label();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.LblDocumento = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblFechaNac = new System.Windows.Forms.Label();
            this.LblTelefono1 = new System.Windows.Forms.Label();
            this.LblTelefono2 = new System.Windows.Forms.Label();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtTelefono1 = new System.Windows.Forms.TextBox();
            this.TxtTelefono2 = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.ChkActivo = new System.Windows.Forms.CheckBox();
            this.LblDetalleUsuario = new System.Windows.Forms.Label();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.BtnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LblListaEmpleados = new System.Windows.Forms.Label();
            this.TxtIdEmpleado = new System.Windows.Forms.TextBox();
            this.DtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.LblBuscarPor = new System.Windows.Forms.Label();
            this.ComboBusqueda = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 477);
            this.label1.TabIndex = 0;
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.BackColor = System.Drawing.Color.White;
            this.LblNombres.Location = new System.Drawing.Point(9, 64);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(52, 13);
            this.LblNombres.TabIndex = 1;
            this.LblNombres.Text = "Nombres:";
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.BackColor = System.Drawing.Color.White;
            this.LblApellidos.Location = new System.Drawing.Point(9, 104);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(52, 13);
            this.LblApellidos.TabIndex = 2;
            this.LblApellidos.Text = "Apellidos:";
            // 
            // LblDocumento
            // 
            this.LblDocumento.AutoSize = true;
            this.LblDocumento.BackColor = System.Drawing.Color.White;
            this.LblDocumento.Location = new System.Drawing.Point(9, 144);
            this.LblDocumento.Name = "LblDocumento";
            this.LblDocumento.Size = new System.Drawing.Size(65, 13);
            this.LblDocumento.TabIndex = 3;
            this.LblDocumento.Text = "Documento:";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.BackColor = System.Drawing.Color.White;
            this.LblDireccion.Location = new System.Drawing.Point(9, 184);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(55, 13);
            this.LblDireccion.TabIndex = 4;
            this.LblDireccion.Text = "Dirección:";
            // 
            // LblFechaNac
            // 
            this.LblFechaNac.AutoSize = true;
            this.LblFechaNac.BackColor = System.Drawing.Color.White;
            this.LblFechaNac.Location = new System.Drawing.Point(9, 223);
            this.LblFechaNac.Name = "LblFechaNac";
            this.LblFechaNac.Size = new System.Drawing.Size(96, 13);
            this.LblFechaNac.TabIndex = 5;
            this.LblFechaNac.Text = "Fecha Nacimiento:";
            // 
            // LblTelefono1
            // 
            this.LblTelefono1.AutoSize = true;
            this.LblTelefono1.BackColor = System.Drawing.Color.White;
            this.LblTelefono1.Location = new System.Drawing.Point(9, 263);
            this.LblTelefono1.Name = "LblTelefono1";
            this.LblTelefono1.Size = new System.Drawing.Size(61, 13);
            this.LblTelefono1.TabIndex = 6;
            this.LblTelefono1.Text = "Teléfono 1:";
            // 
            // LblTelefono2
            // 
            this.LblTelefono2.AutoSize = true;
            this.LblTelefono2.BackColor = System.Drawing.Color.White;
            this.LblTelefono2.Location = new System.Drawing.Point(9, 303);
            this.LblTelefono2.Name = "LblTelefono2";
            this.LblTelefono2.Size = new System.Drawing.Size(61, 13);
            this.LblTelefono2.TabIndex = 7;
            this.LblTelefono2.Text = "Teléfono 2:";
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.BackColor = System.Drawing.Color.White;
            this.LblCorreo.Location = new System.Drawing.Point(9, 343);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(41, 13);
            this.LblCorreo.TabIndex = 8;
            this.LblCorreo.Text = "Correo:";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(12, 81);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(173, 20);
            this.TxtNombres.TabIndex = 10;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(12, 121);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(173, 20);
            this.TxtApellidos.TabIndex = 11;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Location = new System.Drawing.Point(12, 161);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(173, 20);
            this.TxtDocumento.TabIndex = 12;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(12, 200);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(173, 20);
            this.TxtDireccion.TabIndex = 13;
            // 
            // TxtTelefono1
            // 
            this.TxtTelefono1.Location = new System.Drawing.Point(12, 280);
            this.TxtTelefono1.Name = "TxtTelefono1";
            this.TxtTelefono1.Size = new System.Drawing.Size(173, 20);
            this.TxtTelefono1.TabIndex = 15;
            // 
            // TxtTelefono2
            // 
            this.TxtTelefono2.Location = new System.Drawing.Point(12, 320);
            this.TxtTelefono2.Name = "TxtTelefono2";
            this.TxtTelefono2.Size = new System.Drawing.Size(173, 20);
            this.TxtTelefono2.TabIndex = 16;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(12, 360);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(173, 20);
            this.TxtCorreo.TabIndex = 17;
            // 
            // ChkActivo
            // 
            this.ChkActivo.AutoSize = true;
            this.ChkActivo.BackColor = System.Drawing.Color.White;
            this.ChkActivo.Checked = true;
            this.ChkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkActivo.Location = new System.Drawing.Point(12, 386);
            this.ChkActivo.Name = "ChkActivo";
            this.ChkActivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkActivo.Size = new System.Drawing.Size(56, 17);
            this.ChkActivo.TabIndex = 18;
            this.ChkActivo.Text = "Activo";
            this.ChkActivo.UseVisualStyleBackColor = false;
            // 
            // LblDetalleUsuario
            // 
            this.LblDetalleUsuario.AutoSize = true;
            this.LblDetalleUsuario.BackColor = System.Drawing.Color.White;
            this.LblDetalleUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDetalleUsuario.Location = new System.Drawing.Point(11, 20);
            this.LblDetalleUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDetalleUsuario.Name = "LblDetalleUsuario";
            this.LblDetalleUsuario.Size = new System.Drawing.Size(135, 20);
            this.LblDetalleUsuario.TabIndex = 19;
            this.LblDetalleUsuario.Text = "Detalle Empleado";
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
            this.BtnGuardar.Location = new System.Drawing.Point(12, 408);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(173, 27);
            this.BtnGuardar.TabIndex = 20;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.BtnEditar.IconColor = System.Drawing.Color.White;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditar.IconSize = 16;
            this.BtnEditar.Location = new System.Drawing.Point(12, 440);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(173, 26);
            this.BtnEditar.TabIndex = 21;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnSeleccionar,
            this.idEmpleado,
            this.Nombres,
            this.Apellidos,
            this.Documento,
            this.Direccion,
            this.Activo});
            this.dgvData.Location = new System.Drawing.Point(218, 60);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(759, 384);
            this.dgvData.TabIndex = 22;
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.HeaderText = "";
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.ReadOnly = true;
            this.BtnSeleccionar.Width = 30;
            // 
            // idEmpleado
            // 
            this.idEmpleado.HeaderText = "idEmpleado";
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
            this.idEmpleado.Visible = false;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 150;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 150;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 150;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // LblListaEmpleados
            // 
            this.LblListaEmpleados.BackColor = System.Drawing.Color.White;
            this.LblListaEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblListaEmpleados.Location = new System.Drawing.Point(217, 20);
            this.LblListaEmpleados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblListaEmpleados.Name = "LblListaEmpleados";
            this.LblListaEmpleados.Size = new System.Drawing.Size(760, 40);
            this.LblListaEmpleados.TabIndex = 23;
            this.LblListaEmpleados.Text = "Lista de Empleados";
            this.LblListaEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtIdEmpleado
            // 
            this.TxtIdEmpleado.Location = new System.Drawing.Point(159, 55);
            this.TxtIdEmpleado.Name = "TxtIdEmpleado";
            this.TxtIdEmpleado.Size = new System.Drawing.Size(26, 20);
            this.TxtIdEmpleado.TabIndex = 24;
            this.TxtIdEmpleado.Text = "0";
            // 
            // DtFechaNac
            // 
            this.DtFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFechaNac.Location = new System.Drawing.Point(12, 240);
            this.DtFechaNac.Name = "DtFechaNac";
            this.DtFechaNac.Size = new System.Drawing.Size(173, 20);
            this.DtFechaNac.TabIndex = 25;
            this.DtFechaNac.Value = new System.DateTime(2023, 8, 26, 17, 41, 32, 0);
            // 
            // LblBuscarPor
            // 
            this.LblBuscarPor.AutoSize = true;
            this.LblBuscarPor.BackColor = System.Drawing.Color.White;
            this.LblBuscarPor.Location = new System.Drawing.Point(496, 37);
            this.LblBuscarPor.Name = "LblBuscarPor";
            this.LblBuscarPor.Size = new System.Drawing.Size(61, 13);
            this.LblBuscarPor.TabIndex = 26;
            this.LblBuscarPor.Text = "Buscar por:";
            // 
            // ComboBusqueda
            // 
            this.ComboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBusqueda.FormattingEnabled = true;
            this.ComboBusqueda.Location = new System.Drawing.Point(563, 34);
            this.ComboBusqueda.Name = "ComboBusqueda";
            this.ComboBusqueda.Size = new System.Drawing.Size(121, 21);
            this.ComboBusqueda.TabIndex = 27;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(690, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 28;
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
            this.BtnLimpiar.Location = new System.Drawing.Point(897, 30);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(43, 26);
            this.BtnLimpiar.TabIndex = 30;
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
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
            this.BtnBuscar.Location = new System.Drawing.Point(850, 30);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(43, 26);
            this.BtnBuscar.TabIndex = 29;
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 477);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ComboBusqueda);
            this.Controls.Add(this.LblBuscarPor);
            this.Controls.Add(this.DtFechaNac);
            this.Controls.Add(this.TxtIdEmpleado);
            this.Controls.Add(this.LblListaEmpleados);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblDetalleUsuario);
            this.Controls.Add(this.ChkActivo);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtTelefono2);
            this.Controls.Add(this.TxtTelefono1);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtDocumento);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.TxtNombres);
            this.Controls.Add(this.LblCorreo);
            this.Controls.Add(this.LblTelefono2);
            this.Controls.Add(this.LblTelefono1);
            this.Controls.Add(this.LblFechaNac);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.LblDocumento);
            this.Controls.Add(this.LblApellidos);
            this.Controls.Add(this.LblNombres);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmEmpleados";
            this.Text = "FrmEmpleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.Label LblDocumento;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblFechaNac;
        private System.Windows.Forms.Label LblTelefono1;
        private System.Windows.Forms.Label LblTelefono2;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtTelefono1;
        private System.Windows.Forms.TextBox TxtTelefono2;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.CheckBox ChkActivo;
        private System.Windows.Forms.Label LblDetalleUsuario;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label LblListaEmpleados;
        private System.Windows.Forms.TextBox TxtIdEmpleado;
        private System.Windows.Forms.DataGridViewButtonColumn BtnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
        private System.Windows.Forms.DateTimePicker DtFechaNac;
        private System.Windows.Forms.Label LblBuscarPor;
        private System.Windows.Forms.ComboBox ComboBusqueda;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
    }
}
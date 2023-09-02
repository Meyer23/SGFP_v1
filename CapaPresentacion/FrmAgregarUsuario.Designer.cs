namespace CapaPresentacion
{
    partial class FrmAgregarUsuario
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
            this.LblUsuariosAgregar = new System.Windows.Forms.Label();
            this.TxtIndex = new System.Windows.Forms.TextBox();
            this.TxtIdEmpleado = new System.Windows.Forms.TextBox();
            this.ChkActivo = new System.Windows.Forms.CheckBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblAddUsuario = new System.Windows.Forms.Label();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.LblListaEmpleados = new System.Windows.Forms.Label();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.ComboBusqueda = new System.Windows.Forms.ComboBox();
            this.LblBuscarPor = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.LoginLbL = new System.Windows.Forms.Label();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.LblRePassword = new System.Windows.Forms.Label();
            this.TxtRePassword = new System.Windows.Forms.TextBox();
            this.LblRol = new System.Windows.Forms.Label();
            this.ComboRol = new System.Windows.Forms.ComboBox();
            this.LblSucursal = new System.Windows.Forms.Label();
            this.ComboSucursal = new System.Windows.Forms.ComboBox();
            this.LblCaja = new System.Windows.Forms.Label();
            this.ComboCaja = new System.Windows.Forms.ComboBox();
            this.BtnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUsuariosAgregar
            // 
            this.LblUsuariosAgregar.BackColor = System.Drawing.Color.White;
            this.LblUsuariosAgregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblUsuariosAgregar.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblUsuariosAgregar.Location = new System.Drawing.Point(0, 0);
            this.LblUsuariosAgregar.Name = "LblUsuariosAgregar";
            this.LblUsuariosAgregar.Size = new System.Drawing.Size(288, 775);
            this.LblUsuariosAgregar.TabIndex = 2;
            // 
            // TxtIndex
            // 
            this.TxtIndex.Location = new System.Drawing.Point(202, 13);
            this.TxtIndex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtIndex.Name = "TxtIndex";
            this.TxtIndex.Size = new System.Drawing.Size(37, 26);
            this.TxtIndex.TabIndex = 40;
            this.TxtIndex.Text = "-1";
            this.TxtIndex.Visible = false;
            // 
            // TxtIdEmpleado
            // 
            this.TxtIdEmpleado.Location = new System.Drawing.Point(245, 14);
            this.TxtIdEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtIdEmpleado.Name = "TxtIdEmpleado";
            this.TxtIdEmpleado.Size = new System.Drawing.Size(37, 26);
            this.TxtIdEmpleado.TabIndex = 39;
            this.TxtIdEmpleado.Text = "0";
            this.TxtIdEmpleado.Visible = false;
            // 
            // ChkActivo
            // 
            this.ChkActivo.AutoSize = true;
            this.ChkActivo.BackColor = System.Drawing.Color.White;
            this.ChkActivo.Location = new System.Drawing.Point(12, 481);
            this.ChkActivo.Name = "ChkActivo";
            this.ChkActivo.Size = new System.Drawing.Size(78, 24);
            this.ChkActivo.TabIndex = 37;
            this.ChkActivo.Text = "Activo";
            this.ChkActivo.UseVisualStyleBackColor = false;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(12, 147);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(248, 26);
            this.TxtPassword.TabIndex = 36;
            this.TxtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPassword_Validating);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.White;
            this.LblPassword.Location = new System.Drawing.Point(13, 124);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(92, 20);
            this.LblPassword.TabIndex = 35;
            this.LblPassword.Text = "Contraseña";
            // 
            // LblAddUsuario
            // 
            this.LblAddUsuario.AutoSize = true;
            this.LblAddUsuario.BackColor = System.Drawing.Color.White;
            this.LblAddUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddUsuario.Location = new System.Drawing.Point(7, 9);
            this.LblAddUsuario.Name = "LblAddUsuario";
            this.LblAddUsuario.Size = new System.Drawing.Size(188, 29);
            this.LblAddUsuario.TabIndex = 34;
            this.LblAddUsuario.Text = "Agregar Usuario";
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
            this.BtnEditar.Location = new System.Drawing.Point(12, 621);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(260, 40);
            this.BtnEditar.TabIndex = 41;
            this.BtnEditar.Text = "Limpiar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BtnGuardar.IconColor = System.Drawing.Color.White;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.IconSize = 16;
            this.BtnGuardar.Location = new System.Drawing.Point(12, 531);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(260, 42);
            this.BtnGuardar.TabIndex = 38;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LblListaEmpleados
            // 
            this.LblListaEmpleados.BackColor = System.Drawing.Color.White;
            this.LblListaEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblListaEmpleados.Location = new System.Drawing.Point(289, 13);
            this.LblListaEmpleados.Name = "LblListaEmpleados";
            this.LblListaEmpleados.Padding = new System.Windows.Forms.Padding(3);
            this.LblListaEmpleados.Size = new System.Drawing.Size(1078, 62);
            this.LblListaEmpleados.TabIndex = 42;
            this.LblListaEmpleados.Text = "Lista de Empleados";
            this.LblListaEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.BtnLimpiar.Location = new System.Drawing.Point(1280, 20);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(64, 40);
            this.BtnLimpiar.TabIndex = 47;
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
            this.BtnBuscar.Location = new System.Drawing.Point(1197, 20);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(64, 40);
            this.BtnBuscar.TabIndex = 46;
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(947, 26);
            this.TxtBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(230, 26);
            this.TxtBusqueda.TabIndex = 43;
            // 
            // ComboBusqueda
            // 
            this.ComboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBusqueda.FormattingEnabled = true;
            this.ComboBusqueda.Location = new System.Drawing.Point(736, 27);
            this.ComboBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBusqueda.Name = "ComboBusqueda";
            this.ComboBusqueda.Size = new System.Drawing.Size(180, 28);
            this.ComboBusqueda.TabIndex = 45;
            // 
            // LblBuscarPor
            // 
            this.LblBuscarPor.AutoSize = true;
            this.LblBuscarPor.BackColor = System.Drawing.Color.White;
            this.LblBuscarPor.Location = new System.Drawing.Point(574, 26);
            this.LblBuscarPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBuscarPor.Name = "LblBuscarPor";
            this.LblBuscarPor.Size = new System.Drawing.Size(90, 20);
            this.LblBuscarPor.TabIndex = 44;
            this.LblBuscarPor.Text = "Buscar por:";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
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
            this.idEmpleado,
            this.Nombres,
            this.Apellidos,
            this.Documento,
            this.Correo,
            this.Activo});
            this.dgvData.Location = new System.Drawing.Point(295, 80);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.dgvData.RowHeadersWidth = 62;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(845, 660);
            this.dgvData.TabIndex = 48;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting);
            // 
            // LoginLbL
            // 
            this.LoginLbL.AutoSize = true;
            this.LoginLbL.BackColor = System.Drawing.Color.White;
            this.LoginLbL.Location = new System.Drawing.Point(8, 55);
            this.LoginLbL.Name = "LoginLbL";
            this.LoginLbL.Size = new System.Drawing.Size(52, 20);
            this.LoginLbL.TabIndex = 49;
            this.LoginLbL.Text = "Login:";
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(12, 78);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(248, 26);
            this.TxtLogin.TabIndex = 50;
            // 
            // LblRePassword
            // 
            this.LblRePassword.AutoSize = true;
            this.LblRePassword.BackColor = System.Drawing.Color.White;
            this.LblRePassword.Location = new System.Drawing.Point(12, 187);
            this.LblRePassword.Name = "LblRePassword";
            this.LblRePassword.Size = new System.Drawing.Size(169, 20);
            this.LblRePassword.TabIndex = 51;
            this.LblRePassword.Text = "Confirmar Contraseña:";
            // 
            // TxtRePassword
            // 
            this.TxtRePassword.Location = new System.Drawing.Point(12, 210);
            this.TxtRePassword.Name = "TxtRePassword";
            this.TxtRePassword.Size = new System.Drawing.Size(248, 26);
            this.TxtRePassword.TabIndex = 52;
            this.TxtRePassword.Validating += new System.ComponentModel.CancelEventHandler(this.TxtRePassword_Validating);
            // 
            // LblRol
            // 
            this.LblRol.AutoSize = true;
            this.LblRol.BackColor = System.Drawing.Color.White;
            this.LblRol.Location = new System.Drawing.Point(12, 252);
            this.LblRol.Name = "LblRol";
            this.LblRol.Size = new System.Drawing.Size(37, 20);
            this.LblRol.TabIndex = 53;
            this.LblRol.Text = "Rol:";
            // 
            // ComboRol
            // 
            this.ComboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboRol.FormattingEnabled = true;
            this.ComboRol.Location = new System.Drawing.Point(12, 277);
            this.ComboRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboRol.Name = "ComboRol";
            this.ComboRol.Size = new System.Drawing.Size(180, 28);
            this.ComboRol.TabIndex = 54;
            // 
            // LblSucursal
            // 
            this.LblSucursal.AutoSize = true;
            this.LblSucursal.BackColor = System.Drawing.Color.White;
            this.LblSucursal.Location = new System.Drawing.Point(12, 331);
            this.LblSucursal.Name = "LblSucursal";
            this.LblSucursal.Size = new System.Drawing.Size(75, 20);
            this.LblSucursal.TabIndex = 55;
            this.LblSucursal.Text = "Sucursal:";
            // 
            // ComboSucursal
            // 
            this.ComboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboSucursal.FormattingEnabled = true;
            this.ComboSucursal.Location = new System.Drawing.Point(12, 356);
            this.ComboSucursal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboSucursal.Name = "ComboSucursal";
            this.ComboSucursal.Size = new System.Drawing.Size(180, 28);
            this.ComboSucursal.TabIndex = 56;
            // 
            // LblCaja
            // 
            this.LblCaja.AutoSize = true;
            this.LblCaja.BackColor = System.Drawing.Color.White;
            this.LblCaja.Location = new System.Drawing.Point(12, 410);
            this.LblCaja.Name = "LblCaja";
            this.LblCaja.Size = new System.Drawing.Size(45, 20);
            this.LblCaja.TabIndex = 57;
            this.LblCaja.Text = "Caja:";
            // 
            // ComboCaja
            // 
            this.ComboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCaja.FormattingEnabled = true;
            this.ComboCaja.Location = new System.Drawing.Point(15, 435);
            this.ComboCaja.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboCaja.Name = "ComboCaja";
            this.ComboCaja.Size = new System.Drawing.Size(180, 28);
            this.ComboCaja.TabIndex = 58;
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.HeaderText = "";
            this.BtnSeleccionar.MinimumWidth = 8;
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.ReadOnly = true;
            this.BtnSeleccionar.Width = 30;
            // 
            // idEmpleado
            // 
            this.idEmpleado.HeaderText = "idEmpleado";
            this.idEmpleado.MinimumWidth = 8;
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
            this.idEmpleado.Visible = false;
            this.idEmpleado.Width = 150;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.MinimumWidth = 8;
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 150;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.MinimumWidth = 8;
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 150;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.MinimumWidth = 8;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 150;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 8;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 150;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.MinimumWidth = 8;
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Activo.Width = 150;
            // 
            // FrmAgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 775);
            this.Controls.Add(this.ComboCaja);
            this.Controls.Add(this.LblCaja);
            this.Controls.Add(this.ComboSucursal);
            this.Controls.Add(this.LblSucursal);
            this.Controls.Add(this.ComboRol);
            this.Controls.Add(this.LblRol);
            this.Controls.Add(this.TxtRePassword);
            this.Controls.Add(this.LblRePassword);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.LoginLbL);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.ComboBusqueda);
            this.Controls.Add(this.LblBuscarPor);
            this.Controls.Add(this.LblListaEmpleados);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.TxtIndex);
            this.Controls.Add(this.TxtIdEmpleado);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.ChkActivo);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblAddUsuario);
            this.Controls.Add(this.LblUsuariosAgregar);
            this.Name = "FrmAgregarUsuario";
            this.Text = "Agregar Usuario";
            this.Load += new System.EventHandler(this.FrmAgregarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUsuariosAgregar;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private System.Windows.Forms.TextBox TxtIndex;
        private System.Windows.Forms.TextBox TxtIdEmpleado;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.CheckBox ChkActivo;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblAddUsuario;
        private System.Windows.Forms.Label LblListaEmpleados;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.ComboBox ComboBusqueda;
        private System.Windows.Forms.Label LblBuscarPor;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label LoginLbL;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.Label LblRePassword;
        private System.Windows.Forms.TextBox TxtRePassword;
        private System.Windows.Forms.Label LblRol;
        private System.Windows.Forms.ComboBox ComboRol;
        private System.Windows.Forms.Label LblSucursal;
        private System.Windows.Forms.ComboBox ComboSucursal;
        private System.Windows.Forms.Label LblCaja;
        private System.Windows.Forms.ComboBox ComboCaja;
        private System.Windows.Forms.DataGridViewButtonColumn BtnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
    }
}
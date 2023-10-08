namespace CapaPresentacion
{
    partial class FrmCajas
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
            this.LblCajasNav = new System.Windows.Forms.Label();
            this.LblBusquedaCajas = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.BtnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LblNroCaja = new System.Windows.Forms.Label();
            this.ChkActivo = new System.Windows.Forms.CheckBox();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.ComboSucursal = new System.Windows.Forms.ComboBox();
            this.LblSucursal = new System.Windows.Forms.Label();
            this.LblUsuarioCaja = new System.Windows.Forms.Label();
            this.ComboUsuario = new System.Windows.Forms.ComboBox();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.ComboBusqueda = new System.Windows.Forms.ComboBox();
            this.LblBuscarPor = new System.Windows.Forms.Label();
            this.ComboCajas = new System.Windows.Forms.ComboBox();
            this.TxtIndex = new System.Windows.Forms.TextBox();
            this.TxtIdCaja = new System.Windows.Forms.TextBox();
            this.LblAsignarCaja = new System.Windows.Forms.Label();
            this.BtnCrearCaja = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCajasNav
            // 
            this.LblCajasNav.BackColor = System.Drawing.Color.White;
            this.LblCajasNav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCajasNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblCajasNav.Location = new System.Drawing.Point(0, 0);
            this.LblCajasNav.Name = "LblCajasNav";
            this.LblCajasNav.Size = new System.Drawing.Size(298, 560);
            this.LblCajasNav.TabIndex = 1;
            // 
            // LblBusquedaCajas
            // 
            this.LblBusquedaCajas.BackColor = System.Drawing.Color.White;
            this.LblBusquedaCajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBusquedaCajas.Location = new System.Drawing.Point(298, 0);
            this.LblBusquedaCajas.Name = "LblBusquedaCajas";
            this.LblBusquedaCajas.Size = new System.Drawing.Size(1000, 82);
            this.LblBusquedaCajas.TabIndex = 20;
            this.LblBusquedaCajas.Text = "Lista de Cajas";
            this.LblBusquedaCajas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.idCaja,
            this.Usuario,
            this.NumeroCaja,
            this.Sucursal,
            this.Activo});
            this.dgvData.Location = new System.Drawing.Point(321, 85);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 62;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(994, 455);
            this.dgvData.TabIndex = 21;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.HeaderText = "";
            this.BtnSeleccionar.MinimumWidth = 8;
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.ReadOnly = true;
            this.BtnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BtnSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BtnSeleccionar.Width = 150;
            // 
            // idCaja
            // 
            this.idCaja.HeaderText = "idCaja";
            this.idCaja.MinimumWidth = 8;
            this.idCaja.Name = "idCaja";
            this.idCaja.ReadOnly = true;
            this.idCaja.Visible = false;
            this.idCaja.Width = 50;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MinimumWidth = 8;
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 150;
            // 
            // NumeroCaja
            // 
            this.NumeroCaja.HeaderText = "Nro. Caja";
            this.NumeroCaja.MinimumWidth = 8;
            this.NumeroCaja.Name = "NumeroCaja";
            this.NumeroCaja.ReadOnly = true;
            this.NumeroCaja.Width = 150;
            // 
            // Sucursal
            // 
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.MinimumWidth = 8;
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.ReadOnly = true;
            this.Sucursal.Width = 150;
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
            // LblNroCaja
            // 
            this.LblNroCaja.AutoSize = true;
            this.LblNroCaja.BackColor = System.Drawing.Color.White;
            this.LblNroCaja.Location = new System.Drawing.Point(12, 61);
            this.LblNroCaja.Name = "LblNroCaja";
            this.LblNroCaja.Size = new System.Drawing.Size(78, 20);
            this.LblNroCaja.TabIndex = 45;
            this.LblNroCaja.Text = "Nro. Caja:";
            // 
            // ChkActivo
            // 
            this.ChkActivo.AutoSize = true;
            this.ChkActivo.BackColor = System.Drawing.Color.White;
            this.ChkActivo.Location = new System.Drawing.Point(16, 317);
            this.ChkActivo.Name = "ChkActivo";
            this.ChkActivo.Size = new System.Drawing.Size(78, 24);
            this.ChkActivo.TabIndex = 53;
            this.ChkActivo.Text = "Activo";
            this.ChkActivo.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.BtnEditar.IconColor = System.Drawing.Color.White;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditar.IconSize = 16;
            this.BtnEditar.Location = new System.Drawing.Point(12, 431);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(260, 40);
            this.BtnEditar.TabIndex = 52;
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
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BtnGuardar.IconColor = System.Drawing.Color.White;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.IconSize = 16;
            this.BtnGuardar.Location = new System.Drawing.Point(12, 367);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(260, 42);
            this.BtnGuardar.TabIndex = 51;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // ComboSucursal
            // 
            this.ComboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboSucursal.Enabled = false;
            this.ComboSucursal.FormattingEnabled = true;
            this.ComboSucursal.Location = new System.Drawing.Point(12, 171);
            this.ComboSucursal.Name = "ComboSucursal";
            this.ComboSucursal.Size = new System.Drawing.Size(248, 28);
            this.ComboSucursal.TabIndex = 55;
            // 
            // LblSucursal
            // 
            this.LblSucursal.AutoSize = true;
            this.LblSucursal.BackColor = System.Drawing.Color.White;
            this.LblSucursal.ForeColor = System.Drawing.Color.Black;
            this.LblSucursal.Location = new System.Drawing.Point(15, 139);
            this.LblSucursal.Name = "LblSucursal";
            this.LblSucursal.Size = new System.Drawing.Size(75, 20);
            this.LblSucursal.TabIndex = 54;
            this.LblSucursal.Text = "Sucursal:";
            // 
            // LblUsuarioCaja
            // 
            this.LblUsuarioCaja.AutoSize = true;
            this.LblUsuarioCaja.BackColor = System.Drawing.Color.White;
            this.LblUsuarioCaja.ForeColor = System.Drawing.Color.Black;
            this.LblUsuarioCaja.Location = new System.Drawing.Point(15, 218);
            this.LblUsuarioCaja.Name = "LblUsuarioCaja";
            this.LblUsuarioCaja.Size = new System.Drawing.Size(68, 20);
            this.LblUsuarioCaja.TabIndex = 56;
            this.LblUsuarioCaja.Text = "Usuario:";
            // 
            // ComboUsuario
            // 
            this.ComboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboUsuario.Enabled = false;
            this.ComboUsuario.FormattingEnabled = true;
            this.ComboUsuario.Location = new System.Drawing.Point(16, 257);
            this.ComboUsuario.Name = "ComboUsuario";
            this.ComboUsuario.Size = new System.Drawing.Size(248, 28);
            this.ComboUsuario.TabIndex = 57;
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
            this.BtnLimpiar.Location = new System.Drawing.Point(1225, 21);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(64, 40);
            this.BtnLimpiar.TabIndex = 62;
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
            this.BtnBuscar.Location = new System.Drawing.Point(1143, 21);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(64, 40);
            this.BtnBuscar.TabIndex = 61;
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(887, 35);
            this.TxtBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(230, 26);
            this.TxtBusqueda.TabIndex = 58;
            // 
            // ComboBusqueda
            // 
            this.ComboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBusqueda.FormattingEnabled = true;
            this.ComboBusqueda.Location = new System.Drawing.Point(637, 33);
            this.ComboBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBusqueda.Name = "ComboBusqueda";
            this.ComboBusqueda.Size = new System.Drawing.Size(180, 28);
            this.ComboBusqueda.TabIndex = 60;
            // 
            // LblBuscarPor
            // 
            this.LblBuscarPor.AutoSize = true;
            this.LblBuscarPor.BackColor = System.Drawing.Color.White;
            this.LblBuscarPor.Location = new System.Drawing.Point(506, 35);
            this.LblBuscarPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBuscarPor.Name = "LblBuscarPor";
            this.LblBuscarPor.Size = new System.Drawing.Size(90, 20);
            this.LblBuscarPor.TabIndex = 59;
            this.LblBuscarPor.Text = "Buscar por:";
            // 
            // ComboCajas
            // 
            this.ComboCajas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCajas.FormattingEnabled = true;
            this.ComboCajas.Location = new System.Drawing.Point(16, 84);
            this.ComboCajas.Name = "ComboCajas";
            this.ComboCajas.Size = new System.Drawing.Size(248, 28);
            this.ComboCajas.TabIndex = 63;
            // 
            // TxtIndex
            // 
            this.TxtIndex.Location = new System.Drawing.Point(190, 21);
            this.TxtIndex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtIndex.Name = "TxtIndex";
            this.TxtIndex.Size = new System.Drawing.Size(37, 26);
            this.TxtIndex.TabIndex = 65;
            this.TxtIndex.Text = "-1";
            this.TxtIndex.Visible = false;
            // 
            // TxtIdCaja
            // 
            this.TxtIdCaja.Location = new System.Drawing.Point(234, 18);
            this.TxtIdCaja.Name = "TxtIdCaja";
            this.TxtIdCaja.Size = new System.Drawing.Size(48, 26);
            this.TxtIdCaja.TabIndex = 64;
            this.TxtIdCaja.Visible = false;
            // 
            // LblAsignarCaja
            // 
            this.LblAsignarCaja.AutoSize = true;
            this.LblAsignarCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAsignarCaja.Location = new System.Drawing.Point(7, 9);
            this.LblAsignarCaja.Name = "LblAsignarCaja";
            this.LblAsignarCaja.Size = new System.Drawing.Size(213, 25);
            this.LblAsignarCaja.TabIndex = 66;
            this.LblAsignarCaja.Text = "Asignar Caja a Usuario";
            this.LblAsignarCaja.Click += new System.EventHandler(this.LblAsignarCaja_Click);
            // 
            // BtnCrearCaja
            // 
            this.BtnCrearCaja.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnCrearCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCrearCaja.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCrearCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearCaja.ForeColor = System.Drawing.Color.White;
            this.BtnCrearCaja.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.BtnCrearCaja.IconColor = System.Drawing.Color.White;
            this.BtnCrearCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCrearCaja.IconSize = 16;
            this.BtnCrearCaja.Location = new System.Drawing.Point(16, 498);
            this.BtnCrearCaja.Name = "BtnCrearCaja";
            this.BtnCrearCaja.Size = new System.Drawing.Size(260, 42);
            this.BtnCrearCaja.TabIndex = 67;
            this.BtnCrearCaja.Text = "Crear una nueva Caja";
            this.BtnCrearCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCrearCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCrearCaja.UseVisualStyleBackColor = false;
            this.BtnCrearCaja.Click += new System.EventHandler(this.BtnCrearCaja_Click);
            // 
            // FrmCajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 560);
            this.Controls.Add(this.BtnCrearCaja);
            this.Controls.Add(this.LblAsignarCaja);
            this.Controls.Add(this.TxtIndex);
            this.Controls.Add(this.TxtIdCaja);
            this.Controls.Add(this.ComboCajas);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.ComboBusqueda);
            this.Controls.Add(this.LblBuscarPor);
            this.Controls.Add(this.ComboUsuario);
            this.Controls.Add(this.LblUsuarioCaja);
            this.Controls.Add(this.ComboSucursal);
            this.Controls.Add(this.LblSucursal);
            this.Controls.Add(this.ChkActivo);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblNroCaja);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.LblBusquedaCajas);
            this.Controls.Add(this.LblCajasNav);
            this.Name = "FrmCajas";
            this.Text = "Cajas";
            this.Load += new System.EventHandler(this.FrmCajas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCajasNav;
        private System.Windows.Forms.Label LblBusquedaCajas;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label LblNroCaja;
        private System.Windows.Forms.CheckBox ChkActivo;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.ComboBox ComboSucursal;
        private System.Windows.Forms.Label LblSucursal;
        private System.Windows.Forms.Label LblUsuarioCaja;
        private System.Windows.Forms.ComboBox ComboUsuario;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.ComboBox ComboBusqueda;
        private System.Windows.Forms.Label LblBuscarPor;
        private System.Windows.Forms.ComboBox ComboCajas;
        private System.Windows.Forms.TextBox TxtIndex;
        private System.Windows.Forms.TextBox TxtIdCaja;
        private System.Windows.Forms.Label LblAsignarCaja;
        private System.Windows.Forms.DataGridViewButtonColumn BtnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
        private FontAwesome.Sharp.IconButton BtnCrearCaja;
    }
}
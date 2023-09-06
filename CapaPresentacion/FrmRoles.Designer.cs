namespace CapaPresentacion
{
    partial class FrmRoles
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
            this.LblRoles = new System.Windows.Forms.Label();
            this.ListaLabelRoles = new System.Windows.Forms.Label();
            this.dgvRolesData = new System.Windows.Forms.DataGridView();
            this.BtnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LblDetalleRol = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.ChkActivo = new System.Windows.Forms.CheckBox();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.TxtIdRol = new System.Windows.Forms.TextBox();
            this.TxtIndex = new System.Windows.Forms.TextBox();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.dgvModulosData = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdModulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visualiza = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Incluye = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Modifica = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulosData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRoles
            // 
            this.LblRoles.BackColor = System.Drawing.Color.White;
            this.LblRoles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblRoles.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblRoles.Location = new System.Drawing.Point(0, 0);
            this.LblRoles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRoles.Name = "LblRoles";
            this.LblRoles.Size = new System.Drawing.Size(534, 502);
            this.LblRoles.TabIndex = 1;
            // 
            // ListaLabelRoles
            // 
            this.ListaLabelRoles.BackColor = System.Drawing.Color.White;
            this.ListaLabelRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaLabelRoles.Location = new System.Drawing.Point(565, 9);
            this.ListaLabelRoles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ListaLabelRoles.Name = "ListaLabelRoles";
            this.ListaLabelRoles.Size = new System.Drawing.Size(419, 40);
            this.ListaLabelRoles.TabIndex = 20;
            this.ListaLabelRoles.Text = "Roles";
            this.ListaLabelRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvRolesData
            // 
            this.dgvRolesData.AllowUserToAddRows = false;
            this.dgvRolesData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRolesData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRolesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRolesData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnSeleccionar,
            this.idRol,
            this.Descripcion,
            this.Activo});
            this.dgvRolesData.Location = new System.Drawing.Point(565, 62);
            this.dgvRolesData.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRolesData.MultiSelect = false;
            this.dgvRolesData.Name = "dgvRolesData";
            this.dgvRolesData.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRolesData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRolesData.RowHeadersWidth = 62;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRolesData.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRolesData.RowTemplate.Height = 28;
            this.dgvRolesData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRolesData.Size = new System.Drawing.Size(419, 161);
            this.dgvRolesData.TabIndex = 21;
            this.dgvRolesData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRolesData_CellContentClick);
            this.dgvRolesData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvRolesData_CellPainting);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.HeaderText = "";
            this.BtnSeleccionar.MinimumWidth = 8;
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.ReadOnly = true;
            this.BtnSeleccionar.Width = 30;
            // 
            // idRol
            // 
            this.idRol.HeaderText = "idRol";
            this.idRol.Name = "idRol";
            this.idRol.ReadOnly = true;
            this.idRol.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 250;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.MinimumWidth = 8;
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Activo.Width = 50;
            // 
            // LblDetalleRol
            // 
            this.LblDetalleRol.AutoSize = true;
            this.LblDetalleRol.BackColor = System.Drawing.Color.White;
            this.LblDetalleRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDetalleRol.Location = new System.Drawing.Point(11, 21);
            this.LblDetalleRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDetalleRol.Name = "LblDetalleRol";
            this.LblDetalleRol.Size = new System.Drawing.Size(87, 20);
            this.LblDetalleRol.TabIndex = 22;
            this.LblDetalleRol.Text = "Detalle Rol";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(15, 66);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(420, 20);
            this.TxtNombre.TabIndex = 24;
            this.TxtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombre_Validating);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(12, 51);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(47, 13);
            this.LblNombre.TabIndex = 23;
            this.LblNombre.Text = "Nombre:";
            // 
            // ChkActivo
            // 
            this.ChkActivo.AutoSize = true;
            this.ChkActivo.BackColor = System.Drawing.Color.White;
            this.ChkActivo.Location = new System.Drawing.Point(15, 90);
            this.ChkActivo.Margin = new System.Windows.Forms.Padding(2);
            this.ChkActivo.Name = "ChkActivo";
            this.ChkActivo.Size = new System.Drawing.Size(56, 17);
            this.ChkActivo.TabIndex = 25;
            this.ChkActivo.Text = "Activo";
            this.ChkActivo.UseVisualStyleBackColor = false;
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
            this.BtnGuardar.Location = new System.Drawing.Point(106, 468);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(173, 27);
            this.BtnGuardar.TabIndex = 26;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtIdRol
            // 
            this.TxtIdRol.Location = new System.Drawing.Point(156, 23);
            this.TxtIdRol.Name = "TxtIdRol";
            this.TxtIdRol.Size = new System.Drawing.Size(26, 20);
            this.TxtIdRol.TabIndex = 27;
            this.TxtIdRol.Text = "0";
            this.TxtIdRol.Visible = false;
            // 
            // TxtIndex
            // 
            this.TxtIndex.Location = new System.Drawing.Point(124, 23);
            this.TxtIndex.Name = "TxtIndex";
            this.TxtIndex.Size = new System.Drawing.Size(26, 20);
            this.TxtIndex.TabIndex = 32;
            this.TxtIndex.Text = "-1";
            this.TxtIndex.Visible = false;
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
            this.BtnEditar.Location = new System.Drawing.Point(297, 469);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(173, 26);
            this.BtnEditar.TabIndex = 33;
            this.BtnEditar.Text = "Limpiar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // dgvModulosData
            // 
            this.dgvModulosData.AllowUserToAddRows = false;
            this.dgvModulosData.AllowUserToDeleteRows = false;
            this.dgvModulosData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModulosData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Rol,
            this.IdModulo,
            this.Modulo,
            this.Visualiza,
            this.Incluye,
            this.Modifica});
            this.dgvModulosData.Location = new System.Drawing.Point(92, 112);
            this.dgvModulosData.Name = "dgvModulosData";
            this.dgvModulosData.Size = new System.Drawing.Size(423, 164);
            this.dgvModulosData.TabIndex = 34;
            // 
            // id
            // 
            this.id.HeaderText = "";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "";
            this.Rol.Name = "Rol";
            this.Rol.Visible = false;
            // 
            // IdModulo
            // 
            this.IdModulo.HeaderText = "";
            this.IdModulo.Name = "IdModulo";
            this.IdModulo.Visible = false;
            // 
            // Modulo
            // 
            this.Modulo.HeaderText = "Módulo";
            this.Modulo.Name = "Modulo";
            // 
            // Visualiza
            // 
            this.Visualiza.HeaderText = "Visualiza";
            this.Visualiza.Name = "Visualiza";
            // 
            // Incluye
            // 
            this.Incluye.HeaderText = "Incluye";
            this.Incluye.Name = "Incluye";
            // 
            // Modifica
            // 
            this.Modifica.HeaderText = "Modifica";
            this.Modifica.Name = "Modifica";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(92, 313);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(423, 142);
            this.dataGridView2.TabIndex = 35;
            // 
            // FrmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 502);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dgvModulosData);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.TxtIndex);
            this.Controls.Add(this.TxtIdRol);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.ChkActivo);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblDetalleRol);
            this.Controls.Add(this.dgvRolesData);
            this.Controls.Add(this.ListaLabelRoles);
            this.Controls.Add(this.LblRoles);
            this.Name = "FrmRoles";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.FrmRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulosData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRoles;
        private System.Windows.Forms.Label ListaLabelRoles;
        private System.Windows.Forms.DataGridView dgvRolesData;
        private System.Windows.Forms.Label LblDetalleRol;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.CheckBox ChkActivo;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.TextBox TxtIdRol;
        private System.Windows.Forms.TextBox TxtIndex;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private System.Windows.Forms.DataGridView dgvModulosData;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdModulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modulo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Visualiza;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Incluye;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Modifica;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewButtonColumn BtnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
    }
}
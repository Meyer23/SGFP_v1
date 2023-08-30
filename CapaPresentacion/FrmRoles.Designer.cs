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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblRoles = new System.Windows.Forms.Label();
            this.ListaLabelRoles = new System.Windows.Forms.Label();
            this.dgvRolesData = new System.Windows.Forms.DataGridView();
            this.LblDetalleRol = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.ChkActivo = new System.Windows.Forms.CheckBox();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.TxtIdRol = new System.Windows.Forms.TextBox();
            this.BtnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TxtIndex = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesData)).BeginInit();
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
            this.LblRoles.Size = new System.Drawing.Size(199, 306);
            this.LblRoles.TabIndex = 1;
            // 
            // ListaLabelRoles
            // 
            this.ListaLabelRoles.BackColor = System.Drawing.Color.White;
            this.ListaLabelRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaLabelRoles.Location = new System.Drawing.Point(203, 9);
            this.ListaLabelRoles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ListaLabelRoles.Name = "ListaLabelRoles";
            this.ListaLabelRoles.Size = new System.Drawing.Size(586, 40);
            this.ListaLabelRoles.TabIndex = 20;
            this.ListaLabelRoles.Text = "Roles";
            this.ListaLabelRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvRolesData
            // 
            this.dgvRolesData.AllowUserToAddRows = false;
            this.dgvRolesData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRolesData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRolesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRolesData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnSeleccionar,
            this.idRol,
            this.Descripcion,
            this.Activo});
            this.dgvRolesData.Location = new System.Drawing.Point(208, 62);
            this.dgvRolesData.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRolesData.MultiSelect = false;
            this.dgvRolesData.Name = "dgvRolesData";
            this.dgvRolesData.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRolesData.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRolesData.RowHeadersWidth = 62;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRolesData.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRolesData.RowTemplate.Height = 28;
            this.dgvRolesData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRolesData.Size = new System.Drawing.Size(368, 161);
            this.dgvRolesData.TabIndex = 21;
            this.dgvRolesData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRolesData_CellContentClick);
            this.dgvRolesData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvRolesData_CellPainting);
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
            this.TxtNombre.Location = new System.Drawing.Point(15, 83);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(167, 20);
            this.TxtNombre.TabIndex = 24;
            this.TxtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombre_Validating);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(12, 68);
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
            this.ChkActivo.Location = new System.Drawing.Point(15, 125);
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
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BtnGuardar.IconColor = System.Drawing.Color.White;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.IconSize = 16;
            this.BtnGuardar.Location = new System.Drawing.Point(9, 249);
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
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.HeaderText = "";
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.ReadOnly = true;
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
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // FrmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 306);
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
        private System.Windows.Forms.DataGridViewButtonColumn BtnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
        private System.Windows.Forms.TextBox TxtIndex;
    }
}
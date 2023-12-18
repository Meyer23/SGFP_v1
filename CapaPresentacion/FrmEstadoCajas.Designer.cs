namespace CapaPresentacion
{
    partial class FrmEstadoCajas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.LblListadoEstadoCajas = new System.Windows.Forms.Label();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.ComboBusqueda = new System.Windows.Forms.ComboBox();
            this.LblBuscarPor = new System.Windows.Forms.Label();
            this.BtnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idTimbrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnSeleccionar,
            this.idTimbrado,
            this.MontoInicial,
            this.MontoCierre,
            this.MontoActual,
            this.FechaApertura,
            this.FechaCierre,
            this.NroCaja,
            this.Activo});
            this.dgvData.Location = new System.Drawing.Point(15, 268);
            this.dgvData.Margin = new System.Windows.Forms.Padding(6);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvData.RowHeadersWidth = 72;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1271, 520);
            this.dgvData.TabIndex = 63;
            // 
            // LblListadoEstadoCajas
            // 
            this.LblListadoEstadoCajas.BackColor = System.Drawing.Color.White;
            this.LblListadoEstadoCajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblListadoEstadoCajas.Location = new System.Drawing.Point(15, 8);
            this.LblListadoEstadoCajas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblListadoEstadoCajas.Name = "LblListadoEstadoCajas";
            this.LblListadoEstadoCajas.Padding = new System.Windows.Forms.Padding(4);
            this.LblListadoEstadoCajas.Size = new System.Drawing.Size(1271, 156);
            this.LblListadoEstadoCajas.TabIndex = 62;
            this.LblListadoEstadoCajas.Text = "Estado de Cajas";
            this.LblListadoEstadoCajas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblListadoEstadoCajas.Click += new System.EventHandler(this.LblListadoEstadoCajas_Click);
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
            this.BtnBuscar.Location = new System.Drawing.Point(996, 72);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(79, 48);
            this.BtnBuscar.TabIndex = 67;
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(662, 91);
            this.TxtBusqueda.Margin = new System.Windows.Forms.Padding(6);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(281, 29);
            this.TxtBusqueda.TabIndex = 64;
            // 
            // ComboBusqueda
            // 
            this.ComboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBusqueda.FormattingEnabled = true;
            this.ComboBusqueda.Location = new System.Drawing.Point(385, 88);
            this.ComboBusqueda.Margin = new System.Windows.Forms.Padding(6);
            this.ComboBusqueda.Name = "ComboBusqueda";
            this.ComboBusqueda.Size = new System.Drawing.Size(218, 32);
            this.ComboBusqueda.TabIndex = 66;
            // 
            // LblBuscarPor
            // 
            this.LblBuscarPor.AutoSize = true;
            this.LblBuscarPor.BackColor = System.Drawing.Color.White;
            this.LblBuscarPor.Location = new System.Drawing.Point(380, 35);
            this.LblBuscarPor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblBuscarPor.Name = "LblBuscarPor";
            this.LblBuscarPor.Size = new System.Drawing.Size(112, 25);
            this.LblBuscarPor.TabIndex = 65;
            this.LblBuscarPor.Text = "Buscar por:";
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.HeaderText = "";
            this.BtnSeleccionar.MinimumWidth = 9;
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.ReadOnly = true;
            this.BtnSeleccionar.Width = 30;
            // 
            // idTimbrado
            // 
            this.idTimbrado.HeaderText = "idApertura";
            this.idTimbrado.MinimumWidth = 9;
            this.idTimbrado.Name = "idTimbrado";
            this.idTimbrado.ReadOnly = true;
            this.idTimbrado.Visible = false;
            this.idTimbrado.Width = 175;
            // 
            // MontoInicial
            // 
            this.MontoInicial.HeaderText = "Monto Inicial";
            this.MontoInicial.MinimumWidth = 9;
            this.MontoInicial.Name = "MontoInicial";
            this.MontoInicial.ReadOnly = true;
            this.MontoInicial.Width = 150;
            // 
            // MontoCierre
            // 
            this.MontoCierre.HeaderText = "Monto Cierre";
            this.MontoCierre.MinimumWidth = 9;
            this.MontoCierre.Name = "MontoCierre";
            this.MontoCierre.ReadOnly = true;
            this.MontoCierre.Width = 150;
            // 
            // MontoActual
            // 
            this.MontoActual.HeaderText = "Monto Actual";
            this.MontoActual.MinimumWidth = 9;
            this.MontoActual.Name = "MontoActual";
            this.MontoActual.ReadOnly = true;
            this.MontoActual.Width = 150;
            // 
            // FechaApertura
            // 
            this.FechaApertura.HeaderText = "Fecha Apertura";
            this.FechaApertura.MinimumWidth = 9;
            this.FechaApertura.Name = "FechaApertura";
            this.FechaApertura.ReadOnly = true;
            this.FechaApertura.Width = 150;
            // 
            // FechaCierre
            // 
            this.FechaCierre.HeaderText = "Fecha Cierre";
            this.FechaCierre.MinimumWidth = 9;
            this.FechaCierre.Name = "FechaCierre";
            this.FechaCierre.ReadOnly = true;
            this.FechaCierre.Width = 150;
            // 
            // NroCaja
            // 
            this.NroCaja.HeaderText = "Caja";
            this.NroCaja.MinimumWidth = 9;
            this.NroCaja.Name = "NroCaja";
            this.NroCaja.ReadOnly = true;
            this.NroCaja.Width = 175;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.MinimumWidth = 9;
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Activo.Width = 175;
            // 
            // FrmEstadoCajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 803);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.ComboBusqueda);
            this.Controls.Add(this.LblBuscarPor);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.LblListadoEstadoCajas);
            this.Name = "FrmEstadoCajas";
            this.Text = "Estado actual de Cajas";
            this.Load += new System.EventHandler(this.FrmEstadoCajas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label LblListadoEstadoCajas;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.ComboBox ComboBusqueda;
        private System.Windows.Forms.Label LblBuscarPor;
        private System.Windows.Forms.DataGridViewButtonColumn BtnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTimbrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCaja;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
    }
}
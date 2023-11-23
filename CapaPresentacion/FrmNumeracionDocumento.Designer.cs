namespace CapaPresentacion
{
    partial class FrmNumeracionDocumento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboSucursal = new System.Windows.Forms.ComboBox();
            this.lblCaja = new System.Windows.Forms.Label();
            this.ComboCajas = new System.Windows.Forms.ComboBox();
            this.LbLCodEstablecimiento = new System.Windows.Forms.Label();
            this.TxtCodEstablecimiento = new System.Windows.Forms.TextBox();
            this.LbLUltimoNro = new System.Windows.Forms.Label();
            this.TxTUltimoNro = new System.Windows.Forms.TextBox();
            this.LbLPuntoEmision = new System.Windows.Forms.Label();
            this.TxtPuntoEmision = new System.Windows.Forms.TextBox();
            this.LbLidTimbrado = new System.Windows.Forms.Label();
            this.ComboNroTimbrado = new System.Windows.Forms.ComboBox();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.BtnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idNumeracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuntoEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodEstablecimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimoNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timbrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LbLCabecera = new System.Windows.Forms.Label();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.ComboBusqueda = new System.Windows.Forms.ComboBox();
            this.LblBuscarPor = new System.Windows.Forms.Label();
            this.TxtIndex = new System.Windows.Forms.TextBox();
            this.TxtIdNumeracion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1586, 603);
            this.label2.TabIndex = 139;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(127, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sucursal:";
            // 
            // ComboSucursal
            // 
            this.ComboSucursal.Enabled = false;
            this.ComboSucursal.FormattingEnabled = true;
            this.ComboSucursal.Location = new System.Drawing.Point(256, 23);
            this.ComboSucursal.Name = "ComboSucursal";
            this.ComboSucursal.Size = new System.Drawing.Size(342, 28);
            this.ComboSucursal.TabIndex = 1;
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.BackColor = System.Drawing.Color.White;
            this.lblCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja.Location = new System.Drawing.Point(174, 75);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(63, 26);
            this.lblCaja.TabIndex = 2;
            this.lblCaja.Text = "Caja:";
            // 
            // ComboCajas
            // 
            this.ComboCajas.FormattingEnabled = true;
            this.ComboCajas.Location = new System.Drawing.Point(256, 73);
            this.ComboCajas.Name = "ComboCajas";
            this.ComboCajas.Size = new System.Drawing.Size(342, 28);
            this.ComboCajas.TabIndex = 3;
            // 
            // LbLCodEstablecimiento
            // 
            this.LbLCodEstablecimiento.AutoSize = true;
            this.LbLCodEstablecimiento.BackColor = System.Drawing.Color.White;
            this.LbLCodEstablecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLCodEstablecimiento.Location = new System.Drawing.Point(12, 159);
            this.LbLCodEstablecimiento.Name = "LbLCodEstablecimiento";
            this.LbLCodEstablecimiento.Size = new System.Drawing.Size(225, 26);
            this.LbLCodEstablecimiento.TabIndex = 4;
            this.LbLCodEstablecimiento.Text = "Cod. Establecimiento:";
            // 
            // TxtCodEstablecimiento
            // 
            this.TxtCodEstablecimiento.BackColor = System.Drawing.Color.Silver;
            this.TxtCodEstablecimiento.Location = new System.Drawing.Point(256, 161);
            this.TxtCodEstablecimiento.Name = "TxtCodEstablecimiento";
            this.TxtCodEstablecimiento.Size = new System.Drawing.Size(60, 26);
            this.TxtCodEstablecimiento.TabIndex = 5;
            // 
            // LbLUltimoNro
            // 
            this.LbLUltimoNro.AutoSize = true;
            this.LbLUltimoNro.BackColor = System.Drawing.Color.White;
            this.LbLUltimoNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLUltimoNro.Location = new System.Drawing.Point(115, 206);
            this.LbLUltimoNro.Name = "LbLUltimoNro";
            this.LbLUltimoNro.Size = new System.Drawing.Size(122, 26);
            this.LbLUltimoNro.TabIndex = 6;
            this.LbLUltimoNro.Text = "Ultimo Nro:";
            // 
            // TxTUltimoNro
            // 
            this.TxTUltimoNro.BackColor = System.Drawing.Color.Silver;
            this.TxTUltimoNro.Location = new System.Drawing.Point(256, 206);
            this.TxTUltimoNro.Name = "TxTUltimoNro";
            this.TxTUltimoNro.Size = new System.Drawing.Size(99, 26);
            this.TxTUltimoNro.TabIndex = 7;
            // 
            // LbLPuntoEmision
            // 
            this.LbLPuntoEmision.AutoSize = true;
            this.LbLPuntoEmision.BackColor = System.Drawing.Color.White;
            this.LbLPuntoEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLPuntoEmision.Location = new System.Drawing.Point(77, 118);
            this.LbLPuntoEmision.Name = "LbLPuntoEmision";
            this.LbLPuntoEmision.Size = new System.Drawing.Size(160, 26);
            this.LbLPuntoEmision.TabIndex = 8;
            this.LbLPuntoEmision.Text = "Punto Emision:";
            // 
            // TxtPuntoEmision
            // 
            this.TxtPuntoEmision.BackColor = System.Drawing.Color.Silver;
            this.TxtPuntoEmision.Location = new System.Drawing.Point(256, 118);
            this.TxtPuntoEmision.Name = "TxtPuntoEmision";
            this.TxtPuntoEmision.Size = new System.Drawing.Size(60, 26);
            this.TxtPuntoEmision.TabIndex = 9;
            // 
            // LbLidTimbrado
            // 
            this.LbLidTimbrado.AutoSize = true;
            this.LbLidTimbrado.BackColor = System.Drawing.Color.White;
            this.LbLidTimbrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLidTimbrado.ForeColor = System.Drawing.Color.Black;
            this.LbLidTimbrado.Location = new System.Drawing.Point(115, 268);
            this.LbLidTimbrado.Name = "LbLidTimbrado";
            this.LbLidTimbrado.Size = new System.Drawing.Size(109, 26);
            this.LbLidTimbrado.TabIndex = 3;
            this.LbLidTimbrado.Text = "Timbrado:";
            // 
            // ComboNroTimbrado
            // 
            this.ComboNroTimbrado.FormattingEnabled = true;
            this.ComboNroTimbrado.Location = new System.Drawing.Point(256, 266);
            this.ComboNroTimbrado.Name = "ComboNroTimbrado";
            this.ComboNroTimbrado.Size = new System.Drawing.Size(342, 28);
            this.ComboNroTimbrado.TabIndex = 4;
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
            this.BtnGuardar.Location = new System.Drawing.Point(256, 506);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(157, 42);
            this.BtnGuardar.TabIndex = 52;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnCancelar.IconColor = System.Drawing.Color.White;
            this.BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancelar.IconSize = 16;
            this.BtnCancelar.Location = new System.Drawing.Point(440, 506);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(158, 42);
            this.BtnCancelar.TabIndex = 138;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnSeleccionar,
            this.idNumeracion,
            this.Caja,
            this.PuntoEmision,
            this.CodEstablecimiento,
            this.UltimoNro,
            this.Timbrado});
            this.dgvData.Location = new System.Drawing.Point(644, 206);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvData.RowHeadersWidth = 62;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(858, 342);
            this.dgvData.TabIndex = 140;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.HeaderText = "";
            this.BtnSeleccionar.MinimumWidth = 8;
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.ReadOnly = true;
            this.BtnSeleccionar.Width = 30;
            // 
            // idNumeracion
            // 
            this.idNumeracion.HeaderText = "idNumeracion";
            this.idNumeracion.MinimumWidth = 8;
            this.idNumeracion.Name = "idNumeracion";
            this.idNumeracion.ReadOnly = true;
            this.idNumeracion.Visible = false;
            this.idNumeracion.Width = 150;
            // 
            // Caja
            // 
            this.Caja.HeaderText = "Caja";
            this.Caja.MinimumWidth = 8;
            this.Caja.Name = "Caja";
            this.Caja.ReadOnly = true;
            this.Caja.Width = 150;
            // 
            // PuntoEmision
            // 
            this.PuntoEmision.HeaderText = "Punto Emision";
            this.PuntoEmision.MinimumWidth = 8;
            this.PuntoEmision.Name = "PuntoEmision";
            this.PuntoEmision.ReadOnly = true;
            this.PuntoEmision.Width = 150;
            // 
            // CodEstablecimiento
            // 
            this.CodEstablecimiento.HeaderText = "Cod. Establecimiento";
            this.CodEstablecimiento.MinimumWidth = 8;
            this.CodEstablecimiento.Name = "CodEstablecimiento";
            this.CodEstablecimiento.ReadOnly = true;
            this.CodEstablecimiento.Width = 150;
            // 
            // UltimoNro
            // 
            this.UltimoNro.HeaderText = "Ultimo. Nro.";
            this.UltimoNro.MinimumWidth = 8;
            this.UltimoNro.Name = "UltimoNro";
            this.UltimoNro.ReadOnly = true;
            this.UltimoNro.Width = 150;
            // 
            // Timbrado
            // 
            this.Timbrado.HeaderText = "Timbrado";
            this.Timbrado.MinimumWidth = 8;
            this.Timbrado.Name = "Timbrado";
            this.Timbrado.ReadOnly = true;
            this.Timbrado.Width = 150;
            // 
            // LbLCabecera
            // 
            this.LbLCabecera.BackColor = System.Drawing.Color.White;
            this.LbLCabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLCabecera.Location = new System.Drawing.Point(638, 23);
            this.LbLCabecera.Name = "LbLCabecera";
            this.LbLCabecera.Size = new System.Drawing.Size(930, 50);
            this.LbLCabecera.TabIndex = 141;
            this.LbLCabecera.Text = "Numeracion de Documentos";
            this.LbLCabecera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.BtnLimpiar.Location = new System.Drawing.Point(1360, 108);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(64, 40);
            this.BtnLimpiar.TabIndex = 146;
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
            this.BtnBuscar.Location = new System.Drawing.Point(1257, 108);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(64, 40);
            this.BtnBuscar.TabIndex = 145;
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(978, 122);
            this.TxtBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(230, 26);
            this.TxtBusqueda.TabIndex = 142;
            // 
            // ComboBusqueda
            // 
            this.ComboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBusqueda.FormattingEnabled = true;
            this.ComboBusqueda.Location = new System.Drawing.Point(757, 120);
            this.ComboBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBusqueda.Name = "ComboBusqueda";
            this.ComboBusqueda.Size = new System.Drawing.Size(180, 28);
            this.ComboBusqueda.TabIndex = 144;
            // 
            // LblBuscarPor
            // 
            this.LblBuscarPor.AutoSize = true;
            this.LblBuscarPor.BackColor = System.Drawing.Color.White;
            this.LblBuscarPor.Location = new System.Drawing.Point(640, 128);
            this.LblBuscarPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBuscarPor.Name = "LblBuscarPor";
            this.LblBuscarPor.Size = new System.Drawing.Size(90, 20);
            this.LblBuscarPor.TabIndex = 143;
            this.LblBuscarPor.Text = "Buscar por:";
            // 
            // TxtIndex
            // 
            this.TxtIndex.Location = new System.Drawing.Point(41, 387);
            this.TxtIndex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtIndex.Name = "TxtIndex";
            this.TxtIndex.Size = new System.Drawing.Size(37, 26);
            this.TxtIndex.TabIndex = 148;
            this.TxtIndex.Text = "-1";
            this.TxtIndex.Visible = false;
            // 
            // TxtIdNumeracion
            // 
            this.TxtIdNumeracion.Location = new System.Drawing.Point(85, 384);
            this.TxtIdNumeracion.Name = "TxtIdNumeracion";
            this.TxtIdNumeracion.Size = new System.Drawing.Size(48, 26);
            this.TxtIdNumeracion.TabIndex = 147;
            this.TxtIdNumeracion.Visible = false;
            // 
            // FrmNumeracionDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1688, 603);
            this.Controls.Add(this.TxtIndex);
            this.Controls.Add(this.TxtIdNumeracion);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.ComboBusqueda);
            this.Controls.Add(this.LblBuscarPor);
            this.Controls.Add(this.LbLCabecera);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.LbLidTimbrado);
            this.Controls.Add(this.ComboNroTimbrado);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtPuntoEmision);
            this.Controls.Add(this.LbLPuntoEmision);
            this.Controls.Add(this.TxTUltimoNro);
            this.Controls.Add(this.LbLUltimoNro);
            this.Controls.Add(this.TxtCodEstablecimiento);
            this.Controls.Add(this.LbLCodEstablecimiento);
            this.Controls.Add(this.ComboCajas);
            this.Controls.Add(this.lblCaja);
            this.Controls.Add(this.ComboSucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FrmNumeracionDocumento";
            this.Text = "Numeracion de Documentos";
            this.Load += new System.EventHandler(this.FrmNumeracionDocumento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboSucursal;
        private System.Windows.Forms.Label lblCaja;
        private System.Windows.Forms.ComboBox ComboCajas;
        private System.Windows.Forms.Label LbLCodEstablecimiento;
        private System.Windows.Forms.TextBox TxtCodEstablecimiento;
        private System.Windows.Forms.Label LbLUltimoNro;
        private System.Windows.Forms.TextBox TxTUltimoNro;
        private System.Windows.Forms.Label LbLPuntoEmision;
        private System.Windows.Forms.TextBox TxtPuntoEmision;
        private System.Windows.Forms.Label LbLidTimbrado;
        private System.Windows.Forms.ComboBox ComboNroTimbrado;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label LbLCabecera;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.ComboBox ComboBusqueda;
        private System.Windows.Forms.Label LblBuscarPor;
        private System.Windows.Forms.DataGridViewButtonColumn BtnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNumeracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caja;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntoEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodEstablecimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltimoNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timbrado;
        private System.Windows.Forms.TextBox TxtIndex;
        private System.Windows.Forms.TextBox TxtIdNumeracion;
    }
}
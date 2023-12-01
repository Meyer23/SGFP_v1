namespace CapaPresentacion
{
    partial class PopUpDetalleCobro
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
            this.LblCompras = new System.Windows.Forms.Label();
            this.LblTipoValor = new System.Windows.Forms.Label();
            this.LblNroCuenta = new System.Windows.Forms.Label();
            this.LblImporte = new System.Windows.Forms.Label();
            this.LblBanco = new System.Windows.Forms.Label();
            this.LblNroDocumento = new System.Windows.Forms.Label();
            this.ComboTipoValor = new System.Windows.Forms.ComboBox();
            this.ComboBanco = new System.Windows.Forms.ComboBox();
            this.TxtNroCuenta = new System.Windows.Forms.TextBox();
            this.TxtNroDocumento = new System.Windows.Forms.TextBox();
            this.TxtImporte = new System.Windows.Forms.TextBox();
            this.TxtVuelto = new System.Windows.Forms.TextBox();
            this.LblVuelto = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.LblDetalleCobro = new System.Windows.Forms.Label();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.LbLMontoTotal = new System.Windows.Forms.Label();
            this.TxtMontoTotal = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new FontAwesome.Sharp.IconButton();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtImporteActual = new System.Windows.Forms.TextBox();
            this.TxtTipoValor = new System.Windows.Forms.TextBox();
            this.TxtIdBanco = new System.Windows.Forms.TextBox();
            this.tmpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.LblVencimiento = new System.Windows.Forms.Label();
            this.TipoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteVuelto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCompras
            // 
            this.LblCompras.BackColor = System.Drawing.Color.White;
            this.LblCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCompras.Location = new System.Drawing.Point(15, 9);
            this.LblCompras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCompras.Name = "LblCompras";
            this.LblCompras.Padding = new System.Windows.Forms.Padding(4);
            this.LblCompras.Size = new System.Drawing.Size(1481, 873);
            this.LblCompras.TabIndex = 53;
            this.LblCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblTipoValor
            // 
            this.LblTipoValor.AutoSize = true;
            this.LblTipoValor.BackColor = System.Drawing.Color.White;
            this.LblTipoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoValor.Location = new System.Drawing.Point(39, 61);
            this.LblTipoValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTipoValor.Name = "LblTipoValor";
            this.LblTipoValor.Size = new System.Drawing.Size(131, 29);
            this.LblTipoValor.TabIndex = 54;
            this.LblTipoValor.Text = "Tipo Valor:";
            // 
            // LblNroCuenta
            // 
            this.LblNroCuenta.AutoSize = true;
            this.LblNroCuenta.BackColor = System.Drawing.Color.White;
            this.LblNroCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNroCuenta.Location = new System.Drawing.Point(667, 61);
            this.LblNroCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNroCuenta.Name = "LblNroCuenta";
            this.LblNroCuenta.Size = new System.Drawing.Size(147, 29);
            this.LblNroCuenta.TabIndex = 55;
            this.LblNroCuenta.Text = "Nro. Cuenta:";
            // 
            // LblImporte
            // 
            this.LblImporte.AutoSize = true;
            this.LblImporte.BackColor = System.Drawing.Color.White;
            this.LblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImporte.Location = new System.Drawing.Point(341, 167);
            this.LblImporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblImporte.Name = "LblImporte";
            this.LblImporte.Size = new System.Drawing.Size(101, 29);
            this.LblImporte.TabIndex = 56;
            this.LblImporte.Text = "Importe:";
            // 
            // LblBanco
            // 
            this.LblBanco.AutoSize = true;
            this.LblBanco.BackColor = System.Drawing.Color.White;
            this.LblBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBanco.Location = new System.Drawing.Point(341, 61);
            this.LblBanco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBanco.Name = "LblBanco";
            this.LblBanco.Size = new System.Drawing.Size(87, 29);
            this.LblBanco.TabIndex = 57;
            this.LblBanco.Text = "Banco:";
            // 
            // LblNroDocumento
            // 
            this.LblNroDocumento.AutoSize = true;
            this.LblNroDocumento.BackColor = System.Drawing.Color.White;
            this.LblNroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNroDocumento.Location = new System.Drawing.Point(39, 167);
            this.LblNroDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNroDocumento.Name = "LblNroDocumento";
            this.LblNroDocumento.Size = new System.Drawing.Size(194, 29);
            this.LblNroDocumento.TabIndex = 58;
            this.LblNroDocumento.Text = "Nro. Documento:";
            // 
            // ComboTipoValor
            // 
            this.ComboTipoValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTipoValor.FormattingEnabled = true;
            this.ComboTipoValor.Location = new System.Drawing.Point(45, 106);
            this.ComboTipoValor.Margin = new System.Windows.Forms.Padding(4);
            this.ComboTipoValor.Name = "ComboTipoValor";
            this.ComboTipoValor.Size = new System.Drawing.Size(197, 32);
            this.ComboTipoValor.TabIndex = 59;
            this.ComboTipoValor.SelectedIndexChanged += new System.EventHandler(this.ComboTipoValor_SelectedIndexChanged);
            this.ComboTipoValor.SelectedValueChanged += new System.EventHandler(this.ComboTipoValor_SelectedValueChanged);
            // 
            // ComboBanco
            // 
            this.ComboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBanco.FormattingEnabled = true;
            this.ComboBanco.Location = new System.Drawing.Point(347, 106);
            this.ComboBanco.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBanco.Name = "ComboBanco";
            this.ComboBanco.Size = new System.Drawing.Size(197, 32);
            this.ComboBanco.TabIndex = 60;
            this.ComboBanco.SelectedIndexChanged += new System.EventHandler(this.ComboBanco_SelectedIndexChanged);
            // 
            // TxtNroCuenta
            // 
            this.TxtNroCuenta.Location = new System.Drawing.Point(673, 106);
            this.TxtNroCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNroCuenta.Name = "TxtNroCuenta";
            this.TxtNroCuenta.Size = new System.Drawing.Size(187, 29);
            this.TxtNroCuenta.TabIndex = 61;
            this.TxtNroCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNroCuenta_KeyPress);
            // 
            // TxtNroDocumento
            // 
            this.TxtNroDocumento.Location = new System.Drawing.Point(48, 212);
            this.TxtNroDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNroDocumento.Name = "TxtNroDocumento";
            this.TxtNroDocumento.Size = new System.Drawing.Size(195, 29);
            this.TxtNroDocumento.TabIndex = 62;
            this.TxtNroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNroDocumento_KeyPress);
            // 
            // TxtImporte
            // 
            this.TxtImporte.Location = new System.Drawing.Point(350, 212);
            this.TxtImporte.Margin = new System.Windows.Forms.Padding(4);
            this.TxtImporte.Name = "TxtImporte";
            this.TxtImporte.Size = new System.Drawing.Size(195, 29);
            this.TxtImporte.TabIndex = 63;
            this.TxtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtImporte_KeyPress);
            // 
            // TxtVuelto
            // 
            this.TxtVuelto.Enabled = false;
            this.TxtVuelto.Location = new System.Drawing.Point(666, 212);
            this.TxtVuelto.Margin = new System.Windows.Forms.Padding(4);
            this.TxtVuelto.Name = "TxtVuelto";
            this.TxtVuelto.Size = new System.Drawing.Size(195, 29);
            this.TxtVuelto.TabIndex = 65;
            this.TxtVuelto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtVuelto_KeyPress);
            // 
            // LblVuelto
            // 
            this.LblVuelto.AutoSize = true;
            this.LblVuelto.BackColor = System.Drawing.Color.White;
            this.LblVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVuelto.Location = new System.Drawing.Point(667, 167);
            this.LblVuelto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblVuelto.Name = "LblVuelto";
            this.LblVuelto.Size = new System.Drawing.Size(87, 29);
            this.LblVuelto.TabIndex = 64;
            this.LblVuelto.Text = "Vuelto:";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoValor,
            this.Banco,
            this.NroCuenta,
            this.NroDocumento,
            this.Importe,
            this.ImporteVuelto,
            this.idValor,
            this.idBanco,
            this.FechaVencimiento});
            this.dgvData.Location = new System.Drawing.Point(45, 387);
            this.dgvData.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.Size = new System.Drawing.Size(1174, 310);
            this.dgvData.TabIndex = 66;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellEndEdit);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting);
            // 
            // LblDetalleCobro
            // 
            this.LblDetalleCobro.AutoSize = true;
            this.LblDetalleCobro.BackColor = System.Drawing.Color.White;
            this.LblDetalleCobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDetalleCobro.Location = new System.Drawing.Point(40, 283);
            this.LblDetalleCobro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDetalleCobro.Name = "LblDetalleCobro";
            this.LblDetalleCobro.Size = new System.Drawing.Size(275, 39);
            this.LblDetalleCobro.TabIndex = 67;
            this.LblDetalleCobro.Text = "Detalle de Cobro";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.BtnCancelar.IconColor = System.Drawing.Color.Black;
            this.BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancelar.Location = new System.Drawing.Point(1135, 722);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(309, 95);
            this.BtnCancelar.TabIndex = 68;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LbLMontoTotal
            // 
            this.LbLMontoTotal.AutoSize = true;
            this.LbLMontoTotal.BackColor = System.Drawing.Color.White;
            this.LbLMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLMontoTotal.Location = new System.Drawing.Point(45, 760);
            this.LbLMontoTotal.Name = "LbLMontoTotal";
            this.LbLMontoTotal.Size = new System.Drawing.Size(246, 29);
            this.LbLMontoTotal.TabIndex = 69;
            this.LbLMontoTotal.Text = "Monto Total a Cobrar:";
            // 
            // TxtMontoTotal
            // 
            this.TxtMontoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMontoTotal.Location = new System.Drawing.Point(297, 751);
            this.TxtMontoTotal.Name = "TxtMontoTotal";
            this.TxtMontoTotal.Size = new System.Drawing.Size(255, 47);
            this.TxtMontoTotal.TabIndex = 70;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Green;
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.BtnAgregar.IconColor = System.Drawing.Color.White;
            this.BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAgregar.Location = new System.Drawing.Point(346, 271);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(169, 104);
            this.BtnAgregar.TabIndex = 71;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnGuardar.IconColor = System.Drawing.Color.Black;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.Location = new System.Drawing.Point(830, 728);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(254, 88);
            this.BtnGuardar.TabIndex = 72;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(668, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 73;
            this.label1.Text = "Importe Actual:";
            // 
            // TxtImporteActual
            // 
            this.TxtImporteActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtImporteActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImporteActual.Location = new System.Drawing.Point(880, 265);
            this.TxtImporteActual.Name = "TxtImporteActual";
            this.TxtImporteActual.Size = new System.Drawing.Size(255, 47);
            this.TxtImporteActual.TabIndex = 74;
            // 
            // TxtTipoValor
            // 
            this.TxtTipoValor.Location = new System.Drawing.Point(179, 32);
            this.TxtTipoValor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtTipoValor.Name = "TxtTipoValor";
            this.TxtTipoValor.Size = new System.Drawing.Size(33, 29);
            this.TxtTipoValor.TabIndex = 75;
            this.TxtTipoValor.Text = "0";
            this.TxtTipoValor.Visible = false;
            // 
            // TxtIdBanco
            // 
            this.TxtIdBanco.Location = new System.Drawing.Point(511, 32);
            this.TxtIdBanco.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtIdBanco.Name = "TxtIdBanco";
            this.TxtIdBanco.Size = new System.Drawing.Size(33, 29);
            this.TxtIdBanco.TabIndex = 76;
            this.TxtIdBanco.Text = "0";
            this.TxtIdBanco.Visible = false;
            // 
            // tmpFechaVencimiento
            // 
            this.tmpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tmpFechaVencimiento.Location = new System.Drawing.Point(922, 106);
            this.tmpFechaVencimiento.Name = "tmpFechaVencimiento";
            this.tmpFechaVencimiento.Size = new System.Drawing.Size(200, 29);
            this.tmpFechaVencimiento.TabIndex = 77;
            // 
            // LblVencimiento
            // 
            this.LblVencimiento.AutoSize = true;
            this.LblVencimiento.BackColor = System.Drawing.Color.White;
            this.LblVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVencimiento.Location = new System.Drawing.Point(917, 61);
            this.LblVencimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblVencimiento.Name = "LblVencimiento";
            this.LblVencimiento.Size = new System.Drawing.Size(147, 29);
            this.LblVencimiento.TabIndex = 78;
            this.LblVencimiento.Text = "Nro. Cuenta:";
            // 
            // TipoValor
            // 
            this.TipoValor.HeaderText = "Tipo Valor";
            this.TipoValor.MinimumWidth = 8;
            this.TipoValor.Name = "TipoValor";
            this.TipoValor.ReadOnly = true;
            this.TipoValor.Width = 150;
            // 
            // Banco
            // 
            this.Banco.HeaderText = "Banco";
            this.Banco.MinimumWidth = 8;
            this.Banco.Name = "Banco";
            this.Banco.ReadOnly = true;
            this.Banco.Width = 300;
            // 
            // NroCuenta
            // 
            this.NroCuenta.HeaderText = "Nro. Cuenta";
            this.NroCuenta.MinimumWidth = 8;
            this.NroCuenta.Name = "NroCuenta";
            this.NroCuenta.ReadOnly = true;
            this.NroCuenta.Width = 150;
            // 
            // NroDocumento
            // 
            this.NroDocumento.HeaderText = "Nro. Documento";
            this.NroDocumento.MinimumWidth = 8;
            this.NroDocumento.Name = "NroDocumento";
            this.NroDocumento.ReadOnly = true;
            this.NroDocumento.Width = 150;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 8;
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 150;
            // 
            // ImporteVuelto
            // 
            this.ImporteVuelto.HeaderText = "Importe Vuelto";
            this.ImporteVuelto.MinimumWidth = 8;
            this.ImporteVuelto.Name = "ImporteVuelto";
            this.ImporteVuelto.ReadOnly = true;
            this.ImporteVuelto.Width = 150;
            // 
            // idValor
            // 
            this.idValor.HeaderText = "idvalor";
            this.idValor.MinimumWidth = 9;
            this.idValor.Name = "idValor";
            this.idValor.ReadOnly = true;
            this.idValor.Visible = false;
            this.idValor.Width = 175;
            // 
            // idBanco
            // 
            this.idBanco.HeaderText = "idbanco";
            this.idBanco.MinimumWidth = 9;
            this.idBanco.Name = "idBanco";
            this.idBanco.ReadOnly = true;
            this.idBanco.Visible = false;
            this.idBanco.Width = 175;
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.HeaderText = "FechaVencimiento";
            this.FechaVencimiento.MinimumWidth = 9;
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.ReadOnly = true;
            this.FechaVencimiento.Visible = false;
            this.FechaVencimiento.Width = 175;
            // 
            // PopUpDetalleCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 905);
            this.Controls.Add(this.LblVencimiento);
            this.Controls.Add(this.tmpFechaVencimiento);
            this.Controls.Add(this.TxtIdBanco);
            this.Controls.Add(this.TxtTipoValor);
            this.Controls.Add(this.TxtImporteActual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtMontoTotal);
            this.Controls.Add(this.LbLMontoTotal);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.LblDetalleCobro);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.TxtVuelto);
            this.Controls.Add(this.LblVuelto);
            this.Controls.Add(this.TxtImporte);
            this.Controls.Add(this.TxtNroDocumento);
            this.Controls.Add(this.TxtNroCuenta);
            this.Controls.Add(this.ComboBanco);
            this.Controls.Add(this.ComboTipoValor);
            this.Controls.Add(this.LblNroDocumento);
            this.Controls.Add(this.LblBanco);
            this.Controls.Add(this.LblImporte);
            this.Controls.Add(this.LblNroCuenta);
            this.Controls.Add(this.LblTipoValor);
            this.Controls.Add(this.LblCompras);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PopUpDetalleCobro";
            this.Text = "Detalle Cobro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCompras;
        private System.Windows.Forms.Label LblTipoValor;
        private System.Windows.Forms.Label LblNroCuenta;
        private System.Windows.Forms.Label LblImporte;
        private System.Windows.Forms.Label LblBanco;
        private System.Windows.Forms.Label LblNroDocumento;
        private System.Windows.Forms.ComboBox ComboTipoValor;
        private System.Windows.Forms.ComboBox ComboBanco;
        private System.Windows.Forms.TextBox TxtNroCuenta;
        private System.Windows.Forms.TextBox TxtNroDocumento;
        private System.Windows.Forms.TextBox TxtImporte;
        private System.Windows.Forms.TextBox TxtVuelto;
        private System.Windows.Forms.Label LblVuelto;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label LblDetalleCobro;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private System.Windows.Forms.Label LbLMontoTotal;
        private System.Windows.Forms.TextBox TxtMontoTotal;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtImporteActual;
        private System.Windows.Forms.TextBox TxtTipoValor;
        private System.Windows.Forms.TextBox TxtIdBanco;
        private System.Windows.Forms.DateTimePicker tmpFechaVencimiento;
        private System.Windows.Forms.Label LblVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteVuelto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
    }
}
﻿namespace CapaPresentacion
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
            this.LblSaldo = new System.Windows.Forms.Label();
            this.TxtSaldo = new System.Windows.Forms.TextBox();
            this.TxtTipoValor = new System.Windows.Forms.TextBox();
            this.TxtIdBanco = new System.Windows.Forms.TextBox();
            this.tmpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.LblVencimiento = new System.Windows.Forms.Label();
            this.idValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteVuelto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCompras
            // 
            this.LblCompras.BackColor = System.Drawing.Color.White;
            this.LblCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCompras.Location = new System.Drawing.Point(8, 5);
            this.LblCompras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCompras.Name = "LblCompras";
            this.LblCompras.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LblCompras.Size = new System.Drawing.Size(999, 473);
            this.LblCompras.TabIndex = 53;
            this.LblCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblTipoValor
            // 
            this.LblTipoValor.AutoSize = true;
            this.LblTipoValor.BackColor = System.Drawing.Color.White;
            this.LblTipoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoValor.Location = new System.Drawing.Point(21, 64);
            this.LblTipoValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTipoValor.Name = "LblTipoValor";
            this.LblTipoValor.Size = new System.Drawing.Size(58, 13);
            this.LblTipoValor.TabIndex = 54;
            this.LblTipoValor.Text = "Tipo Valor:";
            // 
            // LblNroCuenta
            // 
            this.LblNroCuenta.AutoSize = true;
            this.LblNroCuenta.BackColor = System.Drawing.Color.White;
            this.LblNroCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNroCuenta.Location = new System.Drawing.Point(364, 64);
            this.LblNroCuenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNroCuenta.Name = "LblNroCuenta";
            this.LblNroCuenta.Size = new System.Drawing.Size(67, 13);
            this.LblNroCuenta.TabIndex = 55;
            this.LblNroCuenta.Text = "Nro. Cuenta:";
            // 
            // LblImporte
            // 
            this.LblImporte.AutoSize = true;
            this.LblImporte.BackColor = System.Drawing.Color.White;
            this.LblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImporte.Location = new System.Drawing.Point(734, 64);
            this.LblImporte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblImporte.Name = "LblImporte";
            this.LblImporte.Size = new System.Drawing.Size(45, 13);
            this.LblImporte.TabIndex = 56;
            this.LblImporte.Text = "Importe:";
            // 
            // LblBanco
            // 
            this.LblBanco.AutoSize = true;
            this.LblBanco.BackColor = System.Drawing.Color.White;
            this.LblBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBanco.Location = new System.Drawing.Point(193, 64);
            this.LblBanco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblBanco.Name = "LblBanco";
            this.LblBanco.Size = new System.Drawing.Size(41, 13);
            this.LblBanco.TabIndex = 57;
            this.LblBanco.Text = "Banco:";
            // 
            // LblNroDocumento
            // 
            this.LblNroDocumento.AutoSize = true;
            this.LblNroDocumento.BackColor = System.Drawing.Color.White;
            this.LblNroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNroDocumento.Location = new System.Drawing.Point(611, 64);
            this.LblNroDocumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNroDocumento.Name = "LblNroDocumento";
            this.LblNroDocumento.Size = new System.Drawing.Size(88, 13);
            this.LblNroDocumento.TabIndex = 58;
            this.LblNroDocumento.Text = "Nro. Documento:";
            // 
            // ComboTipoValor
            // 
            this.ComboTipoValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTipoValor.FormattingEnabled = true;
            this.ComboTipoValor.Location = new System.Drawing.Point(24, 79);
            this.ComboTipoValor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboTipoValor.Name = "ComboTipoValor";
            this.ComboTipoValor.Size = new System.Drawing.Size(156, 21);
            this.ComboTipoValor.TabIndex = 59;
            this.ComboTipoValor.SelectedIndexChanged += new System.EventHandler(this.ComboTipoValor_SelectedIndexChanged);
            this.ComboTipoValor.SelectedValueChanged += new System.EventHandler(this.ComboTipoValor_SelectedValueChanged);
            // 
            // ComboBanco
            // 
            this.ComboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBanco.FormattingEnabled = true;
            this.ComboBanco.Location = new System.Drawing.Point(196, 79);
            this.ComboBanco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBanco.Name = "ComboBanco";
            this.ComboBanco.Size = new System.Drawing.Size(146, 21);
            this.ComboBanco.TabIndex = 60;
            this.ComboBanco.SelectedIndexChanged += new System.EventHandler(this.ComboBanco_SelectedIndexChanged);
            // 
            // TxtNroCuenta
            // 
            this.TxtNroCuenta.Location = new System.Drawing.Point(367, 79);
            this.TxtNroCuenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNroCuenta.Name = "TxtNroCuenta";
            this.TxtNroCuenta.Size = new System.Drawing.Size(104, 20);
            this.TxtNroCuenta.TabIndex = 61;
            this.TxtNroCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNroCuenta_KeyPress);
            // 
            // TxtNroDocumento
            // 
            this.TxtNroDocumento.Location = new System.Drawing.Point(614, 79);
            this.TxtNroDocumento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNroDocumento.Name = "TxtNroDocumento";
            this.TxtNroDocumento.Size = new System.Drawing.Size(108, 20);
            this.TxtNroDocumento.TabIndex = 62;
            this.TxtNroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNroDocumento_KeyPress);
            // 
            // TxtImporte
            // 
            this.TxtImporte.Location = new System.Drawing.Point(737, 79);
            this.TxtImporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtImporte.Name = "TxtImporte";
            this.TxtImporte.Size = new System.Drawing.Size(141, 20);
            this.TxtImporte.TabIndex = 63;
            this.TxtImporte.TextChanged += new System.EventHandler(this.TxtImporte_TextChanged);
            this.TxtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtImporte_KeyPress);
            // 
            // TxtVuelto
            // 
            this.TxtVuelto.Enabled = false;
            this.TxtVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVuelto.Location = new System.Drawing.Point(196, 394);
            this.TxtVuelto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtVuelto.Name = "TxtVuelto";
            this.TxtVuelto.ReadOnly = true;
            this.TxtVuelto.Size = new System.Drawing.Size(141, 30);
            this.TxtVuelto.TabIndex = 65;
            this.TxtVuelto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtVuelto_KeyPress);
            // 
            // LblVuelto
            // 
            this.LblVuelto.AutoSize = true;
            this.LblVuelto.BackColor = System.Drawing.Color.White;
            this.LblVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVuelto.Location = new System.Drawing.Point(193, 375);
            this.LblVuelto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblVuelto.Name = "LblVuelto";
            this.LblVuelto.Size = new System.Drawing.Size(52, 17);
            this.LblVuelto.TabIndex = 64;
            this.LblVuelto.Text = "Vuelto:";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idValor,
            this.idBanco,
            this.NroCuenta,
            this.NroDocumento,
            this.Importe,
            this.ImporteVuelto,
            this.FechaVencimiento,
            this.TipoValor,
            this.Banco,
            this.BtnEliminar});
            this.dgvData.Location = new System.Drawing.Point(24, 145);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.Size = new System.Drawing.Size(972, 203);
            this.dgvData.TabIndex = 66;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellEndEdit);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting);
            // 
            // LblDetalleCobro
            // 
            this.LblDetalleCobro.AutoSize = true;
            this.LblDetalleCobro.BackColor = System.Drawing.Color.White;
            this.LblDetalleCobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDetalleCobro.Location = new System.Drawing.Point(20, 26);
            this.LblDetalleCobro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDetalleCobro.Name = "LblDetalleCobro";
            this.LblDetalleCobro.Size = new System.Drawing.Size(128, 20);
            this.LblDetalleCobro.TabIndex = 67;
            this.LblDetalleCobro.Text = "Detalle de Cobro";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.BtnCancelar.IconColor = System.Drawing.Color.White;
            this.BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancelar.IconSize = 16;
            this.BtnCancelar.Location = new System.Drawing.Point(823, 375);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(173, 27);
            this.BtnCancelar.TabIndex = 68;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LbLMontoTotal
            // 
            this.LbLMontoTotal.AutoSize = true;
            this.LbLMontoTotal.BackColor = System.Drawing.Color.White;
            this.LbLMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLMontoTotal.Location = new System.Drawing.Point(364, 375);
            this.LbLMontoTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbLMontoTotal.Name = "LbLMontoTotal";
            this.LbLMontoTotal.Size = new System.Drawing.Size(146, 17);
            this.LbLMontoTotal.TabIndex = 69;
            this.LbLMontoTotal.Text = "Monto Total a Cobrar:";
            // 
            // TxtMontoTotal
            // 
            this.TxtMontoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMontoTotal.Location = new System.Drawing.Point(367, 395);
            this.TxtMontoTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtMontoTotal.Name = "TxtMontoTotal";
            this.TxtMontoTotal.ReadOnly = true;
            this.TxtMontoTotal.Size = new System.Drawing.Size(140, 30);
            this.TxtMontoTotal.TabIndex = 70;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.BtnAgregar.IconColor = System.Drawing.Color.Black;
            this.BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAgregar.Location = new System.Drawing.Point(892, 55);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(82, 72);
            this.BtnAgregar.TabIndex = 71;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
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
            this.BtnGuardar.Location = new System.Drawing.Point(637, 375);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(173, 27);
            this.BtnGuardar.TabIndex = 72;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LblSaldo
            // 
            this.LblSaldo.AutoSize = true;
            this.LblSaldo.BackColor = System.Drawing.Color.White;
            this.LblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaldo.Location = new System.Drawing.Point(22, 375);
            this.LblSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSaldo.Name = "LblSaldo";
            this.LblSaldo.Size = new System.Drawing.Size(48, 17);
            this.LblSaldo.TabIndex = 73;
            this.LblSaldo.Text = "Saldo:";
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSaldo.Location = new System.Drawing.Point(25, 394);
            this.TxtSaldo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.ReadOnly = true;
            this.TxtSaldo.Size = new System.Drawing.Size(140, 30);
            this.TxtSaldo.TabIndex = 74;
            this.TxtSaldo.TextChanged += new System.EventHandler(this.TxtSaldo_TextChanged);
            // 
            // TxtTipoValor
            // 
            this.TxtTipoValor.Location = new System.Drawing.Point(145, 49);
            this.TxtTipoValor.Name = "TxtTipoValor";
            this.TxtTipoValor.Size = new System.Drawing.Size(20, 20);
            this.TxtTipoValor.TabIndex = 75;
            this.TxtTipoValor.Text = "0";
            this.TxtTipoValor.Visible = false;
            // 
            // TxtIdBanco
            // 
            this.TxtIdBanco.Location = new System.Drawing.Point(289, 49);
            this.TxtIdBanco.Name = "TxtIdBanco";
            this.TxtIdBanco.Size = new System.Drawing.Size(20, 20);
            this.TxtIdBanco.TabIndex = 76;
            this.TxtIdBanco.Text = "0";
            this.TxtIdBanco.Visible = false;
            // 
            // tmpFechaVencimiento
            // 
            this.tmpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tmpFechaVencimiento.Location = new System.Drawing.Point(490, 79);
            this.tmpFechaVencimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tmpFechaVencimiento.MinDate = new System.DateTime(2023, 12, 4, 0, 0, 0, 0);
            this.tmpFechaVencimiento.Name = "tmpFechaVencimiento";
            this.tmpFechaVencimiento.Size = new System.Drawing.Size(111, 20);
            this.tmpFechaVencimiento.TabIndex = 77;
            // 
            // LblVencimiento
            // 
            this.LblVencimiento.AutoSize = true;
            this.LblVencimiento.BackColor = System.Drawing.Color.White;
            this.LblVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVencimiento.Location = new System.Drawing.Point(487, 64);
            this.LblVencimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblVencimiento.Name = "LblVencimiento";
            this.LblVencimiento.Size = new System.Drawing.Size(101, 13);
            this.LblVencimiento.TabIndex = 78;
            this.LblVencimiento.Text = "Fecha Vencimiento:";
            // 
            // idValor
            // 
            this.idValor.HeaderText = "idvalor";
            this.idValor.MinimumWidth = 9;
            this.idValor.Name = "idValor";
            this.idValor.ReadOnly = true;
            this.idValor.Visible = false;
            this.idValor.Width = 50;
            // 
            // idBanco
            // 
            this.idBanco.HeaderText = "idbanco";
            this.idBanco.MinimumWidth = 9;
            this.idBanco.Name = "idBanco";
            this.idBanco.ReadOnly = true;
            this.idBanco.Visible = false;
            this.idBanco.Width = 50;
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
            // FechaVencimiento
            // 
            this.FechaVencimiento.HeaderText = "FechaVencimiento";
            this.FechaVencimiento.MinimumWidth = 9;
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.ReadOnly = true;
            this.FechaVencimiento.Visible = false;
            this.FechaVencimiento.Width = 175;
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
            this.Banco.Width = 150;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.HeaderText = "";
            this.BtnEliminar.MinimumWidth = 9;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.ReadOnly = true;
            this.BtnEliminar.Visible = false;
            this.BtnEliminar.Width = 175;
            // 
            // PopUpDetalleCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 479);
            this.Controls.Add(this.LblVencimiento);
            this.Controls.Add(this.tmpFechaVencimiento);
            this.Controls.Add(this.TxtIdBanco);
            this.Controls.Add(this.TxtTipoValor);
            this.Controls.Add(this.TxtSaldo);
            this.Controls.Add(this.LblSaldo);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label LblSaldo;
        private System.Windows.Forms.TextBox TxtSaldo;
        private System.Windows.Forms.TextBox TxtTipoValor;
        private System.Windows.Forms.TextBox TxtIdBanco;
        private System.Windows.Forms.DateTimePicker tmpFechaVencimiento;
        private System.Windows.Forms.Label LblVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteVuelto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEliminar;
    }
}
namespace CapaPresentacion
{
    partial class FrmAperturaCierreCaja
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
            this.LblUsuariosAgregar = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.DateTimePickerApertura = new System.Windows.Forms.DateTimePicker();
            this.LblSucursal = new System.Windows.Forms.Label();
            this.ComboSucursal = new System.Windows.Forms.ComboBox();
            this.ComboCajas = new System.Windows.Forms.ComboBox();
            this.LblCaja = new System.Windows.Forms.Label();
            this.ImporteUpDown = new System.Windows.Forms.NumericUpDown();
            this.LbLimporte = new System.Windows.Forms.Label();
            this.ComboEstado = new System.Windows.Forms.ComboBox();
            this.LbLEstado = new System.Windows.Forms.Label();
            this.LbLCajero = new System.Windows.Forms.Label();
            this.ComboCajero = new System.Windows.Forms.ComboBox();
            this.DateTimePickerCierre = new System.Windows.Forms.DateTimePicker();
            this.LbLFechaCierre = new System.Windows.Forms.Label();
            this.LbLimporteCierre = new System.Windows.Forms.Label();
            this.UpDownMontoCierre = new System.Windows.Forms.NumericUpDown();
            this.BtnSalir = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnApertura = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCerrarCaja = new FontAwesome.Sharp.IconButton();
            this.LblDetalleAperturaCierre = new System.Windows.Forms.Label();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.ImporteUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMontoCierre)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblUsuariosAgregar
            // 
            this.LblUsuariosAgregar.BackColor = System.Drawing.Color.White;
            this.LblUsuariosAgregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblUsuariosAgregar.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblUsuariosAgregar.Location = new System.Drawing.Point(0, 0);
            this.LblUsuariosAgregar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblUsuariosAgregar.Name = "LblUsuariosAgregar";
            this.LblUsuariosAgregar.Size = new System.Drawing.Size(691, 475);
            this.LblUsuariosAgregar.TabIndex = 3;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(17, 29);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(83, 13);
            this.LblFecha.TabIndex = 6;
            this.LblFecha.Text = "Fecha Apertura:";
            // 
            // DateTimePickerApertura
            // 
            this.DateTimePickerApertura.Enabled = false;
            this.DateTimePickerApertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerApertura.Location = new System.Drawing.Point(157, 23);
            this.DateTimePickerApertura.Margin = new System.Windows.Forms.Padding(2);
            this.DateTimePickerApertura.Name = "DateTimePickerApertura";
            this.DateTimePickerApertura.ShowUpDown = true;
            this.DateTimePickerApertura.Size = new System.Drawing.Size(135, 20);
            this.DateTimePickerApertura.TabIndex = 7;
            // 
            // LblSucursal
            // 
            this.LblSucursal.AutoSize = true;
            this.LblSucursal.Location = new System.Drawing.Point(17, 64);
            this.LblSucursal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSucursal.Name = "LblSucursal";
            this.LblSucursal.Size = new System.Drawing.Size(51, 13);
            this.LblSucursal.TabIndex = 8;
            this.LblSucursal.Text = "Sucursal:";
            // 
            // ComboSucursal
            // 
            this.ComboSucursal.Enabled = false;
            this.ComboSucursal.FormattingEnabled = true;
            this.ComboSucursal.Location = new System.Drawing.Point(157, 60);
            this.ComboSucursal.Margin = new System.Windows.Forms.Padding(2);
            this.ComboSucursal.Name = "ComboSucursal";
            this.ComboSucursal.Size = new System.Drawing.Size(135, 21);
            this.ComboSucursal.TabIndex = 9;
            // 
            // ComboCajas
            // 
            this.ComboCajas.FormattingEnabled = true;
            this.ComboCajas.Location = new System.Drawing.Point(157, 101);
            this.ComboCajas.Margin = new System.Windows.Forms.Padding(2);
            this.ComboCajas.Name = "ComboCajas";
            this.ComboCajas.Size = new System.Drawing.Size(135, 21);
            this.ComboCajas.TabIndex = 10;
            // 
            // LblCaja
            // 
            this.LblCaja.AutoSize = true;
            this.LblCaja.Location = new System.Drawing.Point(17, 105);
            this.LblCaja.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCaja.Name = "LblCaja";
            this.LblCaja.Size = new System.Drawing.Size(31, 13);
            this.LblCaja.TabIndex = 11;
            this.LblCaja.Text = "Caja:";
            // 
            // ImporteUpDown
            // 
            this.ImporteUpDown.Location = new System.Drawing.Point(157, 142);
            this.ImporteUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.ImporteUpDown.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.ImporteUpDown.Name = "ImporteUpDown";
            this.ImporteUpDown.Size = new System.Drawing.Size(135, 20);
            this.ImporteUpDown.TabIndex = 12;
            // 
            // LbLimporte
            // 
            this.LbLimporte.AutoSize = true;
            this.LbLimporte.Location = new System.Drawing.Point(17, 145);
            this.LbLimporte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbLimporte.Name = "LbLimporte";
            this.LbLimporte.Size = new System.Drawing.Size(45, 13);
            this.LbLimporte.TabIndex = 13;
            this.LbLimporte.Text = "Importe:";
            // 
            // ComboEstado
            // 
            this.ComboEstado.FormattingEnabled = true;
            this.ComboEstado.Items.AddRange(new object[] {
            "Abierto"});
            this.ComboEstado.Location = new System.Drawing.Point(439, 50);
            this.ComboEstado.Margin = new System.Windows.Forms.Padding(2);
            this.ComboEstado.Name = "ComboEstado";
            this.ComboEstado.Size = new System.Drawing.Size(168, 21);
            this.ComboEstado.TabIndex = 14;
            // 
            // LbLEstado
            // 
            this.LbLEstado.AutoSize = true;
            this.LbLEstado.Location = new System.Drawing.Point(436, 23);
            this.LbLEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbLEstado.Name = "LbLEstado";
            this.LbLEstado.Size = new System.Drawing.Size(43, 13);
            this.LbLEstado.TabIndex = 15;
            this.LbLEstado.Text = "Estado:";
            // 
            // LbLCajero
            // 
            this.LbLCajero.AutoSize = true;
            this.LbLCajero.ForeColor = System.Drawing.Color.Black;
            this.LbLCajero.Location = new System.Drawing.Point(437, 76);
            this.LbLCajero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbLCajero.Name = "LbLCajero";
            this.LbLCajero.Size = new System.Drawing.Size(40, 13);
            this.LbLCajero.TabIndex = 17;
            this.LbLCajero.Text = "Cajero:";
            // 
            // ComboCajero
            // 
            this.ComboCajero.FormattingEnabled = true;
            this.ComboCajero.Location = new System.Drawing.Point(440, 101);
            this.ComboCajero.Margin = new System.Windows.Forms.Padding(2);
            this.ComboCajero.Name = "ComboCajero";
            this.ComboCajero.Size = new System.Drawing.Size(168, 21);
            this.ComboCajero.TabIndex = 16;
            // 
            // DateTimePickerCierre
            // 
            this.DateTimePickerCierre.Enabled = false;
            this.DateTimePickerCierre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerCierre.Location = new System.Drawing.Point(157, 29);
            this.DateTimePickerCierre.Margin = new System.Windows.Forms.Padding(2);
            this.DateTimePickerCierre.Name = "DateTimePickerCierre";
            this.DateTimePickerCierre.Size = new System.Drawing.Size(135, 20);
            this.DateTimePickerCierre.TabIndex = 20;
            this.DateTimePickerCierre.Value = new System.DateTime(2023, 12, 17, 18, 58, 22, 0);
            // 
            // LbLFechaCierre
            // 
            this.LbLFechaCierre.AutoSize = true;
            this.LbLFechaCierre.Location = new System.Drawing.Point(17, 31);
            this.LbLFechaCierre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbLFechaCierre.Name = "LbLFechaCierre";
            this.LbLFechaCierre.Size = new System.Drawing.Size(70, 13);
            this.LbLFechaCierre.TabIndex = 19;
            this.LbLFechaCierre.Text = "Fecha Cierre:";
            // 
            // LbLimporteCierre
            // 
            this.LbLimporteCierre.AutoSize = true;
            this.LbLimporteCierre.Location = new System.Drawing.Point(17, 72);
            this.LbLimporteCierre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbLimporteCierre.Name = "LbLimporteCierre";
            this.LbLimporteCierre.Size = new System.Drawing.Size(45, 13);
            this.LbLimporteCierre.TabIndex = 22;
            this.LbLimporteCierre.Text = "Importe:";
            // 
            // UpDownMontoCierre
            // 
            this.UpDownMontoCierre.Location = new System.Drawing.Point(157, 65);
            this.UpDownMontoCierre.Margin = new System.Windows.Forms.Padding(2);
            this.UpDownMontoCierre.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.UpDownMontoCierre.Name = "UpDownMontoCierre";
            this.UpDownMontoCierre.Size = new System.Drawing.Size(135, 20);
            this.UpDownMontoCierre.TabIndex = 21;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Red;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.BtnSalir.IconColor = System.Drawing.Color.White;
            this.BtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSalir.IconSize = 18;
            this.BtnSalir.Location = new System.Drawing.Point(527, 427);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(136, 26);
            this.BtnSalir.TabIndex = 55;
            this.BtnSalir.Text = "Cancelar";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.BtnApertura);
            this.groupBox1.Controls.Add(this.LbLEstado);
            this.groupBox1.Controls.Add(this.ComboEstado);
            this.groupBox1.Controls.Add(this.ComboCajero);
            this.groupBox1.Controls.Add(this.LbLCajero);
            this.groupBox1.Controls.Add(this.LblFecha);
            this.groupBox1.Controls.Add(this.DateTimePickerApertura);
            this.groupBox1.Controls.Add(this.LblSucursal);
            this.groupBox1.Controls.Add(this.ComboSucursal);
            this.groupBox1.Controls.Add(this.LbLimporte);
            this.groupBox1.Controls.Add(this.ComboCajas);
            this.groupBox1.Controls.Add(this.ImporteUpDown);
            this.groupBox1.Controls.Add(this.LblCaja);
            this.groupBox1.Location = new System.Drawing.Point(8, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(669, 179);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apertura Caja";
            // 
            // BtnApertura
            // 
            this.BtnApertura.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnApertura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnApertura.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnApertura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApertura.ForeColor = System.Drawing.Color.White;
            this.BtnApertura.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BtnApertura.IconColor = System.Drawing.Color.White;
            this.BtnApertura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnApertura.IconSize = 16;
            this.BtnApertura.Location = new System.Drawing.Point(519, 142);
            this.BtnApertura.Margin = new System.Windows.Forms.Padding(2);
            this.BtnApertura.Name = "BtnApertura";
            this.BtnApertura.Size = new System.Drawing.Size(136, 27);
            this.BtnApertura.TabIndex = 55;
            this.BtnApertura.Text = "Aperturar Caja";
            this.BtnApertura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnApertura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnApertura.UseVisualStyleBackColor = false;
            this.BtnApertura.Click += new System.EventHandler(this.BtnApertura_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.BtnCerrarCaja);
            this.groupBox2.Controls.Add(this.LbLFechaCierre);
            this.groupBox2.Controls.Add(this.DateTimePickerCierre);
            this.groupBox2.Controls.Add(this.UpDownMontoCierre);
            this.groupBox2.Controls.Add(this.LbLimporteCierre);
            this.groupBox2.Location = new System.Drawing.Point(8, 251);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(669, 134);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cierre Caja";
            // 
            // BtnCerrarCaja
            // 
            this.BtnCerrarCaja.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCerrarCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrarCaja.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCerrarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarCaja.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarCaja.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.BtnCerrarCaja.IconColor = System.Drawing.Color.White;
            this.BtnCerrarCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCerrarCaja.IconSize = 16;
            this.BtnCerrarCaja.Location = new System.Drawing.Point(519, 98);
            this.BtnCerrarCaja.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCerrarCaja.Name = "BtnCerrarCaja";
            this.BtnCerrarCaja.Size = new System.Drawing.Size(136, 27);
            this.BtnCerrarCaja.TabIndex = 55;
            this.BtnCerrarCaja.Text = "Cerrar Caja";
            this.BtnCerrarCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCerrarCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCerrarCaja.UseVisualStyleBackColor = false;
            this.BtnCerrarCaja.Click += new System.EventHandler(this.BtnCerrarCaja_Click);
            // 
            // LblDetalleAperturaCierre
            // 
            this.LblDetalleAperturaCierre.AutoSize = true;
            this.LblDetalleAperturaCierre.BackColor = System.Drawing.Color.White;
            this.LblDetalleAperturaCierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDetalleAperturaCierre.Location = new System.Drawing.Point(4, 9);
            this.LblDetalleAperturaCierre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDetalleAperturaCierre.Name = "LblDetalleAperturaCierre";
            this.LblDetalleAperturaCierre.Size = new System.Drawing.Size(183, 20);
            this.LblDetalleAperturaCierre.TabIndex = 75;
            this.LblDetalleAperturaCierre.Text = "Apertura / Cierre de Caja";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.BtnGuardar.IconColor = System.Drawing.Color.White;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.IconSize = 16;
            this.BtnGuardar.Location = new System.Drawing.Point(319, 427);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(142, 27);
            this.BtnGuardar.TabIndex = 95;
            this.BtnGuardar.Text = "Rendición Caja";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FrmAperturaCierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 475);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblDetalleAperturaCierre);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.LblUsuariosAgregar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAperturaCierreCaja";
            this.Text = "Apertura / Cierre ";
            this.Load += new System.EventHandler(this.FrmAperturaCierreCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImporteUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMontoCierre)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUsuariosAgregar;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.DateTimePicker DateTimePickerApertura;
        private System.Windows.Forms.Label LblSucursal;
        private System.Windows.Forms.ComboBox ComboSucursal;
        private System.Windows.Forms.ComboBox ComboCajas;
        private System.Windows.Forms.Label LblCaja;
        private System.Windows.Forms.NumericUpDown ImporteUpDown;
        private System.Windows.Forms.Label LbLimporte;
        private System.Windows.Forms.ComboBox ComboEstado;
        private System.Windows.Forms.Label LbLEstado;
        private System.Windows.Forms.Label LbLCajero;
        private System.Windows.Forms.ComboBox ComboCajero;
        private System.Windows.Forms.DateTimePicker DateTimePickerCierre;
        private System.Windows.Forms.Label LbLFechaCierre;
        private System.Windows.Forms.Label LbLimporteCierre;
        private System.Windows.Forms.NumericUpDown UpDownMontoCierre;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton BtnApertura;
        private FontAwesome.Sharp.IconButton BtnCerrarCaja;
        private System.Windows.Forms.Label LblDetalleAperturaCierre;
        private FontAwesome.Sharp.IconButton BtnGuardar;
    }
}
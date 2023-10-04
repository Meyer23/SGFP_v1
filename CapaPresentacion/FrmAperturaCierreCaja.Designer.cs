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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbLApertura = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.DateTimePickerApertura = new System.Windows.Forms.DateTimePicker();
            this.LblSucursal = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.LblCaja = new System.Windows.Forms.Label();
            this.ImporteUpDown = new System.Windows.Forms.NumericUpDown();
            this.LbLimporte = new System.Windows.Forms.Label();
            this.ComboEstado = new System.Windows.Forms.ComboBox();
            this.LbLEstado = new System.Windows.Forms.Label();
            this.LbLCajero = new System.Windows.Forms.Label();
            this.ComboCajero = new System.Windows.Forms.ComboBox();
            this.PanelCierre = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTimePickerCierre = new System.Windows.Forms.DateTimePicker();
            this.LbLFechaCierre = new System.Windows.Forms.Label();
            this.LbLimporteCierre = new System.Windows.Forms.Label();
            this.UpDownMontoCierre = new System.Windows.Forms.NumericUpDown();
            this.BtnSalir = new FontAwesome.Sharp.IconButton();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImporteUpDown)).BeginInit();
            this.PanelCierre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMontoCierre)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUsuariosAgregar
            // 
            this.LblUsuariosAgregar.BackColor = System.Drawing.Color.White;
            this.LblUsuariosAgregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblUsuariosAgregar.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblUsuariosAgregar.Location = new System.Drawing.Point(0, 0);
            this.LblUsuariosAgregar.Name = "LblUsuariosAgregar";
            this.LblUsuariosAgregar.Size = new System.Drawing.Size(1125, 553);
            this.LblUsuariosAgregar.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LbLApertura);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 49);
            this.panel1.TabIndex = 4;
            // 
            // LbLApertura
            // 
            this.LbLApertura.AutoSize = true;
            this.LbLApertura.Location = new System.Drawing.Point(3, 18);
            this.LbLApertura.Name = "LbLApertura";
            this.LbLApertura.Size = new System.Drawing.Size(107, 20);
            this.LbLApertura.TabIndex = 5;
            this.LbLApertura.Text = "Apertura Caja";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(15, 116);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(124, 20);
            this.LblFecha.TabIndex = 6;
            this.LblFecha.Text = "Fecha Apertura:";
            // 
            // DateTimePickerApertura
            // 
            this.DateTimePickerApertura.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerApertura.Location = new System.Drawing.Point(157, 110);
            this.DateTimePickerApertura.Name = "DateTimePickerApertura";
            this.DateTimePickerApertura.Size = new System.Drawing.Size(200, 26);
            this.DateTimePickerApertura.TabIndex = 7;
            // 
            // LblSucursal
            // 
            this.LblSucursal.AutoSize = true;
            this.LblSucursal.Location = new System.Drawing.Point(15, 167);
            this.LblSucursal.Name = "LblSucursal";
            this.LblSucursal.Size = new System.Drawing.Size(75, 20);
            this.LblSucursal.TabIndex = 8;
            this.LblSucursal.Text = "Sucursal:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(157, 159);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(157, 210);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 28);
            this.comboBox2.TabIndex = 10;
            // 
            // LblCaja
            // 
            this.LblCaja.AutoSize = true;
            this.LblCaja.Location = new System.Drawing.Point(15, 218);
            this.LblCaja.Name = "LblCaja";
            this.LblCaja.Size = new System.Drawing.Size(45, 20);
            this.LblCaja.TabIndex = 11;
            this.LblCaja.Text = "Caja:";
            // 
            // ImporteUpDown
            // 
            this.ImporteUpDown.Location = new System.Drawing.Point(157, 255);
            this.ImporteUpDown.Name = "ImporteUpDown";
            this.ImporteUpDown.Size = new System.Drawing.Size(200, 26);
            this.ImporteUpDown.TabIndex = 12;
            // 
            // LbLimporte
            // 
            this.LbLimporte.AutoSize = true;
            this.LbLimporte.Location = new System.Drawing.Point(15, 261);
            this.LbLimporte.Name = "LbLimporte";
            this.LbLimporte.Size = new System.Drawing.Size(68, 20);
            this.LbLimporte.TabIndex = 13;
            this.LbLimporte.Text = "Importe:";
            // 
            // ComboEstado
            // 
            this.ComboEstado.FormattingEnabled = true;
            this.ComboEstado.Location = new System.Drawing.Point(641, 108);
            this.ComboEstado.Name = "ComboEstado";
            this.ComboEstado.Size = new System.Drawing.Size(200, 28);
            this.ComboEstado.TabIndex = 14;
            // 
            // LbLEstado
            // 
            this.LbLEstado.AutoSize = true;
            this.LbLEstado.Location = new System.Drawing.Point(557, 116);
            this.LbLEstado.Name = "LbLEstado";
            this.LbLEstado.Size = new System.Drawing.Size(64, 20);
            this.LbLEstado.TabIndex = 15;
            this.LbLEstado.Text = "Estado:";
            // 
            // LbLCajero
            // 
            this.LbLCajero.AutoSize = true;
            this.LbLCajero.Location = new System.Drawing.Point(557, 167);
            this.LbLCajero.Name = "LbLCajero";
            this.LbLCajero.Size = new System.Drawing.Size(59, 20);
            this.LbLCajero.TabIndex = 17;
            this.LbLCajero.Text = "Cajero:";
            // 
            // ComboCajero
            // 
            this.ComboCajero.FormattingEnabled = true;
            this.ComboCajero.Location = new System.Drawing.Point(641, 159);
            this.ComboCajero.Name = "ComboCajero";
            this.ComboCajero.Size = new System.Drawing.Size(200, 28);
            this.ComboCajero.TabIndex = 16;
            // 
            // PanelCierre
            // 
            this.PanelCierre.Controls.Add(this.label1);
            this.PanelCierre.Location = new System.Drawing.Point(12, 316);
            this.PanelCierre.Name = "PanelCierre";
            this.PanelCierre.Size = new System.Drawing.Size(1110, 49);
            this.PanelCierre.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cierre Caja";
            // 
            // DateTimePickerCierre
            // 
            this.DateTimePickerCierre.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerCierre.Location = new System.Drawing.Point(154, 389);
            this.DateTimePickerCierre.Name = "DateTimePickerCierre";
            this.DateTimePickerCierre.Size = new System.Drawing.Size(200, 26);
            this.DateTimePickerCierre.TabIndex = 20;
            // 
            // LbLFechaCierre
            // 
            this.LbLFechaCierre.AutoSize = true;
            this.LbLFechaCierre.Location = new System.Drawing.Point(12, 395);
            this.LbLFechaCierre.Name = "LbLFechaCierre";
            this.LbLFechaCierre.Size = new System.Drawing.Size(104, 20);
            this.LbLFechaCierre.TabIndex = 19;
            this.LbLFechaCierre.Text = "Fecha Cierre:";
            // 
            // LbLimporteCierre
            // 
            this.LbLimporteCierre.AutoSize = true;
            this.LbLimporteCierre.Location = new System.Drawing.Point(15, 448);
            this.LbLimporteCierre.Name = "LbLimporteCierre";
            this.LbLimporteCierre.Size = new System.Drawing.Size(68, 20);
            this.LbLimporteCierre.TabIndex = 22;
            this.LbLimporteCierre.Text = "Importe:";
            // 
            // UpDownMontoCierre
            // 
            this.UpDownMontoCierre.Location = new System.Drawing.Point(157, 442);
            this.UpDownMontoCierre.Name = "UpDownMontoCierre";
            this.UpDownMontoCierre.Size = new System.Drawing.Size(200, 26);
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
            this.BtnSalir.Location = new System.Drawing.Point(954, 501);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(150, 40);
            this.BtnSalir.TabIndex = 55;
            this.BtnSalir.Text = "Cancelar";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSalir.UseVisualStyleBackColor = false;
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
            this.BtnGuardar.Location = new System.Drawing.Point(786, 499);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(150, 42);
            this.BtnGuardar.TabIndex = 54;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // AperturaCierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 553);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LbLimporteCierre);
            this.Controls.Add(this.UpDownMontoCierre);
            this.Controls.Add(this.DateTimePickerCierre);
            this.Controls.Add(this.LbLFechaCierre);
            this.Controls.Add(this.PanelCierre);
            this.Controls.Add(this.LbLCajero);
            this.Controls.Add(this.ComboCajero);
            this.Controls.Add(this.LbLEstado);
            this.Controls.Add(this.ComboEstado);
            this.Controls.Add(this.LbLimporte);
            this.Controls.Add(this.ImporteUpDown);
            this.Controls.Add(this.LblCaja);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LblSucursal);
            this.Controls.Add(this.DateTimePickerApertura);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblUsuariosAgregar);
            this.Name = "AperturaCierreCaja";
            this.Text = "Apertura / Cierre ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImporteUpDown)).EndInit();
            this.PanelCierre.ResumeLayout(false);
            this.PanelCierre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMontoCierre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUsuariosAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbLApertura;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.DateTimePicker DateTimePickerApertura;
        private System.Windows.Forms.Label LblSucursal;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label LblCaja;
        private System.Windows.Forms.NumericUpDown ImporteUpDown;
        private System.Windows.Forms.Label LbLimporte;
        private System.Windows.Forms.ComboBox ComboEstado;
        private System.Windows.Forms.Label LbLEstado;
        private System.Windows.Forms.Label LbLCajero;
        private System.Windows.Forms.ComboBox ComboCajero;
        private System.Windows.Forms.Panel PanelCierre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateTimePickerCierre;
        private System.Windows.Forms.Label LbLFechaCierre;
        private System.Windows.Forms.Label LbLimporteCierre;
        private System.Windows.Forms.NumericUpDown UpDownMontoCierre;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private FontAwesome.Sharp.IconButton BtnGuardar;
    }
}
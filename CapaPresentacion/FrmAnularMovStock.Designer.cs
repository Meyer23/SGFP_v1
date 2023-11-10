namespace CapaPresentacion
{
    partial class FrmAnularMovStock
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
            this.TxtIdMovStock = new System.Windows.Forms.TextBox();
            this.TxtTotalCantidad = new System.Windows.Forms.TextBox();
            this.LblTotalCantidad = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.LblFecha = new System.Windows.Forms.Label();
            this.TxtTipoMovimiento = new System.Windows.Forms.TextBox();
            this.LblTipoMovimiento = new System.Windows.Forms.Label();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.LblDocumento = new System.Windows.Forms.Label();
            this.LblConfirmarPedido = new System.Windows.Forms.Label();
            this.BtnAnular = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // TxtIdMovStock
            // 
            this.TxtIdMovStock.Location = new System.Drawing.Point(131, 59);
            this.TxtIdMovStock.Name = "TxtIdMovStock";
            this.TxtIdMovStock.Size = new System.Drawing.Size(26, 20);
            this.TxtIdMovStock.TabIndex = 127;
            this.TxtIdMovStock.Text = "0";
            // 
            // TxtTotalCantidad
            // 
            this.TxtTotalCantidad.Location = new System.Drawing.Point(15, 136);
            this.TxtTotalCantidad.Name = "TxtTotalCantidad";
            this.TxtTotalCantidad.ReadOnly = true;
            this.TxtTotalCantidad.Size = new System.Drawing.Size(142, 20);
            this.TxtTotalCantidad.TabIndex = 125;
            this.TxtTotalCantidad.Text = "0";
            // 
            // LblTotalCantidad
            // 
            this.LblTotalCantidad.AutoSize = true;
            this.LblTotalCantidad.BackColor = System.Drawing.Color.White;
            this.LblTotalCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalCantidad.Location = new System.Drawing.Point(12, 120);
            this.LblTotalCantidad.Name = "LblTotalCantidad";
            this.LblTotalCantidad.Size = new System.Drawing.Size(76, 13);
            this.LblTotalCantidad.TabIndex = 124;
            this.LblTotalCantidad.Text = "Total Cantidad";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(15, 59);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(97, 20);
            this.dtpFecha.TabIndex = 123;
            this.dtpFecha.Value = new System.DateTime(2023, 10, 15, 0, 0, 0, 0);
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.BackColor = System.Drawing.Color.White;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(12, 43);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(40, 13);
            this.LblFecha.TabIndex = 122;
            this.LblFecha.Text = "Fecha:";
            // 
            // TxtTipoMovimiento
            // 
            this.TxtTipoMovimiento.Location = new System.Drawing.Point(15, 97);
            this.TxtTipoMovimiento.Name = "TxtTipoMovimiento";
            this.TxtTipoMovimiento.ReadOnly = true;
            this.TxtTipoMovimiento.Size = new System.Drawing.Size(223, 20);
            this.TxtTipoMovimiento.TabIndex = 121;
            // 
            // LblTipoMovimiento
            // 
            this.LblTipoMovimiento.AutoSize = true;
            this.LblTipoMovimiento.BackColor = System.Drawing.Color.White;
            this.LblTipoMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoMovimiento.Location = new System.Drawing.Point(12, 82);
            this.LblTipoMovimiento.Name = "LblTipoMovimiento";
            this.LblTipoMovimiento.Size = new System.Drawing.Size(88, 13);
            this.LblTipoMovimiento.TabIndex = 120;
            this.LblTipoMovimiento.Text = "Tipo Movimiento:";
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
            this.BtnLimpiar.Location = new System.Drawing.Point(308, 12);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(43, 26);
            this.BtnLimpiar.TabIndex = 119;
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
            this.BtnBuscar.Location = new System.Drawing.Point(261, 12);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(43, 26);
            this.BtnBuscar.TabIndex = 118;
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(101, 16);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(155, 20);
            this.TxtBusqueda.TabIndex = 116;
            // 
            // LblDocumento
            // 
            this.LblDocumento.AutoSize = true;
            this.LblDocumento.BackColor = System.Drawing.Color.White;
            this.LblDocumento.Location = new System.Drawing.Point(12, 19);
            this.LblDocumento.Name = "LblDocumento";
            this.LblDocumento.Size = new System.Drawing.Size(65, 13);
            this.LblDocumento.TabIndex = 117;
            this.LblDocumento.Text = "Documento:";
            // 
            // LblConfirmarPedido
            // 
            this.LblConfirmarPedido.BackColor = System.Drawing.Color.White;
            this.LblConfirmarPedido.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblConfirmarPedido.Location = new System.Drawing.Point(0, 0);
            this.LblConfirmarPedido.Name = "LblConfirmarPedido";
            this.LblConfirmarPedido.Size = new System.Drawing.Size(355, 217);
            this.LblConfirmarPedido.TabIndex = 115;
            // 
            // BtnAnular
            // 
            this.BtnAnular.BackColor = System.Drawing.Color.Firebrick;
            this.BtnAnular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAnular.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnular.ForeColor = System.Drawing.Color.White;
            this.BtnAnular.IconChar = FontAwesome.Sharp.IconChar.X;
            this.BtnAnular.IconColor = System.Drawing.Color.White;
            this.BtnAnular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAnular.IconSize = 16;
            this.BtnAnular.Location = new System.Drawing.Point(222, 168);
            this.BtnAnular.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAnular.Name = "BtnAnular";
            this.BtnAnular.Size = new System.Drawing.Size(125, 27);
            this.BtnAnular.TabIndex = 128;
            this.BtnAnular.Text = "Anular";
            this.BtnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAnular.UseVisualStyleBackColor = false;
            this.BtnAnular.Click += new System.EventHandler(this.BtnAnular_Click);
            // 
            // FrmAnularMovStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 217);
            this.Controls.Add(this.BtnAnular);
            this.Controls.Add(this.TxtIdMovStock);
            this.Controls.Add(this.TxtTotalCantidad);
            this.Controls.Add(this.LblTotalCantidad);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.TxtTipoMovimiento);
            this.Controls.Add(this.LblTipoMovimiento);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.LblDocumento);
            this.Controls.Add(this.LblConfirmarPedido);
            this.Name = "FrmAnularMovStock";
            this.Text = "Anular Movimientos Stock";
            this.Load += new System.EventHandler(this.FrmAnularMovStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIdMovStock;
        private System.Windows.Forms.TextBox TxtTotalCantidad;
        private System.Windows.Forms.Label LblTotalCantidad;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.TextBox TxtTipoMovimiento;
        private System.Windows.Forms.Label LblTipoMovimiento;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Label LblDocumento;
        private System.Windows.Forms.Label LblConfirmarPedido;
        private FontAwesome.Sharp.IconButton BtnAnular;
    }
}
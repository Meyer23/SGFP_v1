namespace CapaPresentacion
{
    partial class FrmAnularCompra
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
            this.TxtIdCompra = new System.Windows.Forms.TextBox();
            this.BtnAnular = new FontAwesome.Sharp.IconButton();
            this.TxtTotalCompra = new System.Windows.Forms.TextBox();
            this.LblTotalCompra = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.LblFecha = new System.Windows.Forms.Label();
            this.TxtProveedor = new System.Windows.Forms.TextBox();
            this.LblProveedor = new System.Windows.Forms.Label();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.LblNroPedido = new System.Windows.Forms.Label();
            this.LblConfirmarPedido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtIdCompra
            // 
            this.TxtIdCompra.Location = new System.Drawing.Point(128, 55);
            this.TxtIdCompra.Name = "TxtIdCompra";
            this.TxtIdCompra.Size = new System.Drawing.Size(26, 20);
            this.TxtIdCompra.TabIndex = 127;
            this.TxtIdCompra.Text = "0";
            this.TxtIdCompra.Visible = false;
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
            this.BtnAnular.Location = new System.Drawing.Point(186, 173);
            this.BtnAnular.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAnular.Name = "BtnAnular";
            this.BtnAnular.Size = new System.Drawing.Size(125, 27);
            this.BtnAnular.TabIndex = 126;
            this.BtnAnular.Text = "Anular";
            this.BtnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAnular.UseVisualStyleBackColor = false;
            this.BtnAnular.Click += new System.EventHandler(this.BtnAnular_Click);
            // 
            // TxtTotalCompra
            // 
            this.TxtTotalCompra.Location = new System.Drawing.Point(12, 132);
            this.TxtTotalCompra.Name = "TxtTotalCompra";
            this.TxtTotalCompra.ReadOnly = true;
            this.TxtTotalCompra.Size = new System.Drawing.Size(142, 20);
            this.TxtTotalCompra.TabIndex = 125;
            this.TxtTotalCompra.Text = "0";
            // 
            // LblTotalCompra
            // 
            this.LblTotalCompra.AutoSize = true;
            this.LblTotalCompra.BackColor = System.Drawing.Color.White;
            this.LblTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalCompra.Location = new System.Drawing.Point(9, 116);
            this.LblTotalCompra.Name = "LblTotalCompra";
            this.LblTotalCompra.Size = new System.Drawing.Size(70, 13);
            this.LblTotalCompra.TabIndex = 124;
            this.LblTotalCompra.Text = "Total Compra";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(12, 55);
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
            this.LblFecha.Location = new System.Drawing.Point(9, 39);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(37, 13);
            this.LblFecha.TabIndex = 122;
            this.LblFecha.Text = "Fecha";
            // 
            // TxtProveedor
            // 
            this.TxtProveedor.Location = new System.Drawing.Point(12, 93);
            this.TxtProveedor.Name = "TxtProveedor";
            this.TxtProveedor.ReadOnly = true;
            this.TxtProveedor.Size = new System.Drawing.Size(223, 20);
            this.TxtProveedor.TabIndex = 121;
            // 
            // LblProveedor
            // 
            this.LblProveedor.AutoSize = true;
            this.LblProveedor.BackColor = System.Drawing.Color.White;
            this.LblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProveedor.Location = new System.Drawing.Point(9, 78);
            this.LblProveedor.Name = "LblProveedor";
            this.LblProveedor.Size = new System.Drawing.Size(56, 13);
            this.LblProveedor.TabIndex = 120;
            this.LblProveedor.Text = "Proveedor";
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
            this.BtnLimpiar.Location = new System.Drawing.Point(268, 8);
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
            this.BtnBuscar.Location = new System.Drawing.Point(221, 8);
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
            this.TxtBusqueda.Location = new System.Drawing.Point(61, 12);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(155, 20);
            this.TxtBusqueda.TabIndex = 116;
            // 
            // LblNroPedido
            // 
            this.LblNroPedido.AutoSize = true;
            this.LblNroPedido.BackColor = System.Drawing.Color.White;
            this.LblNroPedido.Location = new System.Drawing.Point(9, 15);
            this.LblNroPedido.Name = "LblNroPedido";
            this.LblNroPedido.Size = new System.Drawing.Size(46, 13);
            this.LblNroPedido.TabIndex = 117;
            this.LblNroPedido.Text = "Factura:";
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
            // FrmAnularCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 217);
            this.Controls.Add(this.TxtIdCompra);
            this.Controls.Add(this.BtnAnular);
            this.Controls.Add(this.TxtTotalCompra);
            this.Controls.Add(this.LblTotalCompra);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.TxtProveedor);
            this.Controls.Add(this.LblProveedor);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.LblNroPedido);
            this.Controls.Add(this.LblConfirmarPedido);
            this.Name = "FrmAnularCompra";
            this.Text = "Anular Compra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIdCompra;
        private FontAwesome.Sharp.IconButton BtnAnular;
        private System.Windows.Forms.TextBox TxtTotalCompra;
        private System.Windows.Forms.Label LblTotalCompra;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.TextBox TxtProveedor;
        private System.Windows.Forms.Label LblProveedor;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Label LblNroPedido;
        private System.Windows.Forms.Label LblConfirmarPedido;
    }
}
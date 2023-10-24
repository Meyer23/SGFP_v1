namespace CapaPresentacion
{
    partial class FrmConfirmarPedido
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
            this.LblConfirmarPedido = new System.Windows.Forms.Label();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.LblNroPedido = new System.Windows.Forms.Label();
            this.TxtProveedor = new System.Windows.Forms.TextBox();
            this.LblProveedor = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.LblFecha = new System.Windows.Forms.Label();
            this.TxtTotalPedido = new System.Windows.Forms.TextBox();
            this.LblTotalCompra = new System.Windows.Forms.Label();
            this.BtnConfirmar = new FontAwesome.Sharp.IconButton();
            this.TxtNumeroPedido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblConfirmarPedido
            // 
            this.LblConfirmarPedido.BackColor = System.Drawing.Color.White;
            this.LblConfirmarPedido.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblConfirmarPedido.Location = new System.Drawing.Point(0, 0);
            this.LblConfirmarPedido.Name = "LblConfirmarPedido";
            this.LblConfirmarPedido.Size = new System.Drawing.Size(355, 206);
            this.LblConfirmarPedido.TabIndex = 86;
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
            this.BtnLimpiar.Location = new System.Drawing.Point(308, 17);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(43, 26);
            this.BtnLimpiar.TabIndex = 93;
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
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
            this.BtnBuscar.Location = new System.Drawing.Point(261, 17);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(43, 26);
            this.BtnBuscar.TabIndex = 92;
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(101, 21);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(155, 20);
            this.TxtBusqueda.TabIndex = 90;
            // 
            // LblNroPedido
            // 
            this.LblNroPedido.AutoSize = true;
            this.LblNroPedido.BackColor = System.Drawing.Color.White;
            this.LblNroPedido.Location = new System.Drawing.Point(12, 24);
            this.LblNroPedido.Name = "LblNroPedido";
            this.LblNroPedido.Size = new System.Drawing.Size(83, 13);
            this.LblNroPedido.TabIndex = 91;
            this.LblNroPedido.Text = "Número Pedido:";
            // 
            // TxtProveedor
            // 
            this.TxtProveedor.Location = new System.Drawing.Point(15, 102);
            this.TxtProveedor.Name = "TxtProveedor";
            this.TxtProveedor.ReadOnly = true;
            this.TxtProveedor.Size = new System.Drawing.Size(223, 20);
            this.TxtProveedor.TabIndex = 95;
            // 
            // LblProveedor
            // 
            this.LblProveedor.AutoSize = true;
            this.LblProveedor.BackColor = System.Drawing.Color.White;
            this.LblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProveedor.Location = new System.Drawing.Point(12, 87);
            this.LblProveedor.Name = "LblProveedor";
            this.LblProveedor.Size = new System.Drawing.Size(59, 13);
            this.LblProveedor.TabIndex = 94;
            this.LblProveedor.Text = "Proveedor:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(15, 64);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(97, 20);
            this.dtpFecha.TabIndex = 97;
            this.dtpFecha.Value = new System.DateTime(2023, 10, 15, 0, 0, 0, 0);
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.BackColor = System.Drawing.Color.White;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(12, 48);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(40, 13);
            this.LblFecha.TabIndex = 96;
            this.LblFecha.Text = "Fecha:";
            // 
            // TxtTotalPedido
            // 
            this.TxtTotalPedido.Location = new System.Drawing.Point(15, 141);
            this.TxtTotalPedido.Name = "TxtTotalPedido";
            this.TxtTotalPedido.ReadOnly = true;
            this.TxtTotalPedido.Size = new System.Drawing.Size(142, 20);
            this.TxtTotalPedido.TabIndex = 99;
            this.TxtTotalPedido.Text = "0";
            // 
            // LblTotalCompra
            // 
            this.LblTotalCompra.AutoSize = true;
            this.LblTotalCompra.BackColor = System.Drawing.Color.White;
            this.LblTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalCompra.Location = new System.Drawing.Point(12, 125);
            this.LblTotalCompra.Name = "LblTotalCompra";
            this.LblTotalCompra.Size = new System.Drawing.Size(67, 13);
            this.LblTotalCompra.TabIndex = 98;
            this.LblTotalCompra.Text = "Total Pedido";
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnConfirmar.IconColor = System.Drawing.Color.White;
            this.BtnConfirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConfirmar.IconSize = 16;
            this.BtnConfirmar.Location = new System.Drawing.Point(226, 169);
            this.BtnConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(125, 27);
            this.BtnConfirmar.TabIndex = 100;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // TxtNumeroPedido
            // 
            this.TxtNumeroPedido.Location = new System.Drawing.Point(131, 64);
            this.TxtNumeroPedido.Name = "TxtNumeroPedido";
            this.TxtNumeroPedido.Size = new System.Drawing.Size(26, 20);
            this.TxtNumeroPedido.TabIndex = 101;
            this.TxtNumeroPedido.Visible = false;
            // 
            // FrmConfirmarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 206);
            this.Controls.Add(this.TxtNumeroPedido);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.TxtTotalPedido);
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
            this.Name = "FrmConfirmarPedido";
            this.Text = "Confirmar Pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblConfirmarPedido;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Label LblNroPedido;
        private System.Windows.Forms.TextBox TxtProveedor;
        private System.Windows.Forms.Label LblProveedor;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.TextBox TxtTotalPedido;
        private System.Windows.Forms.Label LblTotalCompra;
        private FontAwesome.Sharp.IconButton BtnConfirmar;
        private System.Windows.Forms.TextBox TxtNumeroPedido;
    }
}
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TxtImporte = new System.Windows.Forms.TextBox();
            this.TxtVuelto = new System.Windows.Forms.TextBox();
            this.LblVuelto = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.LblDetalleCobro = new System.Windows.Forms.Label();
            this.idCobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteVuelto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCompras
            // 
            this.LblCompras.BackColor = System.Drawing.Color.White;
            this.LblCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCompras.Location = new System.Drawing.Point(12, 9);
            this.LblCompras.Name = "LblCompras";
            this.LblCompras.Padding = new System.Windows.Forms.Padding(3);
            this.LblCompras.Size = new System.Drawing.Size(1212, 726);
            this.LblCompras.TabIndex = 53;
            this.LblCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblTipoValor
            // 
            this.LblTipoValor.AutoSize = true;
            this.LblTipoValor.BackColor = System.Drawing.Color.White;
            this.LblTipoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoValor.Location = new System.Drawing.Point(32, 51);
            this.LblTipoValor.Name = "LblTipoValor";
            this.LblTipoValor.Size = new System.Drawing.Size(108, 25);
            this.LblTipoValor.TabIndex = 54;
            this.LblTipoValor.Text = "Tipo Valor:";
            // 
            // LblNroCuenta
            // 
            this.LblNroCuenta.AutoSize = true;
            this.LblNroCuenta.BackColor = System.Drawing.Color.White;
            this.LblNroCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNroCuenta.Location = new System.Drawing.Point(546, 51);
            this.LblNroCuenta.Name = "LblNroCuenta";
            this.LblNroCuenta.Size = new System.Drawing.Size(123, 25);
            this.LblNroCuenta.TabIndex = 55;
            this.LblNroCuenta.Text = "Nro. Cuenta:";
            // 
            // LblImporte
            // 
            this.LblImporte.AutoSize = true;
            this.LblImporte.BackColor = System.Drawing.Color.White;
            this.LblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImporte.Location = new System.Drawing.Point(279, 139);
            this.LblImporte.Name = "LblImporte";
            this.LblImporte.Size = new System.Drawing.Size(83, 25);
            this.LblImporte.TabIndex = 56;
            this.LblImporte.Text = "Importe:";
            // 
            // LblBanco
            // 
            this.LblBanco.AutoSize = true;
            this.LblBanco.BackColor = System.Drawing.Color.White;
            this.LblBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBanco.Location = new System.Drawing.Point(279, 51);
            this.LblBanco.Name = "LblBanco";
            this.LblBanco.Size = new System.Drawing.Size(74, 25);
            this.LblBanco.TabIndex = 57;
            this.LblBanco.Text = "Banco:";
            // 
            // LblNroDocumento
            // 
            this.LblNroDocumento.AutoSize = true;
            this.LblNroDocumento.BackColor = System.Drawing.Color.White;
            this.LblNroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNroDocumento.Location = new System.Drawing.Point(32, 139);
            this.LblNroDocumento.Name = "LblNroDocumento";
            this.LblNroDocumento.Size = new System.Drawing.Size(159, 25);
            this.LblNroDocumento.TabIndex = 58;
            this.LblNroDocumento.Text = "Nro. Documento:";
            // 
            // ComboTipoValor
            // 
            this.ComboTipoValor.FormattingEnabled = true;
            this.ComboTipoValor.Location = new System.Drawing.Point(37, 88);
            this.ComboTipoValor.Name = "ComboTipoValor";
            this.ComboTipoValor.Size = new System.Drawing.Size(162, 28);
            this.ComboTipoValor.TabIndex = 59;
            // 
            // ComboBanco
            // 
            this.ComboBanco.FormattingEnabled = true;
            this.ComboBanco.Location = new System.Drawing.Point(284, 88);
            this.ComboBanco.Name = "ComboBanco";
            this.ComboBanco.Size = new System.Drawing.Size(162, 28);
            this.ComboBanco.TabIndex = 60;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(551, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 26);
            this.textBox1.TabIndex = 61;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(39, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 26);
            this.textBox2.TabIndex = 62;
            // 
            // TxtImporte
            // 
            this.TxtImporte.Location = new System.Drawing.Point(286, 177);
            this.TxtImporte.Name = "TxtImporte";
            this.TxtImporte.Size = new System.Drawing.Size(160, 26);
            this.TxtImporte.TabIndex = 63;
            // 
            // TxtVuelto
            // 
            this.TxtVuelto.Location = new System.Drawing.Point(545, 177);
            this.TxtVuelto.Name = "TxtVuelto";
            this.TxtVuelto.Size = new System.Drawing.Size(160, 26);
            this.TxtVuelto.TabIndex = 65;
            // 
            // LblVuelto
            // 
            this.LblVuelto.AutoSize = true;
            this.LblVuelto.BackColor = System.Drawing.Color.White;
            this.LblVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVuelto.Location = new System.Drawing.Point(546, 139);
            this.LblVuelto.Name = "LblVuelto";
            this.LblVuelto.Size = new System.Drawing.Size(74, 25);
            this.LblVuelto.TabIndex = 64;
            this.LblVuelto.Text = "Vuelto:";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCobro,
            this.TipoValor,
            this.Banco,
            this.NroCuenta,
            this.NroDocumento,
            this.Importe,
            this.ImporteVuelto,
            this.BtnEliminar});
            this.dgvData.Location = new System.Drawing.Point(37, 291);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.Size = new System.Drawing.Size(1145, 290);
            this.dgvData.TabIndex = 66;
            // 
            // LblDetalleCobro
            // 
            this.LblDetalleCobro.AutoSize = true;
            this.LblDetalleCobro.BackColor = System.Drawing.Color.White;
            this.LblDetalleCobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDetalleCobro.Location = new System.Drawing.Point(33, 236);
            this.LblDetalleCobro.Name = "LblDetalleCobro";
            this.LblDetalleCobro.Size = new System.Drawing.Size(237, 36);
            this.LblDetalleCobro.TabIndex = 67;
            this.LblDetalleCobro.Text = "Detalle de Cobro";
            // 
            // idCobro
            // 
            this.idCobro.HeaderText = "idDetalleCobro";
            this.idCobro.MinimumWidth = 8;
            this.idCobro.Name = "idCobro";
            this.idCobro.ReadOnly = true;
            this.idCobro.Visible = false;
            this.idCobro.Width = 150;
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
            // BtnEliminar
            // 
            this.BtnEliminar.HeaderText = "";
            this.BtnEliminar.MinimumWidth = 8;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.ReadOnly = true;
            this.BtnEliminar.Width = 30;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.BtnCancelar.IconColor = System.Drawing.Color.Black;
            this.BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancelar.Location = new System.Drawing.Point(929, 602);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(253, 79);
            this.BtnCancelar.TabIndex = 68;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // PopUpDetalleCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 754);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.LblDetalleCobro);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.TxtVuelto);
            this.Controls.Add(this.LblVuelto);
            this.Controls.Add(this.TxtImporte);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ComboBanco);
            this.Controls.Add(this.ComboTipoValor);
            this.Controls.Add(this.LblNroDocumento);
            this.Controls.Add(this.LblBanco);
            this.Controls.Add(this.LblImporte);
            this.Controls.Add(this.LblNroCuenta);
            this.Controls.Add(this.LblTipoValor);
            this.Controls.Add(this.LblCompras);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TxtImporte;
        private System.Windows.Forms.TextBox TxtVuelto;
        private System.Windows.Forms.Label LblVuelto;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label LblDetalleCobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteVuelto;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
    }
}
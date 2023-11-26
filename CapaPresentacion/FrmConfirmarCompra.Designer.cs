namespace CapaPresentacion
{
    partial class FrmConfirmarCompra
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
            this.BtnConfirmar = new FontAwesome.Sharp.IconButton();
            this.LblFechaRec = new System.Windows.Forms.Label();
            this.dtpFechaRec = new System.Windows.Forms.DateTimePicker();
            this.LblConfirmarPedido = new System.Windows.Forms.Label();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnConfirmar.IconColor = System.Drawing.Color.White;
            this.BtnConfirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConfirmar.IconSize = 16;
            this.BtnConfirmar.Location = new System.Drawing.Point(33, 87);
            this.BtnConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(125, 27);
            this.BtnConfirmar.TabIndex = 113;
            this.BtnConfirmar.Text = "Aceptar";
            this.BtnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // LblFechaRec
            // 
            this.LblFechaRec.AutoSize = true;
            this.LblFechaRec.BackColor = System.Drawing.Color.White;
            this.LblFechaRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaRec.Location = new System.Drawing.Point(103, 20);
            this.LblFechaRec.Name = "LblFechaRec";
            this.LblFechaRec.Size = new System.Drawing.Size(163, 16);
            this.LblFechaRec.TabIndex = 115;
            this.LblFechaRec.Text = "Asignar Fecha Recepción";
            // 
            // dtpFechaRec
            // 
            this.dtpFechaRec.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRec.Location = new System.Drawing.Point(129, 39);
            this.dtpFechaRec.Name = "dtpFechaRec";
            this.dtpFechaRec.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaRec.TabIndex = 116;
            this.dtpFechaRec.Value = new System.DateTime(2023, 11, 2, 22, 3, 29, 0);
            this.dtpFechaRec.ValueChanged += new System.EventHandler(this.dtpFechaRec_ValueChanged);
            // 
            // LblConfirmarPedido
            // 
            this.LblConfirmarPedido.BackColor = System.Drawing.Color.White;
            this.LblConfirmarPedido.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblConfirmarPedido.Location = new System.Drawing.Point(0, 0);
            this.LblConfirmarPedido.Name = "LblConfirmarPedido";
            this.LblConfirmarPedido.Size = new System.Drawing.Size(355, 144);
            this.LblConfirmarPedido.TabIndex = 102;
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
            this.BtnCancelar.Location = new System.Drawing.Point(188, 87);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(125, 27);
            this.BtnCancelar.TabIndex = 129;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmConfirmarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 144);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.dtpFechaRec);
            this.Controls.Add(this.LblFechaRec);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.LblConfirmarPedido);
            this.Name = "FrmConfirmarCompra";
            this.Text = "Confirmar Compra";
            this.Load += new System.EventHandler(this.FrmConfirmarCompra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton BtnConfirmar;
        private System.Windows.Forms.Label LblFechaRec;
        private System.Windows.Forms.DateTimePicker dtpFechaRec;
        private System.Windows.Forms.Label LblConfirmarPedido;
        private FontAwesome.Sharp.IconButton BtnCancelar;
    }
}
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
            this.BtnAnular = new FontAwesome.Sharp.IconButton();
            this.LblConfirmarPedido = new System.Windows.Forms.Label();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.LblMotivoAnulacion = new System.Windows.Forms.Label();
            this.ComboMotivos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnAnular
            // 
            this.BtnAnular.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnAnular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAnular.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnular.ForeColor = System.Drawing.Color.White;
            this.BtnAnular.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnAnular.IconColor = System.Drawing.Color.White;
            this.BtnAnular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAnular.IconSize = 16;
            this.BtnAnular.Location = new System.Drawing.Point(30, 79);
            this.BtnAnular.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAnular.Name = "BtnAnular";
            this.BtnAnular.Size = new System.Drawing.Size(125, 27);
            this.BtnAnular.TabIndex = 126;
            this.BtnAnular.Text = "Aceptar";
            this.BtnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAnular.UseVisualStyleBackColor = false;
            this.BtnAnular.Click += new System.EventHandler(this.BtnAnular_Click);
            // 
            // LblConfirmarPedido
            // 
            this.LblConfirmarPedido.BackColor = System.Drawing.Color.White;
            this.LblConfirmarPedido.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblConfirmarPedido.Location = new System.Drawing.Point(0, 0);
            this.LblConfirmarPedido.Name = "LblConfirmarPedido";
            this.LblConfirmarPedido.Size = new System.Drawing.Size(355, 143);
            this.LblConfirmarPedido.TabIndex = 115;
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
            this.BtnCancelar.Location = new System.Drawing.Point(178, 79);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(125, 27);
            this.BtnCancelar.TabIndex = 128;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LblMotivoAnulacion
            // 
            this.LblMotivoAnulacion.AutoSize = true;
            this.LblMotivoAnulacion.BackColor = System.Drawing.Color.White;
            this.LblMotivoAnulacion.Location = new System.Drawing.Point(10, 23);
            this.LblMotivoAnulacion.Name = "LblMotivoAnulacion";
            this.LblMotivoAnulacion.Size = new System.Drawing.Size(92, 13);
            this.LblMotivoAnulacion.TabIndex = 130;
            this.LblMotivoAnulacion.Text = "Motivo Anulación:";
            // 
            // ComboMotivos
            // 
            this.ComboMotivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMotivos.FormattingEnabled = true;
            this.ComboMotivos.Location = new System.Drawing.Point(12, 39);
            this.ComboMotivos.Name = "ComboMotivos";
            this.ComboMotivos.Size = new System.Drawing.Size(325, 21);
            this.ComboMotivos.TabIndex = 131;
            // 
            // FrmAnularCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 143);
            this.Controls.Add(this.ComboMotivos);
            this.Controls.Add(this.LblMotivoAnulacion);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAnular);
            this.Controls.Add(this.LblConfirmarPedido);
            this.Name = "FrmAnularCompra";
            this.Text = "Anular Compra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton BtnAnular;
        private System.Windows.Forms.Label LblConfirmarPedido;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private System.Windows.Forms.Label LblMotivoAnulacion;
        private System.Windows.Forms.ComboBox ComboMotivos;
    }
}
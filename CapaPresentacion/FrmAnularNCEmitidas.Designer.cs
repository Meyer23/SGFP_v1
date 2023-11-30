namespace CapaPresentacion
{
    partial class FrmAnularNCEmitidas
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
            this.ComboMotivos = new System.Windows.Forms.ComboBox();
            this.LblMotivoAnulacion = new System.Windows.Forms.Label();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.BtnAnular = new FontAwesome.Sharp.IconButton();
            this.LblConfirmarPedido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboMotivos
            // 
            this.ComboMotivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMotivos.FormattingEnabled = true;
            this.ComboMotivos.Location = new System.Drawing.Point(18, 31);
            this.ComboMotivos.Name = "ComboMotivos";
            this.ComboMotivos.Size = new System.Drawing.Size(325, 21);
            this.ComboMotivos.TabIndex = 144;
            // 
            // LblMotivoAnulacion
            // 
            this.LblMotivoAnulacion.AutoSize = true;
            this.LblMotivoAnulacion.BackColor = System.Drawing.Color.White;
            this.LblMotivoAnulacion.Location = new System.Drawing.Point(16, 15);
            this.LblMotivoAnulacion.Name = "LblMotivoAnulacion";
            this.LblMotivoAnulacion.Size = new System.Drawing.Size(92, 13);
            this.LblMotivoAnulacion.TabIndex = 143;
            this.LblMotivoAnulacion.Text = "Motivo Anulación:";
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
            this.BtnCancelar.Location = new System.Drawing.Point(184, 71);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(125, 27);
            this.BtnCancelar.TabIndex = 142;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
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
            this.BtnAnular.Location = new System.Drawing.Point(46, 71);
            this.BtnAnular.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAnular.Name = "BtnAnular";
            this.BtnAnular.Size = new System.Drawing.Size(125, 27);
            this.BtnAnular.TabIndex = 141;
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
            this.LblConfirmarPedido.Size = new System.Drawing.Size(355, 123);
            this.LblConfirmarPedido.TabIndex = 140;
            // 
            // FrmAnularNCEmitidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 123);
            this.Controls.Add(this.ComboMotivos);
            this.Controls.Add(this.LblMotivoAnulacion);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAnular);
            this.Controls.Add(this.LblConfirmarPedido);
            this.Name = "FrmAnularNCEmitidas";
            this.Text = "FrmAnularNCEmitidas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboMotivos;
        private System.Windows.Forms.Label LblMotivoAnulacion;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnAnular;
        private System.Windows.Forms.Label LblConfirmarPedido;
    }
}
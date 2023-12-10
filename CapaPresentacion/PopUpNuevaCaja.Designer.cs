﻿namespace CapaPresentacion
{
    partial class PopUpNuevaCaja
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
            this.PickUpDownNroCaja = new System.Windows.Forms.NumericUpDown();
            this.LblNroCaja = new System.Windows.Forms.Label();
            this.ChkActivo = new System.Windows.Forms.CheckBox();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.BtnSalir = new FontAwesome.Sharp.IconButton();
            this.ComboSucursal = new System.Windows.Forms.ComboBox();
            this.LblSucursal = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.TxtDescripcionCaja = new System.Windows.Forms.TextBox();
            this.txtidcaja = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PickUpDownNroCaja)).BeginInit();
            this.SuspendLayout();
            // 
            // PickUpDownNroCaja
            // 
            this.PickUpDownNroCaja.Enabled = false;
            this.PickUpDownNroCaja.Location = new System.Drawing.Point(271, 24);
            this.PickUpDownNroCaja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PickUpDownNroCaja.Name = "PickUpDownNroCaja";
            this.PickUpDownNroCaja.ReadOnly = true;
            this.PickUpDownNroCaja.Size = new System.Drawing.Size(147, 29);
            this.PickUpDownNroCaja.TabIndex = 0;
            this.PickUpDownNroCaja.Visible = false;
            // 
            // LblNroCaja
            // 
            this.LblNroCaja.AutoSize = true;
            this.LblNroCaja.Location = new System.Drawing.Point(14, 24);
            this.LblNroCaja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNroCaja.Name = "LblNroCaja";
            this.LblNroCaja.Size = new System.Drawing.Size(224, 25);
            this.LblNroCaja.TabIndex = 1;
            this.LblNroCaja.Text = "Número de Caja a Crear";
            // 
            // ChkActivo
            // 
            this.ChkActivo.AutoSize = true;
            this.ChkActivo.Checked = true;
            this.ChkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkActivo.Location = new System.Drawing.Point(20, 351);
            this.ChkActivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChkActivo.Name = "ChkActivo";
            this.ChkActivo.Size = new System.Drawing.Size(92, 29);
            this.ChkActivo.TabIndex = 2;
            this.ChkActivo.Text = "Activo";
            this.ChkActivo.UseVisualStyleBackColor = true;
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
            this.BtnGuardar.Location = new System.Drawing.Point(19, 411);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(183, 50);
            this.BtnGuardar.TabIndex = 52;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
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
            this.BtnSalir.Location = new System.Drawing.Point(235, 413);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(183, 48);
            this.BtnSalir.TabIndex = 53;
            this.BtnSalir.Text = "Cancelar";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // ComboSucursal
            // 
            this.ComboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboSucursal.FormattingEnabled = true;
            this.ComboSucursal.Location = new System.Drawing.Point(15, 180);
            this.ComboSucursal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ComboSucursal.Name = "ComboSucursal";
            this.ComboSucursal.Size = new System.Drawing.Size(218, 32);
            this.ComboSucursal.TabIndex = 58;
            // 
            // LblSucursal
            // 
            this.LblSucursal.AutoSize = true;
            this.LblSucursal.BackColor = System.Drawing.Color.Transparent;
            this.LblSucursal.Location = new System.Drawing.Point(15, 131);
            this.LblSucursal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSucursal.Name = "LblSucursal";
            this.LblSucursal.Size = new System.Drawing.Size(95, 25);
            this.LblSucursal.TabIndex = 57;
            this.LblSucursal.Text = "Sucursal:";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.LblDescripcion.Location = new System.Drawing.Point(15, 227);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(120, 25);
            this.LblDescripcion.TabIndex = 59;
            this.LblDescripcion.Text = "Descripcion:";
            // 
            // TxtDescripcionCaja
            // 
            this.TxtDescripcionCaja.Location = new System.Drawing.Point(20, 275);
            this.TxtDescripcionCaja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDescripcionCaja.Name = "TxtDescripcionCaja";
            this.TxtDescripcionCaja.Size = new System.Drawing.Size(218, 29);
            this.TxtDescripcionCaja.TabIndex = 60;
            // 
            // txtidcaja
            // 
            this.txtidcaja.Location = new System.Drawing.Point(20, 73);
            this.txtidcaja.Name = "txtidcaja";
            this.txtidcaja.Size = new System.Drawing.Size(218, 29);
            this.txtidcaja.TabIndex = 61;
            // 
            // PopUpNuevaCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 498);
            this.Controls.Add(this.txtidcaja);
            this.Controls.Add(this.TxtDescripcionCaja);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.ComboSucursal);
            this.Controls.Add(this.LblSucursal);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.ChkActivo);
            this.Controls.Add(this.LblNroCaja);
            this.Controls.Add(this.PickUpDownNroCaja);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PopUpNuevaCaja";
            this.Text = "Crear Caja";
            this.Load += new System.EventHandler(this.PopUpNuevaCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PickUpDownNroCaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown PickUpDownNroCaja;
        private System.Windows.Forms.Label LblNroCaja;
        private System.Windows.Forms.CheckBox ChkActivo;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private System.Windows.Forms.ComboBox ComboSucursal;
        private System.Windows.Forms.Label LblSucursal;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.TextBox TxtDescripcionCaja;
        private System.Windows.Forms.TextBox txtidcaja;
    }
}
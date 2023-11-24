﻿namespace CapaPresentacion
{
    partial class PopUpNuevoCliente
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
            this.LblClientes = new System.Windows.Forms.Label();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.groupTipoPersona = new System.Windows.Forms.GroupBox();
            this.radioButtonJuridica = new System.Windows.Forms.RadioButton();
            this.radioButtonFisica = new System.Windows.Forms.RadioButton();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.LblDetalleCliente = new System.Windows.Forms.Label();
            this.ChkActivo = new System.Windows.Forms.CheckBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtTelefono2 = new System.Windows.Forms.TextBox();
            this.TxtTelefono1 = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.LblTelefono2 = new System.Windows.Forms.Label();
            this.LblTelefono1 = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblDocumento = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.groupTipoPersona.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblClientes
            // 
            this.LblClientes.BackColor = System.Drawing.Color.White;
            this.LblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClientes.Location = new System.Drawing.Point(12, 9);
            this.LblClientes.Name = "LblClientes";
            this.LblClientes.Padding = new System.Windows.Forms.Padding(3);
            this.LblClientes.Size = new System.Drawing.Size(776, 753);
            this.LblClientes.TabIndex = 27;
            this.LblClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(27, 302);
            this.TxtApellidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(267, 26);
            this.TxtApellidos.TabIndex = 105;
            this.TxtApellidos.TabStop = false;
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.BackColor = System.Drawing.Color.White;
            this.LblApellidos.Location = new System.Drawing.Point(32, 270);
            this.LblApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(77, 20);
            this.LblApellidos.TabIndex = 104;
            this.LblApellidos.Text = "Apellidos:";
            // 
            // groupTipoPersona
            // 
            this.groupTipoPersona.BackColor = System.Drawing.Color.White;
            this.groupTipoPersona.Controls.Add(this.radioButtonJuridica);
            this.groupTipoPersona.Controls.Add(this.radioButtonFisica);
            this.groupTipoPersona.Location = new System.Drawing.Point(27, 461);
            this.groupTipoPersona.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupTipoPersona.Name = "groupTipoPersona";
            this.groupTipoPersona.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupTipoPersona.Size = new System.Drawing.Size(261, 112);
            this.groupTipoPersona.TabIndex = 103;
            this.groupTipoPersona.TabStop = false;
            this.groupTipoPersona.Text = "Tipo Persona";
            // 
            // radioButtonJuridica
            // 
            this.radioButtonJuridica.AutoSize = true;
            this.radioButtonJuridica.Location = new System.Drawing.Point(4, 60);
            this.radioButtonJuridica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonJuridica.Name = "radioButtonJuridica";
            this.radioButtonJuridica.Size = new System.Drawing.Size(88, 24);
            this.radioButtonJuridica.TabIndex = 1;
            this.radioButtonJuridica.Text = "Jurídica";
            this.radioButtonJuridica.UseVisualStyleBackColor = true;
            // 
            // radioButtonFisica
            // 
            this.radioButtonFisica.AutoSize = true;
            this.radioButtonFisica.Checked = true;
            this.radioButtonFisica.Location = new System.Drawing.Point(8, 29);
            this.radioButtonFisica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonFisica.Name = "radioButtonFisica";
            this.radioButtonFisica.Size = new System.Drawing.Size(75, 24);
            this.radioButtonFisica.TabIndex = 0;
            this.radioButtonFisica.TabStop = true;
            this.radioButtonFisica.Text = "Física";
            this.radioButtonFisica.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.BtnCancelar.IconColor = System.Drawing.Color.White;
            this.BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancelar.IconSize = 18;
            this.BtnCancelar.Location = new System.Drawing.Point(28, 719);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(260, 40);
            this.BtnCancelar.TabIndex = 102;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
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
            this.BtnGuardar.Location = new System.Drawing.Point(28, 650);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(260, 42);
            this.BtnGuardar.TabIndex = 101;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LblDetalleCliente
            // 
            this.LblDetalleCliente.AutoSize = true;
            this.LblDetalleCliente.BackColor = System.Drawing.Color.White;
            this.LblDetalleCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDetalleCliente.Location = new System.Drawing.Point(31, 20);
            this.LblDetalleCliente.Name = "LblDetalleCliente";
            this.LblDetalleCliente.Size = new System.Drawing.Size(171, 29);
            this.LblDetalleCliente.TabIndex = 100;
            this.LblDetalleCliente.Text = "Detalle Cliente";
            // 
            // ChkActivo
            // 
            this.ChkActivo.AutoSize = true;
            this.ChkActivo.BackColor = System.Drawing.Color.White;
            this.ChkActivo.Checked = true;
            this.ChkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkActivo.Location = new System.Drawing.Point(27, 594);
            this.ChkActivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkActivo.Name = "ChkActivo";
            this.ChkActivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkActivo.Size = new System.Drawing.Size(78, 24);
            this.ChkActivo.TabIndex = 99;
            this.ChkActivo.Text = "Activo";
            this.ChkActivo.UseVisualStyleBackColor = false;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(27, 403);
            this.TxtCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(267, 26);
            this.TxtCorreo.TabIndex = 98;
            // 
            // TxtTelefono2
            // 
            this.TxtTelefono2.Location = new System.Drawing.Point(428, 302);
            this.TxtTelefono2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTelefono2.Name = "TxtTelefono2";
            this.TxtTelefono2.Size = new System.Drawing.Size(258, 26);
            this.TxtTelefono2.TabIndex = 97;
            // 
            // TxtTelefono1
            // 
            this.TxtTelefono1.Location = new System.Drawing.Point(428, 207);
            this.TxtTelefono1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTelefono1.Name = "TxtTelefono1";
            this.TxtTelefono1.Size = new System.Drawing.Size(258, 26);
            this.TxtTelefono1.TabIndex = 96;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(428, 110);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(258, 26);
            this.TxtDireccion.TabIndex = 95;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Location = new System.Drawing.Point(36, 110);
            this.TxtDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(258, 26);
            this.TxtDocumento.TabIndex = 94;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(36, 207);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(258, 26);
            this.TxtNombre.TabIndex = 93;
            this.TxtNombre.TabStop = false;
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.BackColor = System.Drawing.Color.White;
            this.LblCorreo.Location = new System.Drawing.Point(23, 361);
            this.LblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(61, 20);
            this.LblCorreo.TabIndex = 92;
            this.LblCorreo.Text = "Correo:";
            // 
            // LblTelefono2
            // 
            this.LblTelefono2.AutoSize = true;
            this.LblTelefono2.BackColor = System.Drawing.Color.White;
            this.LblTelefono2.Location = new System.Drawing.Point(424, 260);
            this.LblTelefono2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTelefono2.Name = "LblTelefono2";
            this.LblTelefono2.Size = new System.Drawing.Size(88, 20);
            this.LblTelefono2.TabIndex = 91;
            this.LblTelefono2.Text = "Teléfono 2:";
            // 
            // LblTelefono1
            // 
            this.LblTelefono1.AutoSize = true;
            this.LblTelefono1.BackColor = System.Drawing.Color.White;
            this.LblTelefono1.Location = new System.Drawing.Point(424, 164);
            this.LblTelefono1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTelefono1.Name = "LblTelefono1";
            this.LblTelefono1.Size = new System.Drawing.Size(88, 20);
            this.LblTelefono1.TabIndex = 90;
            this.LblTelefono1.Text = "Teléfono 1:";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.BackColor = System.Drawing.Color.White;
            this.LblDireccion.Location = new System.Drawing.Point(424, 80);
            this.LblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(79, 20);
            this.LblDireccion.TabIndex = 89;
            this.LblDireccion.Text = "Dirección:";
            // 
            // LblDocumento
            // 
            this.LblDocumento.AutoSize = true;
            this.LblDocumento.BackColor = System.Drawing.Color.White;
            this.LblDocumento.Location = new System.Drawing.Point(32, 80);
            this.LblDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDocumento.Name = "LblDocumento";
            this.LblDocumento.Size = new System.Drawing.Size(96, 20);
            this.LblDocumento.TabIndex = 88;
            this.LblDocumento.Text = "Documento:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(32, 164);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(77, 20);
            this.LblNombre.TabIndex = 87;
            this.LblNombre.Text = "Nombres:";
            // 
            // PopUpNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 771);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.LblApellidos);
            this.Controls.Add(this.groupTipoPersona);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblDetalleCliente);
            this.Controls.Add(this.ChkActivo);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtTelefono2);
            this.Controls.Add(this.TxtTelefono1);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtDocumento);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblCorreo);
            this.Controls.Add(this.LblTelefono2);
            this.Controls.Add(this.LblTelefono1);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.LblDocumento);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblClientes);
            this.Name = "PopUpNuevoCliente";
            this.Text = "Agregar Cliente";
            this.groupTipoPersona.ResumeLayout(false);
            this.groupTipoPersona.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblClientes;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.GroupBox groupTipoPersona;
        private System.Windows.Forms.RadioButton radioButtonJuridica;
        private System.Windows.Forms.RadioButton radioButtonFisica;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.Label LblDetalleCliente;
        private System.Windows.Forms.CheckBox ChkActivo;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtTelefono2;
        private System.Windows.Forms.TextBox TxtTelefono1;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.Label LblTelefono2;
        private System.Windows.Forms.Label LblTelefono1;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblDocumento;
        private System.Windows.Forms.Label LblNombre;
    }
}
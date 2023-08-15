namespace CapaPresentacion
{
    partial class FrmUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblRePassword = new System.Windows.Forms.Label();
            this.LblDocumento = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtRePassword = new System.Windows.Forms.TextBox();
            this.LblRol = new System.Windows.Forms.Label();
            this.ComboRol = new System.Windows.Forms.ComboBox();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.LblDetalleUsuario = new System.Windows.Forms.Label();
            this.ChkActivo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 740);
            this.label1.TabIndex = 0;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(12, 83);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(69, 20);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.BackColor = System.Drawing.Color.White;
            this.LblLogin.Location = new System.Drawing.Point(12, 218);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(52, 20);
            this.LblLogin.TabIndex = 2;
            this.LblLogin.Text = "Login:";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.White;
            this.LblPassword.Location = new System.Drawing.Point(12, 297);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(96, 20);
            this.LblPassword.TabIndex = 3;
            this.LblPassword.Text = "Contraseña:";
            // 
            // LblRePassword
            // 
            this.LblRePassword.AutoSize = true;
            this.LblRePassword.BackColor = System.Drawing.Color.White;
            this.LblRePassword.ForeColor = System.Drawing.Color.Black;
            this.LblRePassword.Location = new System.Drawing.Point(8, 393);
            this.LblRePassword.Name = "LblRePassword";
            this.LblRePassword.Size = new System.Drawing.Size(169, 20);
            this.LblRePassword.TabIndex = 4;
            this.LblRePassword.Text = "Confirmar Contraseña:";
            // 
            // LblDocumento
            // 
            this.LblDocumento.AutoSize = true;
            this.LblDocumento.BackColor = System.Drawing.Color.White;
            this.LblDocumento.Location = new System.Drawing.Point(12, 149);
            this.LblDocumento.Name = "LblDocumento";
            this.LblDocumento.Size = new System.Drawing.Size(96, 20);
            this.LblDocumento.TabIndex = 5;
            this.LblDocumento.Text = "Documento:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(12, 120);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(248, 26);
            this.TxtNombre.TabIndex = 6;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Location = new System.Drawing.Point(12, 180);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(248, 26);
            this.TxtDocumento.TabIndex = 7;
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(12, 258);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(248, 26);
            this.TxtLogin.TabIndex = 8;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(12, 345);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(248, 26);
            this.TxtPassword.TabIndex = 9;
            // 
            // TxtRePassword
            // 
            this.TxtRePassword.Location = new System.Drawing.Point(12, 426);
            this.TxtRePassword.Name = "TxtRePassword";
            this.TxtRePassword.Size = new System.Drawing.Size(248, 26);
            this.TxtRePassword.TabIndex = 10;
            // 
            // LblRol
            // 
            this.LblRol.AutoSize = true;
            this.LblRol.BackColor = System.Drawing.Color.White;
            this.LblRol.ForeColor = System.Drawing.Color.Black;
            this.LblRol.Location = new System.Drawing.Point(12, 465);
            this.LblRol.Name = "LblRol";
            this.LblRol.Size = new System.Drawing.Size(37, 20);
            this.LblRol.TabIndex = 11;
            this.LblRol.Text = "Rol:";
            // 
            // ComboRol
            // 
            this.ComboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboRol.FormattingEnabled = true;
            this.ComboRol.Location = new System.Drawing.Point(12, 501);
            this.ComboRol.Name = "ComboRol";
            this.ComboRol.Size = new System.Drawing.Size(248, 28);
            this.ComboRol.TabIndex = 12;
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
            this.BtnGuardar.Location = new System.Drawing.Point(12, 604);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(260, 42);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.BtnEditar.IconColor = System.Drawing.Color.White;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditar.IconSize = 16;
            this.BtnEditar.Location = new System.Drawing.Point(12, 667);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(260, 40);
            this.BtnEditar.TabIndex = 15;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // LblDetalleUsuario
            // 
            this.LblDetalleUsuario.AutoSize = true;
            this.LblDetalleUsuario.BackColor = System.Drawing.Color.White;
            this.LblDetalleUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDetalleUsuario.Location = new System.Drawing.Point(12, 27);
            this.LblDetalleUsuario.Name = "LblDetalleUsuario";
            this.LblDetalleUsuario.Size = new System.Drawing.Size(184, 29);
            this.LblDetalleUsuario.TabIndex = 16;
            this.LblDetalleUsuario.Text = "Detalle Usuario:";
            // 
            // ChkActivo
            // 
            this.ChkActivo.AutoSize = true;
            this.ChkActivo.BackColor = System.Drawing.Color.White;
            this.ChkActivo.Location = new System.Drawing.Point(12, 556);
            this.ChkActivo.Name = "ChkActivo";
            this.ChkActivo.Size = new System.Drawing.Size(78, 24);
            this.ChkActivo.TabIndex = 17;
            this.ChkActivo.Text = "Activo";
            this.ChkActivo.UseVisualStyleBackColor = false;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1173, 740);
            this.Controls.Add(this.ChkActivo);
            this.Controls.Add(this.LblDetalleUsuario);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.ComboRol);
            this.Controls.Add(this.LblRol);
            this.Controls.Add(this.TxtRePassword);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.TxtDocumento);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblDocumento);
            this.Controls.Add(this.LblRePassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.label1);
            this.Name = "FrmUsuarios";
            this.Text = "Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblRePassword;
        private System.Windows.Forms.Label LblDocumento;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtRePassword;
        private System.Windows.Forms.Label LblRol;
        private System.Windows.Forms.ComboBox ComboRol;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private System.Windows.Forms.Label LblDetalleUsuario;
        private System.Windows.Forms.CheckBox ChkActivo;
    }
}
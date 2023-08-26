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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIdUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 471);
            this.label1.TabIndex = 0;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(5, 63);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(47, 13);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.BackColor = System.Drawing.Color.White;
            this.LblLogin.Location = new System.Drawing.Point(5, 159);
            this.LblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(36, 13);
            this.LblLogin.TabIndex = 2;
            this.LblLogin.Text = "Login:";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.White;
            this.LblPassword.Location = new System.Drawing.Point(5, 208);
            this.LblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(64, 13);
            this.LblPassword.TabIndex = 3;
            this.LblPassword.Text = "Contraseña:";
            // 
            // LblRePassword
            // 
            this.LblRePassword.AutoSize = true;
            this.LblRePassword.BackColor = System.Drawing.Color.White;
            this.LblRePassword.ForeColor = System.Drawing.Color.Black;
            this.LblRePassword.Location = new System.Drawing.Point(5, 255);
            this.LblRePassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRePassword.Name = "LblRePassword";
            this.LblRePassword.Size = new System.Drawing.Size(111, 13);
            this.LblRePassword.TabIndex = 4;
            this.LblRePassword.Text = "Confirmar Contraseña:";
            // 
            // LblDocumento
            // 
            this.LblDocumento.AutoSize = true;
            this.LblDocumento.BackColor = System.Drawing.Color.White;
            this.LblDocumento.Location = new System.Drawing.Point(5, 110);
            this.LblDocumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDocumento.Name = "LblDocumento";
            this.LblDocumento.Size = new System.Drawing.Size(65, 13);
            this.LblDocumento.TabIndex = 5;
            this.LblDocumento.Text = "Documento:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(8, 78);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(167, 20);
            this.TxtNombre.TabIndex = 6;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Location = new System.Drawing.Point(8, 125);
            this.TxtDocumento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(167, 20);
            this.TxtDocumento.TabIndex = 7;
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(8, 174);
            this.TxtLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(167, 20);
            this.TxtLogin.TabIndex = 8;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(8, 223);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(167, 20);
            this.TxtPassword.TabIndex = 9;
            // 
            // TxtRePassword
            // 
            this.TxtRePassword.Location = new System.Drawing.Point(8, 270);
            this.TxtRePassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtRePassword.Name = "TxtRePassword";
            this.TxtRePassword.Size = new System.Drawing.Size(167, 20);
            this.TxtRePassword.TabIndex = 10;
            // 
            // LblRol
            // 
            this.LblRol.AutoSize = true;
            this.LblRol.BackColor = System.Drawing.Color.White;
            this.LblRol.ForeColor = System.Drawing.Color.Black;
            this.LblRol.Location = new System.Drawing.Point(5, 304);
            this.LblRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRol.Name = "LblRol";
            this.LblRol.Size = new System.Drawing.Size(26, 13);
            this.LblRol.TabIndex = 11;
            this.LblRol.Text = "Rol:";
            // 
            // ComboRol
            // 
            this.ComboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboRol.FormattingEnabled = true;
            this.ComboRol.Location = new System.Drawing.Point(8, 319);
            this.ComboRol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboRol.Name = "ComboRol";
            this.ComboRol.Size = new System.Drawing.Size(167, 21);
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
            this.BtnGuardar.Location = new System.Drawing.Point(8, 393);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(173, 27);
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
            this.BtnEditar.Location = new System.Drawing.Point(8, 434);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(173, 26);
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
            this.LblDetalleUsuario.Location = new System.Drawing.Point(8, 18);
            this.LblDetalleUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDetalleUsuario.Name = "LblDetalleUsuario";
            this.LblDetalleUsuario.Size = new System.Drawing.Size(118, 20);
            this.LblDetalleUsuario.TabIndex = 16;
            this.LblDetalleUsuario.Text = "Detalle Usuario";
            // 
            // ChkActivo
            // 
            this.ChkActivo.AutoSize = true;
            this.ChkActivo.BackColor = System.Drawing.Color.White;
            this.ChkActivo.Location = new System.Drawing.Point(8, 356);
            this.ChkActivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChkActivo.Name = "ChkActivo";
            this.ChkActivo.Size = new System.Drawing.Size(56, 17);
            this.ChkActivo.TabIndex = 17;
            this.ChkActivo.Text = "Activo";
            this.ChkActivo.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.idUsuario,
            this.Documento,
            this.Correo,
            this.NombreCompleto,
            this.Apellidos,
            this.idRol,
            this.Rol,
            this.EstadoUsuario});
            this.dataGridView1.Location = new System.Drawing.Point(213, 76);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(762, 384);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 8;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 50;
            // 
            // idUsuario
            // 
            this.idUsuario.HeaderText = "idUsuario";
            this.idUsuario.MinimumWidth = 8;
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Visible = false;
            this.idUsuario.Width = 50;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Nro. Documento";
            this.Documento.MinimumWidth = 8;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 180;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 8;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 180;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.MinimumWidth = 8;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 180;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.MinimumWidth = 8;
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 150;
            // 
            // idRol
            // 
            this.idRol.HeaderText = "idRol";
            this.idRol.MinimumWidth = 8;
            this.idRol.Name = "idRol";
            this.idRol.ReadOnly = true;
            this.idRol.Visible = false;
            this.idRol.Width = 150;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.MinimumWidth = 8;
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 180;
            // 
            // EstadoUsuario
            // 
            this.EstadoUsuario.HeaderText = "Activo";
            this.EstadoUsuario.MinimumWidth = 8;
            this.EstadoUsuario.Name = "EstadoUsuario";
            this.EstadoUsuario.ReadOnly = true;
            this.EstadoUsuario.Width = 150;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(760, 40);
            this.label2.TabIndex = 19;
            this.label2.Text = "Lista de Usuarios";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtIdUsuario
            // 
            this.TxtIdUsuario.Location = new System.Drawing.Point(142, 41);
            this.TxtIdUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtIdUsuario.Name = "TxtIdUsuario";
            this.TxtIdUsuario.Size = new System.Drawing.Size(33, 20);
            this.TxtIdUsuario.TabIndex = 20;
            this.TxtIdUsuario.Visible = false;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 471);
            this.Controls.Add(this.TxtIdUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoUsuario;
    }
}
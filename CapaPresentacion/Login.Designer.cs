namespace CapaPresentacion
{
    partial class Login
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
            this.LabelSistemaFP = new System.Windows.Forms.Label();
            this.LoginLabelSistema = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.UsuarioLogin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnIngresar = new FontAwesome.Sharp.IconButton();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelSistemaFP
            // 
            this.LabelSistemaFP.BackColor = System.Drawing.Color.SteelBlue;
            this.LabelSistemaFP.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelSistemaFP.Location = new System.Drawing.Point(0, 0);
            this.LabelSistemaFP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelSistemaFP.Name = "LabelSistemaFP";
            this.LabelSistemaFP.Size = new System.Drawing.Size(204, 218);
            this.LabelSistemaFP.TabIndex = 0;
            // 
            // LoginLabelSistema
            // 
            this.LoginLabelSistema.AutoSize = true;
            this.LoginLabelSistema.BackColor = System.Drawing.Color.SteelBlue;
            this.LoginLabelSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabelSistema.ForeColor = System.Drawing.Color.White;
            this.LoginLabelSistema.Location = new System.Drawing.Point(60, 170);
            this.LoginLabelSistema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginLabelSistema.Name = "LoginLabelSistema";
            this.LoginLabelSistema.Size = new System.Drawing.Size(70, 25);
            this.LoginLabelSistema.TabIndex = 1;
            this.LoginLabelSistema.Text = "SGFP";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 101;
            this.iconPictureBox1.Location = new System.Drawing.Point(49, 49);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(103, 101);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(231, 72);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(237, 20);
            this.TxtUsuario.TabIndex = 3;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(231, 127);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(237, 20);
            this.TxtPassword.TabIndex = 4;
            // 
            // UsuarioLogin
            // 
            this.UsuarioLogin.AutoSize = true;
            this.UsuarioLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLogin.Location = new System.Drawing.Point(228, 49);
            this.UsuarioLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsuarioLogin.Name = "UsuarioLogin";
            this.UsuarioLogin.Size = new System.Drawing.Size(57, 16);
            this.UsuarioLogin.TabIndex = 5;
            this.UsuarioLogin.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña:";
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.Color.White;
            this.BtnIngresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.BtnIngresar.IconColor = System.Drawing.Color.White;
            this.BtnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnIngresar.IconSize = 30;
            this.BtnIngresar.Location = new System.Drawing.Point(231, 163);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(115, 31);
            this.BtnIngresar.TabIndex = 7;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.BtnCancelar.IconColor = System.Drawing.Color.White;
            this.BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancelar.IconSize = 30;
            this.BtnCancelar.Location = new System.Drawing.Point(350, 163);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(116, 31);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 218);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsuarioLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.LoginLabelSistema);
            this.Controls.Add(this.LabelSistemaFP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Ingresar al Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelSistemaFP;
        private System.Windows.Forms.Label LoginLabelSistema;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label UsuarioLogin;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton BtnIngresar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
    }
}
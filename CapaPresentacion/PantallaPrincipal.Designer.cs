namespace CapaPresentacion
{
    partial class PantallaPrincipal
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.UsuariosMenu = new FontAwesome.Sharp.IconMenuItem();
            this.ClientesMenu = new FontAwesome.Sharp.IconMenuItem();
            this.ProductosMenu = new FontAwesome.Sharp.IconMenuItem();
            this.CategoriasMenu = new FontAwesome.Sharp.IconMenuItem();
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.LabelTituloSistema = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.ULabel = new System.Windows.Forms.Label();
            this.LBLUsuario = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuariosMenu,
            this.ClientesMenu,
            this.ProductosMenu,
            this.CategoriasMenu});
            this.menu.Location = new System.Drawing.Point(0, 82);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1414, 83);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // UsuariosMenu
            // 
            this.UsuariosMenu.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.UsuariosMenu.IconColor = System.Drawing.Color.Black;
            this.UsuariosMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UsuariosMenu.IconSize = 50;
            this.UsuariosMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UsuariosMenu.Name = "UsuariosMenu";
            this.UsuariosMenu.Size = new System.Drawing.Size(96, 79);
            this.UsuariosMenu.Text = "Usuarios";
            this.UsuariosMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ClientesMenu
            // 
            this.ClientesMenu.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.ClientesMenu.IconColor = System.Drawing.Color.Black;
            this.ClientesMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ClientesMenu.IconSize = 50;
            this.ClientesMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ClientesMenu.Name = "ClientesMenu";
            this.ClientesMenu.Size = new System.Drawing.Size(89, 79);
            this.ClientesMenu.Text = "Clientes";
            this.ClientesMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ProductosMenu
            // 
            this.ProductosMenu.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            this.ProductosMenu.IconColor = System.Drawing.Color.Black;
            this.ProductosMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProductosMenu.IconSize = 50;
            this.ProductosMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ProductosMenu.Name = "ProductosMenu";
            this.ProductosMenu.Size = new System.Drawing.Size(109, 79);
            this.ProductosMenu.Text = "Productos";
            this.ProductosMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // CategoriasMenu
            // 
            this.CategoriasMenu.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.CategoriasMenu.IconColor = System.Drawing.Color.Black;
            this.CategoriasMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CategoriasMenu.IconSize = 50;
            this.CategoriasMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CategoriasMenu.Name = "CategoriasMenu";
            this.CategoriasMenu.Size = new System.Drawing.Size(112, 79);
            this.CategoriasMenu.Text = "Categorias";
            this.CategoriasMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menutitulo.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menutitulo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(1414, 82);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menu";
            // 
            // LabelTituloSistema
            // 
            this.LabelTituloSistema.AutoSize = true;
            this.LabelTituloSistema.BackColor = System.Drawing.Color.SteelBlue;
            this.LabelTituloSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTituloSistema.ForeColor = System.Drawing.Color.White;
            this.LabelTituloSistema.Location = new System.Drawing.Point(28, 19);
            this.LabelTituloSistema.Name = "LabelTituloSistema";
            this.LabelTituloSistema.Size = new System.Drawing.Size(226, 46);
            this.LabelTituloSistema.TabIndex = 2;
            this.LabelTituloSistema.Text = "Sistema FP";
            // 
            // Contenedor
            // 
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 165);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1414, 423);
            this.Contenedor.TabIndex = 3;
            // 
            // ULabel
            // 
            this.ULabel.AutoSize = true;
            this.ULabel.BackColor = System.Drawing.Color.SteelBlue;
            this.ULabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ULabel.ForeColor = System.Drawing.Color.White;
            this.ULabel.Location = new System.Drawing.Point(963, 19);
            this.ULabel.Name = "ULabel";
            this.ULabel.Size = new System.Drawing.Size(102, 29);
            this.ULabel.TabIndex = 4;
            this.ULabel.Text = "Usuario:";
            // 
            // LBLUsuario
            // 
            this.LBLUsuario.AutoSize = true;
            this.LBLUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.LBLUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUsuario.ForeColor = System.Drawing.Color.White;
            this.LBLUsuario.Location = new System.Drawing.Point(1060, 19);
            this.LBLUsuario.Name = "LBLUsuario";
            this.LBLUsuario.Size = new System.Drawing.Size(138, 29);
            this.LBLUsuario.TabIndex = 5;
            this.LBLUsuario.Text = "LBLUsuario";
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 588);
            this.Controls.Add(this.LBLUsuario);
            this.Controls.Add(this.ULabel);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.LabelTituloSistema);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGFP ";
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menutitulo;
        private System.Windows.Forms.Label LabelTituloSistema;
        private FontAwesome.Sharp.IconMenuItem UsuariosMenu;
        private FontAwesome.Sharp.IconMenuItem ClientesMenu;
        private FontAwesome.Sharp.IconMenuItem ProductosMenu;
        private FontAwesome.Sharp.IconMenuItem CategoriasMenu;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Label ULabel;
        private System.Windows.Forms.Label LBLUsuario;
    }
}


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
            this.SubMenuRoles = new FontAwesome.Sharp.IconMenuItem();
            this.ClientesMenu = new FontAwesome.Sharp.IconMenuItem();
            this.MantenedorMenu = new FontAwesome.Sharp.IconMenuItem();
            this.submenucategorias = new FontAwesome.Sharp.IconMenuItem();
            this.submenuproductos = new FontAwesome.Sharp.IconMenuItem();
            this.submenuempleados = new FontAwesome.Sharp.IconMenuItem();
            this.VentasMenu = new FontAwesome.Sharp.IconMenuItem();
            this.MenuRegistrarVenta = new FontAwesome.Sharp.IconMenuItem();
            this.MenuVerDetalle = new FontAwesome.Sharp.IconMenuItem();
            this.ComprasMenu = new FontAwesome.Sharp.IconMenuItem();
            this.MenuRegistrarCompra = new FontAwesome.Sharp.IconMenuItem();
            this.MenuVerDetalleCompra = new FontAwesome.Sharp.IconMenuItem();
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.LabelTituloSistema = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.ULabel = new System.Windows.Forms.Label();
            this.LBLUsuario = new System.Windows.Forms.Label();
            this.SubMenuPermisos = new FontAwesome.Sharp.IconMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuariosMenu,
            this.ClientesMenu,
            this.MantenedorMenu,
            this.VentasMenu,
            this.ComprasMenu});
            this.menu.Location = new System.Drawing.Point(0, 53);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menu.Size = new System.Drawing.Size(913, 71);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // UsuariosMenu
            // 
            this.UsuariosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuRoles,
            this.SubMenuPermisos});
            this.UsuariosMenu.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.UsuariosMenu.IconColor = System.Drawing.Color.Black;
            this.UsuariosMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UsuariosMenu.IconSize = 50;
            this.UsuariosMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UsuariosMenu.Name = "UsuariosMenu";
            this.UsuariosMenu.Size = new System.Drawing.Size(64, 69);
            this.UsuariosMenu.Text = "Usuarios";
            this.UsuariosMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.UsuariosMenu.Click += new System.EventHandler(this.UsuariosMenu_Click);
            // 
            // SubMenuRoles
            // 
            this.SubMenuRoles.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuRoles.IconColor = System.Drawing.Color.Black;
            this.SubMenuRoles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuRoles.Name = "SubMenuRoles";
            this.SubMenuRoles.Size = new System.Drawing.Size(188, 30);
            this.SubMenuRoles.Text = "Roles";
            this.SubMenuRoles.Click += new System.EventHandler(this.SubMenuRoles_Click);
            // 
            // ClientesMenu
            // 
            this.ClientesMenu.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.ClientesMenu.IconColor = System.Drawing.Color.Black;
            this.ClientesMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ClientesMenu.IconSize = 50;
            this.ClientesMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ClientesMenu.Name = "ClientesMenu";
            this.ClientesMenu.Size = new System.Drawing.Size(62, 69);
            this.ClientesMenu.Text = "Clientes";
            this.ClientesMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ClientesMenu.Click += new System.EventHandler(this.ClientesMenu_Click);
            // 
            // MantenedorMenu
            // 
            this.MantenedorMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenucategorias,
            this.submenuproductos,
            this.submenuempleados});
            this.MantenedorMenu.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.MantenedorMenu.IconColor = System.Drawing.Color.Black;
            this.MantenedorMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MantenedorMenu.IconSize = 50;
            this.MantenedorMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MantenedorMenu.Name = "MantenedorMenu";
            this.MantenedorMenu.Size = new System.Drawing.Size(95, 69);
            this.MantenedorMenu.Text = "Configuración";
            this.MantenedorMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenucategorias
            // 
            this.submenucategorias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenucategorias.IconColor = System.Drawing.Color.Black;
            this.submenucategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenucategorias.Name = "submenucategorias";
            this.submenucategorias.Size = new System.Drawing.Size(132, 22);
            this.submenucategorias.Text = "Categorías";
            this.submenucategorias.Click += new System.EventHandler(this.submenucategorias_Click);
            // 
            // submenuproductos
            // 
            this.submenuproductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuproductos.IconColor = System.Drawing.Color.Black;
            this.submenuproductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuproductos.Name = "submenuproductos";
            this.submenuproductos.Size = new System.Drawing.Size(132, 22);
            this.submenuproductos.Text = "Productos";
            this.submenuproductos.Click += new System.EventHandler(this.submenuproductos_Click);
            // 
            // submenuempleados
            // 
            this.submenuempleados.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuempleados.IconColor = System.Drawing.Color.Black;
            this.submenuempleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuempleados.Name = "submenuempleados";
            this.submenuempleados.Size = new System.Drawing.Size(132, 22);
            this.submenuempleados.Text = "Empleados";
            this.submenuempleados.Click += new System.EventHandler(this.submenuempleados_Click);
            // 
            // VentasMenu
            // 
            this.VentasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRegistrarVenta,
            this.MenuVerDetalle});
            this.VentasMenu.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.VentasMenu.IconColor = System.Drawing.Color.Black;
            this.VentasMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.VentasMenu.IconSize = 50;
            this.VentasMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.VentasMenu.Name = "VentasMenu";
            this.VentasMenu.Size = new System.Drawing.Size(62, 69);
            this.VentasMenu.Text = "Ventas";
            this.VentasMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuRegistrarVenta
            // 
            this.MenuRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.MenuRegistrarVenta.IconColor = System.Drawing.Color.Black;
            this.MenuRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuRegistrarVenta.Name = "MenuRegistrarVenta";
            this.MenuRegistrarVenta.Size = new System.Drawing.Size(129, 22);
            this.MenuRegistrarVenta.Text = "Registrar";
            this.MenuRegistrarVenta.Click += new System.EventHandler(this.MenuRegistrarVenta_Click);
            // 
            // MenuVerDetalle
            // 
            this.MenuVerDetalle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.MenuVerDetalle.IconColor = System.Drawing.Color.Black;
            this.MenuVerDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuVerDetalle.Name = "MenuVerDetalle";
            this.MenuVerDetalle.Size = new System.Drawing.Size(129, 22);
            this.MenuVerDetalle.Text = "Ver Detalle";
            this.MenuVerDetalle.Click += new System.EventHandler(this.MenuVerDetalle_Click);
            // 
            // ComprasMenu
            // 
            this.ComprasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRegistrarCompra,
            this.MenuVerDetalleCompra});
            this.ComprasMenu.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.ComprasMenu.IconColor = System.Drawing.Color.Black;
            this.ComprasMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ComprasMenu.IconSize = 50;
            this.ComprasMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ComprasMenu.Name = "ComprasMenu";
            this.ComprasMenu.Size = new System.Drawing.Size(67, 69);
            this.ComprasMenu.Text = "Compras";
            this.ComprasMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuRegistrarCompra
            // 
            this.MenuRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.MenuRegistrarCompra.IconColor = System.Drawing.Color.Black;
            this.MenuRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuRegistrarCompra.Name = "MenuRegistrarCompra";
            this.MenuRegistrarCompra.Size = new System.Drawing.Size(129, 22);
            this.MenuRegistrarCompra.Text = "Registrar";
            this.MenuRegistrarCompra.Click += new System.EventHandler(this.MenuRegistrarCompra_Click);
            // 
            // MenuVerDetalleCompra
            // 
            this.MenuVerDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.MenuVerDetalleCompra.IconColor = System.Drawing.Color.Black;
            this.MenuVerDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuVerDetalleCompra.Name = "MenuVerDetalleCompra";
            this.MenuVerDetalleCompra.Size = new System.Drawing.Size(129, 22);
            this.MenuVerDetalleCompra.Text = "Ver Detalle";
            this.MenuVerDetalleCompra.Click += new System.EventHandler(this.MenuVerDetalleCompra_Click);
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menutitulo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(913, 53);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menu";
            // 
            // LabelTituloSistema
            // 
            this.LabelTituloSistema.AutoSize = true;
            this.LabelTituloSistema.BackColor = System.Drawing.Color.SteelBlue;
            this.LabelTituloSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTituloSistema.ForeColor = System.Drawing.Color.White;
            this.LabelTituloSistema.Location = new System.Drawing.Point(19, 12);
            this.LabelTituloSistema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTituloSistema.Name = "LabelTituloSistema";
            this.LabelTituloSistema.Size = new System.Drawing.Size(292, 31);
            this.LabelTituloSistema.TabIndex = 2;
            this.LabelTituloSistema.Text = "Sistema de Gestión FP";
            // 
            // Contenedor
            // 
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 124);
            this.Contenedor.Margin = new System.Windows.Forms.Padding(2);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(913, 363);
            this.Contenedor.TabIndex = 3;
            // 
            // ULabel
            // 
            this.ULabel.AutoSize = true;
            this.ULabel.BackColor = System.Drawing.Color.SteelBlue;
            this.ULabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ULabel.ForeColor = System.Drawing.Color.White;
            this.ULabel.Location = new System.Drawing.Point(744, 12);
            this.ULabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ULabel.Name = "ULabel";
            this.ULabel.Size = new System.Drawing.Size(68, 20);
            this.ULabel.TabIndex = 4;
            this.ULabel.Text = "Usuario:";
            // 
            // LBLUsuario
            // 
            this.LBLUsuario.AutoSize = true;
            this.LBLUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.LBLUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUsuario.ForeColor = System.Drawing.Color.White;
            this.LBLUsuario.Location = new System.Drawing.Point(809, 12);
            this.LBLUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLUsuario.Name = "LBLUsuario";
            this.LBLUsuario.Size = new System.Drawing.Size(93, 20);
            this.LBLUsuario.TabIndex = 5;
            this.LBLUsuario.Text = "LBLUsuario";
            // 
            // SubMenuPermisos
            // 
            this.SubMenuPermisos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuPermisos.IconColor = System.Drawing.Color.Black;
            this.SubMenuPermisos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuPermisos.Name = "SubMenuPermisos";
            this.SubMenuPermisos.Size = new System.Drawing.Size(188, 30);
            this.SubMenuPermisos.Text = "Permisos";
            this.SubMenuPermisos.Click += new System.EventHandler(this.SubMenuPermisos_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.LBLUsuario);
            this.Controls.Add(this.ULabel);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.LabelTituloSistema);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Label ULabel;
        private System.Windows.Forms.Label LBLUsuario;
        private FontAwesome.Sharp.IconMenuItem ComprasMenu;
        private FontAwesome.Sharp.IconMenuItem MantenedorMenu;
        private FontAwesome.Sharp.IconMenuItem submenucategorias;
        private FontAwesome.Sharp.IconMenuItem submenuproductos;
        private FontAwesome.Sharp.IconMenuItem VentasMenu;
        private FontAwesome.Sharp.IconMenuItem submenuempleados;
        private FontAwesome.Sharp.IconMenuItem MenuRegistrarVenta;
        private FontAwesome.Sharp.IconMenuItem MenuVerDetalle;
        private FontAwesome.Sharp.IconMenuItem MenuRegistrarCompra;
        private FontAwesome.Sharp.IconMenuItem MenuVerDetalleCompra;
        private FontAwesome.Sharp.IconMenuItem SubMenuRoles;
        private FontAwesome.Sharp.IconMenuItem SubMenuPermisos;
    }
}


﻿namespace CapaPresentacion
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
            this.SubMenuAbmUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuAgregarUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.MantenedorMenu = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuCategorias = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuUnidadesDeMedida = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuTiposDeImpuesto = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuProductos = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuEmpleados = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuCajas = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuTimbrados = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuTiposDeValor = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuFormasDePago = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuBancos = new FontAwesome.Sharp.IconMenuItem();
            this.ClientesMenu = new FontAwesome.Sharp.IconMenuItem();
            this.VentasMenu = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuAperturaCierreCaja = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuFacturas = new FontAwesome.Sharp.IconMenuItem();
            this.MenuVerDetalle = new FontAwesome.Sharp.IconMenuItem();
            this.ProveedoresMenu = new FontAwesome.Sharp.IconMenuItem();
            this.ComprasMenu = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuVerDetalleCompra = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuPedidos = new FontAwesome.Sharp.IconMenuItem();
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
            this.MantenedorMenu,
            this.ClientesMenu,
            this.VentasMenu,
            this.ProveedoresMenu,
            this.ComprasMenu});
            this.menu.Location = new System.Drawing.Point(0, 82);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(1370, 83);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // UsuariosMenu
            // 
            this.UsuariosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuRoles,
            this.SubMenuAbmUsuarios,
            this.SubMenuAgregarUsuario});
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
            // SubMenuRoles
            // 
            this.SubMenuRoles.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuRoles.IconColor = System.Drawing.Color.Black;
            this.SubMenuRoles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuRoles.Name = "SubMenuRoles";
            this.SubMenuRoles.Size = new System.Drawing.Size(279, 34);
            this.SubMenuRoles.Text = "Roles";
            this.SubMenuRoles.Click += new System.EventHandler(this.SubMenuRoles_Click);
            // 
            // SubMenuAbmUsuarios
            // 
            this.SubMenuAbmUsuarios.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuAbmUsuarios.IconColor = System.Drawing.Color.Black;
            this.SubMenuAbmUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuAbmUsuarios.Name = "SubMenuAbmUsuarios";
            this.SubMenuAbmUsuarios.Size = new System.Drawing.Size(279, 34);
            this.SubMenuAbmUsuarios.Text = "Administrar Usuarios";
            this.SubMenuAbmUsuarios.Click += new System.EventHandler(this.SubMenuAbmUsuarios_Click);
            // 
            // SubMenuAgregarUsuario
            // 
            this.SubMenuAgregarUsuario.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuAgregarUsuario.IconColor = System.Drawing.Color.Black;
            this.SubMenuAgregarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuAgregarUsuario.Name = "SubMenuAgregarUsuario";
            this.SubMenuAgregarUsuario.Size = new System.Drawing.Size(279, 34);
            this.SubMenuAgregarUsuario.Text = "Agregar Usuario";
            this.SubMenuAgregarUsuario.Click += new System.EventHandler(this.SubMenuAgregarUsuario_Click_1);
            // 
            // MantenedorMenu
            // 
            this.MantenedorMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuCategorias,
            this.SubMenuUnidadesDeMedida,
            this.SubMenuTiposDeImpuesto,
            this.SubMenuProductos,
            this.SubMenuEmpleados,
            this.SubMenuCajas,
            this.SubMenuTimbrados,
            this.SubMenuTiposDeValor,
            this.SubMenuFormasDePago,
            this.SubMenuBancos});
            this.MantenedorMenu.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.MantenedorMenu.IconColor = System.Drawing.Color.Black;
            this.MantenedorMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MantenedorMenu.IconSize = 50;
            this.MantenedorMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MantenedorMenu.Name = "MantenedorMenu";
            this.MantenedorMenu.Size = new System.Drawing.Size(139, 79);
            this.MantenedorMenu.Text = "Configuración";
            this.MantenedorMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubMenuCategorias
            // 
            this.SubMenuCategorias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuCategorias.IconColor = System.Drawing.Color.Black;
            this.SubMenuCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuCategorias.Name = "SubMenuCategorias";
            this.SubMenuCategorias.Size = new System.Drawing.Size(278, 34);
            this.SubMenuCategorias.Text = "Categorías";
            this.SubMenuCategorias.Click += new System.EventHandler(this.submenucategorias_Click);
            // 
            // SubMenuUnidadesDeMedida
            // 
            this.SubMenuUnidadesDeMedida.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuUnidadesDeMedida.IconColor = System.Drawing.Color.Black;
            this.SubMenuUnidadesDeMedida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuUnidadesDeMedida.Name = "SubMenuUnidadesDeMedida";
            this.SubMenuUnidadesDeMedida.Size = new System.Drawing.Size(278, 34);
            this.SubMenuUnidadesDeMedida.Text = "Unidades de Medida";
            this.SubMenuUnidadesDeMedida.Click += new System.EventHandler(this.SubMenuUnidadesDeMedida_Click);
            // 
            // SubMenuTiposDeImpuesto
            // 
            this.SubMenuTiposDeImpuesto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuTiposDeImpuesto.IconColor = System.Drawing.Color.Black;
            this.SubMenuTiposDeImpuesto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuTiposDeImpuesto.Name = "SubMenuTiposDeImpuesto";
            this.SubMenuTiposDeImpuesto.Size = new System.Drawing.Size(278, 34);
            this.SubMenuTiposDeImpuesto.Text = "Tipos de Impuesto";
            this.SubMenuTiposDeImpuesto.Click += new System.EventHandler(this.SubMenuTiposDeImpuesto_Click);
            // 
            // SubMenuProductos
            // 
            this.SubMenuProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuProductos.IconColor = System.Drawing.Color.Black;
            this.SubMenuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuProductos.Name = "SubMenuProductos";
            this.SubMenuProductos.Size = new System.Drawing.Size(278, 34);
            this.SubMenuProductos.Text = "Productos";
            this.SubMenuProductos.Click += new System.EventHandler(this.submenuproductos_Click);
            // 
            // SubMenuEmpleados
            // 
            this.SubMenuEmpleados.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuEmpleados.IconColor = System.Drawing.Color.Black;
            this.SubMenuEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuEmpleados.Name = "SubMenuEmpleados";
            this.SubMenuEmpleados.Size = new System.Drawing.Size(278, 34);
            this.SubMenuEmpleados.Text = "Empleados";
            this.SubMenuEmpleados.Click += new System.EventHandler(this.submenuempleados_Click);
            // 
            // SubMenuCajas
            // 
            this.SubMenuCajas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuCajas.IconColor = System.Drawing.Color.Black;
            this.SubMenuCajas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuCajas.Name = "SubMenuCajas";
            this.SubMenuCajas.Size = new System.Drawing.Size(278, 34);
            this.SubMenuCajas.Text = "Cajas";
            this.SubMenuCajas.Click += new System.EventHandler(this.SubMenuCajas_Click);
            // 
            // SubMenuTimbrados
            // 
            this.SubMenuTimbrados.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuTimbrados.IconColor = System.Drawing.Color.Black;
            this.SubMenuTimbrados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuTimbrados.Name = "SubMenuTimbrados";
            this.SubMenuTimbrados.Size = new System.Drawing.Size(278, 34);
            this.SubMenuTimbrados.Text = "Timbrados";
            this.SubMenuTimbrados.Click += new System.EventHandler(this.SubMenuTimbrados_Click);
            // 
            // SubMenuTiposDeValor
            // 
            this.SubMenuTiposDeValor.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuTiposDeValor.IconColor = System.Drawing.Color.Black;
            this.SubMenuTiposDeValor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuTiposDeValor.Name = "SubMenuTiposDeValor";
            this.SubMenuTiposDeValor.Size = new System.Drawing.Size(278, 34);
            this.SubMenuTiposDeValor.Text = "Tipos de Valor";
            this.SubMenuTiposDeValor.Click += new System.EventHandler(this.SubMenuTiposDeValor_Click);
            // 
            // SubMenuFormasDePago
            // 
            this.SubMenuFormasDePago.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuFormasDePago.IconColor = System.Drawing.Color.Black;
            this.SubMenuFormasDePago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuFormasDePago.Name = "SubMenuFormasDePago";
            this.SubMenuFormasDePago.Size = new System.Drawing.Size(278, 34);
            this.SubMenuFormasDePago.Text = "Formas de Pago";
            this.SubMenuFormasDePago.Click += new System.EventHandler(this.SubMenuFormasDePago_Click);
            // 
            // SubMenuBancos
            // 
            this.SubMenuBancos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuBancos.IconColor = System.Drawing.Color.Black;
            this.SubMenuBancos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuBancos.Name = "SubMenuBancos";
            this.SubMenuBancos.Size = new System.Drawing.Size(278, 34);
            this.SubMenuBancos.Text = "Bancos";
            this.SubMenuBancos.Click += new System.EventHandler(this.SubMenuBancos_Click);
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
            this.ClientesMenu.Click += new System.EventHandler(this.ClientesMenu_Click);
            // 
            // VentasMenu
            // 
            this.VentasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuAperturaCierreCaja,
            this.SubMenuFacturas,
            this.MenuVerDetalle});
            this.VentasMenu.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.VentasMenu.IconColor = System.Drawing.Color.Black;
            this.VentasMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.VentasMenu.IconSize = 50;
            this.VentasMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.VentasMenu.Name = "VentasMenu";
            this.VentasMenu.Size = new System.Drawing.Size(80, 79);
            this.VentasMenu.Text = "Ventas";
            this.VentasMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubMenuAperturaCierreCaja
            // 
            this.SubMenuAperturaCierreCaja.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuAperturaCierreCaja.IconColor = System.Drawing.Color.Black;
            this.SubMenuAperturaCierreCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuAperturaCierreCaja.Name = "SubMenuAperturaCierreCaja";
            this.SubMenuAperturaCierreCaja.Size = new System.Drawing.Size(298, 34);
            this.SubMenuAperturaCierreCaja.Text = "Apertura/Cierre de Caja";
            // 
            // SubMenuFacturas
            // 
            this.SubMenuFacturas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuFacturas.IconColor = System.Drawing.Color.Black;
            this.SubMenuFacturas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuFacturas.Name = "SubMenuFacturas";
            this.SubMenuFacturas.Size = new System.Drawing.Size(298, 34);
            this.SubMenuFacturas.Text = "Facturas";
            this.SubMenuFacturas.Click += new System.EventHandler(this.MenuRegistrarVenta_Click);
            // 
            // MenuVerDetalle
            // 
            this.MenuVerDetalle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.MenuVerDetalle.IconColor = System.Drawing.Color.Black;
            this.MenuVerDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuVerDetalle.Name = "MenuVerDetalle";
            this.MenuVerDetalle.Size = new System.Drawing.Size(298, 34);
            this.MenuVerDetalle.Text = "Ver Detalle Facturas";
            this.MenuVerDetalle.Click += new System.EventHandler(this.MenuVerDetalle_Click);
            // 
            // ProveedoresMenu
            // 
            this.ProveedoresMenu.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.ProveedoresMenu.IconColor = System.Drawing.Color.Black;
            this.ProveedoresMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProveedoresMenu.IconSize = 50;
            this.ProveedoresMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ProveedoresMenu.Name = "ProveedoresMenu";
            this.ProveedoresMenu.Size = new System.Drawing.Size(127, 79);
            this.ProveedoresMenu.Text = "Proveedores";
            this.ProveedoresMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ProveedoresMenu.Click += new System.EventHandler(this.ProveedoresMenu_Click);
            // 
            // ComprasMenu
            // 
            this.ComprasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuCompras,
            this.SubMenuVerDetalleCompra,
            this.SubMenuPedidos});
            this.ComprasMenu.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.ComprasMenu.IconColor = System.Drawing.Color.Black;
            this.ComprasMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ComprasMenu.IconSize = 50;
            this.ComprasMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ComprasMenu.Name = "ComprasMenu";
            this.ComprasMenu.Size = new System.Drawing.Size(100, 79);
            this.ComprasMenu.Text = "Compras";
            this.ComprasMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubMenuCompras
            // 
            this.SubMenuCompras.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuCompras.IconColor = System.Drawing.Color.Black;
            this.SubMenuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuCompras.Name = "SubMenuCompras";
            this.SubMenuCompras.Size = new System.Drawing.Size(280, 34);
            this.SubMenuCompras.Text = "Facturas de Compras";
            this.SubMenuCompras.Click += new System.EventHandler(this.MenuRegistrarCompra_Click);
            // 
            // SubMenuVerDetalleCompra
            // 
            this.SubMenuVerDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuVerDetalleCompra.IconColor = System.Drawing.Color.Black;
            this.SubMenuVerDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuVerDetalleCompra.Name = "SubMenuVerDetalleCompra";
            this.SubMenuVerDetalleCompra.Size = new System.Drawing.Size(280, 34);
            this.SubMenuVerDetalleCompra.Text = "Ver Detalle Compras";
            this.SubMenuVerDetalleCompra.Click += new System.EventHandler(this.MenuVerDetalleCompra_Click);
            // 
            // SubMenuPedidos
            // 
            this.SubMenuPedidos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuPedidos.IconColor = System.Drawing.Color.Black;
            this.SubMenuPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuPedidos.Name = "SubMenuPedidos";
            this.SubMenuPedidos.Size = new System.Drawing.Size(280, 34);
            this.SubMenuPedidos.Text = "Pedidos";
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menutitulo.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menutitulo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(1370, 82);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menu";
            // 
            // LabelTituloSistema
            // 
            this.LabelTituloSistema.AutoSize = true;
            this.LabelTituloSistema.BackColor = System.Drawing.Color.SteelBlue;
            this.LabelTituloSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTituloSistema.ForeColor = System.Drawing.Color.White;
            this.LabelTituloSistema.Location = new System.Drawing.Point(28, 18);
            this.LabelTituloSistema.Name = "LabelTituloSistema";
            this.LabelTituloSistema.Size = new System.Drawing.Size(430, 46);
            this.LabelTituloSistema.TabIndex = 2;
            this.LabelTituloSistema.Text = "Sistema de Gestión FP";
            // 
            // Contenedor
            // 
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 165);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1370, 584);
            this.Contenedor.TabIndex = 3;
            // 
            // ULabel
            // 
            this.ULabel.AutoSize = true;
            this.ULabel.BackColor = System.Drawing.Color.SteelBlue;
            this.ULabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ULabel.ForeColor = System.Drawing.Color.White;
            this.ULabel.Location = new System.Drawing.Point(1116, 18);
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
            this.LBLUsuario.Location = new System.Drawing.Point(1214, 18);
            this.LBLUsuario.Name = "LBLUsuario";
            this.LBLUsuario.Size = new System.Drawing.Size(138, 29);
            this.LBLUsuario.TabIndex = 5;
            this.LBLUsuario.Text = "LBLUsuario";
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.LBLUsuario);
            this.Controls.Add(this.ULabel);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.LabelTituloSistema);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGFP ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private FontAwesome.Sharp.IconMenuItem SubMenuCategorias;
        private FontAwesome.Sharp.IconMenuItem SubMenuProductos;
        private FontAwesome.Sharp.IconMenuItem VentasMenu;
        private FontAwesome.Sharp.IconMenuItem SubMenuEmpleados;
        private FontAwesome.Sharp.IconMenuItem SubMenuFacturas;
        private FontAwesome.Sharp.IconMenuItem MenuVerDetalle;
        private FontAwesome.Sharp.IconMenuItem SubMenuCompras;
        private FontAwesome.Sharp.IconMenuItem SubMenuVerDetalleCompra;
        private FontAwesome.Sharp.IconMenuItem SubMenuRoles;
        private FontAwesome.Sharp.IconMenuItem SubMenuAbmUsuarios;
        private FontAwesome.Sharp.IconMenuItem SubMenuAgregarUsuario;
        private FontAwesome.Sharp.IconMenuItem SubMenuUnidadesDeMedida;
        private FontAwesome.Sharp.IconMenuItem SubMenuTiposDeImpuesto;
        private FontAwesome.Sharp.IconMenuItem SubMenuCajas;
        private FontAwesome.Sharp.IconMenuItem SubMenuTimbrados;
        private FontAwesome.Sharp.IconMenuItem SubMenuTiposDeValor;
        private FontAwesome.Sharp.IconMenuItem SubMenuFormasDePago;
        private FontAwesome.Sharp.IconMenuItem SubMenuBancos;
        private FontAwesome.Sharp.IconMenuItem SubMenuAperturaCierreCaja;
        private FontAwesome.Sharp.IconMenuItem ProveedoresMenu;
        private FontAwesome.Sharp.IconMenuItem SubMenuPedidos;
    }
}


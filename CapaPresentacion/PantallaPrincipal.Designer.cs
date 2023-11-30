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
            this.SubMenuTiposDocumentos = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuEmpresa = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuNumeracionDoc = new FontAwesome.Sharp.IconMenuItem();
            this.ClientesMenu = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuListadosClientes = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuListadoClientes = new FontAwesome.Sharp.IconMenuItem();
            this.VentasMenu = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuFacturas = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuAperturaCierreCaja = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuVerDetalleFacturas = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuNCEmitidas = new FontAwesome.Sharp.IconMenuItem();
            this.ProveedoresMenu = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuListadosProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuListadoProveedor = new FontAwesome.Sharp.IconMenuItem();
            this.ComprasMenu = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuPedidos = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuDetallePedidos = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuVerDetalleCompra = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuNCRecibidas = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuVerDetalleNCRecibidas = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuListadosCompras = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuListadoPedidos = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuListadoCompra = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuListadoNCRecibida = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuListadoUltimasCompras = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuListadoComprasSaldos = new FontAwesome.Sharp.IconMenuItem();
            this.StockMenu = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuMovStock = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuVerDetalleMovStock = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuListados = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuListadoExistencia = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuListadoMovstock = new FontAwesome.Sharp.IconMenuItem();
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.LabelTituloSistema = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.ULabel = new System.Windows.Forms.Label();
            this.LBLUsuario = new System.Windows.Forms.Label();
            this.SubMenuVerDetalleNCEmitidas = new FontAwesome.Sharp.IconMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuariosMenu,
            this.MantenedorMenu,
            this.ClientesMenu,
            this.VentasMenu,
            this.ProveedoresMenu,
            this.ComprasMenu,
            this.StockMenu});
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
            this.SubMenuAbmUsuarios,
            this.SubMenuAgregarUsuario});
            this.UsuariosMenu.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.UsuariosMenu.IconColor = System.Drawing.Color.Black;
            this.UsuariosMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UsuariosMenu.IconSize = 50;
            this.UsuariosMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UsuariosMenu.Name = "UsuariosMenu";
            this.UsuariosMenu.Size = new System.Drawing.Size(64, 69);
            this.UsuariosMenu.Text = "Usuarios";
            this.UsuariosMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubMenuRoles
            // 
            this.SubMenuRoles.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuRoles.IconColor = System.Drawing.Color.Black;
            this.SubMenuRoles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuRoles.Name = "SubMenuRoles";
            this.SubMenuRoles.Size = new System.Drawing.Size(184, 22);
            this.SubMenuRoles.Text = "Roles";
            this.SubMenuRoles.Click += new System.EventHandler(this.SubMenuRoles_Click);
            // 
            // SubMenuAbmUsuarios
            // 
            this.SubMenuAbmUsuarios.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuAbmUsuarios.IconColor = System.Drawing.Color.Black;
            this.SubMenuAbmUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuAbmUsuarios.Name = "SubMenuAbmUsuarios";
            this.SubMenuAbmUsuarios.Size = new System.Drawing.Size(184, 22);
            this.SubMenuAbmUsuarios.Text = "Administrar Usuarios";
            this.SubMenuAbmUsuarios.Click += new System.EventHandler(this.SubMenuAbmUsuarios_Click);
            // 
            // SubMenuAgregarUsuario
            // 
            this.SubMenuAgregarUsuario.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuAgregarUsuario.IconColor = System.Drawing.Color.Black;
            this.SubMenuAgregarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuAgregarUsuario.Name = "SubMenuAgregarUsuario";
            this.SubMenuAgregarUsuario.Size = new System.Drawing.Size(184, 22);
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
            this.SubMenuBancos,
            this.SubMenuTiposDocumentos,
            this.SubMenuEmpresa,
            this.SubMenuNumeracionDoc});
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
            // SubMenuCategorias
            // 
            this.SubMenuCategorias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuCategorias.IconColor = System.Drawing.Color.Black;
            this.SubMenuCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuCategorias.Name = "SubMenuCategorias";
            this.SubMenuCategorias.Size = new System.Drawing.Size(227, 22);
            this.SubMenuCategorias.Text = "Categorías";
            this.SubMenuCategorias.Click += new System.EventHandler(this.submenucategorias_Click);
            // 
            // SubMenuUnidadesDeMedida
            // 
            this.SubMenuUnidadesDeMedida.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuUnidadesDeMedida.IconColor = System.Drawing.Color.Black;
            this.SubMenuUnidadesDeMedida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuUnidadesDeMedida.Name = "SubMenuUnidadesDeMedida";
            this.SubMenuUnidadesDeMedida.Size = new System.Drawing.Size(227, 22);
            this.SubMenuUnidadesDeMedida.Text = "Unidades de Medida";
            this.SubMenuUnidadesDeMedida.Click += new System.EventHandler(this.SubMenuUnidadesDeMedida_Click);
            // 
            // SubMenuTiposDeImpuesto
            // 
            this.SubMenuTiposDeImpuesto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuTiposDeImpuesto.IconColor = System.Drawing.Color.Black;
            this.SubMenuTiposDeImpuesto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuTiposDeImpuesto.Name = "SubMenuTiposDeImpuesto";
            this.SubMenuTiposDeImpuesto.Size = new System.Drawing.Size(227, 22);
            this.SubMenuTiposDeImpuesto.Text = "Tipos de Impuesto";
            this.SubMenuTiposDeImpuesto.Click += new System.EventHandler(this.SubMenuTiposDeImpuesto_Click);
            // 
            // SubMenuProductos
            // 
            this.SubMenuProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuProductos.IconColor = System.Drawing.Color.Black;
            this.SubMenuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuProductos.Name = "SubMenuProductos";
            this.SubMenuProductos.Size = new System.Drawing.Size(227, 22);
            this.SubMenuProductos.Text = "Productos";
            this.SubMenuProductos.Click += new System.EventHandler(this.submenuproductos_Click);
            // 
            // SubMenuEmpleados
            // 
            this.SubMenuEmpleados.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuEmpleados.IconColor = System.Drawing.Color.Black;
            this.SubMenuEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuEmpleados.Name = "SubMenuEmpleados";
            this.SubMenuEmpleados.Size = new System.Drawing.Size(227, 22);
            this.SubMenuEmpleados.Text = "Empleados";
            this.SubMenuEmpleados.Click += new System.EventHandler(this.submenuempleados_Click);
            // 
            // SubMenuCajas
            // 
            this.SubMenuCajas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuCajas.IconColor = System.Drawing.Color.Black;
            this.SubMenuCajas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuCajas.Name = "SubMenuCajas";
            this.SubMenuCajas.Size = new System.Drawing.Size(227, 22);
            this.SubMenuCajas.Text = "Cajas";
            this.SubMenuCajas.Click += new System.EventHandler(this.SubMenuCajas_Click);
            // 
            // SubMenuTimbrados
            // 
            this.SubMenuTimbrados.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuTimbrados.IconColor = System.Drawing.Color.Black;
            this.SubMenuTimbrados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuTimbrados.Name = "SubMenuTimbrados";
            this.SubMenuTimbrados.Size = new System.Drawing.Size(227, 22);
            this.SubMenuTimbrados.Text = "Timbrados";
            this.SubMenuTimbrados.Click += new System.EventHandler(this.SubMenuTimbrados_Click);
            // 
            // SubMenuTiposDeValor
            // 
            this.SubMenuTiposDeValor.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuTiposDeValor.IconColor = System.Drawing.Color.Black;
            this.SubMenuTiposDeValor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuTiposDeValor.Name = "SubMenuTiposDeValor";
            this.SubMenuTiposDeValor.Size = new System.Drawing.Size(227, 22);
            this.SubMenuTiposDeValor.Text = "Tipos de Valor";
            this.SubMenuTiposDeValor.Click += new System.EventHandler(this.SubMenuTiposDeValor_Click);
            // 
            // SubMenuFormasDePago
            // 
            this.SubMenuFormasDePago.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuFormasDePago.IconColor = System.Drawing.Color.Black;
            this.SubMenuFormasDePago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuFormasDePago.Name = "SubMenuFormasDePago";
            this.SubMenuFormasDePago.Size = new System.Drawing.Size(227, 22);
            this.SubMenuFormasDePago.Text = "Formas de Pago";
            this.SubMenuFormasDePago.Click += new System.EventHandler(this.SubMenuFormasDePago_Click);
            // 
            // SubMenuBancos
            // 
            this.SubMenuBancos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuBancos.IconColor = System.Drawing.Color.Black;
            this.SubMenuBancos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuBancos.Name = "SubMenuBancos";
            this.SubMenuBancos.Size = new System.Drawing.Size(227, 22);
            this.SubMenuBancos.Text = "Bancos";
            this.SubMenuBancos.Click += new System.EventHandler(this.SubMenuBancos_Click);
            // 
            // SubMenuTiposDocumentos
            // 
            this.SubMenuTiposDocumentos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuTiposDocumentos.IconColor = System.Drawing.Color.Black;
            this.SubMenuTiposDocumentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuTiposDocumentos.Name = "SubMenuTiposDocumentos";
            this.SubMenuTiposDocumentos.Size = new System.Drawing.Size(227, 22);
            this.SubMenuTiposDocumentos.Text = "Tipos Documentos";
            this.SubMenuTiposDocumentos.Click += new System.EventHandler(this.SubMenuTiposDocumentos_Click);
            // 
            // SubMenuEmpresa
            // 
            this.SubMenuEmpresa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuEmpresa.IconColor = System.Drawing.Color.Black;
            this.SubMenuEmpresa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuEmpresa.Name = "SubMenuEmpresa";
            this.SubMenuEmpresa.Size = new System.Drawing.Size(227, 22);
            this.SubMenuEmpresa.Text = "Empresa";
            this.SubMenuEmpresa.Click += new System.EventHandler(this.SubMenuEmpresa_Click);
            // 
            // SubMenuNumeracionDoc
            // 
            this.SubMenuNumeracionDoc.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuNumeracionDoc.IconColor = System.Drawing.Color.Black;
            this.SubMenuNumeracionDoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuNumeracionDoc.Name = "SubMenuNumeracionDoc";
            this.SubMenuNumeracionDoc.Size = new System.Drawing.Size(227, 22);
            this.SubMenuNumeracionDoc.Text = "Numeracion de Documentos";
            this.SubMenuNumeracionDoc.Click += new System.EventHandler(this.SubMenuNumeracionDoc_Click);
            // 
            // ClientesMenu
            // 
            this.ClientesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuClientes,
            this.SubMenuListadosClientes});
            this.ClientesMenu.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.ClientesMenu.IconColor = System.Drawing.Color.Black;
            this.ClientesMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ClientesMenu.IconSize = 50;
            this.ClientesMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ClientesMenu.Name = "ClientesMenu";
            this.ClientesMenu.Size = new System.Drawing.Size(62, 69);
            this.ClientesMenu.Text = "Clientes";
            this.ClientesMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubMenuClientes
            // 
            this.SubMenuClientes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuClientes.IconColor = System.Drawing.Color.Black;
            this.SubMenuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuClientes.Name = "SubMenuClientes";
            this.SubMenuClientes.Size = new System.Drawing.Size(189, 30);
            this.SubMenuClientes.Text = "Administrar Clientes";
            this.SubMenuClientes.Click += new System.EventHandler(this.SubMenuClientes_Click);
            // 
            // SubMenuListadosClientes
            // 
            this.SubMenuListadosClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuListadoClientes});
            this.SubMenuListadosClientes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuListadosClientes.IconColor = System.Drawing.Color.Black;
            this.SubMenuListadosClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuListadosClientes.Name = "SubMenuListadosClientes";
            this.SubMenuListadosClientes.Size = new System.Drawing.Size(189, 30);
            this.SubMenuListadosClientes.Text = "Listados";
            // 
            // SubMenuListadoClientes
            // 
            this.SubMenuListadoClientes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuListadoClientes.IconColor = System.Drawing.Color.Black;
            this.SubMenuListadoClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuListadoClientes.Name = "SubMenuListadoClientes";
            this.SubMenuListadoClientes.Size = new System.Drawing.Size(173, 22);
            this.SubMenuListadoClientes.Text = "Listado de Clientes";
            this.SubMenuListadoClientes.Click += new System.EventHandler(this.SubMenuListadoClientes_Click);
            // 
            // VentasMenu
            // 
            this.VentasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuFacturas,
            this.SubMenuAperturaCierreCaja,
            this.SubMenuVerDetalleFacturas,
            this.SubMenuNCEmitidas,
            this.SubMenuVerDetalleNCEmitidas});
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
            // SubMenuFacturas
            // 
            this.SubMenuFacturas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuFacturas.IconColor = System.Drawing.Color.Black;
            this.SubMenuFacturas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuFacturas.Name = "SubMenuFacturas";
            this.SubMenuFacturas.Size = new System.Drawing.Size(285, 30);
            this.SubMenuFacturas.Text = "Facturas";
            this.SubMenuFacturas.Click += new System.EventHandler(this.MenuRegistrarVenta_Click);
            // 
            // SubMenuAperturaCierreCaja
            // 
            this.SubMenuAperturaCierreCaja.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuAperturaCierreCaja.IconColor = System.Drawing.Color.Black;
            this.SubMenuAperturaCierreCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuAperturaCierreCaja.Name = "SubMenuAperturaCierreCaja";
            this.SubMenuAperturaCierreCaja.Size = new System.Drawing.Size(285, 30);
            this.SubMenuAperturaCierreCaja.Text = "Apertura/Cierre Caja";
            this.SubMenuAperturaCierreCaja.Click += new System.EventHandler(this.SubMenuAperturaCierreCaja_Click);
            // 
            // SubMenuVerDetalleFacturas
            // 
            this.SubMenuVerDetalleFacturas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuVerDetalleFacturas.IconColor = System.Drawing.Color.Black;
            this.SubMenuVerDetalleFacturas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuVerDetalleFacturas.Name = "SubMenuVerDetalleFacturas";
            this.SubMenuVerDetalleFacturas.Size = new System.Drawing.Size(285, 30);
            this.SubMenuVerDetalleFacturas.Text = "Consulta de Facturas";
            this.SubMenuVerDetalleFacturas.Click += new System.EventHandler(this.MenuVerDetalle_Click);
            // 
            // SubMenuNCEmitidas
            // 
            this.SubMenuNCEmitidas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuNCEmitidas.IconColor = System.Drawing.Color.Black;
            this.SubMenuNCEmitidas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuNCEmitidas.Name = "SubMenuNCEmitidas";
            this.SubMenuNCEmitidas.Size = new System.Drawing.Size(285, 30);
            this.SubMenuNCEmitidas.Text = "Notas de Crédito Emitidas";
            this.SubMenuNCEmitidas.Click += new System.EventHandler(this.SubMenuNCEmitida_Click);
            // 
            // ProveedoresMenu
            // 
            this.ProveedoresMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuProveedores,
            this.SubMenuListadosProveedores});
            this.ProveedoresMenu.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.ProveedoresMenu.IconColor = System.Drawing.Color.Black;
            this.ProveedoresMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProveedoresMenu.IconSize = 50;
            this.ProveedoresMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ProveedoresMenu.Name = "ProveedoresMenu";
            this.ProveedoresMenu.Size = new System.Drawing.Size(84, 69);
            this.ProveedoresMenu.Text = "Proveedores";
            this.ProveedoresMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubMenuProveedores
            // 
            this.SubMenuProveedores.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuProveedores.IconColor = System.Drawing.Color.Black;
            this.SubMenuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuProveedores.Name = "SubMenuProveedores";
            this.SubMenuProveedores.Size = new System.Drawing.Size(204, 22);
            this.SubMenuProveedores.Text = "Administrar Proveedores";
            this.SubMenuProveedores.Click += new System.EventHandler(this.SubMenuProveedores_Click);
            // 
            // SubMenuListadosProveedores
            // 
            this.SubMenuListadosProveedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuListadoProveedor});
            this.SubMenuListadosProveedores.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuListadosProveedores.IconColor = System.Drawing.Color.Black;
            this.SubMenuListadosProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuListadosProveedores.Name = "SubMenuListadosProveedores";
            this.SubMenuListadosProveedores.Size = new System.Drawing.Size(204, 22);
            this.SubMenuListadosProveedores.Text = "Listados";
            // 
            // SubMenuListadoProveedor
            // 
            this.SubMenuListadoProveedor.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuListadoProveedor.IconColor = System.Drawing.Color.Black;
            this.SubMenuListadoProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuListadoProveedor.Name = "SubMenuListadoProveedor";
            this.SubMenuListadoProveedor.Size = new System.Drawing.Size(196, 22);
            this.SubMenuListadoProveedor.Text = "Listado de Proveedores";
            this.SubMenuListadoProveedor.Click += new System.EventHandler(this.SubMenuListadoProveedor_Click);
            // 
            // ComprasMenu
            // 
            this.ComprasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuPedidos,
            this.SubMenuDetallePedidos,
            this.SubMenuCompras,
            this.SubMenuVerDetalleCompra,
            this.SubMenuNCRecibidas,
            this.SubMenuVerDetalleNCRecibidas,
            this.SubMenuListadosCompras});
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
            // SubMenuPedidos
            // 
            this.SubMenuPedidos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuPedidos.IconColor = System.Drawing.Color.Black;
            this.SubMenuPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuPedidos.Name = "SubMenuPedidos";
            this.SubMenuPedidos.Size = new System.Drawing.Size(282, 22);
            this.SubMenuPedidos.Text = "Pedidos";
            this.SubMenuPedidos.Click += new System.EventHandler(this.SubMenuPedidos_Click);
            // 
            // SubMenuDetallePedidos
            // 
            this.SubMenuDetallePedidos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuDetallePedidos.IconColor = System.Drawing.Color.Black;
            this.SubMenuDetallePedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuDetallePedidos.Name = "SubMenuDetallePedidos";
            this.SubMenuDetallePedidos.Size = new System.Drawing.Size(282, 22);
            this.SubMenuDetallePedidos.Text = "Consulta de Pedidos";
            this.SubMenuDetallePedidos.Click += new System.EventHandler(this.SubMenuDetallePedidos_Click);
            // 
            // SubMenuCompras
            // 
            this.SubMenuCompras.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuCompras.IconColor = System.Drawing.Color.Black;
            this.SubMenuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuCompras.Name = "SubMenuCompras";
            this.SubMenuCompras.Size = new System.Drawing.Size(282, 22);
            this.SubMenuCompras.Text = "Compras";
            this.SubMenuCompras.Click += new System.EventHandler(this.MenuRegistrarCompra_Click);
            // 
            // SubMenuVerDetalleCompra
            // 
            this.SubMenuVerDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuVerDetalleCompra.IconColor = System.Drawing.Color.Black;
            this.SubMenuVerDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuVerDetalleCompra.Name = "SubMenuVerDetalleCompra";
            this.SubMenuVerDetalleCompra.Size = new System.Drawing.Size(282, 22);
            this.SubMenuVerDetalleCompra.Text = "Consulta de Compras";
            this.SubMenuVerDetalleCompra.Click += new System.EventHandler(this.MenuVerDetalleCompra_Click);
            // 
            // SubMenuNCRecibidas
            // 
            this.SubMenuNCRecibidas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuNCRecibidas.IconColor = System.Drawing.Color.Black;
            this.SubMenuNCRecibidas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuNCRecibidas.Name = "SubMenuNCRecibidas";
            this.SubMenuNCRecibidas.Size = new System.Drawing.Size(282, 22);
            this.SubMenuNCRecibidas.Text = "Notas de Crédito Recibidas";
            this.SubMenuNCRecibidas.Click += new System.EventHandler(this.SubMenuNCRecibidas_Click);
            // 
            // SubMenuVerDetalleNCRecibidas
            // 
            this.SubMenuVerDetalleNCRecibidas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuVerDetalleNCRecibidas.IconColor = System.Drawing.Color.Black;
            this.SubMenuVerDetalleNCRecibidas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuVerDetalleNCRecibidas.Name = "SubMenuVerDetalleNCRecibidas";
            this.SubMenuVerDetalleNCRecibidas.Size = new System.Drawing.Size(282, 22);
            this.SubMenuVerDetalleNCRecibidas.Text = "Consulta de Notas de Crédito Recibidas";
            this.SubMenuVerDetalleNCRecibidas.Click += new System.EventHandler(this.SubMenuVerDetalleNCRecibidas_Click);
            // 
            // SubMenuListadosCompras
            // 
            this.SubMenuListadosCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuListadoPedidos,
            this.SubMenuListadoCompra,
            this.SubMenuListadoNCRecibida,
            this.SubMenuListadoUltimasCompras,
            this.SubMenuListadoComprasSaldos});
            this.SubMenuListadosCompras.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuListadosCompras.IconColor = System.Drawing.Color.Black;
            this.SubMenuListadosCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuListadosCompras.Name = "SubMenuListadosCompras";
            this.SubMenuListadosCompras.Size = new System.Drawing.Size(282, 22);
            this.SubMenuListadosCompras.Text = "Listados";
            // 
            // SubMenuListadoPedidos
            // 
            this.SubMenuListadoPedidos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuListadoPedidos.IconColor = System.Drawing.Color.Black;
            this.SubMenuListadoPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuListadoPedidos.Name = "SubMenuListadoPedidos";
            this.SubMenuListadoPedidos.Size = new System.Drawing.Size(300, 22);
            this.SubMenuListadoPedidos.Text = "Listado de Pedidos";
            this.SubMenuListadoPedidos.Click += new System.EventHandler(this.SubMenuListadoPedidos_Click);
            // 
            // SubMenuListadoCompra
            // 
            this.SubMenuListadoCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuListadoCompra.IconColor = System.Drawing.Color.Black;
            this.SubMenuListadoCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuListadoCompra.Name = "SubMenuListadoCompra";
            this.SubMenuListadoCompra.Size = new System.Drawing.Size(300, 22);
            this.SubMenuListadoCompra.Text = "Listado de Compras";
            this.SubMenuListadoCompra.Click += new System.EventHandler(this.SubMenuListadoCompra_Click);
            // 
            // SubMenuListadoNCRecibida
            // 
            this.SubMenuListadoNCRecibida.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuListadoNCRecibida.IconColor = System.Drawing.Color.Black;
            this.SubMenuListadoNCRecibida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuListadoNCRecibida.Name = "SubMenuListadoNCRecibida";
            this.SubMenuListadoNCRecibida.Size = new System.Drawing.Size(300, 22);
            this.SubMenuListadoNCRecibida.Text = "Listado de Notas de Crédito Recibidas";
            this.SubMenuListadoNCRecibida.Click += new System.EventHandler(this.SubMenuListadoNCRecibida_Click);
            // 
            // SubMenuListadoUltimasCompras
            // 
            this.SubMenuListadoUltimasCompras.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuListadoUltimasCompras.IconColor = System.Drawing.Color.Black;
            this.SubMenuListadoUltimasCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuListadoUltimasCompras.Name = "SubMenuListadoUltimasCompras";
            this.SubMenuListadoUltimasCompras.Size = new System.Drawing.Size(300, 22);
            this.SubMenuListadoUltimasCompras.Text = "Listado de Últimas Compras por Proveedor";
            this.SubMenuListadoUltimasCompras.Click += new System.EventHandler(this.SubMenuListadoUltimasCompras_Click);
            // 
            // SubMenuListadoComprasSaldos
            // 
            this.SubMenuListadoComprasSaldos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuListadoComprasSaldos.IconColor = System.Drawing.Color.Black;
            this.SubMenuListadoComprasSaldos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuListadoComprasSaldos.Name = "SubMenuListadoComprasSaldos";
            this.SubMenuListadoComprasSaldos.Size = new System.Drawing.Size(300, 22);
            this.SubMenuListadoComprasSaldos.Text = "Listado de Saldos de Facturas";
            this.SubMenuListadoComprasSaldos.Click += new System.EventHandler(this.SubMenuListadoComprasSaldos_Click);
            // 
            // StockMenu
            // 
            this.StockMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuMovStock,
            this.SubMenuVerDetalleMovStock,
            this.SubMenuListados});
            this.StockMenu.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            this.StockMenu.IconColor = System.Drawing.Color.Black;
            this.StockMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.StockMenu.IconSize = 50;
            this.StockMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.StockMenu.Name = "StockMenu";
            this.StockMenu.Size = new System.Drawing.Size(62, 69);
            this.StockMenu.Text = "Stock";
            this.StockMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubMenuMovStock
            // 
            this.SubMenuMovStock.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuMovStock.IconColor = System.Drawing.Color.Black;
            this.SubMenuMovStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuMovStock.Name = "SubMenuMovStock";
            this.SubMenuMovStock.Size = new System.Drawing.Size(242, 22);
            this.SubMenuMovStock.Text = "Movimientos Stock";
            this.SubMenuMovStock.Click += new System.EventHandler(this.SubMenuMovStock_Click);
            // 
            // SubMenuVerDetalleMovStock
            // 
            this.SubMenuVerDetalleMovStock.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuVerDetalleMovStock.IconColor = System.Drawing.Color.Black;
            this.SubMenuVerDetalleMovStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuVerDetalleMovStock.Name = "SubMenuVerDetalleMovStock";
            this.SubMenuVerDetalleMovStock.Size = new System.Drawing.Size(242, 22);
            this.SubMenuVerDetalleMovStock.Text = "Consulta de Movimientos Stock";
            this.SubMenuVerDetalleMovStock.Click += new System.EventHandler(this.SubMenuVerDetalleMovStock_Click);
            // 
            // SubMenuListados
            // 
            this.SubMenuListados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuListadoExistencia,
            this.SubMenuListadoMovstock});
            this.SubMenuListados.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuListados.IconColor = System.Drawing.Color.Black;
            this.SubMenuListados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuListados.Name = "SubMenuListados";
            this.SubMenuListados.Size = new System.Drawing.Size(242, 22);
            this.SubMenuListados.Text = "Listados";
            // 
            // SubMenuListadoExistencia
            // 
            this.SubMenuListadoExistencia.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuListadoExistencia.IconColor = System.Drawing.Color.Black;
            this.SubMenuListadoExistencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuListadoExistencia.Name = "SubMenuListadoExistencia";
            this.SubMenuListadoExistencia.Size = new System.Drawing.Size(233, 22);
            this.SubMenuListadoExistencia.Text = "Listado de Existencia";
            this.SubMenuListadoExistencia.Click += new System.EventHandler(this.SubMenuListadoExistencia_Click);
            // 
            // SubMenuListadoMovstock
            // 
            this.SubMenuListadoMovstock.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuListadoMovstock.IconColor = System.Drawing.Color.Black;
            this.SubMenuListadoMovstock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuListadoMovstock.Name = "SubMenuListadoMovstock";
            this.SubMenuListadoMovstock.Size = new System.Drawing.Size(233, 22);
            this.SubMenuListadoMovstock.Text = "Listado de Movimientos Stock";
            this.SubMenuListadoMovstock.Click += new System.EventHandler(this.SubMenuListadoMovstock_Click);
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
            // SubMenuVerDetalleNCEmitidas
            // 
            this.SubMenuVerDetalleNCEmitidas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuVerDetalleNCEmitidas.IconColor = System.Drawing.Color.Black;
            this.SubMenuVerDetalleNCEmitidas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuVerDetalleNCEmitidas.Name = "SubMenuVerDetalleNCEmitidas";
            this.SubMenuVerDetalleNCEmitidas.Size = new System.Drawing.Size(285, 30);
            this.SubMenuVerDetalleNCEmitidas.Text = "Consulta de Notas de Crédito Emitidas";
            this.SubMenuVerDetalleNCEmitidas.Click += new System.EventHandler(this.SubMenuVerDetalleNCEmitidas_Click);
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
        private FontAwesome.Sharp.IconMenuItem SubMenuVerDetalleFacturas;
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
        private FontAwesome.Sharp.IconMenuItem ProveedoresMenu;
        private FontAwesome.Sharp.IconMenuItem SubMenuPedidos;
        private FontAwesome.Sharp.IconMenuItem SubMenuTiposDocumentos;
        private FontAwesome.Sharp.IconMenuItem SubMenuAperturaCierreCaja;
        private FontAwesome.Sharp.IconMenuItem SubMenuDetallePedidos;
        private FontAwesome.Sharp.IconMenuItem SubMenuEmpresa;
        private FontAwesome.Sharp.IconMenuItem StockMenu;
        private FontAwesome.Sharp.IconMenuItem SubMenuMovStock;
        private FontAwesome.Sharp.IconMenuItem SubMenuVerDetalleMovStock;
        private FontAwesome.Sharp.IconMenuItem SubMenuListados;
        private FontAwesome.Sharp.IconMenuItem SubMenuListadoExistencia;
        private FontAwesome.Sharp.IconMenuItem SubMenuNCRecibidas;
        private FontAwesome.Sharp.IconMenuItem SubMenuVerDetalleNCRecibidas;
        private FontAwesome.Sharp.IconMenuItem SubMenuNumeracionDoc;
        private FontAwesome.Sharp.IconMenuItem SubMenuClientes;
        private FontAwesome.Sharp.IconMenuItem SubMenuListadosClientes;
        private FontAwesome.Sharp.IconMenuItem SubMenuListadoClientes;
        private FontAwesome.Sharp.IconMenuItem SubMenuProveedores;
        private FontAwesome.Sharp.IconMenuItem SubMenuListadosProveedores;
        private FontAwesome.Sharp.IconMenuItem SubMenuListadoProveedor;
        private FontAwesome.Sharp.IconMenuItem SubMenuListadosCompras;
        private FontAwesome.Sharp.IconMenuItem SubMenuListadoCompra;
        private FontAwesome.Sharp.IconMenuItem SubMenuListadoPedidos;
        private FontAwesome.Sharp.IconMenuItem SubMenuListadoMovstock;
        private FontAwesome.Sharp.IconMenuItem SubMenuListadoNCRecibida;
        private FontAwesome.Sharp.IconMenuItem SubMenuListadoUltimasCompras;
        private FontAwesome.Sharp.IconMenuItem SubMenuListadoComprasSaldos;
        private FontAwesome.Sharp.IconMenuItem SubMenuNCEmitidas;
        private FontAwesome.Sharp.IconMenuItem SubMenuVerDetalleNCEmitidas;
    }
}


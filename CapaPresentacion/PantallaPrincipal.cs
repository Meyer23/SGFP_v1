using CapaEntidad.Models;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using CapaPresentacion.Interfaces;
using CapaPresentacion.Reportes;

namespace CapaPresentacion
{
    public partial class PantallaPrincipal : Form
    {
        private static UsuarioLogin usuarioActual;

        private static IconMenuItem MenuActivo = null;

        private static Form FormularioActivo = null;

        public PantallaPrincipal(UsuarioLogin usuarioLogin)
        {
            usuarioActual = usuarioLogin;

            InitializeComponent();
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            List<Modulo> modulos = new CN_Modulos().ObtenerModulos(usuarioActual.Id);  

            foreach(IconMenuItem iconmenu in menu.Items)
            {
                bool encontrado = modulos.Any(m => m.Menu == iconmenu.Name && m.Visualiza == true);
                if(encontrado == false)
                {
                    iconmenu.Visible = false;
                }
                else
                {
                    foreach(IconMenuItem iconsubmenu in iconmenu.DropDownItems)
                    {
                        bool encontrado2 = modulos.Any(m => m.Menu == iconsubmenu.Name && m.Visualiza == true);
                        if (encontrado2 == false)
                        {
                            iconsubmenu.Visible = false;
                        }
                        else
                        {
                            foreach (IconMenuItem iconsubmenu2 in iconsubmenu.DropDownItems)
                            {
                                bool encontrado3 = modulos.Any(m => m.Menu == iconsubmenu2.Name && m.Visualiza == true);
                                if (encontrado3 == false)
                                {
                                    iconsubmenu2.Visible = false;
                                }
                            }
                        }
                    }
                }
            }

            LBLUsuario.Text = usuarioActual.Login;
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if(formulario is IFormularioConIdUsuario formularioconidusuario)
            {
                formularioconidusuario.IdUsuario = usuarioActual.Id;
            }

            if(MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;

            MenuActivo = menu;

            if(FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

            Contenedor.Controls.Add(formulario);                
            formulario.Show();
        }

        private void submenucategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MantenedorMenu, new FrmCategorias(usuarioActual));
        }

        private void submenuproductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MantenedorMenu, new FrmProductos());
        }

        private void submenuempleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MantenedorMenu, new FrmEmpleados());
        }

        //private void ClientesMenu_Click(object sender, EventArgs e)
        //{
        //    AbrirFormulario((IconMenuItem)sender, new FrmClientes());
        //}

        private void MenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(VentasMenu, new FrmRegistrarVenta(usuarioActual));
        }

        private void MenuVerDetalle_Click(object sender, EventArgs e)
        {
            AbrirFormulario(VentasMenu, new FrmVerDetalleVenta(usuarioActual));
        }

        private void MenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ComprasMenu, new FrmCompras(usuarioActual));
        }

        private void MenuVerDetalleCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ComprasMenu, new FrmVerDetalleCompra(usuarioActual));
        }

        private void SubMenuRoles_Click(object sender, EventArgs e)
        {
            AbrirFormulario(SubMenuRoles, new FrmRoles());
        }

        private void SubMenuAgregarUsuario_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(SubMenuAgregarUsuario, new FrmAgregarUsuario());
        }

        private void SubMenuAbmUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(SubMenuAbmUsuarios, new FrmUsuarios());
        }

        private void SubMenuTiposDeImpuesto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MantenedorMenu, new FrmImpuestos());
        }

        private void SubMenuUnidadesDeMedida_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MantenedorMenu, new FrmUnidadesMedida());
        }

        //private void ProveedoresMenu_Click(object sender, EventArgs e)
        //{
        //    AbrirFormulario(ProveedoresMenu, new FrmProveedores());
        //}

        private void SubMenuTiposDeValor_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MantenedorMenu, new FrmValores());
        }

        private void SubMenuFormasDePago_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MantenedorMenu, new FrmFormasPago());
        }

        private void SubMenuBancos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MantenedorMenu, new FrmBancos());
        }

        private void SubMenuTimbrados_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MantenedorMenu, new FrmTimbrados());
        }

        private void SubMenuCajas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MantenedorMenu, new FrmCajas());
        }

        private void SubMenuPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ComprasMenu, new FrmPedidos(usuarioActual));
        }

        private void SubMenuTiposDocumentos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MantenedorMenu, new FrmTiposDocumentos());
        }

        private void SubMenuAperturaCierreCaja_Click(object sender, EventArgs e)
        {
            AbrirFormulario(VentasMenu, new FrmAperturaCierreCaja(usuarioActual));
        }

        private void SubMenuDetallePedidos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ComprasMenu, new FrmVerDetallePedido(usuarioActual));
        }

        private void SubMenuEmpresa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MantenedorMenu, new FrmEmpresa());
        }

        //private void SubMenuConfirmarPedido_Click(object sender, EventArgs e)
        //{
        //    AbrirFormulario(ComprasMenu, new FrmConfirmarPedido());
        //}

        //private void SubMenuConfirmarCompra_Click(object sender, EventArgs e)
        //{
        //    AbrirFormulario(ComprasMenu, new FrmConfirmarCompra());
        //}

        //private void SubMenuAnularCompra_Click(object sender, EventArgs e)
        //{
        //    AbrirFormulario(ComprasMenu, new FrmAnularCompra());
        //}

        private void SubMenuMovStock_Click(object sender, EventArgs e)
        {
            AbrirFormulario(StockMenu, new FrmMovimientosStock(usuarioActual));
        }

        //private void SubMenuConfirmarMovStock_Click(object sender, EventArgs e)
        //{
        //    AbrirFormulario(StockMenu, new FrmConfirmarMovStock());
        //}

        //private void SubMenuAnularMovStock_Click(object sender, EventArgs e)
        //{
        //    AbrirFormulario(StockMenu, new FrmAnularMovStock());
        //}

        private void SubMenuVerDetalleMovStock_Click(object sender, EventArgs e)
        {
            AbrirFormulario(StockMenu, new FrmVerDetalleMovStock(usuarioActual));
        }

        private void SubMenuListadoExistencia_Click(object sender, EventArgs e)
        {
            Reportes.FrmRptProductos oRptProductos = new Reportes.FrmRptProductos();
            oRptProductos.ShowDialog();
        }

        private void SubMenuNCRecibidas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ComprasMenu, new FrmNotasCreditoRecibidas(usuarioActual));
        }

        private void SubMenuVerDetalleNCRecibidas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ComprasMenu, new FrmVerDetalleNotasCreditoRecibidas(usuarioActual));
        }

        private void SubMenuNumeracionDoc_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MantenedorMenu, new FrmNumeracionDocumento());
        }

        private void SubMenuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ClientesMenu, new FrmClientes());
        }

        private void SubMenuListadoClientes_Click(object sender, EventArgs e)
        {
            Reportes.FrmRptClientes oRptClientes = new Reportes.FrmRptClientes();
            oRptClientes.ShowDialog();
        }

        private void SubMenuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ProveedoresMenu, new FrmProveedores());
        }

        private void SubMenuListadoProveedor_Click(object sender, EventArgs e)
        {
            Reportes.FrmRptProveedores oRptProveedores = new Reportes.FrmRptProveedores();
            oRptProveedores.ShowDialog();
        }

        private void SubMenuListadoCompra_Click(object sender, EventArgs e)
        {
            Reportes.FrmRptListadoCompras oRptListadoCompras = new Reportes.FrmRptListadoCompras();
            oRptListadoCompras.ShowDialog();
        }

        private void SubMenuListadoPedidos_Click(object sender, EventArgs e)
        {
            Reportes.FrmRptListadoPedidos oRptListadoPedidos = new Reportes.FrmRptListadoPedidos();
            oRptListadoPedidos.ShowDialog();
        }

        private void SubMenuListadoMovstock_Click(object sender, EventArgs e)
        {
            Reportes.FrmRptListadoMovimientoStock oRptListadoMovStock = new Reportes.FrmRptListadoMovimientoStock();
            oRptListadoMovStock.ShowDialog();
        }

        private void SubMenuListadoNCRecibida_Click(object sender, EventArgs e)
        {
            Reportes.FrmRptListadoNCRecibidas oRptListadoNCRecibida = new Reportes.FrmRptListadoNCRecibidas();
            oRptListadoNCRecibida.ShowDialog();
        }

        private void SubMenuListadoUltimasCompras_Click(object sender, EventArgs e)
        {
            Reportes.FrmRptUltimasCompras oRptListadoUltimasCompras = new Reportes.FrmRptUltimasCompras();
            oRptListadoUltimasCompras.ShowDialog();
        }

        private void SubMenuListadoComprasSaldos_Click(object sender, EventArgs e)
        {
            Reportes.FrmRptListadoComprasSaldos oRptListadoComprasSaldos = new Reportes.FrmRptListadoComprasSaldos();
            oRptListadoComprasSaldos.ShowDialog();
        }

        private void SubMenuNCEmitida_Click(object sender, EventArgs e)
        {
            AbrirFormulario(VentasMenu, new FrmNotasCreditoEmitidas(usuarioActual));
        }

        private void SubMenuVerDetalleNCEmitidas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(VentasMenu, new FrmVerDetalleNCEmitida(usuarioActual));
        }

        private void SubMenuListadoFacturas_Click(object sender, EventArgs e)
        {
            Reportes.FrmRptListadoVentas oRptListadoVentas = new Reportes.FrmRptListadoVentas();
            oRptListadoVentas.ShowDialog();
        }

        private void SubMenuListadoNCEmitidas_Click(object sender, EventArgs e)
        {
            Reportes.FrmRptListadoNCEmitidas oRptListadoNCEmitidas = new Reportes.FrmRptListadoNCEmitidas();
            oRptListadoNCEmitidas.ShowDialog();
        }
    }
}
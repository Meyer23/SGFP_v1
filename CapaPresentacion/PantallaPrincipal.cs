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
            AbrirFormulario(MantenedorMenu, new FrmCategorias());
        }

        private void submenuproductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MantenedorMenu, new FrmProductos());
        }

        private void submenuempleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MantenedorMenu, new FrmEmpleados());
        }

        private void ClientesMenu_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmClientes());
        }

        private void MenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(VentasMenu, new FrmRegistrarVenta(usuarioActual));
        }

        private void MenuVerDetalle_Click(object sender, EventArgs e)
        {
            AbrirFormulario(VentasMenu, new FrmVerDetalleVenta());
        }

        private void MenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ComprasMenu, new FrmCompras(usuarioActual));
        }

        private void MenuVerDetalleCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ComprasMenu, new FrmVerDetalleCompra());
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

        private void ProveedoresMenu_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ProveedoresMenu, new FrmProveedores());
        }

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
            AbrirFormulario(ComprasMenu, new FrmVerDetallePedido());
        }

        private void SubMenuEmpresa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MantenedorMenu, new FrmEmpresa());
        }

        private void SubMenuConfirmarPedido_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ComprasMenu, new FrmConfirmarPedido());
        }

        private void SubMenuConfirmarCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ComprasMenu, new FrmConfirmarCompra());
        }
    }
}
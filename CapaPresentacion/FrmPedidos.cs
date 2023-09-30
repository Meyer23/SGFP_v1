using CapaEntidad;
using CapaEntidad.Models;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPedidos : Form
    {
        private UsuarioLogin _Usuario;
        public FrmPedidos(UsuarioLogin oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
            CargarFormasPago();
            CargarTiposDocumentos();
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            
        }

        private void CargarFormasPago()
        {
            List<FormaPago> formasPago = new CN_FormasPago().ObtenerFormasPago();
            ComboFormaPago.DataSource = formasPago;

            foreach (FormaPago formaPago in formasPago)
            {
                ComboFormaPago.DisplayMember = "Descripcion";
            }
        }

        private void CargarTiposDocumentos()
        {
            List<TipoDocumento> tiposDocumentos = new CN_TiposDocumentos().ObtenerTiposDocumentos();
            ComboTipoDoc.DataSource = tiposDocumentos;

            foreach (TipoDocumento tipoDocumento in tiposDocumentos)
            {
                ComboTipoDoc.DisplayMember = "Descripcion";
            }
        }

        private void BtnBuscarProv_Click(object sender, EventArgs e)
        {
            using (var popup = new PopUpProveedores())
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtIdProveedor.Text =  popup._Proveedor.Id.ToString();
                    TxtRUC.Text = popup._Proveedor.Documento;
                    TxtRazonSocial.Text = popup._Proveedor.RazonSocial;
                    TxtObs.Select();
                }
                else
                {
                    TxtRUC.Select();
                }
            }
        }

        private void BntBuscarProd_Click(object sender, EventArgs e)
        {
            using (var popup = new PopUpProductos())
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtIdProducto.Text = popup._Producto.Id.ToString();
                    TxtCodProducto.Text = popup._Producto.Codigo;
                    TxtDescProducto.Text = popup._Producto.Descripcion;
                    TxtPrecioCompra.Select();
                }
                else
                {
                    TxtCodProducto.Select();
                }
            }
        }

        private void TxtCodProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                Producto oProducto = new CN_Productos().Listar().Where(p => p.Codigo == TxtCodProducto.Text && p.Activo == true).FirstOrDefault();
                if (oProducto != null)
                {
                    TxtIdProducto.Text = oProducto.Id.ToString();
                    TxtDescProducto.Text = oProducto.Descripcion;
                    TxtPrecioCompra.Select();
                }
                else
                {
                    TxtCodProducto.BackColor = Color.MistyRose;
                    TxtIdProducto.Text = "0";
                    TxtDescProducto.Text = "";
                }
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}

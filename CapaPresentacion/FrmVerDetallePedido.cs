using CapaEntidad;
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
    public partial class FrmVerDetallePedido : Form
    {
        public FrmVerDetallePedido()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Pedido objPedido = new CN_Pedidos().ObtenerPedido(Convert.ToInt32(TxtBusqueda.Text));

            if(objPedido.Id != 0)
            {
                TxtNumeroPedido.Text = objPedido.NumeroPedido.ToString();

                TxtNroPedido.Text = objPedido.NumeroPedido.ToString();
                dtpFecha.Value = objPedido.Fecha;
                dtpFechaRequerida.Value = objPedido.FechaRequerida;
                TxtUsuario.Text = objPedido.NombreUsuario;
                TxtTipoDoc.Text = objPedido.TipoDocumento;
                TxtFormaPago.Text = objPedido.FormaPago;
                TxtRUC.Text = objPedido.Documento;
                TxtRazonSocial.Text = objPedido.RazonSocial;
                TxtObs.Text = objPedido.Observacion;
                TxtTotalPedido.Text = objPedido.Total.ToString();

                dgvData.Rows.Clear();

                foreach(PedidoDetalle pd in objPedido.Detalle)
                {
                    dgvData.Rows.Add(new object[] { pd.IdProducto, pd.Descripcion, pd.Precio, pd.Cantidad, pd.Total });
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtBusqueda.Clear();
            TxtNroPedido.Clear();
            dtpFecha.Value = DateTime.Now;
            dtpFechaRequerida.Value = DateTime.Now;
            TxtUsuario.Clear();
            TxtTipoDoc.Clear();
            TxtFormaPago.Clear();
            TxtObs.Clear();
            TxtRUC.Clear();
            TxtRazonSocial.Clear();
            TxtTotalPedido.Clear();
            dgvData.Rows.Clear();
        }
    }
}

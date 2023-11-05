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
    public partial class FrmConfirmarPedido : Form
    {
        public FrmConfirmarPedido()
        {
            InitializeComponent();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (TxtNumeroPedido.Text == "0")
            {
                MessageBox.Show("Debe seleccionar un pedido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtBusqueda.Focus();
                TxtBusqueda.SelectAll();
                return;
            }
            else
            {
                string Mensaje = string.Empty;

                bool Respuesta = new CN_Pedidos().ConfirmarPedido(Convert.ToInt32(TxtNumeroPedido.Text), out Mensaje);

                if (Respuesta)
                {
                    var result = MessageBox.Show("Pedido confirmado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        dtpFecha.Value = DateTime.Now;
                        TxtProveedor.Clear();
                        TxtTotalPedido.Clear();
                        TxtBusqueda.Clear();
                        TxtNumeroPedido.Clear();
                    }
                }
                else
                {
                    MessageBox.Show(Mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            using (var popup = new PopUpPedidos(2))
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.OK)
                { 
                    TxtBusqueda.Text = popup._Pedido.NumeroPedido.ToString();
                    TxtNumeroPedido.Text = popup._Pedido.NumeroPedido.ToString();
                    dtpFecha.Value = popup._Pedido.Fecha;
                    TxtProveedor.Text = popup._Pedido.RazonSocial.ToString();
                    TxtTotalPedido.Text = popup._Pedido.Total.ToString();
                }
                else
                {
                    TxtBusqueda.Select();
                }
            }
        }
    }
}

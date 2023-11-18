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
    public partial class FrmAnularCompra : Form
    {
        private int _IdCompra;
        public FrmAnularCompra(int IdCompra = 0)
        {
            _IdCompra = IdCompra;
            InitializeComponent();
            CargarMotivos();
        }

        //private void BtnBuscar_Click(object sender, EventArgs e)
        //{
        //    using (var popup = new PopUpCompras(2))
        //    {
        //        var result = popup.ShowDialog();

        //        if (result == DialogResult.OK)
        //        {
        //            TxtIdCompra.Text = popup._Compra.Id.ToString();
        //            TxtBusqueda.Text = popup._Compra.NumeroFactura.ToString();
        //            dtpFecha.Value = popup._Compra.Fecha;
        //            TxtProveedor.Text = popup._Compra.RazonSocial.ToString();
        //            TxtTotalCompra.Text = popup._Compra.Total.ToString();
        //        }
        //        else
        //        {
        //            TxtBusqueda.Select();
        //        }
        //    }
        //}

        //private void BtnLimpiar_Click(object sender, EventArgs e)
        //{
        //    dtpFecha.Value = DateTime.Now;
        //    TxtProveedor.Clear();
        //    TxtTotalCompra.Clear();
        //    TxtIdCompra.Clear();
        //    TxtBusqueda.Clear();
        //}

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            //if (TxtIdCompra.Text == "0")
            //{
            //    MessageBox.Show("Debe seleccionar una compra", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    TxtBusqueda.Focus();
            //    TxtBusqueda.SelectAll();
            //    return;
            //}
            //else
            //{
                string Mensaje = string.Empty;

                bool Respuesta = new CN_Compras().AnularCompra(_IdCompra, ComboMotivos.Text.ToString(), out Mensaje);

                if (Respuesta)
                {
                    var result = MessageBox.Show("Compra anulada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        ComboMotivos.SelectedIndex = 0;
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(Mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            //}
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarMotivos()
        {
            List<MotivoAnulacion> motivos = new CN_Anulaciones().ObtenerMotivosAnulaciones();
            ComboMotivos.DataSource = motivos;

            foreach (MotivoAnulacion motivo in motivos)
            {
                ComboMotivos.DisplayMember = "Descripcion";
            }
        }
    }
}

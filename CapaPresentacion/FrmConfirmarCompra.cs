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
    public partial class FrmConfirmarCompra : Form
    {
        private int _IdCompra;
        public FrmConfirmarCompra(int IdCompra = 0)
        {
            _IdCompra = IdCompra;
            InitializeComponent();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
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

                bool Respuesta = new CN_Compras().ConfirmarCompra(_IdCompra, dtpFechaRec.Value, out Mensaje);

                if (Respuesta)
                {
                    var result = MessageBox.Show("Compra confirmada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        dtpFechaRec.Value = DateTime.Now;                        
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

        //private void BtnBuscar_Click(object sender, EventArgs e)
        //{
        //    using (var popup = new PopUpCompras(1))
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
        //    dtpFechaRec.Value = DateTime.Now;
        //    TxtProveedor.Clear();
        //    TxtTotalCompra.Clear();
        //    TxtIdCompra.Clear();
        //    TxtBusqueda.Clear();
        //}

        //private void FrmConfirmarCompra_Load(object sender, EventArgs e)
        //{
        //    dtpFecha.Value = DateTime.Now;
        //    dtpFechaRec.Value = DateTime.Now;
        //}

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

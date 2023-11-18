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
    public partial class FrmAnularMovStock : Form
    {
        private int _IdMovStock;
        private string _TipoMov;
        public FrmAnularMovStock(int IdMovStock = 0, string TipoMov = null)
        {
            _IdMovStock = IdMovStock;
            _TipoMov = TipoMov;
            InitializeComponent();
            CargarMotivos();
        }

        //private void BtnBuscar_Click(object sender, EventArgs e)
        //{
        //    using (var popup = new PopUpMovStock(2))
        //    {
        //        var result = popup.ShowDialog();

        //        if (result == DialogResult.OK)
        //        {
        //            TxtIdMovStock.Text = popup._MovimientoStock.Id.ToString();
        //            TxtBusqueda.Text = popup._MovimientoStock.Documento.ToString();
        //            dtpFecha.Value = popup._MovimientoStock.Fecha;
        //            TxtTipoMovimiento.Text = popup._MovimientoStock.TipoMovimiento.ToString();
        //            TxtTotalCantidad.Text = popup._MovimientoStock.Total.ToString();
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
        //    TxtIdMovStock.Clear();
        //    TxtBusqueda.Clear();
        //    TxtTipoMovimiento.Clear();
        //    TxtTotalCantidad.Clear();
        //}

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            //if (TxtIdMovStock.Text == "0")
            //{
            //    MessageBox.Show("Debe seleccionar un movimiento stock", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    TxtBusqueda.Focus();
            //    TxtBusqueda.SelectAll();
            //    return;
            //}
            //else
            //{
                string Mensaje = string.Empty;

                bool Respuesta = new CN_MovimientosStock().AnularMovStock(_IdMovStock, _TipoMov, ComboMotivos.Text.ToString(), out Mensaje);

                if (Respuesta)
                {
                    var result = MessageBox.Show("Movimiento stock anulado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //private void FrmAnularMovStock_Load(object sender, EventArgs e)
        //{
        //    dtpFecha.Value = DateTime.Now;
        //}

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

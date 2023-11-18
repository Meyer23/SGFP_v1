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
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace CapaPresentacion
{
    public partial class FrmVerDetalleMovStock : Form
    {
        public FrmVerDetalleMovStock()
        {
            InitializeComponent();
        }

        private void FrmVerDetalleMovStock_Load(object sender, EventArgs e)
        {
            LblConfirmado.Visible = false;
            PbConfirmado.Visible = false;
            LblNoConfirmado.Visible = false;
            PbNoConfirmado.Visible = false;
            LblAnulado.Visible = false;
            dtpFecha.Value = DateTime.Now;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            using (var popup = new PopUpMovStock(0))
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    MovimientoStock objMovStock = new CN_MovimientosStock().ObtenerMovStock(Convert.ToInt32(popup._MovimientoStock.Id.ToString()));
                    if (objMovStock.Id != 0)
                    {
                        TxtTipoMov.Text = objMovStock.TipoMovimiento.ToString();
                        TxtDocumento.Text = objMovStock.Documento;
                        dtpFecha.Value = objMovStock.Fecha;
                        TxtUsuario.Text = objMovStock.NombreUsuario;
                        TxtObs.Text = objMovStock.Observacion;
                        TxtTotalCantidad.Text = objMovStock.Total.ToString();
                        checkBoxConfirmado.Checked = objMovStock.Confirmado;
                        checkBoxAnulado.Checked = objMovStock.Anulado;

                        if (checkBoxConfirmado.Checked == true && checkBoxAnulado.Checked == false)
                        {
                            LblConfirmado.Visible = true;
                            PbConfirmado.Visible = true;
                            LblNoConfirmado.Visible = false;
                            PbNoConfirmado.Visible = false;
                            LblAnulado.Visible = false;
                        }
                        else if (checkBoxConfirmado.Checked == false && checkBoxAnulado.Checked == false)
                        {
                            LblNoConfirmado.Visible = true;
                            //PbNoConfirmado.Visible = true;
                            LblConfirmado.Visible = false;
                            PbConfirmado.Visible = false;
                            LblAnulado.Visible = false;
                        }
                        else
                        {
                            LblNoConfirmado.Visible = false;
                            PbNoConfirmado.Visible = true;
                            LblConfirmado.Visible = false;
                            PbConfirmado.Visible = false;
                            LblAnulado.Visible = true;
                        }

                        dgvData.Rows.Clear();

                        foreach (DetalleProductos pd in objMovStock.Detalle)
                        {
                            dgvData.Rows.Add(new object[] { pd.IdProducto, pd.Descripcion, pd.Cantidad });
                        }
                    }
                }
                else
                {
                    TxtBusqueda.Select();
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtTipoMov.Clear();
            TxtDocumento.Clear();
            dtpFecha.Value = DateTime.Now;
            TxtUsuario.Clear();
            TxtObs.Clear();
            TxtTotalCantidad.Clear();
            dgvData.Rows.Clear();
            LblConfirmado.Visible = false;
            PbConfirmado.Visible = false;
            LblNoConfirmado.Visible = false;
            PbNoConfirmado.Visible = false;
            LblAnulado.Visible = false;
        }

        private void TxtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MovimientoStock objMovStock = new CN_MovimientosStock().ObtenerMovStock(Convert.ToInt32(Convert.ToInt32(TxtBusqueda.Text)));
                if (objMovStock.Id != 0)
                {
                    TxtTipoMov.Text = objMovStock.TipoMovimiento.ToString();
                    TxtDocumento.Text = objMovStock.Documento;
                    dtpFecha.Value = objMovStock.Fecha;
                    TxtUsuario.Text = objMovStock.NombreUsuario;
                    TxtObs.Text = objMovStock.Observacion;
                    TxtTotalCantidad.Text = objMovStock.Total.ToString();
                    checkBoxConfirmado.Checked = objMovStock.Confirmado;
                    checkBoxAnulado.Checked = objMovStock.Anulado;

                    if (checkBoxConfirmado.Checked == true && checkBoxAnulado.Checked == false)
                    {
                        LblConfirmado.Visible = true;
                        PbConfirmado.Visible = true;
                        LblNoConfirmado.Visible = false;
                        PbNoConfirmado.Visible = false;
                        LblAnulado.Visible = false;
                    }
                    else if (checkBoxConfirmado.Checked == false && checkBoxAnulado.Checked == false)
                    {
                        LblNoConfirmado.Visible = true;
                        //PbNoConfirmado.Visible = true;
                        LblConfirmado.Visible = false;
                        PbConfirmado.Visible = false;
                        LblAnulado.Visible = false;
                    }
                    else
                    {
                        LblNoConfirmado.Visible = false;
                        PbNoConfirmado.Visible = true;
                        LblConfirmado.Visible = false;
                        PbConfirmado.Visible = false;
                        LblAnulado.Visible = true;
                    }

                    dgvData.Rows.Clear();

                    foreach (DetalleProductos pd in objMovStock.Detalle)
                    {
                        dgvData.Rows.Add(new object[] { pd.IdProducto, pd.Descripcion, pd.Cantidad });
                    }
                }
            }
        }
    }
}

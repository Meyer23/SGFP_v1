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
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace CapaPresentacion
{
    public partial class FrmVerDetalleMovStock : Form
    {
        bool confirma, anula;
        private UsuarioLogin _Usuario;
        public FrmVerDetalleMovStock(UsuarioLogin oUsuario = null)
        {
            _Usuario = oUsuario;
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
            BtnConfirmarMovStock.Visible = false;
            BtnAnularMovStock.Visible = false;

            List<Proceso> procesos = new CN_Procesos().ObtenerProcesos(_Usuario.Id);
            foreach (Proceso proceso in procesos)
            {
                confirma = procesos.Any(m => m.Boton == BtnConfirmarMovStock.Name && m.Procesa == true);
                anula = procesos.Any(m => m.Boton == BtnAnularMovStock.Name && m.Procesa == true);
            }
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
                        TxtIdMovStock.Text = objMovStock.Id.ToString();
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
                            BtnConfirmarMovStock.Visible = false;
                            BtnAnularMovStock.Visible = false;
                        }
                        else if (checkBoxConfirmado.Checked == false && checkBoxAnulado.Checked == false)
                        {
                            LblNoConfirmado.Visible = true;
                            //PbNoConfirmado.Visible = true;
                            LblConfirmado.Visible = false;
                            PbConfirmado.Visible = false;
                            LblAnulado.Visible = false;
                            if (confirma)
                            {
                                BtnConfirmarMovStock.Visible = true;
                            }
                            if (anula)
                            {
                                BtnAnularMovStock.Visible = true;
                            }
                        }
                        else
                        {
                            LblNoConfirmado.Visible = false;
                            PbNoConfirmado.Visible = true;
                            LblConfirmado.Visible = false;
                            PbConfirmado.Visible = false;
                            LblAnulado.Visible = true;
                            BtnConfirmarMovStock.Visible = false;
                            BtnAnularMovStock.Visible = false;
                        }

                        dgvData.Rows.Clear();

                        foreach (DetalleProductos pd in objMovStock.Detalle)
                        {
                            dgvData.Rows.Add(new object[] { pd.IdProducto, pd.Codigo, pd.Descripcion, pd.Cantidad });
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
                        BtnConfirmarMovStock.Visible = false;
                        BtnAnularMovStock.Visible = false;
                    }
                    else if (checkBoxConfirmado.Checked == false && checkBoxAnulado.Checked == false)
                    {
                        LblNoConfirmado.Visible = true;
                        //PbNoConfirmado.Visible = true;
                        LblConfirmado.Visible = false;
                        PbConfirmado.Visible = false;
                        LblAnulado.Visible = false;
                        if (confirma)
                        {
                            BtnConfirmarMovStock.Visible = true;
                        }
                        if (anula)
                        {
                            BtnAnularMovStock.Visible = true;
                        }
                    }
                    else
                    {
                        LblNoConfirmado.Visible = false;
                        PbNoConfirmado.Visible = true;
                        LblConfirmado.Visible = false;
                        PbConfirmado.Visible = false;
                        LblAnulado.Visible = true;
                        BtnConfirmarMovStock.Visible = false;
                        BtnAnularMovStock.Visible = false;
                    }

                    dgvData.Rows.Clear();

                    foreach (DetalleProductos pd in objMovStock.Detalle)
                    {
                        dgvData.Rows.Add(new object[] { pd.IdProducto, pd.Descripcion, pd.Cantidad });
                    }
                }
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (TxtIdMovStock.Text == "0")
            {
                MessageBox.Show("Debe seleccionar un movimiento stock", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtBusqueda.Focus();
                TxtBusqueda.SelectAll();
                return;
            }
            else
            {
                string Mensaje = string.Empty;

                bool Respuesta = new CN_MovimientosStock().ConfirmarMovStock(Convert.ToInt32(TxtIdMovStock.Text), TxtTipoMov.Text, out Mensaje);

                if (Respuesta)
                {
                    var result = MessageBox.Show("Movimiento Stock confirmado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        LblConfirmado.Visible = true;
                        PbConfirmado.Visible = true;
                        LblNoConfirmado.Visible = false;
                        BtnConfirmarMovStock.Visible = false;
                        BtnAnularMovStock.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show(Mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            using (var popup = new FrmAnularMovStock(Convert.ToInt32(TxtIdMovStock.Text), TxtTipoMov.Text))
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LblConfirmado.Visible = false;
                    PbConfirmado.Visible = false;
                    LblNoConfirmado.Visible = false;
                    LblAnulado.Visible = true;
                    PbNoConfirmado.Visible = true;
                    BtnAnularMovStock.Visible = false;
                }
                else
                {
                    TxtBusqueda.Select();
                }
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            Reportes.FrmRptMovimientosStock oRptMovStock = new Reportes.FrmRptMovimientosStock();
            oRptMovStock.TxtParamId.Text = TxtIdMovStock.Text;
            oRptMovStock.ShowDialog();
        }
    }
}

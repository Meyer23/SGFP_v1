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
            using (var popup = new PopUpPedidos(0))
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Pedido objPedido = new CN_Pedidos().ObtenerPedido(Convert.ToInt32(popup._Pedido.NumeroPedido.ToString()));
                    if (objPedido.Id != 0)
                    {
                        TxtNumeroPedido.Text = objPedido.NumeroPedido.ToString();
                        TxtIdPedido.Text = objPedido.Id.ToString();
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
                        checkBoxConfirmado.Checked = objPedido.Confirmado;
                        checkBoxAnulado.Checked = objPedido.Anulado;

                        if (checkBoxConfirmado.Checked == true && checkBoxAnulado.Checked == false)
                        {
                            LblConfirmado.Visible = true;
                            PbConfirmado.Visible = true;
                            LblNoConfirmado.Visible = false;
                            PbNoConfirmado.Visible = false;
                            LblAnulado.Visible = false;
                            BtnConfirmar.Visible = false;
                            BtnAnular.Visible = false;
                        }
                        else if (checkBoxConfirmado.Checked == false && checkBoxAnulado.Checked == false)
                        {
                            LblNoConfirmado.Visible = true;
                            //PbNoConfirmado.Visible = true;
                            LblConfirmado.Visible = false;
                            PbConfirmado.Visible = false;
                            LblAnulado.Visible = false;
                            BtnConfirmar.Visible = true;
                            BtnAnular.Visible = true;
                        }
                        else
                        {
                            LblNoConfirmado.Visible = false;
                            PbNoConfirmado.Visible = true;
                            LblConfirmado.Visible = false;
                            PbConfirmado.Visible = false;
                            LblAnulado.Visible = true;
                            BtnConfirmar.Visible = false;
                            BtnAnular.Visible = false;
                        }

                        dgvData.Rows.Clear();

                        foreach (DetalleProductos pd in objPedido.Detalle)
                        {
                            dgvData.Rows.Add(new object[] { pd.IdProducto, pd.Codigo, pd.Descripcion, pd.Precio, pd.Cantidad, pd.Total });
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
            LblConfirmado.Visible = false;
            PbConfirmado.Visible = false;
            LblNoConfirmado.Visible = false;
            //PbNoConfirmado.Visible = false;
            BtnConfirmar.Visible = false;
        }

        private void TxtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Pedido objPedido = new CN_Pedidos().ObtenerPedido(Convert.ToInt32(TxtBusqueda.Text));
                if (objPedido.Id != 0)
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
                   checkBoxConfirmado.Checked = objPedido.Confirmado;

                   if(checkBoxConfirmado.Checked == true && checkBoxAnulado.Checked == false)
                   {
                        LblConfirmado.Visible = true;
                        PbConfirmado.Visible = true;
                        LblNoConfirmado.Visible = false;
                        PbNoConfirmado.Visible = false;
                        LblAnulado.Visible = false;
                        BtnConfirmar.Visible = false;
                        BtnAnular.Visible = false;
                   }                
                   else if (checkBoxConfirmado.Checked == false && checkBoxAnulado.Checked == false)
                   {
                        LblNoConfirmado.Visible = true;
                        //PbNoConfirmado.Visible = true;
                        LblConfirmado.Visible = false;
                        PbConfirmado.Visible = false;
                        LblAnulado.Visible = false;
                        BtnConfirmar.Visible = true;
                        BtnAnular.Visible = true;
                   }
                   else
                   {
                        LblNoConfirmado.Visible = false;
                        PbNoConfirmado.Visible = true;
                        LblConfirmado.Visible = false;
                        PbConfirmado.Visible = false;
                        LblAnulado.Visible = true;
                        BtnConfirmar.Visible = false;
                        BtnAnular.Visible = false;
                   }

                    dgvData.Rows.Clear();

                   foreach (DetalleProductos pd in objPedido.Detalle)
                   {
                        dgvData.Rows.Add(new object[] { pd.IdProducto, pd.Descripcion, pd.Precio, pd.Cantidad, pd.Total });
                   }
                }
                else
                {
                    TxtNumeroPedido.BackColor = Color.MistyRose;
                    TxtNumeroPedido.Clear();
                }
            }
        }

        private void FrmVerDetallePedido_Load(object sender, EventArgs e)
        {
            LblConfirmado.Visible = false;
            PbConfirmado.Visible = false;
            LblNoConfirmado.Visible = false;
            PbNoConfirmado.Visible = false;
            LblAnulado.Visible = false;
            dtpFecha.Value = DateTime.Now;
            dtpFechaRequerida.Value = DateTime.Now;
            BtnConfirmar.Visible = false;
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
                        LblConfirmado.Visible = true;
                        PbConfirmado.Visible = true;
                        LblNoConfirmado.Visible = false;
                        BtnConfirmar.Visible = false;
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
            using (var popup = new FrmAnularPedido(Convert.ToInt32(TxtIdPedido.Text)))
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LblConfirmado.Visible = false;
                    PbConfirmado.Visible = false;
                    LblNoConfirmado.Visible = false;
                    LblAnulado.Visible = true;
                    PbNoConfirmado.Visible = true;
                    BtnAnular.Visible = false;
                    BtnConfirmar.Visible = false;
                }
                else
                {
                    TxtBusqueda.Select();
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Reportes.FrmRptPedidos oRptPedidos = new Reportes.FrmRptPedidos();
            oRptPedidos.TxtParamId.Text = TxtIdPedido.Text;
            oRptPedidos.ShowDialog();
        }
    }
}

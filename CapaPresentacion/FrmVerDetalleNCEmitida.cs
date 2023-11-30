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

namespace CapaPresentacion
{
    public partial class FrmVerDetalleNCEmitida : Form
    {
        bool confirma, anula, imprime;
        private UsuarioLogin _Usuario;

        private void FrmVerDetalleNCEmitida_Load(object sender, EventArgs e)
        {
            LblConfirmado.Visible = false;
            PbConfirmado.Visible = false;
            LblNoConfirmado.Visible = false;
            PbNoConfirmado.Visible = false;
            LblAnulado.Visible = false;
            dtpFecha.Value = DateTime.Now;
            dtpInicioVigencia.Value = DateTime.Now;
            dtpFinVigencia.Value = DateTime.Now;
            BtnConfirmarNCEmitida.Visible = false;
            BtnAnularNCEmitida.Visible = false;
            BtnImprimirNCEmitida.Visible = false;

            List<Proceso> procesos = new CN_Procesos().ObtenerProcesos(_Usuario.Id);
            foreach (Proceso proceso in procesos)
            {
                confirma = procesos.Any(m => m.Boton == BtnConfirmarNCEmitida.Name && m.Procesa == true);
                anula = procesos.Any(m => m.Boton == BtnAnularNCEmitida.Name && m.Procesa == true);
                imprime = procesos.Any(m => m.Boton == BtnImprimirNCEmitida.Name && m.Procesa == true);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            using (var popup = new PopUpNCEmitidas(0))
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    NotaCreditoEmitida objNota = new CN_NotasCreditoEmitidas().ObtenerNota(Convert.ToInt32(popup._NCEmitida.Id.ToString()));
                    if (objNota.Id != 0)
                    {
                        TxtIdNCEmitida.Text = objNota.Id.ToString();
                        TxtBusqueda.Text = objNota.NumeroNota.ToString();
                        TxtFacturaCompra.Text = objNota.NumeroFactura.ToString();
                        TxtIdVenta.Text = objNota.idVenta.ToString();
                        TxtTipoDoc.Text = objNota.TipoDocumento;
                        TxtCajero.Text = objNota.NombreCajero;
                        TxtCodEstablecimiento.Text = objNota.CodEstablecimiento.ToString();
                        TxtPuntoEmision.Text = objNota.PuntoEmision.ToString();
                        TxtDoc.Text = objNota.Doc;
                        dtpFecha.Value = objNota.Fecha;
                        TxtTimbrado.Text = objNota.Timbrado.ToString();
                        dtpInicioVigencia.Value = objNota.InicioVigencia;
                        dtpFinVigencia.Value = objNota.FinVigencia;
                        TxtRUC.Text = objNota.Documento;
                        TxtRazonSocial.Text = objNota.Nombre;
                        TxtObs.Text = objNota.Observacion;
                        TxtTotalNota.Text = objNota.Total.ToString();
                        checkBoxConfirmado.Checked = objNota.Confirmado;
                        checkBoxAnulado.Checked = objNota.Anulado;

                        if (checkBoxConfirmado.Checked == true && checkBoxAnulado.Checked == false)
                        {
                            LblConfirmado.Visible = true;
                            PbConfirmado.Visible = true;
                            LblNoConfirmado.Visible = false;
                            PbNoConfirmado.Visible = false;
                            LblAnulado.Visible = false;
                            BtnConfirmarNCEmitida.Visible = false;
                            BtnAnularNCEmitida.Visible = false;
                            if (imprime)
                            {
                                BtnImprimirNCEmitida.Visible = true;
                            }                           
                        }
                        else if (checkBoxConfirmado.Checked == false && checkBoxAnulado.Checked == false)
                        {
                            LblNoConfirmado.Visible = true;
                            //PbNoConfirmado.Visible = true;
                            LblConfirmado.Visible = false;
                            PbConfirmado.Visible = false;
                            LblAnulado.Visible = false;
                            BtnImprimirNCEmitida.Visible = false;
                            if (confirma)
                            {
                                BtnConfirmarNCEmitida.Visible = true;
                            }
                            if (anula)
                            {
                                BtnAnularNCEmitida.Visible = true;
                            }
                        }
                        else
                        {
                            LblNoConfirmado.Visible = false;
                            PbNoConfirmado.Visible = true;
                            LblConfirmado.Visible = false;
                            PbConfirmado.Visible = false;
                            LblAnulado.Visible = true;
                            BtnImprimirNCEmitida.Visible = false;
                            BtnConfirmarNCEmitida.Visible = false;
                            BtnAnularNCEmitida.Visible = false;
                        }
                        

                        dgvData.Rows.Clear();

                        foreach (DetalleProductos pd in objNota.Detalle)
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

        public FrmVerDetalleNCEmitida(UsuarioLogin oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void TxtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                NotaCreditoEmitida objNota = new CN_NotasCreditoEmitidas().ObtenerNota(Convert.ToInt32(TxtIdNCEmitida.Text));
                if (objNota.Id != 0)
                {
                    TxtIdNCEmitida.Text = objNota.Id.ToString();
                    TxtBusqueda.Text = objNota.NumeroNota.ToString();
                    TxtFacturaCompra.Text = objNota.NumeroFactura.ToString();
                    TxtIdVenta.Text = objNota.idVenta.ToString();
                    TxtTipoDoc.Text = objNota.TipoDocumento;
                    TxtCajero.Text = objNota.NombreCajero;
                    TxtCodEstablecimiento.Text = objNota.CodEstablecimiento.ToString();
                    TxtPuntoEmision.Text = objNota.PuntoEmision.ToString();
                    TxtDoc.Text = objNota.Doc;
                    dtpFecha.Value = objNota.Fecha;
                    TxtTimbrado.Text = objNota.Timbrado.ToString();
                    dtpInicioVigencia.Value = objNota.InicioVigencia;
                    dtpFinVigencia.Value = objNota.FinVigencia;
                    TxtRUC.Text = objNota.Documento;
                    TxtRazonSocial.Text = objNota.Nombre;
                    TxtObs.Text = objNota.Observacion;
                    TxtTotalNota.Text = objNota.Total.ToString();
                    checkBoxConfirmado.Checked = objNota.Confirmado;
                    checkBoxAnulado.Checked = objNota.Anulado;

                    if (checkBoxConfirmado.Checked == true && checkBoxAnulado.Checked == false)
                    {
                        LblConfirmado.Visible = true;
                        PbConfirmado.Visible = true;
                        LblNoConfirmado.Visible = false;
                        PbNoConfirmado.Visible = false;
                        LblAnulado.Visible = false;
                        BtnConfirmarNCEmitida.Visible = false;
                        BtnAnularNCEmitida.Visible = false;
                        if (imprime)
                        {
                            BtnImprimirNCEmitida.Visible = true;
                        }
                    }
                    else if (checkBoxConfirmado.Checked == false && checkBoxAnulado.Checked == false)
                    {
                        LblNoConfirmado.Visible = true;
                        //PbNoConfirmado.Visible = true;
                        LblConfirmado.Visible = false;
                        PbConfirmado.Visible = false;
                        LblAnulado.Visible = false;
                        BtnImprimirNCEmitida.Visible = false;
                        if (confirma)
                        {
                            BtnConfirmarNCEmitida.Visible = true;
                        }
                        if (anula)
                        {
                            BtnAnularNCEmitida.Visible = true;
                        }
                    }
                    else
                    {
                        LblNoConfirmado.Visible = false;
                        PbNoConfirmado.Visible = true;
                        LblConfirmado.Visible = false;
                        PbConfirmado.Visible = false;
                        LblAnulado.Visible = true;
                        BtnConfirmarNCEmitida.Visible = false;
                        BtnAnularNCEmitida.Visible = false;
                        BtnImprimirNCEmitida.Visible = false;
                    }

                    dgvData.Rows.Clear();

                    foreach (DetalleProductos pd in objNota.Detalle)
                    {
                        dgvData.Rows.Add(new object[] { pd.IdProducto, pd.Codigo, pd.Descripcion, pd.Precio, pd.Cantidad, pd.Total });
                    }
                }
                else
                {
                    TxtBusqueda.BackColor = Color.MistyRose;
                    TxtBusqueda.Clear();
                }
            }
        }

        private void BtnConfirmarNCEmitida_Click(object sender, EventArgs e)
        {
            if (TxtIdNCEmitida.Text == "0")
            {
                MessageBox.Show("Debe seleccionar una nota de crédito", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtBusqueda.Focus();
                TxtBusqueda.SelectAll();
                return;
            }
            else
            {
                string Mensaje = string.Empty;

                bool Respuesta = new CN_NotasCreditoEmitidas().ConfirmarNota(Convert.ToInt32(TxtIdNCEmitida.Text), Convert.ToInt32(TxtIdVenta.Text), out Mensaje);

                if (Respuesta)
                {
                    var result = MessageBox.Show("Nota de Crédito confirmada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        LblConfirmado.Visible = true;
                        PbConfirmado.Visible = true;
                        LblNoConfirmado.Visible = false;
                        BtnConfirmarNCEmitida.Visible = false;
                        BtnAnularNCEmitida.Visible = false;
                        if (imprime)
                        {
                            BtnImprimirNCEmitida.Visible = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show(Mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void BtnAnularNCEmitida_Click(object sender, EventArgs e)
        {
            using (var popup = new FrmAnularNCEmitidas(Convert.ToInt32(TxtIdNCEmitida.Text)))
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LblConfirmado.Visible = false;
                    PbConfirmado.Visible = false;
                    LblNoConfirmado.Visible = false;
                    LblAnulado.Visible = true;
                    PbNoConfirmado.Visible = true;
                    BtnAnularNCEmitida.Visible = false;
                    BtnConfirmarNCEmitida.Visible = false;
                }
                else
                {
                    TxtBusqueda.Select();
                }
            }
        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            TxtBusqueda.Clear();
            TxtFacturaCompra.Clear();
            TxtCodEstablecimiento.Clear();
            TxtPuntoEmision.Clear();
            TxtDoc.Clear();
            TxtTimbrado.Clear();
            dtpFecha.Value = DateTime.Now;
            TxtCajero.Clear();
            TxtTipoDoc.Clear();
            TxtObs.Clear();
            TxtRUC.Clear();
            TxtRazonSocial.Clear();
            TxtTotalNota.Clear();
            dgvData.Rows.Clear();
            LblConfirmado.Visible = false;
            PbConfirmado.Visible = false;
            LblNoConfirmado.Visible = false;
            PbNoConfirmado.Visible = false;
            LblAnulado.Visible = false;
            BtnImprimirNCEmitida.Visible = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Reportes.FrmRptNCEmitidas oRptNCEmitidas = new Reportes.FrmRptNCEmitidas();
            oRptNCEmitidas.TxtParamId.Text = TxtIdNCEmitida.Text;
            oRptNCEmitidas.ShowDialog();
        }
    }
}

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
    public partial class FrmVerDetalleNotasCreditoRecibidas : Form
    {
        bool confirma, anula;
        private UsuarioLogin _Usuario;
        public FrmVerDetalleNotasCreditoRecibidas(UsuarioLogin oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void FrmVerDetalleNotasCreditoRecibidas_Load(object sender, EventArgs e)
        {
            LblConfirmado.Visible = false;
            PbConfirmado.Visible = false;
            LblNoConfirmado.Visible = false;
            PbNoConfirmado.Visible = false;
            LblAnulado.Visible = false;
            dtpFecha.Value = DateTime.Now;
            dtpInicioVigencia.Value = DateTime.Now;
            dtpFinVigencia.Value = DateTime.Now;
            BtnConfirmarNCRecibida.Visible = false;
            BtnAnularNCRecibida.Visible = false;

            List<Proceso> procesos = new CN_Procesos().ObtenerProcesos(_Usuario.Id);
            foreach (Proceso proceso in procesos)
            {
                confirma = procesos.Any(m => m.Boton == BtnConfirmarNCRecibida.Name && m.Procesa == true);
                anula = procesos.Any(m => m.Boton == BtnAnularNCRecibida.Name && m.Procesa == true);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            using (var popup = new PopUpNotasCreditoRecibidas(0))
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    NotaCreditoRecibida objNota = new CN_NotasCreditoRecibidas().ObtenerNota(Convert.ToInt32(popup._NCRecibida.Id.ToString()));
                    if (objNota.Id != 0)
                    {
                        TxtIdNCRecibida.Text = objNota.Id.ToString();
                        TxtBusqueda.Text = objNota.NumeroNota.ToString();
                        TxtFacturaCompra.Text = objNota.NumeroFactura.ToString();
                        TxtIdCompra.Text = objNota.idCompra.ToString();
                        TxtTipoDoc.Text = objNota.TipoDocumento;
                        TxtUsuario.Text = objNota.NombreUsuario;
                        TxtCodEstablecimiento.Text = objNota.CodEstablecimiento.ToString();
                        TxtPuntoEmision.Text = objNota.PuntoEmision.ToString();
                        TxtDoc.Text = objNota.Doc;
                        dtpFecha.Value = objNota.Fecha;
                        TxtTimbrado.Text = objNota.Timbrado.ToString();
                        dtpInicioVigencia.Value = objNota.InicioVigencia;
                        dtpFinVigencia.Value = objNota.FinVigencia;
                        TxtRUC.Text = objNota.Documento;
                        TxtRazonSocial.Text = objNota.RazonSocial;
                        TxtObs.Text = objNota.Observacion;
                        TxtTotalCompra.Text = objNota.Total.ToString("0");
                        checkBoxConfirmado.Checked = objNota.Confirmado;
                        checkBoxAnulado.Checked = objNota.Anulado;

                        if (checkBoxConfirmado.Checked == true && checkBoxAnulado.Checked == false)
                        {
                            LblConfirmado.Visible = true;
                            PbConfirmado.Visible = true;
                            LblNoConfirmado.Visible = false;
                            PbNoConfirmado.Visible = false;
                            LblAnulado.Visible = false;
                            BtnConfirmarNCRecibida.Visible = false;
                            BtnAnularNCRecibida.Visible = false;
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
                                BtnConfirmarNCRecibida.Visible = true;
                            }
                            if (anula)
                            {
                                BtnAnularNCRecibida.Visible = true;
                            }
                        }
                        else
                        {
                            LblNoConfirmado.Visible = false;
                            PbNoConfirmado.Visible = true;
                            LblConfirmado.Visible = false;
                            PbConfirmado.Visible = false;
                            LblAnulado.Visible = true;
                            BtnConfirmarNCRecibida.Visible = false;
                            BtnAnularNCRecibida.Visible = false;
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

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtBusqueda.Clear();
            TxtFacturaCompra.Clear();
            TxtCodEstablecimiento.Clear();
            TxtPuntoEmision.Clear();
            TxtDoc.Clear();
            TxtTimbrado.Clear();
            dtpFecha.Value = DateTime.Now;
            TxtUsuario.Clear();
            TxtTipoDoc.Clear();
            TxtObs.Clear();
            TxtRUC.Clear();
            TxtRazonSocial.Clear();
            TxtTotalCompra.Clear();
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
                NotaCreditoRecibida objNota = new CN_NotasCreditoRecibidas().ObtenerNota(Convert.ToInt32(TxtIdNCRecibida.Text));
                if (objNota.Id != 0)
                {
                    TxtIdNCRecibida.Text = objNota.Id.ToString();
                    TxtBusqueda.Text = objNota.NumeroNota.ToString();
                    TxtFacturaCompra.Text = objNota.NumeroFactura.ToString();
                    TxtTipoDoc.Text = objNota.TipoDocumento;
                    TxtUsuario.Text = objNota.NombreUsuario;
                    TxtCodEstablecimiento.Text = objNota.CodEstablecimiento.ToString();
                    TxtPuntoEmision.Text = objNota.PuntoEmision.ToString();
                    TxtDoc.Text = objNota.Doc;
                    dtpFecha.Value = objNota.Fecha;
                    TxtTimbrado.Text = objNota.Timbrado.ToString();
                    dtpInicioVigencia.Value = objNota.InicioVigencia;
                    dtpFinVigencia.Value = objNota.FinVigencia;
                    TxtRUC.Text = objNota.Documento;
                    TxtRazonSocial.Text = objNota.RazonSocial;
                    TxtObs.Text = objNota.Observacion;
                    TxtTotalCompra.Text = objNota.Total.ToString();
                    checkBoxConfirmado.Checked = objNota.Confirmado;
                    checkBoxAnulado.Checked = objNota.Anulado;

                    if (checkBoxConfirmado.Checked == true && checkBoxAnulado.Checked == false)
                    {
                        LblConfirmado.Visible = true;
                        PbConfirmado.Visible = true;
                        LblNoConfirmado.Visible = false;
                        PbNoConfirmado.Visible = false;
                        LblAnulado.Visible = false;
                        BtnConfirmarNCRecibida.Visible = false;
                        BtnAnularNCRecibida.Visible = false;
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
                            BtnConfirmarNCRecibida.Visible = true;
                        }
                        if (anula)
                        {
                            BtnAnularNCRecibida.Visible = true;
                        }
                    }
                    else
                    {
                        LblNoConfirmado.Visible = false;
                        PbNoConfirmado.Visible = true;
                        LblConfirmado.Visible = false;
                        PbConfirmado.Visible = false;
                        LblAnulado.Visible = true;
                        BtnConfirmarNCRecibida.Visible = false;
                        BtnAnularNCRecibida.Visible = false;
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

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (TxtIdNCRecibida.Text == "0")
            {
                MessageBox.Show("Debe seleccionar una nota de crédito", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtBusqueda.Focus();
                TxtBusqueda.SelectAll();
                return;
            }
            else
            {
                string Mensaje = string.Empty;

                bool Respuesta = new CN_NotasCreditoRecibidas().ConfirmarNota(Convert.ToInt32(TxtIdNCRecibida.Text), Convert.ToInt32(TxtIdCompra.Text), out Mensaje);

                if (Respuesta)
                {
                    var result = MessageBox.Show("Nota de Crédito confirmada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        LblConfirmado.Visible = true;
                        PbConfirmado.Visible = true;
                        LblNoConfirmado.Visible = false;
                        BtnConfirmarNCRecibida.Visible = false;
                        BtnAnularNCRecibida.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show(Mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtpFecha.Value;
            DateTime fechaActual = DateTime.Now;

            if ((fechaSeleccionada.Year == fechaActual.Year && fechaSeleccionada.Month != fechaActual.Month) || fechaSeleccionada.Year != fechaActual.Year)
            {
                MessageBox.Show("Fecha fuera de rango del mes actual", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFecha.Select();
                return;
            }

            if (fechaSeleccionada < dtpFecha.Value)
            {
                MessageBox.Show("La fecha de la factura debe ser mayor a la fecha del Pedido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFecha.Select();
                return;
            }
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            using (var popup = new FrmAnularNotasCreditoRecibidas(Convert.ToInt32(TxtIdNCRecibida.Text)))
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LblConfirmado.Visible = false;
                    PbConfirmado.Visible = false;
                    LblNoConfirmado.Visible = false;
                    LblAnulado.Visible = true;
                    PbNoConfirmado.Visible = true;
                    BtnAnularNCRecibida.Visible = false;
                    BtnConfirmarNCRecibida.Visible = false;
                }
                else
                {
                    TxtBusqueda.Select();
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Reportes.FrmRptNotasCreditoRecibidas oRptNCRecibidas = new Reportes.FrmRptNotasCreditoRecibidas();
            oRptNCRecibidas.TxtParamId.Text = TxtIdNCRecibida.Text;
            oRptNCRecibidas.ShowDialog();
        }
    }
}

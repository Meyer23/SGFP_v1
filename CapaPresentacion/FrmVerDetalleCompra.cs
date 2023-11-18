using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Interfaces;
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
    public partial class FrmVerDetalleCompra : Form, IFormularioConIdUsuario
    {
        public FrmVerDetalleCompra()
        {
            InitializeComponent();
        }

        public int IdUsuario { get; set; }

        private void FrmVerDetalleCompra_Load(object sender, EventArgs e)
        {
            LblConfirmado.Visible = false;
            PbConfirmado.Visible = false;
            LblNoConfirmado.Visible = false;
            PbNoConfirmado.Visible = false;
            LblAnulado.Visible = false;
            dtpFecha.Value = DateTime.Now;
            dtpFechaVenc.Value = DateTime.Now;
            dtpInicioVigencia.Value = DateTime.Now;
            dtpFinVigencia.Value = DateTime.Now;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            using (var popup = new PopUpCompras(0))
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Compra objCompra = new CN_Compras().ObtenerCompra(Convert.ToInt32(popup._Compra.Id.ToString()));
                    if (objCompra.Id != 0)
                    {
                        TxtBusqueda.Text = objCompra.NumeroFactura.ToString();
                        TxtNroPedido.Text = objCompra.NumeroPedido.ToString();
                        TxtTipoDoc.Text = objCompra.TipoDocumento;
                        TxtFormaPago.Text = objCompra.FormaPago;
                        TxtUsuario.Text = objCompra.NombreUsuario;
                        TxtCodEstablecimiento.Text = objCompra.CodEstablecimiento.ToString();
                        TxtPuntoEmision.Text = objCompra.PuntoEmision.ToString();
                        TxtDoc.Text = objCompra.Doc;
                        dtpFecha.Value = objCompra.Fecha;
                        dtpFechaVenc.Value = objCompra.FechaVencimiento;
                        TxtTimbrado.Text = objCompra.Timbrado.ToString();  
                        dtpInicioVigencia.Value = objCompra.InicioVigencia;
                        dtpFinVigencia.Value = objCompra.FinVigencia;
                        TxtRUC.Text = objCompra.Documento;
                        TxtRazonSocial.Text = objCompra.RazonSocial;
                        TxtObs.Text = objCompra.Observacion;
                        TxtTotalCompra.Text = objCompra.Total.ToString();
                        checkBoxConfirmado.Checked = objCompra.Confirmado;
                        checkBoxAnulado.Checked = objCompra.Anulado;

                        if (checkBoxConfirmado.Checked == true && checkBoxAnulado.Checked == false)
                        {
                            LblConfirmado.Visible = true;
                            PbConfirmado.Visible = true;
                            LblNoConfirmado.Visible = false;
                            PbNoConfirmado.Visible = false;
                            LblAnulado.Visible = false;
                        }
                        else if(checkBoxConfirmado.Checked == false && checkBoxAnulado.Checked == false)
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

                        foreach (DetalleProductos pd in objCompra.Detalle)
                        {
                            dgvData.Rows.Add(new object[] { pd.IdProducto, pd.Descripcion, pd.Precio, pd.Cantidad, pd.Total });
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
            TxtCodEstablecimiento.Clear();
            TxtPuntoEmision.Clear();
            TxtDoc.Clear();
            TxtTimbrado.Clear();
            dtpFecha.Value = DateTime.Now;
            dtpFechaVenc.Value = DateTime.Now;
            TxtUsuario.Clear();
            TxtTipoDoc.Clear();
            TxtFormaPago.Clear();
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
                Compra objCompra = new CN_Compras().ObtenerCompra(Convert.ToInt32(TxtBusqueda.Text));
                if (objCompra.Id != 0)
                {
                    TxtBusqueda.Text = objCompra.NumeroFactura.ToString();
                    TxtNroPedido.Text = objCompra.NumeroPedido.ToString();
                    TxtTipoDoc.Text = objCompra.TipoDocumento;
                    TxtFormaPago.Text = objCompra.FormaPago;
                    TxtUsuario.Text = objCompra.NombreUsuario;
                    TxtCodEstablecimiento.Text = objCompra.CodEstablecimiento.ToString();
                    TxtPuntoEmision.Text = objCompra.PuntoEmision.ToString();
                    TxtDoc.Text = objCompra.Doc;
                    dtpFecha.Value = objCompra.Fecha;
                    dtpFechaVenc.Value = objCompra.FechaVencimiento;
                    TxtTimbrado.Text = objCompra.Timbrado.ToString();
                    dtpInicioVigencia.Value = objCompra.InicioVigencia;
                    dtpFinVigencia.Value = objCompra.FinVigencia;
                    TxtRUC.Text = objCompra.Documento;
                    TxtRazonSocial.Text = objCompra.RazonSocial;
                    TxtObs.Text = objCompra.Observacion;
                    TxtTotalCompra.Text = objCompra.Total.ToString();
                    checkBoxConfirmado.Checked = objCompra.Confirmado;

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

                    foreach (DetalleProductos pd in objCompra.Detalle)
                    {
                        dgvData.Rows.Add(new object[] { pd.IdProducto, pd.Descripcion, pd.Precio, pd.Cantidad, pd.Total });
                    }
                }
                else
                {
                    TxtBusqueda.BackColor = Color.MistyRose;
                    TxtBusqueda.Clear();
                }
            }
        }
    }
}

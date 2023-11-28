using CapaEntidad;
using CapaEntidad.Models;
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
    public partial class FrmVerDetalleVenta : Form, IFormularioConIdUsuario
    {
        bool anula;
        private UsuarioLogin _Usuario;
        public FrmVerDetalleVenta(UsuarioLogin oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        public int IdUsuario { get; set; }

        private void FrmVerDetalleVenta_Load(object sender, EventArgs e)
        {
            //LblConfirmado.Visible = false;
            //PbConfirmado.Visible = false;
            //LblNoConfirmado.Visible = false;
            PbNoConfirmado.Visible = false;
            LblAnulado.Visible = false;
            dtpFecha.Value = DateTime.Now;
            dtpFechaVenc.Value = DateTime.Now;
            dtpInicioVigencia.Value = DateTime.Now;
            dtpFinVigencia.Value = DateTime.Now;
            //BtnConfirmarCompra.Visible = false;
            BtnAnularVenta.Visible = false;

            List<Proceso> procesos = new CN_Procesos().ObtenerProcesos(_Usuario.Id);
            foreach (Proceso proceso in procesos)
            {
                anula = procesos.Any(m => m.Boton == BtnAnularVenta.Name && m.Procesa == true);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            using (var popup = new PopUpVentas())
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Venta objVenta = new CN_Ventas().ObtenerVenta(Convert.ToInt32(popup._Venta.Id.ToString()));
                    if (objVenta.Id != 0)
                    {
                        TxtIdVenta.Text = objVenta.Id.ToString();
                        TxtBusqueda.Text = objVenta.NumeroFactura.ToString();
                        TxtTipoDoc.Text = objVenta.TipoDocumento;
                        TxtFormaPago.Text = objVenta.FormaPago;
                        TxtCajero.Text = objVenta.NombreCajero;
                        TxtCodEstablecimiento.Text = objVenta.CodEstablecimiento.ToString();
                        TxtPuntoEmision.Text = objVenta.PuntoEmision.ToString();
                        TxtDoc.Text = objVenta.Doc;
                        dtpFecha.Value = objVenta.Fecha;
                        dtpFechaVenc.Value = objVenta.FechaVencimiento;
                        TxtTimbrado.Text = objVenta.Timbrado.ToString();
                        dtpInicioVigencia.Value = objVenta.InicioVigencia;
                        dtpFinVigencia.Value = objVenta.FinVigencia;
                        TxtRUC.Text = objVenta.Documento;
                        TxtRazonSocial.Text = objVenta.Nombre;
                        TxtTotalVenta.Text = objVenta.Total.ToString();
                        checkBoxAnulado.Checked = objVenta.Anulado;

                        //if (checkBoxConfirmado.Checked == true && checkBoxAnulado.Checked == false)
                        //{
                        //    LblConfirmado.Visible = true;
                        //    PbConfirmado.Visible = true;
                        //    LblNoConfirmado.Visible = false;
                        //    PbNoConfirmado.Visible = false;
                        //    LblAnulado.Visible = false;
                        //    BtnConfirmarCompra.Visible = false;
                        //    BtnAnularCompra.Visible = false;
                        //    LblFechaRec.Visible = true;
                        //    dtpFechaRec.Visible = true;
                        //    dtpFechaRec.Value = objCompra.FechaRecepcion;
                        //}
                        //else if (checkBoxConfirmado.Checked == false && checkBoxAnulado.Checked == false)
                        //{
                        //    LblNoConfirmado.Visible = true;
                        //    //PbNoConfirmado.Visible = true;
                        //    LblConfirmado.Visible = false;
                        //    PbConfirmado.Visible = false;
                        //    LblAnulado.Visible = false;
                        //    if (confirma)
                        //    {
                        //        BtnConfirmarCompra.Visible = true;
                        //    }
                        //    if (anula)
                        //    {
                        //        BtnAnularCompra.Visible = true;
                        //    }
                        //    LblFechaRec.Visible = false;
                        //    dtpFechaRec.Visible = false;
                        //}
                        //else
                        //{
                        //    LblNoConfirmado.Visible = false;
                        //    PbNoConfirmado.Visible = true;
                        //    LblConfirmado.Visible = false;
                        //    PbConfirmado.Visible = false;
                        //    LblAnulado.Visible = true;
                        //    BtnConfirmarCompra.Visible = false;
                        //    BtnAnularCompra.Visible = false;
                        //    LblFechaRec.Visible = false;
                        //    dtpFechaRec.Visible = false;
                        //}
                        if (checkBoxAnulado.Checked == false)
                        {
                            PbNoConfirmado.Visible = true;
                            LblAnulado.Visible = true;
                        }                            

                        dgvData.Rows.Clear();

                        foreach (DetalleProductos pd in objVenta.Detalle)
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
            TxtCodEstablecimiento.Clear();
            TxtPuntoEmision.Clear();
            TxtDoc.Clear();
            TxtTimbrado.Clear();
            dtpFecha.Value = DateTime.Now;
            dtpFechaVenc.Value = DateTime.Now;
            TxtCajero.Clear();
            TxtTipoDoc.Clear();
            TxtFormaPago.Clear();
            TxtRUC.Clear();
            TxtRazonSocial.Clear();
            TxtTotalVenta.Clear();
            dgvData.Rows.Clear();
            //LblConfirmado.Visible = false;
            //PbConfirmado.Visible = false;
            //LblNoConfirmado.Visible = false;
            PbNoConfirmado.Visible = false;
            LblAnulado.Visible = false;
        }

        private void TxtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Venta objVenta = new CN_Ventas().ObtenerVenta(Convert.ToInt32(TxtIdVenta.Text));
                if (objVenta.Id != 0)
                {
                    TxtIdVenta.Text = objVenta.Id.ToString();
                    TxtBusqueda.Text = objVenta.NumeroFactura.ToString();
                    TxtTipoDoc.Text = objVenta.TipoDocumento;
                    TxtFormaPago.Text = objVenta.FormaPago;
                    TxtCajero.Text = objVenta.NombreCajero;
                    TxtCodEstablecimiento.Text = objVenta.CodEstablecimiento.ToString();
                    TxtPuntoEmision.Text = objVenta.PuntoEmision.ToString();
                    TxtDoc.Text = objVenta.Doc;
                    dtpFecha.Value = objVenta.Fecha;
                    dtpFechaVenc.Value = objVenta.FechaVencimiento;
                    TxtTimbrado.Text = objVenta.Timbrado.ToString();
                    dtpInicioVigencia.Value = objVenta.InicioVigencia;
                    dtpFinVigencia.Value = objVenta.FinVigencia;
                    TxtRUC.Text = objVenta.Documento;
                    TxtRazonSocial.Text = objVenta.Nombre;
                    TxtTotalVenta.Text = objVenta.Total.ToString();
                    checkBoxAnulado.Checked = objVenta.Anulado;

                    //if (checkBoxConfirmado.Checked == true && checkBoxAnulado.Checked == false)
                    //{
                    //    LblConfirmado.Visible = true;
                    //    PbConfirmado.Visible = true;
                    //    LblNoConfirmado.Visible = false;
                    //    PbNoConfirmado.Visible = false;
                    //    LblAnulado.Visible = false;
                    //    BtnConfirmarCompra.Visible = false;
                    //    BtnAnularCompra.Visible = false;
                    //    LblFechaRec.Visible = true;
                    //    dtpFechaRec.Visible = true;
                    //    dtpFechaRec.Value = objCompra.FechaRecepcion;
                    //}
                    //else if (checkBoxConfirmado.Checked == false && checkBoxAnulado.Checked == false)
                    //{
                    //    LblNoConfirmado.Visible = true;
                    //    //PbNoConfirmado.Visible = true;
                    //    LblConfirmado.Visible = false;
                    //    PbConfirmado.Visible = false;
                    //    LblAnulado.Visible = false;
                    //    if (confirma)
                    //    {
                    //        BtnConfirmarCompra.Visible = true;
                    //    }
                    //    if (anula)
                    //    {
                    //        BtnAnularCompra.Visible = true;
                    //    }
                    //    LblFechaRec.Visible = false;
                    //    dtpFechaRec.Visible = false;
                    //}
                    //else
                    //{
                    //    LblNoConfirmado.Visible = false;
                    //    PbNoConfirmado.Visible = true;
                    //    LblConfirmado.Visible = false;
                    //    PbConfirmado.Visible = false;
                    //    LblAnulado.Visible = true;
                    //    BtnConfirmarCompra.Visible = false;
                    //    BtnAnularCompra.Visible = false;
                    //    LblFechaRec.Visible = false;
                    //    dtpFechaRec.Visible = false;
                    //}
                    if (checkBoxAnulado.Checked == false)
                    {
                        PbNoConfirmado.Visible = true;
                        LblAnulado.Visible = true;
                    }

                    dgvData.Rows.Clear();

                    foreach (DetalleProductos pd in objVenta.Detalle)
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

        private void BtnAnularVenta_Click(object sender, EventArgs e)
        {
            using (var popup = new FrmAnularVenta(Convert.ToInt32(TxtIdVenta.Text)))
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    //LblConfirmado.Visible = false;
                    //PbConfirmado.Visible = false;
                    //LblNoConfirmado.Visible = false;
                    LblAnulado.Visible = true;
                    PbNoConfirmado.Visible = true;
                    BtnAnularVenta.Visible = false;
                    //BtnConfirmarCompra.Visible = false;
                }
                else
                {
                    TxtBusqueda.Select();
                }
            }
        }
    }
}

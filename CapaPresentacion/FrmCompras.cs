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
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmCompras : Form, IFormularioConIdUsuario
    {
        private UsuarioLogin _Usuario;
        public FrmCompras(UsuarioLogin oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
            CargarTiposDocumentos();
        }

        public int IdUsuario { get; set; }

        private void CargarFormasPago()
        {
            List<FormaPago> formasPago = new CN_FormasPago().ObtenerFormasPago(ComboTipoDoc.Text.ToString());
            ComboFormaPago.DataSource = formasPago;

            foreach (FormaPago formaPago in formasPago)
            {
                ComboFormaPago.DisplayMember = "Descripcion";
            }
        }

        private void CargarTiposDocumentos()
        {
            List<TipoDocumento> tiposDocumentos = new CN_TiposDocumentos().ObtenerTiposDocumentos();
            ComboTipoDoc.DataSource = tiposDocumentos;

            foreach (TipoDocumento tipoDocumento in tiposDocumentos)
            {
                ComboTipoDoc.DisplayMember = "Descripcion";
            }
        }

        private void BtnBuscarPedido_Click(object sender, EventArgs e)
        {
            using (var popup = new PopUpPedidos(1))
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Pedido objPedido = new CN_Pedidos().ObtenerPedido(Convert.ToInt32(popup._Pedido.NumeroPedido.ToString()));
                    if (objPedido.Id != 0)
                    {
                        ComboTipoDoc.Visible = false;
                        ComboFormaPago.Visible = false;
                        TxtTipoDoc.Visible = true;
                        TxtFormaPago.Visible = true;

                        TxtNroPedido.Text = objPedido.NumeroPedido.ToString();
                        TxtTipoDoc.Text = objPedido.TipoDocumento;
                        TxtFormaPago.Text = objPedido.FormaPago;
                        dtpFechaPedido.Value = (DateTime)objPedido.Fecha;
                        TxtIdProveedor.Text = objPedido.IdProveedor.ToString();
                        TxtRUC.Text = objPedido.Documento;
                        TxtRazonSocial.Text = objPedido.RazonSocial;
                        TxtObs.Text = objPedido.Observacion;
                        TxtTotalCompra.Text = objPedido.Total.ToString();

                        dgvData.Rows.Clear();

                        foreach (DetalleProductos pd in objPedido.Detalle)
                        {
                            dgvData.Rows.Add(new object[] { pd.IdProducto, pd.Descripcion, pd.Precio, pd.Cantidad, pd.Total });
                        }
                    }
                }
                else
                {
                    TxtNroPedido.Select();
                }
            }
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            ComboTipoDoc.Visible = true;
            ComboFormaPago.Visible = true;
            TxtTipoDoc.Visible = false;
            TxtFormaPago.Visible = false;
            dtpFecha.Value = DateTime.Now;
            dtpFechaVenc.Value = DateTime.Now;
            dtpInicioVigencia.Value = DateTime.Now;
            dtpFinVigencia.Value = DateTime.Now;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtNroPedido.Clear();
            TxtTipoDoc.Clear();
            TxtFormaPago.Clear();
            dtpFecha.Value = DateTime.Now;
            dtpFechaVenc.Value = DateTime.Now;
            TxtTimbrado.Clear();
            dtpInicioVigencia.Value = DateTime.Now;
            dtpFinVigencia.Value = DateTime.Now;
            TxtTipoDoc.Clear();
            TxtFormaPago.Clear();
            TxtObs.Clear();
            TxtRUC.Clear();
            TxtRazonSocial.Clear();
            TxtTotalCompra.Clear();
            dgvData.Rows.Clear();
            TxtTipoDoc.Visible = false;
            TxtFormaPago.Visible = false;
            ComboTipoDoc.Visible = true;
            ComboFormaPago.Visible = true;
        }

        private void TxtNroPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Pedido objPedido = new CN_Pedidos().ObtenerPedido(Convert.ToInt32(TxtNroPedido.Text));
                if (objPedido.Id != 0)
                {
                    ComboTipoDoc.Visible = false;
                    ComboFormaPago.Visible = false;
                    TxtTipoDoc.Visible = true;
                    TxtFormaPago.Visible = true;

                    TxtNroPedido.Text = objPedido.NumeroPedido.ToString();
                    TxtTipoDoc.Text = objPedido.TipoDocumento;
                    TxtFormaPago.Text = objPedido.FormaPago;
                    dtpFechaPedido.Value = objPedido.Fecha;
                    TxtIdProveedor.Text = objPedido.IdProveedor.ToString();
                    TxtRUC.Text = objPedido.Documento;
                    TxtRazonSocial.Text = objPedido.RazonSocial;
                    TxtObs.Text = objPedido.Observacion;
                    TxtTotalCompra.Text = objPedido.Total.ToString();

                    dgvData.Rows.Clear();

                    foreach (DetalleProductos pd in objPedido.Detalle)
                    {
                        dgvData.Rows.Add(new object[] { pd.IdProducto, pd.Descripcion, pd.Precio, pd.Cantidad, pd.Total });
                    }
                }
                else
                {
                    TxtNroPedido.BackColor = Color.MistyRose;
                    TxtNroPedido.Clear();
                }
            }
        }

        private void BntBuscarProd_Click(object sender, EventArgs e)
        {
            using (var popup = new PopUpProductos())
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtIdProducto.Text = popup._Producto.Id.ToString();
                    TxtCodProducto.Text = popup._Producto.Codigo;
                    TxtDescProducto.Text = popup._Producto.Descripcion;
                    TxtCantidad.Select();
                    TxtPrecioCompra.Text = new CN_Pedidos().ObtenerUltimoPrecio(Convert.ToInt32(TxtIdProducto.Text), Convert.ToInt32(TxtIdProveedor.Text)).ToString();
                }
                else
                {
                    TxtCodProducto.Select();
                }
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool producto_existe = false;

            if (int.Parse(TxtIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(TxtPrecioCompra.Text, out precio))
            {
                MessageBox.Show("Precio - Formato Inconrrecto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtPrecioCompra.Select();
                return;
            }

            if (string.IsNullOrEmpty(TxtCantidad.Text) || Convert.ToInt32(TxtCantidad.Text) < 1)
            {
                MessageBox.Show("Debe ingresar la cantidad", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCantidad.Select();
                return;
            }

            if (string.IsNullOrEmpty(TxtPrecioCompra.Text) || Convert.ToInt32(TxtPrecioCompra.Text) < 1)
            {
                MessageBox.Show("Debe ingresar un precio, el producto no posee compras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtPrecioCompra.Select();
                return;
            }

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (dgvData.RowCount > 0)
                {
                    if (row.Cells["idProducto"].Value.ToString() == TxtIdProducto.Text)
                    {
                        producto_existe = true;
                        break;
                    }
                }

            }

            if (!producto_existe)
            {
                dgvData.Rows.Add(new object[] {
                    TxtIdProducto.Text,
                    TxtCodProducto.Text,
                    TxtDescProducto.Text,
                    precio.ToString("0.00"),
                    TxtCantidad.Text,
                    (Convert.ToInt32(TxtCantidad.Text) * precio).ToString("0.00") 
                });

                calcularTotal();
                limpiarProducto();
                TxtCodProducto.Select();
            }
            else
            {
                MessageBox.Show("No se puede registrar el mismo producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpiarProducto();
                TxtCodProducto.Select();
                return;
            }
        }

        private void limpiarProducto()
        {
            TxtIdProducto.Text = "0";
            TxtCodProducto.Clear();
            TxtCodProducto.BackColor = Color.White;
            TxtDescProducto.Clear();
            TxtPrecioCompra.Clear();
            TxtCantidad.Clear();
        }

        private void calcularTotal()
        {
            decimal total = 0;

            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["Total"].Value.ToString());
                }
            }
            TxtTotalCompra.Text = total.ToString("0.00");
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.borrar_rojo2.Width;
                var h = Properties.Resources.borrar_rojo2.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.borrar_rojo2, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "BtnEliminar")
            {
                int index = e.RowIndex;

                if (index >= 0)
                {
                    dgvData.Rows.RemoveAt(index);
                    calcularTotal();
                }
            }
        }

        private void BtnBuscarProv_Click(object sender, EventArgs e)
        {
            using (var popup = new PopUpProveedores())
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtIdProveedor.Text = popup._Proveedor.Id.ToString();
                    TxtRUC.Text = popup._Proveedor.Documento;
                    TxtRazonSocial.Text = popup._Proveedor.RazonSocial;
                    TxtObs.Select();
                }
                else
                {
                    TxtRUC.Select();
                }
            }
        }

        private void TxtCodProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto oProducto = new CN_Productos().Listar().Where(p => p.Codigo == TxtCodProducto.Text && p.Activo == true).FirstOrDefault();
                if (oProducto != null)
                {
                    TxtIdProducto.Text = oProducto.Id.ToString();
                    TxtDescProducto.Text = oProducto.Descripcion;
                    TxtCantidad.Select();
                    TxtPrecioCompra.Text = new CN_Pedidos().ObtenerUltimoPrecio(Convert.ToInt32(TxtIdProducto.Text), Convert.ToInt32(TxtIdProveedor.Text)).ToString();
                }
                else
                {
                    TxtCodProducto.BackColor = Color.MistyRose;
                    TxtIdProducto.Text = "0";
                    TxtDescProducto.Text = "";
                }
            }
        }

        private void TxtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (TxtPrecioCompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ",")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ",")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (TxtCantidad.Text.Trim().Length == 0 && e.KeyChar.ToString() == ",")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ",")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void ComboTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarFormasPago();
        }

        private void limpiar()
        {
            TxtObs.Clear();
            dtpFecha.Value = DateTime.Now;
            dtpFechaVenc.Value = DateTime.Now;
            dtpInicioVigencia.Value = DateTime.Now;
            dtpFinVigencia.Value = DateTime.Now;
            ComboTipoDoc.SelectedIndex = 0;
            TxtTipoDoc.Clear();
            TxtFormaPago.Clear();
            TxtTimbrado.Clear();
            TxtDoc.Clear();
            TxtPuntoEmision.Clear();
            TxtCodEstablecimiento.Clear();
            TxtIdProveedor.Text = "0";
            TxtRUC.Clear();
            TxtRazonSocial.Clear();
            limpiarProducto();
            dgvData.Rows.Clear();
            calcularTotal();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string TipoDoc, FormaPago;

            if (TxtDoc.Text == "" || TxtTimbrado.Text == "")
            {
                MessageBox.Show("Debe completar los datos de la factura", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Convert.ToInt32(TxtIdProveedor.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvData.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar al menos un producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable detalle_compra = new DataTable();

            detalle_compra.Columns.Add("idProducto", typeof(int));
            detalle_compra.Columns.Add("Cantidad", typeof(decimal));
            detalle_compra.Columns.Add("Precio", typeof(decimal));
            detalle_compra.Columns.Add("Total", typeof(decimal));

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                detalle_compra.Rows.Add(new object[] {
                   Convert.ToInt32(row.Cells["idProducto"].Value.ToString()),
                   Convert.ToDecimal(row.Cells["Cantidad"].Value.ToString()),
                   Convert.ToDecimal(row.Cells["Precio"].Value.ToString()),
                   Convert.ToDecimal(row.Cells["Total"].Value.ToString())
                });
            }
            if (TxtNroPedido.Text == "0")
            {
                TipoDoc = ComboTipoDoc.Text.ToString();
                FormaPago = ComboFormaPago.Text.ToString();
            }
            else
            {
                TipoDoc = TxtTipoDoc.Text.ToString();
                FormaPago = TxtFormaPago.Text.ToString();
            }

            Compra objCompra = new Compra()
            {
                IdProveedor = Convert.ToInt32(TxtIdProveedor.Text),
                NumeroPedido = Convert.ToInt32(TxtNroPedido.Text),
                TipoDocumento = TipoDoc,
                FormaPago = FormaPago,
                Fecha = (DateTime)(dtpFecha.Value),
                FechaVencimiento = (DateTime)(dtpFechaVenc.Value),
                Timbrado = Convert.ToInt32(TxtTimbrado.Text),
                InicioVigencia = (DateTime)(dtpInicioVigencia.Value),
                FinVigencia = (DateTime)(dtpFinVigencia.Value),
                CodEstablecimiento = Convert.ToInt32(TxtCodEstablecimiento.Text),
                PuntoEmision = Convert.ToInt32(TxtPuntoEmision.Text),
                Doc = TxtDoc.Text.ToString(),
                Observacion = TxtObs.Text,
                Total = Convert.ToDecimal(TxtTotalCompra.Text),
                IdUsuario = _Usuario.Id
            };

            string Mensaje = string.Empty;

            bool Respuesta = new CN_Compras().Registrar(objCompra, detalle_compra, out Mensaje);

            if (Respuesta)
            {
                var result = MessageBox.Show("Factura de Compra Registrada con Éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show(Mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            int dias;
            DateTime fechaSeleccionada = dtpFecha.Value;
            DateTime fechaActual = DateTime.Now;

            if ((fechaSeleccionada.Year == fechaActual.Year && fechaSeleccionada.Month != fechaActual.Month) || fechaSeleccionada.Year != fechaActual.Year)
            {
                MessageBox.Show("Fecha fuera de rango del mes actual", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFecha.Select();
                return;
            }

            if (fechaSeleccionada < dtpFechaPedido.Value)
            {
                MessageBox.Show("La fecha de la factura debe ser mayor a la fecha del Pedido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFecha.Select();
                return;
            }

            if (TxtNroPedido.Text == "0")
            {
                dias = new CN_FormasPago().ObtenerDias(ComboFormaPago.Text.ToString());
            }
            else
            {
                dias = new CN_FormasPago().ObtenerDias(TxtFormaPago.Text.ToString());
            }
            dtpFechaVenc.Value = dtpFecha.Value.AddDays(dias);
        }

        private void TxtCantidad_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtCantidad.Text))
            {
                //e.Cancel = true;
                errorProvider1.SetError(TxtCantidad, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtCantidad, "");
            }
        }

        private void TxtPrecioCompra_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtPrecioCompra.Text))
            {
                //e.Cancel = true;
                errorProvider1.SetError(TxtPrecioCompra, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtPrecioCompra, "");
            }
        }

        private void TxtCodEstablecimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (TxtCantidad.Text.Trim().Length == 0 && e.KeyChar.ToString() == ",")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ",")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void TxtPuntoEmision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (TxtCantidad.Text.Trim().Length == 0 && e.KeyChar.ToString() == ",")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ",")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void TxtDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (TxtCantidad.Text.Trim().Length == 0 && e.KeyChar.ToString() == ",")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ",")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void TxtTimbrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (TxtCantidad.Text.Trim().Length == 0 && e.KeyChar.ToString() == ",")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ",")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }
    }
}

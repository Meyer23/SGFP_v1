using CapaEntidad;
using CapaEntidad.Models;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmNotasCreditoRecibidas : Form
    {
        private UsuarioLogin _Usuario;
        public FrmNotasCreditoRecibidas(UsuarioLogin oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
            CargarTiposDocumentos();
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

        private void BtnBuscarCompra_Click(object sender, EventArgs e)
        {
            using (var popup = new PopUpCompras(2))
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Compra objCompra = new CN_Compras().ObtenerCompra(Convert.ToInt32(popup._Compra.Id.ToString()));
                    if (objCompra.Id != 0)
                    {
                        TxtNroFactura.Text = objCompra.NumeroFactura.ToString();
                        dtpFechaCompra.Value = (DateTime)objCompra.Fecha;
                        TxtIdCompra.Text = objCompra.Id.ToString();
                        TxtIdProveedor.Text = objCompra.IdProveedor.ToString();
                        TxtRUC.Text = objCompra.Documento;
                        TxtRazonSocial.Text = objCompra.RazonSocial;
                        TxtTotalNota.Text = objCompra.Total.ToString();

                        dgvData.Rows.Clear();

                        foreach (DetalleProductos pd in objCompra.Detalle)
                        {
                            dgvData.Rows.Add(new object[] { pd.IdProducto, pd.Codigo, pd.Descripcion, pd.Precio, pd.Cantidad, pd.Total });
                        }
                    }
                }
                else
                {
                    TxtNroFactura.Select();
                }
            }
        }

        private void FrmNotasCreditoRecibidas_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
            dtpInicioVigencia.Value = DateTime.Now;
            dtpFinVigencia.Value = DateTime.Now;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtNroFactura.Clear();
            dtpFecha.Value = DateTime.Now;
            ComboTipoDoc.SelectedIndex = 0;
            TxtTimbrado.Clear();
            dtpInicioVigencia.Value = DateTime.Now;
            dtpFinVigencia.Value = DateTime.Now;
            TxtObs.Clear();
            TxtRUC.Clear();
            TxtRazonSocial.Clear();
            TxtTotalNota.Clear();
            dgvData.Rows.Clear();
        }

        private void TxtNroFactura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Compra objCompra = new CN_Compras().ObtenerCompra(Convert.ToInt32(TxtIdCompra.Text));
                if (objCompra.Id != 0)
                {

                    TxtNroFactura.Text = objCompra.NumeroFactura.ToString();
                    dtpFechaCompra.Value = (DateTime)objCompra.Fecha;
                    TxtIdProveedor.Text = objCompra.IdProveedor.ToString();
                    TxtRUC.Text = objCompra.Documento;
                    TxtRazonSocial.Text = objCompra.RazonSocial;
                    TxtTotalNota.Text = objCompra.Total.ToString();

                    dgvData.Rows.Clear();

                    foreach (DetalleProductos pd in objCompra.Detalle)
                    {
                       dgvData.Rows.Add(new object[] { pd.IdProducto, pd.Codigo, pd.Descripcion, pd.Precio, pd.Cantidad, pd.Total });
                    }
                }
                else
                {
                    TxtNroFactura.BackColor = Color.MistyRose;
                    TxtNroFactura.Clear();
                }
            }
        }

        private void BntBuscarProd_Click(object sender, EventArgs e)
        {
            using (var popup = new PopUpProductos(1, Convert.ToInt32(TxtIdCompra.Text)))
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtIdProducto.Text = popup._Producto.Id.ToString();
                    TxtCodProducto.Text = popup._Producto.Codigo;
                    TxtDescProducto.Text = popup._Producto.Descripcion;
                    TxtCantidad.Text = popup._Producto.Existencia.ToString();
                    TxtCantidad.Select();
                    //TxtPrecioCompra.Text = new CN_Pedidos().ObtenerUltimoPrecio(Convert.ToInt32(TxtIdProducto.Text), Convert.ToInt32(TxtIdProveedor.Text)).ToString();
                    TxtPrecioCompra.Text = popup._Producto.Precio.ToString();
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
            TxtTotalNota.Text = total.ToString("0.00");
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
                Producto oProducto = new CN_Productos().Listar(1, Convert.ToInt32(TxtIdCompra.Text)).Where(p => p.Codigo == TxtCodProducto.Text && p.Activo == true).FirstOrDefault();
                if (oProducto != null)
                {
                    TxtIdProducto.Text = oProducto.Id.ToString();
                    TxtDescProducto.Text = oProducto.Descripcion;
                    TxtCantidad.Select();
                    //TxtPrecioCompra.Text = new CN_Pedidos().ObtenerUltimoPrecio(Convert.ToInt32(TxtIdProducto.Text), Convert.ToInt32(TxtIdProveedor.Text)).ToString();
                    TxtPrecioCompra.Text = "0";
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

        private void limpiar()
        {
            TxtNroFactura.Clear();
            TxtObs.Clear();
            dtpFecha.Value = DateTime.Now;
            dtpInicioVigencia.Value = DateTime.Now;
            dtpFinVigencia.Value = DateTime.Now;
            ComboTipoDoc.SelectedIndex = 0;
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

            if (TxtDoc.Text == "" || TxtTimbrado.Text == "")
            {
                MessageBox.Show("Debe completar los datos de la nota de crédito", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            DataTable detalle_nota = new DataTable();

            detalle_nota.Columns.Add("idProducto", typeof(int));
            detalle_nota.Columns.Add("Cantidad", typeof(decimal));
            detalle_nota.Columns.Add("Precio", typeof(decimal));
            detalle_nota.Columns.Add("Total", typeof(decimal));

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                detalle_nota.Rows.Add(new object[] {
                   Convert.ToInt32(row.Cells["idProducto"].Value.ToString()),
                   Convert.ToDecimal(row.Cells["Cantidad"].Value.ToString()),
                   Convert.ToDecimal(row.Cells["Precio"].Value.ToString()),
                   Convert.ToDecimal(row.Cells["Total"].Value.ToString())
                });
            }

            NotaCreditoRecibida objNCRecibida = new NotaCreditoRecibida()
            {
                IdProveedor = Convert.ToInt32(TxtIdProveedor.Text),
                NumeroFactura = TxtNroFactura.Text.ToString(),
                idCompra = Convert.ToInt32(TxtIdCompra.Text),
                TipoDocumento = ComboTipoDoc.Text.ToString(),
                Fecha = (DateTime)(dtpFecha.Value),
                Timbrado = Convert.ToInt32(TxtTimbrado.Text),
                InicioVigencia = (DateTime)(dtpInicioVigencia.Value),
                FinVigencia = (DateTime)(dtpFinVigencia.Value),
                CodEstablecimiento = Convert.ToInt32(TxtCodEstablecimiento.Text),
                PuntoEmision = Convert.ToInt32(TxtPuntoEmision.Text),
                Doc = TxtDoc.Text.ToString(),
                Observacion = TxtObs.Text,
                Total = Convert.ToDecimal(TxtTotalNota.Text),
                IdUsuario = _Usuario.Id
            };

            string Mensaje = string.Empty;

            bool Respuesta = new CN_NotasCreditoRecibidas().Registrar(objNCRecibida, detalle_nota, out Mensaje);

            if (Respuesta)
            {
                var result = MessageBox.Show("Nota de Crédito Registrada con Éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DateTime fechaSeleccionada = dtpFecha.Value;
            DateTime fechaActual = DateTime.Now;

            if ((fechaSeleccionada.Year == fechaActual.Year && fechaSeleccionada.Month != fechaActual.Month) || fechaSeleccionada.Year != fechaActual.Year)
            {
                MessageBox.Show("Fecha fuera de rango del mes actual", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFecha.Value = DateTime.Now;
                dtpFecha.Select();
                return;
            }

            if (fechaSeleccionada < dtpFechaCompra.Value)
            {
                MessageBox.Show("La fecha de la nota de crédito debe ser mayor a la fecha de la compra", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFecha.Value = DateTime.Now;
                dtpFecha.Select();
                return;
            }
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

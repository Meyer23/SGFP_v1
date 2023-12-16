using CapaEntidad;
using CapaEntidad.Models;
using CapaNegocio;
using CapaPresentacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmRegistrarVenta : Form, IFormularioConIdUsuario
    {
        private UsuarioLogin _Usuario;

        private DataTable datosDetallesCobro;

        private DataTable datosDetalles;
        public FrmRegistrarVenta(UsuarioLogin oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(BtnCargarCobro_KeyDown);
            CargarTiposDocumentos();
            MostrarCajero();
            TxtCajero.Enabled = false;
            TxtNroCaja.Enabled = false;
            FechaVenta.Value = DateTime.Now;
            ComboTipoDoc.SelectedIndexChanged += ComboTipoDoc_SelectedIndexChanged;
            ObtenerUltimoDocFactura();
            dtpFechaVenc.Value = DateTime.Now;
        }

        public int IdUsuario { get; set; }

        private void iconButtonCodProducto_Click(object sender, EventArgs e)
        {
            using (var popup = new PopUpProductos(-1, 0))
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtIdProducto.Text = popup._Producto.Id.ToString();
                    textBoxCodProducto.Text = popup._Producto.Codigo;
                    TxtProducto.Text = popup._Producto.Descripcion;
                    textBoxPrecio.Text = popup._Producto.Precio.ToString();
                    TxtUnidadMedida.Text = popup._Producto.UnidadMedida.ToString();
                }
                else
                {
                    textBoxCodProducto.Select();
                }
            }
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
           
        //    LblHoraActual.Text = DateTime.Now.ToString("HH:mm:ss");
        //}

        private void FrmRegistrarVenta_Load(object sender, EventArgs e)
        {
            TimerNow.Start();
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

        private void CargarFormasPago()
        {
            List<FormaPago> formasPago = new CN_FormasPago().ObtenerFormasPago(ComboTipoDoc.Text.ToString());
            ComboFormaPago.DataSource = formasPago;

            foreach (FormaPago formaPago in formasPago)
            {
                ComboFormaPago.DisplayMember = "Descripcion";
            }
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            using (var popup = new PopUpClientes())
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtIdCliente.Text = popup.cliente.IdCliente.ToString();
                    TxtRUC.Text = popup.cliente.ClienteRuc;
                    TxtRazonSocial.Text = popup.cliente.ClienteNombre + popup.cliente.ClienteApellido;
                }
                else
                {
                    TxtRUC.Select();
                }
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool producto_existe = false;

            //Obtener la categoria del producto seleccionado. 
            List<Producto> productos = new CN_Productos().Listar(-1, 0);

            var unidadMedida = productos.Where(b => b.Id == Convert.ToInt32(TxtIdProducto.Text))
                                       .Select(b => b.UnidadMedida)
                                       .SingleOrDefault();

            List<UnidadMedida> uMedida = new CN_UnidadesMedida().Listar();

            var codUnidadMedida = uMedida.Where(u => u.Descripcion == unidadMedida)
                                         .Select(u => u.Abreviacion);

            if (int.Parse(TxtIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textBoxPrecio.Text, out precio))
            {
                MessageBox.Show("Precio - Formato Inconrrecto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPrecio.Select();
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
                    textBoxCodProducto.Text,
                    TxtProducto.Text,
                    numericUpDownCantidad.Text,
                    TxtUnidadMedida.Text,
                    precio.ToString(),
                    (Convert.ToInt32(numericUpDownCantidad.Value) * precio).ToString("0") });

                calcularTotal();
                limpiarProducto();
                textBoxCodProducto.Select();
            }
            else
            {
                MessageBox.Show("No se puede registrar el mismo producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpiarProducto();
                textBoxCodProducto.Select();
                return;
            }
        }

        private void calcularTotal()
        {
            decimal total = 0;

            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
                }
            }
            textBoxTotalPagar.Text = total.ToString("0");
        }

        private void CalcularTotalMedioCobro()
        {
            decimal totalMedioCobro = 0;
        }

        private void calcularCambio()
        {  
            if(textBoxTotalPagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagaCon;
            decimal total = Convert.ToDecimal(textBoxTotalPagar.Text);
        }

        private void limpiarProducto()
        {
            textBoxCodProducto.Clear();
            textBoxCodProducto.BackColor = Color.White;
            TxtProducto.Clear();
            numericUpDownCantidad.Text = "1";
        }

        private void textBoxCodProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.Handled = true;
                Producto oProducto = new CN_Productos().Listar(0,0).Where(p => p.Codigo == textBoxCodProducto.Text && p.Activo == true).FirstOrDefault();
                if (oProducto != null)
                {
                    TxtIdProducto.Text = oProducto.Id.ToString();
                    textBoxCodProducto.Text = oProducto.Codigo.ToString();
                    TxtProducto.Text = oProducto.Descripcion;
                    textBoxPrecio.Text = oProducto.Precio.ToString();
                    numericUpDownCantidad.Select();
                }
                else
                {
                    textBoxCodProducto.BackColor = Color.MistyRose;
                    TxtIdProducto.Text = "0";
                    TxtProducto.Text = "";
                }
            }
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 7)
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

        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (textBoxPrecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ",")
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

        private void BtnCargarCobro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F12)
            {
            }
        }

        private void TxtTipoValor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.F11)
            {
                using (var popup = new PopUpTipoValor())
                {
                    var result = popup.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                    }
                    else
                    {
                        TxtRUC.Select();
                    }
                }
            }
        }

        private void TxtImporte_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            decimal txtValorTotal = Convert.ToDecimal(textBoxTotalPagar.Text);
        }

        private void BtnConfirmar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.F1)
            {
                decimal txtValorTotal = Convert.ToDecimal(textBoxTotalPagar.Text);
            }
        }

        private void TxtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtTipoValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dgvData_Cobro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "EliminarMedioCobro")
            {
                int index = e.RowIndex;

                if (index >= 0)
                {
                }
            }
        }

        private void dgvData_Cobro_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 4)
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

        private void TxtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtDocumento_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void limpiar()
        {
        }

        private void ComboFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dias;

            dias = new CN_FormasPago().ObtenerDias(ComboFormaPago.Text.ToString());

            dtpFechaVenc.Value = FechaVenta.Value.AddDays(dias);
        }

        private void ComboTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarFormasPago();

            string tipoPagoSeleccionado = ComboTipoDoc.Text;

            if (tipoPagoSeleccionado == "Factura Crédito")
            {
                BtnCobro.Enabled = false;
            }
            else
            {
                BtnCobro.Enabled = true;
            }
        }

        private void MostrarCajero()
        {
            List<Cajas> listadeCajas = new CN_Cajas().ObtenerCajas();

            var numeroCaja = listadeCajas
                                         .Where(e => e.LoginUsuario == _Usuario.Login.ToString())
                                         .Select(e => e.NumeroCaja)
                                         .SingleOrDefault();

            var idCaja = listadeCajas
                        .Where(e => e.NumeroCaja == numeroCaja)
                        .Select(e => e.Id)
                        .SingleOrDefault();

            TxtCajero.Text = _Usuario.Login.ToString();
            TxtNroCaja.Text = numeroCaja.ToString();

           if(idCaja == 0)
            {
                string nombreUsuario = _Usuario.Login.ToString();
                MessageBox.Show(string.Format("Usuario '{0}' sin caja asignada, verifique", nombreUsuario), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MostrarTimbrado(idCaja);

        }

        private void MostrarTimbrado(int idCaja)
        {

            List<Timbrado> timbrados = new CN_Timbrados().Listar();

            List<NumeracionDocumento> numeracion = new CN_NumeracionDocumento().Listar();

            var timbradosList = timbrados.Where(e => e.Activo)
                                     .Select(e => e.NroTimbrado)
                                     .ToList();

            var timbradoId = numeracion.Where(e => e.DescripcionCaja == idCaja.ToString())
                                      .Select(e => e.IdTimbrado)
                                      .SingleOrDefault();

            var valorTimbrado = timbrados.Where(e=> e.Id == timbradoId)
                                         .Select(e=> e.NroTimbrado)
                                         .SingleOrDefault();

            var inicioVigencia = timbrados.Where(e => e.Id == timbradoId)
                                                .Select(e => e.InicioVigencia)
                                                .SingleOrDefault();

            var finVigencia = timbrados.Where(e => e.Id == timbradoId)
                                                .Select(e => e.FinVigencia)
                                                .SingleOrDefault();

            var codEstablecimiento = numeracion.Where(e => e.DescripcionCaja.ToString() == idCaja.ToString())
                                               .Select(e => e.CodigoEstablecimiento)
                                               .SingleOrDefault();

            var puntoEmision = numeracion.Where(e => e.DescripcionCaja == idCaja.ToString())
                                         .Select(e => e.PuntoEmision)
                                         .SingleOrDefault();

            TxtTimbrado.Text = valorTimbrado.ToString();
            dtpInicioVigencia.Text = inicioVigencia.ToString();
            dtpFinVigencia.Text = finVigencia.ToString();
            TxtCodEstablecimiento.Text = codEstablecimiento.ToString();
            TxtPuntoEmision.Text = puntoEmision.ToString();
            TxtTimbrado.Enabled = false;
            dtpInicioVigencia.Enabled = false;
            dtpFinVigencia.Enabled = false;
            TxtCodEstablecimiento.Enabled = false;
            TxtPuntoEmision.Enabled = false;

        }

        private void BtnAddCliente_Click(object sender, EventArgs e)
        {
            PopUpNuevoCliente nuevo = new PopUpNuevoCliente();
            nuevo.ShowDialog();
        }

        public void BtnCobro_Click(object sender, EventArgs e)
        {
            try
            {
                decimal cobrarMonto = Convert.ToDecimal(textBoxTotalPagar.Text);

                using (var formDetalleCobro = new PopUpDetalleCobro(cobrarMonto))
                {
                    formDetalleCobro.ShowDialog();

                    // Supongamos que las columnas deseadas tienen los índices 2, 3, 4, 5, 6, 7
                    int[] columnIndexesToCopy = { 0, 1, 2, 3, 4, 5, 6 };

                    DataTable datosDetallesCobro = new DataTable();

                    // Agregar las columnas deseadas al nuevo DataTable
                    foreach (int columnIndex in columnIndexesToCopy)
                    {
                        datosDetallesCobro.Columns.Add(formDetalleCobro.dataTableCobro.Columns[columnIndex].ColumnName);
                    }

                    // Copiar filas y datos de las columnas seleccionadas
                    foreach (DataRow row in formDetalleCobro.dataTableCobro.Rows)
                    {
                        DataRow newRow = datosDetallesCobro.NewRow();

                        // Copiar solo las columnas específicas
                        foreach (int columnIndex in columnIndexesToCopy)
                        {
                            // Verificar si la columna actual es la que deseas convertir a DateTime (supongamos que es la columna con índice 3)
                            if ((columnIndex == 4 && row[columnIndex] != DBNull.Value) || (columnIndex == 5 && row[columnIndex] != DBNull.Value))
                            {
                               
                                newRow[columnIndex - columnIndexesToCopy.Min()] = Convert.ToDecimal(row[columnIndex]);
                            }
                            else if(columnIndex == 6 && row[columnIndex] != DBNull.Value)
                            {
                                newRow[columnIndex - columnIndexesToCopy.Min()] = Convert.ToDateTime(row[columnIndex]);
                            }
                            else if((columnIndex == 0 && row[columnIndex] != DBNull.Value) || (columnIndex == 1 && row[columnIndex] != DBNull.Value))
                            {
                                newRow[columnIndex - columnIndexesToCopy.Min()] = Convert.ToInt16(row[columnIndex]);
                            }
                            else if((columnIndex == 2 && row[columnIndex] != DBNull.Value) || (columnIndex == 3 && row[columnIndex] != DBNull.Value))
                            {
                                newRow[columnIndex - columnIndexesToCopy.Min()] = Convert.ToString(row[columnIndex]);
                            }
                            else
                            {
                                // Rellenar con cadena vacía si el valor es DBNull.Value
                                newRow[columnIndex - columnIndexesToCopy.Min()] = "null";
                            }
                        }
                        datosDetallesCobro.Rows.Add(newRow);
                        datosDetalles = datosDetallesCobro.Copy();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ObtenerUltimoDocFactura()
        {
            try
            {
                List<NumeracionDocumento> listNumeracion = new CN_NumeracionDocumento().Listar();

                var ultimoNumero = listNumeracion.Where(e => e.DescripcionCaja == TxtNroCaja.Text)
                                                 .Select(e => e.UltimoNumero).Max();

                if (ultimoNumero >= 0)
                {
                    TxtDoc.Text = ultimoNumero.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnImprimirFactura_Click(object sender, EventArgs e)
        {
            string TipoDoc, FormaCobro;

            int clienteId = Convert.ToInt32(TxtIdCliente.Text);

            if(clienteId == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(TxtIdProducto.Text == "")
            {
                MessageBox.Show("Debe seleccionar al menos un producto", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvData.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar al menos un producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable detalle_venta = new DataTable();
            DataTable detalle_cobro = datosDetalles;

            FormaCobro = ComboFormaPago.Text;
            TipoDoc = ComboTipoDoc.Text;

            detalle_venta.Columns.Add("idProducto", typeof(int));
            detalle_venta.Columns.Add("Cantidad", typeof(decimal));
            detalle_venta.Columns.Add("UnidadMedida", typeof(string));
            detalle_venta.Columns.Add("Precio", typeof(decimal));//Precio unitario
            detalle_venta.Columns.Add("SubTotal", typeof(decimal));



            foreach (DataGridViewRow row in dgvData.Rows)
            {
                detalle_venta.Rows.Add(new object[] {
                   Convert.ToInt32(row.Cells["idProducto"].Value.ToString()),
                   Convert.ToDecimal(row.Cells["Cantidad"].Value.ToString()),
                   Convert.ToString(row.Cells["Unidad"].Value.ToString()),
                   Convert.ToDecimal(row.Cells["Precio"].Value.ToString()),
                   Math.Floor(Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString()))
                });
            }

            Venta objVenta = new Venta()
            {
                IdCliente = clienteId,
                TipoDocumento = TipoDoc,
                FormaPago = FormaCobro,
                Fecha = (DateTime)(FechaVenta.Value),
                FechaVencimiento = (DateTime)(dtpFechaVenc.Value),
                Timbrado = Convert.ToInt32(TxtTimbrado.Text),
                CodEstablecimiento = Convert.ToInt32(TxtCodEstablecimiento.Text),
                PuntoEmision = Convert.ToInt32(TxtPuntoEmision.Text),
                Doc = TxtDoc.Text.ToString(),
                Total = Convert.ToDecimal(textBoxTotalPagar.Text),
                IdCajero = _Usuario.Id
            };

            string Mensaje = string.Empty;

            bool Respuesta = new CN_Ventas().Registrar(objVenta, detalle_venta, detalle_cobro, out Mensaje);

            if (Respuesta)
            {
                var result = MessageBox.Show("Factura de Venta Registrada con Éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    LimpiarForm();
                }
            }
            else
            {
                MessageBox.Show(Mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void TxtIdProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void LimpiarForm()
        {
            TxtRUC.Clear();
            TxtRazonSocial.Clear();
            textBoxCodProducto.Clear();
            TxtProducto.Clear();
            textBoxPrecio.Clear();
            textBoxTotalPagar.Clear();
            dgvData.Rows.Clear();
        }

        private void ComboTipoDoc_SelectedValueChanged(object sender, EventArgs e)
        {
            List<TipoDocumento> tiposDocumentos = new CN_TiposDocumentos().ObtenerTiposDocumentos();

            var idDocumento = tiposDocumentos.Where(x => x.Descripcion == ComboTipoDoc.Text)
                                             .Select(x => x.Id)
                                             .FirstOrDefault();

            if(idDocumento == 2)
            {
                BtnCobro.Enabled = false;
            }
            else
            {
                BtnCobro.Enabled = true;
            }

        }
    }
}
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
    public partial class FrmRegistrarVenta : Form, IFormularioConIdUsuario
    {
        private UsuarioLogin _Usuario;
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
        }

        public int IdUsuario { get; set; }

        private void iconButtonCodProducto_Click(object sender, EventArgs e)
        {
            using (var popup = new PopUpProductos())
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtIdProducto.Text = popup._Producto.Id.ToString();
                    textBoxCodProducto.Text = popup._Producto.Codigo;
                    TxtProducto.Text = popup._Producto.Descripcion;
                    textBoxPrecio.Text = popup._Producto.Precio.ToString();
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
                    precio.ToString("0.00"),
                    (Convert.ToInt32(numericUpDownCantidad.Value) * precio).ToString("0.00") });

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
            textBoxTotalPagar.Text = total.ToString("0.00");
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
            TxtIdProducto.Text = "0";
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
                    textBoxPrecio.Text = oProducto.Precio.ToString("0.00");
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

        }

        private void ComboTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarFormasPago();
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

        private void BtnCobro_Click(object sender, EventArgs e)
        {
            PopUpDetalleCobro cobro = new PopUpDetalleCobro();
            cobro.ShowDialog();
        }
    }
}
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

        private void calcularCambio()
        {
            if(textBoxTotalPagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagaCon;
            decimal total = Convert.ToDecimal(textBoxTotalPagar.Text);

            if(TxtImporte.Text.Trim() == "")
            {
                TxtImporte.Text = "0";
            }

            if(decimal.TryParse(TxtImporte.Text.Trim(), out pagaCon))
            {
                if(pagaCon < total)
                {
                    TxtVuelto.Text = "0";
                }
                else
                {
                    decimal cambio = pagaCon - total;
                    TxtVuelto.Text = cambio.ToString();
                }
            }
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
                Producto oProducto = new CN_Productos().Listar().Where(p => p.Codigo == textBoxCodProducto.Text && p.Activo == true).FirstOrDefault();
                if (oProducto != null)
                {
                    TxtIdProducto.Text = oProducto.Id.ToString();
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

            if (e.ColumnIndex == 5)
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
                //e.Handled = true;
                //PopUpCobrarVenta popup = new PopUpCobrarVenta();
                //popup.Show();
                groupBoxFormaPago.Visible = true;
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
                        TxtTipoValor.Text = popup.Valor.Descripcion.ToString();
                        ChkValidaDocumento.Checked = (bool)popup.Valor.ValidaDocumento;
                    }
                    else
                    {
                        TxtRUC.Select();
                    }
                }
            }
            TxtTipoValor.Enabled = false;

            if (ChkValidaDocumento.Checked)
            {
                ValidarMedioCobro.Visible = true;

                if(TxtTipoValor.Text == "Cheque Diferido" || TxtTipoValor.Text == "Cheque Día")
                {
                    LblNroCheque.Visible = true;
                    TxtNroCheque.Visible = true;
                }
            }
        }

        private void TxtImporte_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                calcularCambio();
            }
        }
    }
}
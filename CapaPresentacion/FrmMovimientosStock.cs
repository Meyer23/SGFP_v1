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
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace CapaPresentacion
{
    public partial class FrmMovimientosStock : Form
    {
        private UsuarioLogin _Usuario;
        public FrmMovimientosStock(UsuarioLogin oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
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
                }
                else
                {
                    TxtCodProducto.Select();
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
                }
                else
                {
                    TxtCodProducto.BackColor = Color.MistyRose;
                    TxtIdProducto.Text = "0";
                    TxtDescProducto.Text = "";
                }
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            bool producto_existe = false;
            decimal existencia = new CN_MovimientosStock().ObtenerExistencia(Convert.ToInt32(TxtIdProducto.Text));

            if (int.Parse(TxtIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(TxtCantidad.Text) || Convert.ToInt32(TxtCantidad.Text) < 1)
            {
                MessageBox.Show("Debe ingresar la cantidad", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCantidad.Select();
                return;
            }

            if (ComboTipoMov.Text.ToString() == "SALIDA" && Convert.ToInt32(TxtCantidad.Text) > existencia)
            {
                MessageBox.Show("Existencia insuficiente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCantidad.Select();
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
                    TxtCantidad.Text });

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
            TxtCantidad.Clear();
        }

        private void calcularTotal()
        {
            decimal total = 0;

            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["Cantidad"].Value.ToString());
                }
            }
            TxtTotalCantidad.Text = total.ToString("0.00");
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
            TxtDocumento.Clear();
            TxtObs.Clear();
            dtpFecha.Value = DateTime.Now;
            ComboTipoMov.SelectedIndex = 0;
            limpiarProducto();
            dgvData.Rows.Clear();
            calcularTotal();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar al menos un producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable detalle_movimiento = new DataTable();

            detalle_movimiento.Columns.Add("idProducto", typeof(int));
            detalle_movimiento.Columns.Add("Cantidad", typeof(decimal));

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                detalle_movimiento.Rows.Add(new object[] {
                   Convert.ToInt32(row.Cells["idProducto"].Value.ToString()),
                   Convert.ToDecimal(row.Cells["Cantidad"].Value.ToString())
                });
            }

           // int NroCorrelativo = new CN_Pedidos().ObtenerNroPedido();

            MovimientoStock objMovimiento = new MovimientoStock()
            {
                TipoMovimiento = ComboTipoMov.Text.ToString(),
                Documento = TxtDocumento.Text,
                Fecha = (DateTime)(dtpFecha.Value),
                Observacion = TxtObs.Text,
                Total = Convert.ToDecimal(TxtTotalCantidad.Text),
                IdUsuario = _Usuario.Id
            };

            string Mensaje = string.Empty;

            bool Respuesta = new CN_MovimientosStock().Registrar(objMovimiento, detalle_movimiento, out Mensaje);

            if (Respuesta)
            {
                var result = MessageBox.Show("Movimiento de Stock Registrado con Éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FrmMovimientosStock_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
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
        }
    }
}

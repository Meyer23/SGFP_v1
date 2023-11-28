using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class PopUpDetalleCobro : Form
    {
        private decimal  _monto;
        public DataTable dataTableCobro { get; private set; }
        public PopUpDetalleCobro(decimal montoTotal = 0)
        {
            _monto = montoTotal;
            InitializeComponent();
            MostrarValores();
            MontoDeLaVenta();
            MostrarBancos();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            dataTableCobro = dgvData.DataSource as DataTable;
            this.Close();
        }

        public void MostrarValores()
        {
            List<Valor> valores = new CN_Valores().Listar();

            var tiposValores = valores.Where(x => x.Activo == true)
                                      .Select(x => x.Descripcion)
                                      .ToList();
            ComboTipoValor.Items.Clear();
            ComboTipoValor.Items.AddRange(tiposValores.ToArray());

        }

        public void MontoDeLaVenta()
        {
            TxtMontoTotal.Text = _monto.ToString();
            TxtMontoTotal.Enabled = false;
        }

        public void MostrarBancos()
        {
            List<Banco> bancos = new CN_Bancos().Listar();

            var listBancos = bancos.Where(x => x.Activo == true);

            foreach(var banco in listBancos)
            {
                ComboBanco.Items.Add(banco.Nombre);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            decimal valorVuelto = 0;
            decimal importe = Convert.ToDecimal(TxtImporte.Text);
            if(importe > _monto)
            {
                valorVuelto = importe - _monto;
                TxtVuelto.Text = valorVuelto.ToString();
            }
            dgvData.Rows.Add(new object[] {
                    "",
                    ComboTipoValor.Text,
                    ComboBanco.Text,
                    TxtNroCuenta.Text,
                    TxtNroDocumento.Text,
                    TxtImporte.Text,
                    TxtVuelto.Text,
                    "",
            });
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "BtnEliminar")
            {
                int index = e.RowIndex;

                if (index >= 0)
                {
                    dgvData.Rows.RemoveAt(index);
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

        private void dgvData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == dgvData.Columns["TxtImporte"].Index)
            //{
            //    // Obtener el valor de la celda en la columna "TxtImporte"
            //    string importeTexto = dgvData.Rows[e.RowIndex].Cells["TxtImporte"].Value?.ToString();

            //    // Convertir el valor de texto a decimal
            //    if (decimal.TryParse(importeTexto, out decimal importe))
            //    {
            //        decimal vuelto = _monto - importe;

            //        // Mostrar el resultado en la celda "TxtVuelto"
            //        dgvData.Rows[e.RowIndex].Cells["TxtVuelto"].Value = vuelto.ToString();
            //    }
            //    else
            //    {
            //        // Manejar el caso en que el valor de "TxtImporte" no sea un número válido
            //        MessageBox.Show("El valor de importe no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Crear un nuevo DataTable
            DataTable datos = new DataTable();

            // Agregar columnas al DataTable
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                datos.Columns.Add(columna.Name);
            }

            // Agregar filas al DataTable con los datos del DataGridView
            foreach (DataGridViewRow fila in dgvData.Rows)
            {
                DataRow nuevaFila = datos.NewRow();

                foreach (DataGridViewCell celda in fila.Cells)
                {
                    nuevaFila[celda.ColumnIndex] = celda.Value;
                }

                datos.Rows.Add(nuevaFila);
            }

            // Asignar el DataTable a la propiedad
            dataTableCobro = datos;
            this.Close();
        }
    }
}

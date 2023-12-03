using CapaEntidad;
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

namespace CapaPresentacion
{
    public partial class PopUpProductos : Form
    {
        public Producto _Producto { get; set; }
        private int _Bandera, _idCompra;
        public PopUpProductos(int bandera = 0, int idCompra = 0)
        {
            _Bandera = bandera;
            _idCompra = idCompra;
            InitializeComponent();
        }

        private void PopUpProductos_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible)
                {
                    ComboBusqueda.Items.Add(columna.Name);
                }
            }
            ComboBusqueda.SelectedIndex = 0;

            List<Producto> listaProducto = new CN_Productos().Listar(_Bandera, _idCompra);

            var listaProductosExistentes = listaProducto.Where(a => a.Activo == true).ToList();

            foreach (Producto producto in listaProductosExistentes)
            {
                dgvData.Rows.Add(producto.Id, producto.Codigo, producto.Descripcion, producto.Precio, producto.Existencia, producto.UnidadMedida);
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColumn = e.ColumnIndex;

            if (iRow >= 0 && iColumn > 0)
            {
                _Producto = new Producto
                {
                    Id = Convert.ToInt32(dgvData.Rows[iRow].Cells["idProducto"].Value.ToString()),
                    Codigo = dgvData.Rows[iRow].Cells["Codigo"].Value.ToString(),
                    Descripcion = dgvData.Rows[iRow].Cells["Descripcion"].Value.ToString(),
                    Precio = Math.Floor(Convert.ToDecimal(dgvData.Rows[iRow].Cells["ProductoPrecio"].Value)),
                    Existencia = Convert.ToDecimal(dgvData.Rows[iRow].Cells["Existencia"].Value),
                    UnidadMedida = dgvData.Rows[iRow].Cells["UnidadMedida"].Value.ToString()
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ComboBusqueda.SelectedItem.ToString();

            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(TxtBusqueda.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtBusqueda.Clear();
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true;
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //no implementado
        }
    }
}

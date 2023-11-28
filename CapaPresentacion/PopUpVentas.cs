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
    public partial class PopUpVentas : Form
    {
        public Venta _Venta { get; set; }
        public PopUpVentas()
        {
            InitializeComponent();
        }

        private void PopUpVentas_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible)
                {
                    ComboBusqueda.Items.Add(columna.Name);
                }
            }
            ComboBusqueda.SelectedIndex = 0;

            List<Venta> listaVenta = new CN_Ventas().Listar();
            foreach (Venta venta in listaVenta)
            {
                dgvData.Rows.Add(venta.Id, venta.NumeroFactura, venta.Fecha, venta.Documento, venta.Nombre, venta.Total, venta.Anulado);
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

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColumn = e.ColumnIndex;

            if (iRow >= 0 && iColumn > 0)
            {
                _Venta = new Venta
                {
                    Id = Convert.ToInt32(dgvData.Rows[iRow].Cells["IdVenta"].Value.ToString()),
                    NumeroFactura = dgvData.Rows[iRow].Cells["Factura"].Value.ToString(),
                    Fecha = Convert.ToDateTime(dgvData.Rows[iRow].Cells["Fecha"].Value.ToString()),
                    Nombre = dgvData.Rows[iRow].Cells["Nombre"].Value.ToString(),
                    Total = Convert.ToDecimal(dgvData.Rows[iRow].Cells["TotalVenta"].Value.ToString()),
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

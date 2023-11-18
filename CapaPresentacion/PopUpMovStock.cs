using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class PopUpMovStock : Form
    {
        public MovimientoStock _MovimientoStock { get; set; }
        private int _Bandera;
        public PopUpMovStock(int bandera = 0)
        {
            _Bandera = bandera;
            InitializeComponent();
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
                _MovimientoStock = new MovimientoStock
                {
                    Id = Convert.ToInt32(dgvData.Rows[iRow].Cells["idMovStock"].Value.ToString()),
                    TipoMovimiento = dgvData.Rows[iRow].Cells["TipoMovimiento"].Value.ToString(),                  
                    Documento = dgvData.Rows[iRow].Cells["Documento"].Value.ToString(),
                    Fecha = Convert.ToDateTime(dgvData.Rows[iRow].Cells["Fecha"].Value.ToString()),
                    Total = Convert.ToDecimal(dgvData.Rows[iRow].Cells["TotalCantidad"].Value.ToString()),
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void PopUpMovStock_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible)
                {
                    ComboBusqueda.Items.Add(columna.Name);
                }
            }
            ComboBusqueda.SelectedIndex = 0;

            List<MovimientoStock> listaMovStock = new CN_MovimientosStock().Listar(_Bandera);
            foreach (MovimientoStock movStock in listaMovStock)
            {
                dgvData.Rows.Add(movStock.Id, movStock.TipoMovimiento, movStock.Documento, movStock.Fecha, movStock.Total, movStock.Confirmado, movStock.Anulado);
            }
        }
    }
}

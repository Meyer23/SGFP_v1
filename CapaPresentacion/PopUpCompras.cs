using CapaEntidad;
using CapaNegocio;
using CapaEntidad.Models;
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
    public partial class PopUpCompras : Form
    {
        public Compra _Compra { get; set; }
        public PopUpCompras()
        {
            InitializeComponent();
        }

        private void PopUpCompras_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible)
                {
                    ComboBusqueda.Items.Add(columna.Name);
                }
            }
            ComboBusqueda.SelectedIndex = 0;

            List<Compra> listaCompra = new CN_Compras().Listar();
            foreach (Compra compra in listaCompra)
            {
                dgvData.Rows.Add(compra.Id, compra.NumeroFactura, compra.Fecha, compra.Documento, compra.RazonSocial, compra.Total);
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
                _Compra = new Compra
                {
                    Id = Convert.ToInt32(dgvData.Rows[iRow].Cells["IdCompra"].Value.ToString()),
                    NumeroFactura = dgvData.Rows[iRow].Cells["Factura"].Value.ToString(),
                    Fecha = Convert.ToDateTime(dgvData.Rows[iRow].Cells["Fecha"].Value.ToString()),
                    RazonSocial = dgvData.Rows[iRow].Cells["RazonSocial"].Value.ToString(),
                    Total = Convert.ToDecimal(dgvData.Rows[iRow].Cells["TotalCompra"].Value.ToString()),
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

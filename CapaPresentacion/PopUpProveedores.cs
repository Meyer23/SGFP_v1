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
    public partial class PopUpProveedores : Form
    {
        public Proveedor _Proveedor { get; set; }
        public PopUpProveedores()
        {
            InitializeComponent();
        }

        private void PopUpProveedores_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible)
                {
                    ComboBusqueda.Items.Add(columna.Name);
                }
            }

            ComboBusqueda.SelectedIndex = 0;

            //Listar proveedores
            List<Proveedor> listaProveedor = new CN_Proveedores().Listar();
            foreach (Proveedor proveedor in listaProveedor)
            {
                dgvData.Rows.Add(proveedor.Id, proveedor.Documento, proveedor.RazonSocial);
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColumn = e.ColumnIndex;

            if (iRow >= 0 && iColumn > 0)
            {
                _Proveedor = new Proveedor
                {
                    Id = Convert.ToInt32(dgvData.Rows[iRow].Cells["idProveedor"].Value.ToString()),
                    Documento = dgvData.Rows[iRow].Cells["Documento"].Value.ToString(),
                    RazonSocial = dgvData.Rows[iRow].Cells["RazonSocial"].Value.ToString()
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
    }
}

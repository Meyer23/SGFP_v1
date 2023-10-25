using CapaEntidad;
using CapaEntidad.Models;
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
    public partial class PopUpPedidos : Form
    {
        public Pedido _Pedido { get; set; }
        private int _Bandera;

        public PopUpPedidos(int bandera = 0)
        {
            _Bandera = bandera;
            InitializeComponent();
        }

        private void PopUpPedidos_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible)
                {
                    ComboBusqueda.Items.Add(columna.Name);
                }
            }
            ComboBusqueda.SelectedIndex = 0;

            List<Pedido> listaPedido = new CN_Pedidos().Listar(_Bandera);
            foreach (Pedido pedido in listaPedido)
            {
                dgvData.Rows.Add(pedido.Id, pedido.NumeroPedido, pedido.Fecha, pedido.Documento, pedido.RazonSocial, pedido.Total);
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
                _Pedido = new Pedido
                {
                    NumeroPedido = Convert.ToInt32(dgvData.Rows[iRow].Cells["NumeroPedido"].Value.ToString()),
                    Fecha = Convert.ToDateTime(dgvData.Rows[iRow].Cells["Fecha"].Value.ToString()),
                    RazonSocial = dgvData.Rows[iRow].Cells["RazonSocial"].Value.ToString(),
                    Total = Convert.ToDecimal(dgvData.Rows[iRow].Cells["TotalPedido"].Value.ToString()),
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

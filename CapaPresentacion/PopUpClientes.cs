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

namespace CapaPresentacion
{
    public partial class PopUpClientes : Form
    {
        public ClientePopUp cliente { get; set; }
        public PopUpClientes()
        {
            InitializeComponent();
        }

        private void PopUpClientes_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible)
                {
                    ComboBusqueda.Items.Add(columna.Name);
                }
            }

            ComboBusqueda.SelectedIndex = 0;

            //Listar clientes
            List<Cliente> listaCliente = new CN_Clientes().Listar();
            foreach (Cliente clientes in listaCliente)
            {
                dgvData.Rows.Add(clientes.Id, clientes.Nombre, clientes.Apellido, clientes.Documento);
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //no implementado
        }

        private void dgvData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //no implementado|
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColumn = e.ColumnIndex;

            try
            {
                if (iRow >= 0 && iColumn > 0)
                {
                    cliente = new ClientePopUp
                    {
                        IdCliente = Convert.ToInt32(dgvData.Rows[iRow].Cells["idCliente"].Value.ToString()),
                        ClienteNombre = dgvData.Rows[iRow].Cells["ClienteNombre"].Value.ToString(),
                        ClienteApellido = dgvData.Rows[iRow].Cells["ClienteApellido"].Value.ToString(),
                        ClienteRuc = dgvData.Rows[iRow].Cells["ClienteRuc"].Value.ToString()
                    };

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }
    }
}

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
    public partial class PopUpNCEmitidas : Form
    {
        public NotaCreditoEmitida _NCEmitida { get; set; }
        private int _Bandera;
        public PopUpNCEmitidas(int bandera = 0)
        {
            _Bandera = bandera;
            InitializeComponent();
        }

        private void PopUpNCEmitidas_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible)
                {
                    ComboBusqueda.Items.Add(columna.Name);
                }
            }
            ComboBusqueda.SelectedIndex = 0;

            List<NotaCreditoEmitida> listaNota = new CN_NotasCreditoEmitidas().Listar(_Bandera);
            foreach (NotaCreditoEmitida nota in listaNota)
            {
                dgvData.Rows.Add(nota.Id, nota.NumeroNota, nota.Fecha, nota.Documento, nota.Nombre, nota.Total, nota.Confirmado, nota.Anulado);
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
                _NCEmitida = new NotaCreditoEmitida
                {
                    Id = Convert.ToInt32(dgvData.Rows[iRow].Cells["idNCEmitida"].Value.ToString()),
                    NumeroNota = dgvData.Rows[iRow].Cells["NotaCredito"].Value.ToString(),
                    Fecha = Convert.ToDateTime(dgvData.Rows[iRow].Cells["Fecha"].Value.ToString()),
                    Nombre = dgvData.Rows[iRow].Cells["RazonSocial"].Value.ToString(),
                    Total = Convert.ToDecimal(dgvData.Rows[iRow].Cells["TotalNota"].Value.ToString()),
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

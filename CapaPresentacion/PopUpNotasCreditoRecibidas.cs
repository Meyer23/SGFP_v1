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
    public partial class PopUpNotasCreditoRecibidas : Form
    {
        public NotaCreditoRecibida _NCRecibida { get; set; }
        private int _Bandera;
        public PopUpNotasCreditoRecibidas(int bandera = 0)
        {
            _Bandera = bandera;
            InitializeComponent();
        }

        private void PopUpNotasCreditoRecibidas_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible)
                {
                    ComboBusqueda.Items.Add(columna.Name);
                }
            }
            ComboBusqueda.SelectedIndex = 0;

            List<NotaCreditoRecibida> listaNota = new CN_NotasCreditoRecibidas().Listar(_Bandera);
            foreach (NotaCreditoRecibida nota in listaNota)
            {
                dgvData.Rows.Add(nota.Id, nota.NumeroNota, nota.Fecha, nota.Documento, nota.RazonSocial, nota.Total, nota.Confirmado, nota.Anulado);
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
                _NCRecibida = new NotaCreditoRecibida
                {
                    Id = Convert.ToInt32(dgvData.Rows[iRow].Cells["idNCRecibida"].Value.ToString()),
                    NumeroNota = dgvData.Rows[iRow].Cells["NotaCredito"].Value.ToString(),
                    Fecha = Convert.ToDateTime(dgvData.Rows[iRow].Cells["Fecha"].Value.ToString()),
                    RazonSocial = dgvData.Rows[iRow].Cells["RazonSocial"].Value.ToString(),
                    Total = Convert.ToDecimal(dgvData.Rows[iRow].Cells["TotalNota"].Value.ToString()),
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

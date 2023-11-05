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
    public partial class PopUpTipoValor : Form
    {
        public Valor Valor { get; set; }
        public PopUpTipoValor()
        {
            InitializeComponent();
        }

        private void PopUpTipoValor_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                ComboBusqueda.Items.Add(columna.Name);
            }

            ComboBusqueda.SelectedIndex = 0;

            List<Valor> listaValores = new CN_Valores().Listar();

            foreach(Valor valores in listaValores)
            {
                dgvData.Rows.Add("", valores.Descripcion, valores.ValidaDocumento);
            }
        }

        private void dgvData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColumn = e.ColumnIndex;

            if (iRow >= 0 && iColumn > 0)
            {
                object validadocumento = dgvData.Rows[iRow].Cells["ValidaDocumento"].Value;

                if(validadocumento != null)
                {
                    if(validadocumento is bool)
                    {
                        Valor = new Valor
                        {
                            Descripcion = dgvData.Rows[iRow].Cells["Descripcion"].Value.ToString(),
                            ValidaDocumento = (bool)validadocumento
                        };
                    }
                }
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

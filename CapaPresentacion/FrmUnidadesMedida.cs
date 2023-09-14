using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Interfaces;
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
    public partial class FrmUnidadesMedida : Form, IFormularioConIdUsuario
    {
        bool estadoUnidadMedida;

        public int IdUsuario { get; set; }

        public FrmUnidadesMedida()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            try
            {
                UnidadMedida objUnidadMedida = new UnidadMedida()
                {
                    Id = Convert.ToInt32(TxtIdUnidadMedida.Text),
                    Abreviacion = TxtAbreviacion.Text,
                    Descripcion = TxtDescripcion.Text,
                    Activo = (bool)(ChkActivo.Checked)
                };

                if (objUnidadMedida.Id == 0)
                {
                    int IdUnidadMedida = new CN_UnidadesMedida().Registrar(objUnidadMedida, out Mensaje);

                    if (IdUnidadMedida != 0)
                    {
                        dgvData.Rows.Add(new object[] { "", IdUnidadMedida, TxtAbreviacion.Text, TxtDescripcion.Text, ChkActivo.Checked });
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show(Mensaje);
                    }
                }
                else
                {
                    bool resultado = new CN_UnidadesMedida().Editar(objUnidadMedida, out Mensaje);

                    if (resultado)
                    {
                        DataGridViewRow row = dgvData.Rows[Convert.ToInt32(TxtIndex.Text)];
                        row.Cells["idUnidadMedida"].Value = TxtIdUnidadMedida.Text;
                        row.Cells["Abreviacion"].Value = TxtAbreviacion.Text;
                        row.Cells["Descripcion"].Value = TxtDescripcion.Text;
                        row.Cells["Activo"].Value = ChkActivo.Checked;

                        limpiar();
                        TxtAbreviacion.ReadOnly = false;
                    }
                    else
                    {
                        MessageBox.Show(Mensaje);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void limpiar()
        {
            TxtIndex.Clear();
            TxtIdUnidadMedida.Text = "0";
            TxtAbreviacion.Clear();
            TxtDescripcion.Clear();
            TxtBusqueda.Select();
            TxtAbreviacion.ReadOnly = false;
        }

        private void FrmUnidadesMedida_Load(object sender, EventArgs e)
        {
            int usuarioActual = this.IdUsuario;

            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible && columna.Name != "BtnSeleccionar")
                {
                    ComboBusqueda.Items.Add(columna.Name);
                }
            }
            ComboBusqueda.SelectedIndex = 0;

            List<UnidadMedida> listaUnidadMedida = new CN_UnidadesMedida().Listar();
            foreach (UnidadMedida unidadMedida in listaUnidadMedida)
            {
                dgvData.Rows.Add("", unidadMedida.Id, unidadMedida.Abreviacion, unidadMedida.Descripcion, unidadMedida.Activo);
            }

            TxtBusqueda.Select();
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.check_azul.Width;
                var h = Properties.Resources.check_azul.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check_azul, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtAbreviacion.ReadOnly = true;

            if (dgvData.Columns[e.ColumnIndex].Name == "BtnSeleccionar")
            {
                int index = e.RowIndex;

                if (index >= 0)
                {
                    TxtIndex.Text = index.ToString();
                    TxtIdUnidadMedida.Text = dgvData.Rows[index].Cells["idUnidadMedida"].Value.ToString();
                    TxtAbreviacion.Text = dgvData.Rows[index].Cells["Abreviacion"].Value.ToString();
                    TxtDescripcion.Text = dgvData.Rows[index].Cells["Descripcion"].Value.ToString();                   
                    estadoUnidadMedida = (bool)dgvData.Rows[index].Cells["Activo"].Value;
                    if (estadoUnidadMedida == true)
                    {
                        ChkActivo.Checked = true;
                    }
                    else
                    {
                        ChkActivo.Checked = false;
                    }
                }
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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void TxtAbreviacion_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtAbreviacion.Text))
            {
                //e.Cancel = true;
                errorProvider1.SetError(TxtAbreviacion, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtAbreviacion, "");
            }
        }

        private void TxtDescripcion_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtDescripcion.Text))
            {
                //e.Cancel = true;
                TxtDescripcion.Focus();
                errorProvider1.SetError(TxtDescripcion, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtDescripcion, "");
            }
        }
    }
}

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
    public partial class FrmValores : Form, IFormularioConIdUsuario
    {
        bool estadoValor, estadoValidaDoc;

        public int IdUsuario { get; set; }

        public FrmValores()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            try
            {
                Valor objValor = new Valor()
                {
                    Id = Convert.ToInt32(TxtIdValor.Text),
                    Descripcion = TxtDescripcion.Text,
                    ValidaDocumento = (bool)(ChkValidaDocumento.Checked),
                    Activo = (bool)(ChkActivo.Checked)
                };

                if (objValor.Id == 0)
                {
                    int IdValor = new CN_Valores().Registrar(objValor, out Mensaje);

                    if (IdValor != 0)
                    {
                        dgvData.Rows.Add(new object[] { "", IdValor, TxtDescripcion.Text, ChkValidaDocumento.Checked, ChkActivo.Checked });
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show(Mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    bool resultado = new CN_Valores().Editar(objValor, out Mensaje);

                    if (resultado)
                    {
                        DataGridViewRow row = dgvData.Rows[Convert.ToInt32(TxtIndex.Text)];
                        row.Cells["IdValor"].Value = TxtIdValor.Text;
                        row.Cells["Descripcion"].Value = TxtDescripcion.Text;
                        row.Cells["ValidaDocumento"].Value = ChkValidaDocumento.Checked;
                        row.Cells["Activo"].Value = ChkActivo.Checked;

                        limpiar();
                        TxtDescripcion.ReadOnly = false;
                    }
                    else
                    {
                        MessageBox.Show(Mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiar()
        {
            TxtIndex.Clear();
            TxtIdValor.Text = "0";
            TxtDescripcion.Clear();
            ChkValidaDocumento.Checked = false;
            TxtBusqueda.Select();
            TxtDescripcion.ReadOnly = false;
        }

        private void FrmValores_Load(object sender, EventArgs e)
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

            List<Valor> listaValor = new CN_Valores().Listar();
            foreach (Valor valor in listaValor)
            {
                dgvData.Rows.Add("", valor.Id, valor.Descripcion, valor.ValidaDocumento, valor.Activo);
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

        private void TxtDescripcion_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtDescripcion.Text))
            {
                //e.Cancel = true;
                errorProvider1.SetError(TxtDescripcion, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtDescripcion, "");
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtDescripcion.ReadOnly = true;

            if (dgvData.Columns[e.ColumnIndex].Name == "BtnSeleccionar")
            {
                int index = e.RowIndex;

                if (index >= 0)
                {
                    TxtIndex.Text = index.ToString();
                    TxtIdValor.Text = dgvData.Rows[index].Cells["IdValor"].Value.ToString();
                    TxtDescripcion.Text = dgvData.Rows[index].Cells["Descripcion"].Value.ToString();
                    estadoValidaDoc = (bool)dgvData.Rows[index].Cells["ValidaDocumento"].Value;
                    if (estadoValidaDoc == true)
                    {
                        ChkValidaDocumento.Checked = true;
                    }
                    else
                    {
                        ChkValidaDocumento.Checked = false;
                    }
                    estadoValor = (bool)dgvData.Rows[index].Cells["Activo"].Value;
                    if (estadoValor == true)
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
    }
}

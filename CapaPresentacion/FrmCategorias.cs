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
    public partial class FrmCategorias : Form, IFormularioConIdUsuario
    {
        bool estadoCategoria;       

        public int IdUsuario { get; set; }     

        public FrmCategorias()
        {
            InitializeComponent();
            CargarImpuestos();            
        }

        private void CargarImpuestos()
        {
            List<Impuesto> roles = new CN_Impuestos().ObtenerImpuestos();
            ComboImpuesto.DataSource = roles;

            foreach (Impuesto impuesto in roles)
            {
                ComboImpuesto.DisplayMember = "Descripcion";
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            try
            {
                Categoria objCategoria = new Categoria()
                {
                    Id = Convert.ToInt32(TxtIdCategoria.Text),
                    Nombre = TxtNombre.Text,
                    Descripcion = TxtDescripcion.Text,
                    PorcUtilidad = Convert.ToDecimal(TxtPorcUtilidad.Text),
                    Impuesto = ComboImpuesto.Text.ToString(),
                    Activo = (bool)(ChkActivo.Checked)
                };

                if (objCategoria.Id == 0)
                {
                    int idCategoria = new CN_Categorias().Registrar(objCategoria, out Mensaje);

                    if (idCategoria != 0)
                    {
                        dgvData.Rows.Add(new object[] { "", idCategoria, TxtNombre.Text, TxtDescripcion.Text, TxtPorcUtilidad.Text, ComboImpuesto.Text, ChkActivo.Checked });
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
                    bool resultado = new CN_Categorias().Editar(objCategoria, out Mensaje);

                    if (resultado)
                    {
                        DataGridViewRow row = dgvData.Rows[Convert.ToInt32(TxtIndex.Text)];
                        row.Cells["IdCategoria"].Value = TxtIdCategoria.Text;
                        row.Cells["Nombre"].Value = TxtNombre.Text;
                        row.Cells["Descripcion"].Value = TxtDescripcion.Text;
                        row.Cells["PorcUtilidad"].Value = TxtPorcUtilidad.Text;
                        row.Cells["Impuesto"].Value = ComboImpuesto.Text;
                        row.Cells["Activo"].Value = ChkActivo.Checked;

                        limpiar();
                        TxtNombre.ReadOnly = false;
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
            TxtIdCategoria.Text = "0";
            TxtNombre.Clear();
            TxtDescripcion.Clear();
            TxtPorcUtilidad.Clear();
            ComboImpuesto.SelectedIndex = 0;
            TxtBusqueda.Select();
            TxtNombre.ReadOnly = false;
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
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

            List<Categoria> listaCategoria = new CN_Categorias().Listar();
            foreach (Categoria categoria in listaCategoria)
            {
                dgvData.Rows.Add("", categoria.Id, categoria.Nombre, categoria.Descripcion, categoria.PorcUtilidad,
                                 categoria.Impuesto, categoria.Activo);
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
            TxtNombre.ReadOnly = true;

            if (dgvData.Columns[e.ColumnIndex].Name == "BtnSeleccionar")
            {
                int index = e.RowIndex;

                if (index >= 0)
                {
                    TxtIndex.Text = index.ToString();
                    TxtIdCategoria.Text = dgvData.Rows[index].Cells["IdCategoria"].Value.ToString();
                    TxtNombre.Text = dgvData.Rows[index].Cells["Nombre"].Value.ToString();
                    TxtDescripcion.Text = dgvData.Rows[index].Cells["Descripcion"].Value.ToString();
                    TxtPorcUtilidad.Text = dgvData.Rows[index].Cells["PorcUtilidad"].Value.ToString();
                    ComboImpuesto.Text = dgvData.Rows[index].Cells["Impuesto"].Value.ToString();
                    estadoCategoria = (bool)dgvData.Rows[index].Cells["Activo"].Value;
                    if (estadoCategoria == true)
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

        private void TxtNombre_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtNombre.Text))
            {
                //e.Cancel = true;
                errorProvider1.SetError(TxtNombre, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtNombre, "");
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

        private void TxtPorcUtilidad_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtPorcUtilidad.Text))
            {
                //e.Cancel = true;
                TxtPorcUtilidad.Focus();
                errorProvider1.SetError(TxtPorcUtilidad, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtPorcUtilidad, "");
            }
        }

        private void BtnGenerarPrecios_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            Categoria objCategoria = new Categoria()
            {
                Id = Convert.ToInt32(TxtIdCategoria.Text),
                Nombre = TxtNombre.Text,
                Descripcion = TxtDescripcion.Text,
                PorcUtilidad = Convert.ToDecimal(TxtPorcUtilidad.Text),
                Impuesto = ComboImpuesto.Text.ToString(),
                Activo = (bool)(ChkActivo.Checked)
            };

            bool resultado = new CN_Categorias().GemerarPrecios(objCategoria, out Mensaje);
            
            if (resultado)
            {
                MessageBox.Show("Precios generados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show(Mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
    }
}

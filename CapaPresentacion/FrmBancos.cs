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
    public partial class FrmBancos : Form, IFormularioConIdUsuario
    {
        bool estadoBanco;

        public int IdUsuario { get; set; }

        public FrmBancos()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            try
            {
                Banco objBanco = new Banco()
                {
                    Id = Convert.ToInt32(TxtIdBanco.Text),
                    Nombre = TxtNombre.Text,
                    Activo = (bool)(ChkActivo.Checked)
                };

                if (objBanco.Id == 0)
                {
                    int IdBanco = new CN_Bancos().Registrar(objBanco, out Mensaje);

                    if (IdBanco != 0)
                    {
                        dgvData.Rows.Add(new object[] { "", IdBanco, TxtNombre.Text, ChkActivo.Checked });
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show(Mensaje);
                    }
                }
                else
                {
                    bool resultado = new CN_Bancos().Editar(objBanco, out Mensaje);

                    if (resultado)
                    {
                        DataGridViewRow row = dgvData.Rows[Convert.ToInt32(TxtIndex.Text)];
                        row.Cells["IdBanco"].Value = TxtIdBanco.Text;
                        row.Cells["Nombre"].Value = TxtNombre.Text;
                        row.Cells["Activo"].Value = ChkActivo.Checked;

                        limpiar();
                        TxtNombre.ReadOnly = false;
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
            TxtIdBanco.Text = "0";
            TxtNombre.Clear();
            TxtBusqueda.Select();
            TxtNombre.ReadOnly = false;
        }

        private void FrmBancos_Load(object sender, EventArgs e)
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

            List<Banco> listaBanco = new CN_Bancos().Listar();
            foreach (Banco banco in listaBanco)
            {
                dgvData.Rows.Add("", banco.Id, banco.Nombre, banco.Activo);
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
                    TxtIdBanco.Text = dgvData.Rows[index].Cells["IdBanco"].Value.ToString();
                    TxtNombre.Text = dgvData.Rows[index].Cells["Nombre"].Value.ToString();
                    estadoBanco = (bool)dgvData.Rows[index].Cells["Activo"].Value;
                    if (estadoBanco == true)
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
    }
}

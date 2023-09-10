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
    public partial class FrmTimbrados : Form
    {
        bool estadoTimbrado;
        public FrmTimbrados()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            try
            {
                Timbrado objTimbrado = new Timbrado()
                {
                    Id = Convert.ToInt32(TxtIdTimbrado.Text),
                    NroTimbrado = Convert.ToInt32(TxtNroTimbrado.Text),
                    InicioVigencia = (DateTime)(DtInicioVigencia.Value),
                    FinVigencia = (DateTime)(DtFinVigencia.Value),
                    NroDesde = Convert.ToInt32(TxtNroDesde.Text),
                    NroHasta = Convert.ToInt32(TxtNroHasta.Text),
                    Activo = (bool)(ChkActivo.Checked)
                };

                if (objTimbrado.Id == 0)
                {
                    int idTimbrado = new CN_Timbrados().Registrar(objTimbrado, out Mensaje);

                    if (idTimbrado != 0)
                    {
                        dgvData.Rows.Add(new object[] { "", idTimbrado, TxtNroTimbrado.Text, DtInicioVigencia.Value, DtFinVigencia.Value, TxtNroDesde.Text, TxtNroHasta.Text, ChkActivo.Checked });
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show(Mensaje);
                    }
                }
                else
                {
                    bool resultado = new CN_Timbrados().Editar(objTimbrado, out Mensaje);

                    if (resultado)
                    {
                        DataGridViewRow row = dgvData.Rows[Convert.ToInt32(TxtIndex.Text)];
                        row.Cells["IdTimbrado"].Value = TxtIdTimbrado.Text;
                        row.Cells["NroTimbrado"].Value = TxtNroTimbrado.Text;
                        row.Cells["InicioVigencia"].Value = DtInicioVigencia.Value;
                        row.Cells["FinVigencia"].Value = DtFinVigencia.Value;
                        row.Cells["NroDesde"].Value = TxtNroDesde.Text;
                        row.Cells["NroHasta"].Value = TxtNroHasta.Text;
                        row.Cells["Activo"].Value = ChkActivo.Checked;

                        limpiar();
                        TxtNroTimbrado.ReadOnly = false;
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
            TxtIdTimbrado.Text = "0";
            TxtNroTimbrado.Clear();
            DtInicioVigencia.Value = DateTime.Today;
            DtFinVigencia.Value = DateTime.Today;
            TxtNroDesde.Clear();
            TxtNroHasta.Clear();
            TxtBusqueda.Select();
            TxtNroTimbrado.ReadOnly = false;
        }

        private void FrmTimbrados_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible && columna.Name != "BtnSeleccionar")
                {
                    ComboBusqueda.Items.Add(columna.Name);
                }
            }

            ComboBusqueda.SelectedIndex = 0;

            List<Timbrado> listaTimbrado = new CN_Timbrados().Listar();
            foreach (Timbrado timbrado in listaTimbrado)
            {
                dgvData.Rows.Add("", timbrado.Id, timbrado.NroTimbrado, timbrado.InicioVigencia, timbrado.FinVigencia,
                                 timbrado.NroDesde, timbrado.NroHasta, timbrado.Activo);
            }

            //TxtNombres.Select();
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
            TxtNroTimbrado.ReadOnly = true;

            if (dgvData.Columns[e.ColumnIndex].Name == "BtnSeleccionar")
            {
                int index = e.RowIndex;

                if (index >= 0)
                {
                    TxtIndex.Text = index.ToString();
                    TxtIdTimbrado.Text = dgvData.Rows[index].Cells["IdTimbrado"].Value.ToString();
                    TxtNroTimbrado.Text = dgvData.Rows[index].Cells["NroTimbrado"].Value.ToString();
                    if (DateTime.TryParse(dgvData.Rows[index].Cells["InicioVigencia"].Value.ToString(), out DateTime selectedDate1))
                    {
                        DtInicioVigencia.Value = selectedDate1;
                    }
                    if (DateTime.TryParse(dgvData.Rows[index].Cells["FinVigencia"].Value.ToString(), out DateTime selectedDate2))
                    {
                        DtFinVigencia.Value = selectedDate2;
                    }
                    TxtNroDesde.Text = dgvData.Rows[index].Cells["NroDesde"].Value.ToString();
                    TxtNroHasta.Text = dgvData.Rows[index].Cells["NroHasta"].Value.ToString();
                    estadoTimbrado = (bool)dgvData.Rows[index].Cells["Activo"].Value;
                    if (estadoTimbrado == true)
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

        private void TxtNroTimbrado_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtNroTimbrado.Text))
            {
                //e.Cancel = true;
                //TxtNombres.Focus();
                errorProvider1.SetError(TxtNroTimbrado, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtNroTimbrado, "");
            }
        }

        private void TxtNroDesde_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtNroDesde.Text))
            {
                //e.Cancel = true;
                TxtNroDesde.Focus();
                errorProvider1.SetError(TxtNroDesde, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtNroDesde, "");
            }
        }

        private void TxtNroHasta_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtNroHasta.Text))
            {
                //e.Cancel = true;
                TxtNroHasta.Focus();
                errorProvider1.SetError(TxtNroHasta, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtNroHasta, "");
            }

        }
    }
}

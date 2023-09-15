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
    public partial class FrmImpuestos : Form, IFormularioConIdUsuario
    {
        bool estadoImpuesto;

        public int IdUsuario { get; set; }

        public FrmImpuestos()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            try
            {
                Impuesto objImpuesto = new Impuesto()
                {
                    Id = Convert.ToInt32(TxtIdImpuesto.Text),
                    TipoImpuesto = Convert.ToInt32(TxtTipoImpuesto.Text),
                    Descripcion = TxtDescripcion.Text,
                    PorcIVA = Convert.ToDecimal(TxtPorcIVA.Text),
                    FactorGravada = Convert.ToDecimal(TxtFactorGravada.Text),
                    FactorIVA = Convert.ToDecimal(TxtFactorIVA.Text),
                    Activo = (bool)(ChkActivo.Checked)
                };

                if (objImpuesto.Id == 0)
                {
                    int idImpuesto = new CN_Impuestos().Registrar(objImpuesto, out Mensaje);

                    if (idImpuesto != 0)
                    {
                        dgvData.Rows.Add(new object[] { "", idImpuesto, TxtTipoImpuesto.Text, TxtDescripcion.Text, TxtPorcIVA.Text, TxtFactorGravada.Text, TxtFactorIVA.Text, ChkActivo.Checked });
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
                    bool resultado = new CN_Impuestos().Editar(objImpuesto, out Mensaje);

                    if (resultado)
                    {
                        DataGridViewRow row = dgvData.Rows[Convert.ToInt32(TxtIndex.Text)];
                        row.Cells["idImpuesto"].Value = TxtIdImpuesto.Text;
                        row.Cells["TipoImpuesto"].Value = TxtTipoImpuesto.Text;
                        row.Cells["Descripcion"].Value = TxtDescripcion.Text;
                        row.Cells["PorcIVA"].Value = TxtPorcIVA.Text;
                        row.Cells["FactorGravada"].Value = TxtFactorGravada.Text;
                        row.Cells["FactorIVA"].Value = TxtFactorIVA.Text;
                        row.Cells["Activo"].Value = ChkActivo.Checked;

                        limpiar();
                        TxtTipoImpuesto.ReadOnly = false;
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
            TxtIdImpuesto.Text = "0";
            TxtTipoImpuesto.Clear();
            TxtDescripcion.Clear();
            TxtPorcIVA.Clear();
            TxtFactorGravada.Clear();
            TxtFactorIVA.Clear();
            TxtBusqueda.Select();
            TxtTipoImpuesto.ReadOnly = false;
        }

        private void FrmImpuestos_Load(object sender, EventArgs e)
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

            List<Impuesto> listaImpuesto = new CN_Impuestos().Listar();
            foreach (Impuesto impuesto in listaImpuesto)
            {
                dgvData.Rows.Add("", impuesto.Id, impuesto.TipoImpuesto, impuesto.Descripcion, impuesto.PorcIVA,
                                 impuesto.FactorGravada, impuesto.FactorIVA, impuesto.Activo);
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
            TxtTipoImpuesto.ReadOnly = true;

            if (dgvData.Columns[e.ColumnIndex].Name == "BtnSeleccionar")
            {
                int index = e.RowIndex;

                if (index >= 0)
                {
                    TxtIndex.Text = index.ToString();
                    TxtIdImpuesto.Text = dgvData.Rows[index].Cells["idImpuesto"].Value.ToString();
                    TxtTipoImpuesto.Text = dgvData.Rows[index].Cells["TipoImpuesto"].Value.ToString();
                    TxtDescripcion.Text = dgvData.Rows[index].Cells["Descripcion"].Value.ToString();
                    TxtPorcIVA.Text = dgvData.Rows[index].Cells["PorcIVA"].Value.ToString();
                    TxtFactorGravada.Text = dgvData.Rows[index].Cells["FactorGravada"].Value.ToString();
                    TxtFactorIVA.Text = dgvData.Rows[index].Cells["FactorIVA"].Value.ToString();
                    estadoImpuesto = (bool)dgvData.Rows[index].Cells["Activo"].Value;
                    if (estadoImpuesto == true)
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

        private void TxtTipoImpuesto_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtTipoImpuesto.Text))
            {
                //e.Cancel = true;
                errorProvider1.SetError(TxtTipoImpuesto, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtTipoImpuesto, "");
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

        private void TxtPorcIVA_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtPorcIVA.Text))
            {
                //e.Cancel = true;
                TxtPorcIVA.Focus();
                errorProvider1.SetError(TxtPorcIVA, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtPorcIVA, "");
            }
        }

        private void TxtFactorGravada_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtFactorGravada.Text))
            {
                //e.Cancel = true;
                TxtFactorGravada.Focus();
                errorProvider1.SetError(TxtFactorGravada, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtFactorGravada, "");
            }
        }

        private void TxtFactorIVA_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtFactorIVA.Text))
            {
                //e.Cancel = true;
                TxtFactorIVA.Focus();
                errorProvider1.SetError(TxtFactorIVA, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtFactorIVA, "");
            }
        }
    }                       
}

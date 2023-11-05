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
    public partial class FrmTiposDocumentos : Form
    {
        bool estadoTipoDocumento, tipocod;
        public FrmTiposDocumentos()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            try
            {
                bool tipo;
                if (radioButtonContado.Checked)
                {
                    tipo = false;
                }
                else
                {
                    tipo = true;
                }
                TipoDocumento objTipoDocumento = new TipoDocumento()
                {
                    Id = Convert.ToInt32(TxtIdTipoDocumento.Text),
                    Descripcion = TxtDescripcion.Text,
                    TipoCodigo = (bool)(tipo),
                    Activo = (bool)(ChkActivo.Checked)
                };

                if (objTipoDocumento.Id == 0)
                {
                    int idTipoDocumento = new CN_TiposDocumentos().Registrar(objTipoDocumento, out Mensaje);

                    if (idTipoDocumento != 0)
                    {
                        bool insert = new CN_TiposDocumentos().InsertarFormasPago(idTipoDocumento);
                        dgvData.Rows.Add(new object[] { "", idTipoDocumento, TxtDescripcion.Text, tipo, ChkActivo.Checked });
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
                    bool resultado = new CN_TiposDocumentos().Editar(objTipoDocumento, out Mensaje);

                    if (resultado)
                    {
                        DataGridViewRow row = dgvData.Rows[Convert.ToInt32(TxtIndex.Text)];
                        row.Cells["IdCategoria"].Value = TxtIdTipoDocumento.Text;
                        row.Cells["Descripcion"].Value = TxtDescripcion.Text;
                        row.Cells["TipoCodigo"].Value = tipo;
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
            TxtIdTipoDocumento.Text = "0";
            TxtDescripcion.Clear();
            radioButtonContado.Checked = true;
            radioButtonCredito.Checked = false;
            TxtBusqueda.Select();
            TxtDescripcion.ReadOnly = false;
            dgvFormasPagoData.Rows.Clear();
            dgvFormasPagoData.Visible = false;
        }

        private void FrmTiposDocumentos_Load(object sender, EventArgs e)
        {
            dgvFormasPagoData.Visible = false;

            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible && columna.Name != "BtnSeleccionar")
                {
                    ComboBusqueda.Items.Add(columna.Name);
                }
            }
            ComboBusqueda.SelectedIndex = 0;

            List<TipoDocumento> listaTiposDocumentos = new CN_TiposDocumentos().Listar();
            foreach (TipoDocumento tipoDocumento in listaTiposDocumentos)
            {
                dgvData.Rows.Add("", tipoDocumento.Id, tipoDocumento.Descripcion, tipoDocumento.TipoCodigo,
                                 tipoDocumento.Activo);
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
                TxtDescripcion.Focus();
                errorProvider1.SetError(TxtDescripcion, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtDescripcion, "");
            }
        }

        private void dgvFormasPagoData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bool Acepta;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Acepta = (bool)dgvFormasPagoData.Rows[e.RowIndex].Cells["Acepta"].Value;

                bool insert = new CN_TiposDocumentos().EditarFormasPago(Convert.ToInt32(TxtIdTipoDocumento.Text), Convert.ToInt32(dgvFormasPagoData.Rows[e.RowIndex].Cells["IdFormaPago"].Value), Acepta);
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtDescripcion.ReadOnly = true;
            dgvFormasPagoData.Visible = true;

            if (dgvData.Columns[e.ColumnIndex].Name == "BtnSeleccionar")
            {
                int index = e.RowIndex;

                if (index >= 0)
                {
                    dgvFormasPagoData.Rows.Clear();
                    TxtIndex.Text = index.ToString();
                    TxtIdTipoDocumento.Text = dgvData.Rows[index].Cells["IdTipoDocumento"].Value.ToString();
                    TxtDescripcion.Text = dgvData.Rows[index].Cells["Descripcion"].Value.ToString();
                    tipocod = (bool)dgvData.Rows[index].Cells["TipoCodigo"].Value;
                    if (tipocod == true)
                    {
                        radioButtonContado.Checked = true;
                    }
                    else
                    {
                        radioButtonCredito.Checked = true;
                    }
                    estadoTipoDocumento = (bool)dgvData.Rows[index].Cells["Activo"].Value;
                    if (estadoTipoDocumento == true)
                    {
                        ChkActivo.Checked = true;
                    }
                    else
                    {
                        ChkActivo.Checked = false;
                    }

                    int IdTipoDoc = Convert.ToInt32(dgvData.Rows[index].Cells["idTipoDocumento"].Value.ToString());
                    List<TipoDocFormaPago> listaFormasPago = new CN_TiposDocumentos().ListarFormasPago(IdTipoDoc);
                    foreach (TipoDocFormaPago formasPago in listaFormasPago)
                    {
                        dgvFormasPagoData.Rows.Add(formasPago.Id, formasPago.IdTipoDoc, formasPago.IdFormaPago, formasPago.Descripcion, formasPago.Acepta);
                    }
                }
            }
        }
    }
}

using CapaEntidad;
using CapaEntidad.Models;
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
    public partial class FrmNumeracionDocumento : Form
    {
        public int idNumeracionDoc { get; set; }
        bool tipoDocumento;
        public FrmNumeracionDocumento()
        {
            InitializeComponent();
            CargarComboCajas();
            CargarComboSucursal();
            ComboTimbrados();
        }

        private void CargarComboCajas()
        {
            List<Cajas> cajas = new CN_Cajas().ObtenerCajas();
            ComboCajas.DataSource = cajas;

            foreach (Cajas resultCajas in cajas)
            {
                ComboCajas.DisplayMember = "DescripcionCaja";
            }
        }

        private void CargarComboSucursal()
        {
            List<Sucursales> sucursales = new CN_Sucursal().ObtenerSucursal();

            ComboSucursal.DataSource = sucursales;

            foreach (Sucursales d in sucursales)
            {
                ComboSucursal.DisplayMember = "DescripcionSucursal";
            }
        }

        private void ComboTimbrados()
        {
            List<Timbrado> timbradosList = new CN_Timbrados().Listar();

            List<Timbrado> timbradosActivos = timbradosList.Where(t => t.Activo).ToList();

            ComboNroTimbrado.DataSource = timbradosActivos;
            ComboNroTimbrado.DisplayMember = "NroTimbrado";

            //ComboIdTimbrado.SelectedIndexChanged += ComboIdTimbrado_SelectedIndexChanged;

            //// Inicializa TxtTimbrado con el valor del primer elemento en la lista (si existe)
            //if (timbradosList.Count > 0)
            //{
            //    MostrarInfoTimbrado(timbradosList[0]);
            //}
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            try
            {
                bool tipo;
                if (radioButtonFactura.Checked)
                {
                    tipo = false;
                }
                else
                {
                    tipo = true;
                }
                NumeracionDocumento obj = new NumeracionDocumento()
                {
                    CodigoEstablecimiento = TxtCodEstablecimiento.Text,
                    PuntoEmision = Convert.ToInt32(TxtPuntoEmision.Text),
                    UltimoNumero = Convert.ToInt32(TxTUltimoNro.Text),
                    NroTimbrado = Convert.ToInt32(ComboNroTimbrado.Text),
                    DescripcionCaja = ComboCajas.Text,
                    TipoDoc = (bool)(tipo)

                };

                int idNumeracionDocumento = new CN_NumeracionDocumento().InsertarNuevaNumeracionDocumento(obj, out Mensaje);

                if (idNumeracionDocumento > 0)
                {
                    dgvData.Rows.Add(new object[] { "", idNumeracion, ComboCajas.Text, TxtPuntoEmision.Text, TxtCodEstablecimiento.Text, TxTUltimoNro.Text, ComboNroTimbrado.Text, tipo });
                    Limpiar();
                    return;
                }
                else
                {
                    MessageBox.Show(Mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Limpiar();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                return;
            }
        }

        private void Limpiar()
        {
            TxtCodEstablecimiento.Clear();
            TxtPuntoEmision.Clear();
            TxTUltimoNro.Clear();
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

        private void FrmNumeracionDocumento_Load(object sender, EventArgs e)
        {
            int idNumeracionActual = this.idNumeracionDoc;


            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible && columna.Name != "BtnSeleccionar")
                {
                    ComboBusqueda.Items.Add(columna.Name);
                }
            }

            ComboBusqueda.SelectedIndex = 0;

            //Listar Numeracion de documentos
            List<NumeracionDocumento> numeracionDocumentos = new CN_NumeracionDocumento().Listar();
            foreach (NumeracionDocumento numeracion in numeracionDocumentos)
            {
                dgvData.Rows.Add("", numeracion.Id, numeracion.DescripcionCaja, numeracion.PuntoEmision, numeracion.CodigoEstablecimiento, numeracion.UltimoNumero, numeracion.NroTimbrado, numeracion.TipoDoc);
            }
            TxtBusqueda.Select();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvData.Columns[e.ColumnIndex].Name == "BtnSeleccionar")
            {
                int index = e.RowIndex;

                if (index >= 0)
                {
                    TxtIndex.Text = index.ToString();
                    TxtPuntoEmision.Text = dgvData.Rows[index].Cells["PuntoEmision"].Value.ToString();
                    TxtCodEstablecimiento.Text = dgvData.Rows[index].Cells["CodEstablecimiento"].Value.ToString();
                    TxTUltimoNro.Text = dgvData.Rows[index].Cells["UltimoNro"].Value.ToString();
                    ComboCajas.Text = dgvData.Rows[index].Cells["Caja"].Value.ToString();
                    ComboNroTimbrado.Text = dgvData.Rows[index].Cells["Timbrado"].Value.ToString();
                    tipoDocumento = (bool)dgvData.Rows[index].Cells["TipoDocumento"].Value;
                    if (tipoDocumento == true)
                    {
                        radioButtonNC.Checked = true;
                    }
                    else
                    {
                        radioButtonFactura.Checked = true;
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
        }
    }
}

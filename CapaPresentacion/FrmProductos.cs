using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmProductos : Form, IFormularioConIdUsuario
    {
        bool estadoProducto;

        public int IdUsuario { get; set; }

        public FrmProductos()
        {
            InitializeComponent();
            CargarCategorias();
            CargarUnidadesMedida();
        }

        private void CargarUnidadesMedida()
        {
            List<UnidadMedida> unidadesMedida = new CN_UnidadesMedida().ObtenerUnidadesMedida();
            ComboUnidadMedida.DataSource = unidadesMedida;

            foreach (UnidadMedida unidadMedida in unidadesMedida)
            {
                ComboUnidadMedida.DisplayMember = "Descripcion";
            }
        }

        private void CargarCategorias()
        {
            List<Categoria> categorias = new CN_Categorias().ObtenerCategorias();
            ComboCategoria.DataSource = categorias;

            foreach (Categoria categoria in categorias)
            {
                ComboCategoria.DisplayMember = "Nombre";
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            try
            {
                Producto objProducto = new Producto()
                {
                    Id = Convert.ToInt32(TxtIdProducto.Text),
                    Codigo = TxtCodigo.Text,
                    Descripcion = TxtDescripcion.Text,
                    Costo = Convert.ToDecimal(TxtCosto.Text),
                    Precio = Convert.ToDecimal(TxtPrecio.Text),
                    Existencia = Convert.ToDecimal(TxtExistencia.Text),
                    ExistenciaMinima = Convert.ToDecimal(TxtExistenciaMinima.Text),
                    Categoria = ComboCategoria.Text.ToString(),
                    UnidadMedida = ComboUnidadMedida.Text.ToString(),
                    Estante = Convert.ToInt32(TxtEstante.Text),
                    Fila = Convert.ToInt32(TxtFila.Text),
                    Columna = Convert.ToInt32(TxtColumna.Text),
                    Activo = (bool)(ChkActivo.Checked)
                };

                if (objProducto.Id == 0)
                {
                    int idProducto = new CN_Productos().Registrar(objProducto, out Mensaje);

                    if (idProducto != 0)
                    {
                        dgvData.Rows.Add(new object[] { "", idProducto, TxtCodigo.Text, TxtDescripcion.Text, TxtCosto.Text, TxtPrecio.Text,
                            TxtExistencia.Text, TxtExistenciaMinima.Text, ComboCategoria.Text, ComboUnidadMedida.Text, 
                            TxtEstante.Text, TxtFila.Text, TxtColumna.Text, ChkActivo.Checked });
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
                    bool resultado = new CN_Productos().Editar(objProducto, out Mensaje);

                    if (resultado)
                    {
                        DataGridViewRow row = dgvData.Rows[Convert.ToInt32(TxtIndex.Text)];
                        row.Cells["IdProducto"].Value = TxtIdProducto.Text;
                        row.Cells["Codigo"].Value = TxtCodigo.Text;
                        row.Cells["Descripcion"].Value = TxtDescripcion.Text;
                        row.Cells["Costo"].Value = TxtCosto.Text;
                        row.Cells["Precio"].Value = TxtPrecio.Text;
                        row.Cells["Existencia"].Value = TxtExistencia.Text;
                        row.Cells["ExistenciaMinima"].Value = TxtExistenciaMinima.Text;
                        row.Cells["Categoria"].Value = ComboCategoria.Text;
                        row.Cells["UnidadMedida"].Value = ComboUnidadMedida.Text;
                        row.Cells["Estante"].Value = TxtEstante.Text;
                        row.Cells["Fila"].Value = TxtFila.Text;
                        row.Cells["Columna"].Value = TxtColumna.Text;
                        row.Cells["Activo"].Value = ChkActivo.Checked;

                        limpiar();
                        TxtCodigo.ReadOnly = false;
                        TxtDescripcion.ReadOnly = false;
                        BtnUltimasCompras.Visible = true;
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
            TxtIdProducto.Text = "0";
            TxtCodigo.Clear();
            TxtDescripcion.Clear();
            TxtCosto.Text = "0";
            TxtPrecio.Text = "0";
            TxtExistencia.Text = "0";
            TxtExistenciaMinima.Clear();
            ComboCategoria.SelectedIndex = 0;
            ComboUnidadMedida.SelectedIndex = 0;
            TxtBusqueda.Select();
            TxtCodigo.ReadOnly = false;
            TxtDescripcion.ReadOnly = false;
            BtnUltimasCompras.Visible = false;
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            int usuarioActual = this.IdUsuario;
            BtnUltimasCompras.Visible = false;

            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible && columna.Name != "BtnSeleccionar")
                {
                    ComboBusqueda.Items.Add(columna.Name);
                }
            }
            ComboBusqueda.SelectedIndex = 0;

            List<Producto> listaProducto = new CN_Productos().Listar(0,0);
            foreach (Producto producto in listaProducto)
            {
                dgvData.Rows.Add("", producto.Id, producto.Codigo, producto.Descripcion, producto.Costo,
                                 producto.Precio, producto.Existencia, producto.ExistenciaMinima, producto.Categoria,
                                 producto.UnidadMedida, producto.Estante, producto.Fila, producto.Columna, producto.Activo);
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
            TxtCodigo.ReadOnly = true;
            TxtDescripcion.ReadOnly = true;
            BtnUltimasCompras.Visible = true;
            bool obtenido = false;

            if (dgvData.Columns[e.ColumnIndex].Name == "BtnSeleccionar")
            {
                int index = e.RowIndex;

                if (index >= 0)
                {
                    TxtIndex.Text = index.ToString();
                    TxtIdProducto.Text = dgvData.Rows[index].Cells["IdProducto"].Value.ToString();
                    TxtCodigo.Text = dgvData.Rows[index].Cells["Codigo"].Value.ToString();
                    TxtDescripcion.Text = dgvData.Rows[index].Cells["Descripcion"].Value.ToString();
                    TxtCosto.Text = dgvData.Rows[index].Cells["Costo"].Value.ToString();
                    TxtPrecio.Text = dgvData.Rows[index].Cells["Precio"].Value.ToString();
                    TxtExistencia.Text = dgvData.Rows[index].Cells["Existencia"].Value.ToString();
                    TxtExistenciaMinima.Text = dgvData.Rows[index].Cells["ExistenciaMinima"].Value.ToString();
                    ComboCategoria.Text = dgvData.Rows[index].Cells["Categoria"].Value.ToString();
                    ComboUnidadMedida.Text = dgvData.Rows[index].Cells["UnidadMedida"].Value.ToString();
                    TxtEstante.Text = dgvData.Rows[index].Cells["Estante"].Value.ToString();
                    TxtFila.Text = dgvData.Rows[index].Cells["Fila"].Value.ToString();
                    TxtColumna.Text = dgvData.Rows[index].Cells["Columna"].Value.ToString();
                    estadoProducto = (bool)dgvData.Rows[index].Cells["Activo"].Value;
                    if (estadoProducto == true)
                    {
                        ChkActivo.Checked = true;
                    }
                    else
                    {
                        ChkActivo.Checked = false;
                    }
                    
                    byte[] byteImage = new CN_Productos().ObtenerLogo(Convert.ToInt32(TxtIdProducto.Text.ToString()),out obtenido);

                    if (obtenido)
                    {
                        Imagen.Image = ByteToImage(byteImage);
                    }
                    else
                    {
                        Imagen.Image = null;
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

        private void TxtCodigo_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtCodigo.Text))
            {
                //e.Cancel = true;
                errorProvider1.SetError(TxtCodigo, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtCodigo, "");
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

        public Image ByteToImage(byte[] ImageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(ImageBytes, 0, ImageBytes.Length);
            Image image = new Bitmap(ms);

            return image;
        }

        private void BtnSubir_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "Files|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                byte[] byteImage = File.ReadAllBytes(ofd.FileName);
                bool respuesta = new CN_Productos().ActualizarLogo(byteImage, Convert.ToInt32(TxtIdProducto.Text), out mensaje);

                if (respuesta)
                {
                    Imagen.Image = ByteToImage(byteImage);
                }
                else
                {
                    MessageBox.Show(mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnUltimasCompras_Click(object sender, EventArgs e)
        {
            using (var popup = new PopUpUltimasCompras(Convert.ToInt32(TxtIdProducto.Text)))
            {
                var result = popup.ShowDialog();
            }
        }
    }
}

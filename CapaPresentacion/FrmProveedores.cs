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
    public partial class FrmProveedores : Form, IFormularioConIdUsuario
    {
        bool estadoProveedor;

        public int IdUsuario { get; set; }

        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            if (!new CN_Proveedores().ValidarCorreo(TxtCorreo.Text))
            {
                MessageBox.Show("Dirección de correo electrónico no válida, el correo debe tener el formato: nombre@dominio.com", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCorreo.Focus();
                TxtCorreo.SelectAll();
            }
            else
            {
                Proveedor objProveedor = new Proveedor()
                {
                    Id = Convert.ToInt32(TxtIdProveedor.Text),
                    RazonSocial = TxtRazonSocial.Text,
                    Documento = TxtRUC.Text,
                    Contacto = TxtContacto.Text,
                    Contacto2 = TxtContacto2.Text,
                    Direccion = TxtDireccion.Text,
                    TelefonoUno = TxtTelefono1.Text,
                    TelefonoDos = TxtTelefono2.Text,
                    Correo = TxtCorreo.Text,
                    Activo = (bool)(ChkActivo.Checked)
                };

                if (objProveedor.Id == 0)
                {
                    int idProveedor = new CN_Proveedores().Registrar(objProveedor, out Mensaje);

                    if (idProveedor != 0)
                    {
                        dgvData.Rows.Add(new object[] { "", idProveedor, TxtRazonSocial.Text, TxtRUC.Text, TxtContacto.Text, TxtContacto2.Text, TxtDireccion.Text, TxtTelefono1.Text, TxtTelefono2.Text, TxtCorreo.Text, ChkActivo.Checked });
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
                    bool resultado = new CN_Proveedores().Editar(objProveedor, out Mensaje);

                    if (resultado)
                    {
                        DataGridViewRow row = dgvData.Rows[Convert.ToInt32(TxtIndex.Text)];
                        row.Cells["IdProveedor"].Value = TxtIdProveedor.Text;
                        row.Cells["RazonSocial"].Value = TxtRazonSocial.Text;
                        row.Cells["Documento"].Value = TxtRUC.Text;
                        row.Cells["Contacto"].Value = TxtContacto.Text;
                        row.Cells["Contacto2"].Value = TxtContacto2.Text;
                        row.Cells["Direccion"].Value = TxtDireccion.Text;
                        row.Cells["Telefono1"].Value = TxtTelefono1.Text;
                        row.Cells["Telefono2"].Value = TxtTelefono2.Text;
                        row.Cells["Correo"].Value = TxtCorreo.Text;
                        row.Cells["Activo"].Value = ChkActivo.Checked;

                        limpiar();
                        TxtRazonSocial.ReadOnly = false;
                        TxtRUC.ReadOnly = false;
                    }
                    else
                    {
                        MessageBox.Show(Mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
        }

        private void limpiar()
        {
            TxtIndex.Clear();
            TxtIdProveedor.Text = "0";
            TxtRazonSocial.Clear();
            TxtRUC.Clear();
            TxtContacto.Clear();
            TxtContacto2.Clear();
            TxtDireccion.Clear();
            TxtTelefono1.Clear();
            TxtTelefono2.Clear();
            TxtCorreo.Clear();
            TxtBusqueda.Select();
            TxtRazonSocial.ReadOnly = false;
            TxtRUC.ReadOnly = false;
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
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

            //Listar proveedores
            List<Proveedor> listaProveedor = new CN_Proveedores().Listar();
            foreach (Proveedor proveedor in listaProveedor)
            {
                dgvData.Rows.Add("", proveedor.Id, proveedor.RazonSocial, proveedor.Documento, proveedor.Contacto, proveedor.Contacto2,
                                 proveedor.Direccion, proveedor.TelefonoUno, proveedor.TelefonoDos,
                                 proveedor.Correo, proveedor.Activo);
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
            TxtRazonSocial.ReadOnly = true;
            TxtRUC.ReadOnly = true;

            if (dgvData.Columns[e.ColumnIndex].Name == "BtnSeleccionar")
            {
                int index = e.RowIndex;

                if (index >= 0)
                {
                    TxtIndex.Text = index.ToString();
                    TxtIdProveedor.Text = dgvData.Rows[index].Cells["idProveedor"].Value.ToString();
                    TxtRazonSocial.Text = dgvData.Rows[index].Cells["RazonSocial"].Value.ToString();
                    TxtRUC.Text = dgvData.Rows[index].Cells["Documento"].Value.ToString();
                    TxtContacto.Text = dgvData.Rows[index].Cells["Contacto"].Value.ToString();
                    TxtContacto2.Text = dgvData.Rows[index].Cells["Contacto2"].Value.ToString();
                    TxtDireccion.Text = dgvData.Rows[index].Cells["Direccion"].Value.ToString();
                    TxtTelefono1.Text = dgvData.Rows[index].Cells["Telefono1"].Value.ToString();
                    TxtTelefono2.Text = dgvData.Rows[index].Cells["Telefono2"].Value.ToString();
                    TxtCorreo.Text = dgvData.Rows[index].Cells["Correo"].Value.ToString();
                    estadoProveedor = (bool)dgvData.Rows[index].Cells["Activo"].Value;
                    if (estadoProveedor == true)
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

        private void TxtRazonSocial_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtRazonSocial.Text))
            {
                //e.Cancel = true;
                //TxtNombres.Focus();
                errorProvider1.SetError(TxtRazonSocial, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtRazonSocial, "");
            }
        }

        private void TxtDocumento_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtRUC.Text))
            {
                //e.Cancel = true;
                TxtRUC.Focus();
                errorProvider1.SetError(TxtRUC, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtRUC, "");
            }
        }

        private void TxtDireccion_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtDireccion.Text))
            {
                //e.Cancel = true;
                TxtDireccion.Focus();
                errorProvider1.SetError(TxtDireccion, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtDireccion, "");
            }
        }

        private void TxtTelefono1_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtTelefono1.Text))
            {
                //e.Cancel = true;
                TxtTelefono1.Focus();
                errorProvider1.SetError(TxtTelefono1, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtTelefono1, "");
            }
        }

        private void TxtCorreo_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtCorreo.Text))
            {
                //e.Cancel = true;
                TxtCorreo.Focus();
                errorProvider1.SetError(TxtCorreo, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtCorreo, "");
            }
        }
    }
}

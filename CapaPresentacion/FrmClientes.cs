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
using System.Windows.Ink;

namespace CapaPresentacion
{
    public partial class FrmClientes : Form
    {
        bool estadoCliente, tipoPersona;
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            if (!new CN_Clientes().ValidarCorreo(TxtCorreo.Text))
            {
                MessageBox.Show("Dirección de correo electrónico no válida, el correo debe tener el formato: nombre@dominio.com");
                TxtCorreo.Focus();
                TxtCorreo.SelectAll();
            }
            else
            {
                bool tipo;
                if(radioButtonFisica.Checked)
                {
                    tipo = false;
                }
                else
                {
                    tipo = true;
                }
                Cliente objCliente = new Cliente()
                {
                    Id = Convert.ToInt32(TxtIdCliente.Text),
                    Nombre = TxtNombre.Text,
                    Documento = TxtDocumento.Text,
                    Direccion = TxtDireccion.Text,
                    TelefonoUno = TxtTelefono1.Text,
                    TelefonoDos = TxtTelefono2.Text,
                    Correo = TxtCorreo.Text,
                    TipoPersona = (bool)(tipo),                                   
                    Activo = (bool)(ChkActivo.Checked)
                };

                if (objCliente.Id == 0)
                {
                    int idCliente = new CN_Clientes().Registrar(objCliente, out Mensaje);

                    if (idCliente != 0)
                    {
                        dgvData.Rows.Add(new object[] { "", idCliente, TxtNombre.Text, TxtDocumento.Text, TxtDireccion.Text, TxtTelefono1.Text, TxtTelefono2.Text, TxtCorreo.Text, tipo, ChkActivo.Checked });
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show(Mensaje);
                    }
                }
                else
                {
                    bool resultado = new CN_Clientes().Editar(objCliente, out Mensaje);

                    if (resultado)
                    {
                        DataGridViewRow row = dgvData.Rows[Convert.ToInt32(TxtIndex.Text)];
                        row.Cells["IdCliente"].Value = TxtIdCliente.Text;
                        row.Cells["Nombre"].Value = TxtNombre.Text;
                        row.Cells["Documento"].Value = TxtDocumento.Text;
                        row.Cells["Direccion"].Value = TxtDireccion.Text;
                        row.Cells["Telefono1"].Value = TxtTelefono1.Text;
                        row.Cells["Telefono2"].Value = TxtTelefono2.Text;
                        row.Cells["Correo"].Value = TxtCorreo.Text;
                        row.Cells["TipoPers"].Value = tipo;
                        row.Cells["Activo"].Value = ChkActivo.Checked;

                        limpiar();
                        TxtNombre.ReadOnly = false;
                        TxtDocumento.ReadOnly = false;
                    }
                    else
                    {
                        MessageBox.Show(Mensaje);
                    }
                }
            }
        }

        private void limpiar()
        {
            TxtIndex.Clear();
            TxtIdCliente.Text = "0";
            TxtNombre.Clear();
            TxtDocumento.Clear();
            TxtDireccion.Clear();
            TxtTelefono1.Clear();
            TxtTelefono2.Clear();
            TxtCorreo.Clear();
            radioButtonFisica.Checked = true;
            radioButtonJuridica.Checked = false;
            TxtBusqueda.Select();
            TxtNombre.ReadOnly = false;
            TxtDocumento.ReadOnly = false;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible && columna.Name != "BtnSeleccionar")
                {
                    ComboBusqueda.Items.Add(columna.Name);
                }
            }

            ComboBusqueda.SelectedIndex = 0;

            //Listar proveedores
            List<Cliente> listaCliente = new CN_Clientes().Listar();
            foreach (Cliente cliente in listaCliente)
            {
                dgvData.Rows.Add("", cliente.Id, cliente.Nombre, cliente.Documento,
                                 cliente.Direccion, cliente.TelefonoUno, cliente.TelefonoDos,
                                 cliente.Correo, cliente.TipoPersona, cliente.Activo);
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
                //TxtNombres.Focus();
                errorProvider1.SetError(TxtNombre, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtNombre, "");
            }
        }

        private void TxtDocumento_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtDocumento.Text))
            {
                //e.Cancel = true;
                TxtDocumento.Focus();
                errorProvider1.SetError(TxtDocumento, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtDocumento, "");
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

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtNombre.ReadOnly = true;
            TxtDocumento.ReadOnly = true;

            if (dgvData.Columns[e.ColumnIndex].Name == "BtnSeleccionar")
            {
                int index = e.RowIndex;

                if (index >= 0)
                {
                    TxtIndex.Text = index.ToString();
                    TxtIdCliente.Text = dgvData.Rows[index].Cells["IdCliente"].Value.ToString();
                    TxtNombre.Text = dgvData.Rows[index].Cells["Nombre"].Value.ToString();
                    TxtDocumento.Text = dgvData.Rows[index].Cells["Documento"].Value.ToString();
                    TxtDireccion.Text = dgvData.Rows[index].Cells["Direccion"].Value.ToString();
                    TxtTelefono1.Text = dgvData.Rows[index].Cells["Telefono1"].Value.ToString();
                    TxtTelefono2.Text = dgvData.Rows[index].Cells["Telefono2"].Value.ToString();
                    TxtCorreo.Text = dgvData.Rows[index].Cells["Correo"].Value.ToString();
                    tipoPersona = (bool)dgvData.Rows[index].Cells["TipoPers"].Value;
                    if(tipoPersona == true)
                    {
                        radioButtonJuridica.Checked = true;
                    }
                    else
                    {
                        radioButtonFisica.Checked = true;
                    }
                    estadoCliente = (bool)dgvData.Rows[index].Cells["Activo"].Value;
                    if (estadoCliente == true)
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

using CapaEntidad;
using CapaEntidad.Models;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmAgregarUsuario : Form
    {
        public FrmAgregarUsuario()
        {
            InitializeComponent();
            CargarRoles();
            CargarComboSucursal();
            ComboSucursal.Enabled = false;
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
            bool estadoEmpleado;
            TxtLogin.ReadOnly = true;

            if (dgvData.Columns[e.ColumnIndex].Name == "BtnSeleccionar")
            {
                int index = e.RowIndex;

                if (index >= 0)
                {
                    TxtIndex.Text = index.ToString();
                    TxtIdEmpleado.Text = dgvData.Rows[index].Cells["IdEmpleado"].Value.ToString();
                    TxtLogin.Text = dgvData.Rows[index].Cells["Correo"].Value.ToString();
                    estadoEmpleado = (bool)dgvData.Rows[index].Cells["Activo"].Value;
                    if (estadoEmpleado == true)
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

        private void FrmAgregarUsuario_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible && columna.Name != "BtnSeleccionar")
                {
                    ComboBusqueda.Items.Add(columna.Name);
                }
            }

            ComboBusqueda.SelectedIndex = 0;

            //Listar empleados
            List<Empleado> listaEmpleado = new CN_Empleados().Listar_2();
            foreach (Empleado empleado in listaEmpleado)
            {
                if (empleado.Activo)
                {
                    dgvData.Rows.Add("", empleado.Id, empleado.Nombres, empleado.Apellidos, empleado.Documento,
                    empleado.Correo, empleado.Activo);
                }
            }

            //TxtNombres.Select();
            TxtBusqueda.Select();
        }

        private void CargarRoles()
        {
            List<Rol> roles = new CN_Roles().ObtenerRoles();
            ComboRol.DataSource = roles;

            foreach (Rol rol in roles)
            {
                ComboRol.DisplayMember = "Nombre";
            }
        }

        private void CargarComboSucursal()
        {
            List<Sucursales> sucursales = new CN_Sucursal().ObtenerSucursal();

            ComboSucursal.DataSource = sucursales;

            foreach(Sucursales d in sucursales)
            {
                ComboSucursal.DisplayMember = "DescripcionSucursal";
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

        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                //e.Cancel = true;
                TxtPassword.Focus();
                errorProvider1.SetError(TxtPassword, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtPassword, "");
            }
        }

        private int ValidarPassword()
        {
            int resultado;
            if (TxtPassword.Text != TxtRePassword.Text)
            {
                resultado = 1;
                return resultado;
            }
            else
            {
                resultado = 0;
                return resultado;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            
            if(TxtLogin.Text.Length == 0)
            {
                MessageBox.Show("Debe seleccionar un empleado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(TxtPassword.Text.Length == 0)
            {
                MessageBox.Show("La contaseña no puede ser vacia.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(ValidarPassword() == 1)
            {
                MessageBox.Show("Contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                UsuarioRequest nuevoUsuario = new UsuarioRequest()
                {
                    Login = TxtLogin.Text,
                    Password = TxtPassword.Text,
                    EmpleadoId = Convert.ToInt32(TxtIdEmpleado.Text),
                    UsuarioRol = ComboRol.Text.ToString(),
                    UsuarioSucursal = ComboSucursal.Text.ToString(),
                    Activo = (bool)ChkActivo.Checked
                };

                int resultado = new CN_Usuario().Registrar(nuevoUsuario, out Mensaje);

                if (resultado != 0)
                {
                    MessageBox.Show("Usuario agregado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    return;
                }
                else
                {
                    MessageBox.Show("Usuario ya existe. Verifique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void TxtRePassword_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtRePassword.Text))
            {
                //e.Cancel = true;
                TxtRePassword.Focus();
                errorProvider1.SetError(TxtRePassword, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtRePassword, "");
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            TxtLogin.Clear();
            TxtPassword.Clear();
            TxtRePassword.Clear();

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtBusqueda.Clear();
        }
    }
}
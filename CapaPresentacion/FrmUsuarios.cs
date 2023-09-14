using CapaEntidad;
using CapaEntidad.Models;
using CapaNegocio;
using CapaPresentacion.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmUsuarios : Form, IFormularioConIdUsuario
    {
        public int IdUsuario { get; set; }

        public FrmUsuarios()
        {
            InitializeComponent();
            CargarRoles();
            CargarComboSucursal();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            int usuarioActual = this.IdUsuario;

            TxtDocumento.ReadOnly = true;
            TxtNombres.ReadOnly = true;
            TxtApellidos.ReadOnly = true;
            TxtLogin.ReadOnly = true;
            
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible && columna.Name != "BtnSeleccionar")
                {
                    ComboBusqueda.Items.Add(columna.Name);
                }
            }

            ComboBusqueda.SelectedIndex = 0;

            //Listar Usuarios
            List<UsuarioResponse> listaUsuario = new CN_Usuario().Listar();
            foreach (UsuarioResponse usuario in listaUsuario)
            {
                    dgvData.Rows.Add("", usuario.idUsuario ,usuario.Cedula, usuario.Login, usuario.Nombres, usuario.Apellidos,
                        usuario.NombreRol, usuario.NombreSucursal, usuario.Activo);
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            if(TxtNombres.Text.Trim().Length == 0 || TxtApellidos.Text.Length == 0 || TxtLogin.Text.Length == 0 || TxtDocumento.Text.Length == 0)
            {
                MessageBox.Show("Debe seleccionar un empleado.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(TxtPassword.Text.Length == 0)
            {
                MessageBox.Show("Contraseña no puede ser nula.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(ValidarPassword() == 1)
            {
                MessageBox.Show("Contraseñas no coinciden, verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UsuarioEditarRequest objUsuario = new UsuarioEditarRequest()
            {
                IdUsuario = Convert.ToInt32(TxtIdUsuario.Text),
                PassWord = TxtPassword.Text,
                UsuarioRol = ComboRol.Text,
                Activo = (bool)ChkActivo.Checked,
            };

            try
            {
                bool cN_Usuario = new CN_Usuario().Editar(objUsuario, out Mensaje);

                if (cN_Usuario)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(TxtIndex.Text)];
                    row.Cells["idUsuario"].Value = TxtIdUsuario.Text;
                    row.Cells["Documento"].Value = TxtDocumento.Text;
                    row.Cells["Login"].Value = TxtLogin.Text;
                    row.Cells["Nombres"].Value = TxtNombres.Text;
                    row.Cells["Apellidos"].Value = TxtApellidos.Text;
                    row.Cells["Rol"].Value = ComboRol.Text;
                    row.Cells["Activo"].Value = ChkActivo.Checked;

                    MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar();
                    TxtDocumento.ReadOnly = true;
                    TxtNombres.ReadOnly = true;
                    TxtApellidos.ReadOnly = true;
                    TxtLogin.ReadOnly = true;

                    
                }
                else
                {
                    MessageBox.Show(Mensaje);
                }
            }
            catch (Exception ex)
            {

            }
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
            bool estadoUsuario;
            TxtLogin.ReadOnly = true;
            TxtDocumento.ReadOnly = true;
            TxtNombres.ReadOnly = true;
            TxtApellidos.ReadOnly = true;

            if (dgvData.Columns[e.ColumnIndex].Name == "BtnSeleccionar")
            {
                int index = e.RowIndex;

                if (index >= 0)
                {
                    TxtIndex.Text = index.ToString();
                    TxtIdUsuario.Text = dgvData.Rows[index].Cells["IdUsuario"].Value.ToString();
                    TxtDocumento.Text = dgvData.Rows[index].Cells["Documento"].Value.ToString();
                    TxtNombres.Text = dgvData.Rows[index].Cells["Nombres"].Value.ToString();
                    TxtApellidos.Text = dgvData.Rows[index].Cells["Apellidos"].Value.ToString();
                    TxtLogin.Text = dgvData.Rows[index].Cells["Login"].Value.ToString();
                    ComboRol.Text = dgvData.Rows[index].Cells["Rol"].Value.ToString();
                    ComboSucursal.Text = dgvData.Rows[index].Cells["Sucursal"].Value.ToString();
                    estadoUsuario = (bool)dgvData.Rows[index].Cells["Activo"].Value;
                    if (estadoUsuario == true)
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

        private void CargarComboSucursal()
        {
            List<Sucursales> sucursales = new CN_Sucursal().ObtenerSucursal();

            ComboSucursal.DataSource = sucursales;

            foreach (Sucursales d in sucursales)
            {
                ComboSucursal.DisplayMember = "DescripcionSucursal";
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

            Limpiar();
        }

        private void Limpiar()
        {
            TxtApellidos.Clear();
            TxtDocumento.Clear();
            TxtNombres.Clear();
            TxtLogin.Clear();
            TxtPassword.Clear();
            TxtRePassword.Clear();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtBusqueda.Clear();
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
    }
}

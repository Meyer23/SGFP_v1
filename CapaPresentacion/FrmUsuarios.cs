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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            CargarRoles();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            
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
                        usuario.NombreRol, usuario.NombreSucursal, usuario.DescripcionCaja, usuario.Activo);
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

            //if (!new CN_Empleado().ValidarCorreo(TxtCorreo.Text))
            //{
            //    MessageBox.Show("Dirección de correo electrónico no válida, el correo debe tener el formato: nombre@dominio.com");
            //    TxtCorreo.Focus();
            //    TxtCorreo.SelectAll();
            //}
            //else
            //{
            //    Empleado objEmpleado = new Empleado()
            //    {
            //        Id = Convert.ToInt32(TxtIdEmpleado.Text),
            //        Nombres = TxtNombres.Text,
            //        Apellidos = TxtApellidos.Text,
            //        Documento = TxtDocumento.Text,
            //        Direccion = TxtDireccion.Text,
            //        FechaNacimiento = (DateTime)(DtFechaNac.Value),
            //        TelefonoUno = TxtTelefono1.Text,
            //        TelefonoDos = TxtTelefono2.Text,
            //        Correo = TxtCorreo.Text,
            //        Activo = (bool)(ChkActivo.Checked)
            //    };

            //    if (objEmpleado.Id == 0)
            //    {
            //        int idEmpleado = new CN_Empleado().Registrar(objEmpleado, out Mensaje);

            //        if (idEmpleado != 0)
            //        {
            //            dgvData.Rows.Add(new object[] { "", idEmpleado, TxtNombres.Text, TxtApellidos.Text, TxtDocumento.Text, TxtDireccion.Text, ChkActivo.Checked });
            //            limpiar();
            //        }
            //        else
            //        {
            //            MessageBox.Show(Mensaje);
            //        }
            //    }
            //    else
            //    {
            //        bool resultado = new CN_Empleado().Editar(objEmpleado, out Mensaje);

            //        if (resultado)
            //        {
            //            DataGridViewRow row = dgvData.Rows[Convert.ToInt32(TxtIndex.Text)];
            //            row.Cells["IdEmpleado"].Value = TxtIdEmpleado.Text;
            //            row.Cells["Nombres"].Value = TxtNombres.Text;
            //            row.Cells["Apellidos"].Value = TxtApellidos.Text;
            //            row.Cells["Documento"].Value = TxtDocumento.Text;
            //            row.Cells["Direccion"].Value = TxtDireccion.Text;
            //            row.Cells["FechaNac"].Value = DtFechaNac.Value;
            //            row.Cells["Telefono1"].Value = TxtTelefono1.Text;
            //            row.Cells["Telefono2"].Value = TxtTelefono2.Text;
            //            row.Cells["Correo"].Value = TxtCorreo.Text;
            //            row.Cells["Activo"].Value = ChkActivo.Checked;

            //            limpiar();
            //            TxtNombres.ReadOnly = false;
            //            TxtApellidos.ReadOnly = false;
            //            TxtDocumento.ReadOnly = false;
            //            DtFechaNac.Enabled = true;
            //        }
            //        else
            //        {
            //            MessageBox.Show(Mensaje);
            //        }
            //    }
            //}

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
                    ComboCaja.Text = dgvData.Rows[index].Cells["Caja"].Value.ToString();
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
    }
}

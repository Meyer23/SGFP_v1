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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            CargarRoles();
            CargarComboCajas();
            CargarComboSucursal();
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

            Usuario objUsuario = new Usuario();

            try
            {
                
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

        private void CargarComboSucursal()
        {
            List<Sucursales> sucursales = new CN_Sucursal().ObtenerSucursal();

            ComboSucursal.DataSource = sucursales;

            foreach (Sucursales d in sucursales)
            {
                ComboSucursal.DisplayMember = "DescripcionSucursal";
            }
        }

        private void CargarComboCajas()
        {
            List<Cajas> cajas = new CN_Cajas().ObtenerCajas();

            ComboCaja.DataSource = cajas;

            foreach (Cajas caj in cajas)
            {
                ComboCaja.DisplayMember = "DescripcionCaja";
            }
        }
    }
}

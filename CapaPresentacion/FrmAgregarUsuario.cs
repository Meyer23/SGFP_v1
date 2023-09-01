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
    public partial class FrmAgregarUsuario : Form
    {
        public FrmAgregarUsuario()
        {
            InitializeComponent();
            CargarRoles();
            CargarComboSucursal();
            CargarComboCajas();
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
            List<Empleado> listaEmpleado = new CN_Empleado().Listar();
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

        private void CargarComboCajas()
        {
            List<Cajas> cajas = new CN_Cajas().ObtenerCajas();

            ComboCaja.DataSource = cajas;

            foreach(Cajas caj in cajas)
            {
                ComboCaja.DisplayMember = "DescripcionCaja";
            }
        }
    }
}
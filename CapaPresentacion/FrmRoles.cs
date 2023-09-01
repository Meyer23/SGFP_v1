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
using System.Windows.Controls;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmRoles : Form
    {
        bool EstadoRol;
        public FrmRoles()
        {
            InitializeComponent();
        }
        private void FrmRoles_Load(object sender, EventArgs e)
        {
            //Listar Roles
            List<Rol> listaRoles = new CN_Roles().Listar();
            foreach (Rol roles in listaRoles)
            {
                dgvRolesData.Rows.Add("", roles.IdRol, roles.Nombre, roles.Activo);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            if (string.IsNullOrEmpty(TxtNombre.Text))
            {
                MessageBox.Show("Nombre no debe ser vacio");
                return;
            }

            Rol objRol = new Rol()
            {
                IdRol = Convert.ToInt32(TxtIdRol.Text),
                Nombre = TxtNombre.Text,
                Activo = (bool)(ChkActivo.Checked)
            };

            try
            {
                if(objRol.IdRol == 0)
                {
                    int idRol = new CN_Roles().Registrar(objRol, out Mensaje);

                    if(idRol != 0)
                    {
                        dgvRolesData.Rows.Add(new object[] { idRol, TxtNombre.Text, ChkActivo.Checked });
                        limpiar();
                    }
                }
                else
                {
                        bool resultado = new CN_Roles().Editar(objRol, out Mensaje);
                        if (resultado)
                        {
                            DataGridViewRow row = dgvRolesData.Rows[Convert.ToInt32(TxtIndex.Text)];
                            row.Cells["Activo"].Value = ChkActivo.Checked;

                            limpiar();
                            TxtNombre.ReadOnly = false;
                        }
                        else
                        {
                            MessageBox.Show(Mensaje);
                        }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void limpiar()
        {
            TxtNombre.Clear();
            TxtIndex.Select();
        }

        private void TxtNombre_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();

            if(string.IsNullOrEmpty(TxtNombre.Text))
            {
                //e.Cancel = true;
                //y cieTxtNombre.Focus();
                errorProvider.SetError(TxtNombre, "Este campo es obligatorio.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(TxtNombre, "");
            }
        }

        private void dgvRolesData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvRolesData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtNombre.ReadOnly = true;
            bool estadoRol;
            int index = e.RowIndex;

            if (index >= 0)
            {
                TxtIndex.Text = index.ToString();
                TxtIdRol.Text = dgvRolesData.Rows[index].Cells["idRol"].Value.ToString();
                TxtNombre.Text = dgvRolesData.Rows[index].Cells["Descripcion"].Value.ToString();
                estadoRol = (bool)dgvRolesData.Rows[index].Cells["Activo"].Value;
                if (estadoRol == true)
                {
                    ChkActivo.Checked = true;
                }
                else
                {
                    ChkActivo.Checked = false;
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
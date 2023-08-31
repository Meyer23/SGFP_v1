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
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarComboRol();
        }

        private void CargarComboRol()
        {
            List<Rol> rol = new List<Rol>();

            rol = new CN_Usuario().ObtenerRol();

            foreach(Rol unRol in rol)
            {
                ComboRol.Items.Add(unRol.Nombre);
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
    }
}

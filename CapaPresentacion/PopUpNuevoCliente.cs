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
    public partial class PopUpNuevoCliente : Form
    {
        public PopUpNuevoCliente()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            if (!new CN_Clientes().ValidarCorreo(TxtCorreo.Text))
            {
                MessageBox.Show("Dirección de correo electrónico no válida, el correo debe tener el formato: nombre@dominio.com", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCorreo.Focus();
                TxtCorreo.SelectAll();
            }
            else
            {
                bool tipo;
                if (radioButtonFisica.Checked)
                {
                    tipo = false;
                }
                else
                {
                    tipo = true;
                }
                Cliente objCliente = new Cliente()
                {
                    Nombre = TxtNombre.Text,
                    Apellido = TxtApellidos.Text,
                    Documento = TxtDocumento.Text,
                    Direccion = TxtDireccion.Text,
                    TelefonoUno = TxtTelefono1.Text,
                    TelefonoDos = TxtTelefono2.Text,
                    Correo = TxtCorreo.Text,
                    TipoPersona = (bool)(tipo),
                    Activo = (bool)(ChkActivo.Checked)
                };
                    int idCliente = new CN_Clientes().Registrar(objCliente, out Mensaje);

                    if (idCliente != 0)
                    {
                        MessageBox.Show("Cliente agregado correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error inesperado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
            }
        }
    }
}

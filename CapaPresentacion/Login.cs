using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaEntidad.Models;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioLogin usuario = new CN_Usuario().ObtenerUsuario().Where(x => x.Login == TxtUsuario.Text && x.PassWord == TxtPassword.Text && x.Activo == true).FirstOrDefault();

            if(usuario != null)
            {
                PantallaPrincipal formulario_principal = new PantallaPrincipal(usuario);
                formulario_principal.Show();
                this.Hide();

                formulario_principal.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            TxtUsuario.Clear();
            TxtPassword.Clear();
            this.Show();
        }
    }
}


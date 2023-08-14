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
            Usuario usuario = new CN_Usuario().Listar().Where(e => e.Activo == true);

            PantallaPrincipal formulario_principal = new PantallaPrincipal();
            formulario_principal.Show();
            this.Hide();

            formulario_principal.FormClosing += frm_closing;
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            TxtUsuario.Clear();
            TxtPassword.Clear();
            this.Show();
        }
    }
}
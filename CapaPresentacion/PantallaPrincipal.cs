using CapaEntidad.Models;
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
    public partial class PantallaPrincipal : Form
    {
        private static UsuarioLogin usuarioActual;
        public PantallaPrincipal(UsuarioLogin usuarioLogin)
        {
            usuarioActual = usuarioLogin;

            InitializeComponent();
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            LBLUsuario.Text = usuarioActual.Login;
        }
    }
}
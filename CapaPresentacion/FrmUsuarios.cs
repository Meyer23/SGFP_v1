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
    }
}

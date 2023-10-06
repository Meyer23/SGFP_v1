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
    public partial class FrmAperturaCierreCaja : Form
    {
        public FrmAperturaCierreCaja()
        {
            InitializeComponent();
            CargarComboSucursal();
            CargarComboUsuarios();
            CargarComboCajas();
        }

        private void FrmAperturaCierreCaja_Load(object sender, EventArgs e)
        {

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

        private void CargarComboUsuarios()
        {
            var usuarios = new CN_Usuario().Listar()
                                          .Where(e => e.NombreRol == "Cajero")
                                          .Select(u => new
                                          {
                                              DisplayText = $"{u.Login}",
                                          })
                                          .ToList();

            ComboCajero.DataSource = usuarios;
            ComboCajero.DisplayMember = "DisplayText";
        }

        private void CargarComboCajas()
        {
            List<Cajas> cajas = new CN_Cajas().ObtenerCajas();
            ComboCajas.DataSource = cajas;

            foreach (Cajas resultCajas in cajas)
            {
                ComboCajas.DisplayMember = "Id";
            }
        }
    }
}

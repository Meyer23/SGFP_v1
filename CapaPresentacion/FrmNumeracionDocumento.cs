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
    public partial class FrmNumeracionDocumento : Form
    {
        public FrmNumeracionDocumento()
        {
            InitializeComponent();
            CargarComboCajas();
        }

        private void CargarComboCajas()
        {
            List<Cajas> cajas = new CN_Cajas().ObtenerCajas();
            ComboCajas.DataSource = cajas;

            foreach (Cajas resultCajas in cajas)
            {
                ComboCajas.DisplayMember = "DescripcionCaja";
            }
        }
    }
}

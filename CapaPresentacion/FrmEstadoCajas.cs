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
    public partial class FrmEstadoCajas : Form
    {
        public FrmEstadoCajas()
        {
            InitializeComponent();
        }

        private void LblListadoEstadoCajas_Click(object sender, EventArgs e)
        {

        }

        private void FrmEstadoCajas_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible && columna.Name != "BtnSeleccionar")
                {
                    ComboBusqueda.Items.Add(columna.Name);
                }
            }

            ComboBusqueda.SelectedIndex = 0;

            List<ListadoEstadoCajas> listadeAperturas = new CN_AperturaCierre().ObtenerListadoAperturas();
            foreach (ListadoEstadoCajas a in listadeAperturas)
            {
                dgvData.Rows.Add("", a.Id, a.MontoInicial, a.MontoCierre, a.MontoActual,
                                 a.FechaApertura, a.FechaCierre, a.NroCaja, a.Estado);
            }

            //TxtNombres.Select();
            TxtBusqueda.Select();
        }
    }
}

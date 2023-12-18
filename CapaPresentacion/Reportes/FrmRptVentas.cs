using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class FrmRptVentas : Form
    {
        public FrmRptVentas()
        {
            InitializeComponent();
        }

        private void FrmRptVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Reportes.Empresa' Puede moverla o quitarla según sea necesario.
            this.empresaTableAdapter.Fill(this.dS_Reportes.Empresa);
            this.ventasTableAdapter.Fill(this.dS_Reportes.Ventas, Convert.ToInt32(TxtParamId.Text));
            this.ventasDetalleTableAdapter.Fill(this.dS_Reportes.VentasDetalle, Convert.ToInt32(TxtParamId.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}

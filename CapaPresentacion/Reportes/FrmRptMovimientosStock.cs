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
    public partial class FrmRptMovimientosStock : Form
    {
        public FrmRptMovimientosStock()
        {
            InitializeComponent();
        }

        private void FrmRptMovimientosStock_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Reportes.Empresa' Puede moverla o quitarla según sea necesario.
            this.empresaTableAdapter.Fill(this.dS_Reportes.Empresa);
            this.movimientosStockTableAdapter.Fill(this.dS_Reportes.MovimientosStock, Convert.ToInt32(TxtParamId.Text));
            this.movimientosStockDetalleTableAdapter.Fill(this.dS_Reportes.MovimientosStockDetalle, Convert.ToInt32(TxtParamId.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}

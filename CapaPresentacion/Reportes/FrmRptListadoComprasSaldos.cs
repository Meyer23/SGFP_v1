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
    public partial class FrmRptListadoComprasSaldos : Form
    {
        public FrmRptListadoComprasSaldos()
        {
            InitializeComponent();
        }

        private void FrmRptListadoComprasSaldos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Reportes.Empresa' Puede moverla o quitarla según sea necesario.
            this.empresaTableAdapter.Fill(this.dS_Reportes.Empresa);
            this.comprasSaldosTableAdapter.Fill(this.dS_Reportes.ComprasSaldos);
            this.reportViewer1.RefreshReport();
        }
    }
}

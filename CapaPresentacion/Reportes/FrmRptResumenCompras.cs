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
    public partial class FrmRptResumenCompras : Form
    {
        public FrmRptResumenCompras()
        {
            InitializeComponent();
        }

        private void FrmRptResumenCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Reportes.Empresa' Puede moverla o quitarla según sea necesario.
            dtpFechaD.Value = DateTime.Now;
            dtpFechaH.Value = DateTime.Now;
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            this.empresaTableAdapter.Fill(this.dS_Reportes.Empresa);
            this.resumenComprasTableAdapter.Fill(this.dS_Reportes.ResumenCompras, dtpFechaD.Value.ToString(), dtpFechaH.Value.ToString());
            this.reportViewer1.RefreshReport();
        }
    }
}

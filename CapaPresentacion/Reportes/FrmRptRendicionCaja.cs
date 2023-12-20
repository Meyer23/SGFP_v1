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
    public partial class FrmRptRendicionCaja : Form
    {
        public FrmRptRendicionCaja()
        {
            InitializeComponent();
        }

        private void FrmRptRendicionCaja_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Reportes.Empresa' Puede moverla o quitarla según sea necesario.
            this.empresaTableAdapter.Fill(this.dS_Reportes.Empresa);
            this.rendicionCajaTableAdapter.Fill(this.dS_Reportes.RendicionCaja, TxtParamLogin.Text, dateTimePicker1.Value.ToString(), TxtParamCaja.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}

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
    public partial class FrmRptProveedores : Form
    {
        public FrmRptProveedores()
        {
            InitializeComponent();
        }

        private void FrmRptProveedores_Load(object sender, EventArgs e)
        {
            comboEstado.SelectedIndex = 0;
            // TODO: esta línea de código carga datos en la tabla 'dS_Reportes.Empresa' Puede moverla o quitarla según sea necesario.
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            this.empresaTableAdapter.Fill(this.dS_Reportes.Empresa);
            if (comboEstado.Text.ToString() == "Activo")
            {
                this.proveedoresTableAdapter.Fill(this.dS_Reportes.Proveedores, true);
            }
            else
            {
                this.proveedoresTableAdapter.Fill(this.dS_Reportes.Proveedores, false);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}

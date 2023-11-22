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
    public partial class FrmRptClientes : Form
    {
        public FrmRptClientes()
        {
            InitializeComponent();
        }

        private void FrmRptClientes_Load(object sender, EventArgs e)
        {
            comboEstado.SelectedIndex = 0;
            // TODO: esta línea de código carga datos en la tabla 'dS_Reportes.Empresa' Puede moverla o quitarla según sea necesario.         
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            this.empresaTableAdapter.Fill(this.dS_Reportes.Empresa);
            if (comboEstado.Text.ToString() == "Activo")
            {
                this.clientesTableAdapter.Fill(this.dS_Reportes.Clientes, true);
            }
            else
            {
                this.clientesTableAdapter.Fill(this.dS_Reportes.Clientes, false);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}

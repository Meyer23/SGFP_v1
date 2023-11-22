using CapaEntidad;
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

namespace CapaPresentacion.Reportes
{
    public partial class FrmRptProductos : Form
    {
        public FrmRptProductos()
        {
            InitializeComponent();
        }

        private void FrmRptProductos_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            comboCategorias.SelectedIndex = 18;
            // TODO: esta línea de código carga datos en la tabla 'dS_Reportes.Empresa' Puede moverla o quitarla según sea necesario.            
        }

        private void CargarCategorias()
        {
            List<Categoria> categorias = new CN_Categorias().ObtenerCategorias();
            comboCategorias.DataSource = categorias;

            foreach (Categoria categoria in categorias)
            {
                comboCategorias.DisplayMember = "Nombre";
            }
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            this.empresaTableAdapter.Fill(this.dS_Reportes.Empresa);
            // TODO: esta línea de código carga datos en la tabla 'dS_Reportes.Productos' Puede moverla o quitarla según sea necesario.
            
            if(comboCategorias.Text.ToString() == "*** TODAS ***"){
                this.productosTableAdapter.Fill(this.dS_Reportes.Productos, "", "ZZZZZZZZ");
            }
            else
            {
                this.productosTableAdapter.Fill(this.dS_Reportes.Productos, comboCategorias.Text.ToString(), comboCategorias.Text.ToString());
            }
            

            this.reportViewer1.RefreshReport();
        }
    }
}

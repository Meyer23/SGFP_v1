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
    public partial class FrmRptRankingCompras : Form
    {
        public FrmRptRankingCompras()
        {
            InitializeComponent();
        }

        private void FrmRptRankingCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Reportes.Empresa' Puede moverla o quitarla según sea necesario.
            dtpFechaD.Value = DateTime.Now;
            dtpFechaH.Value = DateTime.Now;
            CargarCategorias();
            comboCategorias.SelectedIndex = 18;
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.empresaTableAdapter.Fill(this.dS_Reportes.Empresa);
            if (comboCategorias.Text.ToString() == "*** TODAS ***")
            {
                this.sp_Ranking_ComprasTableAdapter.Fill(this.dS_Reportes.sp_Ranking_Compras, dtpFechaD.Value, dtpFechaH.Value, "", "ZZZZZZZZ");
            }
            else
            {
                this.sp_Ranking_ComprasTableAdapter.Fill(this.dS_Reportes.sp_Ranking_Compras, dtpFechaD.Value, dtpFechaH.Value, comboCategorias.Text.ToString(), comboCategorias.Text.ToString());
            }
            this.reportViewer1.RefreshReport();
        }
    }
}

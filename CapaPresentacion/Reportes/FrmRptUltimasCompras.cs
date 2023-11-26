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
    public partial class FrmRptUltimasCompras : Form
    {
        public FrmRptUltimasCompras()
        {
            InitializeComponent();
        }

        private void FrmRptUltimasCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Reportes.Empresa' Puede moverla o quitarla según sea necesario.
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            using (var popup = new PopUpProductos(0, 0))
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtIdProducto.Text = popup._Producto.Id.ToString();
                    TxtProducto.Text = popup._Producto.Codigo;                   
                }
                else
                {
                    TxtProducto.Select();
                }
            }
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            this.empresaTableAdapter.Fill(this.dS_Reportes.Empresa);
            this.ultimasComprasTableAdapter.Fill(this.dS_Reportes.UltimasCompras, Convert.ToInt32(TxtIdProducto.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}

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

namespace CapaPresentacion
{
    public partial class PopUpDetalleCobro : Form
    {
        public PopUpDetalleCobro()
        {
            InitializeComponent();
            MostrarValores();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void MostrarValores()
        {
            List<Valor> valores = new CN_Valores().Listar();

            var tiposValores = valores.Where(x => x.Activo == true)
                                      .Select(x => x.Descripcion)
                                      .ToList();
            ComboTipoValor.Items.Clear();
            ComboTipoValor.Items.AddRange(tiposValores.ToArray());

        }
    }
}

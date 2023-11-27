using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class PopUpDetalleCobro : Form
    {
        private decimal  _monto;
        public PopUpDetalleCobro(decimal montoTotal = 0)
        {
            _monto = montoTotal;
            InitializeComponent();
            MostrarValores();
            MontoDeLaVenta();
            MostrarBancos();
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

        public void MontoDeLaVenta()
        {
            TxtMontoTotal.Text = _monto.ToString();
            TxtMontoTotal.Enabled = false;
        }

        public void MostrarBancos()
        {
            List<Banco> bancos = new CN_Bancos().Listar();

            var listBancos = bancos.Where(x => x.Activo == true);

            foreach(var banco in listBancos)
            {
                ComboBanco.Items.Add(banco.Nombre);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}

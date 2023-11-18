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
    public partial class FrmAnularPedido : Form
    {
        private int _IdPedido;
        public FrmAnularPedido(int IdPedido = 0)
        {
            _IdPedido = IdPedido;
            InitializeComponent();
            CargarMotivos();
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            bool Respuesta = new CN_Compras().AnularCompra(_IdCompra, ComboMotivos.Text.ToString(), out Mensaje);

            if (Respuesta)
            {
                var result = MessageBox.Show("Compra anulada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    ComboMotivos.SelectedIndex = 0;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(Mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarMotivos()
        {
            List<MotivoAnulacion> motivos = new CN_Anulaciones().ObtenerMotivosAnulaciones();
            ComboMotivos.DataSource = motivos;

            foreach (MotivoAnulacion motivo in motivos)
            {
                ComboMotivos.DisplayMember = "Descripcion";
            }
        }
    }
}

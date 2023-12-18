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
    public partial class PopUpNuevaUMedida : Form
    {
        public PopUpNuevaUMedida()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            try
            {
                UnidadMedida objUnidadMedida = new UnidadMedida()
                {
                    Abreviacion = TxtAbreviacion.Text,
                    Descripcion = TxtDescripcion.Text,
                    Activo = (bool)(ChkActivo.Checked)
                };

                int IdUnidadMedida = new CN_UnidadesMedida().Registrar(objUnidadMedida, out Mensaje);

                if (IdUnidadMedida != 0)
                {
                    MessageBox.Show("Unidad de Medida agregada correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error inesperado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

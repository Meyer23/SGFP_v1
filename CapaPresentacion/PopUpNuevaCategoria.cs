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
    public partial class PopUpNuevaCategoria : Form
    {
        public PopUpNuevaCategoria()
        {
            InitializeComponent();
            CargarImpuestos();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarImpuestos()
        {
            List<Impuesto> roles = new CN_Impuestos().ObtenerImpuestos();
            ComboImpuesto.DataSource = roles;

            foreach (Impuesto impuesto in roles)
            {
                ComboImpuesto.DisplayMember = "Descripcion";
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            try
            {
                Categoria objCategoria = new Categoria()
                {
                    Nombre = TxtNombre.Text,
                    Descripcion = TxtDescripcion.Text,
                    PorcUtilidad = Convert.ToDecimal(TxtPorcUtilidad.Text),
                    Impuesto = ComboImpuesto.Text.ToString(),
                    Activo = (bool)(ChkActivo.Checked)
                };

                int idCategoria = new CN_Categorias().Registrar(objCategoria, out Mensaje);

                if (idCategoria != 0)
                {
                    MessageBox.Show("Categoría agregada correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

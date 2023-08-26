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
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            dgvData.Rows.Add(new object[] { "", TxtIdEmpleado.Text, TxtNombres.Text, TxtApellidos.Text, TxtDocumento.Text, TxtDireccion.Text, ChkActivo.Checked });

            limpiar();
        }

        private void limpiar()
        {
            TxtNombres.Clear();
            TxtApellidos.Clear();
            TxtDocumento.Clear();
            TxtDireccion.Clear();
            DtFechaNac.Value=DateTime.Today;
            TxtTelefono1.Clear();
            TxtTelefono2.Clear();
            TxtCorreo.Clear();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if(columna.Visible && columna.Name != "BtnSeleccionar")
                {
                    ComboBusqueda.Items.Add(columna.Name);
                }
            }
        }
    }
}

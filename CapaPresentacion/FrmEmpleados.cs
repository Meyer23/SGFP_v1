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
    public partial class FrmEmpleados : Form
    {
        bool estadoEmpleado;
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
            TxtIndex.Clear();
            TxtIdEmpleado.Clear();
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

            //Listar empleados
            List<Empleado> listaEmpleado = new CN_Empleado().Listar();
            foreach(Empleado empleado in listaEmpleado)
            {
                dgvData.Rows.Add("", empleado.Id, empleado.Nombres, empleado.Apellidos, empleado.Documento, 
                                 empleado.Direccion, empleado.FechaNacimiento, empleado.TelefonoUno, empleado.TelefonoDos, 
                                 empleado.Correo, empleado.Activo);
            }
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                return;
            }
            
            if(e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.check_azul.Width;
                var h = Properties.Resources.check_azul.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check_azul,new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "BtnSeleccionar")
            {
                int index = e.RowIndex;

                if(index >= 0)
                {
                    TxtIndex.Text = index.ToString();
                    TxtIdEmpleado.Text = dgvData.Rows[index].Cells["IdEmpleado"].Value.ToString();
                    TxtNombres.Text = dgvData.Rows[index].Cells["Nombres"].Value.ToString();
                    TxtApellidos.Text = dgvData.Rows[index].Cells["Apellidos"].Value.ToString();
                    TxtDocumento.Text = dgvData.Rows[index].Cells["Documento"].Value.ToString();
                    TxtDireccion.Text = dgvData.Rows[index].Cells["Direccion"].Value.ToString();
                    if (DateTime.TryParse(dgvData.Rows[index].Cells["FechaNac"].Value.ToString(), out DateTime selectedDate))
                    {
                        DtFechaNac.Value = selectedDate;
                    }
                    TxtTelefono1.Text = dgvData.Rows[index].Cells["Telefono1"].Value.ToString();
                    TxtTelefono2.Text = dgvData.Rows[index].Cells["Telefono2"].Value.ToString();
                    TxtCorreo.Text = dgvData.Rows[index].Cells["Correo"].Value.ToString();
                    estadoEmpleado = (bool)dgvData.Rows[index].Cells["Activo"].Value;
                    if (estadoEmpleado == true)
                    {
                        ChkActivo.Checked = true;
                    }
                    else
                    {
                        ChkActivo.Checked = false;
                    }
                }
            }
        }
    }
}

using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Interfaces;
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
    public partial class FrmEmpleados : Form, IFormularioConIdUsuario
    {
        bool estadoEmpleado;

        public int IdUsuario { get; set; }

        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            if (!new CN_Empleados().ValidarCorreo(TxtCorreo.Text))
            {
                MessageBox.Show("Dirección de correo electrónico no válida, el correo debe tener el formato: nombre@dominio.com");
                TxtCorreo.Focus();
                TxtCorreo.SelectAll();
            }
            else
            {
                Empleado objEmpleado = new Empleado()
                {
                    Id = Convert.ToInt32(TxtIdEmpleado.Text),
                    Nombres = TxtNombres.Text,
                    Apellidos = TxtApellidos.Text,
                    Documento = TxtDocumento.Text,
                    Direccion = TxtDireccion.Text,
                    FechaNacimiento = (DateTime)(DtFechaNac.Value),
                    TelefonoUno = TxtTelefono1.Text,
                    TelefonoDos = TxtTelefono2.Text,
                    Correo = TxtCorreo.Text,
                    Activo = (bool)(ChkActivo.Checked)
                };

                if (objEmpleado.Id == 0)
                {
                    int idEmpleado = new CN_Empleados().Registrar(objEmpleado, out Mensaje);

                    if (idEmpleado != 0)
                    {
                        dgvData.Rows.Add(new object[] { "", idEmpleado, TxtNombres.Text, TxtApellidos.Text, TxtDocumento.Text, TxtDireccion.Text, DtFechaNac.Value, TxtTelefono1.Text, TxtTelefono2.Text, TxtCorreo.Text, ChkActivo.Checked });
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show(Mensaje);
                        return;
                    }
                }
                else
                {
                    bool resultado = new CN_Empleados().Editar(objEmpleado, out Mensaje);

                    if (resultado)
                    {
                        DataGridViewRow row = dgvData.Rows[Convert.ToInt32(TxtIndex.Text)];
                        row.Cells["IdEmpleado"].Value = TxtIdEmpleado.Text;
                        row.Cells["Nombres"].Value = TxtNombres.Text;
                        row.Cells["Apellidos"].Value = TxtApellidos.Text;
                        row.Cells["Documento"].Value = TxtDocumento.Text;
                        row.Cells["Direccion"].Value = TxtDireccion.Text;
                        row.Cells["FechaNac"].Value = DtFechaNac.Value;
                        row.Cells["Telefono1"].Value = TxtTelefono1.Text;
                        row.Cells["Telefono2"].Value = TxtTelefono2.Text;
                        row.Cells["Correo"].Value = TxtCorreo.Text;
                        row.Cells["Activo"].Value = ChkActivo.Checked;

                        limpiar();
                        TxtNombres.ReadOnly = false;
                        TxtApellidos.ReadOnly = false;
                        TxtDocumento.ReadOnly = false;
                        DtFechaNac.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show(Mensaje);
                    }
                }
            }
               
        }

        private void limpiar()
        {
            TxtIndex.Clear();
            TxtIdEmpleado.Text = "0";
            TxtNombres.Clear();
            TxtApellidos.Clear();
            TxtDocumento.Clear();
            TxtDireccion.Clear();
            DtFechaNac.Value=DateTime.Today;
            TxtTelefono1.Clear();
            TxtTelefono2.Clear();
            TxtCorreo.Clear();
            TxtBusqueda.Select();
            TxtNombres.ReadOnly = false;
            TxtApellidos.ReadOnly=false;   
            TxtDocumento.ReadOnly = false;
            DtFechaNac.Enabled = true;
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            int usuarioActual = this.IdUsuario;

            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if(columna.Visible && columna.Name != "BtnSeleccionar")
                {
                    ComboBusqueda.Items.Add(columna.Name);
                }
            }

            ComboBusqueda.SelectedIndex = 0;

            //Listar empleados
            List<Empleado> listaEmpleado = new CN_Empleados().Listar();
            foreach(Empleado empleado in listaEmpleado)
            {
                dgvData.Rows.Add("", empleado.Id, empleado.Nombres, empleado.Apellidos, empleado.Documento, 
                                 empleado.Direccion, empleado.FechaNacimiento, empleado.TelefonoUno, empleado.TelefonoDos, 
                                 empleado.Correo, empleado.Activo);
            }

            //TxtNombres.Select();
            TxtBusqueda.Select();
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
            TxtNombres.ReadOnly = true;
            TxtApellidos.ReadOnly = true;
            TxtDocumento.ReadOnly = true;
            DtFechaNac.Enabled = false;

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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ComboBusqueda.SelectedItem.ToString();

            if(dgvData.Rows.Count > 0)
            {
                foreach(DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(TxtBusqueda.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtBusqueda.Clear();
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void TxtNombres_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtNombres.Text))
            {
                //e.Cancel = true;
                //TxtNombres.Focus();
                errorProvider1.SetError(TxtNombres, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtNombres, "");
            }
        }

        private void TxtApellidos_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtApellidos.Text))
            {
                //e.Cancel = true;
                TxtApellidos.Focus();
                errorProvider1.SetError(TxtApellidos, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtApellidos, "");
            }
        }

        private void TxtDocumento_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtDocumento.Text))
            {
                //e.Cancel = true;
                TxtDocumento.Focus();
                errorProvider1.SetError(TxtDocumento, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtDocumento, "");
            }
        }

        private void TxtDireccion_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtDireccion.Text))
            {
                //e.Cancel = true;
                TxtDireccion.Focus();
                errorProvider1.SetError(TxtDireccion, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtDireccion, "");
            }
        }

        private void TxtTelefono1_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtTelefono1.Text))
            {
                //e.Cancel = true;
                TxtTelefono1.Focus();
                errorProvider1.SetError(TxtTelefono1, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtTelefono1, "");
            }
        }

        private void TxtCorreo_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(TxtCorreo.Text))
            {
                //e.Cancel = true;
                TxtCorreo.Focus();
                errorProvider1.SetError(TxtCorreo, "Este campo es obligatorio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtCorreo, "");
            }
        }
    }
}

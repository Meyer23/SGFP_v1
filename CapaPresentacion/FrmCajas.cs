using CapaEntidad;
using CapaEntidad.Models;
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
    public partial class FrmCajas : Form
    {
        public FrmCajas()
        {
            InitializeComponent();
            CargarComboCajas();
            CargarComboUsuarios();
            CargarComboSucursal();
        }

        private void FrmCajas_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible && columna.Name != "BtnSeleccionar")
                {
                    ComboBusqueda.Items.Add(columna.Name);
                }
            }

            ComboBusqueda.SelectedIndex = 0;

            //Listar las cajas, con o sin usuarios asignados.

            List<Cajas> listadeCajas = new CN_Cajas().ObtenerCajas();
            
            foreach(Cajas cajas in listadeCajas)
            {
                if(cajas.LoginUsuario == "")
                {
                    cajas.LoginUsuario = "SIN ASIGNAR";
                }
                dgvData.Rows.Add("", cajas.Id, cajas.LoginUsuario, cajas.NumeroCaja, cajas.Sucursal, cajas.Activo);
            }

            TxtBusqueda.Select();
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.check_azul.Width;
                var h = Properties.Resources.check_azul.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check_azul, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void CargarComboCajas()
        {
            List<Cajas> cajas = new CN_Cajas().ObtenerCajas();
            ComboCajas.DataSource = cajas;

            foreach(Cajas resultCajas in cajas)
            {
                ComboCajas.DisplayMember = "Id";
            }
        }

        private void CargarComboUsuarios()
        {
            var usuarios = new CN_Usuario().Listar()
                                          .Where(e => e.NombreRol == "Cajero")
                                          .Select(u => new
                                          {
                                              DisplayText = $"{u.Login}",
                                          })
                                          .ToList();

            ComboUsuario.DataSource = usuarios;
            ComboUsuario.DisplayMember = "DisplayText";
        }

        private void CargarComboSucursal()
        {
            List<Sucursales> sucursales = new CN_Sucursal().ObtenerSucursal();

            ComboSucursal.DataSource = sucursales;

            foreach (Sucursales d in sucursales)
            {
                ComboSucursal.DisplayMember = "DescripcionSucursal";
            }
        }


        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool estadoCaja;

            if (dgvData.Columns[e.ColumnIndex].Name == "BtnSeleccionar")
            {
                int index = e.RowIndex;

                if(index >= 0)
                {
                    TxtIndex.Text = index.ToString();
                    TxtIdCaja.Text = dgvData.Rows[index].Cells["IdCaja"].Value.ToString();
                    ComboCajas.Text = dgvData.Rows[index].Cells["NumeroCaja"].Value.ToString();
                    ComboUsuario.Text = dgvData.Rows[index].Cells["Usuario"].Value.ToString();
                    estadoCaja = (bool)dgvData.Rows[index].Cells["Activo"].Value;
                    if (estadoCaja == true)
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

        private void LblAsignarCaja_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            int idCaja, numeroCaja;


            if(!int.TryParse(TxtIdCaja.Text.Trim(), out idCaja) )
            {
                MessageBox.Show("ID de caja no es válido.");
                return;
            }

            if (!short.TryParse(ComboCajas.Text, out short tmpNumeroCaja))
            {
                MessageBox.Show("Numero de caja no es válido.");
                return;
            }

            numeroCaja = tmpNumeroCaja;

            CajasRequest objCaja = new CajasRequest()
            {
                IdCaja = idCaja,
                NumeroCaja = numeroCaja,
                Usuario = ComboUsuario.Text,
                Sucursal = ComboSucursal.Text,
                Activo = ChkActivo.Checked
            };

            try
            {
                bool cn_cajas = new CN_Cajas().GuardarUsuarioCaja(objCaja, out Mensaje);

                if(cn_cajas)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(TxtIndex.Text)];
                    row.Cells["IdCaja"].Value = TxtIdCaja.Text;
                    row.Cells["Usuario"].Value = ComboUsuario.Text;
                    row.Cells["NumeroCaja"].Value = ComboCajas.Text;
                    row.Cells["Sucursal"].Value = ComboSucursal.Text;
                    row.Cells["Activo"].Value = ChkActivo.Checked;

                    MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Limpiar()
        {
            
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnCrearCaja_Click(object sender, EventArgs e)
        {
            using (PopUpNuevaCaja popup = new PopUpNuevaCaja())
            {
                popup.ShowDialog(this);
            }
        }
    }
}

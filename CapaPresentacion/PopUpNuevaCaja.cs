using CapaDatos;
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
    public partial class PopUpNuevaCaja : Form
    {
        public PopUpNuevaCaja()
        {
            InitializeComponent();
            CargarComboSucursal();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            InsertarCajaRequest objCaja = new InsertarCajaRequest()
            {
                NumeroCaja = (int)PickUpDownNroCaja.Value,
                Sucursal = ComboSucursal.Text,
                DescripcionCaja = TxtDescripcionCaja.Text,
                Activo = ChkActivo.Checked
            };

            try
            {
                int idCaja = new CN_Cajas().InsertarNuevaCaja(objCaja, out string Mensaje);

                if(idCaja > 0)
                { 
                    MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show(Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopUpNuevaCaja_Load(object sender, EventArgs e)
        {
            PickUpDownNroCaja.ReadOnly = true;

            var numeroCaja = new CN_Cajas().ObtenerCajas().Select(x => x.NumeroCaja).Max();

            PickUpDownNroCaja.Value = numeroCaja++;
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
    }
}

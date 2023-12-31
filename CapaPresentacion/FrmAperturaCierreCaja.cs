﻿using CapaEntidad.Models;
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
    public partial class FrmAperturaCierreCaja : Form
    {
        private UsuarioLogin _Usuario;
        public FrmAperturaCierreCaja(UsuarioLogin oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
            CargarComboSucursal();
            CargarComboUsuarios();
            CargarComboCajas();
            DateTimePickerCierre.Value = DateTime.Now;
            DateTimePickerApertura.Value = DateTime.Now;
        }

        private void FrmAperturaCierreCaja_Load(object sender, EventArgs e)
        {
            if(_Usuario.IdRol == 2)
            {
                ComboCajero.Text = _Usuario.Login;
                ComboCajero.Enabled = false;
                ComboEstado.Text = "ABIERTO";
                ComboEstado.ForeColor = Color.YellowGreen;
                ComboEstado.Enabled = false;
            }
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

        private void CargarComboUsuarios()
        {
            if(_Usuario.Login == "admin")
            {
                var usuarios = new CN_Usuario().Listar()
                              .Where(e => e.NombreRol == "Cajero")
                              .Select(u => new
                              {
                                  DisplayText = $"{u.Login}",
                              })
                              .ToList();

                ComboCajero.DataSource = usuarios;
                ComboCajero.DisplayMember = "DisplayText";
                ComboEstado.Text = "ABIERTO";
                ComboEstado.ForeColor = Color.YellowGreen;
                ComboEstado.Enabled = false;
            }
            else
            {
                ComboCajero.Text = _Usuario.Login.ToString();
                ComboCajero.Enabled = false;
                ComboEstado.Text = "ABIERTO";
                ComboEstado.ForeColor = Color.YellowGreen;
                ComboEstado.Enabled = false;
            }
        }

        private void CargarComboCajas()
        {
            List<Cajas> cajas = new CN_Cajas().ObtenerCajas();
            ComboCajas.DataSource = cajas;

            foreach (Cajas resultCajas in cajas)
            {
                ComboCajas.DisplayMember = "DescripcionCaja";
            }
        }

        private void BtnApertura_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            try
            {
                AperturaRequest obj = new AperturaRequest()
                {
                    FechaApertura = DateTimePickerApertura.Value,
                    DescripcionCaja = ComboCajas.Text,
                    ImporteInicial = ImporteUpDown.Value,
                    Usuario = ComboCajero.Text
                };

                int idAperturaCaja = new CN_AperturaCierre().AperturaCierreCaja(obj, out Mensaje);

                if (idAperturaCaja > 0)
                {
                    MessageBox.Show(Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reportes.FrmRptAperturaCaja oRptApertura = new Reportes.FrmRptAperturaCaja();
                    oRptApertura.TxtParamId.Text = idAperturaCaja.ToString();
                    oRptApertura.ShowDialog();
                }
                else
                {
                    MessageBox.Show(Mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCerrarCaja_Click(object sender, EventArgs e)
        {
            try
            {
                CierreRequest objCierre = new CierreRequest()
                {
                    ImporteCierre = UpDownMontoCierre.Value,
                    FechaApertura = DateTimePickerApertura.Value,
                    LoginCajero = ComboCajero.Text,
                    DescripcionCaja = ComboCajas.Text,
                    FechaCierre = DateTimePickerCierre.Value
                };

                int idCierreCaja = new CN_AperturaCierre().CierreCaja(objCierre, out string Mensaje);
                
                if(idCierreCaja > 0)
                {
                    MessageBox.Show(Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reportes.FrmRptCierreCaja oRptCierre = new Reportes.FrmRptCierreCaja();
                    oRptCierre.TxtParamId.Text = idCierreCaja.ToString();
                    oRptCierre.ShowDialog();
                }
                else
                {
                    MessageBox.Show(Mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Reportes.FrmRptRendicionCaja oRptRendicion = new Reportes.FrmRptRendicionCaja();
            oRptRendicion.TxtParamLogin.Text = ComboCajero.Text;
            oRptRendicion.dateTimePicker1.Value = DateTimePickerApertura.Value.Date;
            oRptRendicion.TxtParamCaja.Text = ComboCajas.Text;
            oRptRendicion.ShowDialog();
        }
    }
}

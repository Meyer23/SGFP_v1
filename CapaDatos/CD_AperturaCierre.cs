﻿using CapaEntidad.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_AperturaCierre
    {

        public int AperturarCaja(AperturaRequest datos, out string Mensaje)
        {
            int resultado = 0; 
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_abrir_caja", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@pi_aperturaFecha", datos.FechaApertura);
                    cmd.Parameters.AddWithValue("@pi_descripcioncaja", datos.DescripcionCaja);
                    cmd.Parameters.AddWithValue("@pi_importe", datos.ImporteInicial);
                    cmd.Parameters.AddWithValue("@pi_cajero", datos.Usuario);
                    cmd.Parameters.AddWithValue("@IdApertura", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToInt32(cmd.Parameters["@IdApertura"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
            }
            catch(Exception ex)
            {
                resultado = 0;
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultado;
        }

        public int CierreCaja(CierreRequest datos, out string Mensaje)
        {
            int resultado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_cerrar_caja", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@pi_aperturaFecha", datos.FechaApertura);
                    cmd.Parameters.AddWithValue("@pi_cierreFecha", datos.FechaCierre);
                    cmd.Parameters.AddWithValue("@pi_descripcioncaja", datos.DescripcionCaja);
                    cmd.Parameters.AddWithValue("@pi_importeCierre", datos.ImporteCierre);
                    cmd.Parameters.AddWithValue("@pi_cajero", datos.LoginCajero);
                    cmd.Parameters.AddWithValue("@IdCierre", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToInt32(cmd.Parameters["@IdCierre"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                resultado = 0;
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultado;
        }
    }
}
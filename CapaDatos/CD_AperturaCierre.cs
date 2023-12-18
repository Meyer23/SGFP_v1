using CapaEntidad;
using CapaEntidad.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
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

        public List<AperturaCierreCajas> ObtenerAperturasDeCajas()
        {
            List<AperturaCierreCajas> aperturas = new List<AperturaCierreCajas>();


            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT x.id FROM DBO.AperturaCierreCaja X WHERE X.Estado = 1";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            aperturas.Add(new AperturaCierreCajas
                            {
                                Id = Convert.ToInt32(reader["Id"].ToString())
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    aperturas = new List<AperturaCierreCajas>();
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return aperturas;
        }

        public List<ListadoEstadoCajas> ObtenerListadoDeAperturas()
        {
            List<ListadoEstadoCajas> aperturas = new List<ListadoEstadoCajas>();


            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                   string query = @"
                                    SELECT 
                                        a.id,
                                        a.MontoInicial,
                                        ISNULL(CAST(a.MontoCierre AS VARCHAR(50)), 'PENDIENTE') AS MontoCierre,
                                        ISNULL(CAST(a.MontoActual AS VARCHAR(50)), 'PENDIENTE') AS MontoActual,
                                        ISNULL(CONVERT(VARCHAR(50), a.FechaApertura, 120), 'PENDIENTE') AS FechaApertura,
                                        ISNULL(CONVERT(VARCHAR(50), a.FechaCierre, 120), 'SIN DATO') AS FechaCierre,
                                        c.NroCaja,
                                        a.Estado
                                    FROM dbo.AperturaCierreCaja a
                                    INNER JOIN dbo.Cajas c ON a.idCaja = c.id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            aperturas.Add(new ListadoEstadoCajas
                            {
                                Id = Convert.ToInt32(reader["Id"].ToString()),
                                MontoInicial = Convert.ToString(reader["MontoInicial"].ToString()),
                                MontoCierre = Convert.ToString(reader["MontoCierre"].ToString()),
                                MontoActual = Convert.ToString(reader["MontoActual"].ToString()),
                                FechaApertura = Convert.ToString(reader["FechaApertura"].ToString()),
                                FechaCierre = Convert.ToString(reader["FechaCierre"].ToString()),
                                NroCaja = Convert.ToInt32(reader["NroCaja"].ToString()),
                                Estado = Convert.ToBoolean(reader["Estado"].ToString())
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    aperturas = new List<ListadoEstadoCajas>();
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return aperturas;
        }
    }
}
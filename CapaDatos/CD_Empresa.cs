using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_Empresa
    {
        public Empresa ObtenerDatos()
        {
            Empresa empresa = new Empresa(); 
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT id, RazonSocial, RUC, Direccion FROM Empresa";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            empresa = new Empresa()
                            {
                                id = Convert.ToInt32(reader["id"]),
                                RazonSocial = reader["RazonSocial"].ToString(),
                                RUC = reader["RUC"].ToString(),
                                Direccion = reader["Direccion"].ToString()
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    empresa = new Empresa();
                }
            }
            return empresa;
        }

        public bool GuardarDatos(Empresa empresa, out string Mensaje)
        {
            bool Respuesta = true;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {
                    con.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE Empresa SET RazonSocial = @RazonSocial, ");
                    query.AppendLine("RUC = @RUC, ");
                    query.AppendLine("Direccion = @Direccion ");
                    query.AppendLine("WHERE id = 1 ");

                    SqlCommand cmd = new SqlCommand(query.ToString(), con);
                    cmd.CommandType = CommandType.Text;
                    
                    cmd.Parameters.AddWithValue("@RazonSocial", empresa.RazonSocial);
                    cmd.Parameters.AddWithValue("@RUC", empresa.RUC);
                    cmd.Parameters.AddWithValue("@Direccion", empresa.Direccion);

                    if(cmd.ExecuteNonQuery() < 1)
                    {
                        Mensaje = "No se pudieron guardar los datos";
                        Respuesta = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Respuesta;
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            obtenido = true;
            byte[] LogoBytes = new byte[0];

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    con.Open();

                    string query = "SELECT Logo FROM Empresa WHERE id = 1";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;                    

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LogoBytes = (byte[]) reader["Logo"];
                        }
                    }

                }
                catch (Exception ex)
                {
                    obtenido = false;
                    LogoBytes = new byte[0];
                }
            }
            return LogoBytes;
        }

        public bool ActualizarLogo(byte[] image, out string Mensaje)
        {
            bool Respuesta = true;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {
                    con.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE Empresa SET Logo = @Imagen ");
                    query.AppendLine("WHERE id = 1 ");

                    SqlCommand cmd = new SqlCommand(query.ToString(), con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@Imagen", image);

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        Mensaje = "No se pudo actualizar el logo";
                        Respuesta = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Respuesta;
        }
    }
}

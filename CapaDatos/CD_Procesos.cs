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
    public class CD_Procesos
    {
        public List<Proceso> Listar(int idRol)
        {
            List<Proceso> procesos = new List<Proceso>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT RP.id, RP.idRol, RP.idProceso, P.Nombre, RP.Procesar " +
                        "FROM RolesProcesos RP INNER JOIN Procesos P ON RP.idProceso = P.id WHERE RP.IdRol = " + idRol;

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            procesos.Add(new Proceso
                            {
                                IdRolProceso = Convert.ToInt32(reader["id"]),
                                RolId = Convert.ToInt32(reader["idRol"]),
                                IdProceso = Convert.ToInt32(reader["idProceso"]),
                                Nombre = reader["Nombre"].ToString(),
                                Procesa = Convert.ToBoolean(reader["Procesar"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    procesos = new List<Proceso>();
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return procesos;
        }

        public bool InsertarProcesos(int idRol)
        {
            bool Respuesta = false;
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_roles_procesos_insertar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@idRol", idRol);
                    cmd.Parameters.Add("@Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    Respuesta = Convert.ToBoolean(cmd.Parameters["@Respuesta"].Value);
                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Respuesta;
        }

        public bool Editar(int IdRol, int IdProceso, bool Procesa)
        {
            bool Respuesta = false;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_roles_procesos_editar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@idRol", IdRol);
                    cmd.Parameters.AddWithValue("@idProceso", IdProceso);
                    cmd.Parameters.AddWithValue("@Procesa", Procesa);
                    cmd.Parameters.Add("@Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["@Respuesta"].Value);
                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Respuesta;
        }

        public List<Proceso> ObtenerProcesos(int idUsuario)
        {
            List<Proceso> procesos = new List<Proceso>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT RP.id, RP.idRol, RP.idProceso, P.Boton, RP.Procesar " +
                        "FROM RolesProcesos RP " +
                        "INNER JOIN Procesos P ON RP.idProceso = P.id " +
                        "INNER JOIN Roles R ON RP.idRol = R.id " +
                        "INNER JOIN Usuarios U ON R.id = U.idRol " +
                        "WHERE U.id = " + idUsuario;

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            procesos.Add(new Proceso
                            {
                                IdRolProceso = Convert.ToInt32(reader["id"]),
                                RolId = Convert.ToInt32(reader["idRol"]),
                                IdProceso = Convert.ToInt32(reader["idProceso"]),
                                Boton = reader["Boton"].ToString(),
                                Procesa = Convert.ToBoolean(reader["Procesar"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    procesos = new List<Proceso>();
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return procesos;
        }

    }
}

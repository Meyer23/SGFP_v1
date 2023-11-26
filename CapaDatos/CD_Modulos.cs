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
    public class CD_Modulos
    {

        public List<Modulo> Listar(int idRol)
        {
            List<Modulo> modulos = new List<Modulo>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT RM.id, RM.idRol, RM.idModulo, M.Nombre, RM.Visualiza, RM.Incluye, RM.Modifica " +
                                    "FROM RolesModulos RM INNER JOIN Modulos M ON RM.idModulo = M.id WHERE RM.IdRol = " + idRol;

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            modulos.Add(new Modulo
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                IdRol = Convert.ToInt32(reader["idRol"]),
                                IdModulo = Convert.ToInt32(reader["idModulo"]),
                                Nombre = reader["Nombre"].ToString(),
                                Visualiza = Convert.ToBoolean(reader["Visualiza"]),
                                Incluye = Convert.ToBoolean(reader["Incluye"]),
                                Modifica = Convert.ToBoolean(reader["Modifica"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    modulos = new List<Modulo>();
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return modulos;
        }

        public bool InsertarModulos(int idRol)
        {
            bool Respuesta = false;
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_roles_modulos_insertar", con);
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

        public bool Editar(int IdRol, int IdModulo, bool Visualiza, bool Incluye, bool Modifica)
        {
            bool Respuesta = false;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_roles_modulos_editar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@idRol", IdRol);
                    cmd.Parameters.AddWithValue("@idModulo", IdModulo);
                    cmd.Parameters.AddWithValue("@Visualiza", Visualiza);
                    cmd.Parameters.AddWithValue("@Incluye", Incluye);
                    cmd.Parameters.AddWithValue("@Modifica", Modifica);
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

        public List<Modulo> ObtenerModulos(int idUsuario)
        {
            List<Modulo> modulos = new List<Modulo>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT RM.id, RM.idRol, RM.idModulo, M.Nombre, M.Menu, RM.Visualiza, RM.Incluye, RM.Modifica " +
                                    "FROM RolesModulos RM " +
                                    "INNER JOIN Modulos M ON RM.idModulo = M.id " +
                                    "INNER JOIN Roles R ON RM.idRol = R.id " +
                                    "INNER JOIN Usuarios U ON R.id = U.idRol " +
                                    "WHERE U.id = " + idUsuario;

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            modulos.Add(new Modulo
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                IdRol = Convert.ToInt32(reader["idRol"]),
                                IdModulo = Convert.ToInt32(reader["idModulo"]),
                                Nombre = reader["Nombre"].ToString(),
                                Menu = reader["Menu"].ToString(),
                                Visualiza = Convert.ToBoolean(reader["Visualiza"]),
                                Incluye = Convert.ToBoolean(reader["Incluye"]),
                                Modifica = Convert.ToBoolean(reader["Modifica"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    modulos = new List<Modulo>();
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return modulos;
        }
    }
}

using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                }
            }
            return modulos;
        }
    }
}

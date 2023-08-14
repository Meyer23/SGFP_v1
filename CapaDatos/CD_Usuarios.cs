using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        public List<Usuario> MostrarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT idUsuario, Nombres, Apellidos, Login, Cedula, r.Nombre as Rol, s.Descripcion as Sucursal, u.Activo" +
                        "FROM Usuarios u" +
                        "inner join Rol r " +
                        "on u.idRol = r.id" +
                        "inner join Sucursal s" +
                        "on s.idSucursal = u.SucursalCaja";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            usuarios.Add(new Usuario
                            {
                                
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                }
            }

            return usuarios;
        }
    }
}
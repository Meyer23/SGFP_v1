using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.ComponentModel;
using CapaEntidad.Models;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        public List<UsuarioLogin> ObtenerUsuarioLogin()
        {
            List<UsuarioLogin> usuarios = new List<UsuarioLogin>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT U.LOGIN, U.CONTRASEÑA, U.ACTIVO FROM DBO.USUARIOS U";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            usuarios.Add(new UsuarioLogin
                            {
                                Login = reader["Login"].ToString(),
                                PassWord = reader["Contraseña"].ToString(),
                                Activo = Convert.ToBoolean(reader["Activo"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                   usuarios = new List<UsuarioLogin>();   
                }
            }

            return usuarios;
        }
    }
}
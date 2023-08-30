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
using System.Windows.Forms;

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
                    string query = "SELECT U.LOGIN, U.PASSWORD, U.ACTIVO FROM DBO.USUARIOS U";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            usuarios.Add(new UsuarioLogin
                            {
                                Login = reader["LOGIN"].ToString(),
                                PassWord = reader["PASSWORD"].ToString(),
                                Activo = Convert.ToBoolean(reader["ACTIVO"])
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

        public List<Rol> ObtenerRol()
        {
            List<Rol> rol = new List<Rol>();


            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT R.NOMBRE, R.ESTADO FROM DBO.ROLES R WHERE R.ESTADO = 1";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rol.Add(new Rol
                            {
                                Nombre = reader["NOMBRE"].ToString(),
                                Activo = Convert.ToBoolean(reader["ESTADO"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    rol = new List<Rol>();
                }
            }

            return rol;
        }

        public List<Usuario> Listar()
        {
            List<Usuario> usuario = new List<Usuario>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "select u.id, u.Login, r.Nombre as Rol, e.Nombres +' '+ e.apellidos as NombreCompleto, e.Documento, s.Descripcion as Sucursal, u.Activo" +
                        "from dbo.Usuarios u " +
                        "inner join dbo.Roles r" +
                        "on u.idRol = r.id" +
                        "inner join dbo.Empleados e" +
                        "on e.id = u.idEmpleado" +
                        "inner join dbo.Sucursales s" +
                        "on u.idSucursalCaja = s.id;";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usuario.Add(new Usuario
                            {
                                //IdRol = Convert.ToInt32(reader["ID"]),
                                //Nombre = reader["NOMBRE"].ToString(),
                                //Activo = Convert.ToBoolean(reader["Activo"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return usuario;
        }
    }
}
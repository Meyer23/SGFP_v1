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
using System.Reflection;

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
                    string query = "SELECT U.ID, U.LOGIN, U.PASSWORD, U.IDROL, U.ACTIVO FROM DBO.USUARIOS U";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            usuarios.Add(new UsuarioLogin
                            {
                                Id = Convert.ToInt32(reader["ID"]),
                                Login = reader["LOGIN"].ToString(),
                                PassWord = reader["PASSWORD"].ToString(),
                                IdRol = Convert.ToInt32(reader["IDROL"]),
                                Activo = Convert.ToBoolean(reader["ACTIVO"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                   usuarios = new List<UsuarioLogin>();
                   MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return rol;
        }

        public List<UsuarioResponse> Listar()
        {
            List<UsuarioResponse> usuario = new List<UsuarioResponse>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "select u.id, e.documento, u.login, e.nombres, e.apellidos, r.nombre Rol, s.Descripcion Sucursal, u.activo from dbo.Empleados e inner join dbo.Usuarios u on e.id = u.idEmpleado inner join dbo.Roles r on u.idRol = r.id inner join dbo.Sucursales s on s.id = u.idSucursal;";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usuario.Add(new UsuarioResponse
                            {
                                idUsuario = Convert.ToInt32(reader["ID"]),
                                Cedula = reader["DOCUMENTO"].ToString(),
                                Login = reader["LOGIN"].ToString(),
                                Nombres = reader["NOMBRES"].ToString(),
                                Apellidos = reader["APELLIDOS"].ToString(),
                                NombreRol = reader["ROL"].ToString(),
                                NombreSucursal = reader["SUCURSAL"].ToString(),
                                Activo = Convert.ToBoolean(reader["Activo"])
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

        public int Registrar(UsuarioRequest obj, out string Mensaje)
        {
            int idUsuario = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_usuario_insertar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@Login", obj.Login);
                    cmd.Parameters.AddWithValue("@Password", obj.Password);
                    cmd.Parameters.AddWithValue("@EmpleadoId", obj.EmpleadoId);
                    cmd.Parameters.AddWithValue("@UsuarioRol", obj.UsuarioRol);
                    cmd.Parameters.AddWithValue("@UsuarioSucursal", obj.UsuarioSucursal);
                    cmd.Parameters.AddWithValue("@Activo", obj.Activo);
                    cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    idUsuario = Convert.ToInt32(cmd.Parameters["@IdUsuario"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idUsuario = 0;
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return idUsuario;
        }

        public bool Editar(UsuarioEditarRequest obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_usuario_editar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@idUsuario", obj.IdUsuario);
                    cmd.Parameters.AddWithValue("@PassWord", obj.PassWord);
                    cmd.Parameters.AddWithValue("@usuarioRol", obj.UsuarioRol);
                    cmd.Parameters.AddWithValue("@Activo", obj.Activo);
                    cmd.Parameters.Add("@Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["@Respuesta"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
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
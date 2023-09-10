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

        public List<UsuarioResponse> Listar()
        {
            List<UsuarioResponse> usuario = new List<UsuarioResponse>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "";

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
                    Mensaje = cmd.Parameters["@Mensaje"].ToString();
                }
            }
            catch (Exception ex)
            {
                idUsuario = 0;
                Mensaje = ex.Message;
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
                    Mensaje = (string)cmd.Parameters["@Mensaje"].Value;
                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }

            return Respuesta;
        }
    }
}
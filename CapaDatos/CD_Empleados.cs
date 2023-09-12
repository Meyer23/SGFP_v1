using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Collections;
using System.Windows.Forms;


namespace CapaDatos
{
    public class CD_Empleados
    {
        public List<Empleado> Listar()
        {
            List<Empleado> empleado = new List<Empleado>();

            using(SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT e.Id, Nombres, Apellidos, Documento, Direccion, FechaNacimiento, Telefono1, Telefono2, Correo, e.Activo FROM Empleados e";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            empleado.Add(new Empleado
                            {
                                Id = Convert.ToInt32(reader["ID"]),
                                Nombres = reader["Nombres"].ToString(),
                                Apellidos = reader["Apellidos"].ToString(),
                                Documento = reader["Documento"].ToString(),
                                Direccion = reader["Direccion"].ToString(),
                                FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                                TelefonoUno = reader["Telefono1"].ToString(),
                                TelefonoDos = reader["Telefono2"].ToString(),
                                Correo = reader["Correo"].ToString(),
                                Activo = Convert.ToBoolean(reader["Activo"])
                            });
                        }
                    }

                }catch (Exception ex)
                {
                    empleado = new List<Empleado>();
                }
            }
            return empleado;
        }

        public int Registrar(Empleado obj, out string Mensaje)
        {
            int IdEmpleado = 0;
            Mensaje = string.Empty;          

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_empleado_insertar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open(); 
                    cmd.Parameters.AddWithValue("@Nombres", obj.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", obj.Apellidos);
                    cmd.Parameters.AddWithValue("@Documento", obj.Documento);
                    cmd.Parameters.AddWithValue("@Direccion", obj.Direccion);
                    cmd.Parameters.AddWithValue("@FechaNac", obj.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@Telefono1", obj.TelefonoUno);
                    cmd.Parameters.AddWithValue("@Telefono2", obj.TelefonoDos);
                    cmd.Parameters.AddWithValue("@Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("@Activo", obj.Activo);
                    cmd.Parameters.Add("@IdEmpleado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    IdEmpleado = Convert.ToInt32(cmd.Parameters["@IdEmpleado"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].ToString();
                }
            }
            catch (Exception ex)
            {
                IdEmpleado = 0;
                Mensaje = ex.Message;
            }
            return IdEmpleado;
        }

        public bool Editar(Empleado obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_empleado_editar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@idEmpleado", obj.Id);
                    cmd.Parameters.AddWithValue("@Nombres", obj.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", obj.Apellidos);
                    cmd.Parameters.AddWithValue("@Documento", obj.Documento);
                    cmd.Parameters.AddWithValue("@Direccion", obj.Direccion);
                    cmd.Parameters.AddWithValue("@FechaNac", obj.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@Telefono1", obj.TelefonoUno);
                    cmd.Parameters.AddWithValue("@Telefono2", obj.TelefonoDos);
                    cmd.Parameters.AddWithValue("@Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("@Activo", obj.Activo);
                    cmd.Parameters.Add("@Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["@Respuesta"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].ToString();
                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }

            return Respuesta;
        }

        //Lista de empleados que no son usuarios.
        public List<Empleado> Listar_2()
        {
            List<Empleado> empleado = new List<Empleado>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT e.Id, Nombres, Apellidos, Documento, Direccion, FechaNacimiento, Telefono1, Telefono2, Correo, e.Activo FROM Empleados e LEFT JOIN Usuarios U on e.id = U.idEmpleado where u.idEmpleado is NULL;";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            empleado.Add(new Empleado
                            {
                                Id = Convert.ToInt32(reader["ID"]),
                                Nombres = reader["Nombres"].ToString(),
                                Apellidos = reader["Apellidos"].ToString(),
                                Documento = reader["Documento"].ToString(),
                                Direccion = reader["Direccion"].ToString(),
                                FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                                TelefonoUno = reader["Telefono1"].ToString(),
                                TelefonoDos = reader["Telefono2"].ToString(),
                                Correo = reader["Correo"].ToString(),
                                Activo = Convert.ToBoolean(reader["Activo"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    empleado = new List<Empleado>();
                }
            }
            return empleado;
        }

    }  

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Windows.Forms;
using System.Collections;


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
                    string query = "SELECT Id, Nombres, Apellidos, Documento, Direccion, FechaNacimiento, Telefono1, Telefono2, Correo, Activo FROM Empleados";

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

        public int Registrar(Empleado obj)
        {
            int IdEmpleado = 0;

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

                    cmd.ExecuteNonQuery();

                    IdEmpleado = Convert.ToInt32(cmd.Parameters["@IdEmpleado"].Value);
                }
            }
            catch (Exception ex)
            {
                IdEmpleado = 0;
                MessageBox.Show(ex.Message);
            }
            return IdEmpleado;
        }

        public int Editar(Empleado obj)
        {
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

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return 0;
        }

    }  

}

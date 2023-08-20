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

    }
}

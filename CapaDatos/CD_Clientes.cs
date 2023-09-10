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
    public class CD_Clientes
    {
        public List<Cliente> Listar()
        {
            List<Cliente> clientes = new List<Cliente>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT id, Nombre, Documento, Direccion, Telefono1, Telefono2, Correo, TipoPersona, Activo FROM Clientes";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clientes.Add(new Cliente
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Nombre = reader["Nombre"].ToString(),
                                Documento = reader["Documento"].ToString(),
                                Direccion = reader["Direccion"].ToString(),
                                TelefonoUno = reader["Telefono1"].ToString(),
                                TelefonoDos = reader["Telefono2"].ToString(),
                                Correo = reader["Correo"].ToString(),
                                TipoPersona = Convert.ToBoolean(reader["TipoPersona"]),
                                Activo = Convert.ToBoolean(reader["Activo"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    clientes = new List<Cliente>();
                }
            }
            return clientes;
        }

        public int Registrar(Cliente obj, out string Mensaje)
        {
            int IdCliente = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_cliente_insertar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("@Documento", obj.Documento);
                    cmd.Parameters.AddWithValue("@Direccion", obj.Direccion);
                    cmd.Parameters.AddWithValue("@Telefono1", obj.TelefonoUno);
                    cmd.Parameters.AddWithValue("@Telefono2", obj.TelefonoDos);
                    cmd.Parameters.AddWithValue("@Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("@TipoPersona", obj.TipoPersona);
                    cmd.Parameters.AddWithValue("@Activo", obj.Activo);
                    cmd.Parameters.Add("@IdCliente", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    IdCliente = Convert.ToInt32(cmd.Parameters["@IdCliente"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].ToString();
                }
            }
            catch (Exception ex)
            {
                IdCliente = 0;
                Mensaje = ex.Message;
            }
            return IdCliente;
        }

        public bool Editar(Cliente obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_cliente_editar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@IdCliente", obj.Id);
                    cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("@Documento", obj.Documento);
                    cmd.Parameters.AddWithValue("@Direccion", obj.Direccion);
                    cmd.Parameters.AddWithValue("@Telefono1", obj.TelefonoUno);
                    cmd.Parameters.AddWithValue("@Telefono2", obj.TelefonoDos);
                    cmd.Parameters.AddWithValue("@Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("@TipoPersona", obj.TipoPersona);
                    cmd.Parameters.AddWithValue("@Activo", obj.Activo);
                    cmd.Parameters.Add("@Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

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
    }
}

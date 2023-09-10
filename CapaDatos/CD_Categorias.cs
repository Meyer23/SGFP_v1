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
    public class CD_Categorias
    {
        public List<Categoria> Listar()
        {
            List<Categoria> categorias = new List<Categoria>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT C.id,  C.Nombre, C.Descripcion, C.PorcUtilidad, I.Descripcion AS Impuesto, C.Activo " +
                        "FROM Categorias C INNER JOIN Impuestos I ON C.idImpuesto = I.id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categorias.Add(new Categoria
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Nombre = reader["Nombre"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                PorcUtilidad = Convert.ToDecimal(reader["PorcUtilidad"]),
                                Impuesto = reader["Descripcion"].ToString(),
                                Activo = Convert.ToBoolean(reader["Activo"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    categorias = new List<Categoria>();
                }
            }
            return categorias;
        }

        public int Registrar(Categoria obj, out string Mensaje)
        {
            int IdCategoria = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_categoria_insertar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("@PorcUtilidad", obj.PorcUtilidad);
                    cmd.Parameters.AddWithValue("@Impuesto", obj.Impuesto);
                    cmd.Parameters.AddWithValue("@Activo", obj.Activo);
                    cmd.Parameters.Add("@IdCategoria", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    IdCategoria = Convert.ToInt32(cmd.Parameters["@IdCategoria"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].ToString();
                }
            }
            catch (Exception ex)
            {
                IdCategoria = 0;
                Mensaje = ex.Message;
            }
            return IdCategoria;
        }

        public bool Editar(Categoria obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_categoria_editar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@IdCategoria", obj.Id);
                    cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("@PorcUtilidad", obj.PorcUtilidad);
                    cmd.Parameters.AddWithValue("@Impuesto", obj.Impuesto);
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

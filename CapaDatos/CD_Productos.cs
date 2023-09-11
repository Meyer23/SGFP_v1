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
    public class CD_Productos
    {
        public List<Producto> Listar()
        {
            List<Producto> productos = new List<Producto>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT P.id, Codigo, P.Descripcion, Costo, Precio, Existencia, ExistenciaMinima," +
                        "C.Descripcion AS Categoria, U.Descripcion AS UnidadMedida, Estante, Fila, Columna, P.Activo FROM Productos P" +
                        " INNER JOIN Categorias C ON P.idCategoria = C.id" +
                        " INNER JOIN UnidadesMedidas U ON P.idUnidadMedida = U.id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productos.Add(new Producto
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Codigo = reader["Codigo"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                Costo = Convert.ToDecimal(reader["Costo"]),
                                Precio = Convert.ToDecimal(reader["Precio"]),
                                Existencia = Convert.ToDecimal(reader["Existencia"]),
                                ExistenciaMinima = Convert.ToDecimal(reader["ExistenciaMinima"]),
                                Categoria = reader["Categoria"].ToString(),
                                UnidadMedida = reader["UnidadMedida"].ToString(),
                                Estante = Convert.ToInt32(reader["Estante"]),
                                Fila = Convert.ToInt32(reader["Fila"]),
                                Columna = Convert.ToInt32(reader["Columna"]),
                                Activo = Convert.ToBoolean(reader["Activo"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    productos = new List<Producto>();
                }
            }
            return productos;
        }

        public int Registrar(Producto obj, out string Mensaje)
        {
            int IdProducto = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_producto_insertar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@Codigo", obj.Codigo);
                    cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("@Costo", obj.Costo);
                    cmd.Parameters.AddWithValue("@Precio", obj.Precio);
                    cmd.Parameters.AddWithValue("@Existencia", obj.Existencia);
                    cmd.Parameters.AddWithValue("@ExistenciaMinima", obj.ExistenciaMinima);
                    cmd.Parameters.AddWithValue("@Categoria", obj.Categoria);
                    cmd.Parameters.AddWithValue("@UnidadMedida", obj.UnidadMedida);
                    cmd.Parameters.AddWithValue("@Estante", obj.Estante);
                    cmd.Parameters.AddWithValue("@Fila", obj.Fila);
                    cmd.Parameters.AddWithValue("@Columna", obj.Columna);
                    cmd.Parameters.AddWithValue("@Activo", obj.Activo);
                    cmd.Parameters.Add("@IdProducto", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    IdProducto = Convert.ToInt32(cmd.Parameters["@IdProducto"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].ToString();
                }
            }
            catch (Exception ex)
            {
                IdProducto = 0;
                Mensaje = ex.Message;
            }
            return IdProducto;
        }

        public bool Editar(Producto obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_producto_editar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@IdProducto", obj.Id);
                    cmd.Parameters.AddWithValue("@Codigo", obj.Codigo);
                    cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("@Costo", obj.Costo);
                    cmd.Parameters.AddWithValue("@Precio", obj.Precio);
                    cmd.Parameters.AddWithValue("@Existencia", obj.Existencia);
                    cmd.Parameters.AddWithValue("@ExistenciaMinima", obj.ExistenciaMinima);
                    cmd.Parameters.AddWithValue("@Categoria", obj.Categoria);
                    cmd.Parameters.AddWithValue("@UnidadMedida", obj.UnidadMedida);
                    cmd.Parameters.AddWithValue("@Estante", obj.Estante);
                    cmd.Parameters.AddWithValue("@Fila", obj.Fila);
                    cmd.Parameters.AddWithValue("@Columna", obj.Columna);
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

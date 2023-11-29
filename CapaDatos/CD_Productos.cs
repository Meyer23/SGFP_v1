using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_Productos
    {
        public List<Producto> Listar(int bandera, int id)
        {
            List<Producto> productos = new List<Producto>();
            string query;

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    if (bandera == 0)
                    {
                        query = "SELECT P.id, Codigo, P.Descripcion, Costo, Precio, Existencia, ExistenciaMinima," +
                        "C.Descripcion AS Categoria, U.Descripcion AS UnidadMedida, Estante, Fila, Columna, P.Activo FROM Productos P" +
                        " INNER JOIN Categorias C ON P.idCategoria = C.id" +
                        " INNER JOIN UnidadesMedidas U ON P.idUnidadMedida = U.id";
                    }
                    else if (bandera == 1)
                    {
                        query = "SELECT P.id, Codigo, P.Descripcion, Costo, CONVERT(int,CD.Precio) AS Precio, CONVERT(int,CD.Cantidad) AS Existencia, ExistenciaMinima, " +
                            "C.Descripcion AS Categoria, U.Descripcion AS UnidadMedida, Estante, Fila, Columna, P.Activo " +
                            "FROM ComprasDetalles CD " +
                            "INNER JOIN Productos P ON CD.idProducto = P.id " +
                            "INNER JOIN Categorias C ON P.idCategoria = C.id " +
                            "INNER JOIN UnidadesMedidas U ON P.idUnidadMedida = U.id " +
                            "WHERE CD.idCompra = " + id;
                    }
                    else
                    {
                        query = "SELECT P.id, Codigo, P.Descripcion, Costo, CONVERT(int,FD.PrecioUnitario) AS Precio, CONVERT(int,FD.Cantidad) AS Existencia, ExistenciaMinima, " +
                            "C.Descripcion AS Categoria, U.Descripcion AS UnidadMedida, Estante, Fila, Columna, P.Activo " +
                            "FROM FacturasDetalles FD " +
                            "INNER JOIN Productos P ON FD.idProducto = P.id " +
                            "INNER JOIN Categorias C ON P.idCategoria = C.id " +
                            "INNER JOIN UnidadesMedidas U ON P.idUnidadMedida = U.id " +
                            "WHERE FD.idFactura = " + id;
                    }
                     
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
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                IdProducto = 0;
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public byte[] ObtenerLogo(int idProducto, out bool obtenido)
        {
            obtenido = true;
            byte[] LogoBytes = new byte[0];

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    con.Open();

                    string query = "SELECT Imagen FROM Productos WHERE id = " + idProducto;

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LogoBytes = (byte[])reader["Imagen"];
                        }
                    }

                }
                catch (Exception ex)
                {
                    obtenido = false;
                    LogoBytes = new byte[0];
                }
            }
            return LogoBytes;
        }

        public bool ActualizarLogo(byte[] image, int idProducto, out string Mensaje)
        {
            bool Respuesta = true;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {
                    con.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE Productos SET Imagen = @Imagen ");
                    query.AppendLine("WHERE id = " + idProducto);

                    SqlCommand cmd = new SqlCommand(query.ToString(), con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@Imagen", image);

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        Mensaje = "No se pudo actualizar la imagen";
                        Respuesta = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Respuesta;
        }

        public List<DetalleProductos> ObtenerUltimasCompras(int idProducto)
        {
            List<DetalleProductos> compras = new List<DetalleProductos>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT P.Documento, P.RazonSocial, H.FechaUltimaCompra, H.PrecioUltimaCompra, H.CantidadUltimaCompra, H.TotalUltimaCompra " +
                        "FROM HistoricoUltimasCompras H " +
                        "INNER JOIN Proveedores P ON H.idProveedor = P.id " +
                        "WHERE H.idProducto = " + idProducto;

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            compras.Add(new DetalleProductos
                            {
                                Documento = reader["Documento"].ToString(),
                                RazonSocial = reader["RazonSocial"].ToString(),
                                Fecha = Convert.ToDateTime(reader["FechaUltimaCompra"].ToString()),
                                Precio = Convert.ToDecimal(reader["PrecioUltimaCompra"]),
                                Cantidad = Convert.ToDecimal(reader["CantidadUltimaCompra"]),
                                Total = Convert.ToDecimal(reader["TotalUltimaCompra"]),
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    compras = new List<DetalleProductos>();
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return compras;
        }
    }
}

using CapaEntidad.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Pedidos
    {
        public int ObtenerNroPedido()
        {
            int NroCorrelativo = 0;
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT COUNT(*) + 1 FROM Pedidos";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    NroCorrelativo = Convert.ToInt32(cmd.ExecuteScalar());

                }
                catch (Exception ex)
                {
                    NroCorrelativo = 0;
                    MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return NroCorrelativo;
        }

        public bool Registrar(Pedido obj, DataTable DetallePedido, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_pedido_insertar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@idProveedor", obj.IdProveedor);
                    cmd.Parameters.AddWithValue("@NumeroPedido", obj.NumeroPedido);
                    cmd.Parameters.AddWithValue("@TipoDocumento", obj.TipoDocumento);
                    cmd.Parameters.AddWithValue("@FormaPago", obj.FormaPago);
                    cmd.Parameters.AddWithValue("@Fecha", obj.Fecha);
                    cmd.Parameters.AddWithValue("@FechaRequerida", obj.FechaRequerida);
                    cmd.Parameters.AddWithValue("@Observacion", obj.Observacion);
                    cmd.Parameters.AddWithValue("@TotalPedido", obj.Total);
                    cmd.Parameters.AddWithValue("@idUsuario", obj.IdUsuario);
                    cmd.Parameters.AddWithValue("@Confirmado", obj.Confirmado);
                    cmd.Parameters.AddWithValue("@Anulado", obj.Anulado);
                    cmd.Parameters.AddWithValue("@DetallePedido", DetallePedido);
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

        public Pedido ObtenerPedido(int NroPedido)
        {
            Pedido objPedido = new Pedido();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT P.id, P.NumeroPedido, P.Fecha, P.FechaRequerida, E.Nombres, PR.id AS idProveedor, " +
                        "PR.Documento, PR.RazonSocial, T.Descripcion AS TipoDocumento, F.Descripcion AS FormaPago, " +
                        "P.Observacion, P.TotalPedido, P.Confirmado, P.Anulado" +
                        " FROM Pedidos P" +
                        " INNER JOIN Usuarios U ON P.idUsuario = U.id" +
                        " INNER JOIN Empleados E ON U.idEmpleado = E.id" +
                        " INNER JOIN Proveedores PR ON P.idProveedor = PR.id" +
                        " INNER JOIN TiposDocumentosCompra T ON P.idTipoDocumento = T.id" +
                        " INNER JOIN FormasPagos F ON P.idFormaPago = F.id" +
                        " WHERE P.NumeroPedido = " + NroPedido;

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            objPedido = new Pedido()
                            {
                                Id = Convert.ToInt32(reader["ID"]),
                                NumeroPedido = Convert.ToInt32(reader["NumeroPedido"]),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                FechaRequerida = Convert.ToDateTime(reader["FechaRequerida"]),
                                NombreUsuario = reader["Nombres"].ToString(),
                                IdProveedor = Convert.ToInt32(reader["idProveedor"]),
                                Documento = reader["Documento"].ToString(),
                                RazonSocial = reader["RazonSocial"].ToString(),
                                TipoDocumento = reader["TipoDocumento"].ToString(),
                                FormaPago = reader["FormaPago"].ToString(),
                                Observacion = reader["Observacion"].ToString(),
                                Total = Convert.ToDecimal(reader["TotalPedido"]),
                                Confirmado = Convert.ToBoolean(reader["Confirmado"]),
                                Anulado = Convert.ToBoolean(reader["Anulado"])
                            };                        
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return objPedido;
        }

        public List <DetalleProductos> ObtenerPedidoDetalle(int idPedido)
        {
            List<DetalleProductos> objDetalle = new List<DetalleProductos>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT P.id, PD.idProducto, P.Codigo, P.Descripcion, PD.Precio, PD.Cantidad, PD.Total" +
                        " FROM PedidosDetalles PD" +
                        " INNER JOIN Productos P ON PD.idProducto = P.id" +
                        " WHERE PD.idPedido = " + idPedido;

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            objDetalle.Add(new DetalleProductos
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                IdProducto = Convert.ToInt32(reader["idProducto"]),
                                Codigo = reader["Codigo"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                Precio = Convert.ToDecimal(reader["Precio"]),
                                Cantidad = Convert.ToDecimal(reader["Cantidad"]),
                                Total = Convert.ToDecimal(reader["Total"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    objDetalle = new List<DetalleProductos>();
                    MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return objDetalle;
        }

        public List<DetalleProductos> ObtenerProductos()
        {
            List<DetalleProductos> objDetalle = new List<DetalleProductos>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT id, Descripcion, 1 AS Precio, Existencia+ExistenciaMinima AS Cantidad, ((Existencia+ExistenciaMinima) * 1) AS Total " +
                        " FROM Productos WHERE Existencia <= ExistenciaMinima";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            objDetalle.Add(new DetalleProductos
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Descripcion = reader["Descripcion"].ToString(),
                                Precio = Convert.ToDecimal(reader["Precio"]),
                                Cantidad = Convert.ToDecimal(reader["Cantidad"]),
                                Total = Convert.ToDecimal(reader["Total"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    objDetalle = new List<DetalleProductos>();
                    MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return objDetalle;
        }

        public decimal ObtenerUltimoPrecio(int idProducto, int idProveedor)
        {
            decimal UltimoPrecio = 0;
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    con.Open();

                    StringBuilder query = new StringBuilder();
                    //query.AppendLine("SELECT PrecioUltimaCompra FROM HistoricoUltimasCompras ");
                    //query.AppendLine("WHERE idProducto =  @idProducto ");
                    //query.AppendLine(" AND idProveedor = @idProveedor");

                    query.AppendLine("SELECT Costo FROM Productos ");
                    query.AppendLine("WHERE id =  @idProducto ");

                    SqlCommand cmd = new SqlCommand(query.ToString(), con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    //cmd.Parameters.AddWithValue("@idProveedor", idProveedor);


                    UltimoPrecio = Convert.ToInt32(cmd.ExecuteScalar());

                }
                catch (Exception ex)
                {
                    UltimoPrecio = 0;
                    MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return UltimoPrecio;
        }

        public bool ConfirmarPedido(int NroPedido, out string Mensaje)
        {
            bool Respuesta = true;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {
                    con.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE Pedidos SET Confirmado = 1 ");
                    query.AppendLine("WHERE NumeroPedido =  @NroPedido");

                    SqlCommand cmd = new SqlCommand(query.ToString(), con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@NroPedido", NroPedido);

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        Mensaje = "No se pudo confirmar el pedido";
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

        public List<Pedido> Listar(int bandera)
        {
            List<Pedido> pedidos = new List<Pedido>();
            string query;

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    if(bandera == 0)
                    {
                        query = "SELECT P.id, NumeroPedido, P.Fecha, PR.Documento, PR.RazonSocial, P.TotalPedido, P.Confirmado, P.Anulado FROM Pedidos P " +
                        "INNER JOIN Proveedores PR ON P.idProveedor = PR.id";
                    }else
                    {
                        if (bandera == 1)
                        {
                            query = "SELECT P.id, NumeroPedido, P.Fecha, PR.Documento, PR.RazonSocial, P.TotalPedido, P.Confirmado, P.Anulado FROM Pedidos P " +
                                "INNER JOIN Proveedores PR ON P.idProveedor = PR.id WHERE Confirmado = 1 " +
                                "AND NOT EXISTS (SELECT * FROM Compras WHERE idPedido = P.id)";
                        }
                        else
                        {
                            query = "SELECT P.id, NumeroPedido, P.Fecha, PR.Documento, PR.RazonSocial, P.TotalPedido, P.Confirmado, P.Anulado FROM Pedidos P " +
                            "INNER JOIN Proveedores PR ON P.idProveedor = PR.id WHERE Confirmado = 0";
                        }
                    }
                    

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pedidos.Add(new Pedido
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                NumeroPedido = Convert.ToInt32(reader["NumeroPedido"]),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                Documento = reader["Documento"].ToString(),
                                RazonSocial = reader["RazonSocial"].ToString(),
                                Total = Convert.ToDecimal(reader["TotalPedido"]),
                                Confirmado = Convert.ToBoolean(reader["Confirmado"]),
                                Anulado = Convert.ToBoolean(reader["Anulado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    pedidos = new List<Pedido>();
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return pedidos;
        }

        public bool AnularPedido(int IdPedido, string MotivoAnulacion, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_pedido_anular", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@IdPedido", IdPedido);
                    cmd.Parameters.AddWithValue("@MotivoAnulacion", MotivoAnulacion);
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

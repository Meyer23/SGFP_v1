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
    public class CD_Compras
    {
        public bool Registrar(Compra obj, DataTable DetalleCompra, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_compra_insertar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@idProveedor", obj.IdProveedor);
                    cmd.Parameters.AddWithValue("@NumeroPedido", obj.NumeroPedido);
                    cmd.Parameters.AddWithValue("@TipoDocumento", obj.TipoDocumento);
                    cmd.Parameters.AddWithValue("@FormaPago", obj.FormaPago);
                    cmd.Parameters.AddWithValue("@Fecha", obj.Fecha);
                    cmd.Parameters.AddWithValue("@FechaVencimiento", obj.FechaVencimiento);
                    cmd.Parameters.AddWithValue("@Timbrado", obj.Timbrado);
                    cmd.Parameters.AddWithValue("@InicioVigencia", obj.InicioVigencia);
                    cmd.Parameters.AddWithValue("@FinVigencia", obj.FinVigencia);
                    cmd.Parameters.AddWithValue("@CodEstablecimiento", obj.CodEstablecimiento);
                    cmd.Parameters.AddWithValue("@PuntoEmision", obj.PuntoEmision);
                    cmd.Parameters.AddWithValue("@Doc", obj.Doc);
                    cmd.Parameters.AddWithValue("@Observacion", obj.Observacion);
                    cmd.Parameters.AddWithValue("@TotalCompra", obj.Total);
                    cmd.Parameters.AddWithValue("@idUsuario", obj.IdUsuario);
                    cmd.Parameters.AddWithValue("@Confirmado", obj.Confirmado);
                    cmd.Parameters.AddWithValue("@Anulado", obj.Anulado);
                    cmd.Parameters.AddWithValue("@DetalleCompra", DetalleCompra);
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

        public bool ConfirmarCompra(int IdCompra, DateTime FechaRec, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_compra_confirmar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@IdCompra", IdCompra);
                    cmd.Parameters.AddWithValue("@FechaRec", FechaRec);
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

        public List<Compra> Listar(int bandera)
        {
            List<Compra> compras = new List<Compra>();
            string query;

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    if (bandera == 0)
                    {
                        query = "SELECT C.id, C.NumeroFactura, C.Fecha, P.Documento, P.RazonSocial, C.TotalFactura FROM Compras C" +
                        " INNER JOIN Proveedores P ON C.idProveedor = P.id";
                    }
                    else
                    {
                        if (bandera == 1)
                        {
                            query = "SELECT C.id, C.NumeroFactura, C.Fecha, P.Documento, P.RazonSocial, C.TotalFactura FROM Compras C" +
                        " INNER JOIN Proveedores P ON C.idProveedor = P.id WHERE Confirmado = 0 AND Anulado = 0";
                        }
                        else
                        {
                            query = "SELECT C.id, C.NumeroFactura, C.Fecha, P.Documento, P.RazonSocial, C.TotalFactura FROM Compras C" +
                        " INNER JOIN Proveedores P ON C.idProveedor = P.id WHERE Confirmado = 1 AND Anulado = 0";
                        }
                    }


                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            compras.Add(new Compra
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                NumeroFactura = reader["NumeroFactura"].ToString(),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                Documento = reader["Documento"].ToString(),
                                RazonSocial = reader["RazonSocial"].ToString(),
                                Total = Convert.ToDecimal(reader["TotalFactura"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    compras = new List<Compra>();
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return compras;
        }

        public Compra ObtenerCompra(int IdCompra)
        {
            Compra objCompra = new Compra();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT C.id, C.NumeroFactura, ISNULL(P.NumeroPedido,0) AS NumeroPedido, T.Descripcion AS TipoDoc, F.Descripcion AS FormaPago, E.Nombres, " +
                        "C.CodigoEstablecimiento, C.PuntoEmision, C.Doc, C.Fecha, C.FechaVencimiento, C.Timbrado, C.InicioVigencia, C.FinVigencia, " +
                        "PR.Documento, PR.RazonSocial, C.Observacion, C.TotalFactura, C.Confirmado, C.Anulado " +
                        "FROM Compras C " +
                        "LEFT JOIN Pedidos P ON C.idPedido = P.id " +
                        "INNER JOIN TiposDocumentosCompra T ON C.idTipoDocumento = T.id " +
                        "INNER JOIN FormasPagos F ON C.idFormaPago = F.id " +
                        "INNER JOIN Usuarios U ON C.idUsuario = U.id " +
                        "INNER JOIN Empleados E ON U.idEmpleado = E.id " +
                        "INNER JOIN Proveedores PR ON C.idProveedor = PR.id " +
                        "WHERE C.id = " + IdCompra;

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            objCompra = new Compra()
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                NumeroFactura = reader["NumeroFactura"].ToString(),
                                NumeroPedido = Convert.ToInt32(reader["NumeroPedido"]),
                                TipoDocumento = reader["TipoDoc"].ToString(),
                                FormaPago = reader["FormaPago"].ToString(),
                                NombreUsuario = reader["Nombres"].ToString(),
                                CodEstablecimiento = Convert.ToInt32(reader["CodigoEstablecimiento"]),
                                PuntoEmision = Convert.ToInt32(reader["PuntoEmision"]),
                                Doc = reader["Doc"].ToString(),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                FechaVencimiento = Convert.ToDateTime(reader["FechaVencimiento"]),
                                Timbrado = Convert.ToInt32(reader["Timbrado"].ToString()),
                                InicioVigencia = Convert.ToDateTime(reader["InicioVigencia"]),
                                FinVigencia = Convert.ToDateTime(reader["FinVigencia"]),
                                Documento = reader["Documento"].ToString(),
                                RazonSocial = reader["RazonSocial"].ToString(),                                                             
                                Observacion = reader["Observacion"].ToString(),
                                Total = Convert.ToDecimal(reader["TotalFactura"]),
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
            return objCompra;
        }

        public List<DetalleProductos> ObtenerCompraDetalle(int idCompra)
        {
            List<DetalleProductos> objDetalle = new List<DetalleProductos>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT P.id, CD.idProducto, P.Descripcion, CD.Precio, CD.Cantidad, CD.Total " +
                        "FROM ComprasDetalles CD " +
                        "INNER JOIN Productos P ON CD.idProducto = P.id " +
                        "WHERE CD.idCompra = " + idCompra;

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

        public bool AnularCompra(int IdCompra, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_compra_anular", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@IdCompra", IdCompra);
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

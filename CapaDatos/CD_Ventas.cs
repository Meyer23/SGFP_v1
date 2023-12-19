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
    public class CD_Ventas
    {
        public Venta ObtenerVenta(int IdVenta)
        {
            Venta objVenta = new Venta();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT F.id, F.NumeroFactura, T.Descripcion AS TipoDoc, FP.Descripcion AS FormaPago, E.Nombres, C.id AS idCliente, " +
                        "F.CodigoEsteblecimiento, F.PuntoEmision, F.Doc, F.Fecha, F.FechaVencimiento, TI.id as Timbrado, TI.InicioVigencia, TI.FinVigencia, " +
                        "C.Documento, C.Nombre, F.TotalFactura, F.Anulado " +
                        "FROM Facturas F " +
                        "INNER JOIN TiposDocumentosCompra T ON F.IdTipo = T.id " +
                        "INNER JOIN FormasPagos FP ON F.idFormaPago = FP.id " +
                        "INNER JOIN Usuarios U ON F.idUsuario = U.id " +
                        "INNER JOIN Empleados E ON U.idEmpleado = E.id " +
                        "INNER JOIN Clientes C ON F.idCliente = C.id " +
                        "INNER JOIN Timbrados TI ON F.idTimbrado = TI.id " +
                        "WHERE F.id = " + IdVenta;

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            objVenta = new Venta()
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                NumeroFactura = reader["NumeroFactura"].ToString(),
                                TipoDocumento = reader["TipoDoc"].ToString(),
                                FormaPago = reader["FormaPago"].ToString(),
                                NombreCajero = reader["Nombres"].ToString(),
                                CodEstablecimiento = Convert.ToInt32(reader["CodigoEsteblecimiento"]),
                                PuntoEmision = Convert.ToInt32(reader["PuntoEmision"]),
                                Doc = reader["Doc"].ToString(),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                FechaVencimiento = Convert.ToDateTime(reader["FechaVencimiento"]),
                                Timbrado = Convert.ToInt32(reader["Timbrado"].ToString()),
                                InicioVigencia = Convert.ToDateTime(reader["InicioVigencia"]),
                                FinVigencia = Convert.ToDateTime(reader["FinVigencia"]),
                                IdCliente = Convert.ToInt32(reader["idCliente"]),
                                Documento = reader["Documento"].ToString(),
                                Nombre = reader["Nombre"].ToString(),
                                Total = Convert.ToDecimal(reader["TotalFactura"]),
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
            return objVenta;
        }

        public List<DetalleProductos> ObtenerVentaDetalle(int idVenta)
        {
            List<DetalleProductos> objDetalle = new List<DetalleProductos>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT P.id, FD.idProducto, P.Codigo, P.Descripcion, CONVERT(INT,FD.PrecioUnitario) AS PrecioUnitario, CONVERT(INT,FD.Cantidad) AS Cantidad, CONVERT(INT,FD.Total) AS Total " +
                        "FROM FacturasDetalles FD " +
                        "INNER JOIN Productos P ON FD.idProducto = P.id " +
                        "WHERE FD.idFactura = " + idVenta;

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
                                Precio = Convert.ToDecimal(reader["PrecioUnitario"]),
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

        public List<Venta> Listar()
        {
            List<Venta> ventas = new List<Venta>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    
                    string query = "SELECT F.id, F.NumeroFactura, F.Fecha, C.Documento, C.Nombre, F.TotalFactura, F.Anulado FROM Facturas F " +
                        "INNER JOIN Clientes C ON F.idCliente = C.id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ventas.Add(new Venta
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                NumeroFactura = reader["NumeroFactura"].ToString(),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                Documento = reader["Documento"].ToString(),
                                Nombre = reader["Nombre"].ToString(),
                                Total = Convert.ToDecimal(reader["TotalFactura"]),
                                Anulado = Convert.ToBoolean(reader["Anulado"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    ventas = new List<Venta>();
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return ventas;
        }

        public bool AnularVenta(int IdVenta, string MotivoAnulacion, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_venta_anular", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@IdVenta", IdVenta);
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

        public int Registrar(Venta objVenta, DataTable detalle_venta, DataTable datosDetallesCobro, out string Mensaje)
        {
            int Respuesta = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_venta_insertar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@idCliente", objVenta.IdCliente);
                    cmd.Parameters.AddWithValue("@FechaVenta", objVenta.Fecha);
                    cmd.Parameters.AddWithValue("@FormaPago", objVenta.FormaPago);
                    cmd.Parameters.AddWithValue("@FechaVencimiento", objVenta.FechaVencimiento);
                    cmd.Parameters.AddWithValue("@Timbrado", objVenta.Timbrado);
                    cmd.Parameters.AddWithValue("@CodEstablecimiento", objVenta.CodEstablecimiento);
                    cmd.Parameters.AddWithValue("@PuntoEmision", objVenta.PuntoEmision);
                    cmd.Parameters.AddWithValue("@TipoDocumento", objVenta.TipoDocumento);
                    cmd.Parameters.AddWithValue("@Doc", objVenta.Doc);
                    cmd.Parameters.AddWithValue("@TotalCompra", objVenta.Total);
                    cmd.Parameters.AddWithValue("@idUsuario", objVenta.IdCajero);
                    cmd.Parameters.AddWithValue("@VentaDetalle", detalle_venta);
                    cmd.Parameters.AddWithValue("@CobroDetalle", datosDetallesCobro);
                    cmd.Parameters.Add("@idFactura", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToInt32(cmd.Parameters["@idFactura"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Respuesta = 0;
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Respuesta;
        }
    }
}

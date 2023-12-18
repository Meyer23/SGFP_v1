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
    public class CD_NotasCreditoEmitidas
    {
        public bool Registrar(NotaCreditoEmitida obj, DataTable DetalleNota, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_notaCreditoEmitida_insertar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@idCliente", obj.IdCliente);
                    cmd.Parameters.AddWithValue("@idVenta", obj.idVenta);
                    cmd.Parameters.AddWithValue("@TipoDocumento", obj.TipoDocumento);
                    cmd.Parameters.AddWithValue("@Fecha", obj.Fecha);
                    cmd.Parameters.AddWithValue("@Timbrado", obj.Timbrado);
                    cmd.Parameters.AddWithValue("@CodEstablecimiento", obj.CodEstablecimiento);
                    cmd.Parameters.AddWithValue("@PuntoEmision", obj.PuntoEmision);
                    cmd.Parameters.AddWithValue("@Doc", obj.Doc);
                    cmd.Parameters.AddWithValue("@Observacion", obj.Observacion);
                    cmd.Parameters.AddWithValue("@TotalNota", obj.Total);
                    cmd.Parameters.AddWithValue("@idUsuario", obj.IdCajero);
                    cmd.Parameters.AddWithValue("@Confirmado", obj.Confirmado);
                    cmd.Parameters.AddWithValue("@Anulado", obj.Anulado);
                    cmd.Parameters.AddWithValue("@DetalleNota", DetalleNota);
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

        public List<NotaCreditoEmitida> Listar(int bandera)
        {
            List<NotaCreditoEmitida> notasCredito = new List<NotaCreditoEmitida>();
            string query;

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    if (bandera == 0)
                    {
                        query = "SELECT N.id, N.NumeroNota, N.Fecha, P.Documento, P.Nombre + ' - ' + P.Apellidos AS RazonSocial, N.TotalNota, N.Confirmado, N.Anulado FROM NotasCreditoEmitidas N " +
                            "INNER JOIN Clientes P ON N.idCliente = P.id";
                    }
                    else
                    {
                        if (bandera == 1)
                        {
                            query = "SELECT N.id, N.NumeroNota, N.Fecha, P.Documento, P.Nombre + ' - ' + P.Apellidos AS RazonSocial, N.TotalNota, N.Confirmado, N.Anulado FROM NotasCreditoEmitidas N " +
                                "INNER JOIN Clientes P ON N.idCliente = P.id WHERE Confirmado = 0 AND Anulado = 0";
                        }
                        else
                        {
                            query = "SELECT N.id, N.NumeroNota, N.Fecha, P.Documento, P.Nombre + ' - ' + P.Apellidos AS RazonSocial, N.TotalNota, N.Confirmado, N.Anulado FROM NotasCreditoEmitidas N " +
                                "INNER JOIN Clientes P ON N.idCliente = P.id WHERE Confirmado = 1 AND Anulado = 0";
                        }
                    }


                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            notasCredito.Add(new NotaCreditoEmitida
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                NumeroNota = reader["NumeroNota"].ToString(),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                Documento = reader["Documento"].ToString(),
                                Nombre = reader["RazonSocial"].ToString(),
                                Total = Convert.ToDecimal(reader["TotalNota"]),
                                Confirmado = Convert.ToBoolean(reader["Confirmado"]),
                                Anulado = Convert.ToBoolean(reader["Anulado"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    notasCredito = new List<NotaCreditoEmitida>();
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return notasCredito;
        }

        public NotaCreditoEmitida ObtenerNota(int IdNCEmitida)
        {
            NotaCreditoEmitida objNCEmitida = new NotaCreditoEmitida();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT N.id, N.NumeroNota, ISNULL(F.NumeroFactura,'') AS NumeroFactura, N.idVenta, T.Descripcion AS TipoDoc, E.Nombres, " +
                        "N.CodigoEstablecimiento, N.PuntoEmision, N.Doc, N.Fecha, TI.NroTimbrado AS Timbrado, TI.InicioVigencia, TI.FinVigencia, " +
                        "C.Documento, C.Nombre + ' - ' + C.Apellidos AS RazonSocial, N.Observacion, N.TotalNota, N.Confirmado, N.Anulado " +
                        "FROM NotasCreditoEmitidas N " +
                        "LEFT JOIN Facturas F ON N.idVenta = F.id " +
                        "INNER JOIN TiposDocumentosCompra T ON N.idTipoDocumento = T.id " +
                        "INNER JOIN Usuarios U ON N.idUsuario = U.id " +
                        "INNER JOIN Empleados E ON U.idEmpleado = E.id " +
                        "INNER JOIN Clientes C ON N.idCliente = C.id " +
                        "INNER JOIN Timbrados TI ON N.idTimbrado = T.id " +
                        "WHERE N.id = " + IdNCEmitida;

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            objNCEmitida = new NotaCreditoEmitida()
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                NumeroNota = reader["NumeroNota"].ToString(),
                                NumeroFactura = reader["NumeroFactura"].ToString(),
                                idVenta = Convert.ToInt32(reader["idVenta"]),
                                TipoDocumento = reader["TipoDoc"].ToString(),
                                NombreCajero = reader["Nombres"].ToString(),
                                CodEstablecimiento = Convert.ToInt32(reader["CodigoEstablecimiento"]),
                                PuntoEmision = Convert.ToInt32(reader["PuntoEmision"]),
                                Doc = reader["Doc"].ToString(),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                Timbrado = Convert.ToInt32(reader["Timbrado"].ToString()),
                                InicioVigencia = Convert.ToDateTime(reader["InicioVigencia"]),
                                FinVigencia = Convert.ToDateTime(reader["FinVigencia"]),
                                Documento = reader["Documento"].ToString(),
                                Nombre = reader["RazonSocial"].ToString(),
                                Observacion = reader["Observacion"].ToString(),
                                Total = Convert.ToDecimal(reader["TotalNota"]),
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
            return objNCEmitida;
        }

        public List<DetalleProductos> ObtenerNotaDetalle(int idNCEmitida)
        {
            List<DetalleProductos> objDetalle = new List<DetalleProductos>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT P.id, ND.idProducto, P.Codigo, P.Descripcion, CONVERT(INT,ND.Precio) AS Precio, CONVERT(INT,ND.Cantidad) AS Cantidad, CONVERT(INT,ND.Total) AS Total " +
                        "FROM NotasCreditoEmitidasDetalles ND " +
                        "INNER JOIN Productos P ON ND.idProducto = P.id " +
                        "WHERE ND.idNCEmitida = " + idNCEmitida;

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

        public bool ConfirmarNota(int IdNCEmitida, int IdVenta, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_notaCreditoEmitida_confirmar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@IdNCEmitida", IdNCEmitida);
                    cmd.Parameters.AddWithValue("@IdVenta", IdVenta);
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

        public bool AnularNota(int idNCEmitida, string MotivoAnulacion, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_notaCreditoEmitida_anular", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@idNCEmitida", idNCEmitida);
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

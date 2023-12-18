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
    public class CD_NotasCreditoRecibidas
    {
        public bool Registrar(NotaCreditoRecibida obj, DataTable DetalleNota, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_notaCreditoRecibida_insertar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@idProveedor", obj.IdProveedor);
                    cmd.Parameters.AddWithValue("@idCompra", obj.idCompra);
                    cmd.Parameters.AddWithValue("@TipoDocumento", obj.TipoDocumento);
                    cmd.Parameters.AddWithValue("@Fecha", obj.Fecha);
                    cmd.Parameters.AddWithValue("@Timbrado", obj.Timbrado);
                    cmd.Parameters.AddWithValue("@InicioVigencia", obj.InicioVigencia);
                    cmd.Parameters.AddWithValue("@FinVigencia", obj.FinVigencia);
                    cmd.Parameters.AddWithValue("@CodEstablecimiento", obj.CodEstablecimiento);
                    cmd.Parameters.AddWithValue("@PuntoEmision", obj.PuntoEmision);
                    cmd.Parameters.AddWithValue("@Doc", obj.Doc);
                    cmd.Parameters.AddWithValue("@Observacion", obj.Observacion);
                    cmd.Parameters.AddWithValue("@TotalNota", obj.Total);
                    cmd.Parameters.AddWithValue("@idUsuario", obj.IdUsuario);
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

        public bool ConfirmarNota(int IdNCRecibida, int IdCompra, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_notaCreditoRecibida_confirmar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@idNCRecibida", IdNCRecibida);
                    cmd.Parameters.AddWithValue("@idCompra", IdCompra);
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

        public List<NotaCreditoRecibida> Listar(int bandera)
        {
            List<NotaCreditoRecibida> notasCredito = new List<NotaCreditoRecibida>();
            string query;

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    if (bandera == 0)
                    {
                        query = "SELECT N.id, N.NumeroNota, N.Fecha, P.Documento, P.RazonSocial, N.TotalNota, N.Confirmado, N.Anulado FROM NotasCreditoRecibidas N" +
                        " INNER JOIN Proveedores P ON N.idProveedor = P.id";
                    }
                    else
                    {
                        if (bandera == 1)
                        {
                            query = "SELECT N.id, N.NumeroNota, N.Fecha, P.Documento, P.RazonSocial, N.TotalNota, N.Confirmado, N.Anulado FROM NotasCreditoRecibidas N" +
                        " INNER JOIN Proveedores P ON N.idProveedor = P.id WHERE Confirmado = 0 AND Anulado = 0";
                        }
                        else
                        {
                            query = "SELECT N.id, N.NumeroNota, N.Fecha, P.Documento, P.RazonSocial, N.TotalNota, N.Confirmado, N.Anulado FROM NotasCreditoRecibidas N" +
                        " INNER JOIN Proveedores P ON N.idProveedor = P.id WHERE Confirmado = 1 AND Anulado = 0";
                        }
                    }


                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            notasCredito.Add(new NotaCreditoRecibida
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                NumeroNota = reader["NumeroNota"].ToString(),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                Documento = reader["Documento"].ToString(),
                                RazonSocial = reader["RazonSocial"].ToString(),
                                Total = Convert.ToDecimal(reader["TotalNota"]),
                                Confirmado = Convert.ToBoolean(reader["Confirmado"]),
                                Anulado = Convert.ToBoolean(reader["Anulado"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    notasCredito = new List<NotaCreditoRecibida>();
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return notasCredito;
        }

        public NotaCreditoRecibida ObtenerNota(int IdNCRecibida)
        {
            NotaCreditoRecibida objNCRecibida = new NotaCreditoRecibida();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT N.id, N.NumeroNota, ISNULL(P.NumeroFactura,'') AS NumeroFactura, N.idCompra, T.Descripcion AS TipoDoc, E.Nombres, " +
                        "N.CodigoEstablecimiento, N.PuntoEmision, N.Doc, N.Fecha, N.Timbrado, N.InicioVigencia, N.FinVigencia, " +
                        "PR.Documento, PR.RazonSocial, N.Observacion, N.TotalNota, N.Confirmado, N.Anulado " +
                        "FROM NotasCreditoRecibidas N " +
                        "LEFT JOIN Compras P ON N.idCompra = P.id " +
                        "INNER JOIN TiposDocumentosCompra T ON N.idTipoDocumento = T.id " +
                        "INNER JOIN Usuarios U ON N.idUsuario = U.id " +
                        "INNER JOIN Empleados E ON U.idEmpleado = E.id " +
                        "INNER JOIN Proveedores PR ON N.idProveedor = PR.id " +
                        "WHERE N.id = " + IdNCRecibida;

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            objNCRecibida = new NotaCreditoRecibida()
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                NumeroNota = reader["NumeroNota"].ToString(),
                                NumeroFactura = reader["NumeroFactura"].ToString(),
                                idCompra = Convert.ToInt32(reader["idCompra"]),
                                TipoDocumento = reader["TipoDoc"].ToString(),
                                NombreUsuario = reader["Nombres"].ToString(),
                                CodEstablecimiento = Convert.ToInt32(reader["CodigoEstablecimiento"]),
                                PuntoEmision = Convert.ToInt32(reader["PuntoEmision"]),
                                Doc = reader["Doc"].ToString(),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                Timbrado = Convert.ToInt32(reader["Timbrado"].ToString()),
                                InicioVigencia = Convert.ToDateTime(reader["InicioVigencia"]),
                                FinVigencia = Convert.ToDateTime(reader["FinVigencia"]),
                                Documento = reader["Documento"].ToString(),
                                RazonSocial = reader["RazonSocial"].ToString(),
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
            return objNCRecibida;
        }

        public List<DetalleProductos> ObtenerNotaDetalle(int idNCRecibida)
        {
            List<DetalleProductos> objDetalle = new List<DetalleProductos>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT P.id, ND.idProducto, P.Codigo, P.Descripcion, CONVERT(INT,ND.Precio) AS Precio, CONVERT(INT,ND.Cantidad) AS Cantidad, CONVERT(INT,ND.Total) AS Total " +
                        "FROM NotasCreditoRecibidasDetalles ND " +
                        "INNER JOIN Productos P ON ND.idProducto = P.id " +
                        "WHERE ND.idNCRecibida = " + idNCRecibida;

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

        public bool AnularNota(int idNCRecibida, string MotivoAnulacion, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_notaCreditoRecibida_anular", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@idNCRecibida", idNCRecibida);
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

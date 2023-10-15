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
                    string query = "SELECT P.id, P.NumeroPedido, P.Fecha, P.FechaRequerida, E.Nombres, " +
                        "PR.Documento, PR.RazonSocial, T.Descripcion AS TipoDocumento, F.Descripcion AS FormaPago, " +
                        "P.Observacion, P.TotalPedido, P.Confirmado" +
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
                                Documento = reader["Documento"].ToString(),
                                RazonSocial = reader["RazonSocial"].ToString(),
                                TipoDocumento = reader["TipoDocumento"].ToString(),
                                FormaPago = reader["FormaPago"].ToString(),
                                Observacion = reader["Observacion"].ToString(),
                                Total = Convert.ToDecimal(reader["TotalPedido"]),
                                Confirmado = Convert.ToBoolean(reader["Confirmado"])
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

        public List <PedidoDetalle> ObtenerPedidoDetalle(int idPedido)
        {
            List<PedidoDetalle> objDetalle = new List<PedidoDetalle>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT P.id, P.Descripcion, PD.Precio, PD.Cantidad, PD.Total" +
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
                            objDetalle.Add(new PedidoDetalle
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
                    objDetalle = new List<PedidoDetalle>();
                    MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return objDetalle;
        }

    }
}

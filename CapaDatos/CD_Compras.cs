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
                    cmd.Parameters.AddWithValue("@CodEstablecimiento", obj.CodEstablecimiento);
                    cmd.Parameters.AddWithValue("@PuntoEmision", obj.PuntoEmision);
                    cmd.Parameters.AddWithValue("@Doc", obj.Doc);
                    cmd.Parameters.AddWithValue("@Observacion", obj.Observacion);
                    cmd.Parameters.AddWithValue("@TotalCompra", obj.Total);
                    cmd.Parameters.AddWithValue("@idUsuario", obj.IdUsuario);
                    cmd.Parameters.AddWithValue("@Confirmado", obj.Confirmado);
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

        public bool ConfirmarCompra(int IdCompra, out string Mensaje)
        {
            bool Respuesta = true;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {
                    con.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE Compras SET Confirmado = 1 ");
                    query.AppendLine("WHERE id =  @IdCompra");

                    SqlCommand cmd = new SqlCommand(query.ToString(), con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@IdCompra", IdCompra);

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        Mensaje = "No se pudo confirmar la compra";
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

        public List<Compra> Listar()
        {
            List<Compra> compras = new List<Compra>();
            

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT C.id, C.NumeroFactura, C.Fecha, P.Documento, P.RazonSocial, C.TotalFactura FROM Compras C" +
                        " INNER JOIN Proveedores P ON C.idProveedor = P.id";


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
    }
}

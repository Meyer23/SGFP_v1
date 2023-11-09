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
    public class CD_MovimientosStock
    {
        public bool Registrar(MovimientoStock obj, DataTable DetalleMovimiento, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_movimientoStock_insertar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@TipoMovimiento", obj.TipoMovimiento);
                    cmd.Parameters.AddWithValue("@Documento", obj.Documento);
                    cmd.Parameters.AddWithValue("@Fecha", obj.Fecha);
                    cmd.Parameters.AddWithValue("@Observacion", obj.Observacion);
                    cmd.Parameters.AddWithValue("@Total", obj.Total);
                    cmd.Parameters.AddWithValue("@idUsuario", obj.IdUsuario);
                    cmd.Parameters.AddWithValue("@Confirmado", obj.Confirmado);
                    cmd.Parameters.AddWithValue("@DetalleMovimiento", DetalleMovimiento);
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

        public List<MovimientoStock> Listar(int bandera)
        {
            List<MovimientoStock> listaMovStock = new List<MovimientoStock>();
            string query;

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    if (bandera == 0)
                    {
                        query = "SELECT id, IIF(TipoMovimiento=0,'ENTRADA','SALIDA') AS TipoMovimiento, Documento, Fecha, Total FROM MovimientosStock";
                    }
                    else
                    {
                        if (bandera == 1)
                        {
                            query = "SELECT id, IIF(TipoMovimiento=0,'ENTRADA','SALIDA') AS TipoMovimiento, Documento, Fecha, Total FROM MovimientosStock WHERE Confirmado = 0";
                        }
                        else
                        {
                            query = "SELECT id, IIF(TipoMovimiento=0,'ENTRADA','SALIDA') AS TipoMovimiento, Documento, Fecha, Total FROM MovimientosStock WHERE Confirmado = 1";
                        }
                    }


                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaMovStock.Add(new MovimientoStock
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                TipoMovimiento = reader["TipoMovimiento"].ToString(),
                                Documento = reader["Documento"].ToString(),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                Total = Convert.ToDecimal(reader["TotalPedido"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    listaMovStock = new List<MovimientoStock>();
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return listaMovStock;
        }

        public bool ConfirmarMovStock(int idMovStock, out string Mensaje)
        {
            bool Respuesta = true;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {
                    con.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE MovimientosStock SET Confirmado = 1 ");
                    query.AppendLine("WHERE id =  @idMovStock");

                    SqlCommand cmd = new SqlCommand(query.ToString(), con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@idMovStock", idMovStock);

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        Mensaje = "No se pudo confirmar el movimiento stock";
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
    }
}

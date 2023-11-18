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
                    cmd.Parameters.AddWithValue("@Anulado", obj.Anulado);
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
                            query = "SELECT id, IIF(TipoMovimiento=0,'ENTRADA','SALIDA') AS TipoMovimiento, Documento, Fecha, Total FROM MovimientosStock WHERE Confirmado = 0 AND Anulado = 0";
                        }
                        else
                        {
                            query = "SELECT id, IIF(TipoMovimiento=0,'ENTRADA','SALIDA') AS TipoMovimiento, Documento, Fecha, Total FROM MovimientosStock WHERE Confirmado = 1 AND Anulado = 0";
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
                                Total = Convert.ToDecimal(reader["Total"])
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

        public bool ConfirmarMovStock(int idMovStock, string TipoMovimiento, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_movimientoStock_confirmar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@idMovStock", idMovStock);
                    cmd.Parameters.AddWithValue("@TipoMovimiento", TipoMovimiento); 
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

        public bool AnularMovStock(int IdMovStock, string TipoMovimiento, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_movimientoStock_anular", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@IdMovStock", IdMovStock);
                    cmd.Parameters.AddWithValue("@TipoMovimiento", TipoMovimiento);
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

        public MovimientoStock ObtenerMovStock(int IdMovStock)
        {
            MovimientoStock objMovStock = new MovimientoStock();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT M.id, M.Documento, IIF(M.TipoMovimiento = 0, 'ENTRADA', 'SALIDA') AS TipoMovimiento, M.Fecha, M.Observacion, M.Total, M.Confirmado, M.Anulado, E.Nombres" +
                        " FROM MovimientosStock M" +
                        " INNER JOIN Usuarios U ON M.idUsuario = U.id" +
                        " INNER JOIN Empleados E ON U.idEmpleado = E.id" +
                        " WHERE M.id = " + IdMovStock;

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            objMovStock = new MovimientoStock()
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Documento = reader["Documento"].ToString(),
                                TipoMovimiento = reader["TipoMovimiento"].ToString(),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                Observacion = reader["Observacion"].ToString(),
                                Total = Convert.ToDecimal(reader["Total"]),
                                Confirmado = Convert.ToBoolean(reader["Confirmado"]),
                                Anulado = Convert.ToBoolean(reader["Anulado"]),
                                NombreUsuario = reader["Nombres"].ToString()                              
                            };
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return objMovStock;
        }

        public List<DetalleProductos> ObtenerMovStockDetalle(int IdMovStock)
        {
            List<DetalleProductos> objDetalle = new List<DetalleProductos>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT MD.id, MD.idProducto, P.Descripcion, MD.Cantidad" +
                        " FROM MovimientosStockDetalles MD " +
                        " INNER JOIN Productos P ON MD.idProducto = P.id" +
                        " WHERE MD.idMovimientoStock = 0" + IdMovStock;

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
                                Cantidad = Convert.ToDecimal(reader["Cantidad"]),
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

        public decimal ObtenerExistencia(int idProducto)
        {
            decimal existencia = 0;
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    con.Open();

                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT Existencia FROM Productos ");
                    query.AppendLine("WHERE id =  @idProducto ");

                    SqlCommand cmd = new SqlCommand(query.ToString(), con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@idProducto", idProducto);

                    existencia = Convert.ToInt32(cmd.ExecuteScalar());

                }
                catch (Exception ex)
                {
                    existencia = 0;
                    MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return existencia;
        }
    }
}

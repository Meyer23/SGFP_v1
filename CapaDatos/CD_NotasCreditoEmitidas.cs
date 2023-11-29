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
                    cmd.Parameters.AddWithValue("@idTimbrado", obj.Timbrado);
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
    }
}

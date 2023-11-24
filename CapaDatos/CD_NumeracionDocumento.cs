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
    public class CD_NumeracionDocumento
    {
        public int GuardarNumeracionDocumento(NumeracionDocumento obj, out string Mensaje)
        {
            int idNumeracionDocumento = 0;

            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_numeracion_documento_insertar_nuevo", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@CodigoEstablecimiento", obj.CodigoEstablecimiento);
                    cmd.Parameters.AddWithValue("@PuntoEmision", obj.PuntoEmision);
                    cmd.Parameters.AddWithValue("@UltimoNro", obj.UltimoNumero);
                    cmd.Parameters.AddWithValue("@NroTimbrado", obj.NroTimbrado);
                    cmd.Parameters.AddWithValue("@DescripcionCaja", obj.DescripcionCaja);
                    cmd.Parameters.Add("@idNumeracionDocumento", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    idNumeracionDocumento = Convert.ToInt32(cmd.Parameters["@idNumeracionDocumento"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idNumeracionDocumento = 0;
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return idNumeracionDocumento;
        }

        public List<NumeracionDocumento> Listar()
        {
            List<NumeracionDocumento> numeracionDocumentos = new List<NumeracionDocumento>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "select n.id, n.CodigoEstablecimiento, t.NroTimbrado NroTimbrado, t.Id, n.PuntoEmision, n.UltimoNro, n.idTimbrado, n.idCaja from dbo.NumeracionDocumento n " +
                        " inner join dbo.Timbrados t" +
                        " on t.id = n.idTimbrado;";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            numeracionDocumentos.Add(new NumeracionDocumento
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                DescripcionCaja = reader["idCaja"].ToString(),
                                PuntoEmision = Convert.ToInt32(reader["PuntoEmision"].ToString()),
                                CodigoEstablecimiento = reader["CodigoEstablecimiento"].ToString(),
                                UltimoNumero = Convert.ToInt32(reader["UltimoNro"].ToString()),
                                IdTimbrado = Convert.ToInt32(reader["Id"]),
                                NroTimbrado = Convert.ToInt32(reader["NroTimbrado"].ToString())
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return numeracionDocumentos;
        }
    }
}
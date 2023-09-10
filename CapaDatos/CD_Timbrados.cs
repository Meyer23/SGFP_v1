using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Timbrados
    {
        public List<Timbrado> Listar()
        {
            List<Timbrado> timbrados = new List<Timbrado>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT id, NroTimbrado, InicioVigencia, FinVigencia, NroDesde, NroHasta, Activo FROM Timbrados";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            timbrados.Add(new Timbrado
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                NroTimbrado = Convert.ToInt32(reader["NroTimbrado"]),
                                InicioVigencia = Convert.ToDateTime(reader["InicioVigencia"]),
                                FinVigencia = Convert.ToDateTime(reader["FinVigencia"]),
                                NroDesde = Convert.ToInt32(reader["NroDesde"]),
                                NroHasta = Convert.ToInt32(reader["NroHasta"]),
                                Activo = Convert.ToBoolean(reader["Activo"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    timbrados = new List<Timbrado>();
                }
            }
            return timbrados;
        }

        public int Registrar(Timbrado obj, out string Mensaje)
        {
            int IdTimbrado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_timbrado_insertar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@NroTimbrado", obj.NroTimbrado);
                    cmd.Parameters.AddWithValue("@InicioVigencia", obj.InicioVigencia);
                    cmd.Parameters.AddWithValue("@FinVigencia", obj.FinVigencia);
                    cmd.Parameters.AddWithValue("@NroDesde", obj.NroDesde);
                    cmd.Parameters.AddWithValue("@NroHasta", obj.NroHasta);
                    cmd.Parameters.AddWithValue("@Activo", obj.Activo);
                    cmd.Parameters.Add("@IdTimbrado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    IdTimbrado = Convert.ToInt32(cmd.Parameters["@IdTimbrado"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].ToString();
                }
            }
            catch (Exception ex)
            {
                IdTimbrado = 0;
                Mensaje = ex.Message;
            }
            return IdTimbrado;
        }

        public bool Editar(Timbrado obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_timbrado_editar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@idTimbrado", obj.Id);
                    cmd.Parameters.AddWithValue("@NroTimbrado", obj.NroTimbrado);
                    cmd.Parameters.AddWithValue("@InicioVigencia", obj.InicioVigencia);
                    cmd.Parameters.AddWithValue("@FinVigencia", obj.FinVigencia);
                    cmd.Parameters.AddWithValue("@NroDesde", obj.NroDesde);
                    cmd.Parameters.AddWithValue("@NroHasta", obj.NroHasta);
                    cmd.Parameters.AddWithValue("@Activo", obj.Activo);
                    cmd.Parameters.Add("@Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["@Respuesta"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].ToString();
                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }

            return Respuesta;
        }
    }
}

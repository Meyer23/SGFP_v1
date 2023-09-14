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
    public class CD_Impuestos
    {
        public List<Impuesto> Listar()
        {
            List<Impuesto> Impuestos = new List<Impuesto>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT id, TipoImpuesto, Descripcion, PorcIVA, FactorGravada, FactorIVA, Activo FROM Impuestos";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Impuestos.Add(new Impuesto
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                TipoImpuesto = Convert.ToInt32(reader["TipoImpuesto"]),
                                Descripcion = reader["Descripcion"].ToString(),
                                PorcIVA = Convert.ToDecimal(reader["PorcIVA"]),
                                FactorGravada = Convert.ToDecimal(reader["FactorGravada"]),
                                FactorIVA = Convert.ToDecimal(reader["FactorIVA"]),
                                Activo = Convert.ToBoolean(reader["Activo"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    Impuestos = new List<Impuesto>();
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return Impuestos;
        }

        public int Registrar(Impuesto obj, out string Mensaje)
        {
            int IdImpuesto = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_impuesto_insertar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@TipoImpuesto", obj.TipoImpuesto);
                    cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("@PorcIVA", obj.PorcIVA);
                    cmd.Parameters.AddWithValue("@FactorGravada", obj.FactorGravada);
                    cmd.Parameters.AddWithValue("@FactorIVA", obj.FactorIVA);
                    cmd.Parameters.AddWithValue("@Activo", obj.Activo);
                    cmd.Parameters.Add("@IdImpuesto", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    IdImpuesto = Convert.ToInt32(cmd.Parameters["@IdImpuesto"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                IdImpuesto = 0;
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return IdImpuesto;
        }

        public bool Editar(Impuesto obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_impuesto_editar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@idImpuesto", obj.Id);
                    cmd.Parameters.AddWithValue("@TipoImpuesto", obj.TipoImpuesto);
                    cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("@PorcIVA", obj.PorcIVA);
                    cmd.Parameters.AddWithValue("@FactorGravada", obj.FactorGravada);
                    cmd.Parameters.AddWithValue("@FactorIVA", obj.FactorIVA);
                    cmd.Parameters.AddWithValue("@Activo", obj.Activo);
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

        public List<Impuesto> ObtenerImpuestos()
        {
            List<Impuesto> impuestos = new List<Impuesto>();
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT Descripcion FROM Impuestos WHERE Activo = 1";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            impuestos.Add(new Impuesto
                            {
                                Descripcion = reader["Descripcion"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return impuestos;
            }
        }
    }
}

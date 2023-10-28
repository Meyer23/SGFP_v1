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
    public class CD_TiposDocumentos
    {
        public List<TipoDocumento> Listar()
        {
            List<TipoDocumento> tiposDocumentos = new List<TipoDocumento>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT id, Descripcion, TipoCodigo, Activo FROM TiposDocumentosCompra WHERE Activo = 1";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tiposDocumentos.Add(new TipoDocumento
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Descripcion = reader["Descripcion"].ToString(),
                                TipoCodigo = Convert.ToBoolean(reader["TipoCodigo"]),
                                Activo = Convert.ToBoolean(reader["Activo"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    tiposDocumentos = new List<TipoDocumento>();
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return tiposDocumentos;
        }

        public int Registrar(TipoDocumento obj, out string Mensaje)
        {
            int IdTipoDocumento = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_tipoDocumento_insertar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("@TipoCodigo", obj.TipoCodigo);
                    cmd.Parameters.AddWithValue("@Activo", obj.Activo);
                    cmd.Parameters.Add("@IdTipoDocumento", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    IdTipoDocumento = Convert.ToInt32(cmd.Parameters["@IdTipoDocumento"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                IdTipoDocumento = 0;
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return IdTipoDocumento;
        }

        public bool Editar(TipoDocumento obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_tipoDocumento_editar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@IdTipoDocumento", obj.Id);
                    cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("@TipoCodigo", obj.TipoCodigo);
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

        public List<TipoDocumento> ObtenerTiposDocumentos()
        {
            List<TipoDocumento> tiposDocumentos = new List<TipoDocumento>();
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT Descripcion FROM TiposDocumentosCompra WHERE Activo = 1";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tiposDocumentos.Add(new TipoDocumento
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
                return tiposDocumentos;
            }
        }

        public bool InsertarFormasPago(int idTipoDoc)
        {
            bool Respuesta = false;
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_tiposDoc_formasPago_insertar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@idTipoDoc", idTipoDoc);
                    cmd.Parameters.Add("@Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    Respuesta = Convert.ToBoolean(cmd.Parameters["@Respuesta"].Value);
                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Respuesta;
        }

        public bool EditarFormasPago(int IdTipoDoc, int IdFormaPago, bool Acepta)
        {
            bool Respuesta = false;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_tiposDoc_formasPago_editar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@idTipoDoc", IdTipoDoc);
                    cmd.Parameters.AddWithValue("@idFormaPago", IdFormaPago);
                    cmd.Parameters.AddWithValue("@Acepta", Acepta);
                    cmd.Parameters.Add("@Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["@Respuesta"].Value);
                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Respuesta;
        }

        //public List<TipoDocFormaPago> ObtenerFormasPago(int idTipoDoc)
        //{
        //    List<TipoDocFormaPago> formasPago = new List<TipoDocFormaPago>();

        //    using (SqlConnection con = new SqlConnection(Conexion.Cadena))
        //    {
        //        try
        //        {
        //            string query = "SELECT T.id, TD.id AS idTipoDoc, F.id AS idFormaPago, F.Descripcion, T.Acepta " +
        //                " FROM TiposDocFormasPago T" +
        //                " INNER JOIN TiposDocumentosCompra TD ON T.idTipoDoc = TD.id" +
        //                " INNER JOIN FormasPagos F ON T.idFormaPago = F.id" +
        //                            "WHERE TD.id = " + idTipoDoc;

        //            SqlCommand cmd = new SqlCommand(query, con);
        //            cmd.CommandType = CommandType.Text;
        //            con.Open();

        //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    formasPago.Add(new TipoDocFormaPago
        //                    {
        //                        Id = Convert.ToInt32(reader["id"]),
        //                        IdTipoDoc = Convert.ToInt32(reader["idTipoDoc"]),
        //                        IdFormaPago = Convert.ToInt32(reader["idFormaPago"]),
        //                        Descripcion = reader["Descripcion"].ToString(),
        //                        Acepta = Convert.ToBoolean(reader["Acepta"])
        //                    });
        //                }
        //            }

        //        }
        //        catch (Exception ex)
        //        {
        //            formasPago = new List<TipoDocFormaPago>();
        //            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    return formasPago;
        //}

        public List<TipoDocFormaPago> ListarFormasPago(int IdTipoDoc)
        {
            List<TipoDocFormaPago> formasPago = new List<TipoDocFormaPago>();

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT T.id, TD.id AS idTipoDoc, F.id AS idFormaPago, F.Descripcion, T.Acepta " +
                        " FROM TiposDocFormasPago T" +
                        " INNER JOIN TiposDocumentosCompra TD ON T.idTipoDoc = TD.id" +
                        " INNER JOIN FormasPagos F ON T.idFormaPago = F.id" +
                                    " WHERE TD.id = " + IdTipoDoc; ;

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            formasPago.Add(new TipoDocFormaPago
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                IdTipoDoc = Convert.ToInt32(reader["idTipoDoc"]),
                                IdFormaPago = Convert.ToInt32(reader["idFormaPago"]),
                                Descripcion = reader["Descripcion"].ToString(),
                                Acepta = Convert.ToBoolean(reader["Acepta"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    formasPago = new List<TipoDocFormaPago>();
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return formasPago;
        }
    }
}

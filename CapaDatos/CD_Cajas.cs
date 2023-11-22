using CapaEntidad.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Cajas
    {
        public CD_Cajas() { }

        public List<Cajas> ObtenerCajas()
        {
            List<Cajas> cajas = new List<Cajas>();
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "select c.id, u.Login, c.NroCaja, c.Descripcion DescripcionCaja, s.Descripcion Sucursal, c.Activo" +
                        " from dbo.Cajas c" +
                        " left join dbo.Usuarios u" +
                        " on c.idUsuario = u.id" +
                        " and u.idRol = 2" +
                        " inner join dbo.Sucursales s" +
                        " on c.idSucursal = s.id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cajas.Add(new Cajas
                            {
                                Id = Convert.ToInt32(reader["Id"].ToString()),
                                LoginUsuario = reader["Login"].ToString(),
                                NumeroCaja= Int16.Parse(reader["NroCaja"].ToString()),
                                DescripcionCaja= reader["DescripcionCaja"].ToString(),
                                Sucursal = reader["Sucursal"].ToString(),
                                Activo = Convert.ToBoolean(reader["Activo"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return cajas;

        }

        public bool GuardarUsuarioCaja(CajasRequest obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_cajas_usuario_guardar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@IdCaja", obj.IdCaja);
                    cmd.Parameters.AddWithValue("@NumeroCaja", obj.NumeroCaja);
                    cmd.Parameters.AddWithValue("@UsuarioLogin", obj.Usuario);
                    cmd.Parameters.AddWithValue("@DescripcionSucursal", obj.Sucursal);
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

        public int GuardarNuevaCaja(InsertarCajaRequest obj, out string Mensaje)
        {
            int idCaja = 0;

            Mensaje = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.Cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_cajas_insertar_nuevo", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@NumeroCaja", obj.NumeroCaja);
                    cmd.Parameters.AddWithValue("@DescripcionSucursal", obj.Sucursal);
                    cmd.Parameters.AddWithValue("@DescripcionCaja", obj.DescripcionCaja);
                    cmd.Parameters.AddWithValue("@Activo", obj.Activo);
                    cmd.Parameters.Add("@idCaja", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    idCaja = Convert.ToInt32(cmd.Parameters["@idCaja"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idCaja = 0;
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return idCaja;
        }
    }
}
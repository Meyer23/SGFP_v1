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
    public class CD_Anulaciones
    {
        public List<MotivoAnulacion> ObtenerMotivosAnulaciones()
        {
            List<MotivoAnulacion> motivos = new List<MotivoAnulacion>();
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "SELECT Descripcion FROM MotivosAnulacion";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            motivos.Add(new MotivoAnulacion
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
                return motivos;
            }
        }
    }
}

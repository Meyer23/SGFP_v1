using CapaEntidad.Models;
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
                    string query = "select c.Descripcion from dbo.Cajas c where c.Activo = 1;";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cajas.Add(new Cajas
                            {
                                DescripcionCaja = reader["DESCRIPCION"].ToString(),
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
    }
}
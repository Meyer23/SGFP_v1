using CapaEntidad;
using CapaEntidad.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace CapaDatos
{
    public class CD_Sucursal
    {
        public CD_Sucursal() { }

        public List<Sucursales> ObtenerSucursales()
        {
            List<Sucursales> sucursales = new List<Sucursales>();
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "select s.Descripcion from dbo.Sucursales s where s.Activo = 1;";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sucursales.Add(new Sucursales
                            {
                                DescripcionSucursal = reader["DESCRIPCION"].ToString(),
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return sucursales;

        }
    }
}
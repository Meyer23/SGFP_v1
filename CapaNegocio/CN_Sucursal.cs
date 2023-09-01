using CapaDatos;
using CapaEntidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Sucursal
    {
        CD_Sucursal cd_sucursal = new CD_Sucursal();
        public CN_Sucursal() { }

        public List<Sucursales> ObtenerSucursal()
        {
            return cd_sucursal.ObtenerSucursales();
        }
    }
}
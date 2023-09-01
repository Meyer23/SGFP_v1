using CapaDatos;
using CapaEntidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cajas
    {
        CD_Cajas cd_cajas = new CD_Cajas();
        public List<Cajas> ObtenerCajas()
        {
            return cd_cajas.ObtenerCajas();
        }
    }
}
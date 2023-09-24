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

        public bool GuardarUsuarioCaja(CajasRequest obj, out string Mensaje)
        {
            return cd_cajas.GuardarUsuarioCaja(obj, out Mensaje);
        }

        public int InsertarNuevaCaja(InsertarCajaRequest obj, out string Mensaje)
        {
            return cd_cajas.GuardarNuevaCaja(obj, out Mensaje);
        }
    }
}
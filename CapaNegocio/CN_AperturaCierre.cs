using CapaDatos;
using CapaEntidad;
using CapaEntidad.Models;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_AperturaCierre
    {

        private CD_AperturaCierre cd_aperturacierre = new CD_AperturaCierre();


        public int AperturaCierreCaja(AperturaRequest obj, out string Mensaje)
        {
            return cd_aperturacierre.AperturarCaja(obj, out Mensaje);
        }

        public int CierreCaja(CierreRequest obj, out string Mensaje)
        {
            return cd_aperturacierre.CierreCaja(obj, out Mensaje);
        }

        public List<AperturaCierreCajas> ObtenerAperturasDeCajas()
        {
            return cd_aperturacierre.ObtenerAperturasDeCajas();
        }
    }
}
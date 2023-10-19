using CapaDatos;
using CapaEntidad;
using CapaEntidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Empresa
    {
        CD_Empresa cd_empresa = new CD_Empresa();
        public Empresa ObtenerDatos()
        {
            return cd_empresa.ObtenerDatos();
        }

        public bool GuardarDatos(Empresa obj, out string Mensaje)
        {
            return cd_empresa.GuardarDatos(obj, out Mensaje);
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            return cd_empresa.ObtenerLogo(out obtenido);
        }

        public bool ActualizarLogo(byte[] image, out string Mensaje)
        {
            return cd_empresa.ActualizarLogo(image, out Mensaje);
        }
    }
}

using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_NumeracionDocumento
    {
        CD_NumeracionDocumento cd_numeracionDocumento = new CD_NumeracionDocumento();
        public int InsertarNuevaNumeracionDocumento(NumeracionDocumento obj, out string Mensaje)
        {
            return cd_numeracionDocumento.GuardarNumeracionDocumento(obj, out Mensaje);
        }

        public List<NumeracionDocumento> Listar()
        {
            return cd_numeracionDocumento.Listar();
        }
    }
}
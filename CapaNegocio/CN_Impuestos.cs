using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Impuestos
    {
        private CD_Impuestos cd_impuesto = new CD_Impuestos();

        public List<Impuesto> Listar()
        {
            return cd_impuesto.Listar();
        }

        public int Registrar(Impuesto obj, out string Mensaje)
        {
            return cd_impuesto.Registrar(obj, out Mensaje);
        }

        public bool Editar(Impuesto obj, out string Mensaje)
        {
            return cd_impuesto.Editar(obj, out Mensaje);
        }
    }
}

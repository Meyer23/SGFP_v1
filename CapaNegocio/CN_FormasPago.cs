using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_FormasPago
    {
        private CD_FormasPago cd_formaPago = new CD_FormasPago();

        public List<FormaPago> Listar()
        {
            return cd_formaPago.Listar();
        }

        public int Registrar(FormaPago obj, out string Mensaje)
        {
            return cd_formaPago.Registrar(obj, out Mensaje);
        }

        public bool Editar(FormaPago obj, out string Mensaje)
        {
            return cd_formaPago.Editar(obj, out Mensaje);
        }

        public List<FormaPago> ObtenerFormasPago()
        {
            return cd_formaPago.ObtenerFormasPago();
        }
    }
}

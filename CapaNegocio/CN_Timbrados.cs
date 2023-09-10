using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Timbrados
    {
        private CD_Timbrados cd_Timbrado = new CD_Timbrados();

        public List<Timbrado> Listar()
        {
            return cd_Timbrado.Listar();
        }

        public int Registrar(Timbrado obj, out string Mensaje)
        {
            return cd_Timbrado.Registrar(obj, out Mensaje);
        }

        public bool Editar(Timbrado obj, out string Mensaje)
        {
            return cd_Timbrado.Editar(obj, out Mensaje);
        }
    }
}

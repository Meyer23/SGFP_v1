using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_UnidadesMedida
    {
        private CD_UnidadesMedida cd_unidadMedida = new CD_UnidadesMedida();

        public List<UnidadMedida> Listar()
        {
            return cd_unidadMedida.Listar();
        }

        public int Registrar(UnidadMedida obj, out string Mensaje)
        {
            return cd_unidadMedida.Registrar(obj, out Mensaje);
        }

        public bool Editar(UnidadMedida obj, out string Mensaje)
        {
            return cd_unidadMedida.Editar(obj, out Mensaje);
        }

        public List<UnidadMedida> ObtenerUnidadesMedida()
        {
            return cd_unidadMedida.ObtenerUnidadesMedida();
        }
    }
}

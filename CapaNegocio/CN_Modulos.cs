using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Modulos
    {

        private CD_Modulos cd_Modulo = new CD_Modulos();

        public List<Modulo> Listar(int idRol)
        {
            return cd_Modulo.Listar(idRol);
        }
    }
}

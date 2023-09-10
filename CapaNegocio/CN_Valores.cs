using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Valores
    {
        private CD_Valores cd_valor = new CD_Valores();

        public List<Valor> Listar()
        {
            return cd_valor.Listar();
        }

        public int Registrar(Valor obj, out string Mensaje)
        {
            return cd_valor.Registrar(obj, out Mensaje);
        }

        public bool Editar(Valor obj, out string Mensaje)
        {
            return cd_valor.Editar(obj, out Mensaje);
        }
    }
}

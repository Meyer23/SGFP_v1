using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Bancos
    {
        private CD_Bancos cd_banco = new CD_Bancos();

        public List<Banco> Listar()
        {
            return cd_banco.Listar();
        }

        public int Registrar(Banco obj, out string Mensaje)
        {
            return cd_banco.Registrar(obj, out Mensaje);
        }

        public bool Editar(Banco obj, out string Mensaje)
        {
            return cd_banco.Editar(obj, out Mensaje);
        }
    }
}

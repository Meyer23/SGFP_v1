using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Roles
    {
        private CD_Roles cd_roles = new CD_Roles();

        public List<Rol> Listar()
        {
            return cd_roles.Listar();
        }

        public int Registrar(Rol obj, out string Mensaje)
        {
            return cd_roles.Registrar(obj, out Mensaje);
        }

        public bool Editar(Rol obj, out string Mensaje)
        {
            return cd_roles.Editar(obj, out Mensaje);
        }
    }
}
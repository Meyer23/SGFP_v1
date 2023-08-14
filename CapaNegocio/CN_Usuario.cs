using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuarios cd_usuario = new CD_Usuarios();

        public List<Usuario> Listar()
        {
            return cd_usuario.MostrarUsuarios();
        }
    }
}
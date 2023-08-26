using CapaDatos;
using CapaEntidad;
using CapaEntidad.Models;
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

        public List<UsuarioLogin> ObtenerUsuario()
        {
            return cd_usuario.ObtenerUsuarioLogin();
        }

        public List<Rol> ObtenerRol()
        {
            return cd_usuario.ObtenerRol().ToList();
        }
    }
}
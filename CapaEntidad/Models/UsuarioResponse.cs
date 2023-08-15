using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class UsuarioResponse
    {
        public int idUsuario { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string Login { get; set; }


        public string Cedula { get; set; }

        public string NombreRol { get; set; }

        public string NombreSucursal { get; set; }

        public bool Activo { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Models
{
    public class UsuarioRequest
    {
        public string Login { get; set; }

        public string Password { get; set; }    

        public string UsuarioSucursalCaja { get; set; }

        public int EmpleadoId { get; set; }

        public string UsuarioRol { get; set; }

        public string UsuarioSucursal { get; set; }

        public bool Activo { get; set; }
    }
}
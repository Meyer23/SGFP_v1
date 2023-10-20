using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Models
{
    public class UsuarioLogin
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string PassWord { get; set; }

        public int IdRol { get; set; }

        public bool Activo { get; set; }
    }
}
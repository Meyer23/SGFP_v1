using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Models
{
    public class UsuarioLogin
    {
        public string Login { get; set; }

        public string PassWord { get; set; }

        public bool Activo { get; set; }
    }
}
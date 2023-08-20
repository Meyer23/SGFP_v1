using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int Id { get; set; }

        public Empleado ObjectEmpleado { get; set; }

        public string PassWord { get; set; }

        public Rol ObjectRol { get; set; }

        public bool Activo { get; set; }

    }
}
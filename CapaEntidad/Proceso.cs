using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Proceso
    {
        public int IdRolProceso { get; set; }

        public int RolId { get; set; }

        public int IdProceso { get; set; }

        public string Nombre { get; set; }

        public string Boton { get; set; }

        public bool Procesa { get; set; }
    }
}

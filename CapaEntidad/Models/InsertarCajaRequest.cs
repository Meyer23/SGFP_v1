using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class InsertarCajaRequest
    {
        public int NumeroCaja { get; set; }
        
        public string Sucursal { get; set; }

        public bool Activo { get; set; }

        public int? IdUsuario { get; set; }
    }
}
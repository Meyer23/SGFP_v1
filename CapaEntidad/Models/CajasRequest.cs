using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Models
{
    public class CajasRequest
    {
        public int IdCaja { get; set; }

        public int NumeroCaja { get; set; }

        public string Descripcion { get; set; }

        public string Sucursal { get; set; }

        public string Usuario { get; set; }

        public bool Activo { get; set; }
    }
}
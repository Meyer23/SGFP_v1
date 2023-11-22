using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Models
{
    public class Cajas
    {
        public int Id { get; set; }

        public string LoginUsuario { get; set; }

        public int NumeroCaja { get; set; }

        public string DescripcionCaja { get; set; }

        public string Sucursal { get; set; }

        public bool Activo { get; set; }
    }
}
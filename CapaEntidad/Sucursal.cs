using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Sucursal
    {
        public int IdSucursal { get; set; }

        public string Descripcion { get; set; } 

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public bool Activo { get; set; }
    }
}
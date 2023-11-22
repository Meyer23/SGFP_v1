using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class NumeracionDocumento
    {
        public int IdTimbrado { get; set; }

        public int IdCaja { get; set; }

        public string CodigoEstablecimiento { get; set; }

        public int PuntoEmision { get; set; }

        public int UltimoNumero { get; set; }
    }
}
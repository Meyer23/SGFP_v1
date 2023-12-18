using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Models
{
    public class AperturaCierreCajas
    {
        public int Id { get; set; }

        public double? MontoInicial { get; set; }

        public double? MontoCierre { get; set; }

        public double? MontoActual { get; set; }

        public DateTime? FechaApertura { get; set; }

        public DateTime? FechaCierre { get; set; }

        public int IdCaja { get; set; }

        public int NroCaja { get; set; }

        public bool Estado { get; set; }
    }
}

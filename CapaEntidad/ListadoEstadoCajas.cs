using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ListadoEstadoCajas
    {
        public int Id { get; set; }

        public string MontoInicial { get; set; }

        public string MontoCierre { get; set; }

        public string MontoActual { get; set; }

        public string FechaApertura { get; set; }

        public string FechaCierre { get; set; }

        public int IdCaja { get; set; }

        public int NroCaja { get; set; }

        public bool Estado { get; set; }
    }
}
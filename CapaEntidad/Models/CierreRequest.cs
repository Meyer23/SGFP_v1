using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Models
{
    public class CierreRequest
    {
        public decimal ImporteCierre { get; set; }

        public int NumeroCaja { get; set; }

        public string DescripcionCaja { get; set; }

        public string LoginCajero { get; set; }

        public DateTime FechaApertura { get; set; }

        public DateTime FechaCierre { get; set; }
    }
}
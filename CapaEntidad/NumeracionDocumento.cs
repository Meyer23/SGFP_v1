using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class NumeracionDocumento
    {
        public int Id { get; set; }

        public int IdTimbrado { get; set; }

        public float NroTimbrado { get; set; }

        public string DescripcionCaja { get; set; }

        public string CodigoEstablecimiento { get; set; }

        public int PuntoEmision { get; set; }

        public int UltimoNumero { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Impuesto
    {
        public int Id { get; set; }

        public int TipoImpuesto { get; set; }

        public string Descripcion{ get; set; }

        public decimal PorcIVA { get; set; }

        public decimal FactorGravada { get; set; }

        public decimal FactorIVA { get; set; }

        public bool Activo { get; set; }
    }
}

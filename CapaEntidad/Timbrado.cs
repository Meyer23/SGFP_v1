using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Timbrado
    {
        public int Id { get; set; }

        public int NroTimbrado { get; set; }

        public DateTime InicioVigencia { get; set; }

        public DateTime FinVigencia { get; set; }

        public int NroDesde { get; set; }

        public int NroHasta { get; set; }

        public bool Activo { get; set; }
    }
}

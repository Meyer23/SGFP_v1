using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class TipoDocFormaPago
    {
        public int Id { get; set; }

        public int IdTipoDoc { get; set; }

        public int IdFormaPago { get; set; }

        public string Descripcion { get; set; }

        public bool Acepta { get; set; }

    }
}

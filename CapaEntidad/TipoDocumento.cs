using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class TipoDocumento
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public bool TipoCodigo { get; set; }

        public bool Activo { get; set; }     
    }
}

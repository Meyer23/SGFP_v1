using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class MovimientoStock
    {
        public int Id { get; set; }

        public string Documento { get; set; }

        public string TipoMovimiento { get; set; }

        public DateTime Fecha { get; set; }

        public string Observacion { get; set; }

        public decimal Total { get; set; }

        public int IdUsuario { get; set; }

        public string NombreUsuario { get; set; }

        public bool Confirmado { get; set; }

        public List<DetalleProductos> Detalle { get; set; }
    }
}

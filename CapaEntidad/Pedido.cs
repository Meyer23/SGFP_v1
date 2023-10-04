using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Pedido
    {
        public int Id { get; set; }

        public int IdProveedor { get; set; }

        public int NumeroPedido { get; set; }

        public string TipoDocumento { get; set; }

        public string FormaPago { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime FechaRequerida { get; set; }

        public string Observacion { get; set; }

        public decimal Total { get; set; }

        public int IdUsuario { get; set; }

        public bool Confirmado { get; set; }
    }
}

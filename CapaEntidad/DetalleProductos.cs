using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleProductos
    {
        public int Id { get; set; }

        public int IdPedido { get; set; }

        public int IdProducto { get; set; }

        public string Descripcion { get; set; }

        public decimal Cantidad { get; set; }

        public decimal Precio { get; set; }

        public decimal Total { get; set; }

        public string Documento { get; set; }

        public string RazonSocial { get; set; }

        public DateTime Fecha { get; set; }
    }
}

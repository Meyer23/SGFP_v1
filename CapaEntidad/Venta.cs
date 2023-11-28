using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        public int Id { get; set; }

        public int IdCliente { get; set; }

        public string Nombre { get; set; }

        public string Documento { get; set; }

        public string NumeroFactura { get; set; }

        public string TipoDocumento { get; set; }

        public string FormaPago { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public int Timbrado { get; set; }

        public DateTime InicioVigencia { get; set; }

        public DateTime FinVigencia { get; set; }

        public int CodEstablecimiento { get; set; }

        public int PuntoEmision { get; set; }

        public string Doc { get; set; }

        public decimal Total { get; set; }

        public int IdCajero { get; set; }

        public string NombreCajero { get; set; }

        public bool Anulado { get; set; }

        public List<DetalleProductos> Detalle { get; set; }
    }
}

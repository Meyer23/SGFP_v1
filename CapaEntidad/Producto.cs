using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public string Descripcion { get; set; }

        public decimal Costo { get; set; }

        public decimal Precio { get; set; }

        public decimal Existencia { get; set; }

        public decimal ExistenciaMinima { get; set; }

        public string Categoria { get; set; }

        public string UnidadMedida { get; set; }

        public int Estante { get; set; }

        public int Fila { get; set; }

        public int Columna { get; set; }

        public bool Activo { get; set; }
    }
}

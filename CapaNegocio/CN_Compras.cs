using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Compras
    {
        private CD_Compras cd_compra = new CD_Compras();

        public bool Registrar(Compra obj, DataTable DetalleCompra, out string Mensaje)
        {
            return cd_compra.Registrar(obj, DetalleCompra, out Mensaje);
        }
    }
}

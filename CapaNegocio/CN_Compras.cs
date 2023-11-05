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

        public bool ConfirmarCompra(int IdCompra, DateTime FechaRec, out string Mensaje)
        {
            return cd_compra.ConfirmarCompra(IdCompra, FechaRec, out Mensaje);
        }

        public List<Compra> Listar(int bandera)
        {
            return cd_compra.Listar(bandera);
        }

        public Compra ObtenerCompra(int IdCompra)
        {
            Compra objCompra = cd_compra.ObtenerCompra(IdCompra);

            if (objCompra.Id != 0)
            {
                List<DetalleProductos> objDetalle = cd_compra.ObtenerCompraDetalle(objCompra.Id);

                objCompra.Detalle = objDetalle;
            }
            return objCompra;
        }
    }
}

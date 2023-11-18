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
    public class CN_MovimientosStock
    {
        private CD_MovimientosStock cd_movStock = new CD_MovimientosStock();

        public bool Registrar(MovimientoStock obj, DataTable DetalleMovimiento, out string Mensaje)
        {
            return cd_movStock.Registrar(obj, DetalleMovimiento, out Mensaje);
        }

        public List<MovimientoStock> Listar(int bandera)
        {
            return cd_movStock.Listar(bandera);
        }

        public bool ConfirmarMovStock(int idMovStock, string TipoMov, out string Mensaje)
        {
            return cd_movStock.ConfirmarMovStock(idMovStock, TipoMov, out Mensaje);
        }

        public bool AnularMovStock(int IdMovStock, string TipoMovimiento, out string Mensaje)
        {
            return cd_movStock.AnularMovStock(IdMovStock, TipoMovimiento, out Mensaje);
        }

        public MovimientoStock ObtenerMovStock(int IdMovStock)
        {
            MovimientoStock objMovStock = cd_movStock.ObtenerMovStock(IdMovStock);

            if (objMovStock.Id != 0)
            {
                List<DetalleProductos> objDetalle = cd_movStock.ObtenerMovStockDetalle(objMovStock.Id);

                objMovStock.Detalle = objDetalle;
            }
            return objMovStock;
        }

        public decimal ObtenerExistencia(int idProducto)
        {
            return cd_movStock.ObtenerExistencia(idProducto);
        }
    }
}

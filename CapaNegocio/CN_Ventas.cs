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
    public class CN_Ventas
    {
        private CD_Ventas cd_venta = new CD_Ventas();
        public Venta ObtenerVenta(int IdVenta)
        {
            Venta objVenta = cd_venta.ObtenerVenta(IdVenta);

            if (objVenta.Id != 0)
            {
                List<DetalleProductos> objDetalle = cd_venta.ObtenerVentaDetalle(objVenta.Id);

                objVenta.Detalle = objDetalle;
            }
            return objVenta;
        }

        public List<Venta> Listar()
        {
            return cd_venta.Listar();
        }

        public bool AnularVenta(int IdVenta, string MotivoAnulacion, out string Mensaje)
        {
            return cd_venta.AnularVenta(IdVenta, MotivoAnulacion, out Mensaje);
        }

        public int Registrar(Venta objVenta, DataTable detalle_venta, DataTable datosDetallesCobro, out string mensaje)
        {
            return cd_venta.Registrar(objVenta, detalle_venta, datosDetallesCobro, out mensaje);
        }
    }
}

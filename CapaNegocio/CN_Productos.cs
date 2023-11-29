using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Productos
    {
        private CD_Productos cd_producto = new CD_Productos();

        public List<Producto> Listar(int bandera, int id)
        {
            return cd_producto.Listar(bandera, id);
        }

        public int Registrar(Producto obj, out string Mensaje)
        {
            return cd_producto.Registrar(obj, out Mensaje);
        }

        public bool Editar(Producto obj, out string Mensaje)
        {
            return cd_producto.Editar(obj, out Mensaje);
        }

        public byte[] ObtenerLogo(int idProducto, out bool obtenido)
        {
            return cd_producto.ObtenerLogo(idProducto, out obtenido);
        }

        public bool ActualizarLogo(byte[] image, int idProducto, out string Mensaje)
        {
            return cd_producto.ActualizarLogo(image, idProducto, out Mensaje);
        }

        public List<DetalleProductos> ObtenerUltimasCompras(int idProducto)
        {
            return cd_producto.ObtenerUltimasCompras(idProducto);
        }
    }
}

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

        public List<Producto> Listar()
        {
            return cd_producto.Listar();
        }

        public int Registrar(Producto obj, out string Mensaje)
        {
            return cd_producto.Registrar(obj, out Mensaje);
        }

        public bool Editar(Producto obj, out string Mensaje)
        {
            return cd_producto.Editar(obj, out Mensaje);
        }
    }
}

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
    public class CN_Pedidos
    {
        private CD_Pedidos cd_pedido = new CD_Pedidos();

        public int ObtenerNroPedido()
        {
            return cd_pedido.ObtenerNroPedido();
        }

        public bool Registrar(Pedido obj, DataTable DetallePedido, out string Mensaje)
        {
            return cd_pedido.Registrar(obj, DetallePedido, out Mensaje);
        }
    }
}

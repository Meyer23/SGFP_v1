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
    public class CN_NotasCreditoEmitidas
    {
        private CD_NotasCreditoEmitidas cd_NCEmitida = new CD_NotasCreditoEmitidas();

        public bool Registrar(NotaCreditoEmitida obj, DataTable DetalleNota, out string Mensaje)
        {
            return cd_NCEmitida.Registrar(obj, DetalleNota, out Mensaje);
        }

        public List<NotaCreditoEmitida> Listar(int bandera)
        {
            return cd_NCEmitida.Listar(bandera);
        }

        public NotaCreditoEmitida ObtenerNota(int IdNCEmitida)
        {
            NotaCreditoEmitida objNCEmitida = cd_NCEmitida.ObtenerNota(IdNCEmitida);

            if (objNCEmitida.Id != 0)
            {
                List<DetalleProductos> objDetalle = cd_NCEmitida.ObtenerNotaDetalle(objNCEmitida.Id);

                objNCEmitida.Detalle = objDetalle;
            }
            return objNCEmitida;
        }

        public bool ConfirmarNota(int objNCEmitida, int IdVenta, out string Mensaje)
        {
            return cd_NCEmitida.ConfirmarNota(objNCEmitida, IdVenta, out Mensaje);
        }

        public bool AnularNota(int idNCEmitida, string MotivoAnulacion, out string Mensaje)
        {
            return cd_NCEmitida.AnularNota(idNCEmitida, MotivoAnulacion, out Mensaje);
        }
    }
}

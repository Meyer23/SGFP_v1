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
    public class CN_NotasCreditoRecibidas
    {
        private CD_NotasCreditoRecibidas cd_NCRecibida = new CD_NotasCreditoRecibidas();

        public bool Registrar(NotaCreditoRecibida obj, DataTable DetalleNota, out string Mensaje)
        {
            return cd_NCRecibida.Registrar(obj, DetalleNota, out Mensaje);
        }

        public bool ConfirmarNota(int IdNCRecibida, int IdCompra, out string Mensaje)
        {
            return cd_NCRecibida.ConfirmarNota(IdNCRecibida, IdCompra, out Mensaje);
        }

        public List<NotaCreditoRecibida> Listar(int bandera)
        {
            return cd_NCRecibida.Listar(bandera);
        }

        public NotaCreditoRecibida ObtenerNota(int IdNCRecibida)
        {
            NotaCreditoRecibida objNCRecibida = cd_NCRecibida.ObtenerNota(IdNCRecibida);

            if (objNCRecibida.Id != 0)
            {
                List<DetalleProductos> objDetalle = cd_NCRecibida.ObtenerNotaDetalle(objNCRecibida.Id);

                objNCRecibida.Detalle = objDetalle;
            }
            return objNCRecibida;
        }

        public bool AnularNota(int idNCRecibida, string MotivoAnulacion, out string Mensaje)
        {
            return cd_NCRecibida.AnularNota(idNCRecibida, MotivoAnulacion, out Mensaje);
        }
    }
}

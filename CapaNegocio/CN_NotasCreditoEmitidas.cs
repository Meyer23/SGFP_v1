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
    }
}

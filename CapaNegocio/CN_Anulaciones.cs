using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Anulaciones
    {
        private CD_Anulaciones cd_motivo = new CD_Anulaciones();
        public List<MotivoAnulacion> ObtenerMotivosAnulaciones()
        {
            return cd_motivo.ObtenerMotivosAnulaciones();
        }
    }
}

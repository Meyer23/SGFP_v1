using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Procesos
    {
        private CD_Procesos cd_proceso = new CD_Procesos();

        public List<Proceso> Listar(int idRol)
        {
            return cd_proceso.Listar(idRol);
        }

        public bool InsertarProcesos(int idRol)
        {
            return cd_proceso.InsertarProcesos(idRol);
        }

        public bool Editar(int IdRol, int IdProceso, bool Procesa)
        {
            return cd_proceso.Editar(IdRol, IdProceso, Procesa);
        }

        public List<Proceso> ObtenerProcesos(int idUsuario)
        {
            return cd_proceso.ObtenerProcesos(idUsuario);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Empleado
    {
        private CD_Empleados cd_Empleado = new CD_Empleados();

        public List<Empleado> Listar() 
        { 
            return cd_Empleado.Listar();
        
        }
    }
}

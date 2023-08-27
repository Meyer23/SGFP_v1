using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public int Registrar(Empleado obj, out string Mensaje)
        {
            return cd_Empleado.Registrar(obj, out Mensaje);
        }

        public bool Editar(Empleado obj, out string Mensaje)
        {
            return cd_Empleado.Editar(obj, out Mensaje);
        }

        public bool ValidarCorreo(string sMail)
        {
            return Regex.IsMatch(sMail, @"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$");

        }
    }
}

using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Clientes
    {
        private CD_Clientes cd_Cliente = new CD_Clientes();

        public List<Cliente> Listar()
        {
            return cd_Cliente.Listar();
        }

        public int Registrar(Cliente obj, out string Mensaje)
        {
            return cd_Cliente.Registrar(obj, out Mensaje);
        }

        public bool Editar(Cliente obj, out string Mensaje)
        {
            return cd_Cliente.Editar(obj, out Mensaje);
        }

        public bool ValidarCorreo(string sMail)
        {
            return Regex.IsMatch(sMail, @"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$");
        }
    }
}

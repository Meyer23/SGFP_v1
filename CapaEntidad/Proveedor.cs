using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Proveedor
    {
        public int Id { get; set; }

        public string RazonSocial { get; set; }

        public string Documento { get; set; }

        public string Contacto { get; set; }

        public string Contacto2 { get; set; }

        public string Direccion { get; set; }        

        public string TelefonoUno { get; set; }

        public string TelefonoDos { get; set; }

        public string Correo { get; set; }

        public bool Activo { get; set; }
    }
}

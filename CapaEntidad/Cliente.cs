using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Documento { get; set; }

        public string Direccion { get; set; }

        public string TelefonoUno { get; set; }

        public string TelefonoDos { get; set; }

        public string Correo { get; set; }

        public bool TipoPersona { get; set; }

        public bool Activo { get; set; }
    }
}

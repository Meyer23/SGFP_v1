﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Modulo
    {
        public int Id { get; set; }

        public int IdRol { get; set; }

        public int IdModulo { get; set; }

        public string Nombre { get; set; }

        public string Menu { get; set; }

        public bool Visualiza { get; set; }

        public bool Incluye { get; set; }

        public bool Modifica { get; set; }

    }
}

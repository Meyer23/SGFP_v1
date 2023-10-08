using System;

namespace CapaEntidad.Models
{
    public class AperturaRequest
    {
        public DateTime FechaApertura { get; set; }

        public int IdCaja { get; set; }

        public decimal ImporteInicial { get; set; }

        public string Usuario { get; set; }

        public bool Activo { set; get; }
    }
}
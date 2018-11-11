using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SistemaDeVentas.Entidades
{
   public class Cliente
    {
        [Key]

        public int ClienteId { get; set; }

        public string Nombres { get; set; }

        public string NoTelefono { get; set; }

        public string NoCedula { get; set; }

        public string Direccion { get; set; }

        public double Deuda { get; set; }

        public Cliente()
        {
            ClienteId = 0;
            Nombres = string.Empty;
            NoTelefono = string.Empty;
            NoCedula = string.Empty;
            Direccion = string.Empty;
            Deuda = 0;
        }

        public override string ToString()
        {
            return Nombres;
        }

    }
}

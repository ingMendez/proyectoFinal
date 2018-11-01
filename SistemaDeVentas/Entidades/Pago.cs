using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SistemaDeVentas.Entidades
{
    public class Pago
    {
        [Key]
        public int PagoId { get; set; }

        public DateTime Fecha { get; set; }

        public int ClienteId { get; set; }

        public double MontoPago { get; set; }


        public Pago()
        {
            PagoId = 0;
            ClienteId = 0;
            Fecha = DateTime.Now;
            MontoPago = 0;
        }
    }
}

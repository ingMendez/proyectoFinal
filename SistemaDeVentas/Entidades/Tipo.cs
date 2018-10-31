using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SistemaDeVentas.Entidades
{
   public class Tipo
    {
        [Key]
        public int IdTipo { get; set; }
        public string descripcion { get; set; }

        public Tipo()
        {
            IdTipo = 0;
            descripcion = string.Empty;
        }
    }

}

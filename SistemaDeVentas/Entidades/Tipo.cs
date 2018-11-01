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
        public string Descripcion { get; set; }

        public Tipo()
        {
            IdTipo = 0;
            Descripcion = string.Empty;
        }
    }

}

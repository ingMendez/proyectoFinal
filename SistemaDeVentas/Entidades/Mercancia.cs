using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SistemaDeVentas.Entidades
{
    public class Mercancia
    {
        [Key]
        public int  MercanciaID {get;set;}
        public string NombreProducto  { get; set; }
        public int cantidadProducto { get; set; }
        public string Descripcion { get; set; }
        public double precioProducto { get; set; }

        public Mercancia()
        {
              MercanciaID = 0;
              NombreProducto = string.Empty;
              cantidadProducto = 0;
              Descripcion = string.Empty;
              precioProducto = 0;
        }
        public Mercancia(int id,String nombre,int cantidad,String descripion,Double precio)
        {
            this.MercanciaID = id;
            this.NombreProducto = nombre;
            this.cantidadProducto = cantidad;
            this.Descripcion = descripion;
            this.precioProducto = precio;
        }
    }
}

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

        public int IdTipo { get; set; }

        public string NombreProducto  { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public int CantidadProducto { get; set; }

        public string Descripcion { get; set; }

        public double PrecioProducto { get; set; }

        public double PorCientoGanancia { get; set; }

        public double Costo { get; set; }

        public double CantidadInventario { get; set; }

        public Mercancia()
        {
              MercanciaID = 0;
              IdTipo = 0;
              NombreProducto = string.Empty;
            FechaVencimiento = DateTime.Now;
              CantidadProducto = 0;
              Descripcion = string.Empty;
              PrecioProducto = 0;
            PorCientoGanancia = 0;
            Costo = 0;
            CantidadInventario = 0;

        }
        public override string ToString()
        {
            return Descripcion;
        }
        /* public Mercancia(int id,String nombre,int cantidad,String descripion,Double precio)
         {
             this.MercanciaID = id;
             this.NombreProducto = nombre;
             this.cantidadProducto = cantidad;
             this.Descripcion = descripion;
             this.precioProducto = precio;
         }*/
    }
}

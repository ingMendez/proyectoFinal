using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SistemaDeVentas.Entidades
{
   public class FacturaDetalle
    {
        [Key]
        public int Id { get; set; }

        public int FacturaID { get; set; }

        public int MercanciaID { get; set; }

        public double Cantidad { get; set; }

        public double Precio { get; set; }

        public double Importe { get; set; }

        [ForeignKey("FacturaID")]
        public virtual Factura Factura { get; set; }

        [ForeignKey("MercanciaID")]
        public virtual Mercancia Mercancia { get; set;}


        public FacturaDetalle()
        {
            Id = 0;
            FacturaID = 0;
            MercanciaID = 0;
            Cantidad = 0;
            Precio = 0;
            Importe = 0;
        }
        public FacturaDetalle(int id,int facturaid,int mercaId,double cantidad,double precio,double importe)
        {
            Id = id;
            FacturaID = facturaid;
            MercanciaID = mercaId;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;
        }
    }
}

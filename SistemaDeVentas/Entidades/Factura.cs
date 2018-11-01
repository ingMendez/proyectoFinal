using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SistemaDeVentas.Entidades
{
   public class Factura
    {
        [Key]
        public int FacturaID { get; set; }

        public int UsuarioID { get; set; }

        public  string NombreCliente { get; set; }

        public DateTime Fecha { get; set; }
        
        //  public int Cantidad { get; set; }

        public double SubTotal { get; set; }
        // public double Precio { get; set; }

        //   public string DetalleArticulo { get; set; }

        public double Total { get; set; }

        public virtual List<FacturaDetalle> Detalle { get; set; }

        public double Itbis { get; set; }

        public Factura()
        {
            // FacturaID = 0;
            // NombreCliente = string.Empty;
            //  Cantidad = 0;
            //Precio = 0.00;
            //DetalleArticulo = string.Empty;
            // Total = 00;
            this.Detalle = new List<FacturaDetalle>();
        }
        public void AgregarDetalle(int id,int facturaid,int mercaid,double cantidad,Double Precio,double importe)
        {
            this.Detalle.Add( new FacturaDetalle(id,facturaid,mercaid,cantidad,Precio,importe));

        }
        public override string ToString()
        {
            return base.ToString();
        }
        /*public Factura(int facturaid,string Nombre,int cantidad,Double precio,string descripcion,Double total)
        {
            this.FacturaID = facturaid;
            this.NombreCliente = Nombre;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.DetalleArticulo = descripcion;
            this.Total = total;
        }*/
    }
}

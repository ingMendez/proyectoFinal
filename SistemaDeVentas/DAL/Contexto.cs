using SistemaDeVentas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace SistemaDeVentas.DAL
{
   public class Contexto :DbContext
    {
        public DbSet<Factura>Factura  { get; set; }
        public DbSet<Mercancia> Mercancias { get; set; }
        public DbSet<Tipo> Tiposs { get; set; }
       // public DbSet<FacturaDetalle> Facturadetalle { get; set; }
        public DbSet<Usuario> Usuario { get; set; }


        public Contexto() : base("ConStr")
        {

        }
    }
}

using SistemaDeVentas.DAL;
using SistemaDeVentas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SistemaDeVentas.BLL
{
    public class FacturaBLL
    {
        public static bool Guardar(Factura factura)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Factura.Add(factura) != null)

                    foreach (var item in factura.Detalle)
                    {
                        contexto.Mercancias.Find(item.MercanciaID).CantidadInventario -= item.Cantidad;
                    }

                contexto.Cliente.Find(factura.ClienteId).Deuda += factura.Total;

                contexto.SaveChanges();
                paso = true;

                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static void ModificarBien(Factura factura, Factura FacturasAnteriores)
        {
            Contexto contexto = new Contexto();
            var Cliente = contexto.Cliente.Find(factura.ClienteId);
            var ClientesAnteriores = contexto.Cliente.Find(FacturasAnteriores.ClienteId);

            Cliente.Deuda += factura.Total;
            ClientesAnteriores.Deuda -= FacturasAnteriores.Total;
            ClienteBLL.Modificar(Cliente);
            ClienteBLL.Modificar(ClientesAnteriores);

        }

        public static bool Modificar(Factura factura)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var FactAnt = FacturaBLL.Buscar(factura.FacturaID);

                if (factura.ClienteId != FactAnt.ClienteId)
                {
                    ModificarBien(factura, FactAnt);
                }

                if (factura != null)
                {
                    foreach (var item in FactAnt.Detalle)
                    {
                        contexto.Mercancias.Find(item.MercanciaID).CantidadInventario += item.Cantidad;

                        if (!factura.Detalle.ToList().Exists(v => v.Id == item.Id))
                        {
                            item.Mercancia = null;
                            contexto.Entry(item).State = EntityState.Deleted;
                        }
                    }

                    foreach (var item in factura.Detalle)
                    {
                        contexto.Mercancias.Find(item.MercanciaID).CantidadInventario -= item.Cantidad;
                        var estado = item.Id > 0 ? EntityState.Modified : EntityState.Added;
                        contexto.Entry(item).State = estado;
                    }

                    contexto.Entry(factura).State = EntityState.Modified;
                }

                Modifica(factura, FactAnt, contexto);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }



        public static void Modifica(Factura factura, Factura FactAnt, Contexto contexto)
        {
            double modificado = factura.Total - FactAnt.Total;

            var Cliente = contexto.Cliente.Find(factura.FacturaID);
            Cliente.Deuda += modificado;
            ClienteBLL.Modificar(Cliente);
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Factura factura = contexto.Factura.Find(id);

                foreach (var item in factura.Detalle)
                {
                    var EliminInventario = contexto.Mercancias.Find(item.MercanciaID);
                    EliminInventario.CantidadInventario += item.Cantidad;
                }

                contexto.Cliente.Find(factura.ClienteId).Deuda -= factura.Total;

                contexto.Factura.Remove(factura);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public static Factura Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Factura factura = new Factura();
            try
            {
                factura = contexto.Factura.Find(id);

                if (factura != null)
                {
                    factura.Detalle.Count();

                    foreach (var item in factura.Detalle)
                    {
                        string s = item.Mercancia.Descripcion;
                        string ss = item.Factura.FacturaID.ToString();
                    }
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return factura;
        }


        public static List<Factura> GetList(Expression<Func<Factura, bool>> expression)
        {
            List<Factura> facturas = new List<Factura>();
            Contexto contexto = new Contexto();
            try
            {
                facturas = contexto.Factura.Where(expression).ToList();

                foreach (var item in facturas)
                {
                    item.Detalle.Count();
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return facturas;
        }

        public static double Importe(double cantidad, double precio)
        {
            double CalImporte = 0;
            CalImporte = cantidad * precio;

            return CalImporte;
        }
    }
}

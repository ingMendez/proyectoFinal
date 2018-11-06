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
   public class MercanciaBLL
    {
        public static bool Guardar(Mercancia mercancia)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Mercancias.Add(mercancia) != null)
                {
                    contexto.SaveChanges();
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


        public static bool Modificar(Mercancia mercancia)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(mercancia).State = EntityState.Modified;
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


        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                Mercancia mercancia = contexto.Mercancias.Find(id);

                contexto.Mercancias.Remove(mercancia);

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


        public static Mercancia Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Mercancia mercancia = new Mercancia();
            try
            {
                mercancia = contexto.Mercancias.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return mercancia;
        }


        public static List<Mercancia> GetList(Expression<Func<Mercancia, bool>> expression)
        {
            List<Mercancia> mercancia = new List<Mercancia>();
            Contexto contexto = new Contexto();

            try
            {
                mercancia = contexto.Mercancias.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

            return mercancia;
        }

        public static double PorcientoGanancia(double costo, double precio)
        {
            double PctGanancia;

            PctGanancia = precio - costo;
            PctGanancia = PctGanancia / costo;
            PctGanancia *= 100;

            return PctGanancia;
        }

    }
}

using Parcial2_Aplicada1_2017_0485.DAL;
using Parcial2_Aplicada1_2017_0485.Entidad;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Aplicada1_2017_0485.BLL
{
   public class ProyectosBLL
    {
        public static bool Existe(string descripcion)
        {
            bool encontrado = false;
            var contexto = new Contexto();

            try
            {
                
                encontrado = contexto.Proyectos.Any(e => e.Descripcion.ToLower() == descripcion.ToLower());
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }

        private static bool Insertar(Proyectos proyectos)
        {
            bool paso = false;
            var contexto = new Contexto();

            try
            {
                contexto.Proyectos.Add(proyectos);
                paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        private static bool Modificar(Proyectos proyectos)
        {
            bool paso = false;
            var contexto = new Contexto();

            try
            {
                contexto.Database.ExecuteSqlRaw($"DELETE FROM Proyectos_Detalles WHERE ProyectoId = {proyectos.ProyectoId}");
                foreach (var anterior in proyectos.Detalles)
                {
                    contexto.Entry(anterior).State = EntityState.Added;
                }
                contexto.Entry(proyectos).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Guardar(Proyectos proyectos)
        {
            if (!Existe(proyectos.Descripcion))
                return Insertar(proyectos);
            else
                return Modificar(proyectos);

        }

        public static Proyectos Buscar(int id)
        {
            var contexto = new Contexto();
            var proyecto = new Proyectos();

            try
            {
                proyecto = contexto.Proyectos.Include(x => x.Detalles).Where(p => p.ProyectoId == id).SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return proyecto;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            var contexto = new Contexto();

            try
            {
                var eliminarProyecto = contexto.Proyectos.Find(id);
                contexto.Entry(eliminarProyecto).State = EntityState.Deleted;

                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static List<Proyectos> GetList(Expression<Func<Proyectos, bool>> criterio)
        {
            List<Proyectos> lista = new List<Proyectos>();
            var contexto = new Contexto();

            try
            {
                lista = contexto.Proyectos.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}

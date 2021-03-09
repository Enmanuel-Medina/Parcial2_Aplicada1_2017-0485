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
      public static bool Existe (string descripcion)
        {
            bool encontrado = false;
            var contexto = new Contexto();
            try
            {
                encontrado = contexto.Proyectos.Any(e => e.Descripcion.ToLower() == descripcion.ToLower());

            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;

        }
        public static bool Insertar(Proyectos proyecto)
        {
            bool paso = false;
            var contexto = new Contexto();

            try
            { 
                foreach (var item in proyecto.Detalles)
                {
                    contexto.Entry(item.tarea).State = EntityState.Modified;
                }
                
                       
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
        public static bool Modificar(Proyectos proyecto)
        {
            bool paso = false;
            var contexto = new Contexto();

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete from Proyectos_Detalles where proyectoId = {proyecto.ProyectoId} ");
                foreach (var item in proyecto.Detalles)
                {
                    contexto.Entry(item.tarea).State = EntityState.Added;
                }
                contexto.Entry(proyecto).State = EntityState.Modified;
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
        public static bool Guardar(Proyectos proyecto)
        {
            if (!Existe(proyecto.Descripcion))
                return Insertar(proyecto);
            else return Modificar(proyecto);

        }
        public static Proyectos Buscar(int id)
        {
            var contexto = new Contexto();
            var proyectos = new Proyectos();

            try
            {
                proyectos = contexto == contexto.Proyectos.Include(x => Proyectos_Detalles).Where(p => p.ProyectoId == id).SinleOrDefault();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return proyectos;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            var contexto = new Contexto();

            try
            {
                var eliminarP = contexto.Proyectos = contexto.Proyectos.Find(id);
                contexto.Entry(eliminarP).State = EntityState.Deleted;
                paso = contexto.SaveChanges() > 0;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;

        }
        public static List<Proyectos> GetList(System.Linq.Expressions.Expression<Func<Proyectos, bool>> criterio)
        {
            List<Proyectos> lista = new List<Proyectos>();
            var contexto = new Contexto();

            try
            {
                lista = contexto.Proyectos.Where(criterio).Tolist();
            }
            catch(Exception)
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

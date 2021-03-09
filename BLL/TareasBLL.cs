using Microsoft.EntityFrameworkCore;
using Parcial2_Aplicada1_2017_0485.DAL;
using Parcial2_Aplicada1_2017_0485.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Aplicada1_2017_0485.BLL
{
   public class TareasBLL
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
        public static bool Insertar(Tareas tareas)
        {
            bool paso = false;
            var contexto = new Contexto();

            try
            {
                contexto.Proyectos.Add(tareas);
                paso = Contexto.SaveChanges() > 0;

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
                paso = Contexto.SaveChanges() > 0;

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
        public static bool Guardar(Tareas tareas)
        {
            if (!Existe(tareas.Descripcion))
                return Insertar(tareas);
            else 
                return Modificar(tareas);

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
       

        }
        public static List<Proyectos> GetList(System.Linq.Expressions.Expression<Func<Proyectos, bool>> criterio)
        {
            List<Proyectos> lista = new List<Proyectos>();
            var contexto = new Contexto();

            try
            {
                lista = contexto.Proyectos.Where(criterio).Tolist();
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


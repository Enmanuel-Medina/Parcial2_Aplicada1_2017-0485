using Microsoft.EntityFrameworkCore;
using Parcial2_Aplicada1_2017_0485.DAL;
using Parcial2_Aplicada1_2017_0485.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                encontrado = contexto.Tareas.Any(e => e.Descripcion.ToLower() == descripcion.ToLower());
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

        private static bool Insertar(Tareas tarea)
        {
            bool paso = false;
            var contexto = new Contexto();

            try
            {
                contexto.Tareas.Add(tarea);
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

        private static bool Modificar(Tareas tarea)
        {
            bool paso = false;
            var contexto = new Contexto();

            try
            {
                contexto.Entry(tarea).State = EntityState.Modified;
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

        public static bool Guardar(Tareas tarea)
        {
            if (!Existe(tarea.Descripcion))
                return Insertar(tarea);
            else
                return Modificar(tarea);
        }

        public static Tareas Buscar(int id)
        {
            var contexto = new Contexto();
            var tiposTarea = new Tareas();

            try
            {
                tiposTarea = contexto.Tareas.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return tiposTarea;
        }

        public static string BuscarRequerimiento(int id)
        {
            var contexto = new Contexto();
            var tiposTarea = new Tareas();

            try
            {
                tiposTarea = contexto.Tareas.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return tiposTarea.Requerimiento;
        }

        public static string BuscarTiempo(int id)
        {
            var contexto = new Contexto();
            var tarea = new Tareas();

            try
            {
                tarea = contexto.Tareas.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return Convert.ToString(tarea.Tiempo);
        }

        public static List<Tareas> GetList(Expression<Func<Tareas, bool>> criterio)
        {
            var lista = new List<Tareas>();
            var contexto = new Contexto();

            try
            {
                lista = contexto.Tareas.Where(criterio).ToList();
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

        public static List<Tareas> GetTareas()
        {
            var lista = new List<Tareas>();
            var contexto = new Contexto();

            try
            {
                lista = contexto.Tareas.ToList();
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


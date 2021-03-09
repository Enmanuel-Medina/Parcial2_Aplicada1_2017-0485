using Microsoft.EntityFrameworkCore;
using Parcial2_Aplicada1_2017_0485.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Aplicada1_2017_0485.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Tareas> Tareas { get; set; }
       
        public DbSet<Proyectos> Proyectos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data\Proyecto.db");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Tareas>().HasData(
              new Tareas() { TareaId = 1, Descripcion = "Análisis", Requerimiento = "Analizar la opción de clientes", Tiempo = 120 },
              new Tareas() { TareaId = 2, Descripcion = "Diseño", Requerimiento = "Hacer un diseño excelente", Tiempo = 60 },
              new Tareas() { TareaId = 3, Descripcion = "Programación", Requerimiento = "Programar todo el registro", Tiempo = 240 },
              new Tareas() { TareaId = 4, Descripcion = "Prueba", Requerimiento = "Probar con mucho cuidado", Tiempo = 30 }
          );
        }

    }
    }


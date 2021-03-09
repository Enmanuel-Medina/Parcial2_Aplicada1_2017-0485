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
            optionsBuilder.UseSqlite(@"Data Source = Data\Proyectos");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tareas>().HasData(new Tareas { TareaId = 1, Descripcion = "Analisis" });

            modelBuilder.Entity<Tareas>().HasData(new Tareas { TareaId = 2, Descripcion = "Diseño" });

            modelBuilder.Entity<Tareas>().HasData(new Tareas { TareaId = 3, Descripcion = "Programacion aplicada" });

        }
    }
}

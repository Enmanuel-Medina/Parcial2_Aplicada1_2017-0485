using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Aplicada1_2017_0485.Entidad
{
    public class Proyectos
    {
        [Key]
        public int ProyectoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int Tiempo { get; set; }

        [ForeignKey("ProyectoId")]
        public List<Proyectos_Detalles> Detalles { get; set; }

        public Proyectos()
        {
            ProyectoId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Tiempo = 0;
            Detalles = new List<Proyectos_Detalles>();
        }
    }       
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Aplicada1_2017_0485.Entidad
{
   public class Proyectos_Detalles
    {
        [Key]
        public int DetalleId { get; set; }
        public int ProyectoId { get; set; }
        public int TareaId { get; set; }
        public string Requerimiento { get; set; }
        public int Tiempo { get; set; }

        public Proyectos_Detalles()
        {
            DetalleId = 0;
            ProyectoId = 0;
            TareaId = 0;
            Requerimiento = string.Empty;
            Tiempo = 0;
        }
        public Proyectos_Detalles(int detalleid,int proyectoId,int tareaId,string requerimiento, int tiempo)
        {
            DetalleId = detalleid;
            ProyectoId = proyectoId;
            TareaId = tareaId;
            Requerimiento = requerimiento;
            Tiempo = tiempo;

        }


    }
}

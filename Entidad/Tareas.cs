using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Aplicada1_2017_0485.Entidad
{
   public class Tareas
    {
        [Key]
        public int TareaId { get; set; }
        public string Descripcion { get; set; }
        public string Requerimiento { get; set; }
        public int Tiempo { get; set; }
        public Tareas()
        {
            TareaId = 0;
            Descripcion = "";
            Requerimiento = "";
            Tiempo = 0;
        }
    }
}

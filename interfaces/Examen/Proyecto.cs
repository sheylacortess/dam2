using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{

    
    public class Proyecto
    {
       public string Nombre { get; set; }
        public List<Tarea> Tareas = new List<Tarea>();

        public Proyecto (string Nombre)
        {
            Nombre = Nombre;
            Tareas = new List<Tarea>();
        }

    }
}

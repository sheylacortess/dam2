using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Tarea
    {
        public string Nombre { get; set; }
        public string Asignado { get; set; }
        public string Fecha { get; set; }
        public string Estado { get; set; }
        public Tarea(string nombre, string asignado, string fecha, string estado)
        {
            Nombre = nombre;
            Asignado = asignado;
            Fecha = fecha;
            Estado = estado;
        }


    }
}

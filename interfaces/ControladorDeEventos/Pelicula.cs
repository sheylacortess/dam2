using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorDeEventos
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public string Actores { get; set; }
        public string Director { get; set; }
        public string Clasificacion {  get; set; }

        public Pelicula(string titulo,string actores, string director, string clasificacion)
        {
            this.Titulo = titulo;
            this.Actores = actores; 
            this.Director = director;
            this.Clasificacion = clasificacion;
        }
    }
}

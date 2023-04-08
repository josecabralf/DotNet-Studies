using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Entidades
{
    internal class Seccion
    {
        public Pregunta PreguntaSeccion { get; set; }
        public string? Respuesta { get; set; }

        public Seccion(Pregunta pr) 
        {
            PreguntaSeccion = pr;
        }
    }
}

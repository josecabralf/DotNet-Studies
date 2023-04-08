using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Entidades
{
    internal class Encuesta
    {
        public List<Seccion> Secciones { get; set; }

        public Encuesta(List<Seccion> secciones) 
        {
            Secciones = secciones;
        }
    }
}

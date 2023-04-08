using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Entidades
{
    internal class Pregunta
    {
        public string Descripcion { get; set; }

        public Pregunta(string desc) 
        {
            Descripcion = desc;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Entidades
{
    internal class Opcion
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public SubOpcion SubOp { get; set; }

        public Opcion(string nom, string desc, Subopcion sub) 
        {
            Nombre = nom;
            Descripcion = desc;
            SubOp = sub;
        }
    }
}

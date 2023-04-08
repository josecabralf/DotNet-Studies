using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Entidades
{
    internal class SubOpcion
    {
        public string Name { get; set; }
        public string Descripcion { get; set; }

        public Subopcion(string nom, string desc) {
            Name = nom;
            Descripcion = desc;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Entidades
{
    internal class Categoria
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Opcion Op { get; set; }

        Categoria(string nom, string desc, Opcion op) 
        {
            Nombre = nom;
            Descripcion = desc;
            Op = op;
        }
    }
}

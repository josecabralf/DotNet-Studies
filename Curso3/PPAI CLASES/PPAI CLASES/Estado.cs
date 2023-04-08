using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Entidades
{
    internal class Estado
    {
        public string Nombre { get; set; }
        public string Descricion { get; set;}

        public Estado(string nom, string desc) 
        {
            Nombre = nom;
            Descricion = desc;
        }
    }
}

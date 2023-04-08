using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto13
{
    // Interfaz: Clase 100% abstracta. Se nombran como "INombre"
    // La palabra reservada abstract está implicitamente en cada miembro de la interfaz
    internal interface IFiguraGeométrica
    {
        // Miembros = Abstractos .: no existen constructores
        double CalcularArea();
    }
}

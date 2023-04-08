using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto13
{
    internal class Circulo : IFiguraGeométrica
    {
        public double Radio { get; set; }

        // Al implementar interfaces, no hace falta escribir override al implementar métodos
        // Override está implícitamente incluido
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public void DatosFigura()
        {
            Console.WriteLine("Círculo con r = {0} | A = {1}", Radio, CalcularArea());
        }
    }
}

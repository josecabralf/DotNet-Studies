using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto13
{
    internal class TrianguloRect : IFiguraGeométrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double CalcularArea()
        {
            return Base * Altura / 2;
        }

        public void DatosFigura()
        {
            Console.WriteLine("Triángulo con b = {0} | h = {1} | A = {2}",
                Base, Altura, CalcularArea());
        }
    }
}

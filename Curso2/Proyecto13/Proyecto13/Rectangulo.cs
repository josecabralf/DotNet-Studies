using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto13
{
    internal class Rectangulo : IFiguraGeométrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double CalcularArea()
        {
            return Base * Altura;
        }

        public void DatosFigura()
        {
            Console.WriteLine("Rectángulo con b = {0} | h = {1} | A = {2}", 
                Base, Altura, CalcularArea());
        }
    }
}

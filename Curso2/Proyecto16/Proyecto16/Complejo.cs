using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto16
{
    internal struct Complejo
    {
        public double Real { get; }
        public double Imaginario {get; }

        public Complejo(double r, double i) : this()
        {
            Real = r;
            Imaginario = i;
        }

        public Complejo Suma(Complejo otro)
        {
            return new Complejo(Real + otro.Real, Imaginario + otro.Imaginario); ;
        }

        public Complejo Multiplica(Complejo otro)
        {
            
            return new Complejo(Real * otro.Real - Imaginario * otro.Imaginario, 
                Real * otro.Imaginario + Imaginario * otro.Real);
        }

        public override string ToString()
        {
            return String.Format("({0:0.0}, {1:0.0})", Real, Imaginario);
        }
    }
}

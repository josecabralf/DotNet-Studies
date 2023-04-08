using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto10
{
    internal class Estudiante : Persona
    {
        public double Promedio { get; set; }
        public string Grado { get; set; }

        public Estudiante(string name, int age, double prom, string grado) : base(name, age)
        {
            Promedio = prom;
            Grado = grado;
        }

        public void Estudiar()
        {
            Console.WriteLine("{0} está estudiando...", Name);
        }

        public void IrAClase()
        {
            Console.WriteLine("{0} está en clase...", Name);
        }

        public override void Saludar()
        {
            Console.WriteLine("Hola {0} de {1} grado", Name, Grado);
        }

        public override string ToString()
        {
            return String.Format("{0}: {1} | Promedio: {2} | Grado: ${3}", Name, Age, Promedio, Grado);
        }
    }
}

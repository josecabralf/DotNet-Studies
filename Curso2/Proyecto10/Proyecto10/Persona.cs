using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto10
{
    internal class Persona
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Persona() { }
        public Persona(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Para que una subclase pueda modificar el método de su clase padre, se necesita
        // la palabra reservada "virtual"
        public virtual void Saludar()
        {
            Console.WriteLine("Hola {0}", Name);
        }

        public override string ToString()
        {
            return String.Format("{0}: {1}", Name, Age);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto11
{
    // Clases Abstractas: clases que no pueden ser instanciadas
    // Sirven para crear subclases que la completen y le den significado a sus métodos y atributos
    
    abstract class Empleado
    {
        #region Atributos
        public string Nombre { get; set; }
        public string Puesto { get; set; }

        // Como el salario depende del tipo de empleado, es un atributo abstracto
        // La cualidad "abstract" denota que su valor no se puede calcular en ese momento
        public abstract decimal Salario { get; }
        #endregion

        public Empleado(string nombre, string puesto)
        {
            Nombre = nombre;
            Puesto = puesto;
        }

        public void Saludar()
        {
            Console.WriteLine("Bienvenido {0}", Nombre);
        }

        // La forma de trabajo depende del tipo de empleado .: abstract
        public abstract void Trabajar();
    }
}

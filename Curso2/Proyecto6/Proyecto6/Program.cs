// Namespace: contenedor de tipos de datos o clases
namespace MyNamespace
{
    class Clase
    {
        public void Metodo()
        {
            Console.WriteLine("Dentro de MyNamespace");
        }
    }
}

// 2 namespaces pueden tener clases con == nombre y que actúen distinto
namespace MyOtherNamespace
{
    class Clase
    {
        public void Metodo()
        {
            Console.WriteLine("Dentro de MyOtherNamespace");
        }
    }
}

namespace Proyecto6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear objetos de otros namespaces
            // Se utiliza el nombre totalmente calificado
            MyNamespace.Clase obj1 = new MyNamespace.Clase();
            MyOtherNamespace.Clase obj2 = new MyOtherNamespace.Clase();

            obj1.Metodo();
            obj2.Metodo();
        }
    }
}

// Aclaración: c/archivo debería contener tan solo 1 clase
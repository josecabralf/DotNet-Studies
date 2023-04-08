// Para evitar escribir el nombre clasificado cada vez que se accede a algo
// perteneciente a OtroNamespace, se puede usar "using"
using OtroNamespace;

namespace Proyecto7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OtraClase obj = new OtraClase();
            
            // Los metodos publicos e internos pueden ser accedidos desde otro archivo
            obj.MetodoPublico();
            obj.MetodoInternal();

            // Los metodos privados y protegidos NO pueden ser accedidos desde otro
            // archivo
        }
    }
}
namespace Proyecto12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Juan", 31);
            Persona p2 = new Persona("Juan", 31);
            Persona p3 = p1;

            // Comparación por referencia
            // p1 != p2: apuntan a distintos objetos
            Console.Write("Referencias p1 y p2 son iguales? ");
            Console.WriteLine(p1 == p2);

            // p1 == p3: Apuntan al mismo objeto
            Console.Write("Referencias p1 y p3 son iguales? ");
            Console.WriteLine(p1 == p3);

            Console.WriteLine();

            // Comparación de objetos
            Console.Write("Objetos p1 y p2 son iguales? ");
            Console.WriteLine(p1.Equals(p2));
        }
    }
}
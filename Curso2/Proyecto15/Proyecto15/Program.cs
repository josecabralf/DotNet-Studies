namespace Proyecto15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(3, 4, 5);
            Vector v2 = new Vector(6, 7, 8);
            Console.WriteLine("Vector v1: " + v1.ToString()); 
            Console.WriteLine("Vector v2: " + v2.ToString());

            Console.WriteLine();

            Console.WriteLine("Módulo: v1 = {0}", v1.CalcModulo());
            Console.WriteLine("Módulo: v2 = {0}", v2.CalcModulo());

            Console.WriteLine();

            Vector suma = v1.Suma(v2);
            Console.WriteLine("Suma v1 + v2 = {0}", suma.ToString());
        }
    }
}